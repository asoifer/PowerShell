// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;

using Dbg = System.Management.Automation.Diagnostics;
// Stops compiler from warning about unknown warnings
#pragma warning disable 1634, 1691

namespace System.Management.Automation.Remoting
{
    internal class ServerRemoteHostRawUserInterface : PSHostRawUserInterface
    {
        private ServerRemoteHostUserInterface _remoteHostUserInterface;

        private ServerMethodExecutor _serverMethodExecutor;

        private HostDefaultData HostDefaultData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 982, 1107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 1018, 1092);

                    return f_1650_1025_1091(f_1650_1025_1075(f_1650_1025_1066(_remoteHostUserInterface)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 982, 1107);

                    System.Management.Automation.Remoting.ServerRemoteHost
                    f_1650_1025_1066(System.Management.Automation.Remoting.ServerRemoteHostUserInterface
                    this_param)
                    {
                        var return_v = this_param.ServerRemoteHost;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1025, 1066);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostInfo
                    f_1650_1025_1075(System.Management.Automation.Remoting.ServerRemoteHost
                    this_param)
                    {
                        var return_v = this_param.HostInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1025, 1075);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_1025_1091(System.Management.Automation.Remoting.HostInfo
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1025, 1091);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 918, 1118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 918, 1118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ServerRemoteHostRawUserInterface(ServerRemoteHostUserInterface remoteHostUserInterface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1650, 1240, 1799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 655, 679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 805, 826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 1361, 1449);

                f_1650_1361_1448(remoteHostUserInterface != null, "Expected remoteHostUserInterface != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 1463, 1514);

                _remoteHostUserInterface = remoteHostUserInterface;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 1528, 1686);

                f_1650_1528_1685(f_1650_1539_1605_M(!f_1650_1540_1589(f_1650_1540_1580(remoteHostUserInterface)).IsHostRawUINull), "Expected !remoteHostUserInterface.ServerRemoteHost.HostInfo.IsHostRawUINull");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 1702, 1788);

