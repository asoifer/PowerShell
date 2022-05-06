// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Security;
using System.Security.Principal;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    /// <summary>
    /// Interface exposing driver single thread invoke enter/exit
    /// nested pipeline.
    /// </summary>
    internal interface IRSPDriverInvoke
    {

        void EnterNestedPipeline();

        void ExitNestedPipeline();

        bool HandleStopSignal();
    }
    internal class ServerRunspacePoolDriver : IRSPDriverInvoke
    {
        private readonly string _initialLocation;

        private ConfigurationDataFromXML _configData;

        private PSPrimitiveDictionary _applicationPrivateData;

        private Dictionary<Guid, ServerPowerShellDriver> _associatedShells
        ;

        private ServerDriverRemoteHost _remoteHost;

        private bool _isClosed;

        private RemoteSessionCapability _serverCapability;

        private Runspace _rsToUseForSteppablePipeline;

        private ServerSteppablePipelineSubscriber _eventSubscriber;

        private PSDataCollection<object> _inputCollection;

        private PowerShellDriverInvoker _driverNestedInvoker;

        private ServerRemoteDebugger _serverRemoteDebugger;

        private Version _clientPSVersion;

        private string _configurationName;

        internal EventHandler<EventArgs> Closed;

        internal ServerRunspacePoolDriver(
                    Guid clientRunspacePoolId,
                    int minRunspaces,
                    int maxRunspaces,
                    PSThreadOptions threadOptions,
                    ApartmentState apartmentState,
                    HostInfo hostInfo,
                    InitialSessionState initialSessionState,
                    PSPrimitiveDictionary applicationPrivateData,
                    ConfigurationDataFromXML configData,
                    AbstractServerSessionTransportManager transportManager,
                    bool isAdministrator,
                    RemoteSessionCapability serverCapability,
                    Version psClientVersion,
                    string configurationName,
                    string initialLocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 5617, 11006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 1498, 1514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 1644, 1655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 1797, 1820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 2150, 2229);
                this._associatedShells = f_1657_2183_2229();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 2331, 2342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 2368, 2377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 2522, 2539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 2567, 2595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 2717, 2775);
                this._eventSubscriber = f_1657_2736_2775();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 2819, 2835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 3007, 3027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 3117, 3138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 3209, 3225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 3474, 3492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 3653, 3659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 11203, 11280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 11779, 11835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42146, 42206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42232, 42311);
                this._initialSessionStateIncludesGetCommandWithListImportedSwitchLock = f_1657_42299_42311();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6334, 6401);

                f_1657_6334_6400(configData != null, "ConfigurationData cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6417, 6454);

                _serverCapability = serverCapability;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6468, 6503);

                _clientPSVersion = psClientVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6519, 6558);

                _configurationName = configurationName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6572, 6607);

                _initialLocation = initialLocation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6720, 6847);

                _remoteHost = f_1657_6734_6846(clientRunspacePoolId, Guid.Empty, hostInfo, transportManager, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6863, 6888);

                _configData = configData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6902, 6951);

                _applicationPrivateData = applicationPrivateData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 6965, 7097);

                RunspacePool = f_1657_6980_7096(minRunspaces, maxRunspaces, initialSessionState, _remoteHost);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 7446, 7596);

                PSThreadOptions
                serverThreadOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(1657, 7484, 7522) || ((f_1657_7484_7522(configData.ShellThreadOptions) && DynAbs.Tracing.TraceSender.Conditional_F2(1657, 7525, 7560)) || DynAbs.Tracing.TraceSender.Conditional_F3(1657, 7563, 7595))) ? f_1657_7525_7560(configData.ShellThreadOptions) : PSThreadOptions.UseCurrentThread
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 7610, 8145) || true) && (threadOptions == PSThreadOptions.Default || (DynAbs.Tracing.TraceSender.Expression_False(1657, 7614, 7694) || threadOptions == serverThreadOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 7610, 8145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 7728, 7777);

                    f_1657_7728_7740().ThreadOptions = serverThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 7610, 8145);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 7610, 8145);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 7843, 8067) || true) && (!isAdministrator)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 7843, 8067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 7905, 8048);

                        throw f_1657_7911_8047(f_1657_7941_8046(f_1657_7988_8045()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 7843, 8067);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 8087, 8130);

                    f_1657_8087_8099().ThreadOptions = threadOptions;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 7610, 8145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 8225, 8387);

                ApartmentState
                serverApartmentState = (DynAbs.Tracing.TraceSender.Conditional_F1(1657, 8263, 8308) || ((f_1657_8263_8308(configData.ShellThreadApartmentState) && DynAbs.Tracing.TraceSender.Conditional_F2(1657, 8311, 8353)) || DynAbs.Tracing.TraceSender.Conditional_F3(1657, 8356, 8386))) ? f_1657_8311_8353(configData.ShellThreadApartmentState) : Runspace.DefaultApartmentState
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 8403, 8700) || true) && (apartmentState == ApartmentState.Unknown || (DynAbs.Tracing.TraceSender.Expression_False(1657, 8407, 8489) || apartmentState == serverApartmentState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 8403, 8700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 8523, 8574);

                    f_1657_8523_8535().ApartmentState = serverApartmentState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 8403, 8700);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 8403, 8700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 8640, 8685);

                    f_1657_8640_8652().ApartmentState = apartmentState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 8403, 8700);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 8876, 9159) || true) && (maxRunspaces == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1657, 8880, 9057) && (f_1657_8919_8945(f_1657_8919_8931()) == PSThreadOptions.Default || (DynAbs.Tracing.TraceSender.Expression_False(1657, 8919, 9056) || f_1657_8994_9020(f_1657_8994_9006()) == PSThreadOptions.UseCurrentThread))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 8876, 9159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 9091, 9144);

                    _driverNestedInvoker = f_1657_9114_9143();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 8876, 9159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 9175, 9209);

                InstanceId = clientRunspacePoolId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 9223, 9313);

                DataStructureHandler = f_1657_9246_9312(this, transportManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 9396, 9526);

                f_1657_9396_9408().StateChanged +=
                                new EventHandler<RunspacePoolStateChangedEventArgs>(HandleRunspacePoolStateChanged);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 9597, 9705);

                f_1657_9597_9609().ForwardEvent +=
                                new EventHandler<PSEventArgs>(HandleRunspacePoolForwardEvent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 9721, 9775);

                f_1657_9721_9733().RunspaceCreated += HandleRunspaceCreated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 9867, 10033);

                f_1657_9867_9887().CreateAndInvokePowerShell +=
                                new EventHandler<RemoteDataEventArgs<RemoteDataObject<PSObject>>>(HandleCreateAndInvokePowerShell);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 10047, 10199);

                f_1657_10047_10067().GetCommandMetadata +=
                                new EventHandler<RemoteDataEventArgs<RemoteDataObject<PSObject>>>(HandleGetCommandMetadata);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 10213, 10361);

                f_1657_10213_10233().HostResponseReceived +=
                                new EventHandler<RemoteDataEventArgs<RemoteHostResponse>>(HandleHostResponseReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 10375, 10519);

                f_1657_10375_10395().SetMaxRunspacesReceived +=
                                new EventHandler<RemoteDataEventArgs<PSObject>>(HandleSetMaxRunspacesReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 10533, 10677);

                f_1657_10533_10553().SetMinRunspacesReceived +=
                                new EventHandler<RemoteDataEventArgs<PSObject>>(HandleSetMinRunspacesReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 10691, 10847);

                f_1657_10691_10711().GetAvailableRunspacesReceived +=
                                new EventHandler<RemoteDataEventArgs<PSObject>>(HandleGetAvailableRunspacesReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 10861, 10995);

                f_1657_10861_10881().ResetRunspaceState +=
                                new EventHandler<RemoteDataEventArgs<PSObject>>(HandleResetRunspaceState);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 5617, 11006);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 5617, 11006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 5617, 11006);
            }
        }

        internal ServerRunspacePoolDataStructureHandler DataStructureHandler { get; }

        internal ServerRemoteHost ServerRemoteHost
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 11470, 11497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 11476, 11495);

                    return _remoteHost;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 11470, 11497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 11403, 11508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 11403, 11508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Guid InstanceId { get; }

        internal RunspacePool RunspacePool { get; private set; }

        internal void Start()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 11994, 12110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 12079, 12099);

                f_1657_12079_12098(f_1657_12079_12091());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 11994, 12110);

                System.Management.Automation.Runspaces.RunspacePool
                f_1657_12079_12091()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 12079, 12091);
                    return return_v;
                }


                int
                f_1657_12079_12098(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 12079, 12098);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 11994, 12110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 11994, 12110);
            }
        }

        internal void SendApplicationPrivateDataToClient()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 12347, 15456);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 12470, 12608) || true) && (_applicationPrivateData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 12470, 12608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 12539, 12593);

                    _applicationPrivateData = f_1657_12565_12592();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 12470, 12608);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 12624, 15329) || true) && (_serverRemoteDebugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 12624, 15329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 12731, 12786);

                    DebugModes
                    debugMode = f_1657_12754_12785(_serverRemoteDebugger)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 12804, 13170) || true) && (f_1657_12808_12876(_applicationPrivateData, RemoteDebugger.DebugModeSetting))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 12804, 13170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 12918, 12992);

                        _applicationPrivateData[RemoteDebugger.DebugModeSetting] = (int)debugMode;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 12804, 13170);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 12804, 13170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13074, 13151);

                        f_1657_13074_13150(_applicationPrivateData, RemoteDebugger.DebugModeSetting, debugMode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 12804, 13170);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13231, 13286);

                    bool
                    inBreakpoint = f_1657_13251_13285(_serverRemoteDebugger)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13304, 13660) || true) && (f_1657_13308_13374(_applicationPrivateData, RemoteDebugger.DebugStopState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 13304, 13660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13416, 13486);

                        _applicationPrivateData[RemoteDebugger.DebugStopState] = inBreakpoint;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 13304, 13660);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 13304, 13660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13568, 13641);

                        f_1657_13568_13640(_applicationPrivateData, RemoteDebugger.DebugStopState, inBreakpoint);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 13304, 13660);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13732, 13797);

                    int
                    breakpointCount = f_1657_13754_13796(_serverRemoteDebugger)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13815, 14195) || true) && (f_1657_13819_13891(_applicationPrivateData, RemoteDebugger.DebugBreakpointCount))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 13815, 14195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 13933, 14012);

                        _applicationPrivateData[RemoteDebugger.DebugBreakpointCount] = breakpointCount;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 13815, 14195);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 13815, 14195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 14094, 14176);

                        f_1657_14094_14175(_applicationPrivateData, RemoteDebugger.DebugBreakpointCount, breakpointCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 13815, 14195);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 14277, 14341);

                    bool
                    breakAll = f_1657_14293_14340(_serverRemoteDebugger)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 14359, 14710) || true) && (f_1657_14363_14430(_applicationPrivateData, RemoteDebugger.BreakAllSetting))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 14359, 14710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 14472, 14539);

                        _applicationPrivateData[RemoteDebugger.BreakAllSetting] = breakAll;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 14359, 14710);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 14359, 14710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 14621, 14691);

                        f_1657_14621_14690(_applicationPrivateData, RemoteDebugger.BreakAllSetting, breakAll);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 14359, 14710);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 14805, 14894);

                    UnhandledBreakpointProcessingMode
                    bpMode = f_1657_14848_14893(_serverRemoteDebugger)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 14912, 15314) || true) && (f_1657_14916_14998(_applicationPrivateData, RemoteDebugger.UnhandledBreakpointModeSetting))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 14912, 15314);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15040, 15125);

                        _applicationPrivateData[RemoteDebugger.UnhandledBreakpointModeSetting] = (int)bpMode;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 14912, 15314);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 14912, 15314);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15207, 15295);

                        f_1657_15207_15294(_applicationPrivateData, RemoteDebugger.UnhandledBreakpointModeSetting, bpMode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 14912, 15314);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 12624, 15329);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15345, 15445);

                f_1657_15345_15444(f_1657_15345_15365(), _applicationPrivateData, _serverCapability);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 12347, 15456);

                System.Management.Automation.PSPrimitiveDictionary
                f_1657_12565_12592()
                {
                    var return_v = new System.Management.Automation.PSPrimitiveDictionary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 12565, 12592);
                    return return_v;
                }


                System.Management.Automation.DebugModes
                f_1657_12754_12785(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.DebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 12754, 12785);
                    return return_v;
                }


                bool
                f_1657_12808_12876(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 12808, 12876);
                    return return_v;
                }


                int
                f_1657_13074_13150(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key, System.Management.Automation.DebugModes
                value)
                {
                    this_param.Add(key, (int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 13074, 13150);
                    return 0;
                }


                bool
                f_1657_13251_13285(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 13251, 13285);
                    return return_v;
                }


                bool
                f_1657_13308_13374(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 13308, 13374);
                    return return_v;
                }


                int
                f_1657_13568_13640(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key, bool
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 13568, 13640);
                    return 0;
                }


                int
                f_1657_13754_13796(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.GetBreakpointCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 13754, 13796);
                    return return_v;
                }


                bool
                f_1657_13819_13891(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 13819, 13891);
                    return return_v;
                }


                int
                f_1657_14094_14175(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 14094, 14175);
                    return 0;
                }


                bool
                f_1657_14293_14340(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.IsDebuggerSteppingEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 14293, 14340);
                    return return_v;
                }


                bool
                f_1657_14363_14430(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 14363, 14430);
                    return return_v;
                }


                int
                f_1657_14621_14690(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key, bool
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 14621, 14690);
                    return 0;
                }


                System.Management.Automation.UnhandledBreakpointProcessingMode
                f_1657_14848_14893(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.UnhandledBreakpointMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 14848, 14893);
                    return return_v;
                }


                bool
                f_1657_14916_14998(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 14916, 14998);
                    return return_v;
                }


                int
                f_1657_15207_15294(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key, System.Management.Automation.UnhandledBreakpointProcessingMode
                value)
                {
                    this_param.Add(key, (int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 15207, 15294);
                    return 0;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_15345_15365()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 15345, 15365);
                    return return_v;
                }


                int
                f_1657_15345_15444(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.PSPrimitiveDictionary
                applicationPrivateData, System.Management.Automation.Remoting.RemoteSessionCapability
                serverCapability)
                {
                    this_param.SendApplicationPrivateDataToClient(applicationPrivateData, serverCapability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 15345, 15444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 12347, 15456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 12347, 15456);
            }
        }

        internal void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 15592, 16933);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15638, 16922) || true) && (!_isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 15638, 16922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15686, 15703);

                    _isClosed = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15723, 16099) || true) && ((_remoteHost != null) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 15727, 15782) && (f_1657_15753_15781(_remoteHost))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 15723, 16099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15824, 15880);

                        Runspace
                        runspaceToDispose = f_1657_15853_15879(_remoteHost)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15902, 15928);

                        f_1657_15902_15927(_remoteHost);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 15950, 16080) || true) && (runspaceToDispose != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 15950, 16080);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16029, 16057);

                            f_1657_16029_16056(runspaceToDispose);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 15950, 16080);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 15723, 16099);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16119, 16143);

                    f_1657_16119_16142(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16163, 16184);

                    f_1657_16163_16183(f_1657_16163_16175());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16202, 16348);

                    f_1657_16202_16214().StateChanged -=
                                                    new EventHandler<RunspacePoolStateChangedEventArgs>(HandleRunspacePoolStateChanged);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16366, 16490);

                    f_1657_16366_16378().ForwardEvent -=
                                                    new EventHandler<PSEventArgs>(HandleRunspacePoolForwardEvent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16508, 16531);

                    f_1657_16508_16530(f_1657_16508_16520());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16549, 16569);

                    RunspacePool = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16589, 16846) || true) && (_rsToUseForSteppablePipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 16589, 16846);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16671, 16708);

                        f_1657_16671_16707(_rsToUseForSteppablePipeline);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16730, 16769);

                        f_1657_16730_16768(_rsToUseForSteppablePipeline);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16791, 16827);

                        _rsToUseForSteppablePipeline = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 16589, 16846);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 16866, 16907);

                    f_1657_16866_16906(
                                    Closed, this, EventArgs.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 15638, 16922);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 15592, 16933);

                bool
                f_1657_15753_15781(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.IsRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 15753, 15781);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_15853_15879(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.PushedRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 15853, 15879);
                    return return_v;
                }


                int
                f_1657_15902_15927(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    this_param.PopRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 15902, 15927);
                    return 0;
                }


                int
                f_1657_16029_16056(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 16029, 16056);
                    return 0;
                }


                int
                f_1657_16119_16142(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    this_param.DisposeRemoteDebugger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 16119, 16142);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_16163_16175()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 16163, 16175);
                    return return_v;
                }


                int
                f_1657_16163_16183(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 16163, 16183);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_16202_16214()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 16202, 16214);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_16366_16378()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 16366, 16378);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_16508_16520()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 16508, 16520);
                    return return_v;
                }


                int
                f_1657_16508_16530(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 16508, 16530);
                    return 0;
                }


                int
                f_1657_16671_16707(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 16671, 16707);
                    return 0;
                }


                int
                f_1657_16730_16768(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 16730, 16768);
                    return 0;
                }


                int
                f_1657_16866_16906(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.ServerRunspacePoolDriver
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 16866, 16906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 15592, 16933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 15592, 16933);
            }
        }

        public void EnterNestedPipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 17313, 17599);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 17371, 17537) || true) && (_driverNestedInvoker == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 17371, 17537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 17437, 17522);

                    throw f_1657_17443_17521(f_1657_17471_17520());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 17371, 17537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 17553, 17588);

                f_1657_17553_17587(
                            _driverNestedInvoker);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 17313, 17599);

                string
                f_1657_17471_17520()
                {
                    var return_v = RemotingErrorIdStrings.NestedPipelineNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 17471, 17520);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1657_17443_17521(string
                message)
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 17443, 17521);
                    return return_v;
                }


                int
                f_1657_17553_17587(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker
                this_param)
                {
                    this_param.PushInvoker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 17553, 17587);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 17313, 17599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 17313, 17599);
            }
        }

        public void ExitNestedPipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 17775, 18059);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 17832, 17998) || true) && (_driverNestedInvoker == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 17832, 17998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 17898, 17983);

                    throw f_1657_17904_17982(f_1657_17932_17981());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 17832, 17998);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 18014, 18048);

                f_1657_18014_18047(
                            _driverNestedInvoker);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 17775, 18059);

                string
                f_1657_17932_17981()
                {
                    var return_v = RemotingErrorIdStrings.NestedPipelineNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 17932, 17981);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1657_17904_17982(string
                message)
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 17904, 17982);
                    return return_v;
                }


                int
                f_1657_18014_18047(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker
                this_param)
                {
                    this_param.PopInvoker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 18014, 18047);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 17775, 18059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 17775, 18059);
            }
        }

        public bool HandleStopSignal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 18478, 18703);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 18533, 18663) || true) && (_serverRemoteDebugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 18533, 18663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 18600, 18648);

                    return f_1657_18607_18647(_serverRemoteDebugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 18533, 18663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 18679, 18692);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 18478, 18703);

                bool
                f_1657_18607_18647(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.HandleStopSignal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 18607, 18647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 18478, 18703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 18478, 18703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleRunspaceCreatedForTypeTable(object sender, RunspaceCreatedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 19083, 20120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19200, 19274);

                f_1657_19200_19220().TypeTable = f_1657_19233_19273(f_1657_19233_19263(f_1657_19233_19246(args)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19288, 19333);

                _rsToUseForSteppablePipeline = f_1657_19319_19332(args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19349, 19399);

                f_1657_19349_19398(this, _rsToUseForSteppablePipeline);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19415, 20109) || true) && (!f_1657_19420_19460(_configurationName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 19415, 20109);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19639, 20094) || true) && ((_remoteHost != null) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 19643, 19699) && f_1657_19668_19699_M(!(f_1657_19670_19698(_remoteHost)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 19639, 20094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19791, 19895);

                        RemoteRunspace
                        remoteRunspace = f_1657_19823_19894(_configurationName, _remoteHost)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19919, 19956);

                        _remoteHost.AllowPushRunspace = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 19978, 20010);

                        _remoteHost.PropagatePop = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 20034, 20075);

                        f_1657_20034_20074(
                                            _remoteHost, remoteRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 19639, 20094);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 19415, 20109);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 19083, 20120);

                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_19200_19220()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 19200, 19220);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_19233_19246(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 19233, 19246);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1657_19233_19263(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 19233, 19263);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1657_19233_19273(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 19233, 19273);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_19319_19332(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 19319, 19332);
                    return return_v;
                }


                int
                f_1657_19349_19398(System.Management.Automation.ServerRunspacePoolDriver
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.SetupRemoteDebugger(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 19349, 19398);
                    return 0;
                }


                bool
                f_1657_19420_19460(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 19420, 19460);
                    return return_v;
                }


                bool
                f_1657_19670_19698(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.IsRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 19670, 19698);
                    return return_v;
                }


                bool
                f_1657_19668_19699_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 19668, 19699);
                    return return_v;
                }


                System.Management.Automation.RemoteRunspace
                f_1657_19823_19894(string
                configurationName, System.Management.Automation.Remoting.ServerDriverRemoteHost
                host)
                {
                    var return_v = HostUtilities.CreateConfiguredRunspace(configurationName, (System.Management.Automation.Host.PSHost)host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 19823, 19894);
                    return return_v;
                }


                int
                f_1657_20034_20074(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param, System.Management.Automation.RemoteRunspace
                runspace)
                {
                    this_param.PushRunspace((System.Management.Automation.Runspaces.Runspace)runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 20034, 20074);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 19083, 20120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 19083, 20120);
            }
        }

        private void SetupRemoteDebugger(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 20132, 21428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 20208, 20339);

                CmdletInfo
                cmdletInfo = f_1657_20232_20338(f_1657_20232_20284(f_1657_20232_20270(f_1657_20232_20257(runspace))), ServerRemoteDebugger.SetPSBreakCommandText)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 20353, 20847) || true) && (cmdletInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 20353, 20847);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 20409, 20635) || true) && ((f_1657_20414_20452(f_1657_20414_20439(runspace)) != PSLanguageMode.FullLanguage) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 20413, 20567) && (f_1657_20510_20566_M(!f_1657_20511_20536(runspace).UseFullLanguageModeInDebugger))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 20409, 20635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 20609, 20616);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 20409, 20635);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 20353, 20847);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 20353, 20847);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 20701, 20832) || true) && (f_1657_20705_20726(cmdletInfo) != SessionStateEntryVisibility.Public)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 20701, 20832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 20806, 20813);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 20701, 20832);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 20353, 20847);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 21017, 21417) || true) && ((_driverNestedInvoker != null) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 21021, 21147) && (_clientPSVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1657, 21073, 21146) && _clientPSVersion >= f_1657_21121_21146()))) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 21021, 21215) && (runspace != null && (DynAbs.Tracing.TraceSender.Expression_True(1657, 21169, 21214) && f_1657_21189_21206(runspace) != null))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 21017, 21417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 21249, 21333);

                    _serverRemoteDebugger = f_1657_21273_21332(this, runspace, f_1657_21314_21331(runspace));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 21351, 21402);

                    _remoteHost.ServerDebugger = _serverRemoteDebugger;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 21017, 21417);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 20132, 21428);

                System.Management.Automation.ExecutionContext
                f_1657_20232_20257(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20232, 20257);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1657_20232_20270(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20232, 20270);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1657_20232_20284(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20232, 20284);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1657_20232_20338(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName)
                {
                    var return_v = this_param.GetCmdlet(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 20232, 20338);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1657_20414_20439(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20414, 20439);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1657_20414_20452(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20414, 20452);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1657_20511_20536(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20511, 20536);
                    return return_v;
                }


                bool
                f_1657_20510_20566_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20510, 20566);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1657_20705_20726(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 20705, 20726);
                    return return_v;
                }


                System.Version
                f_1657_21121_21146()
                {
                    var return_v = PSVersionInfo.PSV4Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 21121, 21146);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_21189_21206(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 21189, 21206);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_21314_21331(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 21314, 21331);
                    return return_v;
                }


                System.Management.Automation.ServerRemoteDebugger
                f_1657_21273_21332(System.Management.Automation.ServerRunspacePoolDriver
                driverInvoker, System.Management.Automation.Runspaces.Runspace
                runspace, System.Management.Automation.Debugger
                debugger)
                {
                    var return_v = new System.Management.Automation.ServerRemoteDebugger((System.Management.Automation.IRSPDriverInvoke)driverInvoker, runspace, debugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 21273, 21332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 20132, 21428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 20132, 21428);
            }
        }

        private void DisposeRemoteDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 21440, 21626);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 21501, 21615) || true) && (_serverRemoteDebugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 21501, 21615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 21568, 21600);

                    f_1657_21568_21599(_serverRemoteDebugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 21501, 21615);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 21440, 21626);

                int
                f_1657_21568_21599(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 21568, 21599);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 21440, 21626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 21440, 21626);
            }
        }

        private PSDataCollection<PSObject> InvokeScript(Command cmdToRun, RunspaceCreatedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 21835, 22602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 21956, 22017);

                f_1657_21956_22016(cmdToRun != null, "cmdToRun shouldn't be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 22159, 22308);

                cmdToRun.CommandOrigin = (DynAbs.Tracing.TraceSender.Conditional_F1(1657, 22184, 22257) || (((f_1657_22185_22223() == SystemEnforcementMode.Enforce) && DynAbs.Tracing.TraceSender.Conditional_F2(1657, 22260, 22282)) || DynAbs.Tracing.TraceSender.Conditional_F3(1657, 22285, 22307))) ? CommandOrigin.Runspace : CommandOrigin.Internal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 22324, 22403);

                f_1657_22324_22402(
                            cmdToRun, PipelineResultTypes.Error, PipelineResultTypes.Output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 22417, 22461);

                PowerShell
                powershell = f_1657_22441_22460()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 22475, 22533);

                f_1657_22475_22532(f_1657_22475_22506(powershell, cmdToRun), "out-default");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 22549, 22591);

                return f_1657_22556_22590(this, powershell, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 21835, 22602);

                int
                f_1657_21956_22016(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 21956, 22016);
                    return 0;
                }


                System.Management.Automation.Security.SystemEnforcementMode
                f_1657_22185_22223()
                {
                    var return_v = SystemPolicy.GetSystemLockdownPolicy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 22185, 22223);
                    return return_v;
                }


                int
                f_1657_22324_22402(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                myResult, System.Management.Automation.Runspaces.PipelineResultTypes
                toResult)
                {
                    this_param.MergeMyResults(myResult, toResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 22324, 22402);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1657_22441_22460()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 22441, 22460);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_22475_22506(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 22475, 22506);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_22475_22532(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 22475, 22532);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1657_22556_22590(System.Management.Automation.ServerRunspacePoolDriver
                this_param, System.Management.Automation.PowerShell
                powershell, System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                args)
                {
                    var return_v = this_param.InvokePowerShell(powershell, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 22556, 22590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 21835, 22602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 21835, 22602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSDataCollection<PSObject> InvokePowerShell(PowerShell powershell, RunspaceCreatedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 22826, 25134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 22956, 23021);

                f_1657_22956_23020(powershell != null, "powershell shouldn't be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 23099, 23140);

                HostInfo
                hostInfo = f_1657_23119_23139(_remoteHost)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 23154, 23561);

                ServerPowerShellDriver
                driver = f_1657_23186_23560(powershell, null, true, Guid.Empty, f_1657_23335_23350(this), this, f_1657_23392_23420(f_1657_23392_23405(args)), hostInfo, RemoteStreamOptions.AddInvocationInfo, false, f_1657_23546_23559(args))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 23577, 23619);

                IAsyncResult
                asyncResult = f_1657_23604_23618(driver)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 23785, 23856);

                PSDataCollection<PSObject>
                results = f_1657_23822_23855(powershell, asyncResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24046, 24139);

                ArrayList
                errorList = (ArrayList)f_1657_24079_24138(f_1657_24079_24118(f_1657_24079_24098(powershell)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24153, 25092) || true) && (f_1657_24157_24172(errorList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 24153, 25092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24210, 24233);

                    string
                    exceptionThrown
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24251, 24309);

                    ErrorRecord
                    lastErrorRecord = f_1657_24281_24293(errorList, 0) as ErrorRecord
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24327, 24932) || true) && (lastErrorRecord != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 24327, 24932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24396, 24441);

                        exceptionThrown = f_1657_24414_24440(lastErrorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 24327, 24932);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 24327, 24932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24523, 24575);

                        Exception
                        lastException = f_1657_24549_24561(errorList, 0) as Exception
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24597, 24913) || true) && (lastException != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 24597, 24913);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24672, 24761);

                            exceptionThrown = (DynAbs.Tracing.TraceSender.Conditional_F1(1657, 24690, 24721) || (((f_1657_24691_24712(lastException) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1657, 24724, 24745)) || DynAbs.Tracing.TraceSender.Conditional_F3(1657, 24748, 24760))) ? f_1657_24724_24745(lastException) : string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 24597, 24913);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 24597, 24913);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24859, 24890);

                            exceptionThrown = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 24597, 24913);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 24327, 24932);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 24952, 25077);

                    throw f_1657_24958_25076(f_1657_25001_25058(), exceptionThrown);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 24153, 25092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 25108, 25123);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 22826, 25134);

                int
                f_1657_22956_23020(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 22956, 23020);
                    return 0;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1657_23119_23139(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.HostInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 23119, 23139);
                    return return_v;
                }


                System.Guid
                f_1657_23335_23350(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 23335, 23350);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_23392_23405(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 23392, 23405);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1657_23392_23420(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 23392, 23420);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_23546_23559(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 23546, 23559);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDriver
                f_1657_23186_23560(System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDriver(powershell, extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 23186, 23560);
                    return return_v;
                }


                System.IAsyncResult
                f_1657_23604_23618(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 23604, 23618);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1657_23822_23855(System.Management.Automation.PowerShell
                this_param, System.IAsyncResult
                asyncResult)
                {
                    var return_v = this_param.EndInvoke(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 23822, 23855);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_24079_24098(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24079, 24098);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1657_24079_24118(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24079, 24118);
                    return return_v;
                }


                object
                f_1657_24079_24138(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24079, 24138);
                    return return_v;
                }


                int
                f_1657_24157_24172(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24157, 24172);
                    return return_v;
                }


                object
                f_1657_24281_24293(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24281, 24293);
                    return return_v;
                }


                string
                f_1657_24414_24440(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 24414, 24440);
                    return return_v;
                }


                object
                f_1657_24549_24561(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24549, 24561);
                    return return_v;
                }


                string
                f_1657_24691_24712(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24691, 24712);
                    return return_v;
                }


                string
                f_1657_24724_24745(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 24724, 24745);
                    return return_v;
                }


                string
                f_1657_25001_25058()
                {
                    var return_v = RemotingErrorIdStrings.StartupScriptThrewTerminatingError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 25001, 25058);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1657_24958_25076(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 24958, 25076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 22826, 25134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 22826, 25134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleRunspaceCreated(object sender, RunspaceCreatedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 25563, 27800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 25668, 25715);

                f_1657_25668_25689(this).Runspace = f_1657_25701_25714(args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 25869, 25941);

                f_1657_25869_25940(f_1657_25909_25939(f_1657_25909_25922(args)));

                // Set the current location to MyDocuments folder for this runspace.
                // This used to be set to the Personal folder but was changed to MyDocuments folder for
                // compatibility with PowerShell on Nano Server for PowerShell V5.
                // This is needed because in the remoting scenario, Environment.CurrentDirectory
                // always points to System Folder (%windir%\system32) irrespective of the
                // user as %HOMEDRIVE% and %HOMEPATH% are not available for the logon process.
                // Doing this here than AutomationEngine as I dont want to introduce a dependency
                // on Remoting in PowerShell engine
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 26673, 26759);

                    string
                    personalfolder = f_1657_26697_26758(Environment.SpecialFolder.MyDocuments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 26777, 26855);

                    f_1657_26777_26854(f_1657_26777_26826(f_1657_26777_26807(f_1657_26777_26790(args))), personalfolder);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 26884, 27220);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 26884, 27220);
                    // SetLocation API can call 3rd party code and so there is no telling what exception may be thrown.
                    // Setting location is not critical and is expected not to work with some account types, so we want
                    // to ignore all but critical errors.
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27236, 27550) || true) && (!f_1657_27241_27284(_initialLocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 27236, 27550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27318, 27371);

                    var
                    setLocationCommand = f_1657_27343_27370("Set-Location")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27389, 27478);

                    f_1657_27389_27477(f_1657_27389_27418(setLocationCommand), f_1657_27423_27476("LiteralPath", _initialLocation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27496, 27535);

                    f_1657_27496_27534(this, setLocationCommand, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 27236, 27550);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27602, 27629);

                f_1657_27602_27628(this, args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27741, 27789);

                f_1657_27741_27788(this, sender, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 25563, 27800);

                System.Management.Automation.Remoting.ServerRemoteHost
                f_1657_25668_25689(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.ServerRemoteHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 25668, 25689);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_25701_25714(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 25701, 25714);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_25909_25922(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 25909, 25922);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1657_25909_25939(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 25909, 25939);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1657_25869_25940(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Utils.EnforceSystemLockDownLanguageMode(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 25869, 25940);
                    return return_v;
                }


                string
                f_1657_26697_26758(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Platform.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 26697, 26758);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_26777_26790(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 26777, 26790);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1657_26777_26807(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 26777, 26807);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1657_26777_26826(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 26777, 26826);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1657_26777_26854(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.SetLocation(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 26777, 26854);
                    return return_v;
                }


                bool
                f_1657_27241_27284(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27241, 27284);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_27343_27370(string
                command)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27343, 27370);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_27389_27418(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 27389, 27418);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_27423_27476(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27423, 27476);
                    return return_v;
                }


                int
                f_1657_27389_27477(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27389, 27477);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1657_27496_27534(System.Management.Automation.ServerRunspacePoolDriver
                this_param, System.Management.Automation.Runspaces.Command
                cmdToRun, System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                args)
                {
                    var return_v = this_param.InvokeScript(cmdToRun, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27496, 27534);
                    return return_v;
                }


                int
                f_1657_27602_27628(System.Management.Automation.ServerRunspacePoolDriver
                this_param, System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                args)
                {
                    this_param.InvokeStartupScripts(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27602, 27628);
                    return 0;
                }


                int
                f_1657_27741_27788(System.Management.Automation.ServerRunspacePoolDriver
                this_param, object
                sender, System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                args)
                {
                    this_param.HandleRunspaceCreatedForTypeTable(sender, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27741, 27788);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 25563, 27800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 25563, 27800);
            }
        }

        private void InvokeStartupScripts(RunspaceCreatedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 27812, 29470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27901, 27925);

                Command
                cmdToRun = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 27939, 28415) || true) && (!f_1657_27944_27991(_configData.StartupScript))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 27939, 28415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 28093, 28157);

                    cmdToRun = f_1657_28104_28156(_configData.StartupScript, false, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 27939, 28415);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 27939, 28415);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 28191, 28415) || true) && (!f_1657_28196_28273(_configData.InitializationScriptForOutOfProcessRunspace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 28191, 28415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 28307, 28400);

                        cmdToRun = f_1657_28318_28399(_configData.InitializationScriptForOutOfProcessRunspace, true, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 28191, 28415);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 27939, 28415);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 28431, 29459) || true) && (cmdToRun != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 28431, 29459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 28485, 28514);

                    f_1657_28485_28513(this, cmdToRun, args);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 28750, 29444) || true) && (f_1657_28754_28794(f_1657_28754_28788(f_1657_28754_28766())) == RunspacePoolState.Opening)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 28750, 29444);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 28865, 28981);

                        object
                        privateDataVariable = f_1657_28894_28980(f_1657_28894_28936(f_1657_28894_28925(f_1657_28894_28907(args))), "global:PSApplicationPrivateData")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 29003, 29425) || true) && (privateDataVariable != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 29003, 29425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 29084, 29402);

                            _applicationPrivateData = (PSPrimitiveDictionary)f_1657_29133_29401(privateDataVariable, typeof(PSPrimitiveDictionary), true, f_1657_29337_29365(), null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 29003, 29425);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 28750, 29444);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 28431, 29459);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 27812, 29470);

                bool
                f_1657_27944_27991(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 27944, 27991);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_28104_28156(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 28104, 28156);
                    return return_v;
                }


                bool
                f_1657_28196_28273(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 28196, 28273);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_28318_28399(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 28318, 28399);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1657_28485_28513(System.Management.Automation.ServerRunspacePoolDriver
                this_param, System.Management.Automation.Runspaces.Command
                cmdToRun, System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                args)
                {
                    var return_v = this_param.InvokeScript(cmdToRun, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 28485, 28513);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_28754_28766()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 28754, 28766);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1657_28754_28788(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 28754, 28788);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1657_28754_28794(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 28754, 28794);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_28894_28907(System.Management.Automation.Runspaces.RunspaceCreatedEventArgs
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 28894, 28907);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateProxy
                f_1657_28894_28925(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.SessionStateProxy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 28894, 28925);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1657_28894_28936(System.Management.Automation.Runspaces.SessionStateProxy
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 28894, 28936);
                    return return_v;
                }


                object
                f_1657_28894_28980(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 28894, 28980);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1657_29337_29365()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 29337, 29365);
                    return return_v;
                }


                object
                f_1657_29133_29401(object
                valueToConvert, System.Type
                resultType, bool
                recursion, System.Globalization.CultureInfo
                formatProvider, System.Management.Automation.Runspaces.TypeTable
                backupTypeTable)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, recursion, (System.IFormatProvider)formatProvider, backupTypeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 29133, 29401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 27812, 29470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 27812, 29470);
            }
        }

        private void HandleRunspacePoolStateChanged(object sender,
                                    RunspacePoolStateChangedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 29779, 30775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 29936, 30000);

                RunspacePoolState
                state = f_1657_29962_29999(f_1657_29962_29993(eventArgs))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 30014, 30072);

                Exception
                reason = f_1657_30033_30071(f_1657_30033_30064(eventArgs))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 30088, 30764);

                switch (state)
                {

                    case RunspacePoolState.Broken:
                    case RunspacePoolState.Closing:
                    case RunspacePoolState.Closed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 30088, 30764);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 30311, 30396);

                            f_1657_30311_30395(f_1657_30311_30331(), f_1657_30354_30394(state, reason));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1657, 30443, 30449);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 30088, 30764);

                    case RunspacePoolState.Opened:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 30088, 30764);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 30548, 30585);

                            f_1657_30548_30584(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 30611, 30696);

                            f_1657_30611_30695(f_1657_30611_30631(), f_1657_30654_30694(state, reason));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1657, 30743, 30749);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 30088, 30764);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 29779, 30775);

                System.Management.Automation.RunspacePoolStateInfo
                f_1657_29962_29993(System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 29962, 29993);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1657_29962_29999(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 29962, 29999);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1657_30033_30064(System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 30033, 30064);
                    return return_v;
                }


                System.Exception
                f_1657_30033_30071(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 30033, 30071);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_30311_30331()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 30311, 30331);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1657_30354_30394(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 30354, 30394);
                    return return_v;
                }


                int
                f_1657_30311_30395(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    this_param.SendStateInfoToClient(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 30311, 30395);
                    return 0;
                }


                int
                f_1657_30548_30584(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    this_param.SendApplicationPrivateDataToClient();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 30548, 30584);
                    return 0;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_30611_30631()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 30611, 30631);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1657_30654_30694(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 30654, 30694);
                    return return_v;
                }


                int
                f_1657_30611_30695(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    this_param.SendStateInfoToClient(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 30611, 30695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 29779, 30775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 29779, 30775);
            }
        }

        private void HandleRunspacePoolForwardEvent(object sender, PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 30886, 31110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 30984, 31099) || true) && (f_1657_30988_31002(e))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 30984, 31099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 31036, 31084);

                    f_1657_31036_31083(f_1657_31036_31056(), e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 30984, 31099);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 30886, 31110);

                bool
                f_1657_30988_31002(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.ForwardEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 30988, 31002);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_31036_31056()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 31036, 31056);
                    return return_v;
                }


                int
                f_1657_31036_31083(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.SendPSEventArgsToClient(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 31036, 31083);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 30886, 31110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 30886, 31110);
            }
        }

        private void HandleCreateAndInvokePowerShell(object _, RemoteDataEventArgs<RemoteDataObject<PSObject>> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 31364, 42120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 31502, 31551);

                RemoteDataObject<PSObject>
                data = f_1657_31536_31550(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 31743, 31802);

                HostInfo
                hostInfo = f_1657_31763_31801(f_1657_31791_31800(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 31818, 31895);

                ApartmentState
                apartmentState = f_1657_31850_31894(f_1657_31884_31893(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 31911, 31997);

                RemoteStreamOptions
                streamOptions = f_1657_31947_31996(f_1657_31986_31995(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32011, 32076);

                PowerShell
                powershell = f_1657_32035_32075(f_1657_32065_32074(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32090, 32143);

                bool
                noInput = f_1657_32105_32142(f_1657_32132_32141(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32157, 32220);

                bool
                addToHistory = f_1657_32177_32219(f_1657_32209_32218(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32234, 32256);

                bool
                isNested = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32371, 32551) || true) && (f_1657_32375_32408(_serverCapability) >= RemotingConstants.ProtocolVersionWin8RTM)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 32371, 32551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32486, 32536);

                    isNested = f_1657_32497_32535(f_1657_32525_32534(data));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 32371, 32551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32655, 36021) || true) && (_serverRemoteDebugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 32655, 36021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32722, 32762);

                    DebuggerCommandArgument
                    commandArgument
                    = default(DebuggerCommandArgument);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32780, 32812);

                    bool
                    terminateImmediate = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32830, 32893);

                    Collection<object>
                    preProcessOutput = f_1657_32868_32892()
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 32957, 33079);

                        var
                        result = f_1657_32970_33078(f_1657_32996_33015(powershell), _serverRemoteDebugger, preProcessOutput, out commandArgument)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 33103, 34908);

                        switch (result)
                        {

                            case PreProcessCommandResult.SetDebuggerAction:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 33103, 34908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 33344, 33420);

                                f_1657_33344_33419(                            // Run this directly on the debugger and terminate the remote command.
                                                            _serverRemoteDebugger, f_1657_33384_33418(f_1657_33384_33412(commandArgument)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 33450, 33476);

                                terminateImmediate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1657, 33506, 33512);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 33103, 34908);

                            case PreProcessCommandResult.SetDebugMode:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 33103, 34908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 33698, 33761);

                                f_1657_33698_33760(                            // Set debug mode directly and terminate remote command.
                                                            _serverRemoteDebugger, f_1657_33733_33759(f_1657_33733_33753(commandArgument)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 33791, 33817);

                                terminateImmediate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1657, 33847, 33853);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 33103, 34908);

                            case PreProcessCommandResult.SetDebuggerStepMode:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 33103, 34908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 34063, 34148);

                                f_1657_34063_34147(                            // Enable debugger and set to step action, then terminate remote command.
                                                            _serverRemoteDebugger, f_1657_34105_34146(f_1657_34105_34140(commandArgument)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 34178, 34204);

                                terminateImmediate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1657, 34234, 34240);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 33103, 34908);

                            case PreProcessCommandResult.SetPreserveUnhandledBreakpointMode:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 33103, 34908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 34362, 34456);

                                _serverRemoteDebugger.UnhandledBreakpointMode = f_1657_34410_34455(f_1657_34410_34449(commandArgument));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 34486, 34512);

                                terminateImmediate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1657, 34542, 34548);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 33103, 34908);

                            case PreProcessCommandResult.ValidNotProcessed:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 33103, 34908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 34653, 34679);

                                terminateImmediate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1657, 34709, 34715);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 33103, 34908);

                            case PreProcessCommandResult.BreakpointManagement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 33103, 34908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 34823, 34849);

                                terminateImmediate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1657, 34879, 34885);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 33103, 34908);
                        }
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 34945, 35167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 35006, 35032);

                        terminateImmediate = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 35076, 35148);

                        f_1657_35076_35147(
                                            preProcessOutput, f_1657_35123_35146(ex));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 34945, 35167);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 35353, 36006) || true) && (terminateImmediate)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 35353, 36006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 35417, 35890);

                        ServerPowerShellDriver
                        noOpDriver = f_1657_35453_35889(powershell, null, noInput, f_1657_35608_35625(data), f_1657_35652_35671(data), this, apartmentState, hostInfo, streamOptions, addToHistory, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 35914, 35958);

                        f_1657_35914_35957(
                                            noOpDriver, preProcessOutput);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 35980, 35987);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 35353, 36006);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 32655, 36021);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36037, 41304) || true) && (f_1657_36041_36069(_remoteHost))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 36037, 41304);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36255, 36392) || true) && (_serverRemoteDebugger != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 36255, 36392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36330, 36373);

                        f_1657_36330_36372(_serverRemoteDebugger);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 36255, 36392);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36412, 36726);

                    f_1657_36412_36725(this, powershell, null, f_1657_36533_36550(data), f_1657_36573_36592(data), hostInfo, streamOptions, noInput, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36746, 36753);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 36037, 41304);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 36037, 41304);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36787, 41304) || true) && (isNested)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 36787, 41304);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36833, 41166) || true) && (f_1657_36837_36867(f_1657_36837_36849()) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 36833, 41166);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 36914, 40035) || true) && (_driverNestedInvoker != null && (DynAbs.Tracing.TraceSender.Expression_True(1657, 36918, 36979) && f_1657_36950_36979(_driverNestedInvoker)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 36914, 40035);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 37029, 37389) || true) && (f_1657_37033_37065(_driverNestedInvoker) == false)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 37029, 37389);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 37201, 37362);

                                    throw f_1657_37207_37361(f_1657_37273_37360(f_1657_37291_37359()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 37029, 37389);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 37483, 37512);

                                f_1657_37483_37511(
                                                        // Handle as nested pipeline invocation.
                                                        powershell, true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 37742, 38281);

                                ServerPowerShellDriver
                                srdriver = f_1657_37776_38280(powershell, null, noInput, f_1657_37947_37964(data), f_1657_37995_38014(data), this, apartmentState, hostInfo, streamOptions, addToHistory, _rsToUseForSteppablePipeline)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 38309, 38353);

                                _inputCollection = f_1657_38328_38352(srdriver);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 38379, 38428);

                                f_1657_38379_38427(_driverNestedInvoker, srdriver);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 38454, 38461);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 36914, 40035);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 36914, 40035);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 38511, 40035) || true) && (_serverRemoteDebugger != null && (DynAbs.Tracing.TraceSender.Expression_True(1657, 38515, 38612) && f_1657_38578_38612(_serverRemoteDebugger)) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 38515, 38676) && f_1657_38646_38676(_serverRemoteDebugger)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 38511, 40035);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 38726, 39159);

                                    f_1657_38726_39158(_serverRemoteDebugger, powershell, f_1657_38842_38859(data), f_1657_38890_38909(data), this, apartmentState, _remoteHost, hostInfo, streamOptions, addToHistory);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 39187, 39194);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 38511, 40035);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 38511, 40035);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 39244, 40035) || true) && (f_1657_39248_39282(f_1657_39248_39276(f_1657_39248_39267(powershell))) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1657, 39248, 39362) && f_1657_39321_39362_M(!f_1657_39322_39353(f_1657_39322_39350(f_1657_39322_39341(powershell)), 0).IsScript)) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 39248, 39673) && ((f_1657_39398_39511(f_1657_39398_39441(f_1657_39398_39429(f_1657_39398_39426(f_1657_39398_39417(powershell)), 0)), "Get-PSDebuggerStopArgs", StringComparison.OrdinalIgnoreCase) != -1) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 39397, 39672) || (f_1657_39554_39665(f_1657_39554_39597(f_1657_39554_39585(f_1657_39554_39582(f_1657_39554_39573(powershell)), 0)), "Set-PSDebuggerAction", StringComparison.OrdinalIgnoreCase) != -1)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 39244, 40035);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 39972, 40012);

                                        throw f_1657_39978_40011();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 39244, 40035);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 38511, 40035);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 36914, 40035);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 40059, 40165);

                            ServerPowerShellDataStructureHandler
                            psHandler = f_1657_40108_40164(f_1657_40108_40128())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 40187, 41147) || true) && (psHandler != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 40187, 41147);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 40321, 40351);

                                f_1657_40321_40350(                        // Have steppable invocation request.
                                                        powershell, false);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 40434, 41046);

                                ServerSteppablePipelineDriver
                                spDriver = f_1657_40475_41045(powershell, noInput, f_1657_40618_40635(data), f_1657_40666_40685(data), this, apartmentState, hostInfo, streamOptions, addToHistory, _rsToUseForSteppablePipeline, _eventSubscriber, _inputCollection)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 41074, 41091);

                                f_1657_41074_41090(
                                                        spDriver);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 41117, 41124);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 40187, 41147);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 36833, 41166);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 41259, 41289);

                        f_1657_41259_41288(
                                        // Allow command to run as non-nested and non-stepping.
                                        powershell, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 36787, 41304);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 36037, 41304);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 41441, 41566) || true) && (_serverRemoteDebugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 41441, 41566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 41508, 41551);

                    f_1657_41508_41550(_serverRemoteDebugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 41441, 41566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 41641, 42022);

                ServerPowerShellDriver
                driver = f_1657_41673_42021(powershell, null, noInput, f_1657_41796_41813(data), f_1657_41832_41851(data), this, apartmentState, hostInfo, streamOptions, addToHistory, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42038, 42080);

                _inputCollection = f_1657_42057_42079(driver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42094, 42109);

                f_1657_42094_42108(driver);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 31364, 42120);

                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1657_31536_31550(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 31536, 31550);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_31791_31800(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 31791, 31800);
                    return return_v;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1657_31763_31801(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetHostInfo(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 31763, 31801);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_31884_31893(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 31884, 31893);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1657_31850_31894(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetApartmentState((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 31850, 31894);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_31986_31995(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 31986, 31995);
                    return return_v;
                }


                System.Management.Automation.RemoteStreamOptions
                f_1657_31947_31996(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetRemoteStreamOptions((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 31947, 31996);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_32065_32074(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 32065, 32074);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_32035_32075(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetPowerShell((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 32035, 32075);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_32132_32141(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 32132, 32141);
                    return return_v;
                }


                bool
                f_1657_32105_32142(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetNoInput((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 32105, 32142);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_32209_32218(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 32209, 32218);
                    return return_v;
                }


                bool
                f_1657_32177_32219(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetAddToHistory((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 32177, 32219);
                    return return_v;
                }


                System.Version
                f_1657_32375_32408(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.ProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 32375, 32408);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_32525_32534(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 32525, 32534);
                    return return_v;
                }


                bool
                f_1657_32497_32535(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetIsNested((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 32497, 32535);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1657_32868_32892()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 32868, 32892);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_32996_33015(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 32996, 33015);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDriver.PreProcessCommandResult
                f_1657_32970_33078(System.Management.Automation.PSCommand
                commands, System.Management.Automation.ServerRemoteDebugger
                serverRemoteDebugger, System.Collections.ObjectModel.Collection<object>
                preProcessOutput, out System.Management.Automation.ServerRunspacePoolDriver.DebuggerCommandArgument
                commandArgument)
                {
                    var return_v = PreProcessDebuggerCommand(commands, serverRemoteDebugger, preProcessOutput, out commandArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 32970, 33078);
                    return return_v;
                }


                System.Management.Automation.DebuggerResumeAction?
                f_1657_33384_33412(System.Management.Automation.ServerRunspacePoolDriver.DebuggerCommandArgument
                this_param)
                {
                    var return_v = this_param.ResumeAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 33384, 33412);
                    return return_v;
                }


                System.Management.Automation.DebuggerResumeAction
                f_1657_33384_33418(System.Management.Automation.DebuggerResumeAction?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 33384, 33418);
                    return return_v;
                }


                int
                f_1657_33344_33419(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.SetDebuggerAction(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 33344, 33419);
                    return 0;
                }


                System.Management.Automation.DebugModes?
                f_1657_33733_33753(System.Management.Automation.ServerRunspacePoolDriver.DebuggerCommandArgument
                this_param)
                {
                    var return_v = this_param.Mode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 33733, 33753);
                    return return_v;
                }


                System.Management.Automation.DebugModes
                f_1657_33733_33759(System.Management.Automation.DebugModes?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 33733, 33759);
                    return return_v;
                }


                int
                f_1657_33698_33760(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 33698, 33760);
                    return 0;
                }


                bool?
                f_1657_34105_34140(System.Management.Automation.ServerRunspacePoolDriver.DebuggerCommandArgument
                this_param)
                {
                    var return_v = this_param.DebuggerStepEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 34105, 34140);
                    return return_v;
                }


                bool
                f_1657_34105_34146(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 34105, 34146);
                    return return_v;
                }


                int
                f_1657_34063_34147(System.Management.Automation.ServerRemoteDebugger
                this_param, bool
                enabled)
                {
                    this_param.SetDebuggerStepMode(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 34063, 34147);
                    return 0;
                }


                System.Management.Automation.UnhandledBreakpointProcessingMode?
                f_1657_34410_34449(System.Management.Automation.ServerRunspacePoolDriver.DebuggerCommandArgument
                this_param)
                {
                    var return_v = this_param.UnhandledBreakpointMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 34410, 34449);
                    return return_v;
                }


                System.Management.Automation.UnhandledBreakpointProcessingMode
                f_1657_34410_34455(System.Management.Automation.UnhandledBreakpointProcessingMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 34410, 34455);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_35123_35146(System.Exception
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 35123, 35146);
                    return return_v;
                }


                int
                f_1657_35076_35147(System.Collections.ObjectModel.Collection<object>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 35076, 35147);
                    return 0;
                }


                System.Guid
                f_1657_35608_35625(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 35608, 35625);
                    return return_v;
                }


                System.Guid
                f_1657_35652_35671(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 35652, 35671);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDriver
                f_1657_35453_35889(System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDriver(powershell, extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 35453, 35889);
                    return return_v;
                }


                int
                f_1657_35914_35957(System.Management.Automation.ServerPowerShellDriver
                this_param, System.Collections.ObjectModel.Collection<object>
                output)
                {
                    this_param.RunNoOpCommand((System.Collections.Generic.IReadOnlyCollection<object>)output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 35914, 35957);
                    return 0;
                }


                bool
                f_1657_36041_36069(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.IsRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 36041, 36069);
                    return return_v;
                }


                int
                f_1657_36330_36372(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    this_param.CheckDebuggerState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 36330, 36372);
                    return 0;
                }


                System.Guid
                f_1657_36533_36550(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 36533, 36550);
                    return return_v;
                }


                System.Guid
                f_1657_36573_36592(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 36573, 36592);
                    return return_v;
                }


                int
                f_1657_36412_36725(System.Management.Automation.ServerRunspacePoolDriver
                this_param, System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, System.Guid
                powershellId, System.Guid
                runspacePoolId, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                noInput, bool
                addToHistory)
                {
                    this_param.StartPowerShellCommandOnPushedRunspace(powershell, extraPowerShell, powershellId, runspacePoolId, hostInfo, streamOptions, noInput, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 36412, 36725);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_36837_36849()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 36837, 36849);
                    return return_v;
                }


                int
                f_1657_36837_36867(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.GetMaxRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 36837, 36867);
                    return return_v;
                }


                bool
                f_1657_36950_36979(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker
                this_param)
                {
                    var return_v = this_param.IsActive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 36950, 36979);
                    return return_v;
                }


                bool
                f_1657_37033_37065(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker
                this_param)
                {
                    var return_v = this_param.IsAvailable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 37033, 37065);
                    return return_v;
                }


                string
                f_1657_37291_37359()
                {
                    var return_v = RemotingErrorIdStrings.CannotInvokeNestedCommandNestedCommandRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 37291, 37359);
                    return return_v;
                }


                string
                f_1657_37273_37360(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 37273, 37360);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1657_37207_37361(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 37207, 37361);
                    return return_v;
                }


                int
                f_1657_37483_37511(System.Management.Automation.PowerShell
                this_param, bool
                isNested)
                {
                    this_param.SetIsNested(isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 37483, 37511);
                    return 0;
                }


                System.Guid
                f_1657_37947_37964(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 37947, 37964);
                    return return_v;
                }


                System.Guid
                f_1657_37995_38014(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 37995, 38014);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDriver
                f_1657_37776_38280(System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDriver(powershell, extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 37776, 38280);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1657_38328_38352(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    var return_v = this_param.InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 38328, 38352);
                    return return_v;
                }


                int
                f_1657_38379_38427(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker
                this_param, System.Management.Automation.ServerPowerShellDriver
                driver)
                {
                    this_param.InvokeDriverAsync(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 38379, 38427);
                    return 0;
                }


                bool
                f_1657_38578_38612(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 38578, 38612);
                    return return_v;
                }


                bool
                f_1657_38646_38676(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.IsPushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 38646, 38676);
                    return return_v;
                }


                System.Guid
                f_1657_38842_38859(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 38842, 38859);
                    return return_v;
                }


                System.Guid
                f_1657_38890_38909(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 38890, 38909);
                    return return_v;
                }


                int
                f_1657_38726_39158(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.PowerShell
                powershell, System.Guid
                powershellId, System.Guid
                runspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.ServerDriverRemoteHost
                remoteHost, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory)
                {
                    this_param.StartPowerShellCommand(powershell, powershellId, runspacePoolId, runspacePoolDriver, apartmentState, (System.Management.Automation.Remoting.ServerRemoteHost)remoteHost, hostInfo, streamOptions, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 38726, 39158);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1657_39248_39267(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39248, 39267);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1657_39248_39276(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39248, 39276);
                    return return_v;
                }


                int
                f_1657_39248_39282(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39248, 39282);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_39322_39341(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39322, 39341);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1657_39322_39350(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39322, 39350);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_39322_39353(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39322, 39353);
                    return return_v;
                }


                bool
                f_1657_39321_39362_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39321, 39362);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_39398_39417(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39398, 39417);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1657_39398_39426(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39398, 39426);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_39398_39429(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39398, 39429);
                    return return_v;
                }


                string
                f_1657_39398_39441(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39398, 39441);
                    return return_v;
                }


                int
                f_1657_39398_39511(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 39398, 39511);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_39554_39573(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39554, 39573);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1657_39554_39582(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39554, 39582);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_39554_39585(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39554, 39585);
                    return return_v;
                }


                string
                f_1657_39554_39597(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 39554, 39597);
                    return return_v;
                }


                int
                f_1657_39554_39665(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 39554, 39665);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1657_39978_40011()
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 39978, 40011);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_40108_40128()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 40108, 40128);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1657_40108_40164(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param)
                {
                    var return_v = this_param.GetPowerShellDataStructureHandler();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 40108, 40164);
                    return return_v;
                }


                int
                f_1657_40321_40350(System.Management.Automation.PowerShell
                this_param, bool
                isNested)
                {
                    this_param.SetIsNested(isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 40321, 40350);
                    return 0;
                }


                System.Guid
                f_1657_40618_40635(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 40618, 40635);
                    return return_v;
                }


                System.Guid
                f_1657_40666_40685(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 40666, 40685);
                    return return_v;
                }


                System.Management.Automation.ServerSteppablePipelineDriver
                f_1657_40475_41045(System.Management.Automation.PowerShell
                powershell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse, System.Management.Automation.ServerSteppablePipelineSubscriber
                eventSubscriber, System.Management.Automation.PSDataCollection<object>
                powershellInput)
                {
                    var return_v = new System.Management.Automation.ServerSteppablePipelineDriver(powershell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse, eventSubscriber, powershellInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 40475, 41045);
                    return return_v;
                }


                int
                f_1657_41074_41090(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 41074, 41090);
                    return 0;
                }


                int
                f_1657_41259_41288(System.Management.Automation.PowerShell
                this_param, bool
                isNested)
                {
                    this_param.SetIsNested(isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 41259, 41288);
                    return 0;
                }


                int
                f_1657_41508_41550(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    this_param.CheckDebuggerState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 41508, 41550);
                    return 0;
                }


                System.Guid
                f_1657_41796_41813(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 41796, 41813);
                    return return_v;
                }


                System.Guid
                f_1657_41832_41851(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 41832, 41851);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDriver
                f_1657_41673_42021(System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDriver(powershell, extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 41673, 42021);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1657_42057_42079(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    var return_v = this_param.InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 42057, 42079);
                    return return_v;
                }


                System.IAsyncResult
                f_1657_42094_42108(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 42094, 42108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 31364, 42120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 31364, 42120);
            }
        }

        private bool? _initialSessionStateIncludesGetCommandWithListImportedSwitch;

        private object _initialSessionStateIncludesGetCommandWithListImportedSwitchLock;

        private bool DoesInitialSessionStateIncludeGetCommandWithListImportedSwitch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 42322, 44563);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42424, 44462) || true) && (f_1657_42428_42498_M(!_initialSessionStateIncludesGetCommandWithListImportedSwitch.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 42424, 44462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42538, 42602);
                    lock (_initialSessionStateIncludesGetCommandWithListImportedSwitchLock)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42644, 44428) || true) && (f_1657_42648_42718_M(!_initialSessionStateIncludesGetCommandWithListImportedSwitch.HasValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 42644, 44428);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42768, 42790);

                            bool
                            newValue = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42818, 42882);

                            InitialSessionState
                            iss = f_1657_42844_42881(f_1657_42844_42861(this))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42908, 44305) || true) && (iss != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 42908, 44305);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 42981, 43212);

                                IEnumerable<SessionStateCommandEntry>
                                publicGetCommandEntries = f_1657_43045_43211(f_1657_43045_43106(f_1657_43045_43091(iss), "Get-Command"), entry => entry.Visibility == SessionStateEntryVisibility.Public)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 43242, 43363);

                                SessionStateFunctionEntry
                                getCommandProxy = f_1657_43286_43362(f_1657_43286_43345(publicGetCommandEntries))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 43393, 44278) || true) && (getCommandProxy != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 43393, 44278);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 43486, 43707) || true) && (f_1657_43490_43582(f_1657_43490_43554(f_1657_43490_43535(f_1657_43490_43517(getCommandProxy))), "ListImported"))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 43486, 43707);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 43656, 43672);

                                        newValue = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 43486, 43707);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 43393, 44278);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 43393, 44278);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 43837, 43955);

                                    SessionStateCmdletEntry
                                    getCommandCmdlet = f_1657_43880_43954(f_1657_43880_43937(publicGetCommandEntries))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 43989, 44247) || true) && ((getCommandCmdlet != null) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 43993, 44122) && (f_1657_44024_44121(f_1657_44024_44057(getCommandCmdlet), typeof(Microsoft.PowerShell.Commands.GetCommandCommand)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 43989, 44247);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 44196, 44212);

                                        newValue = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 43989, 44247);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 43393, 44278);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 42908, 44305);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 44333, 44405);

                            _initialSessionStateIncludesGetCommandWithListImportedSwitch = newValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 42644, 44428);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 42424, 44462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 44478, 44552);

                return f_1657_44485_44551(_initialSessionStateIncludesGetCommandWithListImportedSwitch);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 42322, 44563);

                bool
                f_1657_42428_42498_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 42428, 42498);
                    return return_v;
                }


                bool
                f_1657_42648_42718_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 42648, 42718);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_42844_42861(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 42844, 42861);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1657_42844_42881(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 42844, 42881);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1657_43045_43091(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 43045, 43091);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1657_43045_43106(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 43045, 43106);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1657_43045_43211(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                source, System.Func<System.Management.Automation.Runspaces.SessionStateCommandEntry, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.Runspaces.SessionStateCommandEntry>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 43045, 43211);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateFunctionEntry>
                f_1657_43286_43345(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Runspaces.SessionStateFunctionEntry>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 43286, 43345);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateFunctionEntry
                f_1657_43286_43362(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateFunctionEntry>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Runspaces.SessionStateFunctionEntry>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 43286, 43362);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1657_43490_43517(System.Management.Automation.Runspaces.SessionStateFunctionEntry
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 43490, 43517);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1657_43490_43535(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 43490, 43535);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1657_43490_43554(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 43490, 43554);
                    return return_v;
                }


                bool
                f_1657_43490_43582(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 43490, 43582);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCmdletEntry>
                f_1657_43880_43937(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Runspaces.SessionStateCmdletEntry>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 43880, 43937);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateCmdletEntry
                f_1657_43880_43954(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCmdletEntry>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Runspaces.SessionStateCmdletEntry>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 43880, 43954);
                    return return_v;
                }


                System.Type
                f_1657_44024_44057(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 44024, 44057);
                    return return_v;
                }


                bool
                f_1657_44024_44121(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 44024, 44121);
                    return return_v;
                }


                bool
                f_1657_44485_44551(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 44485, 44551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 42322, 44563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 42322, 44563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleGetCommandMetadata(object sender, RemoteDataEventArgs<RemoteDataObject<PSObject>> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 44838, 47359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 44974, 45023);

                RemoteDataObject<PSObject>
                data = f_1657_45008_45022(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45039, 45124);

                PowerShell
                countingPipeline = f_1657_45069_45123(f_1657_45113_45122(data))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45138, 45312) || true) && (f_1657_45142_45211(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 45138, 45312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45245, 45297);

                    f_1657_45245_45296(countingPipeline, "ListImported", true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 45138, 45312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45328, 45556);

                f_1657_45328_45555(f_1657_45328_45503(f_1657_45328_45457(f_1657_45328_45410(
                            countingPipeline
                , "ErrorAction", "SilentlyContinue"), "Measure-Object"), "Select-Object"), "Property", "Count");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45572, 45653);

                PowerShell
                mainPipeline = f_1657_45598_45652(f_1657_45642_45651(data))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45667, 45837) || true) && (f_1657_45671_45740(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 45667, 45837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45774, 45822);

                    f_1657_45774_45821(mainPipeline, "ListImported", true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 45667, 45837);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 45853, 46091);

                f_1657_45853_46090(f_1657_45853_45911(
                            mainPipeline
                , "Select-Object"), "Property", new string[] {
                    "Name", "Namespace", "HelpUri", "CommandType", "ResolvedCommandName", "OutputType", "Parameters" });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 46107, 46153);

                HostInfo
                useRunspaceHost = f_1657_46134_46152(null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 46167, 46206);

                useRunspaceHost.UseRunspaceHost = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 46222, 47348) || true) && (f_1657_46226_46254(_remoteHost))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 46222, 47348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 46357, 46670);

                    f_1657_46357_46669(this, countingPipeline, mainPipeline, f_1657_46492_46509(data), f_1657_46532_46551(data), useRunspaceHost, 0, true, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 46222, 47348);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 46222, 47348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 46777, 47298);

                    ServerPowerShellDriver
                    driver = f_1657_46809_47297(countingPipeline, mainPipeline, true, f_1657_46974_46991(data), f_1657_47014_47033(data), this, ApartmentState.Unknown, useRunspaceHost, 0, false, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 47318, 47333);

                    f_1657_47318_47332(
                                    driver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 46222, 47348);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 44838, 47359);

                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1657_45008_45022(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 45008, 45022);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_45113_45122(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 45113, 45122);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45069_45123(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetCommandDiscoveryPipeline((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45069, 45123);
                    return return_v;
                }


                bool
                f_1657_45142_45211(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.DoesInitialSessionStateIncludeGetCommandWithListImportedSwitch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45142, 45211);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45245_45296(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45245, 45296);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45328_45410(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45328, 45410);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45328_45457(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45328, 45457);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45328_45503(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45328, 45503);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45328_45555(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45328, 45555);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1657_45642_45651(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 45642, 45651);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45598_45652(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetCommandDiscoveryPipeline((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45598, 45652);
                    return return_v;
                }


                bool
                f_1657_45671_45740(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.DoesInitialSessionStateIncludeGetCommandWithListImportedSwitch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45671, 45740);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45774_45821(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45774, 45821);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45853_45911(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45853, 45911);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_45853_46090(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 45853, 46090);
                    return return_v;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1657_46134_46152(System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = new System.Management.Automation.Remoting.HostInfo(host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 46134, 46152);
                    return return_v;
                }


                bool
                f_1657_46226_46254(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.IsRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 46226, 46254);
                    return return_v;
                }


                System.Guid
                f_1657_46492_46509(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 46492, 46509);
                    return return_v;
                }


                System.Guid
                f_1657_46532_46551(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 46532, 46551);
                    return return_v;
                }


                int
                f_1657_46357_46669(System.Management.Automation.ServerRunspacePoolDriver
                this_param, System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, System.Guid
                powershellId, System.Guid
                runspacePoolId, System.Management.Automation.Remoting.HostInfo
                hostInfo, int
                streamOptions, bool
                noInput, bool
                addToHistory)
                {
                    this_param.StartPowerShellCommandOnPushedRunspace(powershell, extraPowerShell, powershellId, runspacePoolId, hostInfo, (System.Management.Automation.RemoteStreamOptions)streamOptions, noInput, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 46357, 46669);
                    return 0;
                }


                System.Guid
                f_1657_46974_46991(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 46974, 46991);
                    return return_v;
                }


                System.Guid
                f_1657_47014_47033(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 47014, 47033);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDriver
                f_1657_46809_47297(System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, int
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDriver(powershell, extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, (System.Management.Automation.RemoteStreamOptions)streamOptions, addToHistory, rsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 46809, 47297);
                    return return_v;
                }


                System.IAsyncResult
                f_1657_47318_47332(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 47318, 47332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 44838, 47359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 44838, 47359);
            }
        }

        private void HandleHostResponseReceived(object sender,
                    RemoteDataEventArgs<RemoteHostResponse> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 47605, 47845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 47748, 47834);

                f_1657_47748_47833(f_1657_47748_47780(_remoteHost), (f_1657_47817_47831(eventArgs)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 47605, 47845);

                System.Management.Automation.Remoting.ServerMethodExecutor
                f_1657_47748_47780(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.ServerMethodExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 47748, 47780);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1657_47817_47831(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 47817, 47831);
                    return return_v;
                }


                int
                f_1657_47748_47833(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostResponse
                remoteHostResponse)
                {
                    this_param.HandleRemoteHostResponseFromClient(remoteHostResponse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 47748, 47833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 47605, 47845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 47605, 47845);
            }
        }

        private void HandleSetMaxRunspacesReceived(object sender, RemoteDataEventArgs<PSObject> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 48198, 48730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 48321, 48352);

                PSObject
                data = f_1657_48337_48351(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 48366, 48466);

                int
                maxRunspaces = (int)f_1657_48390_48465(((PSNoteProperty)f_1657_48407_48458(f_1657_48407_48422(data), RemoteDataNameStrings.MaxRunspaces)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 48480, 48570);

                long
                callId = (long)f_1657_48500_48569(((PSNoteProperty)f_1657_48517_48562(f_1657_48517_48532(data), RemoteDataNameStrings.CallId)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 48586, 48645);

                bool
                response = f_1657_48602_48644(f_1657_48602_48614(), maxRunspaces)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 48659, 48719);

                f_1657_48659_48718(f_1657_48659_48679(), callId, response);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 48198, 48730);

                System.Management.Automation.PSObject
                f_1657_48337_48351(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48337, 48351);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1657_48407_48422(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48407, 48422);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1657_48407_48458(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48407, 48458);
                    return return_v;
                }


                object
                f_1657_48390_48465(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48390, 48465);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1657_48517_48532(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48517, 48532);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1657_48517_48562(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48517, 48562);
                    return return_v;
                }


                object
                f_1657_48500_48569(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48500, 48569);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_48602_48614()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48602, 48614);
                    return return_v;
                }


                bool
                f_1657_48602_48644(System.Management.Automation.Runspaces.RunspacePool
                this_param, int
                maxRunspaces)
                {
                    var return_v = this_param.SetMaxRunspaces(maxRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 48602, 48644);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_48659_48679()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 48659, 48679);
                    return return_v;
                }


                int
                f_1657_48659_48718(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, long
                callId, bool
                response)
                {
                    this_param.SendResponseToClient(callId, (object)response);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 48659, 48718);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 48198, 48730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 48198, 48730);
            }
        }

        private void HandleSetMinRunspacesReceived(object sender, RemoteDataEventArgs<PSObject> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 49083, 49615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 49206, 49237);

                PSObject
                data = f_1657_49222_49236(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 49251, 49351);

                int
                minRunspaces = (int)f_1657_49275_49350(((PSNoteProperty)f_1657_49292_49343(f_1657_49292_49307(data), RemoteDataNameStrings.MinRunspaces)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 49365, 49455);

                long
                callId = (long)f_1657_49385_49454(((PSNoteProperty)f_1657_49402_49447(f_1657_49402_49417(data), RemoteDataNameStrings.CallId)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 49471, 49530);

                bool
                response = f_1657_49487_49529(f_1657_49487_49499(), minRunspaces)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 49544, 49604);

                f_1657_49544_49603(f_1657_49544_49564(), callId, response);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 49083, 49615);

                System.Management.Automation.PSObject
                f_1657_49222_49236(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49222, 49236);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1657_49292_49307(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49292, 49307);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1657_49292_49343(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49292, 49343);
                    return return_v;
                }


                object
                f_1657_49275_49350(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49275, 49350);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1657_49402_49417(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49402, 49417);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1657_49402_49447(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49402, 49447);
                    return return_v;
                }


                object
                f_1657_49385_49454(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49385, 49454);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_49487_49499()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49487, 49499);
                    return return_v;
                }


                bool
                f_1657_49487_49529(System.Management.Automation.Runspaces.RunspacePool
                this_param, int
                minRunspaces)
                {
                    var return_v = this_param.SetMinRunspaces(minRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 49487, 49529);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_49544_49564()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 49544, 49564);
                    return return_v;
                }


                int
                f_1657_49544_49603(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, long
                callId, bool
                response)
                {
                    this_param.SendResponseToClient(callId, (object)response);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 49544, 49603);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 49083, 49615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 49083, 49615);
            }
        }

        private void HandleGetAvailableRunspacesReceived(object sender, RemoteDataEventArgs<PSObject> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 49933, 50372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 50062, 50093);

                PSObject
                data = f_1657_50078_50092(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 50107, 50197);

                long
                callId = (long)f_1657_50127_50196(((PSNoteProperty)f_1657_50144_50189(f_1657_50144_50159(data), RemoteDataNameStrings.CallId)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 50213, 50275);

                int
                availableRunspaces = f_1657_50238_50274(f_1657_50238_50250())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 50291, 50361);

                f_1657_50291_50360(f_1657_50291_50311(), callId, availableRunspaces);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 49933, 50372);

                System.Management.Automation.PSObject
                f_1657_50078_50092(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50078, 50092);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1657_50144_50159(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50144, 50159);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1657_50144_50189(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50144, 50189);
                    return return_v;
                }


                object
                f_1657_50127_50196(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50127, 50196);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1657_50238_50250()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50238, 50250);
                    return return_v;
                }


                int
                f_1657_50238_50274(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.GetAvailableRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 50238, 50274);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_50291_50311()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50291, 50311);
                    return return_v;
                }


                int
                f_1657_50291_50360(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, long
                callId, int
                response)
                {
                    this_param.SendResponseToClient(callId, (object)response);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 50291, 50360);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 49933, 50372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 49933, 50372);
            }
        }

        private void HandleResetRunspaceState(object sender, RemoteDataEventArgs<PSObject> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 50590, 50948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 50708, 50810);

                long
                callId = (long)f_1657_50728_50809(((PSNoteProperty)f_1657_50745_50802(f_1657_50745_50772((f_1657_50746_50760(eventArgs))), RemoteDataNameStrings.CallId)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 50824, 50861);

                bool
                response = f_1657_50840_50860(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 50877, 50937);

                f_1657_50877_50936(f_1657_50877_50897(), callId, response);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 50590, 50948);

                System.Management.Automation.PSObject
                f_1657_50746_50760(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50746, 50760);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1657_50745_50772(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50745, 50772);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1657_50745_50802(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50745, 50802);
                    return return_v;
                }


                object
                f_1657_50728_50809(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50728, 50809);
                    return return_v;
                }


                bool
                f_1657_50840_50860(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.ResetRunspaceState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 50840, 50860);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1657_50877_50897()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 50877, 50897);
                    return return_v;
                }


                int
                f_1657_50877_50936(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, long
                callId, bool
                response)
                {
                    this_param.SendResponseToClient(callId, (object)response);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 50877, 50936);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 50590, 50948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 50590, 50948);
            }
        }

        private bool ResetRunspaceState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 51102, 51666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 51160, 51238);

                LocalRunspace
                runspaceToReset = _rsToUseForSteppablePipeline as LocalRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 51252, 51383) || true) && ((runspaceToReset == null) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 51256, 51321) || (f_1657_51286_51316(f_1657_51286_51298()) > 1)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 51252, 51383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 51355, 51368);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 51252, 51383);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 51483, 51520);

                    f_1657_51483_51519(                // Local runspace state reset.
                                    runspaceToReset);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 51549, 51627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 51599, 51612);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 51549, 51627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 51643, 51655);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 51102, 51666);

                System.Management.Automation.Runspaces.RunspacePool
                f_1657_51286_51298()
                {
                    var return_v = RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 51286, 51298);
                    return return_v;
                }


                int
                f_1657_51286_51316(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.GetMaxRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 51286, 51316);
                    return return_v;
                }


                int
                f_1657_51483_51519(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.ResetRunspaceState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 51483, 51519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 51102, 51666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 51102, 51666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void StartPowerShellCommandOnPushedRunspace(
                    PowerShell powershell,
                    PowerShell extraPowerShell,
                    Guid powershellId,
                    Guid runspacePoolId,
                    HostInfo hostInfo,
                    RemoteStreamOptions streamOptions,
                    bool noInput,
                    bool addToHistory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 52372, 53451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 52731, 52778);

                Runspace
                runspace = f_1657_52751_52777(_remoteHost)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 52794, 53184);

                ServerPowerShellDriver
                driver = f_1657_52826_53183(powershell, extraPowerShell, noInput, powershellId, runspacePoolId, this, ApartmentState.MTA, hostInfo, streamOptions, addToHistory, runspace)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 53236, 53251);

                    f_1657_53236_53250(driver);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 53280, 53440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 53373, 53399);

                    f_1657_53373_53398(                // Pop runspace on error.
                                    _remoteHost);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 53419, 53425);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 53280, 53440);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 52372, 53451);

                System.Management.Automation.Runspaces.Runspace
                f_1657_52751_52777(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.PushedRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 52751, 52777);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDriver
                f_1657_52826_53183(System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDriver(powershell, extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 52826, 53183);
                    return return_v;
                }


                System.IAsyncResult
                f_1657_53236_53250(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 53236, 53250);
                    return return_v;
                }


                int
                f_1657_53373_53398(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    this_param.PopRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 53373, 53398);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 52372, 53451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 52372, 53451);
            }
        }



        /// <summary>
        /// Debugger command pre processing result type.
        /// </summary>
        private enum PreProcessCommandResult
        {
            /// <summary>
            /// No debugger pre-processing. "Get" commands use this so that the
            /// data they retrieve can be sent back to the caller.
            /// </summary>
            None = 0,

            /// <summary>
            /// This is a valid debugger command but was not processed because
            /// the debugger state was not correct.
            /// </summary>
            ValidNotProcessed,

            /// <summary>
            /// SetDebuggerAction.
            /// </summary>
            SetDebuggerAction,

            /// <summary>
            /// SetDebugMode.
            /// </summary>
            SetDebugMode,

            /// <summary>
            /// SetDebuggerStepMode.
            /// </summary>
            SetDebuggerStepMode,

            /// <summary>
            /// SetPreserveUnhandledBreakpointMode.
            /// </summary>
            SetPreserveUnhandledBreakpointMode,

            /// <summary>
            /// The PreProcessCommandResult used for managing breakpoints.
            /// </summary>
            BreakpointManagement,
        };
        private class DebuggerCommandArgument
        {
            public DebugModes? Mode { get; set; }

            public DebuggerResumeAction? ResumeAction { get; set; }

            public bool? DebuggerStepEnabled { get; set; }

            public UnhandledBreakpointProcessingMode? UnhandledBreakpointMode { get; set; }

            public DebuggerCommandArgument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 54873, 55211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 54935, 54972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 54988, 55043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 55059, 55105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 55121, 55200);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 54873, 55211);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 54873, 55211);
            }


            static DebuggerCommandArgument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1657, 54873, 55211);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1657, 54873, 55211);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 54873, 55211);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1657, 54873, 55211);
        }

        private static PreProcessCommandResult PreProcessDebuggerCommand(
                    PSCommand commands,
                    ServerRemoteDebugger serverRemoteDebugger,
                    Collection<object> preProcessOutput,
                    out DebuggerCommandArgument commandArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1657, 55882, 67932);
                int? runspaceId = default(int?);
                int breakpointId = default(int);
                System.Management.Automation.Breakpoint breakpoint = default(System.Management.Automation.Breakpoint);
                System.Collections.ArrayList breakpoints = default(System.Collections.ArrayList);
                System.Management.Automation.Breakpoint bp = default(System.Management.Automation.Breakpoint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56169, 56217);

                commandArgument = f_1657_56187_56216();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56231, 56293);

                PreProcessCommandResult
                result = PreProcessCommandResult.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56309, 56437) || true) && (f_1657_56313_56336(f_1657_56313_56330(commands)) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1657, 56313, 56374) || f_1657_56345_56374(f_1657_56345_56365(f_1657_56345_56362(commands), 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 56309, 56437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56408, 56422);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 56309, 56437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56453, 56488);

                var
                command = f_1657_56467_56487(f_1657_56467_56484(commands), 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56502, 56543);

                string
                commandText = f_1657_56523_56542(command)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56557, 67891) || true) && (f_1657_56561_56660(commandText, RemoteDebuggingCommands.GetDebuggerStopArgs, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 56557, 67891);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 56942, 57086) || true) && (f_1657_56946_56976_M(!serverRemoteDebugger.IsActive))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 56942, 57086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 57018, 57067);

                        return PreProcessCommandResult.ValidNotProcessed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 56942, 57086);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 57106, 57197);

                    f_1657_57106_57196(commands, "$host.Runspace.Debugger.GetDebuggerStopArgs()");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 56557, 67891);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 56557, 67891);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 57231, 67891) || true) && (f_1657_57235_57332(commandText, RemoteDebuggingCommands.SetDebuggerAction, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 57231, 67891);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 57610, 57754) || true) && (f_1657_57614_57644_M(!serverRemoteDebugger.IsActive))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 57610, 57754);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 57686, 57735);

                            return PreProcessCommandResult.ValidNotProcessed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 57610, 57754);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 57774, 58061) || true) && ((f_1657_57779_57797(command) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 57778, 57841) || (f_1657_57811_57835(f_1657_57811_57829(command)) == 0)) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 57778, 57954) || (!f_1657_57868_57953(f_1657_57868_57894(f_1657_57868_57889(f_1657_57868_57886(command), 0)), "ResumeAction", StringComparison.OrdinalIgnoreCase))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 57774, 58061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 57996, 58042);

                            throw f_1657_58002_58041("ResumeAction");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 57774, 58061);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 58081, 58123);

                        DebuggerResumeAction?
                        resumeAction = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 58141, 58205);

                        PSObject
                        resumeObject = f_1657_58165_58192(f_1657_58165_58186(f_1657_58165_58183(command), 0)) as PSObject
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 58223, 58580) || true) && (resumeObject != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 58223, 58580);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 58341, 58402);

                                resumeAction = (DebuggerResumeAction)f_1657_58378_58401(resumeObject);
                            }
                            catch (InvalidCastException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 58447, 58561);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 58447, 58561);
                                // Do nothing.
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 58223, 58580);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 58600, 58693);

                        commandArgument.ResumeAction = resumeAction ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.DebuggerResumeAction?>(1657, 58631, 58692) ?? throw f_1657_58653_58692("ResumeAction"));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 58711, 58762);

                        result = PreProcessCommandResult.SetDebuggerAction;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 57231, 67891);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 57231, 67891);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 58796, 67891) || true) && (f_1657_58800_58892(commandText, RemoteDebuggingCommands.SetDebugMode, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 58796, 67891);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59076, 59347) || true) && ((f_1657_59081_59099(command) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 59080, 59143) || (f_1657_59113_59137(f_1657_59113_59131(command)) == 0)) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 59080, 59248) || (!f_1657_59170_59247(f_1657_59170_59196(f_1657_59170_59191(f_1657_59170_59188(command), 0)), "Mode", StringComparison.OrdinalIgnoreCase))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 59076, 59347);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59290, 59328);

                                throw f_1657_59296_59327("Mode");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 59076, 59347);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59367, 59391);

                            DebugModes?
                            mode = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59409, 59471);

                            PSObject
                            modeObject = f_1657_59431_59458(f_1657_59431_59452(f_1657_59431_59449(command), 0)) as PSObject
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59489, 59824) || true) && (modeObject != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 59489, 59824);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59605, 59646);

                                    mode = (DebugModes)f_1657_59624_59645(modeObject);
                                }
                                catch (InvalidCastException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 59691, 59805);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 59691, 59805);
                                    // Do nothing.
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 59489, 59824);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59844, 59913);

                            commandArgument.Mode = mode ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.DebugModes?>(1657, 59867, 59912) ?? throw f_1657_59881_59912("Mode"));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 59931, 59977);

                            result = PreProcessCommandResult.SetDebugMode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 58796, 67891);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 58796, 67891);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 60011, 67891) || true) && (f_1657_60015_60114(commandText, RemoteDebuggingCommands.SetDebuggerStepMode, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 60011, 67891);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 60305, 60581) || true) && ((f_1657_60310_60328(command) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 60309, 60372) || (f_1657_60342_60366(f_1657_60342_60360(command)) == 0)) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 60309, 60479) || (!f_1657_60398_60478(f_1657_60398_60424(f_1657_60398_60419(f_1657_60398_60416(command), 0)), "Enabled", StringComparison.OrdinalIgnoreCase))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 60305, 60581);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 60521, 60562);

                                    throw f_1657_60527_60561("Enabled");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 60305, 60581);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 60601, 60650);

                                bool
                                enabled = (bool)f_1657_60622_60649(f_1657_60622_60643(f_1657_60622_60640(command), 0))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 60668, 60714);

                                commandArgument.DebuggerStepEnabled = enabled;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 60732, 60785);

                                result = PreProcessCommandResult.SetDebuggerStepMode;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 60011, 67891);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 60011, 67891);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 60819, 67891) || true) && (f_1657_60823_60929(commandText, RemoteDebuggingCommands.SetUnhandledBreakpointMode, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 60819, 67891);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 61135, 61443) || true) && ((f_1657_61140_61158(command) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 61139, 61202) || (f_1657_61172_61196(f_1657_61172_61190(command)) == 0)) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 61139, 61325) || (!f_1657_61228_61324(f_1657_61228_61254(f_1657_61228_61249(f_1657_61228_61246(command), 0)), "UnhandledBreakpointMode", StringComparison.OrdinalIgnoreCase))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 61135, 61443);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 61367, 61424);

                                        throw f_1657_61373_61423("UnhandledBreakpointMode");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 61135, 61443);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 61463, 61510);

                                    UnhandledBreakpointProcessingMode?
                                    mode = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 61528, 61590);

                                    PSObject
                                    modeObject = f_1657_61550_61577(f_1657_61550_61571(f_1657_61550_61568(command), 0)) as PSObject
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 61608, 61966) || true) && (modeObject != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 61608, 61966);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 61724, 61788);

                                            mode = (UnhandledBreakpointProcessingMode)f_1657_61766_61787(modeObject);
                                        }
                                        catch (InvalidCastException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 61833, 61947);
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 61833, 61947);
                                            // Do nothing.
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 61608, 61966);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 61986, 62074);

                                    commandArgument.UnhandledBreakpointMode = mode ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.UnhandledBreakpointProcessingMode?>(1657, 62028, 62073) ?? throw f_1657_62042_62073("Mode"));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 62092, 62160);

                                    result = PreProcessCommandResult.SetPreserveUnhandledBreakpointMode;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 60819, 67891);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 60819, 67891);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 62194, 67891) || true) && (f_1657_62198_62291(commandText, RemoteDebuggingCommands.GetBreakpoint, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 62194, 67891);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 62509, 62575);

                                        f_1657_62509_62574(command, "RunspaceId", out runspaceId);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 62593, 63068) || true) && (f_1657_62597_62654(command, "Id", out breakpointId))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 62593, 63068);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 62697, 62780);

                                            f_1657_62697_62779(preProcessOutput, f_1657_62718_62778(serverRemoteDebugger, breakpointId, runspaceId));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 62593, 63068);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 62593, 63068);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 62862, 63049);
                                                foreach (Breakpoint breakpoint2 in f_1657_62896_62943_I(f_1657_62896_62943(serverRemoteDebugger, runspaceId)))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 62862, 63049);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 62993, 63026);

                                                    f_1657_62993_63025(preProcessOutput, breakpoint2);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 62862, 63049);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 1, 188);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 1, 188);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 62593, 63068);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 63088, 63142);

                                        result = PreProcessCommandResult.BreakpointManagement;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 62194, 67891);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 62194, 67891);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 63176, 67891) || true) && (f_1657_63180_63273(commandText, RemoteDebuggingCommands.SetBreakpoint, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 63176, 67891);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 63590, 63668);

                                            f_1657_63590_63667(command, "Breakpoint", out breakpoint);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 63686, 63767);

                                            f_1657_63686_63766(command, "BreakpointList", out breakpoints);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 63785, 63977) || true) && (breakpoint == null && (DynAbs.Tracing.TraceSender.Expression_True(1657, 63789, 63830) && breakpoints == null))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 63785, 63977);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 63872, 63958);

                                                throw f_1657_63878_63957(f_1657_63902_63956());
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 63785, 63977);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 63997, 64063);

                                            f_1657_63997_64062(command, "RunspaceId", out runspaceId);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64083, 64100);

                                            f_1657_64083_64099(
                                                            commands);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64293, 64326);

                                            var
                                            bps = f_1657_64303_64325()
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64344, 64919) || true) && (breakpoints != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 64344, 64919);
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64409, 64798);
                                                    foreach (object obj in f_1657_64432_64443_I(breakpoints))
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 64409, 64798);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64493, 64735) || true) && (!f_1657_64498_64565(obj, out bp))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 64493, 64735);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64623, 64708);

                                                            throw f_1657_64629_64707(f_1657_64653_64706());
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 64493, 64735);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64763, 64775);

                                                        f_1657_64763_64774(
                                                                                bps, bp);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 64409, 64798);
                                                    }
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 1, 390);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 1, 390);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 64344, 64919);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 64344, 64919);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64880, 64900);

                                                f_1657_64880_64899(bps, breakpoint);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 64344, 64919);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 64939, 64992);

                                            f_1657_64939_64991(
                                                            serverRemoteDebugger, bps, runspaceId);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65028, 65136);
                                                foreach (var bp2 in f_1657_65047_65050_I(bps))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 65028, 65136);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65092, 65117);

                                                    f_1657_65092_65116(preProcessOutput, bp2);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 65028, 65136);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 1, 109);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 1, 109);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65156, 65210);

                                            result = PreProcessCommandResult.BreakpointManagement;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 63176, 67891);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 63176, 67891);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65244, 67891) || true) && (f_1657_65248_65344(commandText, RemoteDebuggingCommands.RemoveBreakpoint, StringComparison.OrdinalIgnoreCase))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 65244, 67891);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65588, 65640);

                                                int
                                                breakpointId2 = f_1657_65607_65639(command, "Id")
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65658, 65724);

                                                f_1657_65658_65723(command, "RunspaceId", out runspaceId);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65744, 65829);

                                                Breakpoint
                                                breakpoint2 = f_1657_65768_65828(serverRemoteDebugger, breakpointId2, runspaceId)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 65847, 66033);

                                                f_1657_65847_66032(preProcessOutput, (DynAbs.Tracing.TraceSender.Conditional_F1(1657, 65890, 65908) || ((breakpoint2 == null
                                                && DynAbs.Tracing.TraceSender.Conditional_F2(1657, 65937, 65942)) || DynAbs.Tracing.TraceSender.Conditional_F3(1657, 65970, 66031))) ? false
                                                : f_1657_65970_66031(serverRemoteDebugger, breakpoint2, runspaceId));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66053, 66107);

                                                result = PreProcessCommandResult.BreakpointManagement;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 65244, 67891);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 65244, 67891);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66141, 67891) || true) && (f_1657_66145_66241(commandText, RemoteDebuggingCommands.EnableBreakpoint, StringComparison.OrdinalIgnoreCase))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 66141, 67891);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66498, 66550);

                                                    int
                                                    breakpointId3 = f_1657_66517_66549(command, "Id")
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66568, 66634);

                                                    f_1657_66568_66633(command, "RunspaceId", out runspaceId);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66654, 66731);

                                                    Breakpoint
                                                    bp3 = f_1657_66670_66730(serverRemoteDebugger, breakpointId3, runspaceId)
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66749, 66900) || true) && (bp3 != null)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 66749, 66900);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66805, 66881);

                                                        f_1657_66805_66880(preProcessOutput, f_1657_66826_66879(serverRemoteDebugger, bp3, runspaceId));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 66749, 66900);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 66936, 66990);

                                                    result = PreProcessCommandResult.BreakpointManagement;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 66141, 67891);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 66141, 67891);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67024, 67891) || true) && (f_1657_67028_67125(commandText, RemoteDebuggingCommands.DisableBreakpoint, StringComparison.OrdinalIgnoreCase))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 67024, 67891);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67383, 67435);

                                                        int
                                                        breakpointId4 = f_1657_67402_67434(command, "Id")
                                                        ;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67453, 67519);

                                                        f_1657_67453_67518(command, "RunspaceId", out runspaceId);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67539, 67616);

                                                        Breakpoint
                                                        bp4 = f_1657_67555_67615(serverRemoteDebugger, breakpointId4, runspaceId)
                                                        ;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67634, 67786) || true) && (bp4 != null)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 67634, 67786);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67690, 67767);

                                                            f_1657_67690_67766(preProcessOutput, f_1657_67711_67765(serverRemoteDebugger, bp4, runspaceId));
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 67634, 67786);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67822, 67876);

                                                        result = PreProcessCommandResult.BreakpointManagement;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 67024, 67891);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 66141, 67891);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 65244, 67891);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 63176, 67891);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 62194, 67891);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 60819, 67891);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 60011, 67891);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 58796, 67891);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 57231, 67891);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 56557, 67891);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 67907, 67921);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1657, 55882, 67932);

                System.Management.Automation.ServerRunspacePoolDriver.DebuggerCommandArgument
                f_1657_56187_56216()
                {
                    var return_v = new System.Management.Automation.ServerRunspacePoolDriver.DebuggerCommandArgument();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 56187, 56216);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1657_56313_56330(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56313, 56330);
                    return return_v;
                }


                int
                f_1657_56313_56336(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56313, 56336);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1657_56345_56362(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56345, 56362);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_56345_56365(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56345, 56365);
                    return return_v;
                }


                bool
                f_1657_56345_56374(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.IsScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56345, 56374);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1657_56467_56484(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56467, 56484);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1657_56467_56487(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56467, 56487);
                    return return_v;
                }


                string
                f_1657_56523_56542(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56523, 56542);
                    return return_v;
                }


                bool
                f_1657_56561_56660(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 56561, 56660);
                    return return_v;
                }


                bool
                f_1657_56946_56976_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 56946, 56976);
                    return return_v;
                }


                int
                f_1657_57106_57196(System.Management.Automation.PSCommand
                commands, string
                script)
                {
                    ReplaceVirtualCommandWithScript(commands, script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 57106, 57196);
                    return 0;
                }


                bool
                f_1657_57235_57332(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 57235, 57332);
                    return return_v;
                }


                bool
                f_1657_57614_57644_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 57614, 57644);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_57779_57797(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 57779, 57797);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_57811_57829(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 57811, 57829);
                    return return_v;
                }


                int
                f_1657_57811_57835(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 57811, 57835);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_57868_57886(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 57868, 57886);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_57868_57889(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 57868, 57889);
                    return return_v;
                }


                string
                f_1657_57868_57894(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 57868, 57894);
                    return return_v;
                }


                bool
                f_1657_57868_57953(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 57868, 57953);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_58002_58041(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 58002, 58041);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_58165_58183(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 58165, 58183);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_58165_58186(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 58165, 58186);
                    return return_v;
                }


                object
                f_1657_58165_58192(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 58165, 58192);
                    return return_v;
                }


                object
                f_1657_58378_58401(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 58378, 58401);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_58653_58692(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 58653, 58692);
                    return return_v;
                }


                bool
                f_1657_58800_58892(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 58800, 58892);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_59081_59099(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59081, 59099);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_59113_59131(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59113, 59131);
                    return return_v;
                }


                int
                f_1657_59113_59137(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59113, 59137);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_59170_59188(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59170, 59188);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_59170_59191(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59170, 59191);
                    return return_v;
                }


                string
                f_1657_59170_59196(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59170, 59196);
                    return return_v;
                }


                bool
                f_1657_59170_59247(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 59170, 59247);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_59296_59327(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 59296, 59327);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_59431_59449(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59431, 59449);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_59431_59452(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59431, 59452);
                    return return_v;
                }


                object
                f_1657_59431_59458(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59431, 59458);
                    return return_v;
                }


                object
                f_1657_59624_59645(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 59624, 59645);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_59881_59912(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 59881, 59912);
                    return return_v;
                }


                bool
                f_1657_60015_60114(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 60015, 60114);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_60310_60328(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60310, 60328);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_60342_60360(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60342, 60360);
                    return return_v;
                }


                int
                f_1657_60342_60366(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60342, 60366);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_60398_60416(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60398, 60416);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_60398_60419(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60398, 60419);
                    return return_v;
                }


                string
                f_1657_60398_60424(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60398, 60424);
                    return return_v;
                }


                bool
                f_1657_60398_60478(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 60398, 60478);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_60527_60561(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 60527, 60561);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_60622_60640(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60622, 60640);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_60622_60643(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60622, 60643);
                    return return_v;
                }


                object
                f_1657_60622_60649(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 60622, 60649);
                    return return_v;
                }


                bool
                f_1657_60823_60929(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 60823, 60929);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_61140_61158(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61140, 61158);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_61172_61190(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61172, 61190);
                    return return_v;
                }


                int
                f_1657_61172_61196(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61172, 61196);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_61228_61246(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61228, 61246);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_61228_61249(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61228, 61249);
                    return return_v;
                }


                string
                f_1657_61228_61254(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61228, 61254);
                    return return_v;
                }


                bool
                f_1657_61228_61324(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 61228, 61324);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_61373_61423(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 61373, 61423);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_61550_61568(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61550, 61568);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1657_61550_61571(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61550, 61571);
                    return return_v;
                }


                object
                f_1657_61550_61577(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61550, 61577);
                    return return_v;
                }


                object
                f_1657_61766_61787(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 61766, 61787);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_62042_62073(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62042, 62073);
                    return return_v;
                }


                bool
                f_1657_62198_62291(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62198, 62291);
                    return return_v;
                }


                bool
                f_1657_62509_62574(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out int?
                value)
                {
                    var return_v = TryGetParameter<int?>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62509, 62574);
                    return return_v;
                }


                bool
                f_1657_62597_62654(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out int
                value)
                {
                    var return_v = TryGetParameter<int>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62597, 62654);
                    return return_v;
                }


                System.Management.Automation.Breakpoint
                f_1657_62718_62778(System.Management.Automation.ServerRemoteDebugger
                this_param, int
                id, int?
                runspaceId)
                {
                    var return_v = this_param.GetBreakpoint(id, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62718, 62778);
                    return return_v;
                }


                int
                f_1657_62697_62779(System.Collections.ObjectModel.Collection<object>
                this_param, System.Management.Automation.Breakpoint
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62697, 62779);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                f_1657_62896_62943(System.Management.Automation.ServerRemoteDebugger
                this_param, int?
                runspaceId)
                {
                    var return_v = this_param.GetBreakpoints(runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62896, 62943);
                    return return_v;
                }


                int
                f_1657_62993_63025(System.Collections.ObjectModel.Collection<object>
                this_param, System.Management.Automation.Breakpoint
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62993, 63025);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                f_1657_62896_62943_I(System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 62896, 62943);
                    return return_v;
                }


                bool
                f_1657_63180_63273(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 63180, 63273);
                    return return_v;
                }


                bool
                f_1657_63590_63667(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out System.Management.Automation.Breakpoint
                value)
                {
                    var return_v = TryGetParameter<Breakpoint>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 63590, 63667);
                    return return_v;
                }


                bool
                f_1657_63686_63766(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out System.Collections.ArrayList
                value)
                {
                    var return_v = TryGetParameter<ArrayList>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 63686, 63766);
                    return return_v;
                }


                string
                f_1657_63902_63956()
                {
                    var return_v = DebuggerStrings.BreakpointOrBreakpointListNotSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 63902, 63956);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_63878_63957(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 63878, 63957);
                    return return_v;
                }


                bool
                f_1657_63997_64062(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out int?
                value)
                {
                    var return_v = TryGetParameter<int?>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 63997, 64062);
                    return return_v;
                }


                int
                f_1657_64083_64099(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64083, 64099);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                f_1657_64303_64325()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Breakpoint>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64303, 64325);
                    return return_v;
                }


                bool
                f_1657_64498_64565(object
                valueToConvert, out System.Management.Automation.Breakpoint
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<Breakpoint>(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64498, 64565);
                    return return_v;
                }


                string
                f_1657_64653_64706()
                {
                    var return_v = DebuggerStrings.BreakpointListContainedANonBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 64653, 64706);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_64629_64707(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64629, 64707);
                    return return_v;
                }


                int
                f_1657_64763_64774(System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                this_param, System.Management.Automation.Breakpoint
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64763, 64774);
                    return 0;
                }


                System.Collections.ArrayList
                f_1657_64432_64443_I(System.Collections.ArrayList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64432, 64443);
                    return return_v;
                }


                int
                f_1657_64880_64899(System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                this_param, System.Management.Automation.Breakpoint
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64880, 64899);
                    return 0;
                }


                int
                f_1657_64939_64991(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                breakpoints, int?
                runspaceId)
                {
                    this_param.SetBreakpoints((System.Collections.Generic.IEnumerable<System.Management.Automation.Breakpoint>)breakpoints, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 64939, 64991);
                    return 0;
                }


                int
                f_1657_65092_65116(System.Collections.ObjectModel.Collection<object>
                this_param, System.Management.Automation.Breakpoint
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65092, 65116);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                f_1657_65047_65050_I(System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65047, 65050);
                    return return_v;
                }


                bool
                f_1657_65248_65344(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65248, 65344);
                    return return_v;
                }


                int
                f_1657_65607_65639(System.Management.Automation.Runspaces.Command
                command, string
                parameterName)
                {
                    var return_v = GetParameter<int>(command, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65607, 65639);
                    return return_v;
                }


                bool
                f_1657_65658_65723(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out int?
                value)
                {
                    var return_v = TryGetParameter<int?>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65658, 65723);
                    return return_v;
                }


                System.Management.Automation.Breakpoint
                f_1657_65768_65828(System.Management.Automation.ServerRemoteDebugger
                this_param, int
                id, int?
                runspaceId)
                {
                    var return_v = this_param.GetBreakpoint(id, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65768, 65828);
                    return return_v;
                }


                bool
                f_1657_65970_66031(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Breakpoint
                breakpoint, int?
                runspaceId)
                {
                    var return_v = this_param.RemoveBreakpoint(breakpoint, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65970, 66031);
                    return return_v;
                }


                int
                f_1657_65847_66032(System.Collections.ObjectModel.Collection<object>
                this_param, bool
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 65847, 66032);
                    return 0;
                }


                bool
                f_1657_66145_66241(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 66145, 66241);
                    return return_v;
                }


                int
                f_1657_66517_66549(System.Management.Automation.Runspaces.Command
                command, string
                parameterName)
                {
                    var return_v = GetParameter<int>(command, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 66517, 66549);
                    return return_v;
                }


                bool
                f_1657_66568_66633(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out int?
                value)
                {
                    var return_v = TryGetParameter<int?>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 66568, 66633);
                    return return_v;
                }


                System.Management.Automation.Breakpoint
                f_1657_66670_66730(System.Management.Automation.ServerRemoteDebugger
                this_param, int
                id, int?
                runspaceId)
                {
                    var return_v = this_param.GetBreakpoint(id, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 66670, 66730);
                    return return_v;
                }


                System.Management.Automation.Breakpoint
                f_1657_66826_66879(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Breakpoint
                breakpoint, int?
                runspaceId)
                {
                    var return_v = this_param.EnableBreakpoint(breakpoint, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 66826, 66879);
                    return return_v;
                }


                int
                f_1657_66805_66880(System.Collections.ObjectModel.Collection<object>
                this_param, System.Management.Automation.Breakpoint
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 66805, 66880);
                    return 0;
                }


                bool
                f_1657_67028_67125(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 67028, 67125);
                    return return_v;
                }


                int
                f_1657_67402_67434(System.Management.Automation.Runspaces.Command
                command, string
                parameterName)
                {
                    var return_v = GetParameter<int>(command, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 67402, 67434);
                    return return_v;
                }


                bool
                f_1657_67453_67518(System.Management.Automation.Runspaces.Command
                command, string
                parameterName, out int?
                value)
                {
                    var return_v = TryGetParameter<int?>(command, parameterName, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 67453, 67518);
                    return return_v;
                }


                System.Management.Automation.Breakpoint
                f_1657_67555_67615(System.Management.Automation.ServerRemoteDebugger
                this_param, int
                id, int?
                runspaceId)
                {
                    var return_v = this_param.GetBreakpoint(id, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 67555, 67615);
                    return return_v;
                }


                System.Management.Automation.Breakpoint
                f_1657_67711_67765(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Breakpoint
                breakpoint, int?
                runspaceId)
                {
                    var return_v = this_param.DisableBreakpoint(breakpoint, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 67711, 67765);
                    return return_v;
                }


                int
                f_1657_67690_67766(System.Collections.ObjectModel.Collection<object>
                this_param, System.Management.Automation.Breakpoint
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 67690, 67766);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 55882, 67932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 55882, 67932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReplaceVirtualCommandWithScript(PSCommand commands, string script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1657, 67944, 68389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68055, 68108);

                ScriptBlock
                scriptBlock = f_1657_68081_68107(script)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68122, 68177);

                scriptBlock.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68191, 68208);

                f_1657_68191_68207(commands);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68222, 68378);

                f_1657_68222_68377(f_1657_68222_68322(f_1657_68222_68259(commands, "Invoke-Command"), "ScriptBlock", scriptBlock), "NoNewScope", true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1657, 67944, 68389);

                System.Management.Automation.ScriptBlock
                f_1657_68081_68107(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68081, 68107);
                    return return_v;
                }


                int
                f_1657_68191_68207(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68191, 68207);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1657_68222_68259(System.Management.Automation.PSCommand
                this_param, string
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68222, 68259);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_68222_68322(System.Management.Automation.PSCommand
                this_param, string
                parameterName, System.Management.Automation.ScriptBlock
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68222, 68322);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_68222_68377(System.Management.Automation.PSCommand
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68222, 68377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 67944, 68389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 67944, 68389);
            }
        }

        private static T GetParameter<T>(Command command, string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1657, 68401, 69008);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68497, 68625) || true) && (f_1657_68501_68526_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1657_68501_68519(command), 1657, 68501, 68526)?.Count) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 68497, 68625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68565, 68610);

                    throw f_1657_68571_68609(parameterName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 68497, 68625);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68641, 68936);
                    foreach (CommandParameter param in f_1657_68676_68694_I(f_1657_68676_68694(command)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 68641, 68936);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68728, 68921) || true) && (f_1657_68732_68808(f_1657_68746_68756(param), parameterName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 68728, 68921);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68850, 68902);

                            return f_1657_68857_68901(f_1657_68889_68900(param));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 68728, 68921);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 68641, 68936);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 1, 296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 1, 296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 68952, 68997);

                throw f_1657_68958_68996(parameterName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1657, 68401, 69008);

                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_68501_68519(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 68501, 68519);
                    return return_v;
                }


                int?
                f_1657_68501_68526_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 68501, 68526);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_68571_68609(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68571, 68609);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_68676_68694(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 68676, 68694);
                    return return_v;
                }


                string
                f_1657_68746_68756(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 68746, 68756);
                    return return_v;
                }


                bool
                f_1657_68732_68808(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68732, 68808);
                    return return_v;
                }


                object
                f_1657_68889_68900(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 68889, 68900);
                    return return_v;
                }


                T
                f_1657_68857_68901(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<T>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68857, 68901);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1657_68676_68694_I(System.Management.Automation.Runspaces.CommandParameterCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68676, 68694);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1657_68958_68996(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 68958, 68996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 68401, 69008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 68401, 69008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetParameter<T>(Command command, string parameterName, out T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1657, 69020, 69553);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 69171, 69219);

                    value = f_1657_69179_69218(command, parameterName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 69237, 69249);

                    return true;
                }
                catch (Exception ex) when (
                    ex is PSArgumentException || (DynAbs.Tracing.TraceSender.Expression_False(1657, 69322, 69394) || ex is InvalidCastException) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 69322, 69443) || ex is PSInvalidCastException))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 69278, 69542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 69477, 69496);

                    value = default(T);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 69514, 69527);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 69278, 69542);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1657, 69020, 69553);

                T
                f_1657_69179_69218(System.Management.Automation.Runspaces.Command
                command, string
                parameterName)
                {
                    var return_v = GetParameter<T>(command, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 69179, 69218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 69020, 69553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 69020, 69553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class PowerShellDriverInvoker
        {
            private ConcurrentStack<InvokePump> _invokePumpStack;

            public PowerShellDriverInvoker()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 70164, 70297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 69985, 70001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 70229, 70282);

                    _invokePumpStack = f_1657_70248_70281();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 70164, 70297);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 70164, 70297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 70164, 70297);
                }
            }

            public bool IsActive
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 70508, 70549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 70514, 70547);

                        return f_1657_70521_70546_M(!_invokePumpStack.IsEmpty);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 70508, 70549);

                        bool
                        f_1657_70521_70546_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 70521, 70546);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 70455, 70564);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 70455, 70564);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsAvailable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 70763, 71059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 70807, 70823);

                        InvokePump
                        pump
                        = default(InvokePump);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 70845, 70969) || true) && (!f_1657_70850_70884(_invokePumpStack, out pump))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 70845, 70969);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 70934, 70946);

                            pump = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 70845, 70969);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 70993, 71040);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1657, 71000, 71014) || (((pump != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1657, 71017, 71031)) || DynAbs.Tracing.TraceSender.Conditional_F3(1657, 71034, 71039))) ? f_1657_71017_71031_M(!(f_1657_71019_71030(pump))) : false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 70763, 71059);

                        bool
                        f_1657_70850_70884(System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump>
                        this_param, out System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                        result)
                        {
                            var return_v = this_param.TryPeek(out result);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 70850, 70884);
                            return return_v;
                        }


                        bool
                        f_1657_71019_71030(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                        this_param)
                        {
                            var return_v = this_param.IsBusy;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 71019, 71030);
                            return return_v;
                        }


                        bool
                        f_1657_71017_71031_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 71017, 71031);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 70707, 71074);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 70707, 71074);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void InvokeDriverAsync(ServerPowerShellDriver driver)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 71334, 71731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 71427, 71450);

                    InvokePump
                    currentPump
                    = default(InvokePump);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 71468, 71667) || true) && (!f_1657_71473_71514(_invokePumpStack, out currentPump))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 71468, 71667);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 71556, 71648);

                        throw f_1657_71562_71647(f_1657_71594_71646());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 71468, 71667);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 71687, 71716);

                    f_1657_71687_71715(
                                    currentPump, driver);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 71334, 71731);

                    bool
                    f_1657_71473_71514(System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump>
                    this_param, out System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                    result)
                    {
                        var return_v = this_param.TryPeek(out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 71473, 71514);
                        return return_v;
                    }


                    string
                    f_1657_71594_71646()
                    {
                        var return_v = RemotingErrorIdStrings.PowerShellInvokerInvalidState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 71594, 71646);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1657_71562_71647(string
                    message)
                    {
                        var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 71562, 71647);
                        return return_v;
                    }


                    int
                    f_1657_71687_71715(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                    this_param, System.Management.Automation.ServerPowerShellDriver
                    driver)
                    {
                        this_param.Dispatch(driver);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 71687, 71715);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 71334, 71731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 71334, 71731);
                }
            }

            public void PushInvoker()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 71943, 72247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 72001, 72039);

                    InvokePump
                    newPump = f_1657_72022_72038()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 72057, 72088);

                    f_1657_72057_72087(_invokePumpStack, newPump);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 72216, 72232);

                    f_1657_72216_72231(
                                    // Blocking call while new driver invocations are handled on
                                    // new pump.
                                    newPump);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 71943, 72247);

                    System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                    f_1657_72022_72038()
                    {
                        var return_v = new System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 72022, 72038);
                        return return_v;
                    }


                    int
                    f_1657_72057_72087(System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump>
                    this_param, System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 72057, 72087);
                        return 0;
                    }


                    int
                    f_1657_72216_72231(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                    this_param)
                    {
                        this_param.Start();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 72216, 72231);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 71943, 72247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 71943, 72247);
                }
            }

            public void PopInvoker()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 72478, 72872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 72535, 72554);

                    InvokePump
                    oldPump
                    = default(InvokePump);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 72572, 72857) || true) && (f_1657_72576_72612(_invokePumpStack, out oldPump))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 72572, 72857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 72654, 72669);

                        f_1657_72654_72668(oldPump);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 72572, 72857);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 72572, 72857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 72751, 72838);

                        throw f_1657_72757_72837(f_1657_72789_72836());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 72572, 72857);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 72478, 72872);

                    bool
                    f_1657_72576_72612(System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump>
                    this_param, out System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                    result)
                    {
                        var return_v = this_param.TryPop(out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 72576, 72612);
                        return return_v;
                    }


                    int
                    f_1657_72654_72668(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                    this_param)
                    {
                        this_param.Stop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 72654, 72668);
                        return 0;
                    }


                    string
                    f_1657_72789_72836()
                    {
                        var return_v = RemotingErrorIdStrings.CannotExitNestedPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 72789, 72836);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1657_72757_72837(string
                    message)
                    {
                        var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 72757, 72837);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 72478, 72872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 72478, 72872);
                }
            }
            private sealed class InvokePump
            {
                private Queue<ServerPowerShellDriver> _driverInvokeQueue;

                private ManualResetEvent _processDrivers;

                private object _syncObject;

                private bool _stopPump;

                private bool _isDisposed;

                public InvokePump()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 73445, 73698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73218, 73236);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73280, 73295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73329, 73340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73372, 73381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73413, 73424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76289, 76329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73505, 73562);

                        _driverInvokeQueue = f_1657_73526_73561();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73584, 73630);

                        _processDrivers = f_1657_73602_73629(false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73652, 73679);

                        _syncObject = f_1657_73666_73678();
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 73445, 73698);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 73445, 73698);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 73445, 73698);
                    }
                }

                public void Start()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 73718, 75632);
                        try
                        {
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73830, 75418) || true) && (true)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 73830, 75418);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 73899, 73925);

                                    f_1657_73899_73924(_processDrivers);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74048, 74085);

                                    ServerPowerShellDriver
                                    driver = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74123, 74134);

                                    lock (_syncObject)
                                    {

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74200, 74328) || true) && (_stopPump)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 74200, 74328);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1657, 74287, 74293);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 74200, 74328);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74364, 74543) || true) && (f_1657_74368_74392(_driverInvokeQueue) > 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 74364, 74543);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74470, 74508);

                                            driver = f_1657_74479_74507(_driverInvokeQueue);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 74364, 74543);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74579, 74745) || true) && (f_1657_74583_74607(_driverInvokeQueue) == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 74579, 74745);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74686, 74710);

                                            f_1657_74686_74709(_processDrivers);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 74579, 74745);
                                        }
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74808, 75391) || true) && (driver != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 74808, 75391);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 74968, 74982);

                                            IsBusy = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75020, 75040);

                                            f_1657_75020_75039(driver);
                                        }
                                        catch (Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 75109, 75196);
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 75109, 75196);
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1657, 75230, 75360);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75310, 75325);

                                            IsBusy = false;
                                            DynAbs.Tracing.TraceSender.TraceExitFinally(1657, 75230, 75360);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 74808, 75391);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 73830, 75418);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 73830, 75418);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 73830, 75418);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1657, 75463, 75613);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75519, 75538);

                            _isDisposed = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75564, 75590);

                            f_1657_75564_75589(_processDrivers);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1657, 75463, 75613);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 73718, 75632);

                        bool
                        f_1657_73899_73924(System.Threading.ManualResetEvent
                        this_param)
                        {
                            var return_v = this_param.WaitOne();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 73899, 73924);
                            return return_v;
                        }


                        int
                        f_1657_74368_74392(System.Collections.Generic.Queue<System.Management.Automation.ServerPowerShellDriver>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 74368, 74392);
                            return return_v;
                        }


                        System.Management.Automation.ServerPowerShellDriver
                        f_1657_74479_74507(System.Collections.Generic.Queue<System.Management.Automation.ServerPowerShellDriver>
                        this_param)
                        {
                            var return_v = this_param.Dequeue();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 74479, 74507);
                            return return_v;
                        }


                        int
                        f_1657_74583_74607(System.Collections.Generic.Queue<System.Management.Automation.ServerPowerShellDriver>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 74583, 74607);
                            return return_v;
                        }


                        bool
                        f_1657_74686_74709(System.Threading.ManualResetEvent
                        this_param)
                        {
                            var return_v = this_param.Reset();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 74686, 74709);
                            return return_v;
                        }


                        int
                        f_1657_75020_75039(System.Management.Automation.ServerPowerShellDriver
                        this_param)
                        {
                            this_param.InvokeMain();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 75020, 75039);
                            return 0;
                        }


                        int
                        f_1657_75564_75589(System.Threading.ManualResetEvent
                        this_param)
                        {
                            this_param.Dispose();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 75564, 75589);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 73718, 75632);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 73718, 75632);
                    }
                }

                public void Dispatch(ServerPowerShellDriver driver)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 75652, 75976);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75744, 75760);

                        f_1657_75744_75759(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75790, 75801);

                        lock (_syncObject)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75851, 75886);

                            f_1657_75851_75885(_driverInvokeQueue, driver);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 75912, 75934);

                            f_1657_75912_75933(_processDrivers);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 75652, 75976);

                        int
                        f_1657_75744_75759(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                        this_param)
                        {
                            this_param.CheckDisposed();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 75744, 75759);
                            return 0;
                        }


                        int
                        f_1657_75851_75885(System.Collections.Generic.Queue<System.Management.Automation.ServerPowerShellDriver>
                        this_param, System.Management.Automation.ServerPowerShellDriver
                        item)
                        {
                            this_param.Enqueue(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 75851, 75885);
                            return 0;
                        }


                        bool
                        f_1657_75912_75933(System.Threading.ManualResetEvent
                        this_param)
                        {
                            var return_v = this_param.Set();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 75912, 75933);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 75652, 75976);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 75652, 75976);
                    }
                }

                public void Stop()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 75996, 76269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76055, 76071);

                        f_1657_76055_76070(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76101, 76112);

                        lock (_syncObject)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76162, 76179);

                            _stopPump = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76205, 76227);

                            f_1657_76205_76226(_processDrivers);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 75996, 76269);

                        int
                        f_1657_76055_76070(System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump
                        this_param)
                        {
                            this_param.CheckDisposed();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 76055, 76070);
                            return 0;
                        }


                        bool
                        f_1657_76205_76226(System.Threading.ManualResetEvent
                        this_param)
                        {
                            var return_v = this_param.Set();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 76205, 76226);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 75996, 76269);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 75996, 76269);
                    }
                }

                public bool IsBusy { get; private set; }

                private void CheckDisposed()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 76349, 76573);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76418, 76554) || true) && (_isDisposed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 76418, 76554);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76483, 76531);

                            throw f_1657_76489_76530("InvokePump");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 76418, 76554);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 76349, 76573);

                        System.ObjectDisposedException
                        f_1657_76489_76530(string
                        objectName)
                        {
                            var return_v = new System.ObjectDisposedException(objectName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 76489, 76530);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 76349, 76573);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 76349, 76573);
                    }
                }

                static InvokePump()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1657, 73116, 76588);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1657, 73116, 76588);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 73116, 76588);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1657, 73116, 76588);

                System.Collections.Generic.Queue<System.Management.Automation.ServerPowerShellDriver>
                f_1657_73526_73561()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Management.Automation.ServerPowerShellDriver>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 73526, 73561);
                    return return_v;
                }


                System.Threading.ManualResetEvent
                f_1657_73602_73629(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 73602, 73629);
                    return return_v;
                }


                object
                f_1657_73666_73678()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 73666, 73678);
                    return return_v;
                }

            }

            static PowerShellDriverInvoker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1657, 69841, 76625);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1657, 69841, 76625);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 69841, 76625);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1657, 69841, 76625);

            System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump>
            f_1657_70248_70281()
            {
                var return_v = new System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker.InvokePump>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 70248, 70281);
                return return_v;
            }

        }

        static ServerRunspacePoolDriver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1657, 1252, 76654);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1657, 1252, 76654);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 1252, 76654);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1657, 1252, 76654);

        System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDriver>
        f_1657_2183_2229()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDriver>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 2183, 2229);
            return return_v;
        }


        System.Management.Automation.ServerSteppablePipelineSubscriber
        f_1657_2736_2775()
        {
            var return_v = new System.Management.Automation.ServerSteppablePipelineSubscriber();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 2736, 2775);
            return return_v;
        }


        int
        f_1657_6334_6400(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 6334, 6400);
            return 0;
        }


        System.Management.Automation.Remoting.ServerDriverRemoteHost
        f_1657_6734_6846(System.Guid
        clientRunspacePoolId, System.Guid
        clientPowerShellId, System.Management.Automation.Remoting.HostInfo
        hostInfo, System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
        transportManager, System.Management.Automation.ServerRemoteDebugger
        debugger)
        {
            var return_v = new System.Management.Automation.Remoting.ServerDriverRemoteHost(clientRunspacePoolId, clientPowerShellId, hostInfo, transportManager, debugger);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 6734, 6846);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_6980_7096(int
        minRunspaces, int
        maxRunspaces, System.Management.Automation.Runspaces.InitialSessionState
        initialSessionState, System.Management.Automation.Remoting.ServerDriverRemoteHost
        host)
        {
            var return_v = RunspaceFactory.CreateRunspacePool(minRunspaces, maxRunspaces, initialSessionState, (System.Management.Automation.Host.PSHost)host);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 6980, 7096);
            return return_v;
        }


        bool
        f_1657_7484_7522(System.Management.Automation.Runspaces.PSThreadOptions?
        this_param)
        {
            var return_v = this_param.HasValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 7484, 7522);
            return return_v;
        }


        System.Management.Automation.Runspaces.PSThreadOptions
        f_1657_7525_7560(System.Management.Automation.Runspaces.PSThreadOptions?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 7525, 7560);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_7728_7740()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 7728, 7740);
            return return_v;
        }


        string
        f_1657_7988_8045()
        {
            var return_v = RemotingErrorIdStrings.MustBeAdminToOverrideThreadOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 7988, 8045);
            return return_v;
        }


        string
        f_1657_7941_8046(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 7941, 8046);
            return return_v;
        }


        System.InvalidOperationException
        f_1657_7911_8047(string
        message)
        {
            var return_v = new System.InvalidOperationException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 7911, 8047);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_8087_8099()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8087, 8099);
            return return_v;
        }


        bool
        f_1657_8263_8308(System.Threading.ApartmentState?
        this_param)
        {
            var return_v = this_param.HasValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8263, 8308);
            return return_v;
        }


        System.Threading.ApartmentState
        f_1657_8311_8353(System.Threading.ApartmentState?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8311, 8353);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_8523_8535()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8523, 8535);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_8640_8652()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8640, 8652);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_8919_8931()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8919, 8931);
            return return_v;
        }


        System.Management.Automation.Runspaces.PSThreadOptions
        f_1657_8919_8945(System.Management.Automation.Runspaces.RunspacePool
        this_param)
        {
            var return_v = this_param.ThreadOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8919, 8945);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_8994_9006()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8994, 9006);
            return return_v;
        }


        System.Management.Automation.Runspaces.PSThreadOptions
        f_1657_8994_9020(System.Management.Automation.Runspaces.RunspacePool
        this_param)
        {
            var return_v = this_param.ThreadOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 8994, 9020);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker
        f_1657_9114_9143()
        {
            var return_v = new System.Management.Automation.ServerRunspacePoolDriver.PowerShellDriverInvoker();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 9114, 9143);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_9246_9312(System.Management.Automation.ServerRunspacePoolDriver
        driver, System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
        transportManager)
        {
            var return_v = new System.Management.Automation.ServerRunspacePoolDataStructureHandler(driver, transportManager);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 9246, 9312);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_9396_9408()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 9396, 9408);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_9597_9609()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 9597, 9609);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1657_9721_9733()
        {
            var return_v = RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 9721, 9733);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_9867_9887()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 9867, 9887);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_10047_10067()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 10047, 10067);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_10213_10233()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 10213, 10233);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_10375_10395()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 10375, 10395);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_10533_10553()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 10533, 10553);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_10691_10711()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 10691, 10711);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1657_10861_10881()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 10861, 10881);
            return return_v;
        }


        object
        f_1657_42299_42311()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 42299, 42311);
            return return_v;
        }

    }
    internal sealed class ServerRemoteDebugger : Debugger, IDisposable
    {
        private IRSPDriverInvoke _driverInvoker;

        private Runspace _runspace;

        private ObjectRef<Debugger> _wrappedDebugger;

        private bool _inDebugMode;

        private DebuggerStopEventArgs _debuggerStopEventArgs;

        private ManualResetEventSlim _nestedDebugStopCompleteEvent;

        private bool _nestedDebugging;

        private ManualResetEventSlim _processCommandCompleteEvent;

        private ThreadCommandProcessing _threadCommandProcessing;

        private bool _raiseStopEventLocally;

        internal const string
        SetPSBreakCommandText = "Set-PSBreakpoint"
        ;

        private ServerRemoteDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 77573, 77607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76931, 76945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76973, 76982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77021, 77037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77061, 77073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77114, 77136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77178, 77207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77231, 77247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77287, 77315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77358, 77382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77408, 77430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115799, 115885);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 77573, 77607);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 77573, 77607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 77573, 77607);
            }
        }

        internal ServerRemoteDebugger(
                    IRSPDriverInvoke driverInvoker,
                    Runspace runspace,
                    Debugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 77832, 78678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76931, 76945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 76973, 76982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77021, 77037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77061, 77073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77114, 77136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77178, 77207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77231, 77247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77287, 77315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77358, 77382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77408, 77430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115799, 115885);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77996, 78121) || true) && (driverInvoker == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 77996, 78121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78055, 78106);

                    throw f_1657_78061_78105("driverInvoker");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 77996, 78121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78137, 78252) || true) && (runspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 78137, 78252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78191, 78237);

                    throw f_1657_78197_78236("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 78137, 78252);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78268, 78383) || true) && (debugger == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 78268, 78383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78322, 78368);

                    throw f_1657_78328_78367("debugger");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 78268, 78383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78399, 78430);

                _driverInvoker = driverInvoker;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78444, 78465);

                _runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78481, 78534);

                _wrappedDebugger = f_1657_78500_78533(debugger);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78550, 78573);

                f_1657_78550_78572(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78589, 78619);

                _runspace.Name = "RemoteHost";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78633, 78667);

                _runspace.InternalDebugger = this;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 77832, 78678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 77832, 78678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 77832, 78678);
            }
        }

        public override bool InBreakpoint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 78915, 78943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 78921, 78941);

                    return _inDebugMode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 78915, 78943);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 78857, 78954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 78857, 78954);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void SetBreakpoints(IEnumerable<Breakpoint> breakpoints, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 79387, 79465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 79403, 79465);
                f_1657_79403_79465(f_1657_79403_79425(_wrappedDebugger), breakpoints, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 79387, 79465);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 79387, 79465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 79387, 79465);
            }

            System.Management.Automation.Debugger
            f_1657_79403_79425(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 79403, 79425);
                return return_v;
            }


            int
            f_1657_79403_79465(System.Management.Automation.Debugger
            this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.Breakpoint>
            breakpoints, int?
            runspaceId)
            {
                this_param.SetBreakpoints(breakpoints, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 79403, 79465);
                return 0;
            }

        }

        public override Breakpoint GetBreakpoint(int id, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 79974, 80042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 79990, 80042);
                return f_1657_79990_80042(f_1657_79990_80012(_wrappedDebugger), id, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 79974, 80042);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 79974, 80042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 79974, 80042);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_79990_80012(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 79990, 80012);
                return return_v;
            }


            System.Management.Automation.Breakpoint
            f_1657_79990_80042(System.Management.Automation.Debugger
            this_param, int
            id, int?
            runspaceId)
            {
                var return_v = this_param.GetBreakpoint(id, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 79990, 80042);
                return return_v;
            }

        }

        public override List<Breakpoint> GetBreakpoints(int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 80433, 80498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 80449, 80498);
                return f_1657_80449_80498(f_1657_80449_80471(_wrappedDebugger), runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 80433, 80498);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 80433, 80498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 80433, 80498);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_80449_80471(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 80449, 80471);
                return return_v;
            }


            System.Collections.Generic.List<System.Management.Automation.Breakpoint>
            f_1657_80449_80498(System.Management.Automation.Debugger
            this_param, int?
            runspaceId)
            {
                var return_v = this_param.GetBreakpoints(runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 80449, 80498);
                return return_v;
            }

        }

        public override CommandBreakpoint SetCommandBreakpoint(string command, ScriptBlock action, string path, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 81417, 81511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 81433, 81511);
                return f_1657_81433_81511(f_1657_81433_81455(_wrappedDebugger), command, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 81417, 81511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 81417, 81511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 81417, 81511);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_81433_81455(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 81433, 81455);
                return return_v;
            }


            System.Management.Automation.CommandBreakpoint
            f_1657_81433_81511(System.Management.Automation.Debugger
            this_param, string
            command, System.Management.Automation.ScriptBlock
            action, string
            path, int?
            runspaceId)
            {
                var return_v = this_param.SetCommandBreakpoint(command, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 81433, 81511);
                return return_v;
            }

        }

        public override LineBreakpoint SetLineBreakpoint(string path, int line, int column, ScriptBlock action, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 82572, 82668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 82588, 82668);
                return f_1657_82588_82668(f_1657_82588_82610(_wrappedDebugger), path, line, column, action, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 82572, 82668);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 82572, 82668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 82572, 82668);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_82588_82610(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 82588, 82610);
                return return_v;
            }


            System.Management.Automation.LineBreakpoint
            f_1657_82588_82668(System.Management.Automation.Debugger
            this_param, string
            path, int
            line, int
            column, System.Management.Automation.ScriptBlock
            action, int?
            runspaceId)
            {
                var return_v = this_param.SetLineBreakpoint(path, line, column, action, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 82588, 82668);
                return return_v;
            }

        }

        public override VariableBreakpoint SetVariableBreakpoint(string variableName, VariableAccessMode accessMode, ScriptBlock action, string path, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 83772, 83884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 83788, 83884);
                return f_1657_83788_83884(f_1657_83788_83810(_wrappedDebugger), variableName, accessMode, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 83772, 83884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 83772, 83884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 83772, 83884);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_83788_83810(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 83788, 83810);
                return return_v;
            }


            System.Management.Automation.VariableBreakpoint
            f_1657_83788_83884(System.Management.Automation.Debugger
            this_param, string
            variableName, System.Management.Automation.VariableAccessMode
            accessMode, System.Management.Automation.ScriptBlock
            action, string
            path, int?
            runspaceId)
            {
                var return_v = this_param.SetVariableBreakpoint(variableName, accessMode, action, path, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 83788, 83884);
                return return_v;
            }

        }

        public override bool RemoveBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 84445, 84524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 84461, 84524);
                return f_1657_84461_84524(f_1657_84461_84483(_wrappedDebugger), breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 84445, 84524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 84445, 84524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 84445, 84524);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_84461_84483(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 84461, 84483);
                return return_v;
            }


            bool
            f_1657_84461_84524(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.RemoveBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 84461, 84524);
                return return_v;
            }

        }

        public override Breakpoint EnableBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 85110, 85189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 85126, 85189);
                return f_1657_85126_85189(f_1657_85126_85148(_wrappedDebugger), breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 85110, 85189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 85110, 85189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 85110, 85189);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_85126_85148(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 85126, 85148);
                return return_v;
            }


            System.Management.Automation.Breakpoint
            f_1657_85126_85189(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.EnableBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 85126, 85189);
                return return_v;
            }

        }

        public override Breakpoint DisableBreakpoint(Breakpoint breakpoint, int? runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 85777, 85857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 85793, 85857);
                return f_1657_85793_85857(f_1657_85793_85815(_wrappedDebugger), breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 85777, 85857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 85777, 85857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 85777, 85857);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Debugger
            f_1657_85793_85815(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 85793, 85815);
                return return_v;
            }


            System.Management.Automation.Breakpoint
            f_1657_85793_85857(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Breakpoint
            breakpoint, int?
            runspaceId)
            {
                var return_v = this_param.DisableBreakpoint(breakpoint, runspaceId);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 85793, 85857);
                return return_v;
            }

        }

        public override void SetDebuggerAction(DebuggerResumeAction resumeAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 86053, 86398);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 86151, 86343) || true) && (!_inDebugMode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 86151, 86343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 86202, 86328);

                    throw f_1657_86208_86327(f_1657_86262_86326(f_1657_86280_86325()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 86151, 86343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 86359, 86387);

                f_1657_86359_86386(this, resumeAction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 86053, 86398);

                string
                f_1657_86280_86325()
                {
                    var return_v = DebuggerStrings.CannotSetRemoteDebuggerAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 86280, 86325);
                    return return_v;
                }


                string
                f_1657_86262_86326(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 86262, 86326);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1657_86208_86327(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 86208, 86327);
                    return return_v;
                }


                int
                f_1657_86359_86386(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.ExitDebugMode(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 86359, 86386);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 86053, 86398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 86053, 86398);
            }
        }

        public override DebuggerStopEventArgs GetDebuggerStopArgs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 86585, 86732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 86669, 86721);

                return f_1657_86676_86720(f_1657_86676_86698(_wrappedDebugger));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 86585, 86732);

                System.Management.Automation.Debugger
                f_1657_86676_86698(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 86676, 86698);
                    return return_v;
                }


                System.Management.Automation.DebuggerStopEventArgs
                f_1657_86676_86720(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.GetDebuggerStopArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 86676, 86720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 86585, 86732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 86585, 86732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DebuggerCommandResults ProcessCommand(PSCommand command, PSDataCollection<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 86955, 88028);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87087, 87216) || true) && (f_1657_87091_87105())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 87087, 87216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87139, 87201);

                    return f_1657_87146_87200(f_1657_87146_87168(_wrappedDebugger), command, output);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 87087, 87216);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87232, 87471) || true) && (f_1657_87236_87249_M(!InBreakpoint) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 87236, 87287) || (_threadCommandProcessing != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 87232, 87471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87321, 87456);

                    throw f_1657_87327_87455(f_1657_87381_87454(f_1657_87399_87453()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 87232, 87471);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87487, 87639) || true) && (_processCommandCompleteEvent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 87487, 87639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87561, 87624);

                    _processCommandCompleteEvent = f_1657_87592_87623(false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 87487, 87639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87655, 87781);

                _threadCommandProcessing = f_1657_87682_87780(command, output, f_1657_87727_87749(_wrappedDebugger), _processCommandCompleteEvent);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87831, 87901);

                    return f_1657_87838_87900(_threadCommandProcessing, _nestedDebugStopCompleteEvent);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1657, 87930, 88017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 87970, 88002);

                    _threadCommandProcessing = null;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1657, 87930, 88017);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 86955, 88028);

                bool
                f_1657_87091_87105()
                {
                    var return_v = LocalDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 87091, 87105);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_87146_87168(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 87146, 87168);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1657_87146_87200(System.Management.Automation.Debugger
                this_param, System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.ProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 87146, 87200);
                    return return_v;
                }


                bool
                f_1657_87236_87249_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 87236, 87249);
                    return return_v;
                }


                string
                f_1657_87399_87453()
                {
                    var return_v = DebuggerStrings.CannotProcessDebuggerCommandNotStopped;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 87399, 87453);
                    return return_v;
                }


                string
                f_1657_87381_87454(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 87381, 87454);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1657_87327_87455(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 87327, 87455);
                    return return_v;
                }


                System.Threading.ManualResetEventSlim
                f_1657_87592_87623(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEventSlim(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 87592, 87623);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_87727_87749(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 87727, 87749);
                    return return_v;
                }


                System.Management.Automation.ServerRemoteDebugger.ThreadCommandProcessing
                f_1657_87682_87780(System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.Debugger
                debugger, System.Threading.ManualResetEventSlim
                processCommandCompleteEvent)
                {
                    var return_v = new System.Management.Automation.ServerRemoteDebugger.ThreadCommandProcessing(command, output, debugger, processCommandCompleteEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 87682, 87780);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1657_87838_87900(System.Management.Automation.ServerRemoteDebugger.ThreadCommandProcessing
                this_param, System.Threading.ManualResetEventSlim
                startInvokeEvent)
                {
                    var return_v = this_param.Invoke(startInvokeEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 87838, 87900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 86955, 88028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 86955, 88028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void StopProcessCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 88120, 88528);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 88186, 88297) || true) && (f_1657_88190_88204())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 88186, 88297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 88238, 88282);

                    f_1657_88238_88281(f_1657_88238_88260(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 88186, 88297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 88313, 88388);

                ThreadCommandProcessing
                threadCommandProcessing = _threadCommandProcessing
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 88402, 88517) || true) && (threadCommandProcessing != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 88402, 88517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 88471, 88502);

                    f_1657_88471_88501(threadCommandProcessing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 88402, 88517);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 88120, 88528);

                bool
                f_1657_88190_88204()
                {
                    var return_v = LocalDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 88190, 88204);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_88238_88260(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 88238, 88260);
                    return return_v;
                }


                int
                f_1657_88238_88281(System.Management.Automation.Debugger
                this_param)
                {
                    this_param.StopProcessCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 88238, 88281);
                    return 0;
                }


                int
                f_1657_88471_88501(System.Management.Automation.ServerRemoteDebugger.ThreadCommandProcessing
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 88471, 88501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 88120, 88528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 88120, 88528);
            }
        }

        public override void SetDebugMode(DebugModes mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 88655, 88823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 88730, 88772);

                f_1657_88730_88771(f_1657_88730_88752(_wrappedDebugger), mode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 88788, 88812);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetDebugMode(mode), 1657, 88788, 88811);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 88655, 88823);

                System.Management.Automation.Debugger
                f_1657_88730_88752(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 88730, 88752);
                    return return_v;
                }


                int
                f_1657_88730_88771(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 88730, 88771);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 88655, 88823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 88655, 88823);
            }
        }

        public override bool IsActive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 88996, 89143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 89032, 89128);

                    return (f_1657_89040_89052() || (DynAbs.Tracing.TraceSender.Expression_False(1657, 89040, 89087) || f_1657_89056_89087(f_1657_89056_89078(_wrappedDebugger))) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 89040, 89126) || f_1657_89091_89126(f_1657_89091_89113(_wrappedDebugger))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 88996, 89143);

                    bool
                    f_1657_89040_89052()
                    {
                        var return_v = InBreakpoint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 89040, 89052);
                        return return_v;
                    }


                    System.Management.Automation.Debugger
                    f_1657_89056_89078(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 89056, 89078);
                        return return_v;
                    }


                    bool
                    f_1657_89056_89087(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.IsActive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 89056, 89087);
                        return return_v;
                    }


                    System.Management.Automation.Debugger
                    f_1657_89091_89113(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 89091, 89113);
                        return return_v;
                    }


                    bool
                    f_1657_89091_89126(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.InBreakpoint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 89091, 89126);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 88942, 89154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 88942, 89154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void SetDebuggerStepMode(bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 89333, 89754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 89514, 89581);

                DebugModes
                mode = DebugModes.LocalScript | DebugModes.RemoteScript
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 89595, 89619);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetDebugMode(mode), 1657, 89595, 89618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 89633, 89675);

                f_1657_89633_89674(f_1657_89633_89655(_wrappedDebugger), mode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 89691, 89743);

                f_1657_89691_89742(f_1657_89691_89713(_wrappedDebugger), enabled);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 89333, 89754);

                System.Management.Automation.Debugger
                f_1657_89633_89655(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 89633, 89655);
                    return return_v;
                }


                int
                f_1657_89633_89674(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 89633, 89674);
                    return 0;
                }


                System.Management.Automation.Debugger
                f_1657_89691_89713(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 89691, 89713);
                    return return_v;
                }


                int
                f_1657_89691_89742(System.Management.Automation.Debugger
                this_param, bool
                enabled)
                {
                    this_param.SetDebuggerStepMode(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 89691, 89742);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 89333, 89754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 89333, 89754);
            }
        }

        internal override DebuggerCommand InternalProcessCommand(string command, IList<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 89970, 90172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 90091, 90161);

                return f_1657_90098_90160(f_1657_90098_90120(_wrappedDebugger), command, output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 89970, 90172);

                System.Management.Automation.Debugger
                f_1657_90098_90120(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 90098, 90120);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommand
                f_1657_90098_90160(System.Management.Automation.Debugger
                this_param, string
                command, System.Collections.Generic.IList<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.InternalProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 90098, 90160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 89970, 90172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 89970, 90172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void DebugJob(Job job, bool breakAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 90692, 90754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 90708, 90754);
                f_1657_90708_90754(f_1657_90708_90730(_wrappedDebugger), job, breakAll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 90692, 90754);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 90692, 90754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 90692, 90754);
            }

            System.Management.Automation.Debugger
            f_1657_90708_90730(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 90708, 90730);
                return return_v;
            }


            int
            f_1657_90708_90754(System.Management.Automation.Debugger
            this_param, System.Management.Automation.Job
            job, bool
            breakAll)
            {
                this_param.DebugJob(job, breakAll);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 90708, 90754);
                return 0;
            }

        }

        internal override void StopDebugJob(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 90973, 91094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 91042, 91083);

                f_1657_91042_91082(f_1657_91042_91064(_wrappedDebugger), job);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 90973, 91094);

                System.Management.Automation.Debugger
                f_1657_91042_91064(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 91042, 91064);
                    return return_v;
                }


                int
                f_1657_91042_91082(System.Management.Automation.Debugger
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.StopDebugJob(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 91042, 91082);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 90973, 91094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 90973, 91094);
            }
        }

        internal override void DebugRunspace(Runspace runspace, bool breakAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 91497, 91660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 91592, 91649);

                f_1657_91592_91648(f_1657_91592_91614(_wrappedDebugger), runspace, breakAll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 91497, 91660);

                System.Management.Automation.Debugger
                f_1657_91592_91614(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 91592, 91614);
                    return return_v;
                }


                int
                f_1657_91592_91648(System.Management.Automation.Debugger
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace, bool
                breakAll)
                {
                    this_param.DebugRunspace(runspace, breakAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 91592, 91648);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 91497, 91660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 91497, 91660);
            }
        }

        internal override void StopDebugRunspace(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 91857, 92003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 91941, 91992);

                f_1657_91941_91991(f_1657_91941_91963(_wrappedDebugger), runspace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 91857, 92003);

                System.Management.Automation.Debugger
                f_1657_91941_91963(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 91941, 91963);
                    return return_v;
                }


                int
                f_1657_91941_91991(System.Management.Automation.Debugger
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.StopDebugRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 91941, 91991);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 91857, 92003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 91857, 92003);
            }
        }

        internal override bool IsPushed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 92141, 92231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 92177, 92216);

                    return f_1657_92184_92215(f_1657_92184_92206(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 92141, 92231);

                    System.Management.Automation.Debugger
                    f_1657_92184_92206(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 92184, 92206);
                        return return_v;
                    }


                    bool
                    f_1657_92184_92215(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.IsPushed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 92184, 92215);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 92085, 92242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 92085, 92242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsRemote
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 92380, 92470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 92416, 92455);

                    return f_1657_92423_92454(f_1657_92423_92445(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 92380, 92470);

                    System.Management.Automation.Debugger
                    f_1657_92423_92445(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 92423, 92445);
                        return return_v;
                    }


                    bool
                    f_1657_92423_92454(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.IsRemote;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 92423, 92454);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 92324, 92481);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 92324, 92481);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDebuggerSteppingEnabled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 92653, 92760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 92689, 92745);

                    return f_1657_92696_92744(f_1657_92696_92718(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 92653, 92760);

                    System.Management.Automation.Debugger
                    f_1657_92696_92718(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 92696, 92718);
                        return return_v;
                    }


                    bool
                    f_1657_92696_92744(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.IsDebuggerSteppingEnabled;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 92696, 92744);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 92580, 92771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 92580, 92771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override UnhandledBreakpointProcessingMode UnhandledBreakpointMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 92968, 93073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 93004, 93058);

                    return f_1657_93011_93057(f_1657_93011_93033(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 92968, 93073);

                    System.Management.Automation.Debugger
                    f_1657_93011_93033(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 93011, 93033);
                        return return_v;
                    }


                    System.Management.Automation.UnhandledBreakpointProcessingMode
                    f_1657_93011_93057(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.UnhandledBreakpointMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 93011, 93057);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 92868, 93472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 92868, 93472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 93089, 93461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 93125, 93180);

                    f_1657_93125_93147(_wrappedDebugger).UnhandledBreakpointMode = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 93198, 93446) || true) && (value == UnhandledBreakpointProcessingMode.Ignore && (DynAbs.Tracing.TraceSender.Expression_True(1657, 93202, 93288) && _inDebugMode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 93198, 93446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 93382, 93427);

                        f_1657_93382_93426(this, DebuggerResumeAction.Continue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 93198, 93446);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 93089, 93461);

                    System.Management.Automation.Debugger
                    f_1657_93125_93147(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 93125, 93147);
                        return return_v;
                    }


                    int
                    f_1657_93382_93426(System.Management.Automation.ServerRemoteDebugger
                    this_param, System.Management.Automation.DebuggerResumeAction
                    resumeAction)
                    {
                        this_param.ExitDebugMode(resumeAction);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 93382, 93426);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 92868, 93472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 92868, 93472);
                }
            }
        }

        internal override bool IsPendingDebugStopEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 93640, 93702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 93646, 93700);

                    return f_1657_93653_93699(f_1657_93653_93675(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 93640, 93702);

                    System.Management.Automation.Debugger
                    f_1657_93653_93675(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 93653, 93675);
                        return return_v;
                    }


                    bool
                    f_1657_93653_93699(System.Management.Automation.Debugger
                    this_param)
                    {
                        var return_v = this_param.IsPendingDebugStopEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 93653, 93699);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 93569, 93713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 93569, 93713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void ReleaseSavedDebugStop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 93808, 93937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 93879, 93926);

                f_1657_93879_93925(f_1657_93879_93901(_wrappedDebugger));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 93808, 93937);

                System.Management.Automation.Debugger
                f_1657_93879_93901(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 93879, 93901);
                    return return_v;
                }


                int
                f_1657_93879_93925(System.Management.Automation.Debugger
                this_param)
                {
                    this_param.ReleaseSavedDebugStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 93879, 93925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 93808, 93937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 93808, 93937);
            }
        }

        public override IEnumerable<CallStackFrame> GetCallStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 94089, 94228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94172, 94217);

                return f_1657_94179_94216(f_1657_94179_94201(_wrappedDebugger));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 94089, 94228);

                System.Management.Automation.Debugger
                f_1657_94179_94201(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 94179, 94201);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1657_94179_94216(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.GetCallStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 94179, 94216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 94089, 94228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 94089, 94228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void Break(object triggerObject = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 94240, 94377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94322, 94366);

                f_1657_94322_94365(f_1657_94322_94344(_wrappedDebugger), triggerObject);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 94240, 94377);

                System.Management.Automation.Debugger
                f_1657_94322_94344(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 94322, 94344);
                    return return_v;
                }


                int
                f_1657_94322_94365(System.Management.Automation.Debugger
                this_param, object
                triggerObject)
                {
                    this_param.Break(triggerObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 94322, 94365);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 94240, 94377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 94240, 94377);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 94511, 95004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94557, 94583);

                f_1657_94557_94582(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94597, 94703) || true) && (_inDebugMode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 94597, 94703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94647, 94688);

                    f_1657_94647_94687(this, DebuggerResumeAction.Stop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 94597, 94703);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94719, 94849) || true) && (_nestedDebugStopCompleteEvent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 94719, 94849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94794, 94834);

                    f_1657_94794_94833(_nestedDebugStopCompleteEvent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 94719, 94849);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94865, 94993) || true) && (_processCommandCompleteEvent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 94865, 94993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 94939, 94978);

                    f_1657_94939_94977(_processCommandCompleteEvent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 94865, 94993);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 94511, 95004);

                int
                f_1657_94557_94582(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    this_param.RemoveDebuggerCallbacks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 94557, 94582);
                    return 0;
                }


                int
                f_1657_94647_94687(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.ExitDebugMode(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 94647, 94687);
                    return 0;
                }


                int
                f_1657_94794_94833(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 94794, 94833);
                    return 0;
                }


                int
                f_1657_94939_94977(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 94939, 94977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 94511, 95004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 94511, 95004);
            }
        }
        private sealed class ThreadCommandProcessing
        {
            private ManualResetEventSlim _commandCompleteEvent;

            private Debugger _wrappedDebugger;

            private PSCommand _command;

            private PSDataCollection<PSObject> _output;

            private DebuggerCommandResults _results;

            private Exception _exception;

            private WindowsIdentity _identityToImpersonate;

            private ThreadCommandProcessing()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 95585, 95622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95195, 95216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95248, 95264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95297, 95305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95355, 95362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95408, 95416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95449, 95459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95509, 95531);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 95585, 95622);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 95585, 95622);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 95585, 95622);
                }
            }

            public ThreadCommandProcessing(
                            PSCommand command,
                            PSDataCollection<PSObject> output,
                            Debugger debugger,
                            ManualResetEventSlim processCommandCompleteEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1657, 95638, 96078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95195, 95216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95248, 95264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95297, 95305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95355, 95362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95408, 95416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95449, 95459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95509, 95531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95893, 95912);

                    _command = command;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95930, 95947);

                    _output = output;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 95965, 95993);

                    _wrappedDebugger = debugger;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96011, 96063);

                    _commandCompleteEvent = processCommandCompleteEvent;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1657, 95638, 96078);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 95638, 96078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 95638, 96078);
                }
            }

            public DebuggerCommandResults Invoke(ManualResetEventSlim startInvokeEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 96118, 97332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96303, 96371);

                    f_1657_96303_96370(out _identityToImpersonate);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96453, 96557);

                    f_1657_96453_96556(f_1657_96464_96492_M(!_commandCompleteEvent.IsSet), "Command complete event shoulds always be non-signaled here.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96575, 96669);

                    f_1657_96575_96668(f_1657_96586_96609_M(!startInvokeEvent.IsSet), "The event should always be in non-signaled state here.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96687, 96710);

                    f_1657_96687_96709(startInvokeEvent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96771, 96800);

                    f_1657_96771_96799(
                                    // Wait for completion.
                                    _commandCompleteEvent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96818, 96848);

                    f_1657_96818_96847(_commandCompleteEvent);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96877, 97057) || true) && (_identityToImpersonate != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 96877, 97057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 96953, 96986);

                        f_1657_96953_96985(_identityToImpersonate);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97008, 97038);

                        _identityToImpersonate = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 96877, 97057);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97126, 97226) || true) && (_exception != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 97126, 97226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97190, 97207);

                        throw _exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 97126, 97226);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97301, 97317);

                    return _results;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 96118, 97332);

                    bool
                    f_1657_96303_96370(out System.Security.Principal.WindowsIdentity
                    impersonatedIdentity)
                    {
                        var return_v = Utils.TryGetWindowsImpersonatedIdentity(out impersonatedIdentity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 96303, 96370);
                        return return_v;
                    }


                    bool
                    f_1657_96464_96492_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 96464, 96492);
                        return return_v;
                    }


                    int
                    f_1657_96453_96556(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 96453, 96556);
                        return 0;
                    }


                    bool
                    f_1657_96586_96609_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 96586, 96609);
                        return return_v;
                    }


                    int
                    f_1657_96575_96668(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 96575, 96668);
                        return 0;
                    }


                    int
                    f_1657_96687_96709(System.Threading.ManualResetEventSlim
                    this_param)
                    {
                        this_param.Set();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 96687, 96709);
                        return 0;
                    }


                    int
                    f_1657_96771_96799(System.Threading.ManualResetEventSlim
                    this_param)
                    {
                        this_param.Wait();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 96771, 96799);
                        return 0;
                    }


                    int
                    f_1657_96818_96847(System.Threading.ManualResetEventSlim
                    this_param)
                    {
                        this_param.Reset();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 96818, 96847);
                        return 0;
                    }


                    int
                    f_1657_96953_96985(System.Security.Principal.WindowsIdentity
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 96953, 96985);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 96118, 97332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 96118, 97332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Stop()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 97348, 97580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97399, 97436);

                    Debugger
                    debugger = _wrappedDebugger
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97454, 97565) || true) && (debugger != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 97454, 97565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97516, 97546);

                        f_1657_97516_97545(debugger);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 97454, 97565);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 97348, 97580);

                    int
                    f_1657_97516_97545(System.Management.Automation.Debugger
                    this_param)
                    {
                        this_param.StopProcessCommand();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 97516, 97545);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 97348, 97580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 97348, 97580);
                }
            }

            internal void DoInvoke()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 97596, 98395);
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97708, 98044) || true) && (_identityToImpersonate != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 97708, 98044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 97792, 97988);

                            _results = f_1657_97803_97987(f_1657_97865_97899(_identityToImpersonate), () => _wrappedDebugger.ProcessCommand(_command, _output));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 98014, 98021);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 97708, 98044);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 98074, 98136);

                        _results = f_1657_98085_98135(_wrappedDebugger, _command, _output);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 98173, 98267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 98233, 98248);

                        _exception = e;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 98173, 98267);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1657, 98285, 98380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 98333, 98361);

                        f_1657_98333_98360(_commandCompleteEvent);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1657, 98285, 98380);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 97596, 98395);

                    Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                    f_1657_97865_97899(System.Security.Principal.WindowsIdentity
                    this_param)
                    {
                        var return_v = this_param.AccessToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 97865, 97899);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerCommandResults
                    f_1657_97803_97987(Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                    safeAccessTokenHandle, System.Func<System.Management.Automation.DebuggerCommandResults>
                    func)
                    {
                        var return_v = WindowsIdentity.RunImpersonated(safeAccessTokenHandle, func);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 97803, 97987);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerCommandResults
                    f_1657_98085_98135(System.Management.Automation.Debugger
                    this_param, System.Management.Automation.PSCommand
                    command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    output)
                    {
                        var return_v = this_param.ProcessCommand(command, output);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 98085, 98135);
                        return return_v;
                    }


                    int
                    f_1657_98333_98360(System.Threading.ManualResetEventSlim
                    this_param)
                    {
                        this_param.Set();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 98333, 98360);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 97596, 98395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 97596, 98395);
                }
            }

            static ThreadCommandProcessing()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1657, 95073, 98406);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1657, 95073, 98406);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 95073, 98406);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1657, 95073, 98406);
        }

        private void SetDebuggerCallbacks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 98576, 100127);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 98636, 100116) || true) && (_runspace != null && (DynAbs.Tracing.TraceSender.Expression_True(1657, 98640, 98712) && f_1657_98678_98704(_runspace) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 98640, 98763) && f_1657_98733_98755(_wrappedDebugger) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 98636, 100116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 98797, 98846);

                    f_1657_98797_98845(this, f_1657_98822_98844(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 98934, 98987);

                    var
                    eventManager = f_1657_98953_98986(f_1657_98953_98979(_runspace))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 99007, 99531) || true) && (!f_1657_99012_99111(f_1657_99012_99100(f_1657_99012_99084(eventManager, RemoteDebugger.RemoteDebuggerStopEvent))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 99007, 99531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 99153, 99512);

                        f_1657_99153_99511(eventManager, source: null, eventName: null, sourceIdentifier: RemoteDebugger.RemoteDebuggerStopEvent, data: null, action: null, supportEvent: true, forwardEvent: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 99007, 99531);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 99551, 100101) || true) && (!f_1657_99556_99668(f_1657_99556_99657(f_1657_99556_99641(eventManager, RemoteDebugger.RemoteDebuggerBreakpointUpdatedEvent))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 99551, 100101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 99710, 100082);

                        f_1657_99710_100081(eventManager, source: null, eventName: null, sourceIdentifier: RemoteDebugger.RemoteDebuggerBreakpointUpdatedEvent, data: null, action: null, supportEvent: true, forwardEvent: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 99551, 100101);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 98636, 100116);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 98576, 100127);

                System.Management.Automation.ExecutionContext
                f_1657_98678_98704(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 98678, 98704);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_98733_98755(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 98733, 98755);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_98822_98844(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 98822, 98844);
                    return return_v;
                }


                int
                f_1657_98797_98845(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Debugger
                wrappedDebugger)
                {
                    this_param.SubscribeWrappedDebugger(wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 98797, 98845);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1657_98953_98979(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 98953, 98979);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1657_98953_98986(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 98953, 98986);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1657_99012_99084(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99012, 99084);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                f_1657_99012_99100(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99012, 99100);
                    return return_v;
                }


                bool
                f_1657_99012_99111(System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99012, 99111);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1657_99153_99511(System.Management.Automation.PSLocalEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.ScriptBlock
                action, bool
                supportEvent, bool
                forwardEvent)
                {
                    var return_v = this_param.SubscribeEvent(source: source, eventName: eventName, sourceIdentifier: sourceIdentifier, data: data, action: action, supportEvent: supportEvent, forwardEvent: forwardEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99153, 99511);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1657_99556_99641(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99556, 99641);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                f_1657_99556_99657(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99556, 99657);
                    return return_v;
                }


                bool
                f_1657_99556_99668(System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99556, 99668);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1657_99710_100081(System.Management.Automation.PSLocalEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.ScriptBlock
                action, bool
                supportEvent, bool
                forwardEvent)
                {
                    var return_v = this_param.SubscribeEvent(source: source, eventName: eventName, sourceIdentifier: sourceIdentifier, data: data, action: action, supportEvent: supportEvent, forwardEvent: forwardEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 99710, 100081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 98576, 100127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 98576, 100127);
            }
        }

        private void RemoveDebuggerCallbacks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 100238, 101139);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 100301, 101128) || true) && (_runspace != null && (DynAbs.Tracing.TraceSender.Expression_True(1657, 100305, 100377) && f_1657_100343_100369(_runspace) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 100305, 100428) && f_1657_100398_100420(_wrappedDebugger) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 100301, 101128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 100462, 100513);

                    f_1657_100462_100512(this, f_1657_100489_100511(_wrappedDebugger));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 100603, 100656);

                    var
                    eventManager = f_1657_100622_100655(f_1657_100622_100648(_runspace))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 100676, 100878);
                        foreach (var subscriber in f_1657_100703_100775_I(f_1657_100703_100775(eventManager, RemoteDebugger.RemoteDebuggerStopEvent)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 100676, 100878);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 100817, 100859);

                            f_1657_100817_100858(eventManager, subscriber);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 100676, 100878);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 1, 203);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 1, 203);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 100898, 101113);
                        foreach (var subscriber in f_1657_100925_101010_I(f_1657_100925_101010(eventManager, RemoteDebugger.RemoteDebuggerBreakpointUpdatedEvent)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 100898, 101113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101052, 101094);

                            f_1657_101052_101093(eventManager, subscriber);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 100898, 101113);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 1, 216);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 1, 216);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 100301, 101128);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 100238, 101139);

                System.Management.Automation.ExecutionContext
                f_1657_100343_100369(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 100343, 100369);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_100398_100420(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 100398, 100420);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_100489_100511(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 100489, 100511);
                    return return_v;
                }


                int
                f_1657_100462_100512(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Debugger
                wrappedDebugger)
                {
                    this_param.UnsubscribeWrappedDebugger(wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 100462, 100512);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1657_100622_100648(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 100622, 100648);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1657_100622_100655(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 100622, 100655);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1657_100703_100775(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 100703, 100775);
                    return return_v;
                }


                int
                f_1657_100817_100858(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.UnsubscribeEvent(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 100817, 100858);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1657_100703_100775_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 100703, 100775);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1657_100925_101010(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 100925, 101010);
                    return return_v;
                }


                int
                f_1657_101052_101093(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.UnsubscribeEvent(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 101052, 101093);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1657_100925_101010_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 100925, 101010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 100238, 101139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 100238, 101139);
            }
        }

        private void HandleDebuggerStop(object sender, DebuggerStopEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 101240, 102975);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101389, 101429) || true) && (!f_1657_101394_101416(this))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 101389, 101429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101420, 101427);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 101389, 101429);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101445, 101606) || true) && (f_1657_101449_101463())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 101445, 101606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101540, 101566);

                    f_1657_101540_101565(this, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101584, 101591);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 101445, 101606);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101622, 101746) || true) && ((f_1657_101627_101636() & DebugModes.RemoteScript) != DebugModes.RemoteScript)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 101622, 101746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101724, 101731);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 101622, 101746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101762, 101789);

                _debuggerStopEventArgs = e;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101803, 101829);

                PSHost
                contextHost = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 101935, 102002);

                    contextHost = f_1657_101949_102001(f_1657_101949_101988(f_1657_101949_101975(_runspace)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 102074, 102132);

                    f_1657_102074_102131(_runspace != null, "Runspace cannot be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 102150, 102398);

                    f_1657_102150_102397(f_1657_102150_102183(f_1657_102150_102176(_runspace)), sourceIdentifier: RemoteDebugger.RemoteDebuggerStopEvent, sender: null, args: new object[] { e }, extraData: null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 102599, 102647);

                    f_1657_102599_102646(this, f_1657_102614_102645(f_1657_102614_102636(_wrappedDebugger)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 102725, 102789);

                    f_1657_102725_102788(f_1657_102725_102764(f_1657_102725_102751(_runspace)), contextHost);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 102818, 102865);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 102818, 102865);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1657, 102879, 102964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 102919, 102949);

                    _debuggerStopEventArgs = null;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1657, 102879, 102964);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 101240, 102975);

                bool
                f_1657_101394_101416(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.IsDebuggingSupported();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 101394, 101416);
                    return return_v;
                }


                bool
                f_1657_101449_101463()
                {
                    var return_v = LocalDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 101449, 101463);
                    return return_v;
                }


                int
                f_1657_101540_101565(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebuggerStopEventArgs
                args)
                {
                    this_param.RaiseDebuggerStopEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 101540, 101565);
                    return 0;
                }


                System.Management.Automation.DebugModes
                f_1657_101627_101636()
                {
                    var return_v = DebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 101627, 101636);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1657_101949_101975(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 101949, 101975);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1657_101949_101988(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 101949, 101988);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1657_101949_102001(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 101949, 102001);
                    return return_v;
                }


                int
                f_1657_102074_102131(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 102074, 102131);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1657_102150_102176(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 102150, 102176);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1657_102150_102183(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 102150, 102183);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1657_102150_102397(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier: sourceIdentifier, sender: sender, args: args, extraData: extraData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 102150, 102397);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_102614_102636(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 102614, 102636);
                    return return_v;
                }


                bool
                f_1657_102614_102645(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.IsPushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 102614, 102645);
                    return return_v;
                }


                int
                f_1657_102599_102646(System.Management.Automation.ServerRemoteDebugger
                this_param, bool
                isNestedStop)
                {
                    this_param.EnterDebugMode(isNestedStop);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 102599, 102646);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1657_102725_102751(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 102725, 102751);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1657_102725_102764(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 102725, 102764);
                    return return_v;
                }


                int
                f_1657_102725_102788(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Host.PSHost
                psHost)
                {
                    this_param.SetHostRef(psHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 102725, 102788);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 101240, 102975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 101240, 102975);
            }
        }

        private void HandleBreakpointUpdated(object sender, BreakpointUpdatedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 103153, 104062);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 103312, 103352) || true) && (!f_1657_103317_103339(this))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 103312, 103352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 103343, 103350);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 103312, 103352);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 103368, 103534) || true) && (f_1657_103372_103386())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 103368, 103534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 103463, 103494);

                    f_1657_103463_103493(this, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 103512, 103519);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 103368, 103534);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 103638, 103696);

                    f_1657_103638_103695(_runspace != null, "Runspace cannot be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 103714, 103975);

                    f_1657_103714_103974(f_1657_103714_103747(f_1657_103714_103740(_runspace)), sourceIdentifier: RemoteDebugger.RemoteDebuggerBreakpointUpdatedEvent, sender: null, args: new object[] { e }, extraData: null);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 104004, 104051);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 104004, 104051);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 103153, 104062);

                bool
                f_1657_103317_103339(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    var return_v = this_param.IsDebuggingSupported();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 103317, 103339);
                    return return_v;
                }


                bool
                f_1657_103372_103386()
                {
                    var return_v = LocalDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 103372, 103386);
                    return return_v;
                }


                int
                f_1657_103463_103493(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.BreakpointUpdatedEventArgs
                args)
                {
                    this_param.RaiseBreakpointUpdatedEvent(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 103463, 103493);
                    return 0;
                }


                int
                f_1657_103638_103695(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 103638, 103695);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1657_103714_103740(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 103714, 103740);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1657_103714_103747(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 103714, 103747);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1657_103714_103974(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier: sourceIdentifier, sender: sender, args: args, extraData: extraData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 103714, 103974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 103153, 104062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 103153, 104062);
            }
        }

        private void HandleNestedDebuggingCancelEvent(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 104074, 104437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 104232, 104266);

                f_1657_104232_104265(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 104316, 104426) || true) && (_inDebugMode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 104316, 104426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 104366, 104411);

                    f_1657_104366_104410(this, DebuggerResumeAction.Continue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 104316, 104426);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 104074, 104437);

                int
                f_1657_104232_104265(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    this_param.RaiseNestedDebuggingCancelEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 104232, 104265);
                    return 0;
                }


                int
                f_1657_104366_104410(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.ExitDebugMode(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 104366, 104410);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 104074, 104437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 104074, 104437);
            }
        }

        private void EnterDebugMode(bool isNestedStop)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 104580, 106240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 104651, 104671);

                _inDebugMode = true;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 104723, 104810);

                    f_1657_104723_104809(f_1657_104723_104749(_runspace), SpecialVariables.NestedPromptCounterVarPath, 1);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 104830, 105716) || true) && (isNestedStop)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 104830, 105716);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 105091, 105269) || true) && (_nestedDebugStopCompleteEvent == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 105091, 105269);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 105182, 105246);

                            _nestedDebugStopCompleteEvent = f_1657_105214_105245(false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 105091, 105269);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 105293, 105317);

                        _nestedDebugging = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 105339, 105387);

                        f_1657_105339_105386(this, _nestedDebugStopCompleteEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 104830, 105716);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 104830, 105716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 105660, 105697);

                        f_1657_105660_105696(                    // Blocking call.
                                                                 // Process all client commands as nested until nested pipeline is exited at
                                                                 // which point this call returns.
                                            _driverInvoker);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 104830, 105716);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 105745, 105792);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 105745, 105792);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1657, 105806, 105925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 105846, 105867);

                    _inDebugMode = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 105885, 105910);

                    _nestedDebugging = false;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1657, 105806, 105925);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106016, 106229) || true) && (_raiseStopEventLocally)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 106016, 106229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106076, 106107);

                    _raiseStopEventLocally = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106125, 106147);

                    LocalDebugMode = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106165, 106214);

                    f_1657_106165_106213(this, this, _debuggerStopEventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 106016, 106229);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 104580, 106240);

                System.Management.Automation.ExecutionContext
                f_1657_104723_104749(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 104723, 104749);
                    return return_v;
                }


                int
                f_1657_104723_104809(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 104723, 104809);
                    return 0;
                }


                System.Threading.ManualResetEventSlim
                f_1657_105214_105245(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEventSlim(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 105214, 105245);
                    return return_v;
                }


                int
                f_1657_105339_105386(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Threading.ManualResetEventSlim
                debugModeCompletedEvent)
                {
                    this_param.OnEnterDebugMode(debugModeCompletedEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 105339, 105386);
                    return 0;
                }


                int
                f_1657_105660_105696(System.Management.Automation.IRSPDriverInvoke
                this_param)
                {
                    this_param.EnterNestedPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 105660, 105696);
                    return 0;
                }


                int
                f_1657_106165_106213(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.ServerRemoteDebugger
                sender, System.Management.Automation.DebuggerStopEventArgs
                e)
                {
                    this_param.HandleDebuggerStop((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 106165, 106213);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 104580, 106240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 104580, 106240);
            }
        }

        private void OnEnterDebugMode(ManualResetEventSlim debugModeCompletedEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 106409, 107166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106509, 106597);

                f_1657_106509_106596(f_1657_106520_106550_M(!debugModeCompletedEvent.IsSet), "Event should always be non-signaled here.");
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106613, 107155) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 106613, 107155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106658, 106689);

                        f_1657_106658_106688(debugModeCompletedEvent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106707, 106739);

                        f_1657_106707_106738(debugModeCompletedEvent);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106759, 107140) || true) && (_threadCommandProcessing != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 106759, 107140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106878, 106914);

                            f_1657_106878_106913(                    // Process command.
                                                _threadCommandProcessing);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 106936, 106968);

                            _threadCommandProcessing = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 106759, 107140);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 106759, 107140);
                            DynAbs.Tracing.TraceSender.TraceBreak(1657, 107115, 107121);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 106759, 107140);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 106613, 107155);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1657, 106613, 107155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1657, 106613, 107155);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 106409, 107166);

                bool
                f_1657_106520_106550_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 106520, 106550);
                    return return_v;
                }


                int
                f_1657_106509_106596(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 106509, 106596);
                    return 0;
                }


                int
                f_1657_106658_106688(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Wait();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 106658, 106688);
                    return 0;
                }


                int
                f_1657_106707_106738(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 106707, 106738);
                    return 0;
                }


                int
                f_1657_106878_106913(System.Management.Automation.ServerRemoteDebugger.ThreadCommandProcessing
                this_param)
                {
                    this_param.DoInvoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 106878, 106913);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 106409, 107166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 106409, 107166);
            }
        }

        private void ExitDebugMode(DebuggerResumeAction resumeAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 107277, 108006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 107363, 107414);

                _debuggerStopEventArgs.ResumeAction = resumeAction;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 107466, 107812) || true) && (_nestedDebugging)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 107466, 107812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 107577, 107613);

                        f_1657_107577_107612(                    // Release nested debugger.
                                            _nestedDebugStopCompleteEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 107466, 107812);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 107466, 107812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 107757, 107793);

                        f_1657_107757_107792(                    // Release EnterDebugMode blocking call.
                                            _driverInvoker);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 107466, 107812);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 107832, 107919);

                    f_1657_107832_107918(f_1657_107832_107858(_runspace), SpecialVariables.NestedPromptCounterVarPath, 0);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 107948, 107995);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 107948, 107995);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 107277, 108006);

                int
                f_1657_107577_107612(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 107577, 107612);
                    return 0;
                }


                int
                f_1657_107757_107792(System.Management.Automation.IRSPDriverInvoke
                this_param)
                {
                    this_param.ExitNestedPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 107757, 107792);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1657_107832_107858(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 107832, 107858);
                    return return_v;
                }


                int
                f_1657_107832_107918(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 107832, 107918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 107277, 108006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 107277, 108006);
            }
        }

        private void SubscribeWrappedDebugger(Debugger wrappedDebugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 108018, 108343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108106, 108157);

                wrappedDebugger.DebuggerStop += HandleDebuggerStop;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108158, 108159);
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108173, 108234);

                wrappedDebugger.BreakpointUpdated += HandleBreakpointUpdated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108235, 108236);
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108250, 108332);

                wrappedDebugger.NestedDebuggingCancelledEvent += HandleNestedDebuggingCancelEvent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 108018, 108343);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 108018, 108343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 108018, 108343);
            }
        }

        private void UnsubscribeWrappedDebugger(Debugger wrappedDebugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 108355, 108682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108445, 108496);

                wrappedDebugger.DebuggerStop -= HandleDebuggerStop;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108497, 108498);
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108512, 108573);

                wrappedDebugger.BreakpointUpdated -= HandleBreakpointUpdated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108574, 108575);
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108589, 108671);

                wrappedDebugger.NestedDebuggingCancelledEvent -= HandleNestedDebuggingCancelEvent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 108355, 108682);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 108355, 108682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 108355, 108682);
            }
        }

        private bool IsDebuggingSupported()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 108694, 109300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108828, 108885);

                LocalRunspace
                localRunspace = _runspace as LocalRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108899, 109261) || true) && (localRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 108899, 109261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 108958, 109065);

                    CmdletInfo
                    cmdletInfo = f_1657_108982_109064(f_1657_108982_109031(f_1657_108982_109012(localRunspace)), SetPSBreakCommandText)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 109083, 109246) || true) && ((cmdletInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1657, 109087, 109172) && (f_1657_109112_109133(cmdletInfo) != SessionStateEntryVisibility.Public)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 109083, 109246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 109214, 109227);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 109083, 109246);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 108899, 109261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 109277, 109289);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 108694, 109300);

                System.Management.Automation.ExecutionContext
                f_1657_108982_109012(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 108982, 109012);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1657_108982_109031(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 108982, 109031);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1657_108982_109064(System.Management.Automation.SessionStateInternal
                this_param, string
                cmdletName)
                {
                    var return_v = this_param.GetCmdlet(cmdletName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 108982, 109064);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1657_109112_109133(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 109112, 109133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 108694, 109300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 108694, 109300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HandleStopSignal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 109512, 110360);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 109634, 109784) || true) && (f_1657_109638_109646() && (DynAbs.Tracing.TraceSender.Expression_True(1657, 109638, 109684) && (_threadCommandProcessing != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 109634, 109784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 109718, 109739);

                    f_1657_109718_109738(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 109757, 109769);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 109634, 109784);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 110019, 110072);

                f_1657_110019_110071(f_1657_110019_110041(_wrappedDebugger), DebugModes.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 110086, 110320) || true) && (f_1657_110090_110102())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 110086, 110320);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 110180, 110229);

                        f_1657_110180_110228(this, DebuggerResumeAction.Continue);
                    }
                    catch (PSInvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 110266, 110305);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 110266, 110305);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 110086, 110320);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 110336, 110349);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 109512, 110360);

                bool
                f_1657_109638_109646()
                {
                    var return_v = IsPushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 109638, 109646);
                    return return_v;
                }


                int
                f_1657_109718_109738(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    this_param.StopProcessCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 109718, 109738);
                    return 0;
                }


                System.Management.Automation.Debugger
                f_1657_110019_110041(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 110019, 110041);
                    return return_v;
                }


                int
                f_1657_110019_110071(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 110019, 110071);
                    return 0;
                }


                bool
                f_1657_110090_110102()
                {
                    var return_v = InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 110090, 110102);
                    return return_v;
                }


                int
                f_1657_110180_110228(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.SetDebuggerAction(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 110180, 110228);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 109512, 110360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 109512, 110360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CheckDebuggerState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 110522, 110830);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 110581, 110819) || true) && ((f_1657_110586_110618(f_1657_110586_110608(_wrappedDebugger)) == DebugModes.None && (DynAbs.Tracing.TraceSender.Expression_True(1657, 110586, 110722) && (f_1657_110659_110668() & DebugModes.RemoteScript) == DebugModes.RemoteScript)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 110581, 110819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 110757, 110804);

                    f_1657_110757_110803(f_1657_110757_110779(_wrappedDebugger), f_1657_110793_110802());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 110581, 110819);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 110522, 110830);

                System.Management.Automation.Debugger
                f_1657_110586_110608(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 110586, 110608);
                    return return_v;
                }


                System.Management.Automation.DebugModes
                f_1657_110586_110618(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.DebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 110586, 110618);
                    return return_v;
                }


                System.Management.Automation.DebugModes
                f_1657_110659_110668()
                {
                    var return_v = DebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 110659, 110668);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_110757_110779(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 110757, 110779);
                    return return_v;
                }


                System.Management.Automation.DebugModes
                f_1657_110793_110802()
                {
                    var return_v = DebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 110793, 110802);
                    return return_v;
                }


                int
                f_1657_110757_110803(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 110757, 110803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 110522, 110830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 110522, 110830);
            }
        }

        internal void StartPowerShellCommand(
                    PowerShell powershell,
                    Guid powershellId,
                    Guid runspacePoolId,
                    ServerRunspacePoolDriver runspacePoolDriver,
                    ApartmentState apartmentState,
                    ServerRemoteHost remoteHost,
                    HostInfo hostInfo,
                    RemoteStreamOptions streamOptions,
                    bool addToHistory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 110842, 113053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 111455, 111593);

                Runspace
                runspace = (DynAbs.Tracing.TraceSender.Conditional_F1(1657, 111475, 111495) || (((remoteHost != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1657, 111515, 111557)) || DynAbs.Tracing.TraceSender.Conditional_F3(1657, 111560, 111592))) ? f_1657_111515_111557(remoteHost) : f_1657_111560_111592()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 111609, 111625);

                f_1657_111609_111624(
                            runspace);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 111677, 111753);

                    powershell.InvocationStateChanged += HandlePowerShellInvocationStateChanged;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 111771, 111801);

                    f_1657_111771_111800(powershell, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 111821, 112029);

                    string
                    script = @"
                    param ($Debugger, $Commands, $output)
                    trap { throw $_ }

                    $Debugger.ProcessCommand($Commands, $output)
                    "
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 112049, 112118);

                    PSDataCollection<PSObject>
                    output = f_1657_112085_112117()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 112136, 112192);

                    PSCommand
                    Commands = f_1657_112157_112191(f_1657_112171_112190(powershell))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 112210, 112238);

                    f_1657_112210_112237(f_1657_112210_112229(powershell));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 112256, 112382);

                    f_1657_112256_112381(f_1657_112256_112350(f_1657_112256_112315(f_1657_112256_112284(powershell, script), "Debugger", this), "Commands", Commands), "output", output);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 112400, 112859);

                    ServerPowerShellDriver
                    driver = f_1657_112432_112858(powershell, null, true, powershellId, runspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, runspace, output)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 112879, 112894);

                    f_1657_112879_112893(
                                    driver);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1657, 112923, 113042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 112973, 112990);

                    f_1657_112973_112989(runspace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113008, 113027);

                    f_1657_113008_113026(runspace);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1657, 112923, 113042);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 110842, 113053);

                System.Management.Automation.Runspaces.Runspace
                f_1657_111515_111557(System.Management.Automation.Remoting.ServerRemoteHost
                host)
                {
                    var return_v = RunspaceFactory.CreateRunspace((System.Management.Automation.Host.PSHost)host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 111515, 111557);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1657_111560_111592()
                {
                    var return_v = RunspaceFactory.CreateRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 111560, 111592);
                    return return_v;
                }


                int
                f_1657_111609_111624(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 111609, 111624);
                    return 0;
                }


                int
                f_1657_111771_111800(System.Management.Automation.PowerShell
                this_param, bool
                isNested)
                {
                    this_param.SetIsNested(isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 111771, 111800);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1657_112085_112117()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112085, 112117);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_112171_112190(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 112171, 112190);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_112157_112191(System.Management.Automation.PSCommand
                commandToClone)
                {
                    var return_v = new System.Management.Automation.PSCommand(commandToClone);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112157, 112191);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1657_112210_112229(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 112210, 112229);
                    return return_v;
                }


                int
                f_1657_112210_112237(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112210, 112237);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1657_112256_112284(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112256, 112284);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_112256_112315(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ServerRemoteDebugger
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112256, 112315);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_112256_112350(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.PSCommand
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112256, 112350);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1657_112256_112381(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112256, 112381);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDriver
                f_1657_112432_112858(System.Management.Automation.PowerShell
                powershell, System.Management.Automation.PowerShell
                extraPowerShell, bool
                noInput, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId, System.Management.Automation.ServerRunspacePoolDriver
                runspacePoolDriver, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.RemoteStreamOptions
                streamOptions, bool
                addToHistory, System.Management.Automation.Runspaces.Runspace
                rsToUse, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDriver(powershell, extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112432, 112858);
                    return return_v;
                }


                System.IAsyncResult
                f_1657_112879_112893(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112879, 112893);
                    return return_v;
                }


                int
                f_1657_112973_112989(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 112973, 112989);
                    return 0;
                }


                int
                f_1657_113008_113026(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 113008, 113026);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 110842, 113053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 110842, 113053);
            }
        }

        private void HandlePowerShellInvocationStateChanged(object sender, PSInvocationStateChangedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 113065, 113766);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113193, 113755) || true) && (f_1657_113197_113224(f_1657_113197_113218(e)) == PSInvocationState.Completed || (DynAbs.Tracing.TraceSender.Expression_False(1657, 113197, 113332) || f_1657_113276_113303(f_1657_113276_113297(e)) == PSInvocationState.Stopped) || (DynAbs.Tracing.TraceSender.Expression_False(1657, 113197, 113408) || f_1657_113353_113380(f_1657_113353_113374(e)) == PSInvocationState.Failed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 113193, 113755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113442, 113487);

                    PowerShell
                    powershell = sender as PowerShell
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113505, 113581);

                    powershell.InvocationStateChanged -= HandlePowerShellInvocationStateChanged;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113601, 113668);

                    Runspace
                    runspace = f_1657_113621_113655(powershell) as Runspace
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113686, 113703);

                    f_1657_113686_113702(runspace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113721, 113740);

                    f_1657_113721_113739(runspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 113193, 113755);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 113065, 113766);

                System.Management.Automation.PSInvocationStateInfo
                f_1657_113197_113218(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113197, 113218);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1657_113197_113224(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113197, 113224);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1657_113276_113297(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113276, 113297);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1657_113276_113303(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113276, 113303);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1657_113353_113374(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113353, 113374);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1657_113353_113380(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113353, 113380);
                    return return_v;
                }


                object
                f_1657_113621_113655(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetRunspaceConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 113621, 113655);
                    return return_v;
                }


                int
                f_1657_113686_113702(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 113686, 113702);
                    return 0;
                }


                int
                f_1657_113721_113739(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 113721, 113739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 113065, 113766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 113065, 113766);
            }
        }

        internal int GetBreakpointCount()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 113778, 114129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113836, 113909);

                ScriptDebugger
                scriptDebugger = f_1657_113868_113890(_wrappedDebugger) as ScriptDebugger
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113923, 114118) || true) && (scriptDebugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 113923, 114118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 113983, 114028);

                    return f_1657_113990_114027(f_1657_113990_114021(scriptDebugger));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 113923, 114118);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 113923, 114118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114094, 114103);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 113923, 114118);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 113778, 114129);

                System.Management.Automation.Debugger
                f_1657_113868_113890(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113868, 113890);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                f_1657_113990_114021(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    var return_v = this_param.GetBreakpoints();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 113990, 114021);
                    return return_v;
                }


                int
                f_1657_113990_114027(System.Collections.Generic.List<System.Management.Automation.Breakpoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 113990, 114027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 113778, 114129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 113778, 114129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void PushDebugger(Debugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 114141, 114884);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114211, 114287) || true) && (debugger == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 114211, 114287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114265, 114272);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 114211, 114287);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114303, 114467) || true) && (f_1657_114307_114328(debugger, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 114303, 114467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114362, 114452);

                    throw f_1657_114368_114451(f_1657_114400_114450());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 114303, 114467);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114483, 114654) || true) && (f_1657_114487_114516(_wrappedDebugger))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 114483, 114654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114550, 114639);

                    throw f_1657_114556_114638(f_1657_114588_114637());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 114483, 114654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114709, 114760);

                f_1657_114709_114759(this, f_1657_114736_114758(_wrappedDebugger));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114774, 114810);

                f_1657_114774_114809(_wrappedDebugger, debugger);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114824, 114873);

                f_1657_114824_114872(this, f_1657_114849_114871(_wrappedDebugger));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 114141, 114884);

                bool
                f_1657_114307_114328(System.Management.Automation.Debugger
                this_param, System.Management.Automation.ServerRemoteDebugger
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 114307, 114328);
                    return return_v;
                }


                string
                f_1657_114400_114450()
                {
                    var return_v = DebuggerStrings.RemoteServerDebuggerCannotPushSelf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 114400, 114450);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1657_114368_114451(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 114368, 114451);
                    return return_v;
                }


                bool
                f_1657_114487_114516(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.IsOverridden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 114487, 114516);
                    return return_v;
                }


                string
                f_1657_114588_114637()
                {
                    var return_v = DebuggerStrings.RemoteServerDebuggerAlreadyPushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 114588, 114637);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1657_114556_114638(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 114556, 114638);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_114736_114758(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 114736, 114758);
                    return return_v;
                }


                int
                f_1657_114709_114759(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Debugger
                wrappedDebugger)
                {
                    this_param.UnsubscribeWrappedDebugger(wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 114709, 114759);
                    return 0;
                }


                int
                f_1657_114774_114809(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param, System.Management.Automation.Debugger
                newValue)
                {
                    this_param.Override(newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 114774, 114809);
                    return 0;
                }


                System.Management.Automation.Debugger
                f_1657_114849_114871(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 114849, 114871);
                    return return_v;
                }


                int
                f_1657_114824_114872(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Debugger
                wrappedDebugger)
                {
                    this_param.SubscribeWrappedDebugger(wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 114824, 114872);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 114141, 114884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 114141, 114884);
            }
        }

        internal void PopDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 114896, 115215);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114948, 114995) || true) && (f_1657_114952_114982_M(!_wrappedDebugger.IsOverridden))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 114948, 114995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 114986, 114993);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 114948, 114995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115050, 115101);

                f_1657_115050_115100(this, f_1657_115077_115099(_wrappedDebugger));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115115, 115141);

                f_1657_115115_115140(_wrappedDebugger);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115155, 115204);

                f_1657_115155_115203(this, f_1657_115180_115202(_wrappedDebugger));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 114896, 115215);

                bool
                f_1657_114952_114982_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 114952, 114982);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1657_115077_115099(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 115077, 115099);
                    return return_v;
                }


                int
                f_1657_115050_115100(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Debugger
                wrappedDebugger)
                {
                    this_param.UnsubscribeWrappedDebugger(wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 115050, 115100);
                    return 0;
                }


                int
                f_1657_115115_115140(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    this_param.Revert();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 115115, 115140);
                    return 0;
                }


                System.Management.Automation.Debugger
                f_1657_115180_115202(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1657, 115180, 115202);
                    return return_v;
                }


                int
                f_1657_115155_115203(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Debugger
                wrappedDebugger)
                {
                    this_param.SubscribeWrappedDebugger(wrappedDebugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 115155, 115203);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 114896, 115215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 114896, 115215);
            }
        }

        internal void ReleaseAndRaiseDebugStopLocal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1657, 115227, 115540);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115297, 115529) || true) && (_inDebugMode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1657, 115297, 115529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115421, 115451);

                    _raiseStopEventLocally = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 115469, 115514);

                    f_1657_115469_115513(this, DebuggerResumeAction.Continue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1657, 115297, 115529);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1657, 115227, 115540);

                int
                f_1657_115469_115513(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.ExitDebugMode(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 115469, 115513);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1657, 115227, 115540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 115227, 115540);
            }
        }

        internal bool LocalDebugMode
        {
            get;
            set;
        }

        static ServerRemoteDebugger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1657, 76788, 115914);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1657, 77465, 77507);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1657, 76788, 115914);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1657, 76788, 115914);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1657, 76788, 115914);

        System.Management.Automation.PSArgumentNullException
        f_1657_78061_78105(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 78061, 78105);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1657_78197_78236(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 78197, 78236);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1657_78328_78367(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 78328, 78367);
            return return_v;
        }


        System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>
        f_1657_78500_78533(System.Management.Automation.Debugger
        oldValue)
        {
            var return_v = new System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Debugger>(oldValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 78500, 78533);
            return return_v;
        }


        int
        f_1657_78550_78572(System.Management.Automation.ServerRemoteDebugger
        this_param)
        {
            this_param.SetDebuggerCallbacks();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1657, 78550, 78572);
            return 0;
        }

    }
}
