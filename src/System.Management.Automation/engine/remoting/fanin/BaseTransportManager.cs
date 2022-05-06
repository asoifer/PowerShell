// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

/*
 * Common file that contains interface definitions for generic server and client
 * transport managers.
 *
 */

using System.Management.Automation.Tracing;
using System.Text;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Management.Automation.Internal;
using System.Security.Principal;

// Don't expose the System.Management.Automation namespace here. This is transport layer
// and it shouldn't know anything about the engine.
using System.Management.Automation.Remoting.Client;
// TODO: this seems ugly...Remoting datatypes should be in remoting namespace
using System.Management.Automation.Runspaces.Internal;
using PSRemotingCryptoHelper = System.Management.Automation.Internal.PSRemotingCryptoHelper;
using RunspaceConnectionInfo = System.Management.Automation.Runspaces.RunspaceConnectionInfo;
using TypeTable = System.Management.Automation.Runspaces.TypeTable;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{

    internal enum TransportMethodEnum
    {
        CreateShellEx = 0,
        RunShellCommandEx = 1,
        SendShellInputEx = 2,
        ReceiveShellOutputEx = 3,
        CloseShellOperationEx = 4,
        CommandInputEx = 5,
        ReceiveCommandOutputEx = 6,
        DisconnectShellEx = 7,
        ReconnectShellEx = 8,
        ConnectShellEx = 9,
        ReconnectShellCommandEx = 10,
        ConnectShellCommandEx = 11,
        Unknown = 12,
    }
    internal class TransportErrorOccuredEventArgs : EventArgs
    {
        internal TransportErrorOccuredEventArgs(PSRemotingTransportException e,
                    TransportMethodEnum m)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 2177, 2377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 2474, 2535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 2654, 2716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 2309, 2323);

                Exception = e;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 2337, 2366);

                ReportingTransportMethod = m;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 2177, 2377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 2177, 2377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 2177, 2377);
            }
        }

        internal PSRemotingTransportException Exception { get; set; }

        internal TransportMethodEnum ReportingTransportMethod { get; }

        static TransportErrorOccuredEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 1841, 2723);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 1841, 2723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 1841, 2723);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 1841, 2723);
    }



    /// <summary>
    /// Robust Connection notifications.
    /// </summary>
    internal enum ConnectionStatus
    {
        NetworkFailureDetected = 1,
        ConnectionRetryAttempt = 2,
        ConnectionRetrySucceeded = 3,
        AutoDisconnectStarting = 4,
        AutoDisconnectSucceeded = 5,
        InternalErrorAbort = 6
    };
    internal class ConnectionStatusEventArgs : EventArgs
    {
        internal ConnectionStatusEventArgs(ConnectionStatus notification)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 3288, 3417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 3429, 3476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 3378, 3406);

                Notification = notification;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 3288, 3417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 3288, 3417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 3288, 3417);
            }
        }

        internal ConnectionStatus Notification { get; }

        static ConnectionStatusEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 3219, 3483);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 3219, 3483);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 3219, 3483);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 3219, 3483);
    }
    internal class CreateCompleteEventArgs : EventArgs
    {
        internal RunspaceConnectionInfo ConnectionInfo { get; }

        internal CreateCompleteEventArgs(
                    RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 3755, 3908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 3688, 3743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 3865, 3897);

                ConnectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 3755, 3908);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 3755, 3908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 3755, 3908);
            }
        }

        static CreateCompleteEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 3621, 3915);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 3621, 3915);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 3621, 3915);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 3621, 3915);
    }
    internal abstract class BaseTransportManager : IDisposable
    {
        [TraceSourceAttribute("Transport", "Traces BaseWSManTransportManager")]
        private static PSTraceSource s_baseTracer;

        internal const int
        ServerDefaultKeepAliveTimeoutMs = 4 * 60 * 1000
        ;

        internal const int
        ClientDefaultOperationTimeoutMs = 3 * 60 * 1000
        ;

        internal const int
        ClientCloseTimeoutMs = 60 * 1000
        ;

        internal const int
        UseServerDefaultIdleTimeout = -1
        ;

        internal const uint
        UseServerDefaultIdleTimeoutUInt = UInt32.MaxValue
        ;

        internal const int
        MinimumIdleTimeout = 60 * 1000
        ;

        internal const int
        DefaultFragmentSize = 32 << 10
        ;

        internal const int
        MaximumReceivedDataSize = 50 << 20
        ;

        internal const int
        MaximumReceivedObjectSize = 10 << 20
        ;

        internal const string
        MAX_RECEIVED_DATA_PER_COMMAND_MB = "PSMaximumReceivedDataSizePerCommandMB"
        ;

        internal const string
        MAX_RECEIVED_OBJECT_SIZE_MB = "PSMaximumReceivedObjectSizeMB"
        ;

        private ReceiveDataCollection.OnDataAvailableCallback _onDataAvailableCallback;

        // crypto helper used for encrypting/decrypting
        // secure string



        internal event EventHandler<TransportErrorOccuredEventArgs>
WSManTransportErrorOccured
;
        /// <summary>
        /// Event that is raised when a remote object is available. The event is raised
        /// from a WSMan transport thread. Since this thread can hold on to a HTTP
        /// connection, the event handler should complete processing as fast as possible.
        /// Importantly the event handler should not generate any call that results in a
        /// user request like host.ReadLine().
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs>
DataReceived
;

        /// <summary>
        /// Listen to this event to observe the PowerShell guid of the processed object.
        /// </summary>
        public event EventHandler
PowerShellGuidObserver
;

        protected BaseTransportManager(PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 7236, 7979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 6188, 6212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 8047, 8091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 14670, 14728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 14863, 14933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 7328, 7356);

                CryptoHelper = cryptoHelper;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 7666, 7729);

                Fragmentor = f_1633_7679_7728(DefaultFragmentSize, cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 7743, 7852);

                ReceivedDataCollection = f_1633_7768_7851(f_1633_7802_7812(), (this is BaseClientTransportManager));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 7866, 7968);

                _onDataAvailableCallback = new ReceiveDataCollection.OnDataAvailableCallback(OnDataAvailableCallback);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 7236, 7979);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 7236, 7979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 7236, 7979);
            }
        }

        internal Fragmentor Fragmentor { get; set; }

        internal TypeTable TypeTable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 8613, 8649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 8619, 8647);

                    return f_1633_8626_8646(f_1633_8626_8636());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 8613, 8649);

                    System.Management.Automation.Remoting.Fragmentor
                    f_1633_8626_8636()
                    {
                        var return_v = Fragmentor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 8626, 8636);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.TypeTable
                    f_1633_8626_8646(System.Management.Automation.Remoting.Fragmentor
                    this_param)
                    {
                        var return_v = this_param.TypeTable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 8626, 8646);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 8560, 8713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 8560, 8713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 8665, 8702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 8671, 8700);

                    f_1633_8671_8681().TypeTable = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 8665, 8702);

                    System.Management.Automation.Remoting.Fragmentor
                    f_1633_8671_8681()
                    {
                        var return_v = Fragmentor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 8671, 8681);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 8560, 8713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 8560, 8713);
                }
            }
        }

        internal virtual void ProcessRawData(byte[] data, string stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 9043, 9938);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 9168, 9223);

                    f_1633_9168_9222(this, data, stream, _onDataAvailableCallback);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1633, 9252, 9927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 9486, 9562);

                    f_1633_9486_9561(                // This will get executed on a thread pool thread..
                                                     // so we need to protect that thread, hence catching
                                                     // all exceptions
                                    s_baseTracer, "Exception processing data. {0}", f_1633_9543_9560(exception));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 9582, 9678);

                    PSRemotingTransportException
                    e = f_1633_9615_9677(f_1633_9648_9665(exception), exception)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 9696, 9840);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1633_9760_9839(e, TransportMethodEnum.ReceiveShellOutputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 9858, 9887);

                    f_1633_9858_9886(this, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 9905, 9912);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1633, 9252, 9927);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 9043, 9938);

                int
                f_1633_9168_9222(System.Management.Automation.Remoting.BaseTransportManager
                this_param, byte[]
                data, string
                stream, System.Management.Automation.Remoting.ReceiveDataCollection.OnDataAvailableCallback
                dataAvailableCallback)
                {
                    this_param.ProcessRawData(data, stream, dataAvailableCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 9168, 9222);
                    return 0;
                }


                string
                f_1633_9543_9560(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 9543, 9560);
                    return return_v;
                }


                int
                f_1633_9486_9561(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 9486, 9561);
                    return 0;
                }


                string
                f_1633_9648_9665(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 9648, 9665);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1633_9615_9677(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 9615, 9677);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1633_9760_9839(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 9760, 9839);
                    return return_v;
                }


                int
                f_1633_9858_9886(System.Management.Automation.Remoting.BaseTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 9858, 9886);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 9043, 9938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 9043, 9938);
            }
        }

        internal void ProcessRawData(byte[] data,
                    string stream,
                    ReceiveDataCollection.OnDataAvailableCallback dataAvailableCallback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 10584, 12255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 10760, 10813);

                f_1633_10760_10812(data != null, "Cannot process null data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 10829, 10904);

                f_1633_10829_10903(
                            s_baseTracer, "Processing incoming data for stream {0}.", stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 10920, 10947);

                bool
                shouldProcess = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 10963, 11020);

                DataPriorityType
                dataPriority = DataPriorityType.Default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 11034, 11558) || true) && (f_1633_11038_11125(stream, WSManNativeApi.WSMAN_STREAM_ID_STDIN, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1633, 11038, 11234) || f_1633_11146_11234(stream, WSManNativeApi.WSMAN_STREAM_ID_STDOUT, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 11034, 11558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 11268, 11289);

                    shouldProcess = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 11034, 11558);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 11034, 11558);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 11323, 11558) || true) && (f_1633_11327_11423(stream, WSManNativeApi.WSMAN_STREAM_ID_PROMPTRESPONSE, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 11323, 11558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 11457, 11504);

                        dataPriority = DataPriorityType.PromptResponse;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 11522, 11543);

                        shouldProcess = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 11323, 11558);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 11034, 11558);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 11574, 12120) || true) && (!shouldProcess)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 11574, 12120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 11694, 12027);

                    f_1633_11694_12026(false, f_1633_11733_12025(f_1633_11747_11775(), "Data should be from one of the streams : {0} or {1} or {2}", WSManNativeApi.WSMAN_STREAM_ID_STDIN, WSManNativeApi.WSMAN_STREAM_ID_STDOUT, WSManNativeApi.WSMAN_STREAM_ID_PROMPTRESPONSE));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 12045, 12105);

                    f_1633_12045_12104(s_baseTracer, "{0} is not a valid stream", stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 11574, 12120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 12163, 12244);

                f_1633_12163_12243(f_1633_12163_12185(), data, dataPriority, dataAvailableCallback);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 10584, 12255);

                int
                f_1633_10760_10812(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 10760, 10812);
                    return 0;
                }


                int
                f_1633_10829_10903(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 10829, 10903);
                    return 0;
                }


                bool
                f_1633_11038_11125(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 11038, 11125);
                    return return_v;
                }


                bool
                f_1633_11146_11234(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 11146, 11234);
                    return return_v;
                }


                bool
                f_1633_11327_11423(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 11327, 11423);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1633_11747_11775()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 11747, 11775);
                    return return_v;
                }


                string
                f_1633_11733_12025(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 11733, 12025);
                    return return_v;
                }


                int
                f_1633_11694_12026(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 11694, 12026);
                    return 0;
                }


                int
                f_1633_12045_12104(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 12045, 12104);
                    return 0;
                }


                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1633_12163_12185()
                {
                    var return_v = ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 12163, 12185);
                    return return_v;
                }


                int
                f_1633_12163_12243(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType, System.Management.Automation.Remoting.ReceiveDataCollection.OnDataAvailableCallback
                callback)
                {
                    this_param.ProcessRawData(data, priorityType, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 12163, 12243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 10584, 12255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 10584, 12255);
            }
        }

        internal void OnDataAvailableCallback(RemoteDataObject<PSObject> remoteObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 12546, 13702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 12694, 13386);

                f_1633_12694_13385(PSEventId.TransportReceivedObject, PSOpcode.Open, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, remoteObject.RunspacePoolId.ToString(), remoteObject.PowerShellId.ToString(), (f_1633_13184_13208(remoteObject)), (f_1633_13271_13292(remoteObject)), (f_1633_13355_13383(remoteObject)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 13472, 13550);

                f_1633_13472_13549(
                            // This might throw exceptions which the caller handles.
                            PowerShellGuidObserver, f_1633_13506_13531(remoteObject), EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 13566, 13636);

                RemoteDataEventArgs
                eventArgs = f_1633_13598_13635(remoteObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 13650, 13691);

                f_1633_13650_13690(DataReceived, this, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 12546, 13702);

                System.Management.Automation.RemotingDestination
                f_1633_13184_13208(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 13184, 13208);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1633_13271_13292(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 13271, 13292);
                    return return_v;
                }


                System.Management.Automation.RemotingTargetInterface
                f_1633_13355_13383(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.TargetInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 13355, 13383);
                    return return_v;
                }


                int
                f_1633_12694_13385(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 12694, 13385);
                    return 0;
                }


                System.Guid
                f_1633_13506_13531(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 13506, 13531);
                    return return_v;
                }


                int
                f_1633_13472_13549(System.EventHandler
                eventHandler, System.Guid
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 13472, 13549);
                    return 0;
                }


                System.Management.Automation.RemoteDataEventArgs
                f_1633_13598_13635(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                receivedData)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs(receivedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 13598, 13635);
                    return return_v;
                }


                int
                f_1633_13650_13690(System.EventHandler<System.Management.Automation.RemoteDataEventArgs>
                eventHandler, System.Management.Automation.Remoting.BaseTransportManager
                sender, System.Management.Automation.RemoteDataEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 13650, 13690);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 12546, 13702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 12546, 13702);
            }
        }

        public void MigrateDataReadyEventHandlers(BaseTransportManager transportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 13899, 14201);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 14004, 14190);
                    foreach (Delegate handler in f_1633_14033_14082_I(f_1633_14033_14082(transportManager.DataReceived)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 14004, 14190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 14116, 14175);

                        DataReceived += (EventHandler<RemoteDataEventArgs>)handler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 14004, 14190);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1633, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1633, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 13899, 14201);

                System.Delegate[]
                f_1633_14033_14082(System.EventHandler<System.Management.Automation.RemoteDataEventArgs>
                this_param)
                {
                    var return_v = this_param.GetInvocationList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 14033, 14082);
                    return return_v;
                }


                System.Delegate[]
                f_1633_14033_14082_I(System.Delegate[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 14033, 14082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 13899, 14201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 13899, 14201);
            }
        }

        internal virtual void RaiseErrorHandler(TransportErrorOccuredEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 14345, 14517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 14451, 14506);

                f_1633_14451_14505(WSManTransportErrorOccured, this, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 14345, 14517);

                int
                f_1633_14451_14505(System.EventHandler<System.Management.Automation.Remoting.TransportErrorOccuredEventArgs>
                eventHandler, System.Management.Automation.Remoting.BaseTransportManager
                sender, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Remoting.TransportErrorOccuredEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 14451, 14505);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 14345, 14517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 14345, 14517);
            }
        }

        internal PSRemotingCryptoHelper CryptoHelper { get; set; }

        internal PriorityReceiveDataCollection ReceivedDataCollection { get; }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 15118, 15360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 15164, 15178);

                f_1633_15164_15177(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 15316, 15349);

                f_1633_15316_15348(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 15118, 15360);

                int
                f_1633_15164_15177(System.Management.Automation.Remoting.BaseTransportManager
                this_param, bool
                isDisposing)
                {
                    this_param.Dispose(isDisposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 15164, 15177);
                    return 0;
                }


                int
                f_1633_15316_15348(System.Management.Automation.Remoting.BaseTransportManager
                obj)
                {
                    System.GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 15316, 15348);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 15118, 15360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 15118, 15360);
            }
        }

        internal virtual void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 15372, 15552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 15444, 15541) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 15444, 15541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 15493, 15526);

                    f_1633_15493_15525(f_1633_15493_15515());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 15444, 15541);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 15372, 15552);

                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1633_15493_15515()
                {
                    var return_v = ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 15493, 15515);
                    return return_v;
                }


                int
                f_1633_15493_15525(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 15493, 15525);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 15372, 15552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 15372, 15552);
            }
        }

        static BaseTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 4083, 15581);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 4294, 4381);
            s_baseTracer = f_1633_4309_4381("Transport", "Traces BaseWSManTransportManager");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 4751, 4798);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 4856, 4903);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5051, 5083);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5208, 5240);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5271, 5320);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5413, 5443);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5475, 5505);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5601, 5635);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5673, 5709);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5812, 5886);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 5919, 5980);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 4083, 15581);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 4083, 15581);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 4083, 15581);

        static System.Management.Automation.PSTraceSource
        f_1633_4309_4381(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 4309, 4381);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1633_7679_7728(int
        fragmentSize, System.Management.Automation.Internal.PSRemotingCryptoHelper
        cryptoHelper)
        {
            var return_v = new System.Management.Automation.Remoting.Fragmentor(fragmentSize, cryptoHelper);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 7679, 7728);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1633_7802_7812()
        {
            var return_v = Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 7802, 7812);
            return return_v;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1633_7768_7851(System.Management.Automation.Remoting.Fragmentor
        defragmentor, bool
        createdByClientTM)
        {
            var return_v = new System.Management.Automation.Remoting.PriorityReceiveDataCollection(defragmentor, createdByClientTM);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 7768, 7851);
            return return_v;
        }

    }
}

