// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;

namespace System.Management.Automation.Tracing
{
    [AttributeUsage(AttributeTargets.Method)]
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
    [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public sealed class EtwEvent : Attribute
    {
        public EtwEvent(long eventId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1050, 827, 915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 996, 1024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 881, 904);

                this.EventId = eventId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1050, 827, 915);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 827, 915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 827, 915);
            }
        }

        public long EventId { get; }

        static EtwEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1050, 429, 1031);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1050, 429, 1031);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 429, 1031);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1050, 429, 1031);
    }

    /// <summary>
    /// Delegates that defines a call back with no parameter.
    /// </summary>
    public delegate void CallbackNoParameter();

    /// <summary>
    /// Delegates that defines a call back with one parameter (state)
    /// </summary>
    public delegate void CallbackWithState(object state);

    /// <summary>
    /// Delegates that defines a call back with two parameters; state and ElapsedEventArgs.
    /// It will be used in System.Timers.Timer scenarios.
    /// </summary>
    public delegate void CallbackWithStateAndArgs(object state, System.Timers.ElapsedEventArgs args);
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
    public class EtwEventArgs : EventArgs
    {
        public EventDescriptor Descriptor
        {
            get;
            private set;
        }

        public bool Success
        {
            get;
            private set;
        }

        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] Payload
        {
            get;
            private set;
        }

        public EtwEventArgs(EventDescriptor descriptor, bool success, object[] payload)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1050, 2800, 3018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 2125, 2210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 2282, 2465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 2904, 2933);

                this.Descriptor = descriptor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 2947, 2970);

                this.Payload = payload;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 2984, 3007);

                this.Success = success;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1050, 2800, 3018);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 2800, 3018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 2800, 3018);
            }
        }

        static EtwEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1050, 1734, 3025);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1050, 1734, 3025);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 1734, 3025);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1050, 1734, 3025);
    }
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
    public abstract class EtwActivity
    {
        private class CorrelatedCallback
        {
            private CallbackNoParameter callbackNoParam;

            private CallbackWithState callbackWithState;

            private AsyncCallback asyncCallback;

            protected readonly Guid parentActivityId;

            private readonly EtwActivity tracer;

            public CorrelatedCallback(EtwActivity tracer, CallbackNoParameter callback)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1050, 4126, 4676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3594, 3609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3650, 3667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3704, 3717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3908, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6362, 6386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4234, 4359) || true) && (callback == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 4234, 4359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4296, 4340);

                        throw f_1050_4302_4339("callback");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 4234, 4359);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4379, 4500) || true) && (tracer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 4379, 4500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4439, 4481);

                        throw f_1050_4445_4480("tracer");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 4379, 4500);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4520, 4541);

                    this.tracer = tracer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4559, 4611);

                    this.parentActivityId = f_1050_4583_4610();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4629, 4661);

                    this.callbackNoParam = callback;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1050, 4126, 4676);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 4126, 4676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 4126, 4676);
                }
            }

            public CorrelatedCallback(EtwActivity tracer, CallbackWithState callback)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1050, 4887, 5437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3594, 3609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3650, 3667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3704, 3717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3908, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6362, 6386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 4993, 5118) || true) && (callback == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 4993, 5118);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5055, 5099);

                        throw f_1050_5061_5098("callback");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 4993, 5118);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5138, 5259) || true) && (tracer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 5138, 5259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5198, 5240);

                        throw f_1050_5204_5239("tracer");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 5138, 5259);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5279, 5300);

                    this.tracer = tracer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5318, 5370);

                    this.parentActivityId = f_1050_5342_5369();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5388, 5422);

                    this.callbackWithState = callback;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1050, 4887, 5437);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 4887, 5437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 4887, 5437);
                }
            }

            public CorrelatedCallback(EtwActivity tracer, AsyncCallback callback)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1050, 5648, 6190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3594, 3609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3650, 3667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3704, 3717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3908, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6362, 6386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5750, 5875) || true) && (callback == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 5750, 5875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5812, 5856);

                        throw f_1050_5818_5855("callback");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 5750, 5875);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5895, 6016) || true) && (tracer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 5895, 6016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 5955, 5997);

                        throw f_1050_5961_5996("tracer");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 5895, 6016);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6036, 6057);

                    this.tracer = tracer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6075, 6127);

                    this.parentActivityId = f_1050_6099_6126();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6145, 6175);

                    this.asyncCallback = callback;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1050, 5648, 6190);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 5648, 6190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 5648, 6190);
                }
            }

            private CallbackWithStateAndArgs callbackWithStateAndArgs;

            public CorrelatedCallback(EtwActivity tracer, CallbackWithStateAndArgs callback)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1050, 6598, 7162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3594, 3609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3650, 3667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3704, 3717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 3908, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6362, 6386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6711, 6836) || true) && (callback == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 6711, 6836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6773, 6817);

                        throw f_1050_6779_6816("callback");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 6711, 6836);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6856, 6977) || true) && (tracer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 6856, 6977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6916, 6958);

                        throw f_1050_6922_6957("tracer");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 6856, 6977);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 6997, 7018);

                    this.tracer = tracer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 7036, 7088);

                    this.parentActivityId = f_1050_7060_7087();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 7106, 7147);

                    this.callbackWithStateAndArgs = callback;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1050, 6598, 7162);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 6598, 7162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 6598, 7162);
                }
            }

            public void Callback(object state, System.Timers.ElapsedEventArgs args)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 7294, 7614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 7398, 7506);

                    f_1050_7398_7505(callbackWithStateAndArgs != null, "callback is NULL.  There MUST always ba a valid callback!");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 7526, 7538);

                    f_1050_7526_7537(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 7556, 7599);

                    f_1050_7556_7598(this, state, args);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 7294, 7614);

                    int
                    f_1050_7398_7505(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 7398, 7505);
                        return 0;
                    }


                    int
                    f_1050_7526_7537(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param)
                    {
                        this_param.Correlate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 7526, 7537);
                        return 0;
                    }


                    int
                    f_1050_7556_7598(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param, object
                    state, System.Timers.ElapsedEventArgs
                    args)
                    {
                        this_param.callbackWithStateAndArgs(state, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 7556, 7598);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 7294, 7614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 7294, 7614);
                }
            }

            private void Correlate()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 7713, 7837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 7770, 7822);

                    f_1050_7770_7821(tracer, this.parentActivityId);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 7713, 7837);

                    int
                    f_1050_7770_7821(System.Management.Automation.Tracing.EtwActivity
                    this_param, System.Guid
                    parentActivityId)
                    {
                        this_param.CorrelateWithActivity(parentActivityId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 7770, 7821);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 7713, 7837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 7713, 7837);
                }
            }

            public void Callback()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 7969, 8210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8024, 8122);

                    f_1050_8024_8121(callbackNoParam != null, "callback is NULL.  There MUST always ba a valid callback");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8142, 8154);

                    f_1050_8142_8153(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8172, 8195);

                    f_1050_8172_8194(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 7969, 8210);

                    int
                    f_1050_8024_8121(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8024, 8121);
                        return 0;
                    }


                    int
                    f_1050_8142_8153(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param)
                    {
                        this_param.Correlate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8142, 8153);
                        return 0;
                    }


                    int
                    f_1050_8172_8194(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param)
                    {
                        this_param.callbackNoParam();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8172, 8194);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 7969, 8210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 7969, 8210);
                }
            }

            public void Callback(object state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 8342, 8605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8409, 8510);

                    f_1050_8409_8509(callbackWithState != null, "callback is NULL.  There MUST always ba a valid callback!");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8530, 8542);

                    f_1050_8530_8541(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8560, 8590);

                    f_1050_8560_8589(this, state);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 8342, 8605);

                    int
                    f_1050_8409_8509(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8409, 8509);
                        return 0;
                    }


                    int
                    f_1050_8530_8541(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param)
                    {
                        this_param.Correlate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8530, 8541);
                        return 0;
                    }


                    int
                    f_1050_8560_8589(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param, object
                    state)
                    {
                        this_param.callbackWithState(state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8560, 8589);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 8342, 8605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 8342, 8605);
                }
            }

            public void Callback(IAsyncResult asyncResult)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 8737, 9010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8816, 8913);

                    f_1050_8816_8912(asyncCallback != null, "callback is NULL.  There MUST always ba a valid callback!");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8933, 8945);

                    f_1050_8933_8944(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 8963, 8995);

                    f_1050_8963_8994(this, asyncResult);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 8737, 9010);

                    int
                    f_1050_8816_8912(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8816, 8912);
                        return 0;
                    }


                    int
                    f_1050_8933_8944(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param)
                    {
                        this_param.Correlate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8933, 8944);
                        return 0;
                    }


                    int
                    f_1050_8963_8994(System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                    this_param, System.IAsyncResult
                    ar)
                    {
                        this_param.asyncCallback(ar);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 8963, 8994);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 8737, 9010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 8737, 9010);
                }
            }

            static CorrelatedCallback()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1050, 3509, 9021);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1050, 3509, 9021);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 3509, 9021);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1050, 3509, 9021);

            System.ArgumentNullException
            f_1050_4302_4339(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 4302, 4339);
                return return_v;
            }


            System.ArgumentNullException
            f_1050_4445_4480(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 4445, 4480);
                return return_v;
            }


            System.Guid
            f_1050_4583_4610()
            {
                var return_v = EtwActivity.GetActivityId();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 4583, 4610);
                return return_v;
            }


            System.ArgumentNullException
            f_1050_5061_5098(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 5061, 5098);
                return return_v;
            }


            System.ArgumentNullException
            f_1050_5204_5239(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 5204, 5239);
                return return_v;
            }


            System.Guid
            f_1050_5342_5369()
            {
                var return_v = EtwActivity.GetActivityId();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 5342, 5369);
                return return_v;
            }


            System.ArgumentNullException
            f_1050_5818_5855(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 5818, 5855);
                return return_v;
            }


            System.ArgumentNullException
            f_1050_5961_5996(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 5961, 5996);
                return return_v;
            }


            System.Guid
            f_1050_6099_6126()
            {
                var return_v = EtwActivity.GetActivityId();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 6099, 6126);
                return return_v;
            }


            System.ArgumentNullException
            f_1050_6779_6816(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 6779, 6816);
                return return_v;
            }


            System.ArgumentNullException
            f_1050_6922_6957(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 6922, 6957);
                return return_v;
            }


            System.Guid
            f_1050_7060_7087()
            {
                var return_v = EtwActivity.GetActivityId();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 7060, 7087);
                return return_v;
            }

        }

        private static Dictionary<Guid, EventProvider> providers;

        private static object syncLock;

        private static EventDescriptor _WriteTransferEvent;

        private EventProvider currentProvider;

        /// <summary>
        /// Event handler for the class.
        /// </summary>
        public static event EventHandler<EtwEventArgs>
