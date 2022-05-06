// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Diagnostics.Eventing;
using System.Management.Automation.Internal;

namespace System.Management.Automation.Tracing
{
    // pragma warning disable 16001,16003

    /// <summary>
    /// Defines enumerations for event ids.
    /// </summary>
    /// <remarks>add an entry for a new event that you
    /// add to the manifest. Set it to the same value
    /// that was set in the manifest</remarks>
    public enum PowerShellTraceEvent : int
    {
        /// <summary>
        /// None. (Should not be used)
        /// </summary>
        None = 0,

        /// <summary>
        /// HostNameResolve.
        /// </summary>
        HostNameResolve = 0x1001,

        /// <summary>
        /// SchemeResolve.
        /// </summary>
        SchemeResolve = 0x1002,

        /// <summary>
        /// ShellResolve.
        /// </summary>
        ShellResolve = 0x1003,

        /// <summary>
        /// RunspaceConstructor.
        /// </summary>
        RunspaceConstructor = 0x2001,

        /// <summary>
        /// RunspacePoolConstructor.
        /// </summary>
        RunspacePoolConstructor = 0x2002,

        /// <summary>
        /// RunspacePoolOpen.
        /// </summary>
        RunspacePoolOpen = 0x2003,

        /// <summary>
        /// OperationalTransferEventRunspacePool.
        /// </summary>
        OperationalTransferEventRunspacePool = 0x2004,

        /// <summary>
        /// RunspacePort.
        /// </summary>
        RunspacePort = 0x2F01,

        /// <summary>
        /// AppName.
        /// </summary>
        AppName = 0x2F02,

        /// <summary>
        /// ComputerName.
        /// </summary>
        ComputerName = 0x2F03,

        /// <summary>
        /// Scheme.
        /// </summary>
        Scheme = 0x2F04,

        /// <summary>
        /// TestAnalytic.
        /// </summary>
        TestAnalytic = 0x2F05,

        /// <summary>
        /// WSManConnectionInfoDump.
        /// </summary>
        WSManConnectionInfoDump = 0x2F06,

        /// <summary>
        /// AnalyticTransferEventRunspacePool.
        /// </summary>
        AnalyticTransferEventRunspacePool = 0x2F07,

        // Start: Transport related events

        /// <summary>
        /// TransportReceivedObject.
        /// </summary>
        TransportReceivedObject = 0x8001,

        /// <summary>
        /// AppDomainUnhandledExceptionAnalytic.
        /// </summary>
        AppDomainUnhandledExceptionAnalytic = 0x8007,

        /// <summary>
        /// TransportErrorAnalytic.
        /// </summary>
        TransportErrorAnalytic = 0x8008,

        /// <summary>
        /// AppDomainUnhandledException.
        /// </summary>
        AppDomainUnhandledException = 0x8009,

        /// <summary>
        /// TransportError.
        /// </summary>
        TransportError = 0x8010,

        /// <summary>
        /// WSManCreateShell.
        /// </summary>
        WSManCreateShell = 0x8011,

        /// <summary>
        /// WSManCreateShellCallbackReceived.
        /// </summary>
        WSManCreateShellCallbackReceived = 0x8012,

        /// <summary>
        /// WSManCloseShell.
        /// </summary>
        WSManCloseShell = 0x8013,

        /// <summary>
        /// WSManCloseShellCallbackReceived.
        /// </summary>
        WSManCloseShellCallbackReceived = 0x8014,

        /// <summary>
        /// WSManSendShellInputExtended.
        /// </summary>
        WSManSendShellInputExtended = 0x8015,

        /// <summary>
        /// WSManSendShellInputExCallbackReceived.
        /// </summary>
        WSManSendShellInputExtendedCallbackReceived = 0x8016,

        /// <summary>
        /// WSManReceiveShellOutputExtended.
        /// </summary>
        WSManReceiveShellOutputExtended = 0x8017,

        /// <summary>
        /// WSManReceiveShellOutputExCallbackReceived.
        /// </summary>
        WSManReceiveShellOutputExtendedCallbackReceived = 0x8018,

        /// <summary>
        /// WSManCreateCommand.
        /// </summary>
        WSManCreateCommand = 0x8019,

        /// <summary>
        /// WSManCreateCommandCallbackReceived.
        /// </summary>
        WSManCreateCommandCallbackReceived = 0x8020,

        /// <summary>
        /// WSManCloseCommand.
        /// </summary>
        WSManCloseCommand = 0x8021,

        /// <summary>
        /// WSManCloseCommandCallbackReceived.
        /// </summary>
        WSManCloseCommandCallbackReceived = 0x8022,

        /// <summary>
        /// WSManSignal.
        /// </summary>
        WSManSignal = 0x8023,

        /// <summary>
        /// WSManSignalCallbackReceived.
        /// </summary>
        WSManSignalCallbackReceived = 0x8024,

        /// <summary>
        /// UriRedirection.
        /// </summary>
        UriRedirection = 0x8025,

        /// <summary>
        /// ServerSendData.
        /// </summary>
        ServerSendData = 0x8051,

        /// <summary>
        /// ServerCreateRemoteSession.
        /// </summary>
        ServerCreateRemoteSession = 0x8052,

        /// <summary>
        /// ReportContext.
        /// </summary>
        ReportContext = 0x8053,

        /// <summary>
        /// ReportOperationComplete.
        /// </summary>
        ReportOperationComplete = 0x8054,

        /// <summary>
        /// ServerCreateCommandSession.
        /// </summary>
        ServerCreateCommandSession = 0x8055,

        /// <summary>
        /// ServerStopCommand.
        /// </summary>
        ServerStopCommand = 0x8056,

        /// <summary>
        /// ServerReceivedData.
        /// </summary>
        ServerReceivedData = 0x8057,

        /// <summary>
        /// ServerClientReceiveRequest.
        /// </summary>
        ServerClientReceiveRequest = 0x8058,

        /// <summary>
        /// ServerCloseOperation.
        /// </summary>
        ServerCloseOperation = 0x8059,

        /// <summary>
        /// LoadingPSCustomShellAssembly.
        /// </summary>
        LoadingPSCustomShellAssembly = 0x8061,

        /// <summary>
        /// LoadingPSCustomShellType.
        /// </summary>
        LoadingPSCustomShellType = 0x8062,

        /// <summary>
        /// ReceivedRemotingFragment.
        /// </summary>
        ReceivedRemotingFragment = 0x8063,

        /// <summary>
        /// SentRemotingFragment.
        /// </summary>
        SentRemotingFragment = 0x8064,

        /// <summary>
        /// WSManPluginShutdown.
        /// </summary>
        WSManPluginShutdown = 0x8065,
        // End: Transport related events

        // Start: Serialization related events

        /// <summary>
        /// SerializerWorkflowLoadSuccess.
        /// </summary>
        SerializerWorkflowLoadSuccess = 0x7001,

        /// <summary>
        /// SerializerWorkflowLoadFailure.
        /// </summary>
        SerializerWorkflowLoadFailure = 0x7002,

        /// <summary>
        /// SerializerDepthOverride.
        /// </summary>
        SerializerDepthOverride = 0x7003,