namespace System.Management.Automation.Remoting.Client
{
    internal abstract class BaseClientTransportManager : BaseTransportManager, IDisposable
    {
        [TraceSourceAttribute("ClientTransport", "Traces ClientTransportManager")]
        protected static PSTraceSource tracer;

        protected bool isClosed;

        protected object syncObject;

        protected PrioritySendDataCollection dataToBeSent;

        private Queue<CallbackNotificationInformation> _callbackNotificationQueue;

        private ReceiveDataCollection.OnDataAvailableCallback _onDataAvailableCallback;

        private bool _isServicingCallbacks;

        private bool _suspendQueueServicing;

        private bool _isDebuggerSuspend;

        protected bool receiveDataInitiated;

        protected BaseClientTransportManager(Guid runspaceId, PSRemotingCryptoHelper cryptoHelper)
        : base(f_1633_16936_16948_C(cryptoHelper))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 16825, 17286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16049, 16057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16085, 16110);
                this.syncObject = f_1633_16098_16110();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16158, 16170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16331, 16357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16422, 16446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16470, 16491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16515, 16537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16561, 16579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16738, 16758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 16974, 17010);

                RunspacePoolInstanceId = runspaceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 17024, 17072);

                dataToBeSent = f_1633_17039_17071();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 17086, 17187);

                _onDataAvailableCallback = new ReceiveDataCollection.OnDataAvailableCallback(OnDataAvailableHandler);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 17201, 17275);

                _callbackNotificationQueue = f_1633_17230_17274();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 16825, 17286);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 16825, 17286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 16825, 17286);
            }
        }


        /// <summary>
        /// Event that is raised when a create operation on transport has been successfully completed
        /// The event is raised
        /// from a WSMan transport thread. Since this thread can hold on to a HTTP
        /// connection, the event handler should complete processing as fast as possible.
        /// Importantly the event handler should not generate any call that results in a
        /// user request like host.ReadLine().
        ///
        /// Errors (occurred during connection attempt) are reported through WSManTransportErrorOccured
        /// event.
        /// </summary>
        internal event EventHandler<CreateCompleteEventArgs>
