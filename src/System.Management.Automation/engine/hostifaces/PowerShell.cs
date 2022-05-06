// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Management.Infrastructure;
using Microsoft.PowerShell.Telemetry;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation
{
    [Serializable]
    public class InvalidPowerShellStateException : SystemException
    {
        public InvalidPowerShellStateException()
        : base(f_1477_1362_1428_C(f_1477_1362_1428(f_1477_1380_1427())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 1295, 1451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 4169, 4183);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 1295, 1451);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 1295, 1451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 1295, 1451);
            }
        }

        public InvalidPowerShellStateException(string message)
        : base(f_1477_1796_1803_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 1721, 1826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 4169, 4183);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 1721, 1826);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 1721, 1826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 1721, 1826);
            }
        }

        public InvalidPowerShellStateException(string message, Exception innerException)
        : base(f_1477_2333_2340_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 2232, 2379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 4169, 4183);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 2232, 2379);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 2232, 2379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 2232, 2379);
            }
        }

        internal InvalidPowerShellStateException(PSInvocationState currentState)
        : base(f_1477_2741_2807_C(f_1477_2741_2807(f_1477_2759_2806())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 2642, 2870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 4169, 4183);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 2833, 2859);

                _currState = currentState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 2642, 2870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 2642, 2870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 2642, 2870);
            }
        }

        protected
                InvalidPowerShellStateException(SerializationInfo info, StreamingContext context)
        : base(f_1477_3690_3694_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 3573, 3726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 4169, 4183);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 3573, 3726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 3573, 3726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 3573, 3726);
            }
        }

        public PSInvocationState CurrentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 3919, 3988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 3955, 3973);

                    return _currState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 3919, 3988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 3857, 3999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 3857, 3999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [NonSerialized]
        private PSInvocationState _currState;

        static InvalidPowerShellStateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 1071, 4191);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 1071, 4191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 1071, 4191);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 1071, 4191);

        static string
        f_1477_1380_1427()
        {
            var return_v = PowerShellStrings.InvalidPowerShellStateGeneral;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 1380, 1427);
            return return_v;
        }


        static string
        f_1477_1362_1428(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 1362, 1428);
            return return_v;
        }


        static string
        f_1477_1362_1428_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 1295, 1451);
            return return_v;
        }


        static string
        f_1477_1796_1803_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 1721, 1826);
            return return_v;
        }


        static string
        f_1477_2333_2340_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 2232, 2379);
            return return_v;
        }


        static string
        f_1477_2759_2806()
        {
            var return_v = PowerShellStrings.InvalidPowerShellStateGeneral;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 2759, 2806);
            return return_v;
        }


        static string
        f_1477_2741_2807(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 2741, 2807);
            return return_v;
        }


        static string
        f_1477_2741_2807_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 2642, 2870);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1477_3690_3694_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 3573, 3726);
            return return_v;
        }

    }



    /// <summary>
    /// Enumerated type defining the state of the PowerShell.
    /// </summary>
    public enum PSInvocationState
    {
        /// <summary>
        /// PowerShell has not been started.
        /// </summary>
        NotStarted = 0,
        /// <summary>
        /// PowerShell is executing.
        /// </summary>
        Running = 1,
        /// <summary>
        /// PowerShell is stoping execution.
        /// </summary>
        Stopping = 2,
        /// <summary>
        /// PowerShell is completed due to a stop request.
        /// </summary>
        Stopped = 3,
        /// <summary>
        /// PowerShell has completed executing a command.
        /// </summary>
        Completed = 4,
        /// <summary>
        /// PowerShell completed abnormally due to an error.
        /// </summary>
        Failed = 5,
        /// <summary>
        /// PowerShell is in disconnected state.
        /// </summary>
        Disconnected = 6
    }

    /// <summary>
    /// Enumerated type defining runspace modes for nested pipeline.
    /// </summary>
    public enum RunspaceMode
    {
        /// <summary>
        /// Use current runspace from the current thread of execution.
        /// </summary>
        CurrentRunspace = 0,

        /// <summary>
        /// Create new runspace.
        /// </summary>
        NewRunspace = 1
    }
    public sealed class PSInvocationStateInfo
    {
        internal PSInvocationStateInfo(PSInvocationState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 6289, 6462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 8247, 8262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 8423, 8439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 6387, 6411);

                _executionState = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 6425, 6451);

                _exceptionReason = reason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 6289, 6462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 6289, 6462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 6289, 6462);
            }
        }

        internal PSInvocationStateInfo(PipelineStateInfo pipelineStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 6622, 6851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 8247, 8262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 8423, 8439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 6714, 6782);

                _executionState = (PSInvocationState)((int)f_1477_6757_6780(pipelineStateInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 6796, 6840);

                _exceptionReason = f_1477_6815_6839(pipelineStateInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 6622, 6851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 6622, 6851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 6622, 6851);
            }
        }

        public PSInvocationState State
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 7122, 7196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 7158, 7181);

                    return _executionState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 7122, 7196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 7067, 7207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 7067, 7207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Exception Reason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 7593, 7668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 7629, 7653);

                    return _exceptionReason;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 7593, 7668);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 7545, 7679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 7545, 7679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSInvocationStateInfo Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 7893, 8088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 7956, 8077);

                return f_1477_7963_8076(_executionState, _exceptionReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 7893, 8088);

                System.Management.Automation.PSInvocationStateInfo
                f_1477_7963_8076(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 7963, 8076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 7893, 8088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 7893, 8088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSInvocationState _executionState;

        private Exception _exceptionReason;

        static PSInvocationStateInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 5879, 8469);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 5879, 8469);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 5879, 8469);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 5879, 8469);

        System.Management.Automation.Runspaces.PipelineState
        f_1477_6757_6780(System.Management.Automation.Runspaces.PipelineStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 6757, 6780);
            return return_v;
        }


        System.Exception
        f_1477_6815_6839(System.Management.Automation.Runspaces.PipelineStateInfo
        this_param)
        {
            var return_v = this_param.Reason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 6815, 6839);
            return return_v;
        }

    }
    public sealed class PSInvocationStateChangedEventArgs : EventArgs
    {
        internal PSInvocationStateChangedEventArgs(PSInvocationStateInfo psStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 9001, 9234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 9423, 9480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 9103, 9175);

                f_1477_9103_9174(psStateInfo != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 9189, 9223);

                InvocationStateInfo = psStateInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 9001, 9234);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 9001, 9234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 9001, 9234);
            }
        }

        public PSInvocationStateInfo InvocationStateInfo { get; }

        static PSInvocationStateChangedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 8648, 9509);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 8648, 9509);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 8648, 9509);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 8648, 9509);

        int
        f_1477_9103_9174(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 9103, 9174);
            return 0;
        }

    }
    public sealed class PSInvocationSettings
    {
        private PSHost _host;

        public PSInvocationSettings()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 10093, 10346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 9729, 9734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10516, 10566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 11212, 11272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 11487, 11525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 11669, 11729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 12335, 12384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 12396, 12489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 12686, 12783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 12970, 13017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10147, 10192);

                this.ApartmentState = ApartmentState.Unknown;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10206, 10219);

                _host = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10233, 10257);

                RemoteStreamOptions = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10271, 10292);

                AddToHistory = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10306, 10335);

                ErrorActionPreference = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 10093, 10346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 10093, 10346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 10093, 10346);
            }
        }

        public ApartmentState ApartmentState { get; set; }

        public PSHost Host
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 10754, 10818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10790, 10803);

                    return _host;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 10754, 10818);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 10711, 11061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 10711, 11061);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 10834, 11050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10870, 11001) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 10870, 11001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 10929, 10982);

                        throw f_1477_10935_10981("Host");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 10870, 11001);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 11021, 11035);

                    _host = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 10834, 11050);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_10935_10981(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 10935, 10981);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 10711, 11061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 10711, 11061);
                }
            }
        }

        public RemoteStreamOptions RemoteStreamOptions { get; set; }

        public bool AddToHistory { get; set; }

        public ActionPreference? ErrorActionPreference { get; set; }

        public bool FlowImpersonationPolicy { get; set; }

        internal System.Security.Principal.WindowsIdentity WindowsIdentityToImpersonate { get; set; }

        public bool ExposeFlowControlExceptions
        {
            get;
            set;
        }

        internal bool InvokeAndDisconnect { get; set; }

        static PSInvocationSettings()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 9623, 13024);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 9623, 13024);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 9623, 13024);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 9623, 13024);
    }
    internal class BatchInvocationContext
    {
        private AutoResetEvent _completionEvent;

        internal BatchInvocationContext(PSCommand command, PSDataCollection<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 13377, 13605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 13182, 13198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 13696, 13747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 13838, 13873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 13487, 13505);

                Command = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 13519, 13535);

                Output = output;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 13549, 13594);

                _completionEvent = f_1477_13568_13593(false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 13377, 13605);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 13377, 13605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 13377, 13605);
            }
        }

        internal PSDataCollection<PSObject> Output { get; }

        internal PSCommand Command { get; }

        internal void Wait()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 13977, 14060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 14022, 14049);

                f_1477_14022_14048(_completionEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 13977, 14060);

                bool
                f_1477_14022_14048(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 14022, 14048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 13977, 14060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 13977, 14060);
            }
        }

        internal void Signal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 14162, 14243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 14209, 14232);

                f_1477_14209_14231(_completionEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 14162, 14243);

                bool
                f_1477_14209_14231(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 14209, 14231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 14162, 14243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 14162, 14243);
            }
        }

        static BatchInvocationContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 13105, 14250);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 13105, 14250);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 13105, 14250);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 13105, 14250);

        System.Threading.AutoResetEvent
        f_1477_13568_13593(bool
        initialState)
        {
            var return_v = new System.Threading.AutoResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 13568, 13593);
            return return_v;
        }

    }

    /// <summary>
    /// These flags control whether InvocationInfo is added to items in the Error, Warning, Verbose and Debug
    /// streams during remote calls.
    /// </summary>
    [Flags]
    public enum RemoteStreamOptions
    {
        /// <summary>
        /// If this flag is set, ErrorRecord will include an instance of InvocationInfo on remote calls.
        /// </summary>
        AddInvocationInfoToErrorRecord = 0x01,

        /// <summary>
        /// If this flag is set, WarningRecord will include an instance of InvocationInfo on remote calls.
        /// </summary>
        AddInvocationInfoToWarningRecord = 0x02,

        /// <summary>
        /// If this flag is set, DebugRecord will include an instance of InvocationInfo on remote calls.
        /// </summary>
        AddInvocationInfoToDebugRecord = 0x04,

        /// <summary>
        /// If this flag is set, VerboseRecord will include an instance of InvocationInfo on remote calls.
        /// </summary>
        AddInvocationInfoToVerboseRecord = 0x08,

        /// <summary>
        /// If this flag is set, ErrorRecord, WarningRecord, DebugRecord, and VerboseRecord will include an instance of InvocationInfo on remote calls.
        /// </summary>
        AddInvocationInfo = AddInvocationInfoToErrorRecord
                          | AddInvocationInfoToWarningRecord
                          | AddInvocationInfoToDebugRecord
                          | AddInvocationInfoToVerboseRecord
    }
    internal sealed class PowerShellAsyncResult : AsyncResult
    {
        internal bool IsAssociatedWithAsyncInvoke { get; }

        internal PSDataCollection<PSObject> Output { get; }

        internal PowerShellAsyncResult(Guid ownerId, AsyncCallback callback, object state, PSDataCollection<PSObject> output,
                    bool isCalledFromBeginInvoke)
        : base(f_1477_17508_17515_C(ownerId), callback, state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 17327, 17653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 16321, 16371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 16490, 16541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 17558, 17612);

                IsAssociatedWithAsyncInvoke = isCalledFromBeginInvoke;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 17626, 17642);

                Output = output;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 17327, 17653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 17327, 17653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 17327, 17653);
            }
        }

        static PowerShellAsyncResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 15938, 17682);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 15938, 17682);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 15938, 17682);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 15938, 17682);

        static System.Guid
        f_1477_17508_17515_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 17327, 17653);
            return return_v;
        }

    }
    [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Justification = "PowerShell is a valid type in SMAR namespace.")]
    public sealed class PowerShell : IDisposable
    {
        private PSCommand _psCommand;

        private Worker _worker;

        private PowerShellAsyncResult _invokeAsyncResult;

        private PowerShellAsyncResult _stopAsyncResult;

        private PowerShellAsyncResult _batchAsyncResult;

        private PSInvocationSettings _batchInvocationSettings;

        private PSCommand _backupPSCommand;

        private object _rsConnection;

        private PSDataCollection<ErrorRecord> _errorBuffer;

        private bool _isDisposed;

        private object _syncObject;

        private ConnectCommandInfo _connectCmdInfo;

        private bool _commandInvokedSynchronously;

        private bool _isBatching;

        private bool _stopBatchExecution;

        private readonly Func<IAsyncResult, PSDataCollection<PSObject>> _endInvokeMethod;

        private readonly Action<IAsyncResult> _endStopMethod;

        private PowerShell(PSCommand command, Collection<PSCommand> extraCommands, object rsConnection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 20487, 21667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18753, 18763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18837, 18844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18885, 18903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18944, 18960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19001, 19018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19058, 19082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19111, 19127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19153, 19166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19217, 19229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19255, 19266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19292, 19318);
                this._syncObject = f_1477_19306_19318();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19467, 19482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19506, 19542);
                this._commandInvokedSynchronously = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19566, 19585);
                this._isBatching = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19609, 19636);
                this._stopBatchExecution = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19798, 19814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19863, 19877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 55187, 55224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62990, 63051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 63411, 63475);
                this.RedirectShellErrorOutputPipe = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 63830, 63900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 64058, 64100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 64473, 64525);
                this.IsChild = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 64674, 64717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 65025, 65132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68689, 68705);
                this._runspace = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 71055, 71075);
                this._runspacePool = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154273, 154332);
                this.IsRunspaceOwner = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154344, 154396);
                this.ErrorBufferOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154408, 154461);
                this.OutputBufferOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154547, 154617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 159035, 159098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210924, 210994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211137, 211178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211296, 211349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211455, 211511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 20607, 20663);

                f_1477_20607_20662(command != null, "command must not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 20677, 20738);

                ExtraCommands = extraCommands ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>>(1477, 20693, 20737) ?? f_1477_20710_20737());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 20752, 20781);

                RunningExtraCommands = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 20795, 20816);

                _psCommand = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 20830, 20854);

                _psCommand.Owner = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 20868, 20931);

                RemoteRunspace
                remoteRunspace = rsConnection as RemoteRunspace
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 20945, 21029);

                _rsConnection = (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 20961, 20983) || ((remoteRunspace != null && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 20986, 21013)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 21016, 21028))) ? f_1477_20986_21013(remoteRunspace) : rsConnection;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21043, 21071);

                InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21085, 21169);

                InvocationStateInfo = f_1477_21107_21168(PSInvocationState.NotStarted, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21183, 21203);

                OutputBuffer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21217, 21242);

                OutputBufferOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21256, 21307);

                _errorBuffer = f_1477_21271_21306();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21321, 21345);

                ErrorBufferOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21359, 21421);

                InformationalBuffers = f_1477_21382_21420(f_1477_21409_21419());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21435, 21469);

                Streams = f_1477_21445_21468(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21483, 21512);

                _endInvokeMethod = EndInvoke;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21526, 21551);

                _endStopMethod = EndStop;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 21565, 21656);

                f_1477_21565_21655(TelemetryType.PowerShellCreate, "create");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 20487, 21667);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 20487, 21667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 20487, 21667);
            }
        }

        internal PowerShell(ConnectCommandInfo connectCmdInfo, object rsConnection)
        : this(f_1477_22168_22183_C(f_1477_22168_22183()), null, rsConnection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 22072, 23224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22229, 22273);

                ExtraCommands = f_1477_22245_22272();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22287, 22316);

                RunningExtraCommands = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22330, 22365);

                f_1477_22330_22364(this, f_1477_22341_22363(connectCmdInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22379, 22412);

                _connectCmdInfo = connectCmdInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22522, 22561);

                InstanceId = f_1477_22535_22560(_connectCmdInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22577, 22663);

                InvocationStateInfo = f_1477_22599_22662(PSInvocationState.Disconnected, null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22679, 23020) || true) && (rsConnection is RemoteRunspace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 22679, 23020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22747, 22784);

                    _runspace = rsConnection as Runspace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22802, 22862);

                    _runspacePool = f_1477_22818_22861(((RemoteRunspace)rsConnection));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 22679, 23020);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 22679, 23020);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22896, 23020) || true) && (rsConnection is RunspacePool)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 22896, 23020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 22962, 23005);

                        _runspacePool = (RunspacePool)rsConnection;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 22896, 23020);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 22679, 23020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23036, 23105);

                f_1477_23036_23104(_runspacePool != null, "Invalid rsConnection parameter>");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23119, 23213);

                RemotePowerShell = f_1477_23138_23212(this, f_1477_23171_23211(_runspacePool));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 22072, 23224);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 22072, 23224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 22072, 23224);
            }
        }

        internal PowerShell(ObjectStreamBase inputstream,
                    ObjectStreamBase outputstream, ObjectStreamBase errorstream, RunspacePool runspacePool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 23477, 24723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18753, 18763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18837, 18844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18885, 18903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 18944, 18960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19001, 19018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19058, 19082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19111, 19127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19153, 19166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19217, 19229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19255, 19266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19292, 19318);
                this._syncObject = f_1477_19306_19318();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19467, 19482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19506, 19542);
                this._commandInvokedSynchronously = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19566, 19585);
                this._isBatching = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19609, 19636);
                this._stopBatchExecution = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19798, 19814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 19863, 19877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 55187, 55224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62990, 63051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 63411, 63475);
                this.RedirectShellErrorOutputPipe = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 63830, 63900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 64058, 64100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 64473, 64525);
                this.IsChild = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 64674, 64717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 65025, 65132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68689, 68705);
                this._runspace = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 71055, 71075);
                this._runspacePool = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154273, 154332);
                this.IsRunspaceOwner = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154344, 154396);
                this.ErrorBufferOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154408, 154461);
                this.OutputBufferOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154547, 154617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 159035, 159098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210924, 210994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211137, 211178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211296, 211349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211455, 211511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23652, 23696);

                ExtraCommands = f_1477_23668_23695();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23710, 23739);

                RunningExtraCommands = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23753, 23782);

                _rsConnection = runspacePool;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23796, 23824);

                InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23838, 23922);

                InvocationStateInfo = f_1477_23860_23921(PSInvocationState.NotStarted, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 23936, 23998);

                InformationalBuffers = f_1477_23959_23997(f_1477_23986_23996());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24012, 24046);

                Streams = f_1477_24022_24045(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24062, 24161);

                PSDataCollectionStream<PSObject>
                outputdatastream = (PSDataCollectionStream<PSObject>)outputstream
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24175, 24219);

                OutputBuffer = f_1477_24190_24218(outputdatastream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24235, 24338);

                PSDataCollectionStream<ErrorRecord>
                errordatastream = (PSDataCollectionStream<ErrorRecord>)errorstream
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24352, 24395);

                _errorBuffer = f_1477_24367_24394(errordatastream);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24411, 24628) || true) && (runspacePool != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 24415, 24486) && f_1477_24439_24478(runspacePool) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 24411, 24628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24520, 24613);

                    RemotePowerShell = f_1477_24539_24612(this, f_1477_24572_24611(runspacePool));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 24411, 24628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24644, 24673);

                _endInvokeMethod = EndInvoke;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 24687, 24712);

                _endStopMethod = EndStop;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 23477, 24723);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 23477, 24723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 23477, 24723);
            }
        }

        internal PowerShell(ConnectCommandInfo connectCmdInfo, ObjectStreamBase inputstream, ObjectStreamBase outputstream,
                    ObjectStreamBase errorstream, RunspacePool runspacePool)
        : this(f_1477_25457_25468_C(inputstream), outputstream, errorstream, runspacePool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 25251, 26215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25535, 25579);

                ExtraCommands = f_1477_25551_25578();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25593, 25622);

                RunningExtraCommands = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25636, 25665);

                _psCommand = f_1477_25649_25664();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25679, 25703);

                _psCommand.Owner = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25717, 25746);

                _runspacePool = runspacePool;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25762, 25797);

                f_1477_25762_25796(this, f_1477_25773_25795(connectCmdInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25811, 25844);

                _connectCmdInfo = connectCmdInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 25954, 25993);

                InstanceId = f_1477_25967_25992(_connectCmdInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 26009, 26095);

                InvocationStateInfo = f_1477_26031_26094(PSInvocationState.Disconnected, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 26111, 26204);

                RemotePowerShell = f_1477_26130_26203(this, f_1477_26163_26202(runspacePool));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 25251, 26215);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 25251, 26215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 25251, 26215);
            }
        }

        internal void InitForRemotePipeline(CommandCollection command, ObjectStreamBase inputstream,
                    ObjectStreamBase outputstream, ObjectStreamBase errorstream, PSInvocationSettings settings, bool redirectShellErrorOutputPipe)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 26607, 28317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 26864, 26937);

                f_1477_26864_26936(command != null, "A command collection need to be specified");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 26953, 26992);

                _psCommand = f_1477_26966_26991(f_1477_26980_26990(command, 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27006, 27030);

                _psCommand.Owner = this;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27055, 27060);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27046, 27156) || true) && (i < f_1477_27066_27079(command))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27081, 27084)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 27046, 27156))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 27046, 27156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27118, 27141);

                        f_1477_27118_27140(this, f_1477_27129_27139(command, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27172, 27232);

                RedirectShellErrorOutputPipe = redirectShellErrorOutputPipe;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27344, 27531) || true) && (f_1477_27348_27364() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 27344, 27531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 27406, 27516);

                    RemotePowerShell = f_1477_27425_27515(this, f_1477_27458_27514(((RunspacePool)_rsConnection)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 27344, 27531);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 28044, 28066);

                f_1477_28044_28065(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 28082, 28173) || true) && (_isBatching)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 28082, 28173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 28131, 28158);

                    f_1477_28131_28157(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 28082, 28173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 28189, 28306);

                f_1477_28189_28305(f_1477_28189_28205(), inputstream, outputstream, errorstream, f_1477_28274_28294(), settings);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 26607, 28317);

                int
                f_1477_26864_26936(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 26864, 26936);
                    return 0;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_26980_26990(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 26980, 26990);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_26966_26991(System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = new System.Management.Automation.PSCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 26966, 26991);
                    return return_v;
                }


                int
                f_1477_27066_27079(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 27066, 27079);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_27129_27139(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 27129, 27139);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_27118_27140(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 27118, 27140);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_27348_27364()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 27348, 27364);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_27458_27514(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 27458, 27514);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_27425_27515(System.Management.Automation.PowerShell
                shell, System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                runspacePool)
                {
                    var return_v = new System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell(shell, runspacePool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 27425, 27515);
                    return return_v;
                }


                int
                f_1477_28044_28065(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.DetermineIsBatching();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 28044, 28065);
                    return 0;
                }


                int
                f_1477_28131_28157(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.SetupAsyncBatchExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 28131, 28157);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_28189_28205()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 28189, 28205);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1477_28274_28294()
                {
                    var return_v = InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 28274, 28294);
                    return return_v;
                }


                int
                f_1477_28189_28305(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param, System.Management.Automation.Internal.ObjectStreamBase
                inputstream, System.Management.Automation.Internal.ObjectStreamBase
                outputstream, System.Management.Automation.Internal.ObjectStreamBase
                errorstream, System.Management.Automation.PSInformationalBuffers
                informationalBuffers, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Initialize(inputstream, outputstream, errorstream, informationalBuffers, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 28189, 28305);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 26607, 28317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 26607, 28317);
            }
        }

        internal void InitForRemotePipelineConnect(ObjectStreamBase inputstream, ObjectStreamBase outputstream,
                    ObjectStreamBase errorstream, PSInvocationSettings settings, bool redirectShellErrorOutputPipe)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 28790, 29919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29204, 29234);

                f_1477_29204_29233(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29250, 29431) || true) && (f_1477_29254_29279(f_1477_29254_29273()) != PSInvocationState.Disconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 29250, 29431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29347, 29416);

                    throw f_1477_29353_29415(f_1477_29389_29414(f_1477_29389_29408()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 29250, 29431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29447, 29507);

                RedirectShellErrorOutputPipe = redirectShellErrorOutputPipe;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29523, 29710) || true) && (f_1477_29527_29543() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 29523, 29710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29585, 29695);

                    RemotePowerShell = f_1477_29604_29694(this, f_1477_29637_29693(((RunspacePool)_rsConnection)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 29523, 29710);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29726, 29908) || true) && (f_1477_29730_29759_M(!f_1477_29731_29747().Initialized))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 29726, 29908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 29793, 29893);

                    f_1477_29793_29892(f_1477_29793_29809(), inputstream, outputstream, errorstream, f_1477_29861_29881(), settings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 29726, 29908);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 28790, 29919);

                int
                f_1477_29204_29233(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.CheckRunspacePoolAndConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 29204, 29233);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_29254_29273()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29254, 29273);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_29254_29279(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29254, 29279);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_29389_29408()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29389, 29408);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_29389_29414(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29389, 29414);
                    return return_v;
                }


                System.Management.Automation.InvalidPowerShellStateException
                f_1477_29353_29415(System.Management.Automation.PSInvocationState
                currentState)
                {
                    var return_v = new System.Management.Automation.InvalidPowerShellStateException(currentState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 29353, 29415);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_29527_29543()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29527, 29543);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_29637_29693(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29637, 29693);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_29604_29694(System.Management.Automation.PowerShell
                shell, System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                runspacePool)
                {
                    var return_v = new System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell(shell, runspacePool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 29604, 29694);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_29731_29747()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29731, 29747);
                    return return_v;
                }


                bool
                f_1477_29730_29759_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29730, 29759);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_29793_29809()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29793, 29809);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1477_29861_29881()
                {
                    var return_v = InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 29861, 29881);
                    return return_v;
                }


                int
                f_1477_29793_29892(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param, System.Management.Automation.Internal.ObjectStreamBase
                inputstream, System.Management.Automation.Internal.ObjectStreamBase
                outputstream, System.Management.Automation.Internal.ObjectStreamBase
                errorstream, System.Management.Automation.PSInformationalBuffers
                informationalBuffers, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Initialize(inputstream, outputstream, errorstream, informationalBuffers, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 29793, 29892);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 28790, 29919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 28790, 29919);
            }
        }

        public static PowerShell Create()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1477, 30246, 30366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 30304, 30355);

                return f_1477_30311_30354(f_1477_30326_30341(), null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1477, 30246, 30366);

                System.Management.Automation.PSCommand
                f_1477_30326_30341()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 30326, 30341);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_30311_30354(System.Management.Automation.PSCommand
                command, System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                extraCommands, object
                rsConnection)
                {
                    var return_v = new System.Management.Automation.PowerShell(command, extraCommands, rsConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 30311, 30354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 30246, 30366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 30246, 30366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PowerShell Create(RunspaceMode runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1477, 30662, 31621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 30741, 30766);

                PowerShell
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 30782, 31580);

                switch (runspace)
                {

                    case RunspaceMode.CurrentRunspace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 30782, 31580);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 30888, 31081) || true) && (f_1477_30892_30916() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 30888, 31081);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 30974, 31058);

                            throw f_1477_30980_31057(f_1477_31010_31056());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 30888, 31081);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 31105, 31178);

                        result = f_1477_31114_31177(f_1477_31129_31144(), null, f_1477_31152_31176());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 31200, 31222);

                        result.IsChild = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 31244, 31267);

                        result.IsNested = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 31289, 31320);

                        result.IsRunspaceOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 31342, 31386);

                        result._runspace = f_1477_31361_31385();
                        DynAbs.Tracing.TraceSender.TraceBreak(1477, 31408, 31414);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 30782, 31580);

                    case RunspaceMode.NewRunspace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 30782, 31580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 31484, 31537);

                        result = f_1477_31493_31536(f_1477_31508_31523(), null, null);
                        DynAbs.Tracing.TraceSender.TraceBreak(1477, 31559, 31565);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 30782, 31580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 31596, 31610);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1477, 30662, 31621);

                System.Management.Automation.Runspaces.Runspace
                f_1477_30892_30916()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 30892, 30916);
                    return return_v;
                }


                string
                f_1477_31010_31056()
                {
                    var return_v = PowerShellStrings.NoDefaultRunspaceForPSCreate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 31010, 31056);
                    return return_v;
                }


                System.InvalidOperationException
                f_1477_30980_31057(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 30980, 31057);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_31129_31144()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 31129, 31144);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_31152_31176()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 31152, 31176);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_31114_31177(System.Management.Automation.PSCommand
                command, System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                extraCommands, System.Management.Automation.Runspaces.Runspace
                rsConnection)
                {
                    var return_v = new System.Management.Automation.PowerShell(command, extraCommands, (object)rsConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 31114, 31177);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_31361_31385()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 31361, 31385);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_31508_31523()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 31508, 31523);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_31493_31536(System.Management.Automation.PSCommand
                command, System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                extraCommands, object
                rsConnection)
                {
                    var return_v = new System.Management.Automation.PowerShell(command, extraCommands, rsConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 31493, 31536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 30662, 31621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 30662, 31621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PowerShell Create(InitialSessionState initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1477, 31968, 32258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 32065, 32094);

                PowerShell
                result = f_1477_32085_32093()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 32110, 32180);

                result.Runspace = f_1477_32128_32179(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 32194, 32217);

                f_1477_32194_32216(f_1477_32194_32209(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 32233, 32247);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1477, 31968, 32258);

                System.Management.Automation.PowerShell
                f_1477_32085_32093()
                {
                    var return_v = Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 32085, 32093);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_32128_32179(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspace(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 32128, 32179);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_32194_32209(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 32194, 32209);
                    return return_v;
                }


                int
                f_1477_32194_32216(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 32194, 32216);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 31968, 32258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 31968, 32258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PowerShell Create(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1477, 33065, 33388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 33140, 33261) || true) && (runspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 33140, 33261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 33194, 33246);

                    throw f_1477_33200_33245(nameof(runspace));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 33140, 33261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 33277, 33306);

                PowerShell
                result = f_1477_33297_33305()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 33320, 33347);

                result.Runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 33363, 33377);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1477, 33065, 33388);

                System.Management.Automation.PSArgumentNullException
                f_1477_33200_33245(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 33200, 33245);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_33297_33305()
                {
                    var return_v = Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 33297, 33305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 33065, 33388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 33065, 33388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ps", Justification = "ps represents PowerShell and is used at many places.")]
        public PowerShell CreateNestedPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 34350, 35031);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 34600, 34911) || true) && ((_worker != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 34604, 34667) && (f_1477_34626_34658(_worker) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 34600, 34911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 34701, 34823);

                    PowerShell
                    result = f_1477_34721_34822(f_1477_34736_34751(), null, f_1477_34780_34821(f_1477_34780_34812(_worker)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 34841, 34864);

                    result.IsNested = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 34882, 34896);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 34600, 34911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 34927, 35020);

                throw f_1477_34933_35019(f_1477_34976_35018());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 34350, 35031);

                System.Management.Automation.Runspaces.Pipeline
                f_1477_34626_34658(System.Management.Automation.PowerShell.Worker
                this_param)
                {
                    var return_v = this_param.CurrentlyRunningPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 34626, 34658);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_34736_34751()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 34736, 34751);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1477_34780_34812(System.Management.Automation.PowerShell.Worker
                this_param)
                {
                    var return_v = this_param.CurrentlyRunningPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 34780, 34812);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_34780_34821(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 34780, 34821);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_34721_34822(System.Management.Automation.PSCommand
                command, System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                extraCommands, System.Management.Automation.Runspaces.Runspace
                rsConnection)
                {
                    var return_v = new System.Management.Automation.PowerShell(command, extraCommands, (object)rsConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 34721, 34822);
                    return return_v;
                }


                string
                f_1477_34976_35018()
                {
                    var return_v = PowerShellStrings.InvalidStateCreateNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 34976, 35018);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_34933_35019(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 34933, 35019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 34350, 35031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 34350, 35031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PowerShell Create(bool isNested, PSCommand psCommand, Collection<PSCommand> extraCommands)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1477, 35440, 35729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 35570, 35641);

                PowerShell
                powerShell = f_1477_35594_35640(psCommand, extraCommands, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 35655, 35686);

                powerShell.IsNested = isNested;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 35700, 35718);

                return powerShell;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1477, 35440, 35729);

                System.Management.Automation.PowerShell
                f_1477_35594_35640(System.Management.Automation.PSCommand
                command, System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                extraCommands, object
                rsConnection)
                {
                    var return_v = new System.Management.Automation.PowerShell(command, extraCommands, rsConnection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 35594, 35640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 35440, 35729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 35440, 35729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddCommand(string cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 36867, 37121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 36941, 36952);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 36986, 37013);

                    f_1477_36986_37012(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 37033, 37063);

                    f_1477_37033_37062(
                                    _psCommand, cmdlet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 37083, 37095);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 36867, 37121);

                int
                f_1477_36986_37012(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 36986, 37012);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_37033_37062(System.Management.Automation.PSCommand
                this_param, string
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 37033, 37062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 36867, 37121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 36867, 37121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddCommand(string cmdlet, bool useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 38317, 38606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 38411, 38422);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 38456, 38483);

                    f_1477_38456_38482(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 38503, 38548);

                    f_1477_38503_38547(
                                    _psCommand, cmdlet, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 38568, 38580);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 38317, 38606);

                int
                f_1477_38456_38482(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 38456, 38482);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_38503_38547(System.Management.Automation.PSCommand
                this_param, string
                cmdlet, bool
                useLocalScope)
                {
                    var return_v = this_param.AddCommand(cmdlet, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 38503, 38547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 38317, 38606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 38317, 38606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddScript(string script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 39754, 40006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 39827, 39838);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 39872, 39899);

                    f_1477_39872_39898(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 39919, 39948);

                    f_1477_39919_39947(
                                    _psCommand, script);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 39968, 39980);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 39754, 40006);

                int
                f_1477_39872_39898(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 39872, 39898);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_39919_39947(System.Management.Automation.PSCommand
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 39919, 39947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 39754, 40006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 39754, 40006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddScript(string script, bool useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 41286, 41573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 41379, 41390);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 41424, 41451);

                    f_1477_41424_41450(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 41471, 41515);

                    f_1477_41471_41514(
                                    _psCommand, script, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 41535, 41547);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 41286, 41573);

                int
                f_1477_41424_41450(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 41424, 41450);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_41471_41514(System.Management.Automation.PSCommand
                this_param, string
                script, bool
                useLocalScope)
                {
                    var return_v = this_param.AddScript(script, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 41471, 41514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 41286, 41573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 41286, 41573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PowerShell AddCommand(Command command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 42427, 42686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 42505, 42516);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 42550, 42577);

                    f_1477_42550_42576(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 42597, 42628);

                    f_1477_42597_42627(
                                    _psCommand, command);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 42648, 42660);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 42427, 42686);

                int
                f_1477_42550_42576(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 42550, 42576);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_42597_42627(System.Management.Automation.PSCommand
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 42597, 42627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 42427, 42686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 42427, 42686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddCommand(CommandInfo commandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 43493, 43836);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 43571, 43703) || true) && (commandInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 43571, 43703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 43628, 43688);

                    throw f_1477_43634_43687("commandInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 43571, 43703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 43719, 43758);

                Command
                cmd = f_1477_43733_43757(commandInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 43772, 43799);

                f_1477_43772_43798(_psCommand, cmd);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 43813, 43825);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 43493, 43836);

                System.Management.Automation.PSArgumentNullException
                f_1477_43634_43687(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 43634, 43687);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_43733_43757(System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 43733, 43757);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_43772_43798(System.Management.Automation.PSCommand
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 43772, 43798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 43493, 43836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 43493, 43836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddParameter(string parameterName, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 45201, 45698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 45298, 45309);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 45343, 45531) || true) && (f_1477_45347_45372(f_1477_45347_45366(_psCommand)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 45343, 45531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 45419, 45512);

                        throw f_1477_45425_45511(f_1477_45468_45510());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 45343, 45531);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 45551, 45578);

                    f_1477_45551_45577(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 45596, 45642);

                    f_1477_45596_45641(_psCommand, parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 45660, 45672);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 45201, 45698);

                System.Management.Automation.Runspaces.CommandCollection
                f_1477_45347_45366(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 45347, 45366);
                    return return_v;
                }


                int
                f_1477_45347_45372(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 45347, 45372);
                    return return_v;
                }


                string
                f_1477_45468_45510()
                {
                    var return_v = PowerShellStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 45468, 45510);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_45425_45511(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 45425, 45511);
                    return return_v;
                }


                int
                f_1477_45551_45577(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 45551, 45577);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_45596_45641(System.Management.Automation.PSCommand
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 45596, 45641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 45201, 45698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 45201, 45698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddParameter(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 46962, 47438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 47045, 47056);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 47090, 47278) || true) && (f_1477_47094_47119(f_1477_47094_47113(_psCommand)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 47090, 47278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 47166, 47259);

                        throw f_1477_47172_47258(f_1477_47215_47257());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 47090, 47278);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 47298, 47325);

                    f_1477_47298_47324(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 47343, 47382);

                    f_1477_47343_47381(_psCommand, parameterName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 47400, 47412);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 46962, 47438);

                System.Management.Automation.Runspaces.CommandCollection
                f_1477_47094_47113(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 47094, 47113);
                    return return_v;
                }


                int
                f_1477_47094_47119(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 47094, 47119);
                    return return_v;
                }


                string
                f_1477_47215_47257()
                {
                    var return_v = PowerShellStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 47215, 47257);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_47172_47258(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 47172, 47258);
                    return return_v;
                }


                int
                f_1477_47298_47324(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 47298, 47324);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_47343_47381(System.Management.Automation.PSCommand
                this_param, string
                parameterName)
                {
                    var return_v = this_param.AddParameter(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 47343, 47381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 46962, 47438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 46962, 47438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddParameters(IList parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 48251, 48976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48331, 48342);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48376, 48518) || true) && (parameters == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 48376, 48518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48440, 48499);

                        throw f_1477_48446_48498("parameters");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 48376, 48518);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48538, 48726) || true) && (f_1477_48542_48567(f_1477_48542_48561(_psCommand)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 48538, 48726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48614, 48707);

                        throw f_1477_48620_48706(f_1477_48663_48705());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 48538, 48726);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48746, 48773);

                    f_1477_48746_48772(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48793, 48918);
                        foreach (object p in f_1477_48814_48824_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 48793, 48918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48866, 48899);

                            f_1477_48866_48898(_psCommand, null, p);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 48793, 48918);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 126);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 126);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 48938, 48950);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 48251, 48976);

                System.Management.Automation.PSArgumentNullException
                f_1477_48446_48498(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 48446, 48498);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_48542_48561(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 48542, 48561);
                    return return_v;
                }


                int
                f_1477_48542_48567(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 48542, 48567);
                    return return_v;
                }


                string
                f_1477_48663_48705()
                {
                    var return_v = PowerShellStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 48663, 48705);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_48620_48706(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 48620, 48706);
                    return return_v;
                }


                int
                f_1477_48746_48772(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 48746, 48772);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_48866_48898(System.Management.Automation.PSCommand
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 48866, 48898);
                    return return_v;
                }


                System.Collections.IList
                f_1477_48814_48824_I(System.Collections.IList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 48814, 48824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 48251, 48976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 48251, 48976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddParameters(IDictionary parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 50016, 51058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50102, 50113);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50147, 50289) || true) && (parameters == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 50147, 50289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50211, 50270);

                        throw f_1477_50217_50269("parameters");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 50147, 50289);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50309, 50497) || true) && (f_1477_50313_50338(f_1477_50313_50332(_psCommand)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 50309, 50497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50385, 50478);

                        throw f_1477_50391_50477(f_1477_50434_50476());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 50309, 50497);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50517, 50544);

                    f_1477_50517_50543(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50564, 51000);
                        foreach (DictionaryEntry entry in f_1477_50598_50608_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 50564, 51000);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50650, 50693);

                            string
                            parameterName = entry.Key as string
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50717, 50905) || true) && (parameterName == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 50717, 50905);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50792, 50882);

                                throw f_1477_50798_50881("parameters", f_1477_50847_50880());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 50717, 50905);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 50929, 50981);

                            f_1477_50929_50980(
                                                _psCommand, parameterName, entry.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 50564, 51000);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 437);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 437);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 51020, 51032);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 50016, 51058);

                System.Management.Automation.PSArgumentNullException
                f_1477_50217_50269(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 50217, 50269);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_50313_50332(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 50313, 50332);
                    return return_v;
                }


                int
                f_1477_50313_50338(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 50313, 50338);
                    return return_v;
                }


                string
                f_1477_50434_50476()
                {
                    var return_v = PowerShellStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 50434, 50476);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_50391_50477(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 50391, 50477);
                    return return_v;
                }


                int
                f_1477_50517_50543(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 50517, 50543);
                    return 0;
                }


                string
                f_1477_50847_50880()
                {
                    var return_v = PowerShellStrings.KeyMustBeString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 50847, 50880);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1477_50798_50881(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 50798, 50881);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_50929_50980(System.Management.Automation.PSCommand
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 50929, 50980);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1477_50598_50608_I(System.Collections.IDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 50598, 50608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 50016, 51058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 50016, 51058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddArgument(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 52119, 52577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 52193, 52204);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 52238, 52426) || true) && (f_1477_52242_52267(f_1477_52242_52261(_psCommand)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 52238, 52426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 52314, 52407);

                        throw f_1477_52320_52406(f_1477_52363_52405());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 52238, 52426);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 52446, 52473);

                    f_1477_52446_52472(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 52491, 52521);

                    f_1477_52491_52520(_psCommand, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 52539, 52551);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 52119, 52577);

                System.Management.Automation.Runspaces.CommandCollection
                f_1477_52242_52261(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 52242, 52261);
                    return return_v;
                }


                int
                f_1477_52242_52267(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 52242, 52267);
                    return return_v;
                }


                string
                f_1477_52363_52405()
                {
                    var return_v = PowerShellStrings.ParameterRequiresCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 52363, 52405);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_52320_52406(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 52320, 52406);
                    return return_v;
                }


                int
                f_1477_52446_52472(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 52446, 52472);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_52491_52520(System.Management.Automation.PSCommand
                this_param, object
                value)
                {
                    var return_v = this_param.AddArgument(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 52491, 52520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 52119, 52577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 52119, 52577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShell AddStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 53346, 53930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 53409, 53420);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 53623, 53730) || true) && (f_1477_53627_53652(f_1477_53627_53646(_psCommand)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 53623, 53730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 53699, 53711);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 53623, 53730);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 53750, 53777);

                    f_1477_53750_53776(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 53797, 53872);

                    f_1477_53797_53847(f_1477_53797_53816(_psCommand), f_1477_53817_53842(f_1477_53817_53836(_psCommand)) - 1).IsEndOfStatement = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 53892, 53904);

                    return this;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 53346, 53930);

                System.Management.Automation.Runspaces.CommandCollection
                f_1477_53627_53646(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 53627, 53646);
                    return return_v;
                }


                int
                f_1477_53627_53652(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 53627, 53652);
                    return return_v;
                }


                int
                f_1477_53750_53776(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 53750, 53776);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_53797_53816(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 53797, 53816);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_53817_53836(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 53817, 53836);
                    return return_v;
                }


                int
                f_1477_53817_53842(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 53817, 53842);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_53797_53847(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 53797, 53847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 53346, 53930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 53346, 53930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSCommand Commands
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 54569, 54638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 54605, 54623);

                    return _psCommand;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 54569, 54638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 54519, 55070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 54519, 55070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 54654, 55059);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 54690, 54824) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 54690, 54824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 54749, 54805);

                        throw f_1477_54755_54804("Command");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 54690, 54824);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 54850, 54861);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 54903, 54930);

                        f_1477_54903_54929(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 54952, 54979);

                        _psCommand = f_1477_54965_54978(value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 55001, 55025);

                        _psCommand.Owner = this;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 54654, 55059);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_54755_54804(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 54755, 54804);
                        return return_v;
                    }


                    int
                    f_1477_54903_54929(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 54903, 54929);
                        return 0;
                    }


                    System.Management.Automation.PSCommand
                    f_1477_54965_54978(System.Management.Automation.PSCommand
                    this_param)
                    {
                        var return_v = this_param.Clone();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 54965, 54978);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 54519, 55070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 54519, 55070);
                }
            }
        }

        public PSDataStreams Streams { get; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        internal PSDataCollection<ErrorRecord> ErrorBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 56055, 56126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 56091, 56111);

                    return _errorBuffer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 56055, 56126);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 55814, 56551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 55814, 56551);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 56142, 56540);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 56178, 56310) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 56178, 56310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 56237, 56291);

                        throw f_1477_56243_56290("Error");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 56178, 56310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 56336, 56347);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 56389, 56416);

                        f_1477_56389_56415(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 56438, 56459);

                        _errorBuffer = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 56481, 56506);

                        ErrorBufferOwner = false;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 56142, 56540);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_56243_56290(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 56243, 56290);
                        return return_v;
                    }


                    int
                    f_1477_56389_56415(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 56389, 56415);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 55814, 56551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 55814, 56551);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        internal PSDataCollection<ProgressRecord> ProgressBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 57286, 57374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 57322, 57359);

                    return f_1477_57329_57358(f_1477_57329_57349());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 57286, 57374);

                    System.Management.Automation.PSInformationalBuffers
                    f_1477_57329_57349()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 57329, 57349);
                        return return_v;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                    f_1477_57329_57358(System.Management.Automation.PSInformationalBuffers
                    this_param)
                    {
                        var return_v = this_param.Progress;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 57329, 57358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 57039, 57772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 57039, 57772);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 57390, 57761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 57426, 57561) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 57426, 57561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 57485, 57542);

                        throw f_1477_57491_57541("Progress");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 57426, 57561);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 57587, 57598);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 57640, 57667);

                        f_1477_57640_57666(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 57689, 57727);

                        f_1477_57689_57709().Progress = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 57390, 57761);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_57491_57541(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 57491, 57541);
                        return return_v;
                    }


                    int
                    f_1477_57640_57666(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 57640, 57666);
                        return 0;
                    }


                    System.Management.Automation.PSInformationalBuffers
                    f_1477_57689_57709()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 57689, 57709);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 57039, 57772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 57039, 57772);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        internal PSDataCollection<VerboseRecord> VerboseBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 58504, 58591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 58540, 58576);

                    return f_1477_58547_58575(f_1477_58547_58567());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 58504, 58591);

                    System.Management.Automation.PSInformationalBuffers
                    f_1477_58547_58567()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 58547, 58567);
                        return return_v;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                    f_1477_58547_58575(System.Management.Automation.PSInformationalBuffers
                    this_param)
                    {
                        var return_v = this_param.Verbose;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 58547, 58575);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 58259, 58987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 58259, 58987);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 58607, 58976);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 58643, 58777) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 58643, 58777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 58702, 58758);

                        throw f_1477_58708_58757("Verbose");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 58643, 58777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 58803, 58814);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 58856, 58883);

                        f_1477_58856_58882(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 58905, 58942);

                        f_1477_58905_58925().Verbose = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 58607, 58976);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_58708_58757(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 58708, 58757);
                        return return_v;
                    }


                    int
                    f_1477_58856_58882(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 58856, 58882);
                        return 0;
                    }


                    System.Management.Automation.PSInformationalBuffers
                    f_1477_58905_58925()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 58905, 58925);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 58259, 58987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 58259, 58987);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        internal PSDataCollection<DebugRecord> DebugBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 59711, 59796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 59747, 59781);

                    return f_1477_59754_59780(f_1477_59754_59774());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 59711, 59796);

                    System.Management.Automation.PSInformationalBuffers
                    f_1477_59754_59774()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 59754, 59774);
                        return return_v;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                    f_1477_59754_59780(System.Management.Automation.PSInformationalBuffers
                    this_param)
                    {
                        var return_v = this_param.Debug;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 59754, 59780);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 59470, 60188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 59470, 60188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 59812, 60177);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 59848, 59980) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 59848, 59980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 59907, 59961);

                        throw f_1477_59913_59960("Debug");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 59848, 59980);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 60006, 60017);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 60059, 60086);

                        f_1477_60059_60085(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 60108, 60143);

                        f_1477_60108_60128().Debug = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 59812, 60177);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_59913_59960(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 59913, 59960);
                        return return_v;
                    }


                    int
                    f_1477_60059_60085(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 60059, 60085);
                        return 0;
                    }


                    System.Management.Automation.PSInformationalBuffers
                    f_1477_60108_60128()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 60108, 60128);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 59470, 60188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 59470, 60188);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        internal PSDataCollection<WarningRecord> WarningBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 61040, 61127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 61076, 61112);

                    return f_1477_61083_61111(f_1477_61083_61103());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 61040, 61127);

                    System.Management.Automation.PSInformationalBuffers
                    f_1477_61083_61103()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 61083, 61103);
                        return return_v;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                    f_1477_61083_61111(System.Management.Automation.PSInformationalBuffers
                    this_param)
                    {
                        var return_v = this_param.Warning;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 61083, 61111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 60795, 61523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 60795, 61523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 61143, 61512);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 61179, 61313) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 61179, 61313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 61238, 61294);

                        throw f_1477_61244_61293("Warning");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 61179, 61313);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 61339, 61350);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 61392, 61419);

                        f_1477_61392_61418(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 61441, 61478);

                        f_1477_61441_61461().Warning = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 61143, 61512);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_61244_61293(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 61244, 61293);
                        return return_v;
                    }


                    int
                    f_1477_61392_61418(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 61392, 61418);
                        return 0;
                    }


                    System.Management.Automation.PSInformationalBuffers
                    f_1477_61441_61461()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 61441, 61461);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 60795, 61523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 60795, 61523);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        internal PSDataCollection<InformationRecord> InformationBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 62391, 62482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62427, 62467);

                    return f_1477_62434_62466(f_1477_62434_62454());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 62391, 62482);

                    System.Management.Automation.PSInformationalBuffers
                    f_1477_62434_62454()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 62434, 62454);
                        return return_v;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                    f_1477_62434_62466(System.Management.Automation.PSInformationalBuffers
                    this_param)
                    {
                        var return_v = this_param.Information;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 62434, 62466);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 62138, 62886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 62138, 62886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 62498, 62875);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62534, 62672) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 62534, 62672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62593, 62653);

                        throw f_1477_62599_62652("Information");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 62534, 62672);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62698, 62709);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62751, 62778);

                        f_1477_62751_62777(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 62800, 62841);

                        f_1477_62800_62820().Information = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 62498, 62875);

                    System.Management.Automation.PSArgumentNullException
                    f_1477_62599_62652(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 62599, 62652);
                        return return_v;
                    }


                    int
                    f_1477_62751_62777(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 62751, 62777);
                        return 0;
                    }


                    System.Management.Automation.PSInformationalBuffers
                    f_1477_62800_62820()
                    {
                        var return_v = InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 62800, 62820);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 62138, 62886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 62138, 62886);
                }
            }
        }

        internal PSInformationalBuffers InformationalBuffers { get; }

        internal bool RedirectShellErrorOutputPipe { get; set; }

        public Guid InstanceId { get; private set; }

        public PSInvocationStateInfo InvocationStateInfo { get; private set; }

        public bool IsNested { get; private set; }

        internal bool IsChild { get; private set; }

        public bool HadErrors { get; private set; }

        internal void SetHadErrors(bool status)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 64729, 64823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 64793, 64812);

                HadErrors = status;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 64729, 64823);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 64729, 64823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 64729, 64823);
            }
        }

        internal AsyncResult EndInvokeAsyncResult
        {
            get;
            private set;
        }

        /// <summary>
        /// Event raised when PowerShell Execution State Changes.
        /// </summary>
        public event EventHandler<PSInvocationStateChangedEventArgs>
