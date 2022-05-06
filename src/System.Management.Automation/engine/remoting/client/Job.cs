// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

// Stops compiler from warning about unknown warnings
#pragma warning disable 1634, 1691

namespace System.Management.Automation
{
    /// <summary>
    /// Enumeration for job status values. Indicates the status
    /// of the result object.
    /// </summary>
    public enum JobState
    {
        /// <summary>
        /// Execution of command in job not started.
        /// </summary>
        NotStarted = 0,

        /// <summary>
        /// Execution of command in progress.
        /// </summary>
        Running = 1,

        /// <summary>
        /// Execution of command completed in all
        /// computernames/runspaces.
        /// </summary>
        Completed = 2,

        /// <summary>
        /// An error was encountered when trying to executed
        /// command in one or more computernames/runspaces.
        /// </summary>
        Failed = 3,

        /// <summary>
        /// Command execution is cancelled (stopped) in one or more
        /// computernames/runspaces.
        /// </summary>
        Stopped = 4,

        /// <summary>
        /// Command execution is blocked (on user input host calls etc)
        /// </summary>
        Blocked = 5,

        /// <summary>
        /// The job has been suspended.
        /// </summary>
        Suspended = 6,

        /// <summary>
        /// The job is a remote job and has been disconnected from the server.
        /// </summary>
        Disconnected = 7,

        /// <summary>
        /// Suspend is in progress.
        /// </summary>
        Suspending = 8,

        /// <summary>
        /// Stop is in progress.
        /// </summary>
        Stopping = 9,

        /// <summary>
        /// Script execution is halted in a debugger stop.
        /// </summary>
        AtBreakpoint = 10
    }
    [Serializable]
    public class InvalidJobStateException : SystemException
    {
        public InvalidJobStateException()
        : base(
        f_1573_3026_3165_C(f_1573_3026_3165(f_1573_3105_3150())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 2948, 3198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 6750, 6764);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 2948, 3198);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 2948, 3198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 2948, 3198);
            }
        }

        public InvalidJobStateException(string message)
        : base(f_1573_3531_3538_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 3463, 3561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 6750, 6764);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 3463, 3561);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 3463, 3561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 3463, 3561);
            }
        }

        public InvalidJobStateException(string message, Exception innerException)
        : base(f_1573_4056_4063_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 3962, 4102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 6750, 6764);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 3962, 4102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 3962, 4102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 3962, 4102);
            }
        }

        public InvalidJobStateException(JobState currentState, string actionMessage)
        : base(
        f_1573_4678_4847_C(f_1573_4678_4847(f_1573_4757_4803(), currentState, actionMessage)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 4557, 4920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 6750, 6764);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 4883, 4909);

                _currState = currentState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 4557, 4920);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 4557, 4920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 4557, 4920);
            }
        }

        internal InvalidJobStateException(JobState currentState)
        : base(
        f_1573_5279_5418_C(f_1573_5279_5418(f_1573_5358_5403())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 5178, 5491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 6750, 6764);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 5454, 5480);

                _currState = currentState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 5178, 5491);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 5178, 5491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 5178, 5491);
            }
        }

        protected
                InvalidJobStateException(SerializationInfo info, StreamingContext context)
        : base(f_1573_6303_6307_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 6189, 6339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 6750, 6764);
                this._currState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 6189, 6339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 6189, 6339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 6189, 6339);
            }
        }

        public JobState CurrentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 6516, 6585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 6552, 6570);

                    return _currState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 6516, 6585);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 6463, 6596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 6463, 6596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [NonSerialized]
        private JobState _currState;

        static InvalidJobStateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 2736, 6772);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 2736, 6772);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 2736, 6772);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 2736, 6772);

        static string
        f_1573_3105_3150()
        {
            var return_v = RemotingErrorIdStrings.InvalidJobStateGeneral
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 3105, 3150);
            return return_v;
        }


        static string
        f_1573_3026_3165(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 3026, 3165);
            return return_v;
        }


        static string
        f_1573_3026_3165_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 2948, 3198);
            return return_v;
        }


        static string
        f_1573_3531_3538_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 3463, 3561);
            return return_v;
        }


        static string
        f_1573_4056_4063_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 3962, 4102);
            return return_v;
        }


        static string
        f_1573_4757_4803()
        {
            var return_v = RemotingErrorIdStrings.InvalidJobStateSpecific;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 4757, 4803);
            return return_v;
        }


        static string
        f_1573_4678_4847(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 4678, 4847);
            return return_v;
        }


        static string
        f_1573_4678_4847_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 4557, 4920);
            return return_v;
        }


        static string
        f_1573_5358_5403()
        {
            var return_v = RemotingErrorIdStrings.InvalidJobStateGeneral
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 5358, 5403);
            return return_v;
        }


        static string
        f_1573_5279_5418(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 5279, 5418);
            return return_v;
        }


        static string
        f_1573_5279_5418_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 5178, 5491);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1573_6303_6307_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 6189, 6339);
            return return_v;
        }

    }
    public sealed class JobStateInfo
    {
        public JobStateInfo(JobState state)
        : this(f_1573_7242_7247_C(state), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 7186, 7276);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 7186, 7276);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 7186, 7276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 7186, 7276);
            }
        }

        public JobStateInfo(JobState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 7608, 7741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 8468, 8498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 8836, 8868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 7686, 7700);

                State = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 7714, 7730);

                Reason = reason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 7608, 7741);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 7608, 7741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 7608, 7741);
            }
        }

        internal JobStateInfo(JobStateInfo jobStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 8044, 8198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 8468, 8498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 8836, 8868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 8117, 8144);

                State = f_1573_8125_8143(jobStateInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 8158, 8187);

                Reason = f_1573_8167_8186(jobStateInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 8044, 8198);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 8044, 8198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 8044, 8198);
            }
        }

        public JobState State { get; }

        public Exception Reason { get; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 9037, 9130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 9095, 9119);

                return f_1573_9102_9118(f_1573_9102_9107());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 9037, 9130);

                System.Management.Automation.JobState
                f_1573_9102_9107()
                {
                    var return_v = State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 9102, 9107);
                    return return_v;
                }


                string
                f_1573_9102_9118(System.Management.Automation.JobState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 9102, 9118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 9037, 9130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 9037, 9130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal JobStateInfo Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 9269, 9364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 9323, 9353);

                return f_1573_9330_9352(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 9269, 9364);

                System.Management.Automation.JobStateInfo
                f_1573_9330_9352(System.Management.Automation.JobStateInfo
                jobStateInfo)
                {
                    var return_v = new System.Management.Automation.JobStateInfo(jobStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 9330, 9352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 9269, 9364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 9269, 9364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static JobStateInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 6928, 9442);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 6928, 9442);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 6928, 9442);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 6928, 9442);

        static System.Management.Automation.JobState
        f_1573_7242_7247_C(System.Management.Automation.JobState
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 7186, 7276);
            return return_v;
        }


        System.Management.Automation.JobState
        f_1573_8125_8143(System.Management.Automation.JobStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 8125, 8143);
            return return_v;
        }


        System.Exception
        f_1573_8167_8186(System.Management.Automation.JobStateInfo
        this_param)
        {
            var return_v = this_param.Reason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 8167, 8186);
            return return_v;
        }

    }
    public sealed class JobStateEventArgs : EventArgs
    {
        public JobStateEventArgs(JobStateInfo jobStateInfo)
        : this(f_1573_9936_9948_C(jobStateInfo), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 9864, 9977);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 9864, 9977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 9864, 9977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 9864, 9977);
            }
        }

        public JobStateEventArgs(JobStateInfo jobStateInfo, JobStateInfo previousJobStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 10248, 10606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 10791, 10832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 10946, 10995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 10359, 10493) || true) && (jobStateInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 10359, 10493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 10417, 10478);

                    throw f_1573_10423_10477("jobStateInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 10359, 10493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 10509, 10537);

                JobStateInfo = jobStateInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 10551, 10595);

                PreviousJobStateInfo = previousJobStateInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 10248, 10606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 10248, 10606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 10248, 10606);
            }
        }

        public JobStateInfo JobStateInfo { get; }

        public JobStateInfo PreviousJobStateInfo { get; }

        static JobStateEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 9594, 11042);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 9594, 11042);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 9594, 11042);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 9594, 11042);

        static System.Management.Automation.JobStateInfo
        f_1573_9936_9948_C(System.Management.Automation.JobStateInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 9864, 9977);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1573_10423_10477(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 10423, 10477);
            return return_v;
        }

    }
    public sealed class JobIdentifier
    {
        internal JobIdentifier(int id, Guid instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 11304, 11570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 11582, 11619);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 11376, 11499) || true) && (id <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 11376, 11499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 11406, 11499);

                    f_1573_11406_11498("id", f_1573_11447_11493(), id);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 11376, 11499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 11513, 11521);

                Id = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 11535, 11559);

                InstanceId = instanceId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 11304, 11570);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 11304, 11570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 11304, 11570);
            }
        }

        internal int Id { get; private set; }

        internal Guid InstanceId { get; private set; }

        static JobIdentifier()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 11254, 11684);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 11254, 11684);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 11254, 11684);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 11254, 11684);

        string
        f_1573_11447_11493()
        {
            var return_v = RemotingErrorIdStrings.JobSessionIdLessThanOne;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 11447, 11493);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1573_11406_11498(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 11406, 11498);
            return return_v;
        }

    }

    /// <summary>
    /// Interface to expose a job debugger.
    /// </summary>
    public interface IJobDebugger
    {

        Debugger Debugger
        {
            get;
        }

        bool IsAsync
        {
            get;
            set;
        }
    }
    public abstract class Job : IDisposable
    {
        protected Job()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 12478, 12590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16865, 16904);
                this._finished = f_1573_16877_16904(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16932, 16937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16967, 16977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17013, 17038);
                this.syncObject = f_1573_17026_17038();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17179, 17228);
                this._results = f_1573_17190_17228();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17252, 17272);
                this._resultsOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17321, 17365);
                this._error = f_1573_17330_17365();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17389, 17407);
                this._errorOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17459, 17509);
                this._progress = f_1573_17471_17509();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17533, 17554);
                this._progressOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17605, 17653);
                this._verbose = f_1573_17616_17653();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17677, 17697);
                this._verboseOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17748, 17796);
                this._warning = f_1573_17759_17796();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17820, 17840);
                this._warningOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17889, 17933);
                this._debug = f_1573_17898_17933();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17957, 17975);
                this._debugOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18030, 18086);
                this._information = f_1573_18045_18086();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18110, 18134);
                this._informationOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18180, 18222);
                this._output = f_1573_18190_18222();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18246, 18265);
                this._outputOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18453, 18480);
                this._jobTypeName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18654, 18684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18789, 18884);
                this.JobStateInfo = f_1573_18846_18883(JobState.NotStarted);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20101, 20150);
                this.InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20318, 20340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 21715, 21775);
                this.PSBeginTime = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 21865, 21923);
                this.PSEndTime = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23222, 23271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23573, 23625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24252, 24295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27998, 28015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36080, 36097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57493, 57504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57716, 57733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57831, 57926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 12518, 12579);

                Id = f_1573_12523_12578(ref s_jobIdSeed);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 12478, 12590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 12478, 12590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 12478, 12590);
            }
        }

        protected Job(string command)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 12776, 12925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 12852, 12870);

                Command = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 12884, 12914);

                _name = f_1573_12892_12913(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 12776, 12925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 12776, 12925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 12776, 12925);
            }
        }

        protected Job(string command, string name)
        : this(f_1573_13248_13255_C(command))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 13185, 13385);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 13281, 13374) || true) && (!f_1573_13286_13312(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 13281, 13374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 13346, 13359);

                    _name = name;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 13281, 13374);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 13185, 13385);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 13185, 13385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 13185, 13385);
            }
        }

        protected Job(string command, string name, IList<Job> childJobs)
        : this(f_1573_13806_13813_C(command), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 13721, 13879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 13845, 13868);

                _childJobs = childJobs;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 13721, 13879);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 13721, 13879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 13721, 13879);
            }
        }

        protected Job(string command, string name, JobIdentifier token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 14423, 15160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16865, 16904);
                this._finished = f_1573_16877_16904(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16932, 16937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16967, 16977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17013, 17038);
                this.syncObject = f_1573_17026_17038();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17179, 17228);
                this._results = f_1573_17190_17228();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17252, 17272);
                this._resultsOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17321, 17365);
                this._error = f_1573_17330_17365();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17389, 17407);
                this._errorOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17459, 17509);
                this._progress = f_1573_17471_17509();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17533, 17554);
                this._progressOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17605, 17653);
                this._verbose = f_1573_17616_17653();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17677, 17697);
                this._verboseOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17748, 17796);
                this._warning = f_1573_17759_17796();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17820, 17840);
                this._warningOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17889, 17933);
                this._debug = f_1573_17898_17933();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 17957, 17975);
                this._debugOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18030, 18086);
                this._information = f_1573_18045_18086();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18110, 18134);
                this._informationOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18180, 18222);
                this._output = f_1573_18190_18222();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18246, 18265);
                this._outputOwner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18453, 18480);
                this._jobTypeName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18654, 18684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18789, 18884);
                this.JobStateInfo = f_1573_18846_18883(JobState.NotStarted);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20101, 20150);
                this.InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20318, 20340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 21715, 21775);
                this.PSBeginTime = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 21865, 21923);
                this.PSEndTime = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23222, 23271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23573, 23625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24252, 24295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27998, 28015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36080, 36097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57493, 57504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57716, 57733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57831, 57926);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14511, 14643) || true) && (token == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 14511, 14643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14547, 14643);

                    throw f_1573_14553_14642("token", f_1573_14601_14641());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 14511, 14643);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14657, 14836) || true) && (f_1573_14661_14669(token) > s_jobIdSeed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 14657, 14836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14717, 14821);

                    throw f_1573_14723_14820("token", f_1573_14767_14809(), f_1573_14811_14819(token));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 14657, 14836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14852, 14870);

                Command = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14886, 14900);

                Id = f_1573_14891_14899(token);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14914, 14944);

                InstanceId = f_1573_14927_14943(token);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 14960, 15149) || true) && (!f_1573_14965_14991(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 14960, 15149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 15025, 15038);

                    _name = name;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 14960, 15149);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 14960, 15149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 15104, 15134);

                    _name = f_1573_15112_15133(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 14960, 15149);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 14423, 15160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 14423, 15160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 14423, 15160);
            }
        }

        protected Job(string command, string name, Guid instanceId)
        : this(f_1573_15726_15733_C(command), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 15646, 15800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 15765, 15789);

                InstanceId = instanceId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 15646, 15800);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 15646, 15800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 15646, 15800);
            }
        }

        internal static string GetCommandTextFromInvocationInfo(InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1573, 15812, 16759);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 15923, 16010) || true) && (invocationInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 15923, 16010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 15983, 15995);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 15923, 16010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16026, 16085);

                IScriptExtent
                scriptExtent = f_1573_16055_16084(invocationInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16099, 16695) || true) && ((scriptExtent != null) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 16103, 16171) && (f_1573_16130_16162(scriptExtent) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 16103, 16240) && !f_1573_16176_16240(f_1573_16202_16239(f_1573_16202_16234(scriptExtent)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 16099, 16695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16274, 16365);

                    f_1573_16274_16364(f_1573_16285_16330(f_1573_16285_16317(scriptExtent)) > 0, "Column numbers start at 1");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16383, 16549);

                    f_1573_16383_16548(f_1573_16394_16439(f_1573_16394_16426(scriptExtent)) <= f_1573_16443_16487(f_1573_16443_16480(f_1573_16443_16475(scriptExtent))), "Column numbers are not greater than the length of a line");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16567, 16680);

                    return f_1573_16574_16679(f_1573_16574_16672(f_1573_16574_16611(f_1573_16574_16606(scriptExtent)), f_1573_16622_16667(f_1573_16622_16654(scriptExtent)) - 1));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 16099, 16695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 16711, 16748);

                return f_1573_16718_16747(invocationInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1573, 15812, 16759);

                System.Management.Automation.Language.IScriptExtent
                f_1573_16055_16084(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16055, 16084);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1573_16130_16162(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16130, 16162);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1573_16202_16234(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16202, 16234);
                    return return_v;
                }


                string
                f_1573_16202_16239(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16202, 16239);
                    return return_v;
                }


                bool
                f_1573_16176_16240(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 16176, 16240);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1573_16285_16317(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16285, 16317);
                    return return_v;
                }


                int
                f_1573_16285_16330(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16285, 16330);
                    return return_v;
                }


                int
                f_1573_16274_16364(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 16274, 16364);
                    return 0;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1573_16394_16426(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16394, 16426);
                    return return_v;
                }


                int
                f_1573_16394_16439(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16394, 16439);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1573_16443_16475(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16443, 16475);
                    return return_v;
                }


                string
                f_1573_16443_16480(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16443, 16480);
                    return return_v;
                }


                int
                f_1573_16443_16487(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16443, 16487);
                    return return_v;
                }


                int
                f_1573_16383_16548(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 16383, 16548);
                    return 0;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1573_16574_16606(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16574, 16606);
                    return return_v;
                }


                string
                f_1573_16574_16611(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16574, 16611);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1573_16622_16654(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16622, 16654);
                    return return_v;
                }


                int
                f_1573_16622_16667(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16622, 16667);
                    return return_v;
                }


                string
                f_1573_16574_16672(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 16574, 16672);
                    return return_v;
                }


                string
                f_1573_16574_16679(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 16574, 16679);
                    return return_v;
                }


                string
                f_1573_16718_16747(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 16718, 16747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 15812, 16759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 15812, 16759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ManualResetEvent _finished;

        private string _name;

        private IList<Job> _childJobs;

        internal readonly object syncObject;

        private PSDataCollection<PSStreamObject> _results;

        private bool _resultsOwner;

        private PSDataCollection<ErrorRecord> _error;

        private bool _errorOwner;

        private PSDataCollection<ProgressRecord> _progress;

        private bool _progressOwner;

        private PSDataCollection<VerboseRecord> _verbose;

        private bool _verboseOwner;

        private PSDataCollection<WarningRecord> _warning;

        private bool _warningOwner;

        private PSDataCollection<DebugRecord> _debug;

        private bool _debugOwner;

        private PSDataCollection<InformationRecord> _information;

        private bool _informationOwner;

        private PSDataCollection<PSObject> _output;

        private bool _outputOwner;

        private static int s_jobIdSeed;

        private string _jobTypeName;

        public string Command { get; }

        public JobStateInfo JobStateInfo { get; private set; }

        public WaitHandle Finished
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 19159, 19986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 19201, 19216);
                    lock (this.syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 19258, 19952) || true) && (_finished != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 19258, 19952);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 19329, 19346);

                            return _finished;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 19258, 19952);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 19258, 19952);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 19895, 19929);

                            return f_1573_19902_19928(true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 19258, 19952);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 19159, 19986);

                    System.Threading.ManualResetEvent
                    f_1573_19902_19928(bool
                    initialState)
                    {
                        var return_v = new System.Threading.ManualResetEvent(initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 19902, 19928);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 19108, 19997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 19108, 19997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Guid InstanceId { get; }

        public int Id { get; }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 20493, 20557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20529, 20542);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 20493, 20557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 20450, 20687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 20450, 20687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 20573, 20676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20609, 20629);

                    f_1573_20609_20628(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20647, 20661);

                    _name = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 20573, 20676);

                    int
                    f_1573_20609_20628(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertNotDisposed();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 20609, 20628);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 20450, 20687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 20450, 20687);
                }
            }
        }

        public IList<Job> ChildJobs
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 20857, 21254);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20893, 21201) || true) && (_childJobs == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 20893, 21201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 20963, 20973);
                        lock (syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 21023, 21159) || true) && (_childJobs == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 21023, 21159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 21103, 21132);

                                _childJobs = f_1573_21116_21131();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 21023, 21159);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 20893, 21201);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 21221, 21239);

                    return _childJobs;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 20857, 21254);

                    System.Collections.Generic.List<System.Management.Automation.Job>
                    f_1573_21116_21131()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 21116, 21131);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 20805, 21265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 20805, 21265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract string StatusMessage { get; }

        public abstract bool HasMoreData { get; }

        public DateTime? PSBeginTime { get; protected set; }

        public DateTime? PSEndTime { get; protected set; }

        public string PSJobTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 22062, 22090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22068, 22088);

                    return _jobTypeName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 22062, 22090);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 22010, 22237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 22010, 22237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 22106, 22226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22161, 22211);

                    _jobTypeName = value ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1573, 22176, 22210) ?? f_1573_22185_22210(f_1573_22185_22199(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 22106, 22226);

                    System.Type
                    f_1573_22185_22199(System.Management.Automation.Job
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 22185, 22199);
                        return return_v;
                    }


                    string
                    f_1573_22185_22210(System.Type
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 22185, 22210);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 22010, 22237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 22010, 22237);
                }
            }
        }

        internal PSDataCollection<PSStreamObject> Results
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 22578, 22645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22614, 22630);

                    return _results;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 22578, 22645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 22504, 23064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 22504, 23064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 22661, 23053);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22697, 22831) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 22697, 22831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22756, 22812);

                        throw f_1573_22762_22811("Results");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 22697, 22831);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22857, 22867);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22909, 22936);

                        f_1573_22909_22935(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 22958, 22980);

                        _resultsOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23002, 23019);

                        _results = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 22661, 23053);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_22762_22811(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 22762, 22811);
                        return return_v;
                    }


                    int
                    f_1573_22909_22935(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 22909, 22935);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 22504, 23064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 22504, 23064);
                }
            }
        }

        internal bool UsesResultsCollection { get; set; }

        internal bool SuppressOutputForwarding { get; set; }

        internal virtual void WriteObject(object outputObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 23637, 24006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23716, 23797);

                PSObject
                pso = (DynAbs.Tracing.TraceSender.Conditional_F1(1573, 23731, 23753) || (((outputObject == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1573, 23756, 23760)) || DynAbs.Tracing.TraceSender.Conditional_F3(1573, 23763, 23796))) ? null : f_1573_23763_23796(outputObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23811, 23832);

                f_1573_23811_23831(f_1573_23811_23822(this), pso);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23848, 23995) || true) && (f_1573_23852_23877_M(!SuppressOutputForwarding))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 23848, 23995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 23911, 23980);

                    f_1573_23911_23979(f_1573_23911_23923(this), f_1573_23928_23978(PSStreamObjectType.Output, pso));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 23848, 23995);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 23637, 24006);

                System.Management.Automation.PSObject
                f_1573_23763_23796(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 23763, 23796);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1573_23811_23822(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 23811, 23822);
                    return return_v;
                }


                int
                f_1573_23811_23831(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 23811, 23831);
                    return 0;
                }


                bool
                f_1573_23852_23877_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 23852, 23877);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_23911_23923(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 23911, 23923);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_23928_23978(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 23928, 23978);
                    return return_v;
                }


                int
                f_1573_23911_23979(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 23911, 23979);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 23637, 24006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 23637, 24006);
            }
        }

        internal bool PropagateThrows { get; set; }

        private void WriteError(Cmdlet cmdlet, ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 24307, 24703);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24395, 24585) || true) && (f_1573_24399_24419(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 24395, 24585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24453, 24508);

                    Exception
                    e = f_1573_24467_24507(errorRecord)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24526, 24570) || true) && (e != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 24526, 24570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24562, 24570);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 24526, 24570);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 24395, 24585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24601, 24647);

                errorRecord.PreserveInvocationInfoOnce = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24661, 24692);

                f_1573_24661_24691(cmdlet, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 24307, 24703);

                bool
                f_1573_24399_24419(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.PropagateThrows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 24399, 24419);
                    return return_v;
                }


                System.Exception
                f_1573_24467_24507(System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = GetExceptionFromErrorRecord(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 24467, 24507);
                    return return_v;
                }


                int
                f_1573_24661_24691(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 24661, 24691);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 24307, 24703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 24307, 24703);
            }
        }

        private static Exception GetExceptionFromErrorRecord(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1573, 24715, 25508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24817, 24895);

                RuntimeException
                runtimeException = f_1573_24853_24874(errorRecord) as RuntimeException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24909, 24968) || true) && (runtimeException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 24909, 24968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24956, 24968);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 24909, 24968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 24984, 25054);

                RemoteException
                remoteException = runtimeException as RemoteException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25068, 25126) || true) && (remoteException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 25068, 25126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25114, 25126);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 25068, 25126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25142, 25279);

                PSPropertyInfo
                wasThrownFromThrow =
                f_1573_25195_25278(f_1573_25195_25247(f_1573_25195_25236(remoteException)), "WasThrownFromThrowStatement")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25293, 25391) || true) && (wasThrownFromThrow == null || (DynAbs.Tracing.TraceSender.Expression_False(1573, 25297, 25360) || !((bool)f_1573_25335_25359(wasThrownFromThrow))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 25293, 25391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25379, 25391);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 25293, 25391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25407, 25459);

                runtimeException.WasThrownFromThrowStatement = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25473, 25497);

                return runtimeException;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1573, 24715, 25508);

                System.Exception
                f_1573_24853_24874(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 24853, 24874);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1573_25195_25236(System.Management.Automation.RemoteException
                this_param)
                {
                    var return_v = this_param.SerializedRemoteException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25195, 25236);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_25195_25247(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25195, 25247);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1573_25195_25278(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25195, 25278);
                    return return_v;
                }


                object
                f_1573_25335_25359(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25335, 25359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 24715, 25508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 24715, 25508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void WriteError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 25520, 26070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25602, 25625);

                f_1573_25602_25624(f_1573_25602_25607(), errorRecord);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25639, 25972) || true) && (f_1573_25643_25658())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 25639, 25972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25692, 25755);

                    Exception
                    exception = f_1573_25714_25754(errorRecord)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25773, 25957) || true) && (exception != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 25773, 25957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25836, 25909);

                        f_1573_25836_25908(f_1573_25836_25843(), f_1573_25848_25907(PSStreamObjectType.Exception, exception));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25931, 25938);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 25773, 25957);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 25639, 25972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 25988, 26059);

                f_1573_25988_26058(f_1573_25988_25995(), f_1573_26000_26057(PSStreamObjectType.Error, errorRecord));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 25520, 26070);

                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1573_25602_25607()
                {
                    var return_v = Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25602, 25607);
                    return return_v;
                }


                int
                f_1573_25602_25624(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 25602, 25624);
                    return 0;
                }


                bool
                f_1573_25643_25658()
                {
                    var return_v = PropagateThrows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25643, 25658);
                    return return_v;
                }


                System.Exception
                f_1573_25714_25754(System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = GetExceptionFromErrorRecord(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 25714, 25754);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_25836_25843()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25836, 25843);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_25848_25907(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Exception
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 25848, 25907);
                    return return_v;
                }


                int
                f_1573_25836_25908(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 25836, 25908);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_25988_25995()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 25988, 25995);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_26000_26057(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26000, 26057);
                    return return_v;
                }


                int
                f_1573_25988_26058(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 25988, 26058);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 25520, 26070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 25520, 26070);
            }
        }

        internal void WriteError(ErrorRecord errorRecord, out Exception exceptionThrownOnCmdletThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 26082, 26554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 26201, 26229);

                f_1573_26201_26228(f_1573_26201_26211(this), errorRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 26243, 26543);

                f_1573_26243_26542(this, delegate (Cmdlet cmdlet)
                        {
                            this.WriteError(cmdlet, errorRecord);
                            return null;
                        }, out exceptionThrownOnCmdletThread);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 26082, 26554);

                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1573_26201_26211(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 26201, 26211);
                    return return_v;
                }


                int
                f_1573_26201_26228(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26201, 26228);
                    return 0;
                }


                object
                f_1573_26243_26542(System.Management.Automation.Job
                this_param, System.Func<System.Management.Automation.Cmdlet, object>
                invokeCmdletMethodAndReturnResult, out System.Exception
                exceptionThrownOnCmdletThread)
                {
                    var return_v = this_param.InvokeCmdletMethodAndWaitForResults<object>(invokeCmdletMethodAndReturnResult, out exceptionThrownOnCmdletThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26243, 26542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 26082, 26554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 26082, 26554);
            }
        }

        internal virtual void WriteWarning(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 26566, 26785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 26641, 26686);

                f_1573_26641_26685(f_1573_26641_26653(this), f_1573_26658_26684(message));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 26700, 26774);

                f_1573_26700_26773(f_1573_26700_26712(this), f_1573_26717_26772(PSStreamObjectType.Warning, message));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 26566, 26785);

                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1573_26641_26653(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 26641, 26653);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1573_26658_26684(string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26658, 26684);
                    return return_v;
                }


                int
                f_1573_26641_26685(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param, System.Management.Automation.WarningRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26641, 26685);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_26700_26712(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 26700, 26712);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_26717_26772(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26717, 26772);
                    return return_v;
                }


                int
                f_1573_26700_26773(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26700, 26773);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 26566, 26785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 26566, 26785);
            }
        }

        internal virtual void WriteVerbose(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 26797, 27016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 26872, 26917);

                f_1573_26872_26916(f_1573_26872_26884(this), f_1573_26889_26915(message));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 26931, 27005);

                f_1573_26931_27004(f_1573_26931_26943(this), f_1573_26948_27003(PSStreamObjectType.Verbose, message));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 26797, 27016);

                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1573_26872_26884(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 26872, 26884);
                    return return_v;
                }


                System.Management.Automation.VerboseRecord
                f_1573_26889_26915(string
                message)
                {
                    var return_v = new System.Management.Automation.VerboseRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26889, 26915);
                    return return_v;
                }


                int
                f_1573_26872_26916(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param, System.Management.Automation.VerboseRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26872, 26916);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_26931_26943(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 26931, 26943);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_26948_27003(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26948, 27003);
                    return return_v;
                }


                int
                f_1573_26931_27004(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 26931, 27004);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 26797, 27016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 26797, 27016);
            }
        }

        internal virtual void WriteDebug(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 27028, 27239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27101, 27142);

                f_1573_27101_27141(f_1573_27101_27111(this), f_1573_27116_27140(message));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27156, 27228);

                f_1573_27156_27227(f_1573_27156_27168(this), f_1573_27173_27226(PSStreamObjectType.Debug, message));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 27028, 27239);

                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1573_27101_27111(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27101, 27111);
                    return return_v;
                }


                System.Management.Automation.DebugRecord
                f_1573_27116_27140(string
                message)
                {
                    var return_v = new System.Management.Automation.DebugRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27116, 27140);
                    return return_v;
                }


                int
                f_1573_27101_27141(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param, System.Management.Automation.DebugRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27101, 27141);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_27156_27168(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27156, 27168);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_27173_27226(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27173, 27226);
                    return return_v;
                }


                int
                f_1573_27156_27227(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27156, 27227);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 27028, 27239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 27028, 27239);
            }
        }

        internal virtual void WriteProgress(ProgressRecord progressRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 27251, 27713);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27342, 27566) || true) && ((f_1573_27347_27378(progressRecord) == (-1)) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 27346, 27418) && (_parentActivityId != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 27342, 27566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27452, 27551);

                    progressRecord = new ProgressRecord(progressRecord) { ParentActivityId = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1573_27525_27548(_parentActivityId), 1573, 27469, 27550) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 27342, 27566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27582, 27611);

                f_1573_27582_27610(f_1573_27582_27590(), progressRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27625, 27702);

                f_1573_27625_27701(f_1573_27625_27632(), f_1573_27637_27700(PSStreamObjectType.Progress, progressRecord));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 27251, 27713);

                int
                f_1573_27347_27378(System.Management.Automation.ProgressRecord
                this_param)
                {
                    var return_v = this_param.ParentActivityId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27347, 27378);
                    return return_v;
                }


                int
                f_1573_27525_27548(System.Lazy<int>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27525, 27548);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1573_27582_27590()
                {
                    var return_v = Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27582, 27590);
                    return return_v;
                }


                int
                f_1573_27582_27610(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param, System.Management.Automation.ProgressRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27582, 27610);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_27625_27632()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27625, 27632);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_27637_27700(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ProgressRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27637, 27700);
                    return return_v;
                }


                int
                f_1573_27625_27701(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27625, 27701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 27251, 27713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 27251, 27713);
            }
        }

        internal virtual void WriteInformation(InformationRecord informationRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 27725, 27968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27825, 27860);

                f_1573_27825_27859(f_1573_27825_27836(), informationRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 27874, 27957);

                f_1573_27874_27956(f_1573_27874_27881(), f_1573_27886_27955(PSStreamObjectType.Information, informationRecord));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 27725, 27968);

                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1573_27825_27836()
                {
                    var return_v = Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27825, 27836);
                    return return_v;
                }


                int
                f_1573_27825_27859(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param, System.Management.Automation.InformationRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27825, 27859);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_27874_27881()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 27874, 27881);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_27886_27955(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.InformationRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27886, 27955);
                    return return_v;
                }


                int
                f_1573_27874_27956(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 27874, 27956);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 27725, 27968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 27725, 27968);
            }
        }

        private Lazy<int> _parentActivityId;

        internal void SetParentActivityIdGetter(Func<int> parentActivityIdGetter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 28026, 28305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 28124, 28222);

                f_1573_28124_28221(parentActivityIdGetter != null, "Caller should verify parentActivityIdGetter != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 28236, 28294);

                _parentActivityId = f_1573_28256_28293(parentActivityIdGetter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 28026, 28305);

                int
                f_1573_28124_28221(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 28124, 28221);
                    return 0;
                }


                System.Lazy<int>
                f_1573_28256_28293(System.Func<int>
                valueFactory)
                {
                    var return_v = new System.Lazy<int>(valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 28256, 28293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 28026, 28305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 28026, 28305);
            }
        }

        internal bool ShouldContinue(string query, string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 28317, 28543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 28400, 28440);

                Exception
                exceptionThrownOnCmdletThread
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 28454, 28532);

                return f_1573_28461_28531(this, query, caption, out exceptionThrownOnCmdletThread);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 28317, 28543);

                bool
                f_1573_28461_28531(System.Management.Automation.Job
                this_param, string
                query, string
                caption, out System.Exception
                exceptionThrownOnCmdletThread)
                {
                    var return_v = this_param.ShouldContinue(query, caption, out exceptionThrownOnCmdletThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 28461, 28531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 28317, 28543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 28317, 28543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ShouldContinue(string query, string caption, out Exception exceptionThrownOnCmdletThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 28555, 28903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 28683, 28858);

                bool
                methodResult = f_1573_28703_28857(this, cmdlet => cmdlet.ShouldContinue(query, caption), out exceptionThrownOnCmdletThread)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 28872, 28892);

                return methodResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 28555, 28903);

                bool
                f_1573_28703_28857(System.Management.Automation.Job
                this_param, System.Func<System.Management.Automation.Cmdlet, bool>
                invokeCmdletMethodAndReturnResult, out System.Exception
                exceptionThrownOnCmdletThread)
                {
                    var return_v = this_param.InvokeCmdletMethodAndWaitForResults<bool>(invokeCmdletMethodAndReturnResult, out exceptionThrownOnCmdletThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 28703, 28857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 28555, 28903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 28555, 28903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void NonblockingShouldProcess(
                    string verboseDescription,
                    string verboseWarning,
                    string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 28915, 29538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 29092, 29527);

                f_1573_29092_29526(this, delegate (Cmdlet cmdlet)
                                    {
                                        ShouldProcessReason throwAwayProcessReason;
                                        cmdlet.ShouldProcess(
                                            verboseDescription,
                                            verboseWarning,
                                            caption,
                                            out throwAwayProcessReason);
                                    });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 28915, 29538);

                int
                f_1573_29092_29526(System.Management.Automation.Job
                this_param, System.Action<System.Management.Automation.Cmdlet>
                invokeCmdletMethod)
                {
                    this_param.InvokeCmdletMethodAndIgnoreResults(invokeCmdletMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 29092, 29526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 28915, 29538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 28915, 29538);
            }
        }

        internal virtual bool ShouldProcess(
                    string verboseDescription,
                    string verboseWarning,
                    string caption,
                    out ShouldProcessReason shouldProcessReason,
                    out Exception exceptionThrownOnCmdletThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 29550, 30364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 29832, 29910);

                ShouldProcessReason
                closureSafeShouldProcessReason = ShouldProcessReason.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 29926, 30250);

                bool
                methodResult = f_1573_29946_30249(this, cmdlet => cmdlet.ShouldProcess(
                                    verboseDescription,
                                    verboseWarning,
                                    caption,
                                    out closureSafeShouldProcessReason), out exceptionThrownOnCmdletThread)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 30266, 30319);

                shouldProcessReason = closureSafeShouldProcessReason;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 30333, 30353);

                return methodResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 29550, 30364);

                bool
                f_1573_29946_30249(System.Management.Automation.Job
                this_param, System.Func<System.Management.Automation.Cmdlet, bool>
                invokeCmdletMethodAndReturnResult, out System.Exception
                exceptionThrownOnCmdletThread)
                {
                    var return_v = this_param.InvokeCmdletMethodAndWaitForResults<bool>(invokeCmdletMethodAndReturnResult, out exceptionThrownOnCmdletThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 29946, 30249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 29550, 30364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 29550, 30364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InvokeCmdletMethodAndIgnoreResults(Action<Cmdlet> invokeCmdletMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 30376, 30916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 30483, 30517);

                object
                resultsLock = f_1573_30504_30516()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 30531, 30810);

                CmdletMethodInvoker<object>
                methodInvoker = new CmdletMethodInvoker<object>
                {
                    Action = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (Func<Cmdlet, object>)(delegate (Cmdlet cmdlet) { invokeCmdletMethod(cmdlet); return null; }), 1573, 30575, 30809),
                    Finished = null,
                    SyncObject = resultsLock
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 30824, 30905);

                f_1573_30824_30904(f_1573_30824_30831(), f_1573_30836_30903(PSStreamObjectType.BlockingError, methodInvoker));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 30376, 30916);

                object
                f_1573_30504_30516()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 30504, 30516);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_30824_30831()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 30824, 30831);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_30836_30903(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.Remoting.CmdletMethodInvoker<object>
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 30836, 30903);
                    return return_v;
                }


                int
                f_1573_30824_30904(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 30824, 30904);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 30376, 30916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 30376, 30916);
            }
        }

        private T InvokeCmdletMethodAndWaitForResults<T>(Func<Cmdlet, T> invokeCmdletMethodAndReturnResult, out Exception exceptionThrownOnCmdletThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 30928, 34278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 31097, 31217);

                f_1573_31097_31216(invokeCmdletMethodAndReturnResult != null, "Caller should verify invokeCmdletMethodAndReturnResult != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 31233, 31261);

                T
                methodResult = default(T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 31275, 31333);

                Exception
                closureSafeExceptionThrownOnCmdletThread = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 31347, 31381);

                object
                resultsLock = f_1573_31368_31380()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 31395, 34074);
                using (var
                gotResultEvent = f_1573_31423_31454(false)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 31488, 32164);

                    EventHandler<JobStateEventArgs>
                    stateChangedEventHandler =
                                        delegate (object sender, JobStateEventArgs eventArgs)
                                            {
                                                if (IsFinishedState(eventArgs.JobStateInfo.State) || eventArgs.JobStateInfo.State == JobState.Stopping)
                                                {
                                                    lock (resultsLock)
                                                    {
                                                        closureSafeExceptionThrownOnCmdletThread = new OperationCanceledException();
                                                    }

                                                    gotResultEvent.Set();
                                                }
                                            }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 32182, 32228);

                    this.StateChanged += stateChangedEventHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 32246, 32274);

                    f_1573_32246_32273();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 32336, 32409);

                        f_1573_32336_32408(stateChangedEventHandler, null, f_1573_32367_32407(f_1573_32389_32406(this)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 32433, 33909) || true) && (f_1573_32437_32458_M(!gotResultEvent.IsSet))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 32433, 33909);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 32508, 32543);

                            f_1573_32508_32542(this, JobState.Blocked);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 32639, 32942);

                            CmdletMethodInvoker<T>
                            methodInvoker = new CmdletMethodInvoker<T>
                            {
                                Action = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => invokeCmdletMethodAndReturnResult, 1573, 32678, 32941),
                                Finished = gotResultEvent,
                                SyncObject = resultsLock
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 32968, 33032);

                            PSStreamObjectType
                            objectType = PSStreamObjectType.ShouldMethod
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33060, 33168) || true) && (typeof(T) == typeof(object))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 33060, 33168);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33122, 33168);

                                objectType = PSStreamObjectType.BlockingError;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 33060, 33168);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33196, 33255);

                            f_1573_33196_33254(f_1573_33196_33203(), f_1573_33208_33253(objectType, methodInvoker));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33283, 33305);

                            f_1573_33283_33304(
                                                    gotResultEvent);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33331, 33366);

                            f_1573_33331_33365(this, JobState.Running);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33400, 33411);

                            lock (resultsLock)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33469, 33859) || true) && (closureSafeExceptionThrownOnCmdletThread == null)
                                ) // stateChangedEventHandler didn't set the results?  = ok to clobber results?

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 33469, 33859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33665, 33752);

                                    closureSafeExceptionThrownOnCmdletThread = f_1573_33708_33751(methodInvoker);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33786, 33828);

                                    methodResult = f_1573_33801_33827(methodInvoker);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 33469, 33859);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 32433, 33909);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1573, 33946, 34059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 33994, 34040);

                        this.StateChanged -= stateChangedEventHandler;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1573, 33946, 34059);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1573, 31395, 34074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 34096, 34107);

                lock (resultsLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 34141, 34214);

                    exceptionThrownOnCmdletThread = closureSafeExceptionThrownOnCmdletThread;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 34232, 34252);

                    return methodResult;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 30928, 34278);

                int
                f_1573_31097_31216(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 31097, 31216);
                    return 0;
                }


                object
                f_1573_31368_31380()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 31368, 31380);
                    return return_v;
                }


                System.Threading.ManualResetEventSlim
                f_1573_31423_31454(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEventSlim(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 31423, 31454);
                    return return_v;
                }


                int
                f_1573_32246_32273()
                {
                    Interlocked.MemoryBarrier();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 32246, 32273);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_32389_32406(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 32389, 32406);
                    return return_v;
                }


                System.Management.Automation.JobStateEventArgs
                f_1573_32367_32407(System.Management.Automation.JobStateInfo
                jobStateInfo)
                {
                    var return_v = new System.Management.Automation.JobStateEventArgs(jobStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 32367, 32407);
                    return return_v;
                }


                int
                f_1573_32336_32408(System.EventHandler<System.Management.Automation.JobStateEventArgs>
                this_param, object?
                sender, System.Management.Automation.JobStateEventArgs
                e)
                {
                    this_param.Invoke(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 32336, 32408);
                    return 0;
                }


                bool
                f_1573_32437_32458_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 32437, 32458);
                    return return_v;
                }


                int
                f_1573_32508_32542(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 32508, 32542);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_33196_33203()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 33196, 33203);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_33208_33253(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 33208, 33253);
                    return return_v;
                }


                int
                f_1573_33196_33254(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 33196, 33254);
                    return 0;
                }


                int
                f_1573_33283_33304(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Wait();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 33283, 33304);
                    return 0;
                }


                int
                f_1573_33331_33365(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 33331, 33365);
                    return 0;
                }


                System.Exception
                f_1573_33708_33751(System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                this_param)
                {
                    var return_v = this_param.ExceptionThrownOnCmdletThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 33708, 33751);
                    return return_v;
                }


                T
                f_1573_33801_33827(System.Management.Automation.Remoting.CmdletMethodInvoker<T>
                this_param)
                {
                    var return_v = this_param.MethodResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 33801, 33827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 30928, 34278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 30928, 34278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void ForwardAvailableResultsToCmdlet(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 34290, 34521);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 34383, 34510);
                    foreach (PSStreamObject obj in f_1573_34414_34431_I(f_1573_34414_34431(f_1573_34414_34421())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 34383, 34510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 34465, 34495);

                        f_1573_34465_34494(obj, cmdlet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 34383, 34510);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 128);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 34290, 34521);

                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_34414_34421()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 34414, 34421);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_34414_34431(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 34414, 34431);
                    return return_v;
                }


                int
                f_1573_34465_34494(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, System.Management.Automation.Cmdlet
                cmdlet)
                {
                    this_param.WriteStreamObject(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 34465, 34494);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_34414_34431_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 34414, 34431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 34290, 34521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 34290, 34521);
            }
        }

        internal virtual void ForwardAllResultsToCmdlet(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 34533, 34753);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 34620, 34742);
                    foreach (PSStreamObject obj in f_1573_34651_34663_I(f_1573_34651_34663(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 34620, 34742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 34697, 34727);

                        f_1573_34697_34726(obj, cmdlet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 34620, 34742);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 34533, 34753);

                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_34651_34663(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 34651, 34663);
                    return return_v;
                }


                int
                f_1573_34697_34726(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, System.Management.Automation.Cmdlet
                cmdlet)
                {
                    this_param.WriteStreamObject(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 34697, 34726);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_34651_34663_I(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 34651, 34663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 34533, 34753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 34533, 34753);
            }
        }

        protected virtual void DoLoadJobStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 34921, 34984);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 34921, 34984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 34921, 34984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 34921, 34984);
            }
        }

        protected virtual void DoUnloadJobStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 35156, 35221);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 35156, 35221);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 35156, 35221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 35156, 35221);
            }
        }

        public void LoadJobStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 35324, 36055);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35377, 35407) || true) && (_jobStreamsLoaded)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 35377, 35407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35400, 35407);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 35377, 35407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35429, 35439);

                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35473, 35503) || true) && (_jobStreamsLoaded)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 35473, 35503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35496, 35503);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 35473, 35503);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35523, 35548);

                    _jobStreamsLoaded = true;
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35615, 35634);

                    f_1573_35615_35633(this);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 35663, 36044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35860, 36029);
                    using (PowerShellTraceSource
                    tracer = f_1573_35898_35943()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 35985, 36010);

                        f_1573_35985_36009(tracer, e);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1573, 35860, 36029);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 35663, 36044);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 35324, 36055);

                int
                f_1573_35615_35633(System.Management.Automation.Job
                this_param)
                {
                    this_param.DoLoadJobStreams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 35615, 35633);
                    return 0;
                }


                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1573_35898_35943()
                {
                    var return_v = PowerShellTraceSourceFactory.GetTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 35898, 35943);
                    return return_v;
                }


                bool
                f_1573_35985_36009(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 35985, 36009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 35324, 36055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 35324, 36055);
            }
        }

        private bool _jobStreamsLoaded;

        public void UnloadJobStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 36203, 36939);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36258, 36289) || true) && (!_jobStreamsLoaded)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 36258, 36289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36282, 36289);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 36258, 36289);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36311, 36321);

                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36355, 36386) || true) && (!_jobStreamsLoaded)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 36355, 36386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36379, 36386);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 36355, 36386);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36404, 36430);

                    _jobStreamsLoaded = false;
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36497, 36518);

                    f_1573_36497_36517(this);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 36547, 36928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36744, 36913);
                    using (PowerShellTraceSource
                    tracer = f_1573_36782_36827()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 36869, 36894);

                        f_1573_36869_36893(tracer, e);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1573, 36744, 36913);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 36547, 36928);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 36203, 36939);

                int
                f_1573_36497_36517(System.Management.Automation.Job
                this_param)
                {
                    this_param.DoUnloadJobStreams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 36497, 36517);
                    return 0;
                }


                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1573_36782_36827()
                {
                    var return_v = PowerShellTraceSourceFactory.GetTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 36782, 36827);
                    return return_v;
                }


                bool
                f_1573_36869_36893(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 36869, 36893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 36203, 36939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 36203, 36939);
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<PSObject> Output
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 37493, 37617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37529, 37546);

                    f_1573_37529_37545(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37587, 37602);

                    return _output;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 37493, 37617);

                    int
                    f_1573_37529_37545(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.LoadJobStreams();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 37529, 37545);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 37335, 38080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 37335, 38080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 37633, 38069);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37669, 37802) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 37669, 37802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37728, 37783);

                        throw f_1573_37734_37782("Output");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 37669, 37802);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37828, 37838);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37880, 37907);

                        f_1573_37880_37906(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37929, 37950);

                        _outputOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 37972, 37988);

                        _output = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 38010, 38035);

                        _jobStreamsLoaded = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 37633, 38069);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_37734_37782(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 37734, 37782);
                        return return_v;
                    }


                    int
                    f_1573_37880_37906(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 37880, 37906);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 37335, 38080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 37335, 38080);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<ErrorRecord> Error
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 38636, 38759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 38672, 38689);

                    f_1573_38672_38688(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 38730, 38744);

                    return _error;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 38636, 38759);

                    int
                    f_1573_38672_38688(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.LoadJobStreams();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 38672, 38688);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 38476, 39219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 38476, 39219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 38775, 39208);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 38811, 38943) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 38811, 38943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 38870, 38924);

                        throw f_1573_38876_38923("Error");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 38811, 38943);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 38969, 38979);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 39021, 39048);

                        f_1573_39021_39047(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 39070, 39090);

                        _errorOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 39112, 39127);

                        _error = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 39149, 39174);

                        _jobStreamsLoaded = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 38775, 39208);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_38876_38923(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 38876, 38923);
                        return return_v;
                    }


                    int
                    f_1573_39021_39047(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 39021, 39047);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 38476, 39219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 38476, 39219);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<ProgressRecord> Progress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 39785, 39911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 39821, 39838);

                    f_1573_39821_39837(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 39879, 39896);

                    return _progress;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 39785, 39911);

                    int
                    f_1573_39821_39837(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.LoadJobStreams();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 39821, 39837);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 39619, 40380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 39619, 40380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 39927, 40369);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 39963, 40098) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 39963, 40098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40022, 40079);

                        throw f_1573_40028_40078("Progress");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 39963, 40098);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40124, 40134);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40176, 40203);

                        f_1573_40176_40202(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40225, 40248);

                        _progressOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40270, 40288);

                        _progress = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40310, 40335);

                        _jobStreamsLoaded = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 39927, 40369);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_40028_40078(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 40028, 40078);
                        return return_v;
                    }


                    int
                    f_1573_40176_40202(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 40176, 40202);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 39619, 40380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 39619, 40380);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<VerboseRecord> Verbose
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 40826, 40951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40862, 40879);

                    f_1573_40862_40878(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 40920, 40936);

                    return _verbose;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 40826, 40951);

                    int
                    f_1573_40862_40878(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.LoadJobStreams();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 40862, 40878);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 40662, 41417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 40662, 41417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 40967, 41406);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 41003, 41137) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 41003, 41137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 41062, 41118);

                        throw f_1573_41068_41117("Verbose");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 41003, 41137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 41163, 41173);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 41215, 41242);

                        f_1573_41215_41241(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 41264, 41286);

                        _verboseOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 41308, 41325);

                        _verbose = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 41347, 41372);

                        _jobStreamsLoaded = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 40967, 41406);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_41068_41117(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 41068, 41117);
                        return return_v;
                    }


                    int
                    f_1573_41215_41241(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 41215, 41241);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 40662, 41417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 40662, 41417);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<DebugRecord> Debug
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 41976, 42099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42012, 42029);

                    f_1573_42012_42028(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42070, 42084);

                    return _debug;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 41976, 42099);

                    int
                    f_1573_42012_42028(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.LoadJobStreams();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 42012, 42028);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 41816, 42512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 41816, 42512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 42115, 42501);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42151, 42283) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 42151, 42283);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42210, 42264);

                        throw f_1573_42216_42263("Debug");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 42151, 42283);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42309, 42319);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42361, 42388);

                        f_1573_42361_42387(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42410, 42430);

                        _debugOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 42452, 42467);

                        _debug = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 42115, 42501);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_42216_42263(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 42216, 42263);
                        return return_v;
                    }


                    int
                    f_1573_42361_42387(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 42361, 42387);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 41816, 42512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 41816, 42512);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<WarningRecord> Warning
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 43074, 43199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43110, 43127);

                    f_1573_43110_43126(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43168, 43184);

                    return _warning;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 43074, 43199);

                    int
                    f_1573_43110_43126(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.LoadJobStreams();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 43110, 43126);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 42910, 43665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 42910, 43665);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 43215, 43654);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43251, 43385) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 43251, 43385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43310, 43366);

                        throw f_1573_43316_43365("Warning");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 43251, 43385);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43411, 43421);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43463, 43490);

                        f_1573_43463_43489(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43512, 43534);

                        _warningOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43556, 43573);

                        _warning = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 43595, 43620);

                        _jobStreamsLoaded = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 43215, 43654);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_43316_43365(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 43316, 43365);
                        return return_v;
                    }


                    int
                    f_1573_43463_43489(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 43463, 43489);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 42910, 43665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 42910, 43665);
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<InformationRecord> Information
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 44250, 44379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44286, 44303);

                    f_1573_44286_44302(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44344, 44364);

                    return _information;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 44250, 44379);

                    int
                    f_1573_44286_44302(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.LoadJobStreams();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 44286, 44302);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 44078, 44857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 44078, 44857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 44395, 44846);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44431, 44569) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 44431, 44569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44490, 44550);

                        throw f_1573_44496_44549("Information");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 44431, 44569);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44595, 44605);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44647, 44674);

                        f_1573_44647_44673(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44696, 44722);

                        _informationOwner = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44744, 44765);

                        _information = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 44787, 44812);

                        _jobStreamsLoaded = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 44395, 44846);

                    System.Management.Automation.PSArgumentNullException
                    f_1573_44496_44549(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 44496, 44549);
                        return return_v;
                    }


                    int
                    f_1573_44647_44673(System.Management.Automation.Job
                    this_param)
                    {
                        this_param.AssertChangesAreAccepted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 44647, 44673);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 44078, 44857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 44078, 44857);
                }
            }
        }

        public abstract string Location { get; }

        internal virtual bool CanDisconnect
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 45370, 45391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 45376, 45389);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 45370, 45391);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 45310, 45402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 45310, 45402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual IEnumerable<RemoteRunspace> GetRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 45616, 45723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 45700, 45712);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 45616, 45723);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 45616, 45723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 45616, 45723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }




        /// <summary>
        /// Event raised when state of the job changes.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public event EventHandler<JobStateEventArgs>
