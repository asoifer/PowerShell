// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Tracing;
using System.Threading;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting.Server
{
    internal abstract class OutOfProcessMediatorBase
    {
        protected TextReader originalStdIn;

        protected OutOfProcessTextWriter originalStdOut;

        protected OutOfProcessTextWriter originalStdErr;

        protected OutOfProcessServerSessionTransportManager sessionTM;

        protected OutOfProcessUtils.DataProcessingDelegates callbacks;

        protected static object SyncObject;

        protected object _syncObject;

        protected string _initialCommand;

        protected ManualResetEvent allcmdsClosedEvent;

        protected WindowsIdentity _windowsIdentityToImpersonate;

        protected int _inProgressCommandsCount;

        protected PowerShellTraceSource tracer;

        protected bool _exitProcessOnError;

        protected OutOfProcessMediatorBase(bool exitProcessOnError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 1532, 2830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 565, 578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 622, 636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 680, 694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 757, 766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 928, 954);
                this._syncObject = f_1646_942_954();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 982, 997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1035, 1053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1137, 1166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1292, 1320);
                this._inProgressCommandsCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1365, 1419);
                this.tracer = f_1646_1374_1419();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1447, 1466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1616, 1657);

                _exitProcessOnError = exitProcessOnError;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1721, 1781);

                callbacks = f_1646_1733_1780();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1795, 1890);

                callbacks.DataPacketReceived += new OutOfProcessUtils.DataPacketReceived(OnDataPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 1904, 2008);

                callbacks.DataAckPacketReceived += new OutOfProcessUtils.DataAckPacketReceived(OnDataAckPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 2022, 2150);

                callbacks.CommandCreationPacketReceived += new OutOfProcessUtils.CommandCreationPacketReceived(OnCommandCreationPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 2164, 2283);

                callbacks.CommandCreationAckReceived += new OutOfProcessUtils.CommandCreationAckReceived(OnCommandCreationAckReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 2297, 2395);

                callbacks.ClosePacketReceived += new OutOfProcessUtils.ClosePacketReceived(OnClosePacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 2409, 2516);

                callbacks.CloseAckPacketReceived += new OutOfProcessUtils.CloseAckPacketReceived(OnCloseAckPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 2530, 2631);

                callbacks.SignalPacketReceived += new OutOfProcessUtils.SignalPacketReceived(OnSignalPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 2645, 2755);

                callbacks.SignalAckPacketReceived += new OutOfProcessUtils.SignalAckPacketReceived(OnSignalAckPacketReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 2771, 2819);

                allcmdsClosedEvent = f_1646_2792_2818(true);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 1532, 2830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 1532, 2830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 1532, 2830);
            }
        }

        protected void ProcessingThreadStart(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 2908, 4970);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 3554, 3584);

                    string
                    data = state as string
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 3602, 3649);

                    f_1646_3602_3648(data, callbacks);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1646, 3678, 4959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 3730, 4154);

                    f_1646_3730_4153(PSEventId.TransportError, PSOpcode.Open, PSTask.None, PSKeyword.UseAlwaysOperational, Guid.Empty.ToString(), Guid.Empty.ToString(), OutOfProcessUtils.EXITCODE_UNHANDLED_EXCEPTION, f_1646_4108_4117(e), f_1646_4140_4152(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 4174, 4623);

                    f_1646_4174_4622(PSEventId.TransportError_Analytic, PSOpcode.Open, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, Guid.Empty.ToString(), Guid.Empty.ToString(), OutOfProcessUtils.EXITCODE_UNHANDLED_EXCEPTION, f_1646_4577_4586(e), f_1646_4609_4621(e));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 4722, 4944) || true) && (_exitProcessOnError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 4722, 4944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 4787, 4838);

                        f_1646_4787_4837(originalStdErr, f_1646_4812_4821(e) + f_1646_4824_4836(e));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 4860, 4925);

                        f_1646_4860_4924(OutOfProcessUtils.EXITCODE_UNHANDLED_EXCEPTION);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 4722, 4944);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1646, 3678, 4959);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 2908, 4970);

                int
                f_1646_3602_3648(string
                data, System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
                callbacks)
                {
                    OutOfProcessUtils.ProcessData(data, callbacks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 3602, 3648);
                    return 0;
                }


                string
                f_1646_4108_4117(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 4108, 4117);
                    return return_v;
                }


                string
                f_1646_4140_4152(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 4140, 4152);
                    return return_v;
                }


                int
                f_1646_3730_4153(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 3730, 4153);
                    return 0;
                }


                string
                f_1646_4577_4586(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 4577, 4586);
                    return return_v;
                }


                string
                f_1646_4609_4621(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 4609, 4621);
                    return return_v;
                }


                int
                f_1646_4174_4622(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 4174, 4622);
                    return 0;
                }


                string
                f_1646_4812_4821(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 4812, 4821);
                    return return_v;
                }


                string
                f_1646_4824_4836(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 4824, 4836);
                    return return_v;
                }


                int
                f_1646_4787_4837(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 4787, 4837);
                    return 0;
                }


                int
                f_1646_4860_4924(int
                exitCode)
                {
                    Environment.Exit(exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 4860, 4924);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 2908, 4970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 2908, 4970);
            }
        }

        protected void OnDataPacketReceived(byte[] rawData, string stream, Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 4982, 6927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5086, 5188);

                string
                streamTemp = System.Management.Automation.Remoting.Client.WSManNativeApi.WSMAN_STREAM_ID_STDIN
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5202, 5452) || true) && (f_1646_5206_5299(stream, f_1646_5220_5262(DataPriorityType.PromptResponse), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 5202, 5452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5333, 5437);

                    streamTemp = System.Management.Automation.Remoting.Client.WSManNativeApi.WSMAN_STREAM_ID_PROMPTRESPONSE;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 5202, 5452);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5468, 6916) || true) && (Guid.Empty == psGuid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 5468, 6916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5532, 5543);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5585, 5631);

                        f_1646_5585_5630(sessionTM, rawData, streamTemp);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 5468, 6916);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 5468, 6916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5758, 5802);

                    AbstractServerTransportManager
                    cmdTM = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5828, 5839);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5881, 5934);

                        cmdTM = f_1646_5889_5933(sessionTM, psGuid);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 5973, 6901) || true) && (cmdTM != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 5973, 6901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 6312, 6354);

                        f_1646_6312_6353(                    // not throwing when there is no associated command as the command might have
                                                             // legitimately closed while the client is sending data. however the client
                                                             // should die after timeout as we are not sending an ACK back.
                                            cmdTM, rawData, streamTemp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 5973, 6901);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 5973, 6901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 6810, 6882);

                        f_1646_6810_6881(                    // There is no command transport manager to process the input data.
                                                             // However, we still need to acknowledge to the client that this input data
                                                             // was received.  This can happen with some cmdlets such as Select-Object -First
                                                             // where the cmdlet completes before all input data is received.
                                            originalStdOut, f_1646_6835_6880(psGuid));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 5973, 6901);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 5468, 6916);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 4982, 6927);

                string
                f_1646_5220_5262(System.Management.Automation.Remoting.DataPriorityType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 5220, 5262);
                    return return_v;
                }


                bool
                f_1646_5206_5299(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 5206, 5299);
                    return return_v;
                }


                int
                f_1646_5585_5630(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 5585, 5630);
                    return 0;
                }


                System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                f_1646_5889_5933(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param, System.Guid
                powerShellCmdId)
                {
                    var return_v = this_param.GetCommandTransportManager(powerShellCmdId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 5889, 5933);
                    return return_v;
                }


                int
                f_1646_6312_6353(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 6312, 6353);
                    return 0;
                }


                string
                f_1646_6835_6880(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateDataAckPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 6835, 6880);
                    return return_v;
                }


                int
                f_1646_6810_6881(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 6810, 6881);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 4982, 6927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 4982, 6927);
            }
        }

        protected void OnDataAckPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 6939, 7259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7015, 7248);

                throw f_1646_7021_7247(PSRemotingErrorId.IPCUnknownElementReceived, f_1646_7134_7182(), OutOfProcessUtils.PS_OUT_OF_PROC_DATA_ACK_TAG);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 6939, 7259);

                string
                f_1646_7134_7182()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 7134, 7182);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1646_7021_7247(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 7021, 7247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 6939, 7259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 6939, 7259);
            }
        }

        protected void OnCommandCreationPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 7271, 7818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7361, 7372);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7406, 7454);

                    f_1646_7406_7453(sessionTM, psGuid);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7474, 7557) || true) && (_inProgressCommandsCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 7474, 7557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7530, 7557);

                        f_1646_7530_7556(allcmdsClosedEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 7474, 7557);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7577, 7604);

                    _inProgressCommandsCount++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7624, 7792);

                    f_1646_7624_7791(
                                    tracer, "OutOfProcessMediator.OnCommandCreationPacketReceived, in progress command count : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_inProgressCommandsCount).ToString(), 1646, 7731, 7755) + " psGuid : " + psGuid.ToString());
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 7271, 7818);

                int
                f_1646_7406_7453(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param, System.Guid
                powerShellCmdId)
                {
                    this_param.CreateCommandTransportManager(powerShellCmdId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 7406, 7453);
                    return 0;
                }


                bool
                f_1646_7530_7556(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 7530, 7556);
                    return return_v;
                }


                bool
                f_1646_7624_7791(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 7624, 7791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 7271, 7818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 7271, 7818);
            }
        }

        protected void OnCommandCreationAckReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 7830, 8123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 7911, 8112);

                throw f_1646_7917_8111(PSRemotingErrorId.IPCUnknownElementReceived, f_1646_7995_8043(), OutOfProcessUtils.PS_OUT_OF_PROC_COMMAND_ACK_TAG);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 7830, 8123);

                string
                f_1646_7995_8043()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 7995, 8043);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1646_7917_8111(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 7917, 8111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 7830, 8123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 7830, 8123);
            }
        }

        protected void OnSignalPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 8135, 9330);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 8210, 9319) || true) && (psGuid == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 8210, 9319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 8268, 8460);

                    throw f_1646_8274_8459(PSRemotingErrorId.IPCNoSignalForSession, f_1646_8348_8392(), OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_TAG);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 8210, 9319);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 8210, 9319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 8568, 8612);

                    AbstractServerTransportManager
                    cmdTM = null
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 8682, 8693);
                        lock (_syncObject)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 8743, 8796);

                            cmdTM = f_1646_8751_8795(sessionTM, psGuid);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 8936, 9044) || true) && (cmdTM != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 8936, 9044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 9003, 9021);

                            f_1646_9003_9020(cmdTM, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 8936, 9044);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1646, 9081, 9304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 9211, 9285);

                        f_1646_9211_9284(                    // Always send ack signal to avoid not responding in client.
                                            originalStdOut, f_1646_9236_9283(psGuid));
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1646, 9081, 9304);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 8210, 9319);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 8135, 9330);

                string
                f_1646_8348_8392()
                {
                    var return_v = RemotingErrorIdStrings.IPCNoSignalForSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 8348, 8392);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1646_8274_8459(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 8274, 8459);
                    return return_v;
                }


                System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                f_1646_8751_8795(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param, System.Guid
                powerShellCmdId)
                {
                    var return_v = this_param.GetCommandTransportManager(powerShellCmdId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 8751, 8795);
                    return return_v;
                }


                int
                f_1646_9003_9020(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 9003, 9020);
                    return 0;
                }


                string
                f_1646_9236_9283(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateSignalAckPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 9236, 9283);
                    return return_v;
                }


                int
                f_1646_9211_9284(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 9211, 9284);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 8135, 9330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 8135, 9330);
            }
        }

        protected void OnSignalAckPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 9342, 9631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 9420, 9620);

                throw f_1646_9426_9619(PSRemotingErrorId.IPCUnknownElementReceived, f_1646_9504_9552(), OutOfProcessUtils.PS_OUT_OF_PROC_SIGNAL_ACK_TAG);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 9342, 9631);

                string
                f_1646_9504_9552()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 9504, 9552);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1646_9426_9619(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 9426, 9619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 9342, 9631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 9342, 9631);
            }
        }

        protected void OnClosePacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 9643, 12354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 9717, 9794);

                PowerShellTraceSource
                tracer = f_1646_9748_9793()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 9810, 12223) || true) && (psGuid == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 9810, 12223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 9868, 9940);

                    f_1646_9868_9939(tracer, "BEGIN calling close on session transport manager");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 9960, 9999);

                    bool
                    waitForAllcmdsClosedEvent = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10025, 10036);

                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10078, 10170) || true) && (_inProgressCommandsCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 10078, 10170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10137, 10170);

                            waitForAllcmdsClosedEvent = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 10078, 10170);
                        }
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10310, 10391) || true) && (waitForAllcmdsClosedEvent)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 10310, 10391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10362, 10391);

                        f_1646_10362_10390(allcmdsClosedEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 10310, 10391);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10417, 10428);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10470, 10624);

                        f_1646_10470_10623(tracer, "OnClosePacketReceived, in progress commands count should be zero : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_inProgressCommandsCount).ToString(), 1646, 10562, 10586) + ", psGuid : " + psGuid.ToString());

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10648, 11033) || true) && (sessionTM != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 10648, 11033);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 10988, 11010);

                            f_1646_10988_11009(                        // it appears that when closing PowerShell ISE, therefore closing OutOfProcServerMediator, there are 2 Close command requests
                                                                       // changing PSRP/IPC at this point is too risky, therefore protecting about this duplication
                                                    sessionTM, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 10648, 11033);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11057, 11127);

                        f_1646_11057_11126(
                                            tracer, "END calling close on session transport manager");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11149, 11166);

                        sessionTM = null;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 9810, 12223);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 9810, 12223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11251, 11321);

                    f_1646_11251_11320(tracer, "Closing command with GUID " + psGuid.ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11383, 11427);

                    AbstractServerTransportManager
                    cmdTM = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11453, 11464);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11506, 11559);

                        cmdTM = f_1646_11514_11558(sessionTM, psGuid);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11687, 11783) || true) && (cmdTM != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 11687, 11783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11746, 11764);

                        f_1646_11746_11763(cmdTM, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 11687, 11783);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11809, 11820);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 11862, 12029);

                        f_1646_11862_12028(tracer, "OnClosePacketReceived, in progress commands count should be greater than zero : " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_inProgressCommandsCount).ToString(), 1646, 11967, 11991) + ", psGuid : " + psGuid.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 12053, 12080);

                        _inProgressCommandsCount--;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 12104, 12189) || true) && (_inProgressCommandsCount == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 12104, 12189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 12164, 12189);

                            f_1646_12164_12188(allcmdsClosedEvent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 12104, 12189);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 9810, 12223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 12270, 12343);

                f_1646_12270_12342(
                            // send close ack
                            originalStdOut, f_1646_12295_12341(psGuid));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 9643, 12354);

                System.Management.Automation.Tracing.PowerShellTraceSource
                f_1646_9748_9793()
                {
                    var return_v = PowerShellTraceSourceFactory.GetTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 9748, 9793);
                    return return_v;
                }


                bool
                f_1646_9868_9939(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 9868, 9939);
                    return return_v;
                }


                bool
                f_1646_10362_10390(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 10362, 10390);
                    return return_v;
                }


                bool
                f_1646_10470_10623(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 10470, 10623);
                    return return_v;
                }


                int
                f_1646_10988_11009(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 10988, 11009);
                    return 0;
                }


                bool
                f_1646_11057_11126(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 11057, 11126);
                    return return_v;
                }


                bool
                f_1646_11251_11320(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 11251, 11320);
                    return return_v;
                }


                System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                f_1646_11514_11558(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param, System.Guid
                powerShellCmdId)
                {
                    var return_v = this_param.GetCommandTransportManager(powerShellCmdId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 11514, 11558);
                    return return_v;
                }


                int
                f_1646_11746_11763(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 11746, 11763);
                    return 0;
                }


                bool
                f_1646_11862_12028(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                message)
                {
                    var return_v = this_param.WriteMessage(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 11862, 12028);
                    return return_v;
                }


                bool
                f_1646_12164_12188(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 12164, 12188);
                    return return_v;
                }


                string
                f_1646_12295_12341(System.Guid
                psGuid)
                {
                    var return_v = OutOfProcessUtils.CreateCloseAckPacket(psGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 12295, 12341);
                    return return_v;
                }


                int
                f_1646_12270_12342(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 12270, 12342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 9643, 12354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 9643, 12354);
            }
        }

        protected void OnCloseAckPacketReceived(Guid psGuid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 12366, 12653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 12443, 12642);

                throw f_1646_12449_12641(PSRemotingErrorId.IPCUnknownElementReceived, f_1646_12527_12575(), OutOfProcessUtils.PS_OUT_OF_PROC_CLOSE_ACK_TAG);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 12366, 12653);

                string
                f_1646_12527_12575()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 12527, 12575);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1646_12449_12641(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 12449, 12641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 12366, 12653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 12366, 12653);
            }
        }

        protected OutOfProcessServerSessionTransportManager CreateSessionTransportManager(string configurationName, PSRemotingCryptoHelperServer cryptoHelper, string workingDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 12714, 13938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 12914, 12938);

                PSSenderInfo
                senderInfo
                = default(PSSenderInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 12963, 13026);

                WindowsIdentity
                currentIdentity = f_1646_12997_13025()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 13040, 13200);

                PSPrincipal
                userPrincipal = f_1646_13068_13199(f_1646_13102_13164(string.Empty, true, f_1646_13137_13157(currentIdentity), null), currentIdentity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 13214, 13279);

                senderInfo = f_1646_13227_13278(userPrincipal, "http://localhost");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 13544, 13683);

                OutOfProcessServerSessionTransportManager
                tm = f_1646_13591_13682(originalStdOut, originalStdErr, cryptoHelper)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 13699, 13901);

                f_1646_13699_13900(senderInfo, _initialCommand, tm, configurationName, workingDirectory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 13917, 13927);

                return tm;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 12714, 13938);

                System.Security.Principal.WindowsIdentity
                f_1646_12997_13025()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 12997, 13025);
                    return return_v;
                }


                string
                f_1646_13137_13157(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 13137, 13157);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSIdentity
                f_1646_13102_13164(string
                authType, bool
                isAuthenticated, string
                userName, System.Management.Automation.Remoting.PSCertificateDetails
                cert)
                {
                    var return_v = new System.Management.Automation.Remoting.PSIdentity(authType, isAuthenticated, userName, cert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 13102, 13164);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1646_13068_13199(System.Management.Automation.Remoting.PSIdentity
                identity, System.Security.Principal.WindowsIdentity
                windowsIdentity)
                {
                    var return_v = new System.Management.Automation.Remoting.PSPrincipal(identity, windowsIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 13068, 13199);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSSenderInfo
                f_1646_13227_13278(System.Management.Automation.Remoting.PSPrincipal
                userPrincipal, string
                httpUrl)
                {
                    var return_v = new System.Management.Automation.Remoting.PSSenderInfo(userPrincipal, httpUrl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 13227, 13278);
                    return return_v;
                }


                System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                f_1646_13591_13682(System.Management.Automation.Remoting.OutOfProcessTextWriter
                outWriter, System.Management.Automation.Remoting.OutOfProcessTextWriter
                errWriter, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager(outWriter, errWriter, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 13591, 13682);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSession
                f_1646_13699_13900(System.Management.Automation.Remoting.PSSenderInfo
                senderInfo, string
                initializationScriptForOutOfProcessRunspace, System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                transportManager, string
                configurationName, string
                initialLocation)
                {
                    var return_v = ServerRemoteSession.CreateServerRemoteSession(senderInfo, initializationScriptForOutOfProcessRunspace, (System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager)transportManager, configurationName, initialLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 13699, 13900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 12714, 13938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 12714, 13938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void Start(string initialCommand, PSRemotingCryptoHelperServer cryptoHelper, string workingDirectory = null, string configurationName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 13950, 17296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14126, 14159);

                _initialCommand = initialCommand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14175, 14268);

                sessionTM = f_1646_14187_14267(this, configurationName, cryptoHelper, workingDirectory);

                try
                {
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 14320, 15984);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14363, 14402);

                                string
                                data = f_1646_14377_14401(originalStdIn)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14430, 14441);
                                lock (_syncObject)
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14491, 14690) || true) && (sessionTM == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 14491, 14690);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14570, 14663);

                                        sessionTM = f_1646_14582_14662(this, configurationName, cryptoHelper, workingDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 14491, 14690);
                                    }
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14737, 15434) || true) && (f_1646_14741_14767(data))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 14737, 15434);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14823, 14834);
                                    lock (_syncObject)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 15051, 15073);

                                        f_1646_15051_15072(                            // give a chance to runspace/pipelines to close (as it looks like the client died
                                                                                       // intermittently)
                                                                    sessionTM, null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 15103, 15120);

                                        sessionTM = null;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 15175, 15411);

                                    throw f_1646_15181_15410(PSRemotingErrorId.IPCUnknownElementReceived, f_1646_15318_15366(), string.Empty);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 14737, 15434);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 15618, 15821);

                                f_1646_15618_15820(_windowsIdentityToImpersonate, new WaitCallback(ProcessingThreadStart), data);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 14320, 15984);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 14320, 15984) || true) && (true)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1646, 14320, 15984);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1646, 14320, 15984);
                        }
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1646, 16013, 17285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 16065, 16489);

                    f_1646_16065_16488(PSEventId.TransportError, PSOpcode.Open, PSTask.None, PSKeyword.UseAlwaysOperational, Guid.Empty.ToString(), Guid.Empty.ToString(), OutOfProcessUtils.EXITCODE_UNHANDLED_EXCEPTION, f_1646_16443_16452(e), f_1646_16475_16487(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 16509, 16958);

                    f_1646_16509_16957(PSEventId.TransportError_Analytic, PSOpcode.Open, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, Guid.Empty.ToString(), Guid.Empty.ToString(), OutOfProcessUtils.EXITCODE_UNHANDLED_EXCEPTION, f_1646_16912_16921(e), f_1646_16944_16956(e));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 16978, 17270) || true) && (_exitProcessOnError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 16978, 17270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 17126, 17162);

                        f_1646_17126_17161(                    // notify the remote client of any errors and fail gracefully
                                            originalStdErr, f_1646_17151_17160(e));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 17186, 17251);

                        f_1646_17186_17250(OutOfProcessUtils.EXITCODE_UNHANDLED_EXCEPTION);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 16978, 17270);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1646, 16013, 17285);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 13950, 17296);

                System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                f_1646_14187_14267(System.Management.Automation.Remoting.Server.OutOfProcessMediatorBase
                this_param, string
                configurationName, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper, string
                workingDirectory)
                {
                    var return_v = this_param.CreateSessionTransportManager(configurationName, cryptoHelper, workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 14187, 14267);
                    return return_v;
                }


                string?
                f_1646_14377_14401(System.IO.TextReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 14377, 14401);
                    return return_v;
                }


                System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                f_1646_14582_14662(System.Management.Automation.Remoting.Server.OutOfProcessMediatorBase
                this_param, string
                configurationName, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper, string
                workingDirectory)
                {
                    var return_v = this_param.CreateSessionTransportManager(configurationName, cryptoHelper, workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 14582, 14662);
                    return return_v;
                }


                bool
                f_1646_14741_14767(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 14741, 14767);
                    return return_v;
                }


                int
                f_1646_15051_15072(System.Management.Automation.Remoting.Server.OutOfProcessServerSessionTransportManager
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 15051, 15072);
                    return 0;
                }


                string
                f_1646_15318_15366()
                {
                    var return_v = RemotingErrorIdStrings.IPCUnknownElementReceived;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 15318, 15366);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1646_15181_15410(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 15181, 15410);
                    return return_v;
                }


                int
                f_1646_15618_15820(System.Security.Principal.WindowsIdentity
                identityToImpersonate, System.Threading.WaitCallback
                threadProc, string
                state)
                {
                    Utils.QueueWorkItemWithImpersonation(identityToImpersonate, threadProc, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 15618, 15820);
                    return 0;
                }


                string
                f_1646_16443_16452(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 16443, 16452);
                    return return_v;
                }


                string
                f_1646_16475_16487(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 16475, 16487);
                    return return_v;
                }


                int
                f_1646_16065_16488(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 16065, 16488);
                    return 0;
                }


                string
                f_1646_16912_16921(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 16912, 16921);
                    return return_v;
                }


                string
                f_1646_16944_16956(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 16944, 16956);
                    return return_v;
                }


                int
                f_1646_16509_16957(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 16509, 16957);
                    return 0;
                }


                string
                f_1646_17151_17160(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 17151, 17160);
                    return return_v;
                }


                int
                f_1646_17126_17161(System.Management.Automation.Remoting.OutOfProcessTextWriter
                this_param, string
                data)
                {
                    this_param.WriteLine(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 17126, 17161);
                    return 0;
                }


                int
                f_1646_17186_17250(int
                exitCode)
                {
                    Environment.Exit(exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 17186, 17250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 13950, 17296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 13950, 17296);
            }
        }

        internal static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1646, 17364, 18262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 17526, 17580);

                Exception
                exception = (Exception)f_1646_17559_17579(args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 17650, 17920);

                f_1646_17650_17919(PSEventId.AppDomainUnhandledException, PSOpcode.Close, PSTask.None, PSKeyword.UseAlwaysOperational, f_1646_17830_17860(f_1646_17830_17849(exception)), f_1646_17862_17879(exception), f_1646_17898_17918(exception));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 17936, 18251);

                f_1646_17936_18250(PSEventId.AppDomainUnhandledException_Analytic, PSOpcode.Close, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, f_1646_18157_18187(f_1646_18157_18176(exception)), f_1646_18189_18206(exception), f_1646_18229_18249(exception));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1646, 17364, 18262);

                object
                f_1646_17559_17579(System.UnhandledExceptionEventArgs
                this_param)
                {
                    var return_v = this_param.ExceptionObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 17559, 17579);
                    return return_v;
                }


                System.Type
                f_1646_17830_17849(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 17830, 17849);
                    return return_v;
                }


                string
                f_1646_17830_17860(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 17830, 17860);
                    return return_v;
                }


                string
                f_1646_17862_17879(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 17862, 17879);
                    return return_v;
                }


                string
                f_1646_17898_17918(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 17898, 17918);
                    return return_v;
                }


                int
                f_1646_17650_17919(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 17650, 17919);
                    return 0;
                }


                System.Type
                f_1646_18157_18176(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 18157, 18176);
                    return return_v;
                }


                string
                f_1646_18157_18187(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 18157, 18187);
                    return return_v;
                }


                string
                f_1646_18189_18206(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 18189, 18206);
                    return return_v;
                }


                string
                f_1646_18229_18249(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 18229, 18249);
                    return return_v;
                }


                int
                f_1646_17936_18250(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 17936, 18250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 17364, 18262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 17364, 18262);
            }
        }

        static OutOfProcessMediatorBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1646, 445, 18291);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 875, 900);
            SyncObject = f_1646_888_900();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1646, 445, 18291);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 445, 18291);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1646, 445, 18291);

        static object
        f_1646_888_900()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 888, 900);
            return return_v;
        }


        object
        f_1646_942_954()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 942, 954);
            return return_v;
        }


        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1646_1374_1419()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 1374, 1419);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates
        f_1646_1733_1780()
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessUtils.DataProcessingDelegates();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 1733, 1780);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1646_2792_2818(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 2792, 2818);
            return return_v;
        }

    }
    internal sealed class OutOfProcessMediator : OutOfProcessMediatorBase
    {
        private static OutOfProcessMediator s_singletonInstance;

        private OutOfProcessMediator() : base(f_1646_18878_18882_C(true))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 18840, 20066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 19362, 19430);

                originalStdIn = f_1646_19378_19429(f_1646_19395_19422(), true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 19558, 19589);

                f_1646_19558_19588(TextReader.Null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 19717, 19774);

                originalStdOut = f_1646_19734_19773(f_1646_19761_19772());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 19788, 19820);

                f_1646_19788_19819(TextWriter.Null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 19948, 20007);

                originalStdErr = f_1646_19965_20006(f_1646_19992_20005());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 20021, 20055);

                f_1646_20021_20054(TextWriter.Null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 18840, 20066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 18840, 20066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 18840, 20066);
            }
        }

        internal static void Run(string initialCommand, string workingDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1646, 20485, 21264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 20588, 20598);
                lock (SyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 20632, 20814) || true) && (s_singletonInstance != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 20632, 20814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 20705, 20766);

                        f_1646_20705_20765(false, "Run should not be called multiple times");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 20788, 20795);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 20632, 20814);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 20834, 20883);

                    s_singletonInstance = f_1646_20856_20882();
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 21157, 21253);

                f_1646_21157_21252(
                            s_singletonInstance, initialCommand, f_1646_21199_21233(), workingDirectory);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1646, 20485, 21264);

                int
                f_1646_20705_20765(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 20705, 20765);
                    return 0;
                }


                System.Management.Automation.Remoting.Server.OutOfProcessMediator
                f_1646_20856_20882()
                {
                    var return_v = new System.Management.Automation.Remoting.Server.OutOfProcessMediator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 20856, 20882);
                    return return_v;
                }


                System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                f_1646_21199_21233()
                {
                    var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperServer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21199, 21233);
                    return return_v;
                }


                int
                f_1646_21157_21252(System.Management.Automation.Remoting.Server.OutOfProcessMediator
                this_param, string
                initialCommand, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper, string
                workingDirectory)
                {
                    this_param.Start(initialCommand, cryptoHelper, workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21157, 21252);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 20485, 21264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 20485, 21264);
            }
        }

        static OutOfProcessMediator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1646, 18299, 21293);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 18453, 18472);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1646, 18299, 21293);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 18299, 21293);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1646, 18299, 21293);

        System.IO.Stream
        f_1646_19395_19422()
        {
            var return_v = Console.OpenStandardInput();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 19395, 19422);
            return return_v;
        }


        System.IO.StreamReader
        f_1646_19378_19429(System.IO.Stream
        stream, bool
        detectEncodingFromByteOrderMarks)
        {
            var return_v = new System.IO.StreamReader(stream, detectEncodingFromByteOrderMarks);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 19378, 19429);
            return return_v;
        }


        int
        f_1646_19558_19588(System.IO.TextReader
        newIn)
        {
            Console.SetIn(newIn);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 19558, 19588);
            return 0;
        }


        System.IO.TextWriter
        f_1646_19761_19772()
        {
            var return_v = Console.Out;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 19761, 19772);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessTextWriter
        f_1646_19734_19773(System.IO.TextWriter
        writerToWrap)
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter(writerToWrap);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 19734, 19773);
            return return_v;
        }


        int
        f_1646_19788_19819(System.IO.TextWriter
        newOut)
        {
            Console.SetOut(newOut);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 19788, 19819);
            return 0;
        }


        System.IO.TextWriter
        f_1646_19992_20005()
        {
            var return_v = Console.Error;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 19992, 20005);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessTextWriter
        f_1646_19965_20006(System.IO.TextWriter
        writerToWrap)
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter(writerToWrap);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 19965, 20006);
            return return_v;
        }


        int
        f_1646_20021_20054(System.IO.TextWriter
        newError)
        {
            Console.SetError(newError);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 20021, 20054);
            return 0;
        }


        static bool
        f_1646_18878_18882_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1646, 18840, 20066);
            return return_v;
        }

    }
    internal sealed class SSHProcessMediator : OutOfProcessMediatorBase
    {
        private static SSHProcessMediator s_singletonInstance;

        private SSHProcessMediator() : base(f_1646_21573_21577_C(true))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 21537, 22801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 21614, 21707);

                var
                inputHandle = f_1646_21632_21706(PlatformInvokes.StandardHandleId.Input)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 21721, 21845);

                originalStdIn = f_1646_21737_21844(f_1646_21772_21843(f_1646_21787_21825(inputHandle, false), FileAccess.Read));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 21861, 21956);

                var
                outputHandle = f_1646_21880_21955(PlatformInvokes.StandardHandleId.Output)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 21970, 22147);

                originalStdOut = f_1646_21987_22146(f_1646_22032_22145(f_1646_22071_22144(f_1646_22086_22125(outputHandle, false), FileAccess.Write)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 22163, 22256);

                var
                errorHandle = f_1646_22181_22255(PlatformInvokes.StandardHandleId.Error)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 22270, 22446);

                originalStdErr = f_1646_22287_22445(f_1646_22332_22444(f_1646_22371_22443(f_1646_22386_22424(errorHandle, false), FileAccess.Write)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 21537, 22801);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 21537, 22801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 21537, 22801);
            }
        }

        internal static void Run(string initialCommand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1646, 22967, 23618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23045, 23055);
                lock (SyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23089, 23271) || true) && (s_singletonInstance != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 23089, 23271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23162, 23223);

                        f_1646_23162_23222(false, "Run should not be called multiple times");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23245, 23252);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 23089, 23271);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23291, 23338);

                    s_singletonInstance = f_1646_23313_23337();
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23369, 23411);

                PSRemotingCryptoHelperServer
                cryptoHelper
                = default(PSRemotingCryptoHelperServer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23436, 23486);

                cryptoHelper = f_1646_23451_23485();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23551, 23607);

                f_1646_23551_23606(
                            s_singletonInstance, initialCommand, cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1646, 22967, 23618);

                int
                f_1646_23162_23222(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 23162, 23222);
                    return 0;
                }


                System.Management.Automation.Remoting.Server.SSHProcessMediator
                f_1646_23313_23337()
                {
                    var return_v = new System.Management.Automation.Remoting.Server.SSHProcessMediator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 23313, 23337);
                    return return_v;
                }


                System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                f_1646_23451_23485()
                {
                    var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperServer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 23451, 23485);
                    return return_v;
                }


                int
                f_1646_23551_23606(System.Management.Automation.Remoting.Server.SSHProcessMediator
                this_param, string
                initialCommand, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper)
                {
                    this_param.Start(initialCommand, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 23551, 23606);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 22967, 23618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 22967, 23618);
            }
        }

        static SSHProcessMediator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1646, 21301, 23647);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 21451, 21470);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1646, 21301, 23647);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 21301, 23647);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1646, 21301, 23647);

        System.IntPtr
        f_1646_21632_21706(System.Management.Automation.PlatformInvokes.StandardHandleId
        handleId)
        {
            var return_v = PlatformInvokes.GetStdHandle((uint)handleId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21632, 21706);
            return return_v;
        }


        Microsoft.Win32.SafeHandles.SafeFileHandle
        f_1646_21787_21825(System.IntPtr
        preexistingHandle, bool
        ownsHandle)
        {
            var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21787, 21825);
            return return_v;
        }


        System.IO.FileStream
        f_1646_21772_21843(Microsoft.Win32.SafeHandles.SafeFileHandle
        handle, System.IO.FileAccess
        access)
        {
            var return_v = new System.IO.FileStream(handle, access);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21772, 21843);
            return return_v;
        }


        System.IO.StreamReader
        f_1646_21737_21844(System.IO.FileStream
        stream)
        {
            var return_v = new System.IO.StreamReader((System.IO.Stream)stream);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21737, 21844);
            return return_v;
        }


        System.IntPtr
        f_1646_21880_21955(System.Management.Automation.PlatformInvokes.StandardHandleId
        handleId)
        {
            var return_v = PlatformInvokes.GetStdHandle((uint)handleId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21880, 21955);
            return return_v;
        }


        Microsoft.Win32.SafeHandles.SafeFileHandle
        f_1646_22086_22125(System.IntPtr
        preexistingHandle, bool
        ownsHandle)
        {
            var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22086, 22125);
            return return_v;
        }


        System.IO.FileStream
        f_1646_22071_22144(Microsoft.Win32.SafeHandles.SafeFileHandle
        handle, System.IO.FileAccess
        access)
        {
            var return_v = new System.IO.FileStream(handle, access);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22071, 22144);
            return return_v;
        }


        System.IO.StreamWriter
        f_1646_22032_22145(System.IO.FileStream
        stream)
        {
            var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22032, 22145);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessTextWriter
        f_1646_21987_22146(System.IO.StreamWriter
        writerToWrap)
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 21987, 22146);
            return return_v;
        }


        System.IntPtr
        f_1646_22181_22255(System.Management.Automation.PlatformInvokes.StandardHandleId
        handleId)
        {
            var return_v = PlatformInvokes.GetStdHandle((uint)handleId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22181, 22255);
            return return_v;
        }


        Microsoft.Win32.SafeHandles.SafeFileHandle
        f_1646_22386_22424(System.IntPtr
        preexistingHandle, bool
        ownsHandle)
        {
            var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22386, 22424);
            return return_v;
        }


        System.IO.FileStream
        f_1646_22371_22443(Microsoft.Win32.SafeHandles.SafeFileHandle
        handle, System.IO.FileAccess
        access)
        {
            var return_v = new System.IO.FileStream(handle, access);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22371, 22443);
            return return_v;
        }


        System.IO.StreamWriter
        f_1646_22332_22444(System.IO.FileStream
        stream)
        {
            var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22332, 22444);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessTextWriter
        f_1646_22287_22445(System.IO.StreamWriter
        writerToWrap)
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 22287, 22445);
            return return_v;
        }


        static bool
        f_1646_21573_21577_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1646, 21537, 22801);
            return return_v;
        }

    }
    internal sealed class NamedPipeProcessMediator : OutOfProcessMediatorBase
    {
        private static NamedPipeProcessMediator s_singletonInstance;

        private readonly RemoteSessionNamedPipeServer _namedPipeServer;

        internal bool IsDisposed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 24025, 24068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24031, 24066);

                    return f_1646_24038_24065(_namedPipeServer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 24025, 24068);

                    bool
                    f_1646_24038_24065(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                    this_param)
                    {
                        var return_v = this_param.IsDisposed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 24038, 24065);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 23976, 24079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 23976, 24079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NamedPipeProcessMediator() : base(f_1646_24187_24192_C(false))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 24145, 24197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23895, 23911);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 24145, 24197);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 24145, 24197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 24145, 24197);
            }
        }

        private NamedPipeProcessMediator(
                    RemoteSessionNamedPipeServer namedPipeServer) : base(f_1646_24309_24314_C(false))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 24209, 24985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23895, 23911);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24340, 24469) || true) && (namedPipeServer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 24340, 24469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24401, 24454);

                    throw f_1646_24407_24453("namedPipeServer");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 24340, 24469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24485, 24520);

                _namedPipeServer = namedPipeServer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24601, 24644);

                originalStdIn = f_1646_24617_24643(namedPipeServer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24658, 24730);

                originalStdOut = f_1646_24675_24729(f_1646_24702_24728(namedPipeServer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24744, 24818);

                originalStdErr = f_1646_24761_24817(f_1646_24790_24816(namedPipeServer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 24891, 24966);

                f_1646_24891_24965(out _windowsIdentityToImpersonate);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 24209, 24985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 24209, 24985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 24209, 24985);
            }
        }

        internal static void Run(
                    string initialCommand,
                    RemoteSessionNamedPipeServer namedPipeServer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1646, 25053, 25944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 25204, 25214);
                lock (SyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 25248, 25501) || true) && (s_singletonInstance != null && (DynAbs.Tracing.TraceSender.Expression_True(1646, 25252, 25314) && f_1646_25283_25314_M(!s_singletonInstance.IsDisposed)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1646, 25248, 25501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 25356, 25453);

                        f_1646_25356_25452(false, "Run should not be called multiple times, unless the singleton was disposed.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 25475, 25482);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1646, 25248, 25501);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 25521, 25589);

                    s_singletonInstance = f_1646_25543_25588(namedPipeServer);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 25820, 25933);

                f_1646_25820_25932(
                            s_singletonInstance, initialCommand, f_1646_25862_25896(), f_1646_25898_25931(namedPipeServer));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1646, 25053, 25944);

                bool
                f_1646_25283_25314_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 25283, 25314);
                    return return_v;
                }


                int
                f_1646_25356_25452(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 25356, 25452);
                    return 0;
                }


                System.Management.Automation.Remoting.Server.NamedPipeProcessMediator
                f_1646_25543_25588(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                namedPipeServer)
                {
                    var return_v = new System.Management.Automation.Remoting.Server.NamedPipeProcessMediator(namedPipeServer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 25543, 25588);
                    return return_v;
                }


                System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                f_1646_25862_25896()
                {
                    var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperServer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 25862, 25896);
                    return return_v;
                }


                string
                f_1646_25898_25931(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 25898, 25931);
                    return return_v;
                }


                int
                f_1646_25820_25932(System.Management.Automation.Remoting.Server.NamedPipeProcessMediator
                this_param, string
                initialCommand, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper, string
                workingDirectory)
                {
                    this_param.Start(initialCommand, cryptoHelper, workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 25820, 25932);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 25053, 25944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 25053, 25944);
            }
        }

        static NamedPipeProcessMediator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1646, 23655, 25973);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 23817, 23836);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1646, 23655, 25973);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 23655, 25973);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1646, 23655, 25973);

        static bool
        f_1646_24187_24192_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1646, 24145, 24197);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1646_24407_24453(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 24407, 24453);
            return return_v;
        }


        System.IO.StreamReader
        f_1646_24617_24643(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
        this_param)
        {
            var return_v = this_param.TextReader;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 24617, 24643);
            return return_v;
        }


        System.IO.StreamWriter
        f_1646_24702_24728(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
        this_param)
        {
            var return_v = this_param.TextWriter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 24702, 24728);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessTextWriter
        f_1646_24675_24729(System.IO.StreamWriter
        writerToWrap)
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 24675, 24729);
            return return_v;
        }


        System.IO.StreamWriter
        f_1646_24790_24816(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
        this_param)
        {
            var return_v = this_param.TextWriter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 24790, 24816);
            return return_v;
        }


        System.Management.Automation.Remoting.Server.NamedPipeErrorTextWriter
        f_1646_24761_24817(System.IO.StreamWriter
        textWriter)
        {
            var return_v = new System.Management.Automation.Remoting.Server.NamedPipeErrorTextWriter((System.IO.TextWriter)textWriter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 24761, 24817);
            return return_v;
        }


        bool
        f_1646_24891_24965(out System.Security.Principal.WindowsIdentity
        impersonatedIdentity)
        {
            var return_v = Utils.TryGetWindowsImpersonatedIdentity(out impersonatedIdentity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 24891, 24965);
            return return_v;
        }


        static bool
        f_1646_24309_24314_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1646, 24209, 24985);
            return return_v;
        }

    }
    internal sealed class NamedPipeErrorTextWriter : OutOfProcessTextWriter
    {
        private const string
        _errorPrepend = "__NamedPipeError__:"
        ;

        internal static string ErrorPrepend
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1646, 26287, 26316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 26293, 26314);

                    return _errorPrepend;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1646, 26287, 26316);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 26227, 26327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 26227, 26327);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedPipeErrorTextWriter(
                    TextWriter textWriter) : base(f_1646_26471_26481_C(textWriter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 26393, 26495);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 26393, 26495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 26393, 26495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 26393, 26495);
            }
        }

        internal override void WriteLine(string data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 26569, 26758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 26639, 26705);

                string
                dataToWrite = (DynAbs.Tracing.TraceSender.Conditional_F1(1646, 26660, 26674) || (((data != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1646, 26677, 26697)) || DynAbs.Tracing.TraceSender.Conditional_F3(1646, 26700, 26704))) ? _errorPrepend + data : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 26719, 26747);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteLine(dataToWrite), 1646, 26719, 26746);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 26569, 26758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 26569, 26758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 26569, 26758);
            }
        }

        static NamedPipeErrorTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1646, 25981, 26787);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 26125, 26162);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1646, 25981, 26787);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 25981, 26787);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1646, 25981, 26787);

        static System.IO.TextWriter
        f_1646_26471_26481_C(System.IO.TextWriter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1646, 26393, 26495);
            return return_v;
        }

    }
    internal sealed class HyperVSocketMediator : OutOfProcessMediatorBase
    {
        private static HyperVSocketMediator s_instance;

        private readonly RemoteSessionHyperVSocketServer _hypervSocketServer;

        internal bool IsDisposed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 27154, 27200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27160, 27198);

                    return f_1646_27167_27197(_hypervSocketServer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 27154, 27200);

                    bool
                    f_1646_27167_27197(System.Management.Automation.Remoting.RemoteSessionHyperVSocketServer
                    this_param)
                    {
                        var return_v = this_param.IsDisposed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 27167, 27197);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 27105, 27211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 27105, 27211);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private HyperVSocketMediator()
        : base(f_1646_27328_27333_C(false))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 27277, 27683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27021, 27040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27359, 27424);

                _hypervSocketServer = f_1646_27381_27423(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27440, 27487);

                originalStdIn = f_1646_27456_27486(_hypervSocketServer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27501, 27577);

                originalStdOut = f_1646_27518_27576(f_1646_27545_27575(_hypervSocketServer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27591, 27672);

                originalStdErr = f_1646_27608_27671(f_1646_27640_27670(_hypervSocketServer));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 27277, 27683);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 27277, 27683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 27277, 27683);
            }
        }

        internal static void Run(
                    string initialCommand,
                    string configurationName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1646, 27751, 28298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27882, 27892);
                lock (SyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 27926, 27966);

                    s_instance = f_1646_27939_27965();
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 28199, 28287);

                f_1646_28199_28286(

                            s_instance, initialCommand, f_1646_28232_28266(), configurationName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1646, 27751, 28298);

                System.Management.Automation.Remoting.Server.HyperVSocketMediator
                f_1646_27939_27965()
                {
                    var return_v = new System.Management.Automation.Remoting.Server.HyperVSocketMediator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 27939, 27965);
                    return return_v;
                }


                System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                f_1646_28232_28266()
                {
                    var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperServer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 28232, 28266);
                    return return_v;
                }


                int
                f_1646_28199_28286(System.Management.Automation.Remoting.Server.HyperVSocketMediator
                this_param, string
                initialCommand, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper, string
                workingDirectory)
                {
                    this_param.Start(initialCommand, cryptoHelper, workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 28199, 28286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 27751, 28298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 27751, 28298);
            }
        }

        static HyperVSocketMediator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1646, 26795, 28327);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 26949, 26959);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1646, 26795, 28327);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 26795, 28327);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1646, 26795, 28327);

        System.Management.Automation.Remoting.RemoteSessionHyperVSocketServer
        f_1646_27381_27423(bool
        LoopbackMode)
        {
            var return_v = new System.Management.Automation.Remoting.RemoteSessionHyperVSocketServer(LoopbackMode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 27381, 27423);
            return return_v;
        }


        System.IO.StreamReader
        f_1646_27456_27486(System.Management.Automation.Remoting.RemoteSessionHyperVSocketServer
        this_param)
        {
            var return_v = this_param.TextReader;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 27456, 27486);
            return return_v;
        }


        System.IO.StreamWriter
        f_1646_27545_27575(System.Management.Automation.Remoting.RemoteSessionHyperVSocketServer
        this_param)
        {
            var return_v = this_param.TextWriter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 27545, 27575);
            return return_v;
        }


        System.Management.Automation.Remoting.OutOfProcessTextWriter
        f_1646_27518_27576(System.IO.StreamWriter
        writerToWrap)
        {
            var return_v = new System.Management.Automation.Remoting.OutOfProcessTextWriter((System.IO.TextWriter)writerToWrap);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 27518, 27576);
            return return_v;
        }


        System.IO.StreamWriter
        f_1646_27640_27670(System.Management.Automation.Remoting.RemoteSessionHyperVSocketServer
        this_param)
        {
            var return_v = this_param.TextWriter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1646, 27640, 27670);
            return return_v;
        }


        System.Management.Automation.Remoting.Server.HyperVSocketErrorTextWriter
        f_1646_27608_27671(System.IO.StreamWriter
        textWriter)
        {
            var return_v = new System.Management.Automation.Remoting.Server.HyperVSocketErrorTextWriter((System.IO.TextWriter)textWriter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1646, 27608, 27671);
            return return_v;
        }


        static bool
        f_1646_27328_27333_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1646, 27277, 27683);
            return return_v;
        }

    }
    internal sealed class HyperVSocketErrorTextWriter : OutOfProcessTextWriter
    {
        private const string
        _errorPrepend = "__HyperVSocketError__:"
        ;

        internal static string ErrorPrepend
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1646, 28647, 28676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 28653, 28674);

                    return _errorPrepend;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1646, 28647, 28676);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 28587, 28687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 28587, 28687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal HyperVSocketErrorTextWriter(
                    TextWriter textWriter)
        : base(f_1646_28847_28857_C(textWriter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1646, 28753, 28871);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1646, 28753, 28871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 28753, 28871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 28753, 28871);
            }
        }

        internal override void WriteLine(string data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1646, 28945, 29134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 29015, 29081);

                string
                dataToWrite = (DynAbs.Tracing.TraceSender.Conditional_F1(1646, 29036, 29050) || (((data != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1646, 29053, 29073)) || DynAbs.Tracing.TraceSender.Conditional_F3(1646, 29076, 29080))) ? _errorPrepend + data : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 29095, 29123);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteLine(dataToWrite), 1646, 29095, 29122);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1646, 28945, 29134);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1646, 28945, 29134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 28945, 29134);
            }
        }

        static HyperVSocketErrorTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1646, 28335, 29163);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1646, 28482, 28522);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1646, 28335, 29163);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1646, 28335, 29163);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1646, 28335, 29163);

        static System.IO.TextWriter
        f_1646_28847_28857_C(System.IO.TextWriter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1646, 28753, 28871);
            return return_v;
        }

    }
}