CreateCompleted
;
        /// <summary>
        /// Event that is raised when a remote connection is successfully closed. The event is raised
        /// from a WSMan transport thread. Since this thread can hold on to a HTTP
        /// connection, the event handler should complete processing as fast as possible.
        /// Importantly the event handler should not generate any call that results in a
        /// user request like host.ReadLine().
        ///
        /// Errors (occurred during connection attempt) are reported through WSManTransportErrorOccured
        /// event.
        /// </summary>
        /// <remarks>
        /// The eventhandler should make sure not to throw any exceptions.
        /// </remarks>
        internal event EventHandler<EventArgs>
CloseCompleted
;

        /// <summary>
        /// Indicated successful completion of a connect operation on transport
        ///
        /// Errors are reported through WSManTransportErrorOccured
        /// event.
        /// </summary>
        internal event EventHandler<EventArgs>
ConnectCompleted
;

        /// <summary>
        /// Indicated successful completion of a disconnect operation on transport
        ///
        /// Errors are reported through WSManTransportErrorOccured
        /// event.
        /// </summary>
        internal event EventHandler<EventArgs>
DisconnectCompleted
;

        /// <summary>
        /// Indicated successful completion of a reconnect operation on transport
        ///
        /// Errors are reported through WSManTransportErrorOccured
        /// event.
        /// </summary>
        internal event EventHandler<EventArgs>
ReconnectCompleted
;

        /// <summary>
        /// Indicates that the transport/command is ready for a disconnect operation.
        ///
        /// Errors are reported through WSManTransportErrorOccured event.
        /// </summary>
        internal event EventHandler<EventArgs>
ReadyForDisconnect
;

        /// <summary>
        /// Event to pass Robust Connection notifications to client.
        /// </summary>
        internal event EventHandler<ConnectionStatusEventArgs>
RobustConnectionNotification
;

        /// <summary>
        /// Indicates successful processing of a delay stream request on a receive operation
        ///
        /// this event is useful when PS wants to invoke a pipeline in disconnected mode.
        /// </summary>
        internal event EventHandler<EventArgs>