InvocationStateChanged
;

        /// <summary>
        /// This event gets fired when a Runspace from the RunspacePool is assigned to this PowerShell
        /// instance to invoke the commands.
        /// </summary>
        internal event EventHandler<PSEventArgs<Runspace>>
RunspaceAssigned
;

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace", Justification = "Runspace is a well-known term in PowerShell.")]
        public Runspace Runspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 66604, 67262);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 66640, 67210) || true) && (_runspace == null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 66644, 66686) && _runspacePool == null))
                    ) // create a runspace only if neither a runspace nor a runspace pool have been set

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 66640, 67210);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 66816, 66827);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 66877, 67168) || true) && (_runspace == null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 66881, 66923) && _runspacePool == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 66877, 67168);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 66981, 67008);

                                f_1477_66981_67007(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67038, 67090);

                                f_1477_67038_67089(this, f_1477_67050_67082(), true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67120, 67141);

                                f_1477_67120_67140(f_1477_67120_67133(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 66877, 67168);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 66640, 67210);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67230, 67247);

                    return _runspace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 66604, 67262);

                    int
                    f_1477_66981_67007(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 66981, 67007);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1477_67050_67082()
                    {
                        var return_v = RunspaceFactory.CreateRunspace();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 67050, 67082);
                        return return_v;
                    }


                    int
                    f_1477_67038_67089(System.Management.Automation.PowerShell
                    this_param, System.Management.Automation.Runspaces.Runspace
                    runspace, bool
                    owner)
                    {
                        this_param.SetRunspace(runspace, owner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 67038, 67089);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1477_67120_67133(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 67120, 67133);
                        return return_v;
                    }


                    int
                    f_1477_67120_67140(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        this_param.Open();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 67120, 67140);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 66374, 67745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 66374, 67745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 67278, 67734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67320, 67331);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67373, 67400);

                        f_1477_67373_67399(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67424, 67650) || true) && (_runspace != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 67428, 67464) && f_1477_67449_67464()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 67424, 67650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67514, 67534);

                            f_1477_67514_67533(_runspace);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67560, 67577);

                            _runspace = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67603, 67627);

                            IsRunspaceOwner = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 67424, 67650);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67674, 67700);

                        f_1477_67674_67699(this, value, false);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 67278, 67734);

                    int
                    f_1477_67373_67399(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 67373, 67399);
                        return 0;
                    }


                    bool
                    f_1477_67449_67464()
                    {
                        var return_v = IsRunspaceOwner;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 67449, 67464);
                        return return_v;
                    }


                    int
                    f_1477_67514_67533(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 67514, 67533);
                        return 0;
                    }


                    int
                    f_1477_67674_67699(System.Management.Automation.PowerShell
                    this_param, System.Management.Automation.Runspaces.Runspace
                    runspace, bool
                    owner)
                    {
                        this_param.SetRunspace(runspace, owner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 67674, 67699);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 66374, 67745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 66374, 67745);
                }
            }
        }

        private void SetRunspace(Runspace runspace, bool owner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 67863, 68660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 67943, 68002);

                RemoteRunspace
                remoteRunspace = runspace as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68018, 68539) || true) && (remoteRunspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 68018, 68539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68078, 68103);

                    _rsConnection = runspace;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 68018, 68539);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 68018, 68539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68169, 68213);

                    _rsConnection = f_1477_68185_68212(remoteRunspace);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68233, 68396) || true) && (f_1477_68237_68253() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 68233, 68396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68303, 68328);

                        f_1477_68303_68327(f_1477_68303_68319());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68350, 68377);

                        f_1477_68350_68376(f_1477_68350_68366());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 68233, 68396);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68416, 68524);

                    RemotePowerShell = f_1477_68435_68523(this, f_1477_68468_68522(f_1477_68468_68495(remoteRunspace)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 68018, 68539);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68555, 68576);

                _runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68590, 68614);

                IsRunspaceOwner = owner;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 68628, 68649);

                _runspacePool = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 67863, 68660);

                System.Management.Automation.Runspaces.RunspacePool
                f_1477_68185_68212(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 68185, 68212);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_68237_68253()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 68237, 68253);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_68303_68319()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 68303, 68319);
                    return return_v;
                }


                int
                f_1477_68303_68327(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 68303, 68327);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_68350_68366()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 68350, 68366);
                    return return_v;
                }


                int
                f_1477_68350_68376(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 68350, 68376);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1477_68468_68495(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 68468, 68495);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_68468_68522(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 68468, 68522);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_68435_68523(System.Management.Automation.PowerShell
                shell, System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                runspacePool)
                {
                    var return_v = new System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell(shell, runspacePool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 68435, 68523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 67863, 68660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 67863, 68660);
            }
        }

        private Runspace _runspace;

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace", Justification = "Runspace is a well-known term in PowerShell.")]
        public RunspacePool RunspacePool
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 69751, 69823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 69787, 69808);

                    return _runspacePool;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 69751, 69823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 69513, 71022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 69513, 71022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 69839, 71011);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 69875, 70996) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 69875, 70996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 69940, 69951);
                        lock (_syncObject)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70001, 70028);

                            f_1477_70001_70027(this);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70056, 70302) || true) && (_runspace != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 70060, 70096) && f_1477_70081_70096()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 70056, 70302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70154, 70174);

                                f_1477_70154_70173(_runspace);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70204, 70221);

                                _runspace = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70251, 70275);

                                IsRunspaceOwner = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 70056, 70302);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70330, 70352);

                            _rsConnection = value;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70378, 70400);

                            _runspacePool = value;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70428, 70909) || true) && (f_1477_70432_70454(_runspacePool))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 70428, 70909);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70512, 70723) || true) && (f_1477_70516_70532() != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 70512, 70723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70606, 70631);

                                    f_1477_70606_70630(f_1477_70606_70622());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70665, 70692);

                                    f_1477_70665_70691(f_1477_70665_70681());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 70512, 70723);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70755, 70882);

                                RemotePowerShell = f_1477_70774_70881(this, f_1477_70840_70880(_runspacePool));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 70428, 70909);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 70937, 70954);

                            _runspace = null;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 69875, 70996);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 69839, 71011);

                    int
                    f_1477_70001_70027(System.Management.Automation.PowerShell
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 70001, 70027);
                        return 0;
                    }


                    bool
                    f_1477_70081_70096()
                    {
                        var return_v = IsRunspaceOwner;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 70081, 70096);
                        return return_v;
                    }


                    int
                    f_1477_70154_70173(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 70154, 70173);
                        return 0;
                    }


                    bool
                    f_1477_70432_70454(System.Management.Automation.Runspaces.RunspacePool
                    this_param)
                    {
                        var return_v = this_param.IsRemote;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 70432, 70454);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                    f_1477_70516_70532()
                    {
                        var return_v = RemotePowerShell;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 70516, 70532);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                    f_1477_70606_70622()
                    {
                        var return_v = RemotePowerShell;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 70606, 70622);
                        return return_v;
                    }


                    int
                    f_1477_70606_70630(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 70606, 70630);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                    f_1477_70665_70681()
                    {
                        var return_v = RemotePowerShell;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 70665, 70681);
                        return return_v;
                    }


                    int
                    f_1477_70665_70691(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 70665, 70691);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                    f_1477_70840_70880(System.Management.Automation.Runspaces.RunspacePool
                    this_param)
                    {
                        var return_v = this_param.RemoteRunspacePoolInternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 70840, 70880);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                    f_1477_70774_70881(System.Management.Automation.PowerShell
                    shell, System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                    runspacePool)
                    {
                        var return_v = new System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell(shell, runspacePool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 70774, 70881);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 69513, 71022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 69513, 71022);
                }
            }
        }

        private RunspacePool _runspacePool;

        internal object GetRunspaceConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 71323, 71419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 71387, 71408);

                return _rsConnection;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 71323, 71419);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 71323, 71419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 71323, 71419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Connect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 71682, 72841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 71909, 71945);

                _commandInvokedSynchronously = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 71961, 72003);

                IAsyncResult
                asyncResult = f_1477_71988_72002(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72017, 72092);

                PowerShellAsyncResult
                psAsyncResult = asyncResult as PowerShellAsyncResult
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72344, 72381);

                EndInvokeAsyncResult = psAsyncResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72395, 72421);

                f_1477_72395_72420(psAsyncResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72435, 72463);

                EndInvokeAsyncResult = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72479, 72515);

                Collection<PSObject>
                results = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72529, 72799) || true) && (f_1477_72533_72553(psAsyncResult) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 72529, 72799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72595, 72636);

                    results = f_1477_72605_72635(f_1477_72605_72625(psAsyncResult));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 72529, 72799);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 72529, 72799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72747, 72784);

                    results = f_1477_72757_72783();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 72529, 72799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 72815, 72830);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 71682, 72841);

                System.IAsyncResult
                f_1477_71988_72002(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.ConnectAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 71988, 72002);
                    return return_v;
                }


                int
                f_1477_72395_72420(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    this_param.EndInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 72395, 72420);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_72533_72553(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 72533, 72553);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_72605_72625(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 72605, 72625);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1477_72605_72635(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 72605, 72635);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1477_72757_72783()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 72757, 72783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 71682, 72841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 71682, 72841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IAsyncResult ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 73172, 73280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 73231, 73269);

                return f_1477_73238_73268(this, null, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 73172, 73280);

                System.IAsyncResult
                f_1477_73238_73268(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.AsyncCallback
                invocationCallback, object
                state)
                {
                    var return_v = this_param.ConnectAsync(output, invocationCallback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 73238, 73268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 73172, 73280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 73172, 73280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IAsyncResult ConnectAsync(
                    PSDataCollection<PSObject> output,
                    AsyncCallback invocationCallback,
                    object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 73944, 79374);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 74124, 74305) || true) && (f_1477_74128_74153(f_1477_74128_74147()) != PSInvocationState.Disconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 74124, 74305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 74221, 74290);

                    throw f_1477_74227_74289(f_1477_74263_74288(f_1477_74263_74282()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 74124, 74305);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 74471, 74501);

                f_1477_74471_74500(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 74517, 78223) || true) && (_connectCmdInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 74517, 78223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 74704, 74758);

                    PSDataCollection<PSObject>
                    streamToUse = f_1477_74745_74757()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 74879, 76071) || true) && (f_1477_74883_74912_M(!f_1477_74884_74900().Initialized))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 74879, 76071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 74998, 75048);

                        ObjectStreamBase
                        inputStream = f_1477_75029_75047()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75070, 75090);

                        f_1477_75070_75089(inputStream);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75153, 75601) || true) && (output != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 75153, 75601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75281, 75303);

                            OutputBuffer = output;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75329, 75355);

                            OutputBufferOwner = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 75153, 75601);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 75153, 75601);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75405, 75601) || true) && (f_1477_75409_75421() == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 75405, 75601);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75479, 75527);

                                OutputBuffer = f_1477_75494_75526();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75553, 75578);

                                OutputBufferOwner = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 75405, 75601);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 75153, 75601);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75625, 75652);

                        streamToUse = f_1477_75639_75651();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75676, 75770);

                        ObjectStreamBase
                        outputStream = f_1477_75708_75769(f_1477_75745_75755(), streamToUse)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 75794, 76052);

                        f_1477_75794_76051(f_1477_75794_75810(), inputStream, outputStream, f_1477_75903_75968(f_1477_75943_75953(), _errorBuffer), f_1477_76024_76044(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 74879, 76071);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 76091, 76192);

                    f_1477_76091_76191((_invokeAsyncResult == null), "Async result should be null in the reconstruct scenario.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 76210, 76315);

                    _invokeAsyncResult = f_1477_76231_76314(f_1477_76257_76267(), invocationCallback, state, streamToUse, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 74517, 78223);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 74517, 78223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 76562, 76728);

                    f_1477_76562_76727((_invokeAsyncResult != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 76574, 76632) && f_1477_76604_76632(f_1477_76604_76620()))), "AsyncResult and RemotePowerShell objects must be valid here.");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 76748, 78208) || true) && (output != null || (DynAbs.Tracing.TraceSender.Expression_False(1477, 76752, 76817) || invocationCallback != null) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 76752, 76872) || f_1477_76842_76872(_invokeAsyncResult)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 76748, 78208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 76968, 77007);

                        PSDataCollection<PSObject>
                        streamToUse
                        = default(PSDataCollection<PSObject>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77029, 77840) || true) && (output != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 77029, 77840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77097, 77118);

                            streamToUse = output;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77144, 77166);

                            OutputBuffer = output;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77192, 77218);

                            OutputBufferOwner = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 77029, 77840);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 77029, 77840);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77268, 77840) || true) && (f_1477_77272_77297(_invokeAsyncResult) == null || (DynAbs.Tracing.TraceSender.Expression_False(1477, 77272, 77372) || f_1477_77339_77372_M(!f_1477_77340_77365(_invokeAsyncResult).IsOpen)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 77268, 77840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77422, 77470);

                                OutputBuffer = f_1477_77437_77469();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77496, 77521);

                                OutputBufferOwner = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77547, 77574);

                                streamToUse = f_1477_77561_77573();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 77268, 77840);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 77268, 77840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77672, 77712);

                                streamToUse = f_1477_77686_77711(_invokeAsyncResult);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77738, 77765);

                                OutputBuffer = streamToUse;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77791, 77817);

                                OutputBufferOwner = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 77268, 77840);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 77029, 77840);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 77864, 78189);

                        _invokeAsyncResult = f_1477_77885_78188(f_1477_77937_77947(), invocationCallback ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.AsyncCallback>(1477, 77974, 78023) ?? f_1477_77996_78023(_invokeAsyncResult)), (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 78050, 78078) || (((invocationCallback != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 78081, 78086)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 78089, 78118))) ? state : f_1477_78089_78118(_invokeAsyncResult), streamToUse, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 76748, 78208);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 74517, 78223);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 78585, 78632);

                    f_1477_78585_78631(f_1477_78585_78601(), _connectCmdInfo);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 78661, 79321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 78761, 78787);

                    _invokeAsyncResult = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 78805, 78885);

                    f_1477_78805_78884(this, f_1477_78821_78883(PSInvocationState.Failed, exception));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 78948, 79045);

                    InvalidRunspacePoolStateException
                    poolException = exception as InvalidRunspacePoolStateException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79063, 79280) || true) && (poolException != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 79067, 79109) && _runspace != null))
                    ) // the pool exception was actually thrown by a runspace

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 79063, 79280);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79207, 79261);

                        throw f_1477_79213_79260(poolException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 79063, 79280);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79300, 79306);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 78661, 79321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79337, 79363);

                return _invokeAsyncResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 73944, 79374);

                System.Management.Automation.PSInvocationStateInfo
                f_1477_74128_74147()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 74128, 74147);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_74128_74153(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 74128, 74153);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_74263_74282()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 74263, 74282);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_74263_74288(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 74263, 74288);
                    return return_v;
                }


                System.Management.Automation.InvalidPowerShellStateException
                f_1477_74227_74289(System.Management.Automation.PSInvocationState
                currentState)
                {
                    var return_v = new System.Management.Automation.InvalidPowerShellStateException(currentState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 74227, 74289);
                    return return_v;
                }


                int
                f_1477_74471_74500(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.CheckRunspacePoolAndConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 74471, 74500);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_74745_74757()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 74745, 74757);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_74884_74900()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 74884, 74900);
                    return return_v;
                }


                bool
                f_1477_74883_74912_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 74883, 74912);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStream
                f_1477_75029_75047()
                {
                    var return_v = new System.Management.Automation.Internal.ObjectStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 75029, 75047);
                    return return_v;
                }


                int
                f_1477_75070_75089(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 75070, 75089);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_75409_75421()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 75409, 75421);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_75494_75526()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 75494, 75526);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_75639_75651()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 75639, 75651);
                    return return_v;
                }


                System.Guid
                f_1477_75745_75755()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 75745, 75755);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
                f_1477_75708_75769(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 75708, 75769);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_75794_75810()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 75794, 75810);
                    return return_v;
                }


                System.Guid
                f_1477_75943_75953()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 75943, 75953);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
                f_1477_75903_75968(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 75903, 75968);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1477_76024_76044()
                {
                    var return_v = InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 76024, 76044);
                    return return_v;
                }


                int
                f_1477_75794_76051(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param, System.Management.Automation.Internal.ObjectStreamBase
                inputstream, System.Management.Automation.Internal.ObjectStreamBase
                outputstream, System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
                errorstream, System.Management.Automation.PSInformationalBuffers
                informationalBuffers, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Initialize(inputstream, outputstream, (System.Management.Automation.Internal.ObjectStreamBase)errorstream, informationalBuffers, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 75794, 76051);
                    return 0;
                }


                int
                f_1477_76091_76191(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 76091, 76191);
                    return 0;
                }


                System.Guid
                f_1477_76257_76267()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 76257, 76267);
                    return return_v;
                }


                System.Management.Automation.PowerShellAsyncResult
                f_1477_76231_76314(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, bool
                isCalledFromBeginInvoke)
                {
                    var return_v = new System.Management.Automation.PowerShellAsyncResult(ownerId, callback, state, output, isCalledFromBeginInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 76231, 76314);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_76604_76620()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 76604, 76620);
                    return return_v;
                }


                bool
                f_1477_76604_76632(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.Initialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 76604, 76632);
                    return return_v;
                }


                int
                f_1477_76562_76727(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 76562, 76727);
                    return 0;
                }


                bool
                f_1477_76842_76872(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 76842, 76872);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_77272_77297(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 77272, 77297);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_77340_77365(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 77340, 77365);
                    return return_v;
                }


                bool
                f_1477_77339_77372_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 77339, 77372);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_77437_77469()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 77437, 77469);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_77561_77573()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 77561, 77573);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_77686_77711(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 77686, 77711);
                    return return_v;
                }


                System.Guid
                f_1477_77937_77947()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 77937, 77947);
                    return return_v;
                }


                System.AsyncCallback
                f_1477_77996_78023(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Callback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 77996, 78023);
                    return return_v;
                }


                object
                f_1477_78089_78118(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.AsyncState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 78089, 78118);
                    return return_v;
                }


                System.Management.Automation.PowerShellAsyncResult
                f_1477_77885_78188(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, bool
                isCalledFromBeginInvoke)
                {
                    var return_v = new System.Management.Automation.PowerShellAsyncResult(ownerId, callback, state, output, isCalledFromBeginInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 77885, 78188);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_78585_78601()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 78585, 78601);
                    return return_v;
                }


                int
                f_1477_78585_78631(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param, System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
                connectCmdInfo)
                {
                    this_param.ConnectAsync(connectCmdInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 78585, 78631);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_78821_78883(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 78821, 78883);
                    return return_v;
                }


                int
                f_1477_78805_78884(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.SetStateChanged(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 78805, 78884);
                    return 0;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1477_79213_79260(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                this_param)
                {
                    var return_v = this_param.ToInvalidRunspaceStateException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 79213, 79260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 73944, 79374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 73944, 79374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckRunspacePoolAndConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 79601, 80969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79668, 79729);

                RemoteRunspacePoolInternal
                remoteRunspacePoolInternal = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79743, 80119) || true) && (_rsConnection is RemoteRunspace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 79743, 80119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79812, 79915);

                    remoteRunspacePoolInternal = f_1477_79841_79914(f_1477_79841_79887((_rsConnection as RemoteRunspace)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 79743, 80119);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 79743, 80119);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 79949, 80119) || true) && (_rsConnection is RunspacePool)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 79949, 80119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 80016, 80104);

                        remoteRunspacePoolInternal = f_1477_80045_80103((_rsConnection as RunspacePool));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 79949, 80119);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 79743, 80119);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 80135, 80291) || true) && (remoteRunspacePoolInternal == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 80135, 80291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 80207, 80276);

                    throw f_1477_80213_80275(f_1477_80243_80274());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 80135, 80291);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 80351, 80529) || true) && (f_1477_80355_80409(f_1477_80355_80403(remoteRunspacePoolInternal)) == RunspacePoolState.Disconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 80351, 80529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 80477, 80514);

                    f_1477_80477_80513(remoteRunspacePoolInternal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 80351, 80529);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 80614, 80958) || true) && (f_1477_80618_80672(f_1477_80618_80666(remoteRunspacePoolInternal)) != RunspacePoolState.Opened)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 80614, 80958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 80734, 80943);

                    throw f_1477_80740_80942(f_1477_80778_80822(), f_1477_80861_80915(f_1477_80861_80909(remoteRunspacePoolInternal)), RunspacePoolState.Opened);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 80614, 80958);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 79601, 80969);

                System.Management.Automation.Runspaces.RunspacePool
                f_1477_79841_79887(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 79841, 79887);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_79841_79914(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 79841, 79914);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_80045_80103(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80045, 80103);
                    return return_v;
                }


                string
                f_1477_80243_80274()
                {
                    var return_v = PowerShellStrings.CannotConnect;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80243, 80274);
                    return return_v;
                }


                System.InvalidOperationException
                f_1477_80213_80275(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 80213, 80275);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1477_80355_80403(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80355, 80403);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1477_80355_80409(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80355, 80409);
                    return return_v;
                }


                int
                f_1477_80477_80513(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    this_param.Connect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 80477, 80513);
                    return 0;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1477_80618_80666(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80618, 80666);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1477_80618_80672(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80618, 80672);
                    return return_v;
                }


                string
                f_1477_80778_80822()
                {
                    var return_v = RunspacePoolStrings.InvalidRunspacePoolState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80778, 80822);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1477_80861_80909(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80861, 80909);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1477_80861_80915(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 80861, 80915);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                f_1477_80740_80942(string
                message, System.Management.Automation.Runspaces.RunspacePoolState
                currentState, System.Management.Automation.Runspaces.RunspacePoolState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 80740, 80942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 79601, 80969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 79601, 80969);
            }
        }

        internal void InvokeWithDebugger(
                    IEnumerable<object> input,
                    IList<PSObject> output,
                    PSInvocationSettings settings,
                    bool invokeMustRun)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 81818, 84331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82030, 82069);

                Debugger
                debugger = f_1477_82050_82068(_runspace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82083, 82108);

                bool
                addToHistory = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82124, 83389) || true) && (debugger != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 82128, 82192) && f_1477_82165_82188(f_1477_82165_82182(f_1477_82165_82173())) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 82124, 83389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82226, 82266);

                    Command
                    cmd = f_1477_82240_82265(f_1477_82240_82262(f_1477_82240_82253(this)), 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82286, 82400);

                    DebuggerCommand
                    dbgCommandResult = f_1477_82321_82399(debugger, f_1477_82375_82390(cmd), output)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82420, 83374) || true) && (f_1477_82424_82453(dbgCommandResult) != null || (DynAbs.Tracing.TraceSender.Expression_False(1477, 82424, 82521) || f_1477_82486_82521(dbgCommandResult)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 82420, 83374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82563, 82606);

                        f_1477_82563_82605(output, f_1477_82574_82604(dbgCommandResult));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82628, 82654);

                        f_1477_82628_82653(f_1477_82628_82645(f_1477_82628_82636()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82676, 82697);

                        addToHistory = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 82420, 83374);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 82420, 83374);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82739, 83374) || true) && (!f_1477_82744_82828(f_1477_82744_82768(dbgCommandResult), f_1477_82776_82791(cmd), StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 82739, 83374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 82965, 83045);

                            f_1477_82965_82982(f_1477_82965_82973())[0] = f_1477_82988_83044(f_1477_83000_83024(dbgCommandResult), false, true, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83159, 83253);

                            DebuggerCommand
                            dbgCommand = f_1477_83188_83252(f_1477_83208_83232(dbgCommandResult), null, false, true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83275, 83312);

                            f_1477_83275_83311(output, f_1477_83286_83310(dbgCommand));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83334, 83355);

                            addToHistory = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 82739, 83374);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 82420, 83374);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 82124, 83389);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83405, 83614) || true) && (addToHistory && (DynAbs.Tracing.TraceSender.Expression_True(1477, 83409, 83454) && (f_1477_83426_83449(f_1477_83426_83443(f_1477_83426_83434())) > 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 83405, 83614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83488, 83599);

                    addToHistory = f_1477_83503_83598(f_1477_83565_83597(f_1477_83565_83585(f_1477_83565_83582(f_1477_83565_83573()), 0)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 83405, 83614);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83744, 83901) || true) && (f_1477_83748_83771(f_1477_83748_83765(f_1477_83748_83756())) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1477, 83748, 83810) && invokeMustRun))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 83744, 83901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83844, 83886);

                    f_1477_83844_83885(f_1477_83844_83861(f_1477_83844_83852()), string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 83744, 83901);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83917, 84320) || true) && (f_1477_83921_83944(f_1477_83921_83938(f_1477_83921_83929())) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 83917, 84320);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 83982, 84243) || true) && (addToHistory)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 83982, 84243);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 84040, 84171) || true) && (settings == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 84040, 84171);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 84110, 84148);

                            settings = f_1477_84121_84147();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 84040, 84171);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 84195, 84224);

                        settings.AddToHistory = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 83982, 84243);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 84263, 84305);

                    f_1477_84263_84304(this, input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 83917, 84320);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 81818, 84331);

                System.Management.Automation.Debugger
                f_1477_82050_82068(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82050, 82068);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_82165_82173()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82165, 82173);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_82165_82182(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82165, 82182);
                    return return_v;
                }


                int
                f_1477_82165_82188(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82165, 82188);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_82240_82253(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82240, 82253);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_82240_82262(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82240, 82262);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_82240_82265(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82240, 82265);
                    return return_v;
                }


                string
                f_1477_82375_82390(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82375, 82390);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommand
                f_1477_82321_82399(System.Management.Automation.Debugger
                this_param, string
                command, System.Collections.Generic.IList<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.InternalProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 82321, 82399);
                    return return_v;
                }


                System.Management.Automation.DebuggerResumeAction?
                f_1477_82424_82453(System.Management.Automation.DebuggerCommand
                this_param)
                {
                    var return_v = this_param.ResumeAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82424, 82453);
                    return return_v;
                }


                bool
                f_1477_82486_82521(System.Management.Automation.DebuggerCommand
                this_param)
                {
                    var return_v = this_param.ExecutedByDebugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82486, 82521);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1477_82574_82604(System.Management.Automation.DebuggerCommand
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 82574, 82604);
                    return return_v;
                }


                int
                f_1477_82563_82605(System.Collections.Generic.IList<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 82563, 82605);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_82628_82636()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82628, 82636);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_82628_82645(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82628, 82645);
                    return return_v;
                }


                int
                f_1477_82628_82653(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 82628, 82653);
                    return 0;
                }


                string
                f_1477_82744_82768(System.Management.Automation.DebuggerCommand
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82744, 82768);
                    return return_v;
                }


                string
                f_1477_82776_82791(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82776, 82791);
                    return return_v;
                }


                bool
                f_1477_82744_82828(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 82744, 82828);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_82965_82973()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82965, 82973);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_82965_82982(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 82965, 82982);
                    return return_v;
                }


                string
                f_1477_83000_83024(System.Management.Automation.DebuggerCommand
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83000, 83024);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_82988_83044(string
                command, bool
                isScript, bool
                useLocalScope, bool
                mergeUnclaimedPreviousErrorResults)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, (bool?)useLocalScope, mergeUnclaimedPreviousErrorResults);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 82988, 83044);
                    return return_v;
                }


                string
                f_1477_83208_83232(System.Management.Automation.DebuggerCommand
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83208, 83232);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommand
                f_1477_83188_83252(string
                command, System.Management.Automation.DebuggerResumeAction?
                action, bool
                repeatOnEnter, bool
                executedByDebugger)
                {
                    var return_v = new System.Management.Automation.DebuggerCommand(command, action, repeatOnEnter, executedByDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 83188, 83252);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1477_83286_83310(System.Management.Automation.DebuggerCommand
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 83286, 83310);
                    return return_v;
                }


                int
                f_1477_83275_83311(System.Collections.Generic.IList<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 83275, 83311);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_83426_83434()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83426, 83434);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_83426_83443(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83426, 83443);
                    return return_v;
                }


                int
                f_1477_83426_83449(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83426, 83449);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_83565_83573()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83565, 83573);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_83565_83582(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83565, 83582);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_83565_83585(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83565, 83585);
                    return return_v;
                }


                string
                f_1477_83565_83597(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83565, 83597);
                    return return_v;
                }


                bool
                f_1477_83503_83598(string
                command)
                {
                    var return_v = DebuggerUtils.ShouldAddCommandToHistory(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 83503, 83598);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_83748_83756()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83748, 83756);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_83748_83765(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83748, 83765);
                    return return_v;
                }


                int
                f_1477_83748_83771(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83748, 83771);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_83844_83852()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83844, 83852);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_83844_83861(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83844, 83861);
                    return return_v;
                }


                int
                f_1477_83844_83885(System.Management.Automation.Runspaces.CommandCollection
                this_param, string
                scriptContents)
                {
                    this_param.AddScript(scriptContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 83844, 83885);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_83921_83929()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83921, 83929);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_83921_83938(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83921, 83938);
                    return return_v;
                }


                int
                f_1477_83921_83944(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 83921, 83944);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1477_84121_84147()
                {
                    var return_v = new System.Management.Automation.PSInvocationSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 84121, 84147);
                    return return_v;
                }


                int
                f_1477_84263_84304(System.Management.Automation.PowerShell
                this_param, System.Collections.Generic.IEnumerable<object>
                input, System.Collections.Generic.IList<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Invoke<System.Management.Automation.PSObject>((System.Collections.IEnumerable)input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 84263, 84304);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 81818, 84331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 81818, 84331);
            }
        }

        public Collection<PSObject> Invoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 86848, 86946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 86909, 86935);

                return f_1477_86916_86934(this, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 86848, 86946);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1477_86916_86934(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    var return_v = this_param.Invoke(input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 86916, 86934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 86848, 86946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 86848, 86946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Invoke(IEnumerable input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 89515, 89631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 89593, 89620);

                return f_1477_89600_89619(this, input, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 89515, 89631);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1477_89600_89619(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    var return_v = this_param.Invoke(input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 89600, 89619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 89515, 89631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 89515, 89631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Invoke(IEnumerable input, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 92292, 92660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 92401, 92458);

                Collection<PSObject>
                result = f_1477_92431_92457()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 92472, 92554);

                PSDataCollection<PSObject>
                listToWriteTo = f_1477_92515_92553(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 92568, 92621);

                f_1477_92568_92620(this, input, listToWriteTo, settings);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 92635, 92649);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 92292, 92660);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1477_92431_92457()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 92431, 92457);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_92515_92553(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                listToUse)
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>((System.Collections.Generic.IList<System.Management.Automation.PSObject>)listToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 92515, 92553);
                    return return_v;
                }


                int
                f_1477_92568_92620(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvoke<System.Management.Automation.PSObject>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 92568, 92620);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 92292, 92660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 92292, 92660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<T> Invoke<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 95150, 95432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 95306, 95349);

                Collection<T>
                result = f_1477_95329_95348()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 95363, 95393);

                f_1477_95363_95392(this, null, result, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 95407, 95421);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 95150, 95432);

                System.Collections.ObjectModel.Collection<T>
                f_1477_95329_95348()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 95329, 95348);
                    return return_v;
                }


                int
                f_1477_95363_95392(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Collections.ObjectModel.Collection<T>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Invoke<T>(input, (System.Collections.Generic.IList<T>)output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 95363, 95392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 95150, 95432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 95150, 95432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<T> Invoke<T>(IEnumerable input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 98012, 98213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 98086, 98129);

                Collection<T>
                result = f_1477_98109_98128()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 98143, 98174);

                f_1477_98143_98173(this, input, result, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 98188, 98202);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 98012, 98213);

                System.Collections.ObjectModel.Collection<T>
                f_1477_98109_98128()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 98109, 98128);
                    return return_v;
                }


                int
                f_1477_98143_98173(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Collections.ObjectModel.Collection<T>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Invoke<T>(input, (System.Collections.Generic.IList<T>)output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 98143, 98173);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 98012, 98213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 98012, 98213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<T> Invoke<T>(IEnumerable input, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 100885, 101121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 100990, 101033);

                Collection<T>
                result = f_1477_101013_101032()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 101047, 101082);

                f_1477_101047_101081(this, input, result, settings);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 101096, 101110);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 100885, 101121);

                System.Collections.ObjectModel.Collection<T>
                f_1477_101013_101032()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 101013, 101032);
                    return return_v;
                }


                int
                f_1477_101047_101081(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Collections.ObjectModel.Collection<T>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Invoke<T>(input, (System.Collections.Generic.IList<T>)output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 101047, 101081);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 100885, 101121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 100885, 101121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Invoke<T>(IEnumerable input, IList<T> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 104010, 104134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 104092, 104123);

                f_1477_104092_104122(this, input, output, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 104010, 104134);

                int
                f_1477_104092_104122(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Collections.Generic.IList<T>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Invoke<T>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 104092, 104122);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 104010, 104134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 104010, 104134);
            }
        }

        public void Invoke<T>(IEnumerable input, IList<T> output, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 106850, 107298);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 106963, 107085) || true) && (output == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 106963, 107085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 107015, 107070);

                    throw f_1477_107021_107069("output");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 106963, 107085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 107159, 107227);

                PSDataCollection<T>
                listToWriteTo = f_1477_107195_107226(output)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 107241, 107287);

                f_1477_107241_107286(this, input, listToWriteTo, settings);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 106850, 107298);

                System.Management.Automation.PSArgumentNullException
                f_1477_107021_107069(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 107021, 107069);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<T>
                f_1477_107195_107226(System.Collections.Generic.IList<T>
                listToUse)
                {
                    var return_v = new System.Management.Automation.PSDataCollection<T>(listToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 107195, 107226);
                    return return_v;
                }


                int
                f_1477_107241_107286(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Management.Automation.PSDataCollection<T>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvoke<T>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 107241, 107286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 106850, 107298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 106850, 107298);
            }
        }

        public void Invoke<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 110121, 110480);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 110278, 110400) || true) && (output == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 110278, 110400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 110330, 110385);

                    throw f_1477_110336_110384("output");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 110278, 110400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 110416, 110469);

                f_1477_110416_110468(this, input, output, settings);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 110121, 110480);

                System.Management.Automation.PSArgumentNullException
                f_1477_110336_110384(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 110336, 110384);
                    return return_v;
                }


                int
                f_1477_110416_110468(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvoke<TInput, TOutput>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 110416, 110468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 110121, 110480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 110121, 110480);
            }
        }

        public IAsyncResult BeginInvoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 111059, 111179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 111117, 111168);

                return f_1477_111124_111167(this, null, null, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 111059, 111179);

                System.IAsyncResult
                f_1477_111124_111167(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<object>
                input, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginInvoke<object>(input, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 111124, 111167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 111059, 111179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 111059, 111179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IAsyncResult BeginInvoke<T>(PSDataCollection<T> input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 112723, 112867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 112809, 112856);

                return f_1477_112816_112855(this, input, null, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 112723, 112867);

                System.IAsyncResult
                f_1477_112816_112855(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<T>
                input, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginInvoke<T>(input, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 112816, 112855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 112723, 112867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 112723, 112867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IAsyncResult BeginInvoke<T>(PSDataCollection<T> input, PSInvocationSettings settings, AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 115054, 116114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115209, 115231);

                f_1477_115209_115230(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115247, 116103) || true) && (f_1477_115251_115263() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 115247, 116103);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115305, 115494) || true) && (_isBatching || (DynAbs.Tracing.TraceSender.Expression_False(1477, 115309, 115348) || f_1477_115324_115343(f_1477_115324_115337()) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 115305, 115494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115390, 115475);

                        return f_1477_115397_115474(this, input, f_1477_115434_115446(), settings, callback, state);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 115305, 115494);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115514, 115604);

                    return f_1477_115521_115603(this, input, f_1477_115557_115569(), settings, callback, state, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 115247, 116103);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 115247, 116103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115670, 115718);

                    OutputBuffer = f_1477_115685_115717();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115736, 115761);

                    OutputBufferOwner = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115781, 115970) || true) && (_isBatching || (DynAbs.Tracing.TraceSender.Expression_False(1477, 115785, 115824) || f_1477_115800_115819(f_1477_115800_115813()) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 115781, 115970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115866, 115951);

                        return f_1477_115873_115950(this, input, f_1477_115910_115922(), settings, callback, state);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 115781, 115970);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 115990, 116088);

                    return f_1477_115997_116087(this, input, f_1477_116033_116045(), settings, callback, state, f_1477_116074_116086());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 115247, 116103);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 115054, 116114);

                int
                f_1477_115209_115230(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.DetermineIsBatching();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 115209, 115230);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_115251_115263()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115251, 115263);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_115324_115337()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115324, 115337);
                    return return_v;
                }


                int
                f_1477_115324_115343(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115324, 115343);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_115434_115446()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115434, 115446);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_115397_115474(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<T>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginBatchInvoke<T, System.Management.Automation.PSObject>(input, output, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 115397, 115474);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_115557_115569()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115557, 115569);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_115521_115603(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<T>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                asyncResultOutput)
                {
                    var return_v = this_param.CoreInvokeAsync<T, System.Management.Automation.PSObject>(input, output, settings, callback, state, asyncResultOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 115521, 115603);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_115685_115717()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 115685, 115717);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_115800_115813()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115800, 115813);
                    return return_v;
                }


                int
                f_1477_115800_115819(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115800, 115819);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_115910_115922()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 115910, 115922);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_115873_115950(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<T>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginBatchInvoke<T, System.Management.Automation.PSObject>(input, output, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 115873, 115950);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_116033_116045()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 116033, 116045);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_116074_116086()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 116074, 116086);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_115997_116087(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<T>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                asyncResultOutput)
                {
                    var return_v = this_param.CoreInvokeAsync<T, System.Management.Automation.PSObject>(input, output, settings, callback, state, asyncResultOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 115997, 116087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 115054, 116114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 115054, 116114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IAsyncResult BeginInvoke<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 117966, 118185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 118105, 118174);

                return f_1477_118112_118173(this, input, output, null, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 117966, 118185);

                System.IAsyncResult
                f_1477_118112_118173(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginInvoke<TInput, TOutput>(input, output, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 118112, 118173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 117966, 118185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 117966, 118185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IAsyncResult BeginInvoke<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings, AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 120759, 121433);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 120967, 121089) || true) && (output == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 120967, 121089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 121019, 121074);

                    throw f_1477_121025_121073("output");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 120967, 121089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 121105, 121127);

                f_1477_121105_121126(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 121143, 121318) || true) && (_isBatching || (DynAbs.Tracing.TraceSender.Expression_False(1477, 121147, 121186) || f_1477_121162_121181(f_1477_121162_121175()) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 121143, 121318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 121220, 121303);

                    return f_1477_121227_121302(this, input, output, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 121143, 121318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 121334, 121422);

                return f_1477_121341_121421(this, input, output, settings, callback, state, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 120759, 121433);

                System.Management.Automation.PSArgumentNullException
                f_1477_121025_121073(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 121025, 121073);
                    return return_v;
                }


                int
                f_1477_121105_121126(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.DetermineIsBatching();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 121105, 121126);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_121162_121175()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 121162, 121175);
                    return return_v;
                }


                int
                f_1477_121162_121181(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 121162, 121181);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_121227_121302(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginBatchInvoke<TInput, TOutput>(input, output, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 121227, 121302);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_121341_121421(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                asyncResultOutput)
                {
                    var return_v = this_param.CoreInvokeAsync<TInput, TOutput>(input, output, settings, callback, state, asyncResultOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 121341, 121421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 120759, 121433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 120759, 121433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task<PSDataCollection<PSObject>> InvokeAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 122239, 122325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 122242, 122325);
                return f_1477_122242_122325(f_1477_122242_122282(), f_1477_122293_122306(this), _endInvokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 122239, 122325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 122239, 122325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 122239, 122325);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_122242_122282()
            {
                var return_v = Task<PSDataCollection<PSObject>>.Factory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 122242, 122282);
                return return_v;
            }


            System.IAsyncResult
            f_1477_122293_122306(System.Management.Automation.PowerShell
            this_param)
            {
                var return_v = this_param.BeginInvoke();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 122293, 122306);
                return return_v;
            }


            System.Threading.Tasks.Task<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_122242_122325(System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            this_param, System.IAsyncResult
            asyncResult, System.Func<System.IAsyncResult, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            endMethod)
            {
                var return_v = this_param.FromAsync(asyncResult, endMethod);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 122242, 122325);
                return return_v;
            }

        }

        public Task<PSDataCollection<PSObject>> InvokeAsync<T>(PSDataCollection<T> input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 124181, 124275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 124184, 124275);
                return f_1477_124184_124275(f_1477_124184_124224(), f_1477_124235_124256(this, input), _endInvokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 124181, 124275);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 124181, 124275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 124181, 124275);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_124184_124224()
            {
                var return_v = Task<PSDataCollection<PSObject>>.Factory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 124184, 124224);
                return return_v;
            }


            System.IAsyncResult
            f_1477_124235_124256(System.Management.Automation.PowerShell
            this_param, System.Management.Automation.PSDataCollection<T>
            input)
            {
                var return_v = this_param.BeginInvoke<T>(input);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 124235, 124256);
                return return_v;
            }


            System.Threading.Tasks.Task<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_124184_124275(System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            this_param, System.IAsyncResult
            asyncResult, System.Func<System.IAsyncResult, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            endMethod)
            {
                var return_v = this_param.FromAsync(asyncResult, endMethod);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 124184, 124275);
                return return_v;
            }

        }

        public Task<PSDataCollection<PSObject>> InvokeAsync<T>(PSDataCollection<T> input, PSInvocationSettings settings, AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 126840, 126961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 126843, 126961);
                return f_1477_126843_126961(f_1477_126843_126883(), f_1477_126894_126942(this, input, settings, callback, state), _endInvokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 126840, 126961);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 126840, 126961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 126840, 126961);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_126843_126883()
            {
                var return_v = Task<PSDataCollection<PSObject>>.Factory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 126843, 126883);
                return return_v;
            }


            System.IAsyncResult
            f_1477_126894_126942(System.Management.Automation.PowerShell
            this_param, System.Management.Automation.PSDataCollection<T>
            input, System.Management.Automation.PSInvocationSettings
            settings, System.AsyncCallback
            callback, object
            state)
            {
                var return_v = this_param.BeginInvoke<T>(input, settings, callback, state);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 126894, 126942);
                return return_v;
            }


            System.Threading.Tasks.Task<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_126843_126961(System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            this_param, System.IAsyncResult
            asyncResult, System.Func<System.IAsyncResult, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            endMethod)
            {
                var return_v = this_param.FromAsync(asyncResult, endMethod);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 126843, 126961);
                return return_v;
            }

        }

        public Task<PSDataCollection<PSObject>> InvokeAsync<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 129232, 129348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 129235, 129348);
                return f_1477_129235_129348(f_1477_129235_129275(), f_1477_129286_129329(this, input, output), _endInvokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 129232, 129348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 129232, 129348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 129232, 129348);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_129235_129275()
            {
                var return_v = Task<PSDataCollection<PSObject>>.Factory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 129235, 129275);
                return return_v;
            }


            System.IAsyncResult
            f_1477_129286_129329(System.Management.Automation.PowerShell
            this_param, System.Management.Automation.PSDataCollection<TInput>
            input, System.Management.Automation.PSDataCollection<TOutput>
            output)
            {
                var return_v = this_param.BeginInvoke<TInput, TOutput>(input, output);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 129286, 129329);
                return return_v;
            }


            System.Threading.Tasks.Task<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_129235_129348(System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            this_param, System.IAsyncResult
            asyncResult, System.Func<System.IAsyncResult, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            endMethod)
            {
                var return_v = this_param.FromAsync(asyncResult, endMethod);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 129235, 129348);
                return return_v;
            }

        }

        public Task<PSDataCollection<PSObject>> InvokeAsync<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings, AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 132407, 132550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 132410, 132550);
                return f_1477_132410_132550(f_1477_132410_132450(), f_1477_132461_132531(this, input, output, settings, callback, state), _endInvokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 132407, 132550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 132407, 132550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 132407, 132550);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_132410_132450()
            {
                var return_v = Task<PSDataCollection<PSObject>>.Factory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 132410, 132450);
                return return_v;
            }


            System.IAsyncResult
            f_1477_132461_132531(System.Management.Automation.PowerShell
            this_param, System.Management.Automation.PSDataCollection<TInput>
            input, System.Management.Automation.PSDataCollection<TOutput>
            output, System.Management.Automation.PSInvocationSettings
            settings, System.AsyncCallback
            callback, object
            state)
            {
                var return_v = this_param.BeginInvoke<TInput, TOutput>(input, output, settings, callback, state);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 132461, 132531);
                return return_v;
            }


            System.Threading.Tasks.Task<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            f_1477_132410_132550(System.Threading.Tasks.TaskFactory<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            this_param, System.IAsyncResult
            asyncResult, System.Func<System.IAsyncResult, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>
            endMethod)
            {
                var return_v = this_param.FromAsync(asyncResult, endMethod);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 132410, 132550);
                return return_v;
            }

        }

        private IAsyncResult BeginBatchInvoke<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings, AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 133933, 135795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134147, 134233);

                PSDataCollection<PSObject>
                asyncOutput = (object)output as PSDataCollection<PSObject>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134249, 134372) || true) && (asyncOutput == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 134249, 134372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134306, 134357);

                    throw f_1477_134312_134356();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 134249, 134372);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134388, 134479) || true) && (_isBatching)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 134388, 134479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134437, 134464);

                    f_1477_134437_134463(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 134388, 134479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134495, 134545);

                RunspacePool
                pool = _rsConnection as RunspacePool
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134559, 135266) || true) && ((pool != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 134563, 134596) && (f_1477_134582_134595(pool))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 134559, 135266);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134759, 135251) || true) && (f_1477_134763_134794(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 134759, 135251);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 134888, 134983);

                            return f_1477_134895_134982(this, input, output, settings, callback, state, asyncOutput);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 135028, 135232);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 135084, 135209) || true) && (_isBatching)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 135084, 135209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 135157, 135182);

                                f_1477_135157_135181(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 135084, 135209);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 135028, 135232);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 134759, 135251);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 134559, 135266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 135417, 135445);

                RunningExtraCommands = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 135459, 135495);

                _batchInvocationSettings = settings;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 135511, 135605);

                _batchAsyncResult = f_1477_135531_135604(f_1477_135557_135567(), callback, state, asyncOutput, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 135621, 135743);

                f_1477_135621_135742(this, input, output, settings, new AsyncCallback(BatchInvocationCallback), state, asyncOutput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 135759, 135784);

                return _batchAsyncResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 133933, 135795);

                System.Management.Automation.PSInvalidOperationException
                f_1477_134312_134356()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 134312, 134356);
                    return return_v;
                }


                int
                f_1477_134437_134463(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.SetupAsyncBatchExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 134437, 134463);
                    return 0;
                }


                bool
                f_1477_134582_134595(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.IsRemote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 134582, 134595);
                    return return_v;
                }


                bool
                f_1477_134763_134794(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.ServerSupportsBatchInvocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 134763, 134794);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_134895_134982(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                asyncResultOutput)
                {
                    var return_v = this_param.CoreInvokeAsync<TInput, TOutput>(input, output, settings, callback, state, asyncResultOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 134895, 134982);
                    return return_v;
                }


                int
                f_1477_135157_135181(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.EndAsyncBatchExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 135157, 135181);
                    return 0;
                }


                System.Guid
                f_1477_135557_135567()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 135557, 135567);
                    return return_v;
                }


                System.Management.Automation.PowerShellAsyncResult
                f_1477_135531_135604(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, bool
                isCalledFromBeginInvoke)
                {
                    var return_v = new System.Management.Automation.PowerShellAsyncResult(ownerId, callback, state, output, isCalledFromBeginInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 135531, 135604);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_135621_135742(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                asyncResultOutput)
                {
                    var return_v = this_param.CoreInvokeAsync<TInput, TOutput>(input, output, settings, callback, state, asyncResultOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 135621, 135742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 133933, 135795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 133933, 135795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void BatchInvocationWorkItem(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 135936, 139433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136011, 136096);

                f_1477_136011_136095(f_1477_136024_136043(f_1477_136024_136037()) != 0, "This callback is for batch invocation only");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136112, 136177);

                BatchInvocationContext
                context = state as BatchInvocationContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136193, 136255);

                f_1477_136193_136254(context != null, "Context should never be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136271, 136308);

                PSCommand
                backupCommand = _psCommand
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136358, 136387);

                    _psCommand = f_1477_136371_136386(context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136440, 136586) || true) && (_psCommand == f_1477_136458_136496(f_1477_136458_136471(), f_1477_136472_136491(f_1477_136472_136485()) - 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 136440, 136586);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136538, 136567);

                        RunningExtraCommands = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 136440, 136586);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136650, 136834);

                        IAsyncResult
                        cmdResult = f_1477_136675_136833(this, null, f_1477_136715_136729(context), _batchInvocationSettings, null, f_1477_136788_136816(_batchAsyncResult), f_1477_136818_136832(context))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 136858, 136879);

                        f_1477_136858_136878(this, cmdResult);
                    }
                    catch (ActionPreferenceStopException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 136916, 137211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137078, 137105);

                        _stopBatchExecution = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137127, 137163);

                        f_1477_137127_137162(_batchAsyncResult, e);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137185, 137192);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 136916, 137211);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 137229, 139100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137289, 137308);

                        f_1477_137289_137307(this, true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137376, 137745) || true) && ((_batchInvocationSettings != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 137380, 137489) && f_1477_137418_137464(_batchInvocationSettings) == ActionPreference.Stop))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 137376, 137745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137539, 137566);

                            _stopBatchExecution = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137592, 137624);

                            f_1477_137592_137623(this, e);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137650, 137689);

                            f_1477_137650_137688(_batchAsyncResult, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137715, 137722);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 137376, 137745);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 137945, 139039) || true) && (_batchInvocationSettings == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 137945, 139039);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 138031, 138143);

                            ActionPreference
                            preference = (ActionPreference)f_1477_138079_138142(f_1477_138079_138105(f_1477_138079_138087()), "ErrorActionPreference")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 138171, 138807);

                            switch (preference)
                            {

                                case ActionPreference.SilentlyContinue:
                                case ActionPreference.Continue:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 138171, 138807);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 138381, 138413);

                                    f_1477_138381_138412(this, e);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1477, 138447, 138453);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 138171, 138807);

                                case ActionPreference.Stop:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 138171, 138807);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 138544, 138580);

                                    f_1477_138544_138579(_batchAsyncResult, e);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 138614, 138621);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 138171, 138807);

                                case ActionPreference.Inquire:
                                case ActionPreference.Ignore:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 138171, 138807);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1477, 138774, 138780);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 138171, 138807);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 137945, 139039);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 137945, 139039);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 138857, 139039) || true) && (f_1477_138861_138907(_batchInvocationSettings) != ActionPreference.Ignore)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 138857, 139039);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 138984, 139016);

                                f_1477_138984_139015(this, e);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 138857, 139039);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 137945, 139039);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 137229, 139100);

                        // Let it continue
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139120, 139276) || true) && (_psCommand == f_1477_139138_139176(f_1477_139138_139151(), f_1477_139152_139171(f_1477_139152_139165()) - 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 139120, 139276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139218, 139257);

                        f_1477_139218_139256(_batchAsyncResult, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 139120, 139276);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 139305, 139422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139345, 139372);

                    _psCommand = backupCommand;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139390, 139407);

                    f_1477_139390_139406(context);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 139305, 139422);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 135936, 139433);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_136024_136037()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136024, 136037);
                    return return_v;
                }


                int
                f_1477_136024_136043(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136024, 136043);
                    return return_v;
                }


                int
                f_1477_136011_136095(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 136011, 136095);
                    return 0;
                }


                int
                f_1477_136193_136254(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 136193, 136254);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_136371_136386(System.Management.Automation.BatchInvocationContext
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136371, 136386);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_136458_136471()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136458, 136471);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_136472_136485()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136472, 136485);
                    return return_v;
                }


                int
                f_1477_136472_136491(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136472, 136491);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_136458_136496(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136458, 136496);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_136715_136729(System.Management.Automation.BatchInvocationContext
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136715, 136729);
                    return return_v;
                }


                object
                f_1477_136788_136816(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.AsyncState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136788, 136816);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_136818_136832(System.Management.Automation.BatchInvocationContext
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 136818, 136832);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_136675_136833(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<object>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                asyncResultOutput)
                {
                    var return_v = this_param.CoreInvokeAsync<object, System.Management.Automation.PSObject>(input, output, settings, callback, state, asyncResultOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 136675, 136833);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_136858_136878(System.Management.Automation.PowerShell
                this_param, System.IAsyncResult
                asyncResult)
                {
                    var return_v = this_param.EndInvoke(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 136858, 136878);
                    return return_v;
                }


                int
                f_1477_137127_137162(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Management.Automation.ActionPreferenceStopException
                exception)
                {
                    this_param.SetAsCompleted((System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 137127, 137162);
                    return 0;
                }


                int
                f_1477_137289_137307(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 137289, 137307);
                    return 0;
                }


                System.Management.Automation.ActionPreference?
                f_1477_137418_137464(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ErrorActionPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 137418, 137464);
                    return return_v;
                }


                int
                f_1477_137592_137623(System.Management.Automation.PowerShell
                this_param, System.Exception
                e)
                {
                    this_param.AppendExceptionToErrorStream(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 137592, 137623);
                    return 0;
                }


                int
                f_1477_137650_137688(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 137650, 137688);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_138079_138087()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 138079, 138087);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateProxy
                f_1477_138079_138105(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.SessionStateProxy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 138079, 138105);
                    return return_v;
                }


                object
                f_1477_138079_138142(System.Management.Automation.Runspaces.SessionStateProxy
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 138079, 138142);
                    return return_v;
                }


                int
                f_1477_138381_138412(System.Management.Automation.PowerShell
                this_param, System.Exception
                e)
                {
                    this_param.AppendExceptionToErrorStream(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 138381, 138412);
                    return 0;
                }


                int
                f_1477_138544_138579(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 138544, 138579);
                    return 0;
                }


                System.Management.Automation.ActionPreference?
                f_1477_138861_138907(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ErrorActionPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 138861, 138907);
                    return return_v;
                }


                int
                f_1477_138984_139015(System.Management.Automation.PowerShell
                this_param, System.Exception
                e)
                {
                    this_param.AppendExceptionToErrorStream(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 138984, 139015);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_139138_139151()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 139138, 139151);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_139152_139165()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 139152, 139165);
                    return return_v;
                }


                int
                f_1477_139152_139171(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 139152, 139171);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_139138_139176(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 139138, 139176);
                    return return_v;
                }


                int
                f_1477_139218_139256(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 139218, 139256);
                    return 0;
                }


                int
                f_1477_139390_139406(System.Management.Automation.BatchInvocationContext
                this_param)
                {
                    this_param.Signal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 139390, 139406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 135936, 139433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 135936, 139433);
            }
        }

        private void BatchInvocationCallback(IAsyncResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 139575, 142148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139657, 139742);

                f_1477_139657_139741(f_1477_139670_139689(f_1477_139670_139683()) != 0, "This callback is for batch invocation only");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139758, 139797);

                PSDataCollection<PSObject>
                objs = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139849, 139902);

                    objs = f_1477_139856_139873(this, result) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>>(1477, 139856, 139901) ?? f_1477_139877_139901(_batchAsyncResult));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 139922, 139953);

                    f_1477_139922_139952(this, objs);
                }
                catch (PipelineStoppedException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 139982, 140195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140119, 140155);

                    f_1477_140119_140154(                // PowerShell throws the pipeline stopped exception.
                                    _batchAsyncResult, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140173, 140180);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 139982, 140195);
                }
                catch (ActionPreferenceStopException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 140209, 140435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140359, 140395);

                    f_1477_140359_140394(                // We need to honor the current error action preference here
                                    _batchAsyncResult, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140413, 140420);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 140209, 140435);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 140449, 141967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140501, 140530);

                    RunningExtraCommands = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140550, 140569);

                    f_1477_140550_140568(this, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140589, 140617);

                    ActionPreference
                    preference
                    = default(ActionPreference);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140635, 141212) || true) && (_batchInvocationSettings != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 140635, 141212);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140713, 140917);

                        preference = (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 140726, 140783) || (((f_1477_140727_140782(f_1477_140727_140773(_batchInvocationSettings))) && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 140811, 140863)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 140891, 140916))) ? f_1477_140811_140863(f_1477_140811_140857(_batchInvocationSettings)) : ActionPreference.Continue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 140635, 141212);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 140635, 141212);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 140999, 141193);

                        preference = (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 141012, 141030) || (((f_1477_141013_141021() != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 141058, 141139)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 141167, 141192))) ? (ActionPreference)f_1477_141076_141139(f_1477_141076_141102(f_1477_141076_141084()), "ErrorActionPreference") : ActionPreference.Continue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 140635, 141212);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 141232, 141772);

                    switch (preference)
                    {

                        case ActionPreference.SilentlyContinue:
                        case ActionPreference.Continue:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 141232, 141772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 141410, 141442);

                            f_1477_141410_141441(this, e);
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 141468, 141474);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 141232, 141772);

                        case ActionPreference.Stop:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 141232, 141772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 141549, 141585);

                            f_1477_141549_141584(_batchAsyncResult, e);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 141611, 141618);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 141232, 141772);

                        case ActionPreference.Inquire:
                        case ActionPreference.Ignore:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 141232, 141772);
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 141747, 141753);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 141232, 141772);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 141792, 141901) || true) && (objs == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 141792, 141901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 141850, 141882);

                        objs = f_1477_141857_141881(_batchAsyncResult);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 141792, 141901);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 141921, 141952);

                    f_1477_141921_141951(this, objs);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 140449, 141967);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 141981, 142137);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142021, 142122) || true) && (_isBatching)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 142021, 142122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142078, 142103);

                        f_1477_142078_142102(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 142021, 142122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 141981, 142137);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 139575, 142148);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_139670_139683()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 139670, 139683);
                    return return_v;
                }


                int
                f_1477_139670_139689(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 139670, 139689);
                    return return_v;
                }


                int
                f_1477_139657_139741(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 139657, 139741);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_139856_139873(System.Management.Automation.PowerShell
                this_param, System.IAsyncResult
                asyncResult)
                {
                    var return_v = this_param.EndInvoke(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 139856, 139873);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_139877_139901(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 139877, 139901);
                    return return_v;
                }


                int
                f_1477_139922_139952(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                objs)
                {
                    this_param.DoRemainingBatchCommands(objs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 139922, 139952);
                    return 0;
                }


                int
                f_1477_140119_140154(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Management.Automation.PipelineStoppedException
                exception)
                {
                    this_param.SetAsCompleted((System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 140119, 140154);
                    return 0;
                }


                int
                f_1477_140359_140394(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Management.Automation.ActionPreferenceStopException
                exception)
                {
                    this_param.SetAsCompleted((System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 140359, 140394);
                    return 0;
                }


                int
                f_1477_140550_140568(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 140550, 140568);
                    return 0;
                }


                System.Management.Automation.ActionPreference?
                f_1477_140727_140773(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ErrorActionPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 140727, 140773);
                    return return_v;
                }


                bool
                f_1477_140727_140782(System.Management.Automation.ActionPreference?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 140727, 140782);
                    return return_v;
                }


                System.Management.Automation.ActionPreference?
                f_1477_140811_140857(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ErrorActionPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 140811, 140857);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1477_140811_140863(System.Management.Automation.ActionPreference?
                this_param)
                {
                    var return_v = this_param.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 140811, 140863);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_141013_141021()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 141013, 141021);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_141076_141084()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 141076, 141084);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateProxy
                f_1477_141076_141102(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.SessionStateProxy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 141076, 141102);
                    return return_v;
                }


                object
                f_1477_141076_141139(System.Management.Automation.Runspaces.SessionStateProxy
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 141076, 141139);
                    return return_v;
                }


                int
                f_1477_141410_141441(System.Management.Automation.PowerShell
                this_param, System.Exception
                e)
                {
                    this_param.AppendExceptionToErrorStream(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 141410, 141441);
                    return 0;
                }


                int
                f_1477_141549_141584(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 141549, 141584);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_141857_141881(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 141857, 141881);
                    return return_v;
                }


                int
                f_1477_141921_141951(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                objs)
                {
                    this_param.DoRemainingBatchCommands(objs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 141921, 141951);
                    return 0;
                }


                int
                f_1477_142078_142102(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.EndAsyncBatchExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 142078, 142102);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 139575, 142148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 139575, 142148);
            }
        }

        private void DoRemainingBatchCommands(PSDataCollection<PSObject> objs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 142255, 143074);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142350, 143063) || true) && (f_1477_142354_142373(f_1477_142354_142367()) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 142350, 143063);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142420, 142425);
                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142411, 143048) || true) && (i < f_1477_142431_142450(f_1477_142431_142444()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142452, 142455)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 142411, 143048))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 142411, 143048);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142497, 142599) || true) && (_stopBatchExecution)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 142497, 142599);
                                DynAbs.Tracing.TraceSender.TraceBreak(1477, 142570, 142576);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 142497, 142599);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142623, 142707);

                            BatchInvocationContext
                            context = f_1477_142656_142706(f_1477_142683_142699(f_1477_142683_142696(), i), objs)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 142911, 142992);

                            f_1477_142911_142991(new WaitCallback(BatchInvocationWorkItem), context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143014, 143029);

                            f_1477_143014_143028(context);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 638);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 638);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 142350, 143063);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 142255, 143074);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_142354_142367()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 142354, 142367);
                    return return_v;
                }


                int
                f_1477_142354_142373(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 142354, 142373);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_142431_142444()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 142431, 142444);
                    return return_v;
                }


                int
                f_1477_142431_142450(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 142431, 142450);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_142683_142696()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 142683, 142696);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_142683_142699(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 142683, 142699);
                    return return_v;
                }


                System.Management.Automation.BatchInvocationContext
                f_1477_142656_142706(System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = new System.Management.Automation.BatchInvocationContext(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 142656, 142706);
                    return return_v;
                }


                bool
                f_1477_142911_142991(System.Threading.WaitCallback
                callBack, System.Management.Automation.BatchInvocationContext
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 142911, 142991);
                    return return_v;
                }


                int
                f_1477_143014_143028(System.Management.Automation.BatchInvocationContext
                this_param)
                {
                    this_param.Wait();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 143014, 143028);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 142255, 143074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 142255, 143074);
            }
        }

        private void DetermineIsBatching()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 143133, 143472);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143192, 143425);
                    foreach (Command command in f_1477_143220_143239_I(f_1477_143220_143239(_psCommand)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 143192, 143425);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143273, 143410) || true) && (f_1477_143277_143301(command))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 143273, 143410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143343, 143362);

                            _isBatching = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143384, 143391);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 143273, 143410);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 143192, 143425);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143441, 143461);

                _isBatching = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 143133, 143472);

                System.Management.Automation.Runspaces.CommandCollection
                f_1477_143220_143239(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 143220, 143239);
                    return return_v;
                }


                bool
                f_1477_143277_143301(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.IsEndOfStatement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 143277, 143301);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_143220_143239_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 143220, 143239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 143133, 143472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 143133, 143472);
            }
        }

        private void SetupAsyncBatchExecution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 143579, 144545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143643, 143669);

                f_1477_143643_143668(_isBatching);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143685, 143723);

                _backupPSCommand = f_1477_143704_143722(_psCommand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143737, 143759);

                f_1477_143737_143758(f_1477_143737_143750());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143775, 143815);

                PSCommand
                currentPipe = f_1477_143799_143814()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143829, 143854);

                currentPipe.Owner = this;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143870, 144357);
                    foreach (Command command in f_1477_143898_143917_I(f_1477_143898_143917(_psCommand)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 143870, 144357);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 143951, 144342) || true) && (f_1477_143955_143979(command))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 143951, 144342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144021, 144055);

                            f_1477_144021_144054(f_1477_144021_144041(currentPipe), command);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144077, 144108);

                            f_1477_144077_144107(f_1477_144077_144090(), currentPipe);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144130, 144160);

                            currentPipe = f_1477_144144_144159();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144182, 144207);

                            currentPipe.Owner = this;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 143951, 144342);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 143951, 144342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144289, 144323);

                            f_1477_144289_144322(f_1477_144289_144309(currentPipe), command);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 143951, 144342);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 143870, 144357);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 488);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144373, 144488) || true) && (f_1477_144377_144403(f_1477_144377_144397(currentPipe)) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 144373, 144488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144442, 144473);

                    f_1477_144442_144472(f_1477_144442_144455(), currentPipe);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 144373, 144488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144504, 144534);

                _psCommand = f_1477_144517_144533(f_1477_144517_144530(), 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 143579, 144545);

                int
                f_1477_143643_143668(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 143643, 143668);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_143704_143722(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 143704, 143722);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_143737_143750()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 143737, 143750);
                    return return_v;
                }


                int
                f_1477_143737_143758(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 143737, 143758);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_143799_143814()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 143799, 143814);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_143898_143917(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 143898, 143917);
                    return return_v;
                }


                bool
                f_1477_143955_143979(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.IsEndOfStatement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 143955, 143979);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_144021_144041(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144021, 144041);
                    return return_v;
                }


                int
                f_1477_144021_144054(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 144021, 144054);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_144077_144090()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144077, 144090);
                    return return_v;
                }


                int
                f_1477_144077_144107(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, System.Management.Automation.PSCommand
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 144077, 144107);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_144144_144159()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 144144, 144159);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_144289_144309(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144289, 144309);
                    return return_v;
                }


                int
                f_1477_144289_144322(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 144289, 144322);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_143898_143917_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 143898, 143917);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_144377_144397(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144377, 144397);
                    return return_v;
                }


                int
                f_1477_144377_144403(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144377, 144403);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_144442_144455()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144442, 144455);
                    return return_v;
                }


                int
                f_1477_144442_144472(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, System.Management.Automation.PSCommand
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 144442, 144472);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_144517_144530()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144517, 144530);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_144517_144533(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 144517, 144533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 143579, 144545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 143579, 144545);
            }
        }

        private void EndAsyncBatchExecution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 144648, 144793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144710, 144736);

                f_1477_144710_144735(_isBatching);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 144752, 144782);

                _psCommand = _backupPSCommand;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 144648, 144793);

                int
                f_1477_144710_144735(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 144710, 144735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 144648, 144793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 144648, 144793);
            }
        }

        private void AppendExceptionToErrorStream(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 144945, 145419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 145024, 145076);

                IContainsErrorRecord
                er = e as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 145092, 145408) || true) && (er != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 145096, 145132) && f_1477_145110_145124(er) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 145092, 145408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 145166, 145205);

                    f_1477_145166_145204(f_1477_145166_145184(f_1477_145166_145178(this)), f_1477_145189_145203(er));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 145092, 145408);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 145092, 145408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 145271, 145393);

                    f_1477_145271_145392(f_1477_145271_145289(f_1477_145271_145283(this)), f_1477_145294_145391(e, "InvalidOperation", ErrorCategory.InvalidOperation, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 145092, 145408);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 144945, 145419);

                System.Management.Automation.ErrorRecord
                f_1477_145110_145124(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 145110, 145124);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1477_145166_145178(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 145166, 145178);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1477_145166_145184(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 145166, 145184);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1477_145189_145203(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 145189, 145203);
                    return return_v;
                }


                int
                f_1477_145166_145204(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 145166, 145204);
                    return 0;
                }


                System.Management.Automation.PSDataStreams
                f_1477_145271_145283(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 145271, 145283);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1477_145271_145289(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 145271, 145289);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1477_145294_145391(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 145294, 145391);
                    return return_v;
                }


                int
                f_1477_145271_145392(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 145271, 145392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 144945, 145419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 144945, 145419);
            }
        }

        public PSDataCollection<PSObject> EndInvoke(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 146174, 147729);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 146304, 146340);

                    _commandInvokedSynchronously = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 146360, 146504) || true) && (asyncResult == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 146360, 146504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 146425, 146485);

                        throw f_1477_146431_146484("asyncResult");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 146360, 146504);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 146524, 146599);

                    PowerShellAsyncResult
                    psAsyncResult = asyncResult as PowerShellAsyncResult
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 146619, 146996) || true) && ((psAsyncResult == null) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 146623, 146708) || (f_1477_146672_146693(psAsyncResult) != f_1477_146697_146707())) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 146623, 146784) || (f_1477_146734_146775(psAsyncResult) != true)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 146619, 146996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 146826, 146977);

                        throw f_1477_146832_146976("asyncResult", f_1477_146907_146944(), "IAsyncResult", "BeginInvoke");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 146619, 146996);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147016, 147053);

                    EndInvokeAsyncResult = psAsyncResult;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147071, 147097);

                    f_1477_147071_147096(psAsyncResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147115, 147143);

                    EndInvokeAsyncResult = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147265, 147293);

                    f_1477_147265_147292(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147311, 147339);

                    return f_1477_147318_147338(psAsyncResult);
                }
                catch (InvalidRunspacePoolStateException exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 147368, 147718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147452, 147471);

                    f_1477_147452_147470(this, true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147489, 147677) || true) && (_runspace != null)
                    ) // the pool exception was actually thrown by a runspace

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 147489, 147677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147608, 147658);

                        throw f_1477_147614_147657(exception);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 147489, 147677);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 147697, 147703);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 147368, 147718);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 146174, 147729);

                System.Management.Automation.PSArgumentNullException
                f_1477_146431_146484(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 146431, 146484);
                    return return_v;
                }


                System.Guid
                f_1477_146672_146693(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.OwnerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 146672, 146693);
                    return return_v;
                }


                System.Guid
                f_1477_146697_146707()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 146697, 146707);
                    return return_v;
                }


                bool
                f_1477_146734_146775(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.IsAssociatedWithAsyncInvoke;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 146734, 146775);
                    return return_v;
                }


                string
                f_1477_146907_146944()
                {
                    var return_v = PowerShellStrings.AsyncResultNotOwned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 146907, 146944);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1477_146832_146976(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 146832, 146976);
                    return return_v;
                }


                int
                f_1477_147071_147096(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    this_param.EndInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 147071, 147096);
                    return 0;
                }


                int
                f_1477_147265_147292(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.ResetOutputBufferAsNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 147265, 147292);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_147318_147338(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 147318, 147338);
                    return return_v;
                }


                int
                f_1477_147452_147470(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 147452, 147470);
                    return 0;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1477_147614_147657(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                this_param)
                {
                    var return_v = this_param.ToInvalidRunspaceStateException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 147614, 147657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 146174, 147729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 146174, 147729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Stop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 148022, 148630);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 148101, 148155);

                    IAsyncResult
                    asyncResult = f_1477_148128_148154(this, true, null, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 148255, 148293);

                    f_1477_148255_148292(f_1477_148255_148282(asyncResult));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 148417, 148445);

                    f_1477_148417_148444(this);
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 148474, 148619);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 148474, 148619);
                    // If it's already disposed, then the client doesn't need to know.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 148022, 148630);

                System.IAsyncResult
                f_1477_148128_148154(System.Management.Automation.PowerShell
                this_param, bool
                isSyncCall, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.CoreStop(isSyncCall, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 148128, 148154);
                    return return_v;
                }


                System.Threading.WaitHandle
                f_1477_148255_148282(System.IAsyncResult
                this_param)
                {
                    var return_v = this_param.AsyncWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 148255, 148282);
                    return return_v;
                }


                bool
                f_1477_148255_148292(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 148255, 148292);
                    return return_v;
                }


                int
                f_1477_148417_148444(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.ResetOutputBufferAsNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 148417, 148444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 148022, 148630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 148022, 148630);
            }
        }

        public IAsyncResult BeginStop(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 149696, 149839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 149788, 149828);

                return f_1477_149795_149827(this, false, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 149696, 149839);

                System.IAsyncResult
                f_1477_149795_149827(System.Management.Automation.PowerShell
                this_param, bool
                isSyncCall, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.CoreStop(isSyncCall, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 149795, 149827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 149696, 149839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 149696, 149839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EndStop(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 150405, 151263);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 150475, 150607) || true) && (asyncResult == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 150475, 150607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 150532, 150592);

                    throw f_1477_150538_150591("asyncResult");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 150475, 150607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 150623, 150698);

                PowerShellAsyncResult
                psAsyncResult = asyncResult as PowerShellAsyncResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 150714, 151066) || true) && ((psAsyncResult == null) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 150718, 150799) || (f_1477_150763_150784(psAsyncResult) != f_1477_150788_150798())) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 150718, 150872) || (f_1477_150821_150862(psAsyncResult) != false)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 150714, 151066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 150906, 151051);

                    throw f_1477_150912_151050("asyncResult", f_1477_150983_151020(), "IAsyncResult", "BeginStop");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 150714, 151066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 151082, 151108);

                f_1477_151082_151107(
                            psAsyncResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 151224, 151252);

                f_1477_151224_151251(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 150405, 151263);

                System.Management.Automation.PSArgumentNullException
                f_1477_150538_150591(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 150538, 150591);
                    return return_v;
                }


                System.Guid
                f_1477_150763_150784(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.OwnerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 150763, 150784);
                    return return_v;
                }


                System.Guid
                f_1477_150788_150798()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 150788, 150798);
                    return return_v;
                }


                bool
                f_1477_150821_150862(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.IsAssociatedWithAsyncInvoke;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 150821, 150862);
                    return return_v;
                }


                string
                f_1477_150983_151020()
                {
                    var return_v = PowerShellStrings.AsyncResultNotOwned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 150983, 151020);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1477_150912_151050(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 150912, 151050);
                    return return_v;
                }


                int
                f_1477_151082_151107(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    this_param.EndInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 151082, 151107);
                    return 0;
                }


                int
                f_1477_151224_151251(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.ResetOutputBufferAsNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 151224, 151251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 150405, 151263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 150405, 151263);
            }
        }

        public Task StopAsync(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 152609, 152678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 152612, 152678);
                return f_1477_152612_152678(f_1477_152612_152624(), f_1477_152635_152661(this, callback, state), _endStopMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 152609, 152678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 152609, 152678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 152609, 152678);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Threading.Tasks.TaskFactory
            f_1477_152612_152624()
            {
                var return_v = Task.Factory;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 152612, 152624);
                return return_v;
            }


            System.IAsyncResult
            f_1477_152635_152661(System.Management.Automation.PowerShell
            this_param, System.AsyncCallback
            callback, object
            state)
            {
                var return_v = this_param.BeginStop(callback, state);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 152635, 152661);
                return return_v;
            }


            System.Threading.Tasks.Task
            f_1477_152612_152678(System.Threading.Tasks.TaskFactory
            this_param, System.IAsyncResult
            asyncResult, System.Action<System.IAsyncResult>
            endMethod)
            {
                var return_v = this_param.FromAsync(asyncResult, endMethod);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 152612, 152678);
                return return_v;
            }

        }

        private void PipelineStateChanged(object source, PipelineStateEventArgs stateEventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 153069, 153394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 153236, 153336);

                PSInvocationStateInfo
                targetStateInfo = f_1477_153276_153335(f_1477_153302_153334(stateEventArgs))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 153350, 153383);

                f_1477_153350_153382(this, targetStateInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 153069, 153394);

                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1477_153302_153334(System.Management.Automation.Runspaces.PipelineStateEventArgs
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 153302, 153334);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_153276_153335(System.Management.Automation.Runspaces.PipelineStateInfo
                pipelineStateInfo)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(pipelineStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 153276, 153335);
                    return return_v;
                }


                int
                f_1477_153350_153382(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.SetStateChanged(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 153350, 153382);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 153069, 153394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 153069, 153394);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 153681, 154001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 153727, 153741);

                f_1477_153727_153740(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 153957, 153990);

                f_1477_153957_153989(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 153681, 154001);

                int
                f_1477_153727_153740(System.Management.Automation.PowerShell
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 153727, 153740);
                    return 0;
                }


                int
                f_1477_153957_153989(System.Management.Automation.PowerShell
                obj)
                {
                    System.GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 153957, 153989);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 153681, 154001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 153681, 154001);
            }
        }

        public bool IsRunspaceOwner { get; internal set; }

        internal bool ErrorBufferOwner { get; set; }

        internal bool OutputBufferOwner { get; set; }

        internal PSDataCollection<PSObject> OutputBuffer { get; private set; }

        private void ResetOutputBufferAsNeeded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 154771, 154981);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154836, 154970) || true) && (f_1477_154840_154857())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 154836, 154970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154891, 154917);

                    OutputBufferOwner = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 154935, 154955);

                    OutputBuffer = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 154836, 154970);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 154771, 154981);

                bool
                f_1477_154840_154857()
                {
                    var return_v = OutputBufferOwner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 154840, 154857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 154771, 154981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 154771, 154981);
            }
        }

        public SteppablePipeline GetSteppablePipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 155282, 155529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 155354, 155401);

                ExecutionContext
                context = f_1477_155381_155400(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 155415, 155493);

                SteppablePipeline
                spl = f_1477_155439_155492(this, context, CommandOrigin.Internal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 155507, 155518);

                return spl;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 155282, 155529);

                System.Management.Automation.ExecutionContext
                f_1477_155381_155400(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 155381, 155400);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1477_155439_155492(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    var return_v = this_param.GetSteppablePipeline(context, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 155439, 155492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 155282, 155529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 155282, 155529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ExecutionContext GetContextFromTLS()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 155822, 157050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 155892, 155962);

                ExecutionContext
                context = f_1477_155919_155961()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156076, 157008) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 156076, 157008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156129, 156229);

                    string
                    scriptText = (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 156149, 156181) || ((f_1477_156149_156177(f_1477_156149_156171(f_1477_156149_156162(this))) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 156184, 156221)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 156224, 156228))) ? f_1477_156184_156221(f_1477_156184_156209(f_1477_156184_156206(f_1477_156184_156197(this)), 0)) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156247, 156284);

                    PSInvalidOperationException
                    e = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156304, 156901) || true) && (scriptText != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 156304, 156901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156368, 156472);

                        scriptText = f_1477_156381_156471(f_1477_156409_156458(), scriptText);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156494, 156664);

                        e = f_1477_156498_156663(f_1477_156567_156625(), scriptText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 156304, 156901);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 156304, 156901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156746, 156882);

                        e = f_1477_156750_156881(f_1477_156819_156880());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 156304, 156901);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156921, 156967);

                    f_1477_156921_156966(
                                    e, "CommandInvokedFromWrongThread");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 156985, 156993);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 156076, 157008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 157024, 157039);

                return context;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 155822, 157050);

                System.Management.Automation.ExecutionContext
                f_1477_155919_155961()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 155919, 155961);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_156149_156162(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156149, 156162);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_156149_156171(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156149, 156171);
                    return return_v;
                }


                int
                f_1477_156149_156177(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156149, 156177);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_156184_156197(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156184, 156197);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_156184_156206(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156184, 156206);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_156184_156209(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156184, 156209);
                    return return_v;
                }


                string
                f_1477_156184_156221(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156184, 156221);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1477_156409_156458()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156409, 156458);
                    return return_v;
                }


                string
                f_1477_156381_156471(System.Globalization.CultureInfo
                uiCultureInfo, string
                original)
                {
                    var return_v = ErrorCategoryInfo.Ellipsize(uiCultureInfo, original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 156381, 156471);
                    return return_v;
                }


                string
                f_1477_156567_156625()
                {
                    var return_v = PowerShellStrings.CommandInvokedFromWrongThreadWithCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156567, 156625);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_156498_156663(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 156498, 156663);
                    return return_v;
                }


                string
                f_1477_156819_156880()
                {
                    var return_v = PowerShellStrings.CommandInvokedFromWrongThreadWithoutCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 156819, 156880);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_156750_156881(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 156750, 156881);
                    return return_v;
                }


                int
                f_1477_156921_156966(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 156921, 156966);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 155822, 157050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 155822, 157050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SteppablePipeline GetSteppablePipeline(ExecutionContext context, CommandOrigin commandOrigin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 157371, 159023);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 157541, 157634) || true) && (f_1477_157545_157568(f_1477_157545_157562(f_1477_157545_157553())) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 157541, 157634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 157607, 157619);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 157541, 157634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 157650, 157712);

                PipelineProcessor
                pipelineProcessor = f_1477_157688_157711()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 157726, 157746);

                bool
                failed = false
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 157798, 158451);
                        foreach (Command cmd in f_1477_157822_157839_I(f_1477_157822_157839(f_1477_157822_157830())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 157798, 158451);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 157881, 158259);

                            CommandProcessorBase
                            commandProcessorBase =
                            f_1477_157954_158258(cmd, f_1477_158045_158086(f_1477_158045_158069()), false, (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 158161, 158177) || ((f_1477_158161_158169() == true && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 158180, 158202)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 158205, 158227))) ? CommandOrigin.Internal : CommandOrigin.Runspace)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158283, 158364);

                            commandProcessorBase.RedirectShellErrorOutputPipe = f_1477_158335_158363();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158388, 158432);

                            f_1477_158388_158431(
                                                pipelineProcessor, commandProcessorBase);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 157798, 158451);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 654);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 654);
                    }
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 158480, 158590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158537, 158551);

                    failed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158569, 158575);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 158480, 158590);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 158604, 158771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158656, 158670);

                    failed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158688, 158756);

                    throw f_1477_158694_158755(f_1477_158715_158751(), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 158604, 158771);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 158785, 158939);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158825, 158924) || true) && (failed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 158825, 158924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158877, 158905);

                        f_1477_158877_158904(pipelineProcessor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 158825, 158924);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 158785, 158939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 158955, 159012);

                return f_1477_158962_159011(context, pipelineProcessor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 157371, 159023);

                System.Management.Automation.PSCommand
                f_1477_157545_157553()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 157545, 157553);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_157545_157562(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 157545, 157562);
                    return return_v;
                }


                int
                f_1477_157545_157568(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 157545, 157568);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1477_157688_157711()
                {
                    var return_v = new System.Management.Automation.Internal.PipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 157688, 157711);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_157822_157830()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 157822, 157830);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_157822_157839(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 157822, 157839);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_158045_158069()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 158045, 158069);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1477_158045_158086(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 158045, 158086);
                    return return_v;
                }


                bool
                f_1477_158161_158169()
                {
                    var return_v = IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 158161, 158169);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1477_157954_158258(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.ExecutionContext
                executionContext, bool
                addToHistory, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.CreateCommandProcessor(executionContext, addToHistory, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 157954, 158258);
                    return return_v;
                }


                bool
                f_1477_158335_158363()
                {
                    var return_v = RedirectShellErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 158335, 158363);
                    return return_v;
                }


                int
                f_1477_158388_158431(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.CommandProcessorBase
                commandProcessor)
                {
                    var return_v = this_param.Add(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 158388, 158431);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_157822_157839_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 157822, 157839);
                    return return_v;
                }


                string
                f_1477_158715_158751()
                {
                    var return_v = PipelineStrings.CannotCreatePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 158715, 158751);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1477_158694_158755(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 158694, 158755);
                    return return_v;
                }


                int
                f_1477_158877_158904(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 158877, 158904);
                    return 0;
                }


                System.Management.Automation.SteppablePipeline
                f_1477_158962_159011(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Internal.PipelineProcessor
                pipeline)
                {
                    var return_v = new System.Management.Automation.SteppablePipeline(context, pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 158962, 159011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 157371, 159023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 157371, 159023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsGetCommandMetadataSpecialPipeline { get; set; }

        private bool IsCommandRunning()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 159237, 159452);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 159293, 159412) || true) && (f_1477_159297_159322(f_1477_159297_159316()) == PSInvocationState.Running)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 159293, 159412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 159385, 159397);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 159293, 159412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 159428, 159441);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 159237, 159452);

                System.Management.Automation.PSInvocationStateInfo
                f_1477_159297_159316()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 159297, 159316);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_159297_159322(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 159297, 159322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 159237, 159452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 159237, 159452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsDisconnected()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 159602, 159736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 159656, 159725);

                return (f_1477_159664_159689(f_1477_159664_159683()) == PSInvocationState.Disconnected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 159602, 159736);

                System.Management.Automation.PSInvocationStateInfo
                f_1477_159664_159683()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 159664, 159683);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_159664_159689(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 159664, 159689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 159602, 159736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 159602, 159736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AssertExecutionNotStarted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 160272, 161077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160337, 160357);

                f_1477_160337_160356(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160371, 160583) || true) && (f_1477_160375_160393(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 160371, 160583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160427, 160505);

                    string
                    message = f_1477_160444_160504(f_1477_160462_160503())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160523, 160568);

                    throw f_1477_160529_160567(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 160371, 160583);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160599, 160807) || true) && (f_1477_160603_160619(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 160599, 160807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160653, 160729);

                    string
                    message = f_1477_160670_160728(f_1477_160688_160727())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160747, 160792);

                    throw f_1477_160753_160791(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 160599, 160807);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160823, 161066) || true) && (f_1477_160827_160852(f_1477_160827_160846()) == PSInvocationState.Stopping)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 160823, 161066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 160916, 160988);

                    string
                    message = f_1477_160933_160987(f_1477_160951_160986())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 161006, 161051);

                    throw f_1477_161012_161050(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 160823, 161066);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 160272, 161077);

                int
                f_1477_160337_160356(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160337, 160356);
                    return 0;
                }


                bool
                f_1477_160375_160393(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsCommandRunning();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160375, 160393);
                    return return_v;
                }


                string
                f_1477_160462_160503()
                {
                    var return_v = PowerShellStrings.ExecutionAlreadyStarted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 160462, 160503);
                    return return_v;
                }


                string
                f_1477_160444_160504(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160444, 160504);
                    return return_v;
                }


                System.InvalidOperationException
                f_1477_160529_160567(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160529, 160567);
                    return return_v;
                }


                bool
                f_1477_160603_160619(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsDisconnected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160603, 160619);
                    return return_v;
                }


                string
                f_1477_160688_160727()
                {
                    var return_v = PowerShellStrings.ExecutionDisconnected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 160688, 160727);
                    return return_v;
                }


                string
                f_1477_160670_160728(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160670, 160728);
                    return return_v;
                }


                System.InvalidOperationException
                f_1477_160753_160791(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160753, 160791);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_160827_160846()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 160827, 160846);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_160827_160852(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 160827, 160852);
                    return return_v;
                }


                string
                f_1477_160951_160986()
                {
                    var return_v = PowerShellStrings.ExecutionStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 160951, 160986);
                    return return_v;
                }


                string
                f_1477_160933_160987(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 160933, 160987);
                    return return_v;
                }


                System.InvalidOperationException
                f_1477_161012_161050(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 161012, 161050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 160272, 161077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 160272, 161077);
            }
        }

        internal void AssertChangesAreAccepted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 161638, 161990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 161709, 161720);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 161754, 161774);

                    f_1477_161754_161773(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 161792, 161964) || true) && (f_1477_161796_161814(this) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 161796, 161834) || f_1477_161818_161834(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 161792, 161964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 161876, 161945);

                        throw f_1477_161882_161944(f_1477_161918_161943(f_1477_161918_161937()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 161792, 161964);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 161638, 161990);

                int
                f_1477_161754_161773(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 161754, 161773);
                    return 0;
                }


                bool
                f_1477_161796_161814(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsCommandRunning();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 161796, 161814);
                    return return_v;
                }


                bool
                f_1477_161818_161834(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsDisconnected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 161818, 161834);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_161918_161937()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 161918, 161937);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_161918_161943(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 161918, 161943);
                    return return_v;
                }


                System.Management.Automation.InvalidPowerShellStateException
                f_1477_161882_161944(System.Management.Automation.PSInvocationState
                currentState)
                {
                    var return_v = new System.Management.Automation.InvalidPowerShellStateException(currentState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 161882, 161944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 161638, 161990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 161638, 161990);
            }
        }

        private void AssertNotDisposed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 162290, 162483);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 162347, 162472) || true) && (_isDisposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 162347, 162472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 162396, 162457);

                    throw f_1477_162402_162456("PowerShell");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 162347, 162472);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 162290, 162483);

                System.Management.Automation.PSObjectDisposedException
                f_1477_162402_162456(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 162402, 162456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 162290, 162483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 162290, 162483);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 162697, 164114);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 162758, 164103) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 162758, 164103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 162811, 162822);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 162915, 163010) || true) && (_isDisposed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 162915, 163010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 162980, 162987);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 162915, 163010);
                        }
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163124, 163330) || true) && (f_1477_163128_163153(f_1477_163128_163147()) == PSInvocationState.Running || (DynAbs.Tracing.TraceSender.Expression_False(1477, 163128, 163262) || f_1477_163207_163232(f_1477_163207_163226()) == PSInvocationState.Stopping))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 163124, 163330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163304, 163311);

                        f_1477_163304_163310(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 163124, 163330);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163356, 163367);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163409, 163428);

                        _isDisposed = true;
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163467, 163596) || true) && (f_1477_163471_163483() != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 163471, 163512) && f_1477_163495_163512()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 163467, 163596);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163554, 163577);

                        f_1477_163554_163576(f_1477_163554_163566());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 163467, 163596);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163616, 163744) || true) && (_errorBuffer != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 163620, 163660) && f_1477_163644_163660()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 163616, 163744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163702, 163725);

                        f_1477_163702_163724(_errorBuffer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 163616, 163744);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163764, 163864) || true) && (f_1477_163768_163783())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 163764, 163864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163825, 163845);

                        f_1477_163825_163844(_runspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 163764, 163864);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163884, 164000) || true) && (f_1477_163888_163904() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 163884, 164000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 163954, 163981);

                        f_1477_163954_163980(f_1477_163954_163970());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 163884, 164000);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 164020, 164046);

                    _invokeAsyncResult = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 164064, 164088);

                    _stopAsyncResult = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 162758, 164103);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 162697, 164114);

                System.Management.Automation.PSInvocationStateInfo
                f_1477_163128_163147()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163128, 163147);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_163128_163153(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163128, 163153);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_163207_163226()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163207, 163226);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_163207_163232(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163207, 163232);
                    return return_v;
                }


                int
                f_1477_163304_163310(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 163304, 163310);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_163471_163483()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163471, 163483);
                    return return_v;
                }


                bool
                f_1477_163495_163512()
                {
                    var return_v = OutputBufferOwner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163495, 163512);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1477_163554_163566()
                {
                    var return_v = OutputBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163554, 163566);
                    return return_v;
                }


                int
                f_1477_163554_163576(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 163554, 163576);
                    return 0;
                }


                bool
                f_1477_163644_163660()
                {
                    var return_v = ErrorBufferOwner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163644, 163660);
                    return return_v;
                }


                int
                f_1477_163702_163724(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 163702, 163724);
                    return 0;
                }


                bool
                f_1477_163768_163783()
                {
                    var return_v = IsRunspaceOwner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163768, 163783);
                    return return_v;
                }


                int
                f_1477_163825_163844(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 163825, 163844);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_163888_163904()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163888, 163904);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_163954_163970()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 163954, 163970);
                    return return_v;
                }


                int
                f_1477_163954_163980(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 163954, 163980);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 162697, 164114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 162697, 164114);
            }
        }

        private void InternalClearSuppressExceptions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 164215, 164485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 164292, 164303);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 164337, 164459) || true) && (_worker != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 164337, 164459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 164398, 164440);

                        f_1477_164398_164439(_worker);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 164337, 164459);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 164215, 164485);

                int
                f_1477_164398_164439(System.Management.Automation.PowerShell.Worker
                this_param)
                {
                    this_param.InternalClearSuppressExceptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 164398, 164439);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 164215, 164485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 164215, 164485);
            }
        }

        private void RaiseStateChangeEvent(PSInvocationStateInfo stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 164697, 165850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165065, 165125);

                RemoteRunspace
                remoteRunspace = _runspace as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165139, 165314) || true) && (remoteRunspace != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 165143, 165183) && f_1477_165169_165183_M(!this.IsNested)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 165139, 165314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165217, 165299);

                    f_1477_165217_165298(_runspace, f_1477_165254_165279(f_1477_165254_165273()), true, f_1477_165287_165297());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 165139, 165314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165330, 165733) || true) && (f_1477_165334_165349(stateInfo) == PSInvocationState.Running)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 165330, 165733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165412, 165445);

                    f_1477_165412_165444(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 165330, 165733);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 165330, 165733);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165479, 165733) || true) && (f_1477_165483_165498(stateInfo) == PSInvocationState.Completed || (DynAbs.Tracing.TraceSender.Expression_False(1477, 165483, 165577) || f_1477_165533_165548(stateInfo) == PSInvocationState.Stopped) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 165483, 165646) || f_1477_165603_165618(stateInfo) == PSInvocationState.Failed))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 165479, 165733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165680, 165718);

                        f_1477_165680_165717(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 165479, 165733);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 165330, 165733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 165749, 165839);

                f_1477_165749_165838(
                            InvocationStateChanged, this, f_1477_165789_165837(stateInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 164697, 165850);

                bool
                f_1477_165169_165183_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165169, 165183);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_165254_165273()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165254, 165273);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_165254_165279(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165254, 165279);
                    return return_v;
                }


                System.Guid
                f_1477_165287_165297()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165287, 165297);
                    return return_v;
                }


                int
                f_1477_165217_165298(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.PSInvocationState
                invocationState, bool
                raiseEvent, System.Guid
                cmdInstanceId)
                {
                    this_param.UpdateRunspaceAvailability(invocationState, raiseEvent, cmdInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 165217, 165298);
                    return 0;
                }


                System.Management.Automation.PSInvocationState
                f_1477_165334_165349(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165334, 165349);
                    return return_v;
                }


                int
                f_1477_165412_165444(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AddToRemoteRunspaceRunningList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 165412, 165444);
                    return 0;
                }


                System.Management.Automation.PSInvocationState
                f_1477_165483_165498(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165483, 165498);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_165533_165548(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165533, 165548);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_165603_165618(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 165603, 165618);
                    return return_v;
                }


                int
                f_1477_165680_165717(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.RemoveFromRemoteRunspaceRunningList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 165680, 165717);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateChangedEventArgs
                f_1477_165789_165837(System.Management.Automation.PSInvocationStateInfo
                psStateInfo)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateChangedEventArgs(psStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 165789, 165837);
                    return return_v;
                }


                int
                f_1477_165749_165838(System.EventHandler<System.Management.Automation.PSInvocationStateChangedEventArgs>
                eventHandler, System.Management.Automation.PowerShell
                sender, System.Management.Automation.PSInvocationStateChangedEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.PSInvocationStateChangedEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 165749, 165838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 164697, 165850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 164697, 165850);
            }
        }

        internal void SetStateChanged(PSInvocationStateInfo stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 166034, 174543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166121, 166169);

                PSInvocationStateInfo
                copyStateInfo = stateInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166183, 166215);

                PSInvocationState
                previousState
                = default(PSInvocationState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166307, 166476) || true) && (_worker != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 166311, 166370) && f_1477_166330_166362(_worker) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 166307, 166476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166404, 166461);

                    f_1477_166404_166460(this, f_1477_166417_166459(f_1477_166417_166449(_worker)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 166307, 166476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166692, 166736);

                PowerShellAsyncResult
                tempInvokeAsyncResult
                = default(PowerShellAsyncResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166750, 166792);

                PowerShellAsyncResult
                tempStopAsyncResult
                = default(PowerShellAsyncResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166814, 166825);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 166859, 166901);

                    previousState = f_1477_166875_166900(f_1477_166875_166894());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 167016, 168584);

                    switch (f_1477_167024_167049(f_1477_167024_167043()))
                    {

                        case PSInvocationState.Completed:
                        case PSInvocationState.Failed:
                        case PSInvocationState.Stopped:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 167016, 168584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 167452, 167459);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 167016, 168584);

                        case PSInvocationState.Running:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 167016, 168584);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 167538, 167678) || true) && (f_1477_167542_167557(stateInfo) == PSInvocationState.Running)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 167538, 167678);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 167644, 167651);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 167538, 167678);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 167706, 167712);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 167016, 168584);

                        case PSInvocationState.Stopping:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 167016, 168584);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 167917, 168469) || true) && (f_1477_167921_167936(stateInfo) == PSInvocationState.Running || (DynAbs.Tracing.TraceSender.Expression_False(1477, 167921, 168043) || f_1477_167998_168013(stateInfo) == PSInvocationState.Stopping))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 167917, 168469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168101, 168108);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 167917, 168469);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 167917, 168469);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168166, 168469) || true) && (f_1477_168170_168185(stateInfo) == PSInvocationState.Completed || (DynAbs.Tracing.TraceSender.Expression_False(1477, 168170, 168297) || f_1477_168254_168269(stateInfo) == PSInvocationState.Failed))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 168166, 168469);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168355, 168442);

                                    copyStateInfo = f_1477_168371_168441(PSInvocationState.Stopped, f_1477_168424_168440(stateInfo));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 168166, 168469);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 167917, 168469);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 168497, 168503);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 167016, 168584);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 167016, 168584);
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 168559, 168565);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 167016, 168584);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168604, 168647);

                    tempInvokeAsyncResult = _invokeAsyncResult;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168665, 168704);

                    tempStopAsyncResult = _stopAsyncResult;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168722, 168758);

                    InvocationStateInfo = copyStateInfo;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168789, 168821);

                bool
                isExceptionOccured = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168835, 174532);

                switch (f_1477_168843_168868(f_1477_168843_168862()))
                {

                    case PSInvocationState.Running:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 168835, 174532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 168955, 169001);

                        f_1477_168955_169000(this, previousState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169023, 169074);

                        f_1477_169023_169073(this, f_1477_169045_169072(f_1477_169045_169064()));
                        DynAbs.Tracing.TraceSender.TraceBreak(1477, 169096, 169102);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 168835, 174532);

                    case PSInvocationState.Stopping:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 168835, 174532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169174, 169225);

                        f_1477_169174_169224(this, f_1477_169196_169223(f_1477_169196_169215()));
                        DynAbs.Tracing.TraceSender.TraceBreak(1477, 169247, 169253);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 168835, 174532);

                    case PSInvocationState.Completed:
                    case PSInvocationState.Failed:
                    case PSInvocationState.Stopped:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 168835, 174532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169467, 169501);

                        f_1477_169467_169500(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169593, 169715) || true) && (f_1477_169597_169613() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 169593, 169715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169671, 169692);

                            f_1477_169671_169691(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 169593, 169715);
                        }

                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169791, 170570) || true) && (f_1477_169795_169815())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 169791, 170570);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169873, 170068) || true) && (tempInvokeAsyncResult != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 169873, 170068);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 169972, 170037);

                                    f_1477_169972_170036(tempInvokeAsyncResult, f_1477_170009_170035(f_1477_170009_170028()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 169873, 170068);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 170100, 170151);

                                f_1477_170100_170150(this, f_1477_170122_170149(f_1477_170122_170141()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 169791, 170570);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 169791, 170570);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 170265, 170316);

                                f_1477_170265_170315(this, f_1477_170287_170314(f_1477_170287_170306()));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 170348, 170543) || true) && (tempInvokeAsyncResult != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 170348, 170543);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 170447, 170512);

                                    f_1477_170447_170511(tempInvokeAsyncResult, f_1477_170484_170510(f_1477_170484_170503()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 170348, 170543);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 169791, 170570);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 170598, 170755) || true) && (tempStopAsyncResult != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 170598, 170755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 170687, 170728);

                                f_1477_170687_170727(tempStopAsyncResult, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 170598, 170755);
                            }
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 170800, 171126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 171000, 171026);

                            isExceptionOccured = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 171052, 171071);

                            f_1477_171052_171070(this, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 171097, 171103);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 170800, 171126);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 171148, 171477);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 171284, 171454) || true) && (isExceptionOccured && (DynAbs.Tracing.TraceSender.Expression_True(1477, 171288, 171339) && (tempStopAsyncResult != null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 171284, 171454);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 171397, 171427);

                                f_1477_171397_171426(tempStopAsyncResult);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 171284, 171454);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 171148, 171477);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1477, 171501, 171507);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 168835, 174532);

                    case PSInvocationState.Disconnected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 168835, 174532);
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 171707, 171841) || true) && (f_1477_171711_171727() != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 171707, 171841);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 171793, 171814);

                                f_1477_171793_171813(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 171707, 171841);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 172043, 172291) || true) && (_commandInvokedSynchronously && (DynAbs.Tracing.TraceSender.Expression_True(1477, 172047, 172110) && (tempInvokeAsyncResult != null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 172043, 172291);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 172168, 172264);

                                f_1477_172168_172263(tempInvokeAsyncResult, f_1477_172205_172262(f_1477_172226_172261()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 172043, 172291);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 172624, 172781) || true) && (tempStopAsyncResult != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 172624, 172781);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 172713, 172754);

                                f_1477_172713_172753(tempStopAsyncResult, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 172624, 172781);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 173198, 173385) || true) && (previousState != PSInvocationState.Disconnected)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 173198, 173385);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 173307, 173358);

                                f_1477_173307_173357(this, f_1477_173329_173356(f_1477_173329_173348()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 173198, 173385);
                            }
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 173430, 173756);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 173630, 173656);

                            isExceptionOccured = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 173682, 173701);

                            f_1477_173682_173700(this, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 173727, 173733);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 173430, 173756);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 173778, 174107);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 173914, 174084) || true) && (isExceptionOccured && (DynAbs.Tracing.TraceSender.Expression_True(1477, 173918, 173969) && (tempStopAsyncResult != null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 173914, 174084);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 174027, 174057);

                                f_1477_174027_174056(tempStopAsyncResult);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 173914, 174084);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 173778, 174107);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 174409, 174432);

                        _connectCmdInfo = null;
                        DynAbs.Tracing.TraceSender.TraceBreak(1477, 174454, 174460);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 168835, 174532);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 168835, 174532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 174510, 174517);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 168835, 174532);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 166034, 174543);

                System.Management.Automation.Runspaces.Pipeline
                f_1477_166330_166362(System.Management.Automation.PowerShell.Worker
                this_param)
                {
                    var return_v = this_param.CurrentlyRunningPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 166330, 166362);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1477_166417_166449(System.Management.Automation.PowerShell.Worker
                this_param)
                {
                    var return_v = this_param.CurrentlyRunningPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 166417, 166449);
                    return return_v;
                }


                bool
                f_1477_166417_166459(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.HadErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 166417, 166459);
                    return return_v;
                }


                int
                f_1477_166404_166460(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 166404, 166460);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_166875_166894()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 166875, 166894);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_166875_166900(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 166875, 166900);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_167024_167043()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 167024, 167043);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_167024_167049(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 167024, 167049);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_167542_167557(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 167542, 167557);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_167921_167936(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 167921, 167936);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_167998_168013(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 167998, 168013);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_168170_168185(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 168170, 168185);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_168254_168269(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 168254, 168269);
                    return return_v;
                }


                System.Exception
                f_1477_168424_168440(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 168424, 168440);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_168371_168441(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 168371, 168441);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_168843_168862()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 168843, 168862);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_168843_168868(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 168843, 168868);
                    return return_v;
                }


                int
                f_1477_168955_169000(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationState
                previousState)
                {
                    this_param.CloseInputBufferOnReconnection(previousState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 168955, 169000);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_169045_169064()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 169045, 169064);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_169045_169072(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 169045, 169072);
                    return return_v;
                }


                int
                f_1477_169023_169073(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 169023, 169073);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_169196_169215()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 169196, 169215);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_169196_169223(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 169196, 169223);
                    return return_v;
                }


                int
                f_1477_169174_169224(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 169174, 169224);
                    return 0;
                }


                int
                f_1477_169467_169500(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.InternalClearSuppressExceptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 169467, 169500);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_169597_169613()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 169597, 169613);
                    return return_v;
                }


                int
                f_1477_169671_169691(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.ResumeIncomingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 169671, 169691);
                    return 0;
                }


                bool
                f_1477_169795_169815()
                {
                    var return_v = RunningExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 169795, 169815);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_170009_170028()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 170009, 170028);
                    return return_v;
                }


                System.Exception
                f_1477_170009_170035(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 170009, 170035);
                    return return_v;
                }


                int
                f_1477_169972_170036(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 169972, 170036);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_170122_170141()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 170122, 170141);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_170122_170149(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 170122, 170149);
                    return return_v;
                }


                int
                f_1477_170100_170150(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 170100, 170150);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_170287_170306()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 170287, 170306);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_170287_170314(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 170287, 170314);
                    return return_v;
                }


                int
                f_1477_170265_170315(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 170265, 170315);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_170484_170503()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 170484, 170503);
                    return return_v;
                }


                System.Exception
                f_1477_170484_170510(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 170484, 170510);
                    return return_v;
                }


                int
                f_1477_170447_170511(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 170447, 170511);
                    return 0;
                }


                int
                f_1477_170687_170727(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 170687, 170727);
                    return 0;
                }


                int
                f_1477_171052_171070(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 171052, 171070);
                    return 0;
                }


                int
                f_1477_171397_171426(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    this_param.Release();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 171397, 171426);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_171711_171727()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 171711, 171727);
                    return return_v;
                }


                int
                f_1477_171793_171813(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.ResumeIncomingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 171793, 171813);
                    return 0;
                }


                string
                f_1477_172226_172261()
                {
                    var return_v = PowerShellStrings.DiscOnSyncCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 172226, 172261);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1477_172205_172262(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 172205, 172262);
                    return return_v;
                }


                int
                f_1477_172168_172263(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Management.Automation.RuntimeException
                exception)
                {
                    this_param.SetAsCompleted((System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 172168, 172263);
                    return 0;
                }


                int
                f_1477_172713_172753(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 172713, 172753);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_173329_173348()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 173329, 173348);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_173329_173356(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 173329, 173356);
                    return return_v;
                }


                int
                f_1477_173307_173357(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 173307, 173357);
                    return 0;
                }


                int
                f_1477_173682_173700(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 173682, 173700);
                    return 0;
                }


                int
                f_1477_174027_174056(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    this_param.Release();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 174027, 174056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 166034, 174543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 166034, 174543);
            }
        }

        private void CloseInputBufferOnReconnection(PSInvocationState previousState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 174752, 175592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 175223, 175581) || true) && (previousState == PSInvocationState.Disconnected && (DynAbs.Tracing.TraceSender.Expression_True(1477, 175227, 175323) && _commandInvokedSynchronously) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 175227, 175380) && f_1477_175344_175372(f_1477_175344_175360()) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 175227, 175436) && f_1477_175401_175436(f_1477_175401_175429(f_1477_175401_175417()))) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 175227, 175495) && f_1477_175457_175491(f_1477_175457_175485(f_1477_175457_175473())) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 175223, 175581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 175529, 175566);

                    f_1477_175529_175565(f_1477_175529_175557(f_1477_175529_175545()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 175223, 175581);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 174752, 175592);

                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_175344_175360()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175344, 175360);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1477_175344_175372(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175344, 175372);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_175401_175417()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175401, 175417);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1477_175401_175429(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175401, 175429);
                    return return_v;
                }


                bool
                f_1477_175401_175436(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175401, 175436);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_175457_175473()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175457, 175473);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1477_175457_175485(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175457, 175485);
                    return return_v;
                }


                int
                f_1477_175457_175491(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175457, 175491);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_175529_175545()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175529, 175545);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1477_175529_175557(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175529, 175557);
                    return return_v;
                }


                int
                f_1477_175529_175565(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 175529, 175565);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 174752, 175592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 174752, 175592);
            }
        }

        internal void ClearRemotePowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 175715, 175968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 175783, 175794);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 175828, 175942) || true) && (f_1477_175832_175848() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 175828, 175942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 175898, 175923);

                        f_1477_175898_175922(f_1477_175898_175914());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 175828, 175942);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 175715, 175968);

                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_175832_175848()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175832, 175848);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_175898_175914()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 175898, 175914);
                    return return_v;
                }


                int
                f_1477_175898_175922(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 175898, 175922);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 175715, 175968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 175715, 175968);
            }
        }

        internal void SetIsNested(bool isNested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 176164, 176303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 176229, 176256);

                f_1477_176229_176255(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 176272, 176292);

                IsNested = isNested;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 176164, 176303);

                int
                f_1477_176229_176255(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertChangesAreAccepted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 176229, 176255);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 176164, 176303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 176164, 176303);
            }
        }

        private void CoreInvoke<TOutput>(IEnumerable input, PSDataCollection<TOutput> output, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 178806, 179352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 178947, 178991);

                PSDataCollection<object>
                inputBuffer = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 179005, 179283) || true) && (input != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 179005, 179283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 179056, 179101);

                    inputBuffer = f_1477_179070_179100();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 179119, 179225);
                        foreach (object o in f_1477_179140_179145_I(input))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 179119, 179225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 179187, 179206);

                            f_1477_179187_179205(inputBuffer, o);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 179119, 179225);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 107);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 179245, 179268);

                    f_1477_179245_179267(
                                    inputBuffer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 179005, 179283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 179299, 179341);

                f_1477_179299_179340(this, inputBuffer, output, settings);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 178806, 179352);

                System.Management.Automation.PSDataCollection<object>
                f_1477_179070_179100()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 179070, 179100);
                    return return_v;
                }


                int
                f_1477_179187_179205(System.Management.Automation.PSDataCollection<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 179187, 179205);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1477_179140_179145_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 179140, 179145);
                    return return_v;
                }


                int
                f_1477_179245_179267(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 179245, 179267);
                    return 0;
                }


                int
                f_1477_179299_179340(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<object>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvoke<object, TOutput>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 179299, 179340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 178806, 179352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 178806, 179352);
            }
        }

        private void CoreInvokeHelper<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 179757, 183244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 179925, 179975);

                RunspacePool
                pool = _rsConnection as RunspacePool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180052, 180108);

                f_1477_180052_180107(this, input, output, settings, true);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180229, 180253);

                    Runspace
                    rsToUse = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180271, 182626) || true) && (f_1477_180275_180284_M(!IsNested))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 180271, 182626);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180326, 181944) || true) && (pool != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 180326, 181944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180403, 180482);

                            f_1477_180403_180481(this, settings, f_1477_180434_180453(pool), f_1477_180455_180473(pool), false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180665, 180732);

                            _worker.GetRunspaceAsyncResult = f_1477_180698_180731(pool, null, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180758, 180815);

                            f_1477_180758_180814(f_1477_180758_180804(f_1477_180758_180788(_worker)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 180841, 180903);

                            rsToUse = f_1477_180851_180902(pool, f_1477_180871_180901(_worker));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 180326, 181944);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 180326, 181944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 181001, 181037);

                            rsToUse = _rsConnection as Runspace;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 181063, 181921) || true) && (rsToUse != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 181063, 181921);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 181151, 181236);

                                f_1477_181151_181235(this, settings, f_1477_181182_181204(rsToUse), f_1477_181206_181227(rsToUse), false);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 181276, 181894) || true) && (f_1477_181280_181311(f_1477_181280_181305(rsToUse)) != RunspaceState.Opened)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 181276, 181894);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 181401, 181531);

                                    string
                                    message = f_1477_181418_181530(f_1477_181436_181474(), RunspaceState.Opened, f_1477_181498_181529(f_1477_181498_181523(rsToUse)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 181567, 181819);

                                    InvalidRunspaceStateException
                                    e = f_1477_181601_181818(message, f_1477_181685_181716(f_1477_181685_181710(rsToUse)), RunspaceState.Opened)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 181855, 181863);

                                    throw e;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 181276, 181894);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 181063, 181921);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 180326, 181944);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 182031, 182086);

                        f_1477_182031_182085(
                                            // perform the work in the current thread
                                            _worker, rsToUse, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 180271, 182626);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 180271, 182626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 182168, 182204);

                        rsToUse = _rsConnection as Runspace;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 182226, 182328);

                        f_1477_182226_182327(rsToUse != null, "Nested PowerShell can only work on a Runspace");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 182557, 182607);

                        f_1477_182557_182606(
                                            // Perform work on the current thread. Nested Pipeline
                                            // should be invoked from the same thread that the parent
                                            // pipeline is executing in.
                                            _worker, rsToUse, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 180271, 182626);
                    }
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 182655, 183233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 182715, 182795);

                    f_1477_182715_182794(this, f_1477_182731_182793(PSInvocationState.Failed, exception));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 182858, 182955);

                    InvalidRunspacePoolStateException
                    poolException = exception as InvalidRunspacePoolStateException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 182975, 183192) || true) && (poolException != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 182979, 183021) && _runspace != null))
                    ) // the pool exception was actually thrown by a runspace

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 182975, 183192);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 183119, 183173);

                        throw f_1477_183125_183172(poolException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 182975, 183192);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 183212, 183218);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 182655, 183233);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 179757, 183244);

                int
                f_1477_180052_180107(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, bool
                shouldCreateWorker)
                {
                    this_param.Prepare<TInput, TOutput>(input, output, settings, shouldCreateWorker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 180052, 180107);
                    return 0;
                }


                bool
                f_1477_180275_180284_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 180275, 180284);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1477_180434_180453(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 180434, 180453);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1477_180455_180473(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 180455, 180473);
                    return return_v;
                }


                int
                f_1477_180403_180481(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationSettings
                settings, System.Threading.ApartmentState
                runspaceApartmentState, System.Management.Automation.Runspaces.PSThreadOptions
                runspaceThreadOptions, bool
                isRemote)
                {
                    this_param.VerifyThreadSettings(settings, runspaceApartmentState, runspaceThreadOptions, isRemote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 180403, 180481);
                    return 0;
                }


                System.IAsyncResult
                f_1477_180698_180731(System.Management.Automation.Runspaces.RunspacePool
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginGetRunspace(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 180698, 180731);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_180758_180788(System.Management.Automation.PowerShell.Worker
                this_param)
                {
                    var return_v = this_param.GetRunspaceAsyncResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 180758, 180788);
                    return return_v;
                }


                System.Threading.WaitHandle
                f_1477_180758_180804(System.IAsyncResult
                this_param)
                {
                    var return_v = this_param.AsyncWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 180758, 180804);
                    return return_v;
                }


                bool
                f_1477_180758_180814(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 180758, 180814);
                    return return_v;
                }


                System.IAsyncResult
                f_1477_180871_180901(System.Management.Automation.PowerShell.Worker
                this_param)
                {
                    var return_v = this_param.GetRunspaceAsyncResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 180871, 180901);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1477_180851_180902(System.Management.Automation.Runspaces.RunspacePool
                this_param, System.IAsyncResult
                asyncResult)
                {
                    var return_v = this_param.EndGetRunspace(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 180851, 180902);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1477_181182_181204(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181182, 181204);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1477_181206_181227(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181206, 181227);
                    return return_v;
                }


                int
                f_1477_181151_181235(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationSettings
                settings, System.Threading.ApartmentState
                runspaceApartmentState, System.Management.Automation.Runspaces.PSThreadOptions
                runspaceThreadOptions, bool
                isRemote)
                {
                    this_param.VerifyThreadSettings(settings, runspaceApartmentState, runspaceThreadOptions, isRemote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 181151, 181235);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1477_181280_181305(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181280, 181305);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1477_181280_181311(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181280, 181311);
                    return return_v;
                }


                string
                f_1477_181436_181474()
                {
                    var return_v = PowerShellStrings.InvalidRunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181436, 181474);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1477_181498_181523(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181498, 181523);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1477_181498_181529(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181498, 181529);
                    return return_v;
                }


                string
                f_1477_181418_181530(string
                formatSpec, System.Management.Automation.Runspaces.RunspaceState
                o1, System.Management.Automation.Runspaces.RunspaceState
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 181418, 181530);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1477_181685_181710(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181685, 181710);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1477_181685_181716(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 181685, 181716);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1477_181601_181818(string
                message, System.Management.Automation.Runspaces.RunspaceState
                currentState, System.Management.Automation.Runspaces.RunspaceState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 181601, 181818);
                    return return_v;
                }


                int
                f_1477_182031_182085(System.Management.Automation.PowerShell.Worker
                this_param, System.Management.Automation.Runspaces.Runspace
                rsToUse, bool
                isSync)
                {
                    this_param.CreateRunspaceIfNeededAndDoWork(rsToUse, isSync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 182031, 182085);
                    return 0;
                }


                int
                f_1477_182226_182327(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 182226, 182327);
                    return 0;
                }


                bool
                f_1477_182557_182606(System.Management.Automation.PowerShell.Worker
                this_param, System.Management.Automation.Runspaces.Runspace
                rs, bool
                performSyncInvoke)
                {
                    var return_v = this_param.ConstructPipelineAndDoWork(rs, performSyncInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 182557, 182606);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_182731_182793(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 182731, 182793);
                    return return_v;
                }


                int
                f_1477_182715_182794(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.SetStateChanged(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 182715, 182794);
                    return 0;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1477_183125_183172(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                this_param)
                {
                    var return_v = this_param.ToInvalidRunspaceStateException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 183125, 183172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 179757, 183244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 179757, 183244);
            }
        }

        private void CoreInvokeRemoteHelper<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 183662, 184872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 183836, 183886);

                RunspacePool
                pool = _rsConnection as RunspacePool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 183986, 184106);

                IAsyncResult
                asyncResult = f_1477_184013_184105(this, input, output, settings, null, null, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184120, 184156);

                _commandInvokedSynchronously = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184170, 184245);

                PowerShellAsyncResult
                psAsyncResult = asyncResult as PowerShellAsyncResult
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184497, 184534);

                EndInvokeAsyncResult = psAsyncResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184548, 184574);

                f_1477_184548_184573(psAsyncResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184588, 184616);

                EndInvokeAsyncResult = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184632, 184838) || true) && ((PSInvocationState.Failed == f_1477_184665_184690(f_1477_184665_184684())) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 184636, 184756) && (f_1477_184721_184747(f_1477_184721_184740()) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 184632, 184838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184790, 184823);

                    throw f_1477_184796_184822(f_1477_184796_184815());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 184632, 184838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 184854, 184861);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 183662, 184872);

                System.IAsyncResult
                f_1477_184013_184105(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                asyncResultOutput)
                {
                    var return_v = this_param.CoreInvokeAsync<TInput, TOutput>(input, output, settings, callback, state, asyncResultOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 184013, 184105);
                    return return_v;
                }


                int
                f_1477_184548_184573(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    this_param.EndInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 184548, 184573);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_184665_184684()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 184665, 184684);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_184665_184690(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 184665, 184690);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_184721_184740()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 184721, 184740);
                    return return_v;
                }


                System.Exception
                f_1477_184721_184747(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 184721, 184747);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_184796_184815()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 184796, 184815);
                    return return_v;
                }


                System.Exception
                f_1477_184796_184822(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 184796, 184822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 183662, 184872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 183662, 184872);
            }
        }

        private void CoreInvoke<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 185270, 189694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185432, 185454);

                bool
                isRemote = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185470, 185492);

                f_1477_185470_185491(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185508, 185599) || true) && (_isBatching)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 185508, 185599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185557, 185584);

                    f_1477_185557_185583(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 185508, 185599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185615, 185635);

                f_1477_185615_185634(this, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185649, 185699);

                RunspacePool
                pool = _rsConnection as RunspacePool
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185713, 186311) || true) && ((pool != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 185717, 185750) && (f_1477_185736_185749(pool))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 185713, 186311);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185784, 186260) || true) && (f_1477_185788_185819(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 185784, 186260);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 185913, 185961);

                            f_1477_185913_185960(this, input, output, settings);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 186006, 186210);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186062, 186187) || true) && (_isBatching)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 186062, 186187);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186135, 186160);

                                f_1477_186135_186159(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 186062, 186187);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 186006, 186210);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186234, 186241);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 185784, 186260);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186280, 186296);

                    isRemote = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 185713, 186311);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186327, 189683) || true) && (_isBatching)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 186327, 189683);
                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186420, 189128);
                            foreach (PSCommand command in f_1477_186450_186463_I(f_1477_186450_186463()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 186420, 189128);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186554, 186866) || true) && (_psCommand != f_1477_186572_186610(f_1477_186572_186585(), f_1477_186586_186605(f_1477_186586_186599()) - 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 186554, 186866);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186668, 186696);

                                    RunningExtraCommands = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 186554, 186866);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 186554, 186866);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186810, 186839);

                                    RunningExtraCommands = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 186554, 186866);
                                }

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 186954, 186975);

                                    _psCommand = command;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 187007, 187336) || true) && (isRemote)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 187007, 187336);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 187085, 187133);

                                        f_1477_187085_187132(this, input, output, settings);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 187007, 187336);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 187007, 187336);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 187263, 187305);

                                        f_1477_187263_187304(this, input, output, settings);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 187007, 187336);
                                    }
                                }
                                catch (ActionPreferenceStopException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 187389, 187606);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 187573, 187579);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 187389, 187606);
                                }
                                catch (Exception e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 187632, 189105);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 187708, 187727);

                                    f_1477_187708_187726(this, true);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 187811, 187995) || true) && ((settings != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 187815, 187892) && f_1477_187837_187867(settings) == ActionPreference.Stop))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 187811, 187995);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 187958, 187964);

                                        throw;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 187811, 187995);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 188094, 188283) || true) && ((settings != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 188098, 188177) && f_1477_188120_188150(settings) == ActionPreference.Ignore))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 188094, 188283);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 188243, 188252);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 188094, 188283);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 188509, 188561);

                                    IContainsErrorRecord
                                    er = e as IContainsErrorRecord
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 188593, 189037) || true) && (er != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 188597, 188633) && f_1477_188611_188625(er) != null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 188593, 189037);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 188699, 188738);

                                        f_1477_188699_188737(f_1477_188699_188717(f_1477_188699_188711(this)), f_1477_188722_188736(er));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 188593, 189037);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 188593, 189037);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 188868, 189006);

                                        f_1477_188868_189005(f_1477_188868_188886(f_1477_188868_188880(this)), f_1477_188891_189004(e, "InvalidOperation", ErrorCategory.InvalidOperation, null));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 188593, 189037);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 189069, 189078);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 187632, 189105);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 186420, 189128);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 2709);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 2709);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1477, 189165, 189308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 189213, 189242);

                        RunningExtraCommands = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 189264, 189289);

                        f_1477_189264_189288(this);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1477, 189165, 189308);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 186327, 189683);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 186327, 189683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 189374, 189403);

                    RunningExtraCommands = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 189423, 189668) || true) && (isRemote)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 189423, 189668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 189477, 189525);

                        f_1477_189477_189524(this, input, output, settings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 189423, 189668);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 189423, 189668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 189607, 189649);

                        f_1477_189607_189648(this, input, output, settings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 189423, 189668);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 186327, 189683);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 185270, 189694);

                int
                f_1477_185470_185491(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.DetermineIsBatching();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 185470, 185491);
                    return 0;
                }


                int
                f_1477_185557_185583(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.SetupAsyncBatchExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 185557, 185583);
                    return 0;
                }


                int
                f_1477_185615_185634(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 185615, 185634);
                    return 0;
                }


                bool
                f_1477_185736_185749(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.IsRemote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 185736, 185749);
                    return return_v;
                }


                bool
                f_1477_185788_185819(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.ServerSupportsBatchInvocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 185788, 185819);
                    return return_v;
                }


                int
                f_1477_185913_185960(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvokeRemoteHelper<TInput, TOutput>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 185913, 185960);
                    return 0;
                }


                int
                f_1477_186135_186159(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.EndAsyncBatchExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 186135, 186159);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_186450_186463()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 186450, 186463);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_186572_186585()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 186572, 186585);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_186586_186599()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 186586, 186599);
                    return return_v;
                }


                int
                f_1477_186586_186605(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 186586, 186605);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_186572_186610(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 186572, 186610);
                    return return_v;
                }


                int
                f_1477_187085_187132(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvokeRemoteHelper<TInput, TOutput>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 187085, 187132);
                    return 0;
                }


                int
                f_1477_187263_187304(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvokeHelper<TInput, TOutput>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 187263, 187304);
                    return 0;
                }


                int
                f_1477_187708_187726(System.Management.Automation.PowerShell
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 187708, 187726);
                    return 0;
                }


                System.Management.Automation.ActionPreference?
                f_1477_187837_187867(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ErrorActionPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 187837, 187867);
                    return return_v;
                }


                System.Management.Automation.ActionPreference?
                f_1477_188120_188150(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ErrorActionPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 188120, 188150);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1477_188611_188625(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 188611, 188625);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1477_188699_188711(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 188699, 188711);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1477_188699_188717(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 188699, 188717);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1477_188722_188736(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 188722, 188736);
                    return return_v;
                }


                int
                f_1477_188699_188737(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 188699, 188737);
                    return 0;
                }


                System.Management.Automation.PSDataStreams
                f_1477_188868_188880(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 188868, 188880);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1477_188868_188886(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 188868, 188886);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1477_188891_189004(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 188891, 189004);
                    return return_v;
                }


                int
                f_1477_188868_189005(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 188868, 189005);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_186450_186463_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 186450, 186463);
                    return return_v;
                }


                int
                f_1477_189264_189288(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.EndAsyncBatchExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 189264, 189288);
                    return 0;
                }


                int
                f_1477_189477_189524(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvokeRemoteHelper<TInput, TOutput>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 189477, 189524);
                    return 0;
                }


                int
                f_1477_189607_189648(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.CoreInvokeHelper<TInput, TOutput>(input, output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 189607, 189648);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 185270, 189694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 185270, 189694);
            }
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
        private IAsyncResult CoreInvokeAsync<TInput, TOutput>(PSDataCollection<TInput> input,
                    PSDataCollection<TOutput> output, PSInvocationSettings settings,
                    AsyncCallback callback, object state, PSDataCollection<PSObject> asyncResultOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 191110, 198193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 191489, 191539);

                RunspacePool
                pool = _rsConnection as RunspacePool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 191619, 191703);

                f_1477_191619_191702(this, input, output, settings, (pool == null || (DynAbs.Tracing.TraceSender.Expression_False(1477, 191670, 191700) || f_1477_191686_191700_M(!pool.IsRemote))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 191719, 191820);

                _invokeAsyncResult = f_1477_191740_191819(f_1477_191766_191776(), callback, state, asyncResultOutput, true);

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 191942, 197451) || true) && (f_1477_191946_191955_M(!IsNested) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 191946, 191990) || (pool != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 191960, 191989) && f_1477_191976_191989(pool)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 191942, 197451);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 192032, 197212) || true) && (pool != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 192032, 197212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 192109, 192196);

                            f_1477_192109_192195(this, settings, f_1477_192140_192159(pool), f_1477_192161_192179(pool), f_1477_192181_192194(pool));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 192232, 192256);

                            f_1477_192232_192255(
                                                    pool);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 192357, 195745) || true) && (f_1477_192361_192374(pool))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 192357, 195745);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 192432, 192447);

                                _worker = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 192485, 192496);

                                lock (_syncObject)
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 193327, 193355);

                                    f_1477_193327_193354(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 193391, 193472);

                                    InvocationStateInfo = f_1477_193413_193471(PSInvocationState.Running, null);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 193508, 193544);

                                    ObjectStreamBase
                                    inputStream = null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 193580, 193774) || true) && (input != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 193580, 193774);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 193671, 193739);

                                        inputStream = f_1477_193685_193738(f_1477_193720_193730(), input);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 193580, 193774);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 193810, 195217) || true) && (f_1477_193814_193843_M(!f_1477_193815_193831().Initialized))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 193810, 195217);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 193917, 194156) || true) && (inputStream == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 193917, 194156);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 194022, 194055);

                                            inputStream = f_1477_194036_194054();
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 194097, 194117);

                                            f_1477_194097_194116(inputStream);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 193917, 194156);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 194196, 194537);

                                        f_1477_194196_194536(f_1477_194196_194212(), inputStream, f_1477_194279_194334(f_1477_194315_194325(), output), f_1477_194385_194450(f_1477_194425_194435(), _errorBuffer), f_1477_194505_194525(), settings);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 193810, 195217);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 193810, 195217);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 194683, 194870) || true) && (inputStream != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 194683, 194870);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 194788, 194831);

                                            f_1477_194788_194804().InputStream = inputStream;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 194683, 194870);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 194910, 195182) || true) && (output != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 194910, 195182);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 195010, 195143);

                                            f_1477_195010_195026().OutputStream =
                                            f_1477_195087_195142(f_1477_195123_195133(), output);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 194910, 195182);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 193810, 195217);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 195253, 195337);

                                    f_1477_195253_195336(f_1477_195253_195284(pool), f_1477_195319_195335());
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 195400, 195451);

                                f_1477_195400_195450(this, f_1477_195422_195449(f_1477_195422_195441()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 192357, 195745);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 192357, 195745);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 195565, 195718);

                                _worker.GetRunspaceAsyncResult = f_1477_195598_195717(pool, new AsyncCallback(_worker.RunspaceAvailableCallback), null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 192357, 195745);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 192032, 197212);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 192032, 197212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 195843, 195893);

                            LocalRunspace
                            rs = _rsConnection as LocalRunspace
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 195919, 197189) || true) && (rs != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 195919, 197189);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 196002, 196077);

                                f_1477_196002_196076(this, settings, f_1477_196033_196050(rs), f_1477_196052_196068(rs), false);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 196117, 196720) || true) && (f_1477_196121_196147(f_1477_196121_196141(rs)) != RunspaceState.Opened)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 196117, 196720);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 196237, 196362);

                                    string
                                    message = f_1477_196254_196361(f_1477_196272_196310(), RunspaceState.Opened, f_1477_196334_196360(f_1477_196334_196354(rs)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 196398, 196645);

                                    InvalidRunspaceStateException
                                    e = f_1477_196432_196644(message, f_1477_196516_196542(f_1477_196516_196536(rs)), RunspaceState.Opened)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 196681, 196689);

                                    throw e;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 196117, 196720);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 196752, 196803);

                                f_1477_196752_196802(
                                                            _worker, rs, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 195919, 197189);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 195919, 197189);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 196992, 197162);

                                f_1477_196992_197161(new WaitCallback(_worker.CreateRunspaceIfNeededAndDoWork), _rsConnection);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 195919, 197189);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 192032, 197212);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 191942, 197451);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 191942, 197451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 197336, 197432);

                        throw f_1477_197342_197431(f_1477_197385_197430());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 191942, 197451);
                    }
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 197480, 198140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 197580, 197606);

                    _invokeAsyncResult = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 197624, 197704);

                    f_1477_197624_197703(this, f_1477_197640_197702(PSInvocationState.Failed, exception));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 197765, 197862);

                    InvalidRunspacePoolStateException
                    poolException = exception as InvalidRunspacePoolStateException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 197882, 198099) || true) && (poolException != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 197886, 197928) && _runspace != null))
                    ) // the pool exception was actually thrown by a runspace

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 197882, 198099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198026, 198080);

                        throw f_1477_198032_198079(poolException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 197882, 198099);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198119, 198125);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 197480, 198140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198156, 198182);

                return _invokeAsyncResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 191110, 198193);

                bool
                f_1477_191686_191700_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 191686, 191700);
                    return return_v;
                }


                int
                f_1477_191619_191702(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<TInput>
                input, System.Management.Automation.PSDataCollection<TOutput>
                output, System.Management.Automation.PSInvocationSettings
                settings, bool
                shouldCreateWorker)
                {
                    this_param.Prepare<TInput, TOutput>(input, output, settings, shouldCreateWorker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 191619, 191702);
                    return 0;
                }


                System.Guid
                f_1477_191766_191776()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 191766, 191776);
                    return return_v;
                }


                System.Management.Automation.PowerShellAsyncResult
                f_1477_191740_191819(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, bool
                isCalledFromBeginInvoke)
                {
                    var return_v = new System.Management.Automation.PowerShellAsyncResult(ownerId, callback, state, output, isCalledFromBeginInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 191740, 191819);
                    return return_v;
                }


                bool
                f_1477_191946_191955_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 191946, 191955);
                    return return_v;
                }


                bool
                f_1477_191976_191989(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.IsRemote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 191976, 191989);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1477_192140_192159(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 192140, 192159);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1477_192161_192179(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 192161, 192179);
                    return return_v;
                }


                bool
                f_1477_192181_192194(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.IsRemote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 192181, 192194);
                    return return_v;
                }


                int
                f_1477_192109_192195(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationSettings
                settings, System.Threading.ApartmentState
                runspaceApartmentState, System.Management.Automation.Runspaces.PSThreadOptions
                runspaceThreadOptions, bool
                isRemote)
                {
                    this_param.VerifyThreadSettings(settings, runspaceApartmentState, runspaceThreadOptions, isRemote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 192109, 192195);
                    return 0;
                }


                int
                f_1477_192232_192255(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    this_param.AssertPoolIsOpen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 192232, 192255);
                    return 0;
                }


                bool
                f_1477_192361_192374(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.IsRemote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 192361, 192374);
                    return return_v;
                }


                int
                f_1477_193327_193354(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertExecutionNotStarted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 193327, 193354);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_193413_193471(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 193413, 193471);
                    return return_v;
                }


                System.Guid
                f_1477_193720_193730()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 193720, 193730);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<TInput>
                f_1477_193685_193738(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<TInput>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<TInput>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 193685, 193738);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_193815_193831()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 193815, 193831);
                    return return_v;
                }


                bool
                f_1477_193814_193843_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 193814, 193843);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStream
                f_1477_194036_194054()
                {
                    var return_v = new System.Management.Automation.Internal.ObjectStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 194036, 194054);
                    return return_v;
                }


                int
                f_1477_194097_194116(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 194097, 194116);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_194196_194212()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 194196, 194212);
                    return return_v;
                }


                System.Guid
                f_1477_194315_194325()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 194315, 194325);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<TOutput>
                f_1477_194279_194334(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<TOutput>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<TOutput>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 194279, 194334);
                    return return_v;
                }


                System.Guid
                f_1477_194425_194435()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 194425, 194435);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
                f_1477_194385_194450(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 194385, 194450);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1477_194505_194525()
                {
                    var return_v = InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 194505, 194525);
                    return return_v;
                }


                int
                f_1477_194196_194536(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param, System.Management.Automation.Internal.ObjectStreamBase
                inputstream, System.Management.Automation.Internal.PSDataCollectionStream<TOutput>
                outputstream, System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
                errorstream, System.Management.Automation.PSInformationalBuffers
                informationalBuffers, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    this_param.Initialize(inputstream, (System.Management.Automation.Internal.ObjectStreamBase)outputstream, (System.Management.Automation.Internal.ObjectStreamBase)errorstream, informationalBuffers, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 194196, 194536);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_194788_194804()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 194788, 194804);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_195010_195026()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 195010, 195026);
                    return return_v;
                }


                System.Guid
                f_1477_195123_195133()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 195123, 195133);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<TOutput>
                f_1477_195087_195142(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<TOutput>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<TOutput>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 195087, 195142);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_195253_195284(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 195253, 195284);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_195319_195335()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 195319, 195335);
                    return return_v;
                }


                int
                f_1477_195253_195336(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                shell)
                {
                    this_param.CreatePowerShellOnServerAndInvoke(shell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 195253, 195336);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_195422_195441()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 195422, 195441);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_195422_195449(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 195422, 195449);
                    return return_v;
                }


                int
                f_1477_195400_195450(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 195400, 195450);
                    return 0;
                }


                System.IAsyncResult
                f_1477_195598_195717(System.Management.Automation.Runspaces.RunspacePool
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginGetRunspace(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 195598, 195717);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1477_196033_196050(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196033, 196050);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1477_196052_196068(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196052, 196068);
                    return return_v;
                }


                int
                f_1477_196002_196076(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationSettings
                settings, System.Threading.ApartmentState
                runspaceApartmentState, System.Management.Automation.Runspaces.PSThreadOptions
                runspaceThreadOptions, bool
                isRemote)
                {
                    this_param.VerifyThreadSettings(settings, runspaceApartmentState, runspaceThreadOptions, isRemote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 196002, 196076);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1477_196121_196141(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196121, 196141);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1477_196121_196147(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196121, 196147);
                    return return_v;
                }


                string
                f_1477_196272_196310()
                {
                    var return_v = PowerShellStrings.InvalidRunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196272, 196310);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1477_196334_196354(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196334, 196354);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1477_196334_196360(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196334, 196360);
                    return return_v;
                }


                string
                f_1477_196254_196361(string
                formatSpec, System.Management.Automation.Runspaces.RunspaceState
                o1, System.Management.Automation.Runspaces.RunspaceState
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 196254, 196361);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1477_196516_196536(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196516, 196536);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1477_196516_196542(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 196516, 196542);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1477_196432_196644(string
                message, System.Management.Automation.Runspaces.RunspaceState
                currentState, System.Management.Automation.Runspaces.RunspaceState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 196432, 196644);
                    return return_v;
                }


                int
                f_1477_196752_196802(System.Management.Automation.PowerShell.Worker
                this_param, System.Management.Automation.Runspaces.LocalRunspace
                rsToUse, bool
                isSync)
                {
                    this_param.CreateRunspaceIfNeededAndDoWork((System.Management.Automation.Runspaces.Runspace)rsToUse, isSync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 196752, 196802);
                    return 0;
                }


                bool
                f_1477_196992_197161(System.Threading.WaitCallback
                callBack, object
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 196992, 197161);
                    return return_v;
                }


                string
                f_1477_197385_197430()
                {
                    var return_v = PowerShellStrings.NestedPowerShellInvokeAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 197385, 197430);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_197342_197431(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 197342, 197431);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_197640_197702(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 197640, 197702);
                    return return_v;
                }


                int
                f_1477_197624_197703(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.SetStateChanged(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 197624, 197703);
                    return 0;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1477_198032_198079(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                this_param)
                {
                    var return_v = this_param.ToInvalidRunspaceStateException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 198032, 198079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 191110, 198193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 191110, 198193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VerifyThreadSettings(PSInvocationSettings settings, ApartmentState runspaceApartmentState, PSThreadOptions runspaceThreadOptions, bool isRemote)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 198412, 199758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198594, 198624);

                ApartmentState
                apartmentState
                = default(ApartmentState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198640, 198909) || true) && (settings != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 198644, 198713) && f_1477_198664_198687(settings) != ApartmentState.Unknown))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 198640, 198909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198747, 198788);

                    apartmentState = f_1477_198764_198787(settings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 198640, 198909);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 198640, 198909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198854, 198894);

                    apartmentState = runspaceApartmentState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 198640, 198909);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 198925, 199747) || true) && (runspaceThreadOptions == PSThreadOptions.ReuseThread)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 198925, 199747);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 199015, 199198) || true) && (apartmentState != runspaceApartmentState)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 199015, 199198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 199101, 199179);

                        throw f_1477_199107_199178(f_1477_199137_199177());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 199015, 199198);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 198925, 199747);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 198925, 199747);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 199232, 199747) || true) && (runspaceThreadOptions == PSThreadOptions.UseCurrentThread)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 199232, 199747);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 199327, 199732) || true) && (!isRemote)
                        ) // on remote calls this check needs to be done by the server

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 199327, 199732);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 199443, 199713) || true) && (apartmentState != ApartmentState.Unknown && (DynAbs.Tracing.TraceSender.Expression_True(1477, 199447, 199549) && apartmentState != f_1477_199509_199549(f_1477_199509_199529())))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 199443, 199713);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 199599, 199690);

                                throw f_1477_199605_199689(f_1477_199635_199688());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 199443, 199713);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 199327, 199732);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 199232, 199747);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 198925, 199747);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 198412, 199758);

                System.Threading.ApartmentState
                f_1477_198664_198687(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 198664, 198687);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1477_198764_198787(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 198764, 198787);
                    return return_v;
                }


                string
                f_1477_199137_199177()
                {
                    var return_v = PowerShellStrings.ApartmentStateMismatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 199137, 199177);
                    return return_v;
                }


                System.InvalidOperationException
                f_1477_199107_199178(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 199107, 199178);
                    return return_v;
                }


                System.Threading.Thread
                f_1477_199509_199529()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 199509, 199529);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1477_199509_199549(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.GetApartmentState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 199509, 199549);
                    return return_v;
                }


                string
                f_1477_199635_199688()
                {
                    var return_v = PowerShellStrings.ApartmentStateMismatchCurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 199635, 199688);
                    return return_v;
                }


                System.InvalidOperationException
                f_1477_199605_199689(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 199605, 199689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 198412, 199758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 198412, 199758);
            }
        }

        private void Prepare<TInput, TOutput>(PSDataCollection<TInput> input, PSDataCollection<TOutput> output, PSInvocationSettings settings, bool shouldCreateWorker)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 200512, 203478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 200696, 200748);

                f_1477_200696_200747(output != null, "Output cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 200770, 200781);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 200815, 201055) || true) && ((_psCommand == null) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 200819, 200872) || (f_1477_200844_200863(_psCommand) == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1477, 200819, 200908) || (0 == f_1477_200882_200907(f_1477_200882_200901(_psCommand)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 200815, 201055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 200950, 201036);

                        throw f_1477_200956_201035(f_1477_200999_201034());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 200815, 201055);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 201142, 201170);

                    f_1477_201142_201169(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 201190, 202994) || true) && (shouldCreateWorker)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 201190, 202994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 201425, 201506);

                        InvocationStateInfo = f_1477_201447_201505(PSInvocationState.Running, null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 201595, 202180) || true) && ((settings != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 201599, 201655) && (f_1477_201622_201654(settings))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 201595, 202180);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202028, 202157);

                            settings.WindowsIdentityToImpersonate =
                            f_1477_202097_202156(false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 201595, 202180);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202391, 202420);

                        ObjectStreamBase
                        inputStream
                        = default(ObjectStreamBase);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202442, 202777) || true) && (input != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 202442, 202777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202509, 202577);

                            inputStream = f_1477_202523_202576(f_1477_202558_202568(), input);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 202442, 202777);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 202442, 202777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202675, 202708);

                            inputStream = f_1477_202689_202707();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202734, 202754);

                            f_1477_202734_202753(inputStream);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 202442, 202777);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202801, 202889);

                        ObjectStreamBase
                        outputStream = f_1477_202833_202888(f_1477_202869_202879(), output)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 202911, 202975);

                        _worker = f_1477_202921_202974(inputStream, outputStream, settings, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 201190, 202994);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 203128, 203467) || true) && (shouldCreateWorker)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 203128, 203467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 203401, 203452);

                    f_1477_203401_203451(this, f_1477_203423_203450(f_1477_203423_203442()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 203128, 203467);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 200512, 203478);

                int
                f_1477_200696_200747(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 200696, 200747);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_200844_200863(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 200844, 200863);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_200882_200901(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 200882, 200901);
                    return return_v;
                }


                int
                f_1477_200882_200907(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 200882, 200907);
                    return return_v;
                }


                string
                f_1477_200999_201034()
                {
                    var return_v = PowerShellStrings.NoCommandToInvoke;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 200999, 201034);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1477_200956_201035(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 200956, 201035);
                    return return_v;
                }


                int
                f_1477_201142_201169(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.AssertExecutionNotStarted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 201142, 201169);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_201447_201505(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 201447, 201505);
                    return return_v;
                }


                bool
                f_1477_201622_201654(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.FlowImpersonationPolicy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 201622, 201654);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1477_202097_202156(bool
                ifImpersonating)
                {
                    var return_v = System.Security.Principal.WindowsIdentity.GetCurrent(ifImpersonating);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 202097, 202156);
                    return return_v;
                }


                System.Guid
                f_1477_202558_202568()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 202558, 202568);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<TInput>
                f_1477_202523_202576(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<TInput>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<TInput>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 202523, 202576);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStream
                f_1477_202689_202707()
                {
                    var return_v = new System.Management.Automation.Internal.ObjectStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 202689, 202707);
                    return return_v;
                }


                int
                f_1477_202734_202753(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 202734, 202753);
                    return 0;
                }


                System.Guid
                f_1477_202869_202879()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 202869, 202879);
                    return return_v;
                }


                System.Management.Automation.Internal.PSDataCollectionStream<TOutput>
                f_1477_202833_202888(System.Guid
                psInstanceId, System.Management.Automation.PSDataCollection<TOutput>
                storeToUse)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<TOutput>(psInstanceId, storeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 202833, 202888);
                    return return_v;
                }


                System.Management.Automation.PowerShell.Worker
                f_1477_202921_202974(System.Management.Automation.Internal.ObjectStreamBase
                inputStream, System.Management.Automation.Internal.ObjectStreamBase
                outputStream, System.Management.Automation.PSInvocationSettings
                settings, System.Management.Automation.PowerShell
                shell)
                {
                    var return_v = new System.Management.Automation.PowerShell.Worker(inputStream, outputStream, settings, shell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 202921, 202974);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_203423_203442()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 203423, 203442);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_203423_203450(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 203423, 203450);
                    return return_v;
                }


                int
                f_1477_203401_203451(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 203401, 203451);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 200512, 203478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 200512, 203478);
            }
        }

        private IAsyncResult CoreStop(bool isSyncCall, AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 204067, 209044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 204176, 204199);

                bool
                isRunning = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 204213, 204241);

                bool
                isDisconnected = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 204255, 204328);

                Queue<PSInvocationStateInfo>
                events = f_1477_204293_204327()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 204418, 204429);

                // Acquire lock as we are going to change state here..
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 204624, 206775);

                    switch (f_1477_204632_204657(f_1477_204632_204651()))
                    {

                        case PSInvocationState.NotStarted:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 204624, 206775);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 204990, 205101);

                            InvocationStateInfo = f_1477_205012_205100(PSInvocationState.Stopping, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 205129, 205233);

                            f_1477_205129_205232(
                                                    events, f_1477_205144_205231(PSInvocationState.Stopped, null));
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 205259, 205265);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 204624, 206775);

                        case PSInvocationState.Completed:
                        case PSInvocationState.Failed:
                        case PSInvocationState.Stopped:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 204624, 206775);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 205453, 205540);

                            _stopAsyncResult = f_1477_205472_205539(f_1477_205498_205508(), callback, state, null, false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 205566, 205604);

                            f_1477_205566_205603(_stopAsyncResult, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 205630, 205654);

                            return _stopAsyncResult;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 204624, 206775);

                        case PSInvocationState.Stopping:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 204624, 206775);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 205836, 206104) || true) && (_stopAsyncResult == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 205836, 206104);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 205922, 206009);

                                _stopAsyncResult = f_1477_205941_206008(f_1477_205967_205977(), callback, state, null, false);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 206039, 206077);

                                f_1477_206039_206076(_stopAsyncResult, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 205836, 206104);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 206132, 206156);

                            return _stopAsyncResult;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 204624, 206775);

                        case PSInvocationState.Running:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 204624, 206775);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 206237, 206348);

                            InvocationStateInfo = f_1477_206259_206347(PSInvocationState.Stopping, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 206374, 206391);

                            isRunning = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 206417, 206423);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 204624, 206775);

                        case PSInvocationState.Disconnected:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 204624, 206775);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 206596, 206676);

                            InvocationStateInfo = f_1477_206618_206675(PSInvocationState.Failed, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 206702, 206724);

                            isDisconnected = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1477, 206750, 206756);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 204624, 206775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 206795, 206882);

                    _stopAsyncResult = f_1477_206814_206881(f_1477_206840_206850(), callback, state, null, false);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207160, 207663) || true) && (isDisconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 207160, 207663);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207212, 207418) || true) && (_invokeAsyncResult != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 207212, 207418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207359, 207399);

                        f_1477_207359_207398(                    // Since object is stopped, allow result wait to end.
                                            _invokeAsyncResult, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 207212, 207418);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207438, 207476);

                    f_1477_207438_207475(
                                    _stopAsyncResult, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207553, 207604);

                    f_1477_207553_207603(this, f_1477_207575_207602(f_1477_207575_207594()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207624, 207648);

                    return _stopAsyncResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 207160, 207663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207748, 207766);

                f_1477_207748_207765(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207782, 207833);

                f_1477_207782_207832(this, f_1477_207804_207831(f_1477_207804_207823()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207849, 207882);

                bool
                shouldRunStopHelper = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207896, 207946);

                RunspacePool
                pool = _rsConnection as RunspacePool
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 207962, 208658) || true) && (pool != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 207966, 207995) && f_1477_207982_207995(pool)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 207962, 208658);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208029, 208444) || true) && ((f_1477_208034_208050() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 208033, 208091) && f_1477_208063_208091(f_1477_208063_208079())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208029, 208444);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208133, 208162);

                        f_1477_208133_208161(f_1477_208133_208149());

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208186, 208316) || true) && (isSyncCall)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208186, 208316);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208250, 208293);

                            f_1477_208250_208292(f_1477_208250_208282(_stopAsyncResult));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208186, 208316);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208029, 208444);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208029, 208444);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208398, 208425);

                        shouldRunStopHelper = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208029, 208444);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 207962, 208658);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 207962, 208658);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208478, 208658) || true) && (isRunning)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208478, 208658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208525, 208550);

                        f_1477_208525_208549(_worker, isSyncCall);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208478, 208658);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208478, 208658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208616, 208643);

                        shouldRunStopHelper = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208478, 208658);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 207962, 208658);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208674, 208993) || true) && (shouldRunStopHelper)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208674, 208993);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208731, 208978) || true) && (isSyncCall)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208731, 208978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208787, 208806);

                        f_1477_208787_208805(this, events);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208731, 208978);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 208731, 208978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 208888, 208959);

                        f_1477_208888_208958(new WaitCallback(StopThreadProc), events);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208731, 208978);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 208674, 208993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 209009, 209033);

                return _stopAsyncResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 204067, 209044);

                System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                f_1477_204293_204327()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 204293, 204327);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_204632_204651()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 204632, 204651);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_204632_204657(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 204632, 204657);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_205012_205100(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 205012, 205100);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_205144_205231(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 205144, 205231);
                    return return_v;
                }


                int
                f_1477_205129_205232(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                this_param, System.Management.Automation.PSInvocationStateInfo
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 205129, 205232);
                    return 0;
                }


                System.Guid
                f_1477_205498_205508()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 205498, 205508);
                    return return_v;
                }


                System.Management.Automation.PowerShellAsyncResult
                f_1477_205472_205539(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, bool
                isCalledFromBeginInvoke)
                {
                    var return_v = new System.Management.Automation.PowerShellAsyncResult(ownerId, callback, state, output, isCalledFromBeginInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 205472, 205539);
                    return return_v;
                }


                int
                f_1477_205566_205603(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 205566, 205603);
                    return 0;
                }


                System.Guid
                f_1477_205967_205977()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 205967, 205977);
                    return return_v;
                }


                System.Management.Automation.PowerShellAsyncResult
                f_1477_205941_206008(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, bool
                isCalledFromBeginInvoke)
                {
                    var return_v = new System.Management.Automation.PowerShellAsyncResult(ownerId, callback, state, output, isCalledFromBeginInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 205941, 206008);
                    return return_v;
                }


                int
                f_1477_206039_206076(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 206039, 206076);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_206259_206347(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 206259, 206347);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_206618_206675(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 206618, 206675);
                    return return_v;
                }


                System.Guid
                f_1477_206840_206850()
                {
                    var return_v = InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 206840, 206850);
                    return return_v;
                }


                System.Management.Automation.PowerShellAsyncResult
                f_1477_206814_206881(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, bool
                isCalledFromBeginInvoke)
                {
                    var return_v = new System.Management.Automation.PowerShellAsyncResult(ownerId, callback, state, output, isCalledFromBeginInvoke);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 206814, 206881);
                    return return_v;
                }


                int
                f_1477_207359_207398(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 207359, 207398);
                    return 0;
                }


                int
                f_1477_207438_207475(System.Management.Automation.PowerShellAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 207438, 207475);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_207575_207594()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 207575, 207594);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_207575_207602(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 207575, 207602);
                    return return_v;
                }


                int
                f_1477_207553_207603(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 207553, 207603);
                    return 0;
                }


                int
                f_1477_207748_207765(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.ReleaseDebugger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 207748, 207765);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_207804_207823()
                {
                    var return_v = InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 207804, 207823);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_207804_207831(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 207804, 207831);
                    return return_v;
                }


                int
                f_1477_207782_207832(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 207782, 207832);
                    return 0;
                }


                bool
                f_1477_207982_207995(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.IsRemote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 207982, 207995);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_208034_208050()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 208034, 208050);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_208063_208079()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 208063, 208079);
                    return return_v;
                }


                bool
                f_1477_208063_208091(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.Initialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 208063, 208091);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_208133_208149()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 208133, 208149);
                    return return_v;
                }


                int
                f_1477_208133_208161(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    this_param.StopAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 208133, 208161);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1477_208250_208282(System.Management.Automation.PowerShellAsyncResult
                this_param)
                {
                    var return_v = this_param.AsyncWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 208250, 208282);
                    return return_v;
                }


                bool
                f_1477_208250_208292(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 208250, 208292);
                    return return_v;
                }


                int
                f_1477_208525_208549(System.Management.Automation.PowerShell.Worker
                this_param, bool
                isSyncCall)
                {
                    this_param.Stop(isSyncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 208525, 208549);
                    return 0;
                }


                int
                f_1477_208787_208805(System.Management.Automation.PowerShell
                this_param, System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                state)
                {
                    this_param.StopHelper((object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 208787, 208805);
                    return 0;
                }


                bool
                f_1477_208888_208958(System.Threading.WaitCallback
                callBack, System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 208888, 208958);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 204067, 209044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 204067, 209044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReleaseDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 209056, 209299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 209111, 209168);

                LocalRunspace
                localRunspace = _runspace as LocalRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 209182, 209288) || true) && (localRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 209182, 209288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 209241, 209273);

                    f_1477_209241_209272(localRunspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 209182, 209288);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 209056, 209299);

                int
                f_1477_209241_209272(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.ReleaseDebugger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 209241, 209272);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 209056, 209299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 209056, 209299);
            }
        }

        private void StopHelper(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 209600, 210288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 209662, 209738);

                Queue<PSInvocationStateInfo>
                events = state as Queue<PSInvocationStateInfo>
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 209752, 209870);

                f_1477_209752_209869(events != null, "StopImplementation expects a Queue<PSInvocationStateInfo> as parameter");
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210006, 210186) || true) && (f_1477_210013_210025(events) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 210006, 210186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210063, 210120);

                        PSInvocationStateInfo
                        targetStateInfo = f_1477_210103_210119(events)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210138, 210171);

                        f_1477_210138_210170(this, targetStateInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 210006, 210186);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 210006, 210186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 210006, 210186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210243, 210277);

                f_1477_210243_210276(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 209600, 210288);

                int
                f_1477_209752_209869(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 209752, 209869);
                    return 0;
                }


                int
                f_1477_210013_210025(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 210013, 210025);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_210103_210119(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 210103, 210119);
                    return return_v;
                }


                int
                f_1477_210138_210170(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.SetStateChanged(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 210138, 210170);
                    return 0;
                }


                int
                f_1477_210243_210276(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.InternalClearSuppressExceptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 210243, 210276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 209600, 210288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 209600, 210288);
            }
        }

        private void StopThreadProc(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 210300, 210770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210420, 210447);

                Exception
                exception = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210499, 210517);

                    f_1477_210499_210516(this, state);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 210546, 210759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210706, 210720);

                    exception = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 210738, 210744);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 210546, 210759);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 210300, 210770);

                int
                f_1477_210499_210516(System.Management.Automation.PowerShell
                this_param, object
                state)
                {
                    this_param.StopHelper(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 210499, 210516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 210300, 210770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 210300, 210770);
            }
        }

        internal ClientRemotePowerShell RemotePowerShell { get; private set; }

        public string HistoryString { get; set; }

        internal Collection<PSCommand> ExtraCommands { get; }

        internal bool RunningExtraCommands { get; private set; }

        private bool ServerSupportsBatchInvocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 211523, 212495);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211592, 211839) || true) && (_runspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 211592, 211839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211647, 211824);

                    return f_1477_211654_211687(f_1477_211654_211681(_runspace)) != RunspaceState.BeforeOpen && (DynAbs.Tracing.TraceSender.Expression_True(1477, 211654, 211823) && f_1477_211743_211779(_runspace) >= RemotingConstants.ProtocolVersionWin8RTM);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 211592, 211839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211855, 211916);

                RemoteRunspacePoolInternal
                remoteRunspacePoolInternal = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211930, 212306) || true) && (_rsConnection is RemoteRunspace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 211930, 212306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 211999, 212102);

                    remoteRunspacePoolInternal = f_1477_212028_212101(f_1477_212028_212074((_rsConnection as RemoteRunspace)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 211930, 212306);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 211930, 212306);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 212136, 212306) || true) && (_rsConnection is RunspacePool)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 212136, 212306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 212203, 212291);

                        remoteRunspacePoolInternal = f_1477_212232_212290((_rsConnection as RunspacePool));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 212136, 212306);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 211930, 212306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 212322, 212484);

                return remoteRunspacePoolInternal != null && (DynAbs.Tracing.TraceSender.Expression_True(1477, 212329, 212483) && f_1477_212387_212439(remoteRunspacePoolInternal) >= RemotingConstants.ProtocolVersionWin8RTM);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 211523, 212495);

                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1477_211654_211681(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 211654, 211681);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1477_211654_211687(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 211654, 211687);
                    return return_v;
                }


                System.Version
                f_1477_211743_211779(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetRemoteProtocolVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 211743, 211779);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1477_212028_212074(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 212028, 212074);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_212028_212101(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 212028, 212101);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_212232_212290(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 212232, 212290);
                    return return_v;
                }


                System.Version
                f_1477_212387_212439(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.PSRemotingProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 212387, 212439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 211523, 212495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 211523, 212495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddToRemoteRunspaceRunningList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 212643, 213158);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 212713, 213147) || true) && (_runspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 212713, 213147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 212768, 212806);

                    f_1477_212768_212805(_runspace, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 212713, 213147);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 212713, 213147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 212872, 212960);

                    RemoteRunspacePoolInternal
                    remoteRunspacePoolInternal = f_1477_212928_212959(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 212978, 213132) || true) && (remoteRunspacePoolInternal != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 212978, 213132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213058, 213113);

                        f_1477_213058_213112(remoteRunspacePoolInternal, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 212978, 213132);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 212713, 213147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 212643, 213158);

                int
                f_1477_212768_212805(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.PowerShell
                ps)
                {
                    this_param.PushRunningPowerShell(ps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 212768, 212805);
                    return 0;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_212928_212959(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetRemoteRunspacePoolInternal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 212928, 212959);
                    return return_v;
                }


                int
                f_1477_213058_213112(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param, System.Management.Automation.PowerShell
                ps)
                {
                    this_param.PushRunningPowerShell(ps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 213058, 213112);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 212643, 213158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 212643, 213158);
            }
        }

        private void RemoveFromRemoteRunspaceRunningList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 213310, 213820);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213385, 213809) || true) && (_runspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 213385, 213809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213440, 213473);

                    f_1477_213440_213472(_runspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 213385, 213809);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 213385, 213809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213539, 213627);

                    RemoteRunspacePoolInternal
                    remoteRunspacePoolInternal = f_1477_213595_213626(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213645, 213794) || true) && (remoteRunspacePoolInternal != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 213645, 213794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213725, 213775);

                        f_1477_213725_213774(remoteRunspacePoolInternal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 213645, 213794);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 213385, 213809);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 213310, 213820);

                System.Management.Automation.PowerShell
                f_1477_213440_213472(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.PopRunningPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 213440, 213472);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_213595_213626(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetRemoteRunspacePoolInternal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 213595, 213626);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_213725_213774(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.PopRunningPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 213725, 213774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 213310, 213820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 213310, 213820);
            }
        }

        private RemoteRunspacePoolInternal GetRemoteRunspacePoolInternal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 213832, 214087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213923, 213981);

                RunspacePool
                runspacePool = _rsConnection as RunspacePool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 213995, 214076);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 214002, 214024) || (((runspacePool != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 214027, 214068)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 214071, 214075))) ? (f_1477_214028_214067(runspacePool)) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 213832, 214087);

                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1477_214028_214067(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 214028, 214067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 213832, 214087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 213832, 214087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class Worker
        {
            private ObjectStreamBase _inputStream;

            private ObjectStreamBase _outputStream;

            private ObjectStreamBase _errorStream;

            private PSInvocationSettings _settings;

            private bool _isNotActive;

            private PowerShell _shell;

            private object _syncObject;

            internal Worker(ObjectStreamBase inputStream,
                            ObjectStreamBase outputStream,
                            PSInvocationSettings settings,
                            PowerShell shell)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 215015, 215496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 214437, 214449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 214489, 214502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 214542, 214554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 214598, 214607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 214635, 214647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 214681, 214687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 214717, 214743);
                    this._syncObject = f_1477_214731_214743();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 215717, 215775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 215900, 215964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 215224, 215251);

                    _inputStream = inputStream;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 215269, 215298);

                    _outputStream = outputStream;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 215316, 215409);

                    _errorStream = f_1477_215331_215408(f_1477_215371_215387(shell), shell._errorBuffer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 215427, 215448);

                    _settings = settings;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 215466, 215481);

                    _shell = shell;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 215015, 215496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 215015, 215496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 215015, 215496);
                }
            }

            internal IAsyncResult GetRunspaceAsyncResult { get; set; }

            internal Pipeline CurrentlyRunningPipeline { get; private set; }

            internal void CreateRunspaceIfNeededAndDoWork(object state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 216149, 216359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 216241, 216278);

                    Runspace
                    rsToUse = state as Runspace
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 216296, 216344);

                    f_1477_216296_216343(this, rsToUse, false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 216149, 216359);

                    int
                    f_1477_216296_216343(System.Management.Automation.PowerShell.Worker
                    this_param, System.Management.Automation.Runspaces.Runspace
                    rsToUse, bool
                    isSync)
                    {
                        this_param.CreateRunspaceIfNeededAndDoWork(rsToUse, isSync);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 216296, 216343);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 216149, 216359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 216149, 216359);
                }
            }

            internal void CreateRunspaceIfNeededAndDoWork(Runspace rsToUse, bool isSync)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 217009, 219448);
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217277, 217321);

                        LocalRunspace
                        rs = rsToUse as LocalRunspace
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217343, 218480) || true) && (rs == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 217343, 218480);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217413, 217431);
                            lock (_shell._syncObject)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217489, 218430) || true) && (_shell._runspace != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 217489, 218430);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217583, 217610);

                                    rsToUse = _shell._runspace;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 217489, 218430);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 217489, 218430);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217740, 217765);

                                    Runspace
                                    runspace = null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217801, 218209) || true) && ((_settings != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 217805, 217852) && (f_1477_217829_217843(_settings) != null)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 217801, 218209);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 217926, 217984);

                                        runspace = f_1477_217937_217983(f_1477_217968_217982(_settings));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 217801, 218209);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 217801, 218209);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218130, 218174);

                                        runspace = f_1477_218141_218173();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 217801, 218209);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218245, 218280);

                                    f_1477_218245_218279(
                                                                    _shell, runspace, true);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218316, 218350);

                                    rsToUse = (LocalRunspace)runspace;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218384, 218399);

                                    f_1477_218384_218398(rsToUse);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 217489, 218430);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 217343, 218480);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218504, 218548);

                        f_1477_218504_218547(this, rsToUse, isSync);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 218585, 219402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218855, 218866);
                        // PipelineStateChangedEvent is not raised
                        // if there is an exception calling BeginInvoke
                        // So raise the event here and notify the caller.
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218916, 218970) || true) && (_isNotActive)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 218916, 218970);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218963, 218970);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 218916, 218970);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 218996, 219016);

                            _isNotActive = true;
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 219063, 219270);

                        f_1477_219063_219269(
                                            _shell, this, f_1477_219125_219268(f_1477_219185_219267(PipelineState.Failed, e)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 219294, 219383) || true) && (isSync)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 219294, 219383);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 219354, 219360);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 219294, 219383);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 218585, 219402);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 217009, 219448);

                    System.Management.Automation.Host.PSHost
                    f_1477_217829_217843(System.Management.Automation.PSInvocationSettings
                    this_param)
                    {
                        var return_v = this_param.Host;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 217829, 217843);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHost
                    f_1477_217968_217982(System.Management.Automation.PSInvocationSettings
                    this_param)
                    {
                        var return_v = this_param.Host;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 217968, 217982);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1477_217937_217983(System.Management.Automation.Host.PSHost
                    host)
                    {
                        var return_v = RunspaceFactory.CreateRunspace(host);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 217937, 217983);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1477_218141_218173()
                    {
                        var return_v = RunspaceFactory.CreateRunspace();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 218141, 218173);
                        return return_v;
                    }


                    int
                    f_1477_218245_218279(System.Management.Automation.PowerShell
                    this_param, System.Management.Automation.Runspaces.Runspace
                    runspace, bool
                    owner)
                    {
                        this_param.SetRunspace(runspace, owner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 218245, 218279);
                        return 0;
                    }


                    int
                    f_1477_218384_218398(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        this_param.Open();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 218384, 218398);
                        return 0;
                    }


                    bool
                    f_1477_218504_218547(System.Management.Automation.PowerShell.Worker
                    this_param, System.Management.Automation.Runspaces.Runspace
                    rs, bool
                    performSyncInvoke)
                    {
                        var return_v = this_param.ConstructPipelineAndDoWork(rs, performSyncInvoke);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 218504, 218547);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.PipelineStateInfo
                    f_1477_219185_219267(System.Management.Automation.Runspaces.PipelineState
                    state, System.Exception
                    reason)
                    {
                        var return_v = new System.Management.Automation.Runspaces.PipelineStateInfo(state, reason);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 219185, 219267);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.PipelineStateEventArgs
                    f_1477_219125_219268(System.Management.Automation.Runspaces.PipelineStateInfo
                    pipelineStateInfo)
                    {
                        var return_v = new System.Management.Automation.Runspaces.PipelineStateEventArgs(pipelineStateInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 219125, 219268);
                        return return_v;
                    }


                    int
                    f_1477_219063_219269(System.Management.Automation.PowerShell
                    this_param, System.Management.Automation.PowerShell.Worker
                    source, System.Management.Automation.Runspaces.PipelineStateEventArgs
                    stateEventArgs)
                    {
                        this_param.PipelineStateChanged((object)source, stateEventArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 219063, 219269);
                        return 0;
                    }

