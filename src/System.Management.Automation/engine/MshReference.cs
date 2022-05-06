// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Dynamic;
using System.Management.Automation.Language;
using System.Runtime.CompilerServices;

namespace System.Management.Automation
{
    public class PSReference
    {
        private object _value;

        public PSReference(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1295, 1146, 1229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 990, 996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 1203, 1218);

                _value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1295, 1146, 1229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1295, 1146, 1229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1295, 1146, 1229);
            }
        }

        public object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1295, 1596, 1847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 1632, 1675);

                    PSVariable
                    variable = _value as PSVariable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 1695, 1798) || true) && (variable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1295, 1695, 1798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 1757, 1779);

                        return f_1295_1764_1778(variable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1295, 1695, 1798);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 1818, 1832);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1295, 1596, 1847);

                    object
                    f_1295_1764_1778(System.Management.Automation.PSVariable
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1295, 1764, 1778);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1295, 1552, 2156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1295, 1552, 2156);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1295, 1863, 2145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 1899, 1942);

                    PSVariable
                    variable = _value as PSVariable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 1962, 2095) || true) && (variable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1295, 1962, 2095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 2024, 2047);

                        variable.Value = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 2069, 2076);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1295, 1962, 2095);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 2115, 2130);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1295, 1863, 2145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1295, 1552, 2156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1295, 1552, 2156);
                }
            }
        }

        internal static readonly CallSite<Func<CallSite, object, object, object>> CreatePsReferenceInstance;

        internal static PSReference CreateInstance(object value, Type typeOfValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1295, 2406, 2707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 2505, 2575);

                Type
                psReferType = f_1295_2524_2574(typeof(PSReference<>), typeOfValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 2589, 2696);

                // LAFHIS
                //return (PSReference)f_1295_2609_2695(CreatePsReferenceInstance.Target, CreatePsReferenceInstance, psReferType, value);
                var temp = (PSReference)CreatePsReferenceInstance.Target.Invoke(CreatePsReferenceInstance, psReferType, value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1295, 2609, 2695);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1295, 2406, 2707);

                System.Type
                f_1295_2524_2574(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1295, 2524, 2574);
                    return return_v;
                }


                object
                f_1295_2609_2695(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                arg1, System.Type
                arg2, object
                arg3)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (object)arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1295, 2609, 2695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1295, 2406, 2707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1295, 2406, 2707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1295, 934, 2714);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1295, 2242, 2393);
            CreatePsReferenceInstance = f_1295_2287_2393(f_1295_2343_2392(f_1295_2370_2385(1), null));
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1295, 934, 2714);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1295, 934, 2714);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1295, 934, 2714);

        static System.Dynamic.CallInfo
        f_1295_2370_2385(int
        argCount, params string[]
        argNames)
        {
            var return_v = new System.Dynamic.CallInfo(argCount, argNames);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1295, 2370, 2385);
            return return_v;
        }


        static System.Management.Automation.Language.PSCreateInstanceBinder
        f_1295_2343_2392(System.Dynamic.CallInfo
        callInfo, System.Management.Automation.PSMethodInvocationConstraints
        constraints)
        {
            var return_v = PSCreateInstanceBinder.Get(callInfo, constraints);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1295, 2343, 2392);
            return return_v;
        }


        static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
        f_1295_2287_2393(System.Management.Automation.Language.PSCreateInstanceBinder
        binder)
        {
            var return_v = CallSite<Func<CallSite, object, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1295, 2287, 2393);
            return return_v;
        }

    }
    internal class PSReference<T> : PSReference
    {
        public PSReference(object value) : base(f_1295_2822_2827_C(value))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1295, 2782, 2850);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1295, 2782, 2850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1295, 2782, 2850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1295, 2782, 2850);
            }
        }

        static object
        f_1295_2822_2827_C(object
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1295, 2782, 2850);
            return return_v;
        }

    }
}

