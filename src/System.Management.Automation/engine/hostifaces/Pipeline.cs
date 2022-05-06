// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces
{
    [Serializable]
    public class InvalidPipelineStateException : SystemException
    {
        public InvalidPipelineStateException()
        : base(f_1475_853_920_C(f_1475_853_920(f_1475_871_919())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 794, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4224, 4241);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4432, 4450);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 794, 943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 794, 943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 794, 943);
            }
        }

        public InvalidPipelineStateException(string message)
        : base(f_1475_1332_1339_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 1263, 1362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4224, 4241);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4432, 4450);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 1263, 1362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 1263, 1362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 1263, 1362);
            }
        }

        public InvalidPipelineStateException(string message, Exception innerException)
        : base(f_1475_1988_1995_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 1893, 2034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4224, 4241);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4432, 4450);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 1893, 2034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 1893, 2034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 1893, 2034);
            }
        }

        internal InvalidPipelineStateException(string message, PipelineState currentState, PipelineState expectedState)
        : base(f_1475_2635_2642_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 2507, 2753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4224, 4241);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4432, 4450);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 2668, 2699);

                _expectedState = expectedState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 2713, 2742);

                _currentState = currentState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 2507, 2753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 2507, 2753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 2507, 2753);
            }
        }

        private InvalidPipelineStateException(SerializationInfo info, StreamingContext context)
        : base(f_1475_3589_3593_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 3485, 3625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4224, 4241);
                this._currentState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4432, 4450);
                this._expectedState = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 3485, 3625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 3485, 3625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 3485, 3625);
            }
        }

        public PipelineState CurrentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 3812, 3841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 3818, 3839);

                    return _currentState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 3812, 3841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 3754, 3852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 3754, 3852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PipelineState ExpectedState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 4019, 4049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 4025, 4047);

                    return _expectedState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 4019, 4049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 3960, 4060);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 3960, 4060);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [NonSerialized]
        private PipelineState _currentState;

        [NonSerialized]
        private PipelineState _expectedState;

        static InvalidPipelineStateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1475, 566, 4458);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1475, 566, 4458);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 566, 4458);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1475, 566, 4458);

        static string
        f_1475_871_919()
        {
            var return_v = RunspaceStrings.InvalidPipelineStateStateGeneral;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1475, 871, 919);
            return return_v;
        }


        static string
        f_1475_853_920(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 853, 920);
            return return_v;
        }


        static string
        f_1475_853_920_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1475, 794, 943);
            return return_v;
        }


        static string
        f_1475_1332_1339_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1475, 1263, 1362);
            return return_v;
        }


        static string
        f_1475_1988_1995_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1475, 1893, 2034);
            return return_v;
        }


        static string
        f_1475_2635_2642_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1475, 2507, 2753);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1475_3589_3593_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1475, 3485, 3625);
            return return_v;
        }

    }



    /// <summary>
    /// Enumerated type defining the state of the Pipeline.
    /// </summary>
    public enum PipelineState
    {
        /// <summary>
        /// The pipeline has not been started.
        /// </summary>
        NotStarted = 0,
        /// <summary>
        /// The pipeline is executing.
        /// </summary>
        Running = 1,
        /// <summary>
        /// The pipeline is stoping execution.
        /// </summary>
        Stopping = 2,
        /// <summary>
        /// The pipeline is completed due to a stop request.
        /// </summary>
        Stopped = 3,
        /// <summary>
        /// The pipeline has completed.
        /// </summary>
        Completed = 4,
        /// <summary>
        /// The pipeline completed abnormally due to an error.
        /// </summary>
        Failed = 5,
        /// <summary>
        /// The pipeline is disconnected from remote running command.
        /// </summary>
        Disconnected = 6
    }
    public sealed class PipelineStateInfo
    {
        internal PipelineStateInfo(PipelineState state)
        : this(f_1475_6017_6022_C(state), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 5949, 6051);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 5949, 6051);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 5949, 6051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 5949, 6051);
            }
        }

        internal PipelineStateInfo(PipelineState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 6383, 6528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 7410, 7445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 7783, 7815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 6473, 6487);

                State = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 6501, 6517);

                Reason = reason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 6383, 6528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 6383, 6528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 6383, 6528);
            }
        }

        internal PipelineStateInfo(PipelineStateInfo pipelineStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 6841, 7114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 7410, 7445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 7783, 7815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 6929, 7007);

                f_1475_6929_7006(pipelineStateInfo != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 7023, 7055);

                State = f_1475_7031_7054(pipelineStateInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 7069, 7103);

                Reason = f_1475_7078_7102(pipelineStateInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 6841, 7114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 6841, 7114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 6841, 7114);
            }
        }

        public PipelineState State { get; }

        public Exception Reason { get; }

        internal PipelineStateInfo Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 7994, 8099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 8053, 8088);

                return f_1475_8060_8087(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 7994, 8099);

                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1475_8060_8087(System.Management.Automation.Runspaces.PipelineStateInfo
                pipelineStateInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.PipelineStateInfo(pipelineStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 8060, 8087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 7994, 8099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 7994, 8099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PipelineStateInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1475, 5686, 8106);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1475, 5686, 8106);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 5686, 8106);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1475, 5686, 8106);

        static System.Management.Automation.Runspaces.PipelineState
        f_1475_6017_6022_C(System.Management.Automation.Runspaces.PipelineState
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1475, 5949, 6051);
            return return_v;
        }


        int
        f_1475_6929_7006(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 6929, 7006);
            return 0;
        }


        System.Management.Automation.Runspaces.PipelineState
        f_1475_7031_7054(System.Management.Automation.Runspaces.PipelineStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1475, 7031, 7054);
            return return_v;
        }


        System.Exception
        f_1475_7078_7102(System.Management.Automation.Runspaces.PipelineStateInfo
        this_param)
        {
            var return_v = this_param.Reason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1475, 7078, 7102);
            return return_v;
        }

    }
    public sealed class PipelineStateEventArgs : EventArgs
    {
        internal PipelineStateEventArgs(PipelineStateInfo pipelineStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 8722, 8956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 9138, 9189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 8815, 8893);

                f_1475_8815_8892(pipelineStateInfo != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 8907, 8945);

                PipelineStateInfo = pipelineStateInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 8722, 8956);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 8722, 8956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 8722, 8956);
            }
        }

        public PipelineStateInfo PipelineStateInfo { get; }

        static PipelineStateEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1475, 8268, 9236);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1475, 8268, 9236);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 8268, 9236);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1475, 8268, 9236);

        int
        f_1475_8815_8892(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 8815, 8892);
            return 0;
        }

    }
    public abstract class Pipeline : IDisposable
    {
        internal Pipeline(Runspace runspace)
        : this(f_1475_9630_9638_C(runspace), f_1475_9640_9663())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 9573, 9686);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 9573, 9686);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 9573, 9686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 9573, 9686);
            }
        }

        internal Pipeline(Runspace runspace, CommandCollection command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1475, 10157, 10814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 13964, 13974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 14284, 14315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 14438, 14493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 14653, 14710);
                this.SetPipelineSessionState = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 14827, 14889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 16151, 16216);
                this.RedirectShellErrorOutputPipe = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 10245, 10365) || true) && (runspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1475, 10245, 10365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 10299, 10350);

                    f_1475_10299_10349("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1475, 10245, 10365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 10496, 10550);

                f_1475_10496_10549(command != null, "Command cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 10564, 10607);

                InstanceId = f_1475_10577_10606(runspace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 10621, 10640);

                Commands = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 10778, 10803);

                f_1475_10778_10802();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1475, 10157, 10814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 10157, 10814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 10157, 10814);
            }
        }

        public abstract Runspace Runspace { get; }

        public abstract bool IsNested { get; }

        internal virtual bool IsChild
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 11614, 11635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 11620, 11633);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 11614, 11635);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 11560, 11669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 11560, 11669);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 11651, 11658);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 11651, 11658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 11560, 11669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 11560, 11669);
                }
            }
        }

        public abstract PipelineWriter Input { get; }

        public abstract PipelineReader<PSObject> Output { get; }

        public abstract PipelineReader<object> Error { get; }

        public abstract PipelineStateInfo PipelineStateInfo { get; }

        public virtual bool HadErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 13902, 13928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 13908, 13926);

                    return _hadErrors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 13902, 13928);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 13848, 13939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 13848, 13939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _hadErrors;

        internal void SetHadErrors(bool status)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 13987, 14096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 14051, 14085);

                _hadErrors = _hadErrors || (DynAbs.Tracing.TraceSender.Expression_False(1475, 14064, 14084) || status);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 13987, 14096);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 13987, 14096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 13987, 14096);
            }
        }

        public long InstanceId { get; }

        public CommandCollection Commands { get; private set; }

        public bool SetPipelineSessionState { get; set; }

        internal PSInvocationSettings InvocationSettings { get; set; }

        internal bool RedirectShellErrorOutputPipe { get; set; }



        /// <summary>
        /// Event raised when Pipeline's state changes.
        /// </summary>
        public abstract event EventHandler<PipelineStateEventArgs>
