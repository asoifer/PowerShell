// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal
{
    [DebuggerDisplay("Command = {_commandInfo}")]
    public abstract class InternalCommand
    {
        internal ICommandRuntime commandRuntime;

        internal InternalCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1245, 2081, 2167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 1721, 1735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 2401, 2454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 2489, 2509);
                this._myInvocation = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 2997, 3043);
                this.currentObjectInPipeline = f_1245_3023_3043();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 3653, 3660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 3899, 3905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 4414, 4426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5729, 5737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 6069, 6115);
                this.CommandOriginInternal = CommandOrigin.Internal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 2132, 2156);

                this.CommandInfo = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1245, 2081, 2167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 2081, 2167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 2081, 2167);
            }
        }

        internal IScriptExtent InvocationExtent { get; set; }

        private InvocationInfo _myInvocation;

        internal InvocationInfo MyInvocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 2761, 2836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 2767, 2834);

                    return _myInvocation ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.InvocationInfo>(1245, 2774, 2833) ?? (_myInvocation = f_1245_2808_2832(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 2761, 2836);

                    System.Management.Automation.InvocationInfo
                    f_1245_2808_2832(System.Management.Automation.Internal.InternalCommand
                    command)
                    {
                        var return_v = new System.Management.Automation.InvocationInfo(command);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 2808, 2832);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 2700, 2847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 2700, 2847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSObject currentObjectInPipeline;

        internal PSObject CurrentPipelineObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 3242, 3281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 3248, 3279);

                    return currentObjectInPipeline;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 3242, 3281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 3178, 3391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 3178, 3391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 3297, 3380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 3333, 3365);

                    currentObjectInPipeline = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 3297, 3380);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 3178, 3391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 3178, 3391);
                }
            }
        }

        internal PSHost PSHostInternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 3592, 3615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 3598, 3613);

                    return _CBhost;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 3592, 3615);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 3537, 3626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 3537, 3626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSHost _CBhost;

        internal SessionState InternalState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 3833, 3855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 3839, 3853);

                    return _state;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 3833, 3855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 3773, 3866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 3773, 3866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SessionState _state;

        internal bool IsStopping
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 4103, 4276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 4139, 4204);

                    MshCommandRuntime
                    mcr = this.commandRuntime as MshCommandRuntime
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 4222, 4261);

                    return (mcr != null && (DynAbs.Tracing.TraceSender.Expression_True(1245, 4230, 4259) && f_1245_4245_4259(mcr)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 4103, 4276);

                    bool
                    f_1245_4245_4259(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.IsStopping;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 4245, 4259);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 4054, 4287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 4054, 4287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CommandInfo _commandInfo;

        internal CommandInfo CommandInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 4608, 4636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 4614, 4634);

                    return _commandInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 4608, 4636);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 4551, 4692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 4551, 4692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 4652, 4681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 4658, 4679);

                    _commandInfo = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 4652, 4681);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 4551, 4692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 4551, 4692);
                }
            }
        }

        internal ExecutionContext Context
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 5057, 5081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5063, 5079);

                    return _context;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 5057, 5081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 4999, 5692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 4999, 5692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 5097, 5681);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5133, 5267) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1245, 5133, 5267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5192, 5248);

                        throw f_1245_5198_5247("Context");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1245, 5133, 5267);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5287, 5304);

                    _context = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5322, 5441);

                    f_1245_5322_5440(f_1245_5341_5369(_context) is InternalHost, "context.EngineHostInterface is not an InternalHost");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5459, 5512);

                    _CBhost = (InternalHost)f_1245_5483_5511(_context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5611, 5666);

                    _state = f_1245_5620_5665(f_1245_5637_5664(_context));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 5097, 5681);

                    System.Management.Automation.PSArgumentNullException
                    f_1245_5198_5247(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 5198, 5247);
                        return return_v;
                    }


                    System.Management.Automation.Internal.Host.InternalHost
                    f_1245_5341_5369(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineHostInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 5341, 5369);
                        return return_v;
                    }


                    int
                    f_1245_5322_5440(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 5322, 5440);
                        return 0;
                    }


                    System.Management.Automation.Internal.Host.InternalHost
                    f_1245_5483_5511(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineHostInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 5483, 5511);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1245_5637_5664(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 5637, 5664);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1245_5620_5665(System.Management.Automation.SessionStateInternal
                    sessionState)
                    {
                        var return_v = new System.Management.Automation.SessionState(sessionState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 5620, 5665);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 4999, 5692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 4999, 5692);
                }
            }
        }

        private ExecutionContext _context;

        public CommandOrigin CommandOrigin
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 5986, 6023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 5992, 6021);

                    return CommandOriginInternal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 5986, 6023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 5927, 6034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 5927, 6034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CommandOrigin CommandOriginInternal;

        internal virtual void DoBeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 6421, 6484);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 6421, 6484);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 6421, 6484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 6421, 6484);
            }
        }

        internal virtual void DoProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 6642, 6703);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 6642, 6703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 6642, 6703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 6642, 6703);
            }
        }

        internal virtual void DoEndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 6941, 7002);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 6941, 7002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 6941, 7002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 6941, 7002);
            }
        }

        internal virtual void DoStopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 7331, 7393);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 7331, 7393);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 7331, 7393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 7331, 7393);
            }
        }

        internal void ThrowIfStopping()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 7630, 7767);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 7686, 7756) || true) && (f_1245_7690_7700())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1245, 7686, 7756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 7719, 7756);

                    throw f_1245_7725_7755();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1245, 7686, 7756);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 7630, 7767);

                bool
                f_1245_7690_7700()
                {
                    var return_v = IsStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 7690, 7700);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1245_7725_7755()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 7725, 7755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 7630, 7767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 7630, 7767);
            }
        }

        internal void InternalDispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 8369, 8565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 8441, 8462);

                _myInvocation = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 8476, 8490);

                _state = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 8504, 8524);

                _commandInfo = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 8538, 8554);

                _context = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 8369, 8565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 8369, 8565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 8369, 8565);
            }
        }

        static InternalCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1245, 1556, 8594);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1245, 1556, 8594);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 1556, 8594);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1245, 1556, 8594);

        System.Management.Automation.PSObject
        f_1245_3023_3043()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 3023, 3043);
            return return_v;
        }

    }
}

