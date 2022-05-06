// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

using Dbg = System.Diagnostics.Debug;

namespace System.Management.Automation.Remoting.Client
{
    internal static class WSManNativeApi
    {
        internal const uint
        INFINITE = 0xFFFFFFFF
        ;

        internal const string
        PS_CREATION_XML_TAG = "creationXml"
        ;

        internal const string
        PS_CONNECT_XML_TAG = "connectXml"
        ;

        internal const string
        PS_CONNECTRESPONSE_XML_TAG = "connectResponseXml"
        ;

        internal const string
        PS_XML_NAMESPACE = "http://schemas.microsoft.com/powershell"
        ;

        internal const string
        WSMAN_STREAM_ID_STDOUT = "stdout"
        ;

        internal const string
        WSMAN_STREAM_ID_PROMPTRESPONSE = "pr"
        ;

        internal const string
        WSMAN_STREAM_ID_STDIN = "stdin"
        ;

        internal const string
        ResourceURIPrefix = @"http://schemas.microsoft.com/powershell/"
        ;

        internal const string
        NoProfile = "WINRS_NOPROFILE"
        ;

        internal const string
        CodePage = "WINRS_CODEPAGE"
        ;

        internal static readonly Version WSMAN_STACK_VERSION;

        internal const int
        WSMAN_FLAG_REQUESTED_API_VERSION_1_1 = 1
        ;

        internal const int
        WSMAN_DEFAULT_MAX_ENVELOPE_SIZE_KB_V2 = 150
        ;

        internal const int
        WSMAN_DEFAULT_MAX_ENVELOPE_SIZE_KB_V3 = 500
        ;

        internal const int
        ERROR_WSMAN_REDIRECT_REQUESTED = -2144108135
        ;

        internal const int
        ERROR_WSMAN_INVALID_RESOURCE_URI = -2144108485
        ;

        internal const int
        ERROR_WSMAN_INUSE_CANNOT_RECONNECT = -2144108083
        ;

        internal const int
        ERROR_WSMAN_SENDDATA_CANNOT_CONNECT = -2144108526
        ;

        internal const int
        ERROR_WSMAN_SENDDATA_CANNOT_COMPLETE = -2144108250
        ;

        internal const int
        ERROR_WSMAN_ACCESS_DENIED = 5
        ;

        internal const int
        ERROR_WSMAN_OUTOF_MEMORY = 14
        ;

        internal const int
        ERROR_WSMAN_NETWORKPATH_NOTFOUND = 53
        ;

        internal const int
        ERROR_WSMAN_OPERATION_ABORTED = 995
        ;

        internal const int
        ERROR_WSMAN_SHUTDOWN_INPROGRESS = 1115
        ;

        internal const int
        ERROR_WSMAN_AUTHENTICATION_FAILED = 1311
        ;

        internal const int
        ERROR_WSMAN_NO_LOGON_SESSION_EXIST = 1312
        ;

        internal const int
        ERROR_WSMAN_LOGON_FAILURE = 1326
        ;

        internal const int
        ERROR_WSMAN_IMPROPER_RESPONSE = 1722
        ;

        internal const int
        ERROR_WSMAN_INCORRECT_PROTOCOLVERSION = -2141974624
        ;

        internal const int
        ERROR_WSMAN_URL_NOTAVAILABLE = -2144108269
        ;

        internal const int
        ERROR_WSMAN_INVALID_AUTHENTICATION = -2144108274
        ;

        internal const int
        ERROR_WSMAN_CANNOT_CONNECT_INVALID = -2144108080
        ;

        internal const int
        ERROR_WSMAN_CANNOT_CONNECT_MISMATCH = -2144108090
        ;

        internal const int
        ERROR_WSMAN_CANNOT_CONNECT_RUNASFAILED = -2144108065
        ;

        internal const int
        ERROR_WSMAN_CREATEFAILED_INVALIDNAME = -2144108094
        ;

        internal const int
        ERROR_WSMAN_TARGETSESSION_DOESNOTEXIST = -2144108453
        ;

        internal const int
        ERROR_WSMAN_REMOTESESSION_DISALLOWED = -2144108116
        ;

        internal const int
        ERROR_WSMAN_REMOTECONNECTION_DISALLOWED = -2144108061
        ;

        internal const int
        ERROR_WSMAN_INVALID_RESOURCE_URI2 = -2144108542
        ;

        internal const int
        ERROR_WSMAN_CORRUPTED_CONFIG = -2144108539
        ;

        internal const int
        ERROR_WSMAN_URI_LIMIT = -2144108499
        ;

        internal const int
        ERROR_WSMAN_CLIENT_KERBEROS_DISABLED = -2144108318
        ;

        internal const int
        ERROR_WSMAN_SERVER_NOTTRUSTED = -2144108316
        ;

        internal const int
        ERROR_WSMAN_WORKGROUP_NO_KERBEROS = -2144108276
        ;

        internal const int
        ERROR_WSMAN_EXPLICIT_CREDENTIALS_REQUIRED = -2144108315
        ;

        internal const int
        ERROR_WSMAN_REDIRECT_LOCATION_INVALID = -2144108105
        ;

        internal const int
        ERROR_WSMAN_BAD_METHOD = -2144108428
        ;

        internal const int
        ERROR_WSMAN_HTTP_SERVICE_UNAVAILABLE = -2144108270
        ;

        internal const int
        ERROR_WSMAN_HTTP_SERVICE_ERROR = -2144108176
        ;

        internal const int
        ERROR_WSMAN_COMPUTER_NOTFOUND = -2144108103
        ;

        internal const int
        ERROR_WSMAN_TARGET_UNKNOWN = -2146893053
        ;

        internal const int
        ERROR_WSMAN_CANNOTUSE_IP = -2144108101
        ;

        internal struct MarshalledObject : IDisposable
        {

            private IntPtr _dataPtr;

            internal MarshalledObject(IntPtr dataPtr)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 6877, 6985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 6951, 6970);