StateChanged
;

        public Collection<PSObject> Invoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 19516, 19608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 19577, 19597);

                return f_1475_19584_19596(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 19516, 19608);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1475_19584_19596(System.Management.Automation.Runspaces.Pipeline
                this_param, System.Collections.IEnumerable
                input)
                {
                    var return_v = this_param.Invoke(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 19584, 19596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 19516, 19608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 19516, 19608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract Collection<PSObject> Invoke(IEnumerable input);

        public abstract void InvokeAsync();

        public abstract void Stop();

        public abstract void StopAsync();

        public abstract Pipeline Copy();

        public abstract Collection<PSObject> Connect();

        public abstract void ConnectAsync();

        internal void SetCommandCollection(CommandCollection commands)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 25999, 26117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 26086, 26106);

                Commands = commands;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 25999, 26117);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 25999, 26117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 25999, 26117);
            }
        }

        internal abstract void SetHistoryString(string historyString);

        internal abstract void InvokeAsyncAndDisconnect();

        internal virtual void SuspendIncomingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 26792, 26909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 26860, 26898);

                throw f_1475_26866_26897();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 26792, 26909);

                System.Management.Automation.PSNotImplementedException
                f_1475_26866_26897()
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 26866, 26897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 26792, 26909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 26792, 26909);
            }
        }

        internal virtual void ResumeIncomingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 27022, 27138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 27089, 27127);

                throw f_1475_27095_27126();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 27022, 27138);

                System.Management.Automation.PSNotImplementedException
                f_1475_27095_27126()
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 27095, 27126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 27022, 27138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 27022, 27138);
            }
        }

        internal virtual void DrainIncomingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 27294, 27409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 27360, 27398);

                throw f_1475_27366_27397();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 27294, 27409);

                System.Management.Automation.PSNotImplementedException
                f_1475_27366_27397()
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 27366, 27397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 27294, 27409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 27294, 27409);
            }
        }

        public
                void
                Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 27636, 27769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 27700, 27718);

                f_1475_27700_27717(this, f_1475_27708_27716_M(!IsChild));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1475, 27732, 27758);

                f_1475_27732_27757(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 27636, 27769);

                bool
                f_1475_27708_27716_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1475, 27708, 27716);
                    return return_v;
                }


                int
                f_1475_27700_27717(System.Management.Automation.Runspaces.Pipeline
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 27700, 27717);
                    return 0;
                }


                int
                f_1475_27732_27757(System.Management.Automation.Runspaces.Pipeline
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 27732, 27757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 27636, 27769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 27636, 27769);
            }
        }

        protected virtual
                void
                Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1475, 27949, 28035);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1475, 27949, 28035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1475, 27949, 28035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 27949, 28035);
            }
        }

        static Pipeline()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1475, 9391, 28084);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1475, 9391, 28084);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1475, 9391, 28084);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1475, 9391, 28084);

        static System.Management.Automation.Runspaces.CommandCollection
        f_1475_9640_9663()
        {
            var return_v = new System.Management.Automation.Runspaces.CommandCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 9640, 9663);
            return return_v;
        }


        static System.Management.Automation.Runspaces.Runspace
        f_1475_9630_9638_C(System.Management.Automation.Runspaces.Runspace
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1475, 9573, 9686);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1475_10299_10349(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 10299, 10349);
            return return_v;
        }


        int
        f_1475_10496_10549(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 10496, 10549);
            return 0;
        }


        long
        f_1475_10577_10606(System.Management.Automation.Runspaces.Runspace
        this_param)
        {
            var return_v = this_param.GeneratePipelineId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 10577, 10606);
            return return_v;
        }


        int
        f_1475_10778_10802()
        {
            AmsiUtils.CloseSession();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1475, 10778, 10802);
            return 0;
        }

    }
}

