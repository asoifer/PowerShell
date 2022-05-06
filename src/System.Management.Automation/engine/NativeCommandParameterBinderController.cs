// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

namespace System.Management.Automation
{
    internal class NativeCommandParameterBinderController : ParameterBinderController
    {
        internal NativeCommandParameterBinderController(NativeCommand command)
        : base(f_1300_888_908_C(f_1300_888_908(command)), f_1300_910_925(command), f_1300_927_968(command))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1300, 797, 991);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1300, 797, 991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1300, 797, 991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1300, 797, 991);
            }
        }

        internal string Arguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1300, 1183, 1306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1300, 1219, 1291);

                    return f_1300_1226_1290(((NativeCommandParameterBinder)f_1300_1257_1279()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1300, 1183, 1306);

                    System.Management.Automation.ParameterBinderBase
                    f_1300_1257_1279()
                    {
                        var return_v = DefaultParameterBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1300, 1257, 1279);
                        return return_v;
                    }


                    string
                    f_1300_1226_1290(System.Management.Automation.NativeCommandParameterBinder
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1300, 1226, 1290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1300, 1133, 1317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1300, 1133, 1317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool BindParameter(
                    CommandParameterInternal argument,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1300, 1861, 2124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1300, 2013, 2059);

                f_1300_2013_2058(false, "Unreachable code");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1300, 2075, 2113);

                throw f_1300_2081_2112();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1300, 1861, 2124);

                int
                f_1300_2013_2058(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1300, 2013, 2058);
                    return 0;
                }


                System.InvalidOperationException
                f_1300_2081_2112()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1300, 2081, 2112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1300, 1861, 2124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1300, 1861, 2124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Collection<CommandParameterInternal> BindParameters(Collection<CommandParameterInternal> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1300, 2526, 2940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1300, 2669, 2751);

                f_1300_2669_2750(((NativeCommandParameterBinder)f_1300_2700_2722()), parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1300, 2767, 2882);

                f_1300_2767_2881(f_1300_2786_2815(s_emptyReturnCollection) == 0, "This list shouldn't be used for anything as it's shared.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1300, 2898, 2929);

                return s_emptyReturnCollection;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1300, 2526, 2940);

                System.Management.Automation.ParameterBinderBase
                f_1300_2700_2722()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1300, 2700, 2722);
                    return return_v;
                }


                int
                f_1300_2669_2750(System.Management.Automation.NativeCommandParameterBinder
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                parameters)
                {
                    this_param.BindParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1300, 2669, 2750);
                    return 0;
                }


                int
                f_1300_2786_2815(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1300, 2786, 2815);
                    return return_v;
                }


                int
                f_1300_2767_2881(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1300, 2767, 2881);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1300, 2526, 2940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1300, 2526, 2940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Collection<CommandParameterInternal> s_emptyReturnCollection;

        static NativeCommandParameterBinderController()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1300, 377, 3089);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1300, 3013, 3081);
            s_emptyReturnCollection = f_1300_3039_3081();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1300, 377, 3089);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1300, 377, 3089);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1300, 377, 3089);

        static System.Management.Automation.InvocationInfo
        f_1300_888_908(System.Management.Automation.NativeCommand
        this_param)
        {
            var return_v = this_param.MyInvocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1300, 888, 908);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1300_910_925(System.Management.Automation.NativeCommand
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1300, 910, 925);
            return return_v;
        }


        static System.Management.Automation.NativeCommandParameterBinder
        f_1300_927_968(System.Management.Automation.NativeCommand
        command)
        {
            var return_v = new System.Management.Automation.NativeCommandParameterBinder(command);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1300, 927, 968);
            return return_v;
        }


        static System.Management.Automation.InvocationInfo
        f_1300_888_908_C(System.Management.Automation.InvocationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1300, 797, 991);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
        f_1300_3039_3081()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1300, 3039, 3081);
            return return_v;
        }

    }
}

