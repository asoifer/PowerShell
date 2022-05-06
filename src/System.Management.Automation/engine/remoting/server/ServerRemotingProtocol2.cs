// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class ServerRunspacePoolDataStructureHandler
    {
        internal ServerRunspacePoolDataStructureHandler(ServerRunspacePoolDriver driver,
                    AbstractServerSessionTransportManager transportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1655, 915, 1193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 17623, 17640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 17714, 17807);
                this._associatedShells = f_1655_17747_17807();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 17950, 17987);
                this._associationSyncObject = f_1655_17975_17987();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 1089, 1131);

                _clientRunspacePoolId = f_1655_1113_1130(driver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 1145, 1182);

                _transportManager = transportManager;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1655, 915, 1193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 915, 1193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 915, 1193);
            }
        }

        internal void SendApplicationPrivateDataToClient(PSPrimitiveDictionary applicationPrivateData, RemoteSessionCapability serverCapability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 1671, 2963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 1930, 2082);

                PSPrimitiveDictionary
                applicationPrivateDataWithVersionTable =
                f_1655_2010_2081(applicationPrivateData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 2219, 2352);

                PSPrimitiveDictionary
                versionTable = (PSPrimitiveDictionary)f_1655_2279_2351(applicationPrivateDataWithVersionTable, PSVersionInfo.PSVersionTableName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 2366, 2459);

                versionTable[PSVersionInfo.PSRemotingProtocolVersionName] = f_1655_2426_2458(serverCapability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 2473, 2566);

                versionTable[PSVersionInfo.SerializationVersionName] = f_1655_2528_2565(serverCapability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 2680, 2748);

                versionTable[PSVersionInfo.PSVersionName] = f_1655_2724_2747();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 2764, 2916);

                RemoteDataObject
                data = f_1655_2788_2915(_clientRunspacePoolId, applicationPrivateDataWithVersionTable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 2932, 2952);

                f_1655_2932_2951(this, data);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 1671, 2963);

                System.Management.Automation.PSPrimitiveDictionary
                f_1655_2010_2081(System.Management.Automation.PSPrimitiveDictionary
                originalHash)
                {
                    var return_v = PSPrimitiveDictionary.CloneAndAddPSVersionTable(originalHash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 2010, 2081);
                    return return_v;
                }


                object
                f_1655_2279_2351(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 2279, 2351);
                    return return_v;
                }


                System.Version
                f_1655_2426_2458(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.ProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 2426, 2458);
                    return return_v;
                }


                System.Version
                f_1655_2528_2565(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.SerializationVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 2528, 2565);
                    return return_v;
                }


                System.Version
                f_1655_2724_2747()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 2724, 2747);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_2788_2915(System.Guid
                clientRunspacePoolId, System.Management.Automation.PSPrimitiveDictionary
                applicationPrivateData)
                {
                    var return_v = RemotingEncoder.GenerateApplicationPrivateData(clientRunspacePoolId, applicationPrivateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 2788, 2915);
                    return return_v;
                }


                int
                f_1655_2932_2951(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 2932, 2951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 1671, 2963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 1671, 2963);
            }
        }

        internal void SendStateInfoToClient(RunspacePoolStateInfo stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 3161, 3427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 3254, 3380);

                RemoteDataObject
                data = f_1655_3278_3379(_clientRunspacePoolId, stateInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 3396, 3416);

                f_1655_3396_3415(this, data);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 3161, 3427);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_3278_3379(System.Guid
                clientRunspacePoolId, System.Management.Automation.RunspacePoolStateInfo
                stateInfo)
                {
                    var return_v = RemotingEncoder.GenerateRunspacePoolStateInfo(clientRunspacePoolId, stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 3278, 3379);
                    return return_v;
                }


                int
                f_1655_3396_3415(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 3396, 3415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 3161, 3427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 3161, 3427);
            }
        }

        internal void SendPSEventArgsToClient(PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 3602, 3812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 3679, 3765);

                RemoteDataObject
                data = f_1655_3703_3764(_clientRunspacePoolId, e)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 3781, 3801);

                f_1655_3781_3800(this, data);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 3602, 3812);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_3703_3764(System.Guid
                clientRunspacePoolId, System.Management.Automation.PSEventArgs
                e)
                {
                    var return_v = RemotingEncoder.GeneratePSEventArgs(clientRunspacePoolId, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 3703, 3764);
                    return return_v;
                }


                int
                f_1655_3781_3800(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 3781, 3800);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 3602, 3812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 3602, 3812);
            }
        }

        internal void ProcessConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 4028, 4453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4083, 4137);

                List<ServerPowerShellDataStructureHandler>
                dsHandlers
                = default(List<ServerPowerShellDataStructureHandler>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4157, 4179);
                lock (_associationSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4213, 4299);

                    dsHandlers = f_1655_4226_4298(f_1655_4273_4297(_associatedShells));
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4330, 4442);
                    foreach (var dsHandler in f_1655_4356_4366_I(dsHandlers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 4330, 4442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4400, 4427);

                        f_1655_4400_4426(dsHandler);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 4330, 4442);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1655, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1655, 1, 113);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 4028, 4453);

                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>.ValueCollection
                f_1655_4273_4297(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 4273, 4297);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ServerPowerShellDataStructureHandler>
                f_1655_4226_4298(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>.ValueCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.ServerPowerShellDataStructureHandler>((System.Collections.Generic.IEnumerable<System.Management.Automation.ServerPowerShellDataStructureHandler>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 4226, 4298);
                    return return_v;
                }


                int
                f_1655_4400_4426(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    this_param.ProcessConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 4400, 4426);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ServerPowerShellDataStructureHandler>
                f_1655_4356_4366_I(System.Collections.Generic.List<System.Management.Automation.ServerPowerShellDataStructureHandler>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 4356, 4366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 4028, 4453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 4028, 4453);
            }
        }

        internal void ProcessReceivedData(RemoteDataObject<PSObject> receivedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 4665, 8666);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4764, 4898) || true) && (receivedData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 4764, 4898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4822, 4883);

                    throw f_1655_4828_4882("receivedData");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 4764, 4898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 4914, 5056);

                f_1655_4914_5055(f_1655_4925_4953(receivedData) == RemotingTargetInterface.RunspacePool, "RemotingTargetInterface must be Runspace");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 5072, 8655);

                switch (f_1655_5080_5101(receivedData))
                {

                    case RemotingDataType.CreatePowerShell:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 5072, 8655);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 5223, 5384);

                            f_1655_5223_5383(CreateAndInvokePowerShell != null, "The ServerRunspacePoolDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 5412, 5522);

                            f_1655_5412_5521(
                                                    CreateAndInvokePowerShell, this, f_1655_5455_5520(receivedData));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 5569, 5575);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 5072, 8655);

                    case RemotingDataType.GetCommandMetadata:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 5072, 8655);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 5685, 5839);

                            f_1655_5685_5838(GetCommandMetadata != null, "The ServerRunspacePoolDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 5867, 5970);

                            f_1655_5867_5969(
                                                    GetCommandMetadata, this, f_1655_5903_5968(receivedData));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 6017, 6023);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 5072, 8655);

                    case RemotingDataType.RemoteRunspaceHostResponseData:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 5072, 8655);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 6145, 6301);

                            f_1655_6145_6300(HostResponseReceived != null, "The ServerRunspacePoolDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 6329, 6414);

                            RemoteHostResponse
                            remoteHostResponse = f_1655_6369_6413(f_1655_6395_6412(receivedData))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 6628, 6679);

                            f_1655_6628_6678(
                                                    // part of host message robustness algo. Now the host response is back, report to transport that
                                                    // execution status is back to running
                                                    _transportManager);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 6707, 6810);

                            f_1655_6707_6809(
                                                    HostResponseReceived, this, f_1655_6745_6808(remoteHostResponse));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 6857, 6863);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 5072, 8655);

                    case RemotingDataType.SetMaxRunspaces:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 5072, 8655);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 6970, 7129);

                            f_1655_6970_7128(SetMaxRunspacesReceived != null, "The ServerRunspacePoolDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 7157, 7252);

                            f_1655_7157_7251(
                                                    SetMaxRunspacesReceived, this, f_1655_7198_7250(f_1655_7232_7249(receivedData)));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 7299, 7305);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 5072, 8655);

                    case RemotingDataType.SetMinRunspaces:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 5072, 8655);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 7412, 7571);

                            f_1655_7412_7570(SetMinRunspacesReceived != null, "The ServerRunspacePoolDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 7599, 7694);

                            f_1655_7599_7693(
                                                    SetMinRunspacesReceived, this, f_1655_7640_7692(f_1655_7674_7691(receivedData)));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 7741, 7747);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 5072, 8655);

                    case RemotingDataType.AvailableRunspaces:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 5072, 8655);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 7857, 8022);

                            f_1655_7857_8021(GetAvailableRunspacesReceived != null, "The ServerRunspacePoolDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 8050, 8151);

                            f_1655_8050_8150(
                                                    GetAvailableRunspacesReceived, this, f_1655_8097_8149(f_1655_8131_8148(receivedData)));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 8198, 8204);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 5072, 8655);

                    case RemotingDataType.ResetRunspaceState:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 5072, 8655);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 8314, 8469);

                            f_1655_8314_8468(ResetRunspaceState != null, "The ServerRunspacePoolDriver should subscribe to all data structure handler events.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 8497, 8587);

                            f_1655_8497_8586(
                                                    ResetRunspaceState, this, f_1655_8533_8585(f_1655_8567_8584(receivedData)));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 8634, 8640);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 5072, 8655);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 4665, 8666);

                System.Management.Automation.PSArgumentNullException
                f_1655_4828_4882(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 4828, 4882);
                    return return_v;
                }


                System.Management.Automation.RemotingTargetInterface
                f_1655_4925_4953(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.TargetInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 4925, 4953);
                    return return_v;
                }


                int
                f_1655_4914_5055(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 4914, 5055);
                    return 0;
                }


                System.Management.Automation.RemotingDataType
                f_1655_5080_5101(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 5080, 5101);
                    return return_v;
                }


                int
                f_1655_5223_5383(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 5223, 5383);
                    return 0;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>
                f_1655_5455_5520(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 5455, 5520);
                    return return_v;
                }


                int
                f_1655_5412_5521(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>>
                eventHandler, System.Management.Automation.ServerRunspacePoolDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 5412, 5521);
                    return 0;
                }


                int
                f_1655_5685_5838(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 5685, 5838);
                    return 0;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>
                f_1655_5903_5968(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 5903, 5968);
                    return return_v;
                }


                int
                f_1655_5867_5969(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>>
                eventHandler, System.Management.Automation.ServerRunspacePoolDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 5867, 5969);
                    return 0;
                }


                int
                f_1655_6145_6300(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 6145, 6300);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1655_6395_6412(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 6395, 6412);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1655_6369_6413(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteHostResponse.Decode(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 6369, 6413);
                    return return_v;
                }


                int
                f_1655_6628_6678(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param)
                {
                    this_param.ReportExecutionStatusAsRunning();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 6628, 6678);
                    return 0;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>
                f_1655_6745_6808(System.Management.Automation.Remoting.RemoteHostResponse
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 6745, 6808);
                    return return_v;
                }


                int
                f_1655_6707_6809(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>>
                eventHandler, System.Management.Automation.ServerRunspacePoolDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 6707, 6809);
                    return 0;
                }


                int
                f_1655_6970_7128(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 6970, 7128);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1655_7232_7249(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 7232, 7249);
                    return return_v;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                f_1655_7198_7250(System.Management.Automation.PSObject
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 7198, 7250);
                    return return_v;
                }


                int
                f_1655_7157_7251(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>
                eventHandler, System.Management.Automation.ServerRunspacePoolDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 7157, 7251);
                    return 0;
                }


                int
                f_1655_7412_7570(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 7412, 7570);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1655_7674_7691(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 7674, 7691);
                    return return_v;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                f_1655_7640_7692(System.Management.Automation.PSObject
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 7640, 7692);
                    return return_v;
                }


                int
                f_1655_7599_7693(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>
                eventHandler, System.Management.Automation.ServerRunspacePoolDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 7599, 7693);
                    return 0;
                }


                int
                f_1655_7857_8021(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 7857, 8021);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1655_8131_8148(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 8131, 8148);
                    return return_v;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                f_1655_8097_8149(System.Management.Automation.PSObject
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 8097, 8149);
                    return return_v;
                }


                int
                f_1655_8050_8150(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>
                eventHandler, System.Management.Automation.ServerRunspacePoolDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 8050, 8150);
                    return 0;
                }


                int
                f_1655_8314_8468(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 8314, 8468);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1655_8567_8584(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 8567, 8584);
                    return return_v;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                f_1655_8533_8585(System.Management.Automation.PSObject
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 8533, 8585);
                    return return_v;
                }


                int
                f_1655_8497_8586(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>
                eventHandler, System.Management.Automation.ServerRunspacePoolDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 8497, 8586);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 4665, 8666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 4665, 8666);
            }
        }

        internal ServerPowerShellDataStructureHandler CreatePowerShellDataStructureHandler(
                    Guid instanceId, Guid runspacePoolId, RemoteStreamOptions remoteStreamOptions, PowerShell localPowerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 9169, 10304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 9450, 9521);

                AbstractServerTransportManager
                cmdTransportManager = _transportManager
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 9537, 9811) || true) && (instanceId != Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 9537, 9811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 9599, 9678);

                    cmdTransportManager = f_1655_9621_9677(_transportManager, instanceId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 9696, 9796);

                    f_1655_9696_9795(f_1655_9707_9736(cmdTransportManager) != null, "This should be already set in managed C++ code");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 9537, 9811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 9827, 10021);

                ServerPowerShellDataStructureHandler
                dsHandler =
                f_1655_9893_10020(instanceId, runspacePoolId, remoteStreamOptions, cmdTransportManager, localPowerShell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10043, 10065);

                lock (_associationSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10099, 10156);

                    f_1655_10099_10155(_associatedShells, f_1655_10121_10143(dsHandler), dsHandler);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10187, 10260);

                dsHandler.RemoveAssociation += new EventHandler(HandleRemoveAssociation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10276, 10293);

                return dsHandler;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 9169, 10304);

                System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                f_1655_9621_9677(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param, System.Guid
                powerShellCmdId)
                {
                    var return_v = this_param.GetCommandTransportManager(powerShellCmdId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 9621, 9677);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1655_9707_9736(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param)
                {
                    var return_v = this_param.TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 9707, 9736);
                    return return_v;
                }


                int
                f_1655_9696_9795(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 9696, 9795);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1655_9893_10020(System.Guid
                instanceId, System.Guid
                runspacePoolId, System.Management.Automation.RemoteStreamOptions
                remoteStreamOptions, System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                transportManager, System.Management.Automation.PowerShell
                localPowerShell)
                {
                    var return_v = new System.Management.Automation.ServerPowerShellDataStructureHandler(instanceId, runspacePoolId, remoteStreamOptions, transportManager, localPowerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 9893, 10020);
                    return return_v;
                }


                System.Guid
                f_1655_10121_10143(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 10121, 10143);
                    return return_v;
                }


                int
                f_1655_10099_10155(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>
                this_param, System.Guid
                key, System.Management.Automation.ServerPowerShellDataStructureHandler
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 10099, 10155);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 9169, 10304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 9169, 10304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ServerPowerShellDataStructureHandler GetPowerShellDataStructureHandler()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 10571, 11234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10683, 10705);
                lock (_associationSyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10739, 11180) || true) && (f_1655_10743_10766(_associatedShells) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 10739, 11180);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10812, 11161);
                            foreach (object o in f_1655_10833_10857_I(f_1655_10833_10857(_associatedShells)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 10812, 11161);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 10907, 10995);

                                ServerPowerShellDataStructureHandler
                                result = o as ServerPowerShellDataStructureHandler
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 11021, 11138) || true) && (result != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 11021, 11138);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 11097, 11111);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 11021, 11138);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 10812, 11161);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1655, 1, 350);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1655, 1, 350);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 10739, 11180);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 11211, 11223);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 10571, 11234);

                int
                f_1655_10743_10766(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 10743, 10766);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>.ValueCollection
                f_1655_10833_10857(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 10833, 10857);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>.ValueCollection
                f_1655_10833_10857_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 10833, 10857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 10571, 11234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 10571, 11234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void DispatchMessageToPowerShell(RemoteDataObject<PSObject> rcvdData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 11445, 11949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 11548, 11681);

                ServerPowerShellDataStructureHandler
                dsHandler =
                f_1655_11614_11680(this, f_1655_11658_11679(rcvdData))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 11828, 11938) || true) && (dsHandler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 11828, 11938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 11883, 11923);

                    f_1655_11883_11922(dsHandler, rcvdData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 11828, 11938);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 11445, 11949);

                System.Guid
                f_1655_11658_11679(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 11658, 11679);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1655_11614_11680(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Guid
                clientPowerShellId)
                {
                    var return_v = this_param.GetAssociatedPowerShellDataStructureHandler(clientPowerShellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 11614, 11680);
                    return return_v;
                }


                int
                f_1655_11883_11922(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                receivedData)
                {
                    this_param.ProcessReceivedData(receivedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 11883, 11922);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 11445, 11949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 11445, 11949);
            }
        }

        internal void SendResponseToClient(long callId, object response)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 12249, 12527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 12338, 12477);

                RemoteDataObject
                message =
                f_1655_12382_12476(_clientRunspacePoolId, response, callId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 12493, 12516);

                f_1655_12493_12515(this, message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 12249, 12527);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_12382_12476(System.Guid
                clientRunspacePoolId, object
                response, long
                callId)
                {
                    var return_v = RemotingEncoder.GenerateRunspacePoolOperationResponse(clientRunspacePoolId, response, callId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 12382, 12476);
                    return return_v;
                }


                int
                f_1655_12493_12515(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 12493, 12515);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 12249, 12527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 12249, 12527);
            }
        }

        internal TypeTable TypeTable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 12702, 12745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 12708, 12743);

                    return f_1655_12715_12742(_transportManager);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 12702, 12745);

                    System.Management.Automation.Runspaces.TypeTable
                    f_1655_12715_12742(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                    this_param)
                    {
                        var return_v = this_param.TypeTable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 12715, 12742);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 12649, 12816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 12649, 12816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 12761, 12805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 12767, 12803);

                    _transportManager.TypeTable = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 12761, 12805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 12649, 12816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 12649, 12816);
                }
            }
        }



        /// <summary>
        /// This event is raised whenever there is a request from the
        /// client to create a powershell on the server and invoke it.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteDataObject<PSObject>>>