namespace System.Management.Automation
{
    /// <summary>
    /// Defines the potential ErrorView options.
    /// </summary>
    public enum ErrorView
    {
        /// <summary>Existing all red multi-line output.</summary>
        NormalView = 0,

        /// <summary>Only show category information.</summary>
        CategoryView = 1,

        /// <summary>Concise shows more information on the context of the error or just the message if not a script or parser error.</summary>
        ConciseView = 2,
    }

    /// <summary>
    /// Defines the Action Preference options.  These options determine
    /// what will happen when a particular type of event occurs.
    /// For example, setting shell variable ErrorActionPreference to "Stop"
    /// will cause the command to stop when an otherwise non-terminating
    /// error occurs.
    /// </summary>
    public enum ActionPreference
    {
        /// <summary>Ignore this event and continue</summary>
        SilentlyContinue = 0,

        /// <summary>Stop the command</summary>
        Stop = 1,

        /// <summary>Handle this event as normal and continue</summary>
        Continue = 2,

        /// <summary>Ask whether to stop or continue</summary>
        Inquire = 3,

        /// <summary>Ignore the event completely (not even logging it to the target stream)</summary>
        Ignore = 4,

        /// <summary>Reserved for future use.</summary>
        Suspend = 5,

        /// <summary>Enter the debugger.</summary>
        Break = 6,
    } // enum ActionPreference

    /// <summary>
    /// Defines the ConfirmImpact levels.  These levels describe
    /// the "destructiveness" of an action, and thus the degree of
    /// important that the user confirm the action.
    /// For example, setting the read-only flag on a file might be Low,
    /// and reformatting a disk might be High.
    /// These levels are also used in $ConfirmPreference to describe
    /// which operations should be confirmed.  Operations with ConfirmImpact
    /// equal to or greater than $ConfirmPreference are confirmed.
    /// Operations with ConfirmImpact.None are never confirmed, and
    /// no operations are confirmed when $ConfirmPreference is ConfirmImpact.None
    /// (except when explicitly requested with -Confirm).
    /// </summary>
    public enum ConfirmImpact
    {
        /// <summary>There is never any need to confirm this action.</summary>
        None,
        /// <summary>
        /// This action only needs to be confirmed when the
        /// user has requested that low-impact changes must be confirmed.
        /// </summary>
        Low,
        /// <summary>
        /// This action should be confirmed in most scenarios where
        /// confirmation is requested.
        /// </summary>
        Medium,
        /// <summary>
        /// This action is potentially highly "destructive" and should be
        /// confirmed by default unless otherwise specified.
        /// </summary>
        High,
    }
    public abstract partial class PSCmdlet : Cmdlet
    {
        private ProviderIntrinsics _invokeProvider;