DelayStreamRequestProcessed
;

        internal PrioritySendDataCollection DataToBeSentCollection
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 20878, 20906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 20884, 20904);

                    return dataToBeSent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 20878, 20906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 20795, 20917);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 20795, 20917);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Guid RunspacePoolInstanceId { get; }

        internal void RaiseCreateCompleted(CreateCompleteEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 21173, 21322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 21267, 21311);

                f_1633_21267_21310(CreateCompleted, this, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 21173, 21322);

                int
                f_1633_21267_21310(System.EventHandler<System.Management.Automation.Remoting.CreateCompleteEventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.Management.Automation.Remoting.CreateCompleteEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Remoting.CreateCompleteEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 21267, 21310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 21173, 21322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 21173, 21322);
            }
        }

        internal void RaiseConnectCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 21334, 21458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 21396, 21447);

                f_1633_21396_21446(ConnectCompleted, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 21334, 21458);

                int
                f_1633_21396_21446(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 21396, 21446);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 21334, 21458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 21334, 21458);
            }
        }

        internal void RaiseDisconnectCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 21470, 21600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 21535, 21589);

                f_1633_21535_21588(DisconnectCompleted, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 21470, 21600);

                int
                f_1633_21535_21588(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 21535, 21588);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 21470, 21600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 21470, 21600);
            }
        }

        internal void RaiseReconnectCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 21612, 21740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 21676, 21729);

                f_1633_21676_21728(ReconnectCompleted, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 21612, 21740);

                int
                f_1633_21676_21728(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 21676, 21728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 21612, 21740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 21612, 21740);
            }
        }

        internal void RaiseCloseCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 21847, 21967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 21907, 21956);

                f_1633_21907_21955(CloseCompleted, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 21847, 21967);

                int
                f_1633_21907_21955(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 21907, 21955);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 21847, 21967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 21847, 21967);
            }
        }

        internal void RaiseReadyForDisconnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 22075, 22203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 22139, 22192);

                f_1633_22139_22191(ReadyForDisconnect, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 22075, 22203);

                int
                f_1633_22139_22191(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 22139, 22191);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 22075, 22203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 22075, 22203);
            }
        }

        internal void QueueRobustConnectionNotification(int flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 22402, 24248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 22485, 22523);

                ConnectionStatusEventArgs
                args = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 22537, 24023);

                switch (flags)
                {

                    case (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_NETWORK_FAILURE_DETECTED:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 22537, 24023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 22695, 22773);

                        args = f_1633_22702_22772(ConnectionStatus.NetworkFailureDetected);
                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 22795, 22801);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 22537, 24023);

                    case (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RETRYING_AFTER_NETWORK_FAILURE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 22537, 24023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 22938, 23016);

                        args = f_1633_22945_23015(ConnectionStatus.ConnectionRetryAttempt);
                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 23038, 23044);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 22537, 24023);

                    case (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RECONNECTED_AFTER_NETWORK_FAILURE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 22537, 24023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 23184, 23264);

                        args = f_1633_23191_23263(ConnectionStatus.ConnectionRetrySucceeded);
                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 23286, 23292);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 22537, 24023);

                    case (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_SHELL_AUTODISCONNECTING:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 22537, 24023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 23422, 23500);

                        args = f_1633_23429_23499(ConnectionStatus.AutoDisconnectStarting);
                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 23522, 23528);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 22537, 24023);

                    case (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_SHELL_AUTODISCONNECTED:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 22537, 24023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 23657, 23736);

                        args = f_1633_23664_23735(ConnectionStatus.AutoDisconnectSucceeded);
                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 23758, 23764);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 22537, 24023);

                    case (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RETRY_ABORTED_DUE_TO_INTERNAL_ERROR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 22537, 24023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 23906, 23980);

                        args = f_1633_23913_23979(ConnectionStatus.InternalErrorAbort);
                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 24002, 24008);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 22537, 24023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 24187, 24237);

                f_1633_24187_24236(this, null, null, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 22402, 24248);

                System.Management.Automation.Remoting.ConnectionStatusEventArgs
                f_1633_22702_22772(System.Management.Automation.Remoting.ConnectionStatus
                notification)
                {
                    var return_v = new System.Management.Automation.Remoting.ConnectionStatusEventArgs(notification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 22702, 22772);
                    return return_v;
                }


                System.Management.Automation.Remoting.ConnectionStatusEventArgs
                f_1633_22945_23015(System.Management.Automation.Remoting.ConnectionStatus
                notification)
                {
                    var return_v = new System.Management.Automation.Remoting.ConnectionStatusEventArgs(notification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 22945, 23015);
                    return return_v;
                }


                System.Management.Automation.Remoting.ConnectionStatusEventArgs
                f_1633_23191_23263(System.Management.Automation.Remoting.ConnectionStatus
                notification)
                {
                    var return_v = new System.Management.Automation.Remoting.ConnectionStatusEventArgs(notification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 23191, 23263);
                    return return_v;
                }


                System.Management.Automation.Remoting.ConnectionStatusEventArgs
                f_1633_23429_23499(System.Management.Automation.Remoting.ConnectionStatus
                notification)
                {
                    var return_v = new System.Management.Automation.Remoting.ConnectionStatusEventArgs(notification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 23429, 23499);
                    return return_v;
                }


                System.Management.Automation.Remoting.ConnectionStatusEventArgs
                f_1633_23664_23735(System.Management.Automation.Remoting.ConnectionStatus
                notification)
                {
                    var return_v = new System.Management.Automation.Remoting.ConnectionStatusEventArgs(notification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 23664, 23735);
                    return return_v;
                }


                System.Management.Automation.Remoting.ConnectionStatusEventArgs
                f_1633_23913_23979(System.Management.Automation.Remoting.ConnectionStatus
                notification)
                {
                    var return_v = new System.Management.Automation.Remoting.ConnectionStatusEventArgs(notification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 23913, 23979);
                    return return_v;
                }


                int
                f_1633_24187_24236(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, System.Management.Automation.Remoting.ConnectionStatusEventArgs
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, (object)privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 24187, 24236);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 22402, 24248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 22402, 24248);
            }
        }

        internal void RaiseRobustConnectionNotification(ConnectionStatusEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 24435, 24602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 24539, 24591);

                f_1633_24539_24590(RobustConnectionNotification, this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 24435, 24602);

                int
                f_1633_24539_24590(System.EventHandler<System.Management.Automation.Remoting.ConnectionStatusEventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.Management.Automation.Remoting.ConnectionStatusEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Remoting.ConnectionStatusEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 24539, 24590);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 24435, 24602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 24435, 24602);
            }
        }

        internal void RaiseDelayStreamProcessedEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 24614, 24758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 24685, 24747);

                f_1633_24685_24746(DelayStreamRequestProcessed, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 24614, 24758);

                int
                f_1633_24685_24746(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 24685, 24746);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 24614, 24758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 24614, 24758);
            }
        }

        internal override void ProcessRawData(byte[] data, string stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 24843, 26492);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 24933, 25001) || true) && (isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 24933, 25001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 24979, 24986);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 24933, 25001);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 25053, 25113);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ProcessRawData(data, stream, _onDataAvailableCallback), 1633, 25053, 25112);
                }
                catch (PSRemotingTransportException pte)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1633, 25142, 25684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 25325, 25389);

                    f_1633_25325_25388(                // PSRemotingTransportException need not be wrapped in another PSRemotingTransportException.
                                    tracer, "Exception processing data. {0}", f_1633_25376_25387(pte));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 25407, 25569);

                    TransportErrorOccuredEventArgs
                    eventargs = f_1633_25450_25568(pte, TransportMethodEnum.ReceiveShellOutputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 25587, 25642);

                    f_1633_25587_25641(this, null, eventargs, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 25662, 25669);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1633, 25142, 25684);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1633, 25698, 26481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 26015, 26085);

                    f_1633_26015_26084(                // Enqueue an Exception to process in a thread-pool thread. Processing
                                                       // Exception in a thread pool thread is important as calling
                                                       // WSManCloseShell/Command from a Receive callback results in a deadlock.
                                    tracer, "Exception processing data. {0}", f_1633_26066_26083(exception));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 26105, 26190);

                    PSRemotingTransportException
                    e = f_1633_26138_26189(f_1633_26171_26188(exception))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 26208, 26368);

                    TransportErrorOccuredEventArgs
                    eventargs = f_1633_26251_26367(e, TransportMethodEnum.ReceiveShellOutputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 26386, 26441);

                    f_1633_26386_26440(this, null, eventargs, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 26459, 26466);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1633, 25698, 26481);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 24843, 26492);

                string
                f_1633_25376_25387(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 25376, 25387);
                    return return_v;
                }


                int
                f_1633_25325_25388(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 25325, 25388);
                    return 0;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1633_25450_25568(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 25450, 25568);
                    return return_v;
                }


                int
                f_1633_25587_25641(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, object
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 25587, 25641);
                    return 0;
                }


                string
                f_1633_26066_26083(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 26066, 26083);
                    return return_v;
                }


                int
                f_1633_26015_26084(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 26015, 26084);
                    return 0;
                }


                string
                f_1633_26171_26188(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 26171, 26188);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1633_26138_26189(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 26138, 26189);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1633_26251_26367(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 26251, 26367);
                    return return_v;
                }


                int
                f_1633_26386_26440(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, object
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 26386, 26440);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 24843, 26492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 24843, 26492);
            }
        }

        private void OnDataAvailableHandler(RemoteDataObject<PSObject> remoteObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 26504, 26674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 26605, 26663);

                f_1633_26605_26662(this, remoteObject, null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 26504, 26674);

                int
                f_1633_26605_26662(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, object
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 26605, 26662);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 26504, 26674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 26504, 26674);
            }
        }

        internal void EnqueueAndStartProcessingThread(RemoteDataObject<PSObject> remoteObject,
                    TransportErrorOccuredEventArgs transportErrorArgs,
                    object privateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 27556, 30290);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 27764, 27832) || true) && (isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 27764, 27832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 27810, 27817);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 27764, 27832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 27854, 27880);

                lock (_callbackNotificationQueue)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 27914, 28989) || true) && ((remoteObject != null) || (DynAbs.Tracing.TraceSender.Expression_False(1633, 27918, 27972) || (transportErrorArgs != null)) || (DynAbs.Tracing.TraceSender.Expression_False(1633, 27918, 27997) || (privateData != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 27914, 28989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 28039, 28124);

                        CallbackNotificationInformation
                        rcvdDataInfo = f_1633_28086_28123()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 28146, 28187);

                        rcvdDataInfo.remoteObject = remoteObject;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 28209, 28258);

                        rcvdDataInfo.transportError = transportErrorArgs;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 28280, 28319);

                        rcvdDataInfo.privateData = privateData;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 28343, 28970) || true) && (remoteObject != null && (DynAbs.Tracing.TraceSender.Expression_True(1633, 28347, 28651) && (f_1633_28372_28393(remoteObject) == RemotingDataType.PublicKey || (DynAbs.Tracing.TraceSender.Expression_False(1633, 28372, 28538) || f_1633_28477_28498(remoteObject) == RemotingDataType.EncryptedSessionKey) || (DynAbs.Tracing.TraceSender.Expression_False(1633, 28372, 28650) || f_1633_28592_28613(remoteObject) == RemotingDataType.PublicKeyRequest))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 28343, 28970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 28701, 28800);

                            f_1633_28701_28799(f_1633_28701_28753(f_1633_28701_28721(f_1633_28701_28713())), remoteObject);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 28343, 28970);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 28343, 28970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 28898, 28947);

                            f_1633_28898_28946(_callbackNotificationQueue, rcvdDataInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 28343, 28970);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 27914, 28989);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29009, 29283) || true) && (_suspendQueueServicing && (DynAbs.Tracing.TraceSender.Expression_True(1633, 29013, 29057) && _isDebuggerSuspend))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 29009, 29283);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29196, 29264);

                        _suspendQueueServicing = !f_1633_29222_29263(this, remoteObject);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 29009, 29283);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29303, 29561) || true) && (_isServicingCallbacks || (DynAbs.Tracing.TraceSender.Expression_False(1633, 29307, 29354) || _suspendQueueServicing))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 29303, 29561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29535, 29542);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 29303, 29561);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29581, 30264) || true) && (f_1633_29585_29617(_callbackNotificationQueue) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 29581, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29663, 29692);

                        _isServicingCallbacks = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29800, 29838);

                        WindowsIdentity
                        identityToImpersonate
                        = default(WindowsIdentity);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29860, 29927);

                        f_1633_29860_29926(out identityToImpersonate);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 29951, 30136);

                        f_1633_29951_30135(identityToImpersonate, new WaitCallback(ServicePendingCallbacks), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 29581, 30264);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 27556, 30290);

                System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation
                f_1633_28086_28123()
                {
                    var return_v = new System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 28086, 28123);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1633_28372_28393(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 28372, 28393);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1633_28477_28498(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 28477, 28498);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1633_28592_28613(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 28592, 28613);
                    return return_v;
                }


                System.Management.Automation.Internal.PSRemotingCryptoHelper
                f_1633_28701_28713()
                {
                    var return_v = CryptoHelper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 28701, 28713);
                    return return_v;
                }


                System.Management.Automation.RemoteSession
                f_1633_28701_28721(System.Management.Automation.Internal.PSRemotingCryptoHelper
                this_param)
                {
                    var return_v = this_param.Session;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 28701, 28721);
                    return return_v;
                }


                System.Management.Automation.Remoting.BaseSessionDataStructureHandler
                f_1633_28701_28753(System.Management.Automation.RemoteSession
                this_param)
                {
                    var return_v = this_param.BaseSessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 28701, 28753);
                    return return_v;
                }


                int
                f_1633_28701_28799(System.Management.Automation.Remoting.BaseSessionDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                receivedData)
                {
                    this_param.RaiseKeyExchangeMessageReceived(receivedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 28701, 28799);
                    return 0;
                }


                int
                f_1633_28898_28946(System.Collections.Generic.Queue<System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation>
                this_param, System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 28898, 28946);
                    return 0;
                }


                bool
                f_1633_29222_29263(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject)
                {
                    var return_v = this_param.CheckForInteractiveHostCall(remoteObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 29222, 29263);
                    return return_v;
                }


                int
                f_1633_29585_29617(System.Collections.Generic.Queue<System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 29585, 29617);
                    return return_v;
                }


                bool
                f_1633_29860_29926(out System.Security.Principal.WindowsIdentity
                impersonatedIdentity)
                {
                    var return_v = Utils.TryGetWindowsImpersonatedIdentity(out impersonatedIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 29860, 29926);
                    return return_v;
                }


                int
                f_1633_29951_30135(System.Security.Principal.WindowsIdentity
                identityToImpersonate, System.Threading.WaitCallback
                threadProc, object
                state)
                {
                    Utils.QueueWorkItemWithImpersonation(identityToImpersonate, threadProc, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 29951, 30135);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 27556, 30290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 27556, 30290);
            }
        }

        private bool CheckForInteractiveHostCall(RemoteDataObject<PSObject> remoteObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 30612, 32291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 30718, 30751);

                bool
                interactiveHostCall = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 30767, 32237) || true) && ((remoteObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1633, 30771, 30891) && (f_1633_30815_30836(remoteObject) == RemotingDataType.RemoteHostCallUsingPowerShellHost)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 30767, 32237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 30925, 30957);

                    RemoteHostMethodId
                    methodId = 0
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 31021, 31136);

                        methodId = f_1633_31032_31135(f_1633_31085_31102(remoteObject), RemoteDataNameStrings.MethodId);
                    }
                    catch (PSArgumentNullException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1633, 31173, 31208);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1633, 31173, 31208);
                    }
                    catch (PSRemotingDataStructureException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1633, 31226, 31270);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1633, 31226, 31270);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 31402, 31556);

                    f_1633_31402_31555(methodId <= RemoteHostMethodId.PromptForChoiceMultipleSelection, "A new remote host method Id was added.  Update switch statement as needed.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 31576, 32222);

                    switch (methodId)
                    {

                        case RemoteHostMethodId.Prompt:
                        case RemoteHostMethodId.PromptForChoice:
                        case RemoteHostMethodId.PromptForChoiceMultipleSelection:
                        case RemoteHostMethodId.PromptForCredential1:
                        case RemoteHostMethodId.PromptForCredential2:
                        case RemoteHostMethodId.ReadKey:
                        case RemoteHostMethodId.ReadLine:
                        case RemoteHostMethodId.ReadLineAsSecureString:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 31576, 32222);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 32144, 32171);

                            interactiveHostCall = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1633, 32197, 32203);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 31576, 32222);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 30767, 32237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 32253, 32280);

                return interactiveHostCall;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 30612, 32291);

                System.Management.Automation.RemotingDataType
                f_1633_30815_30836(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 30815, 30836);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1633_31085_31102(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 31085, 31102);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1633_31032_31135(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<RemoteHostMethodId>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 31032, 31135);
                    return return_v;
                }


                int
                f_1633_31402_31555(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 31402, 31555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 30612, 32291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 30612, 32291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ServicePendingCallbacks(object objectToProcess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 32303, 35531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 32389, 32452);

                f_1633_32389_32451(tracer, "ServicePendingCallbacks thread is starting");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 32466, 32728);

                f_1633_32466_32727(f_1633_32509_32531(), PSEventId.OperationalTransferEventRunspacePool, PSEventId.AnalyticTransferEventRunspacePool, PSKeyword.Transport, PSTask.None);

                try
                {
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 32780, 34402);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 32890, 32982) || true) && (isClosed)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 32890, 32982);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 32952, 32959);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 32890, 32982);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 33006, 33058);

                                CallbackNotificationInformation
                                rcvdDataInfo = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 33086, 33112);
                                lock (_callbackNotificationQueue)
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 33295, 33453) || true) && (f_1633_33299_33331(_callbackNotificationQueue) <= 0 || (DynAbs.Tracing.TraceSender.Expression_False(1633, 33299, 33362) || _suspendQueueServicing))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 33295, 33453);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 33420, 33426);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 33295, 33453);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 33481, 33533);

                                    rcvdDataInfo = f_1633_33496_33532(_callbackNotificationQueue);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 33619, 34369) || true) && (rcvdDataInfo != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 33619, 34369);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 33772, 34346) || true) && (rcvdDataInfo.transportError != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 33772, 34346);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 33869, 33916);

                                        f_1633_33869_33915(this, rcvdDataInfo.transportError);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1633, 33946, 33952);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 33772, 34346);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 33772, 34346);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 34010, 34346) || true) && (rcvdDataInfo.privateData != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 34010, 34346);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 34104, 34149);

                                            f_1633_34104_34148(this, rcvdDataInfo.privateData);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 34010, 34346);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 34010, 34346);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 34263, 34319);

                                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.OnDataAvailableCallback(rcvdDataInfo.remoteObject), 1633, 34263, 34318);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 34010, 34346);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 33772, 34346);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 33619, 34369);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 32780, 34402);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 32780, 34402) || true) && (true)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1633, 32780, 34402);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1633, 32780, 34402);
                        }
                    }
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1633, 34431, 35100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 34665, 34735);

                    f_1633_34665_34734(                // This will get executed on a thread pool thread..
                                                       // so we need to protect that thread, hence catching
                                                       // all exceptions
                                    tracer, "Exception processing data. {0}", f_1633_34716_34733(exception));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 34755, 34851);

                    PSRemotingTransportException
                    e = f_1633_34788_34850(f_1633_34821_34838(exception), exception)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 34869, 35013);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1633_34933_35012(e, TransportMethodEnum.ReceiveShellOutputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35031, 35060);

                    f_1633_35031_35059(this, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35078, 35085);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1633, 34431, 35100);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1633, 35114, 35520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35160, 35186);
                    lock (_callbackNotificationQueue)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35228, 35290);

                        f_1633_35228_35289(tracer, "ServicePendingCallbacks thread is exiting");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35312, 35342);

                        _isServicingCallbacks = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35436, 35486);

                        f_1633_35436_35485(this, null, null, null);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1633, 35114, 35520);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 32303, 35531);

                int
                f_1633_32389_32451(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 32389, 32451);
                    return 0;
                }


                System.Guid
                f_1633_32509_32531()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 32509, 32531);
                    return return_v;
                }


                int
                f_1633_32466_32727(System.Guid
                newActivityId, System.Management.Automation.Internal.PSEventId
                eventForOperationalChannel, System.Management.Automation.Internal.PSEventId
                eventForAnalyticChannel, System.Management.Automation.Internal.PSKeyword
                keyword, System.Management.Automation.Internal.PSTask
                task)
                {
                    PSEtwLog.ReplaceActivityIdForCurrentThread(newActivityId, eventForOperationalChannel, eventForAnalyticChannel, keyword, task);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 32466, 32727);
                    return 0;
                }


                int
                f_1633_33299_33331(System.Collections.Generic.Queue<System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 33299, 33331);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation
                f_1633_33496_33532(System.Collections.Generic.Queue<System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 33496, 33532);
                    return return_v;
                }


                int
                f_1633_33869_33915(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 33869, 33915);
                    return 0;
                }


                int
                f_1633_34104_34148(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, object
                privateData)
                {
                    this_param.ProcessPrivateData(privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 34104, 34148);
                    return 0;
                }


                string
                f_1633_34716_34733(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 34716, 34733);
                    return return_v;
                }


                int
                f_1633_34665_34734(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 34665, 34734);
                    return 0;
                }


                string
                f_1633_34821_34838(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 34821, 34838);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1633_34788_34850(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 34788, 34850);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1633_34933_35012(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 34933, 35012);
                    return return_v;
                }


                int
                f_1633_35031_35059(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 35031, 35059);
                    return 0;
                }


                int
                f_1633_35228_35289(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 35228, 35289);
                    return 0;
                }


                int
                f_1633_35436_35485(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, object
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 35436, 35485);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 32303, 35531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 32303, 35531);
            }
        }

        internal bool IsServicing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 35593, 35766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35635, 35661);
                    lock (_callbackNotificationQueue)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35703, 35732);

                        return _isServicingCallbacks;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 35593, 35766);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 35543, 35777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 35543, 35777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SuspendQueue(bool debuggerSuspend = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 35789, 36047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35876, 35902);
                lock (_callbackNotificationQueue)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35936, 35973);

                    _isDebuggerSuspend = debuggerSuspend;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 35991, 36021);

                    _suspendQueueServicing = true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 35789, 36047);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 35789, 36047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 35789, 36047);
            }
        }

        internal void ResumeQueue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 36059, 36494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 36117, 36143);
                lock (_callbackNotificationQueue)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 36177, 36204);

                    _isDebuggerSuspend = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 36224, 36468) || true) && (_suspendQueueServicing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 36224, 36468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 36292, 36323);

                        _suspendQueueServicing = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 36399, 36449);

                        f_1633_36399_36448(this, null, null, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 36224, 36468);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 36059, 36494);

                int
                f_1633_36399_36448(System.Management.Automation.Remoting.Client.BaseClientTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, object
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 36399, 36448);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 36059, 36494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 36059, 36494);
            }
        }

        internal virtual void ProcessPrivateData(object privateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 36895, 36977);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 36895, 36977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 36895, 36977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 36895, 36977);
            }
        }
        internal class CallbackNotificationInformation
        {
            internal RemoteDataObject<PSObject> remoteObject;

            internal TransportErrorOccuredEventArgs transportError;

            internal object privateData;

            public CallbackNotificationInformation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 36989, 37537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 37238, 37250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 37305, 37319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 37514, 37525);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 36989, 37537);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 36989, 37537);
            }


            static CallbackNotificationInformation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 36989, 37537);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 36989, 37537);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 36989, 37537);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 36989, 37537);
        }

        internal abstract void CreateAsync();

        internal abstract void ConnectAsync();

        internal virtual void CloseAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 37830, 37963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 37931, 37952);

                f_1633_37931_37951(            // Clear the send collection
                            dataToBeSent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 37830, 37963);

                int
                f_1633_37931_37951(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 37931, 37951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 37830, 37963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 37830, 37963);
            }
        }

        internal virtual void StartReceivingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 37975, 38089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 38042, 38078);

                throw f_1633_38048_38077();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 37975, 38089);

                System.NotImplementedException
                f_1633_38048_38077()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 38048, 38077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 37975, 38089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 37975, 38089);
            }
        }

        internal virtual void PrepareForDisconnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 38222, 38338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 38291, 38327);

                throw f_1633_38297_38326();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 38222, 38338);

                System.NotImplementedException
                f_1633_38297_38326()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 38297, 38326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 38222, 38338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 38222, 38338);
            }
        }

        internal virtual void PrepareForConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 38455, 38568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 38521, 38557);

                throw f_1633_38527_38556();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 38455, 38568);

                System.NotImplementedException
                f_1633_38527_38556()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 38527, 38556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 38455, 38568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 38455, 38568);
            }
        }



        /// <summary>
        /// Finalizer.
        /// </summary>
        ~BaseClientTransportManager()
        {

            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 38755, 39493) || true) && (isClosed)
            )

            {
                DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 38755, 39493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 38801, 38816);

                f_1633_38801_38815(this, false);
                DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 38755, 39493);
            }

            else

            {
                DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 38755, 39493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 38969, 39108);

                this.CloseCompleted += delegate (object source, EventArgs args)
                                {
                                    Dispose(false);
                                };

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 39315, 39328);

                    f_1633_39315_39327(this);
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1633, 39365, 39478);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1633, 39365, 39478);
                    // intentionally blank
                }
                DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 38755, 39493);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 39516, 39930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 39626, 39654);

                this.CreateCompleted = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 39668, 39695);

                this.CloseCompleted = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 39709, 39738);

                this.ConnectCompleted = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 39752, 39784);

                this.DisconnectCompleted = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 39798, 39829);

                this.ReconnectCompleted = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 39893, 39919);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1633, 39893, 39918);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 39516, 39930);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 39516, 39930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 39516, 39930);
            }
        }

        static BaseClientTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 15651, 39959);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 15893, 15977);
            tracer = f_1633_15902_15977("ClientTransport", "Traces ClientTransportManager");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 15651, 39959);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 15651, 39959);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 15651, 39959);

        static System.Management.Automation.PSTraceSource
        f_1633_15902_15977(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 15902, 15977);
            return return_v;
        }


        object
        f_1633_16098_16110()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 16098, 16110);
            return return_v;
        }


        System.Management.Automation.Remoting.PrioritySendDataCollection
        f_1633_17039_17071()
        {
            var return_v = new System.Management.Automation.Remoting.PrioritySendDataCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 17039, 17071);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation>
        f_1633_17230_17274()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Remoting.Client.BaseClientTransportManager.CallbackNotificationInformation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 17230, 17274);
            return return_v;
        }


        static System.Management.Automation.Internal.PSRemotingCryptoHelper
        f_1633_16936_16948_C(System.Management.Automation.Internal.PSRemotingCryptoHelper
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1633, 16825, 17286);
            return return_v;
        }


        int
        f_1633_38801_38815(System.Management.Automation.Remoting.Client.BaseClientTransportManager
        this_param, bool
        isDisposing)
        {
            this_param.Dispose(isDisposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 38801, 38815);
            return 0;
        }


        int
        f_1633_39315_39327(System.Management.Automation.Remoting.Client.BaseClientTransportManager
        this_param)
        {
            this_param.CloseAsync();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 39315, 39327);
            return 0;
        }

    }
    internal abstract class BaseClientSessionTransportManager : BaseClientTransportManager, IDisposable
    {
        protected BaseClientSessionTransportManager(Guid runspaceId, PSRemotingCryptoHelper cryptoHelper)
        : base(f_1633_40233_40243_C(runspaceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 40115, 40280);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 40115, 40280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 40115, 40280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 40115, 40280);
            }
        }

        internal virtual BaseClientCommandTransportManager CreateClientCommandTransportManager(RunspaceConnectionInfo connectionInfo,
                            ClientRemotePowerShell cmd, bool noInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 40950, 41210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 41163, 41199);

                throw f_1633_41169_41198();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 40950, 41210);

                System.NotImplementedException
                f_1633_41169_41198()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 41169, 41198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 40950, 41210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 40950, 41210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void RemoveCommandTransportManager(Guid powerShellCmdId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 41487, 41582);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 41487, 41582);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 41487, 41582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 41487, 41582);
            }
        }

        internal virtual void DisconnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 41696, 41807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 41760, 41796);

                throw f_1633_41766_41795();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 41696, 41807);

                System.NotImplementedException
                f_1633_41766_41795()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 41766, 41795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 41696, 41807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 41696, 41807);
            }
        }

        internal virtual void ReconnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 41930, 42040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 41993, 42029);

                throw f_1633_41999_42028();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 41930, 42040);

                System.NotImplementedException
                f_1633_41999_42028()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 41999, 42028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 41930, 42040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 41930, 42040);
            }
        }

        internal virtual void Redirect(Uri newUri, RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 42418, 42571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 42524, 42560);

                throw f_1633_42530_42559();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 42418, 42571);

                System.NotImplementedException
                f_1633_42530_42559()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 42530, 42559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 42418, 42571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 42418, 42571);
            }
        }

        internal virtual void PrepareForRedirection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 42922, 43039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 42992, 43028);

                throw f_1633_42998_43027();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 42922, 43039);

                System.NotImplementedException
                f_1633_42998_43027()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 42998, 43027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 42922, 43039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 42922, 43039);
            }
        }

        static BaseClientSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 39967, 43068);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 39967, 43068);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 39967, 43068);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 39967, 43068);

        static System.Guid
        f_1633_40233_40243_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1633, 40115, 40280);
            return return_v;
        }

    }
    internal abstract class BaseClientCommandTransportManager : BaseClientTransportManager, IDisposable
    {
        protected StringBuilder cmdText;

        protected SerializedDataStream serializedPipeline;

        protected Guid powershellInstanceId;

        protected Guid PowershellInstanceId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 43544, 43580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 43550, 43578);

                    return powershellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 43544, 43580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 43484, 43591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 43484, 43591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool startInDisconnectedMode;

        protected BaseClientCommandTransportManager(ClientRemotePowerShell shell,
                    PSRemotingCryptoHelper cryptoHelper,
                    BaseClientSessionTransportManager sessnTM) : base(f_1633_43902_43932_C(f_1633_43902_43932(sessnTM)), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 43715, 45132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 43358, 43365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 43407, 43425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 43639, 43670);
                this.startInDisconnectedMode = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 43972, 44030);

                f_1633_43972_43982().FragmentSize = f_1633_43998_44029(f_1633_43998_44016(sessnTM));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44044, 44096);

                f_1633_44044_44054().TypeTable = f_1633_44067_44095(f_1633_44067_44085(sessnTM));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44110, 44152);

                dataToBeSent.Fragmentor = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Fragmentor, 1633, 44136, 44151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44208, 44259);

                powershellInstanceId = f_1633_44231_44258(f_1633_44231_44247(shell));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44275, 44305);

                cmdText = f_1633_44285_44304();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44319, 44537);
                    foreach (System.Management.Automation.Runspaces.Command cmd in f_1633_44382_44416_I(f_1633_44382_44416(f_1633_44382_44407(f_1633_44382_44398(shell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 44319, 44537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44450, 44482);

                        f_1633_44450_44481(cmdText, f_1633_44465_44480(cmd));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44500, 44522);

                        f_1633_44500_44521(cmdText, " | ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 44319, 44537);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1633, 1, 219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1633, 1, 219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44553, 44591);

                f_1633_44553_44590(
                            cmdText, f_1633_44568_44582(cmdText) - 3, 3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44630, 44655);

                RemoteDataObject
                message
                = default(RemoteDataObject);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44669, 44958) || true) && (f_1633_44673_44725(f_1633_44673_44689(shell)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 44669, 44958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44759, 44819);

                    message = f_1633_44769_44818(shell);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 44669, 44958);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 44669, 44958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44885, 44943);

                    message = f_1633_44895_44942(shell);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 44669, 44958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 44974, 45050);

                serializedPipeline = f_1633_44995_45049(f_1633_45020_45048(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Fragmentor, 1633, 45020, 45035)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 45064, 45121);

                f_1633_45064_45120(f_1633_45064_45074(), message, serializedPipeline);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 43715, 45132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 43715, 45132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 43715, 45132);
            }
        }



        internal event EventHandler<EventArgs>
