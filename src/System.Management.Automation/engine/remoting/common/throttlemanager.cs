// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{

    /// <summary>
    /// Defines the different states of the operation.
    /// </summary>
    internal enum OperationState
    {
        /// <summary>
        /// Start operation completed successfully.
        /// </summary>
        StartComplete = 0,

        /// <summary>
        /// Stop operation completed successfully.
        /// </summary>
        StopComplete = 1,
    }
    internal sealed class OperationStateEventArgs : EventArgs
    {
        internal OperationState OperationState { get; set; }

        internal EventArgs BaseEvent { get; set; }

        public OperationStateEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1632, 859, 1267);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 1010, 1062);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 1218, 1260);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1632, 859, 1267);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 859, 1267);
        }


        static OperationStateEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1632, 859, 1267);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1632, 859, 1267);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 859, 1267);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1632, 859, 1267);
    }
    internal abstract class IThrottleOperation
    {
        internal abstract void StartOperation();

        internal abstract void StopOperation();

        /// <summary>
        /// Event which will be triggered when the operation is complete. It is
        /// assumed that all the operations performed by StartOperation and
        /// StopOperation are asynchronous. The submitter of operations may
        /// subscribe to this event to know when it's complete (or it can handle
        /// the synchronization with its scheduler) and the throttle
        /// manager will subscribe to this event to know that it's complete
        /// and to start the operation on the next item.
        /// </summary>
        internal abstract event EventHandler<OperationStateEventArgs>
OperationComplete
;

        internal bool IgnoreStop
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 5434, 5504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 5470, 5489);

                    return _ignoreStop;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 5434, 5504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 5385, 5601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 5385, 5601);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 5520, 5590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 5556, 5575);

                    _ignoreStop = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 5520, 5590);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 5385, 5601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 5385, 5601);
                }
            }
        }

        private bool _ignoreStop;

        internal bool RunspaceDebuggingEnabled
        {
            get;
            set;
        }

        internal bool RunspaceDebugStepInEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Event raised when operation runspace enters a debugger stopped state.
        /// </summary>
        internal event EventHandler<StartRunspaceDebugProcessingEventArgs>
