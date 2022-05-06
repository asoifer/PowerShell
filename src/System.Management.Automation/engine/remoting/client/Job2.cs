// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

// Stops compiler from warning about unknown warnings
#pragma warning disable 1634, 1691

namespace System.Management.Automation
{
    public abstract class Job2 : Job
    {
        private List<CommandParameterCollection> _parameters;

        private readonly object _syncobject;

        private const int
        StartJobOperation = 1
        ;

        private const int
        StopJobOperation = 2
        ;

        private const int
        SuspendJobOperation = 3
        ;

        private const int
        ResumeJobOperation = 4
        ;

        private const int
        UnblockJobOperation = 5
        ;

        private readonly PowerShellTraceSource _tracer;

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        public List<CommandParameterCollection> StartParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 3635, 4006);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 3671, 3952) || true) && (_parameters == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 3671, 3952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 3742, 3753);
                        lock (_syncobject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 3803, 3910) || true) && (_parameters == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 3803, 3910);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 3857, 3910);

                                _parameters = f_1574_3871_3909();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 3803, 3910);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 3671, 3952);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 3972, 3991);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 3635, 4006);

                    System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
                    f_1574_3871_3909()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 3871, 3909);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 3381, 4334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 3381, 4334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 4022, 4323);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 4058, 4190) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 4058, 4190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 4117, 4171);

                        throw f_1574_4123_4170("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 4058, 4190);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 4216, 4227);

                    lock (_syncobject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 4269, 4289);

                        _parameters = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 4022, 4323);

                    System.Management.Automation.PSArgumentNullException
                    f_1574_4123_4170(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 4123, 4170);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 3381, 4334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 3381, 4334);
                }
            }
        }

        protected object SyncRoot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 4443, 4469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 4449, 4467);

                    return syncObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 4443, 4469);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 4393, 4480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 4393, 4480);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected Job2() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 4655, 4684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2417, 2428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2578, 2604);
                this._syncobject = f_1574_2592_2604();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2912, 2967);
                this._tracer = f_1574_2922_2967();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 4655, 4684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 4655, 4684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 4655, 4684);
            }
        }

        protected Job2(string command) : base(f_1574_4997_5004_C(command))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 4959, 5009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2417, 2428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2578, 2604);
                this._syncobject = f_1574_2592_2604();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2912, 2967);
                this._tracer = f_1574_2922_2967();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 4959, 5009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 4959, 5009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 4959, 5009);
            }
        }

        protected Job2(string command, string name)
        : base(f_1574_5333_5340_C(command), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 5269, 5369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2417, 2428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2578, 2604);
                this._syncobject = f_1574_2592_2604();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2912, 2967);
                this._tracer = f_1574_2922_2967();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 5269, 5369);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 5269, 5369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 5269, 5369);
            }
        }

        protected Job2(string command, string name, IList<Job> childJobs)
        : base(f_1574_5791_5798_C(command), name, childJobs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 5705, 5838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2417, 2428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2578, 2604);
                this._syncobject = f_1574_2592_2604();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2912, 2967);
                this._tracer = f_1574_2922_2967();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 5705, 5838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 5705, 5838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 5705, 5838);
            }
        }

        protected Job2(string command, string name, JobIdentifier token)
        : base(f_1574_6278_6285_C(command), name, token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 6193, 6321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2417, 2428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2578, 2604);
                this._syncobject = f_1574_2592_2604();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2912, 2967);
                this._tracer = f_1574_2922_2967();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 6193, 6321);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 6193, 6321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 6193, 6321);
            }
        }

        protected Job2(string command, string name, Guid instanceId)
        : base(f_1574_6738_6745_C(command), name, instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 6657, 6786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2417, 2428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2578, 2604);
                this._syncobject = f_1574_2592_2604();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2912, 2967);
                this._tracer = f_1574_2922_2967();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 6657, 6786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 6657, 6786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 6657, 6786);
            }
        }

        protected new void SetJobState(JobState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 7364, 7496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 7453, 7485);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetJobState(state, reason), 1574, 7453, 7484);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 7364, 7496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 7364, 7496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 7364, 7496);
            }
        }

        public abstract void StartJob();

        public abstract void StartJobAsync();

        /// <summary>
        /// Event to be raise when the start job activity is completed.
        /// This event should not be raised for
        /// synchronous operation.
        /// </summary>
        public event EventHandler<AsyncCompletedEventArgs>
StartJobCompleted
;

        protected virtual void OnStartJobCompleted(AsyncCompletedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 8968, 9133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 9070, 9122);

                f_1574_9070_9121(this, StartJobOperation, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 8968, 9133);

                int
                f_1574_9070_9121(System.Management.Automation.Job2
                this_param, int
                operation, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.RaiseCompletedHandler(operation, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 9070, 9121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 8968, 9133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 8968, 9133);
            }
        }

        protected virtual void OnStopJobCompleted(AsyncCompletedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 9467, 9630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 9568, 9619);

                f_1574_9568_9618(this, StopJobOperation, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 9467, 9630);

                int
                f_1574_9568_9618(System.Management.Automation.Job2
                this_param, int
                operation, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.RaiseCompletedHandler(operation, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 9568, 9618);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 9467, 9630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 9467, 9630);
            }
        }

        protected virtual void OnSuspendJobCompleted(AsyncCompletedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 9966, 10135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 10070, 10124);

                f_1574_10070_10123(this, SuspendJobOperation, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 9966, 10135);

                int
                f_1574_10070_10123(System.Management.Automation.Job2
                this_param, int
                operation, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.RaiseCompletedHandler(operation, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 10070, 10123);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 9966, 10135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 9966, 10135);
            }
        }

        protected virtual void OnResumeJobCompleted(AsyncCompletedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 10479, 10646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 10582, 10635);

                f_1574_10582_10634(this, ResumeJobOperation, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 10479, 10646);

                int
                f_1574_10582_10634(System.Management.Automation.Job2
                this_param, int
                operation, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.RaiseCompletedHandler(operation, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 10582, 10634);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 10479, 10646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 10479, 10646);
            }
        }

        protected virtual void OnUnblockJobCompleted(AsyncCompletedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 10990, 11159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 11094, 11148);

                f_1574_11094_11147(this, UnblockJobOperation, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 10990, 11159);

                int
                f_1574_11094_11147(System.Management.Automation.Job2
                this_param, int
                operation, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.RaiseCompletedHandler(operation, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 11094, 11147);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 10990, 11159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 10990, 11159);
            }
        }

        private void RaiseCompletedHandler(int operation, AsyncCompletedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 11485, 13509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 11819, 11872);

                EventHandler<AsyncCompletedEventArgs>
                handler = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 11888, 13027);

                switch (operation)
                {

                    case StartJobOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 11888, 13027);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 12011, 12039);

                            handler = StartJobCompleted;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 12086, 12092);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 11888, 13027);

                    case StopJobOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 11888, 13027);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 12181, 12208);

                            handler = StopJobCompleted;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 12255, 12261);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 11888, 13027);

                    case SuspendJobOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 11888, 13027);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 12353, 12383);

                            handler = SuspendJobCompleted;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 12430, 12436);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 11888, 13027);

                    case ResumeJobOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 11888, 13027);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 12527, 12556);

                            handler = ResumeJobCompleted;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 12603, 12609);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 11888, 13027);

                    case UnblockJobOperation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 11888, 13027);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 12701, 12731);

                            handler = UnblockJobCompleted;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 12778, 12784);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 11888, 13027);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 11888, 13027);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 12859, 12959);

                            f_1574_12859_12958(false, "this condition should not be hit, check the value of operation that you passed");
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 13006, 13012);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 11888, 13027);
                }
#pragma warning disable 56500
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 13108, 13213) || true) && (handler != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 13108, 13213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 13169, 13194);

                        f_1574_13169_13193(handler, this, eventArgs);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 13108, 13213);
                    }
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1574, 13242, 13467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 13418, 13452);

                    f_1574_13418_13451(                // errors in the handlers are not errors in the operation
                                                       // silently ignore them
                                    _tracer, exception);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1574, 13242, 13467);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 11485, 13509);

                int
                f_1574_12859_12958(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 12859, 12958);
                    return 0;
                }


                int
                f_1574_13169_13193(System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>
                this_param, System.Management.Automation.Job2
                sender, System.ComponentModel.AsyncCompletedEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 13169, 13193);
                    return 0;
                }


                bool
                f_1574_13418_13451(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 13418, 13451);
                    return return_v;
                }

#pragma warning restore 56500
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 11485, 13509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 11485, 13509);
            }
        }

        public abstract void StopJobAsync();

        /// <summary>
        /// Event to be raised when the asynchronous stopping of a job
        /// is completed.This event should not be raised for
        /// synchronous operation.
        /// </summary>
        public event EventHandler<AsyncCompletedEventArgs>
StopJobCompleted
;

        public abstract void SuspendJob();

        public abstract void SuspendJobAsync();

        /// <summary>
        /// This event should be raised whenever the asynchronous suspend of
        /// a job is completed. This event should not be raised for
        /// synchronous operation.
        /// </summary>
        public event EventHandler<AsyncCompletedEventArgs>
SuspendJobCompleted
;

        public abstract void ResumeJob();

        public abstract void ResumeJobAsync();

        /// <summary>
        /// This event should be raised whenever the asynchronous resume of
        /// a suspended job is completed. This event should not be raised for
        /// synchronous operation.
        /// </summary>
        public event EventHandler<AsyncCompletedEventArgs>
ResumeJobCompleted
;

        public abstract void UnblockJob();

        public abstract void UnblockJobAsync();

        public abstract void StopJob(bool force, string reason);

        public abstract void StopJobAsync(bool force, string reason);

        public abstract void SuspendJob(bool force, string reason);

        public abstract void SuspendJobAsync(bool force, string reason);

        /// <summary>
        /// This event should be raised whenever the asynchronous unblock
        /// of a blocked job is completed. This event should not be raised for
        /// synchronous operation.
        /// </summary>
        public event EventHandler<AsyncCompletedEventArgs>
