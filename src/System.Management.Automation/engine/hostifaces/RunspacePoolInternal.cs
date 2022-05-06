// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Management.Automation.Security;
using System.Management.Automation.Tracing;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;
using PSHost = System.Management.Automation.Host.PSHost;

namespace System.Management.Automation.Runspaces.Internal
{
    internal class RunspacePoolInternal
    {
        protected int maxPoolSz;

        protected int minPoolSz;

        protected int totalRunspaces;

        protected List<Runspace> runspaceList;

        protected Stack<Runspace> pool;

        protected Queue<GetRunspaceAsyncResult> runspaceRequestQueue;

        protected Queue<GetRunspaceAsyncResult> ultimateRequestQueue;

        protected RunspacePoolStateInfo stateInfo;

        protected InitialSessionState _initialSessionState;

        protected PSHost host;

        protected Guid instanceId;

        private bool _isDisposed;

        protected bool isServicingRequests;

        protected object syncObject;

        private static readonly TimeSpan s_defaultCleanupPeriod;

        private TimeSpan _cleanupInterval;

        private Timer _cleanupTimer;

        public RunspacePoolInternal(int minRunspaces,
                        int maxRunspaces,
                        PSHost host)
        : this(f_1485_3065_3077_C(minRunspaces), maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1485, 2934, 3541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 3117, 3235) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 3117, 3235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 3167, 3220);

                    throw f_1485_3173_3219("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 3117, 3235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 3251, 3268);

                this.host = host;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 3282, 3311);

                pool = f_1485_3289_3310();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 3325, 3384);

                runspaceRequestQueue = f_1485_3348_3383();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 3398, 3457);

                ultimateRequestQueue = f_1485_3421_3456();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 3471, 3530);

                _initialSessionState = f_1485_3494_3529();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1485, 2934, 3541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 2934, 3541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 2934, 3541);
            }
        }

        public RunspacePoolInternal(int minRunspaces,
                        int maxRunspaces,
                        InitialSessionState initialSessionState,
                        PSHost host)
        : this(f_1485_4929_4941_C(minRunspaces), maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1485, 4740, 5696);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 4981, 5129) || true) && (initialSessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 4981, 5129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5046, 5114);

                    throw f_1485_5052_5113("initialSessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 4981, 5129);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5145, 5263) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 5145, 5263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5195, 5248);

                    throw f_1485_5201_5247("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 5145, 5263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5279, 5330);

                _initialSessionState = f_1485_5302_5329(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5344, 5361);

                this.host = host;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5375, 5425);

                ThreadOptions = f_1485_5391_5424(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5439, 5496);

                this.ApartmentState = f_1485_5461_5495(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5510, 5539);

                pool = f_1485_5517_5538();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5553, 5612);

                runspaceRequestQueue = f_1485_5576_5611();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 5626, 5685);

                ultimateRequestQueue = f_1485_5649_5684();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1485, 4740, 5696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 4740, 5696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 4740, 5696);
            }
        }

        protected RunspacePoolInternal(int minRunspaces, int maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1485, 6241, 7338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 722, 731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 756, 765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 871, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 921, 956);
                this.runspaceList = f_1485_936_956();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1035, 1039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1132, 1152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1337, 1357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1400, 1409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1450, 1470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1498, 1502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1562, 1573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1599, 1618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1646, 1671);
                this.syncObject = f_1485_1659_1671();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1850, 1863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 9350, 9373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 31518, 31597);
                this.ThreadOptions = PSThreadOptions.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 31894, 31980);
                this.ApartmentState = Runspace.DefaultApartmentState;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6332, 6496) || true) && (maxRunspaces < 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 6332, 6496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6386, 6481);

                    throw f_1485_6392_6480("maxRunspaces", f_1485_6443_6479());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 6332, 6496);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6512, 6676) || true) && (minRunspaces < 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 6512, 6676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6566, 6661);

                    throw f_1485_6572_6660("minRunspaces", f_1485_6623_6659());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 6512, 6676);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6692, 6876) || true) && (minRunspaces > maxRunspaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 6692, 6876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6757, 6861);

                    throw f_1485_6763_6860("minRunspaces", f_1485_6814_6859());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 6692, 6876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6892, 6917);

                maxPoolSz = maxRunspaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6931, 6956);

                minPoolSz = minRunspaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 6970, 7044);

                stateInfo = f_1485_6982_7043(RunspacePoolState.BeforeOpen, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 7058, 7086);

                instanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 7100, 7151);

                f_1485_7100_7150(instanceId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 7167, 7209);

                _cleanupInterval = s_defaultCleanupPeriod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 7223, 7327);

                _cleanupTimer = f_1485_7239_7326(new TimerCallback(CleanupCallback), null, Timeout.Infinite, Timeout.Infinite);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1485, 6241, 7338);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 6241, 7338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 6241, 7338);
            }
        }

        internal RunspacePoolInternal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1485, 7431, 7466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 722, 731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 756, 765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 871, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 921, 956);
                this.runspaceList = f_1485_936_956();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1035, 1039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1132, 1152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1337, 1357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1400, 1409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1450, 1470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1498, 1502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1562, 1573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1599, 1618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1646, 1671);
                this.syncObject = f_1485_1659_1671();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1850, 1863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 9350, 9373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 31518, 31597);
                this.ThreadOptions = PSThreadOptions.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 31894, 31980);
                this.ApartmentState = Runspace.DefaultApartmentState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1485, 7431, 7466);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 7431, 7466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 7431, 7466);
            }
        }

        public Guid InstanceId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 7750, 7819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 7786, 7804);

                    return instanceId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 7750, 7819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 7703, 7830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 7703, 7830);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 8014, 8084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 8050, 8069);

                    return _isDisposed;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 8014, 8084);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 7967, 8095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 7967, 8095);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 8283, 8351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 8319, 8336);

                    return stateInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 8283, 8351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 8208, 8362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 8208, 8362);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual PSPrimitiveDictionary GetApplicationPrivateData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 8642, 9119);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 8733, 9061) || true) && (_applicationPrivateData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 8733, 9061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 8808, 8823);
                    lock (this.syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 8865, 9027) || true) && (_applicationPrivateData == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 8865, 9027);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 8950, 9004);

                            _applicationPrivateData = f_1485_8976_9003();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 8865, 9027);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 8733, 9061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 9077, 9108);

                return _applicationPrivateData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 8642, 9119);

                System.Management.Automation.PSPrimitiveDictionary
                f_1485_8976_9003()
                {
                    var return_v = new System.Management.Automation.PSPrimitiveDictionary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 8976, 9003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 8642, 9119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 8642, 9119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void PropagateApplicationPrivateData(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 9131, 9308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 9228, 9297);

                f_1485_9228_9296(runspace, f_1485_9263_9295(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 9131, 9308);

                System.Management.Automation.PSPrimitiveDictionary
                f_1485_9263_9295(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.GetApplicationPrivateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 9263, 9295);
                    return return_v;
                }


                int
                f_1485_9228_9296(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.PSPrimitiveDictionary
                applicationPrivateData)
                {
                    this_param.SetApplicationPrivateData(applicationPrivateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 9228, 9296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 9131, 9308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 9131, 9308);
            }
        }

        private PSPrimitiveDictionary _applicationPrivateData;

        public InitialSessionState InitialSessionState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 9611, 9690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 9647, 9675);

                    return _initialSessionState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 9611, 9690);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 9540, 9701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 9540, 9701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual RunspaceConnectionInfo ConnectionInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 9901, 9964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 9937, 9949);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 9901, 9964);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 9824, 9975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 9824, 9975);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 10154, 10186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 10160, 10184);

                    return _cleanupInterval;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 10154, 10186);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 10098, 10371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 10098, 10371);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 10202, 10360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 10244, 10259);
                    lock (this.syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 10301, 10326);

                        _cleanupInterval = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 10202, 10360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 10098, 10371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 10098, 10371);
                }
            }
        }

        public virtual RunspacePoolAvailability RunspacePoolAvailability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 10568, 10783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 10604, 10768);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1485, 10611, 10656) || (((f_1485_10612_10627(stateInfo) == RunspacePoolState.Opened) && DynAbs.Tracing.TraceSender.Conditional_F2(1485, 10680, 10714)) || DynAbs.Tracing.TraceSender.Conditional_F3(1485, 10738, 10767))) ? RunspacePoolAvailability.Available : RunspacePoolAvailability.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 10568, 10783);

                    System.Management.Automation.Runspaces.RunspacePoolState
                    f_1485_10612_10627(System.Management.Automation.RunspacePoolStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 10612, 10627);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 10479, 10794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 10479, 10794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }



        /// <summary>
        /// Event raised when RunspacePoolState changes.
        /// </summary>
        public event EventHandler<RunspacePoolStateChangedEventArgs>