        /// <summary>
        /// SerializerModeOverride.
        /// </summary>
        SerializerModeOverride = 0x7004,

        /// <summary>
        /// SerializerScriptPropertyWithoutRunspace.
        /// </summary>
        SerializerScriptPropertyWithoutRunspace = 0x7005,

        /// <summary>
        /// SerializerPropertyGetterFailed.
        /// </summary>
        SerializerPropertyGetterFailed = 0x7006,

        /// <summary>
        /// SerializerEnumerationFailed.
        /// </summary>
        SerializerEnumerationFailed = 0x7007,

        /// <summary>
        /// SerializerToStringFailed.
        /// </summary>
        SerializerToStringFailed = 0x7008,

        /// <summary>
        /// SerializerMaxDepthWhenSerializing.
        /// </summary>
        SerializerMaxDepthWhenSerializing = 0x700A,

        /// <summary>
        /// SerializerXmlExceptionWhenDeserializing.
        /// </summary>
        SerializerXmlExceptionWhenDeserializing = 0x700B,

        /// <summary>
        /// SerializerSpecificPropertyMissing.
        /// </summary>
        SerializerSpecificPropertyMissing = 0x700C,
        // End: Serialization related events

        // Start: PerformanceTrack related events
        /// <summary>
        /// PerformanceTrackConsoleStartupStart.
        /// </summary>
        PerformanceTrackConsoleStartupStart = 0xA001,

        /// <summary>
        /// PerformanceTrackConsoleStartupStop.
        /// </summary>
        PerformanceTrackConsoleStartupStop = 0xA002,
        // End: Preftrack related events

        /// <summary>
        /// ErrorRecord.
        /// </summary>
        ErrorRecord = 0xB001,

        /// <summary>
        /// Exception.
        /// </summary>
        Exception = 0xB002,

        /// <summary>
        /// PowerShellObject.
        /// </summary>
        PowerShellObject = 0xB003,

        /// <summary>
        /// Job.
        /// </summary>
        Job = 0xB004,

        /// <summary>
        /// Writing a simple trace message from code.
        /// </summary>
        TraceMessage = 0xB005,

        /// <summary>
        /// Trace the WSManConnectionInfo used for this connection.
        /// </summary>
        TraceWSManConnectionInfo = 0xB006,

        /// <summary>
        /// Writing a simple trace message from code with 2
        /// strings.
        /// </summary>
        TraceMessage2 = 0xC001,

        /// <summary>
        /// Writing a simple trace message from code with 2
        /// strings.
        /// </summary>
        TraceMessageGuid = 0xC002,
    }

    /// <summary>
    /// Defines enumerations for channels.
    /// </summary>
    // pragma warning disable 16001
    public enum PowerShellTraceChannel
    {
        /// <summary>
        /// None (No channel selected, should not be used)
        /// </summary>
        None = 0,
        /// <summary>
        /// Operational Channel.
        /// </summary>
        Operational = 0x10,

        /// <summary>
        /// Analytic Channel.
        /// </summary>
        Analytic = 0x11,

        /// <summary>
        /// Debug Channel.
        /// </summary>
        Debug = 0x12,
    }
    // pragma warning restore 16001

    /// <summary>
    /// Define enumerations for levels.
    /// </summary>
    public enum PowerShellTraceLevel
    {
        /// <summary>
        /// LogAlways.
        /// </summary>
        LogAlways = 0,

        /// <summary>
        /// Critical.
        /// </summary>
        Critical = 1,

        /// <summary>
        /// Error.
        /// </summary>
        Error = 2,

        /// <summary>
        /// Warning.
        /// </summary>
        Warning = 3,

        /// <summary>
        /// Informational.
        /// </summary>
        Informational = 4,

        /// <summary>
        /// Verbose.
        /// </summary>
        Verbose = 5,

        /// <summary>
        /// Debug.
        /// </summary>
        Debug = 20,
    }

    /// <summary>
    /// Defines enumerations for op codes.
    /// </summary>
    public enum PowerShellTraceOperationCode
    {
        /// <summary>
        /// None.  (Should not be used)
        /// </summary>
        None = 0,

        /// <summary>
        /// Open.
        /// </summary>
        Open = 10,

        /// <summary>
        /// Close.
        /// </summary>
        Close = 11,

        /// <summary>
        /// Connect.
        /// </summary>
        Connect = 12,

        /// <summary>
        /// Disconnect.
        /// </summary>
        Disconnect = 13,

        /// <summary>
        /// Negotiate.
        /// </summary>
        Negotiate = 14,

        /// <summary>
        /// Create.
        /// </summary>
        Create = 15,

        /// <summary>
        /// Constructor.
        /// </summary>
        Constructor = 16,

        /// <summary>
        /// Dispose.
        /// </summary>
        Dispose = 17,

        /// <summary>
        /// EventHandler.
        /// </summary>
        EventHandler = 18,

        /// <summary>
        /// Exception.
        /// </summary>
        Exception = 19,

        /// <summary>
        /// Method.
        /// </summary>
        Method = 20,

        /// <summary>
        /// Send.
        /// </summary>
        Send = 21,

        /// <summary>
        /// Receive.
        /// </summary>
        Receive = 22,

        /// <summary>
        /// WorkflowLoad.
        /// </summary>
        WorkflowLoad = 23,

        /// <summary>
        /// SerializationSettings.
        /// </summary>
        SerializationSettings = 24,

        /// <summary>
        /// WinInfo.
        /// </summary>
        WinInfo,

        /// <summary>
        /// WinStart.
        /// </summary>
        WinStart,

        /// <summary>
        /// WinStop.
        /// </summary>
        WinStop,

        /// <summary>
        /// WinDCStart.
        /// </summary>
        WinDCStart,

        /// <summary>
        /// WinDCStop.
        /// </summary>
        WinDCStop,

        /// <summary>
        /// WinExtension.
        /// </summary>
        WinExtension,

        /// <summary>
        /// WinReply.
        /// </summary>
        WinReply,

        /// <summary>
        /// WinResume.
        /// </summary>
        WinResume,

        /// <summary>
        /// WinSuspend.
        /// </summary>
        WinSuspend,
    }

    /// <summary>
    /// Defines Tasks.
    /// </summary>
    public enum PowerShellTraceTask
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// CreateRunspace.
        /// </summary>
        CreateRunspace = 1,

        /// <summary>
        /// ExecuteCommand.
        /// </summary>
        ExecuteCommand = 2,

        /// <summary>
        /// Serialization.
        /// </summary>
        Serialization = 3,