CreateAndInvokePowerShell
;

        /// <summary>
        /// This event is raised whenever there is a request from the
        /// client to run command discovery pipeline.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteDataObject<PSObject>>>
GetCommandMetadata
;

        /// <summary>
        /// This event is raised when a host call response is received.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteHostResponse>>
HostResponseReceived
;

        /// <summary>
        /// This event is raised when there is a request to modify the
        /// maximum runspaces in the runspace pool.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSObject>>
SetMaxRunspacesReceived
;

        /// <summary>
        /// This event is raised when there is a request to modify the
        /// minimum runspaces in the runspace pool.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSObject>>
SetMinRunspacesReceived
;

        /// <summary>
        /// This event is raised when there is a request to get the
        /// available runspaces in the runspace pool.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSObject>>
GetAvailableRunspacesReceived
;

        /// <summary>
        /// This event is raised when the client requests the runspace state
        /// to be reset.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSObject>>
ResetRunspaceState
;

        private void SendDataAsync(RemoteDataObject data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 15293, 15492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 15367, 15420);

                f_1655_15367_15419(data != null, "Cannot send null object.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 15434, 15481);

                f_1655_15434_15480(_transportManager, data, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 15293, 15492);

                int
                f_1655_15367_15419(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 15367, 15419);
                    return 0;
                }


                int
                f_1655_15434_15480(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                psObjectData, bool
                flush)
                {
                    this_param.SendDataToClient(psObjectData, flush);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 15434, 15480);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 15293, 15492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 15293, 15492);
            }
        }

        internal ServerPowerShellDataStructureHandler GetAssociatedPowerShellDataStructureHandler
                    (Guid clientPowerShellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 15856, 16390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16009, 16063);

                ServerPowerShellDataStructureHandler
                dsHandler = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16085, 16107);

                lock (_associationSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16141, 16221);

                    bool
                    success = f_1655_16156_16220(_associatedShells, clientPowerShellId, out dsHandler)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16241, 16331) || true) && (!success)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 16241, 16331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16295, 16312);

                        dsHandler = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 16241, 16331);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16362, 16379);

                return dsHandler;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 15856, 16390);

                bool
                f_1655_16156_16220(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>
                this_param, System.Guid
                key, out System.Management.Automation.ServerPowerShellDataStructureHandler
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 16156, 16220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 15856, 16390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 15856, 16390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleRemoveAssociation(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 16636, 17322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16725, 16870);

                f_1655_16725_16869(sender is ServerPowerShellDataStructureHandler, @"sender of the event
                must be ServerPowerShellDataStructureHandler");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 16886, 16982);

                ServerPowerShellDataStructureHandler
                dsHandler = sender as ServerPowerShellDataStructureHandler
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 17004, 17026);

                lock (_associationSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 17060, 17109);

                    f_1655_17060_17108(_associatedShells, f_1655_17085_17107(dsHandler));
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 17239, 17311);

                f_1655_17239_17310(
                            // let session transport manager remove its association of command transport manager.
                            _transportManager, f_1655_17287_17309(dsHandler));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 16636, 17322);

                int
                f_1655_16725_16869(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 16725, 16869);
                    return 0;
                }


                System.Guid
                f_1655_17085_17107(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 17085, 17107);
                    return return_v;
                }


                bool
                f_1655_17060_17108(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 17060, 17108);
                    return return_v;
                }


                System.Guid
                f_1655_17287_17309(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 17287, 17309);
                    return return_v;
                }


                int
                f_1655_17239_17310(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param, System.Guid
                powerShellCmdId)
                {
                    this_param.RemoveCommandTransportManager(powerShellCmdId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 17239, 17310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 16636, 17322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 16636, 17322);
            }
        }

        private Guid _clientRunspacePoolId;

        private AbstractServerSessionTransportManager _transportManager;

        private Dictionary<Guid, ServerPowerShellDataStructureHandler> _associatedShells
        ;

        private object _associationSyncObject;

        static ServerRunspacePoolDataStructureHandler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1655, 524, 18087);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1655, 524, 18087);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 524, 18087);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1655, 524, 18087);

        System.Guid
        f_1655_1113_1130(System.Management.Automation.ServerRunspacePoolDriver
        this_param)
        {
            var return_v = this_param.InstanceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 1113, 1130);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>
        f_1655_17747_17807()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.ServerPowerShellDataStructureHandler>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 17747, 17807);
            return return_v;
        }


        object
        f_1655_17975_17987()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 17975, 17987);
            return return_v;
        }

    }
    internal class ServerPowerShellDataStructureHandler
    {
        private AbstractServerTransportManager _transportManager;

        private Guid _clientRunspacePoolId;

        private Guid _clientPowerShellId;

        private RemoteStreamOptions _streamSerializationOptions;

        private Runspace _rsUsedToInvokePowerShell;

        internal ServerPowerShellDataStructureHandler(Guid instanceId, Guid runspacePoolId, RemoteStreamOptions remoteStreamOptions,
                    AbstractServerTransportManager transportManager, PowerShell localPowerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1655, 19330, 20069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 18507, 18524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 18651, 18678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 18706, 18731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 19569, 19602);

                _clientPowerShellId = instanceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 19616, 19655);

                _clientRunspacePoolId = runspacePoolId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 19669, 19706);

                _transportManager = transportManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 19720, 19770);

                _streamSerializationOptions = remoteStreamOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 19784, 19835);

                transportManager.Closing += HandleTransportClosing;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 19851, 20058) || true) && (localPowerShell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 19851, 20058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 19912, 20043);

                    localPowerShell.RunspaceAssigned +=
                                        new EventHandler<PSEventArgs<Runspace>>(LocalPowerShell_RunspaceAssigned);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 19851, 20058);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1655, 19330, 20069);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 19330, 20069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 19330, 20069);
            }
        }

        private void LocalPowerShell_RunspaceAssigned(object sender, PSEventArgs<Runspace> e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 20081, 20237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 20191, 20226);

                _rsUsedToInvokePowerShell = e.Args;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 20081, 20237);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 20081, 20237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 20081, 20237);
            }
        }

        internal void Prepare()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 20444, 20801);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 20676, 20790) || true) && (_clientPowerShellId != Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 20676, 20790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 20747, 20775);

                    f_1655_20747_20774(_transportManager);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 20676, 20790);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 20444, 20801);

                int
                f_1655_20747_20774(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param)
                {
                    this_param.Prepare();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 20747, 20774);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 20444, 20801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 20444, 20801);
            }
        }

        internal void SendStateChangedInformationToClient(PSInvocationStateInfo
                    stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 21016, 22266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 21136, 21454);

                f_1655_21136_21453((f_1655_21148_21163(stateInfo) == PSInvocationState.Completed) || (DynAbs.Tracing.TraceSender.Expression_False(1655, 21147, 21268) || (f_1655_21224_21239(stateInfo) == PSInvocationState.Failed)) || (DynAbs.Tracing.TraceSender.Expression_False(1655, 21147, 21342) || (f_1655_21297_21312(stateInfo) == PSInvocationState.Stopped)), "SendStateChangedInformationToClient should be called to notify a termination state");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 21468, 21600);

                f_1655_21468_21599(this, f_1655_21482_21598(stateInfo, _clientPowerShellId, _clientRunspacePoolId));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 21834, 22255) || true) && (_clientPowerShellId != Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 21834, 22255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 21993, 22045);

                    _transportManager.Closing -= HandleTransportClosing;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 22210, 22240);

                    f_1655_22210_22239(                // if terminal state is reached close the transport manager instead of letting
                                                       // the client initiate the close.
                                    _transportManager, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 21834, 22255);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 21016, 22266);

                System.Management.Automation.PSInvocationState
                f_1655_21148_21163(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 21148, 21163);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1655_21224_21239(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 21224, 21239);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1655_21297_21312(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 21297, 21312);
                    return return_v;
                }


                int
                f_1655_21136_21453(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 21136, 21453);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_21482_21598(System.Management.Automation.PSInvocationStateInfo
                stateInfo, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellStateInfo(stateInfo, clientPowerShellId, clientRunspacePoolId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 21482, 21598);
                    return return_v;
                }


                int
                f_1655_21468_21599(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 21468, 21599);
                    return 0;
                }


                int
                f_1655_22210_22239(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 22210, 22239);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 21016, 22266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 21016, 22266);
            }
        }

        internal void SendOutputDataToClient(PSObject data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 22428, 22638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 22504, 22627);

                f_1655_22504_22626(this, f_1655_22518_22625(data, _clientPowerShellId, _clientRunspacePoolId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 22428, 22638);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_22518_22625(System.Management.Automation.PSObject
                data, System.Guid
                clientPowerShellId, System.Guid
                clientRunspacePoolId)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellOutput(data, clientPowerShellId, clientRunspacePoolId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 22518, 22625);
                    return return_v;
                }


                int
                f_1655_22504_22626(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 22504, 22626);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 22428, 22638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 22428, 22638);
            }
        }

        internal void SendErrorRecordToClient(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 22812, 23180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 22899, 23023);

                errorRecord.SerializeExtendedInfo = (_streamSerializationOptions & RemoteStreamOptions.AddInvocationInfoToErrorRecord) != 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 23039, 23169);

                f_1655_23039_23168(this, f_1655_23053_23167(errorRecord, _clientRunspacePoolId, _clientPowerShellId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 22812, 23180);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_23053_23167(System.Management.Automation.ErrorRecord
                errorRecord, System.Guid
                clientRunspacePoolId, System.Guid
                clientPowerShellId)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellError((object)errorRecord, clientRunspacePoolId, clientPowerShellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 23053, 23167);
                    return return_v;
                }


                int
                f_1655_23039_23168(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 23039, 23168);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 22812, 23180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 22812, 23180);
            }
        }

        internal void SendWarningRecordToClient(WarningRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 23355, 23758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 23441, 23562);

                record.SerializeExtendedInfo = (_streamSerializationOptions & RemoteStreamOptions.AddInvocationInfoToWarningRecord) != 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 23578, 23747);

                f_1655_23578_23746(this, f_1655_23592_23745(record, _clientRunspacePoolId, _clientPowerShellId, RemotingDataType.PowerShellWarning));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 23355, 23758);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_23592_23745(System.Management.Automation.WarningRecord
                data, System.Guid
                clientRunspacePoolId, System.Guid
                clientPowerShellId, System.Management.Automation.RemotingDataType
                dataType)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellInformational((object)data, clientRunspacePoolId, clientPowerShellId, dataType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 23592, 23745);
                    return return_v;
                }


                int
                f_1655_23578_23746(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 23578, 23746);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 23355, 23758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 23355, 23758);
            }
        }

        internal void SendDebugRecordToClient(DebugRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 23929, 24324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 24011, 24130);

                record.SerializeExtendedInfo = (_streamSerializationOptions & RemoteStreamOptions.AddInvocationInfoToDebugRecord) != 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 24146, 24313);

                f_1655_24146_24312(this, f_1655_24160_24311(record, _clientRunspacePoolId, _clientPowerShellId, RemotingDataType.PowerShellDebug));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 23929, 24324);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_24160_24311(System.Management.Automation.DebugRecord
                data, System.Guid
                clientRunspacePoolId, System.Guid
                clientPowerShellId, System.Management.Automation.RemotingDataType
                dataType)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellInformational((object)data, clientRunspacePoolId, clientPowerShellId, dataType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 24160, 24311);
                    return return_v;
                }


                int
                f_1655_24146_24312(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 24146, 24312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 23929, 24324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 23929, 24324);
            }
        }

        internal void SendVerboseRecordToClient(VerboseRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 24499, 24902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 24585, 24706);

                record.SerializeExtendedInfo = (_streamSerializationOptions & RemoteStreamOptions.AddInvocationInfoToVerboseRecord) != 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 24722, 24891);

                f_1655_24722_24890(this, f_1655_24736_24889(record, _clientRunspacePoolId, _clientPowerShellId, RemotingDataType.PowerShellVerbose));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 24499, 24902);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_24736_24889(System.Management.Automation.VerboseRecord
                data, System.Guid
                clientRunspacePoolId, System.Guid
                clientPowerShellId, System.Management.Automation.RemotingDataType
                dataType)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellInformational((object)data, clientRunspacePoolId, clientPowerShellId, dataType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 24736, 24889);
                    return return_v;
                }


                int
                f_1655_24722_24890(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 24722, 24890);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 24499, 24902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 24499, 24902);
            }
        }

        internal void SendProgressRecordToClient(ProgressRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 25079, 25311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 25167, 25300);

                f_1655_25167_25299(this, f_1655_25181_25298(record, _clientRunspacePoolId, _clientPowerShellId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 25079, 25311);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_25181_25298(System.Management.Automation.ProgressRecord
                progressRecord, System.Guid
                clientRunspacePoolId, System.Guid
                clientPowerShellId)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellInformational(progressRecord, clientRunspacePoolId, clientPowerShellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 25181, 25298);
                    return return_v;
                }


                int
                f_1655_25167_25299(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 25167, 25299);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 25079, 25311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 25079, 25311);
            }
        }

        internal void SendInformationRecordToClient(InformationRecord record)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 25494, 25732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 25588, 25721);

                f_1655_25588_25720(this, f_1655_25602_25719(record, _clientRunspacePoolId, _clientPowerShellId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 25494, 25732);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1655_25602_25719(System.Management.Automation.InformationRecord
                informationRecord, System.Guid
                clientRunspacePoolId, System.Guid
                clientPowerShellId)
                {
                    var return_v = RemotingEncoder.GeneratePowerShellInformational(informationRecord, clientRunspacePoolId, clientPowerShellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 25602, 25719);
                    return return_v;
                }


                int
                f_1655_25588_25720(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data)
                {
                    this_param.SendDataAsync(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 25588, 25720);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 25494, 25732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 25494, 25732);
            }
        }

        internal void ProcessConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 26008, 26127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 26063, 26116);

                f_1655_26063_26115(OnSessionConnected, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 26008, 26127);

                int
                f_1655_26063_26115(System.EventHandler
                eventHandler, System.Management.Automation.ServerPowerShellDataStructureHandler
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 26063, 26115);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 26008, 26127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 26008, 26127);
            }
        }

        internal void ProcessReceivedData(RemoteDataObject<PSObject> receivedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 26336, 28840);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 26435, 26569) || true) && (receivedData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 26435, 26569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 26493, 26554);

                    throw f_1655_26499_26553("receivedData");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 26435, 26569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 26585, 26727);

                f_1655_26585_26726(f_1655_26596_26624(receivedData) == RemotingTargetInterface.PowerShell, "RemotingTargetInterface must be PowerShell");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 26743, 28829);

                switch (f_1655_26751_26772(receivedData))
                {

                    case RemotingDataType.StopPowerShell:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 26743, 28829);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 26892, 27044);

                            f_1655_26892_27043(StopPowerShellReceived != null, "ServerPowerShellDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 27070, 27127);

                            f_1655_27070_27126(StopPowerShellReceived, this, EventArgs.Empty);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 27174, 27180);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 26743, 28829);

                    case RemotingDataType.PowerShellInput:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 26743, 28829);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 27287, 27430);

                            f_1655_27287_27429(InputReceived != null, "ServerPowerShellDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 27456, 27539);

                            f_1655_27456_27538(InputReceived, this, f_1655_27487_27537(f_1655_27519_27536(receivedData)));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 27586, 27592);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 26743, 28829);

                    case RemotingDataType.PowerShellInputEnd:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 26743, 28829);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 27702, 27848);

                            f_1655_27702_27847(InputEndReceived != null, "ServerPowerShellDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 27874, 27925);

                            f_1655_27874_27924(InputEndReceived, this, EventArgs.Empty);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 27972, 27978);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 26743, 28829);

                    case RemotingDataType.RemotePowerShellHostResponseData:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 26743, 28829);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 28102, 28252);

                            f_1655_28102_28251(HostResponseReceived != null, "ServerPowerShellDriver should subscribe to all data structure handler events");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 28280, 28365);

                            RemoteHostResponse
                            remoteHostResponse = f_1655_28320_28364(f_1655_28346_28363(receivedData))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 28579, 28630);

                            f_1655_28579_28629(
                                                    // part of host message robustness algo. Now the host response is back, report to transport that
                                                    // execution status is back to running
                                                    _transportManager);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 28658, 28761);

                            f_1655_28658_28760(
                                                    HostResponseReceived, this, f_1655_28696_28759(remoteHostResponse));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1655, 28808, 28814);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 26743, 28829);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 26336, 28840);

                System.Management.Automation.PSArgumentNullException
                f_1655_26499_26553(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 26499, 26553);
                    return return_v;
                }


                System.Management.Automation.RemotingTargetInterface
                f_1655_26596_26624(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.TargetInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 26596, 26624);
                    return return_v;
                }


                int
                f_1655_26585_26726(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 26585, 26726);
                    return 0;
                }


                System.Management.Automation.RemotingDataType
                f_1655_26751_26772(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 26751, 26772);
                    return return_v;
                }


                int
                f_1655_26892_27043(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 26892, 27043);
                    return 0;
                }


                int
                f_1655_27070_27126(System.EventHandler
                eventHandler, System.Management.Automation.ServerPowerShellDataStructureHandler
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 27070, 27126);
                    return 0;
                }


                int
                f_1655_27287_27429(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 27287, 27429);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1655_27519_27536(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 27519, 27536);
                    return return_v;
                }


                System.Management.Automation.RemoteDataEventArgs<object>
                f_1655_27487_27537(System.Management.Automation.PSObject
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<object>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 27487, 27537);
                    return return_v;
                }


                int
                f_1655_27456_27538(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<object>>
                eventHandler, System.Management.Automation.ServerPowerShellDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<object>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<object>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 27456, 27538);
                    return 0;
                }


                int
                f_1655_27702_27847(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 27702, 27847);
                    return 0;
                }


                int
                f_1655_27874_27924(System.EventHandler
                eventHandler, System.Management.Automation.ServerPowerShellDataStructureHandler
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 27874, 27924);
                    return 0;
                }


                int
                f_1655_28102_28251(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 28102, 28251);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1655_28346_28363(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 28346, 28363);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1655_28320_28364(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteHostResponse.Decode(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 28320, 28364);
                    return return_v;
                }


                int
                f_1655_28579_28629(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param)
                {
                    this_param.ReportExecutionStatusAsRunning();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 28579, 28629);
                    return 0;
                }


                System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>
                f_1655_28696_28759(System.Management.Automation.Remoting.RemoteHostResponse
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 28696, 28759);
                    return return_v;
                }


                int
                f_1655_28658_28760(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>>
                eventHandler, System.Management.Automation.ServerPowerShellDataStructureHandler
                sender, System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 28658, 28760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 26336, 28840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 26336, 28840);
            }
        }

        internal void RaiseRemoveAssociationEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 29117, 29452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 29185, 29375);

                f_1655_29185_29374(RemoveAssociation != null, @"The ServerRunspacePoolDataStructureHandler should subscribe
                to the RemoveAssociation event of ServerPowerShellDataStructureHandler");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 29389, 29441);

                f_1655_29389_29440(RemoveAssociation, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 29117, 29452);

                int
                f_1655_29185_29374(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 29185, 29374);
                    return 0;
                }


                int
                f_1655_29389_29440(System.EventHandler
                eventHandler, System.Management.Automation.ServerPowerShellDataStructureHandler
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 29389, 29440);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 29117, 29452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 29117, 29452);
            }
        }

        internal ServerRemoteHost GetHostAssociatedWithPowerShell(
                    HostInfo powerShellHostInfo,
                    ServerRemoteHost runspaceServerRemoteHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 29937, 30920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 30118, 30136);

                HostInfo
                hostInfo
                = default(HostInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 30323, 30551) || true) && (f_1655_30327_30361(powerShellHostInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 30323, 30551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 30395, 30440);

                    hostInfo = f_1655_30406_30439(runspaceServerRemoteHost);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 30323, 30551);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1655, 30323, 30551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 30506, 30536);

                    hostInfo = powerShellHostInfo;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1655, 30323, 30551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 30704, 30909);

                return f_1655_30711_30908(_clientRunspacePoolId, _clientPowerShellId, hostInfo, _transportManager, f_1655_30822_30855(runspaceServerRemoteHost), runspaceServerRemoteHost as ServerDriverRemoteHost);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 29937, 30920);

                bool
                f_1655_30327_30361(System.Management.Automation.Remoting.HostInfo
                this_param)
                {
                    var return_v = this_param.UseRunspaceHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 30327, 30361);
                    return return_v;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1655_30406_30439(System.Management.Automation.Remoting.ServerRemoteHost
                this_param)
                {
                    var return_v = this_param.HostInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 30406, 30439);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1655_30822_30855(System.Management.Automation.Remoting.ServerRemoteHost
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1655, 30822, 30855);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteHost
                f_1655_30711_30908(System.Guid
                clientRunspacePoolId, System.Guid
                clientPowerShellId, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                transportManager, System.Management.Automation.Runspaces.Runspace
                runspace, System.Management.Automation.Remoting.ServerRemoteHost
                serverDriverRemoteHost)
                {
                    var return_v = new System.Management.Automation.Remoting.ServerRemoteHost(clientRunspacePoolId, clientPowerShellId, hostInfo, transportManager, runspace, (System.Management.Automation.Remoting.ServerDriverRemoteHost)serverDriverRemoteHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 30711, 30908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 29937, 30920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 29937, 30920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }



        /// <summary>
        /// This event is raised when the state of associated
        /// powershell is terminal and the runspace pool has
        /// to detach the association.
        /// </summary>
        internal event EventHandler
RemoveAssociation
;

        /// <summary>
        /// This event is raised when the a message to stop the
        /// powershell is received from the client.
        /// </summary>
        internal event EventHandler
StopPowerShellReceived
;

        /// <summary>
        /// This event is raised when an input object is received
        /// from the client.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<object>>
InputReceived
;

        /// <summary>
        /// This event is raised when end of input is received from
        /// the client.
        /// </summary>
        internal event EventHandler
InputEndReceived
;

        /// <summary>
        /// Raised when server session is connected from a new client.
        /// </summary>
        internal event EventHandler
OnSessionConnected
;

        /// <summary>
        /// This event is raised when a host response is received.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteHostResponse>>
HostResponseReceived
;

        internal Guid PowerShellId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 32573, 32651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 32609, 32636);

                    return _clientPowerShellId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 32573, 32651);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 32522, 32662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 32522, 32662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Runspace RunspaceUsedToInvokePowerShell
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 32903, 32944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 32909, 32942);

                    return _rsUsedToInvokePowerShell;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 32903, 32944);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 32830, 32955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 32830, 32955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void SendDataAsync(RemoteDataObject data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 33462, 33817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 33536, 33589);

                f_1655_33536_33588(data != null, "Cannot send null object.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 33758, 33806);

                f_1655_33758_33805(            // this is from a command execution..let transport manager collect
                                               // as much data as possible and send bigger buffer to client.
                            _transportManager, data, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 33462, 33817);

                int
                f_1655_33536_33588(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 33536, 33588);
                    return 0;
                }


                int
                f_1655_33758_33805(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                psObjectData, bool
                flush)
                {
                    this_param.SendDataToClient(psObjectData, flush);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 33758, 33805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 33462, 33817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 33462, 33817);
            }
        }

        private void HandleTransportClosing(object sender, EventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1655, 34015, 34163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1655, 34106, 34152);

                f_1655_34106_34151(StopPowerShellReceived, this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1655, 34015, 34163);

                int
                f_1655_34106_34151(System.EventHandler
                eventHandler, System.Management.Automation.ServerPowerShellDataStructureHandler
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1655, 34106, 34151);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1655, 34015, 34163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 34015, 34163);
            }
        }

        static ServerPowerShellDataStructureHandler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1655, 18245, 34208);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1655, 18245, 34208);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1655, 18245, 34208);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1655, 18245, 34208);
    }
}