#pragma warning restore 56500
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 217009, 219448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 217009, 219448);
                }
            }

            internal void RunspaceAvailableCallback(IAsyncResult asyncResult)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 220004, 221597);
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 220177, 220234);

                        RunspacePool
                        pool = _shell._rsConnection as RunspacePool
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 220256, 220327);

                        f_1477_220256_220326(pool != null, "RunspaceConnection must be a runspace pool");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 220495, 220554);

                        Runspace
                        pooledRunspace = f_1477_220521_220553(pool, asyncResult)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 220578, 220653);

                        bool
                        isPipelineCreated = f_1477_220603_220652(this, pooledRunspace, false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 220675, 220807) || true) && (!isPipelineCreated)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 220675, 220807);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 220747, 220784);

                            f_1477_220747_220783(pool, pooledRunspace);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 220675, 220807);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 220844, 221551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 221114, 221125);
                        // PipelineStateChangedEvent is not raised
                        // if there is an exception calling BeginInvoke
                        // So raise the event here and notify the caller.
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 221175, 221229) || true) && (_isNotActive)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 221175, 221229);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 221222, 221229);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 221175, 221229);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 221255, 221275);

                            _isNotActive = true;
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 221322, 221532);

                        f_1477_221322_221531(
                                            _shell, this, f_1477_221385_221530(f_1477_221446_221529(PipelineState.Failed, e)));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 220844, 221551);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 220004, 221597);

                    int
                    f_1477_220256_220326(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 220256, 220326);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1477_220521_220553(System.Management.Automation.Runspaces.RunspacePool
                    this_param, System.IAsyncResult
                    asyncResult)
                    {
                        var return_v = this_param.EndGetRunspace(asyncResult);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 220521, 220553);
                        return return_v;
                    }


                    bool
                    f_1477_220603_220652(System.Management.Automation.PowerShell.Worker
                    this_param, System.Management.Automation.Runspaces.Runspace
                    rs, bool
                    performSyncInvoke)
                    {
                        var return_v = this_param.ConstructPipelineAndDoWork(rs, performSyncInvoke);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 220603, 220652);
                        return return_v;
                    }


                    int
                    f_1477_220747_220783(System.Management.Automation.Runspaces.RunspacePool
                    this_param, System.Management.Automation.Runspaces.Runspace
                    runspace)
                    {
                        this_param.ReleaseRunspace(runspace);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 220747, 220783);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.PipelineStateInfo
                    f_1477_221446_221529(System.Management.Automation.Runspaces.PipelineState
                    state, System.Exception
                    reason)
                    {
                        var return_v = new System.Management.Automation.Runspaces.PipelineStateInfo(state, reason);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 221446, 221529);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.PipelineStateEventArgs
                    f_1477_221385_221530(System.Management.Automation.Runspaces.PipelineStateInfo
                    pipelineStateInfo)
                    {
                        var return_v = new System.Management.Automation.Runspaces.PipelineStateEventArgs(pipelineStateInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 221385, 221530);
                        return return_v;
                    }


                    int
                    f_1477_221322_221531(System.Management.Automation.PowerShell
                    this_param, System.Management.Automation.PowerShell.Worker
                    source, System.Management.Automation.Runspaces.PipelineStateEventArgs
                    stateEventArgs)
                    {
                        this_param.PipelineStateChanged((object)source, stateEventArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 221322, 221531);
                        return 0;
                    }

