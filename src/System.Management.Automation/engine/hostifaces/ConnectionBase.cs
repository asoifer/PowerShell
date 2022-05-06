// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Threading;
using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation.Runspaces
{
    internal abstract class RunspaceBase : Runspace
    {
        protected RunspaceBase(PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1456, 1404, 1693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4976, 5006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5129, 5193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5363, 5430);
                this.Version = f_1456_5406_5429();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5468, 5536);
                this._runspaceStateInfo = f_1456_5489_5536(RunspaceState.BeforeOpen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6322, 6371);
                this._runspaceAvailability = RunspaceAvailability.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6477, 6536);
                this.SyncRoot = f_1456_6523_6535();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 23908, 23965);
                this._runspaceEventQueue = f_1456_23930_23965();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24745, 24794);
                this.RunspaceOpening = f_1456_24763_24794(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29496, 29549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29585, 29617);
                this._pipelineListLock = f_1456_29605_29617();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29755, 29829);
                this.RunningPipelines = f_1456_29808_29828();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 37340, 37372);
                this._currentlyRunningPipeline = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 42795, 42852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 43157, 43190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 58500, 58518);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 1464, 1582) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 1464, 1582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 1514, 1567);

                    throw f_1456_1520_1566("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 1464, 1582);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 1598, 1656);

                InitialSessionState = f_1456_1620_1655();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 1670, 1682);

                Host = host;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1456, 1404, 1693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 1404, 1693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 1404, 1693);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "OK to call ThreadOptions")]
        protected RunspaceBase(PSHost host, InitialSessionState initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1456, 2297, 3097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4976, 5006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5129, 5193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5363, 5430);
                this.Version = f_1456_5406_5429();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5468, 5536);
                this._runspaceStateInfo = f_1456_5489_5536(RunspaceState.BeforeOpen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6322, 6371);
                this._runspaceAvailability = RunspaceAvailability.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6477, 6536);
                this.SyncRoot = f_1456_6523_6535();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 23908, 23965);
                this._runspaceEventQueue = f_1456_23930_23965();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24745, 24794);
                this.RunspaceOpening = f_1456_24763_24794(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29496, 29549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29585, 29617);
                this._pipelineListLock = f_1456_29605_29617();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29755, 29829);
                this.RunningPipelines = f_1456_29808_29828();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 37340, 37372);
                this._currentlyRunningPipeline = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 42795, 42852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 43157, 43190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 58500, 58518);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 2572, 2690) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 2572, 2690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 2622, 2675);

                    throw f_1456_2628_2674("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 2572, 2690);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 2706, 2854) || true) && (initialSessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 2706, 2854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 2771, 2839);

                    throw f_1456_2777_2838("initialSessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 2706, 2854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 2870, 2882);

                Host = host;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 2896, 2946);

                InitialSessionState = f_1456_2918_2945(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 2960, 3015);

                this.ThreadOptions = f_1456_2981_3014(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 3029, 3086);

                this.ApartmentState = f_1456_3051_3085(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1456, 2297, 3097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 2297, 3097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 2297, 3097);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "OK to call ThreadOptions")]
        protected RunspaceBase(PSHost host, InitialSessionState initialSessionState, bool suppressClone)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1456, 3869, 4865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4976, 5006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5129, 5193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5363, 5430);
                this.Version = f_1456_5406_5429();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5468, 5536);
                this._runspaceStateInfo = f_1456_5489_5536(RunspaceState.BeforeOpen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6322, 6371);
                this._runspaceAvailability = RunspaceAvailability.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6477, 6536);
                this.SyncRoot = f_1456_6523_6535();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 23908, 23965);
                this._runspaceEventQueue = f_1456_23930_23965();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24745, 24794);
                this.RunspaceOpening = f_1456_24763_24794(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29496, 29549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29585, 29617);
                this._pipelineListLock = f_1456_29605_29617();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 29755, 29829);
                this.RunningPipelines = f_1456_29808_29828();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 37340, 37372);
                this._currentlyRunningPipeline = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 42795, 42852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 43157, 43190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 58500, 58518);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4164, 4282) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 4164, 4282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4214, 4267);

                    throw f_1456_4220_4266("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 4164, 4282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4298, 4446) || true) && (initialSessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 4298, 4446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4363, 4431);

                    throw f_1456_4369_4430("initialSessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 4298, 4446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4462, 4474);

                Host = host;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4488, 4712) || true) && (suppressClone)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 4488, 4712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4539, 4581);

                    InitialSessionState = initialSessionState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 4488, 4712);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 4488, 4712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4647, 4697);

                    InitialSessionState = f_1456_4669_4696(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 4488, 4712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4728, 4783);

                this.ThreadOptions = f_1456_4749_4782(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 4797, 4854);

                this.ApartmentState = f_1456_4819_4853(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1456, 3869, 4865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 3869, 4865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 3869, 4865);
            }
        }

        protected PSHost Host { get; }

        public override InitialSessionState InitialSessionState { get; }

        public override Version Version { get; }

        private RunspaceStateInfo _runspaceStateInfo;

        public override RunspaceStateInfo RunspaceStateInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 5743, 5957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5785, 5793);
                    lock (f_1456_5785_5793())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 5889, 5923);

                        return f_1456_5896_5922(_runspaceStateInfo);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 5743, 5957);

                    object
                    f_1456_5785_5793()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 5785, 5793);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceStateInfo
                    f_1456_5896_5922(System.Management.Automation.Runspaces.RunspaceStateInfo
                    this_param)
                    {
                        var return_v = this_param.Clone();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 5896, 5922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 5667, 5968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 5667, 5968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RunspaceAvailability RunspaceAvailability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 6169, 6206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6175, 6204);

                    return _runspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 6169, 6206);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 6087, 6281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 6087, 6281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 6222, 6270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6238, 6268);

                    _runspaceAvailability = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 6222, 6270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 6087, 6281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 6087, 6281);
                }
            }
        }

        private RunspaceAvailability _runspaceAvailability;

        protected internal object SyncRoot { get; }

        public override RunspaceConnectionInfo ConnectionInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 6749, 6867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 6840, 6852);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 6749, 6867);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 6671, 6878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 6671, 6878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RunspaceConnectionInfo OriginalConnectionInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 7083, 7103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 7089, 7101);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 7083, 7103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 6997, 7114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 6997, 7114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Open()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 7409, 7487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 7461, 7476);

                f_1456_7461_7475(this, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 7409, 7487);

                int
                f_1456_7461_7475(System.Management.Automation.Runspaces.RunspaceBase
                this_param, bool
                syncCall)
                {
                    this_param.CoreOpen(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 7461, 7475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 7409, 7487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 7409, 7487);
            }
        }

        public override void OpenAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 7726, 7810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 7783, 7799);

                f_1456_7783_7798(this, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 7726, 7810);

                int
                f_1456_7783_7798(System.Management.Automation.Runspaces.RunspaceBase
                this_param, bool
                syncCall)
                {
                    this_param.CoreOpen(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 7783, 7798);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 7726, 7810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 7726, 7810);
            }
        }

        private void CoreOpen(bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 8187, 9932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 8248, 8302);

                bool
                etwEnabled = f_1456_8266_8301(RunspaceEventSource.Log)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 8316, 8376) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 8316, 8376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 8332, 8376);

                    f_1456_8332_8375(RunspaceEventSource.Log);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 8316, 8376);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 8396, 8404);
                lock (f_1456_8396_8404())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 8505, 9010) || true) && (f_1456_8509_8522() != RunspaceState.BeforeOpen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 8505, 9010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 8592, 8961);

                        InvalidRunspaceStateException
                        e =
                        f_1456_8651_8960(f_1456_8741_8834(f_1456_8759_8790(), new object[] { f_1456_8807_8831(f_1456_8807_8820()) }), f_1456_8865_8878(), RunspaceState.BeforeOpen)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 8983, 8991);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 8505, 9010);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 9030, 9070);

                    f_1456_9030_9069(this, RunspaceState.Opening);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 9146, 9173);

                f_1456_9146_9172(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 9189, 9210);

                f_1456_9189_9209(this, syncCall);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 9224, 9283) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 9224, 9283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 9240, 9283);

                    f_1456_9240_9282(RunspaceEventSource.Log);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 9224, 9283);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 8187, 9932);

                bool
                f_1456_8266_8301(System.Management.Automation.Runspaces.RunspaceEventSource
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 8266, 8301);
                    return return_v;
                }


                int
                f_1456_8332_8375(System.Management.Automation.Runspaces.RunspaceEventSource
                this_param)
                {
                    this_param.OpenRunspaceStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 8332, 8375);
                    return 0;
                }


                object
                f_1456_8396_8404()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 8396, 8404);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_8509_8522()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 8509, 8522);
                    return return_v;
                }


                string
                f_1456_8759_8790()
                {
                    var return_v = RunspaceStrings.CannotOpenAgain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 8759, 8790);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_8807_8820()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 8807, 8820);
                    return return_v;
                }


                string
                f_1456_8807_8831(System.Management.Automation.Runspaces.RunspaceState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 8807, 8831);
                    return return_v;
                }


                string
                f_1456_8741_8834(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 8741, 8834);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_8865_8878()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 8865, 8878);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_8651_8960(string
                message, System.Management.Automation.Runspaces.RunspaceState
                currentState, System.Management.Automation.Runspaces.RunspaceState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 8651, 8960);
                    return return_v;
                }


                int
                f_1456_9030_9069(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state)
                {
                    this_param.SetRunspaceState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 9030, 9069);
                    return 0;
                }


                int
                f_1456_9146_9172(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    this_param.RaiseRunspaceStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 9146, 9172);
                    return 0;
                }


                int
                f_1456_9189_9209(System.Management.Automation.Runspaces.RunspaceBase
                this_param, bool
                syncCall)
                {
                    this_param.OpenHelper(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 9189, 9209);
                    return 0;
                }


                int
                f_1456_9240_9282(System.Management.Automation.Runspaces.RunspaceEventSource
                this_param)
                {
                    this_param.OpenRunspaceStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 9240, 9282);
                    return 0;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 8187, 9932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 8187, 9932);
            }
        }

        protected abstract void OpenHelper(bool syncCall);

        public override void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 10510, 10590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 10563, 10579);

                f_1456_10563_10578(this, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 10510, 10590);

                int
                f_1456_10563_10578(System.Management.Automation.Runspaces.RunspaceBase
                this_param, bool
                syncCall)
                {
                    this_param.CoreClose(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 10563, 10578);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 10510, 10590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 10510, 10590);
            }
        }

        public override void CloseAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 10973, 11059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 11031, 11048);

                f_1456_11031_11047(this, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 10973, 11059);

                int
                f_1456_11031_11047(System.Management.Automation.Runspaces.RunspaceBase
                this_param, bool
                syncCall)
                {
                    this_param.CoreClose(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 11031, 11047);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 10973, 11059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 10973, 11059);
            }
        }

        private void CoreClose(bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 11594, 14844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 11656, 11684);

                bool
                alreadyClosing = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 11706, 11714);

                lock (f_1456_11706_11714())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 11748, 12871) || true) && (f_1456_11752_11765() == RunspaceState.Closed || (DynAbs.Tracing.TraceSender.Expression_False(1456, 11752, 11851) || f_1456_11814_11827() == RunspaceState.Broken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 11748, 12871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 11893, 11900);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 11748, 12871);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 11748, 12871);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 11942, 12871) || true) && (f_1456_11946_11959() == RunspaceState.BeforeOpen)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 11942, 12871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12029, 12075);

                            f_1456_12029_12074(this, RunspaceState.Closing, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12097, 12142);

                            f_1456_12097_12141(this, RunspaceState.Closed, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12166, 12193);

                            f_1456_12166_12192(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12217, 12224);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 11942, 12871);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 11942, 12871);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12266, 12871) || true) && (f_1456_12270_12283() == RunspaceState.Opening)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 12266, 12871);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12495, 12518);

                                f_1456_12495_12517(f_1456_12508_12516());
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12592, 12615);

                                    f_1456_12592_12614(RunspaceOpening);
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 12660, 12852);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12805, 12829);

                                    f_1456_12805_12828(f_1456_12819_12827());
                                    DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 12660, 12852);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 12266, 12871);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 11942, 12871);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 11748, 12871);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12891, 13098) || true) && (_bSessionStateProxyCallInProgress)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 12891, 13098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 12970, 13079);

                        throw f_1456_12976_13078(f_1456_13019_13077());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 12891, 13098);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 13118, 13918) || true) && (f_1456_13122_13135() == RunspaceState.Closing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 13118, 13918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 13202, 13224);

                        alreadyClosing = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 13118, 13918);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 13118, 13918);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 13306, 13835) || true) && (f_1456_13310_13323() != RunspaceState.Opened)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 13306, 13835);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 13397, 13778);

                            InvalidRunspaceStateException
                            e =
                            f_1456_13460_13777(f_1456_13558_13643(f_1456_13576_13616(), f_1456_13618_13642(f_1456_13618_13631())), f_1456_13678_13691(), RunspaceState.Opened)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 13804, 13812);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 13306, 13835);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 13859, 13899);

                        f_1456_13859_13898(this, RunspaceState.Closing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 13118, 13918);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 13949, 14631) || true) && (alreadyClosing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 13949, 14631);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 14489, 14589) || true) && (syncCall)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 14489, 14589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 14543, 14570);

                        f_1456_14543_14569(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 14489, 14589);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 14609, 14616);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 13949, 14631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 14692, 14719);

                f_1456_14692_14718(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 14811, 14833);

                f_1456_14811_14832(this, syncCall);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 11594, 14844);

                object
                f_1456_11706_11714()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 11706, 11714);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_11752_11765()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 11752, 11765);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_11814_11827()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 11814, 11827);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_11946_11959()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 11946, 11959);
                    return return_v;
                }


                int
                f_1456_12029_12074(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state, System.Exception
                reason)
                {
                    this_param.SetRunspaceState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 12029, 12074);
                    return 0;
                }


                int
                f_1456_12097_12141(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state, System.Exception
                reason)
                {
                    this_param.SetRunspaceState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 12097, 12141);
                    return 0;
                }


                int
                f_1456_12166_12192(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    this_param.RaiseRunspaceStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 12166, 12192);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_12270_12283()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 12270, 12283);
                    return return_v;
                }


                object
                f_1456_12508_12516()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 12508, 12516);
                    return return_v;
                }


                int
                f_1456_12495_12517(object
                obj)
                {
                    Monitor.Exit(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 12495, 12517);
                    return 0;
                }


                int
                f_1456_12592_12614(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Wait();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 12592, 12614);
                    return 0;
                }


                object
                f_1456_12819_12827()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 12819, 12827);
                    return return_v;
                }


                int
                f_1456_12805_12828(object
                obj)
                {
                    Monitor.Enter(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 12805, 12828);
                    return 0;
                }


                string
                f_1456_13019_13077()
                {
                    var return_v = RunspaceStrings.RunspaceCloseInvalidWhileSessionStateProxy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 13019, 13077);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1456_12976_13078(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 12976, 13078);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_13122_13135()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 13122, 13135);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_13310_13323()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 13310, 13323);
                    return return_v;
                }


                string
                f_1456_13576_13616()
                {
                    var return_v = RunspaceStrings.RunspaceNotInOpenedState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 13576, 13616);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_13618_13631()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 13618, 13631);
                    return return_v;
                }


                string
                f_1456_13618_13642(System.Management.Automation.Runspaces.RunspaceState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 13618, 13642);
                    return return_v;
                }


                string
                f_1456_13558_13643(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 13558, 13643);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_13678_13691()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 13678, 13691);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_13460_13777(string
                message, System.Management.Automation.Runspaces.RunspaceState
                currentState, System.Management.Automation.Runspaces.RunspaceState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 13460, 13777);
                    return return_v;
                }


                int
                f_1456_13859_13898(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state)
                {
                    this_param.SetRunspaceState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 13859, 13898);
                    return 0;
                }


                bool
                f_1456_14543_14569(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.WaitForFinishofPipelines();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 14543, 14569);
                    return return_v;
                }


                int
                f_1456_14692_14718(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    this_param.RaiseRunspaceStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 14692, 14718);
                    return 0;
                }


                int
                f_1456_14811_14832(System.Management.Automation.Runspaces.RunspaceBase
                this_param, bool
                syncCall)
                {
                    this_param.CloseHelper(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 14811, 14832);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 11594, 14844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 11594, 14844);
            }
        }

        protected abstract void CloseHelper(bool syncCall);

        public override void Disconnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 15335, 15620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 15499, 15609);

                throw f_1456_15505_15608(f_1456_15569_15607());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 15335, 15620);

                string
                f_1456_15569_15607()
                {
                    var return_v = RunspaceStrings.DisconnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 15569, 15607);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_15505_15608(string
                message)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 15505, 15608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 15335, 15620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 15335, 15620);
            }
        }

        public override void DisconnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 15733, 16023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 15902, 16012);

                throw f_1456_15908_16011(f_1456_15972_16010());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 15733, 16023);

                string
                f_1456_15972_16010()
                {
                    var return_v = RunspaceStrings.DisconnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 15972, 16010);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_15908_16011(string
                message)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 15908, 16011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 15733, 16023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 15733, 16023);
            }
        }

        public override void Connect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 16156, 16432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 16314, 16421);

                throw f_1456_16320_16420(f_1456_16384_16419());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 16156, 16432);

                string
                f_1456_16384_16419()
                {
                    var return_v = RunspaceStrings.ConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 16384, 16419);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_16320_16420(string
                message)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 16320, 16420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 16156, 16432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 16156, 16432);
            }
        }

        public override void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 16566, 16847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 16729, 16836);

                throw f_1456_16735_16835(f_1456_16799_16834());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 16566, 16847);

                string
                f_1456_16799_16834()
                {
                    var return_v = RunspaceStrings.ConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 16799, 16834);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_16735_16835(string
                message)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 16735, 16835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 16566, 16847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 16566, 16847);
            }
        }

        public override Pipeline CreateDisconnectedPipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 17014, 17324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 17196, 17313);

                throw f_1456_17202_17312(f_1456_17266_17311());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 17014, 17324);

                string
                f_1456_17266_17311()
                {
                    var return_v = RunspaceStrings.DisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 17266, 17311);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_17202_17312(string
                message)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 17202, 17312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 17014, 17324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 17014, 17324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PowerShell CreateDisconnectedPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 17495, 17809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 17681, 17798);

                throw f_1456_17687_17797(f_1456_17751_17796());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 17495, 17809);

                string
                f_1456_17751_17796()
                {
                    var return_v = RunspaceStrings.DisconnectConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 17751, 17796);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_17687_17797(string
                message)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 17687, 17797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 17495, 17809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 17495, 17809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override RunspaceCapability GetCapabilities()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 17964, 18086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 18041, 18075);

                return RunspaceCapability.Default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 17964, 18086);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 17964, 18086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 17964, 18086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Pipeline CreatePipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 18291, 18414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 18357, 18403);

                return f_1456_18364_18402(this, null, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 18291, 18414);

                System.Management.Automation.Runspaces.Pipeline
                f_1456_18364_18402(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                command, bool
                addToHistory, bool
                isNested)
                {
                    var return_v = this_param.CoreCreatePipeline(command, addToHistory, isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 18364, 18402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 18291, 18414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 18291, 18414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Pipeline CreatePipeline(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 18827, 19107);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 18907, 19031) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 18907, 19031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 18960, 19016);

                    throw f_1456_18966_19015("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 18907, 19031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 19047, 19096);

                return f_1456_19054_19095(this, command, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 18827, 19107);

                System.Management.Automation.PSArgumentNullException
                f_1456_18966_19015(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 18966, 19015);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_19054_19095(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                command, bool
                addToHistory, bool
                isNested)
                {
                    var return_v = this_param.CoreCreatePipeline(command, addToHistory, isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 19054, 19095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 18827, 19107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 18827, 19107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Pipeline CreatePipeline(string command, bool addToHistory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 19605, 19911);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 19704, 19828) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 19704, 19828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 19757, 19813);

                    throw f_1456_19763_19812("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 19704, 19828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 19844, 19900);

                return f_1456_19851_19899(this, command, addToHistory, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 19605, 19911);

                System.Management.Automation.PSArgumentNullException
                f_1456_19763_19812(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 19763, 19812);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_19851_19899(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                command, bool
                addToHistory, bool
                isNested)
                {
                    var return_v = this_param.CoreCreatePipeline(command, addToHistory, isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 19851, 19899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 19605, 19911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 19605, 19911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Pipeline CreateNestedPipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 20289, 20417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 20361, 20406);

                return f_1456_20368_20405(this, null, false, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 20289, 20417);

                System.Management.Automation.Runspaces.Pipeline
                f_1456_20368_20405(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                command, bool
                addToHistory, bool
                isNested)
                {
                    var return_v = this_param.CoreCreatePipeline(command, addToHistory, isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 20368, 20405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 20289, 20417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 20289, 20417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Pipeline CreateNestedPipeline(string command, bool addToHistory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 20901, 21212);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 21006, 21130) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 21006, 21130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 21059, 21115);

                    throw f_1456_21065_21114("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 21006, 21130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 21146, 21201);

                return f_1456_21153_21200(this, command, addToHistory, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 20901, 21212);

                System.Management.Automation.PSArgumentNullException
                f_1456_21065_21114(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 21065, 21114);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_21153_21200(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                command, bool
                addToHistory, bool
                isNested)
                {
                    var return_v = this_param.CoreCreatePipeline(command, addToHistory, isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 21153, 21200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 20901, 21212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 20901, 21212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Pipeline CoreCreatePipeline(string command, bool addToHistory, bool isNested);



        /// <summary>
        /// Event raised when RunspaceState changes.
        /// </summary>
        public override event EventHandler<RunspaceStateEventArgs>
StateChanged
;

        /// <summary>
        /// Event raised when the availability of the Runspace changes.
        /// </summary>
        public override event EventHandler<RunspaceAvailabilityEventArgs>
AvailabilityChanged
;

        internal override bool HasAvailabilityChangedSubscribers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 22491, 22539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 22497, 22537);

                    return this.AvailabilityChanged != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 22491, 22539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 22410, 22550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 22410, 22550);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void OnAvailabilityChanged(RunspaceAvailabilityEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 22660, 23075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 22763, 22837);

                EventHandler<RunspaceAvailabilityEventArgs>
                eh = this.AvailabilityChanged
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 22853, 23064) || true) && (eh != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 22853, 23064);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 22945, 22957);

                        f_1456_22945_22956(eh, this, e);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1456, 22994, 23049);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1456, 22994, 23049);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 22853, 23064);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 22660, 23075);

                int
                f_1456_22945_22956(System.EventHandler<System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs>
                this_param, System.Management.Automation.Runspaces.RunspaceBase
                sender, System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 22945, 22956);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 22660, 23075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 22660, 23075);
            }
        }

        protected RunspaceState RunspaceState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 23294, 23377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 23330, 23362);

                    return f_1456_23337_23361(_runspaceStateInfo);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 23294, 23377);

                    System.Management.Automation.Runspaces.RunspaceState
                    f_1456_23337_23361(System.Management.Automation.Runspaces.RunspaceStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 23337, 23361);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 23232, 23388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 23232, 23388);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Queue<RunspaceEventQueueItem> _runspaceEventQueue;
        private class RunspaceEventQueueItem
        {
            public RunspaceEventQueueItem(RunspaceStateInfo runspaceStateInfo, RunspaceAvailability currentAvailability, RunspaceAvailability newAvailability)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1456, 24039, 24414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24455, 24472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24515, 24542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24585, 24608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24218, 24261);

                    this.RunspaceStateInfo = runspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24279, 24334);

                    this.CurrentRunspaceAvailability = currentAvailability;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 24352, 24399);

                    this.NewRunspaceAvailability = newAvailability;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1456, 24039, 24414);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 24039, 24414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 24039, 24414);
                }
            }

            public RunspaceStateInfo RunspaceStateInfo;

            public RunspaceAvailability CurrentRunspaceAvailability;

            public RunspaceAvailability NewRunspaceAvailability;

            static RunspaceEventQueueItem()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1456, 23978, 24620);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1456, 23978, 24620);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 23978, 24620);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1456, 23978, 24620);
        }

        internal ManualResetEventSlim RunspaceOpening;

        protected void SetRunspaceState(RunspaceState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 25363, 26523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 25464, 25472);
                lock (f_1456_25464_25472())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 25506, 26497) || true) && (state != f_1456_25519_25532())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 25506, 26497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 25574, 25632);

                        _runspaceStateInfo = f_1456_25595_25631(state, reason);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 26056, 26122);

                        RunspaceAvailability
                        previousAvailability = _runspaceAvailability
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 26146, 26211);

                        f_1456_26146_26210(
                                            this, f_1456_26178_26202(_runspaceStateInfo), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 26235, 26478);

                        f_1456_26235_26477(
                                            _runspaceEventQueue, f_1456_26289_26476(f_1456_26346_26372(_runspaceStateInfo), previousAvailability, _runspaceAvailability));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 25506, 26497);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 25363, 26523);

                object
                f_1456_25464_25472()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 25464, 25472);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_25519_25532()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 25519, 25532);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1456_25595_25631(System.Management.Automation.Runspaces.RunspaceState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 25595, 25631);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_26178_26202(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 26178, 26202);
                    return return_v;
                }


                int
                f_1456_26146_26210(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.RunspaceState
                runspaceState, bool
                raiseEvent)
                {
                    this_param.UpdateRunspaceAvailability(runspaceState, raiseEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 26146, 26210);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1456_26346_26372(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 26346, 26372);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem
                f_1456_26289_26476(System.Management.Automation.Runspaces.RunspaceStateInfo
                runspaceStateInfo, System.Management.Automation.Runspaces.RunspaceAvailability
                currentAvailability, System.Management.Automation.Runspaces.RunspaceAvailability
                newAvailability)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem(runspaceStateInfo, currentAvailability, newAvailability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 26289, 26476);
                    return return_v;
                }


                int
                f_1456_26235_26477(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>
                this_param, System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 26235, 26477);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 25363, 26523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 25363, 26523);
            }
        }

        protected void SetRunspaceState(RunspaceState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 26694, 26817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 26771, 26806);

                f_1456_26771_26805(this, state, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 26694, 26817);

                int
                f_1456_26771_26805(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.RunspaceState
                state, System.Exception
                reason)
                {
                    this_param.SetRunspaceState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 26771, 26805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 26694, 26817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 26694, 26817);
            }
        }

        protected void RaiseRunspaceStateEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 26934, 29094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27000, 27052);

                Queue<RunspaceEventQueueItem>
                tempEventQueue = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27066, 27123);

                EventHandler<RunspaceStateEventArgs>
                stateChanged = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27137, 27184);

                bool
                hasAvailabilityChangedSubscribers = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27206, 27214);

                lock (f_1456_27206_27214())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27248, 27281);

                    stateChanged = this.StateChanged;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27299, 27374);

                    hasAvailabilityChangedSubscribers = f_1456_27335_27373(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27394, 27953) || true) && (stateChanged != null || (DynAbs.Tracing.TraceSender.Expression_False(1456, 27398, 27455) || hasAvailabilityChangedSubscribers))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 27394, 27953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27497, 27534);

                        tempEventQueue = _runspaceEventQueue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27556, 27614);

                        _runspaceEventQueue = f_1456_27578_27613();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 27394, 27953);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 27394, 27953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27906, 27934);

                        f_1456_27906_27933(                    // Clear the events if there are no EventHandlers. This
                                                               // ensures that events do not get called for state
                                                               // changes prior to their registration.
                                            _runspaceEventQueue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 27394, 27953);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 27984, 29083) || true) && (tempEventQueue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 27984, 29083);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 28044, 29068) || true) && (f_1456_28051_28071(tempEventQueue) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 28044, 29068);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 28117, 28177);

                            RunspaceEventQueueItem
                            queueItem = f_1456_28152_28176(tempEventQueue)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 28201, 28486) || true) && (hasAvailabilityChangedSubscribers && (DynAbs.Tracing.TraceSender.Expression_True(1456, 28205, 28316) && queueItem.NewRunspaceAvailability != queueItem.CurrentRunspaceAvailability))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 28201, 28486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 28366, 28463);

                                f_1456_28366_28462(this, f_1456_28393_28461(queueItem.NewRunspaceAvailability));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 28201, 28486);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 28661, 29018) || true) && (stateChanged != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 28661, 29018);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 28795, 28871);

                                    f_1456_28795_28870(stateChanged, this, f_1456_28814_28869(queueItem.RunspaceStateInfo));
                                }
                                catch (Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1456, 28924, 28995);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1456, 28924, 28995);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 28661, 29018);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 28044, 29068);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1456, 28044, 29068);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1456, 28044, 29068);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 27984, 29083);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 26934, 29094);

                object
                f_1456_27206_27214()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 27206, 27214);
                    return return_v;
                }


                bool
                f_1456_27335_27373(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.HasAvailabilityChangedSubscribers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 27335, 27373);
                    return return_v;
                }


                System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>
                f_1456_27578_27613()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 27578, 27613);
                    return return_v;
                }


                int
                f_1456_27906_27933(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 27906, 27933);
                    return 0;
                }


                int
                f_1456_28051_28071(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 28051, 28071);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem
                f_1456_28152_28176(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 28152, 28176);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                f_1456_28393_28461(System.Management.Automation.Runspaces.RunspaceAvailability
                runspaceAvailability)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs(runspaceAvailability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 28393, 28461);
                    return return_v;
                }


                int
                f_1456_28366_28462(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
                e)
                {
                    this_param.OnAvailabilityChanged(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 28366, 28462);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceStateEventArgs
                f_1456_28814_28869(System.Management.Automation.Runspaces.RunspaceStateInfo
                runspaceStateInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspaceStateEventArgs(runspaceStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 28814, 28869);
                    return return_v;
                }


                int
                f_1456_28795_28870(System.EventHandler<System.Management.Automation.Runspaces.RunspaceStateEventArgs>
                this_param, System.Management.Automation.Runspaces.RunspaceBase
                sender, System.Management.Automation.Runspaces.RunspaceStateEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 28795, 28870);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 26934, 29094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 26934, 29094);
            }
        }

        protected bool ByPassRunspaceStateCheck { get; set; }

        private readonly object _pipelineListLock;

        protected List<Pipeline> RunningPipelines { get; }

        internal void AddToRunningPipelineList(PipelineBase pipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 30397, 31510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 30483, 30552);

                f_1456_30483_30551(pipeline != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 30574, 30591);

                lock (_pipelineListLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 30625, 31153) || true) && (f_1456_30629_30653() == false && (DynAbs.Tracing.TraceSender.Expression_True(1456, 30629, 30703) && f_1456_30666_30679() != RunspaceState.Opened))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 30625, 31153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 30745, 31104);

                        InvalidRunspaceStateException
                        e =
                        f_1456_30804_31103(f_1456_30894_30981(f_1456_30912_30954(), f_1456_30956_30980(f_1456_30956_30969())), f_1456_31012_31025(), RunspaceState.Opened)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 31126, 31134);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 30625, 31153);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 31398, 31429);

                    f_1456_31398_31428(f_1456_31398_31414(), pipeline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 31447, 31484);

                    _currentlyRunningPipeline = pipeline;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 30397, 31510);

                int
                f_1456_30483_30551(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 30483, 30551);
                    return 0;
                }


                bool
                f_1456_30629_30653()
                {
                    var return_v = ByPassRunspaceStateCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 30629, 30653);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_30666_30679()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 30666, 30679);
                    return return_v;
                }


                string
                f_1456_30912_30954()
                {
                    var return_v = RunspaceStrings.RunspaceNotOpenForPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 30912, 30954);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_30956_30969()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 30956, 30969);
                    return return_v;
                }


                string
                f_1456_30956_30980(System.Management.Automation.Runspaces.RunspaceState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 30956, 30980);
                    return return_v;
                }


                string
                f_1456_30894_30981(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 30894, 30981);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_31012_31025()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 31012, 31025);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_30804_31103(string
                message, System.Management.Automation.Runspaces.RunspaceState
                currentState, System.Management.Automation.Runspaces.RunspaceState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 30804, 31103);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_31398_31414()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 31398, 31414);
                    return return_v;
                }


                int
                f_1456_31398_31428(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param, System.Management.Automation.Runspaces.PipelineBase
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.Pipeline)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 31398, 31428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 30397, 31510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 30397, 31510);
            }
        }

        internal void RemoveFromRunningPipelineList(PipelineBase pipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 31895, 32988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 31986, 32055);

                f_1456_31986_32054(pipeline != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 32077, 32094);

                lock (_pipelineListLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 32128, 32275);

                    f_1456_32128_32274(f_1456_32139_32152() != RunspaceState.BeforeOpen, "Runspace should not be before open when pipeline is running");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 32523, 32557);

                    f_1456_32523_32556(f_1456_32523_32539(), pipeline);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 32625, 32905) || true) && (f_1456_32629_32651(f_1456_32629_32645()) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 32625, 32905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 32698, 32731);

                        _currentlyRunningPipeline = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 32625, 32905);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 32625, 32905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 32813, 32886);

                        _currentlyRunningPipeline = f_1456_32841_32885(f_1456_32841_32857(), f_1456_32858_32880(f_1456_32858_32874()) - 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 32625, 32905);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 32925, 32962);

                    f_1456_32925_32961(f_1456_32925_32955(pipeline));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 31895, 32988);

                int
                f_1456_31986_32054(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 31986, 32054);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_32139_32152()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32139, 32152);
                    return return_v;
                }


                int
                f_1456_32128_32274(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 32128, 32274);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_32523_32539()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32523, 32539);
                    return return_v;
                }


                bool
                f_1456_32523_32556(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param, System.Management.Automation.Runspaces.PipelineBase
                item)
                {
                    var return_v = this_param.Remove((System.Management.Automation.Runspaces.Pipeline)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 32523, 32556);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_32629_32645()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32629, 32645);
                    return return_v;
                }


                int
                f_1456_32629_32651(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32629, 32651);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_32841_32857()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32841, 32857);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_32858_32874()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32858, 32874);
                    return return_v;
                }


                int
                f_1456_32858_32880(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32858, 32880);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_32841_32885(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32841, 32885);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1456_32925_32955(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.PipelineFinishedEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 32925, 32955);
                    return return_v;
                }


                bool
                f_1456_32925_32961(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 32925, 32961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 31895, 32988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 31895, 32988);
            }
        }

        internal bool WaitForFinishofPipelines()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 33151, 35801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 33677, 33709);

                PipelineBase[]
                runningPipelines
                = default(PipelineBase[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 33731, 33748);

                lock (_pipelineListLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 33782, 33849);

                    runningPipelines = f_1456_33801_33848(f_1456_33801_33838(f_1456_33801_33817()));
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 33880, 35790) || true) && (f_1456_33884_33907(runningPipelines) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 33880, 35790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 33945, 34012);

                    WaitHandle[]
                    waitHandles = new WaitHandle[f_1456_33987_34010(runningPipelines)]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34041, 34046);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34032, 34200) || true) && (i < f_1456_34052_34075(runningPipelines))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34077, 34080)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 34032, 34200))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 34032, 34200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34122, 34181);

                            waitHandles[i] = f_1456_34139_34180(runningPipelines[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1456, 1, 169);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1456, 1, 169);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34376, 35638) || true) && (f_1456_34380_34403(runningPipelines) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(1456, 34380, 34473) && f_1456_34411_34451(f_1456_34411_34431()) == ApartmentState.STA))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 34376, 35638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34716, 35619);
                        using (ManualResetEvent
                        waitAllIsDone = f_1456_34756_34783(false)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34833, 34953);

                            Tuple<WaitHandle[], ManualResetEvent>
                            stateInfo = f_1456_34883_34952(waitHandles, waitAllIsDone)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 34981, 35539);

                            f_1456_34981_35538(new WaitCallback(
                                                                                     delegate (object state)
                                                                                     {
                                                                                         var tuple = (Tuple<WaitHandle[], ManualResetEvent>)state;
                                                                                         WaitHandle.WaitAll(tuple.Item1);
                                                                                         tuple.Item2.Set();
                                                                                     }), stateInfo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 35565, 35596);

                            return f_1456_35572_35595(waitAllIsDone);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1456, 34716, 35619);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 34376, 35638);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 35658, 35697);

                    return f_1456_35665_35696(waitHandles);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 33880, 35790);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 33880, 35790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 35763, 35775);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 33880, 35790);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 33151, 35801);

                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_33801_33817()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 33801, 33817);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PipelineBase>
                f_1456_33801_33838(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                source)
                {
                    var return_v = source.Cast<System.Management.Automation.Runspaces.PipelineBase>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 33801, 33838);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase[]
                f_1456_33801_33848(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PipelineBase>
                source)
                {
                    var return_v = source.ToArray<System.Management.Automation.Runspaces.PipelineBase>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 33801, 33848);
                    return return_v;
                }


                int
                f_1456_33884_33907(System.Management.Automation.Runspaces.PipelineBase[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 33884, 33907);
                    return return_v;
                }


                int
                f_1456_33987_34010(System.Management.Automation.Runspaces.PipelineBase[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 33987, 34010);
                    return return_v;
                }


                int
                f_1456_34052_34075(System.Management.Automation.Runspaces.PipelineBase[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 34052, 34075);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1456_34139_34180(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.PipelineFinishedEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 34139, 34180);
                    return return_v;
                }


                int
                f_1456_34380_34403(System.Management.Automation.Runspaces.PipelineBase[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 34380, 34403);
                    return return_v;
                }


                System.Threading.Thread
                f_1456_34411_34431()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 34411, 34431);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1456_34411_34451(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.GetApartmentState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 34411, 34451);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1456_34756_34783(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 34756, 34783);
                    return return_v;
                }


                System.Tuple<System.Threading.WaitHandle[], System.Threading.ManualResetEvent>
                f_1456_34883_34952(System.Threading.WaitHandle[]
                item1, System.Threading.ManualResetEvent
                item2)
                {
                    var return_v = new System.Tuple<System.Threading.WaitHandle[], System.Threading.ManualResetEvent>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 34883, 34952);
                    return return_v;
                }


                bool
                f_1456_34981_35538(System.Threading.WaitCallback
                callBack, System.Tuple<System.Threading.WaitHandle[], System.Threading.ManualResetEvent>
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 34981, 35538);
                    return return_v;
                }


                bool
                f_1456_35572_35595(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 35572, 35595);
                    return return_v;
                }


                bool
                f_1456_35665_35696(System.Threading.WaitHandle[]
                waitHandles)
                {
                    var return_v = WaitHandle.WaitAll(waitHandles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 35665, 35696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 33151, 35801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 33151, 35801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void StopPipelines()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 35906, 36453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 35961, 35993);

                PipelineBase[]
                runningPipelines
                = default(PipelineBase[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36015, 36032);

                lock (_pipelineListLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36066, 36133);

                    runningPipelines = f_1456_36085_36132(f_1456_36085_36122(f_1456_36085_36101()));
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36164, 36442) || true) && (f_1456_36168_36191(runningPipelines) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 36164, 36442);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36295, 36326);
                        // Start from the most recent pipeline.
                        for (int
        i = f_1456_36299_36322(runningPipelines) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36286, 36427) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36336, 36339)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 36286, 36427))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 36286, 36427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36381, 36408);

                            f_1456_36381_36407(runningPipelines[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1456, 1, 142);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1456, 1, 142);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 36164, 36442);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 35906, 36453);

                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_36085_36101()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 36085, 36101);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PipelineBase>
                f_1456_36085_36122(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                source)
                {
                    var return_v = source.Cast<System.Management.Automation.Runspaces.PipelineBase>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 36085, 36122);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase[]
                f_1456_36085_36132(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PipelineBase>
                source)
                {
                    var return_v = source.ToArray<System.Management.Automation.Runspaces.PipelineBase>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 36085, 36132);
                    return return_v;
                }


                int
                f_1456_36168_36191(System.Management.Automation.Runspaces.PipelineBase[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 36168, 36191);
                    return return_v;
                }


                int
                f_1456_36299_36322(System.Management.Automation.Runspaces.PipelineBase[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 36299, 36322);
                    return return_v;
                }


                int
                f_1456_36381_36407(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 36381, 36407);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 35906, 36453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 35906, 36453);
            }
        }

        internal bool CanRunActionInCurrentPipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 36465, 36995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36541, 36558);
                lock (_pipelineListLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36761, 36825);

                    var
                    pipelineRunning = _currentlyRunningPipeline as PipelineBase
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 36843, 36969);

                    return pipelineRunning == null || (DynAbs.Tracing.TraceSender.Expression_False(1456, 36850, 36968) || f_1456_36899_36919() == f_1456_36923_36968(pipelineRunning));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 36465, 36995);

                System.Threading.Thread
                f_1456_36899_36919()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 36899, 36919);
                    return return_v;
                }


                System.Threading.Thread
                f_1456_36923_36968(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.NestedPipelineExecutionThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 36923, 36968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 36465, 36995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 36465, 36995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Pipeline GetCurrentlyRunningPipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 37186, 37311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 37267, 37300);

                return _currentlyRunningPipeline;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 37186, 37311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 37186, 37311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 37186, 37311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Pipeline _currentlyRunningPipeline;

        internal void StopNestedPipelines(Pipeline pipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 37615, 39025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 37692, 37730);

                List<Pipeline>
                nestedPipelines = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 37752, 37769);

                lock (_pipelineListLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 37981, 38097) || true) && (f_1456_37985_38020(f_1456_37985_38001(), pipeline) == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 37981, 38097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38071, 38078);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 37981, 38097);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38244, 38357) || true) && (f_1456_38248_38277(this) == pipeline)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 38244, 38357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38331, 38338);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 38244, 38357);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38428, 38467);

                    nestedPipelines = f_1456_38446_38466();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38494, 38524);
                        for (int
        i = f_1456_38498_38520(f_1456_38498_38514()) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38485, 38729) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38534, 38537)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 38485, 38729))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 38485, 38729);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38579, 38647) || true) && (f_1456_38583_38602(f_1456_38583_38599(), i) == pipeline)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 38579, 38647);
                                DynAbs.Tracing.TraceSender.TraceBreak(1456, 38641, 38647);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 38579, 38647);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38669, 38710);

                            f_1456_38669_38709(nestedPipelines, f_1456_38689_38708(f_1456_38689_38705(), i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1456, 1, 245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1456, 1, 245);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38760, 39014);
                    foreach (Pipeline np in f_1456_38784_38799_I(nestedPipelines))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 38760, 39014);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 38877, 38887);

                            f_1456_38877_38886(np);
                        }
                        catch (InvalidPipelineStateException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1456, 38924, 38999);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1456, 38924, 38999);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 38760, 39014);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1456, 1, 255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1456, 1, 255);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 37615, 39025);

                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_37985_38001()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 37985, 38001);
                    return return_v;
                }


                bool
                f_1456_37985_38020(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param, System.Management.Automation.Runspaces.Pipeline
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 37985, 38020);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_38248_38277(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 38248, 38277);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_38446_38466()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 38446, 38466);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_38498_38514()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 38498, 38514);
                    return return_v;
                }


                int
                f_1456_38498_38520(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 38498, 38520);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_38583_38599()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 38583, 38599);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_38583_38602(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 38583, 38602);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_38689_38705()
                {
                    var return_v = RunningPipelines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 38689, 38705);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_38689_38708(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 38689, 38708);
                    return return_v;
                }


                int
                f_1456_38669_38709(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                this_param, System.Management.Automation.Runspaces.Pipeline
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 38669, 38709);
                    return 0;
                }


                int
                f_1456_38877_38886(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 38877, 38886);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                f_1456_38784_38799_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 38784, 38799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 37615, 39025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 37615, 39025);
            }
        }

        internal
                void
                DoConcurrentCheckAndAddToRunningPipelines(PipelineBase pipeline, bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 39037, 39851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 39248, 39256);
                // Concurrency check should be done under runspace lock
                lock (f_1456_39248_39256())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 39290, 39504) || true) && (_bSessionStateProxyCallInProgress == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 39290, 39504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 39377, 39485);

                        throw f_1456_39383_39484(f_1456_39426_39483());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 39290, 39504);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 39653, 39706);

                    f_1456_39653_39705(
                                    // Delegate to pipeline to do check if it is fine to invoke if another
                                    // pipeline is running.
                                    pipeline, syncCall, f_1456_39690_39698(), true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 39790, 39825);

                    f_1456_39790_39824(this, pipeline);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 39037, 39851);

                object
                f_1456_39248_39256()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 39248, 39256);
                    return return_v;
                }


                string
                f_1456_39426_39483()
                {
                    var return_v = RunspaceStrings.NoPipelineWhenSessionStateProxyInProgress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 39426, 39483);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1456_39383_39484(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 39383, 39484);
                    return return_v;
                }


                object
                f_1456_39690_39698()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 39690, 39698);
                    return return_v;
                }


                int
                f_1456_39653_39705(System.Management.Automation.Runspaces.PipelineBase
                this_param, bool
                syncCall, object
                syncObject, bool
                isInLock)
                {
                    this_param.DoConcurrentCheck(syncCall, syncObject, isInLock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 39653, 39705);
                    return 0;
                }


                int
                f_1456_39790_39824(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.PipelineBase
                pipeline)
                {
                    this_param.AddToRunningPipelineList(pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 39790, 39824);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 39037, 39851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 39037, 39851);
            }
        }

        internal void Pulse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 40215, 42783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 40340, 40369);

                bool
                pipelineCreated = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 40383, 41566) || true) && (f_1456_40387_40416(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 40383, 41566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 40464, 40472);
                    lock (f_1456_40464_40472())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 40514, 41532) || true) && (f_1456_40518_40547(this) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 40514, 41532);
                            // This is a pipeline that does the least amount possible.
                            // It evaluates a constant, and results in the execution of only two parse tree nodes.
                            // We don't need to void it, as we aren't using the results. In addition, voiding
                            // (as opposed to ignoring) is 1.6x slower.
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 41037, 41087);

                                PulsePipeline = (PipelineBase)f_1456_41067_41086(this, "0");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 41117, 41154);

                                f_1456_41117_41130().IsPulsePipeline = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 41184, 41207);

                                pipelineCreated = true;
                            }
                            catch (ObjectDisposedException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1456, 41260, 41509);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1456, 41260, 41509);
                                // Ignore. The runspace is closing. The event was not processed,
                                // but this should not crash PowerShell.
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 40514, 41532);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 40383, 41566);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 41755, 42772) || true) && (pipelineCreated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 41755, 42772);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 41852, 41875);

                        f_1456_41852_41874(f_1456_41852_41865());
                    }
                    catch (PSInvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1456, 41912, 42281);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1456, 41912, 42281);
                        // Ignore. A pipeline was created between the time
                        // we checked for it, and when we invoked the pipeline.
                        // This is unlikely, but taking a lock on the runspace
                        // means that OUR invoke will not be able to run.
                    }
                    catch (InvalidRunspaceStateException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1456, 42299, 42522);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1456, 42299, 42522);
                        // Ignore. The runspace is closing. The event was not processed,
                        // but this should not crash PowerShell.
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1456, 42540, 42757);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1456, 42540, 42757);
                        // Ignore. The runspace is closing. The event was not processed,
                        // but this should not crash PowerShell.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 41755, 42772);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 40215, 42783);

                System.Management.Automation.Runspaces.Pipeline
                f_1456_40387_40416(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 40387, 40416);
                    return return_v;
                }


                object
                f_1456_40464_40472()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 40464, 40472);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_40518_40547(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 40518, 40547);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_41067_41086(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                command)
                {
                    var return_v = this_param.CreatePipeline(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 41067, 41086);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase
                f_1456_41117_41130()
                {
                    var return_v = PulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 41117, 41130);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase
                f_1456_41852_41865()
                {
                    var return_v = PulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 41852, 41865);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1456_41852_41874(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 41852, 41874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 40215, 42783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 40215, 42783);
            }
        }

        internal PipelineBase PulsePipeline { get; private set; }

        private bool _bSessionStateProxyCallInProgress;

        private void DoConcurrentCheckAndMarkSessionStateProxyCallInProgress()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 43439, 45822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 43540, 43548);
                lock (f_1456_43540_43548())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 43582, 44071) || true) && (f_1456_43586_43599() != RunspaceState.Opened)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 43582, 44071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 43665, 44022);

                        InvalidRunspaceStateException
                        e =
                        f_1456_43724_44021(f_1456_43814_43899(f_1456_43832_43872(), f_1456_43874_43898(f_1456_43874_43887())), f_1456_43930_43943(), RunspaceState.Opened)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 44044, 44052);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 43582, 44071);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 44091, 44298) || true) && (_bSessionStateProxyCallInProgress == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 44091, 44298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 44178, 44279);

                        throw f_1456_44184_44278(f_1456_44227_44277());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 44091, 44298);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 44318, 44375);

                    Pipeline
                    runningPipeline = f_1456_44345_44374(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 44393, 45677) || true) && (runningPipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 44393, 45677);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 44607, 45658) || true) && (runningPipeline == f_1456_44630_44643() || (DynAbs.Tracing.TraceSender.Expression_False(1456, 44611, 44723) || (f_1456_44673_44697(runningPipeline) && (DynAbs.Tracing.TraceSender.Expression_True(1456, 44673, 44722) && f_1456_44701_44714() != null))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 44607, 45658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 44911, 44934);

                            f_1456_44911_44933(f_1456_44924_44932());

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 45022, 45049);

                                f_1456_45022_45048(this);
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 45102, 45310);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 45259, 45283);

                                f_1456_45259_45282(f_1456_45273_45281());
                                DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 45102, 45310);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 45338, 45396);

                            f_1456_45338_45395(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 45422, 45429);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 44607, 45658);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 44607, 45658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 45527, 45635);

                            throw f_1456_45533_45634(f_1456_45576_45633());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 44607, 45658);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 44393, 45677);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 45755, 45796);

                    _bSessionStateProxyCallInProgress = true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 43439, 45822);

                object
                f_1456_43540_43548()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 43540, 43548);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_43586_43599()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 43586, 43599);
                    return return_v;
                }


                string
                f_1456_43832_43872()
                {
                    var return_v = RunspaceStrings.RunspaceNotInOpenedState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 43832, 43872);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_43874_43887()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 43874, 43887);
                    return return_v;
                }


                string
                f_1456_43874_43898(System.Management.Automation.Runspaces.RunspaceState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 43874, 43898);
                    return return_v;
                }


                string
                f_1456_43814_43899(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 43814, 43899);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1456_43930_43943()
                {
                    var return_v = RunspaceState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 43930, 43943);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidRunspaceStateException
                f_1456_43724_44021(string
                message, System.Management.Automation.Runspaces.RunspaceState
                currentState, System.Management.Automation.Runspaces.RunspaceState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 43724, 44021);
                    return return_v;
                }


                string
                f_1456_44227_44277()
                {
                    var return_v = RunspaceStrings.AnotherSessionStateProxyInProgress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 44227, 44277);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1456_44184_44278(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 44184, 44278);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1456_44345_44374(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 44345, 44374);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase
                f_1456_44630_44643()
                {
                    var return_v = PulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 44630, 44643);
                    return return_v;
                }


                bool
                f_1456_44673_44697(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 44673, 44697);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase
                f_1456_44701_44714()
                {
                    var return_v = PulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 44701, 44714);
                    return return_v;
                }


                object
                f_1456_44924_44932()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 44924, 44932);
                    return return_v;
                }


                int
                f_1456_44911_44933(object
                obj)
                {
                    Monitor.Exit(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 44911, 44933);
                    return 0;
                }


                bool
                f_1456_45022_45048(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.WaitForFinishofPipelines();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 45022, 45048);
                    return return_v;
                }


                object
                f_1456_45273_45281()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 45273, 45281);
                    return return_v;
                }


                int
                f_1456_45259_45282(object
                obj)
                {
                    Monitor.Enter(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 45259, 45282);
                    return 0;
                }


                int
                f_1456_45338_45395(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 45338, 45395);
                    return 0;
                }


                string
                f_1456_45576_45633()
                {
                    var return_v = RunspaceStrings.NoSessionStateProxyWhenPipelineInProgress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 45576, 45633);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1456_45533_45634(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 45533, 45634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 43439, 45822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 43439, 45822);
            }
        }

        internal void SetVariable(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 46211, 46635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 46288, 46346);

                f_1456_46288_46345(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 46396, 46423);

                    f_1456_46396_46422(this, name, value);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 46452, 46624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 46498, 46506);
                    lock (f_1456_46498_46506())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 46548, 46590);

                        _bSessionStateProxyCallInProgress = false;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 46452, 46624);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 46211, 46635);

                int
                f_1456_46288_46345(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 46288, 46345);
                    return 0;
                }


                int
                f_1456_46396_46422(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                name, object
                value)
                {
                    this_param.DoSetVariable(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 46396, 46422);
                    return 0;
                }


                object
                f_1456_46498_46506()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 46498, 46506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 46211, 46635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 46211, 46635);
            }
        }

        internal object GetVariable(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 47015, 47427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 47080, 47138);

                f_1456_47080_47137(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 47188, 47215);

                    return f_1456_47195_47214(this, name);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 47244, 47416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 47290, 47298);
                    lock (f_1456_47290_47298())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 47340, 47382);

                        _bSessionStateProxyCallInProgress = false;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 47244, 47416);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 47015, 47427);

                int
                f_1456_47080_47137(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 47080, 47137);
                    return 0;
                }


                object
                f_1456_47195_47214(System.Management.Automation.Runspaces.RunspaceBase
                this_param, string
                name)
                {
                    var return_v = this_param.DoGetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 47195, 47214);
                    return return_v;
                }


                object
                f_1456_47290_47298()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 47290, 47298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 47015, 47427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 47015, 47427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<string> Applications
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 47826, 48252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 47862, 47920);

                    f_1456_47862_47919(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 47982, 48004);

                        return f_1456_47989_48003();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 48041, 48237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 48095, 48103);
                        lock (f_1456_48095_48103())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 48153, 48195);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 48041, 48237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 47826, 48252);

                    int
                    f_1456_47862_47919(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 47862, 47919);
                        return 0;
                    }


                    System.Collections.Generic.List<string>
                    f_1456_47989_48003()
                    {
                        var return_v = DoApplications;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 47989, 48003);
                        return return_v;
                    }


                    object
                    f_1456_48095_48103()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 48095, 48103);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 47767, 48263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 47767, 48263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal List<string> Scripts
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 48652, 49073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 48688, 48746);

                    f_1456_48688_48745(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 48808, 48825);

                        return f_1456_48815_48824();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 48862, 49058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 48916, 48924);
                        lock (f_1456_48916_48924())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 48974, 49016);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 48862, 49058);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 48652, 49073);

                    int
                    f_1456_48688_48745(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 48688, 48745);
                        return 0;
                    }


                    System.Collections.Generic.List<string>
                    f_1456_48815_48824()
                    {
                        var return_v = DoScripts;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 48815, 48824);
                        return return_v;
                    }


                    object
                    f_1456_48916_48924()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 48916, 48924);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 48598, 49084);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 48598, 49084);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DriveManagementIntrinsics Drive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 49334, 49753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 49370, 49428);

                    f_1456_49370_49427(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 49490, 49505);

                        return f_1456_49497_49504();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 49542, 49738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 49596, 49604);
                        lock (f_1456_49596_49604())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 49654, 49696);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 49542, 49738);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 49334, 49753);

                    int
                    f_1456_49370_49427(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 49370, 49427);
                        return 0;
                    }


                    System.Management.Automation.DriveManagementIntrinsics
                    f_1456_49497_49504()
                    {
                        var return_v = DoDrive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 49497, 49504);
                        return return_v;
                    }


                    object
                    f_1456_49596_49604()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 49596, 49604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 49269, 49764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 49269, 49764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSLanguageMode LanguageMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 50008, 50590);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 50044, 50533) || true) && (f_1456_50048_50061() != RunspaceState.Opened)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 50044, 50533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 50127, 50484);

                        InvalidRunspaceStateException
                        e =
                        f_1456_50186_50483(f_1456_50276_50361(f_1456_50294_50334(), f_1456_50336_50360(f_1456_50336_50349())), f_1456_50392_50405(), RunspaceState.Opened)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 50506, 50514);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 50044, 50533);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 50553, 50575);

                    return f_1456_50560_50574();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 50008, 50590);

                    System.Management.Automation.Runspaces.RunspaceState
                    f_1456_50048_50061()
                    {
                        var return_v = RunspaceState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50048, 50061);
                        return return_v;
                    }


                    string
                    f_1456_50294_50334()
                    {
                        var return_v = RunspaceStrings.RunspaceNotInOpenedState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50294, 50334);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceState
                    f_1456_50336_50349()
                    {
                        var return_v = RunspaceState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50336, 50349);
                        return return_v;
                    }


                    string
                    f_1456_50336_50360(System.Management.Automation.Runspaces.RunspaceState
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 50336, 50360);
                        return return_v;
                    }


                    string
                    f_1456_50276_50361(string
                    formatSpec, string
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 50276, 50361);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceState
                    f_1456_50392_50405()
                    {
                        var return_v = RunspaceState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50392, 50405);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.InvalidRunspaceStateException
                    f_1456_50186_50483(string
                    message, System.Management.Automation.Runspaces.RunspaceState
                    currentState, System.Management.Automation.Runspaces.RunspaceState
                    expectedState)
                    {
                        var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 50186, 50483);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode
                    f_1456_50560_50574()
                    {
                        var return_v = DoLanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50560, 50574);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 49949, 51200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 49949, 51200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 50606, 51189);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 50642, 51131) || true) && (f_1456_50646_50659() != RunspaceState.Opened)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1456, 50642, 51131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 50725, 51082);

                        InvalidRunspaceStateException
                        e =
                        f_1456_50784_51081(f_1456_50874_50959(f_1456_50892_50932(), f_1456_50934_50958(f_1456_50934_50947())), f_1456_50990_51003(), RunspaceState.Opened)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 51104, 51112);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1456, 50642, 51131);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 51151, 51174);

                    DoLanguageMode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 50606, 51189);

                    System.Management.Automation.Runspaces.RunspaceState
                    f_1456_50646_50659()
                    {
                        var return_v = RunspaceState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50646, 50659);
                        return return_v;
                    }


                    string
                    f_1456_50892_50932()
                    {
                        var return_v = RunspaceStrings.RunspaceNotInOpenedState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50892, 50932);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceState
                    f_1456_50934_50947()
                    {
                        var return_v = RunspaceState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50934, 50947);
                        return return_v;
                    }


                    string
                    f_1456_50934_50958(System.Management.Automation.Runspaces.RunspaceState
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 50934, 50958);
                        return return_v;
                    }


                    string
                    f_1456_50874_50959(string
                    formatSpec, string
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 50874, 50959);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceState
                    f_1456_50990_51003()
                    {
                        var return_v = RunspaceState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 50990, 51003);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.InvalidRunspaceStateException
                    f_1456_50784_51081(string
                    message, System.Management.Automation.Runspaces.RunspaceState
                    currentState, System.Management.Automation.Runspaces.RunspaceState
                    expectedState)
                    {
                        var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException(message, currentState, expectedState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 50784, 51081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 49949, 51200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 49949, 51200);
                }
            }
        }

        internal PSModuleInfo Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 51438, 51858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 51474, 51532);

                    f_1456_51474_51531(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 51594, 51610);

                        return f_1456_51601_51609();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 51647, 51843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 51701, 51709);
                        lock (f_1456_51701_51709())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 51759, 51801);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 51647, 51843);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 51438, 51858);

                    int
                    f_1456_51474_51531(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 51474, 51531);
                        return 0;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1456_51601_51609()
                    {
                        var return_v = DoModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 51601, 51609);
                        return return_v;
                    }


                    object
                    f_1456_51701_51709()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 51701, 51709);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 51385, 51869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 51385, 51869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PathIntrinsics PathIntrinsics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 52117, 52535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 52153, 52211);

                    f_1456_52153_52210(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 52273, 52287);

                        return f_1456_52280_52286();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 52324, 52520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 52378, 52386);
                        lock (f_1456_52378_52386())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 52436, 52478);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 52324, 52520);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 52117, 52535);

                    int
                    f_1456_52153_52210(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 52153, 52210);
                        return 0;
                    }


                    System.Management.Automation.PathIntrinsics
                    f_1456_52280_52286()
                    {
                        var return_v = DoPath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 52280, 52286);
                        return return_v;
                    }


                    object
                    f_1456_52378_52386()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 52378, 52386);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 52054, 52546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 52054, 52546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CmdletProviderManagementIntrinsics Provider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 52808, 53230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 52844, 52902);

                    f_1456_52844_52901(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 52964, 52982);

                        return f_1456_52971_52981();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 53019, 53215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 53073, 53081);
                        lock (f_1456_53073_53081())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 53131, 53173);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 53019, 53215);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 52808, 53230);

                    int
                    f_1456_52844_52901(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 52844, 52901);
                        return 0;
                    }


                    System.Management.Automation.CmdletProviderManagementIntrinsics
                    f_1456_52971_52981()
                    {
                        var return_v = DoProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 52971, 52981);
                        return return_v;
                    }


                    object
                    f_1456_53073_53081()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 53073, 53081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 52731, 53241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 52731, 53241);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSVariableIntrinsics PSVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 53491, 53915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 53527, 53585);

                    f_1456_53527_53584(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 53647, 53667);

                        return f_1456_53654_53666();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 53704, 53900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 53758, 53766);
                        lock (f_1456_53758_53766())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 53816, 53858);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 53704, 53900);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 53491, 53915);

                    int
                    f_1456_53527_53584(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 53527, 53584);
                        return 0;
                    }


                    System.Management.Automation.PSVariableIntrinsics
                    f_1456_53654_53666()
                    {
                        var return_v = DoPSVariable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 53654, 53666);
                        return return_v;
                    }


                    object
                    f_1456_53758_53766()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 53758, 53766);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 53426, 53926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 53426, 53926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CommandInvocationIntrinsics InvokeCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 54186, 54613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 54222, 54280);

                    f_1456_54222_54279(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 54342, 54365);

                        return f_1456_54349_54364();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 54402, 54598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 54456, 54464);
                        lock (f_1456_54456_54464())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 54514, 54556);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 54402, 54598);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 54186, 54613);

                    int
                    f_1456_54222_54279(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 54222, 54279);
                        return 0;
                    }


                    System.Management.Automation.CommandInvocationIntrinsics
                    f_1456_54349_54364()
                    {
                        var return_v = DoInvokeCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 54349, 54364);
                        return return_v;
                    }


                    object
                    f_1456_54456_54464()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 54456, 54464);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 54111, 54624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 54111, 54624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ProviderIntrinsics InvokeProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 54876, 55304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 54912, 54970);

                    f_1456_54912_54969(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 55032, 55056);

                        return f_1456_55039_55055();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1456, 55093, 55289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 55147, 55155);
                        lock (f_1456_55147_55155())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 55205, 55247);

                            _bSessionStateProxyCallInProgress = false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1456, 55093, 55289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 54876, 55304);

                    int
                    f_1456_54912_54969(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        this_param.DoConcurrentCheckAndMarkSessionStateProxyCallInProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 54912, 54969);
                        return 0;
                    }


                    System.Management.Automation.ProviderIntrinsics
                    f_1456_55039_55055()
                    {
                        var return_v = DoInvokeProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 55039, 55055);
                        return return_v;
                    }


                    object
                    f_1456_55147_55155()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 55147, 55155);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 54809, 55315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 54809, 55315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract void DoSetVariable(string name, object value);

        protected abstract object DoGetVariable(string name);

        protected abstract List<string> DoApplications { get; }

        protected abstract List<string> DoScripts { get; }

        protected abstract DriveManagementIntrinsics DoDrive { get; }

        protected abstract PSLanguageMode DoLanguageMode { get; set; }

        protected abstract PSModuleInfo DoModule { get; }

        protected abstract PathIntrinsics DoPath { get; }

        protected abstract CmdletProviderManagementIntrinsics DoProvider { get; }

        protected abstract PSVariableIntrinsics DoPSVariable { get; }

        protected abstract CommandInvocationIntrinsics DoInvokeCommand { get; }

        protected abstract ProviderIntrinsics DoInvokeProvider { get; }

        private SessionStateProxy _sessionStateProxy;

        internal override SessionStateProxy GetSessionStateProxy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1456, 58657, 58831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1456, 58740, 58820);

                return _sessionStateProxy ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.SessionStateProxy>(1456, 58747, 58819) ?? (_sessionStateProxy = f_1456_58791_58818(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1456, 58657, 58831);

                System.Management.Automation.Runspaces.SessionStateProxy
                f_1456_58791_58818(System.Management.Automation.Runspaces.RunspaceBase
                runspace)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateProxy(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 58791, 58818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1456, 58657, 58831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 58657, 58831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RunspaceBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1456, 853, 58880);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1456, 853, 58880);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1456, 853, 58880);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1456, 853, 58880);

        System.Management.Automation.PSArgumentNullException
        f_1456_1520_1566(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 1520, 1566);
            return return_v;
        }


        System.Management.Automation.Runspaces.InitialSessionState
        f_1456_1620_1655()
        {
            var return_v = InitialSessionState.CreateDefault();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 1620, 1655);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1456_2628_2674(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 2628, 2674);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1456_2777_2838(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 2777, 2838);
            return return_v;
        }


        System.Management.Automation.Runspaces.InitialSessionState
        f_1456_2918_2945(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.Clone();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 2918, 2945);
            return return_v;
        }


        System.Management.Automation.Runspaces.PSThreadOptions
        f_1456_2981_3014(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.ThreadOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 2981, 3014);
            return return_v;
        }


        System.Threading.ApartmentState
        f_1456_3051_3085(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.ApartmentState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 3051, 3085);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1456_4220_4266(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 4220, 4266);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1456_4369_4430(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 4369, 4430);
            return return_v;
        }


        System.Management.Automation.Runspaces.InitialSessionState
        f_1456_4669_4696(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.Clone();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 4669, 4696);
            return return_v;
        }


        System.Management.Automation.Runspaces.PSThreadOptions
        f_1456_4749_4782(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.ThreadOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 4749, 4782);
            return return_v;
        }


        System.Threading.ApartmentState
        f_1456_4819_4853(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.ApartmentState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 4819, 4853);
            return return_v;
        }


        System.Version
        f_1456_5406_5429()
        {
            var return_v = PSVersionInfo.PSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1456, 5406, 5429);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspaceStateInfo
        f_1456_5489_5536(System.Management.Automation.Runspaces.RunspaceState
        state)
        {
            var return_v = new System.Management.Automation.Runspaces.RunspaceStateInfo(state);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 5489, 5536);
            return return_v;
        }


        object
        f_1456_6523_6535()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 6523, 6535);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>
        f_1456_23930_23965()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.RunspaceBase.RunspaceEventQueueItem>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 23930, 23965);
            return return_v;
        }


        System.Threading.ManualResetEventSlim
        f_1456_24763_24794(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEventSlim(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 24763, 24794);
            return return_v;
        }


        object
        f_1456_29605_29617()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 29605, 29617);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>
        f_1456_29808_29828()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Pipeline>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1456, 29808, 29828);
            return return_v;
        }

    }
}
