// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Host;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class ExecutionContextForStepping : IDisposable
    {
        private ExecutionContext _executionContext;

        private PSInformationalBuffers _originalInformationalBuffers;

        private PSHost _originalHost;

        private ExecutionContextForStepping(ExecutionContext ctxt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1658, 724, 918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 584, 601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 643, 672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 698, 711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 807, 868);

                f_1658_807_867(ctxt != null, "ExecutionContext cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 882, 907);

                _executionContext = ctxt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1658, 724, 918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 724, 918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 724, 918);
            }
        }

        internal static ExecutionContextForStepping PrepareExecutionContext(
                    ExecutionContext ctxt,
                    PSInformationalBuffers newBuffers,
                    PSHost newHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1658, 930, 1594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1136, 1211);

                ExecutionContextForStepping
                result = f_1658_1173_1210(ctxt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1227, 1345);

                result._originalInformationalBuffers
                                = f_1658_1283_1344(f_1658_1283_1311(f_1658_1283_1300(ctxt)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1359, 1413);

                result._originalHost = f_1658_1382_1412(f_1658_1382_1399(ctxt));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1429, 1501);

                f_1658_1429_1500(f_1658_1429_1457(f_1658_1429_1446(ctxt)), newBuffers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1515, 1553);

                f_1658_1515_1552(f_1658_1515_1532(ctxt), newHost);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1569, 1583);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1658, 930, 1594);

                System.Management.Automation.ExecutionContextForStepping
                f_1658_1173_1210(System.Management.Automation.ExecutionContext
                ctxt)
                {
                    var return_v = new System.Management.Automation.ExecutionContextForStepping(ctxt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 1173, 1210);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1658_1283_1300(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1283, 1300);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1658_1283_1311(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1283, 1311);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1658_1283_1344(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param)
                {
                    var return_v = this_param.GetInformationalMessageBuffers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 1283, 1344);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1658_1382_1399(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1382, 1399);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1658_1382_1412(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1382, 1412);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1658_1429_1446(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1429, 1446);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1658_1429_1457(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1429, 1457);
                    return return_v;
                }


                int
                f_1658_1429_1500(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.PSInformationalBuffers
                informationalBuffers)
                {
                    this_param.SetInformationalMessageBuffers(informationalBuffers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 1429, 1500);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1658_1515_1532(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1515, 1532);
                    return return_v;
                }


                int
                f_1658_1515_1552(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Host.PSHost
                psHost)
                {
                    this_param.SetHostRef(psHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 1515, 1552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 930, 1594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 930, 1594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void IDisposable.Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 1764, 2041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1815, 1919);

                f_1658_1815_1918(f_1658_1815_1856(f_1658_1815_1845(_executionContext)), _originalInformationalBuffers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 1933, 1990);

                f_1658_1933_1989(f_1658_1933_1963(_executionContext), _originalHost);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 2004, 2030);

                f_1658_2004_2029(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 1764, 2041);

                System.Management.Automation.Internal.Host.InternalHost
                f_1658_1815_1845(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1815, 1845);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1658_1815_1856(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1815, 1856);
                    return return_v;
                }


                int
                f_1658_1815_1918(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.PSInformationalBuffers
                informationalBuffers)
                {
                    this_param.SetInformationalMessageBuffers(informationalBuffers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 1815, 1918);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1658_1933_1963(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 1933, 1963);
                    return return_v;
                }


                int
                f_1658_1933_1989(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Host.PSHost
                psHost)
                {
                    this_param.SetHostRef(psHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 1933, 1989);
                    return 0;
                }


                int
                f_1658_2004_2029(System.Management.Automation.ExecutionContextForStepping
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 2004, 2029);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 1764, 2041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 1764, 2041);
            }
        }

        static ExecutionContextForStepping()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1658, 486, 2048);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1658, 486, 2048);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 486, 2048);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1658, 486, 2048);

        int
        f_1658_807_867(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 807, 867);
            return 0;
        }

    }
    internal class ServerSteppablePipelineDriver
    {
        private bool _addToHistory;

        private ApartmentState apartmentState;

        private ServerSteppablePipelineSubscriber _eventSubscriber;

        private PSDataCollection<object> _powershellInput;

        internal ServerSteppablePipelineDriver(PowerShell powershell, bool noInput, Guid clientPowerShellId,
                    Guid clientRunspacePoolId, ServerRunspacePoolDriver runspacePoolDriver,
                    ApartmentState apartmentState, HostInfo hostInfo, RemoteStreamOptions streamOptions,
                    bool addToHistory, Runspace rsToUse, ServerSteppablePipelineSubscriber eventSubscriber, PSDataCollection<object> powershellInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1658, 4726, 7122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 2748, 2761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 2839, 2853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 2999, 3015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 3059, 3075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 7257, 7301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 7648, 7693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 7823, 7880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 8388, 8463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 8562, 8624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 8740, 8770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 8868, 8926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9022, 9073);
                this.SyncObject = f_1658_9060_9072();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9163, 9206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9296, 9349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9439, 9487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9583, 9617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9714, 9762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5177, 5206);

                LocalPowerShell = powershell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5220, 5252);

                InstanceId = clientPowerShellId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5266, 5304);

                RunspacePoolId = clientRunspacePoolId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5318, 5354);

                RemoteStreamOptions = streamOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5368, 5405);

                this.apartmentState = apartmentState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5419, 5437);

                NoInput = noInput;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5451, 5480);

                _addToHistory = addToHistory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5494, 5529);

                _eventSubscriber = eventSubscriber;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5543, 5578);

                _powershellInput = powershellInput;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5594, 5633);

                Input = f_1658_5602_5632();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5647, 5687);

                InputEnumerator = f_1658_5665_5686(f_1658_5665_5670());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5701, 5735);

                f_1658_5701_5706().ReleaseOnEnumeration = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5751, 5920);

                DataStructureHandler = f_1658_5774_5919(f_1658_5774_5813(runspacePoolDriver), clientPowerShellId, clientRunspacePoolId, f_1658_5893_5912(), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 5934, 6047);

                RemoteHost = f_1658_5947_6046(f_1658_5947_5967(), hostInfo, f_1658_6010_6045(runspacePoolDriver));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6130, 6212);

                f_1658_6130_6150().InputEndReceived += new EventHandler(HandleInputEndReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6226, 6331);

                f_1658_6226_6246().InputReceived += new EventHandler<RemoteDataEventArgs<object>>(HandleInputReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6345, 6429);

                f_1658_6345_6365().StopPowerShellReceived += new EventHandler(HandleStopReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6443, 6591);

                f_1658_6443_6463().HostResponseReceived +=
                                new EventHandler<RemoteDataEventArgs<RemoteHostResponse>>(HandleHostResponseReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6605, 6689);

                f_1658_6605_6625().OnSessionConnected += new EventHandler(HandleSessionConnected);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6705, 6876) || true) && (rsToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 6705, 6876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6758, 6861);

                    throw f_1658_6764_6860(f_1658_6807_6859());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 6705, 6876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 6963, 6998);

                f_1658_6963_6978().Runspace = rsToUse;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 7012, 7050);

                f_1658_7012_7049(eventSubscriber, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 7066, 7111);

                PipelineState = PSInvocationState.NotStarted;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1658, 4726, 7122);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 4726, 7122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 4726, 7122);
            }
        }

        internal PowerShell LocalPowerShell { get; }

        internal Guid InstanceId { get; }

        internal ServerRemoteHost RemoteHost { get; }

        internal RemoteStreamOptions RemoteStreamOptions { get; }

        internal Guid RunspacePoolId { get; }

        internal ServerPowerShellDataStructureHandler DataStructureHandler { get; }

        internal PSInvocationState PipelineState { get; private set; }

        internal bool NoInput { get; }

        internal SteppablePipeline SteppablePipeline { get; set; }

        internal object SyncObject { get; }

        internal bool ProcessingInput { get; set; }

        internal IEnumerator<object> InputEnumerator { get; }

        internal PSDataCollection<object> Input { get; }

        internal bool Pulsed { get; set; }

        internal int TotalObjectsProcessed { get; set; }

        internal void Start()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 9857, 10140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9903, 9945);

                PipelineState = PSInvocationState.Running;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 9961, 10011);

                f_1658_9961_10010(
                            _eventSubscriber, this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 10027, 10129) || true) && (_powershellInput != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 10027, 10129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 10089, 10114);

                    f_1658_10089_10113(_powershellInput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 10027, 10129);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 9857, 10140);

                int
                f_1658_9961_10010(System.Management.Automation.ServerSteppablePipelineSubscriber
                this_param, System.Management.Automation.ServerSteppablePipelineDriver
                driver)
                {
                    this_param.FireStartSteppablePipeline(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 9961, 10010);
                    return 0;
                }


                int
                f_1658_10089_10113(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Pulse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 10089, 10113);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 9857, 10140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 9857, 10140);
            }
        }

        internal void HandleInputEndReceived(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 10522, 10814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 10619, 10636);

                f_1658_10619_10635(f_1658_10619_10624());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 10652, 10685);

                f_1658_10652_10684(this, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 10701, 10803) || true) && (_powershellInput != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 10701, 10803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 10763, 10788);

                    f_1658_10763_10787(_powershellInput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 10701, 10803);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 10522, 10814);

                System.Management.Automation.PSDataCollection<object>
                f_1658_10619_10624()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 10619, 10624);
                    return return_v;
                }


                int
                f_1658_10619_10635(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 10619, 10635);
                    return 0;
                }


                int
                f_1658_10652_10684(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, bool
                complete)
                {
                    this_param.CheckAndPulseForProcessing(complete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 10652, 10684);
                    return 0;
                }


                int
                f_1658_10763_10787(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Pulse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 10763, 10787);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 10522, 10814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 10522, 10814);
            }
        }

        private void HandleSessionConnected(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 10826, 11186);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 11092, 11175) || true) && (f_1658_11096_11101() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 11092, 11175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 11143, 11160);

                    f_1658_11143_11159(f_1658_11143_11148());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 11092, 11175);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 10826, 11186);

                System.Management.Automation.PSDataCollection<object>
                f_1658_11096_11101()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 11096, 11101);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1658_11143_11148()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 11143, 11148);
                    return return_v;
                }


                int
                f_1658_11143_11159(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 11143, 11159);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 10826, 11186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 10826, 11186);
            }
        }

        internal void HandleHostResponseReceived(object sender, RemoteDataEventArgs<RemoteHostResponse> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 11449, 11674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 11580, 11663);

                f_1658_11580_11662(f_1658_11580_11611(f_1658_11580_11590()), f_1658_11647_11661(eventArgs));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 11449, 11674);

                System.Management.Automation.Remoting.ServerRemoteHost
                f_1658_11580_11590()
                {
                    var return_v = RemoteHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 11580, 11590);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerMethodExecutor
                f_1658_11580_11611(System.Management.Automation.Remoting.ServerRemoteHost
                this_param)
                {
                    var return_v = this_param.ServerMethodExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 11580, 11611);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1658_11647_11661(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 11647, 11661);
                    return return_v;
                }


                int
                f_1658_11580_11662(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostResponse
                remoteHostResponse)
                {
                    this_param.HandleRemoteHostResponseFromClient(remoteHostResponse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 11580, 11662);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 11449, 11674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 11449, 11674);
            }
        }

        private void HandleStopReceived(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 11898, 12257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 11996, 12006);
                lock (f_1658_11996_12006())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12040, 12083);

                    PipelineState = PSInvocationState.Stopping;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12114, 12128);

                f_1658_12114_12127(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12144, 12246) || true) && (_powershellInput != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 12144, 12246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12206, 12231);

                    f_1658_12206_12230(_powershellInput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 12144, 12246);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 11898, 12257);

                object
                f_1658_11996_12006()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 11996, 12006);
                    return return_v;
                }


                int
                f_1658_12114_12127(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    this_param.PerformStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 12114, 12127);
                    return 0;
                }


                int
                f_1658_12206_12230(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Pulse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 12206, 12230);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 11898, 12257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 11898, 12257);
            }
        }

        private void HandleInputReceived(object sender, RemoteDataEventArgs<object> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 12533, 13124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12644, 12740);

                f_1658_12644_12739(f_1658_12655_12663_M(!NoInput), "Input data should not be received for powershells created with no input");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12756, 13113) || true) && (f_1658_12760_12765() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 12756, 13113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12813, 12823);
                    lock (f_1658_12813_12823())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12865, 12891);

                        f_1658_12865_12890(f_1658_12865_12870(), f_1658_12875_12889(eventArgs));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12930, 12964);

                    f_1658_12930_12963(this, false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 12984, 13098) || true) && (_powershellInput != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 12984, 13098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13054, 13079);

                        f_1658_13054_13078(_powershellInput);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 12984, 13098);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 12756, 13113);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 12533, 13124);

                bool
                f_1658_12655_12663_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 12655, 12663);
                    return return_v;
                }


                int
                f_1658_12644_12739(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 12644, 12739);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1658_12760_12765()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 12760, 12765);
                    return return_v;
                }


                object
                f_1658_12813_12823()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 12813, 12823);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1658_12865_12870()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 12865, 12870);
                    return return_v;
                }


                object
                f_1658_12875_12889(System.Management.Automation.RemoteDataEventArgs<object>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 12875, 12889);
                    return return_v;
                }


                int
                f_1658_12865_12890(System.Management.Automation.PSDataCollection<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 12865, 12890);
                    return 0;
                }


                int
                f_1658_12930_12963(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, bool
                complete)
                {
                    this_param.CheckAndPulseForProcessing(complete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 12930, 12963);
                    return 0;
                }


                int
                f_1658_13054_13078(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Pulse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 13054, 13078);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 12533, 13124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 12533, 13124);
            }
        }

        internal void CheckAndPulseForProcessing(bool complete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 13460, 14358);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13540, 14347) || true) && (complete)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 13540, 14347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13586, 13633);

                    f_1658_13586_13632(_eventSubscriber, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 13540, 14347);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 13540, 14347);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13667, 14347) || true) && (f_1658_13671_13678_M(!Pulsed))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 13667, 14347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13712, 13737);

                        bool
                        shouldPulse = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13761, 13771);
                        lock (f_1658_13761_13771())
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13813, 13903) || true) && (f_1658_13817_13823())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 13813, 13903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13873, 13880);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 13813, 13903);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 13927, 14122) || true) && (f_1658_13931_13947_M(!ProcessingInput) && (DynAbs.Tracing.TraceSender.Expression_True(1658, 13931, 13990) && ((f_1658_13953_13964(f_1658_13953_13958()) > f_1658_13967_13988()))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 13927, 14122);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14040, 14059);

                                shouldPulse = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14085, 14099);

                                Pulsed = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 13927, 14122);
                            }
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14161, 14332) || true) && (shouldPulse && (DynAbs.Tracing.TraceSender.Expression_True(1658, 14165, 14224) && (f_1658_14181_14194() == PSInvocationState.Running)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 14161, 14332);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14266, 14313);

                            f_1658_14266_14312(_eventSubscriber, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 14161, 14332);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 13667, 14347);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 13540, 14347);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 13460, 14358);

                int
                f_1658_13586_13632(System.Management.Automation.ServerSteppablePipelineSubscriber
                this_param, System.Management.Automation.ServerSteppablePipelineDriver
                driver)
                {
                    this_param.FireHandleProcessRecord(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 13586, 13632);
                    return 0;
                }


                bool
                f_1658_13671_13678_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 13671, 13678);
                    return return_v;
                }


                object
                f_1658_13761_13771()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 13761, 13771);
                    return return_v;
                }


                bool
                f_1658_13817_13823()
                {
                    var return_v = Pulsed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 13817, 13823);
                    return return_v;
                }


                bool
                f_1658_13931_13947_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 13931, 13947);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1658_13953_13958()
                {
                    var return_v = Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 13953, 13958);
                    return return_v;
                }


                int
                f_1658_13953_13964(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 13953, 13964);
                    return return_v;
                }


                int
                f_1658_13967_13988()
                {
                    var return_v = TotalObjectsProcessed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 13967, 13988);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1658_14181_14194()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 14181, 14194);
                    return return_v;
                }


                int
                f_1658_14266_14312(System.Management.Automation.ServerSteppablePipelineSubscriber
                this_param, System.Management.Automation.ServerSteppablePipelineDriver
                driver)
                {
                    this_param.FireHandleProcessRecord(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 14266, 14312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 13460, 14358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 13460, 14358);
            }
        }

        internal void PerformStop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 14459, 14941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14511, 14542);

                bool
                shouldPerformStop = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14562, 14572);
                lock (f_1658_14562_14572())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14606, 14761) || true) && (f_1658_14610_14626_M(!ProcessingInput) && (DynAbs.Tracing.TraceSender.Expression_True(1658, 14610, 14675) && (f_1658_14631_14644() == PSInvocationState.Stopping)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 14606, 14761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14717, 14742);

                        shouldPerformStop = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 14606, 14761);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14792, 14930) || true) && (shouldPerformStop)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 14792, 14930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 14847, 14915);

                    f_1658_14847_14914(this, PSInvocationState.Stopped, f_1658_14883_14913());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 14792, 14930);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 14459, 14941);

                object
                f_1658_14562_14572()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 14562, 14572);
                    return return_v;
                }


                bool
                f_1658_14610_14626_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 14610, 14626);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1658_14631_14644()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 14631, 14644);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1658_14883_14913()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 14883, 14913);
                    return return_v;
                }


                int
                f_1658_14847_14914(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.PSInvocationState
                newState, System.Management.Automation.PipelineStoppedException
                reason)
                {
                    this_param.SetState(newState, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 14847, 14914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 14459, 14941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 14459, 14941);
            }
        }

        internal void SetState(PSInvocationState newState, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1658, 15158, 19144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 15251, 15310);

                PSInvocationState
                copyState = PSInvocationState.NotStarted
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 15324, 15355);

                bool
                shouldRaiseEvents = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 15375, 15385);
                lock (f_1658_15375_15385())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 15419, 18446);

                    switch (f_1658_15427_15440())
                    {

                        case PSInvocationState.NotStarted:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 15419, 18446);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 15573, 16220);

                                switch (newState)
                                {

                                    case PSInvocationState.Running:
                                    case PSInvocationState.Stopping:
                                    case PSInvocationState.Completed:
                                    case PSInvocationState.Stopped:
                                    case PSInvocationState.Failed:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 15573, 16220);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 15986, 16007);

                                        copyState = newState;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1658, 16183, 16189);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 15573, 16220);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1658, 16275, 16281);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 15419, 18446);

                        case PSInvocationState.Running:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 15419, 18446);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 16393, 17256);

                                switch (newState)
                                {

                                    case PSInvocationState.NotStarted:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 16393, 17256);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 16547, 16585);

                                        throw f_1658_16553_16584();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 16393, 17256);

                                    case PSInvocationState.Running:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 16393, 17256);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1658, 16688, 16694);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 16393, 17256);

                                    case PSInvocationState.Stopping:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 16393, 17256);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 16798, 16819);

                                        copyState = newState;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1658, 16857, 16863);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 16393, 17256);

                                    case PSInvocationState.Completed:
                                    case PSInvocationState.Stopped:
                                    case PSInvocationState.Failed:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 16393, 17256);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 17097, 17118);

                                        copyState = newState;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 17156, 17181);

                                        shouldRaiseEvents = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1658, 17219, 17225);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 16393, 17256);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1658, 17311, 17317);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 15419, 18446);

                        case PSInvocationState.Stopping:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 15419, 18446);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 17430, 18172);

                                switch (newState)
                                {

                                    case PSInvocationState.Completed:
                                    case PSInvocationState.Failed:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 17430, 18172);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 17647, 17685);

                                        copyState = PSInvocationState.Stopped;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 17723, 17748);

                                        shouldRaiseEvents = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1658, 17786, 17792);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 17430, 18172);

                                    case PSInvocationState.Stopped:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 17430, 18172);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 17895, 17916);

                                        copyState = newState;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 17954, 17979);

                                        shouldRaiseEvents = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1658, 18017, 18023);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 17430, 18172);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 17430, 18172);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 18103, 18141);

                                        throw f_1658_18109_18140();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 17430, 18172);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1658, 18227, 18233);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 15419, 18446);

                        case PSInvocationState.Stopped:
                        case PSInvocationState.Completed:
                        case PSInvocationState.Failed:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 15419, 18446);
                            DynAbs.Tracing.TraceSender.TraceBreak(1658, 18421, 18427);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 15419, 18446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 18466, 18492);

                    PipelineState = copyState;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 18523, 18787) || true) && (shouldRaiseEvents)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 18523, 18787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 18647, 18772);

                    f_1658_18647_18771(f_1658_18647_18667(), f_1658_18726_18770(copyState, reason));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 18523, 18787);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 18803, 19133) || true) && (f_1658_18807_18820() == PSInvocationState.Completed
                || (DynAbs.Tracing.TraceSender.Expression_False(1658, 18807, 18914) || f_1658_18872_18885() == PSInvocationState.Stopped
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1658, 18807, 18976) || f_1658_18935_18948() == PSInvocationState.Failed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1658, 18803, 19133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1658, 19067, 19118);

                    f_1658_19067_19117(f_1658_19067_19087());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1658, 18803, 19133);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1658, 15158, 19144);

                object
                f_1658_15375_15385()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 15375, 15385);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1658_15427_15440()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 15427, 15440);
                    return return_v;
                }


                System.InvalidOperationException
                f_1658_16553_16584()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 16553, 16584);
                    return return_v;
                }


                System.InvalidOperationException
                f_1658_18109_18140()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 18109, 18140);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1658_18647_18667()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 18647, 18667);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1658_18726_18770(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 18726, 18770);
                    return return_v;
                }


                int
                f_1658_18647_18771(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.SendStateChangedInformationToClient(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 18647, 18771);
                    return 0;
                }


                System.Management.Automation.PSInvocationState
                f_1658_18807_18820()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 18807, 18820);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1658_18872_18885()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 18872, 18885);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1658_18935_18948()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 18935, 18948);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1658_19067_19087()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 19067, 19087);
                    return return_v;
                }


                int
                f_1658_19067_19117(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    this_param.RaiseRemoveAssociationEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 19067, 19117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1658, 15158, 19144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 15158, 19144);
            }
        }

        static ServerSteppablePipelineDriver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1658, 2215, 19173);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1658, 2215, 19173);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1658, 2215, 19173);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1658, 2215, 19173);

        System.Management.Automation.PSDataCollection<object>
        f_1658_5602_5632()
        {
            var return_v = new System.Management.Automation.PSDataCollection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 5602, 5632);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<object>
        f_1658_5665_5670()
        {
            var return_v = Input;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 5665, 5670);
            return return_v;
        }


        System.Collections.Generic.IEnumerator<object>
        f_1658_5665_5686(System.Management.Automation.PSDataCollection<object>
        this_param)
        {
            var return_v = this_param.GetEnumerator();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 5665, 5686);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<object>
        f_1658_5701_5706()
        {
            var return_v = Input;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 5701, 5706);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1658_5774_5813(System.Management.Automation.ServerRunspacePoolDriver
        this_param)
        {
            var return_v = this_param.DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 5774, 5813);
            return return_v;
        }


        System.Management.Automation.RemoteStreamOptions
        f_1658_5893_5912()
        {
            var return_v = RemoteStreamOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 5893, 5912);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1658_5774_5919(System.Management.Automation.ServerRunspacePoolDataStructureHandler
        this_param, System.Guid
        instanceId, System.Guid
        runspacePoolId, System.Management.Automation.RemoteStreamOptions
        remoteStreamOptions, System.Management.Automation.PowerShell
        localPowerShell)
        {
            var return_v = this_param.CreatePowerShellDataStructureHandler(instanceId, runspacePoolId, remoteStreamOptions, localPowerShell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 5774, 5919);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1658_5947_5967()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 5947, 5967);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteHost
        f_1658_6010_6045(System.Management.Automation.ServerRunspacePoolDriver
        this_param)
        {
            var return_v = this_param.ServerRemoteHost;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6010, 6045);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteHost
        f_1658_5947_6046(System.Management.Automation.ServerPowerShellDataStructureHandler
        this_param, System.Management.Automation.Remoting.HostInfo
        powerShellHostInfo, System.Management.Automation.Remoting.ServerRemoteHost
        runspaceServerRemoteHost)
        {
            var return_v = this_param.GetHostAssociatedWithPowerShell(powerShellHostInfo, runspaceServerRemoteHost);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 5947, 6046);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1658_6130_6150()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6130, 6150);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1658_6226_6246()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6226, 6246);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1658_6345_6365()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6345, 6365);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1658_6443_6463()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6443, 6463);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1658_6605_6625()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6605, 6625);
            return return_v;
        }


        string
        f_1658_6807_6859()
        {
            var return_v = RemotingErrorIdStrings.NestedPipelineMissingRunspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6807, 6859);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1658_6764_6860(string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 6764, 6860);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1658_6963_6978()
        {
            var return_v = LocalPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1658, 6963, 6978);
            return return_v;
        }


        int
        f_1658_7012_7049(System.Management.Automation.ServerSteppablePipelineSubscriber
        this_param, System.Management.Automation.ServerSteppablePipelineDriver
        driver)
        {
            this_param.SubscribeEvents(driver);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 7012, 7049);
            return 0;
        }


        object
        f_1658_9060_9072()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1658, 9060, 9072);
            return return_v;
        }

    }
}
