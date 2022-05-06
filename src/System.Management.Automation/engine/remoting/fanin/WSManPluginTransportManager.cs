// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ----------------------------------------------------------------------
//  Contents:  Entry points for managed PowerShell plugin worker used to
//  host powershell in a WSMan service.
// ----------------------------------------------------------------------

using System.Threading;
using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Remoting.Server;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;

namespace System.Management.Automation.Remoting
{
    internal class WSManPluginServerTransportManager : AbstractServerSessionTransportManager
    {
        private WSManNativeApi.WSManPluginRequest _requestDetails;

        private bool _isRequestPending;

        private object _syncObject;

        private ManualResetEvent _waitHandle;

        private Dictionary<Guid, WSManPluginServerTransportManager> _activeCmdTransportManagers;

        private bool _isClosed;

        private Exception _lastErrorReported;

        private WSManPluginOperationShutdownContext _shutDownContext;

        private RegisteredWaitHandle _registeredShutDownWaitHandle;

        // event that gets raised when Prepare is called. Respective Session
        // object can use this callback to ReportContext to client.
        public event EventHandler<EventArgs>
PrepareCalled
;

        internal WSManPluginServerTransportManager(
                    int fragmentSize,
                    PSRemotingCryptoHelper cryptoHelper)
        : base(f_1643_2196_2208_C(fragmentSize), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1643, 2051, 2444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 858, 873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1046, 1063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1089, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1136, 1147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1218, 1245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1269, 1278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1426, 1444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1603, 1619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 1768, 1797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 2248, 2275);

                _syncObject = f_1643_2262_2274();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 2289, 2377);

