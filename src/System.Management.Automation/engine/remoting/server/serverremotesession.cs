// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Runspaces;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ServerRemoteSessionContext
    {
        internal ServerRemoteSessionContext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1652, 1497, 1638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 1827, 1890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 2031, 2094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 2300, 2350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 1559, 1627);

                ServerCapability = f_1652_1578_1626();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1652, 1497, 1638);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 1497, 1638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 1497, 1638);
            }
        }

        internal RemoteSessionCapability ClientCapability { get; set; }

        internal RemoteSessionCapability ServerCapability { get; set; }

        internal bool IsNegotiationSucceeded { get; set; }

        static ServerRemoteSessionContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1652, 1229, 2357);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1652, 1229, 2357);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 1229, 2357);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1652, 1229, 2357);

        System.Management.Automation.Remoting.RemoteSessionCapability
        f_1652_1578_1626()
        {
            var return_v = RemoteSessionCapability.CreateServerCapability();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 1578, 1626);
            return return_v;
        }

    }
    internal class ServerRemoteSession : RemoteSession
    {
        [TraceSourceAttribute("ServerRemoteSession", "ServerRemoteSession")]
        private static PSTraceSource s_trace;

        private PSSenderInfo _senderInfo;

        private string _configProviderId;

        private string _initParameters;

        private string _initScriptForOutOfProcRS;

        private PSSessionConfiguration _sessionConfigProvider;

        private int? _maxRecvdObjectSize;

        private int? _maxRecvdDataSizeCommand;

        private ServerRunspacePoolDriver _runspacePoolDriver;

        private PSRemotingCryptoHelperServer _cryptoHelper;

        private string _configurationName;

        private string _initialLocation;

        internal EventHandler<RemoteSessionStateMachineEventArgs> Closed;

        internal ServerRemoteSession(PSSenderInfo senderInfo,
                    string configurationProviderId,
                    string initializationParameters,
                    AbstractServerSessionTransportManager transportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1652, 5152, 7731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3234, 3245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3271, 3288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3314, 3329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3355, 3380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3422, 3444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3545, 3564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3588, 3612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3658, 3677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3725, 3738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3943, 3961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 4058, 4074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 4260, 4266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 22692, 22744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 22944, 23029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 5390, 5463);

                f_1652_5390_5462(transportManager != null, "transportManager cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 5632, 5675);

                NativeCommandProcessor.IsServerSide = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 5689, 5714);

                _senderInfo = senderInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 5728, 5772);

                _configProviderId = configurationProviderId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 5786, 5829);

                _initParameters = initializationParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 5854, 5930);

                _cryptoHelper = (PSRemotingCryptoHelperServer)f_1652_5900_5929(transportManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 5944, 5973);

                _cryptoHelper.Session = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6039, 6082);

                Context = f_1652_6049_6081();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6096, 6187);

                SessionDataStructureHandler = f_1652_6126_6186(this, transportManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6201, 6263);

                BaseSessionDataStructureHandler = f_1652_6235_6262();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6277, 6360);

                f_1652_6277_6304().CreateRunspacePoolReceived += HandleCreateRunspacePool;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6374, 6451);

                f_1652_6374_6401().NegotiationReceived += HandleNegotiationReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6465, 6541);

                f_1652_6465_6492().SessionClosing += HandleSessionDSHandlerClosing;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6555, 6692);

                f_1652_6555_6582().PublicKeyReceived +=
                                new EventHandler<RemoteDataEventArgs<string>>(HandlePublicKeyReceived);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6706, 6756);

                transportManager.Closing += HandleResourceClosing;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 6954, 7086);

                f_1652_6954_6993(transportManager).MaximumReceivedObjectSize =
                                BaseTransportManager.MaximumReceivedObjectSize;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 7649, 7720);

                f_1652_7649_7688(transportManager).MaximumReceivedDataSize = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1652, 5152, 7731);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 5152, 7731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 5152, 7731);
            }
        }

        internal static ServerRemoteSession CreateServerRemoteSession(
                    PSSenderInfo senderInfo,
                    string configurationProviderId,
                    string initializationParameters,
                    AbstractServerSessionTransportManager transportManager,
                    string configurationName = null,
                    string initialLocation = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1652, 9138, 11035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 9513, 9657);

                f_1652_9513_9656((senderInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1652, 9542, 9595) && (f_1652_9567_9586(senderInfo) != null)), "senderInfo and userInfo cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 9673, 9769);

                f_1652_9673_9768(
                            s_trace, "Finding InitialSessionState provider for id : {0}", configurationProviderId);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 9785, 10022) || true) && (f_1652_9789_9834(configurationProviderId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 9785, 10022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 9868, 10007);

                    throw f_1652_9874_10006("RemotingErrorIdStrings.NonExistentInitialSessionStateProvider", configurationProviderId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 9785, 10022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 10038, 10137);

                string
                shellPrefix = System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 10151, 10244);

                int
                index = f_1652_10163_10243(configurationProviderId, shellPrefix, StringComparison.OrdinalIgnoreCase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 10258, 10373);

                senderInfo.ConfigurationName = (DynAbs.Tracing.TraceSender.Conditional_F1(1652, 10289, 10301) || (((index == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1652, 10304, 10357)) || DynAbs.Tracing.TraceSender.Conditional_F3(1652, 10360, 10372))) ? f_1652_10304_10357(configurationProviderId, f_1652_10338_10356(shellPrefix)) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 10387, 10729);

                ServerRemoteSession
                result = new ServerRemoteSession(
                                senderInfo,
                                configurationProviderId,
                                initializationParameters,
                                transportManager)
                {
                    _configurationName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => configurationName, 1652, 10416, 10728),
                    _initialLocation = initialLocation
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 10782, 10906);

                RemoteSessionStateMachineEventArgs
                startEventArg = f_1652_10833_10905(RemoteSessionEvent.CreateSession)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 10920, 10994);

                f_1652_10920_10993(f_1652_10920_10967(f_1652_10920_10954(result)), startEventArg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 11010, 11024);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1652, 9138, 11035);

                System.Management.Automation.Remoting.PSPrincipal
                f_1652_9567_9586(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.UserInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 9567, 9586);
                    return return_v;
                }


                int
                f_1652_9513_9656(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 9513, 9656);
                    return 0;
                }


                int
                f_1652_9673_9768(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 9673, 9768);
                    return 0;
                }


                bool
                f_1652_9789_9834(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 9789, 9834);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1652_9874_10006(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 9874, 10006);
                    return return_v;
                }


                int
                f_1652_10163_10243(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 10163, 10243);
                    return return_v;
                }


                int
                f_1652_10338_10356(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 10338, 10356);
                    return return_v;
                }


                string
                f_1652_10304_10357(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 10304, 10357);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_10833_10905(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 10833, 10905);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_10920_10954(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    var return_v = this_param.SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 10920, 10954);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_10920_10967(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 10920, 10967);
                    return return_v;
                }


                int
                f_1652_10920_10993(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 10920, 10993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 9138, 11035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 9138, 11035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ServerRemoteSession CreateServerRemoteSession(
                    PSSenderInfo senderInfo,
                    string initializationScriptForOutOfProcessRunspace,
                    AbstractServerSessionTransportManager transportManager,
                    string configurationName,
                    string initialLocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1652, 11489, 12254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 11824, 12122);

                ServerRemoteSession
                result = f_1652_11853_12121(senderInfo, "Microsoft.PowerShell", string.Empty, transportManager, configurationName: configurationName, initialLocation: initialLocation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 12136, 12215);

                result._initScriptForOutOfProcRS = initializationScriptForOutOfProcessRunspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 12229, 12243);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1652, 11489, 12254);

                System.Management.Automation.Remoting.ServerRemoteSession
                f_1652_11853_12121(System.Management.Automation.Remoting.PSSenderInfo
                senderInfo, string
                configurationProviderId, string
                initializationParameters, System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                transportManager, string
                configurationName, string
                initialLocation)
                {
                    var return_v = CreateServerRemoteSession(senderInfo, configurationProviderId, initializationParameters, transportManager, configurationName: configurationName, initialLocation: initialLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 11853, 12121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 11489, 12254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 11489, 12254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override RemotingDestination MySelf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 12518, 12603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 12554, 12588);

                    return RemotingDestination.Server;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 12518, 12603);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 12449, 12614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 12449, 12614);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void DispatchInputQueueData(object sender, RemoteDataEventArgs dataEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 14134, 18737);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14244, 14378) || true) && (dataEventArg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 14244, 14378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14302, 14363);

                    throw f_1652_14308_14362("dataEventArg");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 14244, 14378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14394, 14458);

                RemoteDataObject<PSObject>
                rcvdData = f_1652_14432_14457(dataEventArg)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14474, 14600) || true) && (rcvdData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 14474, 14600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14528, 14585);

                    throw f_1652_14534_14584("dataEventArg");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 14474, 14600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14616, 14671);

                RemotingDestination
                destination = f_1652_14650_14670(rcvdData)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14687, 14942) || true) && ((destination & f_1652_14706_14712()) != f_1652_14717_14723())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 14687, 14942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14811, 14927);

                    throw f_1652_14817_14926(f_1652_14854_14904(), f_1652_14906_14912(), destination);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 14687, 14942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 14958, 15025);

                RemotingTargetInterface
                targetInterface = f_1652_15000_15024(rcvdData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 15039, 15085);

                RemotingDataType
                dataType = f_1652_15067_15084(rcvdData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 15101, 15162);

                RemoteSessionStateMachineEventArgs
                messageReceivedArg = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 15178, 18726);

                switch (targetInterface)
                {

                    case RemotingTargetInterface.Session:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 15178, 18726);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 15321, 17464);

                            switch (dataType)
                            {

                                case RemotingDataType.CreateRunspacePool:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 15321, 17464);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 15911, 16007);

                                    messageReceivedArg = f_1652_15932_16006(RemoteSessionEvent.MessageReceived);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 16041, 16616) || true) && (f_1652_16045_16125(f_1652_16045_16085(f_1652_16045_16072()), messageReceivedArg))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 16041, 16616);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 16199, 16240);

                                        messageReceivedArg.RemoteData = rcvdData;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 16278, 16363);

                                        f_1652_16278_16362(f_1652_16278_16318(f_1652_16278_16305()), this, messageReceivedArg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 16041, 16616);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 16041, 16616);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 16509, 16581);

                                        f_1652_16509_16580(f_1652_16509_16549(f_1652_16509_16536()), messageReceivedArg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 16041, 16616);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1652, 16652, 16658);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 15321, 17464);

                                case RemotingDataType.CloseSession:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 15321, 17464);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 16759, 16824);

                                    f_1652_16759_16823(f_1652_16759_16786(), dataEventArg);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1652, 16858, 16864);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 15321, 17464);

                                case RemotingDataType.SessionCapability:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 15321, 17464);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 16970, 17035);

                                    f_1652_16970_17034(f_1652_16970_16997(), dataEventArg);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1652, 17069, 17075);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 15321, 17464);

                                case RemotingDataType.PublicKey:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 15321, 17464);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 17173, 17238);

                                    f_1652_17173_17237(f_1652_17173_17200(), dataEventArg);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1652, 17272, 17278);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 15321, 17464);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 15321, 17464);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 17352, 17397);

                                    f_1652_17352_17396(false, "Should never reach here");
                                    DynAbs.Tracing.TraceSender.TraceBreak(1652, 17431, 17437);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 15321, 17464);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1652, 17511, 17517);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 15178, 18726);

                    case RemotingTargetInterface.RunspacePool:
                    case RemotingTargetInterface.PowerShell:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 15178, 18726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 18084, 18180);

                        messageReceivedArg = f_1652_18105_18179(RemoteSessionEvent.MessageReceived);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 18202, 18681) || true) && (f_1652_18206_18286(f_1652_18206_18246(f_1652_18206_18233()), messageReceivedArg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 18202, 18681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 18336, 18377);

                            messageReceivedArg.RemoteData = rcvdData;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 18403, 18488);

                            f_1652_18403_18487(f_1652_18403_18443(f_1652_18403_18430()), this, messageReceivedArg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 18202, 18681);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 18202, 18681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 18586, 18658);

                            f_1652_18586_18657(f_1652_18586_18626(f_1652_18586_18613()), messageReceivedArg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 18202, 18681);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1652, 18705, 18711);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 15178, 18726);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 14134, 18737);

                System.Management.Automation.PSArgumentNullException
                f_1652_14308_14362(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 14308, 14362);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1652_14432_14457(System.Management.Automation.RemoteDataEventArgs
                this_param)
                {
                    var return_v = this_param.ReceivedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 14432, 14457);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1652_14534_14584(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 14534, 14584);
                    return return_v;
                }


                System.Management.Automation.RemotingDestination
                f_1652_14650_14670(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 14650, 14670);
                    return return_v;
                }


                System.Management.Automation.RemotingDestination
                f_1652_14706_14712()
                {
                    var return_v = MySelf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 14706, 14712);
                    return return_v;
                }


                System.Management.Automation.RemotingDestination
                f_1652_14717_14723()
                {
                    var return_v = MySelf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 14717, 14723);
                    return return_v;
                }


                string
                f_1652_14854_14904()
                {
                    var return_v = RemotingErrorIdStrings.RemotingDestinationNotForMe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 14854, 14904);
                    return return_v;
                }


                System.Management.Automation.RemotingDestination
                f_1652_14906_14912()
                {
                    var return_v = MySelf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 14906, 14912);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_14817_14926(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 14817, 14926);
                    return return_v;
                }


                System.Management.Automation.RemotingTargetInterface
                f_1652_15000_15024(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.TargetInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 15000, 15024);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1652_15067_15084(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 15067, 15084);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_15932_16006(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 15932, 16006);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_16045_16072()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16045, 16072);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_16045_16085(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16045, 16085);
                    return return_v;
                }


                bool
                f_1652_16045_16125(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                arg)
                {
                    var return_v = this_param.CanByPassRaiseEvent(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 16045, 16125);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_16278_16305()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16278, 16305);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_16278_16318(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16278, 16318);
                    return return_v;
                }


                int
                f_1652_16278_16362(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.Remoting.ServerRemoteSession
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.DoMessageReceived((object)sender, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 16278, 16362);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_16509_16536()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16509, 16536);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_16509_16549(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16509, 16549);
                    return return_v;
                }


                int
                f_1652_16509_16580(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 16509, 16580);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_16759_16786()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16759, 16786);
                    return return_v;
                }


                int
                f_1652_16759_16823(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param, System.Management.Automation.RemoteDataEventArgs
                arg)
                {
                    this_param.RaiseDataReceivedEvent(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 16759, 16823);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_16970_16997()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 16970, 16997);
                    return return_v;
                }


                int
                f_1652_16970_17034(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param, System.Management.Automation.RemoteDataEventArgs
                arg)
                {
                    this_param.RaiseDataReceivedEvent(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 16970, 17034);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_17173_17200()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 17173, 17200);
                    return return_v;
                }


                int
                f_1652_17173_17237(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param, System.Management.Automation.RemoteDataEventArgs
                arg)
                {
                    this_param.RaiseDataReceivedEvent(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 17173, 17237);
                    return 0;
                }


                int
                f_1652_17352_17396(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 17352, 17396);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_18105_18179(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 18105, 18179);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_18206_18233()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 18206, 18233);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_18206_18246(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 18206, 18246);
                    return return_v;
                }


                bool
                f_1652_18206_18286(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                arg)
                {
                    var return_v = this_param.CanByPassRaiseEvent(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 18206, 18286);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_18403_18430()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 18403, 18430);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_18403_18443(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 18403, 18443);
                    return return_v;
                }


                int
                f_1652_18403_18487(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.Remoting.ServerRemoteSession
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.DoMessageReceived((object)sender, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 18403, 18487);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_18586_18613()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 18586, 18613);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_18586_18626(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 18586, 18626);
                    return return_v;
                }


                int
                f_1652_18586_18657(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 18586, 18657);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 14134, 18737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 14134, 18737);
            }
        }

        private void HandlePublicKeyReceived(object sender, RemoteDataEventArgs<string> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 19100, 20346);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 19215, 20335) || true) && (f_1652_19219_19265(f_1652_19219_19259(f_1652_19219_19246())) == RemoteSessionState.Established || (DynAbs.Tracing.TraceSender.Expression_False(1652, 19219, 19415) || f_1652_19320_19366(f_1652_19320_19360(f_1652_19320_19347())) == RemoteSessionState.EstablishedAndKeyRequested) || (DynAbs.Tracing.TraceSender.Expression_False(1652, 19219, 19566) || f_1652_19471_19517(f_1652_19471_19511(f_1652_19471_19498())) == RemoteSessionState.EstablishedAndKeyExchanged))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 19215, 20335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 19600, 19640);

                    string
                    remotePublicKey = f_1652_19625_19639(eventArgs)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 19660, 19724);

                    bool
                    ret = f_1652_19671_19723(_cryptoHelper, remotePublicKey)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 19744, 19791);

                    RemoteSessionStateMachineEventArgs
                    args = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 19809, 20146) || true) && (!ret)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 19809, 20146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 19962, 20045);

                        args = f_1652_19969_20044(RemoteSessionEvent.KeyReceiveFailed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 20069, 20127);

                        f_1652_20069_20126(f_1652_20069_20109(f_1652_20069_20096()), args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 19809, 20146);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 20166, 20244);

                    args = f_1652_20173_20243(RemoteSessionEvent.KeyReceived);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 20262, 20320);

                    f_1652_20262_20319(f_1652_20262_20302(f_1652_20262_20289()), args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 19215, 20335);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 19100, 20346);

                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_19219_19246()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19219, 19246);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_19219_19259(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19219, 19259);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionState
                f_1652_19219_19265(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19219, 19265);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_19320_19347()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19320, 19347);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_19320_19360(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19320, 19360);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionState
                f_1652_19320_19366(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19320, 19366);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_19471_19498()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19471, 19498);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_19471_19511(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19471, 19511);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionState
                f_1652_19471_19517(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19471, 19517);
                    return return_v;
                }


                string
                f_1652_19625_19639(System.Management.Automation.RemoteDataEventArgs<string>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 19625, 19639);
                    return return_v;
                }


                bool
                f_1652_19671_19723(System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                this_param, string
                publicKeyAsString)
                {
                    var return_v = this_param.ImportRemotePublicKey(publicKeyAsString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 19671, 19723);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_19969_20044(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 19969, 20044);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_20069_20096()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20069, 20096);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_20069_20109(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20069, 20109);
                    return return_v;
                }


                int
                f_1652_20069_20126(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 20069, 20126);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_20173_20243(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 20173, 20243);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_20262_20289()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20262, 20289);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_20262_20302(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20262, 20302);
                    return return_v;
                }


                int
                f_1652_20262_20319(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 20262, 20319);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 19100, 20346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 19100, 20346);
            }
        }

        internal override void StartKeyExchange()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 20450, 21009);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 20516, 20998) || true) && (f_1652_20520_20566(f_1652_20520_20560(f_1652_20520_20547())) == RemoteSessionState.Established)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 20516, 20998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 20688, 20742);

                    f_1652_20688_20741(f_1652_20688_20715());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 20762, 20902);

                    RemoteSessionStateMachineEventArgs
                    eventArgs =
                    f_1652_20830_20901(RemoteSessionEvent.KeyRequested)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 20920, 20983);

                    f_1652_20920_20982(f_1652_20920_20960(f_1652_20920_20947()), eventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 20516, 20998);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 20450, 21009);

                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_20520_20547()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20520, 20547);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_20520_20560(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20520, 20560);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionState
                f_1652_20520_20566(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20520, 20566);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_20688_20715()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20688, 20715);
                    return return_v;
                }


                int
                f_1652_20688_20741(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    this_param.SendRequestForPublicKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 20688, 20741);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_20830_20901(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 20830, 20901);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_20920_20947()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20920, 20947);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_20920_20960(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 20920, 20960);
                    return return_v;
                }


                int
                f_1652_20920_20982(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 20920, 20982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 20450, 21009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 20450, 21009);
            }
        }

        internal override void CompleteKeyExchange()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 21116, 21232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 21185, 21221);

                f_1652_21185_21220(_cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 21116, 21232);

                int
                f_1652_21185_21220(System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                this_param)
                {
                    this_param.CompleteKeyExchange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 21185, 21220);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 21116, 21232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 21116, 21232);
            }
        }

        internal void SendEncryptedSessionKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 21349, 22443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 21413, 21642);

                f_1652_21413_21641(f_1652_21424_21470(f_1652_21424_21464(f_1652_21424_21451())) == RemoteSessionState.EstablishedAndKeyReceived, "Sever must be in EstablishedAndKeyReceived state before you can attempt to send encrypted session key");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 21658, 21692);

                string
                encryptedSessionKey = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 21706, 21782);

                bool
                ret = f_1652_21717_21781(_cryptoHelper, out encryptedSessionKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 21798, 21845);

                RemoteSessionStateMachineEventArgs
                args = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 21859, 22093) || true) && (!ret)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 21859, 22093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 21901, 22002);

                    args =
                    f_1652_21929_22001(RemoteSessionEvent.KeySendFailed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 22020, 22078);

                    f_1652_22020_22077(f_1652_22020_22060(f_1652_22020_22047()), args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 21859, 22093);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 22109, 22182);

                f_1652_22109_22181(f_1652_22109_22136(), encryptedSessionKey);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 22248, 22270);

                f_1652_22248_22269(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 22286, 22360);

                args = f_1652_22293_22359(RemoteSessionEvent.KeySent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 22374, 22432);

                f_1652_22374_22431(f_1652_22374_22414(f_1652_22374_22401()), args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 21349, 22443);

                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_21424_21451()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 21424, 21451);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_21424_21464(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 21424, 21464);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionState
                f_1652_21424_21470(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 21424, 21470);
                    return return_v;
                }


                int
                f_1652_21413_21641(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 21413, 21641);
                    return 0;
                }


                bool
                f_1652_21717_21781(System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                this_param, out string
                encryptedSessionKey)
                {
                    var return_v = this_param.ExportEncryptedSessionKey(out encryptedSessionKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 21717, 21781);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_21929_22001(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 21929, 22001);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_22020_22047()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 22020, 22047);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_22020_22060(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 22020, 22060);
                    return return_v;
                }


                int
                f_1652_22020_22077(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 22020, 22077);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_22109_22136()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 22109, 22136);
                    return return_v;
                }


                int
                f_1652_22109_22181(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param, string
                encryptedSessionKey)
                {
                    this_param.SendEncryptedSessionKey(encryptedSessionKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 22109, 22181);
                    return 0;
                }


                int
                f_1652_22248_22269(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    this_param.CompleteKeyExchange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 22248, 22269);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_22293_22359(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 22293, 22359);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_22374_22401()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 22374, 22401);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_22374_22414(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 22374, 22414);
                    return return_v;
                }


                int
                f_1652_22374_22431(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 22374, 22431);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 21349, 22443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 21349, 22443);
            }
        }

        internal ServerRemoteSessionContext Context { get; }

        internal ServerRemoteSessionDataStructureHandler SessionDataStructureHandler { get; }

        internal void Close(RemoteSessionStateMachineEventArgs reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 23255, 23517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 23350, 23390);

                f_1652_23350_23389(Closed, this, reasonForClose);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 23404, 23506) || true) && (_runspacePoolDriver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 23404, 23506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 23454, 23506);

                    _runspacePoolDriver.Closed -= HandleResourceClosing;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 23404, 23506);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 23255, 23517);

                int
                f_1652_23350_23389(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>
                eventHandler, System.Management.Automation.Remoting.ServerRemoteSession
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteSessionStateMachineEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 23350, 23389);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 23255, 23517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 23255, 23517);
            }
        }

        internal void ExecuteConnect(byte[] connectData, out byte[] connectResponseData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 24653, 36097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 24758, 24785);

                connectResponseData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 24799, 24858);

                Fragmentor
                fragmentor = f_1652_24823_24857(int.MaxValue, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 24872, 24909);

                Fragmentor
                defragmentor = fragmentor
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 24925, 24963);

                int
                totalDataLen = f_1652_24944_24962(connectData)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 24979, 25222) || true) && (totalDataLen < FragmentedRemoteObject.HeaderLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 24979, 25222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 25103, 25207);

                    throw f_1652_25109_25206(f_1652_25146_25205());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 24979, 25222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 25471, 25542);

                long
                fragmentId = f_1652_25489_25541(connectData, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 25556, 25627);

                bool
                sFlag = f_1652_25569_25626(connectData, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 25641, 25710);

                bool
                eFlag = f_1652_25654_25709(connectData, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 25724, 25794);

                int
                blobLength = f_1652_25741_25793(connectData, 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 25810, 26066) || true) && (blobLength > totalDataLen - FragmentedRemoteObject.HeaderLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 25810, 26066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 25947, 26051);

                    throw f_1652_25953_26050(f_1652_25990_26049());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 25810, 26066);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26082, 26255) || true) && (!sFlag || (DynAbs.Tracing.TraceSender.Expression_False(1652, 26086, 26102) || !eFlag))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 26082, 26255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26136, 26240);

                    throw f_1652_26142_26239(f_1652_26179_26238());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 26082, 26255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26323, 26404);

                RemoteSessionState
                currentState = f_1652_26357_26403(f_1652_26357_26397(f_1652_26357_26384()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26418, 26709) || true) && (currentState != RemoteSessionState.Established && (DynAbs.Tracing.TraceSender.Expression_True(1652, 26422, 26550) && currentState != RemoteSessionState.EstablishedAndKeyExchanged))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 26418, 26709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26584, 26694);

                    throw f_1652_26590_26693(f_1652_26627_26692());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 26418, 26709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26763, 26814);

                MemoryStream
                serializedStream = f_1652_26795_26813()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26828, 26913);

                f_1652_26828_26912(serializedStream, connectData, FragmentedRemoteObject.HeaderLength, blobLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26929, 26972);

                f_1652_26929_26971(
                            serializedStream, 0, SeekOrigin.Begin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 26986, 27102);

                RemoteDataObject<PSObject>
                capabilityObject = f_1652_27032_27101(serializedStream, defragmentor)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27118, 27299) || true) && (capabilityObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 27118, 27299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27180, 27284);

                    throw f_1652_27186_27283(f_1652_27223_27282());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 27118, 27299);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27315, 27601) || true) && ((f_1652_27320_27348(capabilityObject) != RemotingDestination.Server) || (DynAbs.Tracing.TraceSender.Expression_False(1652, 27319, 27448) || (f_1652_27384_27409(capabilityObject) != RemotingDataType.SessionCapability)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 27315, 27601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27482, 27586);

                    throw f_1652_27488_27585(f_1652_27525_27584());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 27315, 27601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27656, 27747);

                int
                secondFragmentLength = totalDataLen - FragmentedRemoteObject.HeaderLength - blobLength
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27761, 27976) || true) && (secondFragmentLength < FragmentedRemoteObject.HeaderLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 27761, 27976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27857, 27961);

                    throw f_1652_27863_27960(f_1652_27900_27959());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 27761, 27976);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 27992, 28047);

                byte[]
                secondFragment = new byte[secondFragmentLength]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28061, 28176);

                f_1652_28061_28175(connectData, FragmentedRemoteObject.HeaderLength + blobLength, secondFragment, 0, secondFragmentLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28192, 28261);

                fragmentId = f_1652_28205_28260(secondFragment, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28275, 28344);

                sFlag = f_1652_28283_28343(secondFragment, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28358, 28425);

                eFlag = f_1652_28366_28424(secondFragment, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28439, 28508);

                blobLength = f_1652_28452_28507(secondFragment, 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28524, 28753) || true) && (blobLength != secondFragmentLength - FragmentedRemoteObject.HeaderLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 28524, 28753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28634, 28738);

                    throw f_1652_28640_28737(f_1652_28677_28736());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 28524, 28753);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28769, 28942) || true) && (!sFlag || (DynAbs.Tracing.TraceSender.Expression_False(1652, 28773, 28789) || !eFlag))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 28769, 28942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28823, 28927);

                    throw f_1652_28829_28926(f_1652_28866_28925());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 28769, 28942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 28997, 29035);

                serializedStream = f_1652_29016_29034();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29049, 29137);

                f_1652_29049_29136(serializedStream, secondFragment, FragmentedRemoteObject.HeaderLength, blobLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29153, 29196);

                f_1652_29153_29195(
                            serializedStream, 0, SeekOrigin.Begin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29210, 29335);

                RemoteDataObject<PSObject>
                connectRunspacePoolObject = f_1652_29265_29334(serializedStream, defragmentor)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29351, 29547) || true) && (connectRunspacePoolObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 29351, 29547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29422, 29532);

                    throw f_1652_29428_29531(f_1652_29465_29530());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 29351, 29547);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29563, 29869) || true) && ((f_1652_29568_29605(connectRunspacePoolObject) != RemotingDestination.Server) || (DynAbs.Tracing.TraceSender.Expression_False(1652, 29567, 29716) || (f_1652_29641_29675(connectRunspacePoolObject) != RemotingDataType.ConnectRunspacePool)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 29563, 29869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29750, 29854);

                    throw f_1652_29756_29853(f_1652_29793_29852());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 29563, 29869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 29971, 30012);

                RemoteSessionCapability
                clientCapability
                = default(RemoteSessionCapability);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30062, 30141);

                    clientCapability = f_1652_30081_30140(f_1652_30118_30139(capabilityObject));
                }
                catch (PSRemotingDataStructureException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1652, 30170, 30482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30363, 30467);

                    throw f_1652_30369_30466(f_1652_30406_30465());
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1652, 30170, 30482);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30534, 30588);

                    f_1652_30534_30587(this, clientCapability, true);
                }
                catch (PSRemotingDataStructureException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1652, 30617, 30717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30693, 30702);

                    throw ex;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1652, 30617, 30717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30794, 30831);

                int
                clientRequestedMinRunspaces = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30845, 30882);

                int
                clientRequestedMaxRunspaces = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30896, 30938);

                bool
                clientRequestedRunspaceCount = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 30952, 31732) || true) && (f_1652_30956_31033(f_1652_30956_30997(f_1652_30956_30986(connectRunspacePoolObject)), RemoteDataNameStrings.MinRunspaces) != null && (DynAbs.Tracing.TraceSender.Expression_True(1652, 30956, 31130) && f_1652_31045_31122(f_1652_31045_31086(f_1652_31045_31075(connectRunspacePoolObject)), RemoteDataNameStrings.MaxRunspaces) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 30952, 31732);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 31208, 31302);

                        clientRequestedMinRunspaces = f_1652_31238_31301(f_1652_31270_31300(connectRunspacePoolObject));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 31324, 31418);

                        clientRequestedMaxRunspaces = f_1652_31354_31417(f_1652_31386_31416(connectRunspacePoolObject));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 31440, 31476);

                        clientRequestedRunspaceCount = true;
                    }
                    catch (PSRemotingDataStructureException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1652, 31513, 31717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 31594, 31698);

                        throw f_1652_31600_31697(f_1652_31637_31696());
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1652, 31513, 31717);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 30952, 31732);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 31824, 32163) || true) && (clientRequestedRunspaceCount && (DynAbs.Tracing.TraceSender.Expression_True(1652, 31828, 32010) && (clientRequestedMinRunspaces == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1652, 31878, 31948) || clientRequestedMaxRunspaces == -1) || (DynAbs.Tracing.TraceSender.Expression_False(1652, 31878, 32009) || clientRequestedMinRunspaces > clientRequestedMaxRunspaces))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 31824, 32163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 32044, 32148);

                    throw f_1652_32050_32147(f_1652_32087_32146());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 31824, 32163);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 32179, 32369) || true) && (_runspacePoolDriver == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 32179, 32369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 32244, 32354);

                    throw f_1652_32250_32353(f_1652_32287_32352());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 32179, 32369);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 32507, 32738) || true) && (f_1652_32511_32551(connectRunspacePoolObject) != f_1652_32555_32585(_runspacePoolDriver))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 32507, 32738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 32619, 32723);

                    throw f_1652_32625_32722(f_1652_32662_32721());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 32507, 32738);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 33135, 33545) || true) && (clientRequestedRunspaceCount
                && (DynAbs.Tracing.TraceSender.Expression_True(1652, 33139, 33271) && (f_1652_33189_33239(f_1652_33189_33221(_runspacePoolDriver)) != clientRequestedMaxRunspaces)
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1652, 33139, 33375) && (f_1652_33293_33343(f_1652_33293_33325(_runspacePoolDriver)) != clientRequestedMinRunspaces)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 33135, 33545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 33409, 33530);

                    throw f_1652_33415_33529(f_1652_33452_33528());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 33135, 33545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 33732, 33868);

                RemoteDataObject
                capability = f_1652_33762_33867(f_1652_33810_33834(f_1652_33810_33817()), f_1652_33836_33866(_runspacePoolDriver))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 33882, 34295);

                RemoteDataObject
                runspacepoolInitData = f_1652_33922_34294(f_1652_33967_33997(_runspacePoolDriver), f_1652_34095_34145(f_1652_34095_34127(_runspacePoolDriver)), f_1652_34243_34293(f_1652_34243_34275(_runspacePoolDriver)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 34793, 34858);

                SerializedDataStream
                stream = f_1652_34823_34857(4 * 1024)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 34924, 34939);

                f_1652_34924_34938(stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 34953, 34994);

                f_1652_34953_34993(capability, stream, fragmentor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35008, 35022);

                f_1652_35008_35021(stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35036, 35051);

                f_1652_35036_35050(stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35065, 35116);

                f_1652_35065_35115(runspacepoolInitData, stream, fragmentor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35130, 35144);

                f_1652_35130_35143(stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35158, 35191);

                byte[]
                outbuffer = f_1652_35177_35190(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35205, 35281);

                f_1652_35205_35280(outbuffer != null, "connect response data should be serialized");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35295, 35312);

                f_1652_35295_35311(stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35354, 35386);

                connectResponseData = outbuffer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 35627, 35991);

                f_1652_35627_35990(new WaitCallback(
                                delegate (object state)
                                {
                                    RemoteSessionStateMachineEventArgs startEventArg = new RemoteSessionStateMachineEventArgs(RemoteSessionEvent.ConnectSession);
                                    SessionDataStructureHandler.StateMachine.RaiseEvent(startEventArg);
                                }));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 36007, 36065);

                f_1652_36007_36064(f_1652_36007_36047(_runspacePoolDriver));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 36079, 36086);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 24653, 36097);

                System.Management.Automation.Remoting.Fragmentor
                f_1652_24823_24857(int
                fragmentSize, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.Fragmentor(fragmentSize, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 24823, 24857);
                    return return_v;
                }


                int
                f_1652_24944_24962(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 24944, 24962);
                    return return_v;
                }


                string
                f_1652_25146_25205()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 25146, 25205);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_25109_25206(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 25109, 25206);
                    return return_v;
                }


                long
                f_1652_25489_25541(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetFragmentId(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 25489, 25541);
                    return return_v;
                }


                bool
                f_1652_25569_25626(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetIsStartFragment(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 25569, 25626);
                    return return_v;
                }


                bool
                f_1652_25654_25709(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetIsEndFragment(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 25654, 25709);
                    return return_v;
                }


                int
                f_1652_25741_25793(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetBlobLength(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 25741, 25793);
                    return return_v;
                }


                string
                f_1652_25990_26049()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 25990, 26049);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_25953_26050(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 25953, 26050);
                    return return_v;
                }


                string
                f_1652_26179_26238()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 26179, 26238);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_26142_26239(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 26142, 26239);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_26357_26384()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 26357, 26384);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_26357_26397(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 26357, 26397);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionState
                f_1652_26357_26403(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 26357, 26403);
                    return return_v;
                }


                string
                f_1652_26627_26692()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnServerStateValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 26627, 26692);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_26590_26693(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 26590, 26693);
                    return return_v;
                }


                System.IO.MemoryStream
                f_1652_26795_26813()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 26795, 26813);
                    return return_v;
                }


                int
                f_1652_26828_26912(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 26828, 26912);
                    return 0;
                }


                long
                f_1652_26929_26971(System.IO.MemoryStream
                this_param, int
                offset, System.IO.SeekOrigin
                loc)
                {
                    var return_v = this_param.Seek((long)offset, loc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 26929, 26971);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1652_27032_27101(System.IO.MemoryStream
                serializedDataStream, System.Management.Automation.Remoting.Fragmentor
                defragmentor)
                {
                    var return_v = RemoteDataObject<PSObject>.CreateFrom((System.IO.Stream)serializedDataStream, defragmentor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 27032, 27101);
                    return return_v;
                }


                string
                f_1652_27223_27282()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 27223, 27282);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_27186_27283(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 27186, 27283);
                    return return_v;
                }


                System.Management.Automation.RemotingDestination
                f_1652_27320_27348(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 27320, 27348);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1652_27384_27409(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 27384, 27409);
                    return return_v;
                }


                string
                f_1652_27525_27584()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 27525, 27584);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_27488_27585(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 27488, 27585);
                    return return_v;
                }


                string
                f_1652_27900_27959()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 27900, 27959);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_27863_27960(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 27863, 27960);
                    return return_v;
                }


                int
                f_1652_28061_28175(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 28061, 28175);
                    return 0;
                }


                long
                f_1652_28205_28260(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetFragmentId(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 28205, 28260);
                    return return_v;
                }


                bool
                f_1652_28283_28343(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetIsStartFragment(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 28283, 28343);
                    return return_v;
                }


                bool
                f_1652_28366_28424(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetIsEndFragment(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 28366, 28424);
                    return return_v;
                }


                int
                f_1652_28452_28507(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetBlobLength(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 28452, 28507);
                    return return_v;
                }


                string
                f_1652_28677_28736()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 28677, 28736);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_28640_28737(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 28640, 28737);
                    return return_v;
                }


                string
                f_1652_28866_28925()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 28866, 28925);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_28829_28926(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 28829, 28926);
                    return return_v;
                }


                System.IO.MemoryStream
                f_1652_29016_29034()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 29016, 29034);
                    return return_v;
                }


                int
                f_1652_29049_29136(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 29049, 29136);
                    return 0;
                }


                long
                f_1652_29153_29195(System.IO.MemoryStream
                this_param, int
                offset, System.IO.SeekOrigin
                loc)
                {
                    var return_v = this_param.Seek((long)offset, loc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 29153, 29195);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1652_29265_29334(System.IO.MemoryStream
                serializedDataStream, System.Management.Automation.Remoting.Fragmentor
                defragmentor)
                {
                    var return_v = RemoteDataObject<PSObject>.CreateFrom((System.IO.Stream)serializedDataStream, defragmentor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 29265, 29334);
                    return return_v;
                }


                string
                f_1652_29465_29530()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnServerStateValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 29465, 29530);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_29428_29531(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 29428, 29531);
                    return return_v;
                }


                System.Management.Automation.RemotingDestination
                f_1652_29568_29605(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 29568, 29605);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1652_29641_29675(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 29641, 29675);
                    return return_v;
                }


                string
                f_1652_29793_29852()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 29793, 29852);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_29756_29853(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 29756, 29853);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_30118_30139(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 30118, 30139);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_30081_30140(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetSessionCapability((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 30081, 30140);
                    return return_v;
                }


                string
                f_1652_30406_30465()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 30406, 30465);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_30369_30466(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 30369, 30466);
                    return return_v;
                }


                bool
                f_1652_30534_30587(System.Management.Automation.Remoting.ServerRemoteSession
                this_param, System.Management.Automation.Remoting.RemoteSessionCapability
                clientCapability, bool
                onConnect)
                {
                    var return_v = this_param.RunServerNegotiationAlgorithm(clientCapability, onConnect);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 30534, 30587);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_30956_30986(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 30956, 30986);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1652_30956_30997(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 30956, 30997);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1652_30956_31033(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 30956, 31033);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_31045_31075(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 31045, 31075);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1652_31045_31086(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 31045, 31086);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1652_31045_31122(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 31045, 31122);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_31270_31300(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 31270, 31300);
                    return return_v;
                }


                int
                f_1652_31238_31301(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetMinRunspaces(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 31238, 31301);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_31386_31416(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 31386, 31416);
                    return return_v;
                }


                int
                f_1652_31354_31417(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetMaxRunspaces(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 31354, 31417);
                    return return_v;
                }


                string
                f_1652_31637_31696()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 31637, 31696);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_31600_31697(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 31600, 31697);
                    return return_v;
                }


                string
                f_1652_32087_32146()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 32087, 32146);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_32050_32147(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 32050, 32147);
                    return return_v;
                }


                string
                f_1652_32287_32352()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnServerStateValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 32287, 32352);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_32250_32353(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 32250, 32353);
                    return return_v;
                }


                System.Guid
                f_1652_32511_32551(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 32511, 32551);
                    return return_v;
                }


                System.Guid
                f_1652_32555_32585(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 32555, 32585);
                    return return_v;
                }


                string
                f_1652_32662_32721()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnInputValidation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 32662, 32721);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_32625_32722(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 32625, 32722);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1652_33189_33221(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 33189, 33221);
                    return return_v;
                }


                int
                f_1652_33189_33239(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.GetMaxRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 33189, 33239);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1652_33293_33325(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 33293, 33325);
                    return return_v;
                }


                int
                f_1652_33293_33343(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.GetMinRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 33293, 33343);
                    return return_v;
                }


                string
                f_1652_33452_33528()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnMismatchedRunspacePoolProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 33452, 33528);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_33415_33529(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 33415, 33529);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_33810_33817()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 33810, 33817);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_33810_33834(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 33810, 33834);
                    return return_v;
                }


                System.Guid
                f_1652_33836_33866(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 33836, 33866);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1652_33762_33867(System.Management.Automation.Remoting.RemoteSessionCapability
                capability, System.Guid
                runspacePoolId)
                {
                    var return_v = RemotingEncoder.GenerateServerSessionCapability(capability, runspacePoolId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 33762, 33867);
                    return return_v;
                }


                System.Guid
                f_1652_33967_33997(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 33967, 33997);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1652_34095_34127(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 34095, 34127);
                    return return_v;
                }


                int
                f_1652_34095_34145(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.GetMaxRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 34095, 34145);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1652_34243_34275(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 34243, 34275);
                    return return_v;
                }


                int
                f_1652_34243_34293(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.GetMinRunspaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 34243, 34293);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1652_33922_34294(System.Guid
                runspacePoolId, int
                minRunspaces, int
                maxRunspaces)
                {
                    var return_v = RemotingEncoder.GenerateRunspacePoolInitData(runspacePoolId, minRunspaces, maxRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 33922, 34294);
                    return return_v;
                }


                System.Management.Automation.Remoting.SerializedDataStream
                f_1652_34823_34857(int
                fragmentSize)
                {
                    var return_v = new System.Management.Automation.Remoting.SerializedDataStream(fragmentSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 34823, 34857);
                    return return_v;
                }


                int
                f_1652_34924_34938(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Enter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 34924, 34938);
                    return 0;
                }


                int
                f_1652_34953_34993(System.Management.Automation.Remoting.RemoteDataObject
                this_param, System.Management.Automation.Remoting.SerializedDataStream
                streamToWriteTo, System.Management.Automation.Remoting.Fragmentor
                fragmentor)
                {
                    this_param.Serialize((System.IO.Stream)streamToWriteTo, fragmentor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 34953, 34993);
                    return 0;
                }


                int
                f_1652_35008_35021(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Exit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35008, 35021);
                    return 0;
                }


                int
                f_1652_35036_35050(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Enter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35036, 35050);
                    return 0;
                }


                int
                f_1652_35065_35115(System.Management.Automation.Remoting.RemoteDataObject
                this_param, System.Management.Automation.Remoting.SerializedDataStream
                streamToWriteTo, System.Management.Automation.Remoting.Fragmentor
                fragmentor)
                {
                    this_param.Serialize((System.IO.Stream)streamToWriteTo, fragmentor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35065, 35115);
                    return 0;
                }


                int
                f_1652_35130_35143(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Exit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35130, 35143);
                    return 0;
                }


                byte[]
                f_1652_35177_35190(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35177, 35190);
                    return return_v;
                }


                int
                f_1652_35205_35280(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35205, 35280);
                    return 0;
                }


                int
                f_1652_35295_35311(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35295, 35311);
                    return 0;
                }


                bool
                f_1652_35627_35990(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 35627, 35990);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1652_36007_36047(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 36007, 36047);
                    return return_v;
                }


                int
                f_1652_36007_36064(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param)
                {
                    this_param.ProcessConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 36007, 36064);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 24653, 36097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 24653, 36097);
            }
        }

        internal void HandlePostConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 36196, 36402);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 36254, 36391) || true) && (_runspacePoolDriver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 36254, 36391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 36319, 36376);

                    f_1652_36319_36375(_runspacePoolDriver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 36254, 36391);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 36196, 36402);

                int
                f_1652_36319_36375(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    this_param.SendApplicationPrivateDataToClient();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 36319, 36375);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 36196, 36402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 36196, 36402);
            }
        }

        private void HandleCreateRunspacePool(object sender, RemoteDataEventArgs createRunspaceEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 36773, 45123);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 36894, 37048) || true) && (createRunspaceEventArg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 36894, 37048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 36962, 37033);

                    throw f_1652_36968_37032("createRunspaceEventArg");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 36894, 37048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 37064, 37138);

                RemoteDataObject<PSObject>
                rcvdData = f_1652_37102_37137(createRunspaceEventArg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 37152, 37210);

                f_1652_37152_37209(rcvdData != null, "rcvdData must be non-null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 37386, 37517) || true) && (f_1652_37390_37397() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 37386, 37517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 37439, 37502);

                    _senderInfo.ClientTimeZone = f_1652_37468_37501(f_1652_37468_37492(f_1652_37468_37475()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 37386, 37517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 37533, 37623);

                _senderInfo.ApplicationArguments = f_1652_37568_37622(f_1652_37608_37621(rcvdData));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 37749, 37917);

                ConfigurationDataFromXML
                configurationData =
                f_1652_37811_37916(_configProviderId, _initParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 37983, 38073);

                configurationData.InitializationScriptForOutOfProcessRunspace = _initScriptForOutOfProcRS;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38219, 38283);

                _maxRecvdObjectSize = configurationData.MaxReceivedObjectSizeMB;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38297, 38367);

                _maxRecvdDataSizeCommand = configurationData.MaxReceivedCommandSizeMB;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38383, 38431);

                DISCPowerShellConfiguration
                discProvider = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38447, 39109) || true) && (f_1652_38451_38505(configurationData.ConfigFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 38447, 39109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38539, 38620);

                    _sessionConfigProvider = f_1652_38564_38619(configurationData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 38447, 39109);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 38447, 39109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38686, 38833);

                    System.Security.Principal.WindowsPrincipal
                    windowsPrincipal = f_1652_38748_38832(f_1652_38795_38831(f_1652_38795_38815(_senderInfo)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38853, 38926);

                    Func<string, bool>
                    validator = (role) => windowsPrincipal.IsInRole(role)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 38946, 39038);

                    discProvider = f_1652_38961_39037(configurationData.ConfigFilePath, validator);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 39056, 39094);

                    _sessionConfigProvider = discProvider;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 38447, 39109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 39351, 39460);

                PSPrimitiveDictionary
                applicationPrivateData = f_1652_39398_39459(_sessionConfigProvider, _senderInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 39476, 39523);

                InitialSessionState
                rsSessionStateToUse = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 39539, 40211) || true) && (configurationData.SessionConfigurationData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 39539, 40211);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 39671, 39840);

                        rsSessionStateToUse =
                        f_1652_39718_39839(_sessionConfigProvider, configurationData.SessionConfigurationData, _senderInfo, _configProviderId);
                    }
                    catch (NotImplementedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1652, 39877, 40049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 39949, 40030);

                        rsSessionStateToUse = f_1652_39971_40029(_sessionConfigProvider, _senderInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1652, 39877, 40049);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 39539, 40211);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 39539, 40211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 40115, 40196);

                    rsSessionStateToUse = f_1652_40137_40195(_sessionConfigProvider, _senderInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 39539, 40211);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 40227, 40423) || true) && (rsSessionStateToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 40227, 40423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 40292, 40408);

                    throw f_1652_40298_40407(f_1652_40341_40387(), _configProviderId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 40227, 40423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 40439, 40491);

                rsSessionStateToUse.ThrowOnRunspaceOpenError = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 40578, 40932);

                f_1652_40578_40931(f_1652_40578_40607(rsSessionStateToUse), f_1652_40630_40930(RemoteDataNameStrings.SenderInfoPreferenceVariable, _senderInfo, f_1652_40759_40884(f_1652_40837_40883()), ScopedItemOptions.ReadOnly));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 41105, 41136);

                Version
                psClientVersion = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 41150, 42575) || true) && (f_1652_41154_41186(_senderInfo) != null && (DynAbs.Tracing.TraceSender.Expression_True(1652, 41154, 41260) && f_1652_41198_41260(f_1652_41198_41230(_senderInfo), "PSversionTable")))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 41150, 42575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 41294, 41397);

                    var
                    value = f_1652_41306_41371(f_1652_41320_41370(f_1652_41320_41352(_senderInfo), "PSversionTable")) as PSPrimitiveDictionary
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 41415, 42560) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 41415, 42560);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 41474, 42347) || true) && (f_1652_41478_41516(value, "WSManStackVersion"))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 41474, 42347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 41566, 41643);

                            var
                            wsmanStackVersion = f_1652_41590_41631(f_1652_41604_41630(value, "WSManStackVersion")) as Version
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 41669, 42324) || true) && (wsmanStackVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1652, 41673, 41729) && f_1652_41702_41725(wsmanStackVersion) < 3))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 41669, 42324);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 42024, 42297);

                                f_1652_42024_42296(f_1652_42024_42052(rsSessionStateToUse), f_1652_42091_42295(RemoteDataNameStrings.PSv2TabExpansionFunction, RemoteDataNameStrings.PSv2TabExpansionFunctionText));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 41669, 42324);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 41474, 42347);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 42371, 42541) || true) && (f_1652_42375_42405(value, "PSVersion"))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 42371, 42541);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 42455, 42518);

                            psClientVersion = f_1652_42473_42506(f_1652_42487_42505(value, "PSVersion")) as Version;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 42371, 42541);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 41415, 42560);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 41150, 42575);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 42591, 43019) || true) && (!f_1652_42596_42665(configurationData.EndPointConfigurationTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 42591, 43019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 42799, 42886);

                    _maxRecvdObjectSize = f_1652_42821_42885(_sessionConfigProvider, _senderInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 42904, 43004);

                    _maxRecvdDataSizeCommand = f_1652_42931_43003(_sessionConfigProvider, _senderInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 42591, 43019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43035, 43151);

                f_1652_43035_43102(f_1652_43035_43079(f_1652_43035_43062())).MaximumReceivedObjectSize = _maxRecvdObjectSize;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43301, 43353);

                Guid
                clientRunspacePoolId = f_1652_43329_43352(rcvdData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43367, 43433);

                int
                minRunspaces = f_1652_43386_43432(f_1652_43418_43431(rcvdData))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43447, 43513);

                int
                maxRunspaces = f_1652_43466_43512(f_1652_43498_43511(rcvdData))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43527, 43607);

                PSThreadOptions
                threadOptions = f_1652_43559_43606(f_1652_43592_43605(rcvdData))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43621, 43702);

                ApartmentState
                apartmentState = f_1652_43653_43701(f_1652_43687_43700(rcvdData))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43716, 43779);

                HostInfo
                hostInfo = f_1652_43736_43778(f_1652_43764_43777(rcvdData))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43795, 44017) || true) && (_runspacePoolDriver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 43795, 44017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 43860, 44002);

                    throw f_1652_43866_44001(f_1652_43903_43947(), f_1652_43970_44000(_runspacePoolDriver));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 43795, 44017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 44044, 44157);

                bool
                isAdministrator = f_1652_44067_44156(f_1652_44067_44087(_senderInfo), System.Security.Principal.WindowsBuiltInRole.Administrator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 44231, 44857);

                ServerRunspacePoolDriver
                tmpDriver = f_1652_44268_44856(clientRunspacePoolId, minRunspaces, maxRunspaces, threadOptions, apartmentState, hostInfo, rsSessionStateToUse, applicationPrivateData, configurationData, f_1652_44623_44672(f_1652_44623_44655(this)), isAdministrator, f_1652_44725_44749(f_1652_44725_44732()), psClientVersion, _configurationName, _initialLocation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 44947, 45004);

                f_1652_44947_45003(ref _runspacePoolDriver, tmpDriver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 45018, 45070);

                _runspacePoolDriver.Closed += HandleResourceClosing;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 45084, 45112);

                f_1652_45084_45111(_runspacePoolDriver);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 36773, 45123);

                System.Management.Automation.PSArgumentNullException
                f_1652_36968_37032(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 36968, 37032);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1652_37102_37137(System.Management.Automation.RemoteDataEventArgs
                this_param)
                {
                    var return_v = this_param.ReceivedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 37102, 37137);
                    return return_v;
                }


                int
                f_1652_37152_37209(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 37152, 37209);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_37390_37397()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 37390, 37397);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_37468_37475()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 37468, 37475);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_37468_37492(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ClientCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 37468, 37492);
                    return return_v;
                }


                System.TimeZoneInfo
                f_1652_37468_37501(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.TimeZone;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 37468, 37501);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_37608_37621(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 37608, 37621);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1652_37568_37622(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetApplicationArguments(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 37568, 37622);
                    return return_v;
                }


                System.Management.Automation.Remoting.ConfigurationDataFromXML
                f_1652_37811_37916(string
                shellId, string
                initializationParameters)
                {
                    var return_v = PSSessionConfiguration.LoadEndPointConfiguration(shellId, initializationParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 37811, 37916);
                    return return_v;
                }


                bool
                f_1652_38451_38505(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 38451, 38505);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSSessionConfiguration
                f_1652_38564_38619(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param)
                {
                    var return_v = this_param.CreateEndPointConfigurationInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 38564, 38619);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1652_38795_38815(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.UserInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 38795, 38815);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1652_38795_38831(System.Management.Automation.Remoting.PSPrincipal
                this_param)
                {
                    var return_v = this_param.WindowsIdentity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 38795, 38831);
                    return return_v;
                }


                System.Security.Principal.WindowsPrincipal
                f_1652_38748_38832(System.Security.Principal.WindowsIdentity
                ntIdentity)
                {
                    var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 38748, 38832);
                    return return_v;
                }


                System.Management.Automation.Remoting.DISCPowerShellConfiguration
                f_1652_38961_39037(string
                configFile, System.Func<string, bool>
                roleVerifier)
                {
                    var return_v = new System.Management.Automation.Remoting.DISCPowerShellConfiguration(configFile, roleVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 38961, 39037);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1652_39398_39459(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo)
                {
                    var return_v = this_param.GetApplicationPrivateData(senderInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 39398, 39459);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1652_39718_39839(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param, System.Management.Automation.Remoting.PSSessionConfigurationData
                sessionConfigurationData, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo, string
                configProviderId)
                {
                    var return_v = this_param.GetInitialSessionState(sessionConfigurationData, senderInfo, configProviderId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 39718, 39839);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1652_39971_40029(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo)
                {
                    var return_v = this_param.GetInitialSessionState(senderInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 39971, 40029);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1652_40137_40195(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo)
                {
                    var return_v = this_param.GetInitialSessionState(senderInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 40137, 40195);
                    return return_v;
                }


                string
                f_1652_40341_40387()
                {
                    var return_v = RemotingErrorIdStrings.InitialSessionStateNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 40341, 40387);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1652_40298_40407(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 40298, 40407);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                f_1652_40578_40607(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 40578, 40607);
                    return return_v;
                }


                string
                f_1652_40837_40883()
                {
                    var return_v = RemotingErrorIdStrings.PSSenderInfoDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 40837, 40883);
                    return return_v;
                }


                string
                f_1652_40759_40884(string
                resourceString, params object[]
                args)
                {
                    var return_v = Remoting.PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 40759, 40884);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateVariableEntry
                f_1652_40630_40930(string
                name, System.Management.Automation.Remoting.PSSenderInfo
                value, string
                description, System.Management.Automation.ScopedItemOptions
                options)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateVariableEntry(name, (object)value, description, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 40630, 40930);
                    return return_v;
                }


                int
                f_1652_40578_40931(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateVariableEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 40578, 40931);
                    return 0;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1652_41154_41186(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ApplicationArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 41154, 41186);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1652_41198_41230(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ApplicationArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 41198, 41230);
                    return return_v;
                }


                bool
                f_1652_41198_41260(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 41198, 41260);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1652_41320_41352(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ApplicationArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 41320, 41352);
                    return return_v;
                }


                object
                f_1652_41320_41370(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 41320, 41370);
                    return return_v;
                }


                object
                f_1652_41306_41371(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 41306, 41371);
                    return return_v;
                }


                bool
                f_1652_41478_41516(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 41478, 41516);
                    return return_v;
                }


                object
                f_1652_41604_41630(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 41604, 41630);
                    return return_v;
                }


                object
                f_1652_41590_41631(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 41590, 41631);
                    return return_v;
                }


                int
                f_1652_41702_41725(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 41702, 41725);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1652_42024_42052(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 42024, 42052);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateFunctionEntry
                f_1652_42091_42295(string
                name, string
                definition)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateFunctionEntry(name, definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 42091, 42295);
                    return return_v;
                }


                int
                f_1652_42024_42296(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateFunctionEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 42024, 42296);
                    return 0;
                }


                bool
                f_1652_42375_42405(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 42375, 42405);
                    return return_v;
                }


                object
                f_1652_42487_42505(System.Management.Automation.PSPrimitiveDictionary
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 42487, 42505);
                    return return_v;
                }


                object
                f_1652_42473_42506(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 42473, 42506);
                    return return_v;
                }


                bool
                f_1652_42596_42665(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 42596, 42665);
                    return return_v;
                }


                int?
                f_1652_42821_42885(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo)
                {
                    var return_v = this_param.GetMaximumReceivedObjectSize(senderInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 42821, 42885);
                    return return_v;
                }


                int?
                f_1652_42931_43003(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param, System.Management.Automation.Remoting.PSSenderInfo
                senderInfo)
                {
                    var return_v = this_param.GetMaximumReceivedDataSizePerCommand(senderInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 42931, 43003);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_43035_43062()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43035, 43062);
                    return return_v;
                }


                System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                f_1652_43035_43079(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.TransportManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43035, 43079);
                    return return_v;
                }


                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1652_43035_43102(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43035, 43102);
                    return return_v;
                }


                System.Guid
                f_1652_43329_43352(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43329, 43352);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_43418_43431(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43418, 43431);
                    return return_v;
                }


                int
                f_1652_43386_43432(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetMinRunspaces(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 43386, 43432);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_43498_43511(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43498, 43511);
                    return return_v;
                }


                int
                f_1652_43466_43512(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetMaxRunspaces(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 43466, 43512);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_43592_43605(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43592, 43605);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1652_43559_43606(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetThreadOptions(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 43559, 43606);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_43687_43700(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43687, 43700);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1652_43653_43701(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetApartmentState((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 43653, 43701);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1652_43764_43777(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43764, 43777);
                    return return_v;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1652_43736_43778(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetHostInfo(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 43736, 43778);
                    return return_v;
                }


                string
                f_1652_43903_43947()
                {
                    var return_v = RemotingErrorIdStrings.RunspaceAlreadyExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43903, 43947);
                    return return_v;
                }


                System.Guid
                f_1652_43970_44000(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 43970, 44000);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_43866_44001(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 43866, 44001);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1652_44067_44087(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.UserInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 44067, 44087);
                    return return_v;
                }


                bool
                f_1652_44067_44156(System.Management.Automation.Remoting.PSPrincipal
                this_param, System.Security.Principal.WindowsBuiltInRole
                role)
                {
                    var return_v = this_param.IsInRole(role);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 44067, 44156);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_44623_44655(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    var return_v = this_param.SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 44623, 44655);
                    return return_v;
                }


                System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                f_1652_44623_44672(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.TransportManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 44623, 44672);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_44725_44732()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 44725, 44732);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_44725_44749(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 44725, 44749);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDriver
                f_1652_44268_44856(System.Guid
                clientRunspacePoolId, int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Runspaces.PSThreadOptions
                threadOptions, System.Threading.ApartmentState
                apartmentState, System.Management.Automation.Remoting.HostInfo
                hostInfo, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState, System.Management.Automation.PSPrimitiveDictionary
                applicationPrivateData, System.Management.Automation.Remoting.ConfigurationDataFromXML
                configData, System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                transportManager, bool
                isAdministrator, System.Management.Automation.Remoting.RemoteSessionCapability
                serverCapability, System.Version
                psClientVersion, string
                configurationName, string
                initialLocation)
                {
                    var return_v = new System.Management.Automation.ServerRunspacePoolDriver(clientRunspacePoolId, minRunspaces, maxRunspaces, threadOptions, apartmentState, hostInfo, initialSessionState, applicationPrivateData, configData, transportManager, isAdministrator, serverCapability, psClientVersion, configurationName, initialLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 44268, 44856);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDriver
                f_1652_44947_45003(ref System.Management.Automation.ServerRunspacePoolDriver
                location1, System.Management.Automation.ServerRunspacePoolDriver
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 44947, 45003);
                    return return_v;
                }


                int
                f_1652_45084_45111(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 45084, 45111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 36773, 45123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 36773, 45123);
            }
        }

        private void HandleNegotiationReceived(object sender, RemoteSessionNegotiationEventArgs negotiationEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 45664, 47756);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 45797, 45945) || true) && (negotiationEventArg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 45797, 45945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 45862, 45930);

                    throw f_1652_45868_45929("negotiationEventArg");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 45797, 45945);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 45997, 46068);

                    f_1652_45997_46004().ClientCapability = f_1652_46024_46067(negotiationEventArg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 46165, 46247);

                    f_1652_46165_46246(this, f_1652_46195_46238(negotiationEventArg), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 46323, 46460);

                    RemoteSessionStateMachineEventArgs
                    sendingNegotiationArg = f_1652_46382_46459(RemoteSessionEvent.NegotiationSending)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 46478, 46553);

                    f_1652_46478_46552(f_1652_46478_46518(f_1652_46478_46505()), sendingNegotiationArg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 46654, 46816);

                    RemoteSessionStateMachineEventArgs
                    negotiationCompletedArg =
                    f_1652_46736_46815(RemoteSessionEvent.NegotiationCompleted)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 46834, 46911);

                    f_1652_46834_46910(f_1652_46834_46874(f_1652_46834_46861()), negotiationCompletedArg);
                }
                catch (PSRemotingDataStructureException dse)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1652, 46940, 47745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 47181, 47339);

                    RemoteSessionStateMachineEventArgs
                    sendingNegotiationArg =
                    f_1652_47261_47338(RemoteSessionEvent.NegotiationSending)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 47357, 47432);

                    f_1652_47357_47431(f_1652_47357_47397(f_1652_47357_47384()), sendingNegotiationArg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 47452, 47638);

                    RemoteSessionStateMachineEventArgs
                    negotiationFailedArg =
                    f_1652_47531_47637(RemoteSessionEvent.NegotiationFailed, dse)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 47656, 47730);

                    f_1652_47656_47729(f_1652_47656_47696(f_1652_47656_47683()), negotiationFailedArg);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1652, 46940, 47745);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 45664, 47756);

                System.Management.Automation.PSArgumentNullException
                f_1652_45868_45929(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 45868, 45929);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_45997_46004()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 45997, 46004);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_46024_46067(System.Management.Automation.RemoteSessionNegotiationEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteSessionCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 46024, 46067);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_46195_46238(System.Management.Automation.RemoteSessionNegotiationEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteSessionCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 46195, 46238);
                    return return_v;
                }


                bool
                f_1652_46165_46246(System.Management.Automation.Remoting.ServerRemoteSession
                this_param, System.Management.Automation.Remoting.RemoteSessionCapability
                clientCapability, bool
                onConnect)
                {
                    var return_v = this_param.RunServerNegotiationAlgorithm(clientCapability, onConnect);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 46165, 46246);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_46382_46459(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 46382, 46459);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_46478_46505()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 46478, 46505);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_46478_46518(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 46478, 46518);
                    return return_v;
                }


                int
                f_1652_46478_46552(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 46478, 46552);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_46736_46815(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 46736, 46815);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_46834_46861()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 46834, 46861);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_46834_46874(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 46834, 46874);
                    return return_v;
                }


                int
                f_1652_46834_46910(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 46834, 46910);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_47261_47338(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 47261, 47338);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_47357_47384()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 47357, 47384);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_47357_47397(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 47357, 47397);
                    return return_v;
                }


                int
                f_1652_47357_47431(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 47357, 47431);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_47531_47637(System.Management.Automation.RemoteSessionEvent
                stateEvent, System.Management.Automation.Remoting.PSRemotingDataStructureException
                reason)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 47531, 47637);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_47656_47683()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 47656, 47683);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_47656_47696(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 47656, 47696);
                    return return_v;
                }


                int
                f_1652_47656_47729(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 47656, 47729);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 45664, 47756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 45664, 47756);
            }
        }

        private void HandleSessionDSHandlerClosing(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 48002, 48520);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 48105, 48213) || true) && (_runspacePoolDriver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 48105, 48213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 48170, 48198);

                    f_1652_48170_48197(_runspacePoolDriver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 48105, 48213);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 48345, 48509) || true) && (_sessionConfigProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 48345, 48509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 48413, 48446);

                    f_1652_48413_48445(_sessionConfigProvider);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 48464, 48494);

                    _sessionConfigProvider = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 48345, 48509);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 48002, 48520);

                int
                f_1652_48170_48197(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 48170, 48197);
                    return 0;
                }


                int
                f_1652_48413_48445(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 48413, 48445);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 48002, 48520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 48002, 48520);
            }
        }

        private void HandleResourceClosing(object sender, EventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 48805, 49158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 48895, 49014);

                RemoteSessionStateMachineEventArgs
                closeSessionArgs = f_1652_48949_49013(RemoteSessionEvent.Close)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 49028, 49063);

                closeSessionArgs.RemoteData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 49077, 49147);

                f_1652_49077_49146(f_1652_49077_49117(f_1652_49077_49104()), closeSessionArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 48805, 49158);

                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1652_48949_49013(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 48949, 49013);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1652_49077_49104()
                {
                    var return_v = SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 49077, 49104);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                f_1652_49077_49117(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    var return_v = this_param.StateMachine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 49077, 49117);
                    return return_v;
                }


                int
                f_1652_49077_49146(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 49077, 49146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 48805, 49158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 48805, 49158);
            }
        }

        private bool RunServerNegotiationAlgorithm(RemoteSessionCapability clientCapability, bool onConnect)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 50209, 57287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 50334, 50415);

                f_1652_50334_50414(clientCapability != null, "Client capability cache must be non-null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 50431, 50496);

                Version
                clientProtocolVersion = f_1652_50463_50495(clientCapability)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 50510, 50583);

                Version
                serverProtocolVersion = f_1652_50542_50582(f_1652_50542_50566(f_1652_50542_50549()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 50599, 55649) || true) && (onConnect)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 50599, 55649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 50646, 50676);

                    bool
                    connectSupported = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 51161, 52145) || true) && (f_1652_51165_51192(clientProtocolVersion) == f_1652_51196_51235(RemotingConstants.ProtocolVersion))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 51161, 52145);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 51277, 52126) || true) && (f_1652_51281_51308(clientProtocolVersion) == f_1652_51312_51358(RemotingConstants.ProtocolVersionWin8RTM))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 51277, 52126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 51527, 51551);

                            connectSupported = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 51577, 51642);

                            serverProtocolVersion = RemotingConstants.ProtocolVersionWin8RTM;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 51668, 51733);

                            f_1652_51668_51692(f_1652_51668_51675()).ProtocolVersion = serverProtocolVersion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 51277, 52126);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 51277, 52126);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 51783, 52126) || true) && (f_1652_51787_51814(clientProtocolVersion) > f_1652_51817_51863(RemotingConstants.ProtocolVersionWin8RTM))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 51783, 52126);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 52079, 52103);

                                connectSupported = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 51783, 52126);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 51277, 52126);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 51161, 52145);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 52165, 52855) || true) && (!connectSupported)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 52165, 52855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 52365, 52792);

                        PSRemotingDataStructureException
                        reasonOfFailure =
                        f_1652_52441_52791(f_1652_52478_52533(), RemoteDataNameStrings.PS_STARTUP_PROTOCOL_VERSION_NAME, clientProtocolVersion, f_1652_52701_52726(), RemotingConstants.ProtocolVersion)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 52814, 52836);

                        throw reasonOfFailure;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 52165, 52855);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 50599, 55649);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 50599, 55649);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 52978, 53478) || true) && (clientProtocolVersion == RemotingConstants.ProtocolVersionWin8RTM && (DynAbs.Tracing.TraceSender.Expression_True(1652, 52982, 53190) && (
                                            (serverProtocolVersion == RemotingConstants.ProtocolVersionWin10RTM)
                                        )))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 52978, 53478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 53307, 53372);

                        serverProtocolVersion = RemotingConstants.ProtocolVersionWin8RTM;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 53394, 53459);

                        f_1652_53394_53418(f_1652_53394_53401()).ProtocolVersion = serverProtocolVersion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 52978, 53478);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 53561, 54157) || true) && (clientProtocolVersion == RemotingConstants.ProtocolVersionWin7RTM && (DynAbs.Tracing.TraceSender.Expression_True(1652, 53565, 53869) && (
                                            (serverProtocolVersion == RemotingConstants.ProtocolVersionWin8RTM) || (DynAbs.Tracing.TraceSender.Expression_False(1652, 53682, 53846) || (serverProtocolVersion == RemotingConstants.ProtocolVersionWin10RTM)
                    ))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 53561, 54157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 53986, 54051);

                        serverProtocolVersion = RemotingConstants.ProtocolVersionWin7RTM;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 54073, 54138);

                        f_1652_54073_54097(f_1652_54073_54080()).ProtocolVersion = serverProtocolVersion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 53561, 54157);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 54249, 54937) || true) && (clientProtocolVersion == RemotingConstants.ProtocolVersionWin7RC && (DynAbs.Tracing.TraceSender.Expression_True(1652, 54253, 54652) && (
                                            (serverProtocolVersion == RemotingConstants.ProtocolVersionWin7RTM) || (DynAbs.Tracing.TraceSender.Expression_False(1652, 54369, 54532) || (serverProtocolVersion == RemotingConstants.ProtocolVersionWin8RTM)) || (DynAbs.Tracing.TraceSender.Expression_False(1652, 54369, 54629) || (serverProtocolVersion == RemotingConstants.ProtocolVersionWin10RTM)
                    ))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 54249, 54937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 54767, 54831);

                        serverProtocolVersion = RemotingConstants.ProtocolVersionWin7RC;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 54853, 54918);

                        f_1652_54853_54877(f_1652_54853_54860()).ProtocolVersion = serverProtocolVersion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 54249, 54937);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 54957, 55634) || true) && (!((f_1652_54964_54991(clientProtocolVersion) == f_1652_54995_55022(serverProtocolVersion)) && (DynAbs.Tracing.TraceSender.Expression_True(1652, 54963, 55110) && (f_1652_55051_55078(clientProtocolVersion) >= f_1652_55082_55109(serverProtocolVersion)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 54957, 55634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 55153, 55571);

                        PSRemotingDataStructureException
                        reasonOfFailure =
                        f_1652_55229_55570(f_1652_55266_55312(), RemoteDataNameStrings.PS_STARTUP_PROTOCOL_VERSION_NAME, clientProtocolVersion, f_1652_55480_55505(), RemotingConstants.ProtocolVersion)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 55593, 55615);

                        throw reasonOfFailure;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 54957, 55634);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 50599, 55649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 55697, 55750);

                Version
                clientPSVersion = f_1652_55723_55749(clientCapability)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 55764, 55825);

                Version
                serverPSVersion = f_1652_55790_55824(f_1652_55790_55814(f_1652_55790_55797()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 55839, 56423) || true) && (!((f_1652_55846_55867(clientPSVersion) == f_1652_55871_55892(serverPSVersion)) && (DynAbs.Tracing.TraceSender.Expression_True(1652, 55845, 55964) && (f_1652_55917_55938(clientPSVersion) >= f_1652_55942_55963(serverPSVersion)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 55839, 56423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 55999, 56368);

                    PSRemotingDataStructureException
                    reasonOfFailure =
                    f_1652_56071_56367(f_1652_56108_56154(), RemoteDataNameStrings.PSVersion, clientPSVersion, f_1652_56281_56306(), RemotingConstants.ProtocolVersion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 56386, 56408);

                    throw reasonOfFailure;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 55839, 56423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 56482, 56547);

                Version
                clientSerVersion = f_1652_56509_56546(clientCapability)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 56561, 56634);

                Version
                serverSerVersion = f_1652_56588_56633(f_1652_56588_56612(f_1652_56588_56595()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 56648, 57248) || true) && (!((f_1652_56655_56677(clientSerVersion) == f_1652_56681_56703(serverSerVersion)) && (DynAbs.Tracing.TraceSender.Expression_True(1652, 56654, 56777) && (f_1652_56728_56750(clientSerVersion) >= f_1652_56754_56776(serverSerVersion)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 56648, 57248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 56812, 57193);

                    PSRemotingDataStructureException
                    reasonOfFailure =
                    f_1652_56884_57192(f_1652_56921_56967(), RemoteDataNameStrings.SerializationVersion, clientSerVersion, f_1652_57106_57131(), RemotingConstants.ProtocolVersion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 57211, 57233);

                    throw reasonOfFailure;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 56648, 57248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 57264, 57276);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 50209, 57287);

                int
                f_1652_50334_50414(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 50334, 50414);
                    return 0;
                }


                System.Version
                f_1652_50463_50495(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.ProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 50463, 50495);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_50542_50549()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 50542, 50549);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_50542_50566(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 50542, 50566);
                    return return_v;
                }


                System.Version
                f_1652_50542_50582(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.ProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 50542, 50582);
                    return return_v;
                }


                int
                f_1652_51165_51192(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51165, 51192);
                    return return_v;
                }


                int
                f_1652_51196_51235(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51196, 51235);
                    return return_v;
                }


                int
                f_1652_51281_51308(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51281, 51308);
                    return return_v;
                }


                int
                f_1652_51312_51358(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51312, 51358);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_51668_51675()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51668, 51675);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_51668_51692(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51668, 51692);
                    return return_v;
                }


                int
                f_1652_51787_51814(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51787, 51814);
                    return return_v;
                }


                int
                f_1652_51817_51863(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 51817, 51863);
                    return return_v;
                }


                string
                f_1652_52478_52533()
                {
                    var return_v = RemotingErrorIdStrings.ServerConnectFailedOnNegotiation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 52478, 52533);
                    return return_v;
                }


                string
                f_1652_52701_52726()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 52701, 52726);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_52441_52791(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 52441, 52791);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_53394_53401()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 53394, 53401);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_53394_53418(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 53394, 53418);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_54073_54080()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 54073, 54080);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_54073_54097(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 54073, 54097);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_54853_54860()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 54853, 54860);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_54853_54877(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 54853, 54877);
                    return return_v;
                }


                int
                f_1652_54964_54991(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 54964, 54991);
                    return return_v;
                }


                int
                f_1652_54995_55022(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 54995, 55022);
                    return return_v;
                }


                int
                f_1652_55051_55078(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55051, 55078);
                    return return_v;
                }


                int
                f_1652_55082_55109(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55082, 55109);
                    return return_v;
                }


                string
                f_1652_55266_55312()
                {
                    var return_v = RemotingErrorIdStrings.ServerNegotiationFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55266, 55312);
                    return return_v;
                }


                string
                f_1652_55480_55505()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55480, 55505);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_55229_55570(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 55229, 55570);
                    return return_v;
                }


                System.Version
                f_1652_55723_55749(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55723, 55749);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_55790_55797()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55790, 55797);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_55790_55814(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55790, 55814);
                    return return_v;
                }


                System.Version
                f_1652_55790_55824(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55790, 55824);
                    return return_v;
                }


                int
                f_1652_55846_55867(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55846, 55867);
                    return return_v;
                }


                int
                f_1652_55871_55892(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55871, 55892);
                    return return_v;
                }


                int
                f_1652_55917_55938(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55917, 55938);
                    return return_v;
                }


                int
                f_1652_55942_55963(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 55942, 55963);
                    return return_v;
                }


                string
                f_1652_56108_56154()
                {
                    var return_v = RemotingErrorIdStrings.ServerNegotiationFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56108, 56154);
                    return return_v;
                }


                string
                f_1652_56281_56306()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56281, 56306);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_56071_56367(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 56071, 56367);
                    return return_v;
                }


                System.Version
                f_1652_56509_56546(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.SerializationVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56509, 56546);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1652_56588_56595()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56588, 56595);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1652_56588_56612(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56588, 56612);
                    return return_v;
                }


                System.Version
                f_1652_56588_56633(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.SerializationVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56588, 56633);
                    return return_v;
                }


                int
                f_1652_56655_56677(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56655, 56677);
                    return return_v;
                }


                int
                f_1652_56681_56703(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56681, 56703);
                    return return_v;
                }


                int
                f_1652_56728_56750(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56728, 56750);
                    return return_v;
                }


                int
                f_1652_56754_56776(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56754, 56776);
                    return return_v;
                }


                string
                f_1652_56921_56967()
                {
                    var return_v = RemotingErrorIdStrings.ServerNegotiationFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 56921, 56967);
                    return return_v;
                }


                string
                f_1652_57106_57131()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 57106, 57131);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1652_56884_57192(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 56884, 57192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 50209, 57287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 50209, 57287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ServerRunspacePoolDriver GetRunspacePoolDriver(Guid clientRunspacePoolId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 57436, 57824);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 57543, 57635) || true) && (_runspacePoolDriver == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 57543, 57635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 57608, 57620);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 57543, 57635);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 57651, 57785) || true) && (f_1652_57655_57685(_runspacePoolDriver) == clientRunspacePoolId)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1652, 57651, 57785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 57743, 57770);

                    return _runspacePoolDriver;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1652, 57651, 57785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 57801, 57813);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 57436, 57824);

                System.Guid
                f_1652_57655_57685(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 57655, 57685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 57436, 57824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 57436, 57824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ApplyQuotaOnCommandTransportManager(AbstractServerTransportManager cmdTransportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1652, 58195, 58623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 58321, 58399);

                f_1652_58321_58398(cmdTransportManager != null, "cmdTransportManager cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 58413, 58507);

                f_1652_58413_58455(cmdTransportManager).MaximumReceivedDataSize = _maxRecvdDataSizeCommand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 58521, 58612);

                f_1652_58521_58563(cmdTransportManager).MaximumReceivedObjectSize = _maxRecvdObjectSize;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1652, 58195, 58623);

                int
                f_1652_58321_58398(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 58321, 58398);
                    return 0;
                }


                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1652_58413_58455(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param)
                {
                    var return_v = this_param.ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 58413, 58455);
                    return return_v;
                }


                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1652_58521_58563(System.Management.Automation.Remoting.Server.AbstractServerTransportManager
                this_param)
                {
                    var return_v = this_param.ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 58521, 58563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1652, 58195, 58623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 58195, 58623);
            }
        }

        static ServerRemoteSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1652, 2947, 58652);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1652, 3121, 3200);
            s_trace = f_1652_3131_3200("ServerRemoteSession", "ServerRemoteSession");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1652, 2947, 58652);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1652, 2947, 58652);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1652, 2947, 58652);

        static System.Management.Automation.PSTraceSource
        f_1652_3131_3200(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 3131, 3200);
            return return_v;
        }


        int
        f_1652_5390_5462(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 5390, 5462);
            return 0;
        }


        System.Management.Automation.Internal.PSRemotingCryptoHelper
        f_1652_5900_5929(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
        this_param)
        {
            var return_v = this_param.CryptoHelper;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 5900, 5929);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionContext
        f_1652_6049_6081()
        {
            var return_v = new System.Management.Automation.Remoting.ServerRemoteSessionContext();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 6049, 6081);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerImpl
        f_1652_6126_6186(System.Management.Automation.Remoting.ServerRemoteSession
        session, System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
        transportManager)
        {
            var return_v = new System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerImpl(session, transportManager);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1652, 6126, 6186);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
        f_1652_6235_6262()
        {
            var return_v = SessionDataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 6235, 6262);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
        f_1652_6277_6304()
        {
            var return_v = SessionDataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 6277, 6304);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
        f_1652_6374_6401()
        {
            var return_v = SessionDataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 6374, 6401);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
        f_1652_6465_6492()
        {
            var return_v = SessionDataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 6465, 6492);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
        f_1652_6555_6582()
        {
            var return_v = SessionDataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 6555, 6582);
            return return_v;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1652_6954_6993(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
        this_param)
        {
            var return_v = this_param.ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 6954, 6993);
            return return_v;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1652_7649_7688(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
        this_param)
        {
            var return_v = this_param.ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1652, 7649, 7688);
            return return_v;
        }

    }
}
