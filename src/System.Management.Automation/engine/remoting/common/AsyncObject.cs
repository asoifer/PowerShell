// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class AsyncObject<T> where T : class
    {
        private T _value;

        private ManualResetEvent _valueWasSet;

        internal T Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1616, 827, 1061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 863, 900);

                    bool
                    result = f_1616_877_899(_valueWasSet)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 918, 1012) || true) && (result == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1616, 918, 1012);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 979, 993);

                        _value = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1616, 918, 1012);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 1032, 1046);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1616, 827, 1061);

                    bool
                    f_1616_877_899(System.Threading.ManualResetEvent
                    this_param)
                    {
                        var return_v = this_param.WaitOne();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1616, 877, 899);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1616, 786, 1191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1616, 786, 1191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1616, 1077, 1180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 1113, 1128);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 1146, 1165);

                    f_1616_1146_1164(_valueWasSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1616, 1077, 1180);

                    bool
                    f_1616_1146_1164(System.Threading.ManualResetEvent
                    this_param)
                    {
                        var return_v = this_param.Set();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1616, 1146, 1164);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1616, 786, 1191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1616, 786, 1191);
                }
            }
        }

        internal AsyncObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1616, 1292, 1393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 575, 581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 694, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1616, 1339, 1382);

                _valueWasSet = f_1616_1354_1381(false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1616, 1292, 1393);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1616, 1292, 1393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1616, 1292, 1393);
            }
        }

        static AsyncObject()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1616, 436, 1400);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1616, 436, 1400);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1616, 436, 1400);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1616, 436, 1400);

        System.Threading.ManualResetEvent
        f_1616_1354_1381(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1616, 1354, 1381);
            return return_v;
        }

    }
}