RunspaceDebugStop
;

        internal void RaiseRunspaceDebugStopEvent(System.Management.Automation.Runspaces.Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 6543, 6766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 6667, 6755);

                f_1632_6667_6754(RunspaceDebugStop, this, f_1632_6702_6753(runspace));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 6543, 6766);

                System.Management.Automation.StartRunspaceDebugProcessingEventArgs
                f_1632_6702_6753(System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    var return_v = new System.Management.Automation.StartRunspaceDebugProcessingEventArgs(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 6702, 6753);
                    return return_v;
                }


                int
                f_1632_6667_6754(System.EventHandler<System.Management.Automation.StartRunspaceDebugProcessingEventArgs>
                eventHandler, System.Management.Automation.Remoting.IThrottleOperation
                sender, System.Management.Automation.StartRunspaceDebugProcessingEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.StartRunspaceDebugProcessingEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 6667, 6754);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 6543, 6766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 6543, 6766);
            }
        }

        public IThrottleOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1632, 2108, 6795);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 5626, 5645);
            this._ignoreStop = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 5825, 5921);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 6063, 6161);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1632, 2108, 6795);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 2108, 6795);
        }


        static IThrottleOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1632, 2108, 6795);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1632, 2108, 6795);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 2108, 6795);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1632, 2108, 6795);
    }
    internal class ThrottleManager : IDisposable
    {
        internal int ThrottleLimit
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 8508, 8689);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 8544, 8674) || true) && (value > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1632, 8548, 8590) && value <= s_THROTTLE_LIMIT_MAX))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 8544, 8674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 8632, 8655);

                        _throttleLimit = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 8544, 8674);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 8508, 8689);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 8457, 8789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 8457, 8789);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 8705, 8778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 8741, 8763);

                    return _throttleLimit;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 8705, 8778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 8457, 8789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 8457, 8789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int _throttleLimit;

        internal void SubmitOperations(List<IThrottleOperation> operations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 9311, 10286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 9409, 9420);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 9612, 10164) || true) && (!_submitComplete)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 9612, 10164);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 9721, 10025);
                            foreach (IThrottleOperation operation in f_1632_9762_9772_I(operations))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 9721, 10025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 9822, 9944);

                                f_1632_9822_9943(operation != null, "Operation submitComplete to throttle manager cannot be null");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 9970, 10002);

                                f_1632_9970_10001(_operationsQueue, operation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 9721, 10025);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1632, 1, 305);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1632, 1, 305);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 9612, 10164);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 9612, 10164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 10107, 10145);

                        throw f_1632_10113_10144();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 9612, 10164);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 10248, 10275);

                f_1632_10248_10274(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 9311, 10286);

                int
                f_1632_9822_9943(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 9822, 9943);
                    return 0;
                }


                int
                f_1632_9970_10001(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 9970, 10001);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                f_1632_9762_9772_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 9762, 9772);
                    return return_v;
                }


                System.InvalidOperationException
                f_1632_10113_10144()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 10113, 10144);
                    return return_v;
                }


                int
                f_1632_10248_10274(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.StartOperationsFromQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 10248, 10274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 9311, 10286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 9311, 10286);
            }
        }

        internal void AddOperation(IThrottleOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 10463, 11291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 10588, 10599);
                // add item to the queue
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 10791, 11166) || true) && (!_submitComplete)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 10791, 11166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 10853, 10971);

                        f_1632_10853_10970(operation != null, "Operation submitComplete to throttle manager cannot be null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 10995, 11027);

                        f_1632_10995_11026(
                                            _operationsQueue, operation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 10791, 11166);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 10791, 11166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 11109, 11147);

                        throw f_1632_11115_11146();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 10791, 11166);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 11253, 11280);

                f_1632_11253_11279(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 10463, 11291);

                int
                f_1632_10853_10970(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 10853, 10970);
                    return 0;
                }


                int
                f_1632_10995_11026(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 10995, 11026);
                    return 0;
                }


                System.InvalidOperationException
                f_1632_11115_11146()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 11115, 11146);
                    return return_v;
                }


                int
                f_1632_11253_11279(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.StartOperationsFromQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 11253, 11279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 10463, 11291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 10463, 11291);
            }
        }

        internal void StopAllOperations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 11676, 14521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 11802, 11828);

                bool
                needToReturn = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 11850, 11861);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 11895, 12089) || true) && (!_stopping)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 11895, 12089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 11951, 11968);

                        _stopping = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 11895, 12089);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 11895, 12089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12050, 12070);

                        needToReturn = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 11895, 12089);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12120, 12239) || true) && (needToReturn)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 12120, 12239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12170, 12199);

                    f_1632_12170_12198(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12217, 12224);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 12120, 12239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12255, 12306);

                IThrottleOperation[]
                startOperationsInProcessArray
                = default(IThrottleOperation[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12328, 12339);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12435, 12458);

                    _submitComplete = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12619, 12644);

                    f_1632_12619_12643(
                                    // Clear all pending operations in queue so that they are not
                                    // scheduled when a stop operation completes
                                    _operationsQueue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12781, 12889);

                    startOperationsInProcessArray =
                                            new IThrottleOperation[f_1632_12861_12887(_startOperationQueue)];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 12907, 12966);

                    f_1632_12907_12965(_startOperationQueue, startOperationsInProcessArray);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 13054, 14184);
                        foreach (IThrottleOperation operation in f_1632_13095_13124_I(startOperationsInProcessArray))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 13054, 14184);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 14078, 14113);

                            f_1632_14078_14112(                    // When iterating through the array of operations in process
                                                                   // it is quite possible that a runspace gets to the open state
                                                                   // before stop is actually called on it. In that case, the
                                                                   // OperationCompleteHandler will remove it from the
                                                                   // operationsInProcess queue. Now when the runspace is closed
                                                                   // the same handler will try removing it again and so there will
                                                                   // be an exception. Hence adding it a second time before stop
                                                                   // will ensure that the operation is available in the queue for
                                                                   // removal. In case the stop succeeds before start succeeds then
                                                                   // both will get removed (it goes without saying that there cannot
                                                                   // be a situation where start succeeds after stop succeeded)
                                                _stopOperationQueue, operation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 14137, 14165);

                            operation.IgnoreStop = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 13054, 14184);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1632, 1, 1131);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1632, 1, 1131);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 14215, 14360);
                    foreach (IThrottleOperation operation in f_1632_14256_14285_I(startOperationsInProcessArray))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 14215, 14360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 14319, 14345);

                        f_1632_14319_14344(operation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 14215, 14360);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1632, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1632, 1, 146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 14481, 14510);

                f_1632_14481_14509(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 11676, 14521);

                int
                f_1632_12170_12198(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.RaiseThrottleManagerEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 12170, 12198);
                    return 0;
                }


                int
                f_1632_12619_12643(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 12619, 12643);
                    return 0;
                }


                int
                f_1632_12861_12887(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 12861, 12887);
                    return return_v;
                }


                int
                f_1632_12907_12965(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation[]
                array)
                {
                    this_param.CopyTo(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 12907, 12965);
                    return 0;
                }


                int
                f_1632_14078_14112(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 14078, 14112);
                    return 0;
                }


                System.Management.Automation.Remoting.IThrottleOperation[]
                f_1632_13095_13124_I(System.Management.Automation.Remoting.IThrottleOperation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 13095, 13124);
                    return return_v;
                }


                int
                f_1632_14319_14344(System.Management.Automation.Remoting.IThrottleOperation
                this_param)
                {
                    this_param.StopOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 14319, 14344);
                    return 0;
                }


                System.Management.Automation.Remoting.IThrottleOperation[]
                f_1632_14256_14285_I(System.Management.Automation.Remoting.IThrottleOperation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 14256, 14285);
                    return return_v;
                }


                int
                f_1632_14481_14509(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.RaiseThrottleManagerEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 14481, 14509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 11676, 14521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 11676, 14521);
            }
        }

        internal void StopOperation(IThrottleOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 14705, 16080);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 14952, 15032) || true) && (f_1632_14956_14976(operation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 14952, 15032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15010, 15017);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 14952, 15032);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15161, 15574) || true) && (f_1632_15165_15200(_operationsQueue, operation) != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 15161, 15574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15246, 15257);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15299, 15540) || true) && (f_1632_15303_15338(_operationsQueue, operation) != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 15299, 15540);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15394, 15429);

                            f_1632_15394_15428(_operationsQueue, operation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15455, 15484);

                            f_1632_15455_15483(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15510, 15517);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 15299, 15540);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 15161, 15574);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15829, 15840);

                // The operation has already started, then add it
                // to the inprocess queue and call stop. Refer to
                // comment in StopAllOperations() as to why this is
                // being added a second time
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15874, 15909);

                    f_1632_15874_15908(_stopOperationQueue, operation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 15929, 15957);

                    operation.IgnoreStop = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 16043, 16069);

                f_1632_16043_16068(
                            // stop the operation outside of the lock
                            operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 14705, 16080);

                bool
                f_1632_14956_14976(System.Management.Automation.Remoting.IThrottleOperation
                this_param)
                {
                    var return_v = this_param.IgnoreStop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 14956, 14976);
                    return return_v;
                }


                int
                f_1632_15165_15200(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 15165, 15200);
                    return return_v;
                }


                int
                f_1632_15303_15338(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 15303, 15338);
                    return return_v;
                }


                bool
                f_1632_15394_15428(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 15394, 15428);
                    return return_v;
                }


                int
                f_1632_15455_15483(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.RaiseThrottleManagerEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 15455, 15483);
                    return 0;
                }


                int
                f_1632_15874_15908(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 15874, 15908);
                    return 0;
                }


                int
                f_1632_16043_16068(System.Management.Automation.Remoting.IThrottleOperation
                this_param)
                {
                    this_param.StopOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 16043, 16068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 14705, 16080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 14705, 16080);
            }
        }

        internal void EndSubmitOperations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 16235, 16440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 16301, 16312);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 16346, 16369);

                    _submitComplete = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 16400, 16429);

                f_1632_16400_16428(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 16235, 16440);

                int
                f_1632_16400_16428(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.RaiseThrottleManagerEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 16400, 16428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 16235, 16440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 16235, 16440);
            }
        }



        /// <summary>
        /// Event raised when throttling all operations is complete.
        /// </summary>
        internal event EventHandler<EventArgs>