SignalCompleted
;

        internal void RaiseSignalCompleted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 45259, 45381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 45320, 45370);

                f_1633_45320_45369(SignalCompleted, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 45259, 45381);

                int
                f_1633_45320_45369(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 45320, 45369);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 45259, 45381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 45259, 45381);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 45444, 45711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 45517, 45543);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1633, 45517, 45542);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 45559, 45700) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 45559, 45700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 45656, 45685);

                    f_1633_45656_45684(                // dispose serialized pipeline
                                    serializedPipeline);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 45559, 45700);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 45444, 45711);

                int
                f_1633_45656_45684(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 45656, 45684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 45444, 45711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 45444, 45711);
            }
        }

        internal virtual void ReconnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 46178, 46288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 46241, 46277);

                throw f_1633_46247_46276();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 46178, 46288);

                System.NotImplementedException
                f_1633_46247_46276()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 46247, 46276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 46178, 46288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 46178, 46288);
            }
        }

        internal virtual void SendStopSignal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 46434, 46544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 46497, 46533);

                throw f_1633_46503_46532();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 46434, 46544);

                System.NotImplementedException
                f_1633_46503_46532()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 46503, 46532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 46434, 46544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 46434, 46544);
            }
        }

        static BaseClientCommandTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 43076, 46573);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 43076, 46573);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 43076, 46573);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 43076, 46573);

        static System.Guid
        f_1633_43902_43932(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
        this_param)
        {
            var return_v = this_param.RunspacePoolInstanceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 43902, 43932);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1633_43972_43982()
        {
            var return_v = Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 43972, 43982);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1633_43998_44016(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
        this_param)
        {
            var return_v = this_param.Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 43998, 44016);
            return return_v;
        }


        int
        f_1633_43998_44029(System.Management.Automation.Remoting.Fragmentor
        this_param)
        {
            var return_v = this_param.FragmentSize;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 43998, 44029);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1633_44044_44054()
        {
            var return_v = Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44044, 44054);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1633_44067_44085(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
        this_param)
        {
            var return_v = this_param.Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44067, 44085);
            return return_v;
        }


        System.Management.Automation.Runspaces.TypeTable
        f_1633_44067_44095(System.Management.Automation.Remoting.Fragmentor
        this_param)
        {
            var return_v = this_param.TypeTable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44067, 44095);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1633_44231_44247(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        this_param)
        {
            var return_v = this_param.PowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44231, 44247);
            return return_v;
        }


        System.Guid
        f_1633_44231_44258(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.InstanceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44231, 44258);
            return return_v;
        }


        System.Text.StringBuilder
        f_1633_44285_44304()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44285, 44304);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1633_44382_44398(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        this_param)
        {
            var return_v = this_param.PowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44382, 44398);
            return return_v;
        }


        System.Management.Automation.PSCommand
        f_1633_44382_44407(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.Commands;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44382, 44407);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1633_44382_44416(System.Management.Automation.PSCommand
        this_param)
        {
            var return_v = this_param.Commands;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44382, 44416);
            return return_v;
        }


        string
        f_1633_44465_44480(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.CommandText;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44465, 44480);
            return return_v;
        }


        System.Text.StringBuilder
        f_1633_44450_44481(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44450, 44481);
            return return_v;
        }


        System.Text.StringBuilder
        f_1633_44500_44521(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44500, 44521);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1633_44382_44416_I(System.Management.Automation.Runspaces.CommandCollection
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44382, 44416);
            return return_v;
        }


        int
        f_1633_44568_44582(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44568, 44582);
            return return_v;
        }


        System.Text.StringBuilder
        f_1633_44553_44590(System.Text.StringBuilder
        this_param, int
        startIndex, int
        length)
        {
            var return_v = this_param.Remove(startIndex, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44553, 44590);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1633_44673_44689(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        this_param)
        {
            var return_v = this_param.PowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44673, 44689);
            return return_v;
        }


        bool
        f_1633_44673_44725(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.IsGetCommandMetadataSpecialPipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 44673, 44725);
            return return_v;
        }


        System.Management.Automation.Remoting.RemoteDataObject
        f_1633_44769_44818(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        shell)
        {
            var return_v = RemotingEncoder.GenerateGetCommandMetadata(shell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44769, 44818);
            return return_v;
        }


        System.Management.Automation.Remoting.RemoteDataObject
        f_1633_44895_44942(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        shell)
        {
            var return_v = RemotingEncoder.GenerateCreatePowerShell(shell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44895, 44942);
            return return_v;
        }


        int
        f_1633_45020_45048(System.Management.Automation.Remoting.Fragmentor
        this_param)
        {
            var return_v = this_param.FragmentSize;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 45020, 45048);
            return return_v;
        }


        System.Management.Automation.Remoting.SerializedDataStream
        f_1633_44995_45049(int
        fragmentSize)
        {
            var return_v = new System.Management.Automation.Remoting.SerializedDataStream(fragmentSize);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 44995, 45049);
            return return_v;
        }


        System.Management.Automation.Remoting.Fragmentor
        f_1633_45064_45074()
        {
            var return_v = Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 45064, 45074);
            return return_v;
        }


        int
        f_1633_45064_45120(System.Management.Automation.Remoting.Fragmentor
        this_param, System.Management.Automation.Remoting.RemoteDataObject
        obj, System.Management.Automation.Remoting.SerializedDataStream
        dataToBeSent)
        {
            this_param.Fragment<object>((System.Management.Automation.Remoting.RemoteDataObject<object>)obj, dataToBeSent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 45064, 45120);
            return 0;
        }


        static System.Guid
        f_1633_43902_43932_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1633, 43715, 45132);
            return return_v;
        }

    }
}

