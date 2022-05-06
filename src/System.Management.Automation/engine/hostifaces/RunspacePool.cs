// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces.Internal;
using System.Runtime.Serialization;
using System.Threading;

using PSHost = System.Management.Automation.Host.PSHost;

namespace System.Management.Automation.Runspaces
{
    [Serializable]
    public class InvalidRunspacePoolStateException : SystemException
    {
        public InvalidRunspacePoolStateException()
        : base(
        f_1484_914_984_C(f_1484_914_984(f_1484_932_983())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 831, 1017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6485, 6502);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6701, 6719);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 831, 1017);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 831, 1017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 831, 1017);
            }
        }

        public InvalidRunspacePoolStateException(string message)
        : base(f_1484_1366_1373_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 1289, 1396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6485, 6502);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6701, 6719);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 1289, 1396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 1289, 1396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 1289, 1396);
            }
        }

        public InvalidRunspacePoolStateException(string message, Exception innerException)
        : base(f_1484_1907_1914_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 1804, 1953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6485, 6502);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6701, 6719);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 1804, 1953);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 1804, 1953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 1804, 1953);
            }
        }

        internal InvalidRunspacePoolStateException
                (
                    string message,
                    RunspacePoolState currentState,
                    RunspacePoolState expectedState
                )
        : base(f_1484_2620_2627_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 2416, 2738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6485, 6502);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6701, 6719);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 2653, 2684);

                _expectedState = expectedState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 2698, 2727);

                _currentState = currentState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 2416, 2738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 2416, 2738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 2416, 2738);
            }
        }

        protected
                InvalidRunspacePoolStateException(SerializationInfo info, StreamingContext context)
        : base(f_1484_3566_3570_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 3443, 3602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6485, 6502);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6701, 6719);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 3443, 3602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 3443, 3602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 3443, 3602);
            }
        }

        public RunspacePoolState CurrentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 3926, 3998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 3962, 3983);

                    return _currentState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 3926, 3998);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 3864, 4009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 3864, 4009);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RunspacePoolState ExpectedState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 4239, 4312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 4275, 4297);

                    return _expectedState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 4239, 4312);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 4176, 4323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 4176, 4323);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal InvalidRunspaceStateException ToInvalidRunspaceStateException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 4453, 4938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 4550, 4712);

                InvalidRunspaceStateException
                exception = f_1484_4592_4711(f_1484_4644_4687(), this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 4726, 4803);

                exception.CurrentState = f_1484_4751_4802(f_1484_4784_4801(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 4817, 4896);

                exception.ExpectedState = f_1484_4843_4895(f_1484_4876_4894(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 4910, 4927);

                return exception;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 4453, 4938);

                string
                f_1484_4644_4687()
                {
                    var return_v = RunspaceStrings.InvalidRunspaceStateGeneral;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 4644, 4687);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1484_4592_4711(string
                message, System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                innerException)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 4592, 4711);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1484_4784_4801(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                this_param)
                {
                    var return_v = this_param.CurrentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 4784, 4801);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1484_4751_4802(System.Management.Automation.Runspaces.RunspacePoolState
                state)
                {
                    var return_v = RunspacePoolStateToRunspaceState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 4751, 4802);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1484_4876_4894(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                this_param)
                {
                    var return_v = this_param.ExpectedState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 4876, 4894);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1484_4843_4895(System.Management.Automation.Runspaces.RunspacePoolState
                state)
                {
                    var return_v = RunspacePoolStateToRunspaceState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 4843, 4895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 4453, 4938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 4453, 4938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RunspaceState RunspacePoolStateToRunspaceState(RunspacePoolState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1484, 5059, 6308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5170, 6297);

                switch (state)
                {

                    case RunspacePoolState.BeforeOpen:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5273, 5305);

                        return RunspaceState.BeforeOpen;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Opening:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5378, 5407);

                        return RunspaceState.Opening;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Opened:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5479, 5507);

                        return RunspaceState.Opened;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Closed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5579, 5607);

                        return RunspaceState.Closed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Closing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5680, 5709);

                        return RunspaceState.Closing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Broken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5781, 5809);

                        return RunspaceState.Broken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Disconnecting:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 5888, 5923);

                        return RunspaceState.Disconnecting;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Disconnected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6001, 6035);

                        return RunspaceState.Disconnected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    case RunspacePoolState.Connecting:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6111, 6143);

                        return RunspaceState.Connecting;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 5170, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6193, 6251);

                        f_1484_6193_6250(false, "Unexpected RunspacePoolState");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 6273, 6282);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 5170, 6297);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1484, 5059, 6308);

                int
                f_1484_6193_6250(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 6193, 6250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 5059, 6308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 5059, 6308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [NonSerialized]
        private RunspacePoolState _currentState;

        [NonSerialized]
        private RunspacePoolState _expectedState;

        static InvalidRunspacePoolStateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1484, 603, 6727);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1484, 603, 6727);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 603, 6727);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1484, 603, 6727);

        static string
        f_1484_932_983()
        {
            var return_v = RunspacePoolStrings.InvalidRunspacePoolStateGeneral;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 932, 983);
            return return_v;
        }


        static string
        f_1484_914_984(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 914, 984);
            return return_v;
        }


        static string
        f_1484_914_984_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1484, 831, 1017);
            return return_v;
        }


        static string
        f_1484_1366_1373_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1484, 1289, 1396);
            return return_v;
        }


        static string
        f_1484_1907_1914_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1484, 1804, 1953);
            return return_v;
        }


        static string
        f_1484_2620_2627_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1484, 2416, 2738);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1484_3566_3570_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1484, 3443, 3602);
            return return_v;
        }

    }

    /// <summary>
    /// Defines various states of a runspace pool.
    /// </summary>
    public enum RunspacePoolState
    {
        /// <summary>
        /// Beginning state upon creation.
        /// </summary>
        BeforeOpen = 0,
        /// <summary>
        /// A RunspacePool is being created.
        /// </summary>
        Opening = 1,
        /// <summary>
        /// The RunspacePool is created and valid.
        /// </summary>
        Opened = 2,
        /// <summary>
        /// The RunspacePool is closed.
        /// </summary>
        Closed = 3,
        /// <summary>
        /// The RunspacePool is being closed.
        /// </summary>
        Closing = 4,
        /// <summary>
        /// The RunspacePool has been disconnected abnormally.
        /// </summary>
        Broken = 5,

        /// <summary>
        /// The RunspacePool is being disconnected.
        /// </summary>
        Disconnecting = 6,

        /// <summary>
        /// The RunspacePool has been disconnected.
        /// </summary>
        Disconnected = 7,

        /// <summary>
        /// The RunspacePool is being connected.
        /// </summary>
        Connecting = 8,
    }
    public sealed class RunspacePoolStateChangedEventArgs : EventArgs
    {
        internal RunspacePoolStateChangedEventArgs(RunspacePoolState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 8455, 8621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 9063, 9122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 8547, 8610);

                RunspacePoolStateInfo = f_1484_8571_8609(state, null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 8455, 8621);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 8455, 8621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 8455, 8621);
            }
        }

        internal RunspacePoolStateChangedEventArgs(RunspacePoolStateInfo stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 8726, 8871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 9063, 9122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 8826, 8860);

                RunspacePoolStateInfo = stateInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 8726, 8871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 8726, 8871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 8726, 8871);
            }
        }

        public RunspacePoolStateInfo RunspacePoolStateInfo { get; }

        static RunspacePoolStateChangedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1484, 8168, 9205);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1484, 8168, 9205);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 8168, 9205);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1484, 8168, 9205);

        System.Management.Automation.RunspacePoolStateInfo
        f_1484_8571_8609(System.Management.Automation.Runspaces.RunspacePoolState
        state, System.Exception
        reason)
        {
            var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 8571, 8609);
            return return_v;
        }

    }
    internal sealed class RunspaceCreatedEventArgs : EventArgs
    {
        internal RunspaceCreatedEventArgs(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 9579, 9687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 9760, 9795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 9656, 9676);

                Runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 9579, 9687);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 9579, 9687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 9579, 9687);
            }
        }

        internal Runspace Runspace { get; }

        static RunspaceCreatedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1484, 9326, 9824);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1484, 9326, 9824);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 9326, 9824);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1484, 9326, 9824);
    }



    /// <summary>
    /// Defines runspace pool availability.
    /// </summary>
    public enum RunspacePoolAvailability
    {
        /// <summary>
        /// RunspacePool is not in the Opened state.
        /// </summary>
        None = 0,

        /// <summary>
        /// RunspacePool is Opened and available to accept commands.
        /// </summary>
        Available = 1,

        /// <summary>
        /// RunspacePool on the server is connected to another
        /// client and is not available to this client for connection
        /// or running commands.
        /// </summary>
        Busy = 2
    }



    /// <summary>
    /// Defines runspace capabilities.
    /// </summary>
    public enum RunspacePoolCapability
    {
        /// <summary>
        /// No additional capabilities beyond a default runspace.
        /// </summary>
        Default = 0x0,

        /// <summary>
        /// Runspacepool and remoting layer supports disconnect/connect feature.
        /// </summary>
        SupportsDisconnect = 0x1
    }
    internal sealed class RunspacePoolAsyncResult : AsyncResult
    {
        internal RunspacePoolAsyncResult(Guid ownerId, AsyncCallback callback, object state,
                    bool isCalledFromOpenAsync)
        : base(f_1484_12089_12096_C(ownerId), callback, state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 11943, 12200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 12404, 12452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 12139, 12189);

                IsAssociatedWithAsyncOpen = isCalledFromOpenAsync;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 11943, 12200);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 11943, 12200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 11943, 12200);
            }
        }

        internal bool IsAssociatedWithAsyncOpen { get; }

        static RunspacePoolAsyncResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1484, 11191, 12481);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1484, 11191, 12481);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 11191, 12481);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1484, 11191, 12481);

        static System.Guid
        f_1484_12089_12096_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1484, 11943, 12200);
            return return_v;
        }

    }
    internal sealed class GetRunspaceAsyncResult : AsyncResult
    {
        private bool _isActive;

        internal GetRunspaceAsyncResult(Guid ownerId, AsyncCallback callback, object state)
        : base(f_1484_13340_13347_C(ownerId), callback, state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 13236, 13418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 12725, 12734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 13740, 13780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 13390, 13407);

                _isActive = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 13236, 13418);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 13236, 13418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 13236, 13418);
            }
        }

        internal Runspace Runspace { get; set; }

        internal bool IsActive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 13985, 14130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 14027, 14037);
                    lock (f_1484_14027_14037())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 14079, 14096);

                        return _isActive;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 13985, 14130);

                    object
                    f_1484_14027_14037()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 14027, 14037);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 13938, 14303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 13938, 14303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 14146, 14292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 14188, 14198);
                    lock (f_1484_14188_14198())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 14240, 14258);

                        _isActive = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 14146, 14292);

                    object
                    f_1484_14188_14198()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 14188, 14198);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 13938, 14303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 13938, 14303);
                }
            }
        }

        internal void DoComplete(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 14696, 14791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 14759, 14780);

                f_1484_14759_14779(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 14696, 14791);

                int
                f_1484_14759_14779(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 14759, 14779);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 14696, 14791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 14696, 14791);
            }
        }

        static GetRunspaceAsyncResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1484, 12605, 14820);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1484, 12605, 14820);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 12605, 14820);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1484, 12605, 14820);

        static System.Guid
        f_1484_13340_13347_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1484, 13236, 13418);
            return return_v;
        }

    }
    public sealed class RunspacePool : IDisposable
    {
        private RunspacePoolInternal _internalPool;

        private object _syncObject;
        private event EventHandler<RunspacePoolStateChangedEventArgs>
InternalStateChanged = null
;
        private event EventHandler<PSEventArgs>
InternalForwardEvent = null
;
        private event EventHandler<RunspaceCreatedEventArgs>
InternalRunspaceCreated = null
;

        internal RunspacePool(int minRunspaces, int maxRunspaces, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 16525, 16870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15108, 15121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15147, 15173);
                this._syncObject = f_1484_15161_15173();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 47760, 47800);
                this.IsRemote = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 16784, 16859);

                _internalPool = f_1484_16800_16858(minRunspaces, maxRunspaces, host);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 16525, 16870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 16525, 16870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 16525, 16870);
            }
        }

        internal RunspacePool(int minRunspaces, int maxRunspaces,
                    InitialSessionState initialSessionState, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 18082, 18519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15108, 15121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15147, 15173);
                this._syncObject = f_1484_15161_15173();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 47760, 47800);
                this.IsRemote = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 18395, 18508);

                _internalPool = f_1484_18411_18507(minRunspaces, maxRunspaces, initialSessionState, host);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 18082, 18519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 18082, 18519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 18082, 18519);
            }
        }

        internal RunspacePool(
                    int minRunspaces,
                    int maxRunspaces,
                    TypeTable typeTable,
                    PSHost host,
                    PSPrimitiveDictionary applicationArguments,
                    RunspaceConnectionInfo connectionInfo,
                    string name = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 19052, 19662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15108, 15121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15147, 15173);
                this._syncObject = f_1484_15161_15173();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 47760, 47800);
                this.IsRemote = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 19363, 19619);

                _internalPool = f_1484_19379_19618(minRunspaces, maxRunspaces, typeTable, host, applicationArguments, connectionInfo, name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 19635, 19651);

                IsRemote = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 19052, 19662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 19052, 19662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 19052, 19662);
            }
        }

        internal RunspacePool(
                    bool isDisconnected,
                    Guid instanceId,
                    string name,
                    ConnectCommandInfo[] connectCommands,
                    RunspaceConnectionInfo connectionInfo,
                    PSHost host,
                    TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1484, 20552, 21280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15108, 15121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 15147, 15173);
                this._syncObject = f_1484_15161_15173();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 47760, 47800);
                this.IsRemote = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 20946, 21073) || true) && (!(connectionInfo is WSManConnectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 20946, 21073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 21024, 21058);

                    throw f_1484_21030_21057();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 20946, 21073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 21089, 21237);

                _internalPool = f_1484_21105_21236(instanceId, name, isDisconnected, connectCommands, connectionInfo, host, typeTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 21253, 21269);

                IsRemote = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1484, 20552, 21280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 20552, 21280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 20552, 21280);
            }
        }

        public Guid InstanceId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 21564, 21647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 21600, 21632);

                    return f_1484_21607_21631(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 21564, 21647);

                    System.Guid
                    f_1484_21607_21631(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.InstanceId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 21607, 21631);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 21517, 21658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 21517, 21658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDisposed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 21842, 21925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 21878, 21910);

                    return f_1484_21885_21909(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 21842, 21925);

                    bool
                    f_1484_21885_21909(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.IsDisposed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 21885, 21909);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 21795, 21936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 21795, 21936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RunspacePoolStateInfo RunspacePoolStateInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 22124, 22218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 22160, 22203);

                    return f_1484_22167_22202(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 22124, 22218);

                    System.Management.Automation.RunspacePoolStateInfo
                    f_1484_22167_22202(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.RunspacePoolStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 22167, 22202);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 22049, 22229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 22049, 22229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public InitialSessionState InitialSessionState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 22466, 22558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 22502, 22543);

                    return f_1484_22509_22542(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 22466, 22558);

                    System.Management.Automation.Runspaces.InitialSessionState
                    f_1484_22509_22542(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.InitialSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 22509, 22542);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 22395, 22569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 22395, 22569);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RunspaceConnectionInfo ConnectionInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 22789, 22876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 22825, 22861);

                    return f_1484_22832_22860(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 22789, 22876);

                    System.Management.Automation.Runspaces.RunspaceConnectionInfo
                    f_1484_22832_22860(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.ConnectionInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 22832, 22860);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 22720, 22887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 22720, 22887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TimeSpan CleanupInterval
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 23066, 23111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 23072, 23109);

                    return f_1484_23079_23108(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 23066, 23111);

                    System.TimeSpan
                    f_1484_23079_23108(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.CleanupInterval;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 23079, 23108);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 23010, 23184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 23010, 23184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 23127, 23173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 23133, 23171);

                    _internalPool.CleanupInterval = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 23127, 23173);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 23010, 23184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 23010, 23184);
                }
            }
        }

        public RunspacePoolAvailability RunspacePoolAvailability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 23373, 23427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 23379, 23425);

                    return f_1484_23386_23424(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 23373, 23427);

                    System.Management.Automation.Runspaces.RunspacePoolAvailability
                    f_1484_23386_23424(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.RunspacePoolAvailability;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 23386, 23424);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 23292, 23438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 23292, 23438);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }



        /// <summary>
        /// Event raised when RunspacePoolState changes.
        /// </summary>
        public event EventHandler<RunspacePoolStateChangedEventArgs> StateChanged
        {

            add
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 23701, 24383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 23743, 23754);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 23796, 23845);

                        bool
                        firstEntry = (InternalStateChanged == null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 23867, 23897);

                        InternalStateChanged += value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 23919, 24349) || true) && (firstEntry)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 23919, 24349);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 24199, 24326);

                            _internalPool.StateChanged +=
                                                        new EventHandler<RunspacePoolStateChangedEventArgs>(OnStateChanged);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 23919, 24349);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 23701, 24383);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 23701, 24383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 23701, 24383);
                }
            }

            remove
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 24399, 24815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 24444, 24455);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 24497, 24527);

                        InternalStateChanged -= value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 24549, 24781) || true) && (InternalStateChanged == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 24549, 24781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 24631, 24758);

                            _internalPool.StateChanged -=
                                                        new EventHandler<RunspacePoolStateChangedEventArgs>(OnStateChanged);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 24549, 24781);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 24399, 24815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 24399, 24815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 24399, 24815);
                }
            }
        }

        private void OnStateChanged(object source, RunspacePoolStateChangedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 25025, 25884);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 25132, 25641) || true) && (f_1484_25136_25150() is NewProcessConnectionInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 25132, 25641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 25212, 25297);

                    NewProcessConnectionInfo
                    connectionInfo = f_1484_25254_25268() as NewProcessConnectionInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 25315, 25626) || true) && (f_1484_25319_25341(connectionInfo) != null && (DynAbs.Tracing.TraceSender.Expression_True(1484, 25319, 25522) && (f_1484_25375_25407(f_1484_25375_25401(args)) == RunspacePoolState.Opened || (DynAbs.Tracing.TraceSender.Expression_False(1484, 25375, 25521) || f_1484_25461_25493(f_1484_25461_25487(args)) == RunspacePoolState.Broken))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 25315, 25626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 25564, 25607);

                        f_1484_25564_25586(connectionInfo).RunspacePool = this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 25315, 25626);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 25132, 25641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 25829, 25873);

                f_1484_25829_25872(
                            // call any event handlers on this, replacing the
                            // internalPool sender with 'this' since receivers
                            // are expecting a RunspacePool
                            InternalStateChanged, this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 25025, 25884);

                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1484_25136_25150()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25136, 25150);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1484_25254_25268()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25254, 25268);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PowerShellProcessInstance
                f_1484_25319_25341(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25319, 25341);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1484_25375_25401(System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25375, 25401);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1484_25375_25407(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25375, 25407);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1484_25461_25487(System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25461, 25487);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1484_25461_25493(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25461, 25493);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PowerShellProcessInstance
                f_1484_25564_25586(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 25564, 25586);
                    return return_v;
                }


                int
                f_1484_25829_25872(System.EventHandler<System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs>
                eventHandler, System.Management.Automation.Runspaces.RunspacePool
                sender, System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 25829, 25872);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 25025, 25884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 25025, 25884);
            }
        }

        /// <summary>
        /// Event raised when one of the runspaces in the pool forwards an event to this instance.
        /// </summary>
        internal event EventHandler<PSEventArgs> ForwardEvent
        {

            add
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 26121, 26519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26163, 26174);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26216, 26263);

                        bool
                        firstEntry = InternalForwardEvent == null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26287, 26317);

                        InternalForwardEvent += value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26341, 26485) || true) && (firstEntry)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 26341, 26485);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26405, 26462);

                            _internalPool.ForwardEvent += OnInternalPoolForwardEvent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 26341, 26485);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 26121, 26519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 26121, 26519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 26121, 26519);
                }
            }

            remove
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 26535, 26883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26580, 26591);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26633, 26663);

                        InternalForwardEvent -= value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26687, 26849) || true) && (InternalForwardEvent == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 26687, 26849);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 26769, 26826);

                            _internalPool.ForwardEvent -= OnInternalPoolForwardEvent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 26687, 26849);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 26535, 26883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 26535, 26883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 26535, 26883);
                }
            }
        }

        private void OnInternalPoolForwardEvent(object sender, PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 27026, 27151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27120, 27140);

                f_1484_27120_27139(this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 27026, 27151);

                int
                f_1484_27120_27139(System.Management.Automation.Runspaces.RunspacePool
                this_param, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.OnEventForwarded(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 27120, 27139);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 27026, 27151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 27026, 27151);
            }
        }

        private void OnEventForwarded(PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 27254, 27477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27323, 27375);

                EventHandler<PSEventArgs>
                eh = InternalForwardEvent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27391, 27466) || true) && (eh != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 27391, 27466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27439, 27451);

                    f_1484_27439_27450(eh, this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 27391, 27466);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 27254, 27477);

                int
                f_1484_27439_27450(System.EventHandler<System.Management.Automation.PSEventArgs>
                this_param, System.Management.Automation.Runspaces.RunspacePool
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 27439, 27450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 27254, 27477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 27254, 27477);
            }
        }

        /// <summary>
        /// Event raised when a new Runspace is created by the pool.
        /// </summary>
        internal event EventHandler<RunspaceCreatedEventArgs> RunspaceCreated
        {

            add
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 27700, 28312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27742, 27753);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27795, 27847);

                        bool
                        firstEntry = (InternalRunspaceCreated == null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27869, 27902);

                        InternalRunspaceCreated += value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 27924, 28278) || true) && (firstEntry)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 27924, 28278);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 28204, 28255);

                            _internalPool.RunspaceCreated += OnRunspaceCreated;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 27924, 28278);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 27700, 28312);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 27700, 28312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 27700, 28312);
                }
            }

            remove
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 28328, 28674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 28373, 28384);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 28426, 28459);

                        InternalRunspaceCreated -= value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 28481, 28640) || true) && (InternalRunspaceCreated == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 28481, 28640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 28566, 28617);

                            _internalPool.RunspaceCreated -= OnRunspaceCreated;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 28481, 28640);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 28328, 28674);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 28328, 28674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 28328, 28674);
                }
            }
        }

        private void OnRunspaceCreated(object source, RunspaceCreatedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 28886, 29217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 29159, 29206);

                f_1484_29159_29205(            // call any event handlers on this, replacing the
                                               // internalPool sender with 'this' since receivers
                                               // are expecting a RunspacePool
                            InternalRunspaceCreated, this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 28886, 29217);

                int
                f_1484_29159_29205(System.EventHandler<System.Management.Automation.Runspaces.RunspaceCreatedEventArgs>
                eventHandler, System.Management.Automation.Runspaces.RunspacePool
                sender, System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Runspaces.RunspaceCreatedEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 29159, 29205);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 28886, 29217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 28886, 29217);
            }
        }

        public static RunspacePool[] GetRunspacePools(RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1484, 29911, 30083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 30020, 30072);

                return f_1484_30027_30071(connectionInfo, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1484, 29911, 30083);

                System.Management.Automation.Runspaces.RunspacePool[]
                f_1484_30027_30071(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = GetRunspacePools(connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 30027, 30071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 29911, 30083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 29911, 30083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RunspacePool[] GetRunspacePools(RunspaceConnectionInfo connectionInfo, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1484, 30766, 30951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 30888, 30940);

                return f_1484_30895_30939(connectionInfo, host, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1484, 30766, 30951);

                System.Management.Automation.Runspaces.RunspacePool[]
                f_1484_30895_30939(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = GetRunspacePools(connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 30895, 30939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 30766, 30951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 30766, 30951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RunspacePool[] GetRunspacePools(RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1484, 31697, 31941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 31840, 31930);

                return f_1484_31847_31929(connectionInfo, host, typeTable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1484, 31697, 31941);

                System.Management.Automation.Runspaces.RunspacePool[]
                f_1484_31847_31929(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = RemoteRunspacePoolInternal.GetRemoteRunspacePools(connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 31847, 31929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 31697, 31941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 31697, 31941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Disconnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 32169, 32256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 32218, 32245);

                f_1484_32218_32244(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 32169, 32256);

                int
                f_1484_32218_32244(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.Disconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 32218, 32244);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 32169, 32256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 32169, 32256);
            }
        }

        public IAsyncResult BeginDisconnect(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 32604, 32767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 32702, 32756);

                return f_1484_32709_32755(_internalPool, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 32604, 32767);

                System.IAsyncResult
                f_1484_32709_32755(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginDisconnect(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 32709, 32755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 32604, 32767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 32604, 32767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EndDisconnect(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 32983, 33111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 33059, 33100);

                f_1484_33059_33099(_internalPool, asyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 32983, 33111);

                int
                f_1484_33059_33099(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.IAsyncResult
                asyncResult)
                {
                    this_param.EndDisconnect(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 33059, 33099);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 32983, 33111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 32983, 33111);
            }
        }

        public void Connect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 33271, 33352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 33317, 33341);

                f_1484_33317_33340(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 33271, 33352);

                int
                f_1484_33317_33340(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.Connect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 33317, 33340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 33271, 33352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 33271, 33352);
            }
        }

        public IAsyncResult BeginConnect(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 33600, 33757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 33695, 33746);

                return f_1484_33702_33745(_internalPool, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 33600, 33757);

                System.IAsyncResult
                f_1484_33702_33745(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginConnect(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 33702, 33745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 33600, 33757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 33600, 33757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EndConnect(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 33970, 34092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 34043, 34081);

                f_1484_34043_34080(_internalPool, asyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 33970, 34092);

                int
                f_1484_34043_34080(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.IAsyncResult
                asyncResult)
                {
                    this_param.EndConnect(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 34043, 34080);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 33970, 34092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 33970, 34092);
            }
        }

        public Collection<PowerShell> CreateDisconnectedPowerShells()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 34368, 34522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 34454, 34511);

                return f_1484_34461_34510(_internalPool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 34368, 34522);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
                f_1484_34461_34510(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.RunspacePool
                runspacePool)
                {
                    var return_v = this_param.CreateDisconnectedPowerShells(runspacePool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 34461, 34510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 34368, 34522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 34368, 34522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RunspacePoolCapability GetCapabilities()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 34684, 34806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 34756, 34795);

                return f_1484_34763_34794(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 34684, 34806);

                System.Management.Automation.Runspaces.RunspacePoolCapability
                f_1484_34763_34794(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.GetCapabilities();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 34763, 34794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 34684, 34806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 34684, 34806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool SetMaxRunspaces(int maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 35510, 35642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 35580, 35631);

                return f_1484_35587_35630(_internalPool, maxRunspaces);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 35510, 35642);

                bool
                f_1484_35587_35630(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, int
                maxRunspaces)
                {
                    var return_v = this_param.SetMaxRunspaces(maxRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 35587, 35630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 35510, 35642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 35510, 35642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMaxRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 35880, 35983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 35933, 35972);

                return f_1484_35940_35971(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 35880, 35983);

                int
                f_1484_35940_35971(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.GetMaxRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 35940, 35971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 35880, 35983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 35880, 35983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool SetMinRunspaces(int minRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 36591, 36723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 36661, 36712);

                return f_1484_36668_36711(_internalPool, minRunspaces);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 36591, 36723);

                bool
                f_1484_36668_36711(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, int
                minRunspaces)
                {
                    var return_v = this_param.SetMinRunspaces(minRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 36668, 36711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 36591, 36723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 36591, 36723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMinRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 36961, 37064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 37014, 37053);

                return f_1484_37021_37052(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 36961, 37064);

                int
                f_1484_37021_37052(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.GetMinRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 37021, 37052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 36961, 37064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 36961, 37064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetAvailableRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 37335, 37450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 37394, 37439);

                return f_1484_37401_37438(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 37335, 37450);

                int
                f_1484_37401_37438(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.GetAvailableRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 37401, 37438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 37335, 37450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 37335, 37450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Open()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 37765, 37840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 37808, 37829);

                f_1484_37808_37828(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 37765, 37840);

                int
                f_1484_37808_37828(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 37808, 37828);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 37765, 37840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 37765, 37840);
            }
        }

        public IAsyncResult BeginOpen(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 38519, 38670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 38611, 38659);

                return f_1484_38618_38658(_internalPool, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 38519, 38670);

                System.IAsyncResult
                f_1484_38618_38658(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginOpen(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 38618, 38658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 38519, 38670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 38519, 38670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EndOpen(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 39369, 39485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 39439, 39474);

                f_1484_39439_39473(_internalPool, asyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 39369, 39485);

                int
                f_1484_39439_39473(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.IAsyncResult
                asyncResult)
                {
                    this_param.EndOpen(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 39439, 39473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 39369, 39485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 39369, 39485);
            }
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 40051, 40128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 40095, 40117);

                f_1484_40095_40116(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 40051, 40128);

                int
                f_1484_40095_40116(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 40095, 40116);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 40051, 40128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 40051, 40128);
            }
        }

        public IAsyncResult BeginClose(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 40936, 41089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 41029, 41078);

                return f_1484_41036_41077(_internalPool, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 40936, 41089);

                System.IAsyncResult
                f_1484_41036_41077(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginClose(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 41036, 41077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 40936, 41089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 40936, 41089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EndClose(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 41536, 41654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 41607, 41643);

                f_1484_41607_41642(_internalPool, asyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 41536, 41654);

                int
                f_1484_41607_41642(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.IAsyncResult
                asyncResult)
                {
                    this_param.EndClose(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 41607, 41642);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 41536, 41654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 41536, 41654);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 41760, 41887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 41806, 41834);

                f_1484_41806_41833(_internalPool, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 41850, 41876);

                f_1484_41850_41875(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 41760, 41887);

                int
                f_1484_41806_41833(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 41806, 41833);
                    return 0;
                }


                int
                f_1484_41850_41875(System.Management.Automation.Runspaces.RunspacePool
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 41850, 41875);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 41760, 41887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 41760, 41887);
            }
        }

        public PSPrimitiveDictionary GetApplicationPrivateData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 42670, 42811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 42751, 42800);

                return f_1484_42758_42799(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 42670, 42811);

                System.Management.Automation.PSPrimitiveDictionary
                f_1484_42758_42799(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.GetApplicationPrivateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 42758, 42799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 42670, 42811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 42670, 42811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSThreadOptions ThreadOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 43405, 43491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 43441, 43476);

                    return f_1484_43448_43475(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 43405, 43491);

                    System.Management.Automation.Runspaces.PSThreadOptions
                    f_1484_43448_43475(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.ThreadOptions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 43448, 43475);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 43344, 43843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 43344, 43843);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 43507, 43832);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 43543, 43761) || true) && (f_1484_43547_43579(f_1484_43547_43573(this)) != RunspacePoolState.BeforeOpen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 43543, 43761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 43653, 43742);

                        throw f_1484_43659_43741(f_1484_43697_43740());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 43543, 43761);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 43781, 43817);

                    _internalPool.ThreadOptions = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 43507, 43832);

                    System.Management.Automation.RunspacePoolStateInfo
                    f_1484_43547_43573(System.Management.Automation.Runspaces.RunspacePool
                    this_param)
                    {
                        var return_v = this_param.RunspacePoolStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 43547, 43573);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspacePoolState
                    f_1484_43547_43579(System.Management.Automation.RunspacePoolStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 43547, 43579);
                        return return_v;
                    }


                    string
                    f_1484_43697_43740()
                    {
                        var return_v = RunspacePoolStrings.ChangePropertyAfterOpen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 43697, 43740);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                    f_1484_43659_43741(string
                    message)
                    {
                        var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 43659, 43741);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 43344, 43843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 43344, 43843);
                }
            }
        }

        public ApartmentState ApartmentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 44385, 44472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 44421, 44457);

                    return f_1484_44428_44456(_internalPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 44385, 44472);

                    System.Threading.ApartmentState
                    f_1484_44428_44456(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                    this_param)
                    {
                        var return_v = this_param.ApartmentState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 44428, 44456);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 44324, 44825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 44324, 44825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 44488, 44814);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 44524, 44742) || true) && (f_1484_44528_44560(f_1484_44528_44554(this)) != RunspacePoolState.BeforeOpen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 44524, 44742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 44634, 44723);

                        throw f_1484_44640_44722(f_1484_44678_44721());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 44524, 44742);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 44762, 44799);

                    _internalPool.ApartmentState = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 44488, 44814);

                    System.Management.Automation.RunspacePoolStateInfo
                    f_1484_44528_44554(System.Management.Automation.Runspaces.RunspacePool
                    this_param)
                    {
                        var return_v = this_param.RunspacePoolStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 44528, 44554);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspacePoolState
                    f_1484_44528_44560(System.Management.Automation.RunspacePoolStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 44528, 44560);
                        return return_v;
                    }


                    string
                    f_1484_44678_44721()
                    {
                        var return_v = RunspacePoolStrings.ChangePropertyAfterOpen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1484, 44678, 44721);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                    f_1484_44640_44722(string
                    message)
                    {
                        var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 44640, 44722);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 44324, 44825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 44324, 44825);
                }
            }
        }

        internal IAsyncResult BeginGetRunspace(
                    AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 45449, 45630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 45564, 45619);

                return f_1484_45571_45618(_internalPool, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 45449, 45630);

                System.IAsyncResult
                f_1484_45571_45618(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginGetRunspace(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 45571, 45618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 45449, 45630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 45449, 45630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CancelGetRunspace(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 45825, 45963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 45907, 45952);

                f_1484_45907_45951(_internalPool, asyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 45825, 45963);

                int
                f_1484_45907_45951(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.IAsyncResult
                asyncResult)
                {
                    this_param.CancelGetRunspace(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 45907, 45951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 45825, 45963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 45825, 45963);
            }
        }

        internal Runspace EndGetRunspace(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 46626, 46769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 46709, 46758);

                return f_1484_46716_46757(_internalPool, asyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 46626, 46769);

                System.Management.Automation.Runspaces.Runspace
                f_1484_46716_46757(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.IAsyncResult
                asyncResult)
                {
                    var return_v = this_param.EndGetRunspace(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 46716, 46757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 46626, 46769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 46626, 46769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReleaseRunspace(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 47512, 47636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 47585, 47625);

                f_1484_47585_47624(_internalPool, runspace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 47512, 47636);

                int
                f_1484_47585_47624(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.ReleaseRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 47585, 47624);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 47512, 47636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 47512, 47636);
            }
        }

        internal bool IsRemote { get; }

        internal RemoteRunspacePoolInternal RemoteRunspacePoolInternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 48035, 48337);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 48071, 48322) || true) && (_internalPool is RemoteRunspacePoolInternal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 48071, 48322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 48160, 48209);

                        return (RemoteRunspacePoolInternal)_internalPool;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 48071, 48322);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1484, 48071, 48322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 48291, 48303);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1484, 48071, 48322);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 48035, 48337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 47948, 48348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 47948, 48348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AssertPoolIsOpen()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1484, 48360, 48461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1484, 48417, 48450);

                f_1484_48417_48449(_internalPool);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1484, 48360, 48461);

                int
                f_1484_48417_48449(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.AssertPoolIsOpen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 48417, 48449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1484, 48360, 48461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 48360, 48461);
            }
        }

        static RunspacePool()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1484, 14984, 48490);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1484, 14984, 48490);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1484, 14984, 48490);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1484, 14984, 48490);

        object
        f_1484_15161_15173()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 15161, 15173);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
        f_1484_16800_16858(int
        minRunspaces, int
        maxRunspaces, System.Management.Automation.Host.PSHost
        host)
        {
            var return_v = new System.Management.Automation.Runspaces.Internal.RunspacePoolInternal(minRunspaces, maxRunspaces, host);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 16800, 16858);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
        f_1484_18411_18507(int
        minRunspaces, int
        maxRunspaces, System.Management.Automation.Runspaces.InitialSessionState
        initialSessionState, System.Management.Automation.Host.PSHost
        host)
        {
            var return_v = new System.Management.Automation.Runspaces.Internal.RunspacePoolInternal(minRunspaces, maxRunspaces, initialSessionState, host);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 18411, 18507);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        f_1484_19379_19618(int
        minRunspaces, int
        maxRunspaces, System.Management.Automation.Runspaces.TypeTable
        typeTable, System.Management.Automation.Host.PSHost
        host, System.Management.Automation.PSPrimitiveDictionary
        applicationArguments, System.Management.Automation.Runspaces.RunspaceConnectionInfo
        connectionInfo, string
        name)
        {
            var return_v = new System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal(minRunspaces, maxRunspaces, typeTable, host, applicationArguments, connectionInfo, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 19379, 19618);
            return return_v;
        }


        System.NotSupportedException
        f_1484_21030_21057()
        {
            var return_v = new System.NotSupportedException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 21030, 21057);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        f_1484_21105_21236(System.Guid
        instanceId, string
        name, bool
        isDisconnected, System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
        connectCommands, System.Management.Automation.Runspaces.RunspaceConnectionInfo
        connectionInfo, System.Management.Automation.Host.PSHost
        host, System.Management.Automation.Runspaces.TypeTable
        typeTable)
        {
            var return_v = new System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal(instanceId, name, isDisconnected, connectCommands, connectionInfo, host, typeTable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1484, 21105, 21236);
            return return_v;
        }

    }

}
