// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces
{
    internal class AsyncResult : IAsyncResult
    {
        private ManualResetEvent _completedWaitHandle;

        private AutoResetEvent _invokeOnThreadEvent;

        private WaitCallback _invokeCallback;

        private object _invokeCallbackState;

        internal AsyncResult(Guid ownerId, AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1452, 1345, 1613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 540, 560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 743, 763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 795, 810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 836, 856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 2045, 2090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 2202, 2235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 3315, 3365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 3461, 3501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 3585, 3636);
                this.SyncObject = f_1452_3623_3635();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 1442, 1503);

                f_1452_1442_1502(Guid.Empty != ownerId, "ownerId cannot be empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 1517, 1535);

                OwnerId = ownerId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 1549, 1569);

                Callback = callback;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 1583, 1602);

                AsyncState = state;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1452, 1345, 1613);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 1345, 1613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 1345, 1613);
            }
        }

        public bool CompletedSynchronously
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1452, 1829, 1893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 1865, 1878);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1452, 1829, 1893);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 1770, 1904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 1770, 1904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsCompleted { get; private set; }

        public object AsyncState { get; }

        public WaitHandle AsyncWaitHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1452, 2477, 2932);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 2513, 2869) || true) && (_completedWaitHandle == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 2513, 2869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 2593, 2603);
                        lock (f_1452_2593_2603())
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 2653, 2827) || true) && (_completedWaitHandle == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 2653, 2827);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 2743, 2800);

                                _completedWaitHandle = f_1452_2766_2799(f_1452_2787_2798());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 2653, 2827);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 2513, 2869);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 2889, 2917);

                    return _completedWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1452, 2477, 2932);

                    object
                    f_1452_2593_2603()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 2593, 2603);
                        return return_v;
                    }


                    bool
                    f_1452_2787_2798()
                    {
                        var return_v = IsCompleted;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 2787, 2798);
                        return return_v;
                    }


                    System.Threading.ManualResetEvent
                    f_1452_2766_2799(bool
                    initialState)
                    {
                        var return_v = new System.Threading.ManualResetEvent(initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 2766, 2799);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 2419, 2943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 2419, 2943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Guid OwnerId { get; }

        internal Exception Exception { get; private set; }

        internal AsyncCallback Callback { get; }

        internal object SyncObject { get; }

        internal void SetAsCompleted(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1452, 3869, 4670);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4017, 4088) || true) && (f_1452_4021_4032())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 4017, 4088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4066, 4073);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 4017, 4088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4110, 4120);

                lock (f_1452_4110_4120())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4154, 4496) || true) && (f_1452_4158_4169())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 4154, 4496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4211, 4218);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 4154, 4496);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 4154, 4496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4300, 4322);

                        Exception = exception;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4344, 4363);

                        IsCompleted = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4458, 4477);

                        f_1452_4458_4476(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 4154, 4496);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4575, 4659) || true) && (f_1452_4579_4587() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 4575, 4659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4629, 4644);

                    //f_1452_4629_4643(Callback, this);
                    Callback(this);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 4629, 4643);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 4575, 4659);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1452, 3869, 4670);

                bool
                f_1452_4021_4032()
                {
                    var return_v = IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 4021, 4032);
                    return return_v;
                }


                object
                f_1452_4110_4120()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 4110, 4120);
                    return return_v;
                }


                bool
                f_1452_4158_4169()
                {
                    var return_v = IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 4158, 4169);
                    return return_v;
                }


                int
                f_1452_4458_4476(System.Management.Automation.Runspaces.AsyncResult
                this_param)
                {
                    this_param.SignalWaitHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 4458, 4476);
                    return 0;
                }


                System.AsyncCallback
                f_1452_4579_4587()
                {
                    var return_v = Callback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 4579, 4587);
                    return return_v;
                }


                System.AsyncCallback
                f_1452_4629_4637()
                {
                    var return_v = Callback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 4629, 4637);
                    return return_v;
                }


                int
                f_1452_4629_4643(System.Management.Automation.Runspaces.AsyncResult
                this_param, System.Management.Automation.Runspaces.AsyncResult
                ar)
                {
                    this_param.Callback((System.IAsyncResult)ar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 4629, 4643);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 3869, 4670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 3869, 4670);
            }
        }

        internal void Release()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1452, 4796, 4976);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4844, 4965) || true) && (f_1452_4848_4860_M(!IsCompleted))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 4844, 4965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4894, 4913);

                    IsCompleted = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 4931, 4950);

                    f_1452_4931_4949(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 4844, 4965);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1452, 4796, 4976);

                bool
                f_1452_4848_4860_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 4848, 4860);
                    return return_v;
                }


                int
                f_1452_4931_4949(System.Management.Automation.Runspaces.AsyncResult
                this_param)
                {
                    this_param.SignalWaitHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 4931, 4949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 4796, 4976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 4796, 4976);
            }
        }

        internal void SignalWaitHandle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1452, 5147, 5400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5210, 5220);
                lock (f_1452_5210_5220())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5254, 5374) || true) && (_completedWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 5254, 5374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5328, 5355);

                        f_1452_5328_5354(_completedWaitHandle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 5254, 5374);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1452, 5147, 5400);

                object
                f_1452_5210_5220()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 5210, 5220);
                    return return_v;
                }


                bool
                f_1452_5328_5354(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 5328, 5354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 5147, 5400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 5147, 5400);
            }
        }

        internal void EndInvoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1452, 5539, 6783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5589, 5638);

                _invokeOnThreadEvent = f_1452_5612_5637(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5698, 5785);

                WaitHandle[]
                waitHandles = new WaitHandle[2] { f_1452_5745_5760(), _invokeOnThreadEvent }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5799, 5819);

                bool
                waiting = true
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5833, 6390) || true) && (waiting)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 5833, 6390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5881, 5929);

                        int
                        waitIndex = f_1452_5897_5928(waitHandles)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 5949, 6375) || true) && (waitIndex == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 5949, 6375);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6009, 6025);

                            waiting = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 5949, 6375);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 5949, 6375);
                            // Invoke callback on thread.
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6210, 6248);

                                f_1452_6210_6247(this, _invokeCallbackState);
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1452, 6293, 6356);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1452, 6293, 6356);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 5949, 6375);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 5833, 6390);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1452, 5833, 6390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1452, 5833, 6390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6406, 6432);

                f_1452_6406_6431(f_1452_6406_6421());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6446, 6474);

                _completedWaitHandle = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6509, 6540);

                f_1452_6509_6539(
                            _invokeOnThreadEvent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6554, 6582);

                _invokeOnThreadEvent = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6686, 6772) || true) && (f_1452_6690_6699() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 6686, 6772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 6741, 6757);

                    throw f_1452_6747_6756();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 6686, 6772);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1452, 5539, 6783);

                System.Threading.AutoResetEvent
                f_1452_5612_5637(bool
                initialState)
                {
                    var return_v = new System.Threading.AutoResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 5612, 5637);
                    return return_v;
                }


                System.Threading.WaitHandle
                f_1452_5745_5760()
                {
                    var return_v = AsyncWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 5745, 5760);
                    return return_v;
                }


                int
                f_1452_5897_5928(System.Threading.WaitHandle[]
                waitHandles)
                {
                    var return_v = WaitHandle.WaitAny(waitHandles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 5897, 5928);
                    return return_v;
                }


                int
                f_1452_6210_6247(System.Management.Automation.Runspaces.AsyncResult
                this_param, object
                state)
                {
                    this_param._invokeCallback(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 6210, 6247);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1452_6406_6421()
                {
                    var return_v = AsyncWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 6406, 6421);
                    return return_v;
                }


                int
                f_1452_6406_6431(System.Threading.WaitHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 6406, 6431);
                    return 0;
                }


                int
                f_1452_6509_6539(System.Threading.AutoResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 6509, 6539);
                    return 0;
                }


                System.Exception
                f_1452_6690_6699()
                {
                    var return_v = Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 6690, 6699);
                    return return_v;
                }


                System.Exception
                f_1452_6747_6756()
                {
                    var return_v = Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1452, 6747, 6756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 5539, 6783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 5539, 6783);
            }
        }

        internal bool InvokeCallbackOnThread(WaitCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1452, 7023, 7563);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7121, 7236) || true) && (callback == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 7121, 7236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7175, 7221);

                    throw f_1452_7181_7220("callback");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 7121, 7236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7252, 7279);

                _invokeCallback = callback;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7293, 7322);

                _invokeCallbackState = state;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7385, 7523) || true) && (_invokeOnThreadEvent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1452, 7385, 7523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7451, 7478);

                    f_1452_7451_7477(_invokeOnThreadEvent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7496, 7508);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1452, 7385, 7523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1452, 7539, 7552);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1452, 7023, 7563);

                System.Management.Automation.PSArgumentNullException
                f_1452_7181_7220(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 7181, 7220);
                    return return_v;
                }


                bool
                f_1452_7451_7477(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 7451, 7477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1452, 7023, 7563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 7023, 7563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AsyncResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1452, 425, 7592);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1452, 425, 7592);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1452, 425, 7592);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1452, 425, 7592);

        int
        f_1452_1442_1502(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 1442, 1502);
            return 0;
        }


        object
        f_1452_3623_3635()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1452, 3623, 3635);
            return return_v;
        }

    }
}