StateChanged
;

        protected void SetJobState(JobState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 46273, 46410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 46340, 46360);

                f_1573_46340_46359(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 46374, 46399);

                f_1573_46374_46398(this, state, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 46273, 46410);

                int
                f_1573_46340_46359(System.Management.Automation.Job
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 46340, 46359);
                    return 0;
                }


                int
                f_1573_46374_46398(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 46374, 46398);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 46273, 46410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 46273, 46410);
            }
        }

        internal void SetJobState(JobState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 46688, 49692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 46772, 49681);
                using (PowerShellTraceSource
                tracer = f_1573_46810_46855()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 46889, 46909);

                    f_1573_46889_46908(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 46929, 46950);

                    bool
                    alldone = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 46968, 47010);

                    JobStateInfo
                    previousState = f_1573_46997_47009()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47036, 47046);

                    lock (syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47088, 47135);

                        JobStateInfo = f_1573_47103_47134(state, reason);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47159, 47806) || true) && (state == JobState.Running)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 47159, 47806);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47294, 47429) || true) && (f_1573_47298_47309() == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 47294, 47429);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47375, 47402);

                                PSBeginTime = DateTime.Now;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 47294, 47429);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 47159, 47806);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 47159, 47806);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47479, 47806) || true) && (f_1573_47483_47505(this, state))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 47479, 47806);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47555, 47570);

                                alldone = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47652, 47783) || true) && (f_1573_47656_47665() == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 47652, 47783);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47731, 47756);

                                    PSEndTime = DateTime.Now;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 47652, 47783);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 47479, 47806);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 47159, 47806);
                        }
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47845, 48415) || true) && (alldone)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 47845, 48415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47898, 47916);

                        f_1573_47898_47915(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 47940, 48396) || true) && (_processingOutput)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 47940, 48396);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 48165, 48249);

                                f_1573_48165_48248(this, this, f_1573_48206_48247(false));
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 48302, 48373);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 48302, 48373);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 47940, 48396);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 47845, 48415);
                    }

#pragma warning disable 56500
                    // Exception raised in the eventhandler are not error in job.
                    // silently ignore them.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 48631, 48728);

                        f_1573_48631_48727(tracer, "Job", "SetJobState", Guid.Empty, this, "Invoking StateChanged event", null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 48750, 48840);

                        f_1573_48750_48839(StateChanged, this, f_1573_48780_48838(f_1573_48802_48822(f_1573_48802_48814()), previousState));
                    }
                    catch (Exception exception) // ignore non-severe exceptions
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 48877, 49226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 48977, 49152);

                        f_1573_48977_49151(tracer, "Job", "SetJobState", Guid.Empty, this, "Some Job StateChange event handler threw an unhandled exception.", null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 49174, 49207);

                        f_1573_49174_49206(tracer, exception);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 48877, 49226);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 49352, 49635) || true) && (alldone)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 49352, 49635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 49411, 49421);
                        lock (syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 49471, 49593) || true) && (_finished != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 49471, 49593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 49550, 49566);

                                f_1573_49550_49565(_finished);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 49471, 49593);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 49352, 49635);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1573, 46772, 49681);
