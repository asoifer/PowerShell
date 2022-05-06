// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Text;

using Microsoft.PowerShell;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation
{
    internal abstract class BaseWMIAdapter : Adapter
    {
        internal class WMIMethodCacheEntry : CacheEntry
        {
            public string Name { get; }

            public string ClassPath { get; }

            public MethodInformation MethodInfoStructure { get; }

            public string MethodDefinition { get; }

            internal WMIMethodCacheEntry(string n, string cPath, MethodData mData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1287, 1501, 1844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1286, 1313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1329, 1361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1377, 1430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1446, 1485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1604, 1613);

                    Name = n;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1631, 1649);

                    ClassPath = cPath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1667, 1741);

                    MethodInfoStructure = f_1287_1689_1740(mData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 1759, 1829);

                    MethodDefinition = f_1287_1778_1828(mData);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1287, 1501, 1844);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 1501, 1844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 1501, 1844);
                }
            }

            static WMIMethodCacheEntry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1287, 1214, 1855);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1287, 1214, 1855);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 1214, 1855);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1287, 1214, 1855);

            System.Management.Automation.MethodInformation
            f_1287_1689_1740(System.Management.MethodData
            mData)
            {
                var return_v = ManagementObjectAdapter.GetMethodInformation(mData);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 1689, 1740);
                return return_v;
            }


            string
            f_1287_1778_1828(System.Management.MethodData
            mData)
            {
                var return_v = ManagementObjectAdapter.GetMethodDefinition(mData);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 1778, 1828);
                return return_v;
            }

        }
        internal class WMIParameterInformation : ParameterInformation
        {
            public string Name { get; }

            public WMIParameterInformation(string name, Type ty) : base(f_1287_2121_2123_C(ty), true, null, false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1287, 2061, 2203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 2018, 2045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 2176, 2188);

                    Name = name;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1287, 2061, 2203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 2061, 2203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 2061, 2203);
                }
            }

            static WMIParameterInformation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1287, 1932, 2214);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1287, 1932, 2214);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 1932, 2214);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1287, 1932, 2214);

            static System.Type
            f_1287_2121_2123_C(System.Type
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1287, 2061, 2203);
                return return_v;
            }

        }

        private IEnumerable<string> GetTypeNameHierarchyFromDerivation(ManagementBaseObject managementObj,
                    string dotnetBaseType, bool shouldIncludeNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 2648, 4968);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 2836, 2880);

                StringBuilder
                type = f_1287_2857_2879(200)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 2957, 2985);

                f_1287_2957_2984(            // give the typename based on NameSpace and Class
                            type, dotnetBaseType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 2999, 3016);

                f_1287_2999_3015(type, "#");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3030, 3206) || true) && (shouldIncludeNamespace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 3030, 3206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3090, 3155);

                    f_1287_3090_3154(type, f_1287_3102_3153(f_1287_3102_3147(f_1287_3102_3132(managementObj), "__NAMESPACE")));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3173, 3191);

                    f_1287_3173_3190(type, "\\");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 3030, 3206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3222, 3283);

                f_1287_3222_3282(
                            type, f_1287_3234_3281(f_1287_3234_3275(f_1287_3234_3264(managementObj), "__CLASS")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3297, 3326);

                listYield.Add(f_1287_3310_3325(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3784, 3861);

                PropertyData
                derivationData = f_1287_3814_3860(f_1287_3814_3844(managementObj), "__Derivation")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3875, 4957) || true) && (derivationData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 3875, 4957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 3935, 4035);

                    f_1287_3935_4034(f_1287_3946_3968(derivationData), "__Derivation must be a string array as per MSDN documentation");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4128, 4273);

                    string[]
                    typeHierarchy = f_1287_4153_4260(f_1287_4191_4211(derivationData), typeof(string[]), f_1287_4231_4259()) as string[]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4291, 4942) || true) && (typeHierarchy != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 4291, 4942);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4358, 4923);
                            foreach (string t in f_1287_4379_4392_I(typeHierarchy))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 4358, 4923);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4442, 4455);

                                f_1287_4442_4454(type);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4481, 4509);

                                f_1287_4481_4508(type, dotnetBaseType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4535, 4552);

                                f_1287_4535_4551(type, "#");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4578, 4802) || true) && (shouldIncludeNamespace)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 4578, 4802);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4662, 4727);

                                    f_1287_4662_4726(type, f_1287_4674_4725(f_1287_4674_4719(f_1287_4674_4704(managementObj), "__NAMESPACE")));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4757, 4775);

                                    f_1287_4757_4774(type, "\\");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 4578, 4802);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4830, 4845);

                                f_1287_4830_4844(
                                                        type, t);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 4871, 4900);

                                listYield.Add(f_1287_4884_4899(type));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 4358, 4923);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 566);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 566);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 4291, 4942);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 3875, 4957);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 2648, 4968);

                return listYield;

                System.Text.StringBuilder
                f_1287_2857_2879(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 2857, 2879);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_2957_2984(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 2957, 2984);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_2999_3015(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 2999, 3015);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_3102_3132(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3102, 3132);
                    return return_v;
                }


                System.Management.PropertyData
                f_1287_3102_3147(System.Management.PropertyDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3102, 3147);
                    return return_v;
                }


                object
                f_1287_3102_3153(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3102, 3153);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_3090_3154(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 3090, 3154);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_3173_3190(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 3173, 3190);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_3234_3264(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3234, 3264);
                    return return_v;
                }


                System.Management.PropertyData
                f_1287_3234_3275(System.Management.PropertyDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3234, 3275);
                    return return_v;
                }


                object
                f_1287_3234_3281(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3234, 3281);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_3222_3282(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 3222, 3282);
                    return return_v;
                }


                string
                f_1287_3310_3325(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 3310, 3325);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_3814_3844(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3814, 3844);
                    return return_v;
                }


                System.Management.PropertyData
                f_1287_3814_3860(System.Management.PropertyDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3814, 3860);
                    return return_v;
                }


                bool
                f_1287_3946_3968(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 3946, 3968);
                    return return_v;
                }


                int
                f_1287_3935_4034(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 3935, 4034);
                    return 0;
                }


                object
                f_1287_4191_4211(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 4191, 4211);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1287_4231_4259()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 4231, 4259);
                    return return_v;
                }


                object
                f_1287_4153_4260(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = PropertySetAndMethodArgumentConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4153, 4260);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_4442_4454(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4442, 4454);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_4481_4508(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4481, 4508);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_4535_4551(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4535, 4551);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_4674_4704(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 4674, 4704);
                    return return_v;
                }


                System.Management.PropertyData
                f_1287_4674_4719(System.Management.PropertyDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 4674, 4719);
                    return return_v;
                }


                object
                f_1287_4674_4725(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 4674, 4725);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_4662_4726(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4662, 4726);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_4757_4774(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4757, 4774);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_4830_4844(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4830, 4844);
                    return return_v;
                }


                string
                f_1287_4884_4899(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4884, 4899);
                    return return_v;
                }


                string[]
                f_1287_4379_4392_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 4379, 4392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 2648, 4968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 2648, 4968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IEnumerable<string> GetTypeNameHierarchy(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 5301, 6429);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 5397, 5462);

                ManagementBaseObject
                managementObj = obj as ManagementBaseObject
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 5478, 5505);

                bool
                isLoopStarted = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 5519, 6418);
                    foreach (string baseType in f_1287_5547_5578_I(f_1287_5547_5578(obj)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 5519, 6418);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 5612, 6361) || true) && (!isLoopStarted)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 5612, 6361);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 5672, 5693);

                            isLoopStarted = true;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 5859, 6067);
                                foreach (string typeFromDerivation in f_1287_5897_5962_I(f_1287_5897_5962(this, managementObj, baseType, true)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 5859, 6067);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 6012, 6044);

                                    listYield.Add(typeFromDerivation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 5859, 6067);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 209);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 209);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 6133, 6342);
                                foreach (string typeFromDerivation in f_1287_6171_6237_I(f_1287_6171_6237(this, managementObj, baseType, false)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 6133, 6342);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 6287, 6319);

                                    listYield.Add(typeFromDerivation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 6133, 6342);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 210);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 210);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 5612, 6361);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 6381, 6403);

                        listYield.Add(baseType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 5519, 6418);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 900);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 900);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 5301, 6429);

                return listYield;

                System.Collections.Generic.IEnumerable<string>
                f_1287_5547_5578(object
                obj)
                {
                    var return_v = GetDotNetTypeNameHierarchy(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 5547, 5578);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1287_5897_5962(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                managementObj, string
                dotnetBaseType, bool
                shouldIncludeNamespace)
                {
                    var return_v = this_param.GetTypeNameHierarchyFromDerivation(managementObj, dotnetBaseType, shouldIncludeNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 5897, 5962);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1287_5897_5962_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 5897, 5962);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1287_6171_6237(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                managementObj, string
                dotnetBaseType, bool
                shouldIncludeNamespace)
                {
                    var return_v = this_param.GetTypeNameHierarchyFromDerivation(managementObj, dotnetBaseType, shouldIncludeNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 6171, 6237);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1287_6171_6237_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 6171, 6237);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1287_5547_5578_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 5547, 5578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 5301, 6429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 5301, 6429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override T GetMember<T>(object obj, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 6857, 7927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 6946, 7007);

                f_1287_6946_7006(tracer, "Getting member with name {0}", memberName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7023, 7085);

                ManagementBaseObject
                mgmtObject = obj as ManagementBaseObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7101, 7184) || true) && (mgmtObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 7101, 7184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7157, 7169);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 7101, 7184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7200, 7260);

                PSProperty
                property = f_1287_7222_7259(this, mgmtObject, memberName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7276, 7416) || true) && (f_1287_7280_7326(typeof(T), typeof(PSProperty)) && (DynAbs.Tracing.TraceSender.Expression_True(1287, 7280, 7346) && property != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 7276, 7416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7380, 7401);

                    return property as T;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 7276, 7416);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7432, 7888) || true) && (f_1287_7436_7480(typeof(T), typeof(PSMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 7432, 7888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7514, 7583);

                    T
                    returnValue = f_1287_7530_7582(this, mgmtObject, memberName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7750, 7873) || true) && (returnValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1287, 7754, 7793) && property == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 7750, 7873);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7835, 7854);

                        return returnValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 7750, 7873);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 7432, 7888);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 7904, 7916);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 6857, 7927);

                int
                f_1287_6946_7006(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 6946, 7006);
                    return 0;
                }


                System.Management.Automation.PSProperty
                f_1287_7222_7259(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                wmiObject, string
                propertyName)
                {
                    var return_v = this_param.DoGetProperty(wmiObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 7222, 7259);
                    return return_v;
                }


                bool
                f_1287_7280_7326(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 7280, 7326);
                    return return_v;
                }


                bool
                f_1287_7436_7480(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 7436, 7480);
                    return return_v;
                }


                T
                f_1287_7530_7582(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                wmiObject, string
                methodName)
                {
                    var return_v = this_param.GetManagementObjectMethod<T>(wmiObject, methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 7530, 7582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 6857, 7927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 6857, 7927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override T GetFirstMemberOrDefault<T>(object obj, MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 7939, 8314);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 8054, 8275) || true) && (obj is ManagementBaseObject wmiObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 8054, 8275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 8129, 8260);

                    return f_1287_8136_8186(this, wmiObject, predicate) ?? (DynAbs.Tracing.TraceSender.Expression_Null<T>(1287, 8136, 8259) ?? f_1287_8211_8259(this, wmiObject, predicate));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 8054, 8275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 8291, 8303);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 7939, 8314);

                T
                f_1287_8136_8186(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                wmiObject, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstOrDefaultProperty<T>(wmiObject, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 8136, 8186);
                    return return_v;
                }


                T
                f_1287_8211_8259(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                wmiObject, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstOrDefaultMethod<T>(wmiObject, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 8211, 8259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 7939, 8314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 7939, 8314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override PSMemberInfoInternalCollection<T> GetMembers<T>(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 9091, 9625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 9235, 9291);

                f_1287_9235_9290(obj != null, "Input object is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 9307, 9366);

                ManagementBaseObject
                wmiObject = (ManagementBaseObject)obj
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 9380, 9468);

                PSMemberInfoInternalCollection<T>
                returnValue = f_1287_9428_9467()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 9482, 9526);

                f_1287_9482_9525(this, wmiObject, returnValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 9540, 9581);

                f_1287_9540_9580(this, wmiObject, returnValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 9595, 9614);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 9091, 9625);

                int
                f_1287_9235_9290(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 9235, 9290);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1287_9428_9467()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 9428, 9467);
                    return return_v;
                }


                int
                f_1287_9482_9525(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                wmiObject, System.Management.Automation.PSMemberInfoInternalCollection<T>
                members)
                {
                    this_param.AddAllProperties<T>(wmiObject, members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 9482, 9525);
                    return 0;
                }


                int
                f_1287_9540_9580(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementBaseObject
                wmiObject, System.Management.Automation.PSMemberInfoInternalCollection<T>
                members)
                {
                    this_param.AddAllMethods<T>(wmiObject, members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 9540, 9580);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 9091, 9625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 9091, 9625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object MethodInvoke(PSMethod method, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 10014, 10476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 10114, 10182);

                ManagementObject
                mgmtObject = method.baseObject as ManagementObject
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 10196, 10294);

                f_1287_10196_10293(mgmtObject != null, "Object is not of ManagementObject type");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 10310, 10384);

                WMIMethodCacheEntry
                methodEntry = (WMIMethodCacheEntry)method.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 10400, 10465);

                return f_1287_10407_10464(this, mgmtObject, methodEntry, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 10014, 10476);

                int
                f_1287_10196_10293(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 10196, 10293);
                    return 0;
                }


                object
                f_1287_10407_10464(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementObject
                obj, System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                mdata, object[]
                arguments)
                {
                    var return_v = this_param.AuxillaryInvokeMethod(obj, mdata, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 10407, 10464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 10014, 10476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 10014, 10476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Collection<string> MethodDefinitions(PSMethod method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 10719, 11068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 10816, 10890);

                WMIMethodCacheEntry
                methodEntry = (WMIMethodCacheEntry)method.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 10904, 10962);

                Collection<string>
                returnValue = f_1287_10937_10961()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 10976, 11022);

                f_1287_10976_11021(returnValue, f_1287_10992_11020(methodEntry));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 11038, 11057);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 10719, 11068);

                System.Collections.ObjectModel.Collection<string>
                f_1287_10937_10961()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 10937, 10961);
                    return return_v;
                }


                string
                f_1287_10992_11020(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 10992, 11020);
                    return return_v;
                }


                int
                f_1287_10976_11021(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 10976, 11021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 10719, 11068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 10719, 11068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool PropertyIsSettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 11311, 12821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 11399, 11471);

                ManagementBaseObject
                mObj = property.baseObject as ManagementBaseObject
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 11521, 11575);

                    ManagementClass
                    objClass = f_1287_11548_11574(mObj)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 11593, 11665);

                    return (bool)f_1287_11606_11664(objClass, f_1287_11641_11654(property), "Write");
                }
                catch (ManagementException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 11694, 12046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 12019, 12031);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 11694, 12046);
                }
                catch (UnauthorizedAccessException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 12060, 12420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 12393, 12405);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 12060, 12420);
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 12434, 12810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 12783, 12795);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 12434, 12810);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 11311, 12821);

                System.Management.ManagementClass
                f_1287_11548_11574(System.Management.ManagementBaseObject
                mgmtBaseObject)
                {
                    var return_v = CreateClassFrmObject(mgmtBaseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 11548, 11574);
                    return return_v;
                }


                string
                f_1287_11641_11654(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 11641, 11654);
                    return return_v;
                }


                object
                f_1287_11606_11664(System.Management.ManagementClass
                this_param, string
                propertyName, string
                qualifierName)
                {
                    var return_v = this_param.GetPropertyQualifierValue(propertyName, qualifierName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 11606, 11664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 11311, 12821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 11311, 12821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool PropertyIsGettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 13064, 13175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 13152, 13164);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 13064, 13175);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 13064, 13175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 13064, 13175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string PropertyType(PSProperty property, bool forDisplay)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 13579, 14437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 13680, 13735);

                PropertyData
                pd = property.adapterData as PropertyData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 13802, 13838);

                Type
                dotNetType = f_1287_13820_13837(pd)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 13852, 13868);

                string
                typeName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14012, 14394) || true) && (f_1287_14016_14023(pd) == CimType.Object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 14012, 14394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14075, 14116);

                    typeName = f_1287_14086_14115(pd);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14136, 14228) || true) && (f_1287_14140_14150(pd))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 14136, 14228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14192, 14209);

                        typeName += "[]";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 14136, 14228);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 14012, 14394);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 14012, 14394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14294, 14379);

                    typeName = (DynAbs.Tracing.TraceSender.Conditional_F1(1287, 14305, 14315) || ((forDisplay && DynAbs.Tracing.TraceSender.Conditional_F2(1287, 14318, 14354)) || DynAbs.Tracing.TraceSender.Conditional_F3(1287, 14357, 14378))) ? f_1287_14318_14354(dotNetType) : f_1287_14357_14378(dotNetType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 14012, 14394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14410, 14426);

                return typeName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 13579, 14437);

                System.Type
                f_1287_13820_13837(System.Management.PropertyData
                pData)
                {
                    var return_v = GetDotNetType(pData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 13820, 13837);
                    return return_v;
                }


                System.Management.CimType
                f_1287_14016_14023(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 14016, 14023);
                    return return_v;
                }


                string
                f_1287_14086_14115(System.Management.PropertyData
                pData)
                {
                    var return_v = GetEmbeddedObjectTypeName(pData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 14086, 14115);
                    return return_v;
                }


                bool
                f_1287_14140_14150(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 14140, 14150);
                    return return_v;
                }


                string
                f_1287_14318_14354(System.Type
                type)
                {
                    var return_v = ToStringCodeMethods.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 14318, 14354);
                    return return_v;
                }


                string
                f_1287_14357_14378(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 14357, 14378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 13579, 14437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 13579, 14437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object PropertyGet(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 14749, 14928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14832, 14887);

                PropertyData
                pd = property.adapterData as PropertyData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 14901, 14917);

                return f_1287_14908_14916(pd);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 14749, 14928);

                object
                f_1287_14908_14916(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 14908, 14916);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 14749, 14928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 14749, 14928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void PropertySet(PSProperty property, object setValue, bool convertIfPossible)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 15528, 16867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 15650, 15722);

                ManagementBaseObject
                mObj = property.baseObject as ManagementBaseObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 15736, 16107) || true) && (mObj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 15736, 16107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 15786, 16092);

                    throw f_1287_15792_16091("CannotSetNonManagementObjectMsg", null, f_1287_15907_15954(), f_1287_15977_15990(property), f_1287_15992_16030(f_1287_15992_16021(property.baseObject)), f_1287_16053_16090(typeof(ManagementBaseObject)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 15736, 16107);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16123, 16389) || true) && (!f_1287_16128_16156(this, property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 16123, 16389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16190, 16374);

                    throw f_1287_16196_16373("ReadOnlyWMIProperty", null, f_1287_16297_16332(), f_1287_16359_16372(property));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 16123, 16389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16405, 16460);

                PropertyData
                pd = property.adapterData as PropertyData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16476, 16799) || true) && ((convertIfPossible) && (DynAbs.Tracing.TraceSender.Expression_True(1287, 16480, 16521) && (setValue != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 16476, 16799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16609, 16644);

                    Type
                    paramType = f_1287_16626_16643(pd)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16662, 16784);

                    setValue = f_1287_16673_16783(setValue, paramType, f_1287_16754_16782());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 16476, 16799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16815, 16835);

                pd.Value = setValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 16849, 16856);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 15528, 16867);

                string
                f_1287_15907_15954()
                {
                    var return_v = ExtendedTypeSystem.CannotSetNonManagementObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 15907, 15954);
                    return return_v;
                }


                string
                f_1287_15977_15990(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 15977, 15990);
                    return return_v;
                }


                System.Type
                f_1287_15992_16021(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 15992, 16021);
                    return return_v;
                }


                string
                f_1287_15992_16030(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 15992, 16030);
                    return return_v;
                }


                string
                f_1287_16053_16090(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 16053, 16090);
                    return return_v;
                }


                System.Management.Automation.SetValueInvocationException
                f_1287_15792_16091(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.SetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 15792, 16091);
                    return return_v;
                }


                bool
                f_1287_16128_16156(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.Automation.PSProperty
                property)
                {
                    var return_v = this_param.PropertyIsSettable(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 16128, 16156);
                    return return_v;
                }


                string
                f_1287_16297_16332()
                {
                    var return_v = ExtendedTypeSystem.ReadOnlyProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 16297, 16332);
                    return return_v;
                }


                string
                f_1287_16359_16372(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 16359, 16372);
                    return return_v;
                }


                System.Management.Automation.SetValueException
                f_1287_16196_16373(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.SetValueException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 16196, 16373);
                    return return_v;
                }


                System.Type
                f_1287_16626_16643(System.Management.PropertyData
                pData)
                {
                    var return_v = GetDotNetType(pData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 16626, 16643);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1287_16754_16782()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 16754, 16782);
                    return return_v;
                }


                object
                f_1287_16673_16783(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = PropertySetAndMethodArgumentConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 16673, 16783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 15528, 16867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 15528, 16867);
            }
        }

        protected override string PropertyToString(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 17180, 17993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17268, 17316);

                StringBuilder
                returnValue = f_1287_17296_17315()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17466, 17527);

                f_1287_17466_17526(            // if (PropertyIsStatic(property))
                                               // {
                                               //    returnValue.Append("static ");
                                               // }

                            returnValue, f_1287_17485_17525(this, property, forDisplay: true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17541, 17565);

                f_1287_17541_17564(returnValue, " ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17579, 17613);

                f_1287_17579_17612(returnValue, f_1287_17598_17611(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17627, 17652);

                f_1287_17627_17651(returnValue, " {");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17666, 17774) || true) && (f_1287_17670_17698(this, property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 17666, 17774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17732, 17759);

                    f_1287_17732_17758(returnValue, "get;");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 17666, 17774);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17790, 17898) || true) && (f_1287_17794_17822(this, property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 17790, 17898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17856, 17883);

                    f_1287_17856_17882(returnValue, "set;");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 17790, 17898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17914, 17938);

                f_1287_17914_17937(
                            returnValue, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 17952, 17982);

                return f_1287_17959_17981(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 17180, 17993);

                System.Text.StringBuilder
                f_1287_17296_17315()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17296, 17315);
                    return return_v;
                }


                string
                f_1287_17485_17525(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.Automation.PSProperty
                property, bool
                forDisplay)
                {
                    var return_v = this_param.PropertyType(property, forDisplay: forDisplay);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17485, 17525);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_17466_17526(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17466, 17526);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_17541_17564(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17541, 17564);
                    return return_v;
                }


                string
                f_1287_17598_17611(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 17598, 17611);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_17579_17612(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17579, 17612);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_17627_17651(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17627, 17651);
                    return return_v;
                }


                bool
                f_1287_17670_17698(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.Automation.PSProperty
                property)
                {
                    var return_v = this_param.PropertyIsGettable(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17670, 17698);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_17732_17758(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17732, 17758);
                    return return_v;
                }


                bool
                f_1287_17794_17822(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.Automation.PSProperty
                property)
                {
                    var return_v = this_param.PropertyIsSettable(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17794, 17822);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_17856_17882(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17856, 17882);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_17914_17937(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17914, 17937);
                    return return_v;
                }


                string
                f_1287_17959_17981(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 17959, 17981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 17180, 17993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 17180, 17993);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override AttributeCollection PropertyAttributes(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 18265, 18391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 18368, 18380);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 18265, 18391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 18265, 18391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 18265, 18391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CacheTable GetInstanceMethodTable(ManagementBaseObject wmiObject,
                    bool staticBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 18748, 20819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 18894, 18920);
                lock (s_instanceMethodCacheTable)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 18954, 18982);

                    CacheTable
                    typeTable = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 19085, 19132);

                    ManagementPath
                    classPath = f_1287_19112_19131(wmiObject)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 19150, 19260);

                    string
                    key = f_1287_19163_19259(f_1287_19177_19205(), "{0}#{1}", f_1287_19218_19232(classPath), f_1287_19234_19258(staticBinding))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 19280, 19336);

                    typeTable = (CacheTable)f_1287_19304_19335(s_instanceMethodCacheTable, key);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 19354, 19544) || true) && (typeTable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 19354, 19544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 19417, 19486);

                        f_1287_19417_19485(tracer, "Returning method information from internal cache");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 19508, 19525);

                        return typeTable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 19354, 19544);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 19564, 19649);

                    f_1287_19564_19648(
                                    tracer, "Method information not found in internal cache. Constructing one");

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 20066, 20095);

                        typeTable = f_1287_20078_20094();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 20219, 20311);

                        ManagementClass
                        mgmtClass = wmiObject as ManagementClass ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.ManagementClass>(1287, 20247, 20310) ?? f_1287_20279_20310(wmiObject))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 20333, 20390);

                        f_1287_20333_20389(mgmtClass, typeTable, staticBinding);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 20412, 20456);

                        s_instanceMethodCacheTable[key] = typeTable;
                    }
                    catch (ManagementException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 20493, 20558);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 20493, 20558);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 20576, 20649);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 20576, 20649);
                    }
                    catch (System.Runtime.InteropServices.COMException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 20667, 20756);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 20667, 20756);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 20776, 20793);

                    return typeTable;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 18748, 20819);

                System.Management.ManagementPath
                f_1287_19112_19131(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.ClassPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 19112, 19131);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1287_19177_19205()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 19177, 19205);
                    return return_v;
                }


                string
                f_1287_19218_19232(System.Management.ManagementPath
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 19218, 19232);
                    return return_v;
                }


                string
                f_1287_19234_19258(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 19234, 19258);
                    return return_v;
                }


                string
                f_1287_19163_19259(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 19163, 19259);
                    return return_v;
                }


                object
                f_1287_19304_19335(System.Collections.Specialized.HybridDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 19304, 19335);
                    return return_v;
                }


                int
                f_1287_19417_19485(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 19417, 19485);
                    return 0;
                }


                int
                f_1287_19564_19648(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 19564, 19648);
                    return 0;
                }


                System.Management.Automation.CacheTable
                f_1287_20078_20094()
                {
                    var return_v = new System.Management.Automation.CacheTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 20078, 20094);
                    return return_v;
                }


                System.Management.ManagementClass
                f_1287_20279_20310(System.Management.ManagementBaseObject
                mgmtBaseObject)
                {
                    var return_v = CreateClassFrmObject(mgmtBaseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 20279, 20310);
                    return return_v;
                }


                int
                f_1287_20333_20389(System.Management.ManagementClass
                mgmtClass, System.Management.Automation.CacheTable
                methodTable, bool
                staticBinding)
                {
                    PopulateMethodTable(mgmtClass, methodTable, staticBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 20333, 20389);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 18748, 20819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 18748, 20819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void PopulateMethodTable(ManagementClass mgmtClass, CacheTable methodTable, bool staticBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 21316, 22450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 21451, 21530);

                f_1287_21451_21529(mgmtClass != null, "ManagementClass cannot be null in this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 21544, 21597);

                MethodDataCollection
                mgmtMethods = f_1287_21579_21596(mgmtClass)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 21611, 22439) || true) && (mgmtMethods != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 21611, 22439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 21668, 21715);

                    ManagementPath
                    classPath = f_1287_21695_21714(mgmtClass)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 21783, 22424);
                        foreach (MethodData mdata in f_1287_21812_21823_I(mgmtMethods))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 21783, 22424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 21906, 21944);

                            bool
                            isStatic = f_1287_21922_21943(mdata)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 21966, 22405) || true) && (isStatic == staticBinding)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 21966, 22405);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 22175, 22206);

                                string
                                methodName = f_1287_22195_22205(mdata)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 22232, 22320);

                                WMIMethodCacheEntry
                                mCache = f_1287_22261_22319(methodName, f_1287_22297_22311(classPath), mdata)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 22346, 22382);

                                f_1287_22346_22381(methodTable, methodName, mCache);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 21966, 22405);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 21783, 22424);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 642);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 642);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 21611, 22439);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 21316, 22450);

                int
                f_1287_21451_21529(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 21451, 21529);
                    return 0;
                }


                System.Management.MethodDataCollection
                f_1287_21579_21596(System.Management.ManagementClass
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 21579, 21596);
                    return return_v;
                }


                System.Management.ManagementPath
                f_1287_21695_21714(System.Management.ManagementClass
                this_param)
                {
                    var return_v = this_param.ClassPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 21695, 21714);
                    return return_v;
                }


                bool
                f_1287_21922_21943(System.Management.MethodData
                mdata)
                {
                    var return_v = IsStaticMethod(mdata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 21922, 21943);
                    return return_v;
                }


                string
                f_1287_22195_22205(System.Management.MethodData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 22195, 22205);
                    return return_v;
                }


                string
                f_1287_22297_22311(System.Management.ManagementPath
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 22297, 22311);
                    return return_v;
                }


                System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                f_1287_22261_22319(string
                n, string
                cPath, System.Management.MethodData
                mData)
                {
                    var return_v = new System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry(n, cPath, mData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 22261, 22319);
                    return return_v;
                }


                int
                f_1287_22346_22381(System.Management.Automation.CacheTable
                this_param, string
                name, System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                member)
                {
                    this_param.Add(name, (object)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 22346, 22381);
                    return 0;
                }


                System.Management.MethodDataCollection
                f_1287_21812_21823_I(System.Management.MethodDataCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 21812, 21823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 21316, 22450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 21316, 22450);
            }
        }

        private static ManagementClass CreateClassFrmObject(ManagementBaseObject mgmtBaseObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 22848, 23733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23055, 23117);

                ManagementClass
                mgmtClass = mgmtBaseObject as ManagementClass
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23223, 23689) || true) && (mgmtClass == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 23223, 23689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23278, 23336);

                    mgmtClass = f_1287_23290_23335(f_1287_23310_23334(mgmtBaseObject));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23412, 23477);

                    ManagementObject
                    mgmtObject = mgmtBaseObject as ManagementObject
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23495, 23674) || true) && (mgmtObject != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 23495, 23674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23559, 23594);

                        mgmtClass.Scope = f_1287_23577_23593(mgmtObject);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23616, 23655);

                        mgmtClass.Options = f_1287_23636_23654(mgmtObject);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 23495, 23674);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 23223, 23689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 23705, 23722);

                return mgmtClass;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 22848, 23733);

                System.Management.ManagementPath
                f_1287_23310_23334(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.ClassPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 23310, 23334);
                    return return_v;
                }


                System.Management.ManagementClass
                f_1287_23290_23335(System.Management.ManagementPath
                path)
                {
                    var return_v = new System.Management.ManagementClass(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 23290, 23335);
                    return return_v;
                }


                System.Management.ManagementScope
                f_1287_23577_23593(System.Management.ManagementObject
                this_param)
                {
                    var return_v = this_param.Scope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 23577, 23593);
                    return return_v;
                }


                System.Management.ObjectGetOptions
                f_1287_23636_23654(System.Management.ManagementObject
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 23636, 23654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 22848, 23733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 22848, 23733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static string GetEmbeddedObjectTypeName(PropertyData pData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 24260, 25003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 24354, 24394);

                string
                result = f_1287_24370_24393(typeof(object))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 24410, 24490) || true) && (pData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 24410, 24490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 24461, 24475);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 24410, 24490);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 24542, 24601);

                    string
                    cimType = (string)f_1287_24567_24600(f_1287_24567_24594(f_1287_24567_24583(pData), "cimtype"))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 24619, 24781);

                    result = f_1287_24628_24780(f_1287_24642_24670(), "{0}#{1}", f_1287_24704_24737(typeof(ManagementObject)), f_1287_24739_24779(cimType, "object:", string.Empty));
                }
                catch (ManagementException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 24810, 24867);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 24810, 24867);
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 24881, 24962);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 24881, 24962);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 24978, 24992);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 24260, 25003);

                string
                f_1287_24370_24393(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 24370, 24393);
                    return return_v;
                }


                System.Management.QualifierDataCollection
                f_1287_24567_24583(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Qualifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 24567, 24583);
                    return return_v;
                }


                System.Management.QualifierData
                f_1287_24567_24594(System.Management.QualifierDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 24567, 24594);
                    return return_v;
                }


                object
                f_1287_24567_24600(System.Management.QualifierData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 24567, 24600);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1287_24642_24670()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 24642, 24670);
                    return return_v;
                }


                string
                f_1287_24704_24737(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 24704, 24737);
                    return return_v;
                }


                string
                f_1287_24739_24779(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 24739, 24779);
                    return return_v;
                }


                string
                f_1287_24628_24780(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 24628, 24780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 24260, 25003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 24260, 25003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static Type GetDotNetType(PropertyData pData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 25249, 27888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 25329, 25421);

                f_1287_25329_25420(pData != null, "Input PropertyData should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 25437, 25507);

                f_1287_25437_25506(
                            tracer, "Getting DotNet Type for CimType : {0}", f_1287_25495_25505(pData));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 25523, 25539);

                string
                retValue
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 25553, 27732);

                switch (f_1287_25561_25571(pData))
                {

                    case CimType.SInt8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 25646, 25680);

                        retValue = f_1287_25657_25679(typeof(sbyte));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 25702, 25708);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.UInt8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 25767, 25800);

                        retValue = f_1287_25778_25799(typeof(byte));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 25822, 25828);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.SInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 25888, 25929);

                        retValue = f_1287_25899_25928(typeof(System.Int16));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 25951, 25957);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26017, 26059);

                        retValue = f_1287_26028_26058(typeof(System.UInt16));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26081, 26087);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.SInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26147, 26188);

                        retValue = f_1287_26158_26187(typeof(System.Int32));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26210, 26216);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26276, 26318);

                        retValue = f_1287_26287_26317(typeof(System.UInt32));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26340, 26346);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.SInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26406, 26447);

                        retValue = f_1287_26417_26446(typeof(System.Int64));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26469, 26475);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26535, 26577);

                        retValue = f_1287_26546_26576(typeof(System.UInt64));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26599, 26605);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.Real32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26665, 26700);

                        retValue = f_1287_26676_26699(typeof(Single));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26722, 26728);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.Real64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26788, 26823);

                        retValue = f_1287_26799_26822(typeof(double));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26845, 26851);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 26912, 26945);

                        retValue = f_1287_26923_26944(typeof(bool));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 26967, 26973);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27033, 27068);

                        retValue = f_1287_27044_27067(typeof(string));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 27090, 27096);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27208, 27243);

                        retValue = f_1287_27219_27242(typeof(string));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 27265, 27271);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.Reference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27384, 27419);

                        retValue = f_1287_27395_27418(typeof(string));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 27441, 27447);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.Char16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27507, 27540);

                        retValue = f_1287_27518_27539(typeof(char));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 27562, 27568);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);

                    case CimType.Object:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 25553, 27732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27654, 27689);

                        retValue = f_1287_27665_27688(typeof(object));
                        DynAbs.Tracing.TraceSender.TraceBreak(1287, 27711, 27717);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 25553, 27732);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27748, 27831) || true) && (f_1287_27752_27765(pData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 27748, 27831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27799, 27816);

                    retValue += "[]";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 27748, 27831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 27847, 27877);

                return f_1287_27854_27876(retValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 25249, 27888);

                int
                f_1287_25329_25420(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 25329, 25420);
                    return 0;
                }


                System.Management.CimType
                f_1287_25495_25505(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 25495, 25505);
                    return return_v;
                }


                int
                f_1287_25437_25506(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.CimType
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 25437, 25506);
                    return 0;
                }


                System.Management.CimType
                f_1287_25561_25571(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 25561, 25571);
                    return return_v;
                }


                string
                f_1287_25657_25679(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 25657, 25679);
                    return return_v;
                }


                string
                f_1287_25778_25799(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 25778, 25799);
                    return return_v;
                }


                string
                f_1287_25899_25928(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 25899, 25928);
                    return return_v;
                }


                string
                f_1287_26028_26058(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26028, 26058);
                    return return_v;
                }


                string
                f_1287_26158_26187(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26158, 26187);
                    return return_v;
                }


                string
                f_1287_26287_26317(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26287, 26317);
                    return return_v;
                }


                string
                f_1287_26417_26446(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26417, 26446);
                    return return_v;
                }


                string
                f_1287_26546_26576(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26546, 26576);
                    return return_v;
                }


                string
                f_1287_26676_26699(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26676, 26699);
                    return return_v;
                }


                string
                f_1287_26799_26822(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26799, 26822);
                    return return_v;
                }


                string
                f_1287_26923_26944(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 26923, 26944);
                    return return_v;
                }


                string
                f_1287_27044_27067(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 27044, 27067);
                    return return_v;
                }


                string
                f_1287_27219_27242(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 27219, 27242);
                    return return_v;
                }


                string
                f_1287_27395_27418(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 27395, 27418);
                    return return_v;
                }


                string
                f_1287_27518_27539(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 27518, 27539);
                    return return_v;
                }


                string
                f_1287_27665_27688(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 27665, 27688);
                    return return_v;
                }


                bool
                f_1287_27752_27765(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 27752, 27765);
                    return return_v;
                }


                System.Type?
                f_1287_27854_27876(string
                typeName)
                {
                    var return_v = Type.GetType(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 27854, 27876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 25249, 27888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 25249, 27888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static bool IsStaticMethod(MethodData mdata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 28235, 28876);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 28350, 28409);

                    QualifierData
                    staticQualifier = f_1287_28382_28408(f_1287_28382_28398(mdata), "static")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 28427, 28490) || true) && (staticQualifier == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 28427, 28490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 28477, 28490);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 28427, 28490);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 28510, 28530);

                    bool
                    result = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 28548, 28621);

                    f_1287_28548_28620(f_1287_28586_28607(staticQualifier), out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 28641, 28655);

                    return result;
                }
                catch (ManagementException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 28684, 28741);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 28684, 28741);
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 28755, 28836);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 28755, 28836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 28852, 28865);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 28235, 28876);

                System.Management.QualifierDataCollection
                f_1287_28382_28398(System.Management.MethodData
                this_param)
                {
                    var return_v = this_param.Qualifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 28382, 28398);
                    return return_v;
                }


                System.Management.QualifierData
                f_1287_28382_28408(System.Management.QualifierDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 28382, 28408);
                    return return_v;
                }


                object
                f_1287_28586_28607(System.Management.QualifierData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 28586, 28607);
                    return return_v;
                }


                bool
                f_1287_28548_28620(object
                valueToConvert, out bool
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<bool>(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 28548, 28620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 28235, 28876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 28235, 28876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object AuxillaryInvokeMethod(ManagementObject obj, WMIMethodCacheEntry mdata, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 28888, 31477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 29064, 29091);

                object[]
                verifiedArguments
                = default(object[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 29107, 29162);

                MethodInformation[]
                methods = new MethodInformation[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 29176, 29215);

                methods[0] = f_1287_29189_29214(mdata);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 29295, 29376);

                f_1287_29295_29375(f_1287_29321_29331(mdata), methods, arguments, out verifiedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 29392, 29468);

                ParameterInformation[]
                parameterList = f_1287_29431_29456(mdata).parameters
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 29632, 29762);

                f_1287_29632_29761(
                            // GetBestMethodAndArguments should fill verifiedArguments with
                            // correct values (even if some values are not specified)
                            tracer, "Parameters found {0}. Arguments supplied {0}", f_1287_29714_29734(parameterList), f_1287_29736_29760(verifiedArguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 29778, 29919);

                f_1287_29778_29918(f_1287_29797_29817(parameterList) == f_1287_29821_29845(verifiedArguments), "The number of parameters and arguments should match");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 30309, 30360);

                ManagementClass
                mClass = f_1287_30334_30359(obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 30374, 30449);

                ManagementBaseObject
                inParameters = f_1287_30410_30448(mClass, f_1287_30437_30447(mdata))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 30474, 30479);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 30465, 31389) || true) && (i < f_1287_30485_30505(parameterList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 30507, 30510)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 30465, 31389))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 30465, 31389);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 30596, 30670);

                        WMIParameterInformation
                        pInfo = (WMIParameterInformation)parameterList[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 31165, 31306) || true) && ((i < f_1287_31174_31190(arguments)) && (DynAbs.Tracing.TraceSender.Expression_True(1287, 31169, 31217) && (arguments[i] == null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 31165, 31306);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 31259, 31287);

                            verifiedArguments[i] = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 31165, 31306);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 31326, 31374);

                        inParameters[f_1287_31339_31349(pInfo)] = verifiedArguments[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 925);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 31405, 31466);

                return f_1287_31412_31465(this, obj, f_1287_31440_31450(mdata), inParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 28888, 31477);

                System.Management.Automation.MethodInformation
                f_1287_29189_29214(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.MethodInfoStructure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 29189, 29214);
                    return return_v;
                }


                string
                f_1287_29321_29331(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 29321, 29331);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1287_29295_29375(string
                methodName, System.Management.Automation.MethodInformation[]
                methods, object[]
                arguments, out object[]
                newArguments)
                {
                    var return_v = GetBestMethodAndArguments(methodName, methods, arguments, out newArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 29295, 29375);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1287_29431_29456(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.MethodInfoStructure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 29431, 29456);
                    return return_v;
                }


                int
                f_1287_29714_29734(System.Management.Automation.ParameterInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 29714, 29734);
                    return return_v;
                }


                int
                f_1287_29736_29760(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 29736, 29760);
                    return return_v;
                }


                int
                f_1287_29632_29761(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1, int
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 29632, 29761);
                    return 0;
                }


                int
                f_1287_29797_29817(System.Management.Automation.ParameterInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 29797, 29817);
                    return return_v;
                }


                int
                f_1287_29821_29845(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 29821, 29845);
                    return return_v;
                }


                int
                f_1287_29778_29918(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 29778, 29918);
                    return 0;
                }


                System.Management.ManagementClass
                f_1287_30334_30359(System.Management.ManagementObject
                mgmtBaseObject)
                {
                    var return_v = CreateClassFrmObject((System.Management.ManagementBaseObject)mgmtBaseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 30334, 30359);
                    return return_v;
                }


                string
                f_1287_30437_30447(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 30437, 30447);
                    return return_v;
                }


                System.Management.ManagementBaseObject
                f_1287_30410_30448(System.Management.ManagementClass
                this_param, string
                methodName)
                {
                    var return_v = this_param.GetMethodParameters(methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 30410, 30448);
                    return return_v;
                }


                int
                f_1287_30485_30505(System.Management.Automation.ParameterInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 30485, 30505);
                    return return_v;
                }


                int
                f_1287_31174_31190(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 31174, 31190);
                    return return_v;
                }


                string
                f_1287_31339_31349(System.Management.Automation.BaseWMIAdapter.WMIParameterInformation
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 31339, 31349);
                    return return_v;
                }


                string
                f_1287_31440_31450(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 31440, 31450);
                    return return_v;
                }


                object
                f_1287_31412_31465(System.Management.Automation.BaseWMIAdapter
                this_param, System.Management.ManagementObject
                wmiObject, string
                methodName, System.Management.ManagementBaseObject
                inParams)
                {
                    var return_v = this_param.InvokeManagementMethod(wmiObject, methodName, inParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 31412, 31465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 28888, 31477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 28888, 31477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void UpdateParameters(ManagementBaseObject parameters,
                    SortedList parametersList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 31884, 33193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 32106, 32154) || true) && (parameters == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 32106, 32154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 32147, 32154);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 32106, 32154);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 32170, 33182);
                    foreach (PropertyData data in f_1287_32200_32221_I(f_1287_32200_32221(parameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 32170, 33182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 32296, 32314);

                        int
                        location = -1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 32332, 32424);

                        WMIParameterInformation
                        pInfo = f_1287_32364_32423(f_1287_32392_32401(data), f_1287_32403_32422(data))
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 32488, 32532);

                            location = (int)f_1287_32504_32531(f_1287_32504_32525(f_1287_32504_32519(data), "ID"));
                        }
                        catch (ManagementException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 32569, 32756);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 32569, 32756);
                            // If there is an exception accessing location
                            // add the parameter to the end.
                        }
                        catch (System.Runtime.InteropServices.COMException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 32774, 32985);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 32774, 32985);
                            // If there is an exception accessing location
                            // add the parameter to the end.
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33005, 33114) || true) && (location < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 33005, 33114);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33063, 33095);

                            location = f_1287_33074_33094(parametersList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 33005, 33114);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33134, 33167);

                        parametersList[location] = pInfo;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 32170, 33182);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 1013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 1013);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 31884, 33193);

                System.Management.PropertyDataCollection
                f_1287_32200_32221(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 32200, 32221);
                    return return_v;
                }


                string
                f_1287_32392_32401(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 32392, 32401);
                    return return_v;
                }


                System.Type
                f_1287_32403_32422(System.Management.PropertyData
                pData)
                {
                    var return_v = GetDotNetType(pData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 32403, 32422);
                    return return_v;
                }


                System.Management.Automation.BaseWMIAdapter.WMIParameterInformation
                f_1287_32364_32423(string
                name, System.Type
                ty)
                {
                    var return_v = new System.Management.Automation.BaseWMIAdapter.WMIParameterInformation(name, ty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 32364, 32423);
                    return return_v;
                }


                System.Management.QualifierDataCollection
                f_1287_32504_32519(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Qualifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 32504, 32519);
                    return return_v;
                }


                System.Management.QualifierData
                f_1287_32504_32525(System.Management.QualifierDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 32504, 32525);
                    return return_v;
                }


                object
                f_1287_32504_32531(System.Management.QualifierData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 32504, 32531);
                    return return_v;
                }


                int
                f_1287_33074_33094(System.Collections.SortedList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 33074, 33094);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_32200_32221_I(System.Management.PropertyDataCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 32200, 32221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 31884, 33193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 31884, 33193);
            }
        }

        internal static MethodInformation GetMethodInformation(MethodData mData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 33460, 34180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33557, 33624);

                f_1287_33557_33623(mData != null, "MethodData should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33678, 33719);

                SortedList
                parameters = f_1287_33702_33718()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33733, 33782);

                f_1287_33733_33781(f_1287_33750_33768(mData), parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33839, 33920);

                WMIParameterInformation[]
                pInfos = new WMIParameterInformation[f_1287_33902_33918(parameters)]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33934, 34043) || true) && (f_1287_33938_33954(parameters) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 33934, 34043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 33992, 34028);

                    f_1287_33992_34027(f_1287_33992_34009(parameters), pInfos, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 33934, 34043);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34059, 34134);

                MethodInformation
                returnValue = f_1287_34091_34133(false, true, pInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34150, 34169);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 33460, 34180);

                int
                f_1287_33557_33623(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 33557, 33623);
                    return 0;
                }


                System.Collections.SortedList
                f_1287_33702_33718()
                {
                    var return_v = new System.Collections.SortedList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 33702, 33718);
                    return return_v;
                }


                System.Management.ManagementBaseObject
                f_1287_33750_33768(System.Management.MethodData
                this_param)
                {
                    var return_v = this_param.InParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 33750, 33768);
                    return return_v;
                }


                int
                f_1287_33733_33781(System.Management.ManagementBaseObject
                parameters, System.Collections.SortedList
                parametersList)
                {
                    UpdateParameters(parameters, parametersList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 33733, 33781);
                    return 0;
                }


                int
                f_1287_33902_33918(System.Collections.SortedList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 33902, 33918);
                    return return_v;
                }


                int
                f_1287_33938_33954(System.Collections.SortedList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 33938, 33954);
                    return return_v;
                }


                System.Collections.ICollection
                f_1287_33992_34009(System.Collections.SortedList
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 33992, 34009);
                    return return_v;
                }


                int
                f_1287_33992_34027(System.Collections.ICollection
                this_param, System.Management.Automation.BaseWMIAdapter.WMIParameterInformation[]
                array, int
                index)
                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 33992, 34027);
                    return 0;
                }


                System.Management.Automation.MethodInformation
                f_1287_34091_34133(bool
                hasvarargs, bool
                hasoptional, System.Management.Automation.BaseWMIAdapter.WMIParameterInformation[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInformation(hasvarargs, hasoptional, (System.Management.Automation.ParameterInformation[])arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 34091, 34133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 33460, 34180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 33460, 34180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetMethodDefinition(MethodData mData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1287, 34192, 36291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34489, 34530);

                SortedList
                parameters = f_1287_34513_34529()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34544, 34593);

                f_1287_34544_34592(f_1287_34561_34579(mData), parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34609, 34663);

                StringBuilder
                inParameterString = f_1287_34643_34662()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34679, 35565) || true) && (f_1287_34683_34699(parameters) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 34679, 35565);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34737, 35550);
                        foreach (WMIParameterInformation parameter in f_1287_34783_34800_I(f_1287_34783_34800(parameters)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 34737, 35550);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34842, 34895);

                            string
                            typeName = f_1287_34860_34894(parameter.parameterType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 34919, 34986);

                            PropertyData
                            pData = f_1287_34940_34985(f_1287_34940_34969(f_1287_34940_34958(mData)), f_1287_34970_34984(parameter))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35008, 35304) || true) && (f_1287_35012_35022(pData) == CimType.Object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 35008, 35304);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35090, 35134);

                                typeName = f_1287_35101_35133(pData);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35162, 35281) || true) && (f_1287_35166_35179(pData))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 35162, 35281);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35237, 35254);

                                    typeName += "[]";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 35162, 35281);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 35008, 35304);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35328, 35363);

                            f_1287_35328_35362(
                                                inParameterString, typeName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35385, 35415);

                            f_1287_35385_35414(inParameterString, " ");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35437, 35478);

                            f_1287_35437_35477(inParameterString, f_1287_35462_35476(parameter));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35500, 35531);

                            f_1287_35500_35530(inParameterString, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 34737, 35550);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 814);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 814);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 34679, 35565);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35581, 35720) || true) && (f_1287_35585_35609(inParameterString) > 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 35581, 35720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35647, 35705);

                    f_1287_35647_35704(inParameterString, f_1287_35672_35696(inParameterString) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 35581, 35720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35736, 35814);

                f_1287_35736_35813(
                            tracer, "Constructing method definition for method {0}", f_1287_35802_35812(mData));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35828, 35872);

                StringBuilder
                builder = f_1287_35852_35871()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35888, 35946);

                f_1287_35888_35945(
                            builder, "System.Management.ManagementBaseObject ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 35960, 35987);

                f_1287_35960_35986(builder, f_1287_35975_35985(mData));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 36001, 36021);

                f_1287_36001_36020(builder, "(");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 36035, 36080);

                f_1287_36035_36079(builder, f_1287_36050_36078(inParameterString));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 36094, 36114);

                f_1287_36094_36113(builder, ")");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 36130, 36170);

                string
                returnValue = f_1287_36151_36169(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 36184, 36245);

                f_1287_36184_36244(tracer, "Definition constructed: {0}", returnValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 36261, 36280);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1287, 34192, 36291);

                System.Collections.SortedList
                f_1287_34513_34529()
                {
                    var return_v = new System.Collections.SortedList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 34513, 34529);
                    return return_v;
                }


                System.Management.ManagementBaseObject
                f_1287_34561_34579(System.Management.MethodData
                this_param)
                {
                    var return_v = this_param.InParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 34561, 34579);
                    return return_v;
                }


                int
                f_1287_34544_34592(System.Management.ManagementBaseObject
                parameters, System.Collections.SortedList
                parametersList)
                {
                    UpdateParameters(parameters, parametersList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 34544, 34592);
                    return 0;
                }


                System.Text.StringBuilder
                f_1287_34643_34662()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 34643, 34662);
                    return return_v;
                }


                int
                f_1287_34683_34699(System.Collections.SortedList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 34683, 34699);
                    return return_v;
                }


                System.Collections.ICollection
                f_1287_34783_34800(System.Collections.SortedList
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 34783, 34800);
                    return return_v;
                }


                string
                f_1287_34860_34894(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 34860, 34894);
                    return return_v;
                }


                System.Management.ManagementBaseObject
                f_1287_34940_34958(System.Management.MethodData
                this_param)
                {
                    var return_v = this_param.InParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 34940, 34958);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_34940_34969(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 34940, 34969);
                    return return_v;
                }


                string
                f_1287_34970_34984(System.Management.Automation.BaseWMIAdapter.WMIParameterInformation
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 34970, 34984);
                    return return_v;
                }


                System.Management.PropertyData
                f_1287_34940_34985(System.Management.PropertyDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 34940, 34985);
                    return return_v;
                }


                System.Management.CimType
                f_1287_35012_35022(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 35012, 35022);
                    return return_v;
                }


                string
                f_1287_35101_35133(System.Management.PropertyData
                pData)
                {
                    var return_v = GetEmbeddedObjectTypeName(pData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35101, 35133);
                    return return_v;
                }


                bool
                f_1287_35166_35179(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 35166, 35179);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_35328_35362(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35328, 35362);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_35385_35414(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35385, 35414);
                    return return_v;
                }


                string
                f_1287_35462_35476(System.Management.Automation.BaseWMIAdapter.WMIParameterInformation
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 35462, 35476);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_35437_35477(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35437, 35477);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_35500_35530(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35500, 35530);
                    return return_v;
                }


                System.Collections.ICollection
                f_1287_34783_34800_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 34783, 34800);
                    return return_v;
                }


                int
                f_1287_35585_35609(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 35585, 35609);
                    return return_v;
                }


                int
                f_1287_35672_35696(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 35672, 35696);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_35647_35704(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35647, 35704);
                    return return_v;
                }


                string
                f_1287_35802_35812(System.Management.MethodData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 35802, 35812);
                    return return_v;
                }


                int
                f_1287_35736_35813(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35736, 35813);
                    return 0;
                }


                System.Text.StringBuilder
                f_1287_35852_35871()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35852, 35871);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_35888_35945(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35888, 35945);
                    return return_v;
                }


                string
                f_1287_35975_35985(System.Management.MethodData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 35975, 35985);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_35960_35986(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 35960, 35986);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_36001_36020(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 36001, 36020);
                    return return_v;
                }


                string
                f_1287_36050_36078(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 36050, 36078);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_36035_36079(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 36035, 36079);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1287_36094_36113(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 36094, 36113);
                    return return_v;
                }


                string
                f_1287_36151_36169(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 36151, 36169);
                    return return_v;
                }


                int
                f_1287_36184_36244(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 36184, 36244);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 34192, 36291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 34192, 36291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract void AddAllProperties<T>(ManagementBaseObject wmiObject,
                    PSMemberInfoInternalCollection<T> members) where T : PSMemberInfo;

        protected abstract void AddAllMethods<T>(ManagementBaseObject wmiObject,
                    PSMemberInfoInternalCollection<T> members) where T : PSMemberInfo;

        protected abstract object InvokeManagementMethod(ManagementObject wmiObject,
                    string methodName, ManagementBaseObject inParams);

        protected abstract T GetManagementObjectMethod<T>(ManagementBaseObject wmiObject,
                    string methodName) where T : PSMemberInfo;

        protected abstract PSProperty DoGetProperty(ManagementBaseObject wmiObject,
                    string propertyName);

        protected abstract T GetFirstOrDefaultProperty<T>(ManagementBaseObject wmiObject, MemberNamePredicate predicate) where T : PSMemberInfo;

        protected abstract T GetFirstOrDefaultMethod<T>(ManagementBaseObject wmiObject, MemberNamePredicate predicate) where T : PSMemberInfo;

        private static HybridDictionary s_instanceMethodCacheTable;

        public BaseWMIAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1287, 745, 39652);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1287, 745, 39652);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 745, 39652);
        }


        static BaseWMIAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1287, 745, 39652);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 39571, 39622);
            s_instanceMethodCacheTable = f_1287_39600_39622();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1287, 745, 39652);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 745, 39652);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1287, 745, 39652);

        static System.Collections.Specialized.HybridDictionary
        f_1287_39600_39622()
        {
            var return_v = new System.Collections.Specialized.HybridDictionary();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 39600, 39622);
            return return_v;
        }

    }
    internal class ManagementClassApdapter : BaseWMIAdapter
    {
        protected override void AddAllProperties<T>(ManagementBaseObject wmiObject,
                    PSMemberInfoInternalCollection<T> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 39911, 40361);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40067, 40350) || true) && (f_1287_40071_40097(wmiObject) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 40067, 40350);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40139, 40335);
                        foreach (PropertyData property in f_1287_40173_40199_I(f_1287_40173_40199(wmiObject)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 40139, 40335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40241, 40316);

                            f_1287_40241_40315(members, f_1287_40253_40309(f_1287_40268_40281(property), this, wmiObject, property));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 40139, 40335);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 197);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 40067, 40350);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 39911, 40361);

                System.Management.PropertyDataCollection
                f_1287_40071_40097(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 40071, 40097);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_40173_40199(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 40173, 40199);
                    return return_v;
                }


                string
                f_1287_40268_40281(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 40268, 40281);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1287_40253_40309(string
                name, System.Management.Automation.ManagementClassApdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.PropertyData
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 40253, 40309);
                    return return_v;
                }


                int
                f_1287_40241_40315(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSProperty
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 40241, 40315);
                    return 0;
                }


                System.Management.PropertyDataCollection
                f_1287_40173_40199_I(System.Management.PropertyDataCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 40173, 40199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 39911, 40361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 39911, 40361);
            }
        }

        protected override PSProperty DoGetProperty(ManagementBaseObject wmiObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 40373, 40952);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40494, 40913) || true) && (f_1287_40498_40524(wmiObject) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 40494, 40913);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40566, 40898);
                        foreach (PropertyData property in f_1287_40600_40626_I(f_1287_40600_40626(wmiObject)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 40566, 40898);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40668, 40879) || true) && (f_1287_40672_40742(propertyName, f_1287_40692_40705(property), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 40668, 40879);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40792, 40856);

                                return f_1287_40799_40855(f_1287_40814_40827(property), this, wmiObject, property);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 40668, 40879);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 40566, 40898);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 333);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 333);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 40494, 40913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 40929, 40941);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 40373, 40952);

                System.Management.PropertyDataCollection
                f_1287_40498_40524(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 40498, 40524);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_40600_40626(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 40600, 40626);
                    return return_v;
                }


                string
                f_1287_40692_40705(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 40692, 40705);
                    return return_v;
                }


                bool
                f_1287_40672_40742(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 40672, 40742);
                    return return_v;
                }


                string
                f_1287_40814_40827(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 40814, 40827);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1287_40799_40855(string
                name, System.Management.Automation.ManagementClassApdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.PropertyData
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 40799, 40855);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_40600_40626_I(System.Management.PropertyDataCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 40600, 40626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 40373, 40952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 40373, 40952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object InvokeManagementMethod(ManagementObject wmiObject,
                    string methodName, ManagementBaseObject inParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 41353, 42078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 41517, 41576);

                f_1287_41517_41575(tracer, "Invoking class method: {0}", methodName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 41592, 41646);

                ManagementClass
                mClass = wmiObject as ManagementClass
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 41698, 41753);

                    return f_1287_41705_41752(mClass, methodName, inParams, null);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 41782, 42067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 41834, 42052);

                    throw f_1287_41840_42051("WMIMethodException", e, f_1287_41959_42006(), methodName, f_1287_42041_42050(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 41782, 42067);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 41353, 42078);

                int
                f_1287_41517_41575(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 41517, 41575);
                    return 0;
                }


                System.Management.ManagementBaseObject
                f_1287_41705_41752(System.Management.ManagementClass
                this_param, string
                methodName, System.Management.ManagementBaseObject
                inParameters, System.Management.InvokeMethodOptions
                options)
                {
                    var return_v = this_param.InvokeMethod(methodName, inParameters, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 41705, 41752);
                    return return_v;
                }


                string
                f_1287_41959_42006()
                {
                    var return_v = ExtendedTypeSystem.WMIMethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 41959, 42006);
                    return return_v;
                }


                string
                f_1287_42041_42050(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 42041, 42050);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1287_41840_42051(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 41840, 42051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 41353, 42078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 41353, 42078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void AddAllMethods<T>(ManagementBaseObject wmiObject,
                    PSMemberInfoInternalCollection<T> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 42514, 43397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 42667, 42784);

                f_1287_42667_42783((wmiObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1287, 42686, 42726) && (members != null)), "Input arguments should not be null.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 42800, 42905) || true) && (!f_1287_42805_42849(typeof(T), typeof(PSMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 42800, 42905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 42883, 42890);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 42800, 42905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 42921, 42938);

                CacheTable
                table
                = default(CacheTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 42952, 43000);

                table = f_1287_42960_42999(wmiObject, true);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 43016, 43386);
                    foreach (WMIMethodCacheEntry methodEntry in f_1287_43060_43082_I(table.memberCollection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 43016, 43386);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 43116, 43371) || true) && (f_1287_43120_43145(members, f_1287_43128_43144(methodEntry)) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 43116, 43371);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 43195, 43251);

                            f_1287_43195_43250(tracer, "Adding method {0}", f_1287_43233_43249(methodEntry));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 43273, 43352);

                            f_1287_43273_43351(members, f_1287_43285_43345(f_1287_43298_43314(methodEntry), this, wmiObject, methodEntry));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 43116, 43371);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 43016, 43386);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 371);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 42514, 43397);

                int
                f_1287_42667_42783(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 42667, 42783);
                    return 0;
                }


                bool
                f_1287_42805_42849(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 42805, 42849);
                    return return_v;
                }


                System.Management.Automation.CacheTable
                f_1287_42960_42999(System.Management.ManagementBaseObject
                wmiObject, bool
                staticBinding)
                {
                    var return_v = GetInstanceMethodTable(wmiObject, staticBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 42960, 42999);
                    return return_v;
                }


                string
                f_1287_43128_43144(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 43128, 43144);
                    return return_v;
                }


                T
                f_1287_43120_43145(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 43120, 43145);
                    return return_v;
                }


                string
                f_1287_43233_43249(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 43233, 43249);
                    return return_v;
                }


                int
                f_1287_43195_43250(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 43195, 43250);
                    return 0;
                }


                string
                f_1287_43298_43314(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 43298, 43314);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1287_43285_43345(string
                name, System.Management.Automation.ManagementClassApdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 43285, 43345);
                    return return_v;
                }


                int
                f_1287_43273_43351(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSMethod
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 43273, 43351);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1287_43060_43082_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 43060, 43082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 42514, 43397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 42514, 43397);
            }
        }

        protected override T GetManagementObjectMethod<T>(ManagementBaseObject wmiObject, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 43782, 44367);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 43907, 44017) || true) && (!f_1287_43912_43956(typeof(T), typeof(PSMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 43907, 44017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 43990, 44002);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 43907, 44017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44033, 44096);

                CacheTable
                typeTable = f_1287_44056_44095(wmiObject, true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44110, 44182);

                WMIMethodCacheEntry
                method = (WMIMethodCacheEntry)f_1287_44160_44181(typeTable, methodName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44198, 44277) || true) && (method == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 44198, 44277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44250, 44262);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 44198, 44277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44293, 44356);

                return f_1287_44300_44350(f_1287_44313_44324(method), this, wmiObject, method) as T;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 43782, 44367);

                bool
                f_1287_43912_43956(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 43912, 43956);
                    return return_v;
                }


                System.Management.Automation.CacheTable
                f_1287_44056_44095(System.Management.ManagementBaseObject
                wmiObject, bool
                staticBinding)
                {
                    var return_v = GetInstanceMethodTable(wmiObject, staticBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 44056, 44095);
                    return return_v;
                }


                object
                f_1287_44160_44181(System.Management.Automation.CacheTable
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 44160, 44181);
                    return return_v;
                }


                string
                f_1287_44313_44324(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 44313, 44324);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1287_44300_44350(string
                name, System.Management.Automation.ManagementClassApdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 44300, 44350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 43782, 44367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 43782, 44367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override T GetFirstOrDefaultProperty<T>(ManagementBaseObject wmiObject, MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 44379, 45061);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44516, 44628) || true) && (!f_1287_44521_44567(typeof(T), typeof(PSProperty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 44516, 44628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44601, 44613);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 44516, 44628);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44644, 45022) || true) && (f_1287_44648_44674(wmiObject) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 44644, 45022);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44716, 45007);
                        foreach (PropertyData property in f_1287_44750_44776_I(f_1287_44750_44776(wmiObject)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 44716, 45007);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44818, 44988) || true) && (f_1287_44822_44846(predicate, f_1287_44832_44845(property)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 44818, 44988);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 44896, 44965);

                                return f_1287_44903_44959(f_1287_44918_44931(property), this, wmiObject, property) as T;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 44818, 44988);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 44716, 45007);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 292);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 292);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 44644, 45022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45038, 45050);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 44379, 45061);

                bool
                f_1287_44521_44567(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 44521, 44567);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_44648_44674(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 44648, 44674);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_44750_44776(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.SystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 44750, 44776);
                    return return_v;
                }


                string
                f_1287_44832_44845(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 44832, 44845);
                    return return_v;
                }


                bool
                f_1287_44822_44846(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 44822, 44846);
                    return return_v;
                }


                string
                f_1287_44918_44931(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 44918, 44931);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1287_44903_44959(string
                name, System.Management.Automation.ManagementClassApdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.PropertyData
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 44903, 44959);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_44750_44776_I(System.Management.PropertyDataCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 44750, 44776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 44379, 45061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 44379, 45061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override T GetFirstOrDefaultMethod<T>(ManagementBaseObject wmiObject, MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 45073, 45726);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45208, 45318) || true) && (!f_1287_45213_45257(typeof(T), typeof(PSMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 45208, 45318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45291, 45303);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 45208, 45318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45334, 45393);

                CacheTable
                table = f_1287_45353_45392(wmiObject, true)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45407, 45687);
                    foreach (WMIMethodCacheEntry methodEntry in f_1287_45451_45473_I(table.memberCollection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 45407, 45687);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45507, 45672) || true) && (f_1287_45511_45538(predicate, f_1287_45521_45537(methodEntry)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 45507, 45672);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45580, 45653);

                            return f_1287_45587_45647(f_1287_45600_45616(methodEntry), this, wmiObject, methodEntry) as T;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 45507, 45672);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 45407, 45687);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 45703, 45715);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 45073, 45726);

                bool
                f_1287_45213_45257(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 45213, 45257);
                    return return_v;
                }


                System.Management.Automation.CacheTable
                f_1287_45353_45392(System.Management.ManagementBaseObject
                wmiObject, bool
                staticBinding)
                {
                    var return_v = GetInstanceMethodTable(wmiObject, staticBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 45353, 45392);
                    return return_v;
                }


                string
                f_1287_45521_45537(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 45521, 45537);
                    return return_v;
                }


                bool
                f_1287_45511_45538(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 45511, 45538);
                    return return_v;
                }


                string
                f_1287_45600_45616(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 45600, 45616);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1287_45587_45647(string
                name, System.Management.Automation.ManagementClassApdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 45587, 45647);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1287_45451_45473_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 45451, 45473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 45073, 45726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 45073, 45726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ManagementClassApdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1287, 39839, 45733);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1287, 39839, 45733);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 39839, 45733);
        }


        static ManagementClassApdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1287, 39839, 45733);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1287, 39839, 45733);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 39839, 45733);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1287, 39839, 45733);
    }
    internal class ManagementObjectAdapter : ManagementClassApdapter
    {
        protected override void AddAllProperties<T>(ManagementBaseObject wmiObject,
                    PSMemberInfoInternalCollection<T> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 45956, 46490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46150, 46192);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddAllProperties(wmiObject, members), 1287, 46150, 46191);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46208, 46479) || true) && (f_1287_46212_46232(wmiObject) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 46208, 46479);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46274, 46464);
                        foreach (PropertyData property in f_1287_46308_46328_I(f_1287_46308_46328(wmiObject)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 46274, 46464);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46370, 46445);

                            f_1287_46370_46444(members, f_1287_46382_46438(f_1287_46397_46410(property), this, wmiObject, property));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 46274, 46464);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 46208, 46479);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 45956, 46490);

                System.Management.PropertyDataCollection
                f_1287_46212_46232(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 46212, 46232);
                    return return_v;
                }


                System.Management.PropertyDataCollection
                f_1287_46308_46328(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 46308, 46328);
                    return return_v;
                }


                string
                f_1287_46397_46410(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 46397, 46410);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1287_46382_46438(string
                name, System.Management.Automation.ManagementObjectAdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.PropertyData
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 46382, 46438);
                    return return_v;
                }


                int
                f_1287_46370_46444(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSProperty
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 46370, 46444);
                    return 0;
                }


                System.Management.PropertyDataCollection
                f_1287_46308_46328_I(System.Management.PropertyDataCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 46308, 46328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 45956, 46490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 45956, 46490);
            }
        }

        protected override PSProperty DoGetProperty(ManagementBaseObject wmiObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 46502, 48315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46623, 46655);

                PropertyData
                adapterData = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46749, 46818);

                PSProperty
                returnValue = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DoGetProperty(wmiObject, propertyName), 1287, 46774, 46817)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46834, 46925) || true) && (returnValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 46834, 46925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46891, 46910);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 46834, 46925);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 46977, 47026);

                    adapterData = f_1287_46991_47025(f_1287_46991_47011(wmiObject), propertyName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 47044, 47114);

                    return f_1287_47051_47113(f_1287_47066_47082(adapterData), this, wmiObject, adapterData);
                }
                catch (ManagementException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 47143, 47200);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 47143, 47200);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 47214, 48276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 47374, 47441);

                    Tracing.PSEtwLogProvider
                    provider = f_1287_47410_47440()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 47461, 48219);

                    f_1287_47461_48218(
                                    provider, PSEventId.Engine_Health, PSChannel.Analytic, PSOpcode.Exception, PSLevel.Informational, PSTask.None, PSKeyword.UseAlwaysOperational, f_1287_47836_48115(f_1287_47850_47878(), "ManagementBaseObjectAdapter::DoGetProperty::PropertyName:{0}, Exception:{1}, StackTrace:{2}", propertyName, f_1287_48091_48100(e), f_1287_48102_48114(e)), string.Empty, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 47214, 48276);
                    // ignore the exception.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 48292, 48304);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 46502, 48315);

                System.Management.PropertyDataCollection
                f_1287_46991_47011(System.Management.ManagementBaseObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 46991, 47011);
                    return return_v;
                }


                System.Management.PropertyData
                f_1287_46991_47025(System.Management.PropertyDataCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 46991, 47025);
                    return return_v;
                }


                string
                f_1287_47066_47082(System.Management.PropertyData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 47066, 47082);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1287_47051_47113(string
                name, System.Management.Automation.ManagementObjectAdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.PropertyData
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 47051, 47113);
                    return return_v;
                }


                System.Management.Automation.Tracing.PSEtwLogProvider
                f_1287_47410_47440()
                {
                    var return_v = new System.Management.Automation.Tracing.PSEtwLogProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 47410, 47440);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1287_47850_47878()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 47850, 47878);
                    return return_v;
                }


                string
                f_1287_48091_48100(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 48091, 48100);
                    return return_v;
                }


                string
                f_1287_48102_48114(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 48102, 48114);
                    return return_v;
                }


                string
                f_1287_47836_48115(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 47836, 48115);
                    return return_v;
                }


                int
                f_1287_47461_48218(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 47461, 48218);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 46502, 48315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 46502, 48315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object InvokeManagementMethod(ManagementObject obj, string methodName, ManagementBaseObject inParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 48710, 49394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 48855, 48914);

                f_1287_48855_48913(tracer, "Invoking class method: {0}", methodName);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 48966, 49039);

                    ManagementBaseObject
                    robj = f_1287_48994_49038(obj, methodName, inParams, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 49057, 49069);

                    return robj;
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1287, 49098, 49383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 49150, 49368);

                    throw f_1287_49156_49367("WMIMethodException", e, f_1287_49275_49322(), methodName, f_1287_49357_49366(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1287, 49098, 49383);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 48710, 49394);

                int
                f_1287_48855_48913(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 48855, 48913);
                    return 0;
                }


                System.Management.ManagementBaseObject
                f_1287_48994_49038(System.Management.ManagementObject
                this_param, string
                methodName, System.Management.ManagementBaseObject
                inParameters, System.Management.InvokeMethodOptions
                options)
                {
                    var return_v = this_param.InvokeMethod(methodName, inParameters, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 48994, 49038);
                    return return_v;
                }


                string
                f_1287_49275_49322()
                {
                    var return_v = ExtendedTypeSystem.WMIMethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 49275, 49322);
                    return return_v;
                }


                string
                f_1287_49357_49366(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 49357, 49366);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1287_49156_49367(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 49156, 49367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 48710, 49394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 48710, 49394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void AddAllMethods<T>(ManagementBaseObject wmiObject,
                    PSMemberInfoInternalCollection<T> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 49818, 50702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 49971, 50088);

                f_1287_49971_50087((wmiObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1287, 49990, 50030) && (members != null)), "Input arguments should not be null.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50104, 50209) || true) && (!f_1287_50109_50153(typeof(T), typeof(PSMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 50104, 50209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50187, 50194);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 50104, 50209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50225, 50242);

                CacheTable
                table
                = default(CacheTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50256, 50305);

                table = f_1287_50264_50304(wmiObject, false);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50321, 50691);
                    foreach (WMIMethodCacheEntry methodEntry in f_1287_50365_50387_I(table.memberCollection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 50321, 50691);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50421, 50676) || true) && (f_1287_50425_50450(members, f_1287_50433_50449(methodEntry)) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 50421, 50676);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50500, 50556);

                            f_1287_50500_50555(tracer, "Adding method {0}", f_1287_50538_50554(methodEntry));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 50578, 50657);

                            f_1287_50578_50656(members, f_1287_50590_50650(f_1287_50603_50619(methodEntry), this, wmiObject, methodEntry));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 50421, 50676);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 50321, 50691);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1287, 1, 371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1287, 1, 371);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 49818, 50702);

                int
                f_1287_49971_50087(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 49971, 50087);
                    return 0;
                }


                bool
                f_1287_50109_50153(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 50109, 50153);
                    return return_v;
                }


                System.Management.Automation.CacheTable
                f_1287_50264_50304(System.Management.ManagementBaseObject
                wmiObject, bool
                staticBinding)
                {
                    var return_v = GetInstanceMethodTable(wmiObject, staticBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 50264, 50304);
                    return return_v;
                }


                string
                f_1287_50433_50449(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 50433, 50449);
                    return return_v;
                }


                T
                f_1287_50425_50450(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 50425, 50450);
                    return return_v;
                }


                string
                f_1287_50538_50554(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 50538, 50554);
                    return return_v;
                }


                int
                f_1287_50500_50555(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 50500, 50555);
                    return 0;
                }


                string
                f_1287_50603_50619(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 50603, 50619);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1287_50590_50650(string
                name, System.Management.Automation.ManagementObjectAdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 50590, 50650);
                    return return_v;
                }


                int
                f_1287_50578_50656(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSMethod
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 50578, 50656);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1287_50365_50387_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 50365, 50387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 49818, 50702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 49818, 50702);
            }
        }

        protected override T GetManagementObjectMethod<T>(ManagementBaseObject wmiObject, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1287, 51092, 51725);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51217, 51327) || true) && (!f_1287_51222_51266(typeof(T), typeof(PSMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 51217, 51327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51300, 51312);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 51217, 51327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51343, 51364);

                CacheTable
                typeTable
                = default(CacheTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51378, 51405);

                WMIMethodCacheEntry
                method
                = default(WMIMethodCacheEntry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51421, 51474);

                typeTable = f_1287_51433_51473(wmiObject, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51488, 51540);

                method = (WMIMethodCacheEntry)f_1287_51518_51539(typeTable, methodName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51556, 51635) || true) && (method == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1287, 51556, 51635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51608, 51620);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1287, 51556, 51635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1287, 51651, 51714);

                return f_1287_51658_51708(f_1287_51671_51682(method), this, wmiObject, method) as T;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1287, 51092, 51725);

                bool
                f_1287_51222_51266(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 51222, 51266);
                    return return_v;
                }


                System.Management.Automation.CacheTable
                f_1287_51433_51473(System.Management.ManagementBaseObject
                wmiObject, bool
                staticBinding)
                {
                    var return_v = GetInstanceMethodTable(wmiObject, staticBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 51433, 51473);
                    return return_v;
                }


                object
                f_1287_51518_51539(System.Management.Automation.CacheTable
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 51518, 51539);
                    return return_v;
                }


                string
                f_1287_51671_51682(System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1287, 51671, 51682);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1287_51658_51708(string
                name, System.Management.Automation.ManagementObjectAdapter
                adapter, System.Management.ManagementBaseObject
                baseObject, System.Management.Automation.BaseWMIAdapter.WMIMethodCacheEntry
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, (object)baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1287, 51658, 51708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1287, 51092, 51725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 51092, 51725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ManagementObjectAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1287, 45875, 51732);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1287, 45875, 51732);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 45875, 51732);
        }


        static ManagementObjectAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1287, 45875, 51732);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1287, 45875, 51732);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1287, 45875, 51732);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1287, 45875, 51732);
    }
}