        public PSHost Host
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 13511, 13699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 13547, 13684);
                    using (f_1245_13554_13601())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 13643, 13665);

                        return f_1245_13650_13664();
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 13547, 13684);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 13511, 13699);

                    System.IDisposable
                    f_1245_13554_13601()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 13554, 13601);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHost
                    f_1245_13650_13664()
                    {
                        var return_v = PSHostInternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 13650, 13664);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 13468, 13710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 13468, 13710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SessionState SessionState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 13900, 14092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 13936, 14077);
                    using (f_1245_13943_13990())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 14032, 14058);

                        return f_1245_14039_14057(this);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 13936, 14077);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 13900, 14092);

                    System.IDisposable
                    f_1245_13943_13990()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 13943, 13990);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1245_14039_14057(System.Management.Automation.PSCmdlet
                    this_param)
                    {
                        var return_v = this_param.InternalState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 14039, 14057);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 13843, 14103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 13843, 14103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSEventManager Events
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 14277, 14470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 14313, 14455);
                    using (f_1245_14320_14367())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 14409, 14436);

                        return f_1245_14416_14435(f_1245_14416_14428(this));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 14313, 14455);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 14277, 14470);

                    System.IDisposable
                    f_1245_14320_14367()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 14320, 14367);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1245_14416_14428(System.Management.Automation.PSCmdlet
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 14416, 14428);
                        return return_v;
                    }


                    System.Management.Automation.PSLocalEventManager
                    f_1245_14416_14435(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.Events;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 14416, 14435);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 14224, 14481);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 14224, 14481);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public JobRepository JobRepository
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 14633, 14866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 14669, 14851);
                    using (f_1245_14676_14723())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 14765, 14832);

                        return f_1245_14772_14831(((LocalRunspace)f_1245_14788_14816(f_1245_14788_14800(this))));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 14669, 14851);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 14633, 14866);

                    System.IDisposable
                    f_1245_14676_14723()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 14676, 14723);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1245_14788_14800(System.Management.Automation.PSCmdlet
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 14788, 14800);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1245_14788_14816(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.CurrentRunspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 14788, 14816);
                        return return_v;
                    }


                    System.Management.Automation.JobRepository
                    f_1245_14772_14831(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.JobRepository;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 14772, 14831);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 14574, 14877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 14574, 14877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public JobManager JobManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 15044, 15274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 15080, 15259);
                    using (f_1245_15087_15134())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 15176, 15240);

                        return f_1245_15183_15239(((LocalRunspace)f_1245_15199_15227(f_1245_15199_15211(this))));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 15080, 15259);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 15044, 15274);

                    System.IDisposable
                    f_1245_15087_15134()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 15087, 15134);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1245_15199_15211(System.Management.Automation.PSCmdlet
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 15199, 15211);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1245_15199_15227(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.CurrentRunspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 15199, 15227);
                        return return_v;
                    }


                    System.Management.Automation.JobManager
                    f_1245_15183_15239(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.JobManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 15183, 15239);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 14991, 15285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 14991, 15285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RunspaceRepository RunspaceRepository
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 15454, 15577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 15490, 15562);

                    return f_1245_15497_15561(((LocalRunspace)f_1245_15513_15541(f_1245_15513_15525(this))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 15454, 15577);

                    System.Management.Automation.ExecutionContext
                    f_1245_15513_15525(System.Management.Automation.PSCmdlet
                    this_param)
                    {
                        var return_v = this_param.Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 15513, 15525);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1245_15513_15541(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.CurrentRunspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 15513, 15541);
                        return return_v;
                    }


                    System.Management.Automation.RunspaceRepository
                    f_1245_15497_15561(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.RunspaceRepository;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 15497, 15561);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 15383, 15588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 15383, 15588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ProviderIntrinsics InvokeProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 15800, 16041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 15836, 16026);
                    using (f_1245_15843_15890())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 15932, 16007);

                        return _invokeProvider ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ProviderIntrinsics>(1245, 15939, 16006) ?? (_invokeProvider = f_1245_15977_16005(this)));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 15836, 16026);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 15800, 16041);

                    System.IDisposable
                    f_1245_15843_15890()
                    {
                        var return_v = PSTransactionManager.GetEngineProtectionScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 15843, 15890);
                        return return_v;
                    }


                    System.Management.Automation.ProviderIntrinsics
                    f_1245_15977_16005(System.Management.Automation.PSCmdlet
                    cmdlet)
                    {
                        var return_v = new System.Management.Automation.ProviderIntrinsics((System.Management.Automation.Cmdlet)cmdlet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 15977, 16005);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 15735, 16052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 15735, 16052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PathInfo CurrentProviderLocation(string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 16207, 16833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 16290, 16822);
                using (f_1245_16297_16344())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 16378, 16520) || true) && (providerId == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1245, 16378, 16520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 16442, 16501);

                        throw f_1245_16448_16500("providerId");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1245, 16378, 16520);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 16540, 16612);

                    PathInfo
                    result = f_1245_16558_16611(f_1245_16558_16575(f_1245_16558_16570()), providerId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 16632, 16775);

                    f_1245_16632_16774(result != null, "DataStoreAdapterCollection.GetNamespaceCurrentLocation() should " + "throw an exception, not return null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 16793, 16807);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 16290, 16822);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 16207, 16833);

                System.IDisposable
                f_1245_16297_16344()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 16297, 16344);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1245_16448_16500(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 16448, 16500);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1245_16558_16570()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 16558, 16570);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1245_16558_16575(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 16558, 16575);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1245_16558_16611(System.Management.Automation.PathIntrinsics
                this_param, string
                providerName)
                {
                    var return_v = this_param.CurrentProviderLocation(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 16558, 16611);
                    return return_v;
                }


                int
                f_1245_16632_16774(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 16632, 16774);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 16207, 16833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 16207, 16833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetUnresolvedProviderPathFromPSPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 16961, 17229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 17048, 17218);
                using (f_1245_17055_17102())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 17136, 17203);

                    return f_1245_17143_17202(f_1245_17143_17160(f_1245_17143_17155()), path);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 17048, 17218);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 16961, 17229);

                System.IDisposable
                f_1245_17055_17102()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 17055, 17102);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1245_17143_17155()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 17143, 17155);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1245_17143_17160(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 17143, 17160);
                    return return_v;
                }


                string
                f_1245_17143_17202(System.Management.Automation.PathIntrinsics
                this_param, string
                path)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 17143, 17202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 16961, 17229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 16961, 17229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<string> GetResolvedProviderPathFromPSPath(string path, out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 17357, 17674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 17481, 17663);
                using (f_1245_17488_17535())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 17569, 17648);

                    return f_1245_17576_17647(f_1245_17576_17593(f_1245_17576_17588()), path, out provider);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 17481, 17663);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 17357, 17674);

                System.IDisposable
                f_1245_17488_17535()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 17488, 17535);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1245_17576_17588()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 17576, 17588);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1245_17576_17593(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 17576, 17593);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1245_17576_17647(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 17576, 17647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 17357, 17674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 17357, 17674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected PSCmdlet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1245, 18053, 18095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 13266, 13288);
                this._invokeProvider = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38881, 38898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1290, 38978, 38992);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1245, 18053, 18095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 18053, 18095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 18053, 18095);
            }
        }

        public object GetVariableValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 18298, 18531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 18366, 18520);
                using (f_1245_18373_18420())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 18454, 18505);

                    return f_1245_18461_18504(f_1245_18461_18489(f_1245_18461_18478(this)), name);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 18366, 18520);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 18298, 18531);

                System.IDisposable
                f_1245_18373_18420()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 18373, 18420);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1245_18461_18478(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 18461, 18478);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1245_18461_18489(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 18461, 18489);
                    return return_v;
                }


                object
                f_1245_18461_18504(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 18461, 18504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 18298, 18531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 18298, 18531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetVariableValue(string name, object defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1245, 18640, 18908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 18729, 18897);
                using (f_1245_18736_18783())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1245, 18817, 18882);

                    return f_1245_18824_18881(f_1245_18824_18852(f_1245_18824_18841(this)), name, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1245, 18729, 18897);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1245, 18640, 18908);

                System.IDisposable
                f_1245_18736_18783()
                {
                    var return_v = PSTransactionManager.GetEngineProtectionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 18736, 18783);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1245_18824_18841(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 18824, 18841);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1245_18824_18852(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1245, 18824, 18852);
                    return return_v;
                }


                object
                f_1245_18824_18881(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, object
                defaultValue)
                {
                    var return_v = this_param.GetValue(name, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1245, 18824, 18881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1245, 18640, 18908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 18640, 18908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSCmdlet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1245, 13140, 19067);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1245, 13140, 19067);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1245, 13140, 19067);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1245, 13140, 19067);
    }
}

