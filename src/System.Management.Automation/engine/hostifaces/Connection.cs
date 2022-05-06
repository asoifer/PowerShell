// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces
{
    [Serializable]
    public class InvalidRunspaceStateException : SystemException
    {
        public InvalidRunspaceStateException()
        : base(
        f_1455_950_1012_C(f_1455_950_1012(f_1455_968_1011())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 871, 1045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4740, 4757);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4948, 4966);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 871, 1045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 871, 1045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 871, 1045);
            }
        }

        public InvalidRunspaceStateException(string message)
        : base(f_1455_1387_1394_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 1318, 1417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4740, 4757);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4948, 4966);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 1318, 1417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 1318, 1417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 1318, 1417);
            }
        }

        public InvalidRunspaceStateException(string message, Exception innerException)
        : base(f_1455_2032_2039_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 1937, 2078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4740, 4757);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4948, 4966);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 1937, 2078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 1937, 2078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 1937, 2078);
            }
        }

        internal InvalidRunspaceStateException
                (
                    string message,
                    RunspaceState currentState,
                    RunspaceState expectedState
                )
        : base(f_1455_2712_2719_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 2524, 2830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4740, 4757);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4948, 4966);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 2745, 2776);

                _expectedState = expectedState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 2790, 2819);

                _currentState = currentState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 2524, 2830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 2524, 2830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 2524, 2830);
            }
        }

        protected InvalidRunspaceStateException(SerializationInfo info, StreamingContext context)
        : base(f_1455_3668_3672_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 3562, 3704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4740, 4757);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4948, 4966);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 3562, 3704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 3562, 3704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 3562, 3704);
            }
        }

        public RunspaceState CurrentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 4000, 4072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4036, 4057);

                    return _currentState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 4000, 4072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 3942, 4181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 3942, 4181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 4088, 4170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4133, 4155);

                    _currentState = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 4088, 4170);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 3942, 4181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 3942, 4181);
                }
            }
        }

        public RunspaceState ExpectedState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 4389, 4462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4425, 4447);

                    return _expectedState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 4389, 4462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 4330, 4572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 4330, 4572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 4478, 4561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 4523, 4546);

                    _expectedState = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 4478, 4561);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 4330, 4572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 4330, 4572);
                }
            }
        }

        [NonSerialized]
        private RunspaceState _currentState;

        [NonSerialized]
        private RunspaceState _expectedState;

        static InvalidRunspaceStateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1455, 653, 4974);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1455, 653, 4974);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 653, 4974);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1455, 653, 4974);

        static string
        f_1455_968_1011()
        {
            var return_v = RunspaceStrings.InvalidRunspaceStateGeneral;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 968, 1011);
            return return_v;
        }


        static string
        f_1455_950_1012(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 950, 1012);
            return return_v;
        }


        static string
        f_1455_950_1012_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1455, 871, 1045);
            return return_v;
        }


        static string
        f_1455_1387_1394_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1455, 1318, 1417);
            return return_v;
        }


        static string
        f_1455_2032_2039_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1455, 1937, 2078);
            return return_v;
        }


        static string
        f_1455_2712_2719_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1455, 2524, 2830);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1455_3668_3672_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1455, 3562, 3704);
            return return_v;
        }

    }



    /// <summary>
    /// Defines various states of runspace.
    /// </summary>
    public enum RunspaceState
    {
        /// <summary>
        /// Beginning state upon creation.
        /// </summary>
        BeforeOpen = 0,
        /// <summary>
        /// A runspace is being established.
        /// </summary>
        Opening = 1,
        /// <summary>
        /// The runspace is established and valid.
        /// </summary>
        Opened = 2,
        /// <summary>
        /// The runspace is closed or has not been established.
        /// </summary>
        Closed = 3,
        /// <summary>
        /// The runspace is being closed.
        /// </summary>
        Closing = 4,
        /// <summary>
        /// The runspace has been disconnected abnormally.
        /// </summary>
        Broken = 5,
        /// <summary>
        /// The runspace is being disconnected.
        /// </summary>
        Disconnecting = 6,
        /// <summary>
        /// The runspace is disconnected.
        /// </summary>
        Disconnected = 7,
        /// <summary>
        /// The runspace is Connecting.
        /// </summary>
        Connecting = 8
    }

    /// <summary>
    /// These options control whether a new thread is created when a command is executed within a runspace.
    /// </summary>
    public enum PSThreadOptions
    {
        /// <summary>
        /// Use the default options: UseNewThread for local Runspace, ReuseThread for local RunspacePool, server settings for remote Runspace and RunspacePool.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Creates a new thread for each invocation.
        /// </summary>
        UseNewThread = 1,

        /// <summary>
        /// Creates a new thread for the first invocation and then re-uses
        /// that thread in subsequent invocations.
        /// </summary>
        ReuseThread = 2,

        /// <summary>
        /// Doesn't create a new thread; the execution occurs on the
        /// thread that calls Invoke.
        /// </summary>
        /// <remarks>
        /// This option is not valid for asynchronous calls
        /// </remarks>
        UseCurrentThread = 3
    };
    public sealed class RunspaceStateInfo
    {
        internal RunspaceStateInfo(RunspaceState state)
        : this(f_1455_7805_7810_C(state), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 7737, 7839);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 7737, 7839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 7737, 7839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 7737, 7839);
            }
        }

        internal RunspaceStateInfo(RunspaceState state, Exception reason)
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 8180, 8347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 8913, 8948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 9286, 9318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 8292, 8306);

                State = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 8320, 8336);

                Reason = reason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 8180, 8347);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 8180, 8347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 8180, 8347);
            }
        }

        internal RunspaceStateInfo(RunspaceStateInfo runspaceStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 8565, 8744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 8913, 8948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 9286, 9318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 8653, 8685);

                State = f_1455_8661_8684(runspaceStateInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 8699, 8733);

                Reason = f_1455_8708_8732(runspaceStateInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 8565, 8744);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 8565, 8744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 8565, 8744);
            }
        }

        public RunspaceState State { get; }

        public Exception Reason { get; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 9487, 9580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 9545, 9569);

                return f_1455_9552_9568(f_1455_9552_9557());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 9487, 9580);

                System.Management.Automation.Runspaces.RunspaceState
                f_1455_9552_9557()
                {
                    var return_v = State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 9552, 9557);
                    return return_v;
                }


                string
                f_1455_9552_9568(System.Management.Automation.Runspaces.RunspaceState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 9552, 9568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 9487, 9580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 9487, 9580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal RunspaceStateInfo Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 9722, 9827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 9781, 9816);

                return f_1455_9788_9815(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 9722, 9827);

                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1455_9788_9815(System.Management.Automation.Runspaces.RunspaceStateInfo
                runspaceStateInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceStateInfo(runspaceStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 9788, 9815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 9722, 9827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 9722, 9827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RunspaceStateInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1455, 7464, 9905);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1455, 7464, 9905);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 7464, 9905);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1455, 7464, 9905);

        static System.Management.Automation.Runspaces.RunspaceState
        f_1455_7805_7810_C(System.Management.Automation.Runspaces.RunspaceState
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1455, 7737, 7839);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspaceState
        f_1455_8661_8684(System.Management.Automation.Runspaces.RunspaceStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 8661, 8684);
            return return_v;
        }


        System.Exception
        f_1455_8708_8732(System.Management.Automation.Runspaces.RunspaceStateInfo
        this_param)
        {
            var return_v = this_param.Reason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 8708, 8732);
            return return_v;
        }

    }
    public sealed class RunspaceStateEventArgs : EventArgs
    {
        internal RunspaceStateEventArgs(RunspaceStateInfo runspaceStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 10520, 10822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 11145, 11196);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 10613, 10757) || true) && (runspaceStateInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 10613, 10757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 10676, 10742);

                    throw f_1455_10682_10741("runspaceStateInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 10613, 10757);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 10773, 10811);

                RunspaceStateInfo = runspaceStateInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 10520, 10822);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 10520, 10822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 10520, 10822);
            }
        }

        public RunspaceStateInfo RunspaceStateInfo { get; }

        static RunspaceStateEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1455, 10074, 11243);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1455, 10074, 11243);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 10074, 11243);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1455, 10074, 11243);

        System.Management.Automation.PSArgumentNullException
        f_1455_10682_10741(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 10682, 10741);
            return return_v;
        }

    }

    /// <summary>
    /// Enum to indicate whether a Runspace is busy or available.
    /// </summary>
    public enum RunspaceAvailability
    {
        /// <summary>
        /// The Runspace is not been in the Opened state.
        /// </summary>
        None = 0,

        /// <summary>
        /// The Runspace is available to execute commands.
        /// </summary>
        Available,

        /// <summary>
        /// The Runspace is available to execute nested commands.
        /// </summary>
        AvailableForNestedCommand,

        /// <summary>
        /// The Runspace is busy executing a command.
        /// </summary>
        Busy,

        /// <summary>
        /// Applies only to remote runspace case.  The remote runspace
        /// is currently in a Debugger Stop mode and requires a debugger
        /// SetDebuggerAction() call to continue.
        /// </summary>
        RemoteDebug
    }
    public sealed class RunspaceAvailabilityEventArgs : EventArgs
    {
        internal RunspaceAvailabilityEventArgs(RunspaceAvailability runspaceAvailability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 12441, 12602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 12729, 12786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 12547, 12591);

                RunspaceAvailability = runspaceAvailability;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 12441, 12602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 12441, 12602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 12441, 12602);
            }
        }

        public RunspaceAvailability RunspaceAvailability { get; }

        static RunspaceAvailabilityEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1455, 12363, 12793);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1455, 12363, 12793);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 12363, 12793);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1455, 12363, 12793);
    }



    /// <summary>
    /// Defines runspace capabilities.
    /// </summary>
    public enum RunspaceCapability
    {
        /// <summary>
        /// No additional capabilities beyond a default runspace.
        /// </summary>
        Default = 0x0,

        /// <summary>
        /// Runspace and remoting layer supports disconnect/connect feature.
        /// </summary>
        SupportsDisconnect = 0x1,

        /// <summary>
        /// Runspace is based on a named pipe transport.
        /// </summary>
        NamedPipeTransport = 0x2,

        /// <summary>
        /// Runspace is based on a VM socket transport.
        /// </summary>
        VMSocketTransport = 0x4,

        /// <summary>
        /// Runspace is based on SSH transport.
        /// </summary>
        SSHTransport = 0x8
    }
    public abstract class Runspace : IDisposable
    {
        private static int s_globalId;

        private Stack<PowerShell> _runningPowerShells;

        private PowerShell _baseRunningPowerShell;

        private object _syncObject;

        internal Runspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 14305, 14899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14041, 14060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14090, 14112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14138, 14149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 19994, 20041);
                this.apartmentState = Runspace.DefaultApartmentState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 22394, 22720);
                this.InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 23228, 23280);
                this.SkipUserProfile = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 24018, 24116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 24277, 24370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 24490, 24566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 24660, 24739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 25664, 25722);
                this.EngineActivityId = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 61411, 61503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 63592, 63607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14415, 14475);

                Id = f_1455_14420_14474(ref s_globalId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14489, 14574);

                Name = "Runspace" + f_1455_14509_14573(f_1455_14509_14511(), f_1455_14521_14572());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14588, 14634);

                _runningPowerShells = f_1455_14610_14633();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14648, 14675);

                _syncObject = f_1455_14662_14674();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14763, 14775);

                // Keep track of this runspace until it is disposed.
                lock (s_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 14809, 14873);

                    f_1455_14809_14872(s_runspaceDictionary, f_1455_14834_14836(), f_1455_14838_14871(this));
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 14305, 14899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 14305, 14899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 14305, 14899);
            }
        }

        static Runspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1455, 14991, 15191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 13994, 14004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 15530, 15568);
                t_threadSpecificDefaultRunspace = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 17287, 17304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18961, 19007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26286, 26306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26339, 26351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 15033, 15061);

                s_syncObject = f_1455_15048_15060();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 15075, 15151);

                s_runspaceDictionary = f_1455_15098_15150();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 15165, 15180);

                s_globalId = 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1455, 14991, 15191);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 14991, 15191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 14991, 15191);
            }
        }

        [ThreadStatic]
        private static Runspace t_threadSpecificDefaultRunspace;

        public static Runspace DefaultRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 15882, 15972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 15918, 15957);

                    return t_threadSpecificDefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 15882, 15972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 15819, 16347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 15819, 16347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 15988, 16336);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 16024, 16321) || true) && (value == null || (DynAbs.Tracing.TraceSender.Expression_False(1455, 16028, 16068) || f_1455_16045_16068_M(!value.RunspaceIsRemote)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 16024, 16321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 16110, 16150);

                        t_threadSpecificDefaultRunspace = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 16024, 16321);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 16024, 16321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 16232, 16302);

                        throw f_1455_16238_16301(f_1455_16268_16300());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 16024, 16321);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 15988, 16336);

                    bool
                    f_1455_16045_16068_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 16045, 16068);
                        return return_v;
                    }


                    string
                    f_1455_16268_16300()
                    {
                        var return_v = RunspaceStrings.RunspaceNotLocal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 16268, 16300);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_1455_16238_16301(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 16238, 16301);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 15819, 16347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 15819, 16347);
                }
            }
        }

        internal static Runspace PrimaryRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 16832, 16908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 16868, 16893);

                    return s_primaryRunspace;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 16832, 16908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 16767, 17251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 16767, 17251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 16924, 17240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 16960, 17047);

                    var
                    result = f_1455_16973_17046(ref s_primaryRunspace, value, null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 17065, 17225) || true) && (result != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 17065, 17225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 17125, 17206);

                        throw f_1455_17131_17205(f_1455_17163_17204());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 17065, 17225);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 16924, 17240);

                    System.Management.Automation.Runspaces.Runspace
                    f_1455_16973_17046(ref System.Management.Automation.Runspaces.Runspace
                    location1, System.Management.Automation.Runspaces.Runspace
                    value, System.Management.Automation.Runspaces.Runspace
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange<Runspace>(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 16973, 17046);
                        return return_v;
                    }


                    string
                    f_1455_17163_17204()
                    {
                        var return_v = RunspaceStrings.PrimaryRunspaceAlreadySet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 17163, 17204);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1455_17131_17205(string
                    message)
                    {
                        var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 17131, 17205);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 16767, 17251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 16767, 17251);
                }
            }
        }

        private static Runspace s_primaryRunspace;

        public static bool CanUseDefaultRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 18153, 18908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18189, 18254);

                    RunspaceBase
                    runspace = f_1455_18213_18237() as RunspaceBase
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18272, 18860) || true) && (runspace != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 18272, 18860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18334, 18400);

                        Pipeline
                        currentPipeline = f_1455_18361_18399(runspace)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18422, 18485);

                        LocalPipeline
                        localPipeline = currentPipeline as LocalPipeline
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18507, 18841) || true) && ((localPipeline != null) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 18511, 18591) && (f_1455_18539_18582(localPipeline) != null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 18507, 18841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18641, 18818);

                            return
                                                        (f_1455_18678_18737(f_1455_18678_18721(localPipeline)) == f_1455_18770_18816(f_1455_18770_18800()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 18507, 18841);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 18272, 18860);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 18880, 18893);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 18153, 18908);

                    System.Management.Automation.Runspaces.Runspace
                    f_1455_18213_18237()
                    {
                        var return_v = Runspace.DefaultRunspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 18213, 18237);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1455_18361_18399(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.GetCurrentlyRunningPipeline();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 18361, 18399);
                        return return_v;
                    }


                    System.Threading.Thread
                    f_1455_18539_18582(System.Management.Automation.Runspaces.LocalPipeline
                    this_param)
                    {
                        var return_v = this_param.NestedPipelineExecutionThread;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 18539, 18582);
                        return return_v;
                    }


                    System.Threading.Thread
                    f_1455_18678_18721(System.Management.Automation.Runspaces.LocalPipeline
                    this_param)
                    {
                        var return_v = this_param.NestedPipelineExecutionThread;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 18678, 18721);
                        return return_v;
                    }


                    int
                    f_1455_18678_18737(System.Threading.Thread
                    this_param)
                    {
                        var return_v = this_param.ManagedThreadId
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 18678, 18737);
                        return return_v;
                    }


                    System.Threading.Thread
                    f_1455_18770_18800()
                    {
                        var return_v = Threading.Thread.CurrentThread;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 18770, 18800);
                        return return_v;
                    }


                    int
                    f_1455_18770_18816(System.Threading.Thread
                    this_param)
                    {
                        var return_v = this_param.ManagedThreadId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 18770, 18816);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 17536, 18919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 17536, 18919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal const ApartmentState
        DefaultApartmentState = ApartmentState.Unknown
        ;

        public ApartmentState ApartmentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 19534, 19612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 19570, 19597);

                    return this.apartmentState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 19534, 19612);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 19473, 19959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 19473, 19959);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 19628, 19948);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 19664, 19885) || true) && (f_1455_19668_19696(f_1455_19668_19690(this)) != RunspaceState.BeforeOpen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 19664, 19885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 19766, 19866);

                        throw f_1455_19772_19865(f_1455_19806_19864(f_1455_19824_19863()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 19664, 19885);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 19905, 19933);

                    this.apartmentState = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 19628, 19948);

                    System.Management.Automation.Runspaces.RunspaceStateInfo
                    f_1455_19668_19690(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.RunspaceStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 19668, 19690);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceState
                    f_1455_19668_19696(System.Management.Automation.Runspaces.RunspaceStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 19668, 19696);
                        return return_v;
                    }


                    string
                    f_1455_19824_19863()
                    {
                        var return_v = RunspaceStrings.ChangePropertyAfterOpen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 19824, 19863);
                        return return_v;
                    }


                    string
                    f_1455_19806_19864(string
                    formatSpec, params object[]
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 19806, 19864);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.InvalidRunspaceStateException
                    f_1455_19772_19865(string
                    message)
                    {
                        var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 19772, 19865);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 19473, 19959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 19473, 19959);
                }
            }
        }

        private ApartmentState apartmentState;

        public abstract PSThreadOptions ThreadOptions
        {
            get;
            set;
        }

        public abstract Version Version
        {
            get;
        }

        public bool RunspaceIsRemote
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 21418, 21527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 21454, 21512);

                    return !(this is LocalRunspace || (DynAbs.Tracing.TraceSender.Expression_False(1455, 21463, 21510) || f_1455_21488_21502() == null));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 21418, 21527);

                    System.Management.Automation.Runspaces.RunspaceConnectionInfo
                    f_1455_21488_21502()
                    {
                        var return_v = ConnectionInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 21488, 21502);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 21365, 21538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 21365, 21538);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract RunspaceStateInfo RunspaceStateInfo
        {
            get;
        }

        public abstract RunspaceAvailability RunspaceAvailability
        {
            get;
            protected set;
        }

        public abstract InitialSessionState InitialSessionState
        {
            get;
        }

        public Guid InstanceId
        {
            get;

            // This id is also used to identify proxy and remote runspace objects.
            // We need to set this when reconstructing a remote runspace to connect
            // to an existing remote runspace.
            internal set;
        }

        internal System.Management.Automation.ExecutionContext ExecutionContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 23023, 23101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 23059, 23086);

                    return f_1455_23066_23085();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 23023, 23101);

                    System.Management.Automation.ExecutionContext
                    f_1455_23066_23085()
                    {
                        var return_v = GetExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 23066, 23085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 22927, 23112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 22927, 23112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool SkipUserProfile { get; set; }

        public abstract RunspaceConnectionInfo ConnectionInfo { get; }

        public abstract RunspaceConnectionInfo OriginalConnectionInfo { get; }

        public abstract JobManager JobManager { get; }

        public DateTime? DisconnectedOn
        {
            get;
            internal set;
        }

        public DateTime? ExpiresOn
        {
            get;
            internal set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            private set;
        }

        internal Version GetRemoteProtocolVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 24881, 25555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 24949, 24995);

                Version
                remoteProtocolVersionDeclaredByServer
                = default(Version);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 25009, 25299);

                bool
                isServerDeclarationValid = f_1455_25041_25298(f_1455_25092_25124(this), out remoteProtocolVersionDeclaredByServer, PSVersionInfo.PSVersionTableName, PSVersionInfo.PSRemotingProtocolVersionName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 25315, 25544) || true) && (isServerDeclarationValid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 25315, 25544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 25377, 25422);

                    return remoteProtocolVersionDeclaredByServer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 25315, 25544);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 25315, 25544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 25488, 25529);

                    return RemotingConstants.ProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 25315, 25544);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 24881, 25555);

                System.Management.Automation.PSPrimitiveDictionary
                f_1455_25092_25124(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetApplicationPrivateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 25092, 25124);
                    return return_v;
                }


                bool
                f_1455_25041_25298(System.Management.Automation.PSPrimitiveDictionary
                data, out System.Version
                result, params string[]
                keys)
                {
                    var return_v = PSPrimitiveDictionary.TryPathGet((System.Collections.IDictionary)data, out result, keys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 25041, 25298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 24881, 25555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 24881, 25555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Guid EngineActivityId { get; set; }

        internal static ReadOnlyDictionary<int, WeakReference<Runspace>> RunspaceDictionary
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 25943, 26201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 25985, 25997);
                    lock (s_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26039, 26167);

                        return f_1455_26046_26166(f_1455_26099_26165(s_runspaceDictionary));
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 25943, 26201);

                    System.Collections.Generic.Dictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
                    f_1455_26099_26165(System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
                    dictionary)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>((System.Collections.Generic.IDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>)dictionary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 26099, 26165);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
                    f_1455_26046_26166(System.Collections.Generic.Dictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
                    dictionary)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>((System.Collections.Generic.IDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>)dictionary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 26046, 26166);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 25835, 26212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 25835, 26212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static SortedDictionary<int, WeakReference<Runspace>> s_runspaceDictionary;

        private static object s_syncObject;

        internal static IReadOnlyList<Runspace> RunspaceList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 26540, 27127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26576, 26627);

                    List<Runspace>
                    runspaceList = f_1455_26606_26626()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26653, 26665);

                    lock (s_syncObject)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26707, 27019);
                            foreach (var item in f_1455_26728_26755_I(f_1455_26728_26755(s_runspaceDictionary)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 26707, 27019);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26805, 26823);

                                Runspace
                                runspace
                                = default(Runspace);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26849, 26996) || true) && (f_1455_26853_26884(item, out runspace))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 26849, 26996);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 26942, 26969);

                                    f_1455_26942_26968(runspaceList, runspace);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 26849, 26996);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 26707, 27019);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1455, 1, 313);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1455, 1, 313);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 27058, 27112);

                    return f_1455_27065_27111(runspaceList);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 26540, 27127);

                    System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                    f_1455_26606_26626()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 26606, 26626);
                        return return_v;
                    }


                    System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>.ValueCollection
                    f_1455_26728_26755(System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 26728, 26755);
                        return return_v;
                    }


                    bool
                    f_1455_26853_26884(System.WeakReference<System.Management.Automation.Runspaces.Runspace>
                    this_param, out System.Management.Automation.Runspaces.Runspace
                    target)
                    {
                        var return_v = this_param.TryGetTarget(out target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 26853, 26884);
                        return return_v;
                    }


                    int
                    f_1455_26942_26968(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                    this_param, System.Management.Automation.Runspaces.Runspace
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 26942, 26968);
                        return 0;
                    }


                    System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>.ValueCollection
                    f_1455_26728_26755_I(System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 26728, 26755);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Runspaces.Runspace>
                    f_1455_27065_27111(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Runspaces.Runspace>((System.Collections.Generic.IList<System.Management.Automation.Runspaces.Runspace>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 27065, 27111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 26463, 27138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 26463, 27138);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }



        /// <summary>
        /// Event raised when RunspaceState changes.
        /// </summary>
        public abstract event EventHandler<RunspaceStateEventArgs>
StateChanged
;

        /// <summary>
        /// Event raised when the availability of the Runspace changes.
        /// </summary>
        public abstract event EventHandler<RunspaceAvailabilityEventArgs>
AvailabilityChanged
;

        internal abstract bool HasAvailabilityChangedSubscribers
        {
            get;
        }

        protected abstract void OnAvailabilityChanged(RunspaceAvailabilityEventArgs e);

        internal void UpdateRunspaceAvailability(PipelineState pipelineState, bool raiseEvent, Guid? cmdInstanceId = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 28487, 38753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 28626, 28691);

                RunspaceAvailability
                oldAvailability = f_1455_28665_28690(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 28707, 38531);

                switch (oldAvailability)
                {

                    case RunspaceAvailability.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 28707, 38531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 28964, 29260);

                        switch (pipelineState)
                        {

                            case PipelineState.Running:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 28964, 29260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 29092, 29146);

                                this.RunspaceAvailability = RunspaceAvailability.Busy;
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 29176, 29182);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 28964, 29260);

                                // Otherwise no change.
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 29284, 29290);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 28707, 38531);

                    case RunspaceAvailability.Available:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 28707, 38531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 29368, 29799);

                        switch (pipelineState)
                        {

                            case PipelineState.Running:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 29368, 29799);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 29496, 29550);

                                this.RunspaceAvailability = RunspaceAvailability.Busy;
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 29580, 29586);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 29368, 29799);

                            case PipelineState.Disconnected:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 29368, 29799);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 29676, 29740);

                                this.RunspaceAvailability = Runspaces.RunspaceAvailability.None;
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 29770, 29776);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 29368, 29799);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 29823, 29829);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 28707, 38531);

                    case RunspaceAvailability.AvailableForNestedCommand:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 28707, 38531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 29923, 30651);

                        switch (pipelineState)
                        {

                            case PipelineState.Running:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 29923, 30651);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 30051, 30105);

                                this.RunspaceAvailability = RunspaceAvailability.Busy;
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 30135, 30141);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 29923, 30651);

                            case PipelineState.Completed: // a nested pipeline caused the host to exit nested prompt
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 29923, 30651);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 30287, 30487);

                                this.RunspaceAvailability = (DynAbs.Tracing.TraceSender.Conditional_F1(1455, 30315, 30371) || (((f_1455_30316_30335(this) || (DynAbs.Tracing.TraceSender.Expression_False(1455, 30316, 30370) || (f_1455_30340_30365(_runningPowerShells) > 1))) && DynAbs.Tracing.TraceSender.Conditional_F2(1455, 30407, 30453)) || DynAbs.Tracing.TraceSender.Conditional_F3(1455, 30456, 30486))) ? RunspaceAvailability.AvailableForNestedCommand : RunspaceAvailability.Available;
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 30517, 30523);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 29923, 30651);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 29923, 30651);
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 30589, 30595);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 29923, 30651);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 30675, 30681);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 28707, 38531);

                    case RunspaceAvailability.Busy:
                    case RunspaceAvailability.RemoteDebug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 28707, 38531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 30810, 38350);

                        switch (pipelineState)
                        {

                            case PipelineState.Disconnected:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 30810, 38350);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 30943, 31350) || true) && (oldAvailability == Runspaces.RunspaceAvailability.RemoteDebug)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 30943, 31350);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 31074, 31135);

                                    this.RunspaceAvailability = RunspaceAvailability.RemoteDebug;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 30943, 31350);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 30943, 31350);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 31265, 31319);

                                    this.RunspaceAvailability = RunspaceAvailability.None;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 30943, 31350);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 31382, 31388);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 30810, 38350);

                            case PipelineState.Stopping:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 30810, 38350);
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 31474, 31480);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 30810, 38350);

                            case PipelineState.Completed:
                            case PipelineState.Stopped:
                            case PipelineState.Failed:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 30810, 38350);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 31705, 37976) || true) && (f_1455_31709_31728(this) || (DynAbs.Tracing.TraceSender.Expression_False(1455, 31709, 31787) || !(this is RemoteRunspace) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 31732, 31787) && f_1455_31761_31787(f_1455_31761_31774(this)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 31705, 37976);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 31853, 31928);

                                    this.RunspaceAvailability = RunspaceAvailability.AvailableForNestedCommand;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 31705, 37976);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 31705, 37976);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 32058, 32113);

                                    RemoteRunspace
                                    remoteRunspace = this as RemoteRunspace
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 32147, 32255);

                                    RemoteDebugger
                                    remoteDebugger = (DynAbs.Tracing.TraceSender.Conditional_F1(1455, 32179, 32203) || (((remoteRunspace != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1455, 32206, 32247)) || DynAbs.Tracing.TraceSender.Conditional_F3(1455, 32250, 32254))) ? f_1455_32206_32229(remoteRunspace) as RemoteDebugger : null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 32289, 32396);

                                    Internal.ConnectCommandInfo
                                    remoteCommand = (DynAbs.Tracing.TraceSender.Conditional_F1(1455, 32333, 32357) || (((remoteRunspace != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1455, 32360, 32388)) || DynAbs.Tracing.TraceSender.Conditional_F3(1455, 32391, 32395))) ? f_1455_32360_32388(remoteRunspace) : null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 32430, 33840) || true) && (((pipelineState == PipelineState.Completed) || (DynAbs.Tracing.TraceSender.Expression_False(1455, 32435, 32520) || (pipelineState == PipelineState.Failed)) || (DynAbs.Tracing.TraceSender.Expression_False(1455, 32435, 32661) || ((pipelineState == PipelineState.Stopped) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 32562, 32660) && (f_1455_32607_32635(f_1455_32607_32629(this)) == RunspaceState.Opened)))))
                                    && (DynAbs.Tracing.TraceSender.Expression_True(1455, 32434, 32726) && (remoteCommand != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 32434, 32753) && (cmdInstanceId != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 32434, 32799) && (f_1455_32758_32781(remoteCommand) == cmdInstanceId)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 32430, 33840);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 33265, 33343);

                                        f_1455_33265_33319(f_1455_33265_33292(remoteRunspace)).ConnectCommands = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 33381, 33402);

                                        remoteCommand = null;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 33442, 33805) || true) && ((remoteDebugger != null) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 33446, 33514) && (pipelineState == PipelineState.Stopped)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 33442, 33805);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 33732, 33766);

                                            f_1455_33732_33765(                                        // Notify remote debugger of a stop in case the stop occurred while command was in debug stop.
                                                                                    remoteDebugger);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 33442, 33805);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 32430, 33840);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 33876, 33938);

                                    Pipeline
                                    currentPipeline = f_1455_33903_33937(this)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 33972, 34038);

                                    RemotePipeline
                                    remotePipeline = currentPipeline as RemotePipeline
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 34072, 34215);

                                    Guid?
                                    pipeLineCmdInstance = (DynAbs.Tracing.TraceSender.Conditional_F1(1455, 34100, 34161) || (((remotePipeline != null && (DynAbs.Tracing.TraceSender.Expression_True(1455, 34101, 34160) && f_1455_34127_34152(remotePipeline) != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(1455, 34164, 34200)) || DynAbs.Tracing.TraceSender.Conditional_F3(1455, 34203, 34214))) ? f_1455_34164_34200(f_1455_34164_34189(remotePipeline)) : (Guid?)null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 34249, 37945) || true) && (currentPipeline == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 34249, 37945);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 34776, 36036) || true) && (remoteCommand == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 34776, 36036);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 34883, 35997) || true) && (remoteRunspace != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 34883, 35997);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 34999, 35394) || true) && ((remoteDebugger != null) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 35003, 35071) && (pipelineState == PipelineState.Stopped)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 34999, 35394);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 35313, 35347);

                                                    f_1455_35313_35346(                                                // Notify remote debugger of a stop in case the stop occurred while command was in debug stop.
                                                                                                    remoteDebugger);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 34999, 35394);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 35442, 35717);

                                                this.RunspaceAvailability =
                                                (DynAbs.Tracing.TraceSender.Conditional_F1(1455, 35519, 35596) || ((f_1455_35519_35596(f_1455_35519_35573(f_1455_35519_35546(remoteRunspace))) && DynAbs.Tracing.TraceSender.Conditional_F2(1455, 35648, 35678)) || DynAbs.Tracing.TraceSender.Conditional_F3(1455, 35681, 35716))) ? RunspaceAvailability.Available : Runspaces.RunspaceAvailability.Busy;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 34883, 35997);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 34883, 35997);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 35895, 35954);

                                                this.RunspaceAvailability = RunspaceAvailability.Available;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 34883, 35997);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 34776, 36036);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 34249, 37945);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 34249, 37945);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 36110, 37945) || true) && ((cmdInstanceId != null) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 36114, 36170) && (pipeLineCmdInstance != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 36114, 36212) && (cmdInstanceId == pipeLineCmdInstance)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 36110, 37945);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 36286, 36649) || true) && ((remoteDebugger != null) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 36290, 36358) && (pipelineState == PipelineState.Stopped)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 36286, 36649);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 36576, 36610);

                                                f_1455_36576_36609(                                        // Notify remote debugger of a stop in case the stop occurred while command was in debug stop.
                                                                                        remoteDebugger);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 36286, 36649);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 36689, 36748);

                                            this.RunspaceAvailability = RunspaceAvailability.Available;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 36110, 37945);
                                        }

                                        else // a nested pipeline completed, but the parent pipeline is still running

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 36110, 37945);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 36967, 37910) || true) && (oldAvailability == Runspaces.RunspaceAvailability.RemoteDebug)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 36967, 37910);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 37114, 37185);

                                                this.RunspaceAvailability = Runspaces.RunspaceAvailability.RemoteDebug;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 36967, 37910);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 36967, 37910);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 37267, 37910) || true) && ((f_1455_37272_37311(f_1455_37272_37305(currentPipeline)) == PipelineState.Running) || (DynAbs.Tracing.TraceSender.Expression_False(1455, 37271, 37372) || (f_1455_37342_37367(_runningPowerShells) > 1)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 37267, 37910);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 37596, 37650);

                                                    this.RunspaceAvailability = RunspaceAvailability.Busy;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 37267, 37910);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 37267, 37910);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 37812, 37871);

                                                    this.RunspaceAvailability = RunspaceAvailability.Available;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 37267, 37910);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 36967, 37910);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 36110, 37945);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 34249, 37945);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 31705, 37976);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 38008, 38014);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 30810, 38350);

                            case PipelineState.Running: // this can happen if a nested pipeline is created without entering a nested prompt
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 30810, 38350);
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 38183, 38189);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 30810, 38350);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 30810, 38350);
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 38288, 38294);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 30810, 38350);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 38374, 38380);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 28707, 38531);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 28707, 38531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 38430, 38488);

                        f_1455_38430_38487(false, "Invalid RunspaceAvailability");
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 38510, 38516);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 28707, 38531);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 38547, 38742) || true) && (raiseEvent && (DynAbs.Tracing.TraceSender.Expression_True(1455, 38551, 38609) && f_1455_38565_38590(this) != oldAvailability))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 38547, 38742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 38643, 38727);

                    f_1455_38643_38726(this, f_1455_38665_38725(f_1455_38699_38724(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 38547, 38742);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 28487, 38753);

                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_28665_28690(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 28665, 28690);
                    return return_v;
                }


                bool
                f_1455_30316_30335(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InNestedPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 30316, 30335);
                    return return_v;
                }


                int
                f_1455_30340_30365(System.Collections.Generic.Stack<System.Management.Automation.PowerShell>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 30340, 30365);
                    return return_v;
                }


                bool
                f_1455_31709_31728(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InNestedPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 31709, 31728);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1455_31761_31774(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 31761, 31774);
                    return return_v;
                }


                bool
                f_1455_31761_31787(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 31761, 31787);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1455_32206_32229(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 32206, 32229);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
                f_1455_32360_32388(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RemoteCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 32360, 32388);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1455_32607_32629(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 32607, 32629);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1455_32607_32635(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 32607, 32635);
                    return return_v;
                }


                System.Guid
                f_1455_32758_32781(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
                this_param)
                {
                    var return_v = this_param.CommandId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 32758, 32781);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1455_33265_33292(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 33265, 33292);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1455_33265_33319(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 33265, 33319);
                    return return_v;
                }


                int
                f_1455_33732_33765(System.Management.Automation.RemoteDebugger
                this_param)
                {
                    this_param.OnCommandStopped();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 33732, 33765);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1455_33903_33937(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 33903, 33937);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1455_34127_34152(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 34127, 34152);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1455_34164_34189(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 34164, 34189);
                    return return_v;
                }


                System.Guid
                f_1455_34164_34200(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 34164, 34200);
                    return return_v;
                }


                int
                f_1455_35313_35346(System.Management.Automation.RemoteDebugger
                this_param)
                {
                    this_param.OnCommandStopped();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 35313, 35346);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1455_35519_35546(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 35519, 35546);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1455_35519_35573(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 35519, 35573);
                    return return_v;
                }


                bool
                f_1455_35519_35596(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.AvailableForConnection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 35519, 35596);
                    return return_v;
                }


                int
                f_1455_36576_36609(System.Management.Automation.RemoteDebugger
                this_param)
                {
                    this_param.OnCommandStopped();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 36576, 36609);
                    return 0;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1455_37272_37305(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 37272, 37305);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1455_37272_37311(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 37272, 37311);
                    return return_v;
                }


                int
                f_1455_37342_37367(System.Collections.Generic.Stack<System.Management.Automation.PowerShell>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 37342, 37367);
                    return return_v;
                }


                int
                f_1455_38430_38487(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 38430, 38487);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_38565_38590(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 38565, 38590);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_38699_38724(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 38699, 38724);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                f_1455_38665_38725(System.Management.Automation.Runspaces.RunspaceAvailability
                runspaceAvailability)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs(runspaceAvailability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 38665, 38725);
                    return return_v;
                }


                int
                f_1455_38643_38726(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                e)
                {
                    this_param.OnAvailabilityChanged(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 38643, 38726);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 28487, 38753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 28487, 38753);
            }
        }

        internal void UpdateRunspaceAvailability(PSInvocationState invocationState, bool raiseEvent, Guid cmdInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 39187, 40786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 39324, 40775);

                switch (invocationState)
                {

                    case PSInvocationState.NotStarted:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 39437, 39517);

                        f_1455_39437_39516(this, PipelineState.NotStarted, raiseEvent, cmdInstanceId);
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 39539, 39545);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);

                    case PSInvocationState.Running:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 39618, 39695);

                        f_1455_39618_39694(this, PipelineState.Running, raiseEvent, cmdInstanceId);
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 39717, 39723);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);

                    case PSInvocationState.Completed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 39798, 39877);

                        f_1455_39798_39876(this, PipelineState.Completed, raiseEvent, cmdInstanceId);
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 39899, 39905);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);

                    case PSInvocationState.Failed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 39977, 40053);

                        f_1455_39977_40052(this, PipelineState.Failed, raiseEvent, cmdInstanceId);
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 40075, 40081);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);

                    case PSInvocationState.Stopping:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 40155, 40233);

                        f_1455_40155_40232(this, PipelineState.Stopping, raiseEvent, cmdInstanceId);
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 40255, 40261);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);

                    case PSInvocationState.Stopped:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 40334, 40411);

                        f_1455_40334_40410(this, PipelineState.Stopped, raiseEvent, cmdInstanceId);
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 40433, 40439);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);

                    case PSInvocationState.Disconnected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 40517, 40599);

                        f_1455_40517_40598(this, PipelineState.Disconnected, raiseEvent, cmdInstanceId);
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 40621, 40627);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 39324, 40775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 40677, 40732);

                        f_1455_40677_40731(false, "Invalid PSInvocationState");
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 40754, 40760);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 39324, 40775);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 39187, 40786);

                int
                f_1455_39437_39516(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent, (System.Guid?)cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 39437, 39516);
                    return 0;
                }


                int
                f_1455_39618_39694(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent, (System.Guid?)cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 39618, 39694);
                    return 0;
                }


                int
                f_1455_39798_39876(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent, (System.Guid?)cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 39798, 39876);
                    return 0;
                }


                int
                f_1455_39977_40052(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent, (System.Guid?)cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 39977, 40052);
                    return 0;
                }


                int
                f_1455_40155_40232(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent, (System.Guid?)cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 40155, 40232);
                    return 0;
                }


                int
                f_1455_40334_40410(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent, (System.Guid?)cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 40334, 40410);
                    return 0;
                }


                int
                f_1455_40517_40598(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent, (System.Guid?)cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 40517, 40598);
                    return 0;
                }


                int
                f_1455_40677_40731(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 40677, 40731);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 39187, 40786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 39187, 40786);
            }
        }

        protected void UpdateRunspaceAvailability(RunspaceState runspaceState, bool raiseEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 41189, 43971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41301, 41366);

                RunspaceAvailability
                oldAvailability = f_1455_41340_41365(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41380, 41435);

                RemoteRunspace
                remoteRunspace = this as RemoteRunspace
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41449, 41498);

                Internal.ConnectCommandInfo
                remoteCommand = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41512, 41537);

                bool
                remoteDebug = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41553, 41854) || true) && (remoteRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 41553, 41854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41613, 41658);

                    remoteCommand = f_1455_41629_41657(remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41676, 41750);

                    RemoteDebugger
                    remoteDebugger = f_1455_41708_41731(remoteRunspace) as RemoteDebugger
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41768, 41839);

                    remoteDebug = (remoteDebugger != null) && (DynAbs.Tracing.TraceSender.Expression_True(1455, 41782, 41838) && f_1455_41810_41838(remoteDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 41553, 41854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41870, 43749);

                switch (oldAvailability)
                {

                    case RunspaceAvailability.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 41870, 43749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 41980, 42777);

                        switch (runspaceState)
                        {

                            case RunspaceState.Opened:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 41980, 42777);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 42107, 42611) || true) && (remoteDebug)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 42107, 42611);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 42188, 42259);

                                    this.RunspaceAvailability = Runspaces.RunspaceAvailability.RemoteDebug;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 42107, 42611);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 42107, 42611);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 42389, 42580);

                                    this.RunspaceAvailability = (DynAbs.Tracing.TraceSender.Conditional_F1(1455, 42417, 42481) || (((remoteCommand == null && (DynAbs.Tracing.TraceSender.Expression_True(1455, 42418, 42480) && f_1455_42443_42472(this) == null)) && DynAbs.Tracing.TraceSender.Conditional_F2(1455, 42521, 42551)) || DynAbs.Tracing.TraceSender.Conditional_F3(1455, 42554, 42579))) ? RunspaceAvailability.Available : RunspaceAvailability.Busy;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 42107, 42611);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 42643, 42649);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 41980, 42777);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 41980, 42777);
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 42715, 42721);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 41980, 42777);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 42801, 42807);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 41870, 43749);

                    case RunspaceAvailability.Available:
                    case RunspaceAvailability.AvailableForNestedCommand:
                    case RunspaceAvailability.RemoteDebug:
                    case RunspaceAvailability.Busy:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 41870, 43749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 43060, 43568);

                        switch (runspaceState)
                        {

                            case RunspaceState.Closing:
                            case RunspaceState.Closed:
                            case RunspaceState.Broken:
                            case RunspaceState.Disconnected:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 43060, 43568);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 43350, 43404);

                                this.RunspaceAvailability = RunspaceAvailability.None;
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 43434, 43440);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 43060, 43568);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 43060, 43568);
                                DynAbs.Tracing.TraceSender.TraceBreak(1455, 43506, 43512);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 43060, 43568);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 43592, 43598);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 41870, 43749);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 41870, 43749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 43648, 43706);

                        f_1455_43648_43705(false, "Invalid RunspaceAvailability");
                        DynAbs.Tracing.TraceSender.TraceBreak(1455, 43728, 43734);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 41870, 43749);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 43765, 43960) || true) && (raiseEvent && (DynAbs.Tracing.TraceSender.Expression_True(1455, 43769, 43827) && f_1455_43783_43808(this) != oldAvailability))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 43765, 43960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 43861, 43945);

                    f_1455_43861_43944(this, f_1455_43883_43943(f_1455_43917_43942(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 43765, 43960);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 41189, 43971);

                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_41340_41365(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 41340, 41365);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
                f_1455_41629_41657(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RemoteCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 41629, 41657);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1455_41708_41731(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 41708, 41731);
                    return return_v;
                }


                bool
                f_1455_41810_41838(System.Management.Automation.RemoteDebugger
                this_param)
                {
                    var return_v = this_param.IsRemoteDebug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 41810, 41838);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1455_42443_42472(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 42443, 42472);
                    return return_v;
                }


                int
                f_1455_43648_43705(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 43648, 43705);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_43783_43808(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 43783, 43808);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_43917_43942(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 43917, 43942);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                f_1455_43883_43943(System.Management.Automation.Runspaces.RunspaceAvailability
                runspaceAvailability)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs(runspaceAvailability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 43883, 43943);
                    return return_v;
                }


                int
                f_1455_43861_43944(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                e)
                {
                    this_param.OnAvailabilityChanged(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 43861, 43944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 41189, 43971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 41189, 43971);
            }
        }

        internal void UpdateRunspaceAvailability(RunspaceAvailability availability, bool raiseEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 44130, 44591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 44247, 44312);

                RunspaceAvailability
                oldAvailability = f_1455_44286_44311(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 44328, 44369);

                this.RunspaceAvailability = availability;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 44385, 44580) || true) && (raiseEvent && (DynAbs.Tracing.TraceSender.Expression_True(1455, 44389, 44447) && f_1455_44403_44428(this) != oldAvailability))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 44385, 44580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 44481, 44565);

                    f_1455_44481_44564(this, f_1455_44503_44563(f_1455_44537_44562(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 44385, 44580);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 44130, 44591);

                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_44286_44311(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 44286, 44311);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_44403_44428(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 44403, 44428);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1455_44537_44562(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 44537, 44562);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                f_1455_44503_44563(System.Management.Automation.Runspaces.RunspaceAvailability
                runspaceAvailability)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs(runspaceAvailability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 44503, 44563);
                    return return_v;
                }


                int
                f_1455_44481_44564(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                e)
                {
                    this_param.OnAvailabilityChanged(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 44481, 44564);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 44130, 44591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 44130, 44591);
            }
        }

        internal void RaiseAvailabilityChangedEvent(RunspaceAvailability availability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 44701, 44886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 44804, 44875);

                f_1455_44804_44874(this, f_1455_44826_44873(availability));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 44701, 44886);

                System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                f_1455_44826_44873(System.Management.Automation.Runspaces.RunspaceAvailability
                runspaceAvailability)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs(runspaceAvailability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 44826, 44873);
                    return return_v;
                }


                int
                f_1455_44804_44874(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                e)
                {
                    this_param.OnAvailabilityChanged(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 44804, 44874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 44701, 44886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 44701, 44886);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static Runspace[] GetRunspaces(RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 45550, 45828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 45769, 45817);

                return f_1455_45776_45816(connectionInfo, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 45550, 45828);

                System.Management.Automation.Runspaces.Runspace[]
                f_1455_45776_45816(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = GetRunspaces(connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 45776, 45816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 45550, 45828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 45550, 45828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static Runspace[] GetRunspaces(RunspaceConnectionInfo connectionInfo, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 46482, 46773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 46714, 46762);

                return f_1455_46721_46761(connectionInfo, host, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 46482, 46773);

                System.Management.Automation.Runspaces.Runspace[]
                f_1455_46721_46761(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = GetRunspaces(connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 46721, 46761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 46482, 46773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 46482, 46773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static Runspace[] GetRunspaces(RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 47490, 47828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 47743, 47817);

                return f_1455_47750_47816(connectionInfo, host, typeTable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 47490, 47828);

                System.Management.Automation.Runspaces.Runspace[]
                f_1455_47750_47816(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = RemoteRunspace.GetRemoteRunspaces(connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 47750, 47816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 47490, 47828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 47490, 47828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace GetRunspace(RunspaceConnectionInfo connectionInfo, Guid sessionId, Guid? commandId, PSHost host, TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1455, 48660, 48931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 48825, 48920);

                return f_1455_48832_48919(connectionInfo, sessionId, commandId, host, typeTable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1455, 48660, 48931);

                System.Management.Automation.Runspaces.Runspace
                f_1455_48832_48919(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Guid
                sessionId, System.Guid?
                commandId, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = RemoteRunspace.GetRemoteRunspace(connectionInfo, sessionId, commandId, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 48832, 48919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 48660, 48931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 48660, 48931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract void Disconnect();

        public abstract void DisconnectAsync();

        public abstract void Connect();

        public abstract void ConnectAsync();

        public abstract Pipeline CreateDisconnectedPipeline();

        public abstract PowerShell CreateDisconnectedPowerShell();

        public abstract RunspaceCapability GetCapabilities();

        public abstract void Open();

        public abstract void OpenAsync();

        public abstract void Close();

        public abstract void CloseAsync();

        public abstract Pipeline CreatePipeline();

        public abstract Pipeline CreatePipeline(string command);

        public abstract Pipeline CreatePipeline(string command, bool addToHistory);

        public abstract Pipeline CreateNestedPipeline();

        public abstract Pipeline CreateNestedPipeline(string command, bool addToHistory);

        internal abstract Pipeline GetCurrentlyRunningPipeline();

        public abstract PSPrimitiveDictionary GetApplicationPrivateData();

        internal abstract void SetApplicationPrivateData(PSPrimitiveDictionary applicationPrivateData);

        internal void PushRunningPowerShell(PowerShell ps)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 58323, 58731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 58398, 58466);

                f_1455_58398_58465(ps != null, "Caller should not pass in null reference.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 58488, 58499);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 58533, 58562);

                    f_1455_58533_58561(_runningPowerShells, ps);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 58582, 58705) || true) && (f_1455_58586_58611(_runningPowerShells) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 58582, 58705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 58658, 58686);

                        _baseRunningPowerShell = ps;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 58582, 58705);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 58323, 58731);

                int
                f_1455_58398_58465(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 58398, 58465);
                    return 0;
                }


                int
                f_1455_58533_58561(System.Collections.Generic.Stack<System.Management.Automation.PowerShell>
                this_param, System.Management.Automation.PowerShell
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 58533, 58561);
                    return 0;
                }


                int
                f_1455_58586_58611(System.Collections.Generic.Stack<System.Management.Automation.PowerShell>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 58586, 58611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 58323, 58731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 58323, 58731);
            }
        }

        internal PowerShell PopRunningPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 58896, 59307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 58969, 58980);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59014, 59052);

                    int
                    count = f_1455_59026_59051(_runningPowerShells)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59072, 59253) || true) && (count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 59072, 59253);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59127, 59177) || true) && (count == 1)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 59127, 59177);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59145, 59175);

                            _baseRunningPowerShell = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 59127, 59177);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59201, 59234);

                        return f_1455_59208_59233(_runningPowerShells);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 59072, 59253);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59284, 59296);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 58896, 59307);

                int
                f_1455_59026_59051(System.Collections.Generic.Stack<System.Management.Automation.PowerShell>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 59026, 59051);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1455_59208_59233(System.Collections.Generic.Stack<System.Management.Automation.PowerShell>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 59208, 59233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 58896, 59307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 58896, 59307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PowerShell GetCurrentBasePowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 59319, 59431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59390, 59420);

                return _baseRunningPowerShell;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 59319, 59431);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 59319, 59431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 59319, 59431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SessionStateProxy SessionStateProxy
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 59663, 59744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 59699, 59729);

                    return f_1455_59706_59728(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 59663, 59744);

                    System.Management.Automation.Runspaces.SessionStateProxy
                    f_1455_59706_59728(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.GetSessionStateProxy();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 59706, 59728);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 59596, 59755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 59596, 59755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract SessionStateProxy GetSessionStateProxy();

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 60065, 60176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 60111, 60125);

                f_1455_60111_60124(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 60139, 60165);

                f_1455_60139_60164(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 60065, 60176);

                int
                f_1455_60111_60124(System.Management.Automation.Runspaces.Runspace
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 60111, 60124);
                    return 0;
                }


                int
                f_1455_60139_60164(System.Management.Automation.Runspaces.Runspace
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 60139, 60164);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 60065, 60176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 60065, 60176);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 60356, 60537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 60433, 60445);
                lock (s_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 60479, 60511);

                    f_1455_60479_60510(s_runspaceDictionary, f_1455_60507_60509());
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 60356, 60537);

                int
                f_1455_60507_60509()
                {
                    var return_v = Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 60507, 60509);
                    return return_v;
                }


                bool
                f_1455_60479_60510(System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
                this_param, int
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 60479, 60510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 60356, 60537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 60356, 60537);
            }
        }

        internal abstract System.Management.Automation.ExecutionContext GetExecutionContext
        {
            get;
        }

        internal abstract bool InNestedPrompt
        {
            get;
        }

        public virtual Debugger Debugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 61156, 61310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 61192, 61226);

                    var
                    context = f_1455_61206_61225()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 61244, 61295);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1455, 61251, 61268) || (((context != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1455, 61271, 61287)) || DynAbs.Tracing.TraceSender.Conditional_F3(1455, 61290, 61294))) ? f_1455_61271_61287(context) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 61156, 61310);

                    System.Management.Automation.ExecutionContext
                    f_1455_61206_61225()
                    {
                        var return_v = GetExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 61206, 61225);
                        return return_v;
                    }


                    System.Management.Automation.ScriptDebugger
                    f_1455_61271_61287(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.Debugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 61271, 61287);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 61099, 61321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 61099, 61321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Debugger InternalDebugger
        {
            get;
            set;
        }

        public abstract PSEventManager Events
        {
            get;
        }

        public virtual void ResetRunspaceState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 63390, 63522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 63455, 63511);

                throw f_1455_63461_63510("ResetRunspaceState");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 63390, 63522);

                System.NotImplementedException
                f_1455_63461_63510(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 63461, 63510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 63390, 63522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 63390, 63522);
            }
        }

        private long _pipelineIdSeed;

        internal long GeneratePipelineId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 63675, 63812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 63734, 63801);

                return f_1455_63741_63800(ref _pipelineIdSeed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 63675, 63812);

                long
                f_1455_63741_63800(ref long
                location)
                {
                    var return_v = System.Threading.Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 63741, 63800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 63675, 63812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 63675, 63812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1455, 13882, 63819);

        int
        f_1455_14420_14474(ref int
        location)
        {
            var return_v = System.Threading.Interlocked.Increment(ref location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 14420, 14474);
            return return_v;
        }


        int
        f_1455_14509_14511()
        {
            var return_v = Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 14509, 14511);
            return return_v;
        }


        System.Globalization.NumberFormatInfo
        f_1455_14521_14572()
        {
            var return_v = System.Globalization.NumberFormatInfo.InvariantInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 14521, 14572);
            return return_v;
        }


        string
        f_1455_14509_14573(int
        this_param, System.Globalization.NumberFormatInfo
        provider)
        {
            var return_v = this_param.ToString((System.IFormatProvider)provider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 14509, 14573);
            return return_v;
        }


        System.Collections.Generic.Stack<System.Management.Automation.PowerShell>
        f_1455_14610_14633()
        {
            var return_v = new System.Collections.Generic.Stack<System.Management.Automation.PowerShell>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 14610, 14633);
            return return_v;
        }


        object
        f_1455_14662_14674()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 14662, 14674);
            return return_v;
        }


        int
        f_1455_14834_14836()
        {
            var return_v = Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 14834, 14836);
            return return_v;
        }


        System.WeakReference<System.Management.Automation.Runspaces.Runspace>
        f_1455_14838_14871(System.Management.Automation.Runspaces.Runspace
        target)
        {
            var return_v = new System.WeakReference<System.Management.Automation.Runspaces.Runspace>(target);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 14838, 14871);
            return return_v;
        }


        int
        f_1455_14809_14872(System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
        this_param, int
        key, System.WeakReference<System.Management.Automation.Runspaces.Runspace>
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 14809, 14872);
            return 0;
        }


        static object
        f_1455_15048_15060()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 15048, 15060);
            return return_v;
        }


        static System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>
        f_1455_15098_15150()
        {
            var return_v = new System.Collections.Generic.SortedDictionary<int, System.WeakReference<System.Management.Automation.Runspaces.Runspace>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 15098, 15150);
            return return_v;
        }

    }
    public class SessionStateProxy
    {
        internal SessionStateProxy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 64002, 64052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 64085, 64094);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 64002, 64052);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 64002, 64052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 64002, 64052);
            }
        }

        private RunspaceBase _runspace;

        internal SessionStateProxy(RunspaceBase runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1455, 64105, 64294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 64085, 64094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 64179, 64248);

                f_1455_64179_64247(runspace != null, "Caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 64262, 64283);

                _runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1455, 64105, 64294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 64105, 64294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 64105, 64294);
            }
        }

        public virtual void SetVariable(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 64995, 65258);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 65078, 65196) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 65078, 65196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 65128, 65181);

                    throw f_1455_65134_65180("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 65078, 65196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 65212, 65247);

                f_1455_65212_65246(
                            _runspace, name, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 64995, 65258);

                System.Management.Automation.PSArgumentNullException
                f_1455_65134_65180(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 65134, 65180);
                    return return_v;
                }


                int
                f_1455_65212_65246(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                name, object
                value)
                {
                    this_param.SetVariable(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 65212, 65246);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 64995, 65258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 64995, 65258);
            }
        }

        public virtual object GetVariable(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 65953, 66310);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 66024, 66142) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 66024, 66142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 66074, 66127);

                    throw f_1455_66080_66126("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 66024, 66142);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 66158, 66248) || true) && (f_1455_66162_66187(name, string.Empty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1455, 66158, 66248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 66221, 66233);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1455, 66158, 66248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 66264, 66299);

                return f_1455_66271_66298(_runspace, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 65953, 66310);

                System.Management.Automation.PSArgumentNullException
                f_1455_66080_66126(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 66080, 66126);
                    return return_v;
                }


                bool
                f_1455_66162_66187(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 66162, 66187);
                    return return_v;
                }


                object
                f_1455_66271_66298(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 66271, 66298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 65953, 66310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 65953, 66310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual List<string> Applications
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 66785, 66866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 66821, 66851);

                    return f_1455_66828_66850(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 66785, 66866);

                    System.Collections.Generic.List<string>
                    f_1455_66828_66850(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.Applications;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 66828, 66850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 66720, 66877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 66720, 66877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual List<string> Scripts
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 67342, 67418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 67378, 67403);

                    return f_1455_67385_67402(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 67342, 67418);

                    System.Collections.Generic.List<string>
                    f_1455_67385_67402(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.Scripts;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 67385, 67402);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 67282, 67429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 67282, 67429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual DriveManagementIntrinsics Drive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 67911, 67942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 67917, 67940);

                    return f_1455_67924_67939(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 67911, 67942);

                    System.Management.Automation.DriveManagementIntrinsics
                    f_1455_67924_67939(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.Drive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 67924, 67939);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 67840, 67953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 67840, 67953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual PSLanguageMode LanguageMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 68427, 68465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 68433, 68463);

                    return f_1455_68440_68462(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 68427, 68465);

                    System.Management.Automation.PSLanguageMode
                    f_1455_68440_68462(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.LanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 68440, 68462);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 68360, 68531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 68360, 68531);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 68481, 68520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 68487, 68518);

                    _runspace.LanguageMode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 68481, 68520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 68360, 68531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 68360, 68531);
                }
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Justification = "Shipped this way in V2 before becoming virtual.")]
        public virtual PSModuleInfo Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 69149, 69181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 69155, 69179);

                    return f_1455_69162_69178(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 69149, 69181);

                    System.Management.Automation.PSModuleInfo
                    f_1455_69162_69178(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 69162, 69178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 68932, 69192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 68932, 69192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual PathIntrinsics Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 69675, 69715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 69681, 69713);

                    return f_1455_69688_69712(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 69675, 69715);

                    System.Management.Automation.PathIntrinsics
                    f_1455_69688_69712(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.PathIntrinsics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 69688, 69712);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 69616, 69726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 69616, 69726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual CmdletProviderManagementIntrinsics Provider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 70224, 70258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 70230, 70256);

                    return f_1455_70237_70255(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 70224, 70258);

                    System.Management.Automation.CmdletProviderManagementIntrinsics
                    f_1455_70237_70255(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.Provider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 70237, 70255);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 70141, 70269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 70141, 70269);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual PSVariableIntrinsics PSVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 70754, 70790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 70760, 70788);

                    return f_1455_70767_70787(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 70754, 70790);

                    System.Management.Automation.PSVariableIntrinsics
                    f_1455_70767_70787(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.PSVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 70767, 70787);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 70683, 70801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 70683, 70801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual CommandInvocationIntrinsics InvokeCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 71318, 71357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 71324, 71355);

                    return f_1455_71331_71354(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 71318, 71357);

                    System.Management.Automation.CommandInvocationIntrinsics
                    f_1455_71331_71354(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.InvokeCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 71331, 71354);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 71237, 71368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 71237, 71368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ProviderIntrinsics InvokeProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1455, 71871, 71911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1455, 71877, 71909);

                    return f_1455_71884_71908(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1455, 71871, 71911);

                    System.Management.Automation.ProviderIntrinsics
                    f_1455_71884_71908(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.InvokeProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1455, 71884, 71908);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1455, 71798, 71922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 71798, 71922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SessionStateProxy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1455, 63955, 71929);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1455, 63955, 71929);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1455, 63955, 71929);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1455, 63955, 71929);

        int
        f_1455_64179_64247(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1455, 64179, 64247);
            return 0;
        }

    }
}
