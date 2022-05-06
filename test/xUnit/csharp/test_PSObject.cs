// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation.Language;
using Xunit;

namespace PSTests.Parallel
{
    using System.Linq;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;
    using System.Xml;

    using Microsoft.Management.Infrastructure;
    public static class PSObjectTests
    {
        [Fact]
        public static void TestEmptyObjectHasNoProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 453, 690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 543, 568);

                var
                pso = f_960_553_567()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 582, 639);

                var
                actual = f_960_595_638(pso, name => true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 653, 679);

                f_960_653_678(actual);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 453, 690);

                System.Management.Automation.PSObject
                f_960_553_567()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 553, 567);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_595_638(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 595, 638);
                    return return_v;
                }


                bool
                f_960_653_678(System.Management.Automation.PSPropertyInfo
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 653, 678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 453, 690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 453, 690);
            }
        }

        [Fact]
        public static void TestWrappedDateTimeHasReflectedMember()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 702, 1037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 801, 838);

                var
                pso = f_960_811_837(DateTime.Now)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 852, 924);

                var
                member = f_960_865_923(pso, name => name == "DayOfWeek")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 938, 967);

                f_960_938_966(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 981, 1026);

                f_960_981_1025("DayOfWeek", f_960_1013_1024(member));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 702, 1037);

                System.Management.Automation.PSObject
                f_960_811_837(System.DateTime
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 811, 837);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_865_923(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 865, 923);
                    return return_v;
                }


                bool
                f_960_938_966(System.Management.Automation.PSPropertyInfo
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 938, 966);
                    return return_v;
                }


                string
                f_960_1013_1024(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 1013, 1024);
                    return return_v;
                }


                bool
                f_960_981_1025(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 981, 1025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 702, 1037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 702, 1037);
            }
        }

        [Fact]
        public static void TestAdaptedMember()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 1049, 1437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1128, 1165);

                var
                pso = f_960_1138_1164(DateTime.Now)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1179, 1238);

                f_960_1179_1237(f_960_1179_1190(pso), f_960_1195_1236("NewMember", "AValue"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1252, 1324);

                var
                member = f_960_1265_1323(pso, name => name == "NewMember")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1338, 1367);

                f_960_1338_1366(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1381, 1426);

                f_960_1381_1425("NewMember", f_960_1413_1424(member));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 1049, 1437);

                System.Management.Automation.PSObject
                f_960_1138_1164(System.DateTime
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1138, 1164);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_960_1179_1190(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 1179, 1190);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_960_1195_1236(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1195, 1236);
                    return return_v;
                }


                int
                f_960_1179_1237(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1179, 1237);
                    return 0;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_1265_1323(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1265, 1323);
                    return return_v;
                }


                bool
                f_960_1338_1366(System.Management.Automation.PSPropertyInfo
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1338, 1366);
                    return return_v;
                }


                string
                f_960_1413_1424(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 1413, 1424);
                    return return_v;
                }


                bool
                f_960_1381_1425(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1381, 1425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 1049, 1437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 1049, 1437);
            }
        }

        [Fact]
        public static void TestShadowedMember()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 1449, 1895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1529, 1566);

                var
                pso = f_960_1539_1565(DateTime.Now)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1580, 1639);

                f_960_1580_1638(f_960_1580_1591(pso), f_960_1596_1637("DayOfWeek", "AValue"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1653, 1725);

                var
                member = f_960_1666_1724(pso, name => name == "DayOfWeek")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1739, 1768);

                f_960_1739_1767(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1782, 1827);

                f_960_1782_1826("DayOfWeek", f_960_1814_1825(member));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1841, 1884);

                f_960_1841_1883("AValue", f_960_1870_1882(member));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 1449, 1895);

                System.Management.Automation.PSObject
                f_960_1539_1565(System.DateTime
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1539, 1565);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_960_1580_1591(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 1580, 1591);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_960_1596_1637(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1596, 1637);
                    return return_v;
                }


                int
                f_960_1580_1638(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1580, 1638);
                    return 0;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_1666_1724(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1666, 1724);
                    return return_v;
                }


                bool
                f_960_1739_1767(System.Management.Automation.PSPropertyInfo
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1739, 1767);
                    return return_v;
                }


                string
                f_960_1814_1825(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 1814, 1825);
                    return return_v;
                }


                bool
                f_960_1782_1826(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1782, 1826);
                    return return_v;
                }


                object
                f_960_1870_1882(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 1870, 1882);
                    return return_v;
                }


                bool
                f_960_1841_1883(string
                expected, object
                actual)
                {
                    var return_v = CustomAssert.Equal((object)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 1841, 1883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 1449, 1895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 1449, 1895);
            }
        }

        [Fact]
        public static void TestMemberSetIsNotProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 1907, 2386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 1995, 2032);

                var
                pso = f_960_2005_2031(DateTime.Now)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2046, 2109);

                var
                psNoteProperty = f_960_2067_2108("NewMember", "AValue")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2123, 2155);

                f_960_2123_2154(f_960_2123_2134(pso), psNoteProperty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2169, 2244);

                f_960_2169_2243(f_960_2169_2180(pso), f_960_2185_2242("NewMemberSet", new[] { psNoteProperty }));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2260, 2335);

                var
                member = f_960_2273_2334(pso, name => name == "NewMemberSet")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2349, 2375);

                f_960_2349_2374(member);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 1907, 2386);

                System.Management.Automation.PSObject
                f_960_2005_2031(System.DateTime
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2005, 2031);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_960_2067_2108(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2067, 2108);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_960_2123_2134(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 2123, 2134);
                    return return_v;
                }


                int
                f_960_2123_2154(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2123, 2154);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_960_2169_2180(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 2169, 2180);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_960_2185_2242(string
                name, System.Management.Automation.PSNoteProperty[]
                members)
                {
                    var return_v = new System.Management.Automation.PSMemberSet(name, (System.Collections.Generic.IEnumerable<System.Management.Automation.PSMemberInfo>)members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2185, 2242);
                    return return_v;
                }


                int
                f_960_2169_2243(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberSet
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2169, 2243);
                    return 0;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_2273_2334(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2273, 2334);
                    return return_v;
                }


                bool
                f_960_2349_2374(System.Management.Automation.PSPropertyInfo
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2349, 2374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 1907, 2386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 1907, 2386);
            }
        }

        [Fact]
        public static void TestMemberSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 2398, 2926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2473, 2510);

                var
                pso = f_960_2483_2509(DateTime.Now)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2524, 2587);

                var
                psNoteProperty = f_960_2545_2586("NewMember", "AValue")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2601, 2633);

                f_960_2601_2632(f_960_2601_2612(pso), psNoteProperty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2647, 2722);

                f_960_2647_2721(f_960_2647_2658(pso), f_960_2663_2720("NewMemberSet", new[] { psNoteProperty }));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2738, 2810);

                var
                member = f_960_2751_2809(f_960_2751_2762(pso), name => name == "NewMemberSet")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2824, 2853);

                f_960_2824_2852(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 2867, 2915);

                f_960_2867_2914("NewMemberSet", f_960_2902_2913(member));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 2398, 2926);

                System.Management.Automation.PSObject
                f_960_2483_2509(System.DateTime
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2483, 2509);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_960_2545_2586(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2545, 2586);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_960_2601_2612(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 2601, 2612);
                    return return_v;
                }


                int
                f_960_2601_2632(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2601, 2632);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_960_2647_2658(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 2647, 2658);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_960_2663_2720(string
                name, System.Management.Automation.PSNoteProperty[]
                members)
                {
                    var return_v = new System.Management.Automation.PSMemberSet(name, (System.Collections.Generic.IEnumerable<System.Management.Automation.PSMemberInfo>)members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2663, 2720);
                    return return_v;
                }


                int
                f_960_2647_2721(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberSet
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2647, 2721);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_960_2751_2762(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 2751, 2762);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_960_2751_2809(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.FirstOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2751, 2809);
                    return return_v;
                }


                bool
                f_960_2824_2852(System.Management.Automation.PSMemberInfo
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2824, 2852);
                    return return_v;
                }


                string
                f_960_2902_2913(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 2902, 2913);
                    return return_v;
                }


                bool
                f_960_2867_2914(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 2867, 2914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 2398, 2926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 2398, 2926);
            }
        }

        [Fact]
        public static void TextXmlElementMember()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 2938, 3508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3020, 3048);

                var
                doc = f_960_3030_3047()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3062, 3099);

                var
                root = f_960_3073_3098(doc, "root")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3113, 3135);

                f_960_3113_3134(doc, root);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3149, 3193);

                var
                firstChild = f_960_3166_3192(doc, "elem1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3207, 3236);

                f_960_3207_3235(root, firstChild);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3250, 3307);

                f_960_3250_3306(root, f_960_3267_3293(doc, "elem2"), firstChild);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3323, 3352);

                var
                pso = f_960_3333_3351(root)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3366, 3442);

                var
                member = f_960_3379_3441(pso, name => name.StartsWith("elem"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3456, 3497);

                f_960_3456_3496("elem1", f_960_3484_3495(member));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 2938, 3508);

                System.Xml.XmlDocument
                f_960_3030_3047()
                {
                    var return_v = new System.Xml.XmlDocument();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3030, 3047);
                    return return_v;
                }


                System.Xml.XmlElement
                f_960_3073_3098(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.CreateElement(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3073, 3098);
                    return return_v;
                }


                System.Xml.XmlNode
                f_960_3113_3134(System.Xml.XmlDocument
                this_param, System.Xml.XmlElement
                newChild)
                {
                    var return_v = this_param.AppendChild((System.Xml.XmlNode)newChild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3113, 3134);
                    return return_v;
                }


                System.Xml.XmlElement
                f_960_3166_3192(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.CreateElement(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3166, 3192);
                    return return_v;
                }


                System.Xml.XmlNode
                f_960_3207_3235(System.Xml.XmlElement
                this_param, System.Xml.XmlElement
                newChild)
                {
                    var return_v = this_param.AppendChild((System.Xml.XmlNode)newChild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3207, 3235);
                    return return_v;
                }


                System.Xml.XmlElement
                f_960_3267_3293(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.CreateElement(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3267, 3293);
                    return return_v;
                }


                System.Xml.XmlNode
                f_960_3250_3306(System.Xml.XmlElement
                this_param, System.Xml.XmlElement
                newChild, System.Xml.XmlElement
                refChild)
                {
                    var return_v = this_param.InsertAfter((System.Xml.XmlNode)newChild, (System.Xml.XmlNode)refChild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3250, 3306);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_960_3333_3351(System.Xml.XmlElement
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3333, 3351);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_3379_3441(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3379, 3441);
                    return return_v;
                }


                string
                f_960_3484_3495(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 3484, 3495);
                    return return_v;
                }


                bool
                f_960_3456_3496(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3456, 3496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 2938, 3508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 2938, 3508);
            }
        }

        [Fact]
        public static void TextXmlAttributeMember()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 3520, 4026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3604, 3632);

                var
                doc = f_960_3614_3631()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3646, 3683);

                var
                root = f_960_3657_3682(doc, "root")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3697, 3719);

                f_960_3697_3718(doc, root);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3733, 3768);

                f_960_3733_3767(root, "attr", "value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3782, 3826);

                f_960_3782_3825(root, f_960_3799_3824(doc, "elem"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3842, 3871);

                var
                pso = f_960_3852_3870(root)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3885, 3961);

                var
                member = f_960_3898_3960(pso, name => name.StartsWith("attr"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 3975, 4015);

                f_960_3975_4014("attr", f_960_4002_4013(member));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 3520, 4026);

                System.Xml.XmlDocument
                f_960_3614_3631()
                {
                    var return_v = new System.Xml.XmlDocument();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3614, 3631);
                    return return_v;
                }


                System.Xml.XmlElement
                f_960_3657_3682(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.CreateElement(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3657, 3682);
                    return return_v;
                }


                System.Xml.XmlNode
                f_960_3697_3718(System.Xml.XmlDocument
                this_param, System.Xml.XmlElement
                newChild)
                {
                    var return_v = this_param.AppendChild((System.Xml.XmlNode)newChild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3697, 3718);
                    return return_v;
                }


                int
                f_960_3733_3767(System.Xml.XmlElement
                this_param, string
                name, string
                value)
                {
                    this_param.SetAttribute(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3733, 3767);
                    return 0;
                }


                System.Xml.XmlElement
                f_960_3799_3824(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.CreateElement(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3799, 3824);
                    return return_v;
                }


                System.Xml.XmlNode
                f_960_3782_3825(System.Xml.XmlElement
                this_param, System.Xml.XmlElement
                newChild)
                {
                    var return_v = this_param.AppendChild((System.Xml.XmlNode)newChild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3782, 3825);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_960_3852_3870(System.Xml.XmlElement
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3852, 3870);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_3898_3960(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3898, 3960);
                    return return_v;
                }


                string
                f_960_4002_4013(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 4002, 4013);
                    return return_v;
                }


                bool
                f_960_3975_4014(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 3975, 4014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 3520, 4026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 3520, 4026);
            }
        }

        [SkippableFact]
        public static void TestCimInstanceProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(960, 4038, 4805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4132, 4163);

                f_960_4132_4162(f_960_4143_4161());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4177, 4224);

                var
                iss = f_960_4187_4223()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4238, 4387);

                f_960_4238_4386(f_960_4238_4250(iss), f_960_4255_4385("Get-CimInstance", typeof(Microsoft.Management.Infrastructure.CimCmdlets.GetCimInstanceCommand), null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4401, 4794);
                using (var
                ps = f_960_4417_4439(iss)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4473, 4546);

                    f_960_4473_4545(f_960_4473_4505(ps, "Get-CimInstance"), "ClassName", "Win32_BIOS");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4564, 4603);

                    var
                    res = f_960_4574_4602(f_960_4574_4585(ps))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4621, 4647);

                    f_960_4621_4646(res);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4665, 4732);

                    var
                    member = f_960_4678_4731(res, name => name == "Name")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(960, 4750, 4779);

                    f_960_4750_4778(member);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(960, 4401, 4794);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(960, 4038, 4805);

                bool
                f_960_4143_4161()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 4143, 4161);
                    return return_v;
                }


                int
                f_960_4132_4162(bool
                condition)
                {
                    Skip.IfNot(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4132, 4162);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_960_4187_4223()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4187, 4223);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_960_4238_4250(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(960, 4238, 4250);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateCmdletEntry
                f_960_4255_4385(string
                name, System.Type
                implementingType, string
                helpFileName)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateCmdletEntry(name, implementingType, helpFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4255, 4385);
                    return return_v;
                }


                int
                f_960_4238_4386(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateCmdletEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4238, 4386);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_960_4417_4439(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = PowerShell.Create(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4417, 4439);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_960_4473_4505(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4473, 4505);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_960_4473_4545(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4473, 4545);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_960_4574_4585(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4574, 4585);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_960_4574_4602(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4574, 4602);
                    return return_v;
                }


                bool
                f_960_4621_4646(System.Management.Automation.PSObject
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4621, 4646);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_960_4678_4731(System.Management.Automation.PSObject
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4678, 4731);
                    return return_v;
                }


                bool
                f_960_4750_4778(System.Management.Automation.PSPropertyInfo
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(960, 4750, 4778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(960, 4038, 4805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 4038, 4805);
            }
        }

        static PSObjectTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(960, 403, 4812);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(960, 403, 4812);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(960, 403, 4812);
        }

    }
}