#pragma warning restore 56500
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 46688, 49692);

                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1573_46810_46855()
                {
                    var return_v = PowerShellTraceSourceFactory.GetTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 46810, 46855);
                    return return_v;
                }


                int
                f_1573_46889_46908(System.Management.Automation.Job
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 46889, 46908);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_46997_47009()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 46997, 47009);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_47103_47134(System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.JobStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 47103, 47134);
                    return return_v;
                }


                System.DateTime?
                f_1573_47298_47309()
                {
                    var return_v = PSBeginTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 47298, 47309);
                    return return_v;
                }


                bool
                f_1573_47483_47505(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 47483, 47505);
                    return return_v;
                }


                System.DateTime?
                f_1573_47656_47665()
                {
                    var return_v = PSEndTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 47656, 47665);
                    return return_v;
                }


                int
                f_1573_47898_47915(System.Management.Automation.Job
                this_param)
                {
                    this_param.CloseAllStreams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 47898, 47915);
                    return 0;
                }


                System.Management.Automation.OutputProcessingStateEventArgs
                f_1573_48206_48247(bool
                processingOutput)
                {
                    var return_v = new System.Management.Automation.OutputProcessingStateEventArgs(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 48206, 48247);
                    return return_v;
                }


                int
                f_1573_48165_48248(System.Management.Automation.Job
                this_param, System.Management.Automation.Job
                sender, System.Management.Automation.OutputProcessingStateEventArgs
                e)
                {
                    this_param.HandleOutputProcessingStateChanged((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 48165, 48248);
                    return 0;
                }


                int
                f_1573_48631_48727(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 48631, 48727);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_48802_48814()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 48802, 48814);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_48802_48822(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 48802, 48822);
                    return return_v;
                }


                System.Management.Automation.JobStateEventArgs
                f_1573_48780_48838(System.Management.Automation.JobStateInfo
                jobStateInfo, System.Management.Automation.JobStateInfo
                previousJobStateInfo)
                {
                    var return_v = new System.Management.Automation.JobStateEventArgs(jobStateInfo, previousJobStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 48780, 48838);
                    return return_v;
                }


                int
                f_1573_48750_48839(System.EventHandler<System.Management.Automation.JobStateEventArgs>
                eventHandler, System.Management.Automation.Job
                sender, System.Management.Automation.JobStateEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.JobStateEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 48750, 48839);
                    return 0;
                }


                int
                f_1573_48977_49151(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 48977, 49151);
                    return 0;
                }


                bool
                f_1573_49174_49206(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 49174, 49206);
                    return return_v;
                }


                bool
                f_1573_49550_49565(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 49550, 49565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 46688, 49692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 46688, 49692);
            }
        }

        public abstract void StopJob();

        internal Collection<PSStreamObject> ReadAll()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 50323, 50607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50393, 50408);

                f_1573_50393_50407(f_1573_50393_50399());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50422, 50436);

                f_1573_50422_50435(f_1573_50422_50427());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50450, 50464);

                f_1573_50450_50463(f_1573_50450_50455());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50478, 50494);

                f_1573_50478_50493(f_1573_50478_50485());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50508, 50524);

                f_1573_50508_50523(f_1573_50508_50515());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50538, 50555);

                f_1573_50538_50554(f_1573_50538_50546());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50571, 50596);

                return f_1573_50578_50595(f_1573_50578_50585());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 50323, 50607);

                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1573_50393_50399()
                {
                    var return_v = Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 50393, 50399);
                    return return_v;
                }


                int
                f_1573_50393_50407(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 50393, 50407);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1573_50422_50427()
                {
                    var return_v = Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 50422, 50427);
                    return return_v;
                }


                int
                f_1573_50422_50435(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 50422, 50435);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1573_50450_50455()
                {
                    var return_v = Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 50450, 50455);
                    return return_v;
                }


                int
                f_1573_50450_50463(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 50450, 50463);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1573_50478_50485()
                {
                    var return_v = Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 50478, 50485);
                    return return_v;
                }


                int
                f_1573_50478_50493(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 50478, 50493);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1573_50508_50515()
                {
                    var return_v = Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 50508, 50515);
                    return return_v;
                }


                int
                f_1573_50508_50523(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 50508, 50523);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1573_50538_50546()
                {
                    var return_v = Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 50538, 50546);
                    return return_v;
                }


                int
                f_1573_50538_50554(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 50538, 50554);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_50578_50585()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 50578, 50585);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_50578_50595(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 50578, 50595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 50323, 50607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 50323, 50607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsFinishedState(JobState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 50799, 51039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50875, 50885);
                lock (syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 50919, 51013);

                    return (state == JobState.Completed || (DynAbs.Tracing.TraceSender.Expression_False(1573, 50927, 50982) || state == JobState.Failed) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 50927, 51011) || state == JobState.Stopped));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 50799, 51039);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 50799, 51039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 50799, 51039);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsPersistentState(JobState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 51051, 51296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 51129, 51139);
                lock (syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 51173, 51270);

                    return (f_1573_51181_51203(this, state) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 51181, 51237) || state == JobState.Disconnected) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 51181, 51268) || state == JobState.Suspended));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 51051, 51296);

                bool
                f_1573_51181_51203(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 51181, 51203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 51051, 51296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 51051, 51296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AssertChangesAreAccepted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 51838, 52168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 51902, 51922);

                f_1573_51902_51921(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 51942, 51952);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 51986, 52142) || true) && (f_1573_51990_52008(f_1573_51990_52002()) == JobState.Running)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 51986, 52142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 52070, 52123);

                        throw f_1573_52076_52122(JobState.Running);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 51986, 52142);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 51838, 52168);

                int
                f_1573_51902_51921(System.Management.Automation.Job
                this_param)
                {
                    this_param.AssertNotDisposed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 51902, 51921);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_51990_52002()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 51990, 52002);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_51990_52008(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 51990, 52008);
                    return return_v;
                }


                System.Management.Automation.InvalidJobStateException
                f_1573_52076_52122(System.Management.Automation.JobState
                currentState)
                {
                    var return_v = new System.Management.Automation.InvalidJobStateException(currentState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 52076, 52122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 51838, 52168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 51838, 52168);
            }
        }

        protected string AutoGenerateJobName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 52539, 52693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 52602, 52682);

                return "Job" + f_1573_52617_52681(f_1573_52617_52619(), f_1573_52629_52680());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 52539, 52693);

                int
                f_1573_52617_52619()
                {
                    var return_v = Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 52617, 52619);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1573_52629_52680()
                {
                    var return_v = System.Globalization.NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 52629, 52680);
                    return return_v;
                }


                string
                f_1573_52617_52681(int
                this_param, System.Globalization.NumberFormatInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 52617, 52681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 52539, 52693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 52539, 52693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AssertNotDisposed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 52993, 53182);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53051, 53171) || true) && (_isDisposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 53051, 53171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53100, 53156);

                    throw f_1573_53106_53155("PSJob");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 53051, 53171);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 52993, 53182);

                System.Management.Automation.PSObjectDisposedException
                f_1573_53106_53155(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 53106, 53155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 52993, 53182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 52993, 53182);
            }
        }

        internal void CloseAllStreams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 53296, 54541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53666, 53760) || true) && (_resultsOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 53666, 53760);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53693, 53713);

                        f_1573_53693_53712(_results);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 53716, 53758);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53738, 53756);

                        f_1573_53738_53755(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 53716, 53758);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 53666, 53760);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53776, 53868) || true) && (_outputOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 53776, 53868);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53802, 53821);

                        f_1573_53802_53820(_output);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 53824, 53866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53846, 53864);

                        f_1573_53846_53863(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 53824, 53866);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 53776, 53868);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53884, 53974) || true) && (_errorOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 53884, 53974);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53909, 53927);

                        f_1573_53909_53926(_error);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 53930, 53972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53952, 53970);

                        f_1573_53952_53969(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 53930, 53972);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 53884, 53974);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 53990, 54086) || true) && (_progressOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 53990, 54086);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54018, 54039);

                        f_1573_54018_54038(_progress);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 54042, 54084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54064, 54082);

                        f_1573_54064_54081(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 54042, 54084);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 53990, 54086);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54102, 54196) || true) && (_verboseOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 54102, 54196);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54129, 54149);

                        f_1573_54129_54148(_verbose);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 54152, 54194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54174, 54192);

                        f_1573_54174_54191(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 54152, 54194);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 54102, 54196);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54212, 54306) || true) && (_warningOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 54212, 54306);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54239, 54259);

                        f_1573_54239_54258(_warning);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 54262, 54304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54284, 54302);

                        f_1573_54284_54301(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 54262, 54304);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 54212, 54306);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54322, 54412) || true) && (_debugOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 54322, 54412);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54347, 54365);

                        f_1573_54347_54364(_debug);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 54368, 54410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54390, 54408);

                        f_1573_54390_54407(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 54368, 54410);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 54322, 54412);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54428, 54530) || true) && (_informationOwner)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 54428, 54530);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54459, 54483);

                        f_1573_54459_54482(_information);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 54486, 54528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54508, 54526);

                        f_1573_54508_54525(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 54486, 54528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 54428, 54530);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 53296, 54541);

                int
                f_1573_53693_53712(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 53693, 53712);
                    return 0;
                }


                int
                f_1573_53738_53755(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 53738, 53755);
                    return 0;
                }


                int
                f_1573_53802_53820(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 53802, 53820);
                    return 0;
                }


                int
                f_1573_53846_53863(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 53846, 53863);
                    return 0;
                }


                int
                f_1573_53909_53926(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 53909, 53926);
                    return 0;
                }


                int
                f_1573_53952_53969(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 53952, 53969);
                    return 0;
                }


                int
                f_1573_54018_54038(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54018, 54038);
                    return 0;
                }


                int
                f_1573_54064_54081(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54064, 54081);
                    return 0;
                }


                int
                f_1573_54129_54148(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54129, 54148);
                    return 0;
                }


                int
                f_1573_54174_54191(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54174, 54191);
                    return 0;
                }


                int
                f_1573_54239_54258(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54239, 54258);
                    return 0;
                }


                int
                f_1573_54284_54301(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54284, 54301);
                    return 0;
                }


                int
                f_1573_54347_54364(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54347, 54364);
                    return 0;
                }


                int
                f_1573_54390_54407(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54390, 54407);
                    return 0;
                }


                int
                f_1573_54459_54482(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54459, 54482);
                    return 0;
                }


                int
                f_1573_54508_54525(System.Exception
                e)
                {
                    TraceException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54508, 54525);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 53296, 54541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 53296, 54541);
            }
        }

        private static void TraceException(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1573, 54553, 54793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54625, 54782);
                using (PowerShellTraceSource
                tracer = f_1573_54663_54708()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 54742, 54767);

                    f_1573_54742_54766(tracer, e);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1573, 54625, 54782);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1573, 54553, 54793);

                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1573_54663_54708()
                {
                    var return_v = PowerShellTraceSourceFactory.GetTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54663, 54708);
                    return return_v;
                }


                bool
                f_1573_54742_54766(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 54742, 54766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 54553, 54793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 54553, 54793);
            }
        }

        internal List<Job> GetJobsForLocation(string location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 55025, 55449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 55104, 55146);

                List<Job>
                returnJobList = f_1573_55130_55145()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 55162, 55401);
                    foreach (Job job in f_1573_55182_55191_I(f_1573_55182_55191()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 55162, 55401);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 55225, 55386) || true) && (f_1573_55229_55302(f_1573_55243_55255(job), location, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 55225, 55386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 55344, 55367);

                            f_1573_55344_55366(returnJobList, job);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 55225, 55386);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 55162, 55401);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 55417, 55438);

                return returnJobList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 55025, 55449);

                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1573_55130_55145()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 55130, 55145);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_55182_55191()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 55182, 55191);
                    return return_v;
                }


                string
                f_1573_55243_55255(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 55243, 55255);
                    return return_v;
                }


                bool
                f_1573_55229_55302(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 55229, 55302);
                    return return_v;
                }


                int
                f_1573_55344_55366(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.Job
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 55344, 55366);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_55182_55191_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 55182, 55191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 55025, 55449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 55025, 55449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 55759, 56079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 55805, 55819);

                f_1573_55805_55818(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56035, 56068);

                f_1573_56035_56067(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 55759, 56079);

                int
                f_1573_55805_55818(System.Management.Automation.Job
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 55805, 55818);
                    return 0;
                }


                int
                f_1573_56035_56067(System.Management.Automation.Job
                obj)
                {
                    System.GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 56035, 56067);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 55759, 56079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 55759, 56079);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 56293, 57468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56364, 57457) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 56364, 57457);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56411, 57442) || true) && (!_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 56411, 57442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56469, 56487);

                        f_1573_56469_56486(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56564, 56574);

                        // release the WaitHandle
                        lock (syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56624, 56797) || true) && (_finished != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 56624, 56797);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56703, 56723);

                                f_1573_56703_56722(_finished);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56753, 56770);

                                _finished = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 56624, 56797);
                            }
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56922, 56960) || true) && (_resultsOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 56922, 56960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56941, 56960);

                            f_1573_56941_56959(_results);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 56922, 56960);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 56982, 57018) || true) && (_outputOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 56982, 57018);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57000, 57018);

                            f_1573_57000_57017(_output);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 56982, 57018);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57040, 57074) || true) && (_errorOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 57040, 57074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57057, 57074);

                            f_1573_57057_57073(_error);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 57040, 57074);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57096, 57130) || true) && (_debugOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 57096, 57130);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57113, 57130);

                            f_1573_57113_57129(_debug);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 57096, 57130);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57152, 57198) || true) && (_informationOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 57152, 57198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57175, 57198);

                            f_1573_57175_57197(_information);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 57152, 57198);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57220, 57258) || true) && (_verboseOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 57220, 57258);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57239, 57258);

                            f_1573_57239_57257(_verbose);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 57220, 57258);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57280, 57318) || true) && (_warningOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 57280, 57318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57299, 57318);

                            f_1573_57299_57317(_warning);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 57280, 57318);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57340, 57380) || true) && (_progressOwner)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 57340, 57380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57360, 57380);

                            f_1573_57360_57379(_progress);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 57340, 57380);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 57404, 57423);

                        _isDisposed = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 56411, 57442);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 56364, 57457);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 56293, 57468);

                int
                f_1573_56469_56486(System.Management.Automation.Job
                this_param)
                {
                    this_param.CloseAllStreams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 56469, 56486);
                    return 0;
                }


                int
                f_1573_56703_56722(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 56703, 56722);
                    return 0;
                }


                int
                f_1573_56941_56959(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 56941, 56959);
                    return 0;
                }


                int
                f_1573_57000_57017(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 57000, 57017);
                    return 0;
                }


                int
                f_1573_57057_57073(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 57057, 57073);
                    return 0;
                }


                int
                f_1573_57113_57129(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 57113, 57129);
                    return 0;
                }


                int
                f_1573_57175_57197(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 57175, 57197);
                    return 0;
                }


                int
                f_1573_57239_57257(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 57239, 57257);
                    return 0;
                }


                int
                f_1573_57299_57317(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 57299, 57317);
                    return 0;
                }


                int
                f_1573_57360_57379(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 57360, 57379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 56293, 57468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 56293, 57468);
            }
        }

        private bool _isDisposed;



        internal event EventHandler<OutputProcessingStateEventArgs>
OutputProcessingStateChanged
;

        private bool _processingOutput;

        internal bool MonitorOutputProcessing
        {
            get;
            set;
        }

        internal void SetMonitorOutputProcessing(IOutputProcessingState outputProcessingState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 57938, 58231);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 58049, 58220) || true) && (outputProcessingState != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 58049, 58220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 58116, 58205);

                    outputProcessingState.OutputProcessingStateChanged += HandleOutputProcessingStateChanged;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 58049, 58220);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 57938, 58231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 57938, 58231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 57938, 58231);
            }
        }

        internal void RemoveMonitorOutputProcessing(IOutputProcessingState outputProcessingState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 58243, 58539);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 58357, 58528) || true) && (outputProcessingState != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 58357, 58528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 58424, 58513);

                    outputProcessingState.OutputProcessingStateChanged -= HandleOutputProcessingStateChanged;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 58357, 58528);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 58243, 58539);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 58243, 58539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 58243, 58539);
            }
        }

        private void HandleOutputProcessingStateChanged(object sender, OutputProcessingStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 58551, 58817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 58672, 58711);

                _processingOutput = f_1573_58692_58710(e);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 58725, 58806);

                f_1573_58725_58805(OutputProcessingStateChanged, this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 58551, 58817);

                bool
                f_1573_58692_58710(System.Management.Automation.OutputProcessingStateEventArgs
                this_param)
                {
                    var return_v = this_param.ProcessingOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 58692, 58710);
                    return return_v;
                }


                int
                f_1573_58725_58805(System.EventHandler<System.Management.Automation.OutputProcessingStateEventArgs>
                eventHandler, System.Management.Automation.Job
                sender, System.Management.Automation.OutputProcessingStateEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.OutputProcessingStateEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 58725, 58805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 58551, 58817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 58551, 58817);
            }
        }

        static Job()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 12310, 58846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 18410, 18425);
            s_jobIdSeed = 0;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 12310, 58846);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 12310, 58846);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 12310, 58846);

        int
        f_1573_12523_12578(ref int
        location)
        {
            var return_v = System.Threading.Interlocked.Increment(ref location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 12523, 12578);
            return return_v;
        }


        string
        f_1573_12892_12913(System.Management.Automation.Job
        this_param)
        {
            var return_v = this_param.AutoGenerateJobName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 12892, 12913);
            return return_v;
        }


        bool
        f_1573_13286_13312(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 13286, 13312);
            return return_v;
        }


        static string
        f_1573_13248_13255_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 13185, 13385);
            return return_v;
        }


        static string
        f_1573_13806_13813_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 13721, 13879);
            return return_v;
        }


        string
        f_1573_14601_14641()
        {
            var return_v = RemotingErrorIdStrings.JobIdentifierNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 14601, 14641);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1573_14553_14642(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 14553, 14642);
            return return_v;
        }


        int
        f_1573_14661_14669(System.Management.Automation.JobIdentifier
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 14661, 14669);
            return return_v;
        }


        string
        f_1573_14767_14809()
        {
            var return_v = RemotingErrorIdStrings.JobIdNotYetAssigned;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 14767, 14809);
            return return_v;
        }


        int
        f_1573_14811_14819(System.Management.Automation.JobIdentifier
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 14811, 14819);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1573_14723_14820(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 14723, 14820);
            return return_v;
        }


        int
        f_1573_14891_14899(System.Management.Automation.JobIdentifier
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 14891, 14899);
            return return_v;
        }


        System.Guid
        f_1573_14927_14943(System.Management.Automation.JobIdentifier
        this_param)
        {
            var return_v = this_param.InstanceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 14927, 14943);
            return return_v;
        }


        bool
        f_1573_14965_14991(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 14965, 14991);
            return return_v;
        }


        string
        f_1573_15112_15133(System.Management.Automation.Job
        this_param)
        {
            var return_v = this_param.AutoGenerateJobName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 15112, 15133);
            return return_v;
        }


        static string
        f_1573_15726_15733_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 15646, 15800);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1573_16877_16904(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 16877, 16904);
            return return_v;
        }


        object
        f_1573_17026_17038()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 17026, 17038);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
        f_1573_17190_17228()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 17190, 17228);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
        f_1573_17330_17365()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 17330, 17365);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
        f_1573_17471_17509()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 17471, 17509);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
        f_1573_17616_17653()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 17616, 17653);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
        f_1573_17759_17796()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 17759, 17796);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
        f_1573_17898_17933()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 17898, 17933);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
        f_1573_18045_18086()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 18045, 18086);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
        f_1573_18190_18222()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 18190, 18222);
            return return_v;
        }


        System.Management.Automation.JobStateInfo
        f_1573_18846_18883(System.Management.Automation.JobState
        state)
        {
            var return_v = new System.Management.Automation.JobStateInfo(state);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 18846, 18883);
            return return_v;
        }

    }
    internal class PSRemotingJob : Job
    {
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PSRemotingJob(string[] computerNames,
                                List<IThrottleOperation> computerNameHelpers, string remoteCommand, string name)
        : this(f_1573_60153_60166_C(computerNames), computerNameHelpers, remoteCommand, 0, name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 59880, 60225);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 59880, 60225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 59880, 60225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 59880, 60225);
            }
        }

        internal PSRemotingJob(PSSession[] remoteRunspaceInfos,
                                List<IThrottleOperation> runspaceHelpers, string remoteCommand, string name)
        : this(f_1573_61012_61031_C(remoteRunspaceInfos), runspaceHelpers, remoteCommand, 0, name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 60821, 61086);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 60821, 61086);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 60821, 61086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 60821, 61086);
            }
        }

        internal PSRemotingJob(string[] computerNames,
                                List<IThrottleOperation> computerNameHelpers, string remoteCommand,
                                    int throttleLimit, string name)
        : base(f_1573_61994_62007_C(remoteCommand), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 61773, 62797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78448, 78464);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79583, 79604);
                this._stopIsCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81150, 81164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82285, 82309);
                this._hideComputerName = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84583, 84616);
                this._atleastOneChildJobFailed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84703, 84730);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84815, 84841);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84930, 84961);
                this._disconnectedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85050, 85074);
                this._debugChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91913, 91932);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94782, 94822);
                this._throttleManager = f_1573_94801_94822();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94859, 94885);
                this._syncObject = f_1573_94873_94885();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 62101, 62723);
                    foreach (ExecutionCmdletHelperComputerName helper in f_1573_62154_62173_I(computerNameHelpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 62101, 62723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 62284, 62423);

                        PSRemotingChildJob
                        childJob = f_1573_62314_62422(remoteCommand, helper, _throttleManager)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 62441, 62530);

                        childJob.StateChanged += new EventHandler<JobStateEventArgs>(HandleChildJobStateChanged);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 62548, 62610);

                        childJob.JobUnblocked += new EventHandler(HandleJobUnblocked);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 62684, 62708);

                        f_1573_62684_62707(f_1573_62684_62693(), childJob);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 62101, 62723);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 62739, 62786);

                f_1573_62739_62785(this, throttleLimit, computerNameHelpers);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 61773, 62797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 61773, 62797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 61773, 62797);
            }
        }

        internal PSRemotingJob(PSSession[] remoteRunspaceInfos,
                                List<IThrottleOperation> runspaceHelpers, string remoteCommand,
                                int throttleLimit, string name)
        : base(f_1573_63642_63655_C(remoteCommand), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 63420, 64511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78448, 78464);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79583, 79604);
                this._stopIsCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81150, 81164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82285, 82309);
                this._hideComputerName = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84583, 84616);
                this._atleastOneChildJobFailed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84703, 84730);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84815, 84841);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84930, 84961);
                this._disconnectedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85050, 85074);
                this._debugChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91913, 91932);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94782, 94822);
                this._throttleManager = f_1573_94801_94822();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94859, 94885);
                this._syncObject = f_1573_94873_94885();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 63758, 63763);
                    // Create child jobs for each object in the list
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 63749, 64441) || true) && (i < f_1573_63769_63795(remoteRunspaceInfos))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 63797, 63800)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 63749, 64441))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 63749, 64441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 63834, 63923);

                        ExecutionCmdletHelperRunspace
                        helper = (ExecutionCmdletHelperRunspace)f_1573_63904_63922(runspaceHelpers, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 64028, 64150);

                        PSRemotingChildJob
                        job = f_1573_64053_64149(remoteCommand, helper, _throttleManager)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 64168, 64252);

                        job.StateChanged += new EventHandler<JobStateEventArgs>(HandleChildJobStateChanged);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 64270, 64327);

                        job.JobUnblocked += new EventHandler(HandleJobUnblocked);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 64407, 64426);

                        f_1573_64407_64425(f_1573_64407_64416(), job);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 64457, 64500);

                f_1573_64457_64499(this, throttleLimit, runspaceHelpers);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 63420, 64511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 63420, 64511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 63420, 64511);
            }
        }

        internal PSRemotingJob(List<IThrottleOperation> helpers,
                                       int throttleLimit, string name, bool aggregateResults)
        : base(f_1573_65369_65381_C(string.Empty), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 65205, 66592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78448, 78464);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79583, 79604);
                this._stopIsCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81150, 81164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82285, 82309);
                this._hideComputerName = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84583, 84616);
                this._atleastOneChildJobFailed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84703, 84730);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84815, 84841);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84930, 84961);
                this._disconnectedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85050, 85074);
                this._debugChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91913, 91932);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94782, 94822);
                this._throttleManager = f_1573_94801_94822();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94859, 94885);
                this._syncObject = f_1573_94873_94885();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 65674, 66079);
                    foreach (ExecutionCmdletHelper helper in f_1573_65715_65722_I(helpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 65674, 66079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 65756, 65848);

                        PSRemotingChildJob
                        job = f_1573_65781_65847(helper, _throttleManager, aggregateResults)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 65866, 65950);

                        job.StateChanged += new EventHandler<JobStateEventArgs>(HandleChildJobStateChanged);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 65968, 66025);

                        job.JobUnblocked += new EventHandler(HandleJobUnblocked);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 66045, 66064);

                        f_1573_66045_66063(f_1573_66045_66054(), job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 65674, 66079);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 66206, 66229);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAllStreams(), 1573, 66206, 66228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 66291, 66326);

                f_1573_66291_66325(this, JobState.Disconnected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 66424, 66471);

                _throttleManager.ThrottleLimit = throttleLimit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 66485, 66528);

                f_1573_66485_66527(_throttleManager, helpers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 66542, 66581);

                f_1573_66542_66580(_throttleManager);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 65205, 66592);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 65205, 66592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 65205, 66592);
            }
        }

        protected PSRemotingJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 66685, 66714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78448, 78464);
                this._moreData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79583, 79604);
                this._stopIsCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81150, 81164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82285, 82309);
                this._hideComputerName = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84583, 84616);
                this._atleastOneChildJobFailed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84703, 84730);
                this._finishedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84815, 84841);
                this._blockedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 84930, 84961);
                this._disconnectedChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85050, 85074);
                this._debugChildJobsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91913, 91932);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94782, 94822);
                this._throttleManager = f_1573_94801_94822();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94859, 94885);
                this._syncObject = f_1573_94873_94885();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 66685, 66714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 66685, 66714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 66685, 66714);
            }
        }

        private void CommonInit(int throttleLimit, List<IThrottleOperation> helpers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 66830, 67396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67041, 67064);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAllStreams(), 1573, 67041, 67063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67124, 67154);

                f_1573_67124_67153(this, JobState.Running);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67228, 67275);

                _throttleManager.ThrottleLimit = throttleLimit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67289, 67332);

                f_1573_67289_67331(_throttleManager, helpers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67346, 67385);

                f_1573_67346_67384(_throttleManager);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 66830, 67396);

                int
                f_1573_67124_67153(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 67124, 67153);
                    return 0;
                }


                int
                f_1573_67289_67331(System.Management.Automation.Remoting.ThrottleManager
                this_param, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                operations)
                {
                    this_param.SubmitOperations(operations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 67289, 67331);
                    return 0;
                }


                int
                f_1573_67346_67384(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.EndSubmitOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 67346, 67384);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 66830, 67396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 66830, 67396);
            }
        }

        internal List<Job> GetJobsForComputer(string computerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 67749, 68359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67832, 67874);

                List<Job>
                returnJobList = f_1573_67858_67873()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67890, 68311);
                    foreach (Job j in f_1573_67908_67917_I(f_1573_67908_67917()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 67890, 68311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 67951, 68002);

                        PSRemotingChildJob
                        child = j as PSRemotingChildJob
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68020, 68048) || true) && (child == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 68020, 68048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68039, 68048);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 68020, 68048);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68066, 68296) || true) && (f_1573_68070_68210(f_1573_68084_68126(f_1573_68084_68113(f_1573_68084_68098(child))), computerName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 68066, 68296);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68252, 68277);

                            f_1573_68252_68276(returnJobList, child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 68066, 68296);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 67890, 68311);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 422);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68327, 68348);

                return returnJobList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 67749, 68359);

                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1573_67858_67873()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 67858, 67873);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_67908_67917()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 67908, 67917);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_68084_68098(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 68084, 68098);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1573_68084_68113(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 68084, 68113);
                    return return_v;
                }


                string
                f_1573_68084_68126(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 68084, 68126);
                    return return_v;
                }


                bool
                f_1573_68070_68210(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 68070, 68210);
                    return return_v;
                }


                int
                f_1573_68252_68276(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.PSRemotingChildJob
                item)
                {
                    this_param.Add((System.Management.Automation.Job)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 68252, 68276);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_67908_67917_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 67908, 67917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 67749, 68359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 67749, 68359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<Job> GetJobsForRunspace(PSSession runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 68626, 69148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68708, 68750);

                List<Job>
                returnJobList = f_1573_68734_68749()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68766, 69100);
                    foreach (Job j in f_1573_68784_68793_I(f_1573_68784_68793()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 68766, 69100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68827, 68878);

                        PSRemotingChildJob
                        child = j as PSRemotingChildJob
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68896, 68924) || true) && (child == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 68896, 68924);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68915, 68924);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 68896, 68924);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 68942, 69085) || true) && (f_1573_68946_68960(child).InstanceId.Equals(f_1573_68979_68998(runspace)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 68942, 69085);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69041, 69066);

                            f_1573_69041_69065(returnJobList, child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 68942, 69085);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 68766, 69100);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69116, 69137);

                return returnJobList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 68626, 69148);

                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1573_68734_68749()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 68734, 68749);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_68784_68793()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 68784, 68793);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_68946_68960(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 68946, 68960);
                    return return_v;
                }


                System.Guid
                f_1573_68979_68998(System.Management.Automation.Runspaces.PSSession
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 68979, 68998);
                    return return_v;
                }


                int
                f_1573_69041_69065(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.PSRemotingChildJob
                item)
                {
                    this_param.Add((System.Management.Automation.Job)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 69041, 69065);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_68784_68793_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 68784, 68793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 68626, 69148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 68626, 69148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<Job> GetJobsForOperation(IThrottleOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 69419, 70006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69512, 69554);

                List<Job>
                returnJobList = f_1573_69538_69553()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69568, 69634);

                ExecutionCmdletHelper
                helper = operation as ExecutionCmdletHelper
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69650, 69958);
                    foreach (Job j in f_1573_69668_69677_I(f_1573_69668_69677()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 69650, 69958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69711, 69762);

                        PSRemotingChildJob
                        child = j as PSRemotingChildJob
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69780, 69808) || true) && (child == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 69780, 69808);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69799, 69808);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 69780, 69808);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69826, 69943) || true) && (f_1573_69830_69857(f_1573_69830_69842(child), helper))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 69826, 69943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69899, 69924);

                            f_1573_69899_69923(returnJobList, child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 69826, 69943);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 69650, 69958);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 69974, 69995);

                return returnJobList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 69419, 70006);

                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1573_69538_69553()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 69538, 69553);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_69668_69677()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 69668, 69677);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                f_1573_69830_69842(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Helper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 69830, 69842);
                    return return_v;
                }


                bool
                f_1573_69830_69857(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 69830, 69857);
                    return return_v;
                }


                int
                f_1573_69899_69923(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.PSRemotingChildJob
                item)
                {
                    this_param.Add((System.Management.Automation.Job)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 69899, 69923);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_69668_69677_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 69668, 69677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 69419, 70006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 69419, 70006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ConnectJobs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 70215, 71019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 70354, 70433);

                List<IThrottleOperation>
                connectJobOperations = f_1573_70402_70432()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 70447, 70722);
                    foreach (PSRemotingChildJob childJob in f_1573_70487_70496_I(f_1573_70487_70496()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 70447, 70722);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 70530, 70707) || true) && (f_1573_70534_70561(f_1573_70534_70555(childJob)) == JobState.Disconnected)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 70530, 70707);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 70628, 70688);

                            f_1573_70628_70687(connectJobOperations, f_1573_70653_70686(childJob));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 70530, 70707);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 70447, 70722);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 276);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 70738, 70829) || true) && (f_1573_70742_70768(connectJobOperations) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 70738, 70829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 70807, 70814);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 70738, 70829);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 70962, 71008);

                f_1573_70962_71007(this, connectJobOperations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 70215, 71019);

                System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                f_1573_70402_70432()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 70402, 70432);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_70487_70496()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 70487, 70496);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_70534_70555(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 70534, 70555);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_70534_70561(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 70534, 70561);
                    return return_v;
                }


                System.Management.Automation.PSRemotingJob.ConnectJobOperation
                f_1573_70653_70686(System.Management.Automation.PSRemotingChildJob
                job)
                {
                    var return_v = new System.Management.Automation.PSRemotingJob.ConnectJobOperation(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 70653, 70686);
                    return return_v;
                }


                int
                f_1573_70628_70687(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.PSRemotingJob.ConnectJobOperation
                item)
                {
                    this_param.Add((System.Management.Automation.Remoting.IThrottleOperation)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 70628, 70687);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_70487_70496_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 70487, 70496);
                    return return_v;
                }


                int
                f_1573_70742_70768(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 70742, 70768);
                    return return_v;
                }


                int
                f_1573_70962_71007(System.Management.Automation.PSRemotingJob
                this_param, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                connectJobOperations)
                {
                    this_param.SubmitAndWaitForConnect(connectJobOperations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 70962, 71007);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 70215, 71019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 70215, 71019);
            }
        }

        internal void ConnectJob(Guid runspaceInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 71247, 71929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 71321, 71400);

                List<IThrottleOperation>
                connectJobOperations = f_1573_71369_71399()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 71414, 71489);

                PSRemotingChildJob
                childJob = f_1573_71444_71488(this, runspaceInstanceId)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 71503, 71632) || true) && (childJob != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 71503, 71632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 71557, 71617);

                    f_1573_71557_71616(connectJobOperations, f_1573_71582_71615(childJob));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 71503, 71632);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 71648, 71739) || true) && (f_1573_71652_71678(connectJobOperations) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 71648, 71739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 71717, 71724);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 71648, 71739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 71872, 71918);

                f_1573_71872_71917(this, connectJobOperations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 71247, 71929);

                System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                f_1573_71369_71399()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 71369, 71399);
                    return return_v;
                }


                System.Management.Automation.PSRemotingChildJob
                f_1573_71444_71488(System.Management.Automation.PSRemotingJob
                this_param, System.Guid
                runspaceInstanceId)
                {
                    var return_v = this_param.FindDisconnectedChildJob(runspaceInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 71444, 71488);
                    return return_v;
                }


                System.Management.Automation.PSRemotingJob.ConnectJobOperation
                f_1573_71582_71615(System.Management.Automation.PSRemotingChildJob
                job)
                {
                    var return_v = new System.Management.Automation.PSRemotingJob.ConnectJobOperation(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 71582, 71615);
                    return return_v;
                }


                int
                f_1573_71557_71616(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.PSRemotingJob.ConnectJobOperation
                item)
                {
                    this_param.Add((System.Management.Automation.Remoting.IThrottleOperation)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 71557, 71616);
                    return 0;
                }


                int
                f_1573_71652_71678(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 71652, 71678);
                    return return_v;
                }


                int
                f_1573_71872_71917(System.Management.Automation.PSRemotingJob
                this_param, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                connectJobOperations)
                {
                    this_param.SubmitAndWaitForConnect(connectJobOperations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 71872, 71917);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 71247, 71929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 71247, 71929);
            }
        }

        private void SubmitAndWaitForConnect(List<IThrottleOperation> connectJobOperations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 71941, 73170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72049, 73159);
                using (ThrottleManager
                connectThrottleManager = f_1573_72097_72118()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72152, 73144);
                    using (ManualResetEvent
                    connectResult = f_1573_72192_72219(false)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72261, 72507);

                        EventHandler<EventArgs>
                        throttleCompleteEventHandler =
                                                    delegate (object sender, EventArgs eventArgs)
                                                    {
                                                        connectResult.Set();
                                                    }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72531, 72603);

                        connectThrottleManager.ThrottleComplete += throttleCompleteEventHandler;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72677, 72718);

                            connectThrottleManager.ThrottleLimit = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72744, 72806);

                            f_1573_72744_72805(connectThrottleManager, connectJobOperations);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72832, 72877);

                            f_1573_72832_72876(connectThrottleManager);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 72905, 72929);

                            f_1573_72905_72928(
                                                    connectResult);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1573, 72974, 73125);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 73030, 73102);

                            connectThrottleManager.ThrottleComplete -= throttleCompleteEventHandler;
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1573, 72974, 73125);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1573, 72152, 73144);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1573, 72049, 73159);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 71941, 73170);

                System.Management.Automation.Remoting.ThrottleManager
                f_1573_72097_72118()
                {
                    var return_v = new System.Management.Automation.Remoting.ThrottleManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 72097, 72118);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1573_72192_72219(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 72192, 72219);
                    return return_v;
                }


                int
                f_1573_72744_72805(System.Management.Automation.Remoting.ThrottleManager
                this_param, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                operations)
                {
                    this_param.SubmitOperations(operations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 72744, 72805);
                    return 0;
                }


                int
                f_1573_72832_72876(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.EndSubmitOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 72832, 72876);
                    return 0;
                }


                bool
                f_1573_72905_72928(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 72905, 72928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 71941, 73170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 71941, 73170);
            }
        }
        private class ConnectJobOperation : IThrottleOperation
        {
            private PSRemotingChildJob _psRemoteChildJob;

            internal ConnectJobOperation(PSRemotingChildJob job)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 73435, 73639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 73401, 73418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 73520, 73544);

                    _psRemoteChildJob = job;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 73562, 73624);

                    _psRemoteChildJob.StateChanged += ChildJobStateChangedHandler;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 73435, 73639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 73435, 73639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 73435, 73639);
                }
            }

            internal override void StartOperation()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 73655, 74598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 73727, 73759);

                    bool
                    startedSuccessfully = true
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 73823, 73856);

                        f_1573_73823_73855(_psRemoteChildJob);
                    }
                    catch (InvalidJobStateException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 73893, 74414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 73968, 73996);

                        startedSuccessfully = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74020, 74116);

                        string
                        msg = f_1573_74033_74115(f_1573_74051_74090(), f_1573_74092_74114(_psRemoteChildJob))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74138, 74186);

                        Exception
                        reason = f_1573_74157_74185(msg, e)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74208, 74331);

                        ErrorRecord
                        errorRecord = f_1573_74234_74330(reason, "PSJobConnectFailed", ErrorCategory.InvalidOperation, _psRemoteChildJob)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74353, 74395);

                        f_1573_74353_74394(_psRemoteChildJob, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 73893, 74414);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74434, 74583) || true) && (!startedSuccessfully)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 74434, 74583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74500, 74522);

                        f_1573_74500_74521(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74544, 74564);

                        f_1573_74544_74563(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 74434, 74583);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 73655, 74598);

                    int
                    f_1573_73823_73855(System.Management.Automation.PSRemotingChildJob
                    this_param)
                    {
                        this_param.ConnectAsync();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 73823, 73855);
                        return 0;
                    }


                    string
                    f_1573_74051_74090()
                    {
                        var return_v = RemotingErrorIdStrings.JobConnectFailed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 74051, 74090);
                        return return_v;
                    }


                    string
                    f_1573_74092_74114(System.Management.Automation.PSRemotingChildJob
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 74092, 74114);
                        return return_v;
                    }


                    string
                    f_1573_74033_74115(string
                    formatSpec, string
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74033, 74115);
                        return return_v;
                    }


                    System.Management.Automation.RuntimeException
                    f_1573_74157_74185(string
                    message, System.Management.Automation.InvalidJobStateException
                    innerException)
                    {
                        var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74157, 74185);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1573_74234_74330(System.Exception
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, System.Management.Automation.PSRemotingChildJob
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74234, 74330);
                        return return_v;
                    }


                    int
                    f_1573_74353_74394(System.Management.Automation.PSRemotingChildJob
                    this_param, System.Management.Automation.ErrorRecord
                    errorRecord)
                    {
                        this_param.WriteError(errorRecord);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74353, 74394);
                        return 0;
                    }


                    int
                    f_1573_74500_74521(System.Management.Automation.PSRemotingJob.ConnectJobOperation
                    this_param)
                    {
                        this_param.RemoveEventCallback();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74500, 74521);
                        return 0;
                    }


                    int
                    f_1573_74544_74563(System.Management.Automation.PSRemotingJob.ConnectJobOperation
                    this_param)
                    {
                        this_param.SendStartComplete();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74544, 74563);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 73655, 74598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 73655, 74598);
                }
            }

            internal override void StopOperation()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 74614, 75038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74685, 74707);

                    f_1573_74685_74706(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74778, 74858);

                    OperationStateEventArgs
                    operationStateEventArgs = f_1573_74828_74857()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74876, 74945);

                    operationStateEventArgs.OperationState = OperationState.StopComplete;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 74963, 75023);

                    f_1573_74963_75022(OperationComplete, this, operationStateEventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 74614, 75038);

                    int
                    f_1573_74685_74706(System.Management.Automation.PSRemotingJob.ConnectJobOperation
                    this_param)
                    {
                        this_param.RemoveEventCallback();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74685, 74706);
                        return 0;
                    }


                    System.Management.Automation.Remoting.OperationStateEventArgs
                    f_1573_74828_74857()
                    {
                        var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74828, 74857);
                        return return_v;
                    }


                    int
                    f_1573_74963_75022(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
                    eventHandler, System.Management.Automation.PSRemotingJob.ConnectJobOperation
                    sender, System.Management.Automation.Remoting.OperationStateEventArgs
                    eventArgs)
                    {
                        eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>((object)sender, eventArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 74963, 75022);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 74614, 75038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 74614, 75038);
                }
            }

            internal override event EventHandler<OperationStateEventArgs>