UnblockJobCompleted
;

        static Job2()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1574, 2087, 16680);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2635, 2656);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2685, 2705);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2734, 2757);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2786, 2808);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 2837, 2860);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1574, 2087, 16680);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 2087, 16680);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1574, 2087, 16680);

        object
        f_1574_2592_2604()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 2592, 2604);
            return return_v;
        }


        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1574_2922_2967()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 2922, 2967);
            return return_v;
        }


        static string
        f_1574_4997_5004_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 4959, 5009);
            return return_v;
        }


        static string
        f_1574_5333_5340_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 5269, 5369);
            return return_v;
        }


        static string
        f_1574_5791_5798_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 5705, 5838);
            return return_v;
        }


        static string
        f_1574_6278_6285_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 6193, 6321);
            return return_v;
        }


        static string
        f_1574_6738_6745_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 6657, 6786);
            return return_v;
        }

    }

    /// <summary>
    /// Specifies the various thread options that can be used
    /// for the ThreadBasedJob.
    /// </summary>
    public enum JobThreadOptions
    {
        /// <summary>
        /// Use the default behavior, which is to use a
        /// ThreadPoolThread.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Use a thread pool thread.
        /// </summary>
        UseThreadPoolThread = 1,

        /// <summary>
        /// Create a new thread everything and reuse.
        /// </summary>
        UseNewThread = 2,
    }
    public sealed class ContainerParentJob : Job2
    {
        private const string
        TraceClassName = "ContainerParentJob"
        ;

        private bool _moreData;

        private readonly object _syncObject;

        private int _isDisposed;

        private const int
        DisposedTrue = 1
        ;

        private const int
        DisposedFalse = 0
        ;

        private int _finishedChildJobsCount;

        private int _blockedChildJobsCount;

        private int _suspendedChildJobsCount;

        private int _suspendingChildJobsCount;

        private int _failedChildJobsCount;

        private int _stoppedChildJobsCount;

        private readonly PowerShellTraceSource _tracer;

        private readonly PSDataCollection<ErrorRecord> _executionError;

        private PSEventManager _eventManager;

        internal PSEventManager EventManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 19518, 19547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19524, 19545);

                    return _eventManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 19518, 19547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 19457, 19732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 19457, 19732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 19563, 19721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19599, 19666);

                    f_1574_19599_19665(_tracer, "Setting event manager for Job ", f_1574_19654_19664());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19684, 19706);

                    _eventManager = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 19563, 19721);

                    System.Guid
                    f_1574_19654_19664()
                    {
                        var return_v = InstanceId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 19654, 19664);
                        return return_v;
                    }


                    bool
                    f_1574_19599_19665(System.Management.Automation.Tracing.PowerShellTraceSource
                    this_param, string
                    message, System.Guid
                    instanceId)
                    {
                        var return_v = this_param.WriteMessage(message, instanceId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 19599, 19665);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 19457, 19732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 19457, 19732);
                }
            }
        }

        private ManualResetEvent _jobRunning;

        private ManualResetEvent JobRunning
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 19851, 20529);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19887, 20475) || true) && (_jobRunning == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 19887, 20475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19958, 19969);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20019, 20433) || true) && (_jobRunning == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 20019, 20433);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20314, 20334);

                                f_1574_20314_20333(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20364, 20406);

                                _jobRunning = f_1574_20378_20405(false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 20019, 20433);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 19887, 20475);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20495, 20514);

                    return _jobRunning;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 19851, 20529);

                    int
                    f_1574_20314_20333(System.Management.Automation.ContainerParentJob
                    this_param)
                    {
                        this_param.AssertNotDisposed();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 20314, 20333);
                        return 0;
                    }


                    System.Threading.ManualResetEvent
                    f_1574_20378_20405(bool
                    initialState)
                    {
                        var return_v = new System.Threading.ManualResetEvent(initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 20378, 20405);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 19791, 20540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 19791, 20540);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ManualResetEvent _jobSuspendedOrAborted;

        private ManualResetEvent JobSuspendedOrAborted
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 20681, 21403);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20717, 21338) || true) && (_jobSuspendedOrAborted == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 20717, 21338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20799, 20810);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20860, 21296) || true) && (_jobSuspendedOrAborted == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 20860, 21296);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 21166, 21186);

                                f_1574_21166_21185(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 21216, 21269);

                                _jobSuspendedOrAborted = f_1574_21241_21268(false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 20860, 21296);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 20717, 21338);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 21358, 21388);

                    return _jobSuspendedOrAborted;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 20681, 21403);

                    int
                    f_1574_21166_21185(System.Management.Automation.ContainerParentJob
                    this_param)
                    {
                        this_param.AssertNotDisposed();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 21166, 21185);
                        return 0;
                    }


                    System.Threading.ManualResetEvent
                    f_1574_21241_21268(bool
                    initialState)
                    {
                        var return_v = new System.Threading.ManualResetEvent(initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 21241, 21268);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 20610, 21414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 20610, 21414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ContainerParentJob(string command, string name)
        : base(f_1574_21844_21851_C(command), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 21769, 21931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18230, 18246);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18281, 18307);
                this._syncObject = f_1574_18295_18307();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18330, 18345);
                this._isDisposed = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18597, 18624);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18709, 18735);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18822, 18850);
                this._suspendedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18938, 18967);
                this._suspendingChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19047, 19072);
                this._failedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19153, 19179);
                this._stoppedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19231, 19286);
                this._tracer = f_1574_19241_19286();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19344, 19397);
                this._executionError = f_1574_19362_19397();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19433, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19769, 19780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20577, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 21883, 21920);

                StateChanged += HandleMyStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 21769, 21931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 21769, 21931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 21769, 21931);
            }
        }

        public ContainerParentJob(string command)
        : base(f_1574_22202_22209_C(command))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 22140, 22283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18230, 18246);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18281, 18307);
                this._syncObject = f_1574_18295_18307();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18330, 18345);
                this._isDisposed = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18597, 18624);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18709, 18735);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18822, 18850);
                this._suspendedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18938, 18967);
                this._suspendingChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19047, 19072);
                this._failedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19153, 19179);
                this._stoppedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19231, 19286);
                this._tracer = f_1574_19241_19286();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19344, 19397);
                this._executionError = f_1574_19362_19397();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19433, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19769, 19780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20577, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 22235, 22272);

                StateChanged += HandleMyStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 22140, 22283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 22140, 22283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 22140, 22283);
            }
        }

        public ContainerParentJob(string command, string name, JobIdentifier jobId)
        : base(f_1574_22760_22767_C(command), name, jobId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 22664, 22854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18230, 18246);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18281, 18307);
                this._syncObject = f_1574_18295_18307();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18330, 18345);
                this._isDisposed = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18597, 18624);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18709, 18735);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18822, 18850);
                this._suspendedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18938, 18967);
                this._suspendingChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19047, 19072);
                this._failedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19153, 19179);
                this._stoppedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19231, 19286);
                this._tracer = f_1574_19241_19286();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19344, 19397);
                this._executionError = f_1574_19362_19397();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19433, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19769, 19780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20577, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 22806, 22843);

                StateChanged += HandleMyStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 22664, 22854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 22664, 22854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 22664, 22854);
            }
        }

        public ContainerParentJob(string command, string name, Guid instanceId)
        : base(f_1574_23325_23332_C(command), name, instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 23233, 23424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18230, 18246);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18281, 18307);
                this._syncObject = f_1574_18295_18307();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18330, 18345);
                this._isDisposed = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18597, 18624);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18709, 18735);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18822, 18850);
                this._suspendedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18938, 18967);
                this._suspendingChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19047, 19072);
                this._failedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19153, 19179);
                this._stoppedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19231, 19286);
                this._tracer = f_1574_19241_19286();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19344, 19397);
                this._executionError = f_1574_19362_19397();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19433, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19769, 19780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20577, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 23376, 23413);

                StateChanged += HandleMyStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 23233, 23424);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 23233, 23424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 23233, 23424);
            }
        }

        public ContainerParentJob(string command, string name, JobIdentifier jobId, string jobType)
        : base(f_1574_23975_23982_C(command), name, jobId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 23863, 24107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18230, 18246);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18281, 18307);
                this._syncObject = f_1574_18295_18307();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18330, 18345);
                this._isDisposed = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18597, 18624);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18709, 18735);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18822, 18850);
                this._suspendedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18938, 18967);
                this._suspendingChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19047, 19072);
                this._failedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19153, 19179);
                this._stoppedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19231, 19286);
                this._tracer = f_1574_19241_19286();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19344, 19397);
                this._executionError = f_1574_19362_19397();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19433, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19769, 19780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20577, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 24021, 24045);

                PSJobTypeName = jobType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 24059, 24096);

                StateChanged += HandleMyStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 23863, 24107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 23863, 24107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 23863, 24107);
            }
        }

        public ContainerParentJob(string command, string name, Guid instanceId, string jobType)
        : base(f_1574_24652_24659_C(command), name, instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 24544, 24789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18230, 18246);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18281, 18307);
                this._syncObject = f_1574_18295_18307();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18330, 18345);
                this._isDisposed = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18597, 18624);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18709, 18735);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18822, 18850);
                this._suspendedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18938, 18967);
                this._suspendingChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19047, 19072);
                this._failedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19153, 19179);
                this._stoppedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19231, 19286);
                this._tracer = f_1574_19241_19286();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19344, 19397);
                this._executionError = f_1574_19362_19397();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19433, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19769, 19780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20577, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 24703, 24727);

                PSJobTypeName = jobType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 24741, 24778);

                StateChanged += HandleMyStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 24544, 24789);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 24544, 24789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 24544, 24789);
            }
        }

        public ContainerParentJob(string command, string name, string jobType)
        : base(f_1574_25231_25238_C(command), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 25140, 25356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18230, 18246);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18281, 18307);
                this._syncObject = f_1574_18295_18307();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18330, 18345);
                this._isDisposed = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18597, 18624);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18709, 18735);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18822, 18850);
                this._suspendedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18938, 18967);
                this._suspendingChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19047, 19072);
                this._failedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19153, 19179);
                this._stoppedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19231, 19286);
                this._tracer = f_1574_19241_19286();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19344, 19397);
                this._executionError = f_1574_19362_19397();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19433, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 19769, 19780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 20577, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 25270, 25294);

                PSJobTypeName = jobType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 25308, 25345);

                StateChanged += HandleMyStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 25140, 25356);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 25140, 25356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 25140, 25356);
            }
        }

        internal PSDataCollection<ErrorRecord> ExecutionError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 25459, 25490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 25465, 25488);

                    return _executionError;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 25459, 25490);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 25403, 25492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 25403, 25492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void AddChildJob(Job2 childJob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 25895, 26949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 25958, 25978);

                f_1574_25958_25977(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 25992, 26105) || true) && (childJob == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 25992, 26105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26046, 26090);

                    throw f_1574_26052_26089("childJob");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 25992, 26105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26121, 26263);

                f_1574_26121_26262(
                            _tracer, TraceClassName, "AddChildJob", Guid.Empty, childJob, "Adding Child to Parent with InstanceId : ", f_1574_26240_26250().ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26279, 26310);

                JobStateInfo
                childJobStateInfo
                = default(JobStateInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26330, 26349);
                lock (childJob.syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26613, 26655);

                    childJobStateInfo = f_1574_26633_26654(childJob);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26673, 26762);

                    childJob.StateChanged += new EventHandler<JobStateEventArgs>(HandleChildJobStateChanged);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26793, 26817);

                f_1574_26793_26816(f_1574_26793_26802(), childJob);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 26831, 26938);

                f_1574_26831_26937(this, f_1574_26857_26936(childJobStateInfo, f_1574_26898_26935(JobState.NotStarted)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 25895, 26949);

                int
                f_1574_25958_25977(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 25958, 25977);
                    return 0;
                }


                System.ArgumentNullException
                f_1574_26052_26089(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 26052, 26089);
                    return return_v;
                }


                System.Guid
                f_1574_26240_26250()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 26240, 26250);
                    return return_v;
                }


                int
                f_1574_26121_26262(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job2
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 26121, 26262);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1574_26633_26654(System.Management.Automation.Job2
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 26633, 26654);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_26793_26802()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 26793, 26802);
                    return return_v;
                }


                int
                f_1574_26793_26816(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, System.Management.Automation.Job2
                item)
                {
                    this_param.Add((System.Management.Automation.Job)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 26793, 26816);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1574_26898_26935(System.Management.Automation.JobState
                state)
                {
                    var return_v = new System.Management.Automation.JobStateInfo(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 26898, 26935);
                    return return_v;
                }


                System.Management.Automation.JobStateEventArgs
                f_1574_26857_26936(System.Management.Automation.JobStateInfo
                jobStateInfo, System.Management.Automation.JobStateInfo
                previousJobStateInfo)
                {
                    var return_v = new System.Management.Automation.JobStateEventArgs(jobStateInfo, previousJobStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 26857, 26936);
                    return return_v;
                }


                int
                f_1574_26831_26937(System.Management.Automation.ContainerParentJob
                this_param, System.Management.Automation.JobStateEventArgs
                e)
                {
                    this_param.ParentJobStateCalculation(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 26831, 26937);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 25895, 26949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 25895, 26949);
            }
        }

        public override bool HasMoreData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 27235, 28031);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27443, 27979) || true) && (_moreData && (DynAbs.Tracing.TraceSender.Expression_True(1574, 27447, 27495) && f_1574_27460_27495(this, f_1574_27476_27494(f_1574_27476_27488()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 27443, 27979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27537, 27577);

                        bool
                        atleastOneChildHasMoreData = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27610, 27615);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27601, 27897) || true) && (i < f_1574_27621_27636(f_1574_27621_27630()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27638, 27641)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 27601, 27897))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 27601, 27897);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27691, 27874) || true) && (f_1574_27695_27719(f_1574_27695_27707(f_1574_27695_27704(), i)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 27691, 27874);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27777, 27811);

                                    atleastOneChildHasMoreData = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1574, 27841, 27847);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 27691, 27874);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 297);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 297);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27921, 27960);

                        _moreData = atleastOneChildHasMoreData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 27443, 27979);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 27999, 28016);

                    return _moreData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 27235, 28031);

                    System.Management.Automation.JobStateInfo
                    f_1574_27476_27488()
                    {
                        var return_v = JobStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 27476, 27488);
                        return return_v;
                    }


                    System.Management.Automation.JobState
                    f_1574_27476_27494(System.Management.Automation.JobStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 27476, 27494);
                        return return_v;
                    }


                    bool
                    f_1574_27460_27495(System.Management.Automation.ContainerParentJob
                    this_param, System.Management.Automation.JobState
                    state)
                    {
                        var return_v = this_param.IsFinishedState(state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 27460, 27495);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1574_27621_27630()
                    {
                        var return_v = ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 27621, 27630);
                        return return_v;
                    }


                    int
                    f_1574_27621_27636(System.Collections.Generic.IList<System.Management.Automation.Job>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 27621, 27636);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1574_27695_27704()
                    {
                        var return_v = ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 27695, 27704);
                        return return_v;
                    }


                    System.Management.Automation.Job
                    f_1574_27695_27707(System.Collections.Generic.IList<System.Management.Automation.Job>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 27695, 27707);
                        return return_v;
                    }


                    bool
                    f_1574_27695_27719(System.Management.Automation.Job
                    this_param)
                    {
                        var return_v = this_param.HasMoreData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 27695, 27719);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 27178, 28042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 27178, 28042);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string StatusMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 28213, 28296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 28249, 28281);

                    return f_1574_28256_28280(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 28213, 28296);

                    string
                    f_1574_28256_28280(System.Management.Automation.ContainerParentJob
                    this_param)
                    {
                        var return_v = this_param.ConstructStatusMessage();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 28256, 28280);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 28152, 28307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 28152, 28307);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void StartJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 28490, 33931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 28546, 28566);

                f_1574_28546_28565(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 28580, 28672);

                f_1574_28580_28671(_tracer, TraceClassName, "StartJob", Guid.Empty, this, "Entering method", null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 28686, 28750);

                f_1574_28686_28749(s_structuredTracer, f_1574_28738_28748());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 28877, 29055) || true) && (f_1574_28881_28896(f_1574_28881_28890()) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 28877, 29055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 28935, 29040);

                    throw f_1574_28941_29039(f_1574_28984_29038());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 28877, 29055);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29071, 29275);
                    foreach (Job2 job in f_1574_29092_29106_I(f_1574_29092_29106(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 29071, 29275);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29140, 29260) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 29140, 29260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29157, 29260);

                            throw f_1574_29163_29259(f_1574_29206_29258());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 29140, 29260);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 29071, 29275);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29512, 30841) || true) && (f_1574_29516_29531(f_1574_29516_29525()) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 29512, 30841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29570, 29604);

                    Job2
                    child = f_1574_29583_29595(f_1574_29583_29592(), 0) as Job2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29622, 29688);

                    f_1574_29622_29687(child != null, "Job is null after initial null check");
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29781, 29959);

                        f_1574_29781_29958(_tracer, TraceClassName, "StartJob", Guid.Empty, this, "Single child job synchronously, child InstanceId: {0}", child.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 29981, 29998);

                        f_1574_29981_29997(child);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 30020, 30041);

                        f_1574_30020_30040(f_1574_30020_30030());
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1574, 30078, 30770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 30338, 30501);

                        f_1574_30338_30500(f_1574_30338_30352(), f_1574_30357_30499(e, "ContainerParentJobStartError", ErrorCategory.InvalidResult, child));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 30523, 30703);

                        f_1574_30523_30702(_tracer, TraceClassName, "StartJob", Guid.Empty, this, "Single child job threw exception, child InstanceId: {0}", child.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 30725, 30751);

                        f_1574_30725_30750(_tracer, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1574, 30078, 30770);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 30819, 30826);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 29512, 30841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 30857, 30899);

                var
                completed = f_1574_30873_30898(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 30978, 31008);

                var
                startedChildJobsCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 31022, 32595);

                EventHandler<AsyncCompletedEventArgs>
                eventHandler = (object sender, AsyncCompletedEventArgs e) =>
                            {
                                var childJob = sender as Job2;
                                Dbg.Assert(childJob != null,
                                           "StartJobCompleted only available on Job2");
                                _tracer.WriteMessage(TraceClassName, "StartJob-Handler", Guid.Empty, this,
                                    "Finished starting child job asynchronously, child InstanceId: {0}", childJob.InstanceId.ToString());
                                if (e.Error != null)
                                {
                                    ExecutionError.Add(
                                        new ErrorRecord(e.Error,
                                                        "ContainerParentJobStartError",
                                                        ErrorCategory.InvalidResult,
                                                        childJob));
                                    _tracer.WriteMessage(TraceClassName, "StartJob-Handler", Guid.Empty, this,
                                        "Child job asynchronously had error, child InstanceId: {0}", childJob.InstanceId.ToString());
                                    _tracer.TraceException(e.Error);
                                }

                                Interlocked.Increment(ref startedChildJobsCount);
                                if (startedChildJobsCount == ChildJobs.Count)
                                {
                                    _tracer.WriteMessage(TraceClassName, "StartJob-Handler", Guid.Empty, this,
                                        "Finished starting all child jobs asynchronously", null);
                                    JobRunning.WaitOne();
                                    completed.Set();
                                }
                            }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 32611, 33268);
                    foreach (Job2 job in f_1574_32632_32641_I(f_1574_32632_32641()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 32611, 33268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 32675, 32739);

                        f_1574_32675_32738(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 32759, 32797);

                        job.StartJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 32815, 32981);

                        f_1574_32815_32980(_tracer, TraceClassName, "StartJob", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33155, 33215);

                        f_1574_33155_33214(job, false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33233, 33253);

                        f_1574_33233_33252(job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 32611, 33268);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33284, 33304);

                f_1574_33284_33303(
                            completed);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33318, 33519);
                    foreach (Job2 job in f_1574_33339_33348_I(f_1574_33339_33348()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 33318, 33519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33382, 33446);

                        f_1574_33382_33445(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33466, 33504);

                        job.StartJobCompleted -= eventHandler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 33318, 33519);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 202);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33829, 33920);

                f_1574_33829_33919(
                            /*
                            if (ExecutionError.Count > 0)
                            {
                                // Check to see expected behavior if one child job fails to start.
                            }

                            if (ExecutionError.Count == 1)
                            {
                                throw ExecutionError[0];
                            } */
                            _tracer, TraceClassName, "StartJob", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 28490, 33931);

                int
                f_1574_28546_28565(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 28546, 28565);
                    return 0;
                }


                int
                f_1574_28580_28671(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 28580, 28671);
                    return 0;
                }


                System.Guid
                f_1574_28738_28748()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 28738, 28748);
                    return return_v;
                }


                int
                f_1574_28686_28749(System.Management.Automation.Tracing.Tracer
                this_param, System.Guid
                containerParentJobInstanceId)
                {
                    this_param.BeginContainerParentJobExecution(containerParentJobInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 28686, 28749);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_28881_28890()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 28881, 28890);
                    return return_v;
                }


                int
                f_1574_28881_28896(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 28881, 28896);
                    return return_v;
                }


                string
                f_1574_28984_29038()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNoChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 28984, 29038);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_28941_29039(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 28941, 29039);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_29092_29106(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 29092, 29106);
                    return return_v;
                }


                string
                f_1574_29206_29258()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 29206, 29258);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_29163_29259(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 29163, 29259);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_29092_29106_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 29092, 29106);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_29516_29525()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 29516, 29525);
                    return return_v;
                }


                int
                f_1574_29516_29531(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 29516, 29531);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_29583_29592()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 29583, 29592);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1574_29583_29595(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 29583, 29595);
                    return return_v;
                }


                int
                f_1574_29622_29687(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 29622, 29687);
                    return 0;
                }


                int
                f_1574_29781_29958(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 29781, 29958);
                    return 0;
                }


                int
                f_1574_29981_29997(System.Management.Automation.Job2
                this_param)
                {
                    this_param.StartJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 29981, 29997);
                    return 0;
                }


                System.Threading.ManualResetEvent
                f_1574_30020_30030()
                {
                    var return_v = JobRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 30020, 30030);
                    return return_v;
                }


                bool
                f_1574_30020_30040(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 30020, 30040);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1574_30338_30352()
                {
                    var return_v = ExecutionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 30338, 30352);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1574_30357_30499(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job2
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 30357, 30499);
                    return return_v;
                }


                int
                f_1574_30338_30500(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 30338, 30500);
                    return 0;
                }


                int
                f_1574_30523_30702(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 30523, 30702);
                    return 0;
                }


                bool
                f_1574_30725_30750(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 30725, 30750);
                    return return_v;
                }


                System.Threading.AutoResetEvent
                f_1574_30873_30898(bool
                initialState)
                {
                    var return_v = new System.Threading.AutoResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 30873, 30898);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_32632_32641()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 32632, 32641);
                    return return_v;
                }


                int
                f_1574_32675_32738(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 32675, 32738);
                    return 0;
                }


                int
                f_1574_32815_32980(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 32815, 32980);
                    return 0;
                }


                int
                f_1574_33155_33214(System.Management.Automation.Job2
                debuggableJob, bool
                isAsync)
                {
                    ScriptDebugger.SetDebugJobAsync((System.Management.Automation.IJobDebugger)debuggableJob, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 33155, 33214);
                    return 0;
                }


                int
                f_1574_33233_33252(System.Management.Automation.Job2
                this_param)
                {
                    this_param.StartJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 33233, 33252);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_32632_32641_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 32632, 32641);
                    return return_v;
                }


                bool
                f_1574_33284_33303(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 33284, 33303);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_33339_33348()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 33339, 33348);
                    return return_v;
                }


                int
                f_1574_33382_33445(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 33382, 33445);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_33339_33348_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 33339, 33348);
                    return return_v;
                }


                int
                f_1574_33829_33919(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 33829, 33919);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 28490, 33931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 28490, 33931);
            }
        }

        private static Tracing.Tracer s_structuredTracer;

        public override void StartJobAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 34190, 37436);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34251, 34463) || true) && (_isDisposed == DisposedTrue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 34251, 34463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34316, 34423);

                    f_1574_34316_34422(this, f_1574_34336_34421(f_1574_34364_34407(TraceClassName), false, null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34441, 34448);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 34251, 34463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34479, 34576);

                f_1574_34479_34575(
                            _tracer, TraceClassName, "StartJobAsync", Guid.Empty, this, "Entering method", null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34590, 34654);

                f_1574_34590_34653(s_structuredTracer, f_1574_34642_34652());
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34668, 34872);
                    foreach (Job2 job in f_1574_34689_34703_I(f_1574_34689_34703(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 34668, 34872);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34737, 34857) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 34737, 34857);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34754, 34857);

                            throw f_1574_34760_34856(f_1574_34803_34855());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 34737, 34857);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 34668, 34872);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34953, 34983);

                var
                startedChildJobsCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 34997, 35055);

                EventHandler<AsyncCompletedEventArgs>
                eventHandler = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 35069, 36869);

                eventHandler = (sender, e) =>
                             {
                                 var childJob = sender as Job2;
                                 Dbg.Assert(childJob != null, "StartJobCompleted only available on Job2");
                                 _tracer.WriteMessage(TraceClassName, "StartJobAsync-Handler", Guid.Empty, this,
                                     "Finished starting child job asynchronously, child InstanceId: {0}", childJob.InstanceId.ToString());
                                 if (e.Error != null)
                                 {
                                     ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobStartAsyncError",
                                         ErrorCategory.InvalidResult, childJob));
                                     _tracer.WriteMessage(TraceClassName, "StartJobAsync-Handler", Guid.Empty, this,
                                        "Child job asynchronously had error, child InstanceId: {0}", childJob.InstanceId.ToString());
                                     _tracer.TraceException(e.Error);
                                 }

                                 Interlocked.Increment(ref startedChildJobsCount);
                                 Dbg.Assert(eventHandler != null, "Event handler magically disappeared");
                                 childJob.StartJobCompleted -= eventHandler;

                                 if (startedChildJobsCount == ChildJobs.Count)
                                 {
                                     _tracer.WriteMessage(TraceClassName, "StartJobAsync-Handler", Guid.Empty, this,
                                        "Finished starting all child jobs asynchronously", null);

                                     JobRunning.WaitOne();
                     // There may be multiple exceptions raised. They
                     // are stored in the Error stream of this job object, which is otherwise
                     // unused.
                     OnStartJobCompleted(new AsyncCompletedEventArgs(null, false, null));
                                 }
                             };
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 36885, 37313);
                    foreach (Job2 job in f_1574_36906_36915_I(f_1574_36906_36915()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 36885, 37313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 36949, 37013);

                        f_1574_36949_37012(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37031, 37069);

                        job.StartJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37089, 37260);

                        f_1574_37089_37259(
                                        _tracer, TraceClassName, "StartJobAsync", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37278, 37298);

                        f_1574_37278_37297(job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 36885, 37313);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37329, 37425);

                f_1574_37329_37424(
                            _tracer, TraceClassName, "StartJobAsync", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 34190, 37436);

                System.ObjectDisposedException
                f_1574_34364_34407(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 34364, 34407);
                    return return_v;
                }


                System.ComponentModel.AsyncCompletedEventArgs
                f_1574_34336_34421(System.ObjectDisposedException
                error, bool
                cancelled, object
                userState)
                {
                    var return_v = new System.ComponentModel.AsyncCompletedEventArgs((System.Exception)error, cancelled, userState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 34336, 34421);
                    return return_v;
                }


                int
                f_1574_34316_34422(System.Management.Automation.ContainerParentJob
                this_param, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.OnStartJobCompleted(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 34316, 34422);
                    return 0;
                }


                int
                f_1574_34479_34575(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 34479, 34575);
                    return 0;
                }


                System.Guid
                f_1574_34642_34652()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 34642, 34652);
                    return return_v;
                }


                int
                f_1574_34590_34653(System.Management.Automation.Tracing.Tracer
                this_param, System.Guid
                containerParentJobInstanceId)
                {
                    this_param.BeginContainerParentJobExecution(containerParentJobInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 34590, 34653);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_34689_34703(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 34689, 34703);
                    return return_v;
                }


                string
                f_1574_34803_34855()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 34803, 34855);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_34760_34856(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 34760, 34856);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_34689_34703_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 34689, 34703);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_36906_36915()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 36906, 36915);
                    return return_v;
                }


                int
                f_1574_36949_37012(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 36949, 37012);
                    return 0;
                }


                int
                f_1574_37089_37259(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 37089, 37259);
                    return 0;
                }


                int
                f_1574_37278_37297(System.Management.Automation.Job2
                this_param)
                {
                    this_param.StartJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 37278, 37297);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_36906_36915_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 36906, 36915);
                    return return_v;
                }


                int
                f_1574_37329_37424(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 37329, 37424);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 34190, 37436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 34190, 37436);
            }
        }

        public override void ResumeJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 37619, 43229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37676, 37696);

                f_1574_37676_37695(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37710, 37803);

                f_1574_37710_37802(_tracer, TraceClassName, "ResumeJob", Guid.Empty, this, "Entering method", null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37930, 38108) || true) && (f_1574_37934_37949(f_1574_37934_37943()) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 37930, 38108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 37988, 38093);

                    throw f_1574_37994_38092(f_1574_38037_38091());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 37930, 38108);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 38124, 38328);
                    foreach (Job2 job in f_1574_38145_38159_I(f_1574_38145_38159(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 38124, 38328);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 38193, 38313) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 38193, 38313);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 38210, 38313);

                            throw f_1574_38216_38312(f_1574_38259_38311());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 38193, 38313);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 38124, 38328);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 38565, 39898) || true) && (f_1574_38569_38584(f_1574_38569_38578()) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 38565, 39898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 38623, 38657);

                    Job2
                    child = f_1574_38636_38648(f_1574_38636_38645(), 0) as Job2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 38675, 38741);

                    f_1574_38675_38740(child != null, "Job is null after initial null check");
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 38834, 39013);

                        f_1574_38834_39012(_tracer, TraceClassName, "ResumeJob", Guid.Empty, this, "Single child job synchronously, child InstanceId: {0}", child.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 39035, 39053);

                        f_1574_39035_39052(child);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 39075, 39096);

                        f_1574_39075_39095(f_1574_39075_39085());
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1574, 39133, 39827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 39393, 39557);

                        f_1574_39393_39556(f_1574_39393_39407(), f_1574_39412_39555(e, "ContainerParentJobResumeError", ErrorCategory.InvalidResult, child));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 39579, 39760);

                        f_1574_39579_39759(_tracer, TraceClassName, "ResumeJob", Guid.Empty, this, "Single child job threw exception, child InstanceId: {0}", child.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 39782, 39808);

                        f_1574_39782_39807(_tracer, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1574, 39133, 39827);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 39876, 39883);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 38565, 39898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 39914, 39956);

                var
                completed = f_1574_39930_39955(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 40036, 40066);

                var
                resumedChildJobsCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 40080, 40138);

                EventHandler<AsyncCompletedEventArgs>
                eventHandler = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 40152, 42673);
                    foreach (Job2 job in f_1574_40173_40182_I(f_1574_40173_40182()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 40152, 42673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 40216, 40280);

                        f_1574_40216_40279(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 40300, 42377);

                        eventHandler = (object sender, AsyncCompletedEventArgs e) =>
                                                                    {
                                                                        var childJob = sender as Job2;
                                                                        Dbg.Assert(childJob != null, "ResumeJobCompleted only available on Job2");
                                                                        _tracer.WriteMessage(TraceClassName, "ResumeJob-Handler", Guid.Empty, this,
                                                                            "Finished resuming child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                                                                        if (e.Error != null)
                                                                        {
                                                                            ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobResumeError",
                                                                                ErrorCategory.InvalidResult, job));
                                                                            _tracer.WriteMessage(TraceClassName, "ResumeJob-Handler", Guid.Empty, this,
                                                                                "Child job asynchronously had error, child InstanceId: {0}", job.InstanceId.ToString());
                                                                            _tracer.TraceException(e.Error);
                                                                        }

                                                                        Interlocked.Increment(ref resumedChildJobsCount);
                                                                        if (resumedChildJobsCount == ChildJobs.Count)
                                                                        {
                                                                            _tracer.WriteMessage(TraceClassName, "ResumeJob-Handler", Guid.Empty, this,
                                                                                "Finished resuming all child jobs asynchronously", null);
                                                                            JobRunning.WaitOne();
                                                                            completed.Set();
                                                                        }
                                                                    };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42395, 42434);

                        job.ResumeJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42452, 42619);

                        f_1574_42452_42618(_tracer, TraceClassName, "ResumeJob", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42637, 42658);

                        f_1574_42637_42657(job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 40152, 42673);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 2522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 2522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42689, 42709);

                f_1574_42689_42708(
                            completed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42723, 42795);

                f_1574_42723_42794(eventHandler != null, "Event handler magically disappeared");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42809, 43011);
                    foreach (Job2 job in f_1574_42830_42839_I(f_1574_42830_42839()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 42809, 43011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42873, 42937);

                        f_1574_42873_42936(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 42957, 42996);

                        job.ResumeJobCompleted -= eventHandler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 42809, 43011);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43027, 43119);

                f_1574_43027_43118(
                            _tracer, TraceClassName, "ResumeJob", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 37619, 43229);

                int
                f_1574_37676_37695(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 37676, 37695);
                    return 0;
                }


                int
                f_1574_37710_37802(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 37710, 37802);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_37934_37943()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 37934, 37943);
                    return return_v;
                }


                int
                f_1574_37934_37949(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 37934, 37949);
                    return return_v;
                }


                string
                f_1574_38037_38091()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNoChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 38037, 38091);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_37994_38092(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 37994, 38092);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_38145_38159(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 38145, 38159);
                    return return_v;
                }


                string
                f_1574_38259_38311()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 38259, 38311);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_38216_38312(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 38216, 38312);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_38145_38159_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 38145, 38159);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_38569_38578()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 38569, 38578);
                    return return_v;
                }


                int
                f_1574_38569_38584(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 38569, 38584);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_38636_38645()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 38636, 38645);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1574_38636_38648(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 38636, 38648);
                    return return_v;
                }


                int
                f_1574_38675_38740(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 38675, 38740);
                    return 0;
                }


                int
                f_1574_38834_39012(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 38834, 39012);
                    return 0;
                }


                int
                f_1574_39035_39052(System.Management.Automation.Job2
                this_param)
                {
                    this_param.ResumeJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 39035, 39052);
                    return 0;
                }


                System.Threading.ManualResetEvent
                f_1574_39075_39085()
                {
                    var return_v = JobRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 39075, 39085);
                    return return_v;
                }


                bool
                f_1574_39075_39095(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 39075, 39095);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1574_39393_39407()
                {
                    var return_v = ExecutionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 39393, 39407);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1574_39412_39555(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job2
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 39412, 39555);
                    return return_v;
                }


                int
                f_1574_39393_39556(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 39393, 39556);
                    return 0;
                }


                int
                f_1574_39579_39759(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 39579, 39759);
                    return 0;
                }


                bool
                f_1574_39782_39807(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 39782, 39807);
                    return return_v;
                }


                System.Threading.AutoResetEvent
                f_1574_39930_39955(bool
                initialState)
                {
                    var return_v = new System.Threading.AutoResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 39930, 39955);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_40173_40182()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 40173, 40182);
                    return return_v;
                }


                int
                f_1574_40216_40279(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 40216, 40279);
                    return 0;
                }


                int
                f_1574_42452_42618(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 42452, 42618);
                    return 0;
                }


                int
                f_1574_42637_42657(System.Management.Automation.Job2
                this_param)
                {
                    this_param.ResumeJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 42637, 42657);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_40173_40182_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 40173, 40182);
                    return return_v;
                }


                bool
                f_1574_42689_42708(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 42689, 42708);
                    return return_v;
                }


                int
                f_1574_42723_42794(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 42723, 42794);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_42830_42839()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 42830, 42839);
                    return return_v;
                }


                int
                f_1574_42873_42936(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 42873, 42936);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_42830_42839_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 42830, 42839);
                    return return_v;
                }


                int
                f_1574_43027_43118(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 43027, 43118);
                    return 0;
                }


                // Errors are taken from the Error collection by the cmdlet for ContainerParentJob.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 37619, 43229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 37619, 43229);
            }
        }

        public override void ResumeJobAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 43333, 47236);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43395, 43608) || true) && (_isDisposed == DisposedTrue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 43395, 43608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43460, 43568);

                    f_1574_43460_43567(this, f_1574_43481_43566(f_1574_43509_43552(TraceClassName), false, null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43586, 43593);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 43395, 43608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43624, 43722);

                f_1574_43624_43721(
                            _tracer, TraceClassName, "ResumeJobAsync", Guid.Empty, this, "Entering method", null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43736, 43940);
                    foreach (Job2 job in f_1574_43757_43771_I(f_1574_43757_43771(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 43736, 43940);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43805, 43925) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 43805, 43925);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 43822, 43925);

                            throw f_1574_43828_43924(f_1574_43871_43923());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 43805, 43925);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 43736, 43940);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 44022, 44052);

                var
                resumedChildJobsCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 44066, 47112);
                    foreach (Job2 job in f_1574_44087_44096_I(f_1574_44087_44096()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 44066, 47112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 44130, 44194);

                        f_1574_44130_44193(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 44214, 44272);

                        EventHandler<AsyncCompletedEventArgs>
                        eventHandler = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 44290, 46811);

                        eventHandler = (sender, e) =>
                                                                {
                                                                    var childJob = sender as Job2;
                                                                    Dbg.Assert(childJob != null, "ResumeJobCompleted only available on Job2");
                                                                    _tracer.WriteMessage(TraceClassName, "ResumeJobAsync-Handler", Guid.Empty, this,
                                                                        "Finished resuming child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                                                                    if (e.Error != null)
                                                                    {
                                                                        ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobResumeAsyncError",
                                                                            ErrorCategory.InvalidResult, job));
                                                                        _tracer.WriteMessage(TraceClassName, "ResumeJobAsync-Handler", Guid.Empty, this,
                                                                            "Child job asynchronously had error, child InstanceId: {0}", job.InstanceId.ToString());
                                                                        _tracer.TraceException(e.Error);
                                                                    }

                                                                    Interlocked.Increment(ref resumedChildJobsCount);
                                                                    Dbg.Assert(eventHandler != null, "Event handler magically disappeared");
                                                                    childJob.ResumeJobCompleted -= eventHandler;
                                                                    if (resumedChildJobsCount == ChildJobs.Count)
                                                                    {
                                                                        _tracer.WriteMessage(TraceClassName, "ResumeJobAsync-Handler", Guid.Empty, this,
                                                                            "Finished resuming all child jobs asynchronously", null);

                                                                        JobRunning.WaitOne();
                                                // There may be multiple exceptions raised. They
                                                // are stored in the Error stream of this job object, which is otherwise
                                                // unused.
                                                OnResumeJobCompleted(new AsyncCompletedEventArgs(null, false, null));
                                                                    }
                                                                };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 46829, 46868);

                        job.ResumeJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 46886, 47058);

                        f_1574_46886_47057(_tracer, TraceClassName, "ResumeJobAsync", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 47076, 47097);

                        f_1574_47076_47096(job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 44066, 47112);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 3047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 3047);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 47128, 47225);

                f_1574_47128_47224(
                            _tracer, TraceClassName, "ResumeJobAsync", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 43333, 47236);

                System.ObjectDisposedException
                f_1574_43509_43552(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 43509, 43552);
                    return return_v;
                }


                System.ComponentModel.AsyncCompletedEventArgs
                f_1574_43481_43566(System.ObjectDisposedException
                error, bool
                cancelled, object
                userState)
                {
                    var return_v = new System.ComponentModel.AsyncCompletedEventArgs((System.Exception)error, cancelled, userState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 43481, 43566);
                    return return_v;
                }


                int
                f_1574_43460_43567(System.Management.Automation.ContainerParentJob
                this_param, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.OnResumeJobCompleted(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 43460, 43567);
                    return 0;
                }


                int
                f_1574_43624_43721(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 43624, 43721);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_43757_43771(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 43757, 43771);
                    return return_v;
                }


                string
                f_1574_43871_43923()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 43871, 43923);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_43828_43924(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 43828, 43924);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_43757_43771_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 43757, 43771);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_44087_44096()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 44087, 44096);
                    return return_v;
                }


                int
                f_1574_44130_44193(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 44130, 44193);
                    return 0;
                }


                int
                f_1574_46886_47057(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 46886, 47057);
                    return 0;
                }


                int
                f_1574_47076_47096(System.Management.Automation.Job2
                this_param)
                {
                    this_param.ResumeJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 47076, 47096);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_44087_44096_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 44087, 44096);
                    return return_v;
                }


                int
                f_1574_47128_47224(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 47128, 47224);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 43333, 47236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 43333, 47236);
            }
        }

        public override void SuspendJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 47421, 47521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 47479, 47510);

                f_1574_47479_47509(this, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 47421, 47521);

                int
                f_1574_47479_47509(System.Management.Automation.ContainerParentJob
                this_param, bool?
                force, string
                reason)
                {
                    this_param.SuspendJobInternal(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 47479, 47509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 47421, 47521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 47421, 47521);
            }
        }

        public override void SuspendJob(bool force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 47779, 47907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 47862, 47896);

                f_1574_47862_47895(this, force, reason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 47779, 47907);

                int
                f_1574_47862_47895(System.Management.Automation.ContainerParentJob
                this_param, bool
                force, string
                reason)
                {
                    this_param.SuspendJobInternal((bool?)force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 47862, 47895);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 47779, 47907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 47779, 47907);
            }
        }

        public override void SuspendJobAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 48092, 48202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 48155, 48191);

                f_1574_48155_48190(this, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 48092, 48202);

                int
                f_1574_48155_48190(System.Management.Automation.ContainerParentJob
                this_param, bool?
                force, string
                reason)
                {
                    this_param.SuspendJobAsyncInternal(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 48155, 48190);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 48092, 48202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 48092, 48202);
            }
        }

        public override void SuspendJobAsync(bool force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 48559, 48697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 48647, 48686);

                f_1574_48647_48685(this, force, reason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 48559, 48697);

                int
                f_1574_48647_48685(System.Management.Automation.ContainerParentJob
                this_param, bool
                force, string
                reason)
                {
                    this_param.SuspendJobAsyncInternal((bool?)force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 48647, 48685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 48559, 48697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 48559, 48697);
            }
        }

        public override void StopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 48790, 48884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 48845, 48873);

                f_1574_48845_48872(this, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 48790, 48884);

                int
                f_1574_48845_48872(System.Management.Automation.ContainerParentJob
                this_param, bool?
                force, string
                reason)
                {
                    this_param.StopJobInternal(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 48845, 48872);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 48790, 48884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 48790, 48884);
            }
        }

        public override void StopJobAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 49073, 49177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 49133, 49166);

                f_1574_49133_49165(this, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 49073, 49177);

                int
                f_1574_49133_49165(System.Management.Automation.ContainerParentJob
                this_param, bool?
                force, string
                reason)
                {
                    this_param.StopJobAsyncInternal(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 49133, 49165);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 49073, 49177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 49073, 49177);
            }
        }

        public override void StopJob(bool force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 49343, 49465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 49423, 49454);

                f_1574_49423_49453(this, force, reason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 49343, 49465);

                int
                f_1574_49423_49453(System.Management.Automation.ContainerParentJob
                this_param, bool
                force, string
                reason)
                {
                    this_param.StopJobInternal((bool?)force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 49423, 49453);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 49343, 49465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 49343, 49465);
            }
        }

        public override void StopJobAsync(bool force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 49636, 49768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 49721, 49757);

                f_1574_49721_49756(this, force, reason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 49636, 49768);

                int
                f_1574_49721_49756(System.Management.Automation.ContainerParentJob
                this_param, bool
                force, string
                reason)
                {
                    this_param.StopJobAsyncInternal((bool?)force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 49721, 49756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 49636, 49768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 49636, 49768);
            }
        }

        public override void UnblockJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 49958, 55361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50016, 50036);

                f_1574_50016_50035(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50050, 50144);

                f_1574_50050_50143(_tracer, TraceClassName, "UnblockJob", Guid.Empty, this, "Entering method", null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50271, 50449) || true) && (f_1574_50275_50290(f_1574_50275_50284()) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 50271, 50449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50329, 50434);

                    throw f_1574_50335_50433(f_1574_50378_50432());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 50271, 50449);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50465, 50669);
                    foreach (Job2 job in f_1574_50486_50500_I(f_1574_50486_50500(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 50465, 50669);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50534, 50654) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 50534, 50654);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50551, 50654);

                            throw f_1574_50557_50653(f_1574_50600_50652());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 50534, 50654);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 50465, 50669);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50906, 52169) || true) && (f_1574_50910_50925(f_1574_50910_50919()) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 50906, 52169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 50964, 50998);

                    Job2
                    child = f_1574_50977_50989(f_1574_50977_50986(), 0) as Job2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 51016, 51082);

                    f_1574_51016_51081(child != null, "Job is null after initial null check");
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 51175, 51355);

                        f_1574_51175_51354(_tracer, TraceClassName, "UnblockJob", Guid.Empty, this, "Single child job synchronously, child InstanceId: {0}", child.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 51377, 51396);

                        f_1574_51377_51395(child);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1574, 51433, 52098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 51693, 51827);

                        f_1574_51693_51826(f_1574_51693_51707(), f_1574_51712_51825(e, "ContainerParentJobUnblockError", ErrorCategory.InvalidResult, child));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 51849, 52031);

                        f_1574_51849_52030(_tracer, TraceClassName, "UnblockJob", Guid.Empty, this, "Single child job threw exception, child InstanceId: {0}", child.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52053, 52079);

                        f_1574_52053_52078(_tracer, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1574, 51433, 52098);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52147, 52154);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 50906, 52169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52185, 52227);

                var
                completed = f_1574_52201_52226(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52308, 52340);

                int
                unblockedChildJobsCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52354, 52412);

                EventHandler<AsyncCompletedEventArgs>
                eventHandler = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52426, 54803);
                    foreach (Job2 job in f_1574_52447_52456_I(f_1574_52447_52456()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 52426, 54803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52490, 52554);

                        f_1574_52490_52553(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 52574, 54504);

                        eventHandler = (object sender, AsyncCompletedEventArgs e) =>
                                                                {
                                                                    var childJob = sender as Job2;
                                                                    Dbg.Assert(childJob != null, "UnblockJobCompleted only available on Job2");
                                                                    _tracer.WriteMessage(TraceClassName, "UnblockJob-Handler", Guid.Empty, this,
                                                                        "Finished unblock child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                                                                    if (e.Error != null)
                                                                    {
                                                                        ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobUnblockError",
                                                                            ErrorCategory.InvalidResult, childJob));
                                                                        _tracer.WriteMessage(TraceClassName, "UnblockJob-Handler", Guid.Empty, this,
                                                                            "Child job asynchronously had error, child InstanceId: {0}", job.InstanceId.ToString());
                                                                        _tracer.TraceException(e.Error);
                                                                    }

                                                                    Interlocked.Increment(ref unblockedChildJobsCount);
                                                                    if (unblockedChildJobsCount == ChildJobs.Count)
                                                                    {
                                                                        _tracer.WriteMessage(TraceClassName, "UnblockJob-Handler", Guid.Empty, this,
                                                                            "Finished unblock all child jobs asynchronously", null);
                                                                        completed.Set();
                                                                    }
                                                                };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 54522, 54562);

                        job.UnblockJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 54580, 54748);

                        f_1574_54580_54747(_tracer, TraceClassName, "UnblockJob", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 54766, 54788);

                        f_1574_54766_54787(job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 52426, 54803);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 2378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 2378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 54819, 54839);

                f_1574_54819_54838(
                            completed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 54853, 54925);

                f_1574_54853_54924(eventHandler != null, "Event handler magically disappeared");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 54939, 55142);
                    foreach (Job2 job in f_1574_54960_54969_I(f_1574_54960_54969()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 54939, 55142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55003, 55067);

                        f_1574_55003_55066(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55087, 55127);

                        job.UnblockJobCompleted -= eventHandler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 54939, 55142);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55158, 55251);

                f_1574_55158_55250(
                            _tracer, TraceClassName, "UnblockJob", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 49958, 55361);

                int
                f_1574_50016_50035(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 50016, 50035);
                    return 0;
                }


                int
                f_1574_50050_50143(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 50050, 50143);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_50275_50284()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50275, 50284);
                    return return_v;
                }


                int
                f_1574_50275_50290(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50275, 50290);
                    return return_v;
                }


                string
                f_1574_50378_50432()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNoChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50378, 50432);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_50335_50433(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 50335, 50433);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_50486_50500(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50486, 50500);
                    return return_v;
                }


                string
                f_1574_50600_50652()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50600, 50652);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_50557_50653(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 50557, 50653);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_50486_50500_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 50486, 50500);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_50910_50919()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50910, 50919);
                    return return_v;
                }


                int
                f_1574_50910_50925(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50910, 50925);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_50977_50986()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50977, 50986);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1574_50977_50989(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 50977, 50989);
                    return return_v;
                }


                int
                f_1574_51016_51081(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 51016, 51081);
                    return 0;
                }


                int
                f_1574_51175_51354(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 51175, 51354);
                    return 0;
                }


                int
                f_1574_51377_51395(System.Management.Automation.Job2
                this_param)
                {
                    this_param.UnblockJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 51377, 51395);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1574_51693_51707()
                {
                    var return_v = ExecutionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 51693, 51707);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1574_51712_51825(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job2
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 51712, 51825);
                    return return_v;
                }


                int
                f_1574_51693_51826(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 51693, 51826);
                    return 0;
                }


                int
                f_1574_51849_52030(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 51849, 52030);
                    return 0;
                }


                bool
                f_1574_52053_52078(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 52053, 52078);
                    return return_v;
                }


                System.Threading.AutoResetEvent
                f_1574_52201_52226(bool
                initialState)
                {
                    var return_v = new System.Threading.AutoResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 52201, 52226);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_52447_52456()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 52447, 52456);
                    return return_v;
                }


                int
                f_1574_52490_52553(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 52490, 52553);
                    return 0;
                }


                int
                f_1574_54580_54747(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 54580, 54747);
                    return 0;
                }


                int
                f_1574_54766_54787(System.Management.Automation.Job2
                this_param)
                {
                    this_param.UnblockJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 54766, 54787);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_52447_52456_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 52447, 52456);
                    return return_v;
                }


                bool
                f_1574_54819_54838(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 54819, 54838);
                    return return_v;
                }


                int
                f_1574_54853_54924(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 54853, 54924);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_54960_54969()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 54960, 54969);
                    return return_v;
                }


                int
                f_1574_55003_55066(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 55003, 55066);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_54960_54969_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 54960, 54969);
                    return return_v;
                }


                int
                f_1574_55158_55250(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 55158, 55250);
                    return 0;
                }


                // Errors are taken from the Error collection by the cmdlet for ContainerParentJob.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 49958, 55361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 49958, 55361);
            }
        }

        public override void UnblockJobAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 55557, 59495);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55620, 55834) || true) && (_isDisposed == DisposedTrue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 55620, 55834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55685, 55794);

                    f_1574_55685_55793(this, f_1574_55707_55792(f_1574_55735_55778(TraceClassName), false, null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55812, 55819);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 55620, 55834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55850, 55949);

                f_1574_55850_55948(
                            _tracer, TraceClassName, "UnblockJobAsync", Guid.Empty, this, "Entering method", null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 55963, 56167);
                    foreach (Job2 job in f_1574_55984_55998_I(f_1574_55984_55998(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 55963, 56167);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 56032, 56152) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 56032, 56152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 56049, 56152);

                            throw f_1574_56055_56151(f_1574_56098_56150());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 56032, 56152);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 55963, 56167);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 56250, 56282);

                int
                unblockedChildJobsCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 56296, 59370);
                    foreach (Job2 job in f_1574_56317_56326_I(f_1574_56317_56326()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 56296, 59370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 56360, 56424);

                        f_1574_56360_56423(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 56444, 56502);

                        EventHandler<AsyncCompletedEventArgs>
                        eventHandler = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 56520, 59066);

                        eventHandler = (sender, e) =>
                                                                {
                                                                    var childJob = sender as Job2;
                                                                    Dbg.Assert(childJob != null, "UnblockJobCompleted only available on Job2");
                                                                    _tracer.WriteMessage(TraceClassName, "UnblockJobAsync-Handler", Guid.Empty, this,
                                                                        "Finished unblock child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                                                                    if (e.Error != null)
                                                                    {
                                                                        ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobUnblockError",
                                                                            ErrorCategory.InvalidResult, childJob));
                                                                        _tracer.WriteMessage(TraceClassName, "UnblockJobAsync-Handler", Guid.Empty, this,
                                                                            "Child job asynchronously had error, child InstanceId: {0}", job.InstanceId.ToString());
                                                                        _tracer.TraceException(e.Error);
                                                                    }

                                                                    Interlocked.Increment(ref unblockedChildJobsCount);
                                                                    Dbg.Assert(eventHandler != null, "Event handler magically disappeared");
                                                                    childJob.UnblockJobCompleted -= eventHandler;
                                                                    if (unblockedChildJobsCount == ChildJobs.Count)
                                                                    {
                                                                        _tracer.WriteMessage(TraceClassName, "UnblockJobAsync-Handler", Guid.Empty, this,
                                                                            "Finished unblock all child jobs asynchronously", null);

                                                // State change is handled elsewhere.
                                                // There may be multiple exceptions raised. They
                                                // are stored in the Error stream of this job object, which is otherwise
                                                // unused.
                                                OnUnblockJobCompleted(new AsyncCompletedEventArgs(null, false, null));
                                                                    }
                                                                };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 59084, 59124);

                        job.UnblockJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 59142, 59315);

                        f_1574_59142_59314(_tracer, TraceClassName, "UnblockJobAsync", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 59333, 59355);

                        f_1574_59333_59354(job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 56296, 59370);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 3075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 3075);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 59386, 59484);

                f_1574_59386_59483(
                            _tracer, TraceClassName, "UnblockJobAsync", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 55557, 59495);

                System.ObjectDisposedException
                f_1574_55735_55778(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 55735, 55778);
                    return return_v;
                }


                System.ComponentModel.AsyncCompletedEventArgs
                f_1574_55707_55792(System.ObjectDisposedException
                error, bool
                cancelled, object
                userState)
                {
                    var return_v = new System.ComponentModel.AsyncCompletedEventArgs((System.Exception)error, cancelled, userState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 55707, 55792);
                    return return_v;
                }


                int
                f_1574_55685_55793(System.Management.Automation.ContainerParentJob
                this_param, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.OnUnblockJobCompleted(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 55685, 55793);
                    return 0;
                }


                int
                f_1574_55850_55948(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 55850, 55948);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_55984_55998(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 55984, 55998);
                    return return_v;
                }


                string
                f_1574_56098_56150()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 56098, 56150);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_56055_56151(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 56055, 56151);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_55984_55998_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 55984, 55998);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_56317_56326()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 56317, 56326);
                    return return_v;
                }


                int
                f_1574_56360_56423(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 56360, 56423);
                    return 0;
                }


                int
                f_1574_59142_59314(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 59142, 59314);
                    return 0;
                }


                int
                f_1574_59333_59354(System.Management.Automation.Job2
                this_param)
                {
                    this_param.UnblockJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 59333, 59354);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_56317_56326_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 56317, 56326);
                    return return_v;
                }


                int
                f_1574_59386_59483(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 59386, 59483);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 55557, 59495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 55557, 59495);
            }
        }

        private void SuspendJobInternal(bool? force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 59803, 65272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 59887, 59907);

                f_1574_59887_59906(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 59921, 60015);

                f_1574_59921_60014(_tracer, TraceClassName, "SuspendJob", Guid.Empty, this, "Entering method", null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60142, 60320) || true) && (f_1574_60146_60161(f_1574_60146_60155()) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 60142, 60320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60200, 60305);

                    throw f_1574_60206_60304(f_1574_60249_60303());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 60142, 60320);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60336, 60540);
                    foreach (Job2 job in f_1574_60357_60371_I(f_1574_60357_60371(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 60336, 60540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60405, 60525) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 60405, 60525);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60422, 60525);

                            throw f_1574_60428_60524(f_1574_60471_60523());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 60405, 60525);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 60336, 60540);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60777, 62335) || true) && (f_1574_60781_60796(f_1574_60781_60790()) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 60777, 62335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60835, 60869);

                    Job2
                    child = f_1574_60848_60860(f_1574_60848_60857(), 0) as Job2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 60887, 60953);

                    f_1574_60887_60952(child != null, "Job is null after initial null check");
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 61046, 61272);

                        f_1574_61046_61271(_tracer, TraceClassName, "SuspendJob", Guid.Empty, this, "Single child job synchronously, child InstanceId: {0} force: {1}", child.InstanceId.ToString(), f_1574_61254_61270(force));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 61294, 61448) || true) && (f_1574_61298_61312(force))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 61294, 61448);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 61339, 61377);

                            f_1574_61339_61376(child, f_1574_61356_61367(force), reason);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 61294, 61448);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 61294, 61448);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 61429, 61448);

                            f_1574_61429_61447(child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 61294, 61448);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 61470, 61502);

                        f_1574_61470_61501(f_1574_61470_61491());
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1574, 61539, 62264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 61799, 61964);

                        f_1574_61799_61963(f_1574_61799_61813(), f_1574_61818_61962(e, "ContainerParentJobSuspendError", ErrorCategory.InvalidResult, child));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 61986, 62197);

                        f_1574_61986_62196(_tracer, TraceClassName, "SuspendJob", Guid.Empty, this, "Single child job threw exception, child InstanceId: {0} force: {1}", child.InstanceId.ToString(), f_1574_62179_62195(force));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62219, 62245);

                        f_1574_62219_62244(_tracer, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1574, 61539, 62264);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62313, 62320);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 60777, 62335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62351, 62404);

                AutoResetEvent
                completed = f_1574_62378_62403(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62418, 62450);

                var
                suspendedChildJobsCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62464, 62522);

                EventHandler<AsyncCompletedEventArgs>
                eventHandler = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62536, 64714);
                    foreach (Job2 job in f_1574_62557_62566_I(f_1574_62557_62566()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 62536, 64714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62600, 62664);

                        f_1574_62600_62663(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 62684, 64260);

                        eventHandler = (object sender, AsyncCompletedEventArgs e) =>
                                        {
                                            var childJob = sender as Job2;
                                            Dbg.Assert(childJob != null,
                                                        "SuspendJobCompleted only available on Job2");
                                            _tracer.WriteMessage(TraceClassName, "SuspendJob-Handler", Guid.Empty, this,
                                                "Finished suspending child job asynchronously, child InstanceId: {0} force: {1}", job.InstanceId.ToString(), force.ToString());
                                            if (e.Error != null)
                                            {
                                                ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobSuspendError",
                                                    ErrorCategory.InvalidResult, job));
                                                _tracer.WriteMessage(TraceClassName, "SuspendJob-Handler", Guid.Empty, this,
                                                    "Child job asynchronously had error, child InstanceId: {0} force: {1}", job.InstanceId.ToString(), force.ToString());
                                                _tracer.TraceException(e.Error);
                                            }

                                            Interlocked.Increment(ref suspendedChildJobsCount);
                                            if (suspendedChildJobsCount == ChildJobs.Count)
                                            {
                                                _tracer.WriteMessage(TraceClassName, "SuspendJob-Handler", Guid.Empty, this,
                                                    "Finished suspending all child jobs asynchronously", null);
                                                JobSuspendedOrAborted.WaitOne();
                                                completed.Set();
                                            }
                                        };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64278, 64318);

                        job.SuspendJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64336, 64533);

                        f_1574_64336_64532(_tracer, TraceClassName, "SuspendJob", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0} force: {1}", job.InstanceId.ToString(), f_1574_64515_64531(force));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64551, 64699) || true) && (f_1574_64555_64569(force))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 64551, 64699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64592, 64633);

                            f_1574_64592_64632(job, f_1574_64612_64623(force), reason);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 64551, 64699);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 64551, 64699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64677, 64699);

                            f_1574_64677_64698(job);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 64551, 64699);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 62536, 64714);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 2179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 2179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64730, 64750);

                f_1574_64730_64749(
                            completed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64764, 64836);

                f_1574_64764_64835(eventHandler != null, "Event handler magically disappeared");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64850, 65053);
                    foreach (Job2 job in f_1574_64871_64880_I(f_1574_64871_64880()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 64850, 65053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64914, 64978);

                        f_1574_64914_64977(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 64998, 65038);

                        job.SuspendJobCompleted -= eventHandler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 64850, 65053);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 65069, 65162);

                f_1574_65069_65161(
                            _tracer, TraceClassName, "SuspendJob", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 59803, 65272);

                int
                f_1574_59887_59906(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 59887, 59906);
                    return 0;
                }


                int
                f_1574_59921_60014(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 59921, 60014);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_60146_60155()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60146, 60155);
                    return return_v;
                }


                int
                f_1574_60146_60161(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60146, 60161);
                    return return_v;
                }


                string
                f_1574_60249_60303()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNoChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60249, 60303);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_60206_60304(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 60206, 60304);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_60357_60371(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60357, 60371);
                    return return_v;
                }


                string
                f_1574_60471_60523()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60471, 60523);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_60428_60524(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 60428, 60524);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_60357_60371_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 60357, 60371);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_60781_60790()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60781, 60790);
                    return return_v;
                }


                int
                f_1574_60781_60796(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60781, 60796);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_60848_60857()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60848, 60857);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1574_60848_60860(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 60848, 60860);
                    return return_v;
                }


                int
                f_1574_60887_60952(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 60887, 60952);
                    return 0;
                }


                string?
                f_1574_61254_61270(bool?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61254, 61270);
                    return return_v;
                }


                int
                f_1574_61046_61271(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61046, 61271);
                    return 0;
                }


                bool
                f_1574_61298_61312(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 61298, 61312);
                    return return_v;
                }


                bool
                f_1574_61356_61367(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 61356, 61367);
                    return return_v;
                }


                int
                f_1574_61339_61376(System.Management.Automation.Job2
                this_param, bool
                force, string
                reason)
                {
                    this_param.SuspendJob(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61339, 61376);
                    return 0;
                }


                int
                f_1574_61429_61447(System.Management.Automation.Job2
                this_param)
                {
                    this_param.SuspendJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61429, 61447);
                    return 0;
                }


                System.Threading.ManualResetEvent
                f_1574_61470_61491()
                {
                    var return_v = JobSuspendedOrAborted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 61470, 61491);
                    return return_v;
                }


                bool
                f_1574_61470_61501(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61470, 61501);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1574_61799_61813()
                {
                    var return_v = ExecutionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 61799, 61813);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1574_61818_61962(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job2
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61818, 61962);
                    return return_v;
                }


                int
                f_1574_61799_61963(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61799, 61963);
                    return 0;
                }


                string?
                f_1574_62179_62195(bool?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 62179, 62195);
                    return return_v;
                }


                int
                f_1574_61986_62196(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 61986, 62196);
                    return 0;
                }


                bool
                f_1574_62219_62244(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 62219, 62244);
                    return return_v;
                }


                System.Threading.AutoResetEvent
                f_1574_62378_62403(bool
                initialState)
                {
                    var return_v = new System.Threading.AutoResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 62378, 62403);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_62557_62566()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 62557, 62566);
                    return return_v;
                }


                int
                f_1574_62600_62663(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 62600, 62663);
                    return 0;
                }


                string?
                f_1574_64515_64531(bool?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64515, 64531);
                    return return_v;
                }


                int
                f_1574_64336_64532(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64336, 64532);
                    return 0;
                }


                bool
                f_1574_64555_64569(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 64555, 64569);
                    return return_v;
                }


                bool
                f_1574_64612_64623(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 64612, 64623);
                    return return_v;
                }


                int
                f_1574_64592_64632(System.Management.Automation.Job2
                this_param, bool
                force, string
                reason)
                {
                    this_param.SuspendJobAsync(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64592, 64632);
                    return 0;
                }


                int
                f_1574_64677_64698(System.Management.Automation.Job2
                this_param)
                {
                    this_param.SuspendJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64677, 64698);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_62557_62566_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 62557, 62566);
                    return return_v;
                }


                bool
                f_1574_64730_64749(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64730, 64749);
                    return return_v;
                }


                int
                f_1574_64764_64835(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64764, 64835);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_64871_64880()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 64871, 64880);
                    return return_v;
                }


                int
                f_1574_64914_64977(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64914, 64977);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_64871_64880_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 64871, 64880);
                    return return_v;
                }


                int
                f_1574_65069_65161(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 65069, 65161);
                    return 0;
                }


                // Errors are taken from the Error collection by the cmdlet for ContainerParentJob.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 59803, 65272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 59803, 65272);
            }
        }

        private void SuspendJobAsyncInternal(bool? force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 65503, 69037);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 65592, 65806) || true) && (_isDisposed == DisposedTrue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 65592, 65806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 65657, 65766);

                    f_1574_65657_65765(this, f_1574_65679_65764(f_1574_65707_65750(TraceClassName), false, null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 65784, 65791);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 65592, 65806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 65822, 65921);

                f_1574_65822_65920(
                            _tracer, TraceClassName, "SuspendJobAsync", Guid.Empty, this, "Entering method", null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 65935, 66139);
                    foreach (Job2 job in f_1574_65956_65970_I(f_1574_65956_65970(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 65935, 66139);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 66004, 66124) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 66004, 66124);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 66021, 66124);

                            throw f_1574_66027_66123(f_1574_66070_66122());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 66004, 66124);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 65935, 66139);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 66222, 66254);

                var
                suspendedChildJobsCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 66268, 68912);
                    foreach (Job2 job in f_1574_66289_66298_I(f_1574_66289_66298()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 66268, 68912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 66332, 66396);

                        f_1574_66332_66395(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 66416, 66474);

                        EventHandler<AsyncCompletedEventArgs>
                        eventHandler = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 66492, 68453);

                        eventHandler = (sender, e) =>
                                        {
                                            var childJob = sender as Job2;
                                            Dbg.Assert(childJob != null, "SuspendJobCompleted only available on Job2");
                                            _tracer.WriteMessage(TraceClassName, "SuspendJobAsync-Handler", Guid.Empty, this,
                                                "Finished suspending child job asynchronously, child InstanceId: {0} force: {1}", job.InstanceId.ToString(), force.ToString());
                                            if (e.Error != null)
                                            {
                                                ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobSuspendAsyncError",
                                                    ErrorCategory.InvalidResult, job));
                                                _tracer.WriteMessage(TraceClassName, "SuspendJobAsync-Handler", Guid.Empty, this,
                                                    "Child job asynchronously had error, child InstanceId: {0} force: {1}", job.InstanceId.ToString(), force.ToString());
                                                _tracer.TraceException(e.Error);
                                            }

                                            Interlocked.Increment(ref suspendedChildJobsCount);
                                            Dbg.Assert(eventHandler != null, "Event handler magically disappeared");
                                            childJob.SuspendJobCompleted -= eventHandler;
                                            if (suspendedChildJobsCount == ChildJobs.Count)
                                            {
                                                _tracer.WriteMessage(TraceClassName, "SuspendJobAsync-Handler", Guid.Empty, this,
                                                        "Finished suspending all child jobs asynchronously", null);

                                                JobSuspendedOrAborted.WaitOne();
                        // There may be multiple exceptions raised. They
                        // are stored in the Error stream of this job object, which is otherwise
                        // unused.
                        OnSuspendJobCompleted(new AsyncCompletedEventArgs(null, false, null));
                                            }
                                        };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 68471, 68511);

                        job.SuspendJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 68529, 68731);

                        f_1574_68529_68730(_tracer, TraceClassName, "SuspendJobAsync", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0} force: {1}", job.InstanceId.ToString(), f_1574_68713_68729(force));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 68749, 68897) || true) && (f_1574_68753_68767(force))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 68749, 68897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 68790, 68831);

                            f_1574_68790_68830(job, f_1574_68810_68821(force), reason);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 68749, 68897);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 68749, 68897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 68875, 68897);

                            f_1574_68875_68896(job);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 68749, 68897);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 66268, 68912);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 2645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 2645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 68928, 69026);

                f_1574_68928_69025(
                            _tracer, TraceClassName, "SuspendJobAsync", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 65503, 69037);

                System.ObjectDisposedException
                f_1574_65707_65750(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 65707, 65750);
                    return return_v;
                }


                System.ComponentModel.AsyncCompletedEventArgs
                f_1574_65679_65764(System.ObjectDisposedException
                error, bool
                cancelled, object
                userState)
                {
                    var return_v = new System.ComponentModel.AsyncCompletedEventArgs((System.Exception)error, cancelled, userState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 65679, 65764);
                    return return_v;
                }


                int
                f_1574_65657_65765(System.Management.Automation.ContainerParentJob
                this_param, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.OnSuspendJobCompleted(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 65657, 65765);
                    return 0;
                }


                int
                f_1574_65822_65920(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 65822, 65920);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_65956_65970(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 65956, 65970);
                    return return_v;
                }


                string
                f_1574_66070_66122()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 66070, 66122);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_66027_66123(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 66027, 66123);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_65956_65970_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 65956, 65970);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_66289_66298()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 66289, 66298);
                    return return_v;
                }


                int
                f_1574_66332_66395(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 66332, 66395);
                    return 0;
                }


                string?
                f_1574_68713_68729(bool?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 68713, 68729);
                    return return_v;
                }


                int
                f_1574_68529_68730(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 68529, 68730);
                    return 0;
                }


                bool
                f_1574_68753_68767(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 68753, 68767);
                    return return_v;
                }


                bool
                f_1574_68810_68821(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 68810, 68821);
                    return return_v;
                }


                int
                f_1574_68790_68830(System.Management.Automation.Job2
                this_param, bool
                force, string
                reason)
                {
                    this_param.SuspendJobAsync(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 68790, 68830);
                    return 0;
                }


                int
                f_1574_68875_68896(System.Management.Automation.Job2
                this_param)
                {
                    this_param.SuspendJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 68875, 68896);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_66289_66298_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 66289, 66298);
                    return return_v;
                }


                int
                f_1574_68928_69025(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 68928, 69025);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 65503, 69037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 65503, 69037);
            }
        }

        private void StopJobInternal(bool? force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 69203, 74514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 69284, 69304);

                f_1574_69284_69303(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 69318, 69409);

                f_1574_69318_69408(_tracer, TraceClassName, "StopJob", Guid.Empty, this, "Entering method", null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 69536, 69714) || true) && (f_1574_69540_69555(f_1574_69540_69549()) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 69536, 69714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 69594, 69699);

                    throw f_1574_69600_69698(f_1574_69643_69697());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 69536, 69714);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 69730, 69934);
                    foreach (Job2 job in f_1574_69751_69765_I(f_1574_69751_69765(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 69730, 69934);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 69799, 69919) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 69799, 69919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 69816, 69919);

                            throw f_1574_69822_69918(f_1574_69865_69917());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 69799, 69919);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 69730, 69934);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70171, 71659) || true) && (f_1574_70175_70190(f_1574_70175_70184()) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 70171, 71659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70229, 70263);

                    Job2
                    child = f_1574_70242_70254(f_1574_70242_70251(), 0) as Job2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70281, 70347);

                    f_1574_70281_70346(child != null, "Job is null after initial null check");
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70440, 70634);

                        f_1574_70440_70633(_tracer, TraceClassName, "StopJob", Guid.Empty, this, "Single child job synchronously, child InstanceId: {0}", child.InstanceId.ToString());

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70656, 70804) || true) && (f_1574_70660_70674(force))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 70656, 70804);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70701, 70736);

                            f_1574_70701_70735(child, f_1574_70715_70726(force), reason);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 70656, 70804);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 70656, 70804);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70788, 70804);

                            f_1574_70788_70803(child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 70656, 70804);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 70826, 70845);

                        f_1574_70826_70844(f_1574_70826_70834());
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1574, 70882, 71588);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71142, 71304);

                        f_1574_71142_71303(f_1574_71142_71156(), f_1574_71161_71302(e, "ContainerParentJobStopError", ErrorCategory.InvalidResult, child));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71326, 71521);

                        f_1574_71326_71520(_tracer, TraceClassName, "StopJob", Guid.Empty, this, "Single child job threw exception, child InstanceId: {0}", child.InstanceId.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71543, 71569);

                        f_1574_71543_71568(_tracer, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1574, 70882, 71588);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71637, 71644);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 70171, 71659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71675, 71728);

                AutoResetEvent
                completed = f_1574_71702_71727(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71806, 71836);

                var
                stoppedChildJobsCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71850, 71908);

                EventHandler<AsyncCompletedEventArgs>
                eventHandler = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71922, 73962);
                    foreach (Job2 job in f_1574_71943_71952_I(f_1574_71943_71952()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 71922, 73962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 71986, 72050);

                        f_1574_71986_72049(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 72070, 73548);

                        eventHandler = (object sender, AsyncCompletedEventArgs e) =>
                                        {
                                            var childJob = sender as Job2;
                                            Dbg.Assert(childJob != null,
                                                        "StopJobCompleted only available on Job2");
                                            _tracer.WriteMessage(TraceClassName, "StopJob-Handler", Guid.Empty, this,
                                                "Finished stopping child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                                            if (e.Error != null)
                                            {
                                                ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobStopError",
                                                    ErrorCategory.InvalidResult, job));
                                                _tracer.WriteMessage(TraceClassName, "StopJob-Handler", Guid.Empty, this,
                                                    "Child job asynchronously had error, child InstanceId: {0}", job.InstanceId.ToString());
                                                _tracer.TraceException(e.Error);
                                            }

                                            Interlocked.Increment(ref stoppedChildJobsCount);
                                            if (stoppedChildJobsCount == ChildJobs.Count)
                                            {
                                                _tracer.WriteMessage(TraceClassName, "StopJob-Handler", Guid.Empty, this,
                                                "Finished stopping all child jobs asynchronously", null);
                                                Finished.WaitOne();
                                                completed.Set();
                                            }
                                        };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 73566, 73603);

                        job.StopJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 73621, 73787);

                        f_1574_73621_73786(_tracer, TraceClassName, "StopJob", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 73805, 73947) || true) && (f_1574_73809_73823(force))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 73805, 73947);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 73846, 73884);

                            f_1574_73846_73883(job, f_1574_73863_73874(force), reason);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 73805, 73947);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 73805, 73947);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 73928, 73947);

                            f_1574_73928_73946(job);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 73805, 73947);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 71922, 73962);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 2041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 2041);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 73978, 73998);

                f_1574_73978_73997(
                            completed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74012, 74084);

                f_1574_74012_74083(eventHandler != null, "Event handler magically disappeared");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74098, 74298);
                    foreach (Job2 job in f_1574_74119_74128_I(f_1574_74119_74128()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 74098, 74298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74162, 74226);

                        f_1574_74162_74225(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74246, 74283);

                        job.StopJobCompleted -= eventHandler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 74098, 74298);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74314, 74404);

                f_1574_74314_74403(
                            _tracer, TraceClassName, "StopJob", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 69203, 74514);

                int
                f_1574_69284_69303(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 69284, 69303);
                    return 0;
                }


                int
                f_1574_69318_69408(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 69318, 69408);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_69540_69549()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 69540, 69549);
                    return return_v;
                }


                int
                f_1574_69540_69555(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 69540, 69555);
                    return return_v;
                }


                string
                f_1574_69643_69697()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNoChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 69643, 69697);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_69600_69698(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 69600, 69698);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_69751_69765(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 69751, 69765);
                    return return_v;
                }


                string
                f_1574_69865_69917()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 69865, 69917);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_69822_69918(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 69822, 69918);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_69751_69765_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 69751, 69765);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_70175_70184()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 70175, 70184);
                    return return_v;
                }


                int
                f_1574_70175_70190(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 70175, 70190);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_70242_70251()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 70242, 70251);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1574_70242_70254(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 70242, 70254);
                    return return_v;
                }


                int
                f_1574_70281_70346(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 70281, 70346);
                    return 0;
                }


                int
                f_1574_70440_70633(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 70440, 70633);
                    return 0;
                }


                bool
                f_1574_70660_70674(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 70660, 70674);
                    return return_v;
                }


                bool
                f_1574_70715_70726(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 70715, 70726);
                    return return_v;
                }


                int
                f_1574_70701_70735(System.Management.Automation.Job2
                this_param, bool
                force, string
                reason)
                {
                    this_param.StopJob(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 70701, 70735);
                    return 0;
                }


                int
                f_1574_70788_70803(System.Management.Automation.Job2
                this_param)
                {
                    this_param.StopJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 70788, 70803);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1574_70826_70834()
                {
                    var return_v = Finished;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 70826, 70834);
                    return return_v;
                }


                bool
                f_1574_70826_70844(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 70826, 70844);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1574_71142_71156()
                {
                    var return_v = ExecutionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 71142, 71156);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1574_71161_71302(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job2
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 71161, 71302);
                    return return_v;
                }


                int
                f_1574_71142_71303(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 71142, 71303);
                    return 0;
                }


                int
                f_1574_71326_71520(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 71326, 71520);
                    return 0;
                }


                bool
                f_1574_71543_71568(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 71543, 71568);
                    return return_v;
                }


                System.Threading.AutoResetEvent
                f_1574_71702_71727(bool
                initialState)
                {
                    var return_v = new System.Threading.AutoResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 71702, 71727);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_71943_71952()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 71943, 71952);
                    return return_v;
                }


                int
                f_1574_71986_72049(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 71986, 72049);
                    return 0;
                }


                int
                f_1574_73621_73786(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 73621, 73786);
                    return 0;
                }


                bool
                f_1574_73809_73823(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 73809, 73823);
                    return return_v;
                }


                bool
                f_1574_73863_73874(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 73863, 73874);
                    return return_v;
                }


                int
                f_1574_73846_73883(System.Management.Automation.Job2
                this_param, bool
                force, string
                reason)
                {
                    this_param.StopJobAsync(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 73846, 73883);
                    return 0;
                }


                int
                f_1574_73928_73946(System.Management.Automation.Job2
                this_param)
                {
                    this_param.StopJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 73928, 73946);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_71943_71952_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 71943, 71952);
                    return return_v;
                }


                bool
                f_1574_73978_73997(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 73978, 73997);
                    return return_v;
                }


                int
                f_1574_74012_74083(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74012, 74083);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_74119_74128()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 74119, 74128);
                    return return_v;
                }


                int
                f_1574_74162_74225(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74162, 74225);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_74119_74128_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74119, 74128);
                    return return_v;
                }


                int
                f_1574_74314_74403(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74314, 74403);
                    return 0;
                }


                // Errors are taken from the Error collection by the cmdlet for ContainerParentJob.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 69203, 74514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 69203, 74514);
            }
        }

        private void StopJobAsyncInternal(bool? force, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 74685, 78068);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74771, 74982) || true) && (_isDisposed == DisposedTrue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 74771, 74982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74836, 74942);

                    f_1574_74836_74941(this, f_1574_74855_74940(f_1574_74883_74926(TraceClassName), false, null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74960, 74967);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 74771, 74982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 74998, 75094);

                f_1574_74998_75093(
                            _tracer, TraceClassName, "StopJobAsync", Guid.Empty, this, "Entering method", null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75110, 75314);
                    foreach (Job2 job in f_1574_75131_75145_I(f_1574_75131_75145(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 75110, 75314);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75179, 75299) || true) && (job == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 75179, 75299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75196, 75299);

                            throw f_1574_75202_75298(f_1574_75245_75297());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 75179, 75299);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 75110, 75314);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75394, 75424);

                int
                stoppedChildJobsCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75438, 77946);
                    foreach (Job2 job in f_1574_75459_75468_I(f_1574_75459_75468()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 75438, 77946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75502, 75566);

                        f_1574_75502_75565(job != null, "Job is null after initial null check");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75586, 75644);

                        EventHandler<AsyncCompletedEventArgs>
                        eventHandler = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 75662, 77528);

                        eventHandler = (sender, e) =>
                                        {
                                            var childJob = sender as Job2;
                                            Dbg.Assert(childJob != null, "StopJobCompleted only available on Job2");
                                            _tracer.WriteMessage(TraceClassName, "StopJobAsync-Handler", Guid.Empty, this,
                                                "Finished stopping child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());
                                            if (e.Error != null)
                                            {
                                                ExecutionError.Add(new ErrorRecord(e.Error, "ContainerParentJobStopAsyncError",
                                                    ErrorCategory.InvalidResult, childJob));
                                                _tracer.WriteMessage(TraceClassName, "StopJobAsync-Handler", Guid.Empty, this,
                                                    "Child job asynchronously had error, child InstanceId: {0}", job.InstanceId.ToString());
                                                _tracer.TraceException(e.Error);
                                            }

                                            Interlocked.Increment(ref stoppedChildJobsCount);
                                            Dbg.Assert(eventHandler != null, "Event handler magically disappeared");
                                            childJob.StopJobCompleted -= eventHandler;
                                            if (stoppedChildJobsCount == ChildJobs.Count)
                                            {
                                                _tracer.WriteMessage(TraceClassName, "StopJobAsync-Handler", Guid.Empty, this,
                                                        "Finished stopping all child jobs asynchronously", null);

                                                Finished.WaitOne();
                        // There may be multiple exceptions raised. They
                        // are stored in the Error stream of this job object, which is otherwise
                        // unused.
                        OnStopJobCompleted(new AsyncCompletedEventArgs(null, false, null));
                                            }
                                        };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 77546, 77583);

                        job.StopJobCompleted += eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 77601, 77771);

                        f_1574_77601_77770(_tracer, TraceClassName, "StopJobAsync", Guid.Empty, this, "Child job asynchronously, child InstanceId: {0}", job.InstanceId.ToString());

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 77789, 77931) || true) && (f_1574_77793_77807(force))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 77789, 77931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 77830, 77868);

                            f_1574_77830_77867(job, f_1574_77847_77858(force), reason);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 77789, 77931);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 77789, 77931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 77912, 77931);

                            f_1574_77912_77930(job);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 77789, 77931);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 75438, 77946);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 2509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 2509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 77962, 78057);

                f_1574_77962_78056(
                            _tracer, TraceClassName, "StopJobAsync", Guid.Empty, this, "Exiting method", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 74685, 78068);

                System.ObjectDisposedException
                f_1574_74883_74926(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74883, 74926);
                    return return_v;
                }


                System.ComponentModel.AsyncCompletedEventArgs
                f_1574_74855_74940(System.ObjectDisposedException
                error, bool
                cancelled, object
                userState)
                {
                    var return_v = new System.ComponentModel.AsyncCompletedEventArgs((System.Exception)error, cancelled, userState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74855, 74940);
                    return return_v;
                }


                int
                f_1574_74836_74941(System.Management.Automation.ContainerParentJob
                this_param, System.ComponentModel.AsyncCompletedEventArgs
                eventArgs)
                {
                    this_param.OnStopJobCompleted(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74836, 74941);
                    return 0;
                }


                int
                f_1574_74998_75093(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 74998, 75093);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_75131_75145(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 75131, 75145);
                    return return_v;
                }


                string
                f_1574_75245_75297()
                {
                    var return_v = RemotingErrorIdStrings.JobActionInvalidWithNullChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 75245, 75297);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1574_75202_75298(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 75202, 75298);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_75131_75145_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 75131, 75145);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_75459_75468()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 75459, 75468);
                    return return_v;
                }


                int
                f_1574_75502_75565(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 75502, 75565);
                    return 0;
                }


                int
                f_1574_77601_77770(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 77601, 77770);
                    return 0;
                }


                bool
                f_1574_77793_77807(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 77793, 77807);
                    return return_v;
                }


                bool
                f_1574_77847_77858(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 77847, 77858);
                    return return_v;
                }


                int
                f_1574_77830_77867(System.Management.Automation.Job2
                this_param, bool
                force, string
                reason)
                {
                    this_param.StopJobAsync(force, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 77830, 77867);
                    return 0;
                }


                int
                f_1574_77912_77930(System.Management.Automation.Job2
                this_param)
                {
                    this_param.StopJobAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 77912, 77930);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_75459_75468_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 75459, 75468);
                    return return_v;
                }


                int
                f_1574_77962_78056(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 77962, 78056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 74685, 78068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 74685, 78068);
            }
        }

        private void HandleMyStateChanged(object sender, JobStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 78080, 79966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 78174, 78427);

                f_1574_78174_78426(_tracer, TraceClassName, "HandleMyStateChanged", Guid.Empty, this, "NewState: {0}; OldState: {1}", f_1574_78319_78350(f_1574_78319_78339(f_1574_78319_78333(e))), f_1574_78386_78425(f_1574_78386_78414(f_1574_78386_78408(e))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 78443, 79955);

                switch (f_1574_78451_78471(f_1574_78451_78465(e)))
                {

                    case JobState.Running:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 78443, 79955);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 78582, 78593);
                            lock (_syncObject)
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 78651, 78668);

                                f_1574_78651_78667(f_1574_78651_78661());

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 78814, 78913) || true) && (_jobSuspendedOrAborted != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 78814, 78913);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 78883, 78913);

                                    f_1574_78883_78912(f_1574_78883_78904());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 78814, 78913);
                                }
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 78987, 78993);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 78443, 79955);

                    case JobState.Suspended:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 78443, 79955);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 79092, 79103);
                            lock (_syncObject)
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 79161, 79189);

                                f_1574_79161_79188(f_1574_79161_79182());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 79219, 79238);

                                f_1574_79219_79237(f_1574_79219_79229());
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 79312, 79318);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 78443, 79955);

                    case JobState.Failed:
                    case JobState.Completed:
                    case JobState.Stopped:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 78443, 79955);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 79494, 79505);
                            lock (_syncObject)
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 79563, 79591);

                                f_1574_79563_79590(f_1574_79563_79584());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 79843, 79860);

                                f_1574_79843_79859(f_1574_79843_79853());
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 79934, 79940);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 78443, 79955);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 78080, 79966);

                System.Management.Automation.JobStateInfo
                f_1574_78319_78333(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78319, 78333);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_78319_78339(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78319, 78339);
                    return return_v;
                }


                string
                f_1574_78319_78350(System.Management.Automation.JobState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 78319, 78350);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_78386_78408(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.PreviousJobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78386, 78408);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_78386_78414(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78386, 78414);
                    return return_v;
                }


                string
                f_1574_78386_78425(System.Management.Automation.JobState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 78386, 78425);
                    return return_v;
                }


                int
                f_1574_78174_78426(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.ContainerParentJob
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, (System.Management.Automation.Job)job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 78174, 78426);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1574_78451_78465(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78451, 78465);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_78451_78471(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78451, 78471);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1574_78651_78661()
                {
                    var return_v = JobRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78651, 78661);
                    return return_v;
                }


                bool
                f_1574_78651_78667(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 78651, 78667);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1574_78883_78904()
                {
                    var return_v = JobSuspendedOrAborted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 78883, 78904);
                    return return_v;
                }


                bool
                f_1574_78883_78912(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 78883, 78912);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1574_79161_79182()
                {
                    var return_v = JobSuspendedOrAborted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 79161, 79182);
                    return return_v;
                }


                bool
                f_1574_79161_79188(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 79161, 79188);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1574_79219_79229()
                {
                    var return_v = JobRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 79219, 79229);
                    return return_v;
                }


                bool
                f_1574_79219_79237(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 79219, 79237);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1574_79563_79584()
                {
                    var return_v = JobSuspendedOrAborted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 79563, 79584);
                    return return_v;
                }


                bool
                f_1574_79563_79590(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 79563, 79590);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1574_79843_79853()
                {
                    var return_v = JobRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 79843, 79853);
                    return return_v;
                }


                bool
                f_1574_79843_79859(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 79843, 79859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 78080, 79966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 78080, 79966);
            }
        }

        private void HandleChildJobStateChanged(object sender, JobStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 80186, 80326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 80286, 80315);

                f_1574_80286_80314(this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 80186, 80326);

                int
                f_1574_80286_80314(System.Management.Automation.ContainerParentJob
                this_param, System.Management.Automation.JobStateEventArgs
                e)
                {
                    this_param.ParentJobStateCalculation(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 80286, 80314);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 80186, 80326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 80186, 80326);
            }
        }

        private void ParentJobStateCalculation(JobStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 80338, 81531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 80422, 80445);

                JobState
                computedState
                = default(JobState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 80459, 81520) || true) && (f_1574_80463_80751("ContainerParentJob", e, ref _blockedChildJobsCount, ref _suspendedChildJobsCount, ref _suspendingChildJobsCount, ref _finishedChildJobsCount, ref _failedChildJobsCount, ref _stoppedChildJobsCount, f_1574_80716_80731(f_1574_80716_80725()), out computedState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 80459, 81520);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 80785, 81316) || true) && (computedState != f_1574_80806_80824(f_1574_80806_80818()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 80785, 81316);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 80866, 81048) || true) && (f_1574_80870_80888(f_1574_80870_80882()) == JobState.NotStarted && (DynAbs.Tracing.TraceSender.Expression_True(1574, 80870, 80948) && computedState == JobState.Running))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 80866, 81048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 80998, 81025);

                            PSBeginTime = DateTime.Now;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 80866, 81048);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 81072, 81246) || true) && (!f_1574_81077_81112(this, f_1574_81093_81111(f_1574_81093_81105())) && (DynAbs.Tracing.TraceSender.Expression_True(1574, 81076, 81148) && f_1574_81116_81148(this, computedState)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 81072, 81246);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 81198, 81223);

                            PSEndTime = DateTime.Now;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 81072, 81246);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 81270, 81297);

                        f_1574_81270_81296(this, computedState);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 80785, 81316);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 81336, 81505) || true) && (_finishedChildJobsCount == f_1574_81367_81382(f_1574_81367_81376()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 81336, 81505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 81424, 81486);

                        f_1574_81424_81485(s_structuredTracer, f_1574_81474_81484());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 81336, 81505);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 80459, 81520);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 80338, 81531);

                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_80716_80725()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 80716, 80725);
                    return return_v;
                }


                int
                f_1574_80716_80731(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 80716, 80731);
                    return return_v;
                }


                bool
                f_1574_80463_80751(string
                traceClassName, System.Management.Automation.JobStateEventArgs
                e, ref int
                blockedChildJobsCount, ref int
                suspendedChildJobsCount, ref int
                suspendingChildJobsCount, ref int
                finishedChildJobsCount, ref int
                failedChildJobsCount, ref int
                stoppedChildJobsCount, int
                childJobsCount, out System.Management.Automation.JobState
                computedJobState)
                {
                    var return_v = ComputeJobStateFromChildJobStates(traceClassName, e, ref blockedChildJobsCount, ref suspendedChildJobsCount, ref suspendingChildJobsCount, ref finishedChildJobsCount, ref failedChildJobsCount, ref stoppedChildJobsCount, childJobsCount, out computedJobState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 80463, 80751);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_80806_80818()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 80806, 80818);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_80806_80824(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 80806, 80824);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_80870_80882()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 80870, 80882);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_80870_80888(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 80870, 80888);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_81093_81105()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 81093, 81105);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_81093_81111(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 81093, 81111);
                    return return_v;
                }


                bool
                f_1574_81077_81112(System.Management.Automation.ContainerParentJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 81077, 81112);
                    return return_v;
                }


                bool
                f_1574_81116_81148(System.Management.Automation.ContainerParentJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsPersistentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 81116, 81148);
                    return return_v;
                }


                int
                f_1574_81270_81296(System.Management.Automation.ContainerParentJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 81270, 81296);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_81367_81376()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 81367, 81376);
                    return return_v;
                }


                int
                f_1574_81367_81382(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 81367, 81382);
                    return return_v;
                }


                System.Guid
                f_1574_81474_81484()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 81474, 81484);
                    return return_v;
                }


                int
                f_1574_81424_81485(System.Management.Automation.Tracing.Tracer
                this_param, System.Guid
                containerParentJobInstanceId)
                {
                    this_param.EndContainerParentJobExecution(containerParentJobInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 81424, 81485);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 80338, 81531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 80338, 81531);
            }
        }

        internal static bool ComputeJobStateFromChildJobStates(string traceClassName, JobStateEventArgs e,
                    ref int blockedChildJobsCount, ref int suspendedChildJobsCount, ref int suspendingChildJobsCount, ref int finishedChildJobsCount,
                        ref int failedChildJobsCount, ref int stoppedChildJobsCount, int childJobsCount,
                            out JobState computedJobState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1574, 82309, 91070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 82725, 82764);

                computedJobState = JobState.NotStarted;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 82780, 91030);
                using (PowerShellTraceSource
                tracer = f_1574_82818_82863()
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 82897, 83410) || true) && (f_1574_82901_82921(f_1574_82901_82915(e)) == JobState.Blocked)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 82897, 83410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83045, 83094);

                        f_1574_83045_83093(ref blockedChildJobsCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83202, 83299);

                        f_1574_83202_83298(
                                            // if any of the child job is blocked, we set state to blocked
                                            tracer, traceClassName, ": JobState is Blocked, at least one child job is blocked.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83321, 83357);

                        computedJobState = JobState.Blocked;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83379, 83391);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 82897, 83410);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83430, 84147) || true) && (f_1574_83434_83462(f_1574_83434_83456(e)) == JobState.Blocked)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 83430, 84147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83721, 83770);

                        f_1574_83721_83769(ref blockedChildJobsCount);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83794, 84091) || true) && (blockedChildJobsCount == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 83794, 84091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83874, 83968);

                            f_1574_83874_83967(tracer, traceClassName, ": JobState is unblocked, all child jobs are unblocked.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 83994, 84030);

                            computedJobState = JobState.Running;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 84056, 84068);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 83794, 84091);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 84115, 84128);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 83430, 84147);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 84167, 84508) || true) && (f_1574_84171_84199(f_1574_84171_84193(e)) == JobState.Suspended)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 84167, 84508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 84438, 84489);

                        f_1574_84438_84488(ref suspendedChildJobsCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 84167, 84508);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 84528, 84872) || true) && (f_1574_84532_84560(f_1574_84532_84554(e)) == JobState.Suspending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 84528, 84872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 84801, 84853);

                        f_1574_84801_84852(ref suspendingChildJobsCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 84528, 84872);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 84892, 85875) || true) && (f_1574_84896_84916(f_1574_84896_84910(e)) == JobState.Suspended)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 84892, 85875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 85045, 85096);

                        f_1574_85045_85095(ref suspendedChildJobsCount);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 85251, 85590) || true) && (suspendedChildJobsCount + finishedChildJobsCount == childJobsCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 85251, 85590);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 85371, 85465);

                            f_1574_85371_85464(tracer, traceClassName, ": JobState is suspended, all child jobs are suspended.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 85491, 85529);

                            computedJobState = JobState.Suspended;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 85555, 85567);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 85251, 85590);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 85843, 85856);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 84892, 85875);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 85895, 86932) || true) && (f_1574_85899_85919(f_1574_85899_85913(e)) == JobState.Suspending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 85895, 86932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 86050, 86102);

                        f_1574_86050_86101(ref suspendingChildJobsCount);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 86257, 86635) || true) && (suspendedChildJobsCount + finishedChildJobsCount + suspendingChildJobsCount == childJobsCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 86257, 86635);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 86404, 86509);

                            f_1574_86404_86508(tracer, traceClassName, ": JobState is suspending, all child jobs are in suspending state.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 86535, 86574);

                            computedJobState = JobState.Suspending;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 86600, 86612);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 86257, 86635);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 86900, 86913);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 85895, 86932);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 87124, 87786) || true) && ((f_1574_87129_87149(f_1574_87129_87143(e)) != JobState.Completed && (DynAbs.Tracing.TraceSender.Expression_True(1574, 87129, 87214) && f_1574_87175_87195(f_1574_87175_87189(e)) != JobState.Failed)) && (DynAbs.Tracing.TraceSender.Expression_True(1574, 87128, 87259) && f_1574_87219_87239(f_1574_87219_87233(e)) != JobState.Stopped))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 87124, 87786);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 87301, 87492) || true) && (f_1574_87305_87325(f_1574_87305_87319(e)) == JobState.Running)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 87301, 87492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 87395, 87431);

                            computedJobState = JobState.Running;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 87457, 87469);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 87301, 87492);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 87754, 87767);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 87124, 87786);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 87806, 88090) || true) && (f_1574_87810_87830(f_1574_87810_87824(e)) == JobState.Failed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 87806, 88090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88023, 88071);

                        f_1574_88023_88070(ref failedChildJobsCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 87806, 88090);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88254, 88408) || true) && (f_1574_88258_88278(f_1574_88258_88272(e)) == JobState.Stopped)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 88254, 88408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88340, 88389);

                        f_1574_88340_88388(ref stoppedChildJobsCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 88254, 88408);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88428, 88462);

                    bool
                    allChildJobsFinished = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88482, 88564);

                    int
                    finishedChildJobsCountNew = f_1574_88514_88563(ref finishedChildJobsCount)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88616, 88752) || true) && (finishedChildJobsCountNew == childJobsCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 88616, 88752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88705, 88733);

                        allChildJobsFinished = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 88616, 88752);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 88772, 89812) || true) && (allChildJobsFinished)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 88772, 89812);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89015, 89307) || true) && (failedChildJobsCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 89015, 89307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89093, 89185);

                            f_1574_89093_89184(tracer, traceClassName, ": JobState is failed, at least one child job failed.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89211, 89246);

                            computedJobState = JobState.Failed;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89272, 89284);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 89015, 89307);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89331, 89611) || true) && (stoppedChildJobsCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 89331, 89611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89410, 89488);

                            f_1574_89410_89487(tracer, traceClassName, ": JobState is stopped, stop is called.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89514, 89550);

                            computedJobState = JobState.Stopped;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89576, 89588);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 89331, 89611);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89635, 89699);

                        f_1574_89635_89698(
                                            tracer, traceClassName, ": JobState is completed.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89721, 89759);

                        computedJobState = JobState.Completed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 89781, 89793);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 88772, 89812);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90038, 90360) || true) && (suspendedChildJobsCount + finishedChildJobsCountNew == childJobsCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 90038, 90360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90153, 90247);

                        f_1574_90153_90246(tracer, traceClassName, ": JobState is suspended, all child jobs are suspended.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90269, 90307);

                        computedJobState = JobState.Suspended;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90329, 90341);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 90038, 90360);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90654, 91015) || true) && (suspendingChildJobsCount + suspendedChildJobsCount + finishedChildJobsCountNew == childJobsCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 90654, 91015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90796, 90901);

                        f_1574_90796_90900(tracer, traceClassName, ": JobState is suspending, all child jobs are in suspending state.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90923, 90962);

                        computedJobState = JobState.Suspending;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 90984, 90996);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 90654, 91015);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1574, 82780, 91030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91046, 91059);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1574, 82309, 91070);

                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1574_82818_82863()
                {
                    var return_v = PowerShellTraceSourceFactory.GetTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 82818, 82863);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_82901_82915(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 82901, 82915);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_82901_82921(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 82901, 82921);
                    return return_v;
                }


                int
                f_1574_83045_83093(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 83045, 83093);
                    return return_v;
                }


                bool
                f_1574_83202_83298(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 83202, 83298);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_83434_83456(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.PreviousJobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 83434, 83456);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_83434_83462(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 83434, 83462);
                    return return_v;
                }


                int
                f_1574_83721_83769(ref int
                location)
                {
                    var return_v = Interlocked.Decrement(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 83721, 83769);
                    return return_v;
                }


                bool
                f_1574_83874_83967(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 83874, 83967);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_84171_84193(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.PreviousJobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 84171, 84193);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_84171_84199(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 84171, 84199);
                    return return_v;
                }


                int
                f_1574_84438_84488(ref int
                location)
                {
                    var return_v = Interlocked.Decrement(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 84438, 84488);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_84532_84554(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.PreviousJobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 84532, 84554);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_84532_84560(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 84532, 84560);
                    return return_v;
                }


                int
                f_1574_84801_84852(ref int
                location)
                {
                    var return_v = Interlocked.Decrement(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 84801, 84852);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_84896_84910(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 84896, 84910);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_84896_84916(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 84896, 84916);
                    return return_v;
                }


                int
                f_1574_85045_85095(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 85045, 85095);
                    return return_v;
                }


                bool
                f_1574_85371_85464(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 85371, 85464);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_85899_85913(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 85899, 85913);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_85899_85919(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 85899, 85919);
                    return return_v;
                }


                int
                f_1574_86050_86101(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 86050, 86101);
                    return return_v;
                }


                bool
                f_1574_86404_86508(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 86404, 86508);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_87129_87143(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87129, 87143);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_87129_87149(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87129, 87149);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_87175_87189(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87175, 87189);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_87175_87195(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87175, 87195);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_87219_87233(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87219, 87233);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_87219_87239(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87219, 87239);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_87305_87319(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87305, 87319);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_87305_87325(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87305, 87325);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_87810_87824(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87810, 87824);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_87810_87830(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 87810, 87830);
                    return return_v;
                }


                int
                f_1574_88023_88070(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 88023, 88070);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1574_88258_88272(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 88258, 88272);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1574_88258_88278(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 88258, 88278);
                    return return_v;
                }


                int
                f_1574_88340_88388(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 88340, 88388);
                    return return_v;
                }


                int
                f_1574_88514_88563(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 88514, 88563);
                    return return_v;
                }


                bool
                f_1574_89093_89184(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 89093, 89184);
                    return return_v;
                }


                bool
                f_1574_89410_89487(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 89410, 89487);
                    return return_v;
                }


                bool
                f_1574_89635_89698(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 89635, 89698);
                    return return_v;
                }


                bool
                f_1574_90153_90246(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 90153, 90246);
                    return return_v;
                }


                bool
                f_1574_90796_90900(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message1, string
                message2)
                {
                    var return_v = this_param.WriteMessage(message1, message2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 90796, 90900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 82309, 91070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 82309, 91070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 91317, 92226);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91389, 91412) || true) && (!disposing)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 91389, 91412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91405, 91412);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 91389, 91412);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91426, 91528) || true) && (f_1574_91430_91503(ref _isDisposed, DisposedTrue, DisposedFalse) == DisposedTrue)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 91426, 91528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91521, 91528);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 91426, 91528);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91580, 91605);

                    f_1574_91580_91604(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91623, 91649);

                    f_1574_91623_91648(_executionError);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91667, 91704);

                    StateChanged -= HandleMyStateChanged;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91724, 91914);
                        foreach (Job job in f_1574_91744_91753_I(f_1574_91744_91753()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 91724, 91914);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91795, 91859);

                            f_1574_91795_91858(_tracer, "Disposing child job with id : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1574_91851_91857(job)).ToString(), 1574, 91851, 91857));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91881, 91895);

                            f_1574_91881_91894(job);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 91724, 91914);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 191);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91934, 92002) || true) && (_jobRunning != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 91934, 92002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 91980, 92002);

                        f_1574_91980_92001(_jobRunning);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 91934, 92002);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92022, 92112) || true) && (_jobSuspendedOrAborted != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 92022, 92112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92079, 92112);

                        f_1574_92079_92111(_jobSuspendedOrAborted);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 92022, 92112);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1574, 92141, 92215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92181, 92200);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(true), 1574, 92181, 92199);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1574, 92141, 92215);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 91317, 92226);

                int
                f_1574_91430_91503(ref int
                location1, int
                value, int
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 91430, 91503);
                    return return_v;
                }


                int
                f_1574_91580_91604(System.Management.Automation.ContainerParentJob
                this_param)
                {
                    this_param.UnregisterAllJobEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 91580, 91604);
                    return 0;
                }


                int
                f_1574_91623_91648(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 91623, 91648);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_91744_91753()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 91744, 91753);
                    return return_v;
                }


                int
                f_1574_91851_91857(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 91851, 91857);
                    return return_v;
                }


                bool
                f_1574_91795_91858(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 91795, 91858);
                    return return_v;
                }


                int
                f_1574_91881_91894(System.Management.Automation.Job
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 91881, 91894);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_91744_91753_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 91744, 91753);
                    return return_v;
                }


                int
                f_1574_91980_92001(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 91980, 92001);
                    return 0;
                }


                int
                f_1574_92079_92111(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 92079, 92111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 91317, 92226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 91317, 92226);
            }
        }

        private string ConstructLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 92238, 92531);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92297, 92381) || true) && (f_1574_92301_92310() == null || (DynAbs.Tracing.TraceSender.Expression_False(1574, 92301, 92342) || f_1574_92322_92337(f_1574_92322_92331()) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 92297, 92381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92361, 92381);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 92297, 92381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92395, 92490);

                string
                location = f_1574_92413_92489(f_1574_92413_92452(f_1574_92413_92422(), (job) => job.Location), (s1, s2) => s1 + ',' + s2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92504, 92520);

                return location;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 92238, 92531);

                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92301_92310()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92301, 92310);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92322_92331()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92322, 92331);
                    return return_v;
                }


                int
                f_1574_92322_92337(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92322, 92337);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92413_92422()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92413, 92422);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1574_92413_92452(System.Collections.Generic.IList<System.Management.Automation.Job>
                source, System.Func<System.Management.Automation.Job, string>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.Job, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 92413, 92452);
                    return return_v;
                }


                string
                f_1574_92413_92489(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, string, string>
                func)
                {
                    var return_v = source.Aggregate<string>(func);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 92413, 92489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 92238, 92531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 92238, 92531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ConstructStatusMessage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 92543, 93176);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92607, 92691) || true) && (f_1574_92611_92620() == null || (DynAbs.Tracing.TraceSender.Expression_False(1574, 92611, 92652) || f_1574_92632_92647(f_1574_92632_92641()) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 92607, 92691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92671, 92691);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 92607, 92691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92707, 92746);

                StringBuilder
                sb = f_1574_92726_92745()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92771, 92776);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92762, 93128) || true) && (i < f_1574_92782_92797(f_1574_92782_92791()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92799, 92802)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 92762, 93128))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 92762, 93128);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92836, 92988) || true) && (!f_1574_92841_92889(f_1574_92862_92888(f_1574_92862_92874(f_1574_92862_92871(), i))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 92836, 92988);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 92931, 92969);

                            f_1574_92931_92968(sb, f_1574_92941_92967(f_1574_92941_92953(f_1574_92941_92950(), i)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 92836, 92988);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93008, 93113) || true) && (i < (f_1574_93017_93032(f_1574_93017_93026()) - 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 93008, 93113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93079, 93094);

                            f_1574_93079_93093(sb, ",");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 93008, 93113);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93144, 93165);

                return f_1574_93151_93164(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 92543, 93176);

                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92611_92620()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92611, 92620);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92632_92641()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92632, 92641);
                    return return_v;
                }


                int
                f_1574_92632_92647(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92632, 92647);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1574_92726_92745()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 92726, 92745);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92782_92791()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92782, 92791);
                    return return_v;
                }


                int
                f_1574_92782_92797(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92782, 92797);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92862_92871()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92862, 92871);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1574_92862_92874(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92862, 92874);
                    return return_v;
                }


                string
                f_1574_92862_92888(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.StatusMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92862, 92888);
                    return return_v;
                }


                bool
                f_1574_92841_92889(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 92841, 92889);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_92941_92950()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92941, 92950);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1574_92941_92953(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92941, 92953);
                    return return_v;
                }


                string
                f_1574_92941_92967(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.StatusMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 92941, 92967);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1574_92931_92968(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 92931, 92968);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_93017_93026()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 93017, 93026);
                    return return_v;
                }


                int
                f_1574_93017_93032(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 93017, 93032);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1574_93079_93093(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 93079, 93093);
                    return return_v;
                }


                string
                f_1574_93151_93164(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 93151, 93164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 92543, 93176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 92543, 93176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 93344, 93422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93380, 93407);

                    return f_1574_93387_93406(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 93344, 93422);

                    string
                    f_1574_93387_93406(System.Management.Automation.ContainerParentJob
                    this_param)
                    {
                        var return_v = this_param.ConstructLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 93387, 93406);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 93288, 93433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 93288, 93433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void UnregisterJobEvent(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 93445, 94007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93510, 93569);

                string
                sourceIdentifier = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1574_93536_93550(job)).ToString(), 1574, 93536, 93550) + ":StateChanged"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93585, 93667);

                f_1574_93585_93666(
                            _tracer, "Unregistering StateChanged event for job ", f_1574_93651_93665(job));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93681, 93996);
                    foreach (PSEventSubscriber subscriber in f_1574_93739_93881_I(f_1574_93739_93881(f_1574_93739_93763(f_1574_93739_93751()), subscriber => string.Equals(subscriber.SourceIdentifier, sourceIdentifier, StringComparison.OrdinalIgnoreCase))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 93681, 93996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 93915, 93957);

                        f_1574_93915_93956(f_1574_93915_93927(), subscriber);
                        DynAbs.Tracing.TraceSender.TraceBreak(1574, 93975, 93981);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 93681, 93996);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 316);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 93445, 94007);

                System.Guid
                f_1574_93536_93550(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 93536, 93550);
                    return return_v;
                }


                System.Guid
                f_1574_93651_93665(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 93651, 93665);
                    return return_v;
                }


                bool
                f_1574_93585_93666(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message, System.Guid
                instanceId)
                {
                    var return_v = this_param.WriteMessage(message, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 93585, 93666);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1574_93739_93751()
                {
                    var return_v = EventManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 93739, 93751);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1574_93739_93763(System.Management.Automation.PSEventManager
                this_param)
                {
                    var return_v = this_param.Subscribers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 93739, 93763);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1574_93739_93881(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                source, System.Func<System.Management.Automation.PSEventSubscriber, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.PSEventSubscriber>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 93739, 93881);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1574_93915_93927()
                {
                    var return_v = EventManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 93915, 93927);
                    return return_v;
                }


                int
                f_1574_93915_93956(System.Management.Automation.PSEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.UnsubscribeEvent(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 93915, 93956);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1574_93739_93881_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 93739, 93881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 93445, 94007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 93445, 94007);
            }
        }

        private void UnregisterAllJobEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 94019, 94528);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94081, 94256) || true) && (f_1574_94085_94097() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 94081, 94256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94139, 94216);

                    f_1574_94139_94215(_tracer, "No events subscribed, skipping event unregistrations");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94234, 94241);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 94081, 94256);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94272, 94374);
                    foreach (var job in f_1574_94292_94301_I(f_1574_94292_94301()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 94272, 94374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94335, 94359);

                        f_1574_94335_94358(this, job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 94272, 94374);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1574, 1, 103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1574, 1, 103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94390, 94415);

                f_1574_94390_94414(this, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94429, 94483);

                f_1574_94429_94482(_tracer, "Setting event manager to null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 94497, 94517);

                EventManager = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 94019, 94528);

                System.Management.Automation.PSEventManager
                f_1574_94085_94097()
                {
                    var return_v = EventManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 94085, 94097);
                    return return_v;
                }


                bool
                f_1574_94139_94215(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 94139, 94215);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_94292_94301()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 94292, 94301);
                    return return_v;
                }


                int
                f_1574_94335_94358(System.Management.Automation.ContainerParentJob
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.UnregisterJobEvent(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 94335, 94358);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1574_94292_94301_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 94292, 94301);
                    return return_v;
                }


                int
                f_1574_94390_94414(System.Management.Automation.ContainerParentJob
                this_param, System.Management.Automation.ContainerParentJob
                job)
                {
                    this_param.UnregisterJobEvent((System.Management.Automation.Job)job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 94390, 94414);
                    return 0;
                }


                bool
                f_1574_94429_94482(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 94429, 94482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 94019, 94528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 94019, 94528);
            }
        }

        static ContainerParentJob()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1574, 18051, 94535);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18169, 18206);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18374, 18390);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 18419, 18436);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 33965, 33998);
            s_structuredTracer = f_1574_33986_33998();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1574, 18051, 94535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 18051, 94535);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1574, 18051, 94535);

        object
        f_1574_18295_18307()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 18295, 18307);
            return return_v;
        }


        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1574_19241_19286()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 19241, 19286);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        f_1574_19362_19397()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 19362, 19397);
            return return_v;
        }


        static string
        f_1574_21844_21851_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 21769, 21931);
            return return_v;
        }


        static string
        f_1574_22202_22209_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 22140, 22283);
            return return_v;
        }


        static string
        f_1574_22760_22767_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 22664, 22854);
            return return_v;
        }


        static string
        f_1574_23325_23332_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 23233, 23424);
            return return_v;
        }


        static string
        f_1574_23975_23982_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 23863, 24107);
            return return_v;
        }


        static string
        f_1574_24652_24659_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 24544, 24789);
            return return_v;
        }


        static string
        f_1574_25231_25238_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 25140, 25356);
            return return_v;
        }


        static System.Management.Automation.Tracing.Tracer
        f_1574_33986_33998()
        {
            var return_v = new System.Management.Automation.Tracing.Tracer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 33986, 33998);
            return return_v;
        }

    }
    [Serializable]
    public class JobFailedException : SystemException
    {
        public JobFailedException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 94878, 94927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96967, 96974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97224, 97246);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 94878, 94927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 94878, 94927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 94878, 94927);
            }
        }

        public JobFailedException(string message)
        : base(f_1574_95168_95175_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 95106, 95198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96967, 96974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97224, 97246);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 95106, 95198);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 95106, 95198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 95106, 95198);
            }
        }

        public JobFailedException(string message, Exception innerException)
        : base(f_1574_95560_95567_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 95472, 95606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96967, 96974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97224, 97246);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 95472, 95606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 95472, 95606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 95472, 95606);
            }
        }

        public JobFailedException(Exception innerException, ScriptExtent displayScriptPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 95928, 96137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96967, 96974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97224, 97246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96040, 96065);

                _reason = innerException;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96079, 96126);

                _displayScriptPosition = displayScriptPosition;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 95928, 96137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 95928, 96137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 95928, 96137);
            }
        }

        protected JobFailedException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        : base(f_1574_96493_96510_C(serializationInfo), streamingContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1574, 96372, 96769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96967, 96974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97224, 97246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96554, 96631);

                _reason = (Exception)f_1574_96575_96630(serializationInfo, "Reason", typeof(Exception));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96645, 96758);

                _displayScriptPosition = (ScriptExtent)f_1574_96684_96757(serializationInfo, "DisplayScriptPosition", typeof(ScriptExtent));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1574, 96372, 96769);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 96372, 96769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 96372, 96769);
            }
        }

        public Exception Reason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 96912, 96935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 96918, 96933);

                    return _reason;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 96912, 96935);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 96886, 96937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 96886, 96937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Exception _reason;

        public ScriptExtent DisplayScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 97151, 97189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97157, 97187);

                    return _displayScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 97151, 97189);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 97107, 97191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 97107, 97191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ScriptExtent _displayScriptPosition;

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 97504, 97875);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97613, 97688) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1574, 97613, 97688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97648, 97688);

                    throw f_1574_97654_97687("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1574, 97613, 97688);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97704, 97738);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1574, 97704, 97737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97754, 97787);

                f_1574_97754_97786(
                            info, "Reason", _reason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 97801, 97864);

                f_1574_97801_97863(info, "DisplayScriptPosition", _displayScriptPosition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 97504, 97875);

                System.ArgumentNullException
                f_1574_97654_97687(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 97654, 97687);
                    return return_v;
                }


                int
                f_1574_97754_97786(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Exception
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 97754, 97786);
                    return 0;
                }


                int
                f_1574_97801_97863(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Management.Automation.Language.ScriptExtent
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 97801, 97863);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 97504, 97875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 97504, 97875);
            }
        }

        public override string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1574, 98041, 98114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1574, 98077, 98099);

                    return f_1574_98084_98098(f_1574_98084_98090());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1574, 98041, 98114);

                    System.Exception
                    f_1574_98084_98090()
                    {
                        var return_v = Reason;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 98084, 98090);
                        return return_v;
                    }


                    string
                    f_1574_98084_98098(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1574, 98084, 98098);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1574, 97986, 98125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 97986, 98125);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static JobFailedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1574, 94698, 98132);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1574, 94698, 98132);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1574, 94698, 98132);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1574, 94698, 98132);

        static string
        f_1574_95168_95175_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 95106, 95198);
            return return_v;
        }


        static string
        f_1574_95560_95567_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 95472, 95606);
            return return_v;
        }


        object?
        f_1574_96575_96630(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 96575, 96630);
            return return_v;
        }


        object?
        f_1574_96684_96757(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1574, 96684, 96757);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1574_96493_96510_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1574, 96372, 96769);
            return return_v;
        }

    }

}