                _activeCmdTransportManagers = f_1643_2319_2376();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 2391, 2433);

                _waitHandle = f_1643_2405_2432(false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1643, 2051, 2444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 2051, 2444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 2051, 2444);
            }
        }

        internal override void Close(
                    Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 2548, 2683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 2641, 2672);

                f_1643_2641_2671(this, false, reasonForClose);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 2548, 2683);

                int
                f_1643_2641_2671(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, bool
                isShuttingDown, System.Exception
                reasonForClose)
                {
                    this_param.DoClose(isShuttingDown, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 2641, 2671);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 2548, 2683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 2548, 2683);
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", Justification = "The WSManPluginReceiveResult return value is not documented and is not needed in this case.")]
        internal void DoClose(
                    bool isShuttingDown,
                    Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 3018, 6267);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3330, 3399) || true) && (_isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 3330, 3399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3377, 3384);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 3330, 3399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3421, 3432);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3466, 3547) || true) && (_isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 3466, 3547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3521, 3528);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 3466, 3547);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3567, 3584);

                    _isClosed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3602, 3638);

                    _lastErrorReported = reasonForClose;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3658, 3844) || true) && (!_isRequestPending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 3658, 3844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 3807, 3825);

                        f_1643_3807_3824(                    // release threads blocked on the sending data to client if any
                                            _waitHandle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 3658, 3844);
                    }
                }

                // only one thread will reach here

                // let everyone know that we are about to close
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4022, 4042);

                    f_1643_4022_4041(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4062, 4226);
                        foreach (var cmdTransportKvp in f_1643_4094_4121_I(_activeCmdTransportManagers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 4062, 4226);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4163, 4207);

                            f_1643_4163_4206(cmdTransportKvp.Value, reasonForClose);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 4062, 4226);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1643, 1, 165);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1643, 1, 165);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4246, 4282);

                    f_1643_4246_4281(
                                    _activeCmdTransportManagers);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4302, 4583) || true) && (_registeredShutDownWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 4302, 4583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4458, 4505);

                        f_1643_4458_4504(                    // This will not wait for the callback to complete.
                                            _registeredShutDownWaitHandle, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4527, 4564);

                        _registeredShutDownWaitHandle = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 4302, 4583);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4874, 4987) || true) && (_shutDownContext != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 4874, 4987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 4944, 4968);

                        _shutDownContext = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 4874, 4987);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 5134, 6112) || true) && (_requestDetails != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 5134, 6112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 5285, 5687);

                        f_1643_5285_5686(_requestDetails.unmanagedHandle, WSManNativeApi.WSManFlagReceive.WSMAN_FLAG_RECEIVE_RESULT_NO_MORE_DATA, WSManPluginConstants.SupportedOutputStream, IntPtr.Zero, WSManNativeApi.WSMAN_COMMAND_STATE_DONE, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 5711, 5793);

                        f_1643_5711_5792(_requestDetails, reasonForClose);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6070, 6093);

                        _requestDetails = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 5134, 6112);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1643, 6141, 6256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6219, 6241);

                    f_1643_6219_6240(                // dispose resources
                                    _waitHandle);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1643, 6141, 6256);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 3018, 6267);

                bool
                f_1643_3807_3824(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 3807, 3824);
                    return return_v;
                }


                int
                f_1643_4022_4041(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param)
                {
                    this_param.RaiseClosingEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 4022, 4041);
                    return 0;
                }


                int
                f_1643_4163_4206(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 4163, 4206);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
                f_1643_4094_4121_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 4094, 4121);
                    return return_v;
                }


                int
                f_1643_4246_4281(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 4246, 4281);
                    return 0;
                }


                bool
                f_1643_4458_4504(System.Threading.RegisteredWaitHandle
                this_param, System.Threading.WaitHandle?
                waitObject)
                {
                    var return_v = this_param.Unregister(waitObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 4458, 4504);
                    return return_v;
                }


                int
                f_1643_5285_5686(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManFlagReceive
                flags, string
                stream, System.IntPtr
                streamResult, string
                commandState, int
                exitCode)
                {
                    var return_v = WSManNativeApi.WSManPluginReceiveResult(requestDetails, (int)flags, stream, streamResult, commandState, exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 5285, 5686);
                    return return_v;
                }


                int
                f_1643_5711_5792(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 5711, 5792);
                    return 0;
                }


                int
                f_1643_6219_6240(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 6219, 6240);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 3018, 6267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 3018, 6267);
            }
        }

        internal override void ReportExecutionStatusAsRunning()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 6455, 7383);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6535, 6612) || true) && (true == _isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 6535, 6612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6590, 6597);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 6535, 6612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6628, 6676);

                int
                result = (int)WSManPluginErrorCodes.NoError
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6774, 6785);

                // there should have been a receive request in place already

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6819, 7196) || true) && (!_isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 6819, 7196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 6875, 7177);

                        result = f_1643_6884_7176(_requestDetails.unmanagedHandle, 0, null, IntPtr.Zero, WSManNativeApi.WSMAN_COMMAND_STATE_RUNNING, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 6819, 7196);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 7227, 7372) || true) && ((int)WSManPluginErrorCodes.NoError != result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 7227, 7372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 7309, 7357);

                    f_1643_7309_7356(this, result, "WSManPluginReceiveResult");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 7227, 7372);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 6455, 7383);

                int
                f_1643_6884_7176(System.IntPtr
                requestDetails, int
                flags, string
                stream, System.IntPtr
                streamResult, string
                commandState, int
                exitCode)
                {
                    var return_v = WSManNativeApi.WSManPluginReceiveResult(requestDetails, flags, stream, streamResult, commandState, exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 6884, 7176);
                    return return_v;
                }


                int
                f_1643_7309_7356(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, int
                errorCode, string
                methodName)
                {
                    this_param.ReportError(errorCode, methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 7309, 7356);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 6455, 7383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 6455, 7383);
            }
        }

        protected override void SendDataToClient(
                    byte[] data,
                    bool flush,
                    bool reportAsPending,
                    bool reportAsDataBoundary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 7806, 10415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 7998, 8075) || true) && (true == _isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 7998, 8075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 8053, 8060);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 7998, 8075);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 8258, 8735) || true) && (!_isRequestPending)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 8258, 8735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 8534, 8556);

                    f_1643_8534_8555(                // Dont send data until we have received request from client.
                                                     // The following blocks the calling thread. The thread is
                                                     // unblocked once a request from client arrives.
                                    _waitHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 8574, 8599);

                    _isRequestPending = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 8698, 8720);

                    f_1643_8698_8719(                // at this point request must be pending..so dispose waitHandle
                                    _waitHandle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 8258, 8735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 8751, 8799);

                int
                result = (int)WSManPluginErrorCodes.NoError
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 8950, 10243);
                using (WSManNativeApi.WSManData_ManToUn
                dataToBeSent = f_1643_9005_9047(data)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9087, 9098);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9140, 10209) || true) && (!_isClosed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 9140, 10209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9204, 9218);

                            int
                            flags = 0
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9244, 9355) || true) && (flush)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 9244, 9355);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9284, 9355);

                                flags |= (int)WSManNativeApi.WSManFlagReceive.WSMAN_FLAG_RECEIVE_FLUSH;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 9244, 9355);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9381, 9764) || true) && (reportAsDataBoundary)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 9381, 9764);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9678, 9764);

                                flags |= (int)WSManNativeApi.WSManFlagReceive.WSMAN_FLAG_RECEIVE_RESULT_DATA_BOUNDARY;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 9381, 9764);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 9792, 10186);

                            result = f_1643_9801_10185(_requestDetails.unmanagedHandle, flags, WSManPluginConstants.SupportedOutputStream, dataToBeSent, (DynAbs.Tracing.TraceSender.Conditional_F1(1643, 10085, 10100) || ((reportAsPending && DynAbs.Tracing.TraceSender.Conditional_F2(1643, 10103, 10145)) || DynAbs.Tracing.TraceSender.Conditional_F3(1643, 10148, 10152))) ? WSManNativeApi.WSMAN_COMMAND_STATE_PENDING : null, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 9140, 10209);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1643, 8950, 10243);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 10259, 10404) || true) && ((int)WSManPluginErrorCodes.NoError != result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 10259, 10404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 10341, 10389);

                    f_1643_10341_10388(this, result, "WSManPluginReceiveResult");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 10259, 10404);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 7806, 10415);

                bool
                f_1643_8534_8555(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 8534, 8555);
                    return return_v;
                }


                int
                f_1643_8698_8719(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 8698, 8719);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                f_1643_9005_9047(byte[]
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 9005, 9047);
                    return return_v;
                }


                int
                f_1643_9801_10185(System.IntPtr
                requestDetails, int
                flags, string
                stream, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                streamResult, string
                commandState, int
                exitCode)
                {
                    var return_v = WSManNativeApi.WSManPluginReceiveResult(requestDetails, flags, stream, (System.IntPtr)streamResult, commandState, exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 9801, 10185);
                    return return_v;
                }


                int
                f_1643_10341_10388(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, int
                errorCode, string
                methodName)
                {
                    this_param.ReportError(errorCode, methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 10341, 10388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 7806, 10415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 7806, 10415);
            }
        }

        internal override void Prepare()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 10427, 10788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 10535, 10550);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Prepare(), 1643, 10535, 10549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 10740, 10777);

                f_1643_10740_10776(PrepareCalled, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 10427, 10788);

                int
                f_1643_10740_10776(System.EventHandler<System.EventArgs>
                this_param, System.Management.Automation.Remoting.WSManPluginServerTransportManager
                sender, System.EventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 10740, 10776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 10427, 10788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 10427, 10788);
            }
        }

        internal override AbstractServerTransportManager GetCommandTransportManager(
                    Guid powerShellCmdId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 10932, 11131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11068, 11120);

                return f_1643_11075_11119(_activeCmdTransportManagers, powerShellCmdId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 10932, 11131);

                System.Management.Automation.Remoting.WSManPluginServerTransportManager
                f_1643_11075_11119(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
                this_param, System.Guid
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 11075, 11119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 10932, 11131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 10932, 11131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReportTransportMgrForCmd(
                    Guid cmdId,
                    WSManPluginServerTransportManager transportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 11243, 11744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11403, 11414);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11448, 11529) || true) && (_isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 11448, 11529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11503, 11510);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 11448, 11529);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11549, 11718) || true) && (!f_1643_11554_11600(_activeCmdTransportManagers, cmdId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 11549, 11718);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11642, 11699);

                        f_1643_11642_11698(_activeCmdTransportManagers, cmdId, transportManager);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 11549, 11718);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 11243, 11744);

                bool
                f_1643_11554_11600(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 11554, 11600);
                    return return_v;
                }


                int
                f_1643_11642_11698(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
                this_param, System.Guid
                key, System.Management.Automation.Remoting.WSManPluginServerTransportManager
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 11642, 11698);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 11243, 11744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 11243, 11744);
            }
        }

        internal override void RemoveCommandTransportManager(
                    Guid cmdId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 11756, 12079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11865, 11876);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11910, 11991) || true) && (_isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 11910, 11991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 11965, 11972);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 11910, 11991);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12011, 12053);

                    f_1643_12011_12052(
                                    _activeCmdTransportManagers, cmdId);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 11756, 12079);

                bool
                f_1643_12011_12052(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 12011, 12052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 11756, 12079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 11756, 12079);
            }
        }

        internal bool EnableTransportManagerSendDataToClient(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    WSManPluginOperationShutdownContext ctxtToReport)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 12109, 14930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12313, 12345);

                _shutDownContext = ctxtToReport;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12359, 12410);

                bool
                isRegisterWaitForSingleObjectSucceeded = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12430, 12441);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12475, 12809) || true) && (_isRequestPending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 12475, 12809);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12608, 12755);

                        f_1643_12608_12754(requestDetails, WSManPluginErrorCodes.NoError);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12777, 12790);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 12475, 12809);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12829, 13023) || true) && (_isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 12829, 13023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12884, 12969);

                        f_1643_12884_12968(requestDetails, _lastErrorReported);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 12991, 13004);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 12829, 13023);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 13043, 13068);

                    _isRequestPending = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 13086, 13119);

                    _requestDetails = requestDetails;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 13139, 14275) || true) && (f_1643_13143_13161())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 13139, 14275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 13301, 13402);

                        SafeWaitHandle
                        safeWaitHandle = f_1643_13333_13401(f_1643_13352_13393(requestDetails), false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 13442, 13529);

                        EventWaitHandle
                        eventWaitHandle = f_1643_13476_13528(false, EventResetMode.AutoReset)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 13551, 13599);

                        eventWaitHandle.SafeWaitHandle = safeWaitHandle;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 13623, 13988);

                        _registeredShutDownWaitHandle = f_1643_13655_13987(eventWaitHandle, new WaitOrTimerCallback(WSManPluginManagedEntryWrapper.PSPluginOperationShutdownCallback), _shutDownContext, -1, true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14095, 14256) || true) && (_registeredShutDownWaitHandle == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 14095, 14256);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14186, 14233);

                            isRegisterWaitForSingleObjectSucceeded = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 14095, 14256);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 13139, 14275);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14364, 14382);

                    f_1643_14364_14381(                // release thread waiting to send data to the client.
                                    _waitHandle);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14413, 14891) || true) && (!isRegisterWaitForSingleObjectSucceeded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 14413, 14891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14490, 14546);

                    f_1643_14490_14545(ctxtToReport);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14564, 14845);

                    f_1643_14564_14844(requestDetails, WSManPluginErrorCodes.ShutdownRegistrationFailed, f_1643_14738_14843(f_1643_14782_14842()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14863, 14876);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 14413, 14891);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 14907, 14919);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 12109, 14930);

                int
                f_1643_12608_12754(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 12608, 12754);
                    return 0;
                }


                int
                f_1643_12884_12968(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Exception
                reasonForClose)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 12884, 12968);
                    return 0;
                }


                bool
                f_1643_13143_13161()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 13143, 13161);
                    return return_v;
                }


                System.IntPtr
                f_1643_13352_13393(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.shutdownNotificationHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 13352, 13393);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeWaitHandle
                f_1643_13333_13401(System.IntPtr
                existingHandle, bool
                ownsHandle)
                {
                    var return_v = new Microsoft.Win32.SafeHandles.SafeWaitHandle(existingHandle, ownsHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 13333, 13401);
                    return return_v;
                }


                System.Threading.EventWaitHandle
                f_1643_13476_13528(bool
                initialState, System.Threading.EventResetMode
                mode)
                {
                    var return_v = new System.Threading.EventWaitHandle(initialState, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 13476, 13528);
                    return return_v;
                }


                System.Threading.RegisteredWaitHandle
                f_1643_13655_13987(System.Threading.EventWaitHandle
                waitObject, System.Threading.WaitOrTimerCallback
                callBack, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                state, int
                millisecondsTimeOutInterval, bool
                executeOnlyOnce)
                {
                    var return_v = ThreadPool.RegisterWaitForSingleObject((System.Threading.WaitHandle)waitObject, callBack, (object)state, millisecondsTimeOutInterval, executeOnlyOnce);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 13655, 13987);
                    return return_v;
                }


                bool
                f_1643_14364_14381(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 14364, 14381);
                    return return_v;
                }


                int
                f_1643_14490_14545(System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context)
                {
                    WSManPluginInstance.PerformCloseOperation(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 14490, 14545);
                    return 0;
                }


                string
                f_1643_14782_14842()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginShutdownRegistrationFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 14782, 14842);
                    return return_v;
                }


                string
                f_1643_14738_14843(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 14738, 14843);
                    return return_v;
                }


                int
                f_1643_14564_14844(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 14564, 14844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 12109, 14930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 12109, 14930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void PerformStop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 15281, 15521);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 15333, 15510) || true) && (_isRequestPending)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 15333, 15510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 15388, 15408);

                    f_1643_15388_15407(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 15333, 15510);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1643, 15333, 15510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 15474, 15495);

                    f_1643_15474_15494(this, false, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1643, 15333, 15510);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 15281, 15521);

                int
                f_1643_15388_15407(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param)
                {
                    this_param.RaiseClosingEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 15388, 15407);
                    return 0;
                }


                int
                f_1643_15474_15494(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, bool
                isShuttingDown, System.Exception
                reasonForClose)
                {
                    this_param.DoClose(isShuttingDown, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 15474, 15494);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 15281, 15521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 15281, 15521);
            }
        }

        static WSManPluginServerTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1643, 711, 15528);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1643, 711, 15528);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 711, 15528);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1643, 711, 15528);

        object
        f_1643_2262_2274()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 2262, 2274);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>
        f_1643_2319_2376()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Remoting.WSManPluginServerTransportManager>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 2319, 2376);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1643_2405_2432(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 2405, 2432);
            return return_v;
        }


        static int
        f_1643_2196_2208_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1643, 2051, 2444);
            return return_v;
        }

    }
    internal class WSManPluginCommandTransportManager : WSManPluginServerTransportManager
    {
        private WSManPluginServerTransportManager _serverTransportMgr;

        private System.Guid _cmdId;

        internal WSManPluginCommandTransportManager(WSManPluginServerTransportManager srvrTransportMgr)
        : base(f_1643_15939_15979_C(f_1643_15939_15979(f_1643_15939_15966(srvrTransportMgr))), f_1643_15981_16010(srvrTransportMgr))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1643, 15823, 16144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 15680, 15699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 16036, 16075);

                _serverTransportMgr = srvrTransportMgr;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 16089, 16133);

                this.TypeTable = f_1643_16106_16132(srvrTransportMgr);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1643, 15823, 16144);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 15823, 16144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 15823, 16144);
            }
        }

        internal void Initialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 16156, 16369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 16207, 16288);

                this.PowerShellGuidObserver += new System.EventHandler(OnPowershellGuidReported);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 16302, 16358);

                f_1643_16302_16357(this, _serverTransportMgr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 16156, 16369);

                int
                f_1643_16302_16357(System.Management.Automation.Remoting.WSManPluginCommandTransportManager
                this_param, System.Management.Automation.Remoting.WSManPluginServerTransportManager
                transportManager)
                {
                    this_param.MigrateDataReadyEventHandlers((System.Management.Automation.Remoting.BaseTransportManager)transportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 16302, 16357);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 16156, 16369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 16156, 16369);
            }
        }

        private void OnPowershellGuidReported(object src, System.EventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1643, 16381, 16688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 16478, 16504);

                _cmdId = (System.Guid)src;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 16518, 16577);

                f_1643_16518_16576(_serverTransportMgr, _cmdId, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1643, 16591, 16677);

                this.PowerShellGuidObserver -= new System.EventHandler(this.OnPowershellGuidReported);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1643, 16381, 16688);

                int
                f_1643_16518_16576(System.Management.Automation.Remoting.WSManPluginServerTransportManager
                this_param, System.Guid
                cmdId, System.Management.Automation.Remoting.WSManPluginCommandTransportManager
                transportManager)
                {
                    this_param.ReportTransportMgrForCmd(cmdId, (System.Management.Automation.Remoting.WSManPluginServerTransportManager)transportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1643, 16518, 16576);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1643, 16381, 16688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 16381, 16688);
            }
        }

        static WSManPluginCommandTransportManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1643, 15536, 16695);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1643, 15536, 16695);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1643, 15536, 16695);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1643, 15536, 16695);

        static System.Management.Automation.Remoting.Fragmentor
        f_1643_15939_15966(System.Management.Automation.Remoting.WSManPluginServerTransportManager
        this_param)
        {
            var return_v = this_param.Fragmentor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 15939, 15966);
            return return_v;
        }


        static int
        f_1643_15939_15979(System.Management.Automation.Remoting.Fragmentor
        this_param)
        {
            var return_v = this_param.FragmentSize;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 15939, 15979);
            return return_v;
        }


        static System.Management.Automation.Internal.PSRemotingCryptoHelper
        f_1643_15981_16010(System.Management.Automation.Remoting.WSManPluginServerTransportManager
        this_param)
        {
            var return_v = this_param.CryptoHelper;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 15981, 16010);
            return return_v;
        }


        System.Management.Automation.Runspaces.TypeTable
        f_1643_16106_16132(System.Management.Automation.Remoting.WSManPluginServerTransportManager
        this_param)
        {
            var return_v = this_param.TypeTable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1643, 16106, 16132);
            return return_v;
        }


        static int
        f_1643_15939_15979_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1643, 15823, 16144);
            return return_v;
        }

    }
}