OperationComplete
;

            private void ChildJobStateChangedHandler(object sender, JobStateEventArgs eArgs)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 75150, 75479);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75263, 75384) || true) && (f_1573_75267_75291(f_1573_75267_75285(eArgs)) == JobState.Disconnected)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 75263, 75384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75358, 75365);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 75263, 75384);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75404, 75426);

                    f_1573_75404_75425(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75444, 75464);

                    f_1573_75444_75463(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 75150, 75479);

                    System.Management.Automation.JobStateInfo
                    f_1573_75267_75285(System.Management.Automation.JobStateEventArgs
                    this_param)
                    {
                        var return_v = this_param.JobStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 75267, 75285);
                        return return_v;
                    }


                    System.Management.Automation.JobState
                    f_1573_75267_75291(System.Management.Automation.JobStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 75267, 75291);
                        return return_v;
                    }


                    int
                    f_1573_75404_75425(System.Management.Automation.PSRemotingJob.ConnectJobOperation
                    this_param)
                    {
                        this_param.RemoveEventCallback();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 75404, 75425);
                        return 0;
                    }


                    int
                    f_1573_75444_75463(System.Management.Automation.PSRemotingJob.ConnectJobOperation
                    this_param)
                    {
                        this_param.SendStartComplete();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 75444, 75463);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 75150, 75479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 75150, 75479);
                }
            }

            private void SendStartComplete()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 75495, 75821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75560, 75640);

                    OperationStateEventArgs
                    operationStateEventArgs = f_1573_75610_75639()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75658, 75728);

                    operationStateEventArgs.OperationState = OperationState.StartComplete;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75746, 75806);

                    f_1573_75746_75805(OperationComplete, this, operationStateEventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 75495, 75821);

                    System.Management.Automation.Remoting.OperationStateEventArgs
                    f_1573_75610_75639()
                    {
                        var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 75610, 75639);
                        return return_v;
                    }


                    int
                    f_1573_75746_75805(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
                    eventHandler, System.Management.Automation.PSRemotingJob.ConnectJobOperation
                    sender, System.Management.Automation.Remoting.OperationStateEventArgs
                    eventArgs)
                    {
                        eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>((object)sender, eventArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 75746, 75805);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 75495, 75821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 75495, 75821);
                }
            }

            private void RemoveEventCallback()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 75837, 75981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 75904, 75966);

                    _psRemoteChildJob.StateChanged -= ChildJobStateChangedHandler;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 75837, 75981);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 75837, 75981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 75837, 75981);
                }
            }

            static ConnectJobOperation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 73295, 75992);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 73295, 75992);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 73295, 75992);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 73295, 75992);
        }

        internal PowerShell GetAssociatedPowerShellObject(Guid runspaceInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 76352, 76711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 76451, 76472);

                PowerShell
                ps = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 76486, 76561);

                PSRemotingChildJob
                childJob = f_1573_76516_76560(this, runspaceInstanceId)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 76575, 76674) || true) && (childJob != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 76575, 76674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 76629, 76659);

                    ps = f_1573_76634_76658(childJob);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 76575, 76674);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 76690, 76700);

                return ps;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 76352, 76711);

                System.Management.Automation.PSRemotingChildJob
                f_1573_76516_76560(System.Management.Automation.PSRemotingJob
                this_param, System.Guid
                runspaceInstanceId)
                {
                    var return_v = this_param.FindDisconnectedChildJob(runspaceInstanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 76516, 76560);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_76634_76658(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.GetPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 76634, 76658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 76352, 76711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 76352, 76711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSRemotingChildJob FindDisconnectedChildJob(Guid runspaceInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 77003, 77544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 77104, 77137);

                PSRemotingChildJob
                rtnJob = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 77153, 77503);
                    foreach (PSRemotingChildJob childJob in f_1573_77193_77207_I(f_1573_77193_77207(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 77153, 77503);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 77241, 77488) || true) && ((f_1573_77246_77263(childJob).InstanceId.Equals(runspaceInstanceId)) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 77245, 77381) && (f_1573_77328_77355(f_1573_77328_77349(childJob)) == JobState.Disconnected)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 77241, 77488);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 77423, 77441);

                            rtnJob = childJob;
                            DynAbs.Tracing.TraceSender.TraceBreak(1573, 77463, 77469);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 77241, 77488);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 77153, 77503);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 77519, 77533);

                return rtnJob;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 77003, 77544);

                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_77193_77207(System.Management.Automation.PSRemotingJob
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 77193, 77207);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_77246_77263(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 77246, 77263);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_77328_77349(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 77328, 77349);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_77328_77355(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 77328, 77355);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_77193_77207_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 77193, 77207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 77003, 77544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 77003, 77544);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void InternalStopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 77857, 78401);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 77913, 78040) || true) && (_isDisposed || (DynAbs.Tracing.TraceSender.Expression_False(1573, 77917, 77945) || _stopIsCalled) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 77917, 77984) || f_1573_77949_77984(this, f_1573_77965_77983(f_1573_77965_77977()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 77913, 78040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78018, 78025);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 77913, 78040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78062, 78073);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78107, 78246) || true) && (_isDisposed || (DynAbs.Tracing.TraceSender.Expression_False(1573, 78111, 78139) || _stopIsCalled) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 78111, 78178) || f_1573_78143_78178(this, f_1573_78159_78177(f_1573_78159_78171()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 78107, 78246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78220, 78227);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 78107, 78246);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78266, 78287);

                    _stopIsCalled = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78318, 78355);

                f_1573_78318_78354(
                            _throttleManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78371, 78390);

                f_1573_78371_78389(f_1573_78371_78379());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 77857, 78401);

                System.Management.Automation.JobStateInfo
                f_1573_77965_77977()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 77965, 77977);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_77965_77983(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 77965, 77983);
                    return return_v;
                }


                bool
                f_1573_77949_77984(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 77949, 77984);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_78159_78171()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 78159, 78171);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_78159_78177(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 78159, 78177);
                    return return_v;
                }


                bool
                f_1573_78143_78178(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 78143, 78178);
                    return return_v;
                }


                int
                f_1573_78318_78354(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.StopAllOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 78318, 78354);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1573_78371_78379()
                {
                    var return_v = Finished;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 78371, 78379);
                    return return_v;
                }


                bool
                f_1573_78371_78389(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 78371, 78389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 77857, 78401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 77857, 78401);
            }
        }

        private bool _moreData;

        public override bool HasMoreData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 78749, 79547);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 78959, 79495) || true) && (_moreData && (DynAbs.Tracing.TraceSender.Expression_True(1573, 78963, 79011) && f_1573_78976_79011(this, f_1573_78992_79010(f_1573_78992_79004()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 78959, 79495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79053, 79093);

                        bool
                        atleastOneChildHasMoreData = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79126, 79131);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79117, 79413) || true) && (i < f_1573_79137_79152(f_1573_79137_79146()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79154, 79157)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 79117, 79413))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 79117, 79413);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79207, 79390) || true) && (f_1573_79211_79235(f_1573_79211_79223(f_1573_79211_79220(), i)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 79207, 79390);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79293, 79327);

                                    atleastOneChildHasMoreData = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1573, 79357, 79363);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 79207, 79390);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 297);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 297);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79437, 79476);

                        _moreData = atleastOneChildHasMoreData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 78959, 79495);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79515, 79532);

                    return _moreData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 78749, 79547);

                    System.Management.Automation.JobStateInfo
                    f_1573_78992_79004()
                    {
                        var return_v = JobStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 78992, 79004);
                        return return_v;
                    }


                    System.Management.Automation.JobState
                    f_1573_78992_79010(System.Management.Automation.JobStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 78992, 79010);
                        return return_v;
                    }


                    bool
                    f_1573_78976_79011(System.Management.Automation.PSRemotingJob
                    this_param, System.Management.Automation.JobState
                    state)
                    {
                        var return_v = this_param.IsFinishedState(state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 78976, 79011);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_79137_79146()
                    {
                        var return_v = ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 79137, 79146);
                        return return_v;
                    }


                    int
                    f_1573_79137_79152(System.Collections.Generic.IList<System.Management.Automation.Job>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 79137, 79152);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_79211_79220()
                    {
                        var return_v = ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 79211, 79220);
                        return return_v;
                    }


                    System.Management.Automation.Job
                    f_1573_79211_79223(System.Collections.Generic.IList<System.Management.Automation.Job>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 79211, 79223);
                        return return_v;
                    }


                    bool
                    f_1573_79211_79235(System.Management.Automation.Job
                    this_param)
                    {
                        var return_v = this_param.HasMoreData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 79211, 79235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 78692, 79558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 78692, 79558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _stopIsCalled;

        public override void StopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 79685, 81123);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79874, 81078) || true) && (f_1573_79878_79896(f_1573_79878_79890()) == JobState.Disconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 79874, 81078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 79955, 79978);

                    bool
                    ConnectSuccessful
                    = default(bool);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80042, 80056);

                        f_1573_80042_80055(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80078, 80103);

                        ConnectSuccessful = true;
                    }
                    catch (InvalidRunspaceStateException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 80140, 80263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80218, 80244);

                        ConnectSuccessful = false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 80140, 80263);
                    }
                    catch (PSRemotingTransportException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 80281, 80403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80358, 80384);

                        ConnectSuccessful = false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 80281, 80403);
                    }
                    catch (PSInvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1573, 80421, 80542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80497, 80523);

                        ConnectSuccessful = false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1573, 80421, 80542);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80562, 81063) || true) && (!ConnectSuccessful && (DynAbs.Tracing.TraceSender.Expression_True(1573, 80566, 80605) && f_1573_80588_80605(f_1573_80588_80598(this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 80562, 81063);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80647, 80733);

                        string
                        msg = f_1573_80660_80732(f_1573_80678_80720(), f_1573_80722_80731(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80755, 80800);

                        Exception
                        reason = f_1573_80774_80799(msg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80822, 80967);

                        ErrorRecord
                        errorRecord = f_1573_80848_80966(reason, "StopJobCannotConnectToServer", ErrorCategory.InvalidOperation, this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 80989, 81013);

                        f_1573_80989_81012(this, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81037, 81044);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 80562, 81063);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 79874, 81078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81094, 81112);

                f_1573_81094_81111(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 79685, 81123);

                System.Management.Automation.JobStateInfo
                f_1573_79878_79890()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 79878, 79890);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_79878_79896(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 79878, 79896);
                    return return_v;
                }


                int
                f_1573_80042_80055(System.Management.Automation.PSRemotingJob
                this_param)
                {
                    this_param.ConnectJobs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 80042, 80055);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1573_80588_80598(System.Management.Automation.PSRemotingJob
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 80588, 80598);
                    return return_v;
                }


                bool
                f_1573_80588_80605(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 80588, 80605);
                    return return_v;
                }


                string
                f_1573_80678_80720()
                {
                    var return_v = RemotingErrorIdStrings.StopJobNotConnected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 80678, 80720);
                    return return_v;
                }


                string
                f_1573_80722_80731(System.Management.Automation.PSRemotingJob
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 80722, 80731);
                    return return_v;
                }


                string
                f_1573_80660_80732(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 80660, 80732);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1573_80774_80799(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 80774, 80799);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1573_80848_80966(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSRemotingJob
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 80848, 80966);
                    return return_v;
                }


                int
                f_1573_80989_81012(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 80989, 81012);
                    return 0;
                }


                int
                f_1573_81094_81111(System.Management.Automation.PSRemotingJob
                this_param)
                {
                    this_param.InternalStopJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 81094, 81111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 79685, 81123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 79685, 81123);
            }
        }

        private string _statusMessage;

        public override string StatusMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 81334, 81407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81370, 81392);

                    return _statusMessage;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 81334, 81407);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 81273, 81418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 81273, 81418);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HideComputerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 81817, 81850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81823, 81848);

                    return _hideComputerName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 81817, 81850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 81762, 82260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 81762, 82260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 81866, 82249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81902, 81928);

                    _hideComputerName = value;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 81946, 82234);
                        foreach (Job job in f_1573_81966_81980_I(f_1573_81966_81980(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 81946, 82234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82022, 82074);

                            PSRemotingChildJob
                            rJob = job as PSRemotingChildJob
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82096, 82215) || true) && (rJob != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 82096, 82215);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82162, 82192);

                                rJob.HideComputerName = value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 82096, 82215);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 81946, 82234);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 289);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 81866, 82249);

                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_81966_81980(System.Management.Automation.PSRemotingJob
                    this_param)
                    {
                        var return_v = this_param.ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 81966, 81980);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_81966_81980_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 81966, 81980);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 81762, 82260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 81762, 82260);
                }
            }
        }

        private bool _hideComputerName;

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        private void SetStatusMessage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 82474, 84452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 82617, 82641);

                _statusMessage = "test";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 82474, 84452);
                //        bool localErrors = false; // if local errors are present
                //        bool setFinished = false;    // if finished needs to be set

                //        statusMessage = "OK";

                //        lock (syncObject)
                //        {
                //            if (finishedCount == ChildJobs.Count)
                //            {
                //                // ISSUE: Change this code to look in to child jobs for exception
                //                if (errors.Count > 0)
                //                {
                //                    statusMessage = "LocalErrors";
                //                    localErrors = true;
                //                }

                //                // check for status of remote command
                //                for (int i = 0; i < ChildJobs.Count; i++)
                //                {
                //                    PSRemotingChildJob childJob = ChildJobs[i] as PSRemotingChildJob;
                //                    if (childJob == null) continue;
                //                    if (childJob.ContainsErrors)
                //                    {
                //                        if (localErrors)
                //                        {
                //                            statusMessage = "LocalAndRemoteErrors";
                //                        }
                //                        else
                //                        {
                //                            statusMessage = "RemoteErrors";
                //                        }
                //                        break;
                //                    }
                //                }

                //                setFinished = true;
                //            }
                //        }
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 82474, 84452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 82474, 84452);
            }
        }

        private bool _atleastOneChildJobFailed;

        private int _finishedChildJobsCount;

        private int _blockedChildJobsCount;

        private int _disconnectedChildJobsCount;

        private int _debugChildJobsCount;

        private void HandleChildJobStateChanged(object sender, JobStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 85295, 88519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85490, 85574);

                f_1573_85490_85573(this, f_1573_85522_85542(f_1573_85522_85536(e)), f_1573_85544_85572(f_1573_85544_85566(e)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85590, 86005) || true) && (f_1573_85594_85614(f_1573_85594_85608(e)) == JobState.Blocked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 85590, 86005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85732, 85743);
                    // increment count of blocked child jobs
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85785, 85810);

                        _blockedChildJobsCount++;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85929, 85965);

                    f_1573_85929_85964(this, JobState.Blocked, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 85983, 85990);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 85590, 86005);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86089, 86392) || true) && (f_1573_86093_86113(f_1573_86093_86107(e)) == JobState.AtBreakpoint)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 86089, 86392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86178, 86189);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86193, 86216);

                        _debugChildJobsCount++;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86317, 86352);

                    f_1573_86317_86351(this, JobState.AtBreakpoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86370, 86377);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 86089, 86392);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86478, 86915) || true) && ((f_1573_86483_86503(f_1573_86483_86497(e)) == JobState.Running) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 86482, 86600) && (f_1573_86546_86574(f_1573_86546_86568(e)) == JobState.AtBreakpoint)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 86478, 86915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86634, 86654);

                    int
                    totalDebugCount
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86678, 86689);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86693, 86734);

                        totalDebugCount = --_debugChildJobsCount;
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86756, 86900) || true) && (totalDebugCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 86756, 86900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86822, 86852);

                        f_1573_86822_86851(this, JobState.Running);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 86874, 86881);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 86756, 86900);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 86478, 86915);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87021, 87119) || true) && (!f_1573_87026_87063(this, f_1573_87042_87062(f_1573_87042_87056(e))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 87021, 87119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87097, 87104);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 87021, 87119);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87135, 87336) || true) && (f_1573_87139_87159(f_1573_87139_87153(e)) == JobState.Failed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 87135, 87336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87288, 87321);

                    _atleastOneChildJobFailed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 87135, 87336);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87352, 87386);

                bool
                allChildJobsFinished = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87406, 87417);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87451, 87477);

                    _finishedChildJobsCount++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87529, 87715) || true) && (_finishedChildJobsCount + _disconnectedChildJobsCount
                                        == f_1573_87611_87626(f_1573_87611_87620()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 87529, 87715);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87668, 87696);

                        allChildJobsFinished = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 87529, 87715);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87746, 88508) || true) && (allChildJobsFinished)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 87746, 88508);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 87967, 88493) || true) && (_disconnectedChildJobsCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 87967, 88493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88044, 88079);

                        f_1573_88044_88078(this, JobState.Disconnected);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 87967, 88493);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 87967, 88493);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88121, 88493) || true) && (_atleastOneChildJobFailed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 88121, 88493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88192, 88221);

                            f_1573_88192_88220(this, JobState.Failed);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 88121, 88493);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 88121, 88493);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88263, 88493) || true) && (_stopIsCalled == true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 88263, 88493);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88330, 88360);

                                f_1573_88330_88359(this, JobState.Stopped);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 88263, 88493);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 88263, 88493);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88442, 88474);

                                f_1573_88442_88473(this, JobState.Completed);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 88263, 88493);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 88121, 88493);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 87967, 88493);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 87746, 88508);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 85295, 88519);

                System.Management.Automation.JobStateInfo
                f_1573_85522_85536(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 85522, 85536);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_85522_85542(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 85522, 85542);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_85544_85566(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.PreviousJobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 85544, 85566);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_85544_85572(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 85544, 85572);
                    return return_v;
                }


                int
                f_1573_85490_85573(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                newState, System.Management.Automation.JobState
                prevState)
                {
                    this_param.CheckDisconnectedAndUpdateState(newState, prevState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 85490, 85573);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_85594_85608(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 85594, 85608);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_85594_85614(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 85594, 85614);
                    return return_v;
                }


                int
                f_1573_85929_85964(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 85929, 85964);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_86093_86107(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 86093, 86107);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_86093_86113(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 86093, 86113);
                    return return_v;
                }


                int
                f_1573_86317_86351(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 86317, 86351);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_86483_86497(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 86483, 86497);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_86483_86503(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 86483, 86503);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_86546_86568(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.PreviousJobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 86546, 86568);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_86546_86574(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 86546, 86574);
                    return return_v;
                }


                int
                f_1573_86822_86851(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 86822, 86851);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_87042_87056(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 87042, 87056);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_87042_87062(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 87042, 87062);
                    return return_v;
                }


                bool
                f_1573_87026_87063(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 87026, 87063);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_87139_87153(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 87139, 87153);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_87139_87159(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 87139, 87159);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_87611_87620()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 87611, 87620);
                    return return_v;
                }


                int
                f_1573_87611_87626(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 87611, 87626);
                    return return_v;
                }


                int
                f_1573_88044_88078(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 88044, 88078);
                    return 0;
                }


                int
                f_1573_88192_88220(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 88192, 88220);
                    return 0;
                }


                int
                f_1573_88330_88359(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 88330, 88359);
                    return 0;
                }


                int
                f_1573_88442_88473(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 88442, 88473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 85295, 88519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 85295, 88519);
            }
        }

        private void CheckDisconnectedAndUpdateState(JobState newState, JobState prevState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 88790, 90669);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88898, 88993) || true) && (f_1573_88902_88937(this, f_1573_88918_88936(f_1573_88918_88930())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 88898, 88993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 88971, 88978);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 88898, 88993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 89140, 89151);

                // Do all logic inside a lock to ensure it is atomic against
                // multiple job thread state changes.
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 89185, 90643) || true) && (newState == JobState.Disconnected)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 89185, 90643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 89264, 89296);

                        ++(_disconnectedChildJobsCount);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 89464, 89595) || true) && (prevState == JobState.Blocked)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 89464, 89595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 89547, 89572);

                            --_blockedChildJobsCount;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 89464, 89595);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 89770, 90039) || true) && ((_disconnectedChildJobsCount +
                                                 _finishedChildJobsCount +
                                                 _blockedChildJobsCount) == f_1573_89910_89925(f_1573_89910_89919()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 89770, 90039);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 89975, 90016);

                            f_1573_89975_90015(this, JobState.Disconnected, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 89770, 90039);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 89185, 90643);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 89185, 90643);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 90121, 90264) || true) && (prevState == JobState.Disconnected)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 90121, 90264);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 90209, 90241);

                            --(_disconnectedChildJobsCount);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 90121, 90264);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 90288, 90624) || true) && ((newState == JobState.Running) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 90292, 90371) && (f_1573_90327_90345(f_1573_90327_90339()) == JobState.Disconnected)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 90288, 90624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 90565, 90601);

                            f_1573_90565_90600(this, JobState.Running, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 90288, 90624);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 89185, 90643);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 88790, 90669);

                System.Management.Automation.JobStateInfo
                f_1573_88918_88930()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 88918, 88930);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_88918_88936(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 88918, 88936);
                    return return_v;
                }


                bool
                f_1573_88902_88937(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 88902, 88937);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_89910_89919()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 89910, 89919);
                    return return_v;
                }


                int
                f_1573_89910_89925(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 89910, 89925);
                    return return_v;
                }


                int
                f_1573_89975_90015(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 89975, 90015);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_90327_90339()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 90327, 90339);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_90327_90345(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 90327, 90345);
                    return return_v;
                }


                int
                f_1573_90565_90600(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 90565, 90600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 88790, 90669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 88790, 90669);
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 90918, 91888);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 90990, 91877) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 90990, 91877);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91037, 91120) || true) && (_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 91037, 91120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91094, 91101);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 91037, 91120);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91146, 91157);

                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91199, 91294) || true) && (_isDisposed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 91199, 91294);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91264, 91271);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 91199, 91294);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91318, 91337);

                        _isDisposed = true;
                    }

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91420, 91543) || true) && (!f_1573_91425_91460(this, f_1573_91441_91459(f_1573_91441_91453())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 91420, 91543);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91510, 91520);

                            f_1573_91510_91519(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 91420, 91543);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91567, 91683);
                            foreach (Job job in f_1573_91587_91596_I(f_1573_91587_91596()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 91567, 91683);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91646, 91660);

                                f_1573_91646_91659(job);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 91567, 91683);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 117);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 117);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91707, 91734);

                        f_1573_91707_91733(
                                            _throttleManager);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1573, 91771, 91862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 91819, 91843);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing), 1573, 91819, 91842);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1573, 91771, 91862);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 90990, 91877);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 90918, 91888);

                System.Management.Automation.JobStateInfo
                f_1573_91441_91453()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 91441, 91453);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_91441_91459(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 91441, 91459);
                    return return_v;
                }


                bool
                f_1573_91425_91460(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 91425, 91460);
                    return return_v;
                }


                int
                f_1573_91510_91519(System.Management.Automation.PSRemotingJob
                this_param)
                {
                    this_param.StopJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 91510, 91519);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_91587_91596()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 91587, 91596);
                    return return_v;
                }


                int
                f_1573_91646_91659(System.Management.Automation.Job
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 91646, 91659);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_91587_91596_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 91587, 91596);
                    return return_v;
                }


                int
                f_1573_91707_91733(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 91707, 91733);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 90918, 91888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 90918, 91888);
            }
        }

        private bool _isDisposed;

        private string ConstructLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 91945, 92429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92004, 92049);

                StringBuilder
                location = f_1573_92029_92048()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92065, 92375) || true) && (f_1573_92069_92084(f_1573_92069_92078()) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 92065, 92375);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92122, 92300);
                        foreach (PSRemotingChildJob job in f_1573_92157_92166_I(f_1573_92157_92166()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 92122, 92300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92208, 92238);

                            f_1573_92208_92237(location, f_1573_92224_92236(job));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92260, 92281);

                            f_1573_92260_92280(location, ",");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 92122, 92300);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 179);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 179);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92320, 92360);

                    f_1573_92320_92359(
                                    location, f_1573_92336_92351(location) - 1, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 92065, 92375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92391, 92418);

                return f_1573_92398_92417(location);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 91945, 92429);

                System.Text.StringBuilder
                f_1573_92029_92048()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 92029, 92048);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_92069_92078()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 92069, 92078);
                    return return_v;
                }


                int
                f_1573_92069_92084(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 92069, 92084);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_92157_92166()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 92157, 92166);
                    return return_v;
                }


                string
                f_1573_92224_92236(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 92224, 92236);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1573_92208_92237(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 92208, 92237);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1573_92260_92280(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 92260, 92280);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_92157_92166_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 92157, 92166);
                    return return_v;
                }


                int
                f_1573_92336_92351(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 92336, 92351);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1573_92320_92359(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 92320, 92359);
                    return return_v;
                }


                string
                f_1573_92398_92417(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 92398, 92417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 91945, 92429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 91945, 92429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 92597, 92675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 92633, 92660);

                    return f_1573_92640_92659(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 92597, 92675);

                    string
                    f_1573_92640_92659(System.Management.Automation.PSRemotingJob
                    this_param)
                    {
                        var return_v = this_param.ConstructLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 92640, 92659);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 92541, 92686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 92541, 92686);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool CanDisconnect
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 92972, 93236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 93162, 93221);

                    return (f_1573_93170_93185(f_1573_93170_93179()) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 93169, 93220) && f_1573_93194_93220(f_1573_93194_93206(f_1573_93194_93203(), 0)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 92972, 93236);

                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_93170_93179()
                    {
                        var return_v = ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 93170, 93179);
                        return return_v;
                    }


                    int
                    f_1573_93170_93185(System.Collections.Generic.IList<System.Management.Automation.Job>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 93170, 93185);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_93194_93203()
                    {
                        var return_v = ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 93194, 93203);
                        return return_v;
                    }


                    System.Management.Automation.Job
                    f_1573_93194_93206(System.Collections.Generic.IList<System.Management.Automation.Job>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 93194, 93206);
                        return return_v;
                    }


                    bool
                    f_1573_93194_93220(System.Management.Automation.Job
                    this_param)
                    {
                        var return_v = this_param.CanDisconnect;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 93194, 93220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 92911, 93247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 92911, 93247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<RemoteRunspace> GetRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 93461, 93803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 93546, 93606);

                List<RemoteRunspace>
                runspaces = f_1573_93579_93605()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 93620, 93759);
                    foreach (PSRemotingChildJob job in f_1573_93655_93664_I(f_1573_93655_93664()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 93620, 93759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 93698, 93744);

                        f_1573_93698_93743(runspaces, f_1573_93712_93724(job) as RemoteRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 93620, 93759);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 93775, 93792);

                return runspaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 93461, 93803);

                System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                f_1573_93579_93605()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 93579, 93605);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_93655_93664()
                {
                    var return_v = ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 93655, 93664);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_93712_93724(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 93712, 93724);
                    return return_v;
                }


                int
                f_1573_93698_93743(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
                this_param, System.Management.Automation.Runspaces.Runspace
                item)
                {
                    this_param.Add((System.Management.Automation.RemoteRunspace)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 93698, 93743);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1573_93655_93664_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 93655, 93664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 93461, 93803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 93461, 93803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleJobUnblocked(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 94232, 94711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94324, 94348);

                bool
                unblockjob = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94370, 94381);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94415, 94440);

                    _blockedChildJobsCount--;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94460, 94570) || true) && (_blockedChildJobsCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 94460, 94570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94533, 94551);

                        unblockjob = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 94460, 94570);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94601, 94700) || true) && (unblockjob)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 94601, 94700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 94649, 94685);

                    f_1573_94649_94684(this, JobState.Running, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 94601, 94700);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 94232, 94711);

                int
                f_1573_94649_94684(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 94649, 94684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 94232, 94711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 94232, 94711);
            }
        }

        private ThrottleManager _throttleManager;

        private readonly object _syncObject;

        static PSRemotingJob()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 59177, 94956);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 59177, 94956);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 59177, 94956);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 59177, 94956);

        static string[]
        f_1573_60153_60166_C(string[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 59880, 60225);
            return return_v;
        }


        static System.Management.Automation.Runspaces.PSSession[]
        f_1573_61012_61031_C(System.Management.Automation.Runspaces.PSSession[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 60821, 61086);
            return return_v;
        }


        System.Management.Automation.PSRemotingChildJob
        f_1573_62314_62422(string
        remoteCommand, Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
        helper, System.Management.Automation.Remoting.ThrottleManager
        throttleManager)
        {
            var return_v = new System.Management.Automation.PSRemotingChildJob(remoteCommand, (Microsoft.PowerShell.Commands.ExecutionCmdletHelper)helper, throttleManager);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 62314, 62422);
            return return_v;
        }


        System.Collections.Generic.IList<System.Management.Automation.Job>
        f_1573_62684_62693()
        {
            var return_v = ChildJobs;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 62684, 62693);
            return return_v;
        }


        int
        f_1573_62684_62707(System.Collections.Generic.IList<System.Management.Automation.Job>
        this_param, System.Management.Automation.PSRemotingChildJob
        item)
        {
            this_param.Add((System.Management.Automation.Job)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 62684, 62707);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        f_1573_62154_62173_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 62154, 62173);
            return return_v;
        }


        int
        f_1573_62739_62785(System.Management.Automation.PSRemotingJob
        this_param, int
        throttleLimit, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        helpers)
        {
            this_param.CommonInit(throttleLimit, helpers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 62739, 62785);
            return 0;
        }


        static string
        f_1573_61994_62007_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 61773, 62797);
            return return_v;
        }


        int
        f_1573_63769_63795(System.Management.Automation.Runspaces.PSSession[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 63769, 63795);
            return return_v;
        }


        System.Management.Automation.Remoting.IThrottleOperation
        f_1573_63904_63922(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 63904, 63922);
            return return_v;
        }


        System.Management.Automation.PSRemotingChildJob
        f_1573_64053_64149(string
        remoteCommand, Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
        helper, System.Management.Automation.Remoting.ThrottleManager
        throttleManager)
        {
            var return_v = new System.Management.Automation.PSRemotingChildJob(remoteCommand, (Microsoft.PowerShell.Commands.ExecutionCmdletHelper)helper, throttleManager);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 64053, 64149);
            return return_v;
        }


        System.Collections.Generic.IList<System.Management.Automation.Job>
        f_1573_64407_64416()
        {
            var return_v = ChildJobs;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 64407, 64416);
            return return_v;
        }


        int
        f_1573_64407_64425(System.Collections.Generic.IList<System.Management.Automation.Job>
        this_param, System.Management.Automation.PSRemotingChildJob
        item)
        {
            this_param.Add((System.Management.Automation.Job)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 64407, 64425);
            return 0;
        }


        int
        f_1573_64457_64499(System.Management.Automation.PSRemotingJob
        this_param, int
        throttleLimit, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        helpers)
        {
            this_param.CommonInit(throttleLimit, helpers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 64457, 64499);
            return 0;
        }


        static string
        f_1573_63642_63655_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 63420, 64511);
            return return_v;
        }


        System.Management.Automation.PSRemotingChildJob
        f_1573_65781_65847(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        helper, System.Management.Automation.Remoting.ThrottleManager
        throttleManager, bool
        aggregateResults)
        {
            var return_v = new System.Management.Automation.PSRemotingChildJob(helper, throttleManager, aggregateResults);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 65781, 65847);
            return return_v;
        }


        System.Collections.Generic.IList<System.Management.Automation.Job>
        f_1573_66045_66054()
        {
            var return_v = ChildJobs;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 66045, 66054);
            return return_v;
        }


        int
        f_1573_66045_66063(System.Collections.Generic.IList<System.Management.Automation.Job>
        this_param, System.Management.Automation.PSRemotingChildJob
        item)
        {
            this_param.Add((System.Management.Automation.Job)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 66045, 66063);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        f_1573_65715_65722_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 65715, 65722);
            return return_v;
        }


        int
        f_1573_66291_66325(System.Management.Automation.PSRemotingJob
        this_param, System.Management.Automation.JobState
        state)
        {
            this_param.SetJobState(state);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 66291, 66325);
            return 0;
        }


        int
        f_1573_66485_66527(System.Management.Automation.Remoting.ThrottleManager
        this_param, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        operations)
        {
            this_param.SubmitOperations(operations);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 66485, 66527);
            return 0;
        }


        int
        f_1573_66542_66580(System.Management.Automation.Remoting.ThrottleManager
        this_param)
        {
            this_param.EndSubmitOperations();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 66542, 66580);
            return 0;
        }


        static string
        f_1573_65369_65381_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 65205, 66592);
            return return_v;
        }


        System.Management.Automation.Remoting.ThrottleManager
        f_1573_94801_94822()
        {
            var return_v = new System.Management.Automation.Remoting.ThrottleManager();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 94801, 94822);
            return return_v;
        }


        object
        f_1573_94873_94885()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 94873, 94885);
            return return_v;
        }

    }
    internal class DisconnectedJobOperation : ExecutionCmdletHelper
    {
        internal DisconnectedJobOperation(Pipeline pipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 95234, 95460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 95311, 95336);

                this.pipeline = pipeline;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 95350, 95449);

                this.pipeline.StateChanged += new EventHandler<PipelineStateEventArgs>(HandlePipelineStateChanged);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 95234, 95460);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 95234, 95460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 95234, 95460);
            }
        }

        internal override void StartOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 95472, 95644);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 95472, 95644);
                // This is a no-op since disconnected jobs (pipelines) have
                // already been started.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 95472, 95644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 95472, 95644);
            }
        }

        internal override void StopOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 95656, 96517);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 95719, 96506) || true) && (f_1573_95723_95755(f_1573_95723_95749(pipeline)) == PipelineState.Running || (DynAbs.Tracing.TraceSender.Expression_False(1573, 95723, 95863) || f_1573_95801_95833(f_1573_95801_95827(pipeline)) == PipelineState.Disconnected) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 95723, 95944) || f_1573_95884_95916(f_1573_95884_95910(pipeline)) == PipelineState.NotStarted))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 95719, 96506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 96266, 96287);

                    f_1573_96266_96286(                // If the pipeline state has reached Complete/Failed/Stopped
                                                       // by the time control reaches here, then this operation
                                                       // becomes a no-op. However, an OperationComplete would have
                                                       // already been raised from the handler.
                                    pipeline);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 95719, 96506);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 95719, 96506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 96472, 96491);

                    f_1573_96472_96490(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 95719, 96506);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 95656, 96517);

                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_95723_95749(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 95723, 95749);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_95723_95755(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 95723, 95755);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_95801_95827(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 95801, 95827);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_95801_95833(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 95801, 95833);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_95884_95910(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 95884, 95910);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_95884_95916(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 95884, 95916);
                    return return_v;
                }


                int
                f_1573_96266_96286(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    this_param.StopAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 96266, 96286);
                    return 0;
                }


                int
                f_1573_96472_96490(System.Management.Automation.DisconnectedJobOperation
                this_param)
                {
                    this_param.SendStopComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 96472, 96490);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 95656, 96517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 95656, 96517);
            }
        }

        internal override event EventHandler<OperationStateEventArgs>
