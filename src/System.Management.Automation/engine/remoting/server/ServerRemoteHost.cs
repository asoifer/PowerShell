// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ServerRemoteHost : PSHost, IHostSupportsInteractiveSession
    {
        private ServerRemoteHostUserInterface _remoteHostUserInterface;

        private ServerMethodExecutor _serverMethodExecutor;

        private Guid _clientRunspacePoolId;

        private Guid _clientPowerShellId;

        protected AbstractServerTransportManager _transportManager;

        private ServerDriverRemoteHost _serverDriverRemoteHost;

        internal ServerRemoteHost(
                    Guid clientRunspacePoolId,
                    Guid clientPowerShellId,
                    HostInfo hostInfo,
                    AbstractServerTransportManager transportManager,
                    Runspace runspace,
                    ServerDriverRemoteHost serverDriverRemoteHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1649, 1605, 2848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 713, 737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 863, 884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 1277, 1294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 1422, 1445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 3778, 3836);
                this.InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 4453, 4500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 4583, 4618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 1920, 1965);

                _clientRunspacePoolId = clientRunspacePoolId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 1979, 2020);

                _clientPowerShellId = clientPowerShellId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2034, 2092);

                f_1649_2034_2091(hostInfo != null, "Expected hostInfo != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2106, 2180);

                f_1649_2106_2179(transportManager != null, "Expected transportManager != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2253, 2273);

                HostInfo = hostInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2287, 2324);

                _transportManager = transportManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2338, 2387);

                _serverDriverRemoteHost = serverDriverRemoteHost;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2461, 2589);

                _serverMethodExecutor = f_1649_2485_2588(clientRunspacePoolId, clientPowerShellId, _transportManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2703, 2801);

                _remoteHostUserInterface = (DynAbs.Tracing.TraceSender.Conditional_F1(1649, 2730, 2751) || ((f_1649_2730_2751(hostInfo) && DynAbs.Tracing.TraceSender.Conditional_F2(1649, 2754, 2758)) || DynAbs.Tracing.TraceSender.Conditional_F3(1649, 2761, 2800))) ? null : f_1649_2761_2800(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 2817, 2837);

                Runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1649, 1605, 2848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 1605, 2848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 1605, 2848);
            }
        }

        internal ServerMethodExecutor ServerMethodExecutor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 3071, 3108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 3077, 3106);

                    return _serverMethodExecutor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 3071, 3108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 2996, 3119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 2996, 3119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PSHostUserInterface UI
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 3274, 3314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 3280, 3312);

                    return _remoteHostUserInterface;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 3274, 3314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 3211, 3325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 3211, 3325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 3455, 3489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 3461, 3487);

                    return "ServerRemoteHost";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 3455, 3489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 3403, 3500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 3403, 3500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 3637, 3682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 3643, 3680);

                    return RemotingConstants.HostVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 3637, 3682);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 3581, 3693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 3581, 3693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Guid InstanceId { get; }

        public virtual bool IsRunspacePushed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 3989, 4360);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 4025, 4345) || true) && (_serverDriverRemoteHost != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 4025, 4345);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 4102, 4150);

                        return f_1649_4109_4149(_serverDriverRemoteHost);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 4025, 4345);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 4025, 4345);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 4232, 4326);

                        throw f_1649_4238_4325(RemoteHostMethodId.GetIsRunspacePushed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 4025, 4345);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 3989, 4360);

                    bool
                    f_1649_4109_4149(System.Management.Automation.Remoting.ServerDriverRemoteHost
                    this_param)
                    {
                        var return_v = this_param.IsRunspacePushed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 4109, 4149);
                        return return_v;
                    }


                    System.Exception
                    f_1649_4238_4325(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 4238, 4325);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 3928, 4371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 3928, 4371);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Runspace Runspace { get; internal set; }

        internal HostInfo HostInfo { get; }

        internal virtual bool AllowPushRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 4863, 4964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 4869, 4962);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1649, 4876, 4909) || (((_serverDriverRemoteHost != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1649, 4912, 4953)) || DynAbs.Tracing.TraceSender.Conditional_F3(1649, 4956, 4961))) ? f_1649_4912_4953(_serverDriverRemoteHost) : false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 4863, 4964);

                    bool
                    f_1649_4912_4953(System.Management.Automation.Remoting.ServerDriverRemoteHost
                    this_param)
                    {
                        var return_v = this_param.AllowPushRunspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 4912, 4953);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 4799, 5090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 4799, 5090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 4980, 5079);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 4986, 5077) || true) && (_serverDriverRemoteHost != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 4986, 5077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 5025, 5075);

                        _serverDriverRemoteHost.AllowPushRunspace = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 4986, 5077);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 4980, 5079);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 4799, 5090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 4799, 5090);
                }
            }
        }

        public override void SetShouldExit(int exitCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 5237, 5422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 5310, 5411);

                f_1649_5310_5410(_serverMethodExecutor, RemoteHostMethodId.SetShouldExit, new object[] { exitCode });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 5237, 5422);

                int
                f_1649_5310_5410(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 5310, 5410);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 5237, 5422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 5237, 5422);
            }
        }

        public override void EnterNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 5515, 5683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 5580, 5672);

                throw f_1649_5586_5671(RemoteHostMethodId.EnterNestedPrompt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 5515, 5683);

                System.Exception
                f_1649_5586_5671(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 5586, 5671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 5515, 5683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 5515, 5683);
            }
        }

        public override void ExitNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 5775, 5941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 5839, 5930);

                throw f_1649_5845_5929(RemoteHostMethodId.ExitNestedPrompt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 5775, 5941);

                System.Exception
                f_1649_5845_5929(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 5845, 5929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 5775, 5941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 5775, 5941);
            }
        }

        public override void NotifyBeginApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 6039, 6484);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 6039, 6484);
                // This is called when a native application is executed on the server. It gives the
                // host an opportunity to save state that might be altered by the native application.
                // This call should not be sent to the client because the native application running
                // on the server cannot affect the state of the machine on the client.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 6039, 6484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 6039, 6484);
            }
        }

        public override void NotifyEndApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 6580, 6697);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 6580, 6697);
                // See note in NotifyBeginApplication.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 6580, 6697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 6580, 6697);
            }
        }

        public override CultureInfo CurrentCulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 6853, 7085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 7036, 7070);

                    return f_1649_7043_7069();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 6853, 7085);

                    System.Globalization.CultureInfo
                    f_1649_7043_7069()
                    {
                        var return_v = CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 7043, 7069);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 6786, 7096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 6786, 7096);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override CultureInfo CurrentUICulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 7257, 7497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 7446, 7482);

                    return f_1649_7453_7481();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 7257, 7497);

                    System.Globalization.CultureInfo
                    f_1649_7453_7481()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 7453, 7481);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 7188, 7508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 7188, 7508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual void PushRunspace(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 7644, 8015);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 7720, 8004) || true) && (_serverDriverRemoteHost != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 7720, 8004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 7789, 7836);

                    f_1649_7789_7835(_serverDriverRemoteHost, runspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 7720, 8004);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 7720, 8004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 7902, 7989);

                    throw f_1649_7908_7988(RemoteHostMethodId.PushRunspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 7720, 8004);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 7644, 8015);

                int
                f_1649_7789_7835(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.PushRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 7789, 7835);
                    return 0;
                }


                System.Exception
                f_1649_7908_7988(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 7908, 7988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 7644, 8015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 7644, 8015);
            }
        }

        public virtual void PopRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 8101, 8897);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 8159, 8886) || true) && ((_serverDriverRemoteHost != null) && (DynAbs.Tracing.TraceSender.Expression_True(1649, 8163, 8242) && (f_1649_8201_8241(_serverDriverRemoteHost))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 8159, 8886);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 8276, 8733) || true) && (f_1649_8280_8316(_serverDriverRemoteHost))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 8276, 8733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 8522, 8594);

                        f_1649_8522_8593(                    // Forward the PopRunspace command to client and keep *this* pushed runspace as
                                                             // the configured JEA restricted session.
                                            _serverMethodExecutor, RemoteHostMethodId.PopRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 8276, 8733);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 8276, 8733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 8676, 8714);

                        f_1649_8676_8713(_serverDriverRemoteHost);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 8276, 8733);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 8159, 8886);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 8159, 8886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 8799, 8871);

                    f_1649_8799_8870(_serverMethodExecutor, RemoteHostMethodId.PopRunspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 8159, 8886);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 8101, 8897);

                bool
                f_1649_8201_8241(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.IsRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 8201, 8241);
                    return return_v;
                }


                bool
                f_1649_8280_8316(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    var return_v = this_param.PropagatePop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 8280, 8316);
                    return return_v;
                }


                int
                f_1649_8522_8593(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    this_param.ExecuteVoidMethod(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 8522, 8593);
                    return 0;
                }


                int
                f_1649_8676_8713(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param)
                {
                    this_param.PopRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 8676, 8713);
                    return 0;
                }


                int
                f_1649_8799_8870(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    this_param.ExecuteVoidMethod(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 8799, 8870);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 8101, 8897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 8101, 8897);
            }
        }

        static ServerRemoteHost()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1649, 462, 8926);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1649, 462, 8926);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 462, 8926);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1649, 462, 8926);

        int
        f_1649_2034_2091(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 2034, 2091);
            return 0;
        }


        int
        f_1649_2106_2179(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 2106, 2179);
            return 0;
        }


        System.Management.Automation.Remoting.ServerMethodExecutor
        f_1649_2485_2588(System.Guid
        clientRunspacePoolId, System.Guid
        clientPowerShellId, System.Management.Automation.Remoting.Server.AbstractServerTransportManager
        transportManager)
        {
            var return_v = new System.Management.Automation.Remoting.ServerMethodExecutor(clientRunspacePoolId, clientPowerShellId, transportManager);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 2485, 2588);
            return return_v;
        }


        bool
        f_1649_2730_2751(System.Management.Automation.Remoting.HostInfo
        this_param)
        {
            var return_v = this_param.IsHostUINull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 2730, 2751);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteHostUserInterface
        f_1649_2761_2800(System.Management.Automation.Remoting.ServerRemoteHost
        remoteHost)
        {
            var return_v = new System.Management.Automation.Remoting.ServerRemoteHostUserInterface(remoteHost);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 2761, 2800);
            return return_v;
        }

    }
    internal class ServerDriverRemoteHost : ServerRemoteHost
    {
        private RemoteRunspace _pushedRunspace;

        private ServerRemoteDebugger _debugger;

        private bool _hostSupportsPSEdit;

        internal ServerDriverRemoteHost(
                    Guid clientRunspacePoolId,
                    Guid clientPowerShellId,
                    HostInfo hostInfo,
                    AbstractServerSessionTransportManager transportManager,
                    ServerRemoteDebugger debugger)
        : base(f_1649_9618_9638_C(clientRunspacePoolId), clientPowerShellId, hostInfo, transportManager, null, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1649, 9342, 9756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 9169, 9184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 9224, 9233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 9257, 9276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 13604, 13702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14002, 14086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 9724, 9745);

                _debugger = debugger;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1649, 9342, 9756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 9342, 9756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 9342, 9756);
            }
        }

        public override bool IsRunspacePushed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 9969, 10053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 10005, 10038);

                    return (_pushedRunspace != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 9969, 10053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 9907, 10064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 9907, 10064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void PushRunspace(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 10247, 12259);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 10522, 10949) || true) && (f_1649_10526_10544_M(!AllowPushRunspace) && (DynAbs.Tracing.TraceSender.Expression_True(1649, 10526, 10847) && ((_transportManager is OutOfProcessServerSessionTransportManager) || (DynAbs.Tracing.TraceSender.Expression_False(1649, 10566, 10846) || !(f_1649_10654_10677(runspace) is NamedPipeConnectionInfo || (DynAbs.Tracing.TraceSender.Expression_False(1649, 10654, 10771) || f_1649_10728_10751(runspace) is VMConnectionInfo) || (DynAbs.Tracing.TraceSender.Expression_False(1649, 10654, 10845) || f_1649_10795_10818(runspace) is ContainerConnectionInfo))))
                ))
                               )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 10522, 10949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 10898, 10934);

                    throw f_1649_10904_10933();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 10522, 10949);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 10965, 11136) || true) && (_debugger == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 10965, 11136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11020, 11121);

                    throw f_1649_11026_11120(f_1649_11058_11119());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 10965, 11136);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11152, 11326) || true) && (_pushedRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 11152, 11326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11213, 11311);

                    throw f_1649_11219_11310(f_1649_11251_11309());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 11152, 11326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11342, 11401);

                RemoteRunspace
                remoteRunspace = runspace as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11415, 11592) || true) && (remoteRunspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 11415, 11592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11475, 11577);

                    throw f_1649_11481_11576(f_1649_11513_11575());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 11415, 11592);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11718, 11746);

                _hostSupportsPSEdit = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11760, 11839);

                PSEventManager
                localEventManager = (DynAbs.Tracing.TraceSender.Conditional_F1(1649, 11795, 11813) || (((f_1649_11796_11804() != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1649, 11816, 11831)) || DynAbs.Tracing.TraceSender.Conditional_F3(1649, 11834, 11838))) ? f_1649_11816_11831(f_1649_11816_11824()) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 11853, 12020);

                _hostSupportsPSEdit = (DynAbs.Tracing.TraceSender.Conditional_F1(1649, 11875, 11902) || (((localEventManager != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1649, 11905, 12011)) || DynAbs.Tracing.TraceSender.Conditional_F3(1649, 12014, 12019))) ? f_1649_11905_12011(f_1649_11905_12000(f_1649_11905_11984(localEventManager, HostUtilities.RemoteSessionOpenFileEvent))) : false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12034, 12143) || true) && (_hostSupportsPSEdit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 12034, 12143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12091, 12128);

                    f_1649_12091_12127(this, remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 12034, 12143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12159, 12201);

                f_1649_12159_12200(
                            _debugger, f_1649_12182_12199(runspace));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12215, 12248);

                _pushedRunspace = remoteRunspace;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 10247, 12259);

                bool
                f_1649_10526_10544_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 10526, 10544);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1649_10654_10677(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 10654, 10677);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1649_10728_10751(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 10728, 10751);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1649_10795_10818(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 10795, 10818);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1649_10904_10933()
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 10904, 10933);
                    return return_v;
                }


                string
                f_1649_11058_11119()
                {
                    var return_v = RemotingErrorIdStrings.ServerDriverRemoteHostNoDebuggerToPush;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 11058, 11119);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1649_11026_11120(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 11026, 11120);
                    return return_v;
                }


                string
                f_1649_11251_11309()
                {
                    var return_v = RemotingErrorIdStrings.ServerDriverRemoteHostAlreadyPushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 11251, 11309);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1649_11219_11310(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 11219, 11310);
                    return return_v;
                }


                string
                f_1649_11513_11575()
                {
                    var return_v = RemotingErrorIdStrings.ServerDriverRemoteHostNotRemoteRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 11513, 11575);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1649_11481_11576(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 11481, 11576);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1649_11796_11804()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 11796, 11804);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1649_11816_11824()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 11816, 11824);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1649_11816_11831(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 11816, 11831);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1649_11905_11984(System.Management.Automation.PSEventManager
                this_param, string
                sourceIdentifier)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 11905, 11984);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                f_1649_11905_12000(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 11905, 12000);
                    return return_v;
                }


                bool
                f_1649_11905_12011(System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 11905, 12011);
                    return return_v;
                }


                int
                f_1649_12091_12127(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param, System.Management.Automation.RemoteRunspace
                remoteRunspace)
                {
                    this_param.AddPSEditForRunspace(remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 12091, 12127);
                    return 0;
                }


                System.Management.Automation.Debugger
                f_1649_12182_12199(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 12182, 12199);
                    return return_v;
                }


                int
                f_1649_12159_12200(System.Management.Automation.ServerRemoteDebugger
                this_param, System.Management.Automation.Debugger
                debugger)
                {
                    this_param.PushDebugger(debugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 12159, 12200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 10247, 12259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 10247, 12259);
            }
        }

        public override void PopRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 12345, 12927);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12404, 12916) || true) && (_pushedRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 12404, 12916);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12465, 12571) || true) && (_debugger != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 12465, 12571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12528, 12552);

                        f_1649_12528_12551(_debugger);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 12465, 12571);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12591, 12717) || true) && (_hostSupportsPSEdit)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 12591, 12717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12656, 12698);

                        f_1649_12656_12697(this, _pushedRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 12591, 12717);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12737, 12858) || true) && (f_1649_12741_12773(_pushedRunspace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 12737, 12858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12815, 12839);

                        f_1649_12815_12838(_pushedRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 12737, 12858);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 12878, 12901);

                    _pushedRunspace = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 12404, 12916);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 12345, 12927);

                int
                f_1649_12528_12551(System.Management.Automation.ServerRemoteDebugger
                this_param)
                {
                    this_param.PopDebugger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 12528, 12551);
                    return 0;
                }


                int
                f_1649_12656_12697(System.Management.Automation.Remoting.ServerDriverRemoteHost
                this_param, System.Management.Automation.RemoteRunspace
                remoteRunspace)
                {
                    this_param.RemovePSEditFromRunspace(remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 12656, 12697);
                    return 0;
                }


                bool
                f_1649_12741_12773(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ShouldCloseOnPop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 12741, 12773);
                    return return_v;
                }


                int
                f_1649_12815_12838(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 12815, 12838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 12345, 12927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 12345, 12927);
            }
        }

        internal Debugger ServerDebugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 13125, 13150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 13131, 13148);

                    return _debugger;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 13125, 13150);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 13068, 13227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 13068, 13227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 13166, 13216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 13172, 13214);

                    _debugger = value as ServerRemoteDebugger;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 13166, 13216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 13068, 13227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 13068, 13227);
                }
            }
        }

        internal Runspace PushedRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 13381, 13412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 13387, 13410);

                    return _pushedRunspace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 13381, 13412);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 13324, 13423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 13324, 13423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool AllowPushRunspace
        {
            get;
            set;
        }

        internal bool PropagatePop
        {
            get;
            set;
        }

        private void AddPSEditForRunspace(RemoteRunspace remoteRunspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 14167, 14925);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14256, 14302) || true) && (f_1649_14260_14281(remoteRunspace) == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 14256, 14302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14293, 14300);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 14256, 14302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14353, 14443);

                f_1649_14353_14389(f_1649_14353_14374(remoteRunspace)).PSEventReceived += HandleRemoteSessionForwardedEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14496, 14914);
                using (PowerShell
                powershell = f_1649_14527_14546()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14580, 14617);

                    powershell.Runspace = remoteRunspace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14635, 14753);

                    f_1649_14635_14752(f_1649_14635_14691(powershell, HostUtilities.CreatePSEditFunction), "PSEditFunction", HostUtilities.PSEditFunction);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 14815, 14835);

                        f_1649_14815_14834(powershell);
                    }
                    catch (RemoteException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1649, 14872, 14899);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1649, 14872, 14899);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1649, 14496, 14914);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 14167, 14925);

                System.Management.Automation.PSEventManager
                f_1649_14260_14281(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 14260, 14281);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1649_14353_14374(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 14353, 14374);
                    return return_v;
                }


                System.Management.Automation.PSEventArgsCollection
                f_1649_14353_14389(System.Management.Automation.PSEventManager
                this_param)
                {
                    var return_v = this_param.ReceivedEvents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 14353, 14389);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1649_14527_14546()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 14527, 14546);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1649_14635_14691(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 14635, 14691);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1649_14635_14752(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 14635, 14752);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1649_14815_14834(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 14815, 14834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 14167, 14925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 14167, 14925);
            }
        }

        private void RemovePSEditFromRunspace(RemoteRunspace remoteRunspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 14937, 15951);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15030, 15076) || true) && (f_1649_15034_15055(remoteRunspace) == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 15030, 15076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15067, 15074);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 15030, 15076);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15184, 15383) || true) && ((f_1649_15189_15227(f_1649_15189_15221(remoteRunspace)) != RunspaceState.Opened) || (DynAbs.Tracing.TraceSender.Expression_False(1649, 15188, 15327) || (f_1649_15257_15292(remoteRunspace) != RunspaceAvailability.Available)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 15184, 15383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15361, 15368);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 15184, 15383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15437, 15527);

                f_1649_15437_15473(f_1649_15437_15458(remoteRunspace)).PSEventReceived -= HandleRemoteSessionForwardedEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15583, 15940);
                using (PowerShell
                powershell = f_1649_15614_15633()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15667, 15704);

                    powershell.Runspace = remoteRunspace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15722, 15779);

                    f_1649_15722_15778(powershell, HostUtilities.RemovePSEditFunction);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 15841, 15861);

                        f_1649_15841_15860(powershell);
                    }
                    catch (RemoteException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1649, 15898, 15925);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1649, 15898, 15925);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1649, 15583, 15940);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 14937, 15951);

                System.Management.Automation.PSEventManager
                f_1649_15034_15055(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 15034, 15055);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1649_15189_15221(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 15189, 15221);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1649_15189_15227(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 15189, 15227);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1649_15257_15292(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 15257, 15292);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1649_15437_15458(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 15437, 15458);
                    return return_v;
                }


                System.Management.Automation.PSEventArgsCollection
                f_1649_15437_15473(System.Management.Automation.PSEventManager
                this_param)
                {
                    var return_v = this_param.ReceivedEvents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 15437, 15473);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1649_15614_15633()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 15614, 15633);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1649_15722_15778(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 15722, 15778);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1649_15841_15860(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 15841, 15860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 14937, 15951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 14937, 15951);
            }
        }

        private void HandleRemoteSessionForwardedEvent(object sender, PSEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1649, 15963, 16557);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 16067, 16131) || true) && ((f_1649_16072_16080() == null) || (DynAbs.Tracing.TraceSender.Expression_False(1649, 16071, 16118) || (f_1649_16094_16109(f_1649_16094_16102()) == null)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1649, 16067, 16131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 16122, 16129);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1649, 16067, 16131);
                }

                // Forward events from nested pushed session to parent session.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1649, 16260, 16470);

                    f_1649_16260_16469(f_1649_16260_16275(f_1649_16260_16268()), sourceIdentifier: f_1649_16330_16351(args), sender: null, args: f_1649_16415_16430(args), extraData: null);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1649, 16499, 16546);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1649, 16499, 16546);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1649, 15963, 16557);

                System.Management.Automation.Runspaces.Runspace
                f_1649_16072_16080()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 16072, 16080);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1649_16094_16102()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 16094, 16102);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1649_16094_16109(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 16094, 16109);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1649_16260_16268()
                {
                    var return_v = Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 16260, 16268);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1649_16260_16275(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 16260, 16275);
                    return return_v;
                }


                string
                f_1649_16330_16351(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 16330, 16351);
                    return return_v;
                }


                object[]
                f_1649_16415_16430(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1649, 16415, 16430);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1649_16260_16469(System.Management.Automation.PSEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier: sourceIdentifier, sender: sender, args: args, extraData: extraData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1649, 16260, 16469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1649, 15963, 16557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 15963, 16557);
            }
        }

        static ServerDriverRemoteHost()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1649, 9038, 16586);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1649, 9038, 16586);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1649, 9038, 16586);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1649, 9038, 16586);

        static System.Guid
        f_1649_9618_9638_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1649, 9342, 9756);
            return return_v;
        }

    }
}