StateChanged
;

        /// <summary>
        /// Event raised when one of the runspaces in the pool forwards an event to this instance.
        /// </summary>
        public event EventHandler<PSEventArgs>
ForwardEvent
;

        /// <summary>
        /// Event raised when a new Runspace is created by the pool.
        /// </summary>
        internal event EventHandler<RunspaceCreatedEventArgs>
RunspaceCreated
;

        public virtual void Disconnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 11630, 11806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 11687, 11795);

                throw f_1485_11693_11794(f_1485_11736_11793());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 11630, 11806);

                string
                f_1485_11736_11793()
                {
                    var return_v = RunspacePoolStrings.RunspaceDisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 11736, 11793);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_11693_11794(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 11693, 11794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 11630, 11806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 11630, 11806);
            }
        }

        public virtual IAsyncResult BeginDisconnect(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 12039, 12264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 12145, 12253);

                throw f_1485_12151_12252(f_1485_12194_12251());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 12039, 12264);

                string
                f_1485_12194_12251()
                {
                    var return_v = RunspacePoolStrings.RunspaceDisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 12194, 12251);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_12151_12252(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 12151, 12252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 12039, 12264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 12039, 12264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void EndDisconnect(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 12422, 12625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 12506, 12614);

                throw f_1485_12512_12613(f_1485_12555_12612());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 12422, 12625);

                string
                f_1485_12555_12612()
                {
                    var return_v = RunspacePoolStrings.RunspaceDisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 12555, 12612);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_12512_12613(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 12512, 12613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 12422, 12625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 12422, 12625);
            }
        }

        public virtual void Connect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 12734, 12907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 12788, 12896);

                throw f_1485_12794_12895(f_1485_12837_12894());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 12734, 12907);

                string
                f_1485_12837_12894()
                {
                    var return_v = RunspacePoolStrings.RunspaceDisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 12837, 12894);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_12794_12895(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 12794, 12895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 12734, 12907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 12734, 12907);
            }
        }

        public virtual IAsyncResult BeginConnect(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 13137, 13359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 13240, 13348);

                throw f_1485_13246_13347(f_1485_13289_13346());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 13137, 13359);

                string
                f_1485_13289_13346()
                {
                    var return_v = RunspacePoolStrings.RunspaceDisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 13289, 13346);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_13246_13347(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 13246, 13347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 13137, 13359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 13137, 13359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void EndConnect(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 13514, 13714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 13595, 13703);

                throw f_1485_13601_13702(f_1485_13644_13701());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 13514, 13714);

                string
                f_1485_13644_13701()
                {
                    var return_v = RunspacePoolStrings.RunspaceDisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 13644, 13701);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_13601_13702(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 13601, 13702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 13514, 13714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 13514, 13714);
            }
        }

        public virtual Collection<PowerShell> CreateDisconnectedPowerShells(RunspacePool runspacePool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 13990, 14228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 14109, 14217);

                throw f_1485_14115_14216(f_1485_14158_14215());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 13990, 14228);

                string
                f_1485_14158_14215()
                {
                    var return_v = RunspacePoolStrings.RunspaceDisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 14158, 14215);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_14115_14216(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 14115, 14216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 13990, 14228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 13990, 14228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual RunspacePoolCapability GetCapabilities()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 14391, 14520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 14471, 14509);

                return RunspacePoolCapability.Default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 14391, 14520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 14391, 14520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 14391, 14520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool ResetRunspaceState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 14852, 14966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 14919, 14955);

                throw f_1485_14925_14954();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 14852, 14966);

                System.Management.Automation.PSNotSupportedException
                f_1485_14925_14954()
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 14925, 14954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 14852, 14966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 14852, 14966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool SetMaxRunspaces(int maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 15618, 16807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 15698, 15727);

                bool
                isSizeIncreased = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 15749, 15753);

                lock (pool)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 15787, 15894) || true) && (maxRunspaces < this.minPoolSz)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 15787, 15894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 15862, 15875);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 15787, 15894);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 15914, 16470) || true) && (maxRunspaces > this.maxPoolSz)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 15914, 16470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 15989, 16012);

                        isSizeIncreased = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 15914, 16470);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 15914, 16470);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 16257, 16451) || true) && (f_1485_16264_16274(pool) > maxRunspaces)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 16257, 16451);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 16339, 16373);

                                Runspace
                                rsToDestroy = f_1485_16362_16372(pool)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 16399, 16428);

                                f_1485_16399_16427(this, rsToDestroy);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 16257, 16451);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1485, 16257, 16451);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1485, 16257, 16451);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 15914, 16470);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 16490, 16515);

                    maxPoolSz = maxRunspaces;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 16644, 16768) || true) && (isSizeIncreased)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 16644, 16768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 16697, 16753);

                    f_1485_16697_16752(this, null, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 16644, 16768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 16784, 16796);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 15618, 16807);

                int
                f_1485_16264_16274(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 16264, 16274);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_16362_16372(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 16362, 16372);
                    return return_v;
                }


                int
                f_1485_16399_16427(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.DestroyRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 16399, 16427);
                    return 0;
                }


                int
                f_1485_16697_16752(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                requestToEnqueue, bool
                useCallingThread)
                {
                    this_param.EnqueueCheckAndStartRequestServicingThread(requestToEnqueue, useCallingThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 16697, 16752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 15618, 16807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 15618, 16807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMaxRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 17045, 17126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 17098, 17115);

                return maxPoolSz;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 17045, 17126);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 17045, 17126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 17045, 17126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool SetMinRunspaces(int minRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 17734, 18088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 17820, 17824);
                lock (pool)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 17858, 17989) || true) && ((minRunspaces < 1) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 17862, 17915) || (minRunspaces > this.maxPoolSz)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 17858, 17989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 17957, 17970);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 17858, 17989);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 18009, 18034);

                    minPoolSz = minRunspaces;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 18065, 18077);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 17734, 18088);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 17734, 18088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 17734, 18088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetMinRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 18326, 18407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 18379, 18396);

                return minPoolSz;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 18326, 18407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 18326, 18407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 18326, 18407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int GetAvailableRunspaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 18813, 20875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 18952, 18962);
                // Dont allow state changes while we get the count
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 18996, 20849) || true) && (f_1485_19000_19015(stateInfo) == RunspacePoolState.Opened)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 18996, 20849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 20092, 20181);

                        int
                        unUsedCapacity = (DynAbs.Tracing.TraceSender.Conditional_F1(1485, 20113, 20145) || (((maxPoolSz - totalRunspaces) < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1485, 20148, 20149)) || DynAbs.Tracing.TraceSender.Conditional_F3(1485, 20152, 20180))) ? 0 : (maxPoolSz - totalRunspaces)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 20203, 20240);

                        return (f_1485_20211_20221(pool) + unUsedCapacity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 18996, 20849);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 18996, 20849);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 20282, 20849) || true) && (f_1485_20286_20301(stateInfo) == RunspacePoolState.Disconnected)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 20282, 20849);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 20377, 20458);

                            throw f_1485_20383_20457(f_1485_20413_20456());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 20282, 20849);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 20282, 20849);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 20500, 20849) || true) && (f_1485_20504_20519(stateInfo) != RunspacePoolState.BeforeOpen && (DynAbs.Tracing.TraceSender.Expression_True(1485, 20504, 20599) && f_1485_20555_20570(stateInfo) != RunspacePoolState.Opening))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 20500, 20849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 20641, 20731);

                                throw f_1485_20647_20730(f_1485_20677_20729());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 20500, 20849);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 20500, 20849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 20813, 20830);

                                return maxPoolSz;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 20500, 20849);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 20282, 20849);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 18996, 20849);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 18813, 20875);

                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_19000_19015(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 19000, 19015);
                    return return_v;
                }


                int
                f_1485_20211_20221(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 20211, 20221);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_20286_20301(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 20286, 20301);
                    return return_v;
                }


                string
                f_1485_20413_20456()
                {
                    var return_v = RunspacePoolStrings.CannotWhileDisconnected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 20413, 20456);
                    return return_v;
                }


                System.InvalidOperationException
                f_1485_20383_20457(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 20383, 20457);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_20504_20519(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 20504, 20519);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_20555_20570(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 20555, 20570);
                    return return_v;
                }


                string
                f_1485_20677_20729()
                {
                    var return_v = HostInterfaceExceptionsStrings.RunspacePoolNotOpened;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 20677, 20729);
                    return return_v;
                }


                System.InvalidOperationException
                f_1485_20647_20730(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 20647, 20730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 18813, 20875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 18813, 20875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void Open()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 21190, 21280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 21241, 21269);

                f_1485_21241_21268(this, false, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 21190, 21280);

                System.IAsyncResult
                f_1485_21241_21268(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, bool
                isAsync, System.AsyncCallback
                callback, object
                asyncState)
                {
                    var return_v = this_param.CoreOpen(isAsync, callback, asyncState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 21241, 21268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 21190, 21280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 21190, 21280);
            }
        }

        public IAsyncResult BeginOpen(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 21959, 22101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 22051, 22090);

                return f_1485_22058_22089(this, true, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 21959, 22101);

                System.IAsyncResult
                f_1485_22058_22089(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, bool
                isAsync, System.AsyncCallback
                callback, object
                asyncState)
                {
                    var return_v = this_param.CoreOpen(isAsync, callback, asyncState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 22058, 22089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 21959, 22101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 21959, 22101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EndOpen(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 22800, 23663);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 22870, 23002) || true) && (asyncResult == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 22870, 23002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 22927, 22987);

                    throw f_1485_22933_22986("asyncResult");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 22870, 23002);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 23018, 23097);

                RunspacePoolAsyncResult
                rsAsyncResult = asyncResult as RunspacePoolAsyncResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 23113, 23610) || true) && ((rsAsyncResult == null) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 23117, 23198) || (f_1485_23162_23183(rsAsyncResult) != instanceId)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 23117, 23261) || (f_1485_23220_23260_M(!rsAsyncResult.IsAssociatedWithAsyncOpen))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 23113, 23610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 23295, 23595);

                    throw f_1485_23301_23594("asyncResult", f_1485_23409_23448(), "IAsyncResult", "BeginOpen");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 23113, 23610);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 23626, 23652);

                f_1485_23626_23651(
                            rsAsyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 22800, 23663);

                System.Management.Automation.PSArgumentNullException
                f_1485_22933_22986(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 22933, 22986);
                    return return_v;
                }


                System.Guid
                f_1485_23162_23183(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                this_param)
                {
                    var return_v = this_param.OwnerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 23162, 23183);
                    return return_v;
                }


                bool
                f_1485_23220_23260_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 23220, 23260);
                    return return_v;
                }


                string
                f_1485_23409_23448()
                {
                    var return_v = RunspacePoolStrings.AsyncResultNotOwned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 23409, 23448);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1485_23301_23594(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 23301, 23594);
                    return return_v;
                }


                int
                f_1485_23626_23651(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                this_param)
                {
                    this_param.EndInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 23626, 23651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 22800, 23663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 22800, 23663);
            }
        }

        public virtual void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 24039, 24131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 24091, 24120);

                f_1485_24091_24119(this, false, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 24039, 24131);

                System.IAsyncResult
                f_1485_24091_24119(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, bool
                isAsync, System.AsyncCallback
                callback, object
                asyncState)
                {
                    var return_v = this_param.CoreClose(isAsync, callback, asyncState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 24091, 24119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 24039, 24131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 24039, 24131);
            }
        }

        public virtual IAsyncResult BeginClose(AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 24939, 25091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 25040, 25080);

                return f_1485_25047_25079(this, true, callback, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 24939, 25091);

                System.IAsyncResult
                f_1485_25047_25079(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, bool
                isAsync, System.AsyncCallback
                callback, object
                asyncState)
                {
                    var return_v = this_param.CoreClose(isAsync, callback, asyncState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 25047, 25079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 24939, 25091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 24939, 25091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void EndClose(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 25525, 26397);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 25604, 25736) || true) && (asyncResult == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 25604, 25736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 25661, 25721);

                    throw f_1485_25667_25720("asyncResult");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 25604, 25736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 25752, 25831);

                RunspacePoolAsyncResult
                rsAsyncResult = asyncResult as RunspacePoolAsyncResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 25847, 26344) || true) && ((rsAsyncResult == null) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 25851, 25932) || (f_1485_25896_25917(rsAsyncResult) != instanceId)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 25851, 25994) || (f_1485_25954_25993(rsAsyncResult))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 25847, 26344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 26028, 26329);

                    throw f_1485_26034_26328("asyncResult", f_1485_26142_26181(), "IAsyncResult", "BeginClose");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 25847, 26344);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 26360, 26386);

                f_1485_26360_26385(
                            rsAsyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 25525, 26397);

                System.Management.Automation.PSArgumentNullException
                f_1485_25667_25720(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 25667, 25720);
                    return return_v;
                }


                System.Guid
                f_1485_25896_25917(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                this_param)
                {
                    var return_v = this_param.OwnerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 25896, 25917);
                    return return_v;
                }


                bool
                f_1485_25954_25993(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                this_param)
                {
                    var return_v = this_param.IsAssociatedWithAsyncOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 25954, 25993);
                    return return_v;
                }


                string
                f_1485_26142_26181()
                {
                    var return_v = RunspacePoolStrings.AsyncResultNotOwned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 26142, 26181);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1485_26034_26328(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 26034, 26328);
                    return return_v;
                }


                int
                f_1485_26360_26385(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                this_param)
                {
                    this_param.EndInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 26360, 26385);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 25525, 26397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 25525, 26397);
            }
        }

        public Runspace GetRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 26959, 27575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 27013, 27032);

                f_1485_27013_27031(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 27095, 27185);

                GetRunspaceAsyncResult
                asyncResult = (GetRunspaceAsyncResult)f_1485_27156_27184(this, null, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 27253, 27291);

                f_1485_27253_27290(f_1485_27253_27280(asyncResult));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 27410, 27520) || true) && (f_1485_27414_27435(asyncResult) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 27410, 27520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 27477, 27505);

                    throw f_1485_27483_27504(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 27410, 27520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 27536, 27564);

                return f_1485_27543_27563(asyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 26959, 27575);

                int
                f_1485_27013_27031(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.AssertPoolIsOpen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 27013, 27031);
                    return 0;
                }


                System.IAsyncResult
                f_1485_27156_27184(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginGetRunspace(callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 27156, 27184);
                    return return_v;
                }


                System.Threading.WaitHandle
                f_1485_27253_27280(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    var return_v = this_param.AsyncWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 27253, 27280);
                    return return_v;
                }


                bool
                f_1485_27253_27290(System.Threading.WaitHandle
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 27253, 27290);
                    return return_v;
                }


                System.Exception
                f_1485_27414_27435(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 27414, 27435);
                    return return_v;
                }


                System.Exception
                f_1485_27483_27504(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 27483, 27504);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_27543_27563(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 27543, 27563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 26959, 27575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 26959, 27575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void ReleaseRunspace(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 28299, 30453);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28370, 28496) || true) && (runspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 28370, 28496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28424, 28481);

                    throw f_1485_28430_28480("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 28370, 28496);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28512, 28531);

                f_1485_28512_28530(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28547, 28579);

                bool
                isRunspaceReleased = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28593, 28622);

                bool
                destroyRunspace = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28703, 28715);

                // check if the runspace is owned by the pool
                lock (runspaceList)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28749, 28941) || true) && (!f_1485_28754_28785(runspaceList, runspace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 28749, 28941);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 28827, 28922);

                        throw f_1485_28833_28921(f_1485_28876_28920());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 28749, 28941);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29082, 29900) || true) && (f_1485_29086_29118(f_1485_29086_29112(runspace)) == RunspaceState.Opened)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 29082, 29900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29182, 29186);
                    lock (pool)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29228, 29733) || true) && (f_1485_29232_29242(pool) < maxPoolSz)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 29228, 29733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29304, 29330);

                            isRunspaceReleased = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29356, 29376);

                            f_1485_29356_29375(pool, runspace);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 29228, 29733);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 29228, 29733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29635, 29661);

                            isRunspaceReleased = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29687, 29710);

                            destroyRunspace = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 29228, 29733);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 29082, 29900);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 29082, 29900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29818, 29841);

                    destroyRunspace = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29859, 29885);

                    isRunspaceReleased = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 29082, 29900);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 29916, 30124) || true) && (destroyRunspace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 29916, 30124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30083, 30109);

                    f_1485_30083_30108(this, runspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 29916, 30124);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30256, 30442) || true) && (isRunspaceReleased)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 30256, 30442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30371, 30427);

                    f_1485_30371_30426(this, null, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 30256, 30442);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 28299, 30453);

                System.Management.Automation.PSArgumentNullException
                f_1485_28430_28480(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 28430, 28480);
                    return return_v;
                }


                int
                f_1485_28512_28530(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.AssertPoolIsOpen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 28512, 28530);
                    return 0;
                }


                bool
                f_1485_28754_28785(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param, System.Management.Automation.Runspaces.Runspace
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 28754, 28785);
                    return return_v;
                }


                string
                f_1485_28876_28920()
                {
                    var return_v = RunspacePoolStrings.RunspaceNotBelongsToPool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 28876, 28920);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1485_28833_28921(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 28833, 28921);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1485_29086_29112(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 29086, 29112);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1485_29086_29118(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 29086, 29118);
                    return return_v;
                }


                int
                f_1485_29232_29242(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 29232, 29242);
                    return return_v;
                }


                int
                f_1485_29356_29375(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param, System.Management.Automation.Runspaces.Runspace
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 29356, 29375);
                    return 0;
                }


                int
                f_1485_30083_30108(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.DestroyRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 30083, 30108);
                    return 0;
                }


                int
                f_1485_30371_30426(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                requestToEnqueue, bool
                useCallingThread)
                {
                    this_param.EnqueueCheckAndStartRequestServicingThread(requestToEnqueue, useCallingThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 30371, 30426);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 28299, 30453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 28299, 30453);
            }
        }

        public virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 30681, 31076);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30749, 31065) || true) && (!_isDisposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 30749, 31065);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30799, 31011) || true) && (disposing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 30799, 31011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30854, 30862);

                        f_1485_30854_30861(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30884, 30908);

                        f_1485_30884_30907(_cleanupTimer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30930, 30958);

                        _initialSessionState = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 30980, 30992);

                        host = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 30799, 31011);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 31031, 31050);

                    _isDisposed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 30749, 31065);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 30681, 31076);

                int
                f_1485_30854_30861(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 30854, 30861);
                    return 0;
                }


                int
                f_1485_30884_30907(System.Threading.Timer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 30884, 30907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 30681, 31076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 30681, 31076);
            }
        }

        internal PSThreadOptions ThreadOptions { get; set; }

        internal ApartmentState ApartmentState { get; set; }

        internal IAsyncResult BeginGetRunspace(
                    AsyncCallback callback, object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 32604, 33078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 32719, 32738);

                f_1485_32719_32737(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 32754, 32869);

                GetRunspaceAsyncResult
                asyncResult = f_1485_32791_32868(f_1485_32818_32833(this), callback, state)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 32970, 33032);

                f_1485_32970_33031(this, asyncResult, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 33048, 33067);

                return asyncResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 32604, 33078);

                int
                f_1485_32719_32737(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.AssertPoolIsOpen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 32719, 32737);
                    return 0;
                }


                System.Guid
                f_1485_32818_32833(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 32818, 32833);
                    return return_v;
                }


                System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                f_1485_32791_32868(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = new System.Management.Automation.Runspaces.GetRunspaceAsyncResult(ownerId, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 32791, 32868);
                    return return_v;
                }


                int
                f_1485_32970_33031(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                requestToEnqueue, bool
                useCallingThread)
                {
                    this_param.EnqueueCheckAndStartRequestServicingThread(requestToEnqueue, useCallingThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 32970, 33031);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 32604, 33078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 32604, 33078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CancelGetRunspace(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 33273, 34099);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 33355, 33487) || true) && (asyncResult == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 33355, 33487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 33412, 33472);

                    throw f_1485_33418_33471("asyncResult");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 33355, 33487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 33503, 33598);

                GetRunspaceAsyncResult
                grsAsyncResult =
                                asyncResult as GetRunspaceAsyncResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 33614, 34040) || true) && ((grsAsyncResult == null) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 33618, 33684) || (f_1485_33647_33669(grsAsyncResult) != instanceId)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 33614, 34040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 33718, 34025);

                    throw f_1485_33724_34024("asyncResult", f_1485_33832_33871(), "IAsyncResult", "BeginGetRunspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 33614, 34040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 34056, 34088);

                grsAsyncResult.IsActive = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 33273, 34099);

                System.Management.Automation.PSArgumentNullException
                f_1485_33418_33471(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 33418, 33471);
                    return return_v;
                }


                System.Guid
                f_1485_33647_33669(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    var return_v = this_param.OwnerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 33647, 33669);
                    return return_v;
                }


                string
                f_1485_33832_33871()
                {
                    var return_v = RunspacePoolStrings.AsyncResultNotOwned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 33832, 33871);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1485_33724_34024(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 33724, 34024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 33273, 34099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 33273, 34099);
            }
        }

        internal Runspace EndGetRunspace(IAsyncResult asyncResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 34881, 35748);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 34964, 35096) || true) && (asyncResult == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 34964, 35096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 35021, 35081);

                    throw f_1485_35027_35080("asyncResult");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 34964, 35096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 35112, 35207);

                GetRunspaceAsyncResult
                grsAsyncResult =
                                asyncResult as GetRunspaceAsyncResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 35223, 35649) || true) && ((grsAsyncResult == null) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 35227, 35293) || (f_1485_35256_35278(grsAsyncResult) != instanceId)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 35223, 35649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 35327, 35634);

                    throw f_1485_35333_35633("asyncResult", f_1485_35441_35480(), "IAsyncResult", "BeginGetRunspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 35223, 35649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 35665, 35692);

                f_1485_35665_35691(
                            grsAsyncResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 35706, 35737);

                return f_1485_35713_35736(grsAsyncResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 34881, 35748);

                System.Management.Automation.PSArgumentNullException
                f_1485_35027_35080(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 35027, 35080);
                    return return_v;
                }


                System.Guid
                f_1485_35256_35278(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    var return_v = this_param.OwnerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 35256, 35278);
                    return return_v;
                }


                string
                f_1485_35441_35480()
                {
                    var return_v = RunspacePoolStrings.AsyncResultNotOwned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 35441, 35480);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1485_35333_35633(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 35333, 35633);
                    return return_v;
                }


                int
                f_1485_35665_35691(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    this_param.EndInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 35665, 35691);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_35713_35736(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 35713, 35736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 34881, 35748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 34881, 35748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual IAsyncResult CoreOpen(bool isAsync, AsyncCallback callback,
                    object asyncState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 36888, 37803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37028, 37038);
                lock (syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37072, 37100);

                    f_1485_37072_37099(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37120, 37191);

                    stateInfo = f_1485_37132_37190(RunspacePoolState.Opening, null);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37307, 37340);

                f_1485_37307_37339(this, stateInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37356, 37689) || true) && (isAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 37356, 37689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37401, 37495);

                    AsyncResult
                    asyncResult = f_1485_37427_37494(instanceId, callback, asyncState, true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37561, 37637);

                    f_1485_37561_37636(new WaitCallback(OpenThreadProc), asyncResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37655, 37674);

                    return asyncResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 37356, 37689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37753, 37766);

                f_1485_37753_37765(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 37780, 37792);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 36888, 37803);

                int
                f_1485_37072_37099(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.AssertIfStateIsBeforeOpen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 37072, 37099);
                    return 0;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1485_37132_37190(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 37132, 37190);
                    return return_v;
                }


                int
                f_1485_37307_37339(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 37307, 37339);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                f_1485_37427_37494(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, bool
                isCalledFromOpenAsync)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult(ownerId, callback, state, isCalledFromOpenAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 37427, 37494);
                    return return_v;
                }


                bool
                f_1485_37561_37636(System.Threading.WaitCallback
                callBack, System.Management.Automation.Runspaces.AsyncResult
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 37561, 37636);
                    return return_v;
                }


                int
                f_1485_37753_37765(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.OpenHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 37753, 37765);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 36888, 37803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 36888, 37803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void OpenHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 38063, 39369);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38151, 38207);

                    f_1485_38151_38206(f_1485_38190_38205(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38419, 38450);

                    Runspace
                    rs = f_1485_38433_38449(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38468, 38482);

                    f_1485_38468_38481(pool, rs);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1485, 38511, 38680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38571, 38599);

                    f_1485_38571_38598(this, exception);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38659, 38665);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1485, 38511, 38680);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38696, 38727);

                bool
                shouldRaiseEvents = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38886, 38896);
                // RunspacePool might be closed while we are still opening
                // we should not change state from closed to opened..
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 38930, 39224) || true) && (f_1485_38934_38949(stateInfo) == RunspacePoolState.Opening)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 38930, 39224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39088, 39158);

                        stateInfo = f_1485_39100_39157(RunspacePoolState.Opened, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39180, 39205);

                        shouldRaiseEvents = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 38930, 39224);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39255, 39358) || true) && (shouldRaiseEvents)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 39255, 39358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39310, 39343);

                    f_1485_39310_39342(this, stateInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 39255, 39358);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 38063, 39369);

                System.Guid
                f_1485_38190_38205(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 38190, 38205);
                    return return_v;
                }


                int
                f_1485_38151_38206(System.Guid
                newActivityId)
                {
                    PSEtwLog.SetActivityIdForCurrentThread(newActivityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 38151, 38206);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_38433_38449(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.CreateRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 38433, 38449);
                    return return_v;
                }


                int
                f_1485_38468_38481(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param, System.Management.Automation.Runspaces.Runspace
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 38468, 38481);
                    return 0;
                }


                int
                f_1485_38571_38598(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Exception
                reason)
                {
                    this_param.SetStateToBroken(reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 38571, 38598);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_38934_38949(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 38934, 38949);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1485_39100_39157(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 39100, 39157);
                    return return_v;
                }


                int
                f_1485_39310_39342(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 39310, 39342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 38063, 39369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 38063, 39369);
            }
        }

        private void SetStateToBroken(Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 39381, 40347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39453, 39484);

                bool
                shouldRaiseEvents = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39504, 39514);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39548, 40073) || true) && ((f_1485_39553_39568(stateInfo) == RunspacePoolState.Opening) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 39552, 39668) || (f_1485_39624_39639(stateInfo) == RunspacePoolState.Opened)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 39552, 39745) || (f_1485_39694_39709(stateInfo) == RunspacePoolState.Disconnecting)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 39552, 39821) || (f_1485_39771_39786(stateInfo) == RunspacePoolState.Disconnected)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 39552, 39895) || (f_1485_39847_39862(stateInfo) == RunspacePoolState.Connecting)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 39548, 40073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 39937, 40007);

                        stateInfo = f_1485_39949_40006(RunspacePoolState.Broken, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40029, 40054);

                        shouldRaiseEvents = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 39548, 40073);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40104, 40336) || true) && (shouldRaiseEvents)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 40104, 40336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40159, 40270);

                    RunspacePoolStateInfo
                    stateInfo = f_1485_40193_40269(f_1485_40219_40239(this.stateInfo), reason)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40288, 40321);

                    f_1485_40288_40320(this, stateInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 40104, 40336);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 39381, 40347);

                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_39553_39568(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 39553, 39568);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_39624_39639(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 39624, 39639);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_39694_39709(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 39694, 39709);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_39771_39786(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 39771, 39786);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_39847_39862(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 39847, 39862);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1485_39949_40006(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 39949, 40006);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_40219_40239(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 40219, 40239);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1485_40193_40269(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 40193, 40269);
                    return return_v;
                }


                int
                f_1485_40288_40320(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 40288, 40320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 39381, 40347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 39381, 40347);
            }
        }

        protected void OpenThreadProc(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 40538, 41339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40602, 40669);

                f_1485_40602_40668(o is AsyncResult, "OpenThreadProc expects AsyncResult");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40802, 40843);

                AsyncResult
                asyncObject = (AsyncResult)o
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40911, 40938);

                Exception
                exception = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 40990, 41003);

                    f_1485_40990_41002(this);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1485, 41032, 41221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 41192, 41206);

                    exception = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1485, 41032, 41221);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1485, 41235, 41328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 41275, 41313);

                    f_1485_41275_41312(asyncObject, exception);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1485, 41235, 41328);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 40538, 41339);

                int
                f_1485_40602_40668(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 40602, 40668);
                    return 0;
                }


                int
                f_1485_40990_41002(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.OpenHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 40990, 41002);
                    return 0;
                }


                int
                f_1485_41275_41312(System.Management.Automation.Runspaces.AsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 41275, 41312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 40538, 41339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 40538, 41339);
            }
        }

        private IAsyncResult CoreClose(bool isAsync, AsyncCallback callback, object asyncState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 42062, 43715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 42180, 42190);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 42224, 43033) || true) && ((f_1485_42229_42244(stateInfo) == RunspacePoolState.Closed) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 42228, 42343) || (f_1485_42299_42314(stateInfo) == RunspacePoolState.Broken)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 42228, 42414) || (f_1485_42369_42384(stateInfo) == RunspacePoolState.Closing)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 42228, 42491) || (f_1485_42440_42455(stateInfo) == RunspacePoolState.Disconnecting)) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 42228, 42567) || (f_1485_42517_42532(stateInfo) == RunspacePoolState.Disconnected)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 42224, 43033);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 42609, 43014) || true) && (isAsync)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 42609, 43014);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 42670, 42777);

                            RunspacePoolAsyncResult
                            asyncResult = f_1485_42708_42776(instanceId, callback, asyncState, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 42803, 42836);

                            f_1485_42803_42835(asyncResult, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 42862, 42881);

                            return asyncResult;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 42609, 43014);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 42609, 43014);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 42979, 42991);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 42609, 43014);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 42224, 43033);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43053, 43124);

                    stateInfo = f_1485_43065_43123(RunspacePoolState.Closing, null);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43204, 43237);

                f_1485_43204_43236(this, stateInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43253, 43600) || true) && (isAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 43253, 43600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43298, 43405);

                    RunspacePoolAsyncResult
                    asyncResult = f_1485_43336_43404(instanceId, callback, asyncState, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43471, 43548);

                    f_1485_43471_43547(new WaitCallback(CloseThreadProc), asyncResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43566, 43585);

                    return asyncResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 43253, 43600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43664, 43678);

                f_1485_43664_43677(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43692, 43704);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 42062, 43715);

                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_42229_42244(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 42229, 42244);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_42299_42314(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 42299, 42314);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_42369_42384(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 42369, 42384);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_42440_42455(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 42440, 42455);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_42517_42532(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 42517, 42532);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                f_1485_42708_42776(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, bool
                isCalledFromOpenAsync)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult(ownerId, callback, state, isCalledFromOpenAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 42708, 42776);
                    return return_v;
                }


                int
                f_1485_42803_42835(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 42803, 42835);
                    return 0;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1485_43065_43123(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43065, 43123);
                    return return_v;
                }


                int
                f_1485_43204_43236(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43204, 43236);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                f_1485_43336_43404(System.Guid
                ownerId, System.AsyncCallback
                callback, object
                state, bool
                isCalledFromOpenAsync)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult(ownerId, callback, state, isCalledFromOpenAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43336, 43404);
                    return return_v;
                }


                bool
                f_1485_43471_43547(System.Threading.WaitCallback
                callBack, System.Management.Automation.Runspaces.RunspacePoolAsyncResult
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43471, 43547);
                    return return_v;
                }


                int
                f_1485_43664_43677(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.CloseHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43664, 43677);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 42062, 43715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 42062, 43715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CloseHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 43727, 44058);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43814, 43842);

                    f_1485_43814_43841(this);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1485, 43871, 44047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43911, 43981);

                    stateInfo = f_1485_43923_43980(RunspacePoolState.Closed, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 43999, 44032);

                    f_1485_43999_44031(this, stateInfo);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1485, 43871, 44047);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 43727, 44058);

                int
                f_1485_43814_43841(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.InternalClearAllResources();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43814, 43841);
                    return 0;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1485_43923_43980(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43923, 43980);
                    return return_v;
                }


                int
                f_1485_43999_44031(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    this_param.RaiseStateChangeEvent(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 43999, 44031);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 43727, 44058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 43727, 44058);
            }
        }

        private void CloseThreadProc(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 44070, 44872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 44133, 44201);

                f_1485_44133_44200(o is AsyncResult, "CloseThreadProc expects AsyncResult");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 44334, 44375);

                AsyncResult
                asyncObject = (AsyncResult)o
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 44443, 44470);

                Exception
                exception = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 44522, 44536);

                    f_1485_44522_44535(this);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1485, 44565, 44754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 44725, 44739);

                    exception = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1485, 44565, 44754);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1485, 44768, 44861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 44808, 44846);

                    f_1485_44808_44845(asyncObject, exception);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1485, 44768, 44861);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 44070, 44872);

                int
                f_1485_44133_44200(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 44133, 44200);
                    return 0;
                }


                int
                f_1485_44522_44535(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    this_param.CloseHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 44522, 44535);
                    return 0;
                }


                int
                f_1485_44808_44845(System.Management.Automation.Runspaces.AsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 44808, 44845);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 44070, 44872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 44070, 44872);
            }
        }

        protected void RaiseStateChangeEvent(RunspacePoolStateInfo stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 45142, 45344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 45236, 45333);

                f_1485_45236_45332(StateChanged, this, f_1485_45283_45331(stateInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 45142, 45344);

                System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
                f_1485_45283_45331(System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 45283, 45331);
                    return return_v;
                }


                int
                f_1485_45236_45332(System.EventHandler<System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs>
                eventHandler, System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                sender, System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 45236, 45332);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 45142, 45344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 45142, 45344);
            }
        }

        internal void AssertPoolIsOpen()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 45696, 46217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 45759, 45769);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 45803, 46191) || true) && (f_1485_45807_45822(stateInfo) != RunspacePoolState.Opened)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 45803, 46191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 45892, 46016);

                        string
                        message = f_1485_45909_46015(f_1485_45927_45971(), RunspacePoolState.Opened, f_1485_45999_46014(stateInfo))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 46038, 46172);

                        throw f_1485_46044_46171(message, f_1485_46129_46144(stateInfo), RunspacePoolState.Opened);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 45803, 46191);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 45696, 46217);

                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_45807_45822(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 45807, 45822);
                    return return_v;
                }


                string
                f_1485_45927_45971()
                {
                    var return_v = RunspacePoolStrings.InvalidRunspacePoolState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 45927, 45971);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_45999_46014(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 45999, 46014);
                    return return_v;
                }


                string
                f_1485_45909_46015(string
                formatSpec, System.Management.Automation.Runspaces.RunspacePoolState
                o1, System.Management.Automation.Runspaces.RunspacePoolState
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 45909, 46015);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_46129_46144(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 46129, 46144);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                f_1485_46044_46171(string
                message, System.Management.Automation.Runspaces.RunspacePoolState
                currentState, System.Management.Automation.Runspaces.RunspacePoolState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 46044, 46171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 45696, 46217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 45696, 46217);
            }
        }

        protected Runspace CreateRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 46541, 48107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 46601, 46685);

                f_1485_46601_46684(_initialSessionState != null, "_initialSessionState should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 46835, 46935);

                Runspace
                result = f_1485_46853_46934(host, _initialSessionState)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 46951, 47071);

                result.ThreadOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(1485, 46974, 47019) || ((f_1485_46974_46992(this) == PSThreadOptions.Default && DynAbs.Tracing.TraceSender.Conditional_F2(1485, 47022, 47049)) || DynAbs.Tracing.TraceSender.Conditional_F3(1485, 47052, 47070))) ? PSThreadOptions.ReuseThread : f_1485_47052_47070(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47085, 47129);

                result.ApartmentState = f_1485_47109_47128(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47145, 47190);

                f_1485_47145_47189(
                            this, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47206, 47220);

                f_1485_47206_47219(
                            result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47306, 47371);

                f_1485_47306_47370(f_1485_47346_47369(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47387, 47440);

                f_1485_47387_47400(result).ForwardEvent += OnRunspaceForwardEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47538, 47550);

                lock (runspaceList)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47584, 47609);

                    f_1485_47584_47608(runspaceList, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47627, 47663);

                    totalRunspaces = f_1485_47644_47662(runspaceList);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47785, 47800);

                // Start/Reset the cleanup timer to release idle runspaces in the pool.
                lock (this.syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47834, 47889);

                    f_1485_47834_47888(_cleanupTimer, f_1485_47855_47870(), f_1485_47872_47887());
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 47995, 48066);

                f_1485_47995_48065(
                            // raise the RunspaceCreated event and let callers handle it.
                            RunspaceCreated, this, f_1485_48028_48064(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48082, 48096);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 46541, 48107);

                int
                f_1485_46601_46684(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 46601, 46684);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_46853_46934(System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspaceFromSessionStateNoClone(host, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 46853, 46934);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1485_46974_46992(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 46974, 46992);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1485_47052_47070(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 47052, 47070);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1485_47109_47128(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 47109, 47128);
                    return return_v;
                }


                int
                f_1485_47145_47189(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.PropagateApplicationPrivateData(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 47145, 47189);
                    return 0;
                }


                int
                f_1485_47206_47219(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 47206, 47219);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1485_47346_47369(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 47346, 47369);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1485_47306_47370(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Utils.EnforceSystemLockDownLanguageMode(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 47306, 47370);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1485_47387_47400(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 47387, 47400);
                    return return_v;
                }


                int
                f_1485_47584_47608(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param, System.Management.Automation.Runspaces.Runspace
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 47584, 47608);
                    return 0;
                }


                int
                f_1485_47644_47662(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 47644, 47662);
                    return return_v;
                }


                System.TimeSpan
                f_1485_47855_47870()
                {
                    var return_v = CleanupInterval;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 47855, 47870);
                    return return_v;
                }


                System.TimeSpan
                f_1485_47872_47887()
                {
                    var return_v = CleanupInterval;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 47872, 47887);
                    return return_v;
                }


                bool
                f_1485_47834_47888(System.Threading.Timer
                this_param, System.TimeSpan
                dueTime, System.TimeSpan
                period)
                {
                    var return_v = this_param.Change(dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 47834, 47888);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                f_1485_48028_48064(System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceCreatedEventArgs(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 48028, 48064);
                    return return_v;
                }


                int
                f_1485_47995_48065(System.EventHandler<System.Management.Automation.Runspaces.RunspaceCreatedEventArgs>
                eventHandler, System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                sender, System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Runspaces.RunspaceCreatedEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 47995, 48065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 46541, 48107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 46541, 48107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void DestroyRunspace(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 48309, 48824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48383, 48439);

                f_1485_48383_48438(runspace != null, "Runspace cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48453, 48508);

                f_1485_48453_48468(runspace).ForwardEvent -= OnRunspaceForwardEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48598, 48615);

                f_1485_48598_48614(runspace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48629, 48648);

                f_1485_48629_48647(runspace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48668, 48680);
                lock (runspaceList)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48714, 48744);

                    f_1485_48714_48743(runspaceList, runspace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 48762, 48798);

                    totalRunspaces = f_1485_48779_48797(runspaceList);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 48309, 48824);

                int
                f_1485_48383_48438(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 48383, 48438);
                    return 0;
                }


                System.Management.Automation.PSEventManager
                f_1485_48453_48468(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 48453, 48468);
                    return return_v;
                }


                int
                f_1485_48598_48614(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 48598, 48614);
                    return 0;
                }


                int
                f_1485_48629_48647(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 48629, 48647);
                    return 0;
                }


                bool
                f_1485_48714_48743(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param, System.Management.Automation.Runspaces.Runspace
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 48714, 48743);
                    return return_v;
                }


                int
                f_1485_48779_48797(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 48779, 48797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 48309, 48824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 48309, 48824);
            }
        }

        protected void CleanupCallback(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 49158, 51158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 49227, 49546);

                f_1485_49227_49545((f_1485_49239_49259(this.stateInfo) != RunspacePoolState.Disconnected && (DynAbs.Tracing.TraceSender.Expression_True(1485, 49239, 49377) && f_1485_49322_49342(this.stateInfo) != RunspacePoolState.Disconnecting) && (DynAbs.Tracing.TraceSender.Expression_True(1485, 49239, 49458) && f_1485_49406_49426(this.stateInfo) != RunspacePoolState.Connecting)), "Local RunspacePool cannot be in disconnect/connect states");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 49562, 49597);

                bool
                isCleanupTimerChanged = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 49720, 51147) || true) && (totalRunspaces > minPoolSz)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 49720, 51147);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 49844, 49965) || true) && (f_1485_49848_49868(this.stateInfo) == RunspacePoolState.Closing)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 49844, 49965);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 49939, 49946);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 49844, 49965);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50224, 50258);

                        Runspace
                        runspaceToDestroy = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50282, 50286);
                        lock (pool)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50328, 50446) || true) && (f_1485_50332_50342(pool) <= 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 50328, 50446);
                                DynAbs.Tracing.TraceSender.TraceBreak(1485, 50397, 50403);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 50328, 50446);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50470, 50501);

                            runspaceToDestroy = f_1485_50490_50500(pool);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50700, 50993) || true) && (!isCleanupTimerChanged)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 50700, 50993);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50774, 50789);
                            lock (this.syncObject)
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50839, 50896);

                                f_1485_50839_50895(_cleanupTimer, Timeout.Infinite, Timeout.Infinite);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 50922, 50951);

                                isCleanupTimerChanged = true;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 50700, 50993);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51070, 51105);

                        f_1485_51070_51104(this, runspaceToDestroy);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51123, 51132);

                        continue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 49720, 51147);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1485, 49720, 51147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1485, 49720, 51147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 49158, 51158);

                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_49239_49259(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 49239, 49259);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_49322_49342(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 49322, 49342);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_49406_49426(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 49406, 49426);
                    return return_v;
                }


                int
                f_1485_49227_49545(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 49227, 49545);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_49848_49868(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 49848, 49868);
                    return return_v;
                }


                int
                f_1485_50332_50342(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 50332, 50342);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_50490_50500(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 50490, 50500);
                    return return_v;
                }


                bool
                f_1485_50839_50895(System.Threading.Timer
                this_param, int
                dueTime, int
                period)
                {
                    var return_v = this_param.Change(dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 50839, 50895);
                    return return_v;
                }


                int
                f_1485_51070_51104(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.DestroyRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 51070, 51104);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 49158, 51158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 49158, 51158);
            }
        }

        private void InternalClearAllResources()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 51267, 53549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51332, 51456);

                string
                message = f_1485_51349_51455(f_1485_51367_51411(), RunspacePoolState.Opened, f_1485_51439_51454(stateInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51470, 51612);

                Exception
                invalidStateException = f_1485_51504_51611(message, f_1485_51569_51584(stateInfo), RunspacePoolState.Opened)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51626, 51667);

                GetRunspaceAsyncResult
                runspaceRequester
                = default(GetRunspaceAsyncResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51803, 51823);

                // clear the request queue first..this way waiting threads
                // are immediately notified.
                lock (runspaceRequestQueue)
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51857, 52084) || true) && (f_1485_51864_51890(runspaceRequestQueue) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 51857, 52084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 51936, 51987);

                            runspaceRequester = f_1485_51956_51986(runspaceRequestQueue);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52009, 52065);

                            f_1485_52009_52064(runspaceRequester, invalidStateException);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 51857, 52084);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1485, 51857, 52084);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1485, 51857, 52084);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52121, 52141);

                lock (ultimateRequestQueue)
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52175, 52402) || true) && (f_1485_52182_52208(ultimateRequestQueue) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 52175, 52402);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52254, 52305);

                            runspaceRequester = f_1485_52274_52304(ultimateRequestQueue);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52327, 52383);

                            f_1485_52327_52382(runspaceRequester, invalidStateException);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 52175, 52402);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1485, 52175, 52402);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1485, 52175, 52402);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52473, 52528);

                List<Runspace>
                runspaceListCopy = f_1485_52507_52527()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52550, 52562);

                lock (runspaceList)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52596, 52636);

                    f_1485_52596_52635(runspaceListCopy, runspaceList);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52654, 52675);

                    f_1485_52654_52674(runspaceList);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52768, 52802);

                    // Start from the most recent runspace.
                    for (int
        index = f_1485_52776_52798(runspaceListCopy) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52759, 53275) || true) && (index >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 52816, 52823)
        , index--, DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 52759, 53275))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 52759, 53275);
                        // close runspaces suppress exceptions
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 53060, 53092);

                            f_1485_53060_53091(f_1485_53060_53083(runspaceListCopy, index));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 53114, 53148);

                            f_1485_53114_53147(f_1485_53114_53137(runspaceListCopy, index));
                        }
                        catch (InvalidRunspaceStateException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1485, 53185, 53260);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1485, 53185, 53260);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1485, 1, 517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1485, 1, 517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 53297, 53301);

                lock (pool)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 53335, 53348);

                    f_1485_53335_53347(pool);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 51267, 53549);

                string
                f_1485_51367_51411()
                {
                    var return_v = RunspacePoolStrings.InvalidRunspacePoolState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 51367, 51411);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_51439_51454(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 51439, 51454);
                    return return_v;
                }


                string
                f_1485_51349_51455(string
                formatSpec, System.Management.Automation.Runspaces.RunspacePoolState
                o1, System.Management.Automation.Runspaces.RunspacePoolState
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 51349, 51455);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_51569_51584(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 51569, 51584);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                f_1485_51504_51611(string
                message, System.Management.Automation.Runspaces.RunspacePoolState
                currentState, System.Management.Automation.Runspaces.RunspacePoolState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 51504, 51611);
                    return return_v;
                }


                int
                f_1485_51864_51890(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 51864, 51890);
                    return return_v;
                }


                System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                f_1485_51956_51986(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 51956, 51986);
                    return return_v;
                }


                int
                f_1485_52009_52064(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 52009, 52064);
                    return 0;
                }


                int
                f_1485_52182_52208(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 52182, 52208);
                    return return_v;
                }


                System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                f_1485_52274_52304(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 52274, 52304);
                    return return_v;
                }


                int
                f_1485_52327_52382(System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                this_param, System.Exception
                exception)
                {
                    this_param.SetAsCompleted(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 52327, 52382);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                f_1485_52507_52527()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 52507, 52527);
                    return return_v;
                }


                int
                f_1485_52596_52635(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param, System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.Runspace>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 52596, 52635);
                    return 0;
                }


                int
                f_1485_52654_52674(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 52654, 52674);
                    return 0;
                }


                int
                f_1485_52776_52798(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 52776, 52798);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_53060_53083(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 53060, 53083);
                    return return_v;
                }


                int
                f_1485_53060_53091(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 53060, 53091);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1485_53114_53137(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 53114, 53137);
                    return return_v;
                }


                int
                f_1485_53114_53147(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 53114, 53147);
                    return 0;
                }


                int
                f_1485_53335_53347(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 53335, 53347);
                    return 0;
                }


                // dont release pool/runspacelist/runspaceRequestQueue/ultimateRequestQueue as they
                // might be accessed in lock() statements from another thread.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 51267, 53549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 51267, 53549);
            }
        }

        protected void EnqueueCheckAndStartRequestServicingThread(GetRunspaceAsyncResult requestToEnqueue,
                    bool useCallingThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 54202, 56199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 54361, 54407);

                bool
                shouldStartServicingInSameThread = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 54427, 54447);
                lock (runspaceRequestQueue)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 54481, 54617) || true) && (requestToEnqueue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 54481, 54617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 54551, 54598);

                        f_1485_54551_54597(runspaceRequestQueue, requestToEnqueue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 54481, 54617);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 54713, 54804) || true) && (isServicingRequests)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 54713, 54804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 54778, 54785);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 54713, 54804);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 54824, 55937) || true) && ((f_1485_54829_54855(runspaceRequestQueue) + f_1485_54858_54884(ultimateRequestQueue)) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 54824, 55937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 55069, 55073);
                        // we have requests pending..check if a runspace is available to
                        // service the requests.
                        lock (pool)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 55123, 55895) || true) && ((f_1485_55128_55138(pool) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1485, 55127, 55175) || (totalRunspaces < maxPoolSz)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 55123, 55895);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 55233, 55260);

                                isServicingRequests = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 55290, 55868) || true) && ((useCallingThread) && (DynAbs.Tracing.TraceSender.Expression_True(1485, 55294, 55349) && (f_1485_55317_55343(ultimateRequestQueue) == 0)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 55290, 55868);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 55415, 55455);

                                    shouldStartServicingInSameThread = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 55290, 55868);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 55290, 55868);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 55759, 55837);

                                    f_1485_55759_55836(new WaitCallback(ServicePendingRequests), false);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 55290, 55868);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 55123, 55895);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 54824, 55937);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 56074, 56188) || true) && (shouldStartServicingInSameThread)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 56074, 56188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 56144, 56173);

                    f_1485_56144_56172(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 56074, 56188);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 54202, 56199);

                int
                f_1485_54551_54597(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param, System.Management.Automation.Runspaces.GetRunspaceAsyncResult
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 54551, 54597);
                    return 0;
                }


                int
                f_1485_54829_54855(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 54829, 54855);
                    return return_v;
                }


                int
                f_1485_54858_54884(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 54858, 54884);
                    return return_v;
                }


                int
                f_1485_55128_55138(System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 55128, 55138);
                    return return_v;
                }


                int
                f_1485_55317_55343(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 55317, 55343);
                    return return_v;
                }


                bool
                f_1485_55759_55836(System.Threading.WaitCallback
                callBack, bool
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 55759, 55836);
                    return return_v;
                }


                int
                f_1485_56144_56172(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, bool
                useCallingThreadState)
                {
                    this_param.ServicePendingRequests((object)useCallingThreadState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 56144, 56172);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 54202, 56199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 54202, 56199);
            }
        }

        /// <summary>
        /// Releases any readers in the reader queue waiting for
        /// Runspace.
        /// </summary>
        /// <param name="useCallingThreadState">
        /// This is of type object..because this method is called from a ThreadPool
        /// Thread.
        /// true, if calling thread should be used to assign a runspace.
        /// </param>
        protected void ServicePendingRequests(object useCallingThreadState)
        {
            // Check if the pool is closed or closing..if so return.
            if ((stateInfo.State == RunspacePoolState.Closed) || (stateInfo.State == RunspacePoolState.Closing))
            {
                return;
            }

            Dbg.Assert((this.stateInfo.State != RunspacePoolState.Disconnected &&
                        this.stateInfo.State != RunspacePoolState.Disconnecting &&
                        this.stateInfo.State != RunspacePoolState.Connecting),
                       "Local RunspacePool cannot be in disconnect/connect states");

            bool useCallingThread = (bool)useCallingThreadState;
            GetRunspaceAsyncResult runspaceRequester = null;

            try
            {
                do
                {
                    lock (ultimateRequestQueue)
                    {
                        while (ultimateRequestQueue.Count > 0)
                        {
                            // if the pool is closing just return..
                            if (this.stateInfo.State == RunspacePoolState.Closing)
                            {
                                return;
                            }

                            Runspace result;
                            lock (pool)
                            {
                                if (pool.Count > 0)
                                {
                                    result = pool.Pop();
                                }
                                else if (totalRunspaces >= maxPoolSz)
                                {
                                    // no runspace is available..
                                    return;
                                }
                                else
                                {
                                    // TODO: how to handle exceptions if runspace
                                    // creation fails.
                                    // Create a new runspace..since the max limit is
                                    // not reached.
                                    result = CreateRunspace();
                                }
                            }

                            // Dequeue a runspace request
                            runspaceRequester = ultimateRequestQueue.Dequeue();
                            // if the runspace is not active send the runspace back to
                            // the pool and process other requests
                            if (!runspaceRequester.IsActive)
                            {
                                lock (pool)
                                {
                                    pool.Push(result);
                                }
                                // release the runspace requester
                                runspaceRequester.Release();
                                continue;
                            }
                            // release readers waiting for runspace on a thread pool
                            // thread.
                            runspaceRequester.Runspace = result;
                            // release the async operation on a thread pool thread.
                            if (useCallingThread)
                            {
                                // call DoComplete outside of the lock..as the
                                // DoComplete handler may handle the runspace
                                // in the same thread thereby blocking future
                                // servicing requests.
                                goto endOuterWhile;
                            }
                            else
                            {
                                ThreadPool.QueueUserWorkItem(new WaitCallback(runspaceRequester.DoComplete));
                            }
                        }
                    }

                    lock (runspaceRequestQueue)
                    {
                        if (runspaceRequestQueue.Count == 0)
                        {
                            break;
                        }

                        // copy requests from one queue to another and start
                        // processing the other queue
                        while (runspaceRequestQueue.Count > 0)
                        {
                            ultimateRequestQueue.Enqueue(runspaceRequestQueue.Dequeue());
                        }
                    }
                } while (true);
            endOuterWhile:
                ;
            }
            finally
            {
                lock (runspaceRequestQueue)
                {
                    isServicingRequests = false;
                    // check if any new runspace request has arrived..
                    EnqueueCheckAndStartRequestServicingThread(null, false);
                }
            }

            if ((useCallingThread) && (runspaceRequester != null))
            {
                // call DoComplete outside of the lock and finally..as the
                // DoComplete handler may handle the runspace in the same
                // thread thereby blocking future servicing requests.
                runspaceRequester.DoComplete(null);
            }
        }

        protected void AssertIfStateIsBeforeOpen()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 62203, 62898);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 62270, 62887) || true) && (f_1485_62274_62289(stateInfo) != RunspacePoolState.BeforeOpen)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 62270, 62887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 62426, 62846);

                    InvalidRunspacePoolStateException
                    e =
                    f_1485_62485_62845(f_1485_62571_62725(f_1485_62589_62624(), new object[] { f_1485_62670_62696(f_1485_62670_62685(stateInfo)) }), f_1485_62752_62767(stateInfo), RunspacePoolState.BeforeOpen)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 62864, 62872);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 62270, 62887);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 62203, 62898);

                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_62274_62289(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 62274, 62289);
                    return return_v;
                }


                string
                f_1485_62589_62624()
                {
                    var return_v = RunspacePoolStrings.CannotOpenAgain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 62589, 62624);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_62670_62685(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 62670, 62685);
                    return return_v;
                }


                string
                f_1485_62670_62696(System.Management.Automation.Runspaces.RunspacePoolState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 62670, 62696);
                    return return_v;
                }


                string
                f_1485_62571_62725(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 62571, 62725);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1485_62752_62767(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 62752, 62767);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
                f_1485_62485_62845(string
                message, System.Management.Automation.Runspaces.RunspacePoolState
                currentState, System.Management.Automation.Runspaces.RunspacePoolState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 62485, 62845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 62203, 62898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 62203, 62898);
            }
        }

        protected virtual void OnForwardEvent(PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 63001, 63229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 63078, 63127);

                EventHandler<PSEventArgs>
                eh = this.ForwardEvent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 63143, 63218) || true) && (eh != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 63143, 63218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 63191, 63203);

                    f_1485_63191_63202(eh, this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 63143, 63218);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 63001, 63229);

                int
                f_1485_63191_63202(System.EventHandler<System.Management.Automation.PSEventArgs>
                this_param, System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 63191, 63202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 63001, 63229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 63001, 63229);
            }
        }

        private void OnRunspaceForwardEvent(object sender, PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1485, 63352, 63538);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 63442, 63527) || true) && (f_1485_63446_63460(e))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1485, 63442, 63527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 63494, 63512);

                    f_1485_63494_63511(this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1485, 63442, 63527);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1485, 63352, 63538);

                bool
                f_1485_63446_63460(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.ForwardEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 63446, 63460);
                    return return_v;
                }


                int
                f_1485_63494_63511(System.Management.Automation.Runspaces.Internal.RunspacePoolInternal
                this_param, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.OnForwardEvent(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 63494, 63511);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1485, 63352, 63538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 63352, 63538);
            }
        }

        static RunspacePoolInternal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1485, 624, 63567);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1485, 1717, 1764);
            s_defaultCleanupPeriod = f_1485_1742_1764(0, 15, 0);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1485, 624, 63567);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1485, 624, 63567);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1485, 624, 63567);

        System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
        f_1485_936_956()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 936, 956);
            return return_v;
        }


        object
        f_1485_1659_1671()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 1659, 1671);
            return return_v;
        }


        static System.TimeSpan
        f_1485_1742_1764(int
        hours, int
        minutes, int
        seconds)
        {
            var return_v = new System.TimeSpan(hours, minutes, seconds);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 1742, 1764);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1485_3173_3219(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 3173, 3219);
            return return_v;
        }


        System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
        f_1485_3289_3310()
        {
            var return_v = new System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 3289, 3310);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
        f_1485_3348_3383()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 3348, 3383);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
        f_1485_3421_3456()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 3421, 3456);
            return return_v;
        }


        System.Management.Automation.Runspaces.InitialSessionState
        f_1485_3494_3529()
        {
            var return_v = InitialSessionState.CreateDefault();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 3494, 3529);
            return return_v;
        }


        static int
        f_1485_3065_3077_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1485, 2934, 3541);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1485_5052_5113(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 5052, 5113);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1485_5201_5247(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 5201, 5247);
            return return_v;
        }


        System.Management.Automation.Runspaces.InitialSessionState
        f_1485_5302_5329(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.Clone();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 5302, 5329);
            return return_v;
        }


        System.Management.Automation.Runspaces.PSThreadOptions
        f_1485_5391_5424(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.ThreadOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 5391, 5424);
            return return_v;
        }


        System.Threading.ApartmentState
        f_1485_5461_5495(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.ApartmentState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 5461, 5495);
            return return_v;
        }


        System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>
        f_1485_5517_5538()
        {
            var return_v = new System.Collections.Generic.Stack<System.Management.Automation.Runspaces.Runspace>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 5517, 5538);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
        f_1485_5576_5611()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 5576, 5611);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>
        f_1485_5649_5684()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.GetRunspaceAsyncResult>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 5649, 5684);
            return return_v;
        }


        static int
        f_1485_4929_4941_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1485, 4740, 5696);
            return return_v;
        }


        string
        f_1485_6443_6479()
        {
            var return_v = RunspacePoolStrings.MaxPoolLessThan1;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 6443, 6479);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1485_6392_6480(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 6392, 6480);
            return return_v;
        }


        string
        f_1485_6623_6659()
        {
            var return_v = RunspacePoolStrings.MinPoolLessThan1;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 6623, 6659);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1485_6572_6660(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 6572, 6660);
            return return_v;
        }


        string
        f_1485_6814_6859()
        {
            var return_v = RunspacePoolStrings.MinPoolGreaterThanMaxPool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1485, 6814, 6859);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1485_6763_6860(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 6763, 6860);
            return return_v;
        }


        System.Management.Automation.RunspacePoolStateInfo
        f_1485_6982_7043(System.Management.Automation.Runspaces.RunspacePoolState
        state, System.Exception
        reason)
        {
            var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 6982, 7043);
            return return_v;
        }


        int
        f_1485_7100_7150(System.Guid
        newActivityId)
        {
            PSEtwLog.SetActivityIdForCurrentThread(newActivityId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 7100, 7150);
            return 0;
        }


        System.Threading.Timer
        f_1485_7239_7326(System.Threading.TimerCallback
        callback, object?
        state, int
        dueTime, int
        period)
        {
            var return_v = new System.Threading.Timer(callback, state, dueTime, period);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1485, 7239, 7326);
            return return_v;
        }

    }
}
