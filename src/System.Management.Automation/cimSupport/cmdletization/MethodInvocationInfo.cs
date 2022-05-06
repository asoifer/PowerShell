// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.PowerShell.Cmdletization
{
    public sealed class MethodInvocationInfo
    {
        public MethodInvocationInfo(string name, IEnumerable<MethodParameter> parameters, MethodParameter returnValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1062, 888, 1537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1639, 1672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1763, 1830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1989, 2032);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1023, 1081) || true) && (name == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 1023, 1081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1041, 1081);

                    throw f_1062_1047_1080("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 1023, 1081);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1095, 1165) || true) && (parameters == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 1095, 1165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1119, 1165);

                    throw f_1062_1125_1164("parameters");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 1095, 1165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1221, 1239);

                MethodName = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1253, 1279);

                ReturnValue = returnValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1295, 1375);

                KeyedCollection<string, MethodParameter>
                mpk = f_1062_1342_1374()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1389, 1493);
                    foreach (var parameter in f_1062_1415_1425_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 1389, 1493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1459, 1478);

                        f_1062_1459_1477(mpk, parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 1389, 1493);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1062, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1062, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 1509, 1526);

                Parameters = mpk;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1062, 888, 1537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1062, 888, 1537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1062, 888, 1537);
            }
        }

        public string MethodName { get; }

        public KeyedCollection<string, MethodParameter> Parameters { get; }

        public MethodParameter ReturnValue { get; }

        internal IEnumerable<T> GetArgumentsOfType<T>() where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1062, 2044, 3250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2132, 2163);

                List<T>
                result = f_1062_2149_2162()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2177, 3209);
                    foreach (var methodParameter in f_1062_2209_2224_I(f_1062_2209_2224(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 2177, 3209);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2258, 2417) || true) && (MethodParameterBindings.In != (f_1062_2293_2317(methodParameter) & MethodParameterBindings.In))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 2258, 2417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2389, 2398);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 2258, 2417);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2437, 2485);

                        var
                        objectInstance = f_1062_2458_2479(methodParameter) as T
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2503, 2648) || true) && (objectInstance != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 2503, 2648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2571, 2598);

                            f_1062_2571_2597(result, objectInstance);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2620, 2629);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 2503, 2648);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2668, 2731);

                        var
                        objectInstanceArray = f_1062_2694_2715(methodParameter) as IEnumerable
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2749, 3194) || true) && (objectInstanceArray != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 2749, 3194);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2822, 3142);
                                foreach (object element in f_1062_2849_2868_I(objectInstanceArray))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 2822, 3142);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2918, 2953);

                                    var
                                    objectInstance2 = element as T
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 2979, 3119) || true) && (objectInstance2 != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1062, 2979, 3119);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 3064, 3092);

                                        f_1062_3064_3091(result, objectInstance2);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 2979, 3119);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 2822, 3142);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1062, 1, 321);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1062, 1, 321);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 3166, 3175);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 2749, 3194);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1062, 2177, 3209);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1062, 1, 1033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1062, 1, 1033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1062, 3225, 3239);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1062, 2044, 3250);

                System.Collections.Generic.List<T>
                f_1062_2149_2162()

                {
                    var return_v = new System.Collections.Generic.List<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 2149, 2162);
                    return return_v;
                }


                System.Collections.ObjectModel.KeyedCollection<string, Microsoft.PowerShell.Cmdletization.MethodParameter>
                f_1062_2209_2224(Microsoft.PowerShell.Cmdletization.MethodInvocationInfo
                this_param) 

                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1062, 2209, 2224);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                f_1062_2293_2317(Microsoft.PowerShell.Cmdletization.MethodParameter
                this_param)

                {
                    var return_v = this_param.Bindings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1062, 2293, 2317);
                    return return_v;
                }


                object
                f_1062_2458_2479(Microsoft.PowerShell.Cmdletization.MethodParameter
                this_param)

                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1062, 2458, 2479);
                    return return_v;
                }


                int
                f_1062_2571_2597(System.Collections.Generic.List<T>
                this_param, T
                item)

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 2571, 2597);
                    return 0;
                }


                object
                f_1062_2694_2715(Microsoft.PowerShell.Cmdletization.MethodParameter
                this_param) 

                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1062, 2694, 2715);
                    return return_v;
                }


                int
                f_1062_3064_3091(System.Collections.Generic.List<T>
                this_param, T
                item)

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 3064, 3091);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1062_2849_2868_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 2849, 2868);
                    return return_v;
                }


                System.Collections.ObjectModel.KeyedCollection<string, Microsoft.PowerShell.Cmdletization.MethodParameter>
                f_1062_2209_2224_I(System.Collections.ObjectModel.KeyedCollection<string, Microsoft.PowerShell.Cmdletization.MethodParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 2209, 2224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1062, 2044, 3250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1062, 2044, 3250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodInvocationInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1062, 450, 3257);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1062, 450, 3257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1062, 450, 3257);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1062, 450, 3257);

        System.ArgumentNullException
        f_1062_1047_1080(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 1047, 1080);
            return return_v;
        }


        System.ArgumentNullException
        f_1062_1125_1164(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 1125, 1164);
            return return_v;
        }


        Microsoft.PowerShell.Cmdletization.MethodParametersCollection
        f_1062_1342_1374()
        {
            var return_v = new Microsoft.PowerShell.Cmdletization.MethodParametersCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 1342, 1374);
            return return_v;
        }


        int
        f_1062_1459_1477(System.Collections.ObjectModel.KeyedCollection<string, Microsoft.PowerShell.Cmdletization.MethodParameter>
        this_param, Microsoft.PowerShell.Cmdletization.MethodParameter
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 1459, 1477);
            return 0;
        }


        System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.MethodParameter>
        f_1062_1415_1425_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.MethodParameter>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1062, 1415, 1425);
            return return_v;
        }

    }
}
