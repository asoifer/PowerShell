// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Remoting.Server;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ServerMethodExecutor
    {
        private const long
        DefaultClientPipelineId = -1
        ;

        private Guid _clientRunspacePoolId;

        private Guid _clientPowerShellId;

        private ServerDispatchTable _serverDispatchTable;

        private RemotingDataType _remoteHostCallDataType;

        private AbstractServerTransportManager _transportManager;

        internal ServerMethodExecutor(
                    Guid clientRunspacePoolId, Guid clientPowerShellId,
                    AbstractServerTransportManager transportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1647, 1462, 2151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1034, 1054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1180, 1203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1334, 1351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1644, 1689);

                _clientRunspacePoolId = clientRunspacePoolId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1703, 1744);

                _clientPowerShellId = clientPowerShellId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1758, 1832);

                f_1647_1758_1831(transportManager != null, "Expected transportManager != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1846, 1883);

                _transportManager = transportManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 1897, 2077);

                _remoteHostCallDataType =
                (DynAbs.Tracing.TraceSender.Conditional_F1(1647, 1940, 1972) || ((clientPowerShellId == Guid.Empty && DynAbs.Tracing.TraceSender.Conditional_F2(1647, 1975, 2023)) || DynAbs.Tracing.TraceSender.Conditional_F3(1647, 2026, 2076))) ? RemotingDataType.RemoteHostCallUsingRunspaceHost : RemotingDataType.RemoteHostCallUsingPowerShellHost;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 2091, 2140);

                _serverDispatchTable = f_1647_2114_2139();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1647, 1462, 2151);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1647, 1462, 2151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 1462, 2151);
            }
        }

        internal void HandleRemoteHostResponseFromClient(RemoteHostResponse remoteHostResponse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1647, 2264, 2559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 2376, 2454);

                f_1647_2376_2453(remoteHostResponse != null, "Expected remoteHostResponse != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 2468, 2548);

                f_1647_2468_2547(_serverDispatchTable, f_1647_2501_2526(remoteHostResponse), remoteHostResponse);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1647, 2264, 2559);

                int
                f_1647_2376_2453(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 2376, 2453);
                    return 0;
                }


                long
                f_1647_2501_2526(System.Management.Automation.Remoting.RemoteHostResponse
                this_param)
                {
                    var return_v = this_param.CallId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1647, 2501, 2526);
                    return return_v;
                }


                int
                f_1647_2468_2547(System.Management.Automation.Remoting.ServerDispatchTable
                this_param, long
                callId, System.Management.Automation.Remoting.RemoteHostResponse
                remoteHostResponse)
                {
                    this_param.SetResponse(callId, remoteHostResponse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 2468, 2547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1647, 2264, 2559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 2264, 2559);
            }
        }

        internal void AbortAllCalls()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1647, 2648, 2750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 2702, 2739);

                f_1647_2702_2738(_serverDispatchTable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1647, 2648, 2750);

                int
                f_1647_2702_2738(System.Management.Automation.Remoting.ServerDispatchTable
                this_param)
                {
                    this_param.AbortAllCalls();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 2702, 2738);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1647, 2648, 2750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 2648, 2750);
            }
        }

        internal void ExecuteVoidMethod(RemoteHostMethodId methodId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1647, 2843, 2990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 2928, 2979);

                f_1647_2928_2978(this, methodId, f_1647_2956_2977());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1647, 2843, 2990);

                object[]
                f_1647_2956_2977()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 2956, 2977);
                    return return_v;
                }


                int
                f_1647_2928_2978(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 2928, 2978);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1647, 2843, 2990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 2843, 2990);
            }
        }

        internal void ExecuteVoidMethod(RemoteHostMethodId methodId, object[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1647, 3083, 4223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 3189, 3251);

                f_1647_3189_3250(parameters != null, "Expected parameters != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 3354, 3399);

                long
                callId = ServerDispatchTable.VoidCallId
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 3413, 3494);

                RemoteHostCall
                remoteHostCall = f_1647_3445_3493(callId, methodId, parameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 3681, 3917);

                RemoteDataObject<PSObject>
                dataToBeSent = f_1647_3723_3916(RemotingDestination.Client, _remoteHostCallDataType, _clientRunspacePoolId, _clientPowerShellId, f_1647_3892_3915(remoteHostCall))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 4156, 4212);

                f_1647_4156_4211(            // flush is not used here..since this is a void method and server host
                                             // does not expect anything from client..so let the transport manager buffer
                                             // and send as much data as possible.
                            _transportManager, dataToBeSent, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1647, 3083, 4223);

                int
                f_1647_3189_3250(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 3189, 3250);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1647_3445_3493(long
                callId, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostCall(callId, methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 3445, 3493);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1647_3892_3915(System.Management.Automation.Remoting.RemoteHostCall
                this_param)
                {
                    var return_v = this_param.Encode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 3892, 3915);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1647_3723_3916(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject<PSObject>.CreateFrom(destination, dataType, runspacePoolId, powerShellId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 3723, 3916);
                    return return_v;
                }


                int
                f_1647_4156_4211(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                data, bool
                flush)
                {
                    this_param.SendDataToClient<System.Management.Automation.PSObject>(data, flush);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 4156, 4211);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1647, 3083, 4223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 3083, 4223);
            }
        }

        internal T ExecuteMethod<T>(RemoteHostMethodId methodId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1647, 4311, 4460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 4392, 4449);

                return f_1647_4399_4448(this, methodId, f_1647_4426_4447());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1647, 4311, 4460);

                object[]
                f_1647_4426_4447()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 4426, 4447);
                    return return_v;
                }


                T
                f_1647_4399_4448(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = this_param.ExecuteMethod<T>(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 4399, 4448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1647, 4311, 4460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 4311, 4460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal T ExecuteMethod<T>(RemoteHostMethodId methodId, object[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1647, 4548, 5972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 4650, 4712);

                f_1647_4650_4711(parameters != null, "Expected parameters != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 4775, 4828);

                long
                callId = f_1647_4789_4827(_serverDispatchTable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 4842, 4923);

                RemoteHostCall
                remoteHostCall = f_1647_4874_4922(callId, methodId, parameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 4939, 5175);

                RemoteDataObject<PSObject>
                dataToBeSent = f_1647_4981_5174(RemotingDestination.Client, _remoteHostCallDataType, _clientRunspacePoolId, _clientPowerShellId, f_1647_5150_5173(remoteHostCall))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 5252, 5314);

                f_1647_5252_5313(            // report that execution is pending host response
                            _transportManager, dataToBeSent, false, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 5365, 5452);

                RemoteHostResponse
                remoteHostResponse = f_1647_5405_5451(_serverDispatchTable, callId, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 5563, 5712) || true) && (remoteHostResponse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1647, 5563, 5712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 5627, 5697);

                    throw f_1647_5633_5696(methodId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1647, 5563, 5712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 5766, 5826);

                object
                returnValue = f_1647_5787_5825(remoteHostResponse)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 5840, 5898);

                f_1647_5840_5897(returnValue is T, "Expected returnValue is T");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 5912, 5961);

                return (T)f_1647_5922_5960(remoteHostResponse);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1647, 4548, 5972);

                int
                f_1647_4650_4711(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 4650, 4711);
                    return 0;
                }


                long
                f_1647_4789_4827(System.Management.Automation.Remoting.ServerDispatchTable
                this_param)
                {
                    var return_v = this_param.CreateNewCallId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 4789, 4827);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1647_4874_4922(long
                callId, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostCall(callId, methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 4874, 4922);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1647_5150_5173(System.Management.Automation.Remoting.RemoteHostCall
                this_param)
                {
                    var return_v = this_param.Encode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 5150, 5173);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1647_4981_5174(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject<PSObject>.CreateFrom(destination, dataType, runspacePoolId, powerShellId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 4981, 5174);
                    return return_v;
                }


                int
                f_1647_5252_5313(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                data, bool
                flush, bool
                reportPending)
                {
                    this_param.SendDataToClient<System.Management.Automation.PSObject>(data, flush, reportPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 5252, 5313);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1647_5405_5451(System.Management.Automation.Remoting.ServerDispatchTable
                this_param, long
                callId, System.Management.Automation.Remoting.RemoteHostResponse
                defaultValue)
                {
                    var return_v = this_param.GetResponse(callId, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 5405, 5451);
                    return return_v;
                }


                System.Exception
                f_1647_5633_5696(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostExceptions.NewRemoteHostCallFailedException(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 5633, 5696);
                    return return_v;
                }


                object
                f_1647_5787_5825(System.Management.Automation.Remoting.RemoteHostResponse
                this_param)
                {
                    var return_v = this_param.SimulateExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 5787, 5825);
                    return return_v;
                }


                int
                f_1647_5840_5897(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 5840, 5897);
                    return 0;
                }


                object
                f_1647_5922_5960(System.Management.Automation.Remoting.RemoteHostResponse
                this_param)
                {
                    var return_v = this_param.SimulateExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 5922, 5960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1647, 4548, 5972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 4548, 5972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ServerMethodExecutor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1647, 463, 5979);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1647, 622, 650);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1647, 463, 5979);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1647, 463, 5979);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1647, 463, 5979);

        int
        f_1647_1758_1831(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 1758, 1831);
            return 0;
        }


        System.Management.Automation.Remoting.ServerDispatchTable
        f_1647_2114_2139()
        {
            var return_v = new System.Management.Automation.Remoting.ServerDispatchTable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1647, 2114, 2139);
            return return_v;
        }

    }
}