namespace System.Management.Automation.Remoting.Server
{
    internal abstract class AbstractServerTransportManager : BaseTransportManager
    {
        private object _syncObject;

        private SerializedDataStream.OnDataAvailableCallback _onDataAvailable;

        private bool _shouldFlushData;

        private bool _reportAsPending;

        private Guid _runspacePoolInstanceId;

        private Guid _powerShellInstanceId;

        private RemotingDataType _dataType;

        private RemotingTargetInterface _targetInterface;

        private Queue<Tuple<RemoteDataObject, bool, bool>> _dataToBeSentQueue;

        private bool _isSerializing;

        protected AbstractServerTransportManager(int fragmentSize, PSRemotingCryptoHelper cryptoHelper)
        : base(f_1633_47802_47814_C(cryptoHelper))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 47686, 47994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 46893, 46919);
                this._syncObject = f_1633_46907_46919();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47063, 47079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47175, 47191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47215, 47231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47359, 47368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47411, 47427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47566, 47584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47608, 47622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47840, 47884);

                DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Fragmentor, 1633, 47840, 47855).FragmentSize = fragmentSize;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 47898, 47983);

                _onDataAvailable = new SerializedDataStream.OnDataAvailableCallback(OnDataAvailable);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 47686, 47994);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 47686, 47994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 47686, 47994);
            }
        }

        internal void SendDataToClient<T>(RemoteDataObject<T> data, bool flush, bool reportPending = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 48744, 54138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 49022, 49033);
                // make sure only one data packet can be sent in its entirety at any
                // given point of time using this transport manager.
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 51528, 51826);

                    RemoteDataObject
                    dataToBeSent = f_1633_51560_51825(f_1633_51588_51604(data), f_1633_51606_51619(data), f_1633_51698_51717(data), f_1633_51719_51736(data), f_1633_51815_51824(data))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 51844, 52253) || true) && (_isSerializing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 51844, 52253);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 51904, 52077) || true) && (_dataToBeSentQueue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 51904, 52077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 51984, 52054);

                            _dataToBeSentQueue = f_1633_52005_52053();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 51904, 52077);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52101, 52205);

                        f_1633_52101_52204(
                                            _dataToBeSentQueue, f_1633_52128_52203(dataToBeSent, flush, reportPending));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52227, 52234);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 51844, 52253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52273, 52295);

                    _isSerializing = true;
                    try
                    {
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 52357, 53985);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52609, 53317);
                                    using (SerializedDataStream
                                    serializedData =
                                    f_1633_52683_52750(f_1633_52708_52731(f_1633_52708_52718()), _onDataAvailable)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52808, 52833);

                                        _shouldFlushData = flush;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52863, 52896);

                                        _reportAsPending = reportPending;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52926, 52980);

                                        _runspacePoolInstanceId = f_1633_52952_52979(dataToBeSent);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53010, 53060);

                                        _powerShellInstanceId = f_1633_53034_53059(dataToBeSent);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53090, 53124);

                                        _dataType = f_1633_53102_53123(dataToBeSent);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53154, 53202);

                                        _targetInterface = f_1633_53173_53201(dataToBeSent);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53232, 53290);

                                        f_1633_53232_53289(f_1633_53232_53242(), dataToBeSent, serializedData);
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(1633, 52609, 53317);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53345, 53932) || true) && ((_dataToBeSentQueue != null) && (DynAbs.Tracing.TraceSender.Expression_True(1633, 53349, 53411) && (f_1633_53382_53406(_dataToBeSentQueue) > 0)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 53345, 53932);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53469, 53558);

                                        Tuple<RemoteDataObject, bool, bool>
                                        dataToBeSentQueueItem = f_1633_53529_53557(_dataToBeSentQueue)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53588, 53631);

                                        dataToBeSent = f_1633_53603_53630(dataToBeSentQueueItem);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53661, 53697);

                                        flush = f_1633_53669_53696(dataToBeSentQueueItem);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53727, 53771);

                                        reportPending = f_1633_53743_53770(dataToBeSentQueueItem);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 53345, 53932);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 53345, 53932);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 53885, 53905);

                                        dataToBeSent = null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 53345, 53932);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 52357, 53985);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 52357, 53985) || true) && (dataToBeSent != null)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1633, 52357, 53985);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1633, 52357, 53985);
                            }
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1633, 54022, 54112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 54070, 54093);

                        _isSerializing = false;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1633, 54022, 54112);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 48744, 54138);

                System.Management.Automation.RemotingDestination
                f_1633_51588_51604(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 51588, 51604);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1633_51606_51619(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 51606, 51619);
                    return return_v;
                }


                System.Guid
                f_1633_51698_51717(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 51698, 51717);
                    return return_v;
                }


                System.Guid
                f_1633_51719_51736(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 51719, 51736);
                    return return_v;
                }


                T
                f_1633_51815_51824(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 51815, 51824);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1633_51560_51825(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, T
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 51560, 51825);
                    return return_v;
                }


                System.Collections.Generic.Queue<System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>>
                f_1633_52005_52053()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 52005, 52053);
                    return return_v;
                }


                System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>
                f_1633_52128_52203(System.Management.Automation.Remoting.RemoteDataObject
                item1, bool
                item2, bool
                item3)
                {
                    var return_v = new System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 52128, 52203);
                    return return_v;
                }


                int
                f_1633_52101_52204(System.Collections.Generic.Queue<System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>>
                this_param, System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 52101, 52204);
                    return 0;
                }


                System.Management.Automation.Remoting.Fragmentor
                f_1633_52708_52718()
                {
                    var return_v = Fragmentor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 52708, 52718);
                    return return_v;
                }


                int
                f_1633_52708_52731(System.Management.Automation.Remoting.Fragmentor
                this_param)
                {
                    var return_v = this_param.FragmentSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 52708, 52731);
                    return return_v;
                }


                System.Management.Automation.Remoting.SerializedDataStream
                f_1633_52683_52750(int
                fragmentSize, System.Management.Automation.Remoting.SerializedDataStream.OnDataAvailableCallback
                callbackToNotify)
                {
                    var return_v = new System.Management.Automation.Remoting.SerializedDataStream(fragmentSize, callbackToNotify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 52683, 52750);
                    return return_v;
                }


                System.Guid
                f_1633_52952_52979(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 52952, 52979);
                    return return_v;
                }


                System.Guid
                f_1633_53034_53059(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53034, 53059);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1633_53102_53123(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53102, 53123);
                    return return_v;
                }


                System.Management.Automation.RemotingTargetInterface
                f_1633_53173_53201(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.TargetInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53173, 53201);
                    return return_v;
                }


                System.Management.Automation.Remoting.Fragmentor
                f_1633_53232_53242()
                {
                    var return_v = Fragmentor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53232, 53242);
                    return return_v;
                }


                int
                f_1633_53232_53289(System.Management.Automation.Remoting.Fragmentor
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                obj, System.Management.Automation.Remoting.SerializedDataStream
                dataToBeSent)
                {
                    this_param.Fragment<object>((System.Management.Automation.Remoting.RemoteDataObject<object>)obj, dataToBeSent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 53232, 53289);
                    return 0;
                }


                int
                f_1633_53382_53406(System.Collections.Generic.Queue<System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53382, 53406);
                    return return_v;
                }


                System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>
                f_1633_53529_53557(System.Collections.Generic.Queue<System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 53529, 53557);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1633_53603_53630(System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53603, 53630);
                    return return_v;
                }


                bool
                f_1633_53669_53696(System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53669, 53696);
                    return return_v;
                }


                bool
                f_1633_53743_53770(System.Tuple<System.Management.Automation.Remoting.RemoteDataObject, bool, bool>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 53743, 53770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 48744, 54138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 48744, 54138);
            }
        }

        private void OnDataAvailable(byte[] dataToSend, bool isEndFragment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 54150, 54929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 54242, 54325);

                f_1633_54242_54324(dataToSend != null, "ServerTransportManager cannot send null fragment");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 54375, 54789);

                f_1633_54375_54788(PSEventId.ServerSendData, PSOpcode.Send, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, _runspacePoolInstanceId.ToString(), _powerShellInstanceId.ToString(), f_1633_54652_54708(f_1633_54652_54669(dataToSend), f_1633_54679_54707()), _dataType, _targetInterface);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 54805, 54918);

                f_1633_54805_54917(this, dataToSend, (DynAbs.Tracing.TraceSender.Conditional_F1(1633, 54834, 54868) || (((isEndFragment & _shouldFlushData) && DynAbs.Tracing.TraceSender.Conditional_F2(1633, 54871, 54875)) || DynAbs.Tracing.TraceSender.Conditional_F3(1633, 54878, 54883))) ? true : false, _reportAsPending, isEndFragment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 54150, 54929);

                int
                f_1633_54242_54324(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 54242, 54324);
                    return 0;
                }


                int
                f_1633_54652_54669(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 54652, 54669);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1633_54679_54707()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 54679, 54707);
                    return return_v;
                }


                string
                f_1633_54652_54708(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 54652, 54708);
                    return return_v;
                }


                int
                f_1633_54375_54788(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 54375, 54788);
                    return 0;
                }


                int
                f_1633_54805_54917(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, byte[]
                data, bool
                flush, bool
                reportAsPending, bool
                reportAsDataBoundary)
                {
                    this_param.SendDataToClient(data, flush, reportAsPending, reportAsDataBoundary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 54805, 54917);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 54150, 54929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 54150, 54929);
            }
        }

        internal void SendDataToClient(RemoteDataObject psObjectData, bool flush, bool reportAsPending = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 55592, 55822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 55720, 55811);

                f_1633_55720_55810(this, (psObjectData), flush, reportAsPending);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 55592, 55822);

                int
                f_1633_55720_55810(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data, bool
                flush, bool
                reportPending)
                {
                    this_param.SendDataToClient<object>((System.Management.Automation.Remoting.RemoteDataObject<object>)data, flush, reportPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 55720, 55810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 55592, 55822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 55592, 55822);
            }
        }

        internal void ReportError(int errorCode, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 56314, 57231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 56398, 56459);

                string
                messageResource = f_1633_56423_56458()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 56473, 56613);

                string
                errorMessage = f_1633_56495_56612(f_1633_56509_56537(), messageResource, new object[] { errorCode, methodName })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 56629, 56709);

                PSRemotingTransportException
                e = f_1633_56662_56708(errorMessage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 56723, 56747);

                e.ErrorCode = errorCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 56884, 57220);

                f_1633_56884_57219(new WaitCallback(
                                delegate (object state)
                                {
                                    TransportErrorOccuredEventArgs eventArgs = new TransportErrorOccuredEventArgs(e,
                                        TransportMethodEnum.Unknown);
                                    RaiseErrorHandler(eventArgs);
                                }));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 56314, 57231);

                string
                f_1633_56423_56458()
                {
                    var return_v = RemotingErrorIdStrings.GeneralError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 56423, 56458);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1633_56509_56537()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 56509, 56537);
                    return return_v;
                }


                string
                f_1633_56495_56612(System.Globalization.CultureInfo
                provider, string
                format, params object[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 56495, 56612);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1633_56662_56708(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 56662, 56708);
                    return return_v;
                }


                bool
                f_1633_56884_57219(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 56884, 57219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 56314, 57231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 56314, 57231);
            }
        }

        internal void RaiseClosingEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 57329, 57440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 57387, 57429);

                f_1633_57387_57428(Closing, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 57329, 57440);

                int
                f_1633_57387_57428(System.EventHandler
                eventHandler, System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 57387, 57428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 57329, 57440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 57329, 57440);
            }
        }



        /// <summary>
        /// Event that is raised when this transport manager is closing.
        /// </summary>
        internal event EventHandler