#pragma warning restore 56500
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 220004, 221597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 220004, 221597);
                }
            }

            internal bool ConstructPipelineAndDoWork(Runspace rs, bool performSyncInvoke)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 222551, 225254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 222661, 222741);

                    f_1477_222661_222740(rs != null, "Runspace cannot be null in ConstructPipelineAndDoWork");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 222759, 222831);

                    f_1477_222759_222830(_shell.RunspaceAssigned, this, f_1477_222800_222829(rs));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 222976, 223016);

                    LocalRunspace
                    lrs = rs as LocalRunspace
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223042, 223053);

                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223095, 223197) || true) && (_isNotActive)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 223095, 223197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223161, 223174);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 223095, 223197);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223221, 224723) || true) && (lrs != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 223221, 224723);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223286, 223753);

                            LocalPipeline
                            localPipeline = f_1477_223316_223752(lrs, f_1477_223398_223422(f_1477_223398_223413(_shell)), (DynAbs.Tracing.TraceSender.Conditional_F1(1477, 223453, 223502) || ((((_settings != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 223454, 223501) && (f_1477_223478_223500(_settings)))) && DynAbs.Tracing.TraceSender.Conditional_F2(1477, 223505, 223509)) || DynAbs.Tracing.TraceSender.Conditional_F3(1477, 223512, 223517))) ? true : false, f_1477_223548_223563(_shell), _inputStream, _outputStream, _errorStream, f_1477_223724_223751(_shell))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223781, 223820);

                            localPipeline.IsChild = f_1477_223805_223819(_shell);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223848, 224033) || true) && (!f_1477_223853_223895(f_1477_223874_223894(_shell)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 223848, 224033);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 223953, 224006);

                                f_1477_223953_224005(localPipeline, f_1477_223984_224004(_shell));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 223848, 224033);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 224061, 224142);

                            localPipeline.RedirectShellErrorOutputPipe = f_1477_224106_224141(_shell);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 224170, 224211);

                            CurrentlyRunningPipeline = localPipeline;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 224484, 224553);

                            f_1477_224484_224508().StateChanged += _shell.PipelineStateChanged;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 223221, 224723);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 223221, 224723);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 224651, 224700);

                            throw f_1477_224657_224699();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 223221, 224723);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 224813, 224869);

                    f_1477_224813_224837().InvocationSettings = _settings;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 224889, 224950);

                    f_1477_224889_224949(lrs != null, "LocalRunspace cannot be null here");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 224970, 225207) || true) && (performSyncInvoke)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 224970, 225207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225033, 225067);

                        f_1477_225033_225066(f_1477_225033_225057());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 224970, 225207);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 224970, 225207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225149, 225188);

                        f_1477_225149_225187(f_1477_225149_225173());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 224970, 225207);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225227, 225239);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 222551, 225254);

                    int
                    f_1477_222661_222740(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 222661, 222740);
                        return 0;
                    }


                    System.Management.Automation.PSEventArgs<System.Management.Automation.Runspaces.Runspace>
                    f_1477_222800_222829(System.Management.Automation.Runspaces.Runspace
                    args)
                    {
                        var return_v = new System.Management.Automation.PSEventArgs<System.Management.Automation.Runspaces.Runspace>(args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 222800, 222829);
                        return return_v;
                    }


                    int
                    f_1477_222759_222830(System.EventHandler<System.Management.Automation.PSEventArgs<System.Management.Automation.Runspaces.Runspace>>
                    eventHandler, System.Management.Automation.PowerShell.Worker
                    sender, System.Management.Automation.PSEventArgs<System.Management.Automation.Runspaces.Runspace>
                    eventArgs)
                    {
                        eventHandler.SafeInvoke<System.Management.Automation.PSEventArgs<System.Management.Automation.Runspaces.Runspace>>((object)sender, eventArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 222759, 222830);
                        return 0;
                    }


                    System.Management.Automation.PSCommand
                    f_1477_223398_223413(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.Commands;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223398, 223413);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.CommandCollection
                    f_1477_223398_223422(System.Management.Automation.PSCommand
                    this_param)
                    {
                        var return_v = this_param.Commands;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223398, 223422);
                        return return_v;
                    }


                    bool
                    f_1477_223478_223500(System.Management.Automation.PSInvocationSettings
                    this_param)
                    {
                        var return_v = this_param.AddToHistory;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223478, 223500);
                        return return_v;
                    }


                    bool
                    f_1477_223548_223563(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.IsNested;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223548, 223563);
                        return return_v;
                    }


                    System.Management.Automation.PSInformationalBuffers
                    f_1477_223724_223751(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.InformationalBuffers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223724, 223751);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.LocalPipeline
                    f_1477_223316_223752(System.Management.Automation.Runspaces.LocalRunspace
                    runspace, System.Management.Automation.Runspaces.CommandCollection
                    command, bool
                    addToHistory, bool
                    isNested, System.Management.Automation.Internal.ObjectStreamBase
                    inputStream, System.Management.Automation.Internal.ObjectStreamBase
                    outputStream, System.Management.Automation.Internal.ObjectStreamBase
                    errorStream, System.Management.Automation.PSInformationalBuffers
                    infoBuffers)
                    {
                        var return_v = new System.Management.Automation.Runspaces.LocalPipeline(runspace, command, addToHistory, isNested, inputStream, outputStream, errorStream, infoBuffers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 223316, 223752);
                        return return_v;
                    }


                    bool
                    f_1477_223805_223819(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.IsChild;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223805, 223819);
                        return return_v;
                    }


                    string
                    f_1477_223874_223894(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.HistoryString;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223874, 223894);
                        return return_v;
                    }


                    bool
                    f_1477_223853_223895(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 223853, 223895);
                        return return_v;
                    }


                    string
                    f_1477_223984_224004(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.HistoryString;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 223984, 224004);
                        return return_v;
                    }


                    int
                    f_1477_223953_224005(System.Management.Automation.Runspaces.LocalPipeline
                    this_param, string
                    historyString)
                    {
                        this_param.SetHistoryString(historyString);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 223953, 224005);
                        return 0;
                    }


                    bool
                    f_1477_224106_224141(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.RedirectShellErrorOutputPipe;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 224106, 224141);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_224484_224508()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 224484, 224508);
                        return return_v;
                    }


                    System.Management.Automation.PSNotImplementedException
                    f_1477_224657_224699()
                    {
                        var return_v = PSTraceSource.NewNotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 224657, 224699);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_224813_224837()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 224813, 224837);
                        return return_v;
                    }


                    int
                    f_1477_224889_224949(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 224889, 224949);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_225033_225057()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 225033, 225057);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    f_1477_225033_225066(System.Management.Automation.Runspaces.Pipeline
                    this_param)
                    {
                        var return_v = this_param.Invoke();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 225033, 225066);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_225149_225173()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 225149, 225173);
                        return return_v;
                    }


                    int
                    f_1477_225149_225187(System.Management.Automation.Runspaces.Pipeline
                    this_param)
                    {
                        this_param.InvokeAsync();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 225149, 225187);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 222551, 225254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 222551, 225254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void Stop(bool isSyncCall)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 225420, 227106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225494, 225505);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225547, 225643) || true) && (_isNotActive)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 225547, 225643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225613, 225620);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 225547, 225643);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225667, 225687);

                        _isNotActive = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225709, 226135) || true) && (f_1477_225713_225737() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 225709, 226135);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225795, 226077) || true) && (isSyncCall)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 225795, 226077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 225867, 225899);

                                f_1477_225867_225898(f_1477_225867_225891());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 225795, 226077);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 225795, 226077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226013, 226050);

                                f_1477_226013_226049(f_1477_226013_226037());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 225795, 226077);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226105, 226112);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 225709, 226135);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226159, 226493) || true) && (f_1477_226163_226185() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 226159, 226493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226243, 226300);

                            RunspacePool
                            pool = _shell._rsConnection as RunspacePool
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226326, 226397);

                            f_1477_226326_226396(pool != null, "RunspaceConnection must be a runspace pool");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226423, 226470);

                            f_1477_226423_226469(pool, f_1477_226446_226468());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 226159, 226493);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226644, 226717);

                    Queue<PSInvocationStateInfo>
                    events = f_1477_226682_226716()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226735, 226810);

                    f_1477_226735_226809(events, f_1477_226750_226808(PSInvocationState.Stopped, null));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226830, 227091) || true) && (isSyncCall)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 226830, 227091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226886, 226912);

                        f_1477_226886_226911(_shell, events);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 226830, 227091);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 226830, 227091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 226994, 227072);

                        f_1477_226994_227071(new WaitCallback(_shell.StopThreadProc), events);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 226830, 227091);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 225420, 227106);

                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_225713_225737()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 225713, 225737);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_225867_225891()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 225867, 225891);
                        return return_v;
                    }


                    int
                    f_1477_225867_225898(System.Management.Automation.Runspaces.Pipeline
                    this_param)
                    {
                        this_param.Stop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 225867, 225898);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_226013_226037()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 226013, 226037);
                        return return_v;
                    }


                    int
                    f_1477_226013_226049(System.Management.Automation.Runspaces.Pipeline
                    this_param)
                    {
                        this_param.StopAsync();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226013, 226049);
                        return 0;
                    }


                    System.IAsyncResult
                    f_1477_226163_226185()
                    {
                        var return_v = GetRunspaceAsyncResult;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 226163, 226185);
                        return return_v;
                    }


                    int
                    f_1477_226326_226396(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226326, 226396);
                        return 0;
                    }


                    System.IAsyncResult
                    f_1477_226446_226468()
                    {
                        var return_v = GetRunspaceAsyncResult;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 226446, 226468);
                        return return_v;
                    }


                    int
                    f_1477_226423_226469(System.Management.Automation.Runspaces.RunspacePool
                    this_param, System.IAsyncResult
                    asyncResult)
                    {
                        this_param.CancelGetRunspace(asyncResult);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226423, 226469);
                        return 0;
                    }


                    System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                    f_1477_226682_226716()
                    {
                        var return_v = new System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226682, 226716);
                        return return_v;
                    }


                    System.Management.Automation.PSInvocationStateInfo
                    f_1477_226750_226808(System.Management.Automation.PSInvocationState
                    state, System.Exception
                    reason)
                    {
                        var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226750, 226808);
                        return return_v;
                    }


                    int
                    f_1477_226735_226809(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                    this_param, System.Management.Automation.PSInvocationStateInfo
                    item)
                    {
                        this_param.Enqueue(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226735, 226809);
                        return 0;
                    }


                    int
                    f_1477_226886_226911(System.Management.Automation.PowerShell
                    this_param, System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                    state)
                    {
                        this_param.StopHelper((object)state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226886, 226911);
                        return 0;
                    }


                    bool
                    f_1477_226994_227071(System.Threading.WaitCallback
                    callBack, System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
                    state)
                    {
                        var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 226994, 227071);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 225420, 227106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 225420, 227106);
                }
            }

            internal void InternalClearSuppressExceptions()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 227297, 229411);
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227421, 227690) || true) && ((_settings != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 227425, 227496) && (f_1477_227449_227487(_settings) != null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 227421, 227690);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227546, 227595);

                            f_1477_227546_227594(f_1477_227546_227584(_settings));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227621, 227667);

                            _settings.WindowsIdentityToImpersonate = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 227421, 227690);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227714, 227735);

                        f_1477_227714_227734(
                                            _inputStream);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227757, 227779);

                        f_1477_227757_227778(_outputStream);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227801, 227822);

                        f_1477_227801_227821(_errorStream);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227846, 227962) || true) && (f_1477_227850_227874() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 227846, 227962);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 227932, 227939);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 227846, 227962);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 228150, 228219);

                        f_1477_228150_228174().StateChanged -= _shell.PipelineStateChanged;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 228243, 228906) || true) && ((f_1477_228248_228270() == null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 228247, 228313) && (_shell._rsConnection == null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 228243, 228906);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 228503, 228545);

                            f_1477_228503_228544(f_1477_228503_228536(f_1477_228503_228527()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 228243, 228906);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 228243, 228906);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 228643, 228700);

                            RunspacePool
                            pool = _shell._rsConnection as RunspacePool
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 228726, 228883) || true) && (pool != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 228726, 228883);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 228800, 228856);

                                f_1477_228800_228855(pool, f_1477_228821_228854(f_1477_228821_228845()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 228726, 228883);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 228243, 228906);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 228930, 228965);

                        f_1477_228930_228964(f_1477_228930_228954());
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 229002, 229065);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 229002, 229065);
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 229083, 229154);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 229083, 229154);
                    }
                    catch (InvalidRunspaceStateException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 229172, 229247);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 229172, 229247);
                    }
                    catch (InvalidRunspacePoolStateException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1477, 229265, 229344);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1477, 229265, 229344);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 229364, 229396);

                    CurrentlyRunningPipeline = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 227297, 229411);

                    System.Security.Principal.WindowsIdentity
                    f_1477_227449_227487(System.Management.Automation.PSInvocationSettings
                    this_param)
                    {
                        var return_v = this_param.WindowsIdentityToImpersonate;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 227449, 227487);
                        return return_v;
                    }


                    System.Security.Principal.WindowsIdentity
                    f_1477_227546_227584(System.Management.Automation.PSInvocationSettings
                    this_param)
                    {
                        var return_v = this_param.WindowsIdentityToImpersonate;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 227546, 227584);
                        return return_v;
                    }


                    int
                    f_1477_227546_227594(System.Security.Principal.WindowsIdentity
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 227546, 227594);
                        return 0;
                    }


                    int
                    f_1477_227714_227734(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        this_param.Close();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 227714, 227734);
                        return 0;
                    }


                    int
                    f_1477_227757_227778(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        this_param.Close();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 227757, 227778);
                        return 0;
                    }


                    int
                    f_1477_227801_227821(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        this_param.Close();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 227801, 227821);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_227850_227874()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 227850, 227874);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_228150_228174()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 228150, 228174);
                        return return_v;
                    }


                    System.IAsyncResult
                    f_1477_228248_228270()
                    {
                        var return_v = GetRunspaceAsyncResult;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 228248, 228270);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_228503_228527()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 228503, 228527);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1477_228503_228536(System.Management.Automation.Runspaces.Pipeline
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 228503, 228536);
                        return return_v;
                    }


                    int
                    f_1477_228503_228544(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        this_param.Close();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 228503, 228544);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_228821_228845()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 228821, 228845);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1477_228821_228854(System.Management.Automation.Runspaces.Pipeline
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 228821, 228854);
                        return return_v;
                    }


                    int
                    f_1477_228800_228855(System.Management.Automation.Runspaces.RunspacePool
                    this_param, System.Management.Automation.Runspaces.Runspace
                    runspace)
                    {
                        this_param.ReleaseRunspace(runspace);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 228800, 228855);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Pipeline
                    f_1477_228930_228954()
                    {
                        var return_v = CurrentlyRunningPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 228930, 228954);
                        return return_v;
                    }


                    int
                    f_1477_228930_228964(System.Management.Automation.Runspaces.Pipeline
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 228930, 228964);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 227297, 229411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 227297, 229411);
                }
            }

            static Worker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 214360, 229766);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 214360, 229766);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 214360, 229766);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 214360, 229766);

            object
            f_1477_214731_214743()
            {
                var return_v = new object();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 214731, 214743);
                return return_v;
            }


            System.Guid
            f_1477_215371_215387(System.Management.Automation.PowerShell
            this_param)
            {
                var return_v = this_param.InstanceId;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 215371, 215387);
                return return_v;
            }


            System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
            f_1477_215331_215408(System.Guid
            psInstanceId, System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
            storeToUse)
            {
                var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>(psInstanceId, storeToUse);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 215331, 215408);
                return return_v;
            }

        }

        internal static PowerShell FromPSObjectForRemoting(PSObject powerShellAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1477, 230582, 233391);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 230688, 230838) || true) && (powerShellAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 230688, 230838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 230754, 230823);

                    throw f_1477_230760_230822("powerShellAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 230688, 230838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 230854, 230897);

                Collection<PSCommand>
                extraCommands = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 230911, 231046);

                ReadOnlyPSMemberInfoCollection<PSPropertyInfo>
                properties = f_1477_230971_231045(f_1477_230971_231002(powerShellAsPSObject), RemoteDataNameStrings.ExtraCommands)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231062, 232178) || true) && (f_1477_231066_231082(properties) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 231062, 232178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231120, 231164);

                    extraCommands = f_1477_231136_231163();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231184, 232163);
                        foreach (PSObject extraCommandsAsPSObject in f_1477_231229_231335_I(f_1477_231229_231335(powerShellAsPSObject, RemoteDataNameStrings.ExtraCommands)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 231184, 232163);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231377, 231398);

                            PSCommand
                            cmd = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231420, 232097);
                                foreach (PSObject extraCommand in f_1477_231454_231558_I(f_1477_231454_231558(extraCommandsAsPSObject, RemoteDataNameStrings.Commands)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 231420, 232097);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231608, 231779);

                                    System.Management.Automation.Runspaces.Command
                                    command =
                                    f_1477_231694_231778(extraCommand)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231807, 232074) || true) && (cmd == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 231807, 232074);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 231880, 231909);

                                        cmd = f_1477_231886_231908(command);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 231807, 232074);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 231807, 232074);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232023, 232047);

                                        f_1477_232023_232046(cmd, command);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 231807, 232074);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 231420, 232097);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 678);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 678);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232121, 232144);

                            f_1477_232121_232143(
                                                extraCommands, cmd);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 231184, 232163);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 980);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 980);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 231062, 232178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232194, 232221);

                PSCommand
                psCommand = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232235, 232841);
                    foreach (PSObject commandAsPSObject in f_1477_232274_232375_I(f_1477_232274_232375(powerShellAsPSObject, RemoteDataNameStrings.Commands)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 232235, 232841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232409, 232577);

                        System.Management.Automation.Runspaces.Command
                        command =
                        f_1477_232487_232576(commandAsPSObject)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232597, 232826) || true) && (psCommand == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 232597, 232826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232660, 232695);

                            psCommand = f_1477_232672_232694(command);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 232597, 232826);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 232597, 232826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232777, 232807);

                            f_1477_232777_232806(psCommand, command);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 232597, 232826);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 232235, 232841);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232857, 232966);

                bool
                isNested = f_1477_232873_232965(powerShellAsPSObject, RemoteDataNameStrings.IsNested)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 232980, 233053);

                PowerShell
                shell = f_1477_232999_233052(isNested, psCommand, extraCommands)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 233067, 233189);

                shell.HistoryString = f_1477_233089_233188(powerShellAsPSObject, RemoteDataNameStrings.HistoryString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 233203, 233353);

                shell.RedirectShellErrorOutputPipe = f_1477_233240_233352(powerShellAsPSObject, RemoteDataNameStrings.RedirectShellErrorOutputPipe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 233367, 233380);

                return shell;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1477, 230582, 233391);

                System.Management.Automation.PSArgumentNullException
                f_1477_230760_230822(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 230760, 230822);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_230971_231002(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 230971, 231002);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_230971_231045(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    var return_v = this_param.Match(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 230971, 231045);
                    return return_v;
                }


                int
                f_1477_231066_231082(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 231066, 231082);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_231136_231163()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 231136, 231163);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1477_231229_231335(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.EnumerateListProperty<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 231229, 231335);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1477_231454_231558(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.EnumerateListProperty<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 231454, 231558);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_231694_231778(System.Management.Automation.PSObject
                commandAsPSObject)
                {
                    var return_v = System.Management.Automation.Runspaces.Command.FromPSObjectForRemoting(commandAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 231694, 231778);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_231886_231908(System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = new System.Management.Automation.PSCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 231886, 231908);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_232023_232046(System.Management.Automation.PSCommand
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232023, 232046);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1477_231454_231558_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 231454, 231558);
                    return return_v;
                }


                int
                f_1477_232121_232143(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param, System.Management.Automation.PSCommand
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232121, 232143);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1477_231229_231335_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 231229, 231335);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1477_232274_232375(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.EnumerateListProperty<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232274, 232375);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1477_232487_232576(System.Management.Automation.PSObject
                commandAsPSObject)
                {
                    var return_v = System.Management.Automation.Runspaces.Command.FromPSObjectForRemoting(commandAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232487, 232576);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_232672_232694(System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = new System.Management.Automation.PSCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232672, 232694);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1477_232777_232806(System.Management.Automation.PSCommand
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232777, 232806);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1477_232274_232375_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232274, 232375);
                    return return_v;
                }


                bool
                f_1477_232873_232965(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<bool>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232873, 232965);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1477_232999_233052(bool
                isNested, System.Management.Automation.PSCommand
                psCommand, System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                extraCommands)
                {
                    var return_v = PowerShell.Create(isNested, psCommand, extraCommands);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 232999, 233052);
                    return return_v;
                }


                string
                f_1477_233089_233188(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 233089, 233188);
                    return return_v;
                }


                bool
                f_1477_233240_233352(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<bool>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 233240, 233352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 230582, 233391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 230582, 233391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSObject ToPSObjectForRemoting()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 233648, 235506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 233714, 233784);

                PSObject
                powerShellAsPSObject = f_1477_233746_233783()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 233798, 233896);

                Version
                psRPVersion = f_1477_233820_233895(_rsConnection as RunspacePool)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 233974, 234809) || true) && (f_1477_233978_234009(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 233974, 234809);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234043, 234794) || true) && (f_1477_234047_234066(f_1477_234047_234060()) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 234043, 234794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234112, 234200);

                        List<PSObject>
                        extraCommandsAsListOfPSObjects = f_1477_234160_234199(f_1477_234179_234198(f_1477_234179_234192()))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234222, 234626);
                            foreach (PSCommand extraCommand in f_1477_234257_234270_I(f_1477_234257_234270()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 234222, 234626);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234320, 234373);

                                PSObject
                                obj = f_1477_234335_234372()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234401, 234535);

                                f_1477_234401_234534(f_1477_234401_234415(obj), f_1477_234420_234533(RemoteDataNameStrings.Commands, f_1477_234471_234532(this, f_1477_234497_234518(extraCommand), psRPVersion)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234563, 234603);

                                f_1477_234563_234602(
                                                        extraCommandsAsListOfPSObjects, obj);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 234222, 234626);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 405);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 405);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234650, 234775);

                        f_1477_234650_234774(f_1477_234650_234681(powerShellAsPSObject), f_1477_234686_234773(RemoteDataNameStrings.ExtraCommands, extraCommandsAsListOfPSObjects));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 234043, 234794);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 233974, 234809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234825, 234926);

                List<PSObject>
                commandsAsListOfPSObjects = f_1477_234868_234925(this, f_1477_234894_234911(f_1477_234894_234902()), psRPVersion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 234942, 235057);

                f_1477_234942_235056(f_1477_234942_234973(powerShellAsPSObject), f_1477_234978_235055(RemoteDataNameStrings.Commands, commandsAsListOfPSObjects));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235071, 235174);

                f_1477_235071_235173(f_1477_235071_235102(powerShellAsPSObject), f_1477_235107_235172(RemoteDataNameStrings.IsNested, f_1477_235158_235171(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235188, 235296);

                f_1477_235188_235295(f_1477_235188_235219(powerShellAsPSObject), f_1477_235224_235294(RemoteDataNameStrings.HistoryString, f_1477_235280_235293()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235310, 235453);

                f_1477_235310_235452(f_1477_235310_235341(powerShellAsPSObject), f_1477_235346_235451(RemoteDataNameStrings.RedirectShellErrorOutputPipe, f_1477_235417_235450(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235467, 235495);

                return powerShellAsPSObject;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 233648, 235506);

                System.Management.Automation.PSObject
                f_1477_233746_233783()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 233746, 233783);
                    return return_v;
                }


                System.Version
                f_1477_233820_233895(object
                rsPool)
                {
                    var return_v = RemotingEncoder.GetPSRemotingProtocolVersion((System.Management.Automation.Runspaces.RunspacePool)rsPool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 233820, 233895);
                    return return_v;
                }


                bool
                f_1477_233978_234009(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.ServerSupportsBatchInvocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 233978, 234009);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_234047_234060()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234047, 234060);
                    return return_v;
                }


                int
                f_1477_234047_234066(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234047, 234066);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_234179_234192()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234179, 234192);
                    return return_v;
                }


                int
                f_1477_234179_234198(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234179, 234198);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1477_234160_234199(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234160, 234199);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_234257_234270()
                {
                    var return_v = ExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234257, 234270);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1477_234335_234372()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234335, 234372);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_234401_234415(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234401, 234415);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_234497_234518(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234497, 234518);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1477_234471_234532(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.CommandCollection
                commands, System.Version
                psRPVersion)
                {
                    var return_v = this_param.CommandsAsListOfPSObjects(commands, psRPVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234471, 234532);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1477_234420_234533(string
                name, System.Collections.Generic.List<System.Management.Automation.PSObject>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234420, 234533);
                    return return_v;
                }


                int
                f_1477_234401_234534(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234401, 234534);
                    return 0;
                }


                int
                f_1477_234563_234602(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234563, 234602);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                f_1477_234257_234270_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234257, 234270);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_234650_234681(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234650, 234681);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1477_234686_234773(string
                name, System.Collections.Generic.List<System.Management.Automation.PSObject>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234686, 234773);
                    return return_v;
                }


                int
                f_1477_234650_234774(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234650, 234774);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1477_234894_234902()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234894, 234902);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_234894_234911(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234894, 234911);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1477_234868_234925(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.CommandCollection
                commands, System.Version
                psRPVersion)
                {
                    var return_v = this_param.CommandsAsListOfPSObjects(commands, psRPVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234868, 234925);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_234942_234973(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 234942, 234973);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1477_234978_235055(string
                name, System.Collections.Generic.List<System.Management.Automation.PSObject>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234978, 235055);
                    return return_v;
                }


                int
                f_1477_234942_235056(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 234942, 235056);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_235071_235102(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 235071, 235102);
                    return return_v;
                }


                bool
                f_1477_235158_235171(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 235158, 235171);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1477_235107_235172(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235107, 235172);
                    return return_v;
                }


                int
                f_1477_235071_235173(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235071, 235173);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_235188_235219(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 235188, 235219);
                    return return_v;
                }


                string
                f_1477_235280_235293()
                {
                    var return_v = HistoryString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 235280, 235293);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1477_235224_235294(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235224, 235294);
                    return return_v;
                }


                int
                f_1477_235188_235295(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235188, 235295);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1477_235310_235341(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 235310, 235341);
                    return return_v;
                }


                bool
                f_1477_235417_235450(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.RedirectShellErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 235417, 235450);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1477_235346_235451(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235346, 235451);
                    return return_v;
                }


                int
                f_1477_235310_235452(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235310, 235452);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 233648, 235506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 233648, 235506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<PSObject> CommandsAsListOfPSObjects(CommandCollection commands, Version psRPVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 235518, 235951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235640, 235718);

                List<PSObject>
                commandsAsListOfPSObjects = f_1477_235683_235717(f_1477_235702_235716(commands))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235732, 235891);
                    foreach (Command command in f_1477_235760_235768_I(commands))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 235732, 235891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235802, 235876);

                        f_1477_235802_235875(commandsAsListOfPSObjects, f_1477_235832_235874(command, psRPVersion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 235732, 235891);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 1, 160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 1, 160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 235907, 235940);

                return commandsAsListOfPSObjects;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 235518, 235951);

                int
                f_1477_235702_235716(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 235702, 235716);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1477_235683_235717(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235683, 235717);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1477_235832_235874(System.Management.Automation.Runspaces.Command
                this_param, System.Version
                psRPVersion)
                {
                    var return_v = this_param.ToPSObjectForRemoting(psRPVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235832, 235874);
                    return return_v;
                }


                int
                f_1477_235802_235875(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235802, 235875);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1477_235760_235768_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 235760, 235768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 235518, 235951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 235518, 235951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SuspendIncomingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 236140, 236512);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236200, 236313) || true) && (f_1477_236204_236220() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 236200, 236313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236262, 236298);

                    throw f_1477_236268_236297();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 236200, 236313);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236329, 236501) || true) && (f_1477_236333_236370(f_1477_236333_236349()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 236329, 236501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236412, 236486);

                    f_1477_236412_236485(f_1477_236412_236466(f_1477_236412_236449(f_1477_236412_236428())), true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 236329, 236501);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 236140, 236512);

                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_236204_236220()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236204, 236220);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1477_236268_236297()
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 236268, 236297);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_236333_236349()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236333, 236349);
                    return return_v;
                }


                System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                f_1477_236333_236370(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236333, 236370);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_236412_236428()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236412, 236428);
                    return return_v;
                }


                System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                f_1477_236412_236449(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236412, 236449);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
                f_1477_236412_236466(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                this_param)
                {
                    var return_v = this_param.TransportManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236412, 236466);
                    return return_v;
                }


                int
                f_1477_236412_236485(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
                this_param, bool
                debuggerSuspend)
                {
                    this_param.SuspendQueue(debuggerSuspend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 236412, 236485);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 236140, 236512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 236140, 236512);
            }
        }

        internal void ResumeIncomingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 236627, 236993);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236686, 236799) || true) && (f_1477_236690_236706() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 236686, 236799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236748, 236784);

                    throw f_1477_236754_236783();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 236686, 236799);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236815, 236982) || true) && (f_1477_236819_236856(f_1477_236819_236835()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 236815, 236982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 236898, 236967);

                    f_1477_236898_236966(f_1477_236898_236952(f_1477_236898_236935(f_1477_236898_236914())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 236815, 236982);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 236627, 236993);

                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_236690_236706()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236690, 236706);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1477_236754_236783()
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 236754, 236783);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_236819_236835()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236819, 236835);
                    return return_v;
                }


                System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                f_1477_236819_236856(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236819, 236856);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_236898_236914()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236898, 236914);
                    return return_v;
                }


                System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                f_1477_236898_236935(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236898, 236935);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
                f_1477_236898_236952(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                this_param)
                {
                    var return_v = this_param.TransportManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 236898, 236952);
                    return return_v;
                }


                int
                f_1477_236898_236966(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
                this_param)
                {
                    this_param.ResumeQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 236898, 236966);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 236627, 236993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 236627, 236993);
            }
        }

        internal void WaitForServicingComplete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 237245, 237842);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 237310, 237423) || true) && (f_1477_237314_237330() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 237310, 237423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 237372, 237408);

                    throw f_1477_237378_237407();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 237310, 237423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 237439, 237831) || true) && (f_1477_237443_237480(f_1477_237443_237459()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 237439, 237831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 237522, 237536);

                    int
                    count = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 237554, 237816) || true) && (++count < 2 && (DynAbs.Tracing.TraceSender.Expression_True(1477, 237561, 237666) && f_1477_237600_237666(f_1477_237600_237654(f_1477_237600_237637(f_1477_237600_237616())))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 237554, 237816);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 237770, 237797);

                            f_1477_237770_237796(50);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 237554, 237816);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1477, 237554, 237816);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1477, 237554, 237816);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 237439, 237831);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 237245, 237842);

                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_237314_237330()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 237314, 237330);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1477_237378_237407()
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 237378, 237407);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_237443_237459()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 237443, 237459);
                    return return_v;
                }


                System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                f_1477_237443_237480(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 237443, 237480);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                f_1477_237600_237616()
                {
                    var return_v = RemotePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 237600, 237616);
                    return return_v;
                }


                System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                f_1477_237600_237637(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 237600, 237637);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
                f_1477_237600_237654(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
                this_param)
                {
                    var return_v = this_param.TransportManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 237600, 237654);
                    return return_v;
                }


                bool
                f_1477_237600_237666(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
                this_param)
                {
                    var return_v = this_param.IsServicing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 237600, 237666);
                    return return_v;
                }


                int
                f_1477_237770_237796(int
                millisecondsTimeout)
                {
                    Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 237770, 237796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 237245, 237842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 237245, 237842);
            }
        }

        static PowerShell()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 18488, 241267);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 18488, 241267);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 18488, 241267);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 18488, 241267);

        object
        f_1477_19306_19318()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 19306, 19318);
            return return_v;
        }


        int
        f_1477_20607_20662(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 20607, 20662);
            return 0;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
        f_1477_20710_20737()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 20710, 20737);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1477_20986_21013(System.Management.Automation.RemoteRunspace
        this_param)
        {
            var return_v = this_param.RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 20986, 21013);
            return return_v;
        }


        System.Management.Automation.PSInvocationStateInfo
        f_1477_21107_21168(System.Management.Automation.PSInvocationState
        state, System.Exception
        reason)
        {
            var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 21107, 21168);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        f_1477_21271_21306()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 21271, 21306);
            return return_v;
        }


        System.Guid
        f_1477_21409_21419()
        {
            var return_v = InstanceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 21409, 21419);
            return return_v;
        }


        System.Management.Automation.PSInformationalBuffers
        f_1477_21382_21420(System.Guid
        psInstanceId)
        {
            var return_v = new System.Management.Automation.PSInformationalBuffers(psInstanceId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 21382, 21420);
            return return_v;
        }


        System.Management.Automation.PSDataStreams
        f_1477_21445_21468(System.Management.Automation.PowerShell
        powershell)
        {
            var return_v = new System.Management.Automation.PSDataStreams(powershell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 21445, 21468);
            return return_v;
        }


        int
        f_1477_21565_21655(Microsoft.PowerShell.Telemetry.TelemetryType
        metricId, string
        data)
        {
            ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 21565, 21655);
            return 0;
        }


        static System.Management.Automation.PSCommand
        f_1477_22168_22183()
        {
            var return_v = new System.Management.Automation.PSCommand();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 22168, 22183);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
        f_1477_22245_22272()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 22245, 22272);
            return return_v;
        }


        string
        f_1477_22341_22363(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
        this_param)
        {
            var return_v = this_param.Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 22341, 22363);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1477_22330_22364(System.Management.Automation.PowerShell
        this_param, string
        cmdlet)
        {
            var return_v = this_param.AddCommand(cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 22330, 22364);
            return return_v;
        }


        System.Guid
        f_1477_22535_22560(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
        this_param)
        {
            var return_v = this_param.CommandId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 22535, 22560);
            return return_v;
        }


        System.Management.Automation.PSInvocationStateInfo
        f_1477_22599_22662(System.Management.Automation.PSInvocationState
        state, System.Exception
        reason)
        {
            var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 22599, 22662);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1477_22818_22861(System.Management.Automation.RemoteRunspace
        this_param)
        {
            var return_v = this_param.RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 22818, 22861);
            return return_v;
        }


        int
        f_1477_23036_23104(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 23036, 23104);
            return 0;
        }


        System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        f_1477_23171_23211(System.Management.Automation.Runspaces.RunspacePool
        this_param)
        {
            var return_v = this_param.RemoteRunspacePoolInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 23171, 23211);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        f_1477_23138_23212(System.Management.Automation.PowerShell
        shell, System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        runspacePool)
        {
            var return_v = new System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell(shell, runspacePool);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 23138, 23212);
            return return_v;
        }


        static System.Management.Automation.PSCommand
        f_1477_22168_22183_C(System.Management.Automation.PSCommand
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 22072, 23224);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
        f_1477_23668_23695()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 23668, 23695);
            return return_v;
        }


        System.Management.Automation.PSInvocationStateInfo
        f_1477_23860_23921(System.Management.Automation.PSInvocationState
        state, System.Exception
        reason)
        {
            var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 23860, 23921);
            return return_v;
        }


        System.Guid
        f_1477_23986_23996()
        {
            var return_v = InstanceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 23986, 23996);
            return return_v;
        }


        System.Management.Automation.PSInformationalBuffers
        f_1477_23959_23997(System.Guid
        psInstanceId)
        {
            var return_v = new System.Management.Automation.PSInformationalBuffers(psInstanceId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 23959, 23997);
            return return_v;
        }


        System.Management.Automation.PSDataStreams
        f_1477_24022_24045(System.Management.Automation.PowerShell
        powershell)
        {
            var return_v = new System.Management.Automation.PSDataStreams(powershell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 24022, 24045);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
        f_1477_24190_24218(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
        this_param)
        {
            var return_v = this_param.ObjectStore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 24190, 24218);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        f_1477_24367_24394(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
        this_param)
        {
            var return_v = this_param.ObjectStore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 24367, 24394);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        f_1477_24439_24478(System.Management.Automation.Runspaces.RunspacePool
        this_param)
        {
            var return_v = this_param.RemoteRunspacePoolInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 24439, 24478);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        f_1477_24572_24611(System.Management.Automation.Runspaces.RunspacePool
        this_param)
        {
            var return_v = this_param.RemoteRunspacePoolInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 24572, 24611);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        f_1477_24539_24612(System.Management.Automation.PowerShell
        shell, System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        runspacePool)
        {
            var return_v = new System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell(shell, runspacePool);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 24539, 24612);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>
        f_1477_25551_25578()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSCommand>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 25551, 25578);
            return return_v;
        }


        System.Management.Automation.PSCommand
        f_1477_25649_25664()
        {
            var return_v = new System.Management.Automation.PSCommand();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 25649, 25664);
            return return_v;
        }


        string
        f_1477_25773_25795(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
        this_param)
        {
            var return_v = this_param.Command;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 25773, 25795);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1477_25762_25796(System.Management.Automation.PowerShell
        this_param, string
        cmdlet)
        {
            var return_v = this_param.AddCommand(cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 25762, 25796);
            return return_v;
        }


        System.Guid
        f_1477_25967_25992(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
        this_param)
        {
            var return_v = this_param.CommandId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 25967, 25992);
            return return_v;
        }


        System.Management.Automation.PSInvocationStateInfo
        f_1477_26031_26094(System.Management.Automation.PSInvocationState
        state, System.Exception
        reason)
        {
            var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 26031, 26094);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        f_1477_26163_26202(System.Management.Automation.Runspaces.RunspacePool
        this_param)
        {
            var return_v = this_param.RemoteRunspacePoolInternal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 26163, 26202);
            return return_v;
        }


        System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        f_1477_26130_26203(System.Management.Automation.PowerShell
        shell, System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
        runspacePool)
        {
            var return_v = new System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell(shell, runspacePool);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 26130, 26203);
            return return_v;
        }


        static System.Management.Automation.Internal.ObjectStreamBase
        f_1477_25457_25468_C(System.Management.Automation.Internal.ObjectStreamBase
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1477, 25251, 26215);
            return return_v;
        }

    }
    public sealed class PSDataStreams
    {
        internal PSDataStreams(PowerShell powershell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 241574, 241680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247955, 247966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 241644, 241669);

                _powershell = powershell;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 241574, 241680);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 241574, 241680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 241574, 241680);
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        public PSDataCollection<ErrorRecord> Error
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 242503, 242585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 242539, 242570);

                    return f_1477_242546_242569(_powershell);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 242503, 242585);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                    f_1477_242546_242569(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.ErrorBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 242546, 242569);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 242270, 242695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 242270, 242695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 242601, 242684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 242637, 242669);

                    _powershell.ErrorBuffer = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 242601, 242684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 242270, 242695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 242270, 242695);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        public PSDataCollection<ProgressRecord> Progress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 243422, 243507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 243458, 243492);

                    return f_1477_243465_243491(_powershell);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 243422, 243507);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                    f_1477_243465_243491(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.ProgressBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 243465, 243491);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 243183, 243620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 243183, 243620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 243523, 243609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 243559, 243594);

                    _powershell.ProgressBuffer = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 243523, 243609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 243183, 243620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 243183, 243620);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        public PSDataCollection<VerboseRecord> Verbose
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 244344, 244428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 244380, 244413);

                    return f_1477_244387_244412(_powershell);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 244344, 244428);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                    f_1477_244387_244412(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.VerboseBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 244387, 244412);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 244107, 244540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 244107, 244540);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 244444, 244529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 244480, 244514);

                    _powershell.VerboseBuffer = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 244444, 244529);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 244107, 244540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 244107, 244540);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        public PSDataCollection<DebugRecord> Debug
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 245256, 245338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 245292, 245323);

                    return f_1477_245299_245322(_powershell);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 245256, 245338);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                    f_1477_245299_245322(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.DebugBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 245299, 245322);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 245023, 245448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 245023, 245448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 245354, 245437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 245390, 245422);

                    _powershell.DebugBuffer = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 245354, 245437);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 245023, 245448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 245023, 245448);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        public PSDataCollection<WarningRecord> Warning
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 246292, 246376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 246328, 246361);

                    return f_1477_246335_246360(_powershell);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 246292, 246376);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                    f_1477_246335_246360(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.WarningBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 246335, 246360);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 246055, 246488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 246055, 246488);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 246392, 246477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 246428, 246462);

                    _powershell.WarningBuffer = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 246392, 246477);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 246055, 246488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 246055, 246488);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "We want to allow callers to change the backing store.")]
        public PSDataCollection<InformationRecord> Information
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 247344, 247432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247380, 247417);

                    return f_1477_247387_247416(_powershell);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 247344, 247432);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                    f_1477_247387_247416(System.Management.Automation.PowerShell
                    this_param)
                    {
                        var return_v = this_param.InformationBuffer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 247387, 247416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 247099, 247548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 247099, 247548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 247448, 247537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247484, 247522);

                    _powershell.InformationBuffer = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 247448, 247537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 247099, 247548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 247099, 247548);
                }
            }
        }

        public void ClearStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 247665, 247924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247716, 247735);

                f_1477_247716_247734(f_1477_247716_247726(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247749, 247771);

                f_1477_247749_247770(f_1477_247749_247762(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247785, 247806);

                f_1477_247785_247805(f_1477_247785_247797(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247820, 247845);

                f_1477_247820_247844(f_1477_247820_247836(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247859, 247878);

                f_1477_247859_247877(f_1477_247859_247869(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 247892, 247913);

                f_1477_247892_247912(f_1477_247892_247904(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 247665, 247924);

                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1477_247716_247726(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 247716, 247726);
                    return return_v;
                }


                int
                f_1477_247716_247734(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 247716, 247734);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1477_247749_247762(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 247749, 247762);
                    return return_v;
                }


                int
                f_1477_247749_247770(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 247749, 247770);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1477_247785_247797(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 247785, 247797);
                    return return_v;
                }


                int
                f_1477_247785_247805(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 247785, 247805);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1477_247820_247836(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 247820, 247836);
                    return return_v;
                }


                int
                f_1477_247820_247844(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 247820, 247844);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1477_247859_247869(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 247859, 247869);
                    return return_v;
                }


                int
                f_1477_247859_247877(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 247859, 247877);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1477_247892_247904(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 247892, 247904);
                    return return_v;
                }


                int
                f_1477_247892_247912(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 247892, 247912);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 247665, 247924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 247665, 247924);
            }
        }

        private PowerShell _powershell;

        static PSDataStreams()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 241368, 247974);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 241368, 247974);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 241368, 247974);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 241368, 247974);
    }
    internal class PowerShellStopper : IDisposable
    {
        private PipelineBase _pipeline;

        private PowerShell _powerShell;

        private EventHandler<PipelineStateEventArgs> _eventHandler;

        internal PowerShellStopper(ExecutionContext context, PowerShell powerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1477, 248751, 249790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 248619, 248628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 248658, 248669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 248725, 248738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250157, 250168);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 248851, 248962) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 248851, 248962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 248904, 248947);

                    throw f_1477_248910_248946("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 248851, 248962);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 248978, 249095) || true) && (powerShell == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 248978, 249095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 249034, 249080);

                    throw f_1477_249040_249079("powerShell");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 248978, 249095);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 249111, 249136);

                _powerShell = powerShell;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 249152, 249779) || true) && ((f_1477_249157_249188(context) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 249156, 249274) && (f_1477_249219_249265(f_1477_249219_249250(context)) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 249156, 249369) && (f_1477_249296_249360(f_1477_249296_249342(f_1477_249296_249327(context))) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 249156, 249478) && (f_1477_249391_249469(f_1477_249391_249455(f_1477_249391_249437(f_1477_249391_249422(context)))) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 249152, 249779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 249512, 249597);

                    _eventHandler = new EventHandler<PipelineStateEventArgs>(LocalPipeline_StateChanged);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 249615, 249706);

                    _pipeline = f_1477_249627_249705(f_1477_249627_249691(f_1477_249627_249673(f_1477_249627_249658(context))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 249724, 249764);

                    _pipeline.StateChanged += _eventHandler;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 249152, 249779);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1477, 248751, 249790);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 248751, 249790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 248751, 249790);
            }
        }

        private void LocalPipeline_StateChanged(object sender, PipelineStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 249802, 250132);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 249907, 250121) || true) && ((f_1477_249912_249937(f_1477_249912_249931(e)) == PipelineState.Stopping) && (DynAbs.Tracing.TraceSender.Expression_True(1477, 249911, 250053) && (f_1477_249986_250023(f_1477_249986_250017(_powerShell)) == PSInvocationState.Running)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 249907, 250121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250087, 250106);

                    f_1477_250087_250105(_powerShell);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 249907, 250121);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 249802, 250132);

                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1477_249912_249931(System.Management.Automation.Runspaces.PipelineStateEventArgs
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249912, 249931);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1477_249912_249937(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249912, 249937);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1477_249986_250017(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249986, 250017);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1477_249986_250023(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249986, 250023);
                    return return_v;
                }


                int
                f_1477_250087_250105(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 250087, 250105);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 249802, 250132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 249802, 250132);
            }
        }

        private bool _isDisposed;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1477, 250181, 250555);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250227, 250544) || true) && (!_isDisposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 250227, 250544);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250277, 250446) || true) && (_eventHandler != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1477, 250277, 250446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250344, 250384);

                        _pipeline.StateChanged -= _eventHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250406, 250427);

                        _eventHandler = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 250277, 250446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250466, 250492);

                    f_1477_250466_250491(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1477, 250510, 250529);

                    _isDisposed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1477, 250227, 250544);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1477, 250181, 250555);

                int
                f_1477_250466_250491(System.Management.Automation.PowerShellStopper
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 250466, 250491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1477, 250181, 250555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 250181, 250555);
            }
        }

        static PowerShellStopper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1477, 248535, 250562);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1477, 248535, 250562);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1477, 248535, 250562);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1477, 248535, 250562);

        System.ArgumentNullException
        f_1477_248910_248946(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 248910, 248946);
            return return_v;
        }


        System.ArgumentNullException
        f_1477_249040_249079(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1477, 249040, 249079);
            return return_v;
        }


        System.Management.Automation.CommandProcessorBase
        f_1477_249157_249188(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CurrentCommandProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249157, 249188);
            return return_v;
        }


        System.Management.Automation.CommandProcessorBase
        f_1477_249219_249250(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CurrentCommandProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249219, 249250);
            return return_v;
        }


        System.Management.Automation.MshCommandRuntime
        f_1477_249219_249265(System.Management.Automation.CommandProcessorBase
        this_param)
        {
            var return_v = this_param.CommandRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249219, 249265);
            return return_v;
        }


        System.Management.Automation.CommandProcessorBase
        f_1477_249296_249327(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CurrentCommandProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249296, 249327);
            return return_v;
        }


        System.Management.Automation.MshCommandRuntime
        f_1477_249296_249342(System.Management.Automation.CommandProcessorBase
        this_param)
        {
            var return_v = this_param.CommandRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249296, 249342);
            return return_v;
        }


        System.Management.Automation.Internal.PipelineProcessor
        f_1477_249296_249360(System.Management.Automation.MshCommandRuntime
        this_param)
        {
            var return_v = this_param.PipelineProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249296, 249360);
            return return_v;
        }


        System.Management.Automation.CommandProcessorBase
        f_1477_249391_249422(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CurrentCommandProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249391, 249422);
            return return_v;
        }


        System.Management.Automation.MshCommandRuntime
        f_1477_249391_249437(System.Management.Automation.CommandProcessorBase
        this_param)
        {
            var return_v = this_param.CommandRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249391, 249437);
            return return_v;
        }


        System.Management.Automation.Internal.PipelineProcessor
        f_1477_249391_249455(System.Management.Automation.MshCommandRuntime
        this_param)
        {
            var return_v = this_param.PipelineProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249391, 249455);
            return return_v;
        }


        System.Management.Automation.Runspaces.LocalPipeline
        f_1477_249391_249469(System.Management.Automation.Internal.PipelineProcessor
        this_param)
        {
            var return_v = this_param.LocalPipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249391, 249469);
            return return_v;
        }


        System.Management.Automation.CommandProcessorBase
        f_1477_249627_249658(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CurrentCommandProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249627, 249658);
            return return_v;
        }


        System.Management.Automation.MshCommandRuntime
        f_1477_249627_249673(System.Management.Automation.CommandProcessorBase
        this_param)
        {
            var return_v = this_param.CommandRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249627, 249673);
            return return_v;
        }


        System.Management.Automation.Internal.PipelineProcessor
        f_1477_249627_249691(System.Management.Automation.MshCommandRuntime
        this_param)
        {
            var return_v = this_param.PipelineProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249627, 249691);
            return return_v;
        }


        System.Management.Automation.Runspaces.LocalPipeline
        f_1477_249627_249705(System.Management.Automation.Internal.PipelineProcessor
        this_param)
        {
            var return_v = this_param.LocalPipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1477, 249627, 249705);
            return return_v;
        }

    }
}