        /// <summary>
        /// PowerShellConsoleStartup.
        /// </summary>
        PowerShellConsoleStartup = 4,
    }

    /// <summary>
    /// Defines Keywords.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1028")]
    [Flags]
    public enum PowerShellTraceKeywords : ulong
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Runspace.
        /// </summary>
        Runspace = 0x1,

        /// <summary>
        /// Pipeline.
        /// </summary>
        Pipeline = 0x2,

        /// <summary>
        /// Protocol.
        /// </summary>
        Protocol = 0x4,

        /// <summary>
        /// Transport.
        /// </summary>
        Transport = 0x8,

        /// <summary>
        /// Host.
        /// </summary>
        Host = 0x10,

        /// <summary>
        /// Cmdlets.
        /// </summary>
        Cmdlets = 0x20,

        /// <summary>
        /// Serializer.
        /// </summary>
        Serializer = 0x40,

        /// <summary>
        /// Session.
        /// </summary>
        Session = 0x80,

        /// <summary>
        /// ManagedPlugIn.
        /// </summary>
        ManagedPlugIn = 0x100,

        /// <summary>
        /// </summary>
        UseAlwaysDebug = 0x2000000000000000,

        /// <summary>
        /// </summary>
        UseAlwaysOperational = 0x8000000000000000,

        /// <summary>
        /// </summary>
        UseAlwaysAnalytic = 0x4000000000000000,
    }
    public abstract class BaseChannelWriter : IDisposable
    {
        private bool disposed;

        public virtual void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 16730, 16917);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 16784, 16906) || true) && (!disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 16784, 16906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 16831, 16857);

                    f_1034_16831_16856(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 16875, 16891);

                    disposed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 16784, 16906);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 16730, 16917);

                int
                f_1034_16831_16856(System.Management.Automation.Tracing.BaseChannelWriter
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 16831, 16856);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 16730, 16917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 16730, 16917);
            }
        }

        public virtual bool TraceError(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 17001, 17204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 17181, 17193);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 17001, 17204);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 17001, 17204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 17001, 17204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool TraceWarning(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 17290, 17495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 17472, 17484);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 17290, 17495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 17290, 17495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 17290, 17495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool TraceInformational(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 17587, 17798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 17775, 17787);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 17587, 17798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 17587, 17798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 17587, 17798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool TraceVerbose(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 17884, 18089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 18066, 18078);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 17884, 18089);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 17884, 18089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 17884, 18089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool TraceDebug(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 18173, 18376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 18353, 18365);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 18173, 18376);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 18173, 18376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 18173, 18376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool TraceLogAlways(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 18464, 18671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 18648, 18660);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 18464, 18671);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 18464, 18671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 18464, 18671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool TraceCritical(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 18758, 18964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 18941, 18953);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 18758, 18964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 18758, 18964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 18758, 18964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual PowerShellTraceKeywords Keywords
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 19095, 19182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 19131, 19167);

                    return PowerShellTraceKeywords.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 19095, 19182);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 19023, 19316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 19023, 19316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 19198, 19305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 19234, 19290);

                    PowerShellTraceKeywords
                    powerShellTraceKeywords = value
                    ;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 19198, 19305);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 19023, 19316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 19023, 19316);
                }
            }
        }

        public BaseChannelWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1034, 16550, 19323);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 16633, 16641);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1034, 16550, 19323);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 16550, 19323);
        }


        static BaseChannelWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1034, 16550, 19323);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1034, 16550, 19323);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 16550, 19323);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1034, 16550, 19323);
    }
    public sealed class NullWriter : BaseChannelWriter
    {
        public static BaseChannelWriter Instance { get; }

        private NullWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1034, 19841, 19883);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1034, 19841, 19883);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 19841, 19883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 19841, 19883);
            }
        }

        static NullWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1034, 19607, 19890);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 19760, 19829);
            Instance = f_1034_19812_19828();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1034, 19607, 19890);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 19607, 19890);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1034, 19607, 19890);

        static System.Management.Automation.Tracing.NullWriter
        f_1034_19812_19828()
        {
            var return_v = new System.Management.Automation.Tracing.NullWriter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 19812, 19828);
            return return_v;
        }

    }
    public sealed class PowerShellChannelWriter : BaseChannelWriter
    {
        private readonly PowerShellTraceChannel _traceChannel;

        private static readonly EventProvider _provider;

        private bool disposed;

        private PowerShellTraceKeywords _keywords;

        public override PowerShellTraceKeywords Keywords
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 20748, 20816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 20784, 20801);

                    return _keywords;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 20748, 20816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 20675, 20912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 20675, 20912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 20832, 20901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 20868, 20886);

                    _keywords = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 20832, 20901);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 20675, 20912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 20675, 20912);
                }
            }
        }

        internal PowerShellChannelWriter(PowerShellTraceChannel traceChannel, PowerShellTraceKeywords keywords)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1034, 20924, 21127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 20294, 20307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 20555, 20563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 20606, 20615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 21052, 21081);

                _traceChannel = traceChannel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 21095, 21116);

                _keywords = keywords;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1034, 20924, 21127);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 20924, 21127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 20924, 21127);
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 21215, 21403);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 21270, 21392) || true) && (!disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 21270, 21392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 21317, 21343);

                    f_1034_21317_21342(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 21361, 21377);

                    disposed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 21270, 21392);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 21215, 21403);

                int
                f_1034_21317_21342(System.Management.Automation.Tracing.PowerShellChannelWriter
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 21317, 21342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 21215, 21403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 21215, 21403);
            }
        }

        private bool Trace(PowerShellTraceEvent traceEvent, PowerShellTraceLevel level, PowerShellTraceOperationCode operationCode,
                    PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 21415, 22297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 21624, 21822);

                EventDescriptor
                ed = f_1034_21645_21821(traceEvent, 1, _traceChannel, level, operationCode, task, _keywords)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 21951, 22228) || true) && (args != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 21951, 22228);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22010, 22015);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22001, 22213) || true) && (i < f_1034_22021_22032(args))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22034, 22037)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 22001, 22213))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 22001, 22213);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22079, 22194) || true) && (args[i] == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 22079, 22194);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22148, 22171);

                                args[i] = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 22079, 22194);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1034, 1, 213);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1034, 1, 213);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 21951, 22228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22244, 22286);

                return f_1034_22251_22285(_provider, ref ed, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 21415, 22297);

                System.Diagnostics.Eventing.EventDescriptor
                f_1034_21645_21821(System.Management.Automation.Tracing.PowerShellTraceEvent
                id, int
                version, System.Management.Automation.Tracing.PowerShellTraceChannel
                channel, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                opcode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, System.Management.Automation.Tracing.PowerShellTraceKeywords
                keywords)
                {
                    var return_v = new System.Diagnostics.Eventing.EventDescriptor((int)id, (byte)version, (byte)channel, (byte)level, (byte)opcode, (int)task, (long)keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 21645, 21821);
                    return return_v;
                }


                int
                f_1034_22021_22032(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 22021, 22032);
                    return return_v;
                }


                bool
                f_1034_22251_22285(System.Diagnostics.Eventing.EventProvider
                this_param, ref System.Diagnostics.Eventing.EventDescriptor
                eventDescriptor, params object[]
                eventPayload)
                {
                    var return_v = this_param.WriteEvent(ref eventDescriptor, eventPayload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 22251, 22285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 21415, 22297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 21415, 22297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TraceError(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 22381, 22653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22562, 22642);

                return f_1034_22569_22641(this, traceEvent, PowerShellTraceLevel.Error, operationCode, task, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 22381, 22653);

                bool
                f_1034_22569_22641(System.Management.Automation.Tracing.PowerShellChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.Trace(traceEvent, level, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 22569, 22641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 22381, 22653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 22381, 22653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TraceWarning(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 22739, 23015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 22922, 23004);

                return f_1034_22929_23003(this, traceEvent, PowerShellTraceLevel.Warning, operationCode, task, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 22739, 23015);

                bool
                f_1034_22929_23003(System.Management.Automation.Tracing.PowerShellChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.Trace(traceEvent, level, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 22929, 23003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 22739, 23015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 22739, 23015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TraceInformational(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 23107, 23395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 23296, 23384);

                return f_1034_23303_23383(this, traceEvent, PowerShellTraceLevel.Informational, operationCode, task, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 23107, 23395);

                bool
                f_1034_23303_23383(System.Management.Automation.Tracing.PowerShellChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.Trace(traceEvent, level, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 23303, 23383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 23107, 23395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 23107, 23395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TraceVerbose(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 23481, 23757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 23664, 23746);

                return f_1034_23671_23745(this, traceEvent, PowerShellTraceLevel.Verbose, operationCode, task, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 23481, 23757);

                bool
                f_1034_23671_23745(System.Management.Automation.Tracing.PowerShellChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.Trace(traceEvent, level, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 23671, 23745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 23481, 23757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 23481, 23757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TraceDebug(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 23841, 24246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 24147, 24235);

                return f_1034_24154_24234(this, traceEvent, PowerShellTraceLevel.Informational, operationCode, task, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 23841, 24246);

                bool
                f_1034_24154_24234(System.Management.Automation.Tracing.PowerShellChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.Trace(traceEvent, level, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 24154, 24234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 23841, 24246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 23841, 24246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TraceLogAlways(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 24334, 24614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 24519, 24603);

                return f_1034_24526_24602(this, traceEvent, PowerShellTraceLevel.LogAlways, operationCode, task, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 24334, 24614);

                bool
                f_1034_24526_24602(System.Management.Automation.Tracing.PowerShellChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.Trace(traceEvent, level, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 24526, 24602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 24334, 24614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 24334, 24614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TraceCritical(PowerShellTraceEvent traceEvent, PowerShellTraceOperationCode operationCode, PowerShellTraceTask task, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 24701, 24979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 24885, 24968);

                return f_1034_24892_24967(this, traceEvent, PowerShellTraceLevel.Critical, operationCode, task, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 24701, 24979);

                bool
                f_1034_24892_24967(System.Management.Automation.Tracing.PowerShellChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceLevel
                level, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.Trace(traceEvent, level, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 24892, 24967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 24701, 24979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 24701, 24979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PowerShellChannelWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1034, 20174, 24986);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 20469, 20529);
            _provider = f_1034_20481_20529(PSEtwLogProvider.ProviderGuid);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1034, 20174, 24986);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 20174, 24986);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1034, 20174, 24986);

        static System.Diagnostics.Eventing.EventProvider
        f_1034_20481_20529(System.Guid
        providerGuid)
        {
            var return_v = new System.Diagnostics.Eventing.EventProvider(providerGuid);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 20481, 20529);
            return return_v;
        }

    }
    public sealed class PowerShellTraceSource : IDisposable
    {
        private bool disposed;

        internal PowerShellTraceSource(PowerShellTraceTask task, PowerShellTraceKeywords keywords)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1034, 25451, 26563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 25357, 25365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27109, 27189);
                this.Keywords = PowerShellTraceKeywords.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27300, 27373);
                this.Task = PowerShellTraceTask.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 49825, 49871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 49986, 50035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 50151, 50203);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 25566, 26552) || true) && (f_1034_25570_25584())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 25566, 26552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 25618, 25802);

                    DebugChannel = f_1034_25633_25801(PowerShellTraceChannel.Debug, keywords | PowerShellTraceKeywords.UseAlwaysDebug);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 25820, 26016);

                    AnalyticChannel = f_1034_25838_26015(PowerShellTraceChannel.Analytic, keywords | PowerShellTraceKeywords.UseAlwaysAnalytic);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26034, 26241);

                    OperationalChannel = f_1034_26055_26240(PowerShellTraceChannel.Operational, keywords | PowerShellTraceKeywords.UseAlwaysOperational);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26261, 26278);

                    this.Task = task;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26296, 26321);

                    this.Keywords = keywords;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 25566, 26552);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 25566, 26552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26387, 26422);

                    DebugChannel = f_1034_26402_26421();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26440, 26478);

                    AnalyticChannel = f_1034_26458_26477();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26496, 26537);

                    OperationalChannel = f_1034_26517_26536();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 25566, 26552);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1034, 25451, 26563);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 25451, 26563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 25451, 26563);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 26651, 26964);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26697, 26953) || true) && (!disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 26697, 26953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26744, 26760);

                    disposed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26778, 26804);

                    f_1034_26778_26803(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26824, 26847);

                    f_1034_26824_26846(f_1034_26824_26836());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26865, 26891);

                    f_1034_26865_26890(f_1034_26865_26880());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 26909, 26938);

                    f_1034_26909_26937(f_1034_26909_26927());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 26697, 26953);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 26651, 26964);

                int
                f_1034_26778_26803(System.Management.Automation.Tracing.PowerShellTraceSource
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 26778, 26803);
                    return 0;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_26824_26836()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 26824, 26836);
                    return return_v;
                }


                int
                f_1034_26824_26846(System.Management.Automation.Tracing.BaseChannelWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 26824, 26846);
                    return 0;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_26865_26880()
                {
                    var return_v = AnalyticChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 26865, 26880);
                    return return_v;
                }


                int
                f_1034_26865_26890(System.Management.Automation.Tracing.BaseChannelWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 26865, 26890);
                    return 0;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_26909_26927()
                {
                    var return_v = OperationalChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 26909, 26927);
                    return return_v;
                }


                int
                f_1034_26909_26937(System.Management.Automation.Tracing.BaseChannelWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 26909, 26937);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 26651, 26964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 26651, 26964);
            }
        }

        public PowerShellTraceKeywords Keywords { get; }

        public PowerShellTraceTask Task { get; set; }

        private bool IsEtwSupported
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 27437, 27536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27473, 27521);

                    return f_1034_27480_27515(f_1034_27480_27509(f_1034_27480_27501())) >= 6;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 27437, 27536);

                    System.OperatingSystem
                    f_1034_27480_27501()
                    {
                        var return_v = Environment.OSVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 27480, 27501);
                        return return_v;
                    }


                    System.Version
                    f_1034_27480_27509(System.OperatingSystem
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 27480, 27509);
                        return return_v;
                    }


                    int
                    f_1034_27480_27515(System.Version
                    this_param)
                    {
                        var return_v = this_param.Major;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 27480, 27515);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 27385, 27547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 27385, 27547);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool TraceErrorRecord(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 27637, 29193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27715, 29182) || true) && (errorRecord != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 27715, 29182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27772, 27816);

                    Exception
                    exception = f_1034_27794_27815(errorRecord)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27834, 27865);

                    string
                    innerException = "None"
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27883, 28030) || true) && (f_1034_27887_27911(exception) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 27883, 28030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 27961, 28011);

                        innerException = f_1034_27978_28010(f_1034_27978_28002(exception));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 27883, 28030);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 28050, 28101);

                    ErrorCategoryInfo
                    cinfo = f_1034_28076_28100(errorRecord)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 28119, 28143);

                    string
                    message = "None"
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 28163, 28303) || true) && (f_1034_28167_28191(errorRecord) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 28163, 28303);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 28241, 28284);

                        message = f_1034_28251_28283(f_1034_28251_28275(errorRecord));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 28163, 28303);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 28323, 28854);

                    return f_1034_28330_28853(f_1034_28330_28342(), PowerShellTraceEvent.ErrorRecord, PowerShellTraceOperationCode.Exception, PowerShellTraceTask.None, message, f_1034_28607_28632(f_1034_28607_28621(cinfo)), f_1034_28634_28646(cinfo), f_1034_28648_28664(cinfo), f_1034_28714_28747(errorRecord), f_1034_28797_28814(exception), f_1034_28816_28836(exception), innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 27715, 29182);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 27715, 29182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 28920, 29167);

                    return f_1034_28927_29166(f_1034_28927_28939(), PowerShellTraceEvent.ErrorRecord, PowerShellTraceOperationCode.Exception, PowerShellTraceTask.None, "NULL errorRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 27715, 29182);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 27637, 29193);

                System.Exception
                f_1034_27794_27815(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 27794, 27815);
                    return return_v;
                }


                System.Exception
                f_1034_27887_27911(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 27887, 27911);
                    return return_v;
                }


                System.Exception
                f_1034_27978_28002(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 27978, 28002);
                    return return_v;
                }


                string
                f_1034_27978_28010(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 27978, 28010);
                    return return_v;
                }


                System.Management.Automation.ErrorCategoryInfo
                f_1034_28076_28100(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.CategoryInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28076, 28100);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1034_28167_28191(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28167, 28191);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1034_28251_28275(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28251, 28275);
                    return return_v;
                }


                string
                f_1034_28251_28283(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28251, 28283);
                    return return_v;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_28330_28342()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28330, 28342);
                    return return_v;
                }


                System.Management.Automation.ErrorCategory
                f_1034_28607_28621(System.Management.Automation.ErrorCategoryInfo
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28607, 28621);
                    return return_v;
                }


                string
                f_1034_28607_28632(System.Management.Automation.ErrorCategory
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 28607, 28632);
                    return return_v;
                }


                string
                f_1034_28634_28646(System.Management.Automation.ErrorCategoryInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28634, 28646);
                    return return_v;
                }


                string
                f_1034_28648_28664(System.Management.Automation.ErrorCategoryInfo
                this_param)
                {
                    var return_v = this_param.TargetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28648, 28664);
                    return return_v;
                }


                string
                f_1034_28714_28747(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28714, 28747);
                    return return_v;
                }


                string
                f_1034_28797_28814(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28797, 28814);
                    return return_v;
                }


                string
                f_1034_28816_28836(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28816, 28836);
                    return return_v;
                }


                bool
                f_1034_28330_28853(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceError(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 28330, 28853);
                    return return_v;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_28927_28939()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 28927, 28939);
                    return return_v;
                }


                bool
                f_1034_28927_29166(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceError(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 28927, 29166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 27637, 29193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 27637, 29193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TraceException(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 29281, 30233);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 29353, 30222) || true) && (exception != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 29353, 30222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 29408, 29439);

                    string
                    innerException = "None"
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 29457, 29604) || true) && (f_1034_29461_29485(exception) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 29457, 29604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 29535, 29585);

                        innerException = f_1034_29552_29584(f_1034_29552_29576(exception));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 29457, 29604);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 29624, 29902);

                    return f_1034_29631_29901(f_1034_29631_29643(), PowerShellTraceEvent.Exception, PowerShellTraceOperationCode.Exception, PowerShellTraceTask.None, f_1034_29845_29862(exception), f_1034_29864_29884(exception), innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 29353, 30222);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 29353, 30222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 29968, 30207);

                    return f_1034_29975_30206(f_1034_29975_29987(), PowerShellTraceEvent.Exception, PowerShellTraceOperationCode.Exception, PowerShellTraceTask.None, "NULL exception");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 29353, 30222);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 29281, 30233);

                System.Exception
                f_1034_29461_29485(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 29461, 29485);
                    return return_v;
                }


                System.Exception
                f_1034_29552_29576(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 29552, 29576);
                    return return_v;
                }


                string
                f_1034_29552_29584(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 29552, 29584);
                    return return_v;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_29631_29643()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 29631, 29643);
                    return return_v;
                }


                string
                f_1034_29845_29862(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 29845, 29862);
                    return return_v;
                }


                string
                f_1034_29864_29884(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 29864, 29884);
                    return return_v;
                }


                bool
                f_1034_29631_29901(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceError(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 29631, 29901);
                    return return_v;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_29975_29987()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 29975, 29987);
                    return return_v;
                }


                bool
                f_1034_29975_30206(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceError(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 29975, 30206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 29281, 30233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 29281, 30233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TracePowerShellObject(PSObject powerShellObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 30328, 30611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 30413, 30600);

                return f_1034_30420_30599(f_1034_30420_30437(this), PowerShellTraceEvent.PowerShellObject, PowerShellTraceOperationCode.Method, PowerShellTraceTask.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 30328, 30611);

                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_30420_30437(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param)
                {
                    var return_v = this_param.DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 30420, 30437);
                    return return_v;
                }


                bool
                f_1034_30420_30599(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceDebug(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 30420, 30599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 30328, 30611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 30328, 30611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TraceJob(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 30693, 31602);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 30747, 31591) || true) && (job != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 30747, 31591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 30796, 31254);

                    return f_1034_30803_31253(f_1034_30803_30815(), PowerShellTraceEvent.Job, PowerShellTraceOperationCode.Method, PowerShellTraceTask.None, f_1034_31012_31057(f_1034_31012_31018(job), f_1034_31028_31056()), job.InstanceId.ToString(), f_1034_31086_31094(job), f_1034_31144_31156(job), f_1034_31158_31191(f_1034_31158_31180(f_1034_31158_31174(job))), f_1034_31241_31252(job));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 30747, 31591);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 30747, 31591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 31320, 31576);

                    return f_1034_31327_31575(f_1034_31327_31339(), PowerShellTraceEvent.Job, PowerShellTraceOperationCode.Method, PowerShellTraceTask.None, string.Empty, string.Empty, "NULL job");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 30747, 31591);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 30693, 31602);

                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_30803_30815()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 30803, 30815);
                    return return_v;
                }


                int
                f_1034_31012_31018(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31012, 31018);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1034_31028_31056()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31028, 31056);
                    return return_v;
                }


                string
                f_1034_31012_31057(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 31012, 31057);
                    return return_v;
                }


                string
                f_1034_31086_31094(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31086, 31094);
                    return return_v;
                }


                string
                f_1034_31144_31156(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31144, 31156);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1034_31158_31174(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31158, 31174);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1034_31158_31180(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31158, 31180);
                    return return_v;
                }


                string
                f_1034_31158_31191(System.Management.Automation.JobState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 31158, 31191);
                    return return_v;
                }


                string
                f_1034_31241_31252(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31241, 31252);
                    return return_v;
                }


                bool
                f_1034_30803_31253(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceDebug(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 30803, 31253);
                    return return_v;
                }


                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_31327_31339()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31327, 31339);
                    return return_v;
                }


                bool
                f_1034_31327_31575(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceDebug(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 31327, 31575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 30693, 31602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 30693, 31602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool WriteMessage(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 31738, 32048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 31803, 32037);

                return f_1034_31810_32036(f_1034_31810_31822(), PowerShellTraceEvent.TraceMessage, PowerShellTraceOperationCode.None, PowerShellTraceTask.None, message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 31738, 32048);

                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_31810_31822()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 31810, 31822);
                    return return_v;
                }


                bool
                f_1034_31810_32036(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceInformational(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 31810, 32036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 31738, 32048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 31738, 32048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool WriteMessage(string message1, string message2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 32230, 32570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 32313, 32559);

                return f_1034_32320_32558(f_1034_32320_32332(), PowerShellTraceEvent.TraceMessage2, PowerShellTraceOperationCode.None, PowerShellTraceTask.None, message1, message2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 32230, 32570);

                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_32320_32332()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 32320, 32332);
                    return return_v;
                }


                bool
                f_1034_32320_32558(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceInformational(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 32320, 32558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 32230, 32570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 32230, 32570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool WriteMessage(string message, Guid instanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 32753, 33096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 32835, 33085);

                return f_1034_32842_33084(f_1034_32842_32854(), PowerShellTraceEvent.TraceMessageGuid, PowerShellTraceOperationCode.None, PowerShellTraceTask.None, message, instanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 32753, 33096);

                System.Management.Automation.Tracing.BaseChannelWriter
                f_1034_32842_32854()
                {
                    var return_v = DebugChannel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 32842, 32854);
                    return return_v;
                }


                bool
                f_1034_32842_33084(System.Management.Automation.Tracing.BaseChannelWriter
                this_param, System.Management.Automation.Tracing.PowerShellTraceEvent
                traceEvent, System.Management.Automation.Tracing.PowerShellTraceOperationCode
                operationCode, System.Management.Automation.Tracing.PowerShellTraceTask
                task, params object[]
                args)
                {
                    var return_v = this_param.TraceInformational(traceEvent, operationCode, task, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 32842, 33084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 32753, 33096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 32753, 33096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void WriteMessage(string className, string methodName, Guid workflowId, string message, params string[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 33419, 34230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 33566, 34219);

                f_1034_33566_34218(PSEventId.Engine_Trace, PSOpcode.Method, PSTask.None, PSKeyword.UseAlwaysAnalytic, className, methodName, workflowId.ToString(), (DynAbs.Tracing.TraceSender.Conditional_F1(1034, 33887, 33905) || ((parameters == null && DynAbs.Tracing.TraceSender.Conditional_F2(1034, 33908, 33915)) || DynAbs.Tracing.TraceSender.Conditional_F3(1034, 33918, 33956))) ? message : f_1034_33918_33956(message, parameters), string.Empty, string.Empty, string.Empty, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 33419, 34230);

                string
                f_1034_33918_33956(string
                formatSpec, params string[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object[])o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 33918, 33956);
                    return return_v;
                }


                int
                f_1034_33566_34218(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticVerbose(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 33566, 34218);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 33419, 34230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 33419, 34230);
            }
        }

        public void WriteMessage(string className, string methodName, Guid workflowId, Job job, string message, params string[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 34593, 36932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 34749, 34788);

                StringBuilder
                sb = f_1034_34768_34787()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 34804, 36252) || true) && (job != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 34804, 36252);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 34897, 34967);

                        f_1034_34897_34966(sb, f_1034_34911_34965(f_1034_34929_34954(), f_1034_34956_34964(job)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 34989, 35094);

                        f_1034_34989_35093(sb, f_1034_35003_35092(f_1034_35021_35044(), f_1034_35046_35091(f_1034_35046_35052(job), f_1034_35062_35090())));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 35116, 35209);

                        f_1034_35116_35208(sb, f_1034_35130_35207(f_1034_35148_35179(), job.InstanceId.ToString()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 35231, 35309);

                        f_1034_35231_35308(sb, f_1034_35245_35307(f_1034_35263_35292(), f_1034_35294_35306(job)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 35331, 35427);

                        f_1034_35331_35426(sb, f_1034_35345_35425(f_1034_35363_35389(), f_1034_35391_35424(f_1034_35391_35413(f_1034_35391_35407(job)))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 35449, 35525);

                        f_1034_35449_35524(sb, f_1034_35463_35523(f_1034_35481_35509(), f_1034_35511_35522(job)));
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1034, 35562, 36080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 35797, 35815);

                        f_1034_35797_35814(this, e);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 35937, 35948);

                        f_1034_35937_35947(
                                            // If an exception is thrown, make sure the message is not partially formed.
                                            sb);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 35970, 36061);

                        f_1034_35970_36060(sb, f_1034_35984_36059(f_1034_36002_36027(), f_1034_36029_36058()));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1034, 35562, 36080);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 34804, 36252);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1034, 34804, 36252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 36146, 36237);

                    f_1034_36146_36236(sb, f_1034_36160_36235(f_1034_36178_36203(), f_1034_36205_36234()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1034, 34804, 36252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 36268, 36921);

                f_1034_36268_36920(PSEventId.Engine_Trace, PSOpcode.Method, PSTask.None, PSKeyword.UseAlwaysAnalytic, className, methodName, workflowId.ToString(), (DynAbs.Tracing.TraceSender.Conditional_F1(1034, 36589, 36607) || ((parameters == null && DynAbs.Tracing.TraceSender.Conditional_F2(1034, 36610, 36617)) || DynAbs.Tracing.TraceSender.Conditional_F3(1034, 36620, 36658))) ? message : f_1034_36620_36658(message, parameters), f_1034_36701_36714(sb), string.Empty, string.Empty, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 34593, 36932);

                System.Text.StringBuilder
                f_1034_34768_34787()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 34768, 34787);
                    return return_v;
                }


                string
                f_1034_34929_34954()
                {
                    var return_v = EtwLoggingStrings.JobName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 34929, 34954);
                    return return_v;
                }


                string
                f_1034_34956_34964(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 34956, 34964);
                    return return_v;
                }


                string
                f_1034_34911_34965(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 34911, 34965);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_34897_34966(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 34897, 34966);
                    return return_v;
                }


                string
                f_1034_35021_35044()
                {
                    var return_v = EtwLoggingStrings.JobId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35021, 35044);
                    return return_v;
                }


                int
                f_1034_35046_35052(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35046, 35052);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1034_35062_35090()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35062, 35090);
                    return return_v;
                }


                string
                f_1034_35046_35091(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35046, 35091);
                    return return_v;
                }


                string
                f_1034_35003_35092(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35003, 35092);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_34989_35093(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 34989, 35093);
                    return return_v;
                }


                string
                f_1034_35148_35179()
                {
                    var return_v = EtwLoggingStrings.JobInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35148, 35179);
                    return return_v;
                }


                string
                f_1034_35130_35207(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35130, 35207);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_35116_35208(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35116, 35208);
                    return return_v;
                }


                string
                f_1034_35263_35292()
                {
                    var return_v = EtwLoggingStrings.JobLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35263, 35292);
                    return return_v;
                }


                string
                f_1034_35294_35306(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35294, 35306);
                    return return_v;
                }


                string
                f_1034_35245_35307(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35245, 35307);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_35231_35308(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35231, 35308);
                    return return_v;
                }


                string
                f_1034_35363_35389()
                {
                    var return_v = EtwLoggingStrings.JobState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35363, 35389);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1034_35391_35407(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35391, 35407);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1034_35391_35413(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35391, 35413);
                    return return_v;
                }


                string
                f_1034_35391_35424(System.Management.Automation.JobState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35391, 35424);
                    return return_v;
                }


                string
                f_1034_35345_35425(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35345, 35425);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_35331_35426(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35331, 35426);
                    return return_v;
                }


                string
                f_1034_35481_35509()
                {
                    var return_v = EtwLoggingStrings.JobCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35481, 35509);
                    return return_v;
                }


                string
                f_1034_35511_35522(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 35511, 35522);
                    return return_v;
                }


                string
                f_1034_35463_35523(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35463, 35523);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_35449_35524(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35449, 35524);
                    return return_v;
                }


                bool
                f_1034_35797_35814(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.TraceException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35797, 35814);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_35937_35947(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35937, 35947);
                    return return_v;
                }


                string
                f_1034_36002_36027()
                {
                    var return_v = EtwLoggingStrings.JobName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 36002, 36027);
                    return return_v;
                }


                string
                f_1034_36029_36058()
                {
                    var return_v = EtwLoggingStrings.NullJobName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 36029, 36058);
                    return return_v;
                }


                string
                f_1034_35984_36059(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35984, 36059);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_35970_36060(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 35970, 36060);
                    return return_v;
                }


                string
                f_1034_36178_36203()
                {
                    var return_v = EtwLoggingStrings.JobName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 36178, 36203);
                    return return_v;
                }


                string
                f_1034_36205_36234()
                {
                    var return_v = EtwLoggingStrings.NullJobName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 36205, 36234);
                    return return_v;
                }


                string
                f_1034_36160_36235(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 36160, 36235);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1034_36146_36236(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 36146, 36236);
                    return return_v;
                }


                string
                f_1034_36620_36658(string
                formatSpec, params string[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object[])o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 36620, 36658);
                    return return_v;
                }


                string
                f_1034_36701_36714(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 36701, 36714);
                    return return_v;
                }


                int
                f_1034_36268_36920(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticVerbose(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 36268, 36920);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 34593, 36932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 34593, 36932);
            }
        }

        public void WriteScheduledJobStartEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 37093, 37523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 37179, 37512);

                f_1034_37179_37511(PSEventId.ScheduledJob_Start, PSOpcode.Method, PSTask.ScheduledJob, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 37093, 37523);

                int
                f_1034_37179_37511(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 37179, 37511);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 37093, 37523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 37093, 37523);
            }
        }

        public void WriteScheduledJobCompleteEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 37688, 38124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 37777, 38113);

                f_1034_37777_38112(PSEventId.ScheduledJob_Complete, PSOpcode.Method, PSTask.ScheduledJob, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 37688, 38124);

                int
                f_1034_37777_38112(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 37777, 38112);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 37688, 38124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 37688, 38124);
            }
        }

        public void WriteScheduledJobErrorEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 38285, 38688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 38371, 38677);

                f_1034_38371_38676(PSEventId.ScheduledJob_Error, PSOpcode.Exception, PSTask.ScheduledJob, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 38285, 38688);

                int
                f_1034_38371_38676(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 38371, 38676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 38285, 38688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 38285, 38688);
            }
        }

        public void WriteISEExecuteScriptEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 38848, 39275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 38933, 39264);

                f_1034_38933_39263(PSEventId.ISEExecuteScript, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 38848, 39275);

                int
                f_1034_38933_39263(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 38933, 39263);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 38848, 39275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 38848, 39275);
            }
        }

        public void WriteISEExecuteSelectionEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 39438, 39871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 39526, 39860);

                f_1034_39526_39859(PSEventId.ISEExecuteSelection, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 39438, 39871);

                int
                f_1034_39526_39859(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 39526, 39859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 39438, 39871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 39438, 39871);
            }
        }

        public void WriteISEStopCommandEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 40029, 40452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 40112, 40441);

                f_1034_40112_40440(PSEventId.ISEStopCommand, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 40029, 40452);

                int
                f_1034_40112_40440(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 40112, 40440);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 40029, 40452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 40029, 40452);
            }
        }

        public void WriteISEResumeDebuggerEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 40613, 41042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 40699, 41031);

                f_1034_40699_41030(PSEventId.ISEResumeDebugger, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 40613, 41042);

                int
                f_1034_40699_41030(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 40699, 41030);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 40613, 41042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 40613, 41042);
            }
        }

        public void WriteISEStopDebuggerEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 41201, 41626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 41285, 41615);

                f_1034_41285_41614(PSEventId.ISEStopDebugger, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 41201, 41626);

                int
                f_1034_41285_41614(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 41285, 41614);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 41201, 41626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 41201, 41626);
            }
        }

        public void WriteISEDebuggerStepIntoEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 41790, 42223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 41878, 42212);

                f_1034_41878_42211(PSEventId.ISEDebuggerStepInto, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 41790, 42223);

                int
                f_1034_41878_42211(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 41878, 42211);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 41790, 42223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 41790, 42223);
            }
        }

        public void WriteISEDebuggerStepOverEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 42387, 42820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 42475, 42809);

                f_1034_42475_42808(PSEventId.ISEDebuggerStepOver, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 42387, 42820);

                int
                f_1034_42475_42808(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 42475, 42808);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 42387, 42820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 42387, 42820);
            }
        }

        public void WriteISEDebuggerStepOutEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 42983, 43414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 43070, 43403);

                f_1034_43070_43402(PSEventId.ISEDebuggerStepOut, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 42983, 43414);

                int
                f_1034_43070_43402(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 43070, 43402);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 42983, 43414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 42983, 43414);
            }
        }

        public void WriteISEEnableAllBreakpointsEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 43582, 44023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 43674, 44012);

                f_1034_43674_44011(PSEventId.ISEEnableAllBreakpoints, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 43582, 44023);

                int
                f_1034_43674_44011(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 43674, 44011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 43582, 44023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 43582, 44023);
            }
        }

        public void WriteISEDisableAllBreakpointsEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 44192, 44635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 44285, 44624);

                f_1034_44285_44623(PSEventId.ISEDisableAllBreakpoints, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 44192, 44635);

                int
                f_1034_44285_44623(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 44285, 44623);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 44192, 44635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 44192, 44635);
            }
        }

        public void WriteISERemoveAllBreakpointsEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 44803, 45244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 44895, 45233);

                f_1034_44895_45232(PSEventId.ISERemoveAllBreakpoints, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 44803, 45244);

                int
                f_1034_44895_45232(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 44895, 45232);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 44803, 45244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 44803, 45244);
            }
        }

        public void WriteISESetBreakpointEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 45404, 45831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 45489, 45820);

                f_1034_45489_45819(PSEventId.ISESetBreakpoint, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 45404, 45831);

                int
                f_1034_45489_45819(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 45489, 45819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 45404, 45831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 45404, 45831);
            }
        }

        public void WriteISERemoveBreakpointEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 45994, 46427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 46082, 46416);

                f_1034_46082_46415(PSEventId.ISERemoveBreakpoint, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 45994, 46427);

                int
                f_1034_46082_46415(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 46082, 46415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 45994, 46427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 45994, 46427);
            }
        }

        public void WriteISEEnableBreakpointEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 46590, 47023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 46678, 47012);

                f_1034_46678_47011(PSEventId.ISEEnableBreakpoint, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 46590, 47023);

                int
                f_1034_46678_47011(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 46678, 47011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 46590, 47023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 46590, 47023);
            }
        }

        public void WriteISEDisableBreakpointEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 47187, 47622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 47276, 47611);

                f_1034_47276_47610(PSEventId.ISEDisableBreakpoint, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 47187, 47622);

                int
                f_1034_47276_47610(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 47276, 47610);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 47187, 47622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 47187, 47622);
            }
        }

        public void WriteISEHitBreakpointEvent(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 47782, 48209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 47867, 48198);

                f_1034_47867_48197(PSEventId.ISEHitBreakpoint, PSOpcode.Method, PSTask.ISEOperation, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 47782, 48209);

                int
                f_1034_47867_48197(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 47867, 48197);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 47782, 48209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 47782, 48209);
            }
        }

        public void WriteMessage(string className, string methodName, Guid workflowId, string activityName, Guid activityId, string message, params string[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 48628, 49452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 48813, 49441);

                f_1034_48813_49440(PSEventId.Engine_Trace, PSOpcode.Method, PSTask.None, PSKeyword.UseAlwaysAnalytic, className, methodName, workflowId.ToString(), (DynAbs.Tracing.TraceSender.Conditional_F1(1034, 49134, 49152) || ((parameters == null && DynAbs.Tracing.TraceSender.Conditional_F2(1034, 49155, 49162)) || DynAbs.Tracing.TraceSender.Conditional_F3(1034, 49165, 49203))) ? message : f_1034_49165_49203(message, parameters), string.Empty, activityName, activityId.ToString(), string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 48628, 49452);

                string
                f_1034_49165_49203(string
                formatSpec, params string[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object[])o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 49165, 49203);
                    return return_v;
                }


                int
                f_1034_48813_49440(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticVerbose(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 48813, 49440);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 48628, 49452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 48628, 49452);
            }
        }

        public bool TraceWSManConnectionInfo(WSManConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1034, 49595, 49715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 49692, 49704);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1034, 49595, 49715);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 49595, 49715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 49595, 49715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BaseChannelWriter DebugChannel { get; }

        public BaseChannelWriter AnalyticChannel { get; }

        public BaseChannelWriter OperationalChannel { get; }

        static PowerShellTraceSource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1034, 25272, 50210);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1034, 25272, 50210);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 25272, 50210);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1034, 25272, 50210);

        bool
        f_1034_25570_25584()
        {
            var return_v = IsEtwSupported;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 25570, 25584);
            return return_v;
        }


        System.Management.Automation.Tracing.PowerShellChannelWriter
        f_1034_25633_25801(System.Management.Automation.Tracing.PowerShellTraceChannel
        traceChannel, System.Management.Automation.Tracing.PowerShellTraceKeywords
        keywords)
        {
            var return_v = new System.Management.Automation.Tracing.PowerShellChannelWriter(traceChannel, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 25633, 25801);
            return return_v;
        }


        System.Management.Automation.Tracing.PowerShellChannelWriter
        f_1034_25838_26015(System.Management.Automation.Tracing.PowerShellTraceChannel
        traceChannel, System.Management.Automation.Tracing.PowerShellTraceKeywords
        keywords)
        {
            var return_v = new System.Management.Automation.Tracing.PowerShellChannelWriter(traceChannel, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 25838, 26015);
            return return_v;
        }


        System.Management.Automation.Tracing.PowerShellChannelWriter
        f_1034_26055_26240(System.Management.Automation.Tracing.PowerShellTraceChannel
        traceChannel, System.Management.Automation.Tracing.PowerShellTraceKeywords
        keywords)
        {
            var return_v = new System.Management.Automation.Tracing.PowerShellChannelWriter(traceChannel, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 26055, 26240);
            return return_v;
        }


        System.Management.Automation.Tracing.BaseChannelWriter
        f_1034_26402_26421()
        {
            var return_v = NullWriter.Instance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 26402, 26421);
            return return_v;
        }


        System.Management.Automation.Tracing.BaseChannelWriter
        f_1034_26458_26477()
        {
            var return_v = NullWriter.Instance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 26458, 26477);
            return return_v;
        }


        System.Management.Automation.Tracing.BaseChannelWriter
        f_1034_26517_26536()
        {
            var return_v = NullWriter.Instance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1034, 26517, 26536);
            return return_v;
        }

    }
    public static class PowerShellTraceSourceFactory
    {
        public static PowerShellTraceSource GetTraceSource()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1034, 50893, 51070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 50970, 51059);

                return f_1034_50977_51058(PowerShellTraceTask.None, PowerShellTraceKeywords.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1034, 50893, 51070);

                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1034_50977_51058(System.Management.Automation.Tracing.PowerShellTraceTask
                task, System.Management.Automation.Tracing.PowerShellTraceKeywords
                keywords)
                {
                    var return_v = new System.Management.Automation.Tracing.PowerShellTraceSource(task, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 50977, 51058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 50893, 51070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 50893, 51070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PowerShellTraceSource GetTraceSource(PowerShellTraceTask task)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1034, 51542, 51723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 51643, 51712);

                return f_1034_51650_51711(task, PowerShellTraceKeywords.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1034, 51542, 51723);

                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1034_51650_51711(System.Management.Automation.Tracing.PowerShellTraceTask
                task, System.Management.Automation.Tracing.PowerShellTraceKeywords
                keywords)
                {
                    var return_v = new System.Management.Automation.Tracing.PowerShellTraceSource(task, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 51650, 51711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 51542, 51723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 51542, 51723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PowerShellTraceSource GetTraceSource(PowerShellTraceTask task, PowerShellTraceKeywords keywords)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1034, 52195, 52390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1034, 52330, 52379);

                return f_1034_52337_52378(task, keywords);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1034, 52195, 52390);

                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1034_52337_52378(System.Management.Automation.Tracing.PowerShellTraceTask
                task, System.Management.Automation.Tracing.PowerShellTraceKeywords
                keywords)
                {
                    var return_v = new System.Management.Automation.Tracing.PowerShellTraceSource(task, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1034, 52337, 52378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1034, 52195, 52390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 52195, 52390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PowerShellTraceSourceFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1034, 50368, 52397);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1034, 50368, 52397);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1034, 50368, 52397);
        }

    }
    // pragma warning restore 16001,16003
}