ThrottleComplete
;

        public ThrottleManager()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1632, 16888, 17174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 8813, 8854);
                this._throttleLimit = s_DEFAULT_THROTTLE_LIMIT;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 23507, 23523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 23699, 23719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 23894, 23913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 24050, 24061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 24087, 24110);
                this._submitComplete = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 24204, 24221);
                this._stopping = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 16937, 16987);

                _operationsQueue = f_1632_16956_16986();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 17001, 17055);

                _startOperationQueue = f_1632_17024_17054();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 17069, 17122);

                _stopOperationQueue = f_1632_17091_17121();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 17136, 17163);

                _syncObject = f_1632_17150_17162();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1632, 16888, 17174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 16888, 17174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 16888, 17174);
            }
        }

        private void OperationCompleteHandler(object source, OperationStateEventArgs stateEventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 17700, 20339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18080, 18091);
                // An item has completed operation. If it's a start operation which completed
                // remove the instance from the startOperationqueue. If it's a stop operation
                // which completed, then remove the instance from both queues
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18125, 18185);

                    IThrottleOperation
                    operation = source as IThrottleOperation
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18205, 18273);

                    f_1632_18205_18272(operation != null, "Source of event should not be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18293, 18308);

                    int
                    index = -1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18328, 20000) || true) && (f_1632_18332_18361(stateEventArgs) == OperationState.StartComplete)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 18328, 20000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18813, 18861);

                        index = f_1632_18821_18860(_startOperationQueue, operation);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18883, 19008) || true) && (index != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 18883, 19008);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 18948, 18985);

                            f_1632_18948_18984(_startOperationQueue, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 18883, 19008);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 18328, 20000);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 18328, 20000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 19308, 19356);

                        index = f_1632_19316_19355(_startOperationQueue, operation);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 19378, 19503) || true) && (index != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 19378, 19503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 19443, 19480);

                            f_1632_19443_19479(_startOperationQueue, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 19378, 19503);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 19527, 19574);

                        index = f_1632_19535_19573(_stopOperationQueue, operation);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 19596, 19720) || true) && (index != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 19596, 19720);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 19661, 19697);

                            f_1632_19661_19696(_stopOperationQueue, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 19596, 19720);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 19953, 19981);

                        operation.IgnoreStop = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 18328, 20000);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20164, 20193);

                f_1632_20164_20192(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20299, 20328);

                f_1632_20299_20327(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 17700, 20339);

                int
                f_1632_18205_18272(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 18205, 18272);
                    return 0;
                }


                System.Management.Automation.Remoting.OperationState
                f_1632_18332_18361(System.Management.Automation.Remoting.OperationStateEventArgs
                this_param)
                {
                    var return_v = this_param.OperationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 18332, 18361);
                    return return_v;
                }


                int
                f_1632_18821_18860(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 18821, 18860);
                    return return_v;
                }


                int
                f_1632_18948_18984(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 18948, 18984);
                    return 0;
                }


                int
                f_1632_19316_19355(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 19316, 19355);
                    return return_v;
                }


                int
                f_1632_19443_19479(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 19443, 19479);
                    return 0;
                }


                int
                f_1632_19535_19573(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 19535, 19573);
                    return return_v;
                }


                int
                f_1632_19661_19696(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 19661, 19696);
                    return 0;
                }


                int
                f_1632_20164_20192(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.RaiseThrottleManagerEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 20164, 20192);
                    return 0;
                }


                int
                f_1632_20299_20327(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.StartOneOperationFromQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 20299, 20327);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 17700, 20339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 17700, 20339);
            }
        }

        private void StartOneOperationFromQueue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 20472, 21158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20538, 20574);

                IThrottleOperation
                operation = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20596, 20607);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20641, 21019) || true) && (f_1632_20645_20667(_operationsQueue) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 20641, 21019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20713, 20745);

                        operation = f_1632_20725_20744(_operationsQueue, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20767, 20796);

                        f_1632_20767_20795(_operationsQueue, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20818, 20942);

                        operation.OperationComplete +=
                                                new EventHandler<OperationStateEventArgs>(OperationCompleteHandler);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 20964, 21000);

                        f_1632_20964_20999(_startOperationQueue, operation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 20641, 21019);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21050, 21147) || true) && (operation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 21050, 21147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21105, 21132);

                    f_1632_21105_21131(operation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 21050, 21147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 20472, 21158);

                int
                f_1632_20645_20667(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 20645, 20667);
                    return return_v;
                }


                System.Management.Automation.Remoting.IThrottleOperation
                f_1632_20725_20744(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 20725, 20744);
                    return return_v;
                }


                int
                f_1632_20767_20795(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 20767, 20795);
                    return 0;
                }


                int
                f_1632_20964_20999(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.Remoting.IThrottleOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 20964, 20999);
                    return 0;
                }


                int
                f_1632_21105_21131(System.Management.Automation.Remoting.IThrottleOperation
                this_param)
                {
                    this_param.StartOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 21105, 21131);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 20472, 21158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 20472, 21158);
            }
        }

        private void StartOperationsFromQueue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 21285, 22042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21349, 21382);

                int
                operationsInProcessCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21396, 21425);

                int
                operationsQueueCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21447, 21458);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21492, 21546);

                    operationsInProcessCount = f_1632_21519_21545(_startOperationQueue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21564, 21610);

                    operationsQueueCount = f_1632_21587_21609(_operationsQueue);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21641, 21702);

                int
                remainingCap = _throttleLimit - operationsInProcessCount
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21718, 22031) || true) && (remainingCap > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 21718, 22031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21772, 21868);

                    int
                    numOperations = (DynAbs.Tracing.TraceSender.Conditional_F1(1632, 21792, 21829) || (((remainingCap > operationsQueueCount) && DynAbs.Tracing.TraceSender.Conditional_F2(1632, 21832, 21852)) || DynAbs.Tracing.TraceSender.Conditional_F3(1632, 21855, 21867))) ? operationsQueueCount : remainingCap
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21897, 21902);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21888, 22016) || true) && (i < numOperations)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21923, 21926)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 21888, 22016))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 21888, 22016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 21968, 21997);

                            f_1632_21968_21996(this);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1632, 1, 129);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1632, 1, 129);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 21718, 22031);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 21285, 22042);

                int
                f_1632_21519_21545(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 21519, 21545);
                    return return_v;
                }


                int
                f_1632_21587_21609(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 21587, 21609);
                    return return_v;
                }


                int
                f_1632_21968_21996(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.StartOneOperationFromQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 21968, 21996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 21285, 22042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 21285, 22042);
            }
        }

        private void RaiseThrottleManagerEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 22177, 22906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 22243, 22269);

                bool
                readyToRaise = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 22291, 22302);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 22485, 22748) || true) && (_submitComplete && (DynAbs.Tracing.TraceSender.Expression_True(1632, 22489, 22560) && f_1632_22529_22555(_startOperationQueue) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1632, 22489, 22615) && f_1632_22585_22610(_stopOperationQueue) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1632, 22489, 22667) && f_1632_22640_22662(_operationsQueue) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 22485, 22748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 22709, 22729);

                        readyToRaise = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 22485, 22748);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 22779, 22895) || true) && (readyToRaise)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 22779, 22895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 22829, 22880);

                    f_1632_22829_22879(ThrottleComplete, this, EventArgs.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 22779, 22895);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 22177, 22906);

                int
                f_1632_22529_22555(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 22529, 22555);
                    return return_v;
                }


                int
                f_1632_22585_22610(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 22585, 22610);
                    return return_v;
                }


                int
                f_1632_22640_22662(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1632, 22640, 22662);
                    return return_v;
                }


                int
                f_1632_22829_22879(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.ThrottleManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 22829, 22879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 22177, 22906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 22177, 22906);
            }
        }

        private static int s_DEFAULT_THROTTLE_LIMIT;

        private static int s_THROTTLE_LIMIT_MAX;

        private List<IThrottleOperation> _operationsQueue;

        private List<IThrottleOperation> _startOperationQueue;

        private List<IThrottleOperation> _stopOperationQueue;

        private object _syncObject;

        private bool _submitComplete;

        private bool _stopping;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 24569, 24682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 24615, 24629);

                f_1632_24615_24628(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 24645, 24671);

                f_1632_24645_24670(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 24569, 24682);

                int
                f_1632_24615_24628(System.Management.Automation.Remoting.ThrottleManager
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 24615, 24628);
                    return 0;
                }


                int
                f_1632_24645_24670(System.Management.Automation.Remoting.ThrottleManager
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 24645, 24670);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 24569, 24682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 24569, 24682);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1632, 24966, 25120);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 25027, 25109) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1632, 25027, 25109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 25074, 25094);

                    f_1632_25074_25093(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1632, 25027, 25109);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1632, 24966, 25120);

                int
                f_1632_25074_25093(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.StopAllOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 25074, 25093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1632, 24966, 25120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 24966, 25120);
            }
        }

        static ThrottleManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1632, 8228, 25171);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 23168, 23197);
            s_DEFAULT_THROTTLE_LIMIT = 32;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1632, 23342, 23377);
            s_THROTTLE_LIMIT_MAX = int.MaxValue;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1632, 8228, 25171);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1632, 8228, 25171);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1632, 8228, 25171);

        System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        f_1632_16956_16986()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 16956, 16986);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        f_1632_17024_17054()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 17024, 17054);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        f_1632_17091_17121()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 17091, 17121);
            return return_v;
        }


        object
        f_1632_17150_17162()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1632, 17150, 17162);
            return return_v;
        }

    }




}