Closing
;

        protected abstract void SendDataToClient(byte[] data, bool flush, bool reportAsPending, bool reportAsDataBoundary);

        internal abstract void ReportExecutionStatusAsRunning();

        internal abstract void Close(Exception reasonForClose);

        internal virtual void Prepare()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1633, 59089, 59414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 59346, 59403);

                f_1633_59346_59402(f_1633_59346_59368());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1633, 59089, 59414);

                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1633_59346_59368()
                {
                    var return_v = ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 59346, 59368);
                    return return_v;
                }


                int
                f_1633_59346_59402(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param)
                {
                    this_param.AllowTwoThreadsToProcessRawData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 59346, 59402);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 59089, 59414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 59089, 59414);
            }
        }

        static AbstractServerTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 46752, 59443);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 46752, 59443);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 46752, 59443);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 46752, 59443);

        object
        f_1633_46907_46919()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 46907, 46919);
            return return_v;
        }


        static System.Management.Automation.Internal.PSRemotingCryptoHelper
        f_1633_47802_47814_C(System.Management.Automation.Internal.PSRemotingCryptoHelper
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1633, 47686, 47994);
            return return_v;
        }

    }
    internal abstract class AbstractServerSessionTransportManager : AbstractServerTransportManager
    {
        protected AbstractServerSessionTransportManager(int fragmentSize, PSRemotingCryptoHelper cryptoHelper)
        : base(f_1633_59834_59846_C(fragmentSize), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1633, 59711, 59883);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1633, 59711, 59883);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 59711, 59883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 59711, 59883);
            }
        }

        internal abstract AbstractServerTransportManager GetCommandTransportManager(Guid powerShellCmdId);

        internal abstract void RemoveCommandTransportManager(Guid powerShellCmdId);

        static AbstractServerSessionTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 59568, 60654);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 59568, 60654);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 59568, 60654);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1633, 59568, 60654);

        static int
        f_1633_59834_59846_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1633, 59711, 59883);
            return return_v;
        }

    }
    internal static class ServerOperationHelpers
    {
        internal static byte[] ExtractEncodedXmlElement(string xmlBuffer, string xmlTag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1633, 61477, 62862);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 61582, 61659) || true) && (xmlBuffer == null || (DynAbs.Tracing.TraceSender.Expression_False(1633, 61586, 61621) || xmlTag == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 61582, 61659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 61640, 61659);

                    return new byte[1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 61582, 61659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 61839, 61898);

                XmlReaderSettings
                readerSettings = f_1633_61874_61897()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 61912, 61951);

                readerSettings.CheckCharacters = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 61965, 62002);

                readerSettings.IgnoreComments = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62016, 62067);

                readerSettings.IgnoreProcessingInstructions = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62081, 62115);

                readerSettings.XmlResolver = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62129, 62189);

                readerSettings.ConformanceLevel = ConformanceLevel.Fragment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62203, 62251);

                readerSettings.MaxCharactersFromEntities = 1024;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62265, 62330);

                readerSettings.DtdProcessing = System.Xml.DtdProcessing.Prohibit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62344, 62425);

                XmlReader
                reader = f_1633_62363_62424(f_1633_62380_62407(xmlBuffer), readerSettings)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62441, 62463);

                string
                additionalData
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62477, 62787) || true) && (XmlNodeType.Element == f_1633_62504_62526(reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 62477, 62787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62560, 62640);

                    additionalData = f_1633_62577_62639(reader, xmlTag, f_1633_62619_62638(reader));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 62477, 62787);
                }

                else // No element found, so return a default value

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1633, 62477, 62787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62753, 62772);

                    return new byte[1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1633, 62477, 62787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1633, 62803, 62851);

                return f_1633_62810_62850(additionalData);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1633, 61477, 62862);

                System.Xml.XmlReaderSettings
                f_1633_61874_61897()
                {
                    var return_v = new System.Xml.XmlReaderSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 61874, 61897);
                    return return_v;
                }


                System.IO.StringReader
                f_1633_62380_62407(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 62380, 62407);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1633_62363_62424(System.IO.StringReader
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.TextReader)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 62363, 62424);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1633_62504_62526(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.MoveToContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 62504, 62526);
                    return return_v;
                }


                string
                f_1633_62619_62638(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.NamespaceURI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1633, 62619, 62638);
                    return return_v;
                }


                string
                f_1633_62577_62639(System.Xml.XmlReader
                this_param, string
                localName, string
                namespaceURI)
                {
                    var return_v = this_param.ReadElementContentAsString(localName, namespaceURI);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 62577, 62639);
                    return return_v;
                }


                byte[]
                f_1633_62810_62850(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1633, 62810, 62850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1633, 61477, 62862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 61477, 62862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ServerOperationHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1633, 60791, 62889);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1633, 60791, 62889);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1633, 60791, 62889);
        }

    }
}
