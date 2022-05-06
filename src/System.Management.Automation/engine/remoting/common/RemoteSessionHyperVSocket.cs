// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Management.Automation.Tracing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

using Dbg = System.Diagnostics.Debug;

namespace System.Management.Automation.Remoting
{
    [SerializableAttribute]
    internal class HyperVSocketEndPoint : EndPoint
    {
        private System.Net.Sockets.AddressFamily _addressFamily;

        private Guid _vmId;

        private Guid _serviceId;

        public const System.Net.Sockets.AddressFamily
        AF_HYPERV = (System.Net.Sockets.AddressFamily)34
        ;

        public const int
        HYPERV_SOCK_ADDR_SIZE = 36
        ;

        public HyperVSocketEndPoint(System.Net.Sockets.AddressFamily AddrFamily,
                                           Guid VmId,
                                           Guid ServiceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1626, 817, 1116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 513, 527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1013, 1041);

                _addressFamily = AddrFamily;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1055, 1068);

                _vmId = VmId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1082, 1105);

                _serviceId = ServiceId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1626, 817, 1116);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 817, 1116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 817, 1116);
            }
        }

        public override System.Net.Sockets.AddressFamily AddressFamily
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 1215, 1245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1221, 1243);

                    return _addressFamily;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 1215, 1245);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 1128, 1256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 1128, 1256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Guid VmId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 1309, 1330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1315, 1328);

                    return _vmId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 1309, 1330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 1268, 1379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 1268, 1379);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 1346, 1368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1352, 1366);

                    _vmId = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 1346, 1368);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 1268, 1379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 1268, 1379);
                }
            }
        }

        public Guid ServiceId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 1437, 1463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1443, 1461);

                    return _serviceId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 1437, 1463);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 1391, 1512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 1391, 1512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 1479, 1501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1485, 1499);

                    _vmId = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 1479, 1501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 1391, 1512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 1391, 1512);
                }
            }
        }

        public override EndPoint Create(SocketAddress SockAddr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 1575, 2185);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1655, 1825) || true) && (SockAddr == null || (DynAbs.Tracing.TraceSender.Expression_False(1626, 1659, 1724) || f_1626_1696_1711(SockAddr) != AF_HYPERV) || (DynAbs.Tracing.TraceSender.Expression_False(1626, 1659, 1764) || f_1626_1745_1758(SockAddr) != 34))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 1655, 1825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1798, 1810);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 1655, 1825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1841, 1939);

                HyperVSocketEndPoint
                endpoint = f_1626_1873_1938(f_1626_1898_1913(SockAddr), Guid.Empty, Guid.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 1955, 1996);

                string
                sockAddress = f_1626_1976_1995(SockAddr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2012, 2067);

                endpoint.VmId = f_1626_2028_2066(f_1626_2037_2065(sockAddress, 4, 16));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2081, 2142);

                endpoint.ServiceId = f_1626_2102_2141(f_1626_2111_2140(sockAddress, 20, 16));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2158, 2174);

                return endpoint;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 1575, 2185);

                System.Net.Sockets.AddressFamily
                f_1626_1696_1711(System.Net.SocketAddress
                this_param)
                {
                    var return_v = this_param.Family;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 1696, 1711);
                    return return_v;
                }


                int
                f_1626_1745_1758(System.Net.SocketAddress
                this_param)
                {
                    var return_v = this_param.Size;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 1745, 1758);
                    return return_v;
                }


                System.Net.Sockets.AddressFamily
                f_1626_1898_1913(System.Net.SocketAddress
                this_param)
                {
                    var return_v = this_param.Family;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 1898, 1913);
                    return return_v;
                }


                System.Management.Automation.Remoting.HyperVSocketEndPoint
                f_1626_1873_1938(System.Net.Sockets.AddressFamily
                AddrFamily, System.Guid
                VmId, System.Guid
                ServiceId)
                {
                    var return_v = new System.Management.Automation.Remoting.HyperVSocketEndPoint(AddrFamily, VmId, ServiceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 1873, 1938);
                    return return_v;
                }


                string
                f_1626_1976_1995(System.Net.SocketAddress
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 1976, 1995);
                    return return_v;
                }


                string
                f_1626_2037_2065(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 2037, 2065);
                    return return_v;
                }


                System.Guid
                f_1626_2028_2066(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 2028, 2066);
                    return return_v;
                }


                string
                f_1626_2111_2140(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 2111, 2140);
                    return return_v;
                }


                System.Guid
                f_1626_2102_2141(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 2102, 2141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 1575, 2185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 1575, 2185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 2197, 2680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2261, 2319);

                HyperVSocketEndPoint
                endpoint = (HyperVSocketEndPoint)obj
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2335, 2417) || true) && (endpoint == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 2335, 2417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2389, 2402);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 2335, 2417);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2433, 2640) || true) && ((_addressFamily == f_1626_2456_2478(endpoint)) && (DynAbs.Tracing.TraceSender.Expression_True(1626, 2437, 2524) && (_vmId == f_1626_2510_2523(endpoint))) && (DynAbs.Tracing.TraceSender.Expression_True(1626, 2437, 2579) && (_serviceId == f_1626_2560_2578(endpoint))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 2433, 2640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2613, 2625);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 2433, 2640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2656, 2669);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 2197, 2680);

                System.Net.Sockets.AddressFamily
                f_1626_2456_2478(System.Management.Automation.Remoting.HyperVSocketEndPoint
                this_param)
                {
                    var return_v = this_param.AddressFamily;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 2456, 2478);
                    return return_v;
                }


                System.Guid
                f_1626_2510_2523(System.Management.Automation.Remoting.HyperVSocketEndPoint
                this_param)
                {
                    var return_v = this_param.VmId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 2510, 2523);
                    return return_v;
                }


                System.Guid
                f_1626_2560_2578(System.Management.Automation.Remoting.HyperVSocketEndPoint
                this_param)
                {
                    var return_v = this_param.ServiceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 2560, 2578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 2197, 2680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 2197, 2680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 2692, 2794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2750, 2783);

                return f_1626_2757_2782(f_1626_2757_2768(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 2692, 2794);

                System.Net.SocketAddress
                f_1626_2757_2768(System.Management.Automation.Remoting.HyperVSocketEndPoint
                this_param)
                {
                    var return_v = this_param.Serialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 2757, 2768);
                    return return_v;
                }


                int
                f_1626_2757_2782(System.Net.SocketAddress
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 2757, 2782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 2692, 2794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 2692, 2794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SocketAddress Serialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 2806, 3470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 2872, 2991);

                SocketAddress
                sockAddress = f_1626_2900_2990((System.Net.Sockets.AddressFamily)_addressFamily, HYPERV_SOCK_ADDR_SIZE)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3007, 3041);

                byte[]
                vmId = _vmId.ToByteArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3055, 3099);

                byte[]
                serviceId = _serviceId.ToByteArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3115, 3140);

                sockAddress[2] = (byte)0;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3165, 3170);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3156, 3270) || true) && (i < f_1626_3176_3187(vmId))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3189, 3192)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 3156, 3270))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 3156, 3270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3226, 3255);

                        sockAddress[i + 4] = vmId[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1626, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1626, 1, 115);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3295, 3300);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3286, 3424) || true) && (i < f_1626_3306_3322(serviceId))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3324, 3327)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 3286, 3424))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 3286, 3424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3361, 3409);

                        sockAddress[i + 4 + f_1626_3381_3392(vmId)] = serviceId[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1626, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1626, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3440, 3459);

                return sockAddress;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 2806, 3470);

                System.Net.SocketAddress
                f_1626_2900_2990(System.Net.Sockets.AddressFamily
                family, int
                size)
                {
                    var return_v = new System.Net.SocketAddress(family, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 2900, 2990);
                    return return_v;
                }


                int
                f_1626_3176_3187(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 3176, 3187);
                    return return_v;
                }


                int
                f_1626_3306_3322(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 3306, 3322);
                    return return_v;
                }


                int
                f_1626_3381_3392(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 3381, 3392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 2806, 3470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 2806, 3470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 3482, 3599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3540, 3588);

                return _vmId.ToString() + _serviceId.ToString();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 3482, 3599);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 3482, 3599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 3482, 3599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static HyperVSocketEndPoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1626, 353, 3628);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 649, 697);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 725, 751);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1626, 353, 3628);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 353, 3628);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1626, 353, 3628);
    }
    internal sealed class RemoteSessionHyperVSocketServer : IDisposable
    {
        private readonly object _syncObject;

        private PowerShellTraceSource _tracer;

        public Socket HyperVSocket { get; }

        public NetworkStream Stream { get; }

        public StreamReader TextReader { get; private set; }

        public StreamWriter TextWriter { get; private set; }

        public bool IsDisposed { get; private set; }

        public RemoteSessionHyperVSocketServer(bool LoopbackMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1626, 4772, 9729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3771, 3782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 3823, 3878);
                this._tracer = f_1626_3833_3878();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 4038, 4073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 4180, 4216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 4328, 4380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 4492, 4544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 4662, 4706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 5101, 5128);

                _syncObject = f_1626_5115_5127();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 5144, 5164);

                Exception
                ex = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7346, 7412);

                    Guid
                    serviceId = f_1626_7363_7411("a5201c21-2770-4c11-a68e-f182edb29220")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7465, 7577);

                    HyperVSocketEndPoint
                    endpoint = f_1626_7497_7576(HyperVSocketEndPoint.AF_HYPERV, Guid.Empty, serviceId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7597, 7709);

                    Socket
                    listenSocket = f_1626_7619_7708(f_1626_7630_7652(endpoint), SocketType.Stream, 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7727, 7755);

                    f_1626_7727_7754(listenSocket, endpoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7775, 7798);

                    f_1626_7775_7797(
                                    listenSocket, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7816, 7853);

                    HyperVSocket = f_1626_7831_7852(listenSocket);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7873, 7920);

                    Stream = f_1626_7882_7919(f_1626_7900_7912(), true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 7990, 8028);

                    TextReader = f_1626_8003_8027(f_1626_8020_8026());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 8046, 8084);

                    TextWriter = f_1626_8059_8083(f_1626_8076_8082());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 8102, 8130);

                    f_1626_8102_8112().AutoFlush = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 8543, 8716) || true) && (listenSocket != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 8543, 8716);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 8615, 8638);

                            f_1626_8615_8637(listenSocket);
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 8662, 8697);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 8662, 8697);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 8543, 8716);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 8745, 8819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 8797, 8804);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 8745, 8819);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 8835, 9718) || true) && (ex != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 8835, 9718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 8883, 8957);

                    f_1626_8883_8956(false, "Unexpected error in RemoteSessionHyperVSocketServer.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 9015, 9099);

                    string
                    errorMessage = (DynAbs.Tracing.TraceSender.Conditional_F1(1626, 9037, 9070) || ((!f_1626_9038_9070(f_1626_9059_9069(ex)) && DynAbs.Tracing.TraceSender.Conditional_F2(1626, 9073, 9083)) || DynAbs.Tracing.TraceSender.Conditional_F3(1626, 9086, 9098))) ? f_1626_9073_9083(ex) : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 9117, 9295);

                    f_1626_9117_9294(_tracer, "RemoteSessionHyperVSocketServer", "RemoteSessionHyperVSocketServer", Guid.Empty, "Unexpected error in constructor: {0}", errorMessage);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 9315, 9703);

                    throw f_1626_9321_9702(f_1626_9375_9495(f_1626_9422_9494()), ex, f_1626_9543_9621(PSRemotingErrorId.RemoteSessionHyperVSocketServerConstructorFailure), ErrorCategory.InvalidOperation, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 8835, 9718);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1626, 4772, 9729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 4772, 9729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 4772, 9729);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 9863, 10799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 9915, 9926);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 9960, 9987) || true) && (f_1626_9964_9974())
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 9960, 9987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 9978, 9985);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 9960, 9987);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10007, 10025);

                    IsDisposed = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10056, 10247) || true) && (f_1626_10060_10070() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 10056, 10247);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10118, 10139);

                        f_1626_10118_10138(f_1626_10118_10128());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 10159, 10194);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 10159, 10194);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10214, 10232);

                    TextReader = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 10056, 10247);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10263, 10454) || true) && (f_1626_10267_10277() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 10263, 10454);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10325, 10346);

                        f_1626_10325_10345(f_1626_10325_10335());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 10366, 10401);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 10366, 10401);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10421, 10439);

                    TextWriter = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 10263, 10454);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10470, 10615) || true) && (f_1626_10474_10480() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 10470, 10615);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10528, 10545);

                        f_1626_10528_10544(f_1626_10528_10534());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 10565, 10600);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 10565, 10600);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 10470, 10615);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10631, 10788) || true) && (f_1626_10635_10647() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 10631, 10788);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10695, 10718);

                        f_1626_10695_10717(f_1626_10695_10707());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 10738, 10773);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 10738, 10773);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 10631, 10788);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 9863, 10799);

                bool
                f_1626_9964_9974()
                {
                    var return_v = IsDisposed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 9964, 9974);
                    return return_v;
                }


                System.IO.StreamReader
                f_1626_10060_10070()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10060, 10070);
                    return return_v;
                }


                System.IO.StreamReader
                f_1626_10118_10128()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10118, 10128);
                    return return_v;
                }


                int
                f_1626_10118_10138(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 10118, 10138);
                    return 0;
                }


                System.IO.StreamWriter
                f_1626_10267_10277()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10267, 10277);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1626_10325_10335()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10325, 10335);
                    return return_v;
                }


                int
                f_1626_10325_10345(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 10325, 10345);
                    return 0;
                }


                System.Net.Sockets.NetworkStream
                f_1626_10474_10480()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10474, 10480);
                    return return_v;
                }


                System.Net.Sockets.NetworkStream
                f_1626_10528_10534()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10528, 10534);
                    return return_v;
                }


                int
                f_1626_10528_10544(System.Net.Sockets.NetworkStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 10528, 10544);
                    return 0;
                }


                System.Net.Sockets.Socket
                f_1626_10635_10647()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10635, 10647);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_10695_10707()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 10695, 10707);
                    return return_v;
                }


                int
                f_1626_10695_10717(System.Net.Sockets.Socket
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 10695, 10717);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 9863, 10799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 9863, 10799);
            }
        }

        static RemoteSessionHyperVSocketServer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1626, 3636, 10828);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1626, 3636, 10828);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 3636, 10828);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1626, 3636, 10828);

        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1626_3833_3878()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 3833, 3878);
            return return_v;
        }


        object
        f_1626_5115_5127()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 5115, 5127);
            return return_v;
        }


        System.Guid
        f_1626_7363_7411(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 7363, 7411);
            return return_v;
        }


        System.Management.Automation.Remoting.HyperVSocketEndPoint
        f_1626_7497_7576(System.Net.Sockets.AddressFamily
        AddrFamily, System.Guid
        VmId, System.Guid
        ServiceId)
        {
            var return_v = new System.Management.Automation.Remoting.HyperVSocketEndPoint(AddrFamily, VmId, ServiceId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 7497, 7576);
            return return_v;
        }


        System.Net.Sockets.AddressFamily
        f_1626_7630_7652(System.Management.Automation.Remoting.HyperVSocketEndPoint
        this_param)
        {
            var return_v = this_param.AddressFamily;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 7630, 7652);
            return return_v;
        }


        System.Net.Sockets.Socket
        f_1626_7619_7708(System.Net.Sockets.AddressFamily
        addressFamily, System.Net.Sockets.SocketType
        socketType, int
        protocolType)
        {
            var return_v = new System.Net.Sockets.Socket(addressFamily, socketType, (System.Net.Sockets.ProtocolType)protocolType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 7619, 7708);
            return return_v;
        }


        int
        f_1626_7727_7754(System.Net.Sockets.Socket
        this_param, System.Management.Automation.Remoting.HyperVSocketEndPoint
        localEP)
        {
            this_param.Bind((System.Net.EndPoint)localEP);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 7727, 7754);
            return 0;
        }


        int
        f_1626_7775_7797(System.Net.Sockets.Socket
        this_param, int
        backlog)
        {
            this_param.Listen(backlog);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 7775, 7797);
            return 0;
        }


        System.Net.Sockets.Socket
        f_1626_7831_7852(System.Net.Sockets.Socket
        this_param)
        {
            var return_v = this_param.Accept();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 7831, 7852);
            return return_v;
        }


        System.Net.Sockets.Socket
        f_1626_7900_7912()
        {
            var return_v = HyperVSocket;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 7900, 7912);
            return return_v;
        }


        System.Net.Sockets.NetworkStream
        f_1626_7882_7919(System.Net.Sockets.Socket
        socket, bool
        ownsSocket)
        {
            var return_v = new System.Net.Sockets.NetworkStream(socket, ownsSocket);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 7882, 7919);
            return return_v;
        }


        System.Net.Sockets.NetworkStream
        f_1626_8020_8026()
        {
            var return_v = Stream;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 8020, 8026);
            return return_v;
        }


        System.IO.StreamReader
        f_1626_8003_8027(System.Net.Sockets.NetworkStream
        stream)
        {
            var return_v = new System.IO.StreamReader((System.IO.Stream)stream);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 8003, 8027);
            return return_v;
        }


        System.Net.Sockets.NetworkStream
        f_1626_8076_8082()
        {
            var return_v = Stream;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 8076, 8082);
            return return_v;
        }


        System.IO.StreamWriter
        f_1626_8059_8083(System.Net.Sockets.NetworkStream
        stream)
        {
            var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 8059, 8083);
            return return_v;
        }


        System.IO.StreamWriter
        f_1626_8102_8112()
        {
            var return_v = TextWriter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 8102, 8112);
            return return_v;
        }


        int
        f_1626_8615_8637(System.Net.Sockets.Socket
        this_param)
        {
            this_param.Dispose();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 8615, 8637);
            return 0;
        }


        int
        f_1626_8883_8956(bool
        condition, string
        message)
        {
            Dbg.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 8883, 8956);
            return 0;
        }


        string
        f_1626_9059_9069(System.Exception
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 9059, 9069);
            return return_v;
        }


        bool
        f_1626_9038_9070(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 9038, 9070);
            return return_v;
        }


        string
        f_1626_9073_9083(System.Exception
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 9073, 9083);
            return return_v;
        }


        int
        f_1626_9117_9294(System.Management.Automation.Tracing.PowerShellTraceSource
        this_param, string
        className, string
        methodName, System.Guid
        workflowId, string
        message, params string[]
        parameters)
        {
            this_param.WriteMessage(className, methodName, workflowId, message, parameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 9117, 9294);
            return 0;
        }


        string
        f_1626_9422_9494()
        {
            var return_v = RemotingErrorIdStrings.RemoteSessionHyperVSocketServerConstructorFailure;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 9422, 9494);
            return return_v;
        }


        string
        f_1626_9375_9495(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 9375, 9495);
            return return_v;
        }


        string
        f_1626_9543_9621(System.Management.Automation.Remoting.PSRemotingErrorId
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 9543, 9621);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1626_9321_9702(string
        message, System.Exception
        innerException, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        target)
        {
            var return_v = new System.Management.Automation.PSInvalidOperationException(message, innerException, errorId, errorCategory, target);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 9321, 9702);
            return return_v;
        }

    }
    internal sealed class RemoteSessionHyperVSocketClient : IDisposable
    {
        private readonly object _syncObject;

        private PowerShellTraceSource _tracer;

        private static ManualResetEvent s_connectDone;

        public const int
        HV_PROTOCOL_RAW = 1
        ;

        public const int
        HVSOCKET_CONTAINER_PASSTHRU = 2
        ;

        public HyperVSocketEndPoint EndPoint { get; }

        public Socket HyperVSocket { get; }

        public NetworkStream Stream { get; private set; }

        public StreamReader TextReader { get; private set; }

        public StreamWriter TextWriter { get; private set; }

        public bool IsDisposed { get; private set; }

        internal RemoteSessionHyperVSocketClient(
                    Guid vmId,
                    bool isFirstConnection,
                    bool isContainer = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1626, 12424, 14307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 10971, 10982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11023, 11078);
                this._tracer = f_1626_11033_11078();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11525, 11570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11677, 11712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11819, 11868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11980, 12032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 12144, 12196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 12314, 12358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 12590, 12605);

                Guid
                serviceId
                = default(Guid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 12621, 12648);

                _syncObject = f_1626_12635_12647();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 12664, 13024) || true) && (isFirstConnection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 12664, 13024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 12769, 12830);

                    serviceId = f_1626_12781_12829("999e53d4-3d5c-4c3e-8779-bed06ec056e1");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 12664, 13024);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 12664, 13024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 12948, 13009);

                    serviceId = f_1626_12960_13008("a5201c21-2770-4c11-a68e-f182edb29220");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 12664, 13024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 13040, 13125);

                EndPoint = f_1626_13051_13124(HyperVSocketEndPoint.AF_HYPERV, vmId, serviceId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 13141, 13246);

                HyperVSocket = f_1626_13156_13245(f_1626_13167_13189(f_1626_13167_13175()), SocketType.Stream, 1);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 13554, 14296) || true) && (isContainer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 13554, 14296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 13603, 13638);

                    var
                    value = new byte[sizeof(uint)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 13656, 13669);

                    value[0] = 1;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 13733, 13988);

                        f_1626_13733_13987(f_1626_13733_13745(), HV_PROTOCOL_RAW, HVSOCKET_CONTAINER_PASSTHRU, value);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 14025, 14281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14071, 14262);

                        throw f_1626_14077_14261(f_1626_14125_14260(f_1626_14172_14259()));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 14025, 14281);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 13554, 14296);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1626, 12424, 14307);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 12424, 14307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 12424, 14307);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 14441, 15377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14493, 14504);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14538, 14565) || true) && (f_1626_14542_14552())
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 14538, 14565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14556, 14563);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 14538, 14565);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14585, 14603);

                    IsDisposed = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14634, 14825) || true) && (f_1626_14638_14648() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 14634, 14825);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14696, 14717);

                        f_1626_14696_14716(f_1626_14696_14706());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 14737, 14772);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 14737, 14772);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14792, 14810);

                    TextReader = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 14634, 14825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14841, 15032) || true) && (f_1626_14845_14855() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 14841, 15032);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14903, 14924);

                        f_1626_14903_14923(f_1626_14903_14913());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 14944, 14979);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 14944, 14979);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 14999, 15017);

                    TextWriter = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 14841, 15032);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 15048, 15193) || true) && (f_1626_15052_15058() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 15048, 15193);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 15106, 15123);

                        f_1626_15106_15122(f_1626_15106_15112());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 15143, 15178);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 15143, 15178);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 15048, 15193);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 15209, 15366) || true) && (f_1626_15213_15225() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 15209, 15366);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 15273, 15296);

                        f_1626_15273_15295(f_1626_15273_15285());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1626, 15316, 15351);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1626, 15316, 15351);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 15209, 15366);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 14441, 15377);

                bool
                f_1626_14542_14552()
                {
                    var return_v = IsDisposed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 14542, 14552);
                    return return_v;
                }


                System.IO.StreamReader
                f_1626_14638_14648()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 14638, 14648);
                    return return_v;
                }


                System.IO.StreamReader
                f_1626_14696_14706()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 14696, 14706);
                    return return_v;
                }


                int
                f_1626_14696_14716(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 14696, 14716);
                    return 0;
                }


                System.IO.StreamWriter
                f_1626_14845_14855()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 14845, 14855);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1626_14903_14913()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 14903, 14913);
                    return return_v;
                }


                int
                f_1626_14903_14923(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 14903, 14923);
                    return 0;
                }


                System.Net.Sockets.NetworkStream
                f_1626_15052_15058()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 15052, 15058);
                    return return_v;
                }


                System.Net.Sockets.NetworkStream
                f_1626_15106_15112()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 15106, 15112);
                    return return_v;
                }


                int
                f_1626_15106_15122(System.Net.Sockets.NetworkStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 15106, 15122);
                    return 0;
                }


                System.Net.Sockets.Socket
                f_1626_15213_15225()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 15213, 15225);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_15273_15285()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 15273, 15285);
                    return return_v;
                }


                int
                f_1626_15273_15295(System.Net.Sockets.Socket
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 15273, 15295);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 14441, 15377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 14441, 15377);
            }
        }

        public bool Connect(
                    NetworkCredential networkCredential,
                    string configurationName,
                    bool isFirstConnection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 15915, 21521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16086, 16106);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16299, 16624) || true) && (isFirstConnection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 16299, 16624);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16354, 16609) || true) && (f_1626_16358_16406(f_1626_16379_16405(networkCredential)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 16354, 16609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16448, 16590);

                        throw f_1626_16454_16589(f_1626_16502_16588(f_1626_16549_16587()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 16354, 16609);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 16299, 16624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16640, 16671);

                f_1626_16640_16670(f_1626_16640_16652(), f_1626_16661_16669());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16687, 21480) || true) && (f_1626_16691_16713(f_1626_16691_16703()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 16687, 21480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16747, 16868);

                    f_1626_16747_16867(_tracer, "RemoteSessionHyperVSocketClient", "Connect", Guid.Empty, "Client connected.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16888, 16935);

                    Stream = f_1626_16897_16934(f_1626_16915_16927(), true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 16955, 21041) || true) && (isFirstConnection)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 16955, 21041);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17018, 17180) || true) && (f_1626_17022_17068(f_1626_17043_17067(networkCredential)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 17018, 17180);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17118, 17157);

                            networkCredential.Domain = "localhost";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 17018, 17180);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17204, 17274);

                        bool
                        emptyPassword = f_1626_17225_17273(f_1626_17246_17272(networkCredential))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17296, 17362);

                        bool
                        emptyConfiguration = f_1626_17322_17361(configurationName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17386, 17454);

                        byte[]
                        domain = f_1626_17402_17453(f_1626_17402_17418(), f_1626_17428_17452(networkCredential))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17476, 17548);

                        byte[]
                        userName = f_1626_17494_17547(f_1626_17494_17510(), f_1626_17520_17546(networkCredential))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17570, 17642);

                        byte[]
                        password = f_1626_17588_17641(f_1626_17588_17604(), f_1626_17614_17640(networkCredential))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17664, 17694);

                        byte[]
                        response = new byte[4]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17743, 17765);

                        string
                        responseString
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 17995, 18021);

                        f_1626_17995_18020(f_1626_17995_18007(), domain);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18043, 18074);

                        f_1626_18043_18073(f_1626_18043_18055(), response);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18098, 18126);

                        f_1626_18098_18125(f_1626_18098_18110(), userName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18148, 18179);

                        f_1626_18148_18178(f_1626_18148_18160(), response);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18413, 19095) || true) && (emptyPassword)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 18413, 19095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18480, 18534);

                            f_1626_18480_18533(f_1626_18480_18492(), f_1626_18498_18532(f_1626_18498_18512(), "EMPTYPW"));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18560, 18591);

                            f_1626_18560_18590(f_1626_18560_18572(), response);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18617, 18669);

                            responseString = f_1626_18634_18668(f_1626_18634_18648(), response);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 18413, 19095);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 18413, 19095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18767, 18824);

                            f_1626_18767_18823(f_1626_18767_18779(), f_1626_18785_18822(f_1626_18785_18799(), "NONEMPTYPW"));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18850, 18881);

                            f_1626_18850_18880(f_1626_18850_18862(), response);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18909, 18937);

                            f_1626_18909_18936(f_1626_18909_18921(), password);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 18963, 18994);

                            f_1626_18963_18993(f_1626_18963_18975(), response);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 19020, 19072);

                            responseString = f_1626_19037_19071(f_1626_19037_19051(), response);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 18413, 19095);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 19678, 20028) || true) && (f_1626_19682_19746(responseString, "FAIL", StringComparison.Ordinal) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 19678, 20028);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 19801, 19829);

                            f_1626_19801_19828(f_1626_19801_19813(), response);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 19857, 20005);

                            throw f_1626_19863_20004(f_1626_19915_20003(f_1626_19962_20002()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 19678, 20028);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20200, 21022) || true) && (f_1626_20204_20268(responseString, "CONF", StringComparison.Ordinal) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 20200, 21022);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20323, 20873) || true) && (emptyConfiguration)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 20323, 20873);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20403, 20457);

                                f_1626_20403_20456(f_1626_20403_20415(), f_1626_20421_20455(f_1626_20421_20435(), "EMPTYCF"));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 20323, 20873);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 20323, 20873);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20571, 20628);

                                f_1626_20571_20627(f_1626_20571_20583(), f_1626_20589_20626(f_1626_20589_20603(), "NONEMPTYCF"));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20658, 20689);

                                f_1626_20658_20688(f_1626_20658_20670(), response);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20721, 20786);

                                byte[]
                                configName = f_1626_20741_20785(f_1626_20741_20757(), configurationName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20816, 20846);

                                f_1626_20816_20845(f_1626_20816_20828(), configName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 20323, 20873);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 20200, 21022);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 20200, 21022);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 20971, 20999);

                            f_1626_20971_20998(f_1626_20971_20983(), response);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 20200, 21022);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 16955, 21041);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21061, 21099);

                    TextReader = f_1626_21074_21098(f_1626_21091_21097());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21117, 21155);

                    TextWriter = f_1626_21130_21154(f_1626_21147_21153());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21173, 21201);

                    f_1626_21173_21183().AutoFlush = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21221, 21235);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 16687, 21480);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1626, 16687, 21480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21301, 21430);

                    f_1626_21301_21429(_tracer, "RemoteSessionHyperVSocketClient", "Connect", Guid.Empty, "Client unable to connect.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21450, 21465);

                    result = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1626, 16687, 21480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21496, 21510);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 15915, 21521);

                string
                f_1626_16379_16405(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 16379, 16405);
                    return return_v;
                }


                bool
                f_1626_16358_16406(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 16358, 16406);
                    return return_v;
                }


                string
                f_1626_16549_16587()
                {
                    var return_v = RemotingErrorIdStrings.InvalidUsername;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 16549, 16587);
                    return return_v;
                }


                string
                f_1626_16502_16588(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 16502, 16588);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSDirectException
                f_1626_16454_16589(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSDirectException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 16454, 16589);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_16640_16652()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 16640, 16652);
                    return return_v;
                }


                System.Management.Automation.Remoting.HyperVSocketEndPoint
                f_1626_16661_16669()
                {
                    var return_v = EndPoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 16661, 16669);
                    return return_v;
                }


                int
                f_1626_16640_16670(System.Net.Sockets.Socket
                this_param, System.Management.Automation.Remoting.HyperVSocketEndPoint
                remoteEP)
                {
                    this_param.Connect((System.Net.EndPoint)remoteEP);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 16640, 16670);
                    return 0;
                }


                System.Net.Sockets.Socket
                f_1626_16691_16703()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 16691, 16703);
                    return return_v;
                }


                bool
                f_1626_16691_16713(System.Net.Sockets.Socket
                this_param)
                {
                    var return_v = this_param.Connected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 16691, 16713);
                    return return_v;
                }


                int
                f_1626_16747_16867(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 16747, 16867);
                    return 0;
                }


                System.Net.Sockets.Socket
                f_1626_16915_16927()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 16915, 16927);
                    return return_v;
                }


                System.Net.Sockets.NetworkStream
                f_1626_16897_16934(System.Net.Sockets.Socket
                socket, bool
                ownsSocket)
                {
                    var return_v = new System.Net.Sockets.NetworkStream(socket, ownsSocket);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 16897, 16934);
                    return return_v;
                }


                string
                f_1626_17043_17067(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.Domain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17043, 17067);
                    return return_v;
                }


                bool
                f_1626_17022_17068(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 17022, 17068);
                    return return_v;
                }


                string
                f_1626_17246_17272(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.Password;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17246, 17272);
                    return return_v;
                }


                bool
                f_1626_17225_17273(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 17225, 17273);
                    return return_v;
                }


                bool
                f_1626_17322_17361(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 17322, 17361);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_17402_17418()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17402, 17418);
                    return return_v;
                }


                string
                f_1626_17428_17452(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.Domain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17428, 17452);
                    return return_v;
                }


                byte[]
                f_1626_17402_17453(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 17402, 17453);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_17494_17510()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17494, 17510);
                    return return_v;
                }


                string
                f_1626_17520_17546(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17520, 17546);
                    return return_v;
                }


                byte[]
                f_1626_17494_17547(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 17494, 17547);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_17588_17604()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17588, 17604);
                    return return_v;
                }


                string
                f_1626_17614_17640(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.Password;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17614, 17640);
                    return return_v;
                }


                byte[]
                f_1626_17588_17641(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 17588, 17641);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_17995_18007()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 17995, 18007);
                    return return_v;
                }


                int
                f_1626_17995_18020(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 17995, 18020);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18043_18055()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18043, 18055);
                    return return_v;
                }


                int
                f_1626_18043_18073(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Receive(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18043, 18073);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18098_18110()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18098, 18110);
                    return return_v;
                }


                int
                f_1626_18098_18125(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18098, 18125);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18148_18160()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18148, 18160);
                    return return_v;
                }


                int
                f_1626_18148_18178(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Receive(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18148, 18178);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18480_18492()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18480, 18492);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_18498_18512()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18498, 18512);
                    return return_v;
                }


                byte[]
                f_1626_18498_18532(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18498, 18532);
                    return return_v;
                }


                int
                f_1626_18480_18533(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18480, 18533);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18560_18572()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18560, 18572);
                    return return_v;
                }


                int
                f_1626_18560_18590(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Receive(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18560, 18590);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_18634_18648()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18634, 18648);
                    return return_v;
                }


                string
                f_1626_18634_18668(System.Text.Encoding
                this_param, byte[]
                bytes)
                {
                    var return_v = this_param.GetString(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18634, 18668);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18767_18779()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18767, 18779);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_18785_18799()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18785, 18799);
                    return return_v;
                }


                byte[]
                f_1626_18785_18822(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18785, 18822);
                    return return_v;
                }


                int
                f_1626_18767_18823(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18767, 18823);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18850_18862()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18850, 18862);
                    return return_v;
                }


                int
                f_1626_18850_18880(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Receive(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18850, 18880);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18909_18921()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18909, 18921);
                    return return_v;
                }


                int
                f_1626_18909_18936(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18909, 18936);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_18963_18975()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 18963, 18975);
                    return return_v;
                }


                int
                f_1626_18963_18993(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Receive(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 18963, 18993);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_19037_19051()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 19037, 19051);
                    return return_v;
                }


                string
                f_1626_19037_19071(System.Text.Encoding
                this_param, byte[]
                bytes)
                {
                    var return_v = this_param.GetString(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 19037, 19071);
                    return return_v;
                }


                int
                f_1626_19682_19746(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 19682, 19746);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_19801_19813()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 19801, 19813);
                    return return_v;
                }


                int
                f_1626_19801_19828(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 19801, 19828);
                    return return_v;
                }


                string
                f_1626_19962_20002()
                {
                    var return_v = RemotingErrorIdStrings.InvalidCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 19962, 20002);
                    return return_v;
                }


                string
                f_1626_19915_20003(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 19915, 20003);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSDirectException
                f_1626_19863_20004(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSDirectException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 19863, 20004);
                    return return_v;
                }


                int
                f_1626_20204_20268(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20204, 20268);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_20403_20415()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20403, 20415);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_20421_20435()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20421, 20435);
                    return return_v;
                }


                byte[]
                f_1626_20421_20455(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20421, 20455);
                    return return_v;
                }


                int
                f_1626_20403_20456(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20403, 20456);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_20571_20583()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20571, 20583);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_20589_20603()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20589, 20603);
                    return return_v;
                }


                byte[]
                f_1626_20589_20626(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20589, 20626);
                    return return_v;
                }


                int
                f_1626_20571_20627(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20571, 20627);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_20658_20670()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20658, 20670);
                    return return_v;
                }


                int
                f_1626_20658_20688(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Receive(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20658, 20688);
                    return return_v;
                }


                System.Text.Encoding
                f_1626_20741_20757()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20741, 20757);
                    return return_v;
                }


                byte[]
                f_1626_20741_20785(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20741, 20785);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_20816_20828()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20816, 20828);
                    return return_v;
                }


                int
                f_1626_20816_20845(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20816, 20845);
                    return return_v;
                }


                System.Net.Sockets.Socket
                f_1626_20971_20983()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 20971, 20983);
                    return return_v;
                }


                int
                f_1626_20971_20998(System.Net.Sockets.Socket
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.Send(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 20971, 20998);
                    return return_v;
                }


                System.Net.Sockets.NetworkStream
                f_1626_21091_21097()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 21091, 21097);
                    return return_v;
                }


                System.IO.StreamReader
                f_1626_21074_21098(System.Net.Sockets.NetworkStream
                stream)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 21074, 21098);
                    return return_v;
                }


                System.Net.Sockets.NetworkStream
                f_1626_21147_21153()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 21147, 21153);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1626_21130_21154(System.Net.Sockets.NetworkStream
                stream)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 21130, 21154);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1626_21173_21183()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 21173, 21183);
                    return return_v;
                }


                int
                f_1626_21301_21429(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 21301, 21429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 15915, 21521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 15915, 21521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1626, 21533, 21642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21577, 21594);

                f_1626_21577_21593(f_1626_21577_21583());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 21608, 21631);

                f_1626_21608_21630(f_1626_21608_21620());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1626, 21533, 21642);

                System.Net.Sockets.NetworkStream
                f_1626_21577_21583()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 21577, 21583);
                    return return_v;
                }


                int
                f_1626_21577_21593(System.Net.Sockets.NetworkStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 21577, 21593);
                    return 0;
                }


                System.Net.Sockets.Socket
                f_1626_21608_21620()
                {
                    var return_v = HyperVSocket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 21608, 21620);
                    return return_v;
                }


                int
                f_1626_21608_21630(System.Net.Sockets.Socket
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 21608, 21630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1626, 21533, 21642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 21533, 21642);
            }
        }

        static RemoteSessionHyperVSocketClient()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1626, 10836, 21671);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11123, 11183);
            s_connectDone = f_1626_11156_11183(false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11278, 11297);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1626, 11325, 11356);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1626, 10836, 21671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1626, 10836, 21671);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1626, 10836, 21671);

        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1626_11033_11078()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 11033, 11078);
            return return_v;
        }


        static System.Threading.ManualResetEvent
        f_1626_11156_11183(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 11156, 11183);
            return return_v;
        }


        object
        f_1626_12635_12647()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 12635, 12647);
            return return_v;
        }


        System.Guid
        f_1626_12781_12829(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 12781, 12829);
            return return_v;
        }


        System.Guid
        f_1626_12960_13008(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 12960, 13008);
            return return_v;
        }


        System.Management.Automation.Remoting.HyperVSocketEndPoint
        f_1626_13051_13124(System.Net.Sockets.AddressFamily
        AddrFamily, System.Guid
        VmId, System.Guid
        ServiceId)
        {
            var return_v = new System.Management.Automation.Remoting.HyperVSocketEndPoint(AddrFamily, VmId, ServiceId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 13051, 13124);
            return return_v;
        }


        System.Management.Automation.Remoting.HyperVSocketEndPoint
        f_1626_13167_13175()
        {
            var return_v = EndPoint;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 13167, 13175);
            return return_v;
        }


        System.Net.Sockets.AddressFamily
        f_1626_13167_13189(System.Management.Automation.Remoting.HyperVSocketEndPoint
        this_param)
        {
            var return_v = this_param.AddressFamily;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 13167, 13189);
            return return_v;
        }


        System.Net.Sockets.Socket
        f_1626_13156_13245(System.Net.Sockets.AddressFamily
        addressFamily, System.Net.Sockets.SocketType
        socketType, int
        protocolType)
        {
            var return_v = new System.Net.Sockets.Socket(addressFamily, socketType, (System.Net.Sockets.ProtocolType)protocolType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 13156, 13245);
            return return_v;
        }


        System.Net.Sockets.Socket
        f_1626_13733_13745()
        {
            var return_v = HyperVSocket;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 13733, 13745);
            return return_v;
        }


        int
        f_1626_13733_13987(System.Net.Sockets.Socket
        this_param, int
        optionLevel, int
        optionName, byte[]
        optionValue)
        {
            this_param.SetSocketOption((System.Net.Sockets.SocketOptionLevel)optionLevel, (System.Net.Sockets.SocketOptionName)optionName, optionValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 13733, 13987);
            return 0;
        }


        string
        f_1626_14172_14259()
        {
            var return_v = RemotingErrorIdStrings.RemoteSessionHyperVSocketClientConstructorSetSocketOptionFailure;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1626, 14172, 14259);
            return return_v;
        }


        string
        f_1626_14125_14260(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 14125, 14260);
            return return_v;
        }


        System.Management.Automation.Remoting.PSDirectException
        f_1626_14077_14261(string
        message)
        {
            var return_v = new System.Management.Automation.Remoting.PSDirectException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1626, 14077, 14261);
            return return_v;
        }

    }
}