                    _dataPtr = dataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 6877, 6985);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 6877, 6985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 6877, 6985);
                }
            }

            internal IntPtr DataPtr
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 7123, 7147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 7129, 7145);

                        return _dataPtr;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 7123, 7147);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 7097, 7149);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 7097, 7149);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal static MarshalledObject Create<T>(T obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 7495, 7912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 7577, 7632);

                    IntPtr
                    ptr = f_1639_7590_7631(f_1639_7611_7630())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 7650, 7690);

                    f_1639_7650_7689(obj, ptr, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 7774, 7823);

                    MarshalledObject
                    result = f_1639_7800_7822()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 7841, 7863);

                    result._dataPtr = ptr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 7883, 7897);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 7495, 7912);

                    int
                    f_1639_7611_7630()
                    {
                        var return_v = Marshal.SizeOf<T>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 7611, 7630);
                        return return_v;
                    }


                    System.IntPtr
                    f_1639_7590_7631(int
                    cb)
                    {
                        var return_v = Marshal.AllocHGlobal(cb);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 7590, 7631);
                        return return_v;
                    }


                    int
                    f_1639_7650_7689(T
                    structure, System.IntPtr
                    ptr, bool
                    fDeleteOld)
                    {
                        Marshal.StructureToPtr(structure, ptr, fDeleteOld);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 7650, 7689);
                        return 0;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.MarshalledObject
                    f_1639_7800_7822()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.MarshalledObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 7800, 7822);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 7495, 7912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 7495, 7912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 8030, 8262);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 8084, 8247) || true) && (IntPtr.Zero != _dataPtr)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 8084, 8247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 8153, 8183);

                        f_1639_8153_8182(_dataPtr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 8205, 8228);

                        _dataPtr = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 8084, 8247);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 8030, 8262);

                    int
                    f_1639_8153_8182(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 8153, 8182);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 8030, 8262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 8030, 8262);
                }
            }

            /// <summary>
            /// Implicit cast to IntPtr.
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(MarshalledObject obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 8456, 8584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 8549, 8569);

                    return obj._dataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 8456, 8584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 8456, 8584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 8456, 8584);
                }
            }
            static MarshalledObject()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 6576, 8595);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 6576, 8595);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 6576, 8595);
            }
        }



        /// <summary>
        /// Different Authentication Mechanisms supported by WSMan.
        /// TODO: By the look of it, this appears like a Flags enum.
        /// Need to confirm the behavior with WSMan.
        /// </summary>
        /// <remarks>
        /// Please keep in sync with WSManAuthenticationMechanism
        /// from C:\e\win7_powershell\admin\monad\nttargets\assemblies\logging\ETW\Manifests\Microsoft-Windows-PowerShell-Instrumentation.man
        /// </remarks>
        [Flags]
        internal enum WSManAuthenticationMechanism : int
        {
            /// <summary>
            /// Use the default authentication.
            /// </summary>
            WSMAN_FLAG_DEFAULT_AUTHENTICATION = 0x0,
            /// <summary>
            /// Use no authentication for a remote operation.
            /// </summary>
            WSMAN_FLAG_NO_AUTHENTICATION = 0x1,
            /// <summary>
            /// Use digest authentication for a remote operation.
            /// </summary>
            WSMAN_FLAG_AUTH_DIGEST = 0x2,
            /// <summary>
            /// Use negotiate authentication for a remote operation (may use kerberos or ntlm)
            /// </summary>
            WSMAN_FLAG_AUTH_NEGOTIATE = 0x4,
            /// <summary>
            /// Use basic authentication for a remote operation.
            /// </summary>
            WSMAN_FLAG_AUTH_BASIC = 0x8,
            /// <summary>
            /// Use kerberos authentication for a remote operation.
            /// </summary>
            WSMAN_FLAG_AUTH_KERBEROS = 0x10,
            /// <summary>
            /// Use client certificate authentication for a remote operation.
            /// </summary>
            WSMAN_FLAG_AUTH_CLIENT_CERTIFICATE = 0x20,
            /// <summary>
            /// Use CredSSP authentication for a remote operation.
            /// </summary>
            WSMAN_FLAG_AUTH_CREDSSP = 0x80,
        }
        internal abstract class BaseWSManAuthenticationCredentials : IDisposable
        {
            public abstract MarshalledObject GetMarshalledObject();

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 11265, 11399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 11319, 11333);

                    f_1639_11319_11332(this, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 11351, 11384);

                    f_1639_11351_11383(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 11265, 11399);

                    int
                    f_1639_11319_11332(System.Management.Automation.Remoting.Client.WSManNativeApi.BaseWSManAuthenticationCredentials
                    this_param, bool
                    isDisposing)
                    {
                        this_param.Dispose(isDisposing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 11319, 11332);
                        return 0;
                    }


                    int
                    f_1639_11351_11383(System.Management.Automation.Remoting.Client.WSManNativeApi.BaseWSManAuthenticationCredentials
                    obj)
                    {
                        System.GC.SuppressFinalize((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 11351, 11383);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 11265, 11399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 11265, 11399);
                }
            }

            protected virtual void Dispose(bool isDisposing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 11415, 11493);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 11415, 11493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 11415, 11493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 11415, 11493);
                }
            }

            public BaseWSManAuthenticationCredentials()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 11039, 11504);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 11039, 11504);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 11039, 11504);
            }


            static BaseWSManAuthenticationCredentials()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 11039, 11504);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 11039, 11504);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 11039, 11504);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 11039, 11504);
        }
        internal class WSManUserNameAuthenticationCredentials : BaseWSManAuthenticationCredentials
        {
            [StructLayout(LayoutKind.Sequential)]
            internal struct WSManUserNameCredentialStruct
            {

                internal WSManAuthenticationMechanism authenticationMechanism;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string userName;

                [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
                internal IntPtr password;
                static WSManUserNameCredentialStruct()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 11846, 12535);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 11846, 12535);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 11846, 12535);
                }
            }

            private WSManUserNameCredentialStruct _cred;

            private MarshalledObject _data;

            internal WSManUserNameAuthenticationCredentials()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 12749, 12978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 12831, 12875);

                    _cred = f_1639_12839_12874();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 12893, 12963);

                    _data = MarshalledObject.Create<WSManUserNameCredentialStruct>(_cred);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 12749, 12978);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 12749, 12978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 12749, 12978);
                }
            }

            internal WSManUserNameAuthenticationCredentials(string name,
                            System.Security.SecureString pwd, WSManAuthenticationMechanism authMechanism)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 13864, 14460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14052, 14096);

                    _cred = f_1639_14060_14095();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14114, 14160);

                    _cred.authenticationMechanism = authMechanism;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14178, 14200);

                    _cred.userName = name;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14218, 14355) || true) && (pwd != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 14218, 14355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14275, 14336);

                        _cred.password = f_1639_14292_14335(pwd);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 14218, 14355);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14375, 14445);

                    _data = MarshalledObject.Create<WSManUserNameCredentialStruct>(_cred);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 13864, 14460);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 13864, 14460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 13864, 14460);
                }
            }

            internal WSManUserNameCredentialStruct CredentialStruct
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 14691, 14712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14697, 14710);

                        return _cred;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 14691, 14712);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 14603, 14727);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 14603, 14727);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override MarshalledObject GetMarshalledObject()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 14869, 14984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 14956, 14969);

                    return _data;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 14869, 14984);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 14869, 14984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 14869, 14984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override void Dispose(bool isDisposing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 15150, 15477);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 15232, 15426) || true) && (_cred.password != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 15232, 15426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 15307, 15356);

                        f_1639_15307_15355(_cred.password);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 15378, 15407);

                        _cred.password = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 15232, 15426);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 15446, 15462);

                    _data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 15150, 15477);

                    int
                    f_1639_15307_15355(System.IntPtr
                    s)
                    {
                        Marshal.ZeroFreeCoTaskMemUnicode(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 15307, 15355);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 15150, 15477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 15150, 15477);
                }
            }

            static WSManUserNameAuthenticationCredentials()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 11676, 15488);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 11676, 15488);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 11676, 15488);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 11676, 15488);

            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct
            f_1639_12839_12874()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 12839, 12874);
                return return_v;
            }


            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct
            f_1639_14060_14095()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 14060, 14095);
                return return_v;
            }


            System.IntPtr
            f_1639_14292_14335(System.Security.SecureString
            s)
            {
                var return_v = Marshal.SecureStringToCoTaskMemUnicode(s);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 14292, 14335);
                return return_v;
            }

        }
        internal class WSManCertificateThumbprintCredentials : BaseWSManAuthenticationCredentials
        {
            [StructLayout(LayoutKind.Sequential)]
            private struct WSManThumbprintStruct
            {

                internal WSManAuthenticationMechanism authenticationMechanism;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string certificateThumbprint;

                internal IntPtr reserved;
                static WSManThumbprintStruct()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 15716, 16407);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 15716, 16407);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 15716, 16407);
                }
            }

            private MarshalledObject _data;

            internal WSManCertificateThumbprintCredentials(string thumbPrint)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 16809, 17277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 16907, 16964);

                    WSManThumbprintStruct
                    cred = f_1639_16936_16963()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 16982, 17077);

                    cred.authenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_CLIENT_CERTIFICATE;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 17095, 17135);

                    cred.certificateThumbprint = thumbPrint;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 17153, 17181);

                    cred.reserved = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 17201, 17262);

                    _data = MarshalledObject.Create<WSManThumbprintStruct>(cred);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 16809, 17277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 16809, 17277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 16809, 17277);
                }
            }

            public override MarshalledObject GetMarshalledObject()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 17419, 17534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 17506, 17519);

                    return _data;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 17419, 17534);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 17419, 17534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 17419, 17534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override void Dispose(bool isDisposing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 17700, 17897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 17866, 17882);

                    _data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 17700, 17897);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 17700, 17897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 17700, 17897);
                }
            }

            static WSManCertificateThumbprintCredentials()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 15547, 17908);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 15547, 17908);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 15547, 17908);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 15547, 17908);

            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateThumbprintCredentials.WSManThumbprintStruct
            f_1639_16936_16963()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateThumbprintCredentials.WSManThumbprintStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 16936, 16963);
                return return_v;
            }

        }



        /// <summary>
        /// Enum representing native WSManSessionOption enum.
        /// </summary>
        internal enum WSManSessionOption : int
        {

            /// <summary>
            /// Int - default timeout in ms that applies to all operations on the client side.
            /// </summary>
            WSMAN_OPTION_DEFAULT_OPERATION_TIMEOUTMS = 1,
            /// <summary>
            /// Int - Robust connection maximum retry time in minutes.
            /// </summary>
            WSMAN_OPTION_MAX_RETRY_TIME = 11,
            /// <summary>
            /// Int - timeout in ms for WSManCreateShellEx operations.
            /// </summary>
            WSMAN_OPTION_TIMEOUTMS_CREATE_SHELL = 12,
            /// <summary>
            /// Int - timeout in ms for WSManReceiveShellOutputEx operations.
            /// </summary>
            WSMAN_OPTION_TIMEOUTMS_RECEIVE_SHELL_OUTPUT = 14,
            /// <summary>
            /// Int - timeout in ms for WSManSendShellInputEx operations.
            /// </summary>
            WSMAN_OPTION_TIMEOUTMS_SEND_SHELL_INPUT = 15,
            /// <summary>
            /// Int - timeout in ms for WSManSignalShellEx operations.
            /// </summary>
            WSMAN_OPTION_TIMEOUTMS_SIGNAL_SHELL = 16,
            /// <summary>
            /// Int - timeout in ms for WSManCloseShellOperationEx operations.
            /// </summary>
            WSMAN_OPTION_TIMEOUTMS_CLOSE_SHELL_OPERATION = 17,



            /// <summary>
            /// Int - 1 to not validate the CA on the server certificate; 0 - default.
            /// </summary>
            WSMAN_OPTION_SKIP_CA_CHECK = 18,
            /// <summary>
            /// Int - 1 to not validate the CN on the server certificate; 0 - default.
            /// </summary>
            WSMAN_OPTION_SKIP_CN_CHECK = 19,
            /// <summary>
            /// Int - 1 to not encrypt the messages; 0 - default.
            /// </summary>
            WSMAN_OPTION_UNENCRYPTED_MESSAGES = 20,
            /// <summary>
            /// Int - 1 Send all network packets for remote operations in UTF16; 0 - default is UTF8.
            /// </summary>
            WSMAN_OPTION_UTF16 = 21,
            /// <summary>
            /// Int - 1 When using negotiate, include port number in the connection SPN; 0 - default.
            /// </summary>
            WSMAN_OPTION_ENABLE_SPN_SERVER_PORT = 22,
            /// <summary>
            /// Int - Used when not talking to the main OS on a machine but, for instance, a BMC
            /// 1 Identify this machine to the server by including the MachineID header; 0 - default.
            /// </summary>
            WSMAN_OPTION_MACHINE_ID = 23,
            /// <summary>
            /// Int -1 Enables host process to be created with interactive token.
            /// </summary>
            WSMAN_OPTION_USE_INTERACTIVE_TOKEN = 34,


            /// <summary>
            /// String - RFC 3066 language code.
            /// </summary>
            WSMAN_OPTION_LOCALE = 25,
            /// <summary>
            /// String - RFC 3066 language code.
            /// </summary>
            WSMAN_OPTION_UI_LANGUAGE = 26,


            /// <summary>
            /// Int - max SOAP envelope size (kb) - default 150kb from winrm config
            /// (see 'winrm help config' for more details); the client SOAP packet size cannot surpass
            /// this value; this value will be also sent to the server in the SOAP request as a
            /// MaxEnvelopeSize header; the server will use min(MaxEnvelopeSizeKb from server configuration,
            /// MaxEnvelopeSize value from SOAP).
            /// </summary>
            WSMAN_OPTION_MAX_ENVELOPE_SIZE_KB = 28,
            /// <summary>
            /// Int (read only) - max data size (kb) provided by the client, guaranteed by
            /// the winrm client implementation to fit into one SOAP packet; this is an
            /// approximate value calculated based on the WSMAN_OPTION_MAX_ENVELOPE_SIZE_KB (default 150kb),
            /// the maximum possible size of the SOAP headers and the overhead of the base64
            /// encoding which is specific to WSManSendShellInput API; this option can be used
            /// with WSManGetSessionOptionAsDword API; it cannot be used with WSManSetSessionOption API.
            /// </summary>
            WSMAN_OPTION_SHELL_MAX_DATA_SIZE_PER_MESSAGE_KB = 29,
            /// <summary>
            /// String -
            /// </summary>
            WSMAN_OPTION_REDIRECT_LOCATION = 30,
            /// <summary>
            /// DWORD  - 1 to not validate the revocation status on the server certificate; 0 - default.
            /// </summary>
            WSMAN_OPTION_SKIP_REVOCATION_CHECK = 31,
            /// <summary>
            /// DWORD  - 1 to allow default credentials for Negotiate (this is for SSL only); 0 - default.
            /// </summary>
            WSMAN_OPTION_ALLOW_NEGOTIATE_IMPLICIT_CREDENTIALS = 32,
            /// <summary>
            /// DWORD - When using just a machine name in the connection string use an SSL connection.
            /// 0 means HTTP, 1 means HTTPS.  Default is 0.
            /// </summary>
            WSMAN_OPTION_USE_SSL = 33
        }

        /// <summary>
        /// Enum representing WSMan Shell specific options.
        /// </summary>
        internal enum WSManShellFlag : int
        {
            /// <summary>
            /// Turn off compression for Send/Receive operations.  By default compression is
            /// turned on, but if communicating with a down-level box it may be necessary to
            /// do this.  Other reasons for turning it off is due to the extra memory consumption
            /// and CPU utilization that is used as a result of compression.
            /// </summary>
            WSMAN_FLAG_NO_COMPRESSION = 1,
            /// <summary>
            /// Enable the service to drop operation output when running disconnected.
            /// </summary>
            WSMAN_FLAG_SERVER_BUFFERING_MODE_DROP = 0x4,
            /// <summary>
            /// Enable the service to block operation progress when output buffers are full.
            /// </summary>
            WSMAN_FLAG_SERVER_BUFFERING_MODE_BLOCK = 0x8,
            /// <summary>
            /// Enable receive call to not immediately retrieve results. Only applicable for Receive calls on commands.
            /// </summary>
            WSMAN_FLAG_RECEIVE_DELAY_OUTPUT_STREAM = 0X10
        }


        /// <summary>
        /// Types of supported WSMan data.
        /// PowerShell uses only Text and DWORD (in some places).
        /// </summary>
        internal enum WSManDataType : uint
        {
            WSMAN_DATA_NONE = 0,
            WSMAN_DATA_TYPE_TEXT = 1,
            WSMAN_DATA_TYPE_BINARY = 2,
            WSMAN_DATA_TYPE_WS_XML_READER = 3,
            WSMAN_DATA_TYPE_DWORD = 4
        };
        [StructLayout(LayoutKind.Sequential)]
        internal class WSManDataStruct
        {
            internal uint type;

            internal WSManBinaryOrTextDataStruct binaryOrTextData;

            public WSManDataStruct()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 25343, 25543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 25459, 25463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 25515, 25531);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 25343, 25543);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 25343, 25543);
            }


            static WSManDataStruct()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 25343, 25543);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 25343, 25543);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 25343, 25543);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 25343, 25543);
        }
        [StructLayout(LayoutKind.Sequential)]
        internal class WSManBinaryOrTextDataStruct
        {
            internal int bufferLength;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr data;

            public WSManBinaryOrTextDataStruct()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 25555, 25849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 25682, 25694);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 25555, 25849);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 25555, 25849);
            }


            static WSManBinaryOrTextDataStruct()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 25555, 25849);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 25555, 25849);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 25555, 25849);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 25555, 25849);
        }
        internal class WSManData_ManToUn : IDisposable
        {
            private WSManDataStruct _internalData;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            private IntPtr _marshalledObject;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            private IntPtr _marshalledBuffer;

            internal WSManData_ManToUn(byte[] data)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 26677, 27718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26095, 26108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26246, 26277);
                    this._marshalledObject = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26415, 26446);
                    this._marshalledBuffer = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26749, 26797);

                    f_1639_26749_26796(data != null, "Data cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26817, 26855);

                    _internalData = f_1639_26833_26854();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26873, 26940);

                    _internalData.binaryOrTextData = f_1639_26906_26939();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26958, 27016);

                    _internalData.binaryOrTextData.bufferLength = f_1639_27004_27015(data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 27034, 27098);

                    _internalData.type = (uint)WSManDataType.WSMAN_DATA_TYPE_BINARY;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 27118, 27207);

                    IntPtr
                    dataToSendPtr = f_1639_27141_27206(_internalData.binaryOrTextData.bufferLength)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 27225, 27277);

                    _internalData.binaryOrTextData.data = dataToSendPtr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 27295, 27329);

                    _marshalledBuffer = dataToSendPtr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 27423, 27527);

                    f_1639_27423_27526(data, 0, _internalData.binaryOrTextData.data, _internalData.binaryOrTextData.bufferLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 27545, 27621);

                    _marshalledObject = f_1639_27565_27620(f_1639_27586_27619());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 27639, 27703);

                    f_1639_27639_27702(_internalData, _marshalledObject, false);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 26677, 27718);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 26677, 27718);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 26677, 27718);
                }
            }

            internal WSManData_ManToUn(string data)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 27946, 28833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26095, 26108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26246, 26277);
                    this._marshalledObject = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 26415, 26446);
                    this._marshalledBuffer = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28018, 28066);

                    f_1639_28018_28065(data != null, "Data cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28086, 28124);

                    _internalData = f_1639_28102_28123();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28142, 28209);

                    _internalData.binaryOrTextData = f_1639_28175_28208();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28227, 28285);

                    _internalData.binaryOrTextData.bufferLength = f_1639_28273_28284(data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28303, 28365);

                    _internalData.type = (uint)WSManDataType.WSMAN_DATA_TYPE_TEXT;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28423, 28494);

                    _internalData.binaryOrTextData.data = f_1639_28461_28493(data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28512, 28568);

                    _marshalledBuffer = _internalData.binaryOrTextData.data;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28660, 28736);

                    _marshalledObject = f_1639_28680_28735(f_1639_28701_28734());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 28754, 28818);

                    f_1639_28754_28817(_internalData, _marshalledObject, false);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 27946, 28833);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 27946, 28833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 27946, 28833);
                }
            }

            /// <summary>
            /// Finalizer
            ///
            /// Note: Do not depend on the finalizer! This object should be
            /// properly disposed of when no longer needed via a direct call
            /// to Dispose().
            /// </summary>
            ~WSManData_ManToUn()
            {
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 29187, 29202);

                f_1639_29187_29201(this, false);
            }

            internal uint Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 29379, 29413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 29385, 29411);

                        return _internalData.type;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 29379, 29413);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 29328, 29483);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 29328, 29483);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 29433, 29468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 29439, 29466);

                        _internalData.type = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 29433, 29468);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 29328, 29483);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 29328, 29483);
                    }
                }
            }

            internal int BufferLength
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 29661, 29720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 29667, 29718);

                        return _internalData.binaryOrTextData.bufferLength;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 29661, 29720);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 29603, 29815);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 29603, 29815);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 29740, 29800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 29746, 29798);

                        _internalData.binaryOrTextData.bufferLength = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 29740, 29800);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 29603, 29815);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 29603, 29815);
                    }
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 30045, 30172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30099, 30113);

                    f_1639_30099_30112(this, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30131, 30157);

                    f_1639_30131_30156(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 30045, 30172);

                    int
                    f_1639_30099_30112(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                    this_param, bool
                    isDisposing)
                    {
                        this_param.Dispose(isDisposing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 30099, 30112);
                        return 0;
                    }


                    int
                    f_1639_30131_30156(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                    obj)
                    {
                        GC.SuppressFinalize((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 30131, 30156);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 30045, 30172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 30045, 30172);
                }
            }

            private void Dispose(bool isDisposing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 30188, 30992);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30577, 30767) || true) && (_marshalledBuffer != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 30577, 30767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30655, 30694);

                        f_1639_30655_30693(_marshalledBuffer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30716, 30748);

                        _marshalledBuffer = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 30577, 30767);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30787, 30977) || true) && (_marshalledObject != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 30787, 30977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30865, 30904);

                        f_1639_30865_30903(_marshalledObject);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 30926, 30958);

                        _marshalledObject = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 30787, 30977);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 30188, 30992);

                    int
                    f_1639_30655_30693(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 30655, 30693);
                        return 0;
                    }


                    int
                    f_1639_30865_30903(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 30865, 30903);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 30188, 30992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 30188, 30992);
                }
            }

            /// <summary>
            /// Implicit IntPtr conversion.
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(WSManData_ManToUn data)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 31190, 31508);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 31285, 31493) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 31285, 31493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 31343, 31373);

                        return data._marshalledObject;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 31285, 31493);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 31285, 31493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 31455, 31474);

                        return IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 31285, 31493);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 31190, 31508);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 31190, 31508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 31190, 31508);
                }
            }
            static WSManData_ManToUn()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 26000, 31519);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 26000, 31519);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 26000, 31519);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 26000, 31519);

            int
            f_1639_26749_26796(bool
            condition, string
            message)
            {
                Dbg.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 26749, 26796);
                return 0;
            }


            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
            f_1639_26833_26854()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 26833, 26854);
                return return_v;
            }


            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManBinaryOrTextDataStruct
            f_1639_26906_26939()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManBinaryOrTextDataStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 26906, 26939);
                return return_v;
            }


            int
            f_1639_27004_27015(byte[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 27004, 27015);
                return return_v;
            }


            System.IntPtr
            f_1639_27141_27206(int
            cb)
            {
                var return_v = Marshal.AllocHGlobal(cb);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 27141, 27206);
                return return_v;
            }


            int
            f_1639_27423_27526(byte[]
            source, int
            startIndex, System.IntPtr
            destination, int
            length)
            {
                Marshal.Copy(source, startIndex, destination, length);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 27423, 27526);
                return 0;
            }


            int
            f_1639_27586_27619()
            {
                var return_v = Marshal.SizeOf<WSManDataStruct>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 27586, 27619);
                return return_v;
            }


            System.IntPtr
            f_1639_27565_27620(int
            cb)
            {
                var return_v = Marshal.AllocHGlobal(cb);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 27565, 27620);
                return return_v;
            }


            int
            f_1639_27639_27702(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
            structure, System.IntPtr
            ptr, bool
            fDeleteOld)
            {
                Marshal.StructureToPtr(structure, ptr, fDeleteOld);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 27639, 27702);
                return 0;
            }


            int
            f_1639_28018_28065(bool
            condition, string
            message)
            {
                Dbg.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 28018, 28065);
                return 0;
            }


            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
            f_1639_28102_28123()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 28102, 28123);
                return return_v;
            }


            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManBinaryOrTextDataStruct
            f_1639_28175_28208()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManBinaryOrTextDataStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 28175, 28208);
                return return_v;
            }


            int
            f_1639_28273_28284(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 28273, 28284);
                return return_v;
            }


            System.IntPtr
            f_1639_28461_28493(string
            s)
            {
                var return_v = Marshal.StringToHGlobalUni(s);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 28461, 28493);
                return return_v;
            }


            int
            f_1639_28701_28734()
            {
                var return_v = Marshal.SizeOf<WSManDataStruct>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 28701, 28734);
                return return_v;
            }


            System.IntPtr
            f_1639_28680_28735(int
            cb)
            {
                var return_v = Marshal.AllocHGlobal(cb);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 28680, 28735);
                return return_v;
            }


            int
            f_1639_28754_28817(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
            structure, System.IntPtr
            ptr, bool
            fDeleteOld)
            {
                Marshal.StructureToPtr(structure, ptr, fDeleteOld);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 28754, 28817);
                return 0;
            }


            int
            f_1639_29187_29201(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
            this_param, bool
            isDisposing)
            {
                this_param.Dispose(isDisposing);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 29187, 29201);
                return 0;
            }

        }
        internal class WSManData_UnToMan
        {
            private uint _type;

            internal uint Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 31767, 31788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 31773, 31786);

                        return _type;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 31767, 31788);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 31716, 31845);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 31716, 31845);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 31808, 31830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 31814, 31828);

                        _type = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 31808, 31830);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 31716, 31845);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 31716, 31845);
                    }
                }
            }

            private int _bufferLength;

            internal int BufferLength
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 32063, 32092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32069, 32090);

                        return _bufferLength;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 32063, 32092);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 32005, 32157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 32005, 32157);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 32112, 32142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32118, 32140);

                        _bufferLength = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 32112, 32142);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 32005, 32157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 32005, 32157);
                    }
                }
            }

            private string _text;

            internal string Text
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 32261, 32493);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32305, 32474) || true) && (f_1639_32309_32318(this) == (uint)WSManDataType.WSMAN_DATA_TYPE_TEXT)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 32305, 32474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32389, 32402);

                            return _text;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 32305, 32474);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 32305, 32474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32454, 32474);

                            return string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 32305, 32474);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 32261, 32493);

                        uint
                        f_1639_32309_32318(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 32309, 32318);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 32208, 32508);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 32208, 32508);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private byte[] _data;

            internal byte[] Data
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 32612, 32853);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32656, 32834) || true) && (f_1639_32660_32669(this) == (uint)WSManDataType.WSMAN_DATA_TYPE_BINARY)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 32656, 32834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32742, 32755);

                            return _data;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 32656, 32834);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 32656, 32834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32807, 32834);

                            return f_1639_32814_32833();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 32656, 32834);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 32612, 32853);

                        uint
                        f_1639_32660_32669(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 32660, 32669);
                            return return_v;
                        }


                        byte[]
                        f_1639_32814_32833()
                        {
                            var return_v = Array.Empty<byte>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 32814, 32833);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 32559, 32868);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 32559, 32868);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal static WSManData_UnToMan UnMarshal(WSManDataStruct dataStruct)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 33104, 34814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 33208, 33260);

                    WSManData_UnToMan
                    newData = f_1639_33236_33259()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 33280, 33312);

                    newData._type = dataStruct.type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 33330, 33395);

                    newData._bufferLength = dataStruct.binaryOrTextData.bufferLength;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 33415, 34764);

                    switch (dataStruct.type)
                    {

                        case (uint)WSManNativeApi.WSManDataType.WSMAN_DATA_TYPE_TEXT:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 33415, 34764);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 33567, 33872) || true) && (dataStruct.binaryOrTextData.bufferLength > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 33567, 33872);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 33673, 33790);

                                string
                                tempText = f_1639_33691_33789(dataStruct.binaryOrTextData.data, dataStruct.binaryOrTextData.bufferLength)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 33820, 33845);

                                newData._text = tempText;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 33567, 33872);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1639, 33900, 33906);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 33415, 34764);

                        case (uint)WSManNativeApi.WSManDataType.WSMAN_DATA_TYPE_BINARY:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 33415, 34764);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 34017, 34621) || true) && (dataStruct.binaryOrTextData.bufferLength > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 34017, 34621);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 34202, 34272);

                                byte[]
                                dataRecvd = new byte[dataStruct.binaryOrTextData.bufferLength]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 34302, 34538);

                                f_1639_34302_34537(dataStruct.binaryOrTextData.data, dataRecvd, 0, dataStruct.binaryOrTextData.bufferLength);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 34568, 34594);

                                newData._data = dataRecvd;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 34017, 34621);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1639, 34649, 34655);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 33415, 34764);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 33415, 34764);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 34711, 34745);

                            throw f_1639_34717_34744();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 33415, 34764);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 34784, 34799);

                    return newData;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 33104, 34814);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                    f_1639_33236_33259()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 33236, 33259);
                        return return_v;
                    }


                    string
                    f_1639_33691_33789(System.IntPtr
                    ptr, int
                    len)
                    {
                        var return_v = Marshal.PtrToStringUni(ptr, len);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 33691, 33789);
                        return return_v;
                    }


                    int
                    f_1639_34302_34537(System.IntPtr
                    source, byte[]
                    destination, int
                    startIndex, int
                    length)
                    {
                        Marshal.Copy(source, destination, startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 34302, 34537);
                        return 0;
                    }


                    System.NotSupportedException
                    f_1639_34717_34744()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 34717, 34744);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 33104, 34814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 33104, 34814);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static WSManData_UnToMan UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 35051, 35506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 35149, 35181);

                    WSManData_UnToMan
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 35201, 35457) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 35201, 35457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 35275, 35363);

                        WSManDataStruct
                        resultInternal = f_1639_35308_35362(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 35385, 35438);

                        result = f_1639_35394_35437(resultInternal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 35201, 35457);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 35477, 35491);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 35051, 35506);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                    f_1639_35308_35362(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManDataStruct>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 35308, 35362);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                    f_1639_35394_35437(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                    dataStruct)
                    {
                        var return_v = WSManData_UnToMan.UnMarshal(dataStruct);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 35394, 35437);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 35051, 35506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 35051, 35506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public WSManData_UnToMan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 31531, 35517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 31696, 31701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 31977, 31990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32188, 32193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 32539, 32544);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 31531, 35517);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 31531, 35517);
            }


            static WSManData_UnToMan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 31531, 35517);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 31531, 35517);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 31531, 35517);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 31531, 35517);
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WSManDataDWord
        {

            private WSManDataType _type;

            private WSManDWordDataInternal _dwordData;

            internal WSManDataDWord(int data)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 35999, 36227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 36065, 36107);

                    _dwordData = f_1639_36078_36106();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 36125, 36150);

                    _dwordData.number = data;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 36168, 36212);

                    _type = WSManDataType.WSMAN_DATA_TYPE_DWORD;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 35999, 36227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 35999, 36227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 35999, 36227);
                }
            }

            internal MarshalledObject Marshal()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 36476, 36612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 36544, 36597);

                    return MarshalledObject.Create<WSManDataDWord>(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 36476, 36612);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 36476, 36612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 36476, 36612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManDWordDataInternal
            {

                internal int number;

                internal IntPtr reserved;
                static WSManDWordDataInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 36898, 37097);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 36898, 37097);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 36898, 37097);
                }
            }
            static WSManDataDWord()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 35642, 37108);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 35642, 37108);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 35642, 37108);
            }

            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord.WSManDWordDataInternal
            f_1639_36078_36106()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord.WSManDWordDataInternal();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 36078, 36106);
                return return_v;
            }

        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct WSManStreamIDSetStruct
        {

            internal int streamIDsCount;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr streamIDs;
            static WSManStreamIDSetStruct()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 37577, 37901);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 37577, 37901);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 37577, 37901);
            }
        }

        internal struct WSManStreamIDSet_ManToUn
        {

            private WSManStreamIDSetStruct _streamSetInfo;

            private MarshalledObject _data;

            internal WSManStreamIDSet_ManToUn(string[] streamIds)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 38220, 39080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38306, 38374);

                    f_1639_38306_38373(streamIds != null, "stream ids cannot be null or empty");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38394, 38438);

                    int
                    sizeOfIntPtr = f_1639_38413_38437()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38456, 38502);

                    _streamSetInfo = f_1639_38473_38501();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38520, 38569);

                    _streamSetInfo.streamIDsCount = f_1639_38552_38568(streamIds);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38587, 38668);

                    _streamSetInfo.streamIDs = f_1639_38614_38667(sizeOfIntPtr * f_1639_38650_38666(streamIds));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38695, 38704);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38686, 38973) || true) && (index < f_1639_38714_38730(streamIds))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38732, 38739)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 38686, 38973))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 38686, 38973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38781, 38849);

                            IntPtr
                            streamAddress = f_1639_38804_38848(streamIds[index])
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38871, 38954);

                            f_1639_38871_38953(_streamSetInfo.streamIDs, index * sizeOfIntPtr, streamAddress);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 288);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 288);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 38993, 39065);

                    _data = MarshalledObject.Create<WSManStreamIDSetStruct>(_streamSetInfo);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 38220, 39080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 38220, 39080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 38220, 39080);
                }
            }

            internal void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 39184, 40113);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39240, 40062) || true) && (IntPtr.Zero != _streamSetInfo.streamIDs)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 39240, 40062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39325, 39369);

                        int
                        sizeOfIntPtr = f_1639_39344_39368()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39400, 39409);
                            for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39391, 39912) || true) && (index < _streamSetInfo.streamIDsCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39450, 39457)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 39391, 39912))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 39391, 39912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39507, 39542);

                                IntPtr
                                streamAddress = IntPtr.Zero
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39568, 39651);

                                streamAddress = f_1639_39584_39650(_streamSetInfo.streamIDs, index * sizeOfIntPtr);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39679, 39889) || true) && (IntPtr.Zero != streamAddress)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 39679, 39889);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39769, 39804);

                                    f_1639_39769_39803(streamAddress);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39834, 39862);

                                    streamAddress = IntPtr.Zero;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 39679, 39889);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 522);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 522);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 39936, 39982);

                        f_1639_39936_39981(_streamSetInfo.streamIDs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 40004, 40043);

                        _streamSetInfo.streamIDs = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 39240, 40062);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 40082, 40098);

                    _data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 39184, 40113);

                    int
                    f_1639_39344_39368()
                    {
                        var return_v = Marshal.SizeOf<IntPtr>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 39344, 39368);
                        return return_v;
                    }


                    System.IntPtr
                    f_1639_39584_39650(System.IntPtr
                    ptr, int
                    ofs)
                    {
                        var return_v = Marshal.ReadIntPtr(ptr, ofs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 39584, 39650);
                        return return_v;
                    }


                    int
                    f_1639_39769_39803(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 39769, 39803);
                        return 0;
                    }


                    int
                    f_1639_39936_39981(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 39936, 39981);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 39184, 40113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 39184, 40113);
                }
            }

            /// <summary>
            /// Implicit cast to IntPtr.
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(WSManStreamIDSet_ManToUn obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 40307, 40448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 40408, 40433);

                    return obj._data.DataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 40307, 40448);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 40307, 40448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 40307, 40448);
                }
            }
            static WSManStreamIDSet_ManToUn()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 37913, 40459);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 37913, 40459);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 37913, 40459);
            }

            static int
            f_1639_38306_38373(bool
            condition, string
            message)
            {
                Dbg.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 38306, 38373);
                return 0;
            }


            static int
            f_1639_38413_38437()
            {
                var return_v = Marshal.SizeOf<IntPtr>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 38413, 38437);
                return return_v;
            }


            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSetStruct
            f_1639_38473_38501()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSetStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 38473, 38501);
                return return_v;
            }


            static int
            f_1639_38552_38568(string[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 38552, 38568);
                return return_v;
            }


            static int
            f_1639_38650_38666(string[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 38650, 38666);
                return return_v;
            }


            static System.IntPtr
            f_1639_38614_38667(int
            cb)
            {
                var return_v = Marshal.AllocHGlobal(cb);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 38614, 38667);
                return return_v;
            }


            static int
            f_1639_38714_38730(string[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 38714, 38730);
                return return_v;
            }


            static System.IntPtr
            f_1639_38804_38848(string
            s)
            {
                var return_v = Marshal.StringToHGlobalUni(s);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 38804, 38848);
                return return_v;
            }


            static int
            f_1639_38871_38953(System.IntPtr
            ptr, int
            ofs, System.IntPtr
            val)
            {
                Marshal.WriteIntPtr(ptr, ofs, val);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 38871, 38953);
                return 0;
            }

        }
        internal class WSManStreamIDSet_UnToMan
        {
            internal string[] streamIDs;

            internal int streamIDsCount;

            internal static WSManStreamIDSet_UnToMan UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 40842, 42813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 40947, 40986);

                    WSManStreamIDSet_UnToMan
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41006, 42764) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 41006, 42764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41080, 41182);

                        WSManStreamIDSetStruct
                        resultInternal = f_1639_41120_41181(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41206, 41246);

                        result = f_1639_41215_41245();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41268, 41293);

                        string[]
                        idsArray = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41315, 42617) || true) && (resultInternal.streamIDsCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 41315, 42617);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41402, 41455);

                            idsArray = new string[resultInternal.streamIDsCount];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41481, 41539);

                            IntPtr[]
                            ptrs = new IntPtr[resultInternal.streamIDsCount]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41565, 41644);

                            f_1639_41565_41643(resultInternal.streamIDs, ptrs, 0, resultInternal.streamIDsCount);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41719, 41724);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41710, 41939) || true) && (i < resultInternal.streamIDsCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41761, 41764)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 41710, 41939))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 41710, 41939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 41822, 41868);

                                    idsArray[i] = f_1639_41836_41867(ptrs[i]);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 230);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 230);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 41315, 42617);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 42641, 42669);

                        result.streamIDs = idsArray;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 42691, 42745);

                        result.streamIDsCount = resultInternal.streamIDsCount;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 41006, 42764);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 42784, 42798);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 40842, 42813);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSetStruct
                    f_1639_41120_41181(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManStreamIDSetStruct>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 41120, 41181);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan
                    f_1639_41215_41245()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 41215, 41245);
                        return return_v;
                    }


                    int
                    f_1639_41565_41643(System.IntPtr
                    source, System.IntPtr[]
                    destination, int
                    startIndex, int
                    length)
                    {
                        Marshal.Copy(source, destination, startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 41565, 41643);
                        return 0;
                    }


                    string?
                    f_1639_41836_41867(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStringUni(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 41836, 41867);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 40842, 42813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 40842, 42813);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public WSManStreamIDSet_UnToMan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 40471, 42824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 40553, 40562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 40590, 40604);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 40471, 42824);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 40471, 42824);
            }


            static WSManStreamIDSet_UnToMan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 40471, 42824);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 40471, 42824);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 40471, 42824);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 40471, 42824);
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct WSManOption
        {

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string name;

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string value;

            internal bool mustComply;
            static WSManOption()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 43059, 43678);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 43059, 43678);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 43059, 43678);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct WSManOptionSetStruct
        {

            internal int optionsCount;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr options;

            internal bool optionsMustUnderstand;
            static WSManOptionSetStruct()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 43874, 44358);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 43874, 44358);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 43874, 44358);
            }
        }

        internal struct WSManOptionSet : IDisposable
        {

            private WSManOptionSetStruct _optionSet;

            private MarshalledObject _data;

            internal WSManOptionSet(WSManOption[] options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 44896, 46123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 44975, 45029);

                    f_1639_44975_45028(options != null, "options cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45049, 45098);

                    int
                    sizeOfOption = f_1639_45068_45097()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45116, 45156);

                    _optionSet = f_1639_45129_45155();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45174, 45215);

                    _optionSet.optionsCount = f_1639_45200_45214(options);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45233, 45273);

                    _optionSet.optionsMustUnderstand = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45291, 45364);

                    _optionSet.options = f_1639_45312_45363(sizeOfOption * f_1639_45348_45362(options));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45393, 45402);

                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45384, 45853) || true) && (index < f_1639_45412_45426(options))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45428, 45435)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 45384, 45853))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 45384, 45853);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45723, 45834);

                            f_1639_45723_45833(options[index], (_optionSet.options.ToInt64() + (sizeOfOption * index)), false);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 470);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 470);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45873, 45939);

                    _data = MarshalledObject.Create<WSManOptionSetStruct>(_optionSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 45995, 46017);

                    this.optionsCount = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 46035, 46055);

                    this.options = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 46073, 46108);

                    this.optionsMustUnderstand = false;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 44896, 46123);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 44896, 46123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 44896, 46123);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 46194, 46529);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 46248, 46441) || true) && (IntPtr.Zero != _optionSet.options)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 46248, 46441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 46327, 46367);

                        f_1639_46327_46366(_optionSet.options);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 46389, 46422);

                        _optionSet.options = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 46248, 46441);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 46498, 46514);

                    _data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 46194, 46529);

                    int
                    f_1639_46327_46366(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 46327, 46366);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 46194, 46529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 46194, 46529);
                }
            }

            /// <summary>
            /// Implicit IntPtr cast.
            /// </summary>
            /// <param name="optionSet"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(WSManOptionSet optionSet)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 46726, 46869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 46823, 46854);

                    return optionSet._data.DataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 46726, 46869);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 46726, 46869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 46726, 46869);
                }
            }
            internal int optionsCount;

            internal WSManOption[] options;

            internal bool optionsMustUnderstand;

            internal static WSManOptionSet UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 47313, 47779);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 47408, 47764) || true) && (IntPtr.Zero == unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 47408, 47764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 47482, 47510);

                        return f_1639_47489_47509();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 47408, 47764);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 47408, 47764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 47592, 47690);

                        WSManOptionSetStruct
                        resultInternal = f_1639_47630_47689(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 47712, 47745);

                        return UnMarshal(resultInternal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 47408, 47764);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 47313, 47779);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet
                    f_1639_47489_47509()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 47489, 47509);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSetStruct
                    f_1639_47630_47689(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManOptionSetStruct>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 47630, 47689);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 47313, 47779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 47313, 47779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static WSManOptionSet UnMarshal(WSManOptionSetStruct resultInternal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 48019, 49077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48129, 48162);

                    WSManOption[]
                    tempOptions = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48180, 48762) || true) && (resultInternal.optionsCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 48180, 48762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48257, 48316);

                        tempOptions = new WSManOption[resultInternal.optionsCount];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48340, 48388);

                        int
                        sizeInBytes = f_1639_48358_48387()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48410, 48456);

                        IntPtr
                        perElementPtr = resultInternal.options
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48489, 48494);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48480, 48743) || true) && (i < resultInternal.optionsCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48529, 48532)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 48480, 48743))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 48480, 48743);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48582, 48638);

                                IntPtr
                                p = IntPtr.Add(perElementPtr, (i * sizeInBytes))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48664, 48720);

                                tempOptions[i] = f_1639_48681_48719(p);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 264);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 264);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 48180, 48762);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48782, 48827);

                    WSManOptionSet
                    result = f_1639_48806_48826()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48845, 48895);

                    result.optionsCount = resultInternal.optionsCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48913, 48942);

                    result.options = tempOptions;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 48960, 49028);

                    result.optionsMustUnderstand = resultInternal.optionsMustUnderstand;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 49048, 49062);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 48019, 49077);

                    int
                    f_1639_48358_48387()
                    {
                        var return_v = Marshal.SizeOf<WSManOption>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 48358, 48387);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
                    f_1639_48681_48719(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManOption>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 48681, 48719);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet
                    f_1639_48806_48826()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 48806, 48826);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 48019, 49077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 48019, 49077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static WSManOptionSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 44520, 49114);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 44520, 49114);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 44520, 49114);
            }

            static int
            f_1639_44975_45028(bool
            condition, string
            message)
            {
                Dbg.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 44975, 45028);
                return 0;
            }


            static int
            f_1639_45068_45097()
            {
                var return_v = Marshal.SizeOf<WSManOption>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 45068, 45097);
                return return_v;
            }


            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSetStruct
            f_1639_45129_45155()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSetStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 45129, 45155);
                return return_v;
            }


            static int
            f_1639_45200_45214(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 45200, 45214);
                return return_v;
            }


            static int
            f_1639_45348_45362(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 45348, 45362);
                return return_v;
            }


            static System.IntPtr
            f_1639_45312_45363(int
            cb)
            {
                var return_v = Marshal.AllocHGlobal(cb);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 45312, 45363);
                return return_v;
            }


            static int
            f_1639_45412_45426(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 45412, 45426);
                return return_v;
            }


            static int
            f_1639_45723_45833(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
            structure, long
            ptr, bool
            fDeleteOld)
            {
                Marshal.StructureToPtr(structure, (System.IntPtr)ptr, fDeleteOld);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 45723, 45833);
                return 0;
            }


        }

        internal struct WSManCommandArgSet : IDisposable
        {

            [StructLayout(LayoutKind.Sequential)]
            internal struct WSManCommandArgSetInternal
            {

                internal int argsCount;

                [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
                internal IntPtr args;
                static WSManCommandArgSetInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 49246, 49561);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 49246, 49561);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 49246, 49561);
                }
            }

            private WSManCommandArgSetInternal _internalData;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            private MarshalledObject _data;

            internal WSManCommandArgSet(byte[] firstArgument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 49839, 50887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 49921, 49970);

                    _internalData = f_1639_49937_49969();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 49988, 50016);

                    _internalData.argsCount = 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 50034, 50102);

                    _internalData.args = f_1639_50055_50101(f_1639_50076_50100());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 50411, 50480);

                    string
                    base64EncodedArgument = f_1639_50442_50479(firstArgument)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 50498, 50573);

                    IntPtr
                    firstArgAddress = f_1639_50523_50572(base64EncodedArgument)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 50591, 50648);

                    f_1639_50591_50647(_internalData.args, firstArgAddress);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 50668, 50762);

                    _data = MarshalledObject.Create<WSManCommandArgSet.WSManCommandArgSetInternal>(_internalData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 50818, 50835);

                    this.args = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 50853, 50872);

                    this.argsCount = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 49839, 50887);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 49839, 50887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 49839, 50887);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 50991, 51370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 51045, 51109);

                    IntPtr
                    firstArgAddress = f_1639_51070_51108(_internalData.args)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 51127, 51259) || true) && (IntPtr.Zero != firstArgAddress)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 51127, 51259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 51203, 51240);

                        f_1639_51203_51239(firstArgAddress);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 51127, 51259);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 51279, 51319);

                    f_1639_51279_51318(_internalData.args);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 51339, 51355);

                    _data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 50991, 51370);

                    System.IntPtr
                    f_1639_51070_51108(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.ReadIntPtr(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 51070, 51108);
                        return return_v;
                    }


                    int
                    f_1639_51203_51239(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 51203, 51239);
                        return 0;
                    }


                    int
                    f_1639_51279_51318(System.IntPtr
                    hglobal)
                    {
                        Marshal.FreeHGlobal(hglobal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 51279, 51318);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 50991, 51370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 50991, 51370);
                }
            }

            /// <summary>
            /// Implicit cast to IntPtr.
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(WSManCommandArgSet obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 51564, 51699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 51659, 51684);

                    return obj._data.DataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 51564, 51699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 51564, 51699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 51564, 51699);
                }
            }
            internal string[] args;

            internal int argsCount;

            internal static WSManCommandArgSet UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 52311, 53536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52410, 52463);

                    WSManCommandArgSet
                    result = f_1639_52438_52462()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52483, 53487) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 52483, 53487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52557, 52667);

                        WSManCommandArgSetInternal
                        resultInternal = f_1639_52601_52666(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52691, 52716);

                        string[]
                        tempArgs = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52738, 53355) || true) && (resultInternal.argsCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 52738, 53355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52820, 52868);

                            tempArgs = new string[resultInternal.argsCount];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52894, 52947);

                            IntPtr[]
                            ptrs = new IntPtr[resultInternal.argsCount]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 52973, 53042);

                            f_1639_52973_53041(resultInternal.args, ptrs, 0, resultInternal.argsCount);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 53117, 53122);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 53108, 53332) || true) && (i < resultInternal.argsCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 53154, 53157)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 53108, 53332))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 53108, 53332);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 53215, 53261);

                                    tempArgs[i] = f_1639_53229_53260(ptrs[i]);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 225);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 225);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 52738, 53355);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 53379, 53423);

                        result.argsCount = resultInternal.argsCount;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 53445, 53468);

                        result.args = tempArgs;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 52483, 53487);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 53507, 53521);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 52311, 53536);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet
                    f_1639_52438_52462()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 52438, 52462);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet.WSManCommandArgSetInternal
                    f_1639_52601_52666(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManCommandArgSetInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 52601, 52666);
                        return return_v;
                    }


                    int
                    f_1639_52973_53041(System.IntPtr
                    source, System.IntPtr[]
                    destination, int
                    startIndex, int
                    length)
                    {
                        Marshal.Copy(source, destination, startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 52973, 53041);
                        return 0;
                    }


                    string?
                    f_1639_53229_53260(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStringUni(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 53229, 53260);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 52311, 53536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 52311, 53536);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static WSManCommandArgSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 49173, 53573);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 49173, 53573);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 49173, 53573);
            }

            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet.WSManCommandArgSetInternal
            f_1639_49937_49969()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet.WSManCommandArgSetInternal();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 49937, 49969);
                return return_v;
            }


            static int
            f_1639_50076_50100()
            {
                var return_v = Marshal.SizeOf<IntPtr>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 50076, 50100);
                return return_v;
            }


            static System.IntPtr
            f_1639_50055_50101(int
            cb)
            {
                var return_v = Marshal.AllocHGlobal(cb);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 50055, 50101);
                return return_v;
            }


            static string
            f_1639_50442_50479(byte[]
            inArray)
            {
                var return_v = Convert.ToBase64String(inArray);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 50442, 50479);
                return return_v;
            }


            static System.IntPtr
            f_1639_50523_50572(string
            s)
            {
                var return_v = Marshal.StringToHGlobalUni(s);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 50523, 50572);
                return return_v;
            }


            static int
            f_1639_50591_50647(System.IntPtr
            ptr, System.IntPtr
            val)
            {
                Marshal.WriteIntPtr(ptr, val);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 50591, 50647);
                return 0;
            }


        }

        internal struct WSManShellDisconnectInfo : IDisposable
        {

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            private struct WSManShellDisconnectInfoInternal
            {

                internal uint idleTimeoutMs;
                static WSManShellDisconnectInfoInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 53664, 54057);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 53664, 54057);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 53664, 54057);
                }
            }

            private WSManShellDisconnectInfoInternal _internalInfo;

            internal MarshalledObject data;

            internal WSManShellDisconnectInfo(uint serverIdleTimeOut)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 54238, 54562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 54328, 54383);

                    _internalInfo = f_1639_54344_54382();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 54401, 54449);

                    _internalInfo.idleTimeoutMs = serverIdleTimeOut;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 54467, 54547);

                    data = MarshalledObject.Create<WSManShellDisconnectInfoInternal>(_internalInfo);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 54238, 54562);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 54238, 54562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 54238, 54562);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 54671, 54755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 54725, 54740);

                    data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 54671, 54755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 54671, 54755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 54671, 54755);
                }
            }

            /// <summary>
            /// Implicit IntPtr.
            /// </summary>
            /// <param name="disconnectInfo"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(WSManShellDisconnectInfo disconnectInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 54952, 55114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 55064, 55099);

                    return disconnectInfo.data.DataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 54952, 55114);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 54952, 55114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 54952, 55114);
                }
            }
            static WSManShellDisconnectInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 53585, 55151);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 53585, 55151);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 53585, 55151);
            }

            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellDisconnectInfo.WSManShellDisconnectInfoInternal
            f_1639_54344_54382()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellDisconnectInfo.WSManShellDisconnectInfoInternal();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 54344, 54382);
                return return_v;
            }


        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct WSManShellStartupInfoStruct
        {

            internal IntPtr inputStreamSet;

            internal IntPtr outputStreamSet;

            internal uint idleTimeoutMs;

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string workingDirectory;

            internal IntPtr environmentVariableSet;

            [MarshalAs(UnmanagedType.LPWStr)]
            internal string name;
            static WSManShellStartupInfoStruct()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 55163, 56498);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 55163, 56498);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 55163, 56498);
            }
        }

        internal struct WSManShellStartupInfo_ManToUn : IDisposable
        {

            private WSManShellStartupInfoStruct _internalInfo;

            internal MarshalledObject data;

            internal WSManShellStartupInfo_ManToUn(WSManStreamIDSet_ManToUn inputStreamSet, WSManStreamIDSet_ManToUn outputStreamSet, uint serverIdleTimeOut, string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 57508, 58304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 57699, 57749);

                    _internalInfo = f_1639_57715_57748();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 57767, 57813);

                    _internalInfo.inputStreamSet = inputStreamSet;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 57831, 57879);

                    _internalInfo.outputStreamSet = outputStreamSet;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 57897, 57945);

                    _internalInfo.idleTimeoutMs = serverIdleTimeOut;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 58043, 58081);

                    _internalInfo.workingDirectory = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 58099, 58150);

                    _internalInfo.environmentVariableSet = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 58168, 58194);

                    _internalInfo.name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 58214, 58289);

                    data = MarshalledObject.Create<WSManShellStartupInfoStruct>(_internalInfo);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 57508, 58304);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 57508, 58304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 57508, 58304);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 58413, 58497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 58467, 58482);

                    data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 58413, 58497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 58413, 58497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 58413, 58497);
                }
            }

            /// <summary>
            /// Implicit IntPtr.
            /// </summary>
            /// <param name="startupInfo"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(WSManShellStartupInfo_ManToUn startupInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 58691, 58852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 58805, 58837);

                    return startupInfo.data.DataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 58691, 58852);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 58691, 58852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 58691, 58852);
                }
            }
            static WSManShellStartupInfo_ManToUn()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 56786, 58889);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 56786, 58889);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 56786, 58889);
            }

            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfoStruct
            f_1639_57715_57748()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfoStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 57715, 57748);
                return return_v;
            }


        }
        internal class WSManShellStartupInfo_UnToMan
        {
            internal WSManStreamIDSet_UnToMan inputStreamSet;

            internal WSManStreamIDSet_UnToMan outputStreamSet;

            internal uint idleTimeoutMS;

            internal string workingDirectory;

            internal WSManEnvironmentVariableSet environmentVariableSet;

            internal string name;

            internal static WSManShellStartupInfo_UnToMan UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 59733, 60840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59843, 59887);

                    WSManShellStartupInfo_UnToMan
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59907, 60791) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 59907, 60791);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59981, 60093);

                        WSManShellStartupInfoStruct
                        resultInternal = f_1639_60026_60092(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60117, 60162);

                        result = f_1639_60126_60161();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60184, 60274);

                        result.inputStreamSet = f_1639_60208_60273(resultInternal.inputStreamSet);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60296, 60388);

                        result.outputStreamSet = f_1639_60321_60387(resultInternal.outputStreamSet);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60410, 60462);

                        result.idleTimeoutMS = resultInternal.idleTimeoutMs;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60484, 60542);

                        result.workingDirectory = resultInternal.workingDirectory;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60607, 60716);

                        result.environmentVariableSet = f_1639_60639_60715(resultInternal.environmentVariableSet);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60738, 60772);

                        result.name = resultInternal.name;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 59907, 60791);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 60811, 60825);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 59733, 60840);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfoStruct
                    f_1639_60026_60092(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManShellStartupInfoStruct>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 60026, 60092);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_UnToMan
                    f_1639_60126_60161()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_UnToMan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 60126, 60161);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan
                    f_1639_60208_60273(System.IntPtr
                    unmanagedData)
                    {
                        var return_v = WSManStreamIDSet_UnToMan.UnMarshal(unmanagedData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 60208, 60273);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan
                    f_1639_60321_60387(System.IntPtr
                    unmanagedData)
                    {
                        var return_v = WSManStreamIDSet_UnToMan.UnMarshal(unmanagedData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 60321, 60387);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManEnvironmentVariableSet
                    f_1639_60639_60715(System.IntPtr
                    unmanagedData)
                    {
                        var return_v = WSManEnvironmentVariableSet.UnMarshal(unmanagedData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 60639, 60715);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 59733, 60840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 59733, 60840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public WSManShellStartupInfo_UnToMan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 59116, 60851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59219, 59233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59282, 59297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59326, 59339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59370, 59386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59438, 59460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 59491, 59495);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 59116, 60851);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 59116, 60851);
            }


            static WSManShellStartupInfo_UnToMan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 59116, 60851);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 59116, 60851);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 59116, 60851);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 59116, 60851);
        }
        internal class WSManEnvironmentVariableSet
        {
            internal uint varsCount;

            internal WSManEnvironmentVariableInternal[] vars;

            internal static WSManEnvironmentVariableSet UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 61494, 62878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 61602, 61644);

                    WSManEnvironmentVariableSet
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 61664, 62829) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 61664, 62829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 61738, 61866);

                        WSManEnvironmentVariableSetInternal
                        resultInternal = f_1639_61791_61865(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 61890, 61933);

                        result = f_1639_61899_61932();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 61955, 62007);

                        WSManEnvironmentVariableInternal[]
                        varsArray = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62029, 62696) || true) && (resultInternal.varsCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 62029, 62696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62111, 62186);

                            varsArray = new WSManEnvironmentVariableInternal[resultInternal.varsCount];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62212, 62281);

                            int
                            sizeInBytes = f_1639_62230_62280()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62307, 62350);

                            IntPtr
                            perElementPtr = resultInternal.vars
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62387, 62392);

                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62378, 62673) || true) && (i < resultInternal.varsCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62424, 62427)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 62378, 62673))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 62378, 62673);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62485, 62541);

                                    IntPtr
                                    p = IntPtr.Add(perElementPtr, (i * sizeInBytes))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62571, 62646);

                                    varsArray[i] = f_1639_62586_62645(p);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 296);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 296);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 62029, 62696);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62720, 62744);

                        result.vars = varsArray;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62766, 62810);

                        result.varsCount = resultInternal.varsCount;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 61664, 62829);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 62849, 62863);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 61494, 62878);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManEnvironmentVariableSet.WSManEnvironmentVariableSetInternal
                    f_1639_61791_61865(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManEnvironmentVariableSetInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 61791, 61865);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManEnvironmentVariableSet
                    f_1639_61899_61932()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManEnvironmentVariableSet();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 61899, 61932);
                        return return_v;
                    }


                    int
                    f_1639_62230_62280()
                    {
                        var return_v = Marshal.SizeOf<WSManEnvironmentVariableInternal>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 62230, 62280);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManEnvironmentVariableSet.WSManEnvironmentVariableInternal
                    f_1639_62586_62645(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManEnvironmentVariableInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 62586, 62645);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 61494, 62878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 61494, 62878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            private struct WSManEnvironmentVariableSetInternal
            {

                internal uint varsCount;

                internal IntPtr vars;
                static WSManEnvironmentVariableSetInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 62894, 63186);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 62894, 63186);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 62894, 63186);
                }
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal struct WSManEnvironmentVariableInternal
            {

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string name;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string value;
                static WSManEnvironmentVariableInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 63202, 63539);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 63202, 63539);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 63202, 63539);
                }
            }

            public WSManEnvironmentVariableSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 61103, 63550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 61184, 61193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 61252, 61256);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 61103, 63550);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 61103, 63550);
            }


            static WSManEnvironmentVariableSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 61103, 63550);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 61103, 63550);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 61103, 63550);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 61103, 63550);
        }
        internal class WSManProxyInfo : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            private struct WSManProxyInfoInternal
            {

                public int proxyAccessType;

                public WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct proxyAuthCredentialsStruct;
                static WSManProxyInfoInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 63731, 64042);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 63731, 64042);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 63731, 64042);
                }
            }

            private MarshalledObject _data;

            internal WSManProxyInfo(ProxyAccessType proxyAccessType,
                            WSManUserNameAuthenticationCredentials authCredentials)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 64272, 65141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 64434, 64501);

                    WSManProxyInfoInternal
                    internalInfo = f_1639_64472_64500()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 64519, 64571);

                    internalInfo.proxyAccessType = (int)proxyAccessType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 64589, 64706);

                    internalInfo.proxyAuthCredentialsStruct = f_1639_64631_64705();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 64724, 64853);

                    internalInfo.proxyAuthCredentialsStruct.authenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_DEFAULT_AUTHENTICATION;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 64873, 65036) || true) && (authCredentials != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 64873, 65036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 64942, 65017);

                        internalInfo.proxyAuthCredentialsStruct = f_1639_64984_65016(authCredentials);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 64873, 65036);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 65056, 65126);

                    _data = MarshalledObject.Create<WSManProxyInfoInternal>(internalInfo);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 64272, 65141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 64272, 65141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 64272, 65141);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 65157, 65360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 65285, 65301);

                    _data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 65319, 65345);

                    f_1639_65319_65344(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 65157, 65360);

                    int
                    f_1639_65319_65344(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManProxyInfo
                    obj)
                    {
                        GC.SuppressFinalize((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 65319, 65344);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 65157, 65360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 65157, 65360);
                }
            }

            /// <summary>
            /// Implicit IntPtr.
            /// </summary>
            /// <param name="proxyInfo"></param>
            /// <returns></returns>
            public static implicit operator IntPtr(WSManProxyInfo proxyInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 65552, 65695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 65649, 65680);

                    return proxyInfo._data.DataPtr;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 65552, 65695);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 65552, 65695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 65552, 65695);
                }
            }
            static WSManProxyInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 63663, 65706);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 63663, 65706);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 63663, 65706);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 63663, 65706);

            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManProxyInfo.WSManProxyInfoInternal
            f_1639_64472_64500()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManProxyInfo.WSManProxyInfoInternal();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 64472, 64500);
                return return_v;
            }


            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct
            f_1639_64631_64705()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 64631, 64705);
                return return_v;
            }


            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials.WSManUserNameCredentialStruct
            f_1639_64984_65016(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials
            this_param)
            {
                var return_v = this_param.CredentialStruct;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 64984, 65016);
                return return_v;
            }

        }



        /// <summary>
        /// Flags used by all callback functions: WSMAN_COMPLETION_FUNCTION,
        /// WSMAN_SUBSCRIPTION_COMPLETION_FUNCTION and WSMAN_SHELL_COMPLETION_FUNCTION.
        /// </summary>
        internal enum WSManCallbackFlags
        {
            //
            // Flag that marks the end of any single step of multistep operation
            //
            WSMAN_FLAG_CALLBACK_END_OF_OPERATION = 0x1,

            //
            // WSMAN_SHELL_COMPLETION_FUNCTION API specific flags
            //  end of a particular stream; it is used for optimization purposes if the shell
            //  knows that no more output will occur for this stream; in some conditions this
            //  cannot be determined.
            //
            WSMAN_FLAG_CALLBACK_END_OF_STREAM = 0x8,

            //
            // Flag that if present on CreateShell callback indicates that it supports disconnect
            //
            WSMAN_FLAG_CALLBACK_SHELL_SUPPORTS_DISCONNECT = 0x20,

            //
            // Marks the end of an auto-disconnect operation.
            //
            WSMAN_FLAG_CALLBACK_SHELL_AUTODISCONNECTED = 0x40,

            //
            // Network failure notification.
            //
            WSMAN_FLAG_CALLBACK_NETWORK_FAILURE_DETECTED = 0x100,

            //
            // Network connection retry notification.
            //
            WSMAN_FLAG_CALLBACK_RETRYING_AFTER_NETWORK_FAILURE = 0x200,

            //
            // Network retry succeeded, connection re-established notification.
            //
            WSMAN_FLAG_CALLBACK_RECONNECTED_AFTER_NETWORK_FAILURE = 0x400,

            //
            // Retries failed, now auto-disconnecting.
            //
            WSMAN_FLAG_CALLBACK_SHELL_AUTODISCONNECTING = 0x800,

            //
            // Internal error during retries.  Cannot auto-disconnect.  Shell failure.
            //
            WSMAN_FLAG_CALLBACK_RETRY_ABORTED_DUE_TO_INTERNAL_ERROR = 0x1000,

            //
            // Flag that indicates for a receive operation that a delay stream request has been processed
            //
            WSMAN_FLAG_RECEIVE_DELAY_STREAM_REQUEST_PROCESSED = 0X2000
        }

        /// <summary>
        /// Completion function used by all Shell functions. Returns error->code != 0 upon error;
        /// use error->errorDetail structure for extended error informations; the callback is
        /// called for each shell operation; after a WSManReceiveShellOutput operation is initiated,
        /// the callback is called for each output stream element or if error; the underlying
        /// implementation handles the polling of stream data from the command or shell.
        /// If WSMAN_COMMAND_STATE_DONE state is received, no more streams will be received from the command,
        /// so the command can be closed using WSManCloseShellOperationEx(command).
        /// If error->code != 0, the result is guaranteed to be NULL. The error and result objects are
        /// allocated and owned by the WSMan client stack; they are valid during the callback only; the user
        /// has to synchronously copy the data in the callback. This callback function will use the current
        /// access token, whether it is a process or impersonation token.
        /// </summary>
        /// <param name="operationContext">
        /// user supplied operation context.
        /// </param>
        /// <param name="flags">
        /// one or more flags from WSManCallbackFlags
        /// </param>
        /// <param name="error">
        /// error allocated and owned by the winrm stack; valid in the callback only;
        /// </param>
        /// <param name="shellOperationHandle">
        /// shell handle associated with the user context
        /// </param>
        /// <param name="commandOperationHandle">
        /// command handle associated with the user context
        /// </param>
        /// <param name="operationHandle">
        /// operation handle associated with the user context
        /// </param>
        /// <param name="data">
        /// output data from command/shell; allocated internally and owned by the winrm stack.
        /// valid only within this function.
        /// See WSManReceiveDataResult.
        /// </param>
        internal delegate void WSManShellCompletionFunction(
            IntPtr operationContext,
            int flags,
            IntPtr error,
            IntPtr shellOperationHandle,
            IntPtr commandOperationHandle,
            IntPtr operationHandle,
            IntPtr data
            );

        internal struct WSManShellAsyncCallback
        {

            private GCHandle _gcHandle;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            private IntPtr _asyncCallback;

            internal WSManShellAsyncCallback(WSManShellCompletionFunction callback)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 70978, 71622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 71487, 71524);

                    _gcHandle = GCHandle.Alloc(callback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 71542, 71607);

                    _asyncCallback = f_1639_71559_71606(callback);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 70978, 71622);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 70978, 71622);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 70978, 71622);
                }
            }

            public static implicit operator IntPtr(WSManShellAsyncCallback callback)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 71638, 71789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 71743, 71774);

                    return callback._asyncCallback;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 71638, 71789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 71638, 71789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 71638, 71789);
                }
            }
            static WSManShellAsyncCallback()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 70629, 71800);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 70629, 71800);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 70629, 71800);
            }

            static System.IntPtr
            f_1639_71559_71606(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
            d)
            {
                var return_v = Marshal.GetFunctionPointerForDelegate(d);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 71559, 71606);
                return return_v;
            }

        }
        internal class WSManShellAsync
        {
            [StructLayout(LayoutKind.Sequential)]
            internal struct WSManShellAsyncInternal
            {

                internal IntPtr operationContext;

                internal IntPtr asyncCallback;
                static WSManShellAsyncInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 71987, 72206);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 71987, 72206);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 71987, 72206);
                }
            }

            private MarshalledObject _data;

            private WSManShellAsyncInternal _internalData;

            internal WSManShellAsync(IntPtr context, WSManShellAsyncCallback callback)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 72329, 72705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 72436, 72482);

                    _internalData = f_1639_72452_72481();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 72500, 72541);

                    _internalData.operationContext = context;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 72561, 72600);

                    _internalData.asyncCallback = callback;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 72618, 72690);

                    _data = MarshalledObject.Create<WSManShellAsyncInternal>(_internalData);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 72329, 72705);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 72329, 72705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 72329, 72705);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 72721, 72806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 72775, 72791);

                    _data.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 72721, 72806);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 72721, 72806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 72721, 72806);
                }
            }

            public static implicit operator IntPtr(WSManShellAsync async)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 72822, 72950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 72916, 72935);

                    return async._data;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 72822, 72950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 72822, 72950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 72822, 72950);
                }
            }
            static WSManShellAsync()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 71932, 72961);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 71932, 72961);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 71932, 72961);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 71932, 72961);

            System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync.WSManShellAsyncInternal
            f_1639_72452_72481()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync.WSManShellAsyncInternal();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 72452, 72481);
                return return_v;
            }

        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct WSManError
        {

            internal int errorCode;

            internal string errorDetail;

            internal string language;

            internal string machineName;

            internal static WSManError UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 74124, 74287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 74215, 74272);

                    return f_1639_74222_74271(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 74124, 74287);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                    f_1639_74222_74271(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManError>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 74222, 74271);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 74124, 74287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 74124, 74287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static WSManError()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 73099, 74298);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 73099, 74298);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 73099, 74298);
            }
        }
        internal class WSManCreateShellDataResult
        {
            [StructLayout(LayoutKind.Sequential)]
            private struct WSManCreateShellDataResultInternal
            {

                internal WSManDataStruct data;
                static WSManCreateShellDataResultInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 74376, 74554);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 74376, 74554);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 74376, 74554);
                }
            }

            internal string data;

            internal static WSManCreateShellDataResult UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 74607, 75426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 74714, 74783);

                    WSManCreateShellDataResult
                    result = f_1639_74750_74782()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 74803, 75377) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 74803, 75377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 74877, 75003);

                        WSManCreateShellDataResultInternal
                        resultInternal = f_1639_74929_75002(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 75027, 75053);

                        string
                        connectData = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 75075, 75308) || true) && (resultInternal.data.textData.textLength > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 75075, 75308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 75172, 75285);

                            connectData = f_1639_75186_75284(resultInternal.data.textData.text, resultInternal.data.textData.textLength);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 75075, 75308);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 75332, 75358);

                        result.data = connectData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 74803, 75377);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 75397, 75411);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 74607, 75426);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCreateShellDataResult
                    f_1639_74750_74782()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCreateShellDataResult();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 74750, 74782);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCreateShellDataResult.WSManCreateShellDataResultInternal
                    f_1639_74929_75002(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManCreateShellDataResultInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 74929, 75002);
                        return return_v;
                    }


                    string
                    f_1639_75186_75284(System.IntPtr
                    ptr, int
                    len)
                    {
                        var return_v = Marshal.PtrToStringUni(ptr, len);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 75186, 75284);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 74607, 75426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 74607, 75426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManDataStruct
            {

                internal uint type;

                internal WSManTextDataInternal textData;
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManTextDataInternal
            {

                internal int textLength;

                internal IntPtr text;
                static WSManTextDataInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 75782, 75980);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 75782, 75980);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 75782, 75980);
                }
            }

            public WSManCreateShellDataResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 74310, 75991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 74586, 74590);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 74310, 75991);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 74310, 75991);
            }


            static WSManCreateShellDataResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 74310, 75991);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 74310, 75991);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 74310, 75991);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 74310, 75991);
        }
        internal class WSManConnectDataResult
        {
            [StructLayout(LayoutKind.Sequential)]
            private struct WSManConnectDataResultInternal
            {

                internal WSManDataStruct data;
                static WSManConnectDataResultInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 76065, 76239);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 76065, 76239);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 76065, 76239);
                }
            }

            internal string data;

            internal static WSManConnectDataResult UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 76292, 76972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76395, 76513);

                    WSManConnectDataResultInternal
                    resultInternal = f_1639_76443_76512(unmanagedData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76533, 76559);

                    string
                    connectData = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76577, 76798) || true) && (resultInternal.data.textData.textLength > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 76577, 76798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76666, 76779);

                        connectData = f_1639_76680_76778(resultInternal.data.textData.text, resultInternal.data.textData.textLength);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 76577, 76798);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76818, 76879);

                    WSManConnectDataResult
                    result = f_1639_76850_76878()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76897, 76923);

                    result.data = connectData;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76943, 76957);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 76292, 76972);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManConnectDataResult.WSManConnectDataResultInternal
                    f_1639_76443_76512(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManConnectDataResultInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 76443, 76512);
                        return return_v;
                    }


                    string
                    f_1639_76680_76778(System.IntPtr
                    ptr, int
                    len)
                    {
                        var return_v = Marshal.PtrToStringUni(ptr, len);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 76680, 76778);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManConnectDataResult
                    f_1639_76850_76878()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManConnectDataResult();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 76850, 76878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 76292, 76972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 76292, 76972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManDataStruct
            {

                internal uint type;

                internal WSManTextDataInternal textData;
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManTextDataInternal
            {

                internal int textLength;

                internal IntPtr text;
            }

            public WSManConnectDataResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 76003, 77537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 76271, 76275);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 76003, 77537);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 76003, 77537);
            }


            static WSManConnectDataResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 76003, 77537);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 76003, 77537);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 76003, 77537);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 76003, 77537);
        }
        internal class WSManReceiveDataResult
        {
            internal byte[] data;

            internal string stream;

            internal static WSManReceiveDataResult UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 78535, 79666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 78638, 78770);

                    WSManReceiveDataResultInternal
                    result1 =
                    f_1639_78700_78769(unmanagedData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 78857, 78881);

                    byte[]
                    dataRecvd = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 78899, 79257) || true) && (result1.data.binaryData.bufferLength > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 78899, 79257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 78985, 79044);

                        dataRecvd = new byte[result1.data.binaryData.bufferLength];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 79066, 79238);

                        f_1639_79066_79237(result1.data.binaryData.buffer, dataRecvd, 0, result1.data.binaryData.bufferLength);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 78899, 79257);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 79288, 79435);

                    f_1639_79288_79434(result1.data.type == (uint)WSManDataType.WSMAN_DATA_TYPE_BINARY, "ReceiveDataResult can receive only binary data");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 79463, 79524);

                    WSManReceiveDataResult
                    result = f_1639_79495_79523()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 79542, 79566);

                    result.data = dataRecvd;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 79584, 79617);

                    result.stream = result1.streamId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 79637, 79651);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 78535, 79666);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManReceiveDataResult.WSManReceiveDataResultInternal
                    f_1639_78700_78769(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManReceiveDataResultInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 78700, 78769);
                        return return_v;
                    }


                    int
                    f_1639_79066_79237(System.IntPtr
                    source, byte[]
                    destination, int
                    startIndex, int
                    length)
                    {
                        Marshal.Copy(source, destination, startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 79066, 79237);
                        return 0;
                    }


                    int
                    f_1639_79288_79434(bool
                    condition, string
                    message)
                    {
                        Dbg.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 79288, 79434);
                        return 0;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManReceiveDataResult
                    f_1639_79495_79523()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManReceiveDataResult();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 79495, 79523);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 78535, 79666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 78535, 79666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManReceiveDataResultInternal
            {

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string streamId;

                internal WSManDataStruct data;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string commandState;

                internal int exitCode;
                static WSManReceiveDataResultInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 79682, 80088);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 79682, 80088);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 79682, 80088);
                }
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManDataStruct
            {

                internal uint type;

                internal WSManBinaryDataInternal binaryData;
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct WSManBinaryDataInternal
            {

                internal int bufferLength;

                internal IntPtr buffer;
                static WSManBinaryDataInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 80448, 80652);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 80448, 80652);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 80448, 80652);
                }
            }

            public WSManReceiveDataResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 77676, 80663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 77843, 77847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 77978, 77984);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 77676, 80663);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 77676, 80663);
            }


            static WSManReceiveDataResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 77676, 80663);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 77676, 80663);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 77676, 80663);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 77676, 80663);
        }
        internal class WSManPluginRequest
        {
            internal WSManSenderDetails senderDetails;

            internal string locale;

            internal string resourceUri;

            internal WSManOperationInfo operationInfo;

            private WSManPluginRequestInternal _internalDetails;

            internal bool shutdownNotification
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 81870, 81923);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 81876, 81921);

                        return _internalDetails.shutdownNotification;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 81870, 81923);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 81803, 81938);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 81803, 81938);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal IntPtr shutdownNotificationHandle
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 82217, 82276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 82223, 82274);

                        return _internalDetails.shutdownNotificationHandle;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 82217, 82276);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 82142, 82291);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 82142, 82291);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal IntPtr unmanagedHandle;

            internal static WSManPluginRequest UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 82710, 83768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 82943, 82976);

                    WSManPluginRequest
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 82996, 83719) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 82996, 83719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83070, 83180);

                        WSManPluginRequestInternal
                        resultInternal = f_1639_83114_83179(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83204, 83238);

                        result = f_1639_83213_83237();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83260, 83342);

                        result.senderDetails = f_1639_83283_83341(resultInternal.senderDetails);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83364, 83402);

                        result.locale = resultInternal.locale;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83424, 83472);

                        result.resourceUri = resultInternal.resourceUri;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83494, 83576);

                        result.operationInfo = f_1639_83517_83575(resultInternal.operationInfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83598, 83639);

                        result._internalDetails = resultInternal;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83661, 83700);

                        result.unmanagedHandle = unmanagedData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 82996, 83719);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 83739, 83753);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 82710, 83768);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest.WSManPluginRequestInternal
                    f_1639_83114_83179(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManPluginRequestInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 83114, 83179);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                    f_1639_83213_83237()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 83213, 83237);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSenderDetails
                    f_1639_83283_83341(System.IntPtr
                    unmanagedData)
                    {
                        var return_v = WSManSenderDetails.UnMarshal(unmanagedData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 83283, 83341);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOperationInfo
                    f_1639_83517_83575(System.IntPtr
                    unmanagedData)
                    {
                        var return_v = WSManOperationInfo.UnMarshal(unmanagedData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 83517, 83575);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 82710, 83768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 82710, 83768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            private struct WSManPluginRequestInternal
            {

                internal IntPtr senderDetails;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string locale;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string resourceUri;

                internal IntPtr operationInfo;

                internal bool shutdownNotification;

                internal IntPtr shutdownNotificationHandle;
                static WSManPluginRequestInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 83896, 84652);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 83896, 84652);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 83896, 84652);
                }
            }

            public WSManPluginRequest()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 80880, 84663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 81079, 81092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 81123, 81129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 81160, 81171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 81327, 81340);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 80880, 84663);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 80880, 84663);
            }


            static WSManPluginRequest()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 80880, 84663);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 80880, 84663);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 80880, 84663);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 80880, 84663);
        }
        internal class WSManSenderDetails
        {
            internal string senderName;

            internal string authenticationMechanism;

            internal WSManCertificateDetails certificateDetails;

            internal IntPtr clientToken;

            internal string httpUrl;

            internal static WSManSenderDetails UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 85240, 86153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85339, 85372);

                    WSManSenderDetails
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85392, 86104) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 85392, 86104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85466, 85576);

                        WSManSenderDetailsInternal
                        resultInternal = f_1639_85510_85575(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85600, 85634);

                        result = f_1639_85609_85633();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85656, 85702);

                        result.senderName = resultInternal.senderName;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85724, 85796);

                        result.authenticationMechanism = resultInternal.authenticationMechanism;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85818, 85915);

                        result.certificateDetails = f_1639_85846_85914(resultInternal.certificateDetails);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 85937, 85985);

                        result.clientToken = resultInternal.clientToken;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 86045, 86085);

                        result.httpUrl = resultInternal.httpUrl;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 85392, 86104);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 86124, 86138);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 85240, 86153);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSenderDetails.WSManSenderDetailsInternal
                    f_1639_85510_85575(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManSenderDetailsInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 85510, 85575);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSenderDetails
                    f_1639_85609_85633()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSenderDetails();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 85609, 85633);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateDetails
                    f_1639_85846_85914(System.IntPtr
                    unmanagedData)
                    {
                        var return_v = WSManCertificateDetails.UnMarshal(unmanagedData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 85846, 85914);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 85240, 86153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 85240, 86153);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            private struct WSManSenderDetailsInternal
            {

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string senderName;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string authenticationMechanism;

                internal IntPtr certificateDetails;

                internal IntPtr clientToken;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string httpUrl;
                static WSManSenderDetailsInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 86289, 86944);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 86289, 86944);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 86289, 86944);
                }
            }

            public WSManSenderDetails()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 84675, 86955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 84749, 84759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 84790, 84813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 84861, 84879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 84995, 85002);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 84675, 86955);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 84675, 86955);
            }


            static WSManSenderDetails()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 84675, 86955);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 84675, 86955);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 84675, 86955);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 84675, 86955);
        }
        internal class WSManCertificateDetails
        {
            internal string subject;

            internal string issuerName;

            internal string issuerThumbprint;

            internal string subjectName;

            internal static WSManCertificateDetails UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 87421, 88188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87525, 87563);

                    WSManCertificateDetails
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87583, 88139) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 87583, 88139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87657, 87777);

                        WSManCertificateDetailsInternal
                        resultInternal = f_1639_87706_87776(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87801, 87840);

                        result = f_1639_87810_87839();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87862, 87902);

                        result.subject = resultInternal.subject;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87924, 87970);

                        result.issuerName = resultInternal.issuerName;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87992, 88050);

                        result.issuerThumbprint = resultInternal.issuerThumbprint;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 88072, 88120);

                        result.subjectName = resultInternal.subjectName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 87583, 88139);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 88159, 88173);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 87421, 88188);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateDetails.WSManCertificateDetailsInternal
                    f_1639_87706_87776(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManCertificateDetailsInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 87706, 87776);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateDetails
                    f_1639_87810_87839()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateDetails();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 87810, 87839);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 87421, 88188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 87421, 88188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            private struct WSManCertificateDetailsInternal
            {

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string subject;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string issuerName;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string issuerThumbprint;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string subjectName;
                static WSManCertificateDetailsInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 88327, 88869);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 88327, 88869);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 88327, 88869);
                }
            }

            public WSManCertificateDetails()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 86967, 88880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87046, 87053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87084, 87094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87125, 87141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 87172, 87183);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 86967, 88880);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 86967, 88880);
            }


            static WSManCertificateDetails()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 86967, 88880);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 86967, 88880);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 86967, 88880);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 86967, 88880);
        }
        internal class WSManOperationInfo
        {
            internal WSManFragmentInternal fragment;

            internal WSManFilterInternal filter;

            internal WSManSelectorSet selectorSet;

            internal WSManOptionSet optionSet;

            internal static WSManOperationInfo UnMarshal(IntPtr unmanagedData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 89377, 90153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89476, 89509);

                    WSManOperationInfo
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89529, 90104) || true) && (IntPtr.Zero != unmanagedData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 89529, 90104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89603, 89713);

                        WSManOperationInfoInternal
                        resultInternal = f_1639_89647_89712(unmanagedData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89737, 89771);

                        result = f_1639_89746_89770();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89793, 89835);

                        result.fragment = resultInternal.fragment;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89857, 89895);

                        result.filter = resultInternal.filter;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89917, 89993);

                        result.selectorSet = f_1639_89938_89992(resultInternal.selectorSet);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 90015, 90085);

                        result.optionSet = WSManOptionSet.UnMarshal(resultInternal.optionSet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 89529, 90104);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 90124, 90138);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 89377, 90153);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOperationInfo.WSManOperationInfoInternal
                    f_1639_89647_89712(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManOperationInfoInternal>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 89647, 89712);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOperationInfo
                    f_1639_89746_89770()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOperationInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 89746, 89770);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSelectorSet
                    f_1639_89938_89992(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSelectorSet.WSManSelectorSetStruct
                    resultInternal)
                    {
                        var return_v = WSManSelectorSet.UnMarshal(resultInternal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 89938, 89992);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 89377, 90153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 89377, 90153);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            private struct WSManOperationInfoInternal
            {

                internal WSManFragmentInternal fragment;

                internal WSManFilterInternal filter;

                internal WSManSelectorSet.WSManSelectorSetStruct selectorSet;

                internal WSManOptionSetStruct optionSet;
                static WSManOperationInfoInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 90555, 90953);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 90555, 90953);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 90555, 90953);
                }
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal struct WSManFragmentInternal
            {

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string path;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string dialect;
                static WSManFragmentInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 91083, 91411);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 91083, 91411);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 91083, 91411);
                }
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal struct WSManFilterInternal
            {

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string filter;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string dialect;
                static WSManFilterInternal()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 91539, 91867);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 91539, 91867);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 91539, 91867);
                }
            }

            public WSManOperationInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 88892, 91878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 89080, 89091);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 88892, 91878);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 88892, 91878);
            }


            static WSManOperationInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 88892, 91878);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 88892, 91878);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 88892, 91878);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 88892, 91878);
        }
        internal class WSManSelectorSet
        {
            internal int numberKeys;

            internal WSManKeyStruct[] keys;

            internal static WSManSelectorSet UnMarshal(WSManSelectorSetStruct resultInternal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 92253, 93215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92367, 92400);

                    WSManKeyStruct[]
                    tempKeys = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92418, 92992) || true) && (resultInternal.numberKeys > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 92418, 92992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92493, 92550);

                        tempKeys = new WSManKeyStruct[resultInternal.numberKeys];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92572, 92623);

                        int
                        sizeInBytes = f_1639_92590_92622()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92645, 92688);

                        IntPtr
                        perElementPtr = resultInternal.keys
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92721, 92726);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92712, 92973) || true) && (i < resultInternal.numberKeys)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92759, 92762)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 92712, 92973))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 92712, 92973);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92812, 92868);

                                IntPtr
                                p = IntPtr.Add(perElementPtr, (i * sizeInBytes))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92894, 92950);

                                tempKeys[i] = f_1639_92908_92949(p);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1639, 1, 262);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1639, 1, 262);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 92418, 92992);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 93012, 93061);

                    WSManSelectorSet
                    result = f_1639_93038_93060()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 93079, 93125);

                    result.numberKeys = resultInternal.numberKeys;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 93143, 93166);

                    result.keys = tempKeys;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 93186, 93200);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 92253, 93215);

                    int
                    f_1639_92590_92622()
                    {
                        var return_v = Marshal.SizeOf<WSManKeyStruct>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 92590, 92622);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSelectorSet.WSManKeyStruct
                    f_1639_92908_92949(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<WSManKeyStruct>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 92908, 92949);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSelectorSet
                    f_1639_93038_93060()
                    {
                        var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSelectorSet();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 93038, 93060);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 92253, 93215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 92253, 93215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal struct WSManSelectorSetStruct
            {

                internal int numberKeys;

                internal IntPtr keys;
                static WSManSelectorSetStruct()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 93349, 93696);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 93349, 93696);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 93349, 93696);
                }
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal struct WSManKeyStruct
            {

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string key;

                [MarshalAs(UnmanagedType.LPWStr)]
                internal string value;
                static WSManKeyStruct()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 93828, 94146);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 93828, 94146);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 93828, 94146);
                }
            }

            public WSManSelectorSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 91890, 94157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 91959, 91969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 92010, 92014);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 91890, 94157);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 91890, 94157);
            }


            static WSManSelectorSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 91890, 94157);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 91890, 94157);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 91890, 94157);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 91890, 94157);
        }

        internal const string
        WSManClientApiDll = @"WsmSvc.dll"
        ;

        internal const string
        WSManProviderApiDll = @"WsmSvc.dll"
        ;

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManInitialize(int flags,
                  [In, Out] ref IntPtr wsManAPIHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManDeinitialize(IntPtr wsManAPIHandle, int flags);

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManCreateSession(IntPtr wsManAPIHandle,
                    [MarshalAs(UnmanagedType.LPWStr)] string connection,
                    int flags,
                    IntPtr authenticationCredentials,
                    IntPtr proxyInfo,
                    [In, Out] ref IntPtr wsManSessionHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManCloseSession(IntPtr wsManSessionHandle,
                    int flags);

        internal static int WSManSetSessionOption(IntPtr wsManSessionHandle,
                    WSManSessionOption option,
                    WSManDataDWord data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 97991, 98371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 98158, 98203);

                MarshalledObject
                marshalObj = data.Marshal()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 98217, 98360);
                using (marshalObj)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 98268, 98345);

                    return f_1639_98275_98344(wsManSessionHandle, option, marshalObj.DataPtr);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1639, 98217, 98360);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 97991, 98371);

                int
                f_1639_98275_98344(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.IntPtr
                data)
                {
                    var return_v = WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 98275, 98344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 97991, 98371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 97991, 98371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManSetSessionOption(IntPtr wsManSessionHandle,
                    WSManSessionOption option,
                    IntPtr data);

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManGetSessionOptionAsDword(IntPtr wsManSessionHandle,
                    WSManSessionOption option,
                    out int value);

        internal static string WSManGetSessionOptionAsString(IntPtr wsManAPIHandle,
                    WSManSessionOption option)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 99671, 101363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 99811, 99887);

                f_1639_99811_99886(IntPtr.Zero != wsManAPIHandle, "wsManAPIHandle cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 99986, 100028);

                const int
                ERROR_INSUFFICIENT_BUFFER = 122
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100044, 100076);

                string
                returnval = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100090, 100109);

                int
                bufferSize = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100170, 100364) || true) && (ERROR_INSUFFICIENT_BUFFER != f_1639_100203_100298(wsManAPIHandle, option, 0, null, out bufferSize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 100170, 100364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100332, 100349);

                    return returnval;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 100170, 100364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100623, 100662);

                int
                bufferSizeInBytes = bufferSize * 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100676, 100726);

                byte[]
                msgBufferPtr = new byte[bufferSizeInBytes]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100783, 100801);

                int
                messageLength
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100815, 101016) || true) && (0 != f_1639_100824_100950(wsManAPIHandle, option, bufferSizeInBytes, msgBufferPtr, out messageLength))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 100815, 101016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 100984, 101001);

                    return returnval;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 100815, 101016);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 101068, 101143);

                    returnval = f_1639_101080_101142(f_1639_101080_101096(), msgBufferPtr, 0, bufferSizeInBytes);
                }
                catch (ArgumentNullException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1639, 101172, 101231);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1639, 101172, 101231);
                }
                catch (System.Text.DecoderFallbackException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1639, 101245, 101319);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1639, 101245, 101319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 101335, 101352);

                return returnval;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 99671, 101363);

                int
                f_1639_99811_99886(bool
                condition, string
                message)
                {
                    Dbg.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 99811, 99886);
                    return 0;
                }


                int
                f_1639_100203_100298(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                optionLength, byte[]
                optionAsString, out int
                optionLengthUsed)
                {
                    var return_v = WSManGetSessionOptionAsString(wsManSessionHandle, option, optionLength, optionAsString, out optionLengthUsed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 100203, 100298);
                    return return_v;
                }


                int
                f_1639_100824_100950(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                optionLength, byte[]
                optionAsString, out int
                optionLengthUsed)
                {
                    var return_v = WSManGetSessionOptionAsString(wsManSessionHandle, option, optionLength, optionAsString, out optionLengthUsed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 100824, 100950);
                    return return_v;
                }


                System.Text.Encoding
                f_1639_101080_101096()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 101080, 101096);
                    return return_v;
                }


                string
                f_1639_101080_101142(System.Text.Encoding
                this_param, byte[]
                bytes, int
                index, int
                count)
                {
                    var return_v = this_param.GetString(bytes, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 101080, 101142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 99671, 101363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 99671, 101363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        private static extern int WSManGetSessionOptionAsString(IntPtr wsManSessionHandle,
                    WSManSessionOption option,
                    int optionLength,
                    byte[] optionAsString,
                    out int optionLengthUsed);

        internal static void WSManCreateShellEx(IntPtr wsManSessionHandle,
                    int flags,
                    string resourceUri,
                    string shellId,
                    WSManShellStartupInfo_ManToUn startupInfo,
                    WSManOptionSet optionSet,
                    WSManData_ManToUn openContent,
                    IntPtr asyncCallback,
                    ref IntPtr shellOperationHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 102860, 103443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 103257, 103432);

                f_1639_103257_103431(wsManSessionHandle, flags, resourceUri, shellId, startupInfo, optionSet, openContent, asyncCallback, ref shellOperationHandle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 102860, 103443);

                int
                f_1639_103257_103431(System.IntPtr
                wsManSessionHandle, int
                flags, string
                resourceUri, string
                shellId, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_ManToUn
                startupInfo, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet
                optionSet, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                openContent, System.IntPtr
                asyncCallback, ref System.IntPtr
                shellOperationHandle)
                {
                    WSManCreateShellExInternal(wsManSessionHandle, flags, resourceUri, shellId, (System.IntPtr)startupInfo, (System.IntPtr)optionSet, (System.IntPtr)openContent, asyncCallback, ref shellOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 103257, 103431);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 102860, 103443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 102860, 103443);
            }
        }

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManCreateShellEx", SetLastError = false, CharSet = CharSet.Unicode)]
        private static extern void WSManCreateShellExInternal(IntPtr wsManSessionHandle,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)] string resourceUri,
                    [MarshalAs(UnmanagedType.LPWStr)] string shellId,
                    IntPtr startupInfo,
                    IntPtr optionSet,
                    IntPtr openContent,
                    IntPtr asyncCallback,
                    [In, Out] ref IntPtr shellOperationHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManConnectShell", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManConnectShellEx(IntPtr wsManSessionHandle,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)] string resourceUri,
                    [MarshalAs(UnmanagedType.LPWStr)] string shellId,
                    IntPtr optionSet,
                    IntPtr connectXml,
                    IntPtr asyncCallback,
                    [In, Out] ref IntPtr shellOperationHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManDisconnectShell", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManDisconnectShellEx(IntPtr wsManSessionHandle,
                    int flags,
                    IntPtr disconnectInfo,
                    IntPtr asyncCallback);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManReconnectShell", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManReconnectShellEx(IntPtr wsManSessionHandle,
                    int flags,
                    IntPtr asyncCallback);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManReconnectShellCommand", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManReconnectShellCommandEx(IntPtr wsManCommandHandle,
                    int flags,
                    IntPtr asyncCallback);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManRunShellCommandEx", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManRunShellCommandEx(IntPtr shellOperationHandle,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)]
            string commandId,
                    [MarshalAs(UnmanagedType.LPWStr)]
            string commandLine,
                    IntPtr commandArgSet,
                    IntPtr optionSet,
                    IntPtr asyncCallback,
                    ref IntPtr commandOperationHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManConnectShellCommand", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManConnectShellCommandEx(IntPtr shellOperationHandle,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)]
            string commandID,
                    IntPtr optionSet,
                    IntPtr connectXml,
                    IntPtr asyncCallback,
                    ref IntPtr commandOperationHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManReceiveShellOutput", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManReceiveShellOutputEx(IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    int flags,
                    IntPtr desiredStreamSet,
                    IntPtr asyncCallback,
                    [In, Out] ref IntPtr receiveOperationHandle);

        internal static void WSManSendShellInputEx(IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)] string streamId,
                    WSManData_ManToUn streamData,
                    IntPtr asyncCallback,
                    ref IntPtr sendOperationHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 110804, 111339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 111155, 111328);

                f_1639_111155_111327(shellOperationHandle, commandOperationHandle, flags, streamId, streamData, false, asyncCallback, ref sendOperationHandle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 110804, 111339);

                int
                f_1639_111155_111327(System.IntPtr
                shellOperationHandle, System.IntPtr
                commandOperationHandle, int
                flags, string
                streamId, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                streamData, bool
                endOfStream, System.IntPtr
                asyncCallback, ref System.IntPtr
                sendOperationHandle)
                {
                    WSManSendShellInputExInternal(shellOperationHandle, commandOperationHandle, flags, streamId, (System.IntPtr)streamData, endOfStream, asyncCallback, ref sendOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 111155, 111327);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 110804, 111339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 110804, 111339);
            }
        }

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManSendShellInput", SetLastError = false, CharSet = CharSet.Unicode)]
        private static extern void WSManSendShellInputExInternal(IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)] string streamId,
                    IntPtr streamData,
                    bool endOfStream,
                    IntPtr asyncCallback,
                    [In, Out] ref IntPtr sendOperationHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManCloseShell(IntPtr shellHandle,
                    int flags,
                    IntPtr asyncCallback);

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManCloseCommand(IntPtr cmdHandle,
                    int flags,
                    IntPtr asyncCallback);

        [DllImport(WSManNativeApi.WSManClientApiDll, EntryPoint = "WSManSignalShell", SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManSignalShellEx(IntPtr shellOperationHandle,
                    IntPtr cmdOperationHandle,
                    int flags,
                    string code,
                    IntPtr asyncCallback,
                    [In, Out] ref IntPtr signalOperationHandle);

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern void WSManCloseOperation(IntPtr operationHandle, int flags);

        internal static string WSManGetErrorMessage(IntPtr wsManAPIHandle, int errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1639, 115855, 117715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 115961, 116037);

                f_1639_115961_116036(IntPtr.Zero != wsManAPIHandle, "wsManAPIHandle cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116138, 116180);

                const int
                ERROR_INSUFFICIENT_BUFFER = 122
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116231, 116283);

                string
                langCode = f_1639_116249_116282(f_1639_116249_116277())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116299, 116331);

                string
                returnval = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116345, 116364);

                int
                bufferSize = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116425, 116630) || true) && (ERROR_INSUFFICIENT_BUFFER != f_1639_116458_116564(wsManAPIHandle, 0, langCode, errorCode, 0, null, out bufferSize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 116425, 116630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116598, 116615);

                    return returnval;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 116425, 116630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116889, 116928);

                int
                bufferSizeInBytes = bufferSize * 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 116942, 116992);

                byte[]
                msgBufferPtr = new byte[bufferSizeInBytes]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 117049, 117067);

                int
                messageLength
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 117081, 117289) || true) && (0 != f_1639_117090_117223(wsManAPIHandle, 0, langCode, errorCode, bufferSizeInBytes, msgBufferPtr, out messageLength))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1639, 117081, 117289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 117257, 117274);

                    return returnval;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1639, 117081, 117289);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 117341, 117416);

                    returnval = f_1639_117353_117415(f_1639_117353_117369(), msgBufferPtr, 0, bufferSizeInBytes);
                }
                catch (ArgumentNullException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1639, 117445, 117504);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1639, 117445, 117504);
                }
                catch (System.Text.DecoderFallbackException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1639, 117518, 117592);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1639, 117518, 117592);
                }
                catch (ArgumentOutOfRangeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1639, 117606, 117671);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1639, 117606, 117671);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 117687, 117704);

                return returnval;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1639, 115855, 117715);

                int
                f_1639_115961_116036(bool
                condition, string
                message)
                {
                    Dbg.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 115961, 116036);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1639_116249_116277()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 116249, 116277);
                    return return_v;
                }


                string
                f_1639_116249_116282(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 116249, 116282);
                    return return_v;
                }


                int
                f_1639_116458_116564(System.IntPtr
                wsManAPIHandle, int
                flags, string
                languageCode, int
                errorCode, int
                messageLength, byte[]
                message, out int
                messageLengthUsed)
                {
                    var return_v = WSManGetErrorMessage(wsManAPIHandle, flags, languageCode, errorCode, messageLength, message, out messageLengthUsed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 116458, 116564);
                    return return_v;
                }


                int
                f_1639_117090_117223(System.IntPtr
                wsManAPIHandle, int
                flags, string
                languageCode, int
                errorCode, int
                messageLength, byte[]
                message, out int
                messageLengthUsed)
                {
                    var return_v = WSManGetErrorMessage(wsManAPIHandle, flags, languageCode, errorCode, messageLength, message, out messageLengthUsed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 117090, 117223);
                    return return_v;
                }


                System.Text.Encoding
                f_1639_117353_117369()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1639, 117353, 117369);
                    return return_v;
                }


                string
                f_1639_117353_117415(System.Text.Encoding
                this_param, byte[]
                bytes, int
                index, int
                count)
                {
                    var return_v = this_param.GetString(bytes, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 117353, 117415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 115855, 117715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 115855, 117715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DllImport(WSManNativeApi.WSManClientApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManGetErrorMessage(IntPtr wsManAPIHandle,
                    int flags,
                    string languageCode,
                    int errorCode,
                    int messageLength,
                    byte[] message,
                    out int messageLengthUsed);

        [DllImport(WSManNativeApi.WSManProviderApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManPluginGetOperationParameters(
                    IntPtr requestDetails,
                    int flags,
                    [In, Out, MarshalAs(UnmanagedType.LPStruct)] WSManDataStruct data);

        [DllImport(WSManNativeApi.WSManProviderApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManPluginOperationComplete(
                    IntPtr requestDetails,
                    int flags,
                    int errorCode,
                    [MarshalAs(UnmanagedType.LPWStr)] string extendedInformation);

        internal enum WSManFlagReceive : int
        {
            /// <summary>
            /// No more data on this stream.  Only valid when a stream is specified.
            /// </summary>
            WSMAN_FLAG_RECEIVE_RESULT_NO_MORE_DATA = 1,
            /// <summary>
            /// Send the data as soon as possible.  Normally data is held onto in
            /// order to maximise the size of the response packet.  This should
            /// only be used if a request/response style of data is needed between
            /// the send and receive data streams.
            /// </summary>
            WSMAN_FLAG_RECEIVE_FLUSH = 2,
            /// <summary>
            /// Data reported is at a boundary. Plugins usually serialize and fragment
            /// output data objects and push them along the receive byte stream.
            /// If the current data chunk being reported is an end fragment of the
            /// data object current processed, plugins would set this flag.
            /// </summary>
            WSMAN_FLAG_RECEIVE_RESULT_DATA_BOUNDARY = 4
        }

        internal const string
        WSMAN_SHELL_NAMESPACE = "http://schemas.microsoft.com/wbem/wsman/1/windows/shell"
        ;

        internal const string
        WSMAN_COMMAND_STATE_DONE = WSMAN_SHELL_NAMESPACE + "/CommandState/Done"
        ;

        internal const string
        WSMAN_COMMAND_STATE_PENDING = WSMAN_SHELL_NAMESPACE + "/CommandState/Pending"
        ;

        internal const string
        WSMAN_COMMAND_STATE_RUNNING = WSMAN_SHELL_NAMESPACE + "/CommandState/Running"
        ;

        [DllImport(WSManNativeApi.WSManProviderApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManPluginReceiveResult(
                    IntPtr requestDetails,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)] string stream,
                    IntPtr streamResult,
                    [MarshalAs(UnmanagedType.LPWStr)] string commandState,
                    int exitCode);

        [DllImport(WSManNativeApi.WSManProviderApiDll, SetLastError = false, CharSet = CharSet.Unicode)]
        internal static extern int WSManPluginReportContext(
                    IntPtr requestDetails,
                    int flags,
                    IntPtr context);

        static WSManNativeApi()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 334, 127305);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 407, 428);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 461, 496);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 529, 562);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 595, 644);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 677, 737);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 770, 803);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 836, 873);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 906, 937);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 970, 1033);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 1066, 1095);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 1128, 1155);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 1199, 1238);
            WSMAN_STACK_VERSION = f_1639_1221_1238(3, 0);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 1268, 1308);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 1385, 1428);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 1505, 1548);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 1920, 1964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 2320, 2366);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 2598, 2646);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 3280, 3329);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 3750, 3800);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 3832, 3861);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 3893, 3922);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 3954, 3991);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4023, 4058);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4090, 4128);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4160, 4200);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4232, 4273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4305, 4337);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4369, 4405);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4437, 4488);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4520, 4562);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4594, 4642);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4674, 4722);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4754, 4803);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4835, 4887);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 4919, 4969);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5001, 5053);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5085, 5135);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5167, 5220);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5252, 5299);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5331, 5373);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5405, 5440);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5472, 5522);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5554, 5597);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5629, 5676);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5708, 5763);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5795, 5846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5878, 5914);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 5946, 5996);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 6028, 6072);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 6104, 6147);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 6179, 6219);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 6251, 6289);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 94264, 94297);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 94330, 94365);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 123762, 123843);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 123876, 123947);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 123980, 124057);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 124090, 124167);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 334, 127305);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 334, 127305);
        }


        static System.Version
        f_1639_1221_1238(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 1221, 1238);
            return return_v;
        }

    }

    /// <summary>
    /// Interface to enable stubbing of the WSManNativeApi PInvoke calls for
    /// unit testing.
    /// Note: It is implemented as a class to avoid exposing it outside the module.
    /// </summary>
    internal interface IWSManNativeApiFacade
    {

        int WSManPluginGetOperationParameters(
                    IntPtr requestDetails,
                    int flags,
                    WSManNativeApi.WSManDataStruct data);

        int WSManPluginOperationComplete(
                    IntPtr requestDetails,
                    int flags,
                    int errorCode,
                    string extendedInformation);

        int WSManPluginReceiveResult(
                    IntPtr requestDetails,
                    int flags,
                    string stream,
                    IntPtr streamResult,
                    string commandState,
                    int exitCode);

        int WSManPluginReportContext(
                    IntPtr requestDetails,
                    int flags,
                    IntPtr context);

        void WSManPluginRegisterShutdownCallback(
                    IntPtr requestDetails,
                    IntPtr shutdownCallback,
                    IntPtr shutdownContext);
    }
    internal class WSManNativeApiFacade : IWSManNativeApiFacade
    {
        int IWSManNativeApiFacade.WSManPluginGetOperationParameters(
                    IntPtr requestDetails,
                    int flags,
                    WSManNativeApi.WSManDataStruct data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 128746, 129037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 128941, 129026);

                return f_1639_128948_129025(requestDetails, flags, data);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 128746, 129037);

                int
                f_1639_128948_129025(System.IntPtr
                requestDetails, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                data)
                {
                    var return_v = WSManNativeApi.WSManPluginGetOperationParameters(requestDetails, flags, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 128948, 129025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 128746, 129037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 128746, 129037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IWSManNativeApiFacade.WSManPluginOperationComplete(
                    IntPtr requestDetails,
                    int flags,
                    int errorCode,
                    string extendedInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 129049, 129375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 129258, 129364);

                return f_1639_129265_129363(requestDetails, flags, errorCode, extendedInformation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 129049, 129375);

                int
                f_1639_129265_129363(System.IntPtr
                requestDetails, int
                flags, int
                errorCode, string
                extendedInformation)
                {
                    var return_v = WSManNativeApi.WSManPluginOperationComplete(requestDetails, flags, errorCode, extendedInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 129265, 129363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 129049, 129375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 129049, 129375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IWSManNativeApiFacade.WSManPluginReceiveResult(
                    IntPtr requestDetails,
                    int flags,
                    string stream,
                    IntPtr streamResult,
                    string commandState,
                    int exitCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 129387, 129773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 129646, 129762);

                return f_1639_129653_129761(requestDetails, flags, stream, streamResult, commandState, exitCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 129387, 129773);

                int
                f_1639_129653_129761(System.IntPtr
                requestDetails, int
                flags, string
                stream, System.IntPtr
                streamResult, string
                commandState, int
                exitCode)
                {
                    var return_v = WSManNativeApi.WSManPluginReceiveResult(requestDetails, flags, stream, streamResult, commandState, exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 129653, 129761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 129387, 129773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 129387, 129773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IWSManNativeApiFacade.WSManPluginReportContext(
                    IntPtr requestDetails,
                    int flags,
                    IntPtr context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 129785, 130040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1639, 129950, 130029);

                return f_1639_129957_130028(requestDetails, flags, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 129785, 130040);

                int
                f_1639_129957_130028(System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                context)
                {
                    var return_v = WSManNativeApi.WSManPluginReportContext(requestDetails, flags, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1639, 129957, 130028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 129785, 130040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 129785, 130040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void IWSManNativeApiFacade.WSManPluginRegisterShutdownCallback(
                    IntPtr requestDetails,
                    IntPtr shutdownCallback,
                    IntPtr shutdownContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1639, 130052, 130382);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1639, 130052, 130382);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1639, 130052, 130382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 130052, 130382);
            }
        }

        public WSManNativeApiFacade()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1639, 128670, 130389);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1639, 128670, 130389);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 128670, 130389);
        }


        static WSManNativeApiFacade()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1639, 128670, 130389);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1639, 128670, 130389);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1639, 128670, 130389);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1639, 128670, 130389);
    }
}
