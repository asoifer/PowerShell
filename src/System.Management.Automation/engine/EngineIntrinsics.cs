// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public class EngineIntrinsics
    {
        private EngineIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1268, 573, 826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 3242, 3250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 3276, 3281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 3328, 3342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 624, 815);

                f_1268_624_814(false, "This constructor should never be called. Only the constructor that takes an instance of ExecutionContext should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1268, 573, 826);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1268, 573, 826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 573, 826);
            }
        }

        internal EngineIntrinsics(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1268, 1254, 1537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 3242, 3250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 3276, 3281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 3328, 3342);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 1330, 1441) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1268, 1330, 1441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 1383, 1426);

                    throw f_1268_1389_1425("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1268, 1330, 1441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 1457, 1476);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 1490, 1526);

                _host = f_1268_1498_1525(context);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1268, 1254, 1537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1268, 1254, 1537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 1254, 1537);
            }
        }

        public PSHost Host
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1268, 1758, 1995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 1794, 1947);

                    f_1268_1794_1946(_host != null, "The only constructor for this class should always set the host field");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 1967, 1980);

                    return _host;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1268, 1758, 1995);

                    int
                    f_1268_1794_1946(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1268, 1794, 1946);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1268, 1715, 2006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 1715, 2006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSEventManager Events
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1268, 2177, 2251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 2213, 2236);

                    return f_1268_2220_2235(_context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1268, 2177, 2251);

                    System.Management.Automation.PSLocalEventManager
                    f_1268_2220_2235(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.Events;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1268, 2220, 2235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1268, 2124, 2262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 2124, 2262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ProviderIntrinsics InvokeProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1268, 2441, 2542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 2477, 2527);

                    return f_1268_2484_2526(f_1268_2484_2511(_context));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1268, 2441, 2542);

                    System.Management.Automation.SessionStateInternal
                    f_1268_2484_2511(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1268, 2484, 2511);
                        return return_v;
                    }


                    System.Management.Automation.ProviderIntrinsics
                    f_1268_2484_2526(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.InvokeProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1268, 2484, 2526);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1268, 2376, 2553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 2376, 2553);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SessionState SessionState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1268, 2728, 2833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 2764, 2818);

                    return f_1268_2771_2817(f_1268_2771_2798(_context));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1268, 2728, 2833);

                    System.Management.Automation.SessionStateInternal
                    f_1268_2771_2798(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1268, 2771, 2798);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1268_2771_2817(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.PublicSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1268, 2771, 2817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1268, 2671, 2844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 2671, 2844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommandInvocationIntrinsics InvokeCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1268, 3031, 3125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1268, 3037, 3123);

                    return _invokeCommand ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandInvocationIntrinsics>(1268, 3044, 3122) ?? (_invokeCommand = f_1268_3080_3121(_context)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1268, 3031, 3125);

                    System.Management.Automation.CommandInvocationIntrinsics
                    f_1268_3080_3121(System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = new System.Management.Automation.CommandInvocationIntrinsics(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1268, 3080, 3121);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1268, 2958, 3136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 2958, 3136);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExecutionContext _context;

        private PSHost _host;

        private CommandInvocationIntrinsics _invokeCommand;

        static EngineIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1268, 349, 3383);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1268, 349, 3383);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1268, 349, 3383);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1268, 349, 3383);

        int
        f_1268_624_814(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1268, 624, 814);
            return 0;
        }


        System.ArgumentNullException
        f_1268_1389_1425(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1268, 1389, 1425);
            return return_v;
        }


        System.Management.Automation.Internal.Host.InternalHost
        f_1268_1498_1525(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineHostInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1268, 1498, 1525);
            return return_v;
        }

    }
}