EventWritten
;

        public static bool SetActivityId(Guid activityId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1050, 9960, 10230);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10034, 10190) || true) && (f_1050_10038_10053() != activityId)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 10034, 10190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10101, 10145);

                    f_1050_10101_10144(ref activityId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10163, 10175);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 10034, 10190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10206, 10219);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1050, 9960, 10230);

                System.Guid
                f_1050_10038_10053()
                {
                    var return_v = GetActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 10038, 10053);
                    return return_v;
                }


                int
                f_1050_10101_10144(ref System.Guid
                id)
                {
                    EventProvider.SetActivityId(ref id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 10101, 10144);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 9960, 10230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 9960, 10230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Guid CreateActivityId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1050, 10409, 10522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10471, 10511);

                return f_1050_10478_10510();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1050, 10409, 10522);

                System.Guid
                f_1050_10478_10510()
                {
                    var return_v = EventProvider.CreateActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 10478, 10510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 10409, 10522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 10409, 10522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults")]
        public static Guid GetActivityId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1050, 10673, 11018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10813, 10842);

                Guid
                activityId = Guid.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10856, 10975);

                uint
                hresult = f_1050_10871_10974(UnsafeNativeMethods.ActivityControlCode.Get, ref activityId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 10989, 11007);

                return activityId;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1050, 10673, 11018);

                uint
                f_1050_10871_10974(System.Management.Automation.Tracing.EtwActivity.UnsafeNativeMethods.ActivityControlCode
                controlCode, ref System.Guid
                activityId)
                {
                    var return_v = UnsafeNativeMethods.EventActivityIdControl(controlCode, ref activityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 10871, 10974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 10673, 11018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 10673, 11018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected EtwActivity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1050, 11103, 11148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 9366, 9381);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1050, 11103, 11148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 11103, 11148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 11103, 11148);
            }
        }

        public void CorrelateWithActivity(Guid parentActivityId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 11404, 11951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11485, 11524);

                EventProvider
                provider = f_1050_11510_11523(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11538, 11589) || true) && (!f_1050_11543_11563(provider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 11538, 11589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11582, 11589);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 11538, 11589);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11605, 11642);

                Guid
                activityId = f_1050_11623_11641()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11656, 11682);

                f_1050_11656_11681(activityId);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11698, 11940) || true) && (parentActivityId != Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 11698, 11940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11766, 11812);

                    EventDescriptor
                    transferEvent = f_1050_11798_11811()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 11830, 11925);

                    f_1050_11830_11924(provider, ref transferEvent, parentActivityId, activityId, parentActivityId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 11698, 11940);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 11404, 11951);

                System.Diagnostics.Eventing.EventProvider
                f_1050_11510_11523(System.Management.Automation.Tracing.EtwActivity
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 11510, 11523);
                    return return_v;
                }


                bool
                f_1050_11543_11563(System.Diagnostics.Eventing.EventProvider
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 11543, 11563);
                    return return_v;
                }


                System.Guid
                f_1050_11623_11641()
                {
                    var return_v = CreateActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 11623, 11641);
                    return return_v;
                }


                bool
                f_1050_11656_11681(System.Guid
                activityId)
                {
                    var return_v = SetActivityId(activityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 11656, 11681);
                    return return_v;
                }


                System.Diagnostics.Eventing.EventDescriptor
                f_1050_11798_11811()
                {
                    var return_v = TransferEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1050, 11798, 11811);
                    return return_v;
                }


                bool
                f_1050_11830_11924(System.Diagnostics.Eventing.EventProvider
                this_param, ref System.Diagnostics.Eventing.EventDescriptor
                eventDescriptor, System.Guid
                relatedActivityId, params object[]
                eventPayload)
                {
                    var return_v = this_param.WriteTransferEvent(ref eventDescriptor, relatedActivityId, eventPayload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 11830, 11924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 11404, 11951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 11404, 11951);
            }
        }

        public bool IsEnabled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 12080, 12164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 12116, 12149);

                    return f_1050_12123_12148(f_1050_12123_12136(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 12080, 12164);

                    System.Diagnostics.Eventing.EventProvider
                    f_1050_12123_12136(System.Management.Automation.Tracing.EtwActivity
                    this_param)
                    {
                        var return_v = this_param.GetProvider();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 12123, 12136);
                        return return_v;
                    }


                    bool
                    f_1050_12123_12148(System.Diagnostics.Eventing.EventProvider
                    this_param)
                    {
                        var return_v = this_param.IsEnabled();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 12123, 12148);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 12034, 12175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 12034, 12175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsProviderEnabled(byte levels, long keywords)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 12524, 12666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 12606, 12655);

                return f_1050_12613_12654(f_1050_12613_12626(this), levels, keywords);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 12524, 12666);

                System.Diagnostics.Eventing.EventProvider
                f_1050_12613_12626(System.Management.Automation.Tracing.EtwActivity
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 12613, 12626);
                    return return_v;
                }


                bool
                f_1050_12613_12654(System.Diagnostics.Eventing.EventProvider
                this_param, byte
                level, long
                keywords)
                {
                    var return_v = this_param.IsEnabled(level, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 12613, 12654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 12524, 12666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 12524, 12666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Correlate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 12942, 13091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 12990, 13028);

                Guid
                parentActivity = f_1050_13012_13027()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 13042, 13080);

                f_1050_13042_13079(this, parentActivity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 12942, 13091);

                System.Guid
                f_1050_13012_13027()
                {
                    var return_v = GetActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 13012, 13027);
                    return return_v;
                }


                int
                f_1050_13042_13079(System.Management.Automation.Tracing.EtwActivity
                this_param, System.Guid
                parentActivityId)
                {
                    this_param.CorrelateWithActivity(parentActivityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 13042, 13079);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 12942, 13091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 12942, 13091);
            }
        }

        public CallbackNoParameter Correlate(CallbackNoParameter callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 13274, 13560);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 13365, 13478) || true) && (callback == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 13365, 13478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 13419, 13463);

                    throw f_1050_13425_13462("callback");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 13365, 13478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 13494, 13549);

                return f_1050_13501_13539(this, callback).Callback;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 13274, 13560);

                System.ArgumentNullException
                f_1050_13425_13462(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 13425, 13462);
                    return return_v;
                }


                System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                f_1050_13501_13539(System.Management.Automation.Tracing.EtwActivity
                tracer, System.Management.Automation.Tracing.CallbackNoParameter
                callback)
                {
                    var return_v = new System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback(tracer, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 13501, 13539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 13274, 13560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 13274, 13560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CallbackWithState Correlate(CallbackWithState callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 13750, 14032);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 13837, 13950) || true) && (callback == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 13837, 13950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 13891, 13935);

                    throw f_1050_13897_13934("callback");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 13837, 13950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 13966, 14021);

                return f_1050_13973_14011(this, callback).Callback;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 13750, 14032);

                System.ArgumentNullException
                f_1050_13897_13934(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 13897, 13934);
                    return return_v;
                }


                System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                f_1050_13973_14011(System.Management.Automation.Tracing.EtwActivity
                tracer, System.Management.Automation.Tracing.CallbackWithState
                callback)
                {
                    var return_v = new System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback(tracer, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 13973, 14011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 13750, 14032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 13750, 14032);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AsyncCallback Correlate(AsyncCallback callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 14229, 14503);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 14308, 14421) || true) && (callback == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 14308, 14421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 14362, 14406);

                    throw f_1050_14368_14405("callback");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 14308, 14421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 14437, 14492);

                return f_1050_14444_14482(this, callback).Callback;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 14229, 14503);

                System.ArgumentNullException
                f_1050_14368_14405(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 14368, 14405);
                    return return_v;
                }


                System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                f_1050_14444_14482(System.Management.Automation.Tracing.EtwActivity
                tracer, System.AsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback(tracer, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 14444, 14482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 14229, 14503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 14229, 14503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CallbackWithStateAndArgs Correlate(CallbackWithStateAndArgs callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 14796, 15092);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 14897, 15010) || true) && (callback == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 14897, 15010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 14951, 14995);

                    throw f_1050_14957_14994("callback");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 14897, 15010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 15026, 15081);

                return f_1050_15033_15071(this, callback).Callback;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 14796, 15092);

                System.ArgumentNullException
                f_1050_14957_14994(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 14957, 14994);
                    return return_v;
                }


                System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback
                f_1050_15033_15071(System.Management.Automation.Tracing.EtwActivity
                tracer, System.Management.Automation.Tracing.CallbackWithStateAndArgs
                callback)
                {
                    var return_v = new System.Management.Automation.Tracing.EtwActivity.CorrelatedCallback(tracer, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 15033, 15071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 14796, 15092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 14796, 15092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual Guid ProviderId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 15282, 15370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 15318, 15355);

                    return PSEtwLogProvider.ProviderGuid;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 15282, 15370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 15224, 15381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 15224, 15381);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual EventDescriptor TransferEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 15716, 15794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 15752, 15779);

                    return _WriteTransferEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 15716, 15794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 15644, 15805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 15644, 15805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void WriteEvent(EventDescriptor ed, params object[] payload)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 16130, 16868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16225, 16264);

                EventProvider
                provider = f_1050_16250_16263(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16280, 16331) || true) && (!f_1050_16285_16305(provider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 16280, 16331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16324, 16331);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 16280, 16331);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16347, 16636) || true) && (payload != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 16347, 16636);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16409, 16414);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16400, 16621) || true) && (i < f_1050_16420_16434(payload))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16436, 16439)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 16400, 16621))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 16400, 16621);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16481, 16602) || true) && (payload[i] == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 16481, 16602);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16553, 16579);

                                payload[i] = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 16481, 16602);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1050, 1, 222);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1050, 1, 222);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 16347, 16636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16652, 16704);

                bool
                success = f_1050_16667_16703(provider, ref ed, payload)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16718, 16857) || true) && (EventWritten != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 16718, 16857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16776, 16842);

                    f_1050_16776_16841(EventWritten, this, f_1050_16802_16840(ed, success, payload));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 16718, 16857);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 16130, 16868);

                System.Diagnostics.Eventing.EventProvider
                f_1050_16250_16263(System.Management.Automation.Tracing.EtwActivity
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 16250, 16263);
                    return return_v;
                }


                bool
                f_1050_16285_16305(System.Diagnostics.Eventing.EventProvider
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 16285, 16305);
                    return return_v;
                }


                int
                f_1050_16420_16434(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1050, 16420, 16434);
                    return return_v;
                }


                bool
                f_1050_16667_16703(System.Diagnostics.Eventing.EventProvider
                this_param, ref System.Diagnostics.Eventing.EventDescriptor
                eventDescriptor, params object[]
                eventPayload)
                {
                    var return_v = this_param.WriteEvent(ref eventDescriptor, eventPayload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 16667, 16703);
                    return return_v;
                }


                System.Management.Automation.Tracing.EtwEventArgs
                f_1050_16802_16840(System.Diagnostics.Eventing.EventDescriptor
                descriptor, bool
                success, object[]
                payload)
                {
                    var return_v = new System.Management.Automation.Tracing.EtwEventArgs(descriptor, success, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 16802, 16840);
                    return return_v;
                }


                int
                f_1050_16776_16841(System.EventHandler<System.Management.Automation.Tracing.EtwEventArgs>
                this_param, System.Management.Automation.Tracing.EtwActivity
                sender, System.Management.Automation.Tracing.EtwEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 16776, 16841);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 16130, 16868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 16130, 16868);
            }
        }

        private EventProvider GetProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1050, 16880, 17461);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16940, 17009) || true) && (currentProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 16940, 17009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 16986, 17009);

                    return currentProvider;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 16940, 17009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 17031, 17039);

                lock (syncLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 17073, 17146) || true) && (currentProvider != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 17073, 17146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 17123, 17146);

                        return currentProvider;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 17073, 17146);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 17166, 17396) || true) && (!f_1050_17171_17225(providers, f_1050_17193_17203(), out currentProvider))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1050, 17166, 17396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 17267, 17315);

                        currentProvider = f_1050_17285_17314(f_1050_17303_17313());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 17337, 17377);

                        providers[f_1050_17347_17357()] = currentProvider;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1050, 17166, 17396);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 17427, 17450);

                return currentProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1050, 16880, 17461);

                System.Guid
                f_1050_17193_17203()
                {
                    var return_v = ProviderId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1050, 17193, 17203);
                    return return_v;
                }


                bool
                f_1050_17171_17225(System.Collections.Generic.Dictionary<System.Guid, System.Diagnostics.Eventing.EventProvider>
                this_param, System.Guid
                key, out System.Diagnostics.Eventing.EventProvider
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 17171, 17225);
                    return return_v;
                }


                System.Guid
                f_1050_17303_17313()
                {
                    var return_v = ProviderId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1050, 17303, 17313);
                    return return_v;
                }


                System.Diagnostics.Eventing.EventProvider
                f_1050_17285_17314(System.Guid
                providerGuid)
                {
                    var return_v = new System.Diagnostics.Eventing.EventProvider(providerGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 17285, 17314);
                    return return_v;
                }


                System.Guid
                f_1050_17347_17357()
                {
                    var return_v = ProviderId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1050, 17347, 17357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1050, 16880, 17461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 16880, 17461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class UnsafeNativeMethods
        {
            internal enum ActivityControlCode : uint
            {
                /// <summary>
                /// Gets the ActivityId from thread local storage.
                /// </summary>
                Get = 1,

                /// <summary>
                /// Sets the ActivityId in the thread local storage.
                /// </summary>
                Set = 2,

                /// <summary>
                /// Creates a new activity id.
                /// </summary>
                Create = 3,

                /// <summary>
                /// Sets the activity id in thread local storage and returns the previous value.
                /// </summary>
                GetSet = 4,

                /// <summary>
                /// Creates a new activity id, sets thread local storage, and returns the previous value.
                /// </summary>
                CreateSet = 5
            }

            [DllImport(PinvokeDllNames.EventActivityIdControlDllName, ExactSpelling = true, EntryPoint = "EventActivityIdControl", CharSet = CharSet.Unicode)]
            internal static extern unsafe uint EventActivityIdControl([In] ActivityControlCode controlCode, [In][Out] ref Guid activityId);

            static UnsafeNativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1050, 17473, 19213);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1050, 17473, 19213);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 17473, 19213);
            }

        }

        static EtwActivity()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1050, 3173, 19220);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 9080, 9129);
            providers = f_1050_9092_9129();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 9162, 9185);
            syncLock = f_1050_9173_9185();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1050, 9229, 9331);
            _WriteTransferEvent = f_1050_9251_9331(0x1f05, 0x1, 0x11, 0x5, 0x14, 0x0, (long)0x4000000000000000);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1050, 3173, 19220);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1050, 3173, 19220);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1050, 3173, 19220);

        static System.Collections.Generic.Dictionary<System.Guid, System.Diagnostics.Eventing.EventProvider>
        f_1050_9092_9129()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Diagnostics.Eventing.EventProvider>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 9092, 9129);
            return return_v;
        }


        static object
        f_1050_9173_9185()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 9173, 9185);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1050_9251_9331(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1050, 9251, 9331);
            return return_v;
        }

    }
}

