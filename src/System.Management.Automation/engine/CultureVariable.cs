// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
    internal class PSCultureVariable : PSVariable
    {
        internal PSCultureVariable()
        : base(f_1260_445_471_C(SpecialVariables.PSCulture), true, ScopedItemOptions.ReadOnly | ScopedItemOptions.AllScope, f_1260_556_595())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1260, 396, 618);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1260, 396, 618);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1260, 396, 618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1260, 396, 618);
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1260, 783, 945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1260, 819, 847);

                    f_1260_819_846(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1260, 865, 930);

                    return f_1260_872_929(f_1260_872_924(f_1260_872_909()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1260, 783, 945);

                    int
                    f_1260_819_846(System.Management.Automation.PSCultureVariable
                    this_param)
                    {
                        this_param.DebuggerCheckVariableRead();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1260, 819, 846);
                        return 0;
                    }


                    System.Threading.Thread
                    f_1260_872_909()
                    {
                        var return_v = System.Threading.Thread.CurrentThread;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 872, 909);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1260_872_924(System.Threading.Thread
                    this_param)
                    {
                        var return_v = this_param.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 872, 924);
                        return return_v;
                    }


                    string
                    f_1260_872_929(System.Globalization.CultureInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 872, 929);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1260, 730, 956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1260, 730, 956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSCultureVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1260, 234, 963);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1260, 234, 963);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1260, 234, 963);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1260, 234, 963);

        static string
        f_1260_556_595()
        {
            var return_v = RunspaceInit.DollarPSCultureDescription;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 556, 595);
            return return_v;
        }


        static string
        f_1260_445_471_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1260, 396, 618);
            return return_v;
        }

    }
    internal class PSUICultureVariable : PSVariable
    {
        internal PSUICultureVariable()
        : base(f_1260_1275_1303_C(SpecialVariables.PSUICulture), true, ScopedItemOptions.ReadOnly | ScopedItemOptions.AllScope, f_1260_1388_1429())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1260, 1224, 1452);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1260, 1224, 1452);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1260, 1224, 1452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1260, 1224, 1452);
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1260, 1617, 1781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1260, 1653, 1681);

                    f_1260_1653_1680(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1260, 1699, 1766);

                    return f_1260_1706_1765(f_1260_1706_1760(f_1260_1706_1743()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1260, 1617, 1781);

                    int
                    f_1260_1653_1680(System.Management.Automation.PSUICultureVariable
                    this_param)
                    {
                        this_param.DebuggerCheckVariableRead();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1260, 1653, 1680);
                        return 0;
                    }


                    System.Threading.Thread
                    f_1260_1706_1743()
                    {
                        var return_v = System.Threading.Thread.CurrentThread;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 1706, 1743);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1260_1706_1760(System.Threading.Thread
                    this_param)
                    {
                        var return_v = this_param.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 1706, 1760);
                        return return_v;
                    }


                    string
                    f_1260_1706_1765(System.Globalization.CultureInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 1706, 1765);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1260, 1564, 1792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1260, 1564, 1792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSUICultureVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1260, 1060, 1799);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1260, 1060, 1799);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1260, 1060, 1799);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1260, 1060, 1799);

        static string
        f_1260_1388_1429()
        {
            var return_v = RunspaceInit.DollarPSUICultureDescription;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1260, 1388, 1429);
            return return_v;
        }


        static string
        f_1260_1275_1303_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1260, 1224, 1452);
            return return_v;
        }

    }
}
