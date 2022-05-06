// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ----------------------------------------------------------------------
//  Contents:  Entry points for managed PowerShell plugin worker used to
//  host powershell in a WSMan service.
// ----------------------------------------------------------------------

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Tracing;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal abstract class WSManPluginServerSession : IDisposable
    {
        private object _syncObject;

        protected bool isClosed;

        protected bool isContextReported;

        protected Exception lastErrorReported;

        internal WSManNativeApi.WSManPluginRequest creationRequestDetails;

        internal WSManNativeApi.WSManPluginRequest sendRequestDetails;

        internal WSManPluginOperationShutdownContext shutDownContext;

        internal RegisteredWaitHandle registeredShutDownWaitHandle;

        internal WSManPluginServerTransportManager transportMgr;

        internal int registeredShutdownNotification;

        // event that gets raised when session is closed.."source" will provide
        // IntPtr for "creationRequestDetails" which can be used to free
        // the context.
        internal event EventHandler<EventArgs>
SessionClosed
;

        private bool _disposed;

        protected WSManPluginServerSession(
                    WSManNativeApi.WSManPluginRequest creationRequestDetails,
                    WSManPluginServerTransportManager transportMgr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1642, 2356, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1080, 1091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1119, 1127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1153, 1170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1320, 1337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1472, 1494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1619, 1637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1693, 1708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1856, 1884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1938, 1950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 1974, 2004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 2326, 2343);
                this._disposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 2548, 2575);

                _syncObject = f_1642_2562_2574();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 2589, 2642);

                this.creationRequestDetails = creationRequestDetails;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 2656, 2689);

                this.transportMgr = transportMgr;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 2705, 2820);

                transportMgr.PrepareCalled +=
                                new EventHandler<EventArgs>(this.HandlePrepareFromTransportManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 2834, 2970);

                transportMgr.WSManTransportErrorOccured +=
                                new EventHandler<TransportErrorOccuredEventArgs>(this.HandleTransportError);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1642, 2356, 2981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 2356, 2981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 2356, 2981);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 2993, 3456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 3087, 3101);

                f_1642_3087_3100(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 3419, 3445);

                f_1642_3419_3444(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 2993, 3456);

                int
                f_1642_3087_3100(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 3087, 3100);
                    return 0;
                }


                int
                f_1642_3419_3444(System.Management.Automation.Remoting.WSManPluginServerSession
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 3419, 3444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 2993, 3456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 2993, 3456);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 4104, 4893);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 4240, 4882) || true) && (!_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 4240, 4882);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 4399, 4540) || true) && (disposing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 4399, 4540);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 4399, 4540);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 4767, 4780);

                    f_1642_4767_4779(this, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 4850, 4867);

                    _disposed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 4240, 4882);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 4104, 4893);

                int
                f_1642_4767_4779(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param, bool
                isShuttingDown)
                {
                    this_param.Close(isShuttingDown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 4767, 4779);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 4104, 4893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 4104, 4893);
            }
        }

        /// <summary>
        /// Use C# destructor syntax for finalization code.
        /// This destructor will run only if the Dispose method
        /// does not get called.
        /// It gives your base class the opportunity to finalize.
        /// Do not provide destructors in types derived from this class.
        /// </summary>
        ~WSManPluginServerSession()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 5477, 5492);

            f_1642_5477_5491(this, false);
        }

        internal void SendOneItemToSession(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    string stream,
                    WSManNativeApi.WSManData_UnToMan inboundData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 5515, 7854);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 5749, 6376) || true) && ((!f_1642_5755_5845(stream, WSManPluginConstants.SupportedInputStream, StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(1642, 5753, 5969) && (!f_1642_5869_5968(stream, WSManPluginConstants.SupportedPromptResponseStream, StringComparison.Ordinal))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 5749, 6376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 6003, 6336);

                    f_1642_6003_6335(requestDetails, WSManPluginErrorCodes.InvalidInputStream, f_1642_6169_6334(f_1642_6213_6265(), WSManPluginConstants.SupportedInputStream));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 6354, 6361);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 5749, 6376);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 6392, 6677) || true) && (inboundData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 6392, 6677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 6503, 6637);

                    f_1642_6503_6636(requestDetails, WSManPluginErrorCodes.NoError);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 6655, 6662);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 6392, 6677);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 6693, 7216) || true) && ((uint)WSManNativeApi.WSManDataType.WSMAN_DATA_TYPE_BINARY != f_1642_6758_6774(inboundData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 6693, 7216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 6858, 7176);

                    f_1642_6858_7175(requestDetails, WSManPluginErrorCodes.InvalidInputDatatype, f_1642_7026_7174(f_1642_7070_7122(), "WSMAN_DATA_TYPE_BINARY"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7194, 7201);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 6693, 7216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7238, 7249);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7283, 7477) || true) && (true == isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 7283, 7477);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7345, 7429);

                        f_1642_7345_7428(requestDetails, lastErrorReported);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7451, 7458);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 7283, 7477);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7634, 7670);

                    sendRequestDetails = requestDetails;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7701, 7754);

                f_1642_7701_7753(this, f_1642_7728_7744(inboundData), stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7813, 7843);

                f_1642_7813_7842(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 5515, 7854);

                bool
                f_1642_5755_5845(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 5755, 5845);
                    return return_v;
                }


                bool
                f_1642_5869_5968(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 5869, 5968);
                    return return_v;
                }


                string
                f_1642_6213_6265()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidInputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 6213, 6265);
                    return return_v;
                }


                string
                f_1642_6169_6334(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 6169, 6334);
                    return return_v;
                }


                int
                f_1642_6003_6335(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 6003, 6335);
                    return 0;
                }


                int
                f_1642_6503_6636(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 6503, 6636);
                    return 0;
                }


                uint
                f_1642_6758_6774(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 6758, 6774);
                    return return_v;
                }


                string
                f_1642_7070_7122()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidInputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 7070, 7122);
                    return return_v;
                }


                string
                f_1642_7026_7174(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 7026, 7174);
                    return return_v;
                }


                int
                f_1642_6858_7175(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 6858, 7175);
                    return 0;
                }


                int
                f_1642_7345_7428(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 7345, 7428);
                    return 0;
                }


                byte[]
                f_1642_7728_7744(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 7728, 7744);
                    return return_v;
                }


                int
                f_1642_7701_7753(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.SendOneItemToSessionHelper(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 7701, 7753);
                    return 0;
                }


                int
                f_1642_7813_7842(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param)
                {
                    this_param.ReportSendOperationComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 7813, 7842);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 5515, 7854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 5515, 7854);
            }
        }

        internal void SendOneItemToSessionHelper(
                    byte[] data,
                    string stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 7866, 8039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 7986, 8028);

                f_1642_7986_8027(transportMgr, data, stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 7866, 8039);

                int
                f_1642_7986_8027(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 7986, 8027);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 7866, 8039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 7866, 8039);
            }
        }

        internal bool EnableSessionToSendDataToClient(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    WSManNativeApi.WSManStreamIDSet_UnToMan streamSet,
                    WSManPluginOperationShutdownContext ctxtToReport)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 8051, 9819);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 8336, 8520) || true) && (true == isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 8336, 8520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 8390, 8474);

                    f_1642_8390_8473(requestDetails, lastErrorReported);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 8492, 8505);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 8336, 8520);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 8536, 9093) || true) && ((streamSet == null) || (DynAbs.Tracing.TraceSender.Expression_False(1642, 8540, 8611) || (1 != streamSet.streamIDsCount)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 8536, 9093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 8711, 9047);

                    f_1642_8711_9046(requestDetails, WSManPluginErrorCodes.InvalidOutputStream, f_1642_8878_9045(f_1642_8922_8975(), WSManPluginConstants.SupportedOutputStream));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 9065, 9078);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 8536, 9093);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 9109, 9703) || true) && (!f_1642_9114_9221(streamSet.streamIDs[0], WSManPluginConstants.SupportedOutputStream, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 9109, 9703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 9321, 9657);

                    f_1642_9321_9656(requestDetails, WSManPluginErrorCodes.InvalidOutputStream, f_1642_9488_9655(f_1642_9532_9585(), WSManPluginConstants.SupportedOutputStream));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 9675, 9688);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 9109, 9703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 9719, 9808);

                return f_1642_9726_9807(transportMgr, requestDetails, ctxtToReport);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 8051, 9819);

                int
                f_1642_8390_8473(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 8390, 8473);
                    return 0;
                }


                string
                f_1642_8922_8975()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidOutputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 8922, 8975);
                    return return_v;
                }


                string
                f_1642_8878_9045(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 8878, 9045);
                    return return_v;
                }


                int
                f_1642_8711_9046(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 8711, 9046);
                    return 0;
                }


                bool
                f_1642_9114_9221(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 9114, 9221);
                    return return_v;
                }


                string
                f_1642_9532_9585()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidOutputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 9532, 9585);
                    return return_v;
                }


                string
                f_1642_9488_9655(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 9488, 9655);
                    return return_v;
                }


                int
                f_1642_9321_9656(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 9321, 9656);
                    return 0;
                }


                bool
                f_1642_9726_9807(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                ctxtToReport)
                {
                    var return_v = this_param.EnableTransportManagerSendDataToClient(requestDetails, ctxtToReport);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 9726, 9807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 8051, 9819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 8051, 9819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReportContext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 10002, 13383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10056, 10071);

                int
                result = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10085, 10134);

                bool
                isRegisterWaitForSingleObjectFailed = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10156, 10167);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10201, 10289) || true) && (true == isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 10201, 10289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10263, 10270);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 10201, 10289);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10309, 12614) || true) && (!isContextReported)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 10309, 12614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10373, 10398);

                        isContextReported = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 10420, 10710);

                        f_1642_10420_10709(PSEventId.ReportContext, PSOpcode.Connect, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, f_1642_10640_10673(creationRequestDetails), f_1642_10675_10708(creationRequestDetails));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 11004, 11136);

                        result = f_1642_11013_11135(creationRequestDetails.unmanagedHandle, 0, creationRequestDetails.unmanagedHandle);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 11158, 12595) || true) && (f_1642_11162_11180() && (DynAbs.Tracing.TraceSender.Expression_True(1642, 11162, 11232) && (WSManPluginConstants.ExitCodeSuccess == result)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 11158, 12595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 11282, 11317);

                            registeredShutdownNotification = 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 11447, 11556);

                            SafeWaitHandle
                            safeWaitHandle = f_1642_11479_11555(f_1642_11498_11547(creationRequestDetails), false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 11600, 11687);

                            EventWaitHandle
                            eventWaitHandle = f_1642_11634_11686(false, EventResetMode.AutoReset)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 11713, 11761);

                            eventWaitHandle.SafeWaitHandle = safeWaitHandle;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 11855, 12223);

                            this.registeredShutDownWaitHandle = f_1642_11891_12222(eventWaitHandle, new WaitOrTimerCallback(WSManPluginManagedEntryWrapper.PSPluginOperationShutdownCallback), shutDownContext, -1, true);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 12334, 12572) || true) && (this.registeredShutDownWaitHandle == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 12334, 12572);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 12437, 12480);

                                isRegisterWaitForSingleObjectFailed = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 12510, 12545);

                                registeredShutdownNotification = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 12334, 12572);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 11158, 12595);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 10309, 12614);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 12645, 13372) || true) && ((WSManPluginConstants.ExitCodeSuccess != result) || (DynAbs.Tracing.TraceSender.Expression_False(1642, 12649, 12738) || (isRegisterWaitForSingleObjectFailed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 12645, 13372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 12772, 12792);

                    string
                    errorMessage
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 12810, 13175) || true) && (isRegisterWaitForSingleObjectFailed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 12810, 13175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 12891, 12986);

                        errorMessage = f_1642_12906_12985(f_1642_12924_12984());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 12810, 13175);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 12810, 13175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 13068, 13156);

                        errorMessage = f_1642_13083_13155(f_1642_13101_13154());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 12810, 13175);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 13250, 13319);

                    Exception
                    mgdException = f_1642_13275_13318(errorMessage)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 13337, 13357);

                    f_1642_13337_13356(this, mgdException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 12645, 13372);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 10002, 13383);

                string?
                f_1642_10640_10673(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 10640, 10673);
                    return return_v;
                }


                string?
                f_1642_10675_10708(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 10675, 10708);
                    return return_v;
                }


                int
                f_1642_10420_10709(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 10420, 10709);
                    return 0;
                }


                int
                f_1642_11013_11135(System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                context)
                {
                    var return_v = WSManNativeApi.WSManPluginReportContext(requestDetails, flags, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 11013, 11135);
                    return return_v;
                }


                bool
                f_1642_11162_11180()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 11162, 11180);
                    return return_v;
                }


                System.IntPtr
                f_1642_11498_11547(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.shutdownNotificationHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 11498, 11547);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeWaitHandle
                f_1642_11479_11555(System.IntPtr
                existingHandle, bool
                ownsHandle)
                {
                    var return_v = new Microsoft.Win32.SafeHandles.SafeWaitHandle(existingHandle, ownsHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 11479, 11555);
                    return return_v;
                }


                System.Threading.EventWaitHandle
                f_1642_11634_11686(bool
                initialState, System.Threading.EventResetMode
                mode)
                {
                    var return_v = new System.Threading.EventWaitHandle(initialState, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 11634, 11686);
                    return return_v;
                }


                System.Threading.RegisteredWaitHandle
                f_1642_11891_12222(System.Threading.EventWaitHandle
                waitObject, System.Threading.WaitOrTimerCallback
                callBack, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                state, int
                millisecondsTimeOutInterval, bool
                executeOnlyOnce)
                {
                    var return_v = ThreadPool.RegisterWaitForSingleObject((System.Threading.WaitHandle)waitObject, callBack, (object)state, millisecondsTimeOutInterval, executeOnlyOnce);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 11891, 12222);
                    return return_v;
                }


                string
                f_1642_12924_12984()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginShutdownRegistrationFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 12924, 12984);
                    return return_v;
                }


                string
                f_1642_12906_12985(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 12906, 12985);
                    return return_v;
                }


                string
                f_1642_13101_13154()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginReportContextFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 13101, 13154);
                    return return_v;
                }


                string
                f_1642_13083_13155(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 13083, 13155);
                    return return_v;
                }


                System.InvalidOperationException
                f_1642_13275_13318(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 13275, 13318);
                    return return_v;
                }


                int
                f_1642_13337_13356(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 13337, 13356);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 10002, 13383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 10002, 13383);
            }
        }

        protected internal void SafeInvokeSessionClosed(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 13623, 13786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 13731, 13775);

                f_1642_13731_13774(SessionClosed, sender, eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 13623, 13786);

                int
                f_1642_13731_13774(System.EventHandler<System.EventArgs>
                eventHandler, object
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>(sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 13731, 13774);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 13623, 13786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 13623, 13786);
            }
        }

        internal void HandleTransportError(object sender, TransportErrorOccuredEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 13850, 14168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 13966, 13998);

                Exception
                reasonForClose = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14012, 14119) || true) && (eventArgs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 14012, 14119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14067, 14104);

                    reasonForClose = f_1642_14084_14103(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 14012, 14119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14135, 14157);

                f_1642_14135_14156(this, reasonForClose);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 13850, 14168);

                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1642_14084_14103(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 14084, 14103);
                    return return_v;
                }


                int
                f_1642_14135_14156(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 14135, 14156);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 13850, 14168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 13850, 14168);
            }
        }

        internal void HandlePrepareFromTransportManager(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 14253, 14544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14361, 14377);

                f_1642_14361_14376(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14391, 14421);

                f_1642_14391_14420(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14435, 14533);

                transportMgr.PrepareCalled -= new EventHandler<EventArgs>(this.HandlePrepareFromTransportManager);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 14253, 14544);

                int
                f_1642_14361_14376(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param)
                {
                    this_param.ReportContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 14361, 14376);
                    return 0;
                }


                int
                f_1642_14391_14420(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param)
                {
                    this_param.ReportSendOperationComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 14391, 14420);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 14253, 14544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 14253, 14544);
            }
        }

        internal void Close(bool isShuttingDown)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 14556, 15992);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14621, 15005) || true) && (f_1642_14625_14684(ref registeredShutdownNotification, 0) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 14621, 15005);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14785, 14990) || true) && (registeredShutDownWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 14785, 14990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14867, 14913);

                        f_1642_14867_14912(registeredShutDownWaitHandle, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 14935, 14971);

                        registeredShutDownWaitHandle = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 14785, 14990);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 14621, 15005);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 15280, 15379) || true) && (shutDownContext != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 15280, 15379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 15341, 15364);

                    shutDownContext = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 15280, 15379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 15395, 15531);

                transportMgr.WSManTransportErrorOccured -=
                                new EventHandler<TransportErrorOccuredEventArgs>(this.HandleTransportError);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 15733, 15763);

                creationRequestDetails = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 14556, 15992);

                int
                f_1642_14625_14684(ref int
                location1, int
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 14625, 14684);
                    return return_v;
                }


                bool
                f_1642_14867_14912(System.Threading.RegisteredWaitHandle
                this_param, System.Threading.WaitHandle?
                waitObject)
                {
                    var return_v = this_param.Unregister(waitObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 14867, 14912);
                    return return_v;
                }

                // if already disposing..no need to let finalizer thread
                // put resources to clean this object.
                // System.GC.SuppressFinalize(this); // TODO: This is already called in Dispose().
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 14556, 15992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 14556, 15992);
            }
        }

        internal void Close(Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 16084, 16400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 16154, 16189);

                lastErrorReported = reasonForClose;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 16203, 16335);

                WSManPluginOperationShutdownContext
                context = f_1642_16249_16334(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 16349, 16389);

                f_1642_16349_16388(this, context, reasonForClose);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 16084, 16400);

                System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                f_1642_16249_16334(System.IntPtr
                plgContext, System.IntPtr
                shContext, System.IntPtr
                cmdContext, bool
                isRcvOp)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginOperationShutdownContext(plgContext, shContext, cmdContext, isRcvOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 16249, 16334);
                    return return_v;
                }


                int
                f_1642_16349_16388(System.Management.Automation.Remoting.WSManPluginServerSession
                this_param, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context, System.Exception
                reasonForClose)
                {
                    this_param.CloseOperation(context, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 16349, 16388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 16084, 16400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 16084, 16400);
            }
        }

        internal void ReportSendOperationComplete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 16482, 16920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 16556, 16567);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 16601, 16894) || true) && (sendRequestDetails != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 16601, 16894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 16739, 16827);

                        f_1642_16739_16826(sendRequestDetails, lastErrorReported);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 16849, 16875);

                        sendRequestDetails = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 16601, 16894);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 16482, 16920);

                int
                f_1642_16739_16826(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 16739, 16826);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 16482, 16920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 16482, 16920);
            }
        }

        internal abstract void CloseOperation(WSManPluginOperationShutdownContext context, Exception reasonForClose);

        internal abstract void ExecuteConnect(
                    WSManNativeApi.WSManPluginRequest requestDetails, // in
                    int flags, // in
                    WSManNativeApi.WSManData_UnToMan inboundConnectInformation);

        static WSManPluginServerSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1642, 986, 17346);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1642, 986, 17346);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 986, 17346);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1642, 986, 17346);

        object
        f_1642_2562_2574()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 2562, 2574);
            return return_v;
        }


        int
        f_1642_5477_5491(System.Management.Automation.Remoting.WSManPluginServerSession
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 5477, 5491);
            return 0;
        }

    }
    internal class WSManPluginShellSession : WSManPluginServerSession
    {
        private Dictionary<IntPtr, WSManPluginCommandSession> _activeCommandSessions;

        private ServerRemoteSession _remoteSession;

        internal object shellSyncObject;

        internal WSManPluginShellSession(
                    WSManNativeApi.WSManPluginRequest creationRequestDetails,
                    WSManPluginServerTransportManager transportMgr,
                    ServerRemoteSession remoteSession,
                    WSManPluginOperationShutdownContext shutDownContext)
        : base(f_1642_18115_18137_C(creationRequestDetails), transportMgr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1642, 17815, 18562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 17564, 17586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 17625, 17639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 17736, 17751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 18177, 18208);

                _remoteSession = remoteSession;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 18222, 18355);

                _remoteSession.Closed +=
                                new EventHandler<RemoteSessionStateMachineEventArgs>(this.HandleServerRemoteSessionClosed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 18371, 18448);

                _activeCommandSessions = f_1642_18396_18447();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 18462, 18498);

                this.shellSyncObject = f_1642_18485_18497();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 18512, 18551);

                this.shutDownContext = shutDownContext;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1642, 17815, 18562);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 17815, 18562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 17815, 18562);
            }
        }

        internal override void ExecuteConnect(
                    WSManNativeApi.WSManPluginRequest requestDetails, // in
                    int flags, // in
                    WSManNativeApi.WSManData_UnToMan inboundConnectInformation) // in optional
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 19045, 21908);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 19295, 19773) || true) && (inboundConnectInformation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 19295, 19773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 19366, 19733);

                    f_1642_19366_19732(requestDetails, WSManPluginErrorCodes.NullInvalidInput, f_1642_19530_19731(f_1642_19574_19624(), "inboundConnectInformation", "WSManPluginShellConnect"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 19751, 19758);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 19295, 19773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 19874, 19907);

                IntPtr
                responseXml = IntPtr.Zero
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 19957, 19974);

                    byte[]
                    inputData
                    = default(byte[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 19992, 20010);

                    byte[]
                    outputData
                    = default(byte[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 20087, 20257);

                    inputData = f_1642_20099_20256(f_1642_20169_20199(inboundConnectInformation), WSManNativeApi.PS_CONNECT_XML_TAG);

                    // this will raise exceptions on failure
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 20379, 20436);

                        f_1642_20379_20435(_remoteSession, inputData, out outputData);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 20511, 20890);

                        string
                        responseData = f_1642_20533_20889(f_1642_20547_20596(), "<{0} xmlns=\"{1}\">{2}</{0}>", WSManNativeApi.PS_CONNECTRESPONSE_XML_TAG, WSManNativeApi.PS_XML_NAMESPACE, f_1642_20854_20888(outputData))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 21112, 21217);

                        f_1642_21112_21216(requestDetails, WSManPluginErrorCodes.NoError, responseData);
                    }
                    catch (PSRemotingDataStructureException ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1642, 21254, 21481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 21338, 21462);

                        f_1642_21338_21461(requestDetails, WSManPluginErrorCodes.PluginConnectOperationFailed, f_1642_21450_21460(ex));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1642, 21254, 21481);
                    }
                }
                catch (OutOfMemoryException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1642, 21510, 21681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 21571, 21666);

                    f_1642_21571_21665(requestDetails, WSManPluginErrorCodes.OutOfMemory);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1642, 21510, 21681);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1642, 21695, 21874);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 21735, 21859) || true) && (responseXml != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 21735, 21859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 21807, 21840);

                        f_1642_21807_21839(responseXml);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 21735, 21859);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1642, 21695, 21874);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 21890, 21897);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 19045, 21908);

                string
                f_1642_19574_19624()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 19574, 19624);
                    return return_v;
                }


                string
                f_1642_19530_19731(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 19530, 19731);
                    return return_v;
                }


                int
                f_1642_19366_19732(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 19366, 19732);
                    return 0;
                }


                string
                f_1642_20169_20199(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 20169, 20199);
                    return return_v;
                }


                byte[]
                f_1642_20099_20256(string
                xmlBuffer, string
                xmlTag)
                {
                    var return_v = ServerOperationHelpers.ExtractEncodedXmlElement(xmlBuffer, xmlTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 20099, 20256);
                    return return_v;
                }


                int
                f_1642_20379_20435(System.Management.Automation.Remoting.ServerRemoteSession
                this_param, byte[]
                connectData, out byte[]
                connectResponseData)
                {
                    this_param.ExecuteConnect(connectData, out connectResponseData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 20379, 20435);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1642_20547_20596()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 20547, 20596);
                    return return_v;
                }


                string
                f_1642_20854_20888(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 20854, 20888);
                    return return_v;
                }


                string
                f_1642_20533_20889(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 20533, 20889);
                    return return_v;
                }


                int
                f_1642_21112_21216(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 21112, 21216);
                    return 0;
                }


                string
                f_1642_21450_21460(System.Management.Automation.Remoting.PSRemotingDataStructureException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 21450, 21460);
                    return return_v;
                }


                int
                f_1642_21338_21461(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 21338, 21461);
                    return 0;
                }


                int
                f_1642_21571_21665(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 21571, 21665);
                    return 0;
                }


                int
                f_1642_21807_21839(System.IntPtr
                hglobal)
                {
                    Marshal.FreeHGlobal(hglobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 21807, 21839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 19045, 21908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 19045, 21908);
            }
        }

        internal void CreateCommand(
                    IntPtr pluginContext,
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    string commandLine,
                    WSManNativeApi.WSManCommandArgSet arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 21975, 24514);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 22370, 22482);

                    WSManPluginCommandTransportManager
                    serverCmdTransportMgr = f_1642_22429_22481(transportMgr)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 22500, 22535);

                    f_1642_22500_22534(serverCmdTransportMgr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 22627, 22701);

                    f_1642_22627_22700(
                                    // Apply quota limits on the command transport manager
                                    _remoteSession, serverCmdTransportMgr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 22721, 22848);

                    WSManPluginCommandSession
                    mgdCmdSession = f_1642_22763_22847(requestDetails, serverCmdTransportMgr, _remoteSession)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 22866, 22904);

                    f_1642_22866_22903(this, mgdCmdSession);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 22922, 23014);

                    mgdCmdSession.SessionClosed += new EventHandler<EventArgs>(this.HandleCommandSessionClosed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 23034, 23307);

                    mgdCmdSession.shutDownContext = f_1642_23066_23306(pluginContext, creationRequestDetails.unmanagedHandle, mgdCmdSession.creationRequestDetails.unmanagedHandle, false);
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 23327, 24006);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 23370, 23863) || true) && (!f_1642_23375_23416(mgdCmdSession, arguments))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 23370, 23863);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 23466, 23808);

                                    f_1642_23466_23807(requestDetails, WSManPluginErrorCodes.InvalidArgSet, f_1642_23651_23806(f_1642_23703_23750(), "WSManPluginCommand"));
                                    DynAbs.Tracing.TraceSender.TraceBreak(1642, 23834, 23840);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 23370, 23863);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 23942, 23972);

                                f_1642_23942_23971(
                                                    // Report plugin context to WSMan
                                                    mgdCmdSession);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 23327, 24006);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 23327, 24006) || true) && (false)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1642, 23327, 24006);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1642, 23327, 24006);
                        }
                    }
                }
                catch (System.Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1642, 24035, 24503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 24191, 24488);

                    f_1642_24191_24487(requestDetails, WSManPluginErrorCodes.ManagedException, f_1642_24355_24486(f_1642_24399_24449(), f_1642_24476_24485(e)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1642, 24035, 24503);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 21975, 24514);

                System.Management.Automation.Remoting.WSManPluginCommandTransportManager
                f_1642_22429_22481(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                srvrTransportMgr)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginCommandTransportManager(srvrTransportMgr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 22429, 22481);
                    return return_v;
                }


                int
                f_1642_22500_22534(System.Management.Automation.Remoting.WSManPluginCommandTransportManager
                this_param)
                {
                    this_param.Initialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 22500, 22534);
                    return 0;
                }


                int
                f_1642_22627_22700(System.Management.Automation.Remoting.ServerRemoteSession
                this_param, System.Management.Automation.Remoting.WSManPluginCommandTransportManager
                cmdTransportManager)
                {
                    this_param.ApplyQuotaOnCommandTransportManager((System.Management.Automation.Remoting.Server.AbstractServerTransportManager)cmdTransportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 22627, 22700);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginCommandSession
                f_1642_22763_22847(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                creationRequestDetails, System.Management.Automation.Remoting.WSManPluginCommandTransportManager
                transportMgr, System.Management.Automation.Remoting.ServerRemoteSession
                remoteSession)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginCommandSession(creationRequestDetails, (System.Management.Automation.Remoting.WSManPluginServerTransportManager)transportMgr, remoteSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 22763, 22847);
                    return return_v;
                }


                int
                f_1642_22866_22903(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Management.Automation.Remoting.WSManPluginCommandSession
                newCmdSession)
                {
                    this_param.AddToActiveCmdSessions(newCmdSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 22866, 22903);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                f_1642_23066_23306(System.IntPtr
                plgContext, System.IntPtr
                shContext, System.IntPtr
                cmdContext, bool
                isRcvOp)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginOperationShutdownContext(plgContext, shContext, cmdContext, isRcvOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 23066, 23306);
                    return return_v;
                }


                bool
                f_1642_23375_23416(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet
                arguments)
                {
                    var return_v = this_param.ProcessArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 23375, 23416);
                    return return_v;
                }


                string
                f_1642_23703_23750()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidArgSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 23703, 23750);
                    return return_v;
                }


                string
                f_1642_23651_23806(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 23651, 23806);
                    return return_v;
                }


                int
                f_1642_23466_23807(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 23466, 23807);
                    return 0;
                }


                int
                f_1642_23942_23971(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param)
                {
                    this_param.ReportContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 23942, 23971);
                    return 0;
                }


                string
                f_1642_24399_24449()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginManagedException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 24399, 24449);
                    return return_v;
                }


                string
                f_1642_24476_24485(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 24476, 24485);
                    return return_v;
                }


                string
                f_1642_24355_24486(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 24355, 24486);
                    return return_v;
                }


                int
                f_1642_24191_24487(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 24191, 24487);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 21975, 24514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 21975, 24514);
            }
        }

        internal void CloseCommandOperation(
                    WSManPluginOperationShutdownContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 24589, 25304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 24708, 24792);

                WSManPluginCommandSession
                mgdCmdSession = f_1642_24750_24791(this, context.commandContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 24806, 24969) || true) && (mgdCmdSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 24806, 24969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 24947, 24954);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 24806, 24969);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25071, 25233) || true) && (!context.isReceiveOperation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 25071, 25233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25136, 25218);

                    f_1642_25136_25217(this, mgdCmdSession.creationRequestDetails.unmanagedHandle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 25071, 25233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25249, 25293);

                f_1642_25249_25292(
                            mgdCmdSession, context, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 24589, 25304);

                System.Management.Automation.Remoting.WSManPluginCommandSession
                f_1642_24750_24791(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.IntPtr
                cmdContext)
                {
                    var return_v = this_param.GetCommandSession(cmdContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 24750, 24791);
                    return return_v;
                }


                int
                f_1642_25136_25217(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.IntPtr
                keyToDelete)
                {
                    this_param.DeleteFromActiveCmdSessions(keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 25136, 25217);
                    return 0;
                }


                int
                f_1642_25249_25292(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context, System.Exception
                reasonForClose)
                {
                    this_param.CloseOperation(context, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 25249, 25292);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 24589, 25304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 24589, 25304);
            }
        }

        private void AddToActiveCmdSessions(
                    WSManPluginCommandSession newCmdSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 25444, 26095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25565, 25580);
                lock (shellSyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25614, 25694) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 25614, 25694);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25668, 25675);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 25614, 25694);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25714, 25780);

                    IntPtr
                    key = newCmdSession.creationRequestDetails.unmanagedHandle
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25798, 25868);

                    f_1642_25798_25867(IntPtr.Zero != key, "NULL handles should not be provided");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25888, 26069) || true) && (!f_1642_25893_25932(_activeCommandSessions, key))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 25888, 26069);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 25974, 26021);

                        f_1642_25974_26020(_activeCommandSessions, key, newCmdSession);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26043, 26050);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 25888, 26069);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 25444, 26095);

                int
                f_1642_25798_25867(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 25798, 25867);
                    return 0;
                }


                bool
                f_1642_25893_25932(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 25893, 25932);
                    return return_v;
                }


                int
                f_1642_25974_26020(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param, System.IntPtr
                key, System.Management.Automation.Remoting.WSManPluginCommandSession
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 25974, 26020);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 25444, 26095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 25444, 26095);
            }
        }

        private void DeleteFromActiveCmdSessions(
                    IntPtr keyToDelete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 26107, 26430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26212, 26227);
                lock (shellSyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26261, 26341) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 26261, 26341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26315, 26322);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 26261, 26341);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26361, 26404);

                    f_1642_26361_26403(
                                    _activeCommandSessions, keyToDelete);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 26107, 26430);

                bool
                f_1642_26361_26403(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 26361, 26403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 26107, 26430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 26107, 26430);
            }
        }

        private void CloseAndClearCommandSessions(
                    Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 26494, 27791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26600, 26700);

                Collection<WSManPluginCommandSession>
                copyCmdSessions = f_1642_26656_26699()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26720, 26735);
                lock (shellSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26769, 26881);

                    Dictionary<IntPtr, WSManPluginCommandSession>.Enumerator
                    cmdEnumerator = f_1642_26842_26880(_activeCommandSessions)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26899, 27040) || true) && (cmdEnumerator.MoveNext())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 26899, 27040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 26972, 27021);

                            f_1642_26972_27020(copyCmdSessions, cmdEnumerator.Current.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 26899, 27040);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1642, 26899, 27040);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1642, 26899, 27040);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 27060, 27091);

                    f_1642_27060_27090(
                                    _activeCommandSessions);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 27185, 27279);

                IEnumerator<WSManPluginCommandSession>
                cmdSessionEnumerator = f_1642_27247_27278(copyCmdSessions)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 27293, 27740) || true) && (f_1642_27300_27331(cmdSessionEnumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 27293, 27740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 27365, 27433);

                        WSManPluginCommandSession
                        cmdSession = f_1642_27404_27432(cmdSessionEnumerator)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 27585, 27674);

                        cmdSession.SessionClosed -= new EventHandler<EventArgs>(this.HandleCommandSessionClosed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 27692, 27725);

                        f_1642_27692_27724(cmdSession, reasonForClose);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 27293, 27740);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1642, 27293, 27740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1642, 27293, 27740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 27756, 27780);

                f_1642_27756_27779(
                            copyCmdSessions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 26494, 27791);

                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.WSManPluginCommandSession>
                f_1642_26656_26699()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.WSManPluginCommandSession>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 26656, 26699);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>.Enumerator
                f_1642_26842_26880(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 26842, 26880);
                    return return_v;
                }


                int
                f_1642_26972_27020(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param, System.Management.Automation.Remoting.WSManPluginCommandSession
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 26972, 27020);
                    return 0;
                }


                int
                f_1642_27060_27090(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 27060, 27090);
                    return 0;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.Remoting.WSManPluginCommandSession>
                f_1642_27247_27278(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 27247, 27278);
                    return return_v;
                }


                bool
                f_1642_27300_27331(System.Collections.Generic.IEnumerator<System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 27300, 27331);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginCommandSession
                f_1642_27404_27432(System.Collections.Generic.IEnumerator<System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 27404, 27432);
                    return return_v;
                }


                int
                f_1642_27692_27724(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 27692, 27724);
                    return 0;
                }


                int
                f_1642_27756_27779(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 27756, 27779);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 26494, 27791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 26494, 27791);
            }
        }

        internal WSManPluginCommandSession GetCommandSession(
                    IntPtr cmdContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 27907, 28247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28023, 28038);
                lock (shellSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28072, 28112);

                    WSManPluginCommandSession
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28130, 28189);

                    f_1642_28130_28188(_activeCommandSessions, cmdContext, out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28207, 28221);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 27907, 28247);

                bool
                f_1642_28130_28188(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>
                this_param, System.IntPtr
                key, out System.Management.Automation.Remoting.WSManPluginCommandSession
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 28130, 28188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 27907, 28247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 27907, 28247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleServerRemoteSessionClosed(
                    object sender,
                    RemoteSessionStateMachineEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 28259, 28615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28416, 28448);

                Exception
                reasonForClose = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28462, 28566) || true) && (eventArgs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 28462, 28566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28517, 28551);

                    reasonForClose = f_1642_28534_28550(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 28462, 28566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28582, 28604);

                f_1642_28582_28603(this, reasonForClose);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 28259, 28615);

                System.Exception
                f_1642_28534_28550(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1642, 28534, 28550);
                    return return_v;
                }


                int
                f_1642_28582_28603(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 28582, 28603);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 28259, 28615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 28259, 28615);
            }
        }

        private void HandleCommandSessionClosed(
                    object source,
                    EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 28627, 28865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 28810, 28854);

                f_1642_28810_28853(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 28627, 28865);

                int
                f_1642_28810_28853(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, object
                keyToDelete)
                {
                    this_param.DeleteFromActiveCmdSessions((System.IntPtr)keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 28810, 28853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 28627, 28865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 28627, 28865);
            }
        }

        internal override void CloseOperation(
                    WSManPluginOperationShutdownContext context,
                    Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 28877, 30812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29090, 29105);
                // let command sessions to close.
                lock (shellSyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29139, 29227) || true) && (true == isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 29139, 29227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29201, 29208);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 29139, 29227);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29247, 29355) || true) && (!context.isReceiveOperation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 29247, 29355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29320, 29336);

                        isClosed = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 29247, 29355);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29386, 29450);

                f_1642_29386_29449(creationRequestDetails);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29466, 29550);

                bool
                isRcvOpShuttingDown = (context.isShuttingDown) && (DynAbs.Tracing.TraceSender.Expression_True(1642, 29493, 29549) && (context.isReceiveOperation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29564, 29606);

                bool
                isRcvOp = context.isReceiveOperation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29620, 29665);

                bool
                isShuttingDown = context.isShuttingDown
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29737, 29767);

                f_1642_29737_29766(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29870, 29928);

                f_1642_29870_29927(            // close the shell's transport manager after commands handled the operation
                            transportMgr, isRcvOpShuttingDown, reasonForClose);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 29944, 30754) || true) && (!isRcvOp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 29944, 30754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 30131, 30176);

                    f_1642_30131_30175(this, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 30383, 30469);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SafeInvokeSessionClosed(creationRequestDetails.unmanagedHandle, EventArgs.Empty), 1642, 30383, 30468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 30548, 30637);

                    f_1642_30548_30636(creationRequestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 30712, 30739);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Close(isShuttingDown), 1642, 30712, 30738);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 29944, 30754);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 28877, 30812);

                int
                f_1642_29386_29449(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    WSManPluginInstance.SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 29386, 29449);
                    return 0;
                }


                int
                f_1642_29737_29766(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param)
                {
                    this_param.ReportSendOperationComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 29737, 29766);
                    return 0;
                }


                int
                f_1642_29870_29927(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, bool
                isShuttingDown, System.Exception
                reasonForClose)
                {
                    this_param.DoClose(isShuttingDown, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 29870, 29927);
                    return 0;
                }


                int
                f_1642_30131_30175(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.CloseAndClearCommandSessions(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 30131, 30175);
                    return 0;
                }


                int
                f_1642_30548_30636(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 30548, 30636);
                    return 0;
                }

                // TODO: Do this.Dispose(); here?
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 28877, 30812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 28877, 30812);
            }
        }

        static WSManPluginShellSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1642, 17393, 30819);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1642, 17393, 30819);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 17393, 30819);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1642, 17393, 30819);

        System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>
        f_1642_18396_18447()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginCommandSession>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 18396, 18447);
            return return_v;
        }


        object
        f_1642_18485_18497()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 18485, 18497);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
        f_1642_18115_18137_C(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1642, 17815, 18562);
            return return_v;
        }

    }
    internal class WSManPluginCommandSession : WSManPluginServerSession
    {
        private ServerRemoteSession _remoteSession;

        internal object cmdSyncObject;

        internal WSManPluginCommandSession(
                    WSManNativeApi.WSManPluginRequest creationRequestDetails,
                    WSManPluginServerTransportManager transportMgr,
                    ServerRemoteSession remoteSession)
        : base(f_1642_31400_31422_C(creationRequestDetails), transportMgr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1642, 31164, 31547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 30974, 30988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31085, 31098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31462, 31493);

                _remoteSession = remoteSession;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31507, 31536);

                cmdSyncObject = f_1642_31523_31535();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1642, 31164, 31547);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 31164, 31547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 31164, 31547);
            }
        }

        internal bool ProcessArguments(
                    WSManNativeApi.WSManCommandArgSet arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 31581, 32011);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31695, 31785) || true) && (1 != arguments.argsCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 31695, 31785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31757, 31770);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 31695, 31785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31801, 31870);

                byte[]
                convertedBase64 = f_1642_31826_31869(arguments.args[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31884, 31972);

                f_1642_31884_31971(transportMgr, convertedBase64, WSManPluginConstants.SupportedInputStream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 31988, 32000);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 31581, 32011);

                byte[]
                f_1642_31826_31869(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 31826, 31869);
                    return return_v;
                }


                int
                f_1642_31884_31971(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 31884, 31971);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 31581, 32011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 31581, 32011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Stop(
                    WSManNativeApi.WSManPluginRequest requestDetails)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 32121, 32471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32348, 32375);

                f_1642_32348_32374(            // stop the command..command will be stoped if we raise ClosingEvent on
                                               // transport manager.
                            transportMgr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32389, 32460);

                f_1642_32389_32459(requestDetails, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 32121, 32471);

                int
                f_1642_32348_32374(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param)
                {
                    this_param.PerformStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 32348, 32374);
                    return 0;
                }


                int
                f_1642_32389_32459(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 32389, 32459);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 32121, 32471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 32121, 32471);
            }
        }

        internal override void CloseOperation(
                    WSManPluginOperationShutdownContext context,
                    Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 32483, 34454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32696, 32709);
                // let command sessions to close.
                lock (cmdSyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32743, 32831) || true) && (true == isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 32743, 32831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32805, 32812);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 32743, 32831);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32851, 32959) || true) && (!context.isReceiveOperation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 32851, 32959);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32924, 32940);

                        isClosed = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 32851, 32959);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 32990, 33054);

                f_1642_32990_33053(creationRequestDetails);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 33070, 33112);

                bool
                isRcvOp = context.isReceiveOperation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 33172, 33360);

                bool
                isRcvOpShuttingDown = (context.isShuttingDown) && (DynAbs.Tracing.TraceSender.Expression_True(1642, 33199, 33272) && (context.isReceiveOperation)) && (DynAbs.Tracing.TraceSender.Expression_True(1642, 33199, 33359) && (context.commandContext == creationRequestDetails.unmanagedHandle))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 33376, 33563);

                bool
                isCmdShuttingDown = (context.isShuttingDown) && (DynAbs.Tracing.TraceSender.Expression_True(1642, 33401, 33475) && (!context.isReceiveOperation)) && (DynAbs.Tracing.TraceSender.Expression_True(1642, 33401, 33562) && (context.commandContext == creationRequestDetails.unmanagedHandle))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 33635, 33665);

                f_1642_33635_33664(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 33760, 33818);

                f_1642_33760_33817(            // close the shell's transport manager first..so we wont send data.
                            transportMgr, isRcvOpShuttingDown, reasonForClose);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 33834, 34443) || true) && (!isRcvOp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1642, 33834, 34443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 34069, 34155);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SafeInvokeSessionClosed(creationRequestDetails.unmanagedHandle, EventArgs.Empty), 1642, 34069, 34154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 34234, 34323);

                    f_1642_34234_34322(creationRequestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 34398, 34428);

                    f_1642_34398_34427(                // let base class release its resources
                                    this, isCmdShuttingDown);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1642, 33834, 34443);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 32483, 34454);

                int
                f_1642_32990_33053(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    WSManPluginInstance.SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 32990, 33053);
                    return 0;
                }


                int
                f_1642_33635_33664(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param)
                {
                    this_param.ReportSendOperationComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 33635, 33664);
                    return 0;
                }


                int
                f_1642_33760_33817(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, bool
                isShuttingDown, System.Exception
                reasonForClose)
                {
                    this_param.DoClose(isShuttingDown, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 33760, 33817);
                    return 0;
                }


                int
                f_1642_34234_34322(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 34234, 34322);
                    return 0;
                }


                int
                f_1642_34398_34427(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, bool
                isShuttingDown)
                {
                    this_param.Close(isShuttingDown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 34398, 34427);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 32483, 34454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 32483, 34454);
            }
        }

        internal override void ExecuteConnect(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    WSManNativeApi.WSManData_UnToMan inboundConnectInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1642, 34907, 35288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 35130, 35256);

                f_1642_35130_35255(requestDetails, WSManPluginErrorCodes.NoError);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1642, 35270, 35277);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1642, 34907, 35288);

                int
                f_1642_35130_35255(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 35130, 35255);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1642, 34907, 35288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 34907, 35288);
            }
        }

        static WSManPluginCommandSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1642, 30827, 35295);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1642, 30827, 35295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1642, 30827, 35295);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1642, 30827, 35295);

        object
        f_1642_31523_31535()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1642, 31523, 31535);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
        f_1642_31400_31422_C(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1642, 31164, 31547);
            return return_v;
        }

    }
}