OperationComplete
;

        private void HandlePipelineStateChanged(object sender, PipelineStateEventArgs stateEventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 96621, 97150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 96739, 96802);

                PipelineStateInfo
                stateInfo = f_1573_96769_96801(stateEventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 96818, 97090);

                switch (f_1573_96826_96841(stateInfo))
                {

                    case PipelineState.Running:
                    case PipelineState.NotStarted:
                    case PipelineState.Stopping:
                    case PipelineState.Disconnected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 96818, 97090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 97068, 97075);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 96818, 97090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 97106, 97139);

                f_1573_97106_97138(this, stateEventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 96621, 97150);

                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_96769_96801(System.Management.Automation.Runspaces.PipelineStateEventArgs
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 96769, 96801);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_96826_96841(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 96826, 96841);
                    return return_v;
                }


                int
                f_1573_97106_97138(System.Management.Automation.DisconnectedJobOperation
                this_param, System.Management.Automation.Runspaces.PipelineStateEventArgs
                eventArgs)
                {
                    this_param.SendStopComplete((System.EventArgs)eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 97106, 97138);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 96621, 97150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 96621, 97150);
            }
        }

        private void SendStopComplete(EventArgs eventArgs = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 97162, 97552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 97244, 97324);

                OperationStateEventArgs
                operationStateEventArgs = f_1573_97294_97323()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 97338, 97384);

                operationStateEventArgs.BaseEvent = eventArgs;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 97398, 97467);

                operationStateEventArgs.OperationState = OperationState.StopComplete;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 97481, 97541);

                f_1573_97481_97540(OperationComplete, this, operationStateEventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 97162, 97552);

                System.Management.Automation.Remoting.OperationStateEventArgs
                f_1573_97294_97323()
                {
                    var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 97294, 97323);
                    return return_v;
                }


                int
                f_1573_97481_97540(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
                eventHandler, System.Management.Automation.DisconnectedJobOperation
                sender, System.Management.Automation.Remoting.OperationStateEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 97481, 97540);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 97162, 97552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 97162, 97552);
            }
        }

        static DisconnectedJobOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 95154, 97559);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 95154, 97559);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 95154, 97559);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 95154, 97559);
    }
    internal class PSRemotingChildJob : Job, IJobDebugger
    {
        internal PSRemotingChildJob(string remoteCommand, ExecutionCmdletHelper helper, ThrottleManager throttleManager)
        : base(f_1573_98512_98525_C(remoteCommand))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 98379, 99368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104190, 104223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104331, 104385);
                this.Helper = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105252, 105276);
                this._hideComputerName = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105451, 105518);
                this.DisconnectedAndBlocked = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117310, 117333);
                this._doFinishCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 118085, 118104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127698, 127717);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127743, 127763);
                this._cleanupDone = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143884, 143906);
                this._remotePipeline = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143980, 144005);
                this.SyncObject = f_1573_143993_144005();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144042, 144058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144082, 144103);
                this._stopIsCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144142, 144154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144180, 144195);
                this._isAsync = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144237, 144290);
                this._prevRunspaceAvailability = RunspaceAvailability.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98551, 98580);

                UsesResultsCollection = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98594, 98687);

                f_1573_98594_98686(f_1573_98605_98620(helper) is RemotePipeline, "Pipeline passed should be a remote pipeline");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98703, 98719);

                Helper = helper;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98733, 98769);

                Runspace = f_1573_98744_98768(f_1573_98744_98759(helper));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98783, 98835);

                _remotePipeline = f_1573_98801_98816(helper) as RemotePipeline;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98849, 98884);

                _throttleManager = throttleManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98900, 98953);

                RemoteRunspace
                remoteRS = f_1573_98926_98934() as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 98967, 99166) || true) && ((remoteRS != null) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 98971, 99055) && (f_1573_98994_99026(f_1573_98994_99020(remoteRS)) == RunspaceState.BeforeOpen)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 98967, 99166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 99089, 99151);

                    remoteRS.URIRedirectionReported += HandleURIDirectionReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 98967, 99166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 99182, 99217);

                f_1573_99182_99216(this, helper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 99233, 99299);

                f_1573_99233_99241().AvailabilityChanged += HandleRunspaceAvailabilityChanged;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 99315, 99357);

                f_1573_99315_99356(this, throttleManager);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 98379, 99368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 98379, 99368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 98379, 99368);
            }
        }

        internal PSRemotingChildJob(ExecutionCmdletHelper helper, ThrottleManager throttleManager, bool aggregateResults = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 100066, 101512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104190, 104223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104331, 104385);
                this.Helper = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105252, 105276);
                this._hideComputerName = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105451, 105518);
                this.DisconnectedAndBlocked = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117310, 117333);
                this._doFinishCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 118085, 118104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127698, 127717);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127743, 127763);
                this._cleanupDone = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143884, 143906);
                this._remotePipeline = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143980, 144005);
                this.SyncObject = f_1573_143993_144005();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144042, 144058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144082, 144103);
                this._stopIsCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144142, 144154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144180, 144195);
                this._isAsync = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144237, 144290);
                this._prevRunspaceAvailability = RunspaceAvailability.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100212, 100241);

                UsesResultsCollection = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100255, 100357);

                f_1573_100255_100356((f_1573_100267_100282(helper) is RemotePipeline), "Helper pipeline object should be a remote pipeline");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100371, 100512);

                f_1573_100371_100511((f_1573_100383_100422(f_1573_100383_100416(f_1573_100383_100398(helper))) == PipelineState.Disconnected), "Remote pipeline object must be in Disconnected state.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100528, 100544);

                Helper = helper;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100558, 100610);

                _remotePipeline = f_1573_100576_100591(helper) as RemotePipeline;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100624, 100660);

                Runspace = f_1573_100635_100659(f_1573_100635_100650(helper));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100674, 100709);

                _throttleManager = throttleManager;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100725, 101174) || true) && (aggregateResults)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 100725, 101174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100779, 100814);

                    f_1573_100779_100813(this, helper);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 100725, 101174);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 100725, 101174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100880, 100981);

                    _remotePipeline.StateChanged += new EventHandler<PipelineStateEventArgs>(HandlePipelineStateChanged);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 100999, 101071);

                    f_1573_100999_101021(_remotePipeline).DataReady += new EventHandler(HandleOutputReady);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 101089, 101159);

                    f_1573_101089_101110(_remotePipeline).DataReady += new EventHandler(HandleErrorReady);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 100725, 101174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 101190, 101256);

                f_1573_101190_101198().AvailabilityChanged += HandleRunspaceAvailabilityChanged;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 101272, 101332);

                IThrottleOperation
                operation = helper as IThrottleOperation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 101346, 101444);

                operation.OperationComplete += new EventHandler<OperationStateEventArgs>(HandleOperationComplete);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 101460, 101501);

                f_1573_101460_101500(this, JobState.Disconnected, null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 100066, 101512);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 100066, 101512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 100066, 101512);
            }
        }

        protected PSRemotingChildJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 101605, 101657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104190, 104223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104331, 104385);
                this.Helper = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105252, 105276);
                this._hideComputerName = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105451, 105518);
                this.DisconnectedAndBlocked = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117310, 117333);
                this._doFinishCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 118085, 118104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127698, 127717);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127743, 127763);
                this._cleanupDone = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143884, 143906);
                this._remotePipeline = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143980, 144005);
                this.SyncObject = f_1573_143993_144005();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144042, 144058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144082, 144103);
                this._stopIsCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144142, 144154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144180, 144195);
                this._isAsync = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144237, 144290);
                this._prevRunspaceAvailability = RunspaceAvailability.None;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 101605, 101657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 101605, 101657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 101605, 101657);
            }
        }

        internal void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 101863, 102125);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 101916, 102067) || true) && (f_1573_101920_101938(f_1573_101920_101932()) != JobState.Disconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 101916, 102067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 101997, 102052);

                    throw f_1573_102003_102051(f_1573_102032_102050(f_1573_102032_102044()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 101916, 102067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102083, 102114);

                f_1573_102083_102113(
                            _remotePipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 101863, 102125);

                System.Management.Automation.JobStateInfo
                f_1573_101920_101932()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 101920, 101932);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_101920_101938(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 101920, 101938);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_102032_102044()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 102032, 102044);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_102032_102050(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 102032, 102050);
                    return return_v;
                }


                System.Management.Automation.InvalidJobStateException
                f_1573_102003_102051(System.Management.Automation.JobState
                currentState)
                {
                    var return_v = new System.Management.Automation.InvalidJobStateException(currentState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 102003, 102051);
                    return return_v;
                }


                int
                f_1573_102083_102113(System.Management.Automation.RemotePipeline
                this_param)
                {
                    this_param.ConnectAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 102083, 102113);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 101863, 102125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 101863, 102125);
            }
        }

        public override void StopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 102297, 103135);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102352, 102479) || true) && (_isDisposed || (DynAbs.Tracing.TraceSender.Expression_False(1573, 102356, 102384) || _stopIsCalled) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 102356, 102423) || f_1573_102388_102423(this, f_1573_102404_102422(f_1573_102404_102416()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 102352, 102479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102457, 102464);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 102352, 102479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102501, 102511);

                lock (SyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102545, 102684) || true) && (_isDisposed || (DynAbs.Tracing.TraceSender.Expression_False(1573, 102549, 102577) || _stopIsCalled) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 102549, 102616) || f_1573_102581_102616(this, f_1573_102597_102615(f_1573_102597_102609()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 102545, 102684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102658, 102665);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 102545, 102684);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102704, 102725);

                    _stopIsCalled = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 102756, 102795);

                f_1573_102756_102794(
                            _throttleManager, f_1573_102787_102793());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 103105, 103124);

                f_1573_103105_103123(f_1573_103105_103113());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 102297, 103135);

                System.Management.Automation.JobStateInfo
                f_1573_102404_102416()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 102404, 102416);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_102404_102422(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 102404, 102422);
                    return return_v;
                }


                bool
                f_1573_102388_102423(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 102388, 102423);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_102597_102609()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 102597, 102609);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_102597_102615(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 102597, 102615);
                    return return_v;
                }


                bool
                f_1573_102581_102616(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 102581, 102616);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                f_1573_102787_102793()
                {
                    var return_v = Helper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 102787, 102793);
                    return return_v;
                }


                int
                f_1573_102756_102794(System.Management.Automation.Remoting.ThrottleManager
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                operation)
                {
                    this_param.StopOperation((System.Management.Automation.Remoting.IThrottleOperation)operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 102756, 102794);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1573_103105_103113()
                {
                    var return_v = Finished;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 103105, 103113);
                    return return_v;
                }


                bool
                f_1573_103105_103123(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 103105, 103123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 102297, 103135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 102297, 103135);
            }
        }

        public override string StatusMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 103365, 103478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 103443, 103463);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 103365, 103478);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 103304, 103489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 103304, 103489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasMoreData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 103686, 103782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 103722, 103767);

                    return (f_1573_103730_103744(f_1573_103730_103737()) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 103730, 103765) || f_1573_103748_103761(f_1573_103748_103755()) > 0));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 103686, 103782);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                    f_1573_103730_103737()
                    {
                        var return_v = Results;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 103730, 103737);
                        return return_v;
                    }


                    bool
                    f_1573_103730_103744(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                    this_param)
                    {
                        var return_v = this_param.IsOpen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 103730, 103744);
                        return return_v;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                    f_1573_103748_103755()
                    {
                        var return_v = Results;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 103748, 103755);
                        return return_v;
                    }


                    int
                    f_1573_103748_103761(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 103748, 103761);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 103629, 103793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 103629, 103793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 103989, 104120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104025, 104105);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1573, 104032, 104050) || (((f_1573_104033_104041() != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1573, 104053, 104089)) || DynAbs.Tracing.TraceSender.Conditional_F3(1573, 104092, 104104))) ? f_1573_104053_104089(f_1573_104053_104076(f_1573_104053_104061())) : string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 103989, 104120);

                    System.Management.Automation.Runspaces.Runspace
                    f_1573_104033_104041()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 104033, 104041);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1573_104053_104061()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 104053, 104061);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceConnectionInfo
                    f_1573_104053_104076(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.ConnectionInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 104053, 104076);
                        return return_v;
                    }


                    string
                    f_1573_104053_104089(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                    this_param)
                    {
                        var return_v = this_param.ComputerName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 104053, 104089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 103933, 104131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 103933, 104131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Runspace Runspace { get; }

        internal ExecutionCmdletHelper Helper { get; }

        internal bool HideComputerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 104784, 104817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104790, 104815);

                    return _hideComputerName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 104784, 104817);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 104729, 105227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 104729, 105227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 104833, 105216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104869, 104895);

                    _hideComputerName = value;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104913, 105201);
                        foreach (Job job in f_1573_104933_104947_I(f_1573_104933_104947(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 104913, 105201);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 104989, 105041);

                            PSRemotingChildJob
                            rJob = job as PSRemotingChildJob
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105063, 105182) || true) && (rJob != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 105063, 105182);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105129, 105159);

                                rJob.HideComputerName = value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 105063, 105182);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 104913, 105201);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 289);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 104833, 105216);

                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_104933_104947(System.Management.Automation.PSRemotingChildJob
                    this_param)
                    {
                        var return_v = this_param.ChildJobs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 104933, 104947);
                        return return_v;
                    }


                    System.Collections.Generic.IList<System.Management.Automation.Job>
                    f_1573_104933_104947_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 104933, 104947);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 104729, 105227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 104729, 105227);
                }
            }
        }

        private bool _hideComputerName;

        internal bool DisconnectedAndBlocked { get; private set; }

        internal override bool CanDisconnect
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 105804, 105985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105840, 105893);

                    RemoteRunspace
                    remoteRS = f_1573_105866_105874() as RemoteRunspace
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 105911, 105970);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1573, 105918, 105936) || (((remoteRS != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1573, 105939, 105961)) || DynAbs.Tracing.TraceSender.Conditional_F3(1573, 105964, 105969))) ? f_1573_105939_105961(remoteRS) : false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 105804, 105985);

                    System.Management.Automation.Runspaces.Runspace
                    f_1573_105866_105874()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 105866, 105874);
                        return return_v;
                    }


                    bool
                    f_1573_105939_105961(System.Management.Automation.RemoteRunspace
                    this_param)
                    {
                        var return_v = this_param.CanDisconnect;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 105939, 105961);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 105743, 105996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 105743, 105996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Debugger Debugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 106196, 106716);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 106232, 106661) || true) && (_jobDebugger == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 106232, 106661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 106304, 106319);
                        lock (this.SyncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 106369, 106619) || true) && ((_jobDebugger == null) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 106373, 106455) && (f_1573_106429_106446(f_1573_106429_106437()) != null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 106369, 106619);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 106513, 106592);

                                _jobDebugger = f_1573_106528_106591(f_1573_106552_106569(f_1573_106552_106560()), f_1573_106571_106579(), f_1573_106581_106590(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 106369, 106619);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 106232, 106661);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 106681, 106701);

                    return _jobDebugger;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 106196, 106716);

                    System.Management.Automation.Runspaces.Runspace
                    f_1573_106429_106437()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 106429, 106437);
                        return return_v;
                    }


                    System.Management.Automation.Debugger
                    f_1573_106429_106446(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.Debugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 106429, 106446);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1573_106552_106560()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 106552, 106560);
                        return return_v;
                    }


                    System.Management.Automation.Debugger
                    f_1573_106552_106569(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.Debugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 106552, 106569);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1573_106571_106579()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 106571, 106579);
                        return return_v;
                    }


                    string
                    f_1573_106581_106590(System.Management.Automation.PSRemotingChildJob
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 106581, 106590);
                        return return_v;
                    }


                    System.Management.Automation.RemotingJobDebugger
                    f_1573_106528_106591(System.Management.Automation.Debugger
                    debugger, System.Management.Automation.Runspaces.Runspace
                    runspace, string
                    jobName)
                    {
                        var return_v = new System.Management.Automation.RemotingJobDebugger(debugger, runspace, jobName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 106528, 106591);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 106147, 106727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 106147, 106727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 106891, 106915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 106897, 106913);

                    return _isAsync;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 106891, 106915);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 106847, 106966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 106847, 106966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 106931, 106955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 106937, 106953);

                    _isAsync = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 106931, 106955);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 106847, 106966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 106847, 106966);
                }
            }
        }

        private void HandleOutputReady(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 107425, 109749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 107516, 107658);

                PSDataCollectionPipelineReader<PSObject, PSObject>
                reader =
                                    sender as PSDataCollectionPipelineReader<PSObject, PSObject>
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 107674, 107729);

                Collection<PSObject>
                output = f_1573_107704_107728(reader)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 107745, 109738);
                    foreach (PSObject dataObject in f_1573_107777_107783_I(output))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 107745, 109738);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 108033, 109674) || true) && (dataObject != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 108033, 109674);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 108312, 108535) || true) && (f_1573_108316_108381(f_1573_108316_108337(dataObject), RemotingConstants.ComputerNameNoteProperty) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 108312, 108535);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 108439, 108512);

                                f_1573_108439_108511(f_1573_108439_108460(dataObject), RemotingConstants.ComputerNameNoteProperty);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 108312, 108535);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 108559, 108778) || true) && (f_1573_108563_108626(f_1573_108563_108584(dataObject), RemotingConstants.RunspaceIdNoteProperty) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 108559, 108778);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 108684, 108755);

                                f_1573_108684_108754(f_1573_108684_108705(dataObject), RemotingConstants.RunspaceIdNoteProperty);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 108559, 108778);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 108802, 108913);

                            f_1573_108802_108912(f_1573_108802_108823(dataObject), f_1573_108828_108911(RemotingConstants.ComputerNameNoteProperty, f_1573_108891_108910(reader)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 108935, 109042);

                            f_1573_108935_109041(f_1573_108935_108956(dataObject), f_1573_108961_109040(RemotingConstants.RunspaceIdNoteProperty, f_1573_109022_109039(reader)));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 109306, 109655) || true) && (f_1573_109310_109379(f_1573_109310_109331(dataObject), RemotingConstants.ShowComputerNameNoteProperty) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 109306, 109655);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 109437, 109560);

                                PSNoteProperty
                                showComputerNameNP = f_1573_109473_109559(RemotingConstants.ShowComputerNameNoteProperty, !_hideComputerName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 109586, 109632);

                                f_1573_109586_109631(f_1573_109586_109607(dataObject), showComputerNameNP);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 109306, 109655);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 108033, 109674);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 109694, 109723);

                        f_1573_109694_109722(
                                        this, dataObject);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 107745, 109738);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 1994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 1994);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 107425, 109749);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1573_107704_107728(System.Management.Automation.Internal.PSDataCollectionPipelineReader<System.Management.Automation.PSObject, System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.NonBlockingRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 107704, 107728);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_108316_108337(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108316, 108337);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1573_108316_108381(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108316, 108381);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_108439_108460(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108439, 108460);
                    return return_v;
                }


                int
                f_1573_108439_108511(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 108439, 108511);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_108563_108584(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108563, 108584);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1573_108563_108626(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108563, 108626);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_108684_108705(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108684, 108705);
                    return return_v;
                }


                int
                f_1573_108684_108754(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 108684, 108754);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_108802_108823(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108802, 108823);
                    return return_v;
                }


                string
                f_1573_108891_108910(System.Management.Automation.Internal.PSDataCollectionPipelineReader<System.Management.Automation.PSObject, System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108891, 108910);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1573_108828_108911(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 108828, 108911);
                    return return_v;
                }


                int
                f_1573_108802_108912(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 108802, 108912);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_108935_108956(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 108935, 108956);
                    return return_v;
                }


                System.Guid
                f_1573_109022_109039(System.Management.Automation.Internal.PSDataCollectionPipelineReader<System.Management.Automation.PSObject, System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspaceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 109022, 109039);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1573_108961_109040(string
                name, System.Guid
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 108961, 109040);
                    return return_v;
                }


                int
                f_1573_108935_109041(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 108935, 109041);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_109310_109331(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 109310, 109331);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1573_109310_109379(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 109310, 109379);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1573_109473_109559(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 109473, 109559);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1573_109586_109607(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 109586, 109607);
                    return return_v;
                }


                int
                f_1573_109586_109631(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 109586, 109631);
                    return 0;
                }


                int
                f_1573_109694_109722(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.PSObject
                outputObject)
                {
                    this_param.WriteObject((object)outputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 109694, 109722);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1573_107777_107783_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 107777, 107783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 107425, 109749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 107425, 109749);
            }
        }

        private void HandleErrorReady(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 110149, 111141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110239, 110379);

                PSDataCollectionPipelineReader<ErrorRecord, object>
                reader =
                                sender as PSDataCollectionPipelineReader<ErrorRecord, object>
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110395, 110447);

                Collection<object>
                error = f_1573_110422_110446(reader)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110463, 111130);
                    foreach (object errorData in f_1573_110492_110497_I(error))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 110463, 111130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110531, 110573);

                        ErrorRecord
                        er = errorData as ErrorRecord
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110591, 111115) || true) && (er != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 110591, 111115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110647, 110726);

                            OriginInfo
                            originInfo = f_1573_110671_110725(f_1573_110686_110705(reader), f_1573_110707_110724(reader))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110750, 110849);

                            RemotingErrorRecord
                            errorRecord =
                            f_1573_110809_110848(er, originInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 110871, 110917);

                            errorRecord.PreserveInvocationInfoOnce = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 111067, 111096);

                            f_1573_111067_111095(
                                                // ISSUE: Add an Assert for ErrorRecord.
                                                // Add to the PSRemotingChild jobs streams
                                                this, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 110591, 111115);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 110463, 111130);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 668);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 110149, 111141);

                System.Collections.ObjectModel.Collection<object>
                f_1573_110422_110446(System.Management.Automation.Internal.PSDataCollectionPipelineReader<System.Management.Automation.ErrorRecord, object>
                this_param)
                {
                    var return_v = this_param.NonBlockingRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 110422, 110446);
                    return return_v;
                }


                string
                f_1573_110686_110705(System.Management.Automation.Internal.PSDataCollectionPipelineReader<System.Management.Automation.ErrorRecord, object>
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 110686, 110705);
                    return return_v;
                }


                System.Guid
                f_1573_110707_110724(System.Management.Automation.Internal.PSDataCollectionPipelineReader<System.Management.Automation.ErrorRecord, object>
                this_param)
                {
                    var return_v = this_param.RunspaceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 110707, 110724);
                    return return_v;
                }


                System.Management.Automation.Remoting.OriginInfo
                f_1573_110671_110725(string
                computerName, System.Guid
                runspaceID)
                {
                    var return_v = new System.Management.Automation.Remoting.OriginInfo(computerName, runspaceID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 110671, 110725);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RemotingErrorRecord
                f_1573_110809_110848(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.Remoting.OriginInfo
                originInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RemotingErrorRecord(errorRecord, originInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 110809, 110848);
                    return return_v;
                }


                int
                f_1573_111067_111095(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.Runspaces.RemotingErrorRecord
                errorRecord)
                {
                    this_param.WriteError((System.Management.Automation.ErrorRecord)errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 111067, 111095);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1573_110492_110497_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 110492, 110497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 110149, 111141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 110149, 111141);
            }
        }

        protected void HandleURIDirectionReported(object sender, RemoteDataEventArgs<Uri> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 111459, 111743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 111576, 111691);

                string
                message = f_1573_111593_111690(f_1573_111611_111658(), f_1573_111660_111689(f_1573_111660_111674(eventArgs)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 111705, 111732);

                f_1573_111705_111731(this, message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 111459, 111743);

                string
                f_1573_111611_111658()
                {
                    var return_v = RemotingErrorIdStrings.URIRedirectWarningToHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 111611, 111658);
                    return return_v;
                }


                System.Uri
                f_1573_111660_111674(System.Management.Automation.RemoteDataEventArgs<System.Uri>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 111660, 111674);
                    return return_v;
                }


                string
                f_1573_111660_111689(System.Uri
                this_param)
                {
                    var return_v = this_param.OriginalString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 111660, 111689);
                    return return_v;
                }


                string
                f_1573_111593_111690(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 111593, 111690);
                    return return_v;
                }


                int
                f_1573_111705_111731(System.Management.Automation.PSRemotingChildJob
                this_param, string
                message)
                {
                    this_param.WriteWarning(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 111705, 111731);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 111459, 111743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 111459, 111743);
            }
        }

        private void HandleHostCalls(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 111968, 113114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112057, 112111);

                ObjectStream
                hostCallsStream = sender as ObjectStream
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112127, 113103) || true) && (hostCallsStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 112127, 113103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112188, 112309);

                    Collection<object>
                    hostCallMethodExecutors =
                    f_1573_112254_112308(hostCallsStream, f_1573_112286_112307(hostCallsStream))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112335, 112345);

                    lock (SyncObject)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112387, 113069);
                            foreach (ClientMethodExecutor hostCallMethodExecutor in f_1573_112443_112466_I(hostCallMethodExecutors))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 112387, 113069);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112516, 112607);

                                f_1573_112516_112606(f_1573_112516_112523(), f_1573_112528_112605(PSStreamObjectType.MethodExecutor, hostCallMethodExecutor));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112843, 113046) || true) && (f_1573_112847_112891(f_1573_112847_112884(hostCallMethodExecutor)) != ServerDispatchTable.VoidCallId)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 112843, 113046);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 112983, 113019);

                                    f_1573_112983_113018(this, JobState.Blocked, null);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 112843, 113046);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 112387, 113069);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 683);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 683);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 112127, 113103);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 111968, 113114);

                int
                f_1573_112286_112307(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 112286, 112307);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1573_112254_112308(System.Management.Automation.Internal.ObjectStream
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 112254, 112308);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_112516_112523()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 112516, 112523);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_112528_112605(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.Remoting.ClientMethodExecutor
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 112528, 112605);
                    return return_v;
                }


                int
                f_1573_112516_112606(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 112516, 112606);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1573_112847_112884(System.Management.Automation.Remoting.ClientMethodExecutor
                this_param)
                {
                    var return_v = this_param.RemoteHostCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 112847, 112884);
                    return return_v;
                }


                long
                f_1573_112847_112891(System.Management.Automation.Remoting.RemoteHostCall
                this_param)
                {
                    var return_v = this_param.CallId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 112847, 112891);
                    return return_v;
                }


                int
                f_1573_112983_113018(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 112983, 113018);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1573_112443_112466_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 112443, 112466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 111968, 113114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 111968, 113114);
            }
        }

        protected virtual void HandlePipelineStateChanged(object sender, PipelineStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 113302, 114962);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 113417, 113749) || true) && ((f_1573_113422_113430() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 113421, 113495) && (f_1573_113444_113469(f_1573_113444_113463(e)) != PipelineState.Running)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 113417, 113749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 113654, 113734);

                    ((RemoteRunspace)f_1573_113671_113679()).URIRedirectionReported -= HandleURIDirectionReported;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 113417, 113749);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 113765, 113813);

                PipelineState
                state = f_1573_113787_113812(f_1573_113787_113806(e))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 113827, 114507);

                switch (state)
                {

                    case PipelineState.Running:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 113827, 114507);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 113923, 114237) || true) && (f_1573_113927_113949())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 113923, 114237);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 113999, 114030);

                            DisconnectedAndBlocked = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 114056, 114086);

                            f_1573_114056_114085(this, JobState.Blocked);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 113923, 114237);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 113923, 114237);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 114184, 114214);

                            f_1573_114184_114213(this, JobState.Running);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 113923, 114237);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1573, 114261, 114267);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 113827, 114507);

                    case PipelineState.Disconnected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 113827, 114507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 114341, 114407);

                        DisconnectedAndBlocked = (f_1573_114367_114385(f_1573_114367_114379()) == JobState.Blocked);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 114429, 114464);

                        f_1573_114429_114463(this, JobState.Disconnected);
                        DynAbs.Tracing.TraceSender.TraceBreak(1573, 114486, 114492);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 113827, 114507);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 113302, 114962);

                System.Management.Automation.Runspaces.Runspace
                f_1573_113422_113430()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 113422, 113430);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_113444_113463(System.Management.Automation.Runspaces.PipelineStateEventArgs
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 113444, 113463);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_113444_113469(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 113444, 113469);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_113671_113679()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 113671, 113679);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_113787_113806(System.Management.Automation.Runspaces.PipelineStateEventArgs
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 113787, 113806);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_113787_113812(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 113787, 113812);
                    return return_v;
                }


                bool
                f_1573_113927_113949()
                {
                    var return_v = DisconnectedAndBlocked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 113927, 113949);
                    return return_v;
                }


                int
                f_1573_114056_114085(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 114056, 114085);
                    return 0;
                }


                int
                f_1573_114184_114213(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 114184, 114213);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1573_114367_114379()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 114367, 114379);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_114367_114385(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 114367, 114385);
                    return return_v;
                }


                int
                f_1573_114429_114463(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 114429, 114463);
                    return 0;
                }


                // Question: Why is the DoFinish() call on terminal pipeline state deleted
                // Answer: Because in the runspace case, when pipeline reaches a terminal state
                // OperationComplete will be raised and DoFinish() is called on OperationComplete
                // In the computer name case, once pipeline reaches a terminal state, runspace is
                // closed which will result in an OperationComplete event
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 113302, 114962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 113302, 114962);
            }
        }

        private void HandleThrottleComplete(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 115202, 116128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 116106, 116117);

                f_1573_116106_116116(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 115202, 116128);

                int
                f_1573_116106_116116(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    this_param.DoFinish();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 116106, 116116);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 115202, 116128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 115202, 116128);
            }
        }

        protected virtual void HandleOperationComplete(object sender, OperationStateEventArgs stateEventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 116382, 117285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117058, 117121);

                ExecutionCmdletHelper
                helper = sender as ExecutionCmdletHelper
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117135, 117225);

                f_1573_117135_117224(helper != null, "Sender of OperationComplete has to be ExecutionCmdletHelper");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117241, 117274);

                f_1573_117241_117273(this, helper);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 116382, 117285);

                int
                f_1573_117135_117224(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 117135, 117224);
                    return 0;
                }


                int
                f_1573_117241_117273(System.Management.Automation.PSRemotingChildJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper)
                {
                    this_param.DeterminedAndSetJobState(helper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 117241, 117273);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 116382, 117285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 116382, 117285);
            }
        }

        private bool _doFinishCalled;

        protected virtual void DoFinish()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 117523, 117913);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117581, 117634) || true) && (_doFinishCalled == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 117581, 117634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117627, 117634);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 117581, 117634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117656, 117666);

                lock (SyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117700, 117757) || true) && (_doFinishCalled == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 117700, 117757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117750, 117757);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 117700, 117757);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117777, 117800);

                    _doFinishCalled = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117831, 117864);

                f_1573_117831_117863(this, f_1573_117856_117862());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 117880, 117902);

                f_1573_117880_117901(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 117523, 117913);

                Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                f_1573_117856_117862()
                {
                    var return_v = Helper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 117856, 117862);
                    return return_v;
                }


                int
                f_1573_117831_117863(System.Management.Automation.PSRemotingChildJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper)
                {
                    this_param.DeterminedAndSetJobState(helper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 117831, 117863);
                    return 0;
                }


                int
                f_1573_117880_117901(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    this_param.DoCleanupOnFinished();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 117880, 117901);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 117523, 117913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 117523, 117913);
            }
        }

        private ErrorRecord _failureErrorRecord;

        internal ErrorRecord FailureErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 118397, 118475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 118433, 118460);

                    return _failureErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 118397, 118475);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 118333, 118486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 118333, 118486);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void ProcessJobFailure(ExecutionCmdletHelper helper, out Exception failureException,
                                    out ErrorRecord failureErrorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 118766, 126782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119530, 119575);

                f_1573_119530_119574(helper != null, "helper is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119591, 119651);

                RemotePipeline
                pipeline = f_1573_119617_119632(helper) as RemotePipeline
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119665, 119714);

                f_1573_119665_119713(pipeline != null, "pipeline is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119730, 119797);

                RemoteRunspace
                runspace = f_1573_119756_119778(pipeline) as RemoteRunspace
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119811, 119860);

                f_1573_119811_119859(runspace != null, "runspace is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119876, 119900);

                failureException = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119914, 119940);

                failureErrorRecord = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 119956, 126771) || true) && (f_1573_119960_119984(helper) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 119956, 126771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120026, 120075);

                    string
                    errorId = "RemotePipelineExecutionFailed"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120093, 120137);

                    failureException = f_1573_120112_120136(helper);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120155, 120656) || true) && ((failureException is InvalidRunspaceStateException) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 120159, 120269) || (failureException is InvalidRunspacePoolStateException)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 120155, 120656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120311, 120343);

                        errorId = "InvalidSessionState";

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120365, 120637) || true) && (!f_1573_120370_120415(f_1573_120391_120414(failureException)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 120365, 120637);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120465, 120614);

                            errorId = f_1573_120475_120613(f_1573_120489_120538(), "{0},{1}", errorId, f_1573_120589_120612(failureException));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 120365, 120637);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 120155, 120656);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120676, 120841);

                    failureErrorRecord = f_1573_120697_120840(f_1573_120713_120737(helper), errorId, ErrorCategory.OperationStopped, helper);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 119956, 126771);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 119956, 126771);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 120943, 126771) || true) && ((f_1573_120948_120980(f_1573_120948_120974(runspace)) == RunspaceState.Broken) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 120947, 121074) || (f_1573_121032_121065(f_1573_121032_121058(runspace)) != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 120943, 126771);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 121108, 121161);

                        failureException = f_1573_121127_121160(f_1573_121127_121153(runspace));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 121179, 121238);

                        object
                        targetObject = f_1573_121201_121237(f_1573_121201_121224(runspace))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 121258, 121285);

                        string
                        errorDetails = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 121520, 121644);

                        PSRemotingTransportException
                        transException =
                                                    failureException as PSRemotingTransportException
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 121664, 121947);

                        string
                        fullyQualifiedErrorId =
                        f_1573_121716_121946((DynAbs.Tracing.TraceSender.Conditional_F1(1573, 121841, 121865) || (((transException != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1573, 121868, 121892)) || DynAbs.Tracing.TraceSender.Conditional_F3(1573, 121895, 121896))) ? f_1573_121868_121892(transException) : 0, "PSSessionStateBroken")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 121967, 123416) || true) && (transException != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 121967, 123416);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 122035, 122100);

                            errorDetails = "[" + f_1573_122056_122092(f_1573_122056_122079(runspace)) + "] ";

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 122124, 123397) || true) && (f_1573_122128_122152(transException) ==
                                                    Remoting.Client.WSManNativeApi.ERROR_WSMAN_REDIRECT_REQUESTED)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 122124, 123397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 122515, 122928);

                                string
                                message = f_1573_122532_122927(f_1573_122609_122654(), f_1573_122685_122707(transException), "MaximumConnectionRedirectionCount", Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet.DEFAULT_SESSION_OPTION, "AllowRedirection")
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 122956, 122980);

                                errorDetails += message;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 122124, 123397);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 122124, 123397);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 123030, 123397) || true) && (!f_1573_123035_123079(f_1573_123056_123078(transException)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 123030, 123397);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 123129, 123168);

                                    errorDetails += f_1573_123145_123167(transException);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 123030, 123397);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 123030, 123397);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 123218, 123397) || true) && (!f_1573_123223_123276(f_1573_123244_123275(transException)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 123218, 123397);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 123326, 123374);

                                        errorDetails += f_1573_123342_123373(transException);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 123218, 123397);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 123030, 123397);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 122124, 123397);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 121967, 123416);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 123436, 123787) || true) && (failureException == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 123436, 123787);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 123506, 123768);

                            failureException = f_1573_123525_123767(f_1573_123572_123766(f_1573_123649_123702(), f_1573_123733_123765(f_1573_123733_123759(runspace))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 123436, 123787);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 123807, 124040);

                        failureErrorRecord = f_1573_123828_124039(failureException, targetObject, fullyQualifiedErrorId, ErrorCategory.OpenError, null, null, null, null, null, errorDetails, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 120943, 126771);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 120943, 126771);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124074, 126771) || true) && ((f_1573_124079_124111(f_1573_124079_124105(pipeline)) == PipelineState.Failed) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 124078, 124361) || ((f_1573_124164_124196(f_1573_124164_124190(pipeline)) == PipelineState.Stopped) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 124163, 124360) && (f_1573_124250_124283(f_1573_124250_124276(pipeline)) != null && (DynAbs.Tracing.TraceSender.Expression_True(1573, 124250, 124359) && !(f_1573_124297_124330(f_1573_124297_124323(pipeline)) is PipelineStoppedException)))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 124074, 126771);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124528, 124587);

                            object
                            targetObject = f_1573_124550_124586(f_1573_124550_124573(runspace))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124605, 124658);

                            failureException = f_1573_124624_124657(f_1573_124624_124650(pipeline));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124676, 126756) || true) && (failureException != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 124676, 126756);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124746, 124811);

                                RemoteException
                                rException = failureException as RemoteException
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124835, 124866);

                                ErrorRecord
                                errorRecord = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124888, 126365) || true) && (rException != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 124888, 126365);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 124960, 124997);

                                    errorRecord = f_1573_124974_124996(rException);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 125134, 125521) || true) && (errorRecord != null && (DynAbs.Tracing.TraceSender.Expression_True(1573, 125138, 125285) && f_1573_125190_125285(f_1573_125190_125223(errorRecord), "PipelineStopped", StringComparison.OrdinalIgnoreCase)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 125134, 125521);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 125433, 125457);

                                        failureException = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 125487, 125494);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 125134, 125521);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 124888, 126365);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 124888, 126365);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 126099, 126342);

                                    errorRecord = f_1573_126113_126341(f_1573_126129_126162(f_1573_126129_126155(pipeline)), "JobFailure", ErrorCategory.OperationStopped, targetObject);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 124888, 126365);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 126389, 126480);

                                string
                                computerName = f_1573_126411_126479(f_1573_126411_126466(((RemoteRunspace)f_1573_126428_126450(pipeline))))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 126502, 126554);

                                Guid
                                runspaceId = f_1573_126520_126553(f_1573_126520_126542(pipeline))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 126578, 126643);

                                OriginInfo
                                originInfo = f_1573_126602_126642(computerName, runspaceId)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 126667, 126737);

                                failureErrorRecord = f_1573_126688_126736(errorRecord, originInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 124676, 126756);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 124074, 126771);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 120943, 126771);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 119956, 126771);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 118766, 126782);

                int
                f_1573_119530_119574(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 119530, 119574);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1573_119617_119632(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 119617, 119632);
                    return return_v;
                }


                int
                f_1573_119665_119713(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 119665, 119713);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_119756_119778(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.GetRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 119756, 119778);
                    return return_v;
                }


                int
                f_1573_119811_119859(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 119811, 119859);
                    return 0;
                }


                System.Exception
                f_1573_119960_119984(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.InternalException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 119960, 119984);
                    return return_v;
                }


                System.Exception
                f_1573_120112_120136(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.InternalException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 120112, 120136);
                    return return_v;
                }


                string
                f_1573_120391_120414(System.Exception
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 120391, 120414);
                    return return_v;
                }


                bool
                f_1573_120370_120415(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 120370, 120415);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1573_120489_120538()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 120489, 120538);
                    return return_v;
                }


                string
                f_1573_120589_120612(System.Exception
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 120589, 120612);
                    return return_v;
                }


                string
                f_1573_120475_120613(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 120475, 120613);
                    return return_v;
                }


                System.Exception
                f_1573_120713_120737(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.InternalException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 120713, 120737);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1573_120697_120840(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 120697, 120840);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1573_120948_120974(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 120948, 120974);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1573_120948_120980(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 120948, 120980);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1573_121032_121058(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 121032, 121058);
                    return return_v;
                }


                System.Exception
                f_1573_121032_121065(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 121032, 121065);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1573_121127_121153(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 121127, 121153);
                    return return_v;
                }


                System.Exception
                f_1573_121127_121160(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 121127, 121160);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1573_121201_121224(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 121201, 121224);
                    return return_v;
                }


                string
                f_1573_121201_121237(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 121201, 121237);
                    return return_v;
                }


                int
                f_1573_121868_121892(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 121868, 121892);
                    return return_v;
                }


                string
                f_1573_121716_121946(int
                transportErrorCode, string
                defaultFQEID)
                {
                    var return_v = System.Management.Automation.Remoting.Client.WSManTransportManagerUtils.GetFQEIDFromTransportError(transportErrorCode, defaultFQEID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 121716, 121946);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1573_122056_122079(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 122056, 122079);
                    return return_v;
                }


                string
                f_1573_122056_122092(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 122056, 122092);
                    return return_v;
                }


                int
                f_1573_122128_122152(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 122128, 122152);
                    return return_v;
                }


                string
                f_1573_122609_122654()
                {
                    var return_v = RemotingErrorIdStrings.URIRedirectionReported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 122609, 122654);
                    return return_v;
                }


                string
                f_1573_122685_122707(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 122685, 122707);
                    return return_v;
                }


                string
                f_1573_122532_122927(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 122532, 122927);
                    return return_v;
                }


                string
                f_1573_123056_123078(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 123056, 123078);
                    return return_v;
                }


                bool
                f_1573_123035_123079(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 123035, 123079);
                    return return_v;
                }


                string
                f_1573_123145_123167(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 123145, 123167);
                    return return_v;
                }


                string
                f_1573_123244_123275(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.TransportMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 123244, 123275);
                    return return_v;
                }


                bool
                f_1573_123223_123276(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 123223, 123276);
                    return return_v;
                }


                string
                f_1573_123342_123373(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.TransportMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 123342, 123373);
                    return return_v;
                }


                string
                f_1573_123649_123702()
                {
                    var return_v = RemotingErrorIdStrings.RemoteRunspaceOpenUnknownState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 123649, 123702);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1573_123733_123759(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 123733, 123759);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1573_123733_123765(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 123733, 123765);
                    return return_v;
                }


                string
                f_1573_123572_123766(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 123572, 123766);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1573_123525_123767(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 123525, 123767);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1573_123828_124039(System.Exception
                exception, object
                targetObject, string
                fullyQualifiedErrorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                errorCategory_Activity, string
                errorCategory_Reason, string
                errorCategory_TargetName, string
                errorCategory_TargetType, string
                errorCategory_Message, string
                errorDetails_Message, string
                errorDetails_RecommendedAction)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, targetObject, fullyQualifiedErrorId, errorCategory, errorCategory_Activity, errorCategory_Reason, errorCategory_TargetName, errorCategory_TargetType, errorCategory_Message, errorDetails_Message, errorDetails_RecommendedAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 123828, 124039);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_124079_124105(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124079, 124105);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_124079_124111(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124079, 124111);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_124164_124190(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124164, 124190);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_124164_124196(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124164, 124196);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_124250_124276(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124250, 124276);
                    return return_v;
                }


                System.Exception
                f_1573_124250_124283(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124250, 124283);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_124297_124323(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124297, 124323);
                    return return_v;
                }


                System.Exception
                f_1573_124297_124330(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124297, 124330);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1573_124550_124573(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124550, 124573);
                    return return_v;
                }


                string
                f_1573_124550_124586(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124550, 124586);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_124624_124650(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124624, 124650);
                    return return_v;
                }


                System.Exception
                f_1573_124624_124657(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124624, 124657);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1573_124974_124996(System.Management.Automation.RemoteException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 124974, 124996);
                    return return_v;
                }


                string
                f_1573_125190_125223(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 125190, 125223);
                    return return_v;
                }


                bool
                f_1573_125190_125285(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 125190, 125285);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_126129_126155(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 126129, 126155);
                    return return_v;
                }


                System.Exception
                f_1573_126129_126162(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 126129, 126162);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1573_126113_126341(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 126113, 126341);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_126428_126450(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.GetRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 126428, 126450);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1573_126411_126466(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 126411, 126466);
                    return return_v;
                }


                string
                f_1573_126411_126479(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 126411, 126479);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_126520_126542(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.GetRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 126520, 126542);
                    return return_v;
                }


                System.Guid
                f_1573_126520_126553(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 126520, 126553);
                    return return_v;
                }


                System.Management.Automation.Remoting.OriginInfo
                f_1573_126602_126642(string
                computerName, System.Guid
                runspaceID)
                {
                    var return_v = new System.Management.Automation.Remoting.OriginInfo(computerName, runspaceID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 126602, 126642);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RemotingErrorRecord
                f_1573_126688_126736(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.Remoting.OriginInfo
                originInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RemotingErrorRecord(errorRecord, originInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 126688, 126736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 118766, 126782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 118766, 126782);
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 126996, 127673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127068, 127662) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 127068, 127662);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127115, 127198) || true) && (_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 127115, 127198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127172, 127179);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 127115, 127198);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127224, 127234);

                    lock (SyncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127276, 127371) || true) && (_isDisposed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 127276, 127371);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127341, 127348);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 127276, 127371);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127395, 127414);

                        _isDisposed = true;
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127497, 127519);

                        f_1573_127497_127518(this);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1573, 127556, 127647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127604, 127628);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing), 1573, 127604, 127627);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1573, 127556, 127647);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 127068, 127662);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 126996, 127673);

                int
                f_1573_127497_127518(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    this_param.DoCleanupOnFinished();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 127497, 127518);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 126996, 127673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 126996, 127673);
            }
        }

        private bool _isDisposed;

        private bool _cleanupDone;

        protected virtual void DoCleanupOnFinished()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 127877, 128763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127946, 127969);

                bool
                doCleanup = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 127983, 128295) || true) && (_cleanupDone == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 127983, 128295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128048, 128058);
                    lock (SyncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128100, 128261) || true) && (_cleanupDone == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 128100, 128261);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128175, 128195);

                            _cleanupDone = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128221, 128238);

                            doCleanup = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 128100, 128261);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 127983, 128295);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128311, 128334) || true) && (!doCleanup)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 128311, 128334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128327, 128334);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 128311, 128334);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128350, 128389);

                f_1573_128350_128388(this, f_1573_128381_128387());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128403, 128469);

                f_1573_128403_128411().AvailabilityChanged -= HandleRunspaceAvailabilityChanged;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128483, 128543);

                IThrottleOperation
                operation = f_1573_128514_128520() as IThrottleOperation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128557, 128655);

                operation.OperationComplete -= new EventHandler<OperationStateEventArgs>(HandleOperationComplete);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128669, 128714);

                f_1573_128669_128713(this, _throttleManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 128728, 128752);

                _throttleManager = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 127877, 128763);

                Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                f_1573_128381_128387()
                {
                    var return_v = Helper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 128381, 128387);
                    return return_v;
                }


                int
                f_1573_128350_128388(System.Management.Automation.PSRemotingChildJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper)
                {
                    this_param.StopAggregateResultsFromHelper(helper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 128350, 128388);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1573_128403_128411()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 128403, 128411);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                f_1573_128514_128520()
                {
                    var return_v = Helper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 128514, 128520);
                    return return_v;
                }


                int
                f_1573_128669_128713(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.Remoting.ThrottleManager
                throttleManager)
                {
                    this_param.UnregisterThrottleComplete(throttleManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 128669, 128713);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 127877, 128763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 127877, 128763);
            }
        }

        protected void AggregateResultsFromHelper(ExecutionCmdletHelper helper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 129030, 130996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129223, 129259);

                Pipeline
                pipeline = f_1573_129243_129258(helper)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129273, 129338);

                f_1573_129273_129288(pipeline).DataReady += new EventHandler(HandleOutputReady);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129352, 129415);

                f_1573_129352_129366(pipeline).DataReady += new EventHandler(HandleErrorReady);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129429, 129523);

                pipeline.StateChanged += new EventHandler<PipelineStateEventArgs>(HandlePipelineStateChanged);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129607, 129676);

                f_1573_129607_129675(pipeline is RemotePipeline, "pipeline is RemotePipeline");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129690, 129749);

                RemotePipeline
                remotePipeline = pipeline as RemotePipeline
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129763, 129846);

                f_1573_129763_129798(remotePipeline).DataReady += new EventHandler(HandleHostCalls);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 129860, 129991);

                f_1573_129860_129902(f_1573_129860_129893(f_1573_129860_129885(remotePipeline))).DataAdded +=
                                new EventHandler<DataAddedEventArgs>(HandleProgressAdded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 130005, 130134);

                f_1573_130005_130046(f_1573_130005_130038(f_1573_130005_130030(remotePipeline))).DataAdded +=
                                new EventHandler<DataAddedEventArgs>(HandleWarningAdded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 130148, 130277);

                f_1573_130148_130189(f_1573_130148_130181(f_1573_130148_130173(remotePipeline))).DataAdded +=
                                new EventHandler<DataAddedEventArgs>(HandleVerboseAdded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 130291, 130416);

                f_1573_130291_130330(f_1573_130291_130324(f_1573_130291_130316(remotePipeline))).DataAdded +=
                                new EventHandler<DataAddedEventArgs>(HandleDebugAdded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 130430, 130567);

                f_1573_130430_130475(f_1573_130430_130463(f_1573_130430_130455(remotePipeline))).DataAdded +=
                                new EventHandler<DataAddedEventArgs>(HandleInformationAdded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 130745, 130797);

                remotePipeline.IsMethodExecutorStreamEnabled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 130813, 130873);

                IThrottleOperation
                operation = helper as IThrottleOperation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 130887, 130985);

                operation.OperationComplete += new EventHandler<OperationStateEventArgs>(HandleOperationComplete);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 129030, 130996);

                System.Management.Automation.Runspaces.Pipeline
                f_1573_129243_129258(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 129243, 129258);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
                f_1573_129273_129288(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 129273, 129288);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<object>
                f_1573_129352_129366(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 129352, 129366);
                    return return_v;
                }


                int
                f_1573_129607_129675(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 129607, 129675);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStream
                f_1573_129763_129798(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.MethodExecutorStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 129763, 129798);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_129860_129885(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 129860, 129885);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_129860_129893(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 129860, 129893);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1573_129860_129902(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 129860, 129902);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_130005_130030(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130005, 130030);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_130005_130038(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130005, 130038);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1573_130005_130046(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130005, 130046);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_130148_130173(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130148, 130173);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_130148_130181(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130148, 130181);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1573_130148_130189(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130148, 130189);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_130291_130316(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130291, 130316);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_130291_130324(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130291, 130324);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1573_130291_130330(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130291, 130330);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_130430_130455(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130430, 130455);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_130430_130463(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130430, 130463);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1573_130430_130475(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 130430, 130475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 129030, 130996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 129030, 130996);
            }
        }

        private PowerShell GetPipelinePowerShell(RemotePipeline pipeline, Guid instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 131429, 131692);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 131536, 131632) || true) && (pipeline != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 131536, 131632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 131590, 131617);

                    return f_1573_131597_131616(pipeline);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 131536, 131632);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 131648, 131681);

                return f_1573_131655_131680(this, instanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 131429, 131692);

                System.Management.Automation.PowerShell
                f_1573_131597_131616(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 131597, 131616);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_131655_131680(System.Management.Automation.PSRemotingChildJob
                this_param, System.Guid
                instanceId)
                {
                    var return_v = this_param.GetPowerShell(instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 131655, 131680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 131429, 131692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 131429, 131692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleDebugAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 131998, 132380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 132097, 132125);

                int
                index = f_1573_132109_132124(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 132139, 132234);

                PowerShell
                powershell = f_1573_132163_132233(this, _remotePipeline, f_1573_132202_132232(eventArgs))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 132250, 132369) || true) && (powershell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 132250, 132369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 132306, 132354);

                    f_1573_132306_132353(f_1573_132306_132316(this), f_1573_132321_132352(f_1573_132321_132345(f_1573_132321_132339(powershell)), index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 132250, 132369);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 131998, 132380);

                int
                f_1573_132109_132124(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132109, 132124);
                    return return_v;
                }


                System.Guid
                f_1573_132202_132232(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.PowerShellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132202, 132232);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_132163_132233(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.RemotePipeline
                pipeline, System.Guid
                instanceId)
                {
                    var return_v = this_param.GetPipelinePowerShell(pipeline, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 132163, 132233);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1573_132306_132316(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132306, 132316);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_132321_132339(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132321, 132339);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1573_132321_132345(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132321, 132345);
                    return return_v;
                }


                System.Management.Automation.DebugRecord
                f_1573_132321_132352(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132321, 132352);
                    return return_v;
                }


                int
                f_1573_132306_132353(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param, System.Management.Automation.DebugRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 132306, 132353);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 131998, 132380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 131998, 132380);
            }
        }

        private void HandleVerboseAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 132690, 133078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 132791, 132819);

                int
                index = f_1573_132803_132818(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 132833, 132928);

                PowerShell
                powershell = f_1573_132857_132927(this, _remotePipeline, f_1573_132896_132926(eventArgs))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 132944, 133067) || true) && (powershell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 132944, 133067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 133000, 133052);

                    f_1573_133000_133051(f_1573_133000_133012(this), f_1573_133017_133050(f_1573_133017_133043(f_1573_133017_133035(powershell)), index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 132944, 133067);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 132690, 133078);

                int
                f_1573_132803_132818(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132803, 132818);
                    return return_v;
                }


                System.Guid
                f_1573_132896_132926(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.PowerShellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 132896, 132926);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_132857_132927(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.RemotePipeline
                pipeline, System.Guid
                instanceId)
                {
                    var return_v = this_param.GetPipelinePowerShell(pipeline, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 132857, 132927);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1573_133000_133012(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133000, 133012);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_133017_133035(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133017, 133035);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1573_133017_133043(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133017, 133043);
                    return return_v;
                }


                System.Management.Automation.VerboseRecord
                f_1573_133017_133050(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133017, 133050);
                    return return_v;
                }


                int
                f_1573_133000_133051(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param, System.Management.Automation.VerboseRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 133000, 133051);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 132690, 133078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 132690, 133078);
            }
        }

        private void HandleWarningAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 133388, 133942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 133489, 133517);

                int
                index = f_1573_133501_133516(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 133531, 133626);

                PowerShell
                powershell = f_1573_133555_133625(this, _remotePipeline, f_1573_133594_133624(eventArgs))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 133642, 133931) || true) && (powershell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 133642, 133931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 133698, 133762);

                    WarningRecord
                    warningRecord = f_1573_133728_133761(f_1573_133728_133754(f_1573_133728_133746(powershell)), index)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 133780, 133812);

                    f_1573_133780_133811(f_1573_133780_133792(this), warningRecord);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 133830, 133916);

                    f_1573_133830_133915(f_1573_133830_133842(this), f_1573_133847_133914(PSStreamObjectType.WarningRecord, warningRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 133642, 133931);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 133388, 133942);

                int
                f_1573_133501_133516(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133501, 133516);
                    return return_v;
                }


                System.Guid
                f_1573_133594_133624(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.PowerShellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133594, 133624);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_133555_133625(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.RemotePipeline
                pipeline, System.Guid
                instanceId)
                {
                    var return_v = this_param.GetPipelinePowerShell(pipeline, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 133555, 133625);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_133728_133746(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133728, 133746);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1573_133728_133754(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133728, 133754);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1573_133728_133761(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133728, 133761);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1573_133780_133792(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133780, 133792);
                    return return_v;
                }


                int
                f_1573_133780_133811(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param, System.Management.Automation.WarningRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 133780, 133811);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_133830_133842(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 133830, 133842);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_133847_133914(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.WarningRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 133847, 133914);
                    return return_v;
                }


                int
                f_1573_133830_133915(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 133830, 133915);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 133388, 133942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 133388, 133942);
            }
        }

        private void HandleProgressAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 134253, 134644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 134355, 134383);

                int
                index = f_1573_134367_134382(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 134397, 134492);

                PowerShell
                powershell = f_1573_134421_134491(this, _remotePipeline, f_1573_134460_134490(eventArgs))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 134508, 134633) || true) && (powershell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 134508, 134633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 134564, 134618);

                    f_1573_134564_134617(f_1573_134564_134577(this), f_1573_134582_134616(f_1573_134582_134609(f_1573_134582_134600(powershell)), index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 134508, 134633);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 134253, 134644);

                int
                f_1573_134367_134382(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 134367, 134382);
                    return return_v;
                }


                System.Guid
                f_1573_134460_134490(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.PowerShellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 134460, 134490);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_134421_134491(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.RemotePipeline
                pipeline, System.Guid
                instanceId)
                {
                    var return_v = this_param.GetPipelinePowerShell(pipeline, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 134421, 134491);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1573_134564_134577(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 134564, 134577);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_134582_134600(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 134582, 134600);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1573_134582_134609(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 134582, 134609);
                    return return_v;
                }


                System.Management.Automation.ProgressRecord
                f_1573_134582_134616(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 134582, 134616);
                    return return_v;
                }


                int
                f_1573_134564_134617(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param, System.Management.Automation.ProgressRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 134564, 134617);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 134253, 134644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 134253, 134644);
            }
        }

        private void HandleInformationAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 134962, 135952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135067, 135095);

                int
                index = f_1573_135079_135094(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135109, 135204);

                PowerShell
                powershell = f_1573_135133_135203(this, _remotePipeline, f_1573_135172_135202(eventArgs))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135220, 135941) || true) && (powershell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 135220, 135941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135276, 135352);

                    InformationRecord
                    informationRecord = f_1573_135314_135351(f_1573_135314_135344(f_1573_135314_135332(powershell)), index)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135370, 135410);

                    f_1573_135370_135409(f_1573_135370_135386(this), informationRecord);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135672, 135818) || true) && (f_1573_135676_135717(f_1573_135676_135698(informationRecord), "PSHOST"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 135672, 135818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135759, 135799);

                        f_1573_135759_135798(f_1573_135759_135781(informationRecord), "FORWARDED");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 135672, 135818);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 135838, 135926);

                    f_1573_135838_135925(f_1573_135838_135850(this), f_1573_135855_135924(PSStreamObjectType.Information, informationRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 135220, 135941);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 134962, 135952);

                int
                f_1573_135079_135094(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135079, 135094);
                    return return_v;
                }


                System.Guid
                f_1573_135172_135202(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.PowerShellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135172, 135202);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_135133_135203(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.RemotePipeline
                pipeline, System.Guid
                instanceId)
                {
                    var return_v = this_param.GetPipelinePowerShell(pipeline, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 135133, 135203);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_135314_135332(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135314, 135332);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1573_135314_135344(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135314, 135344);
                    return return_v;
                }


                System.Management.Automation.InformationRecord
                f_1573_135314_135351(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135314, 135351);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1573_135370_135386(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135370, 135386);
                    return return_v;
                }


                int
                f_1573_135370_135409(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param, System.Management.Automation.InformationRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 135370, 135409);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1573_135676_135698(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135676, 135698);
                    return return_v;
                }


                bool
                f_1573_135676_135717(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 135676, 135717);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1573_135759_135781(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135759, 135781);
                    return return_v;
                }


                int
                f_1573_135759_135798(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 135759, 135798);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_135838_135850(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 135838, 135850);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1573_135855_135924(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.InformationRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 135855, 135924);
                    return return_v;
                }


                int
                f_1573_135838_135925(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 135838, 135925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 134962, 135952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 134962, 135952);
            }
        }

        protected void StopAggregateResultsFromHelper(ExecutionCmdletHelper helper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 136239, 136604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 136436, 136478);

                f_1573_136436_136477(this, helper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 136494, 136530);

                Pipeline
                pipeline = f_1573_136514_136529(helper)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 136544, 136563);

                f_1573_136544_136562(pipeline);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 136577, 136593);

                pipeline = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 136239, 136604);

                int
                f_1573_136436_136477(System.Management.Automation.PSRemotingChildJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper)
                {
                    this_param.RemoveAggreateCallbacksFromHelper(helper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 136436, 136477);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1573_136514_136529(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 136514, 136529);
                    return return_v;
                }


                int
                f_1573_136544_136562(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 136544, 136562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 136239, 136604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 136239, 136604);
            }
        }

        protected void RemoveAggreateCallbacksFromHelper(ExecutionCmdletHelper helper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 137014, 138673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137211, 137247);

                Pipeline
                pipeline = f_1573_137231_137246(helper)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137261, 137308);

                f_1573_137261_137276(pipeline).DataReady -= HandleOutputReady;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137322, 137367);

                f_1573_137322_137336(pipeline).DataReady -= HandleErrorReady;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137381, 137433);

                pipeline.StateChanged -= HandlePipelineStateChanged;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137509, 137578);

                f_1573_137509_137577(pipeline is RemotePipeline, "pipeline is RemotePipeline");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137592, 137651);

                RemotePipeline
                remotePipeline = pipeline as RemotePipeline
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137665, 137748);

                f_1573_137665_137700(remotePipeline).DataReady -= new EventHandler(HandleHostCalls);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137762, 138662) || true) && (f_1573_137766_137791(remotePipeline) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 137762, 138662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137833, 137968);

                    f_1573_137833_137875(f_1573_137833_137866(f_1573_137833_137858(remotePipeline))).DataAdded -=
                                        new EventHandler<DataAddedEventArgs>(HandleProgressAdded);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 137986, 138119);

                    f_1573_137986_138027(f_1573_137986_138019(f_1573_137986_138011(remotePipeline))).DataAdded -=
                                        new EventHandler<DataAddedEventArgs>(HandleWarningAdded);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 138137, 138270);

                    f_1573_138137_138178(f_1573_138137_138170(f_1573_138137_138162(remotePipeline))).DataAdded -=
                                        new EventHandler<DataAddedEventArgs>(HandleVerboseAdded);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 138288, 138417);

                    f_1573_138288_138327(f_1573_138288_138321(f_1573_138288_138313(remotePipeline))).DataAdded -=
                                        new EventHandler<DataAddedEventArgs>(HandleDebugAdded);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 138435, 138576);

                    f_1573_138435_138480(f_1573_138435_138468(f_1573_138435_138460(remotePipeline))).DataAdded -=
                                        new EventHandler<DataAddedEventArgs>(HandleInformationAdded);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 138594, 138647);

                    remotePipeline.IsMethodExecutorStreamEnabled = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 137762, 138662);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 137014, 138673);

                System.Management.Automation.Runspaces.Pipeline
                f_1573_137231_137246(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137231, 137246);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
                f_1573_137261_137276(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137261, 137276);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<object>
                f_1573_137322_137336(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137322, 137336);
                    return return_v;
                }


                int
                f_1573_137509_137577(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 137509, 137577);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStream
                f_1573_137665_137700(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.MethodExecutorStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137665, 137700);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_137766_137791(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137766, 137791);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_137833_137858(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137833, 137858);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_137833_137866(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137833, 137866);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1573_137833_137875(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137833, 137875);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_137986_138011(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137986, 138011);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_137986_138019(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137986, 138019);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1573_137986_138027(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 137986, 138027);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_138137_138162(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138137, 138162);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_138137_138170(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138137, 138170);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1573_138137_138178(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138137, 138178);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_138288_138313(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138288, 138313);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_138288_138321(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138288, 138321);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1573_138288_138327(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138288, 138327);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1573_138435_138460(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138435, 138460);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1573_138435_138468(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138435, 138468);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1573_138435_138480(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 138435, 138480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 137014, 138673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 137014, 138673);
            }
        }

        protected void RegisterThrottleComplete(ThrottleManager throttleManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 138877, 139073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 138974, 139062);

                throttleManager.ThrottleComplete += new EventHandler<EventArgs>(HandleThrottleComplete);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 138877, 139073);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 138877, 139073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 138877, 139073);
            }
        }

        protected void UnregisterThrottleComplete(ThrottleManager throttleManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 139280, 139478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 139379, 139467);

                throttleManager.ThrottleComplete -= new EventHandler<EventArgs>(HandleThrottleComplete);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 139280, 139478);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 139280, 139478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 139280, 139478);
            }
        }

        protected void DeterminedAndSetJobState(ExecutionCmdletHelper helper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 139715, 140876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 139809, 139836);

                Exception
                failureException
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 139905, 139978);

                f_1573_139905_139977(this, helper, out failureException, out _failureErrorRecord);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 139994, 140865) || true) && (failureException != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 139994, 140865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 140056, 140103);

                    f_1573_140056_140102(this, JobState.Failed, failureException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 139994, 140865);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 139994, 140865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 140219, 140281);

                    PipelineState
                    state = f_1573_140241_140280(f_1573_140241_140274(f_1573_140241_140256(helper)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 140299, 140850) || true) && (state == PipelineState.NotStarted)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 140299, 140850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 140537, 140567);

                        f_1573_140537_140566(this, JobState.Stopped);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 140299, 140850);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 140299, 140850);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 140609, 140850) || true) && (state == PipelineState.Completed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 140609, 140850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 140687, 140719);

                            f_1573_140687_140718(this, JobState.Completed);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 140609, 140850);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 140609, 140850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 140801, 140831);

                            f_1573_140801_140830(this, JobState.Stopped);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 140609, 140850);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 140299, 140850);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 139994, 140865);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 139715, 140876);

                int
                f_1573_139905_139977(System.Management.Automation.PSRemotingChildJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper, out System.Exception
                failureException, out System.Management.Automation.ErrorRecord
                failureErrorRecord)
                {
                    this_param.ProcessJobFailure(helper, out failureException, out failureErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 139905, 139977);
                    return 0;
                }


                int
                f_1573_140056_140102(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 140056, 140102);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1573_140241_140256(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 140241, 140256);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_140241_140274(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 140241, 140274);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_140241_140280(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 140241, 140280);
                    return return_v;
                }


                int
                f_1573_140537_140566(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 140537, 140566);
                    return 0;
                }


                int
                f_1573_140687_140718(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 140687, 140718);
                    return 0;
                }


                int
                f_1573_140801_140830(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 140801, 140830);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 139715, 140876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 139715, 140876);
            }
        }

        internal void UnblockJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 141108, 141538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 141159, 141294);

                f_1573_141159_141293(f_1573_141170_141188(f_1573_141170_141182()) == JobState.Blocked, "Current state of job must be blocked before it can be unblocked");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 141310, 141346);

                f_1573_141310_141345(this, JobState.Running, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 141362, 141466);

                f_1573_141362_141465(JobUnblocked != null, "Parent job must register for JobUnblocked event from all child jobs");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 141480, 141527);

                f_1573_141480_141526(JobUnblocked, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 141108, 141538);

                System.Management.Automation.JobStateInfo
                f_1573_141170_141182()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 141170, 141182);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_141170_141188(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 141170, 141188);
                    return return_v;
                }


                int
                f_1573_141159_141293(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 141159, 141293);
                    return 0;
                }


                int
                f_1573_141310_141345(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 141310, 141345);
                    return 0;
                }


                int
                f_1573_141362_141465(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 141362, 141465);
                    return 0;
                }


                int
                f_1573_141480_141526(System.EventHandler
                eventHandler, System.Management.Automation.PSRemotingChildJob
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 141480, 141526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 141108, 141538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 141108, 141538);
            }
        }

        internal virtual PowerShell GetPowerShell(Guid instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 141790, 142008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 141946, 141997);

                throw f_1573_141952_141996();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 141790, 142008);

                System.Management.Automation.PSInvalidOperationException
                f_1573_141952_141996()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 141952, 141996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 141790, 142008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 141790, 142008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PowerShell GetPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 142200, 142440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 142260, 142281);

                PowerShell
                ps = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 142295, 142403) || true) && (_remotePipeline != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 142295, 142403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 142356, 142388);

                    ps = f_1573_142361_142387(_remotePipeline);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 142295, 142403);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 142419, 142429);

                return ps;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 142200, 142440);

                System.Management.Automation.PowerShell
                f_1573_142361_142387(System.Management.Automation.RemotePipeline
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 142361, 142387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 142200, 142440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 142200, 142440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleRunspaceAvailabilityChanged(object sender, RunspaceAvailabilityEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 142854, 143512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 142973, 143039);

                RunspaceAvailability
                prevAvailability = _prevRunspaceAvailability
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143053, 143104);

                _prevRunspaceAvailability = f_1573_143081_143103(e);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143120, 143501) || true) && (f_1573_143124_143146(e) == RunspaceAvailability.RemoteDebug)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 143120, 143501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143216, 143251);

                    f_1573_143216_143250(this, JobState.AtBreakpoint);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 143120, 143501);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 143120, 143501);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143285, 143501) || true) && ((prevAvailability == RunspaceAvailability.RemoteDebug) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 143289, 143422) && (f_1573_143370_143392(e) == RunspaceAvailability.Busy)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 143285, 143501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 143456, 143486);

                        f_1573_143456_143485(this, JobState.Running);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 143285, 143501);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 143120, 143501);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 142854, 143512);

                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1573_143081_143103(System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 143081, 143103);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1573_143124_143146(System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 143124, 143146);
                    return return_v;
                }


                int
                f_1573_143216_143250(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 143216, 143250);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1573_143370_143392(System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 143370, 143392);
                    return return_v;
                }


                int
                f_1573_143456_143485(System.Management.Automation.PSRemotingChildJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 143456, 143485);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 142854, 143512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 142854, 143512);
            }
        }

        /// <summary>
        /// Event raised by this job to indicate to its parent that
        /// its now unblocked by the user.
        /// </summary>
        internal event EventHandler
