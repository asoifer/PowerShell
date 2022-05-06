// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TestOrder.TestCaseOrdering
{
    public class PriorityOrderer : ITestCaseOrderer
    {
        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(951, 326, 1397);

                var listYield = new List<TTestCase>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 468, 533);

                var
                sortedMethods = f_951_488_532()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 549, 988);
                    foreach (TTestCase testCase in f_951_580_589_I(testCases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(951, 549, 988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 623, 640);

                        int
                        priority = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 660, 902);
                            foreach (IAttributeInfo attr in f_951_692_791_I(f_951_692_791(f_951_692_718(f_951_692_711(testCase)), f_951_739_790(typeof(TestPriorityAttribute)))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(951, 660, 902);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 833, 883);

                                priority = f_951_844_882(attr, "Priority");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(951, 660, 902);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(951, 1, 243);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(951, 1, 243);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 922, 973);

                        f_951_922_972(f_951_922_958(sortedMethods, priority), testCase);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(951, 549, 988);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(951, 1, 440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(951, 1, 440);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1004, 1386);
                    foreach (var list in f_951_1025_1087_I(f_951_1025_1087(f_951_1025_1043(sortedMethods), priority => sortedMethods[priority])))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(951, 1004, 1386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1121, 1235);

                        f_951_1121_1234(list, (x, y) => StringComparer.OrdinalIgnoreCase.Compare(x.TestMethod.Method.Name, y.TestMethod.Method.Name));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1253, 1371);
                            foreach (TTestCase testCase in f_951_1284_1288_I(list))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(951, 1253, 1371);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1330, 1352);

                                listYield.Add(testCase);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(951, 1253, 1371);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(951, 1, 119);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(951, 1, 119);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(951, 1004, 1386);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(951, 1, 383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(951, 1, 383);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(951, 326, 1397);

                return listYield;

                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<TTestCase>>
                f_951_488_532()
                {
                    var return_v = new System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<TTestCase>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 488, 532);
                    return return_v;
                }


                Xunit.Abstractions.ITestMethod
                f_951_692_711(TTestCase
                this_param)
                {
                    var return_v = this_param.TestMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(951, 692, 711);
                    return return_v;
                }


                Xunit.Abstractions.IMethodInfo
                f_951_692_718(Xunit.Abstractions.ITestMethod
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(951, 692, 718);
                    return return_v;
                }


                string
                f_951_739_790(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(951, 739, 790);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Xunit.Abstractions.IAttributeInfo>
                f_951_692_791(Xunit.Abstractions.IMethodInfo
                this_param, string
                assemblyQualifiedAttributeTypeName)
                {
                    var return_v = this_param.GetCustomAttributes(assemblyQualifiedAttributeTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 692, 791);
                    return return_v;
                }


                int
                f_951_844_882(Xunit.Abstractions.IAttributeInfo
                this_param, string
                argumentName)
                {
                    var return_v = this_param.GetNamedArgument<int>(argumentName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 844, 882);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Xunit.Abstractions.IAttributeInfo>
                f_951_692_791_I(System.Collections.Generic.IEnumerable<Xunit.Abstractions.IAttributeInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 692, 791);
                    return return_v;
                }


                System.Collections.Generic.List<TTestCase>
                f_951_922_958(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<TTestCase>>
                dictionary, int
                key)
                {
                    var return_v = GetOrCreate((System.Collections.Generic.IDictionary<int, System.Collections.Generic.List<TTestCase>>)dictionary, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 922, 958);
                    return return_v;
                }


                int
                f_951_922_972(System.Collections.Generic.List<TTestCase>
                this_param, TTestCase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 922, 972);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<TTestCase>
                f_951_580_589_I(System.Collections.Generic.IEnumerable<TTestCase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 580, 589);
                    return return_v;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<TTestCase>>.KeyCollection
                f_951_1025_1043(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<TTestCase>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(951, 1025, 1043);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.List<TTestCase>>
                f_951_1025_1087(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<TTestCase>>.KeyCollection
                source, System.Func<int, System.Collections.Generic.List<TTestCase>>
                selector)
                {
                    var return_v = source.Select<int, System.Collections.Generic.List<TTestCase>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 1025, 1087);
                    return return_v;
                }


                int
                f_951_1121_1234(System.Collections.Generic.List<TTestCase>
                this_param, System.Comparison<TTestCase>
                comparison)
                {
                    this_param.Sort(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 1121, 1234);
                    return 0;
                }


                System.Collections.Generic.List<TTestCase>
                f_951_1284_1288_I(System.Collections.Generic.List<TTestCase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 1284, 1288);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.List<TTestCase>>
                f_951_1025_1087_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.List<TTestCase>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 1025, 1087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(951, 326, 1397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(951, 326, 1397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TValue GetOrCreate<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TKey key) where TValue : new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(951, 1409, 1804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1550, 1564);

                TValue
                result
                = default(TValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1580, 1686) || true) && (f_951_1584_1623(dictionary, key, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(951, 1580, 1686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1657, 1671);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(951, 1580, 1686);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1702, 1724);

                result = f_951_1711_1723();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1738, 1763);

                dictionary[key] = result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(951, 1779, 1793);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(951, 1409, 1804);

                bool
                f_951_1584_1623(System.Collections.Generic.IDictionary<TKey, TValue>
                this_param, TKey
                key, out TValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 1584, 1623);
                    return return_v;
                }


                TValue
                f_951_1711_1723()
                {
                    var return_v = new TValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(951, 1711, 1723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(951, 1409, 1804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(951, 1409, 1804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PriorityOrderer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(951, 262, 1811);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(951, 262, 1811);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(951, 262, 1811);
        }


        static PriorityOrderer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(951, 262, 1811);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(951, 262, 1811);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(951, 262, 1811);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(951, 262, 1811);
    }
}