                _serverMethodExecutor = f_1650_1726_1787(f_1650_1726_1766(remoteHostUserInterface));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1650, 1240, 1799);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 1240, 1799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 1240, 1799);
            }
        }

        public override ConsoleColor ForegroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 1958, 2399);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 1994, 2384) || true) && (f_1650_1998_2062(f_1650_1998_2018(this), HostDefaultDataId.ForegroundColor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 1994, 2384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 2104, 2190);

                        return (ConsoleColor)f_1650_2125_2189(f_1650_2125_2145(this), HostDefaultDataId.ForegroundColor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 1994, 2384);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 1994, 2384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 2272, 2365);

                        throw f_1650_2278_2364(RemoteHostMethodId.GetForegroundColor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 1994, 2384);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 1958, 2399);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_1998_2018(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1998, 2018);
                        return return_v;
                    }


                    bool
                    f_1650_1998_2062(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 1998, 2062);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_2125_2145(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 2125, 2145);
                        return return_v;
                    }


                    object
                    f_1650_2125_2189(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 2125, 2189);
                        return return_v;
                    }


                    System.Exception
                    f_1650_2278_2364(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 2278, 2364);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 1889, 2670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 1889, 2670);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 2415, 2659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 2451, 2523);

                    f_1650_2451_2522(f_1650_2451_2471(this), HostDefaultDataId.ForegroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 2541, 2644);

                    f_1650_2541_2643(_serverMethodExecutor, RemoteHostMethodId.SetForegroundColor, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 2415, 2659);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_2451_2471(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 2451, 2471);
                        return return_v;
                    }


                    int
                    f_1650_2451_2522(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, System.ConsoleColor
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 2451, 2522);
                        return 0;
                    }


                    int
                    f_1650_2541_2643(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 2541, 2643);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 1889, 2670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 1889, 2670);
                }
            }
        }

        public override ConsoleColor BackgroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 2829, 3270);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 2865, 3255) || true) && (f_1650_2869_2933(f_1650_2869_2889(this), HostDefaultDataId.BackgroundColor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 2865, 3255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 2975, 3061);

                        return (ConsoleColor)f_1650_2996_3060(f_1650_2996_3016(this), HostDefaultDataId.BackgroundColor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 2865, 3255);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 2865, 3255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 3143, 3236);

                        throw f_1650_3149_3235(RemoteHostMethodId.GetBackgroundColor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 2865, 3255);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 2829, 3270);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_2869_2889(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 2869, 2889);
                        return return_v;
                    }


                    bool
                    f_1650_2869_2933(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 2869, 2933);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_2996_3016(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 2996, 3016);
                        return return_v;
                    }


                    object
                    f_1650_2996_3060(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 2996, 3060);
                        return return_v;
                    }


                    System.Exception
                    f_1650_3149_3235(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 3149, 3235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 2760, 3541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 2760, 3541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 3286, 3530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 3322, 3394);

                    f_1650_3322_3393(f_1650_3322_3342(this), HostDefaultDataId.BackgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 3412, 3515);

                    f_1650_3412_3514(_serverMethodExecutor, RemoteHostMethodId.SetBackgroundColor, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 3286, 3530);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_3322_3342(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 3322, 3342);
                        return return_v;
                    }


                    int
                    f_1650_3322_3393(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, System.ConsoleColor
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 3322, 3393);
                        return 0;
                    }


                    int
                    f_1650_3412_3514(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 3412, 3514);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 2760, 3541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 2760, 3541);
                }
            }
        }

        public override Coordinates CursorPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 3697, 4134);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 3733, 4119) || true) && (f_1650_3737_3800(f_1650_3737_3757(this), HostDefaultDataId.CursorPosition))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 3733, 4119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 3842, 3926);

                        return (Coordinates)f_1650_3862_3925(f_1650_3862_3882(this), HostDefaultDataId.CursorPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 3733, 4119);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 3733, 4119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 4008, 4100);

                        throw f_1650_4014_4099(RemoteHostMethodId.GetCursorPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 3733, 4119);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 3697, 4134);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_3737_3757(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 3737, 3757);
                        return return_v;
                    }


                    bool
                    f_1650_3737_3800(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 3737, 3800);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_3862_3882(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 3862, 3882);
                        return return_v;
                    }


                    object
                    f_1650_3862_3925(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 3862, 3925);
                        return return_v;
                    }


                    System.Exception
                    f_1650_4014_4099(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 4014, 4099);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 3630, 4403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 3630, 4403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 4150, 4392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 4186, 4257);

                    f_1650_4186_4256(f_1650_4186_4206(this), HostDefaultDataId.CursorPosition, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 4275, 4377);

                    f_1650_4275_4376(_serverMethodExecutor, RemoteHostMethodId.SetCursorPosition, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 4150, 4392);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_4186_4206(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 4186, 4206);
                        return return_v;
                    }


                    int
                    f_1650_4186_4256(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, System.Management.Automation.Host.Coordinates
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 4186, 4256);
                        return 0;
                    }


                    int
                    f_1650_4275_4376(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 4275, 4376);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 3630, 4403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 3630, 4403);
                }
            }
        }

        public override Coordinates WindowPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 4559, 4996);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 4595, 4981) || true) && (f_1650_4599_4662(f_1650_4599_4619(this), HostDefaultDataId.WindowPosition))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 4595, 4981);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 4704, 4788);

                        return (Coordinates)f_1650_4724_4787(f_1650_4724_4744(this), HostDefaultDataId.WindowPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 4595, 4981);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 4595, 4981);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 4870, 4962);

                        throw f_1650_4876_4961(RemoteHostMethodId.GetWindowPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 4595, 4981);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 4559, 4996);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_4599_4619(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 4599, 4619);
                        return return_v;
                    }


                    bool
                    f_1650_4599_4662(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 4599, 4662);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_4724_4744(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 4724, 4744);
                        return return_v;
                    }


                    object
                    f_1650_4724_4787(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 4724, 4787);
                        return return_v;
                    }


                    System.Exception
                    f_1650_4876_4961(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 4876, 4961);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 4492, 5265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 4492, 5265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 5012, 5254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 5048, 5119);

                    f_1650_5048_5118(f_1650_5048_5068(this), HostDefaultDataId.WindowPosition, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 5137, 5239);

                    f_1650_5137_5238(_serverMethodExecutor, RemoteHostMethodId.SetWindowPosition, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 5012, 5254);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_5048_5068(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 5048, 5068);
                        return return_v;
                    }


                    int
                    f_1650_5048_5118(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, System.Management.Automation.Host.Coordinates
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 5048, 5118);
                        return 0;
                    }


                    int
                    f_1650_5137_5238(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 5137, 5238);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 4492, 5265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 4492, 5265);
                }
            }
        }

        public override int CursorSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 5405, 5822);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 5441, 5807) || true) && (f_1650_5445_5504(f_1650_5445_5465(this), HostDefaultDataId.CursorSize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 5441, 5807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 5546, 5618);

                        return (int)f_1650_5558_5617(f_1650_5558_5578(this), HostDefaultDataId.CursorSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 5441, 5807);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 5441, 5807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 5700, 5788);

                        throw f_1650_5706_5787(RemoteHostMethodId.GetCursorSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 5441, 5807);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 5405, 5822);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_5445_5465(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 5445, 5465);
                        return return_v;
                    }


                    bool
                    f_1650_5445_5504(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 5445, 5504);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_5558_5578(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 5558, 5578);
                        return return_v;
                    }


                    object
                    f_1650_5558_5617(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 5558, 5617);
                        return return_v;
                    }


                    System.Exception
                    f_1650_5706_5787(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 5706, 5787);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 5350, 6083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 5350, 6083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 5838, 6072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 5874, 5941);

                    f_1650_5874_5940(f_1650_5874_5894(this), HostDefaultDataId.CursorSize, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 5959, 6057);

                    f_1650_5959_6056(_serverMethodExecutor, RemoteHostMethodId.SetCursorSize, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 5838, 6072);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_5874_5894(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 5874, 5894);
                        return return_v;
                    }


                    int
                    f_1650_5874_5940(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, int
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 5874, 5940);
                        return 0;
                    }


                    int
                    f_1650_5959_6056(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 5959, 6056);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 5350, 6083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 5350, 6083);
                }
            }
        }

        public override Size BufferSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 6224, 6642);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 6260, 6627) || true) && (f_1650_6264_6323(f_1650_6264_6284(this), HostDefaultDataId.BufferSize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 6260, 6627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 6365, 6438);

                        return (Size)f_1650_6378_6437(f_1650_6378_6398(this), HostDefaultDataId.BufferSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 6260, 6627);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 6260, 6627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 6520, 6608);

                        throw f_1650_6526_6607(RemoteHostMethodId.GetBufferSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 6260, 6627);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 6224, 6642);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_6264_6284(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 6264, 6284);
                        return return_v;
                    }


                    bool
                    f_1650_6264_6323(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 6264, 6323);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_6378_6398(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 6378, 6398);
                        return return_v;
                    }


                    object
                    f_1650_6378_6437(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 6378, 6437);
                        return return_v;
                    }


                    System.Exception
                    f_1650_6526_6607(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 6526, 6607);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 6168, 6903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 6168, 6903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 6658, 6892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 6694, 6761);

                    f_1650_6694_6760(f_1650_6694_6714(this), HostDefaultDataId.BufferSize, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 6779, 6877);

                    f_1650_6779_6876(_serverMethodExecutor, RemoteHostMethodId.SetBufferSize, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 6658, 6892);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_6694_6714(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 6694, 6714);
                        return return_v;
                    }


                    int
                    f_1650_6694_6760(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, System.Management.Automation.Host.Size
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 6694, 6760);
                        return 0;
                    }


                    int
                    f_1650_6779_6876(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 6779, 6876);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 6168, 6903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 6168, 6903);
                }
            }
        }

        public override Size WindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 7044, 7462);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 7080, 7447) || true) && (f_1650_7084_7143(f_1650_7084_7104(this), HostDefaultDataId.WindowSize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 7080, 7447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 7185, 7258);

                        return (Size)f_1650_7198_7257(f_1650_7198_7218(this), HostDefaultDataId.WindowSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 7080, 7447);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 7080, 7447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 7340, 7428);

                        throw f_1650_7346_7427(RemoteHostMethodId.GetWindowSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 7080, 7447);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 7044, 7462);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_7084_7104(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 7084, 7104);
                        return return_v;
                    }


                    bool
                    f_1650_7084_7143(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 7084, 7143);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_7198_7218(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 7198, 7218);
                        return return_v;
                    }


                    object
                    f_1650_7198_7257(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 7198, 7257);
                        return return_v;
                    }


                    System.Exception
                    f_1650_7346_7427(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 7346, 7427);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 6988, 7723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 6988, 7723);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 7478, 7712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 7514, 7581);

                    f_1650_7514_7580(f_1650_7514_7534(this), HostDefaultDataId.WindowSize, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 7599, 7697);

                    f_1650_7599_7696(_serverMethodExecutor, RemoteHostMethodId.SetWindowSize, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 7478, 7712);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_7514_7534(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 7514, 7534);
                        return return_v;
                    }


                    int
                    f_1650_7514_7580(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, System.Management.Automation.Host.Size
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 7514, 7580);
                        return 0;
                    }


                    int
                    f_1650_7599_7696(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 7599, 7696);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 6988, 7723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 6988, 7723);
                }
            }
        }

        public override string WindowTitle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 7868, 8291);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 7904, 8276) || true) && (f_1650_7908_7968(f_1650_7908_7928(this), HostDefaultDataId.WindowTitle))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 7904, 8276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 8010, 8086);

                        return (string)f_1650_8025_8085(f_1650_8025_8045(this), HostDefaultDataId.WindowTitle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 7904, 8276);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 7904, 8276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 8168, 8257);

                        throw f_1650_8174_8256(RemoteHostMethodId.GetWindowTitle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 7904, 8276);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 7868, 8291);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_7908_7928(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 7908, 7928);
                        return return_v;
                    }


                    bool
                    f_1650_7908_7968(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 7908, 7968);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_8025_8045(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 8025, 8045);
                        return return_v;
                    }


                    object
                    f_1650_8025_8085(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 8025, 8085);
                        return return_v;
                    }


                    System.Exception
                    f_1650_8174_8256(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 8174, 8256);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 7809, 8554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 7809, 8554);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 8307, 8543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 8343, 8411);

                    f_1650_8343_8410(f_1650_8343_8363(this), HostDefaultDataId.WindowTitle, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 8429, 8528);

                    f_1650_8429_8527(_serverMethodExecutor, RemoteHostMethodId.SetWindowTitle, new object[] { value });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 8307, 8543);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_8343_8363(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 8343, 8363);
                        return return_v;
                    }


                    int
                    f_1650_8343_8410(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id, string
                    dataValue)
                    {
                        this_param.SetValue(id, (object)dataValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 8343, 8410);
                        return 0;
                    }


                    int
                    f_1650_8429_8527(System.Management.Automation.Remoting.ServerMethodExecutor
                    this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId, object[]
                    parameters)
                    {
                        this_param.ExecuteVoidMethod(methodId, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 8429, 8527);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 7809, 8554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 7809, 8554);
                }
            }
        }

        public override Size MaxWindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 8702, 9129);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 8738, 9114) || true) && (f_1650_8742_8804(f_1650_8742_8762(this), HostDefaultDataId.MaxWindowSize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 8738, 9114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 8846, 8922);

                        return (Size)f_1650_8859_8921(f_1650_8859_8879(this), HostDefaultDataId.MaxWindowSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 8738, 9114);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 8738, 9114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 9004, 9095);

                        throw f_1650_9010_9094(RemoteHostMethodId.GetMaxWindowSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 8738, 9114);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 8702, 9129);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_8742_8762(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 8742, 8762);
                        return return_v;
                    }


                    bool
                    f_1650_8742_8804(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 8742, 8804);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_8859_8879(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 8859, 8879);
                        return return_v;
                    }


                    object
                    f_1650_8859_8921(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 8859, 8921);
                        return return_v;
                    }


                    System.Exception
                    f_1650_9010_9094(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 9010, 9094);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 8643, 9140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 8643, 9140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Size MaxPhysicalWindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 9305, 9756);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 9341, 9741) || true) && (f_1650_9345_9415(f_1650_9345_9365(this), HostDefaultDataId.MaxPhysicalWindowSize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 9341, 9741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 9457, 9541);

                        return (Size)f_1650_9470_9540(f_1650_9470_9490(this), HostDefaultDataId.MaxPhysicalWindowSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 9341, 9741);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 9341, 9741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 9623, 9722);

                        throw f_1650_9629_9721(RemoteHostMethodId.GetMaxPhysicalWindowSize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 9341, 9741);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 9305, 9756);

                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_9345_9365(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 9345, 9365);
                        return return_v;
                    }


                    bool
                    f_1650_9345_9415(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.HasValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 9345, 9415);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.HostDefaultData
                    f_1650_9470_9490(System.Management.Automation.Remoting.ServerRemoteHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.HostDefaultData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 9470, 9490);
                        return return_v;
                    }


                    object
                    f_1650_9470_9540(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 9470, 9540);
                        return return_v;
                    }


                    System.Exception
                    f_1650_9629_9721(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 9629, 9721);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 9238, 9767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 9238, 9767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool KeyAvailable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 9943, 10084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 9979, 10069);

                    throw f_1650_9985_10068(RemoteHostMethodId.GetKeyAvailable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 9943, 10084);

                    System.Exception
                    f_1650_9985_10068(System.Management.Automation.Remoting.RemoteHostMethodId
                    methodId)
                    {
                        var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 9985, 10068);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 9854, 10126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 9854, 10126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override KeyInfo ReadKey(ReadKeyOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 10208, 10405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 10288, 10394);

                return f_1650_10295_10393(_serverMethodExecutor, RemoteHostMethodId.ReadKey, new object[] { options });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 10208, 10405);

                System.Management.Automation.Host.KeyInfo
                f_1650_10295_10393(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = this_param.ExecuteMethod<System.Management.Automation.Host.KeyInfo>(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 10295, 10393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 10208, 10405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 10208, 10405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void FlushInputBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 10497, 10649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 10561, 10638);

                f_1650_10561_10637(_serverMethodExecutor, RemoteHostMethodId.FlushInputBuffer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 10497, 10649);

                int
                f_1650_10561_10637(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    this_param.ExecuteVoidMethod(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 10561, 10637);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 10497, 10649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 10497, 10649);
            }
        }

        public override void ScrollBufferContents(Rectangle source, Coordinates destination, Rectangle clip, BufferCell fill)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 10745, 11029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 10887, 11018);

                f_1650_10887_11017(_serverMethodExecutor, RemoteHostMethodId.ScrollBufferContents, new object[] { source, destination, clip, fill });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 10745, 11029);

                int
                f_1650_10887_11017(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 10887, 11017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 10745, 11029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 10745, 11029);
            }
        }

        public override void SetBufferContents(Rectangle rectangle, BufferCell fill)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 11122, 11347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 11223, 11336);

                f_1650_11223_11335(_serverMethodExecutor, RemoteHostMethodId.SetBufferContents1, new object[] { rectangle, fill });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 11122, 11347);

                int
                f_1650_11223_11335(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 11223, 11335);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 11122, 11347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 11122, 11347);
            }
        }

        public override void SetBufferContents(Coordinates origin, BufferCell[,] contents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 11440, 11672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 11547, 11661);

                f_1650_11547_11660(_serverMethodExecutor, RemoteHostMethodId.SetBufferContents2, new object[] { origin, contents });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 11440, 11672);

                int
                f_1650_11547_11660(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    this_param.ExecuteVoidMethod(methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 11547, 11660);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 11440, 11672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 11440, 11672);
            }
        }

        public override BufferCell[,] GetBufferContents(Rectangle rectangle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 11765, 12181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12078, 12170);

                throw f_1650_12084_12169(RemoteHostMethodId.GetBufferContents);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 11765, 12181);

                System.Exception
                f_1650_12084_12169(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostExceptions.NewNotImplementedException(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 12084, 12169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 11765, 12181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 11765, 12181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int LengthInBufferCells(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 12364, 12600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12443, 12552) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 12443, 12552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12495, 12537);

                    throw f_1650_12501_12536("source");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 12443, 12552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12568, 12589);

                return f_1650_12575_12588(source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 12364, 12600);

                System.ArgumentNullException
                f_1650_12501_12536(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 12501, 12536);
                    return return_v;
                }


                int
                f_1650_12575_12588(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 12575, 12588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 12364, 12600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 12364, 12600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int LengthInBufferCells(string source, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1650, 12707, 13128);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12798, 12907) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1650, 12798, 12907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12850, 12892);

                    throw f_1650_12856_12891("source");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1650, 12798, 12907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12923, 12962);

                f_1650_12923_12961(offset >= 0, "offset >= 0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 12976, 13071);

                f_1650_12976_13070(f_1650_12987_13015(source) || (DynAbs.Tracing.TraceSender.Expression_False(1650, 12987, 13043) || (offset < f_1650_13029_13042(source))), "offset < source.Length");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1650, 13087, 13117);

                return f_1650_13094_13107(source) - offset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1650, 12707, 13128);

                System.ArgumentNullException
                f_1650_12856_12891(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 12856, 12891);
                    return return_v;
                }


                int
                f_1650_12923_12961(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 12923, 12961);
                    return 0;
                }


                bool
                f_1650_12987_13015(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 12987, 13015);
                    return return_v;
                }


                int
                f_1650_13029_13042(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 13029, 13042);
                    return return_v;
                }


                int
                f_1650_12976_13070(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 12976, 13070);
                    return 0;
                }


                int
                f_1650_13094_13107(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 13094, 13107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1650, 12707, 13128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 12707, 13128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ServerRemoteHostRawUserInterface()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1650, 440, 13135);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1650, 440, 13135);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1650, 440, 13135);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1650, 440, 13135);

        int
        f_1650_1361_1448(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 1361, 1448);
            return 0;
        }


        System.Management.Automation.Remoting.ServerRemoteHost
        f_1650_1540_1580(System.Management.Automation.Remoting.ServerRemoteHostUserInterface
        this_param)
        {
            var return_v = this_param.ServerRemoteHost;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1540, 1580);
            return return_v;
        }


        System.Management.Automation.Remoting.HostInfo
        f_1650_1540_1589(System.Management.Automation.Remoting.ServerRemoteHost
        this_param)
        {
            var return_v = this_param.HostInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1540, 1589);
            return return_v;
        }


        bool
        f_1650_1539_1605_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1539, 1605);
            return return_v;
        }


        int
        f_1650_1528_1685(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1650, 1528, 1685);
            return 0;
        }


        System.Management.Automation.Remoting.ServerRemoteHost
        f_1650_1726_1766(System.Management.Automation.Remoting.ServerRemoteHostUserInterface
        this_param)
        {
            var return_v = this_param.ServerRemoteHost;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1726, 1766);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerMethodExecutor
        f_1650_1726_1787(System.Management.Automation.Remoting.ServerRemoteHost
        this_param)
        {
            var return_v = this_param.ServerMethodExecutor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1650, 1726, 1787);
            return return_v;
        }

    }
}