JobUnblocked
;

        private RemotePipeline _remotePipeline;

        protected object SyncObject;

        private ThrottleManager _throttleManager;

        private bool _stopIsCalled;

        private volatile Debugger _jobDebugger;

        private bool _isAsync;

        private RunspaceAvailability _prevRunspaceAvailability;

        static PSRemotingChildJob()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 97986, 144336);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 97986, 144336);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 97986, 144336);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 97986, 144336);

        System.Management.Automation.Runspaces.Pipeline
        f_1573_98605_98620(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 98605, 98620);
            return return_v;
        }


        int
        f_1573_98594_98686(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 98594, 98686);
            return 0;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_98744_98759(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 98744, 98759);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1573_98744_98768(System.Management.Automation.Runspaces.Pipeline
        this_param)
        {
            var return_v = this_param.Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 98744, 98768);
            return return_v;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_98801_98816(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 98801, 98816);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1573_98926_98934()
        {
            var return_v = Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 98926, 98934);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspaceStateInfo
        f_1573_98994_99020(System.Management.Automation.RemoteRunspace
        this_param)
        {
            var return_v = this_param.RunspaceStateInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 98994, 99020);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspaceState
        f_1573_98994_99026(System.Management.Automation.Runspaces.RunspaceStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 98994, 99026);
            return return_v;
        }


        int
        f_1573_99182_99216(System.Management.Automation.PSRemotingChildJob
        this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        helper)
        {
            this_param.AggregateResultsFromHelper(helper);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 99182, 99216);
            return 0;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1573_99233_99241()
        {
            var return_v = Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 99233, 99241);
            return return_v;
        }


        int
        f_1573_99315_99356(System.Management.Automation.PSRemotingChildJob
        this_param, System.Management.Automation.Remoting.ThrottleManager
        throttleManager)
        {
            this_param.RegisterThrottleComplete(throttleManager);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 99315, 99356);
            return 0;
        }


        static string
        f_1573_98512_98525_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1573, 98379, 99368);
            return return_v;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_100267_100282(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100267, 100282);
            return return_v;
        }


        int
        f_1573_100255_100356(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 100255, 100356);
            return 0;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_100383_100398(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100383, 100398);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineStateInfo
        f_1573_100383_100416(System.Management.Automation.Runspaces.Pipeline
        this_param)
        {
            var return_v = this_param.PipelineStateInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100383, 100416);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineState
        f_1573_100383_100422(System.Management.Automation.Runspaces.PipelineStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100383, 100422);
            return return_v;
        }


        int
        f_1573_100371_100511(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 100371, 100511);
            return 0;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_100576_100591(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100576, 100591);
            return return_v;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_100635_100650(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100635, 100650);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1573_100635_100659(System.Management.Automation.Runspaces.Pipeline
        this_param)
        {
            var return_v = this_param.Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100635, 100659);
            return return_v;
        }


        int
        f_1573_100779_100813(System.Management.Automation.PSRemotingChildJob
        this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        helper)
        {
            this_param.AggregateResultsFromHelper(helper);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 100779, 100813);
            return 0;
        }


        System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
        f_1573_100999_101021(System.Management.Automation.RemotePipeline
        this_param)
        {
            var return_v = this_param.Output;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 100999, 101021);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineReader<object>
        f_1573_101089_101110(System.Management.Automation.RemotePipeline
        this_param)
        {
            var return_v = this_param.Error;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 101089, 101110);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1573_101190_101198()
        {
            var return_v = Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 101190, 101198);
            return return_v;
        }


        int
        f_1573_101460_101500(System.Management.Automation.PSRemotingChildJob
        this_param, System.Management.Automation.JobState
        state, System.Exception
        reason)
        {
            this_param.SetJobState(state, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 101460, 101500);
            return 0;
        }


        object
        f_1573_143993_144005()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 143993, 144005);
            return return_v;
        }

    }
    internal sealed class RemotingJobDebugger : Debugger
    {
        private Debugger _wrappedDebugger;

        private Runspace _runspace;

        private string _jobName;

        private RemotingJobDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 144784, 144817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144631, 144647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144675, 144684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144710, 144718);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 144784, 144817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 144784, 144817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 144784, 144817);
            }
        }

        public RemotingJobDebugger(
                    Debugger debugger,
                    Runspace runspace,
                    string jobName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 145092, 145827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144631, 144647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144675, 144684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 144710, 144718);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145237, 145352) || true) && (debugger == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 145237, 145352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145291, 145337);

                    throw f_1573_145297_145336("debugger");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 145237, 145352);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145368, 145483) || true) && (runspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 145368, 145483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145422, 145468);

                    throw f_1573_145428_145467("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 145368, 145483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145499, 145527);

                _wrappedDebugger = debugger;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145541, 145562);

                _runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145576, 145611);

                _jobName = jobName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1573, 145587, 145610) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145688, 145750);

                _wrappedDebugger.BreakpointUpdated += HandleBreakpointUpdated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 145764, 145816);

                _wrappedDebugger.DebuggerStop += HandleDebuggerStop;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 145092, 145827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 145092, 145827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 145092, 145827);
            }
        }

        public override DebuggerCommandResults ProcessCommand(PSCommand command, PSDataCollection<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 146231, 146682);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 146420, 146599) || true) && (f_1573_146424_146515(f_1573_146424_146462(f_1573_146424_146455(f_1573_146424_146443(f_1573_146424_146440(command), 0))), "prompt", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 146420, 146599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 146549, 146584);

                    return f_1573_146556_146583(this, output);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 146420, 146599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 146615, 146671);

                return f_1573_146622_146670(_wrappedDebugger, command, output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 146231, 146682);

                System.Management.Automation.Runspaces.CommandCollection
                f_1573_146424_146440(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 146424, 146440);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1573_146424_146443(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 146424, 146443);
                    return return_v;
                }


                string
                f_1573_146424_146455(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 146424, 146455);
                    return return_v;
                }


                string
                f_1573_146424_146462(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 146424, 146462);
                    return return_v;
                }


                bool
                f_1573_146424_146515(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 146424, 146515);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1573_146556_146583(System.Management.Automation.RemotingJobDebugger
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.HandlePromptCommand(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 146556, 146583);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1573_146622_146670(System.Management.Automation.Debugger
                this_param, System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.ProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 146622, 146670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 146231, 146682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 146231, 146682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetBreakpoints(IEnumerable<Breakpoint> breakpoints, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 147114, 147186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 147130, 147186);
                f_1573_147130_147186(_wrappedDebugger, breakpoints, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 147114, 147186);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 147114, 147186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 147114, 147186);
            }

            int
            f_1573_147130_147186(System.Management.Automation.Debugger
            this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.Breakpoint>
            breakpoints, int?
            runspaceId)
            {
                this_param.SetBreakpoints(breakpoints, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 147130, 147186);
                return 0;
            }

        }

        public override Breakpoint GetBreakpoint(int id, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 147695, 147757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 147711, 147757);
                return f_1573_147711_147757(_wrappedDebugger, id, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 147695, 147757);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 147695, 147757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 147695, 147757);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Breakpoint
            f_1573_147711_147757(System.Management.Automation.Debugger
            this_param, int
            id, int?
            runspaceId)
            {
                var return_v = this_param.GetBreakpoint(id, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 147711, 147757);
                return return_v;
            }

        }

        public override List<Breakpoint> GetBreakpoints(int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 148148, 148207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 148164, 148207);
                return f_1573_148164_148207(_wrappedDebugger, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 148148, 148207);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 148148, 148207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 148148, 148207);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.List<System.Management.Automation.Breakpoint>
            f_1573_148164_148207(System.Management.Automation.Debugger
            this_param, int?
            runspaceId)
            {
                var return_v = this_param.GetBreakpoints(runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 148164, 148207);
                return return_v;
            }

        }

        public override CommandBreakpoint SetCommandBreakpoint(string command, ScriptBlock action, string path, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 149126, 149214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 149142, 149214);
                return f_1573_149142_149214(_wrappedDebugger, command, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 149126, 149214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 149126, 149214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 149126, 149214);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.CommandBreakpoint
            f_1573_149142_149214(System.Management.Automation.Debugger
            this_param, string
            command, System.Management.Automation.ScriptBlock
            action, string
            path, int?
            runspaceId)
            {
                var return_v = this_param.SetCommandBreakpoint(command, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 149142, 149214);
                return return_v;
            }

        }

        public override LineBreakpoint SetLineBreakpoint(string path, int line, int column, ScriptBlock action, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 150275, 150365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 150291, 150365);
                return f_1573_150291_150365(_wrappedDebugger, path, line, column, action, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 150275, 150365);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 150275, 150365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 150275, 150365);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.LineBreakpoint
            f_1573_150291_150365(System.Management.Automation.Debugger
            this_param, string
            path, int
            line, int
            column, System.Management.Automation.ScriptBlock
            action, int?
            runspaceId)
            {
                var return_v = this_param.SetLineBreakpoint(path, line, column, action, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 150291, 150365);
                return return_v;
            }

        }

        public override VariableBreakpoint SetVariableBreakpoint(string variableName, VariableAccessMode accessMode, ScriptBlock action, string path, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 151469, 151575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 151485, 151575);
                return f_1573_151485_151575(_wrappedDebugger, variableName, accessMode, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 151469, 151575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 151469, 151575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 151469, 151575);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.VariableBreakpoint
            f_1573_151485_151575(System.Management.Automation.Debugger
            this_param, string
            variableName, System.Management.Automation.VariableAccessMode
            accessMode, System.Management.Automation.ScriptBlock
            action, string
            path, int?
            runspaceId)
            {
                var return_v = this_param.SetVariableBreakpoint(variableName, accessMode, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 151485, 151575);
                return return_v;
            }

        }

        public override bool RemoveBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 152136, 152209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 152152, 152209);
                return f_1573_152152_152209(_wrappedDebugger, breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 152136, 152209);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 152136, 152209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 152136, 152209);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1573_152152_152209(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.RemoveBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 152152, 152209);
                return return_v;
            }

        }

        public override Breakpoint EnableBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 152795, 152868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 152811, 152868);
                return f_1573_152811_152868(_wrappedDebugger, breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 152795, 152868);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 152795, 152868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 152795, 152868);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Breakpoint
            f_1573_152811_152868(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.EnableBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 152811, 152868);
                return return_v;
            }

        }

        public override Breakpoint DisableBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 153456, 153530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 153472, 153530);
                return f_1573_153472_153530(_wrappedDebugger, breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 153456, 153530);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 153456, 153530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 153456, 153530);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Breakpoint
            f_1573_153472_153530(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.DisableBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 153472, 153530);
                return return_v;
            }

        }

        public override void SetDebuggerAction(DebuggerResumeAction resumeAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 153706, 153864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 153804, 153853);

                f_1573_153804_153852(_wrappedDebugger, resumeAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 153706, 153864);

                int
                f_1573_153804_153852(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.SetDebuggerAction(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 153804, 153852);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 153706, 153864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 153706, 153864);
            }
        }

        public override void StopProcessCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 153961, 154076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 154027, 154065);

                f_1573_154027_154064(_wrappedDebugger);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 153961, 154076);

                int
                f_1573_154027_154064(System.Management.Automation.Debugger
                this_param)
                {
                    this_param.StopProcessCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 154027, 154064);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 153961, 154076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 153961, 154076);
            }
        }

        public override DebuggerStopEventArgs GetDebuggerStopArgs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 154323, 154464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 154407, 154453);

                return f_1573_154414_154452(_wrappedDebugger);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 154323, 154464);

                System.Management.Automation.DebuggerStopEventArgs
                f_1573_154414_154452(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.GetDebuggerStopArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 154414, 154452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 154323, 154464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 154323, 154464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetParent(
                    Debugger parent,
                    IEnumerable<Breakpoint> breakPoints,
                    DebuggerResumeAction? startAction,
                    PSHost host,
                    PathInfo path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 154916, 155250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 155213, 155239);

                f_1573_155213_155238(this, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 154916, 155250);

                int
                f_1573_155213_155238(System.Management.Automation.RemotingJobDebugger
                this_param, bool
                enabled)
                {
                    this_param.SetDebuggerStepMode(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 155213, 155238);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 154916, 155250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 154916, 155250);
            }
        }

        public override void SetDebugMode(DebugModes mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 155346, 155508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 155421, 155457);

                f_1573_155421_155456(_wrappedDebugger, mode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 155473, 155497);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetDebugMode(mode), 1573, 155473, 155496);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 155346, 155508);

                int
                f_1573_155421_155456(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 155421, 155456);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 155346, 155508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 155346, 155508);
            }
        }

        public override IEnumerable<CallStackFrame> GetCallStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 155660, 155793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 155743, 155782);

                return f_1573_155750_155781(_wrappedDebugger);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 155660, 155793);

                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1573_155750_155781(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.GetCallStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 155750, 155781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 155660, 155793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 155660, 155793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetDebuggerStepMode(bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 155972, 156108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 156051, 156097);

                f_1573_156051_156096(_wrappedDebugger, enabled);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 155972, 156108);

                int
                f_1573_156051_156096(System.Management.Automation.Debugger
                this_param, bool
                enabled)
                {
                    this_param.SetDebuggerStepMode(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 156051, 156096);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 155972, 156108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 155972, 156108);
            }
        }

        internal void CheckStateAndRaiseStopEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 156209, 156489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 156277, 156344);

                RemoteDebugger
                remoteDebugger = _wrappedDebugger as RemoteDebugger
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 156358, 156478) || true) && (remoteDebugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 156358, 156478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 156418, 156463);

                    f_1573_156418_156462(remoteDebugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 156358, 156478);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 156209, 156489);

                int
                f_1573_156418_156462(System.Management.Automation.RemoteDebugger
                this_param)
                {
                    this_param.CheckStateAndRaiseStopEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 156418, 156462);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 156209, 156489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 156209, 156489);
            }
        }

        public override bool InBreakpoint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 156666, 156711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 156672, 156709);

                    return f_1573_156679_156708(_wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 156666, 156711);

                    bool
                    f_1573_156679_156708(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.InBreakpoint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 156679, 156708);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 156608, 156722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 156608, 156722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void HandleDebuggerStop(object sender, DebuggerStopEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 156791, 157270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 156887, 156920);

                Pipeline
                remoteRunningCmd = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157039, 157086);

                    remoteRunningCmd = f_1573_157058_157085(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157106, 157137);

                    f_1573_157106_157136(
                                    this, e);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1573, 157166, 157259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157206, 157244);

                    f_1573_157206_157243(this, remoteRunningCmd);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1573, 157166, 157259);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 156791, 157270);

                System.Management.Automation.Runspaces.Pipeline
                f_1573_157058_157085(System.Management.Automation.RemotingJobDebugger
                this_param)
                {
                    var return_v = this_param.DrainAndBlockRemoteOutput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 157058, 157085);
                    return return_v;
                }


                int
                f_1573_157106_157136(System.Management.Automation.RemotingJobDebugger
                this_param, System.Management.Automation.DebuggerStopEventArgs
                args)
                {
                    this_param.RaiseDebuggerStopEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 157106, 157136);
                    return 0;
                }


                int
                f_1573_157206_157243(System.Management.Automation.RemotingJobDebugger
                this_param, System.Management.Automation.Runspaces.Pipeline
                runningCmd)
                {
                    this_param.RestoreRemoteOutput(runningCmd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 157206, 157243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 156791, 157270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 156791, 157270);
            }
        }

        private Pipeline DrainAndBlockRemoteOutput()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 157282, 157779);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157405, 157457) || true) && (!(_runspace is RemoteRunspace))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 157405, 157457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157443, 157455);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 157405, 157457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157473, 157535);

                Pipeline
                runningCmd = f_1573_157495_157534(_runspace)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157549, 157740) || true) && (runningCmd != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 157549, 157740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157605, 157636);

                    f_1573_157605_157635(runningCmd);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157654, 157687);

                    f_1573_157654_157686(runningCmd);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157707, 157725);

                    return runningCmd;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 157549, 157740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157756, 157768);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 157282, 157779);

                System.Management.Automation.Runspaces.Pipeline
                f_1573_157495_157534(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 157495, 157534);
                    return return_v;
                }


                int
                f_1573_157605_157635(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    this_param.DrainIncomingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 157605, 157635);
                    return 0;
                }


                int
                f_1573_157654_157686(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    this_param.SuspendIncomingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 157654, 157686);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 157282, 157779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 157282, 157779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RestoreRemoteOutput(Pipeline runningCmd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 157791, 157983);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157869, 157972) || true) && (runningCmd != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 157869, 157972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 157925, 157957);

                    f_1573_157925_157956(runningCmd);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 157869, 157972);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 157791, 157983);

                int
                f_1573_157925_157956(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    this_param.ResumeIncomingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 157925, 157956);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 157791, 157983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 157791, 157983);
            }
        }

        private void HandleBreakpointUpdated(object sender, BreakpointUpdatedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 157995, 158148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 158101, 158137);

                f_1573_158101_158136(this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 157995, 158148);

                int
                f_1573_158101_158136(System.Management.Automation.RemotingJobDebugger
                this_param, System.Management.Automation.BreakpointUpdatedEventArgs
                args)
                {
                    this_param.RaiseBreakpointUpdatedEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 158101, 158136);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 157995, 158148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 157995, 158148);
            }
        }

        private DebuggerCommandResults HandlePromptCommand(PSDataCollection<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 158160, 158824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 158379, 158574);

                string
                promptScript = "'[DBG]: '" + " + " + "'[" + f_1573_158430_158486(_jobName) + "]: '" + " + " + @"""PS $($executionContext.SessionState.Path.CurrentLocation)>> """
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 158588, 158630);

                PSCommand
                promptCommand = f_1573_158614_158629()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 158644, 158682);

                f_1573_158644_158681(promptCommand, promptScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 158696, 158751);

                f_1573_158696_158750(_wrappedDebugger, promptCommand, output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 158767, 158813);

                return f_1573_158774_158812(null, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 158160, 158824);

                string
                f_1573_158430_158486(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 158430, 158486);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1573_158614_158629()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 158614, 158629);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1573_158644_158681(System.Management.Automation.PSCommand
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 158644, 158681);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1573_158696_158750(System.Management.Automation.Debugger
                this_param, System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.ProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 158696, 158750);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1573_158774_158812(System.Management.Automation.DebuggerResumeAction?
                resumeAction, bool
                evaluatedByDebugger)
                {
                    var return_v = new System.Management.Automation.DebuggerCommandResults(resumeAction, evaluatedByDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 158774, 158812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 158160, 158824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 158160, 158824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemotingJobDebugger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 144518, 158853);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 144518, 158853);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 144518, 158853);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 144518, 158853);

        System.Management.Automation.PSArgumentNullException
        f_1573_145297_145336(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 145297, 145336);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1573_145428_145467(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 145428, 145467);
            return return_v;
        }

    }
    internal class PSInvokeExpressionSyncJob : PSRemotingChildJob
    {
        private List<ExecutionCmdletHelper> _helpers;

        private ThrottleManager _throttleManager;

        private Dictionary<Guid, PowerShell> _powershells;

        private int _pipelineFinishedCount;

        private int _pipelineDisconnectedCount;

        internal PSInvokeExpressionSyncJob(List<IThrottleOperation> operations, ThrottleManager throttleManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 160106, 161448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 159460, 159504);
                this._helpers = f_1573_159471_159504();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 159539, 159555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 159603, 159652);
                this._powershells = f_1573_159618_159652();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 159677, 159699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 159722, 159748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161545, 161565);
                this._cleanupDone = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 166662, 166685);
                this._doFinishCalled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160235, 160264);

                UsesResultsCollection = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160278, 160295);

                f_1573_160278_160294(f_1573_160278_160285());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160311, 160346);

                _throttleManager = throttleManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160360, 160403);

                f_1573_160360_160402(this, _throttleManager);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160419, 161437);
                    foreach (IThrottleOperation operation in f_1573_160460_160470_I(operations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 160419, 161437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160504, 160570);

                        ExecutionCmdletHelper
                        helper = operation as ExecutionCmdletHelper
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160590, 160659);

                        RemoteRunspace
                        remoteRS = f_1573_160616_160640(f_1573_160616_160631(helper)) as RemoteRunspace
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160677, 161033) || true) && (remoteRS != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 160677, 161033);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160739, 160791);

                            remoteRS.StateChanged += HandleRunspaceStateChanged;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160815, 161014) || true) && (f_1573_160819_160851(f_1573_160819_160845(remoteRS)) == RunspaceState.BeforeOpen)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 160815, 161014);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 160929, 160991);

                                remoteRS.URIRedirectionReported += HandleURIDirectionReported;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 160815, 161014);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 160677, 161033);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161053, 161074);

                        f_1573_161053_161073(
                                        _helpers, helper);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161092, 161127);

                        f_1573_161092_161126(this, helper);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161147, 161256);

                        f_1573_161147_161255(f_1573_161158_161173(helper) is RemotePipeline, "Only remote pipeline can be used in InvokeExpressionSyncJob");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161274, 161334);

                        RemotePipeline
                        pipeline = f_1573_161300_161315(helper) as RemotePipeline
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161352, 161422);

                        f_1573_161352_161421(_powershells, f_1573_161369_161399(f_1573_161369_161388(pipeline)), f_1573_161401_161420(pipeline));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 160419, 161437);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 1019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 1019);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 160106, 161448);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 160106, 161448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 160106, 161448);
            }
        }

        private bool _cleanupDone;

        protected override void DoCleanupOnFinished()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 161669, 162815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161739, 161762);

                bool
                doCleanup = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161776, 162088) || true) && (_cleanupDone == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 161776, 162088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161841, 161851);
                    lock (SyncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161893, 162054) || true) && (_cleanupDone == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 161893, 162054);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 161968, 161988);

                            _cleanupDone = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162014, 162031);

                            doCleanup = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 161893, 162054);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 161776, 162088);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162104, 162127) || true) && (!doCleanup)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 162104, 162127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162120, 162127);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 162104, 162127);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162143, 162664);
                    foreach (ExecutionCmdletHelper helper in f_1573_162184_162192_I(_helpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 162143, 162664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162287, 162355);

                        RemoteRunspace
                        remoteRS = f_1573_162313_162336(helper) as RemoteRunspace
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162373, 162590) || true) && (remoteRS != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 162373, 162590);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162435, 162487);

                            remoteRS.StateChanged -= HandleRunspaceStateChanged;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162509, 162571);

                            remoteRS.URIRedirectionReported -= HandleURIDirectionReported;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 162373, 162590);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162610, 162649);

                        f_1573_162610_162648(this, helper);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 162143, 162664);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162680, 162725);

                f_1573_162680_162724(this, _throttleManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 162781, 162804);

                f_1573_162781_162803(f_1573_162781_162788());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 161669, 162815);

                System.Management.Automation.Runspaces.Runspace
                f_1573_162313_162336(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.PipelineRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 162313, 162336);
                    return return_v;
                }


                int
                f_1573_162610_162648(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper)
                {
                    this_param.StopAggregateResultsFromHelper(helper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 162610, 162648);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                f_1573_162184_162192_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 162184, 162192);
                    return return_v;
                }


                int
                f_1573_162680_162724(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, System.Management.Automation.Remoting.ThrottleManager
                throttleManager)
                {
                    this_param.UnregisterThrottleComplete(throttleManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 162680, 162724);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1573_162781_162788()
                {
                    var return_v = Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 162781, 162788);
                    return return_v;
                }


                int
                f_1573_162781_162803(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.DecrementRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 162781, 162803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 161669, 162815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 161669, 162815);
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 162984, 163091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 163056, 163080);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing), 1573, 163056, 163079);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 162984, 163091);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 162984, 163091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 162984, 163091);
            }
        }

        protected override void HandleOperationComplete(object sender, OperationStateEventArgs stateEventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 163445, 164112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 163572, 163635);

                ExecutionCmdletHelper
                helper = sender as ExecutionCmdletHelper
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 163649, 163739);

                f_1573_163649_163738(helper != null, "Sender of OperationComplete has to be ExecutionCmdletHelper");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 163755, 163782);

                Exception
                failureException
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 163851, 163882);

                ErrorRecord
                failureErrorRecord
                = default(ErrorRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 163898, 163970);

                f_1573_163898_163969(this, helper, out failureException, out failureErrorRecord);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 163986, 164101) || true) && (failureErrorRecord != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 163986, 164101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 164050, 164086);

                    f_1573_164050_164085(this, failureErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 163986, 164101);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 163445, 164112);

                int
                f_1573_163649_163738(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 163649, 163738);
                    return 0;
                }


                int
                f_1573_163898_163969(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper, out System.Exception
                failureException, out System.Management.Automation.ErrorRecord
                failureErrorRecord)
                {
                    this_param.ProcessJobFailure(helper, out failureException, out failureErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 163898, 163969);
                    return 0;
                }


                int
                f_1573_164050_164085(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 164050, 164085);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 163445, 164112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 163445, 164112);
            }
        }

        protected override void HandlePipelineStateChanged(object sender, PipelineStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 164300, 164935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 164416, 164464);

                PipelineState
                state = f_1573_164438_164463(f_1573_164438_164457(e))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 164478, 164924);

                switch (state)
                {

                    case PipelineState.Running:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 164478, 164924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 164574, 164604);

                        f_1573_164574_164603(this, JobState.Running);
                        DynAbs.Tracing.TraceSender.TraceBreak(1573, 164626, 164632);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 164478, 164924);

                    case PipelineState.Completed:
                    case PipelineState.Failed:
                    case PipelineState.Stopped:
                    case PipelineState.Disconnected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 164478, 164924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 164842, 164881);

                        f_1573_164842_164880(this, state);
                        DynAbs.Tracing.TraceSender.TraceBreak(1573, 164903, 164909);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 164478, 164924);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 164300, 164935);

                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_164438_164457(System.Management.Automation.Runspaces.PipelineStateEventArgs
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 164438, 164457);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_164438_164463(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 164438, 164463);
                    return return_v;
                }


                int
                f_1573_164574_164603(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 164574, 164603);
                    return 0;
                }


                int
                f_1573_164842_164880(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState)
                {
                    this_param.CheckForAndSetDisconnectedState(pipelineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 164842, 164880);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 164300, 164935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 164300, 164935);
            }
        }

        private void CheckForAndSetDisconnectedState(PipelineState pipelineState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 165206, 166433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165304, 165335);

                bool
                setJobStateToDisconnected
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165355, 165365);
                lock (SyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165399, 165488) || true) && (f_1573_165403_165420(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 165399, 165488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165462, 165469);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 165399, 165488);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165508, 165948);

                    switch (pipelineState)
                    {

                        case PipelineState.Completed:
                        case PipelineState.Failed:
                        case PipelineState.Stopped:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 165508, 165948);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165723, 165751);

                            _pipelineFinishedCount += 1;
                            DynAbs.Tracing.TraceSender.TraceBreak(1573, 165777, 165783);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 165508, 165948);

                        case PipelineState.Disconnected:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 165508, 165948);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165865, 165897);

                            _pipelineDisconnectedCount += 1;
                            DynAbs.Tracing.TraceSender.TraceBreak(1573, 165923, 165929);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 165508, 165948);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 165968, 166151);

                    setJobStateToDisconnected = ((_pipelineFinishedCount + _pipelineDisconnectedCount) == f_1573_166054_166068(_helpers) && (DynAbs.Tracing.TraceSender.Expression_True(1573, 165997, 166149) && _pipelineDisconnectedCount > 0));
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 166182, 166422) || true) && (setJobStateToDisconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 166182, 166422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 166372, 166407);

                    f_1573_166372_166406(this, JobState.Disconnected);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 166182, 166422);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 165206, 166433);

                bool
                f_1573_165403_165420(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param)
                {
                    var return_v = this_param.IsTerminalState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 165403, 165420);
                    return return_v;
                }


                int
                f_1573_166054_166068(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 166054, 166068);
                    return return_v;
                }


                int
                f_1573_166372_166406(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 166372, 166406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 165206, 166433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 165206, 166433);
            }
        }

        public override void StopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 166534, 166637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 166589, 166626);

                f_1573_166589_166625(_throttleManager);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 166534, 166637);

                int
                f_1573_166589_166625(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.StopAllOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 166589, 166625);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 166534, 166637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 166534, 166637);
            }
        }

        private bool _doFinishCalled;

        protected override void DoFinish()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 166875, 167534);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 166934, 166987) || true) && (_doFinishCalled == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 166934, 166987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 166980, 166987);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 166934, 166987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167009, 167019);

                lock (SyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167053, 167110) || true) && (_doFinishCalled == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 167053, 167110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167103, 167110);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 167053, 167110);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167130, 167153);

                    _doFinishCalled = true;
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167184, 167315);
                    foreach (ExecutionCmdletHelper helper in f_1573_167225_167233_I(_helpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 167184, 167315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167267, 167300);

                        f_1573_167267_167299(this, helper);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 167184, 167315);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 132);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167331, 167485) || true) && (f_1573_167335_167349(_helpers) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1573, 167335, 167404) && f_1573_167358_167381(f_1573_167358_167375(this)) == JobState.NotStarted))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 167331, 167485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167438, 167470);

                    f_1573_167438_167469(this, JobState.Completed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 167331, 167485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167501, 167523);

                f_1573_167501_167522(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 166875, 167534);

                int
                f_1573_167267_167299(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper)
                {
                    this_param.DeterminedAndSetJobState(helper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 167267, 167299);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                f_1573_167225_167233_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 167225, 167233);
                    return return_v;
                }


                int
                f_1573_167335_167349(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 167335, 167349);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_167358_167375(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 167358, 167375);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_167358_167381(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 167358, 167381);
                    return return_v;
                }


                int
                f_1573_167438_167469(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 167438, 167469);
                    return 0;
                }


                int
                f_1573_167501_167522(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param)
                {
                    this_param.DoCleanupOnFinished();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 167501, 167522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 166875, 167534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 166875, 167534);
            }
        }

        internal override PowerShell GetPowerShell(Guid instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 167786, 168013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167870, 167899);

                PowerShell
                powershell = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167915, 167968);

                f_1573_167915_167967(
                            _powershells, instanceId, out powershell);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 167984, 168002);

                return powershell;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 167786, 168013);

                bool
                f_1573_167915_167967(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>
                this_param, System.Guid
                key, out System.Management.Automation.PowerShell
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 167915, 167967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 167786, 168013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 167786, 168013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleRunspaceStateChanged(object sender, RunspaceStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 168284, 169053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 168389, 168440);

                RemoteRunspace
                remoteRS = sender as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 168594, 169042) || true) && (remoteRS != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 168594, 169042);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 168648, 169027) || true) && (f_1573_168652_168677(f_1573_168652_168671(e)) != RunspaceState.Opening)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 168648, 169027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 168744, 168806);

                        remoteRS.URIRedirectionReported -= HandleURIDirectionReported;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 168830, 169008) || true) && (f_1573_168834_168859(f_1573_168834_168853(e)) != RunspaceState.Opened)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 168830, 169008);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 168933, 168985);

                            remoteRS.StateChanged -= HandleRunspaceStateChanged;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 168830, 169008);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 168648, 169027);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 168594, 169042);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 168284, 169053);

                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1573_168652_168671(System.Management.Automation.Runspaces.RunspaceStateEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 168652, 168671);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1573_168652_168677(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 168652, 168677);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1573_168834_168853(System.Management.Automation.Runspaces.RunspaceStateEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 168834, 168853);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1573_168834_168859(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 168834, 168859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 168284, 169053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 168284, 169053);
            }
        }

        internal void StartOperations(List<IThrottleOperation> operations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 169249, 169508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 169398, 169444);

                f_1573_169398_169443(            // submit operations to the throttle manager
                            _throttleManager, operations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 169458, 169497);

                f_1573_169458_169496(_throttleManager);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 169249, 169508);

                int
                f_1573_169398_169443(System.Management.Automation.Remoting.ThrottleManager
                this_param, System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                operations)
                {
                    this_param.SubmitOperations(operations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 169398, 169443);
                    return 0;
                }


                int
                f_1573_169458_169496(System.Management.Automation.Remoting.ThrottleManager
                this_param)
                {
                    this_param.EndSubmitOperations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 169458, 169496);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 169249, 169508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 169249, 169508);
            }
        }

        internal bool IsTerminalState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 169719, 169909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 169775, 169898);

                return (f_1573_169783_169823(this, f_1573_169799_169822(f_1573_169799_169816(this))) || (DynAbs.Tracing.TraceSender.Expression_False(1573, 169783, 169896) || f_1573_169848_169871(f_1573_169848_169865(this)) == JobState.Disconnected));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 169719, 169909);

                System.Management.Automation.JobStateInfo
                f_1573_169799_169816(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 169799, 169816);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_169799_169822(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 169799, 169822);
                    return return_v;
                }


                bool
                f_1573_169783_169823(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 169783, 169823);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1573_169848_169865(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 169848, 169865);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1573_169848_169871(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 169848, 169871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 169719, 169909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 169719, 169909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<PowerShell> GetPowerShells()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 170101, 170438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 170174, 170248);

                Collection<PowerShell>
                powershellsToReturn = f_1573_170219_170247()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 170262, 170384);
                    foreach (PowerShell ps in f_1573_170288_170307_I(f_1573_170288_170307(_powershells)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 170262, 170384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 170341, 170369);

                        f_1573_170341_170368(powershellsToReturn, ps);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 170262, 170384);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 170400, 170427);

                return powershellsToReturn;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 170101, 170438);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
                f_1573_170219_170247()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 170219, 170247);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>.ValueCollection
                f_1573_170288_170307(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 170288, 170307);
                    return return_v;
                }


                int
                f_1573_170341_170368(System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
                this_param, System.Management.Automation.PowerShell
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 170341, 170368);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>.ValueCollection
                f_1573_170288_170307_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 170288, 170307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 170101, 170438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 170101, 170438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSRemotingJob CreateDisconnectedRemotingJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1573, 170680, 171574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 170759, 170840);

                List<IThrottleOperation>
                disconnectedJobHelpers = f_1573_170809_170839()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 170854, 171369);
                    foreach (var helper in f_1573_170877_170885_I(_helpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 170854, 171369);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 170919, 171354) || true) && (f_1573_170923_170962(f_1573_170923_170956(f_1573_170923_170938(helper))) == PipelineState.Disconnected)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 170919, 171354);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 171101, 171143);

                            f_1573_171101_171142(this, helper);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 171261, 171335);

                            f_1573_171261_171334(
                                                // Create new helper used to create the new Disconnected PSRemoting job.
                                                disconnectedJobHelpers, f_1573_171288_171333(f_1573_171317_171332(helper)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 170919, 171354);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 170854, 171369);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1573, 1, 516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1573, 1, 516);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 171385, 171483) || true) && (f_1573_171389_171417(disconnectedJobHelpers) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1573, 171385, 171483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 171456, 171468);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1573, 171385, 171483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 171499, 171563);

                return f_1573_171506_171562(disconnectedJobHelpers, 0, f_1573_171551_171555(), true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1573, 170680, 171574);

                System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                f_1573_170809_170839()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 170809, 170839);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1573_170923_170938(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 170923, 170938);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1573_170923_170956(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 170923, 170956);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1573_170923_170962(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 170923, 170962);
                    return return_v;
                }


                int
                f_1573_171101_171142(System.Management.Automation.PSInvokeExpressionSyncJob
                this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                helper)
                {
                    this_param.RemoveAggreateCallbacksFromHelper(helper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 171101, 171142);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1573_171317_171332(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 171317, 171332);
                    return return_v;
                }


                System.Management.Automation.DisconnectedJobOperation
                f_1573_171288_171333(System.Management.Automation.Runspaces.Pipeline
                pipeline)
                {
                    var return_v = new System.Management.Automation.DisconnectedJobOperation(pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 171288, 171333);
                    return return_v;
                }


                int
                f_1573_171261_171334(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param, System.Management.Automation.DisconnectedJobOperation
                item)
                {
                    this_param.Add((System.Management.Automation.Remoting.IThrottleOperation)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 171261, 171334);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                f_1573_170877_170885_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 170877, 170885);
                    return return_v;
                }


                int
                f_1573_171389_171417(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 171389, 171417);
                    return return_v;
                }


                string
                f_1573_171551_171555()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 171551, 171555);
                    return return_v;
                }


                System.Management.Automation.PSRemotingJob
                f_1573_171506_171562(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
                helpers, int
                throttleLimit, string
                name, bool
                aggregateResults)
                {
                    var return_v = new System.Management.Automation.PSRemotingJob(helpers, throttleLimit, name, aggregateResults);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 171506, 171562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 170680, 171574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 170680, 171574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSInvokeExpressionSyncJob()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 159311, 171620);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 159311, 171620);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 159311, 171620);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 159311, 171620);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
        f_1573_159471_159504()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 159471, 159504);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>
        f_1573_159618_159652()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 159618, 159652);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
        f_1573_160278_160285()
        {
            var return_v = Results;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 160278, 160285);
            return return_v;
        }


        int
        f_1573_160278_160294(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
        this_param)
        {
            this_param.AddRef();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 160278, 160294);
            return 0;
        }


        int
        f_1573_160360_160402(System.Management.Automation.PSInvokeExpressionSyncJob
        this_param, System.Management.Automation.Remoting.ThrottleManager
        throttleManager)
        {
            this_param.RegisterThrottleComplete(throttleManager);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 160360, 160402);
            return 0;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_160616_160631(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 160616, 160631);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1573_160616_160640(System.Management.Automation.Runspaces.Pipeline
        this_param)
        {
            var return_v = this_param.Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 160616, 160640);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspaceStateInfo
        f_1573_160819_160845(System.Management.Automation.RemoteRunspace
        this_param)
        {
            var return_v = this_param.RunspaceStateInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 160819, 160845);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspaceState
        f_1573_160819_160851(System.Management.Automation.Runspaces.RunspaceStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 160819, 160851);
            return return_v;
        }


        int
        f_1573_161053_161073(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ExecutionCmdletHelper>
        this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 161053, 161073);
            return 0;
        }


        int
        f_1573_161092_161126(System.Management.Automation.PSInvokeExpressionSyncJob
        this_param, Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        helper)
        {
            this_param.AggregateResultsFromHelper(helper);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 161092, 161126);
            return 0;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_161158_161173(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 161158, 161173);
            return return_v;
        }


        int
        f_1573_161147_161255(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 161147, 161255);
            return 0;
        }


        System.Management.Automation.Runspaces.Pipeline
        f_1573_161300_161315(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
        this_param)
        {
            var return_v = this_param.Pipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 161300, 161315);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1573_161369_161388(System.Management.Automation.RemotePipeline
        this_param)
        {
            var return_v = this_param.PowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 161369, 161388);
            return return_v;
        }


        System.Guid
        f_1573_161369_161399(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.InstanceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 161369, 161399);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1573_161401_161420(System.Management.Automation.RemotePipeline
        this_param)
        {
            var return_v = this_param.PowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1573, 161401, 161420);
            return return_v;
        }


        int
        f_1573_161352_161421(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.PowerShell>
        this_param, System.Guid
        key, System.Management.Automation.PowerShell
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 161352, 161421);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        f_1573_160460_160470_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1573, 160460, 160470);
            return return_v;
        }

    }
    internal class OutputProcessingStateEventArgs : EventArgs
    {
        internal bool ProcessingOutput
        {
            get;
            private set;
        }

        internal OutputProcessingStateEventArgs(bool processingOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1573, 171853, 171987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 171745, 171841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1573, 171940, 171976);

                ProcessingOutput = processingOutput;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1573, 171853, 171987);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1573, 171853, 171987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 171853, 171987);
            }
        }

        static OutputProcessingStateEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1573, 171671, 171994);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1573, 171671, 171994);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1573, 171671, 171994);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1573, 171671, 171994);
    }

    internal interface IOutputProcessingState
    {
        event EventHandler<OutputProcessingStateEventArgs>
OutputProcessingStateChanged
;
    }

}
