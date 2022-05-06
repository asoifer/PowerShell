// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Remoting;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;

using Microsoft.Win32.SafeHandles;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal
{
    internal class PSSafeCryptProvHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        internal PSSafeCryptProvHandle() : base(f_1007_1281_1285_C(true))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 1241, 1290);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 1241, 1290);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 1241, 1290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 1241, 1290);
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected override bool ReleaseHandle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 1477, 1687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 1618, 1676);

                return f_1007_1625_1675(handle, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 1477, 1687);

                bool
                f_1007_1625_1675(System.IntPtr
                hProv, int
                dwFlags)
                {
                    var return_v = PSCryptoNativeUtils.CryptReleaseContext(hProv, (uint)dwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 1625, 1675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 1477, 1687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 1477, 1687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSSafeCryptProvHandle()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 858, 1694);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 858, 1694);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 858, 1694);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 858, 1694);

        static bool
        f_1007_1281_1285_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1007, 1241, 1290);
            return return_v;
        }

    }
    internal class PSSafeCryptKey : SafeHandleZeroOrMinusOneIsInvalid
    {
        internal PSSafeCryptKey() : base(f_1007_2430_2434_C(true))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 2397, 2439);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 2397, 2439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 2397, 2439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 2397, 2439);
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected override bool ReleaseHandle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 2626, 2829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 2767, 2818);

                return f_1007_2774_2817(handle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 2626, 2829);

                bool
                f_1007_2774_2817(System.IntPtr
                hKey)
                {
                    var return_v = PSCryptoNativeUtils.CryptDestroyKey(hKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 2774, 2817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 2626, 2829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 2626, 2829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSSafeCryptKey Zero { get; }

        static PSSafeCryptKey()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 2021, 3026);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 2951, 3019);
            Zero = f_1007_2998_3018();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 2021, 3026);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 2021, 3026);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 2021, 3026);

        static bool
        f_1007_2430_2434_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1007, 2397, 2439);
            return return_v;
        }


        static System.Management.Automation.Internal.PSSafeCryptKey
        f_1007_2998_3018()
        {
            var return_v = new System.Management.Automation.Internal.PSSafeCryptKey();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 2998, 3018);
            return return_v;
        }

    }
    internal class PSCryptoNativeUtils
    {
        [DllImportAttribute(PinvokeDllNames.CryptGenKeyDllName, EntryPoint = "CryptGenKey")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptGenKey(PSSafeCryptProvHandle hProv,
                                                      uint Algid,
                                                      uint dwFlags,
                                                      ref PSSafeCryptKey phKey);

        [DllImportAttribute(PinvokeDllNames.CryptDestroyKeyDllName, EntryPoint = "CryptDestroyKey")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptDestroyKey(IntPtr hKey);

        [DllImportAttribute(PinvokeDllNames.CryptAcquireContextDllName, EntryPoint = "CryptAcquireContext")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptAcquireContext(ref PSSafeCryptProvHandle phProv,
                    [InAttribute()][MarshalAsAttribute(UnmanagedType.LPWStr)] string szContainer,
                    [InAttribute()][MarshalAsAttribute(UnmanagedType.LPWStr)] string szProvider,
                    uint dwProvType,
                    uint dwFlags);

        [DllImportAttribute(PinvokeDllNames.CryptReleaseContextDllName, EntryPoint = "CryptReleaseContext")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptReleaseContext(IntPtr hProv, uint dwFlags);

        [DllImportAttribute(PinvokeDllNames.CryptEncryptDllName, EntryPoint = "CryptEncrypt")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptEncrypt(PSSafeCryptKey hKey,
                    IntPtr hHash,
                    [MarshalAsAttribute(UnmanagedType.Bool)] bool Final,
                    uint dwFlags,
                    byte[] pbData,
                    ref int pdwDataLen,
                    int dwBufLen);

        [DllImportAttribute(PinvokeDllNames.CryptDecryptDllName, EntryPoint = "CryptDecrypt")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptDecrypt(PSSafeCryptKey hKey,
                    IntPtr hHash,
                    [MarshalAsAttribute(UnmanagedType.Bool)] bool Final,
                    uint dwFlags,
                    byte[] pbData,
                    ref int pdwDataLen);

        [DllImportAttribute(PinvokeDllNames.CryptExportKeyDllName, EntryPoint = "CryptExportKey")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptExportKey(PSSafeCryptKey hKey,
                    PSSafeCryptKey hExpKey,
                    uint dwBlobType,
                    uint dwFlags,
                    byte[] pbData,
                    ref uint pdwDataLen);

        [DllImportAttribute(PinvokeDllNames.CryptImportKeyDllName, EntryPoint = "CryptImportKey")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptImportKey(PSSafeCryptProvHandle hProv,
                    byte[] pbData,
                    int dwDataLen,
                    PSSafeCryptKey hPubKey,
                    uint dwFlags,
                    ref PSSafeCryptKey phKey);

        [DllImportAttribute(PinvokeDllNames.CryptDuplicateKeyDllName, EntryPoint = "CryptDuplicateKey")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CryptDuplicateKey(PSSafeCryptKey hKey,
                                                            ref uint pdwReserved,
                                                            uint dwFlags,
                                                            ref PSSafeCryptKey phKey);

        [DllImportAttribute(PinvokeDllNames.GetLastErrorDllName, EntryPoint = "GetLastError")]
        public static extern uint GetLastError();

        public const uint
        CRYPT_VERIFYCONTEXT = 0xF0000000
        ;

        public const uint
        CRYPT_EXPORTABLE = 0x00000001
        ;

        public const int
        CRYPT_CREATE_SALT = 4
        ;

        public const int
        PROV_RSA_FULL = 1
        ;

        public const int
        PROV_RSA_AES = 24
        ;

        public const int
        AT_KEYEXCHANGE = 1
        ;

        public const int
        CALG_RSA_KEYX =
                    (PSCryptoNativeUtils.ALG_CLASS_KEY_EXCHANGE |
                    (PSCryptoNativeUtils.ALG_TYPE_RSA | PSCryptoNativeUtils.ALG_SID_RSA_ANY))
        ;

        public const int
        ALG_CLASS_KEY_EXCHANGE = (5) << (13)
        ;

        public const int
        ALG_TYPE_RSA = (2) << (9)
        ;

        public const int
        ALG_SID_RSA_ANY = 0
        ;

        public const int
        PUBLICKEYBLOB = 6
        ;

        public const int
        SIMPLEBLOB = 1
        ;

        public const int
        CALG_AES_256 = (ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_BLOCK | ALG_SID_AES_256)
        ;

        public const int
        ALG_CLASS_DATA_ENCRYPT = (3) << (13)
        ;

        public const int
        ALG_TYPE_BLOCK = (3) << (9)
        ;

        public const int
        ALG_SID_AES_256 = 16
        ;

        public const int
        CALG_AES_128 = (ALG_CLASS_DATA_ENCRYPT
                            | (ALG_TYPE_BLOCK | ALG_SID_AES_128))
        ;

        public const int
        ALG_SID_AES_128 = 14
        ;

        public PSCryptoNativeUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 3145, 16449);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 3145, 16449);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 3145, 16449);
        }


        static PSCryptoNativeUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 3145, 16449);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 13781, 13813);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 13929, 13958);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 14124, 14145);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 14249, 14266);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 14412, 14429);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 14557, 14575);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 14674, 14835);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 14954, 14990);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 15103, 15128);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 15205, 15224);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 15352, 15369);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 15495, 15509);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 15622, 15696);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 15810, 15846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 15952, 15979);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 16092, 16112);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 16227, 16324);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 16389, 16409);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 3145, 16449);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 3145, 16449);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 3145, 16449);
    }
    [SuppressMessage("Microsoft.Design", "CA1064:ExceptionsShouldBePublic")]
    [Serializable]
    internal class PSCryptoException : Exception
    {
        private uint _errorCode;

        internal uint ErrorCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 17311, 17380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 17347, 17365);

                    return _errorCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 17311, 17380);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 17263, 17391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 17263, 17391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSCryptoException() : this(f_1007_17592_17593_C(0), f_1007_17595_17626(string.Empty))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 17558, 17631);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 17558, 17631);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 17558, 17631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 17558, 17631);
            }
        }

        public PSCryptoException(uint errorCode, StringBuilder message)
        : base(f_1007_18036_18054_C(f_1007_18036_18054(message)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 17952, 18114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 17058, 17068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 18080, 18103);

                _errorCode = errorCode;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 17952, 18114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 17952, 18114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 17952, 18114);
            }
        }

        public PSCryptoException(string message) : this(f_1007_18375_18382_C(message), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 18327, 18393);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 18327, 18393);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 18327, 18393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 18327, 18393);
            }
        }

        public PSCryptoException(string message, Exception innerException) : base(f_1007_18826_18833_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 18739, 18919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 17058, 17068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 18875, 18908);

                _errorCode = unchecked((uint)-1);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 18739, 18919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 18739, 18919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 18739, 18919);
            }
        }

        protected PSCryptoException(SerializationInfo info, StreamingContext context)
        : base(f_1007_19421_19425_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 19310, 19635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 17058, 17068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 19460, 19494);

                _errorCode = unchecked(0xFFFFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 19508, 19624);

                f_1007_19508_19623(false, "type-specific serialization logic not implemented and so this constructor should not be called");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 19310, 19635);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 19310, 19635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 19310, 19635);
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 19924, 20078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 20033, 20067);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1007, 20033, 20066);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 19924, 20078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 19924, 20078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 19924, 20078);
            }
        }

        static PSCryptoException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 16851, 20129);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 16851, 20129);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 16851, 20129);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 16851, 20129);

        static System.Text.StringBuilder
        f_1007_17595_17626(string
        value)
        {
            var return_v = new System.Text.StringBuilder(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 17595, 17626);
            return return_v;
        }


        static uint
        f_1007_17592_17593_C(uint
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1007, 17558, 17631);
            return return_v;
        }


        static string
        f_1007_18036_18054(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 18036, 18054);
            return return_v;
        }


        static string
        f_1007_18036_18054_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1007, 17952, 18114);
            return return_v;
        }


        static string
        f_1007_18375_18382_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1007, 18327, 18393);
            return return_v;
        }


        static string
        f_1007_18826_18833_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1007, 18739, 18919);
            return return_v;
        }


        int
        f_1007_19508_19623(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 19508, 19623);
            return 0;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1007_19421_19425_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1007, 19310, 19635);
            return return_v;
        }

    }
    internal class PSRSACryptoServiceProvider : IDisposable
    {
        private PSSafeCryptProvHandle _hProv;

        private bool _canEncrypt;

        private PSSafeCryptKey _hRSAKey;

        private PSSafeCryptKey _hSessionKey;

        private bool _sessionKeyGenerated;

        private static PSSafeCryptProvHandle s_hStaticProv;

        private static PSSafeCryptKey s_hStaticRSAKey;

        private static bool s_keyPairGenerated;

        private static object s_syncObject;

        private PSRSACryptoServiceProvider(bool serverMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 21729, 22457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 20541, 20547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 20606, 20625);
                this._canEncrypt = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 20806, 20814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 20987, 20999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 21115, 21143);
                this._sessionKeyGenerated = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 21805, 22394) || true) && (serverMode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 21805, 22394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 21853, 21890);

                    _hProv = f_1007_21862_21889();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 22056, 22290);

                    bool
                    ret = f_1007_22067_22289(ref _hProv, null, null, PSCryptoNativeUtils.PROV_RSA_AES, PSCryptoNativeUtils.CRYPT_VERIFYCONTEXT)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 22310, 22327);

                    f_1007_22310_22326(this, ret);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 22347, 22379);

                    _hRSAKey = f_1007_22358_22378();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 21805, 22394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 22410, 22446);

                _hSessionKey = f_1007_22425_22445();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 21729, 22457);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 21729, 22457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 21729, 22457);
            }
        }

        internal string GetPublicKeyAsBase64EncodedString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 22716, 24150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 22792, 22817);

                uint
                publicKeyLength = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 22870, 23307);

                bool
                ret = f_1007_22881_23306(_hRSAKey, f_1007_22985_23004(), PSCryptoNativeUtils.PUBLICKEYBLOB, 0, null, ref publicKeyLength)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 23321, 23338);

                f_1007_23321_23337(this, ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 23415, 23460);

                byte[]
                publicKey = new byte[publicKeyLength]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 23474, 23891);

                ret = f_1007_23480_23890(_hRSAKey, f_1007_23580_23599(), PSCryptoNativeUtils.PUBLICKEYBLOB, 0, publicKey, ref publicKeyLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 23905, 23922);

                f_1007_23905_23921(this, ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 24059, 24109);

                string
                result = f_1007_24075_24108(publicKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 24125, 24139);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 22716, 24150);

                System.Management.Automation.Internal.PSSafeCryptKey
                f_1007_22985_23004()
                {
                    var return_v = PSSafeCryptKey.Zero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 22985, 23004);
                    return return_v;
                }


                bool
                f_1007_22881_23306(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.Management.Automation.Internal.PSSafeCryptKey
                hExpKey, int
                dwBlobType, int
                dwFlags, byte[]
                pbData, ref uint
                pdwDataLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptExportKey(hKey, hExpKey, (uint)dwBlobType, (uint)dwFlags, pbData, ref pdwDataLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 22881, 23306);
                    return return_v;
                }


                int
                f_1007_23321_23337(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 23321, 23337);
                    return 0;
                }


                System.Management.Automation.Internal.PSSafeCryptKey
                f_1007_23580_23599()
                {
                    var return_v = PSSafeCryptKey.Zero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 23580, 23599);
                    return return_v;
                }


                bool
                f_1007_23480_23890(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.Management.Automation.Internal.PSSafeCryptKey
                hExpKey, int
                dwBlobType, int
                dwFlags, byte[]
                pbData, ref uint
                pdwDataLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptExportKey(hKey, hExpKey, (uint)dwBlobType, (uint)dwFlags, pbData, ref pdwDataLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 23480, 23890);
                    return return_v;
                }


                int
                f_1007_23905_23921(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 23905, 23921);
                    return 0;
                }


                string
                f_1007_24075_24108(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 24075, 24108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 22716, 24150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 22716, 24150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GenerateSessionKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 24288, 25305);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 24347, 24397) || true) && (_sessionKeyGenerated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 24347, 24397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 24390, 24397);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 24347, 24397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 24419, 24431);

                lock (s_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 24465, 25279) || true) && (!_sessionKeyGenerated)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 24465, 25279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 24532, 25069);

                        bool
                        ret = f_1007_24543_25068(_hProv, PSCryptoNativeUtils.CALG_AES_256, 0x01000000 |    // key length = 256 bits
                                                                                      PSCryptoNativeUtils.CRYPT_EXPORTABLE |
                                                                                      PSCryptoNativeUtils.CRYPT_CREATE_SALT, ref _hSessionKey)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 25091, 25108);

                        f_1007_25091_25107(this, ret);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 25130, 25158);

                        _sessionKeyGenerated = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 25180, 25199);

                        _canEncrypt = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 24465, 25279);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 24288, 25305);

                bool
                f_1007_24543_25068(System.Management.Automation.Internal.PSSafeCryptProvHandle
                hProv, int
                Algid, uint
                dwFlags, ref System.Management.Automation.Internal.PSSafeCryptKey
                phKey)
                {
                    var return_v = PSCryptoNativeUtils.CryptGenKey(hProv, (uint)Algid, dwFlags, ref phKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 24543, 25068);
                    return return_v;
                }


                int
                f_1007_25091_25107(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 25091, 25107);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 24288, 25305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 24288, 25305);
            }
        }

        internal string SafeExportSessionKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 25692, 27103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 25805, 25826);

                f_1007_25805_25825(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 25842, 25858);

                uint
                length = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 25911, 26304);

                bool
                ret = f_1007_25922_26303(_hSessionKey, _hRSAKey, PSCryptoNativeUtils.SIMPLEBLOB, 0, null, ref length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 26318, 26335);

                f_1007_26318_26334(this, ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 26402, 26439);

                byte[]
                sessionkey = new byte[length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 26453, 26847);

                ret = f_1007_26459_26846(_hSessionKey, _hRSAKey, PSCryptoNativeUtils.SIMPLEBLOB, 0, sessionkey, ref length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 26861, 26878);

                f_1007_26861_26877(this, ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 26956, 26975);

                _canEncrypt = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 27050, 27092);

                return f_1007_27057_27091(sessionkey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 25692, 27103);

                int
                f_1007_25805_25825(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    this_param.GenerateSessionKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 25805, 25825);
                    return 0;
                }


                bool
                f_1007_25922_26303(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.Management.Automation.Internal.PSSafeCryptKey
                hExpKey, int
                dwBlobType, int
                dwFlags, byte[]
                pbData, ref uint
                pdwDataLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptExportKey(hKey, hExpKey, (uint)dwBlobType, (uint)dwFlags, pbData, ref pdwDataLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 25922, 26303);
                    return return_v;
                }


                int
                f_1007_26318_26334(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 26318, 26334);
                    return 0;
                }


                bool
                f_1007_26459_26846(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.Management.Automation.Internal.PSSafeCryptKey
                hExpKey, int
                dwBlobType, int
                dwFlags, byte[]
                pbData, ref uint
                pdwDataLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptExportKey(hKey, hExpKey, (uint)dwBlobType, (uint)dwFlags, pbData, ref pdwDataLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 26459, 26846);
                    return return_v;
                }


                int
                f_1007_26861_26877(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 26861, 26877);
                    return 0;
                }


                string
                f_1007_27057_27091(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 27057, 27091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 25692, 27103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 25692, 27103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ImportPublicKeyFromBase64EncodedString(string publicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 27341, 28002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 27436, 27512);

                f_1007_27436_27511(!f_1007_27448_27479(publicKey), "key cannot be null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 27528, 27589);

                byte[]
                convertedBase64 = f_1007_27553_27588(publicKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 27605, 27958);

                bool
                ret = f_1007_27616_27957(_hProv, convertedBase64, f_1007_27764_27786(convertedBase64), f_1007_27832_27851(), 0, ref _hRSAKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 27974, 27991);

                f_1007_27974_27990(this, ret);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 27341, 28002);

                bool
                f_1007_27448_27479(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 27448, 27479);
                    return return_v;
                }


                int
                f_1007_27436_27511(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 27436, 27511);
                    return 0;
                }


                byte[]
                f_1007_27553_27588(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 27553, 27588);
                    return return_v;
                }


                int
                f_1007_27764_27786(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 27764, 27786);
                    return return_v;
                }


                System.Management.Automation.Internal.PSSafeCryptKey
                f_1007_27832_27851()
                {
                    var return_v = PSSafeCryptKey.Zero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 27832, 27851);
                    return return_v;
                }


                bool
                f_1007_27616_27957(System.Management.Automation.Internal.PSSafeCryptProvHandle
                hProv, byte[]
                pbData, int
                dwDataLen, System.Management.Automation.Internal.PSSafeCryptKey
                hPubKey, int
                dwFlags, ref System.Management.Automation.Internal.PSSafeCryptKey
                phKey)
                {
                    var return_v = PSCryptoNativeUtils.CryptImportKey(hProv, pbData, dwDataLen, hPubKey, (uint)dwFlags, ref phKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 27616, 27957);
                    return return_v;
                }


                int
                f_1007_27974_27990(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 27974, 27990);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 27341, 28002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 27341, 28002);
            }
        }

        internal void ImportSessionKeyFromBase64EncodedString(string sessionKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 28259, 29066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 28356, 28433);

                f_1007_28356_28432(!f_1007_28368_28400(sessionKey), "key cannot be null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 28449, 28511);

                byte[]
                convertedBase64 = f_1007_28474_28510(sessionKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 28527, 28878);

                bool
                ret = f_1007_28538_28877(_hProv, convertedBase64, f_1007_28688_28710(convertedBase64), _hRSAKey, 0, ref _hSessionKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 28892, 28909);

                f_1007_28892_28908(this, ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 29036, 29055);

                _canEncrypt = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 28259, 29066);

                bool
                f_1007_28368_28400(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 28368, 28400);
                    return return_v;
                }


                int
                f_1007_28356_28432(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 28356, 28432);
                    return 0;
                }


                byte[]
                f_1007_28474_28510(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 28474, 28510);
                    return return_v;
                }


                int
                f_1007_28688_28710(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 28688, 28710);
                    return return_v;
                }


                bool
                f_1007_28538_28877(System.Management.Automation.Internal.PSSafeCryptProvHandle
                hProv, byte[]
                pbData, int
                dwDataLen, System.Management.Automation.Internal.PSSafeCryptKey
                hPubKey, int
                dwFlags, ref System.Management.Automation.Internal.PSSafeCryptKey
                phKey)
                {
                    var return_v = PSCryptoNativeUtils.CryptImportKey(hProv, pbData, dwDataLen, hPubKey, (uint)dwFlags, ref phKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 28538, 28877);
                    return return_v;
                }


                int
                f_1007_28892_28908(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 28892, 28908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 28259, 29066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 28259, 29066);
            }
        }

        internal byte[] EncryptWithSessionKey(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 29283, 31824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 29531, 29602);

                f_1007_29531_29601(_canEncrypt, "Remote key has not been imported to encrypt");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 29618, 29663);

                byte[]
                encryptedData = new byte[f_1007_29650_29661(data)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 29677, 29728);

                f_1007_29677_29727(data, 0, encryptedData, 0, f_1007_29715_29726(data));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 29744, 29782);

                int
                dataLength = f_1007_29761_29781(encryptedData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 29862, 30328);

                bool
                ret = f_1007_29873_30327(_hSessionKey, IntPtr.Zero, true, 0, encryptedData, ref dataLength, f_1007_30315_30326(data))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30524, 31514) || true) && (false == ret)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 30524, 31514);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30691, 30696);
                        // before reallocating the encryptedData buffer,
                        // zero out its contents
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30682, 30809) || true) && (i < f_1007_30702_30722(encryptedData))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30724, 30727)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 30682, 30809))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 30682, 30809);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30769, 30790);

                            encryptedData[i] = 0;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1007, 1, 128);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1007, 1, 128);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30829, 30866);

                    encryptedData = new byte[dataLength];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30886, 30937);

                    f_1007_30886_30936(data, 0, encryptedData, 0, f_1007_30924_30935(data));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30955, 30980);

                    dataLength = f_1007_30968_30979(data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 30998, 31462);

                    ret = f_1007_31004_31461(_hSessionKey, IntPtr.Zero, true, 0, encryptedData, ref dataLength, f_1007_31440_31460(encryptedData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 31482, 31499);

                    f_1007_31482_31498(this, ret);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 30524, 31514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 31682, 31719);

                byte[]
                result = new byte[dataLength]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 31733, 31785);

                f_1007_31733_31784(encryptedData, 0, result, 0, dataLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 31799, 31813);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 29283, 31824);

                int
                f_1007_29531_29601(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 29531, 29601);
                    return 0;
                }


                int
                f_1007_29650_29661(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 29650, 29661);
                    return return_v;
                }


                int
                f_1007_29715_29726(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 29715, 29726);
                    return return_v;
                }


                int
                f_1007_29677_29727(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 29677, 29727);
                    return 0;
                }


                int
                f_1007_29761_29781(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 29761, 29781);
                    return return_v;
                }


                int
                f_1007_30315_30326(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 30315, 30326);
                    return return_v;
                }


                bool
                f_1007_29873_30327(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.IntPtr
                hHash, bool
                Final, int
                dwFlags, byte[]
                pbData, ref int
                pdwDataLen, int
                dwBufLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptEncrypt(hKey, hHash, Final, (uint)dwFlags, pbData, ref pdwDataLen, dwBufLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 29873, 30327);
                    return return_v;
                }


                int
                f_1007_30702_30722(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 30702, 30722);
                    return return_v;
                }


                int
                f_1007_30924_30935(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 30924, 30935);
                    return return_v;
                }


                int
                f_1007_30886_30936(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 30886, 30936);
                    return 0;
                }


                int
                f_1007_30968_30979(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 30968, 30979);
                    return return_v;
                }


                int
                f_1007_31440_31460(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 31440, 31460);
                    return return_v;
                }


                bool
                f_1007_31004_31461(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.IntPtr
                hHash, bool
                Final, int
                dwFlags, byte[]
                pbData, ref int
                pdwDataLen, int
                dwBufLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptEncrypt(hKey, hHash, Final, (uint)dwFlags, pbData, ref pdwDataLen, dwBufLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 31004, 31461);
                    return return_v;
                }


                int
                f_1007_31482_31498(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 31482, 31498);
                    return 0;
                }


                int
                f_1007_31733_31784(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 31733, 31784);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 29283, 31824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 29283, 31824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal byte[] DecryptWithSessionKey(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 32033, 34162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 32281, 32326);

                byte[]
                decryptedData = new byte[f_1007_32313_32324(data)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 32342, 32393);

                f_1007_32342_32392(data, 0, decryptedData, 0, f_1007_32380_32391(data));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 32409, 32447);

                int
                dataLength = f_1007_32426_32446(decryptedData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 32463, 32859);

                bool
                ret = f_1007_32474_32858(_hSessionKey, IntPtr.Zero, true, 0, decryptedData, ref dataLength)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 33055, 33667) || true) && (false == ret)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 33055, 33667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 33105, 33142);

                    decryptedData = new byte[dataLength];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 33162, 33213);

                    f_1007_33162_33212(data, 0, decryptedData, 0, f_1007_33200_33211(data));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 33231, 33617);

                    ret = f_1007_33237_33616(_hSessionKey, IntPtr.Zero, true, 0, decryptedData, ref dataLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 33635, 33652);

                    f_1007_33635_33651(this, ret);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 33055, 33667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 33835, 33872);

                byte[]
                result = new byte[dataLength]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 33888, 33940);

                f_1007_33888_33939(decryptedData, 0, result, 0, dataLength);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34015, 34020);

                    // zero out the decryptedData buffer
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34006, 34121) || true) && (i < f_1007_34026_34046(decryptedData))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34048, 34051)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 34006, 34121))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 34006, 34121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34085, 34106);

                        decryptedData[i] = 0;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1007, 1, 116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1007, 1, 116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34137, 34151);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 32033, 34162);

                int
                f_1007_32313_32324(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 32313, 32324);
                    return return_v;
                }


                int
                f_1007_32380_32391(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 32380, 32391);
                    return return_v;
                }


                int
                f_1007_32342_32392(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 32342, 32392);
                    return 0;
                }


                int
                f_1007_32426_32446(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 32426, 32446);
                    return return_v;
                }


                bool
                f_1007_32474_32858(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.IntPtr
                hHash, bool
                Final, int
                dwFlags, byte[]
                pbData, ref int
                pdwDataLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptDecrypt(hKey, hHash, Final, (uint)dwFlags, pbData, ref pdwDataLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 32474, 32858);
                    return return_v;
                }


                int
                f_1007_33200_33211(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 33200, 33211);
                    return return_v;
                }


                int
                f_1007_33162_33212(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 33162, 33212);
                    return 0;
                }


                bool
                f_1007_33237_33616(System.Management.Automation.Internal.PSSafeCryptKey
                hKey, System.IntPtr
                hHash, bool
                Final, int
                dwFlags, byte[]
                pbData, ref int
                pdwDataLen)
                {
                    var return_v = PSCryptoNativeUtils.CryptDecrypt(hKey, hHash, Final, (uint)dwFlags, pbData, ref pdwDataLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 33237, 33616);
                    return return_v;
                }


                int
                f_1007_33635_33651(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 33635, 33651);
                    return 0;
                }


                int
                f_1007_33888_33939(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 33888, 33939);
                    return 0;
                }


                int
                f_1007_34026_34046(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 34026, 34046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 32033, 34162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 32033, 34162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GenerateKeyPair()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 34320, 35786);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34376, 35695) || true) && (!s_keyPairGenerated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 34376, 35695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34439, 34451);
                    lock (s_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34493, 35661) || true) && (!s_keyPairGenerated)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 34493, 35661);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34566, 34610);

                            s_hStaticProv = f_1007_34582_34609();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 34798, 35071);

                            bool
                            ret = f_1007_34809_35070(ref s_hStaticProv, null, null, PSCryptoNativeUtils.PROV_RSA_AES, PSCryptoNativeUtils.CRYPT_VERIFYCONTEXT)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 35099, 35116);

                            f_1007_35099_35115(this, ret);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 35144, 35183);

                            s_hStaticRSAKey = f_1007_35162_35182();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 35209, 35480);

                            ret = f_1007_35215_35479(s_hStaticProv, PSCryptoNativeUtils.AT_KEYEXCHANGE, 0x08000000 | PSCryptoNativeUtils.CRYPT_EXPORTABLE, ref s_hStaticRSAKey);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 35508, 35525);

                            f_1007_35508_35524(this, ret);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 35612, 35638);

                            s_keyPairGenerated = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 34493, 35661);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 34376, 35695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 35711, 35734);

                _hProv = s_hStaticProv;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 35748, 35775);

                _hRSAKey = s_hStaticRSAKey;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 34320, 35786);

                System.Management.Automation.Internal.PSSafeCryptProvHandle
                f_1007_34582_34609()
                {
                    var return_v = new System.Management.Automation.Internal.PSSafeCryptProvHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 34582, 34609);
                    return return_v;
                }


                bool
                f_1007_34809_35070(ref System.Management.Automation.Internal.PSSafeCryptProvHandle
                phProv, string
                szContainer, string
                szProvider, int
                dwProvType, uint
                dwFlags)
                {
                    var return_v = PSCryptoNativeUtils.CryptAcquireContext(ref phProv, szContainer, szProvider, (uint)dwProvType, dwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 34809, 35070);
                    return return_v;
                }


                int
                f_1007_35099_35115(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 35099, 35115);
                    return 0;
                }


                System.Management.Automation.Internal.PSSafeCryptKey
                f_1007_35162_35182()
                {
                    var return_v = new System.Management.Automation.Internal.PSSafeCryptKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 35162, 35182);
                    return return_v;
                }


                bool
                f_1007_35215_35479(System.Management.Automation.Internal.PSSafeCryptProvHandle
                hProv, int
                Algid, uint
                dwFlags, ref System.Management.Automation.Internal.PSSafeCryptKey
                phKey)
                {
                    var return_v = PSCryptoNativeUtils.CryptGenKey(hProv, (uint)Algid, dwFlags, ref phKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 35215, 35479);
                    return return_v;
                }


                int
                f_1007_35508_35524(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                value)
                {
                    this_param.CheckStatus(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 35508, 35524);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 34320, 35786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 34320, 35786);
            }
        }

        internal bool CanEncrypt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 35991, 36061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 36027, 36046);

                    return _canEncrypt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 35991, 36061);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 35942, 36159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 35942, 36159);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 36077, 36148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 36113, 36133);

                    _canEncrypt = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 36077, 36148);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 35942, 36159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 35942, 36159);
                }
            }
        }

        internal static PSRSACryptoServiceProvider GetRSACryptoServiceProviderForClient()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1007, 36535, 36939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 36641, 36723);

                PSRSACryptoServiceProvider
                cryptoProvider = f_1007_36685_36722(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 36796, 36834);

                cryptoProvider._hProv = s_hStaticProv;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 36848, 36890);

                cryptoProvider._hRSAKey = s_hStaticRSAKey;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 36906, 36928);

                return cryptoProvider;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1007, 36535, 36939);

                System.Management.Automation.Internal.PSRSACryptoServiceProvider
                f_1007_36685_36722(bool
                serverMode)
                {
                    var return_v = new System.Management.Automation.Internal.PSRSACryptoServiceProvider(serverMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 36685, 36722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 36535, 36939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 36535, 36939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSRSACryptoServiceProvider GetRSACryptoServiceProviderForServer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1007, 37206, 37442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 37312, 37393);

                PSRSACryptoServiceProvider
                cryptoProvider = f_1007_37356_37392(true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 37409, 37431);

                return cryptoProvider;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1007, 37206, 37442);

                System.Management.Automation.Internal.PSRSACryptoServiceProvider
                f_1007_37356_37392(bool
                serverMode)
                {
                    var return_v = new System.Management.Automation.Internal.PSRSACryptoServiceProvider(serverMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 37356, 37392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 37206, 37442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 37206, 37442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckStatus(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 37815, 38220);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 37876, 37941) || true) && (value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 37876, 37941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 37919, 37926);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 37876, 37941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 37957, 38009);

                uint
                errorCode = f_1007_37974_38008()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38023, 38140);

                StringBuilder
                errorMessage = f_1007_38052_38139(f_1007_38070_38138(f_1007_38070_38130(unchecked(errorCode))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38156, 38209);

                throw f_1007_38162_38208(errorCode, errorMessage);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 37815, 38220);

                uint
                f_1007_37974_38008()
                {
                    var return_v = PSCryptoNativeUtils.GetLastError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 37974, 38008);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1007_38070_38130(uint
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception((int)error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 38070, 38130);
                    return return_v;
                }


                string
                f_1007_38070_38138(System.ComponentModel.Win32Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 38070, 38138);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1007_38052_38139(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 38052, 38139);
                    return return_v;
                }


                System.Management.Automation.Internal.PSCryptoException
                f_1007_38162_38208(uint
                errorCode, System.Text.StringBuilder
                message)
                {
                    var return_v = new System.Management.Automation.Internal.PSCryptoException(errorCode, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 38162, 38208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 37815, 38220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 37815, 38220);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 38380, 38498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38426, 38440);

                f_1007_38426_38439(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38454, 38487);

                f_1007_38454_38486(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 38380, 38498);

                int
                f_1007_38426_38439(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 38426, 38439);
                    return 0;
                }


                int
                f_1007_38454_38486(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                obj)
                {
                    System.GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 38454, 38486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 38380, 38498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 38380, 38498);
            }
        }

        protected void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 38586, 39940);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38649, 39929) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 38649, 39929);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38696, 38948) || true) && (_hSessionKey != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 38696, 38948);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38762, 38885) || true) && (f_1007_38766_38789_M(!_hSessionKey.IsInvalid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 38762, 38885);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38839, 38862);

                            f_1007_38839_38861(_hSessionKey);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 38762, 38885);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 38909, 38929);

                        _hSessionKey = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 38696, 38948);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39200, 39552) || true) && (s_hStaticRSAKey == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 39200, 39552);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39269, 39533) || true) && (_hRSAKey != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 39269, 39533);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39339, 39466) || true) && (f_1007_39343_39362_M(!_hRSAKey.IsInvalid))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 39339, 39466);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39420, 39439);

                                f_1007_39420_39438(_hRSAKey);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 39339, 39466);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39494, 39510);

                            _hRSAKey = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 39269, 39533);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 39200, 39552);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39572, 39914) || true) && (s_hStaticProv == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 39572, 39914);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39639, 39895) || true) && (_hProv != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 39639, 39895);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39707, 39830) || true) && (f_1007_39711_39728_M(!_hProv.IsInvalid))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 39707, 39830);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39786, 39803);

                                f_1007_39786_39802(_hProv);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 39707, 39830);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 39858, 39872);

                            _hProv = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 39639, 39895);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 39572, 39914);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 38649, 39929);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 38586, 39940);

                bool
                f_1007_38766_38789_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 38766, 38789);
                    return return_v;
                }


                int
                f_1007_38839_38861(System.Management.Automation.Internal.PSSafeCryptKey
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 38839, 38861);
                    return 0;
                }


                bool
                f_1007_39343_39362_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 39343, 39362);
                    return return_v;
                }


                int
                f_1007_39420_39438(System.Management.Automation.Internal.PSSafeCryptKey
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 39420, 39438);
                    return 0;
                }


                bool
                f_1007_39711_39728_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 39711, 39728);
                    return return_v;
                }


                int
                f_1007_39786_39802(System.Management.Automation.Internal.PSSafeCryptProvHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 39786, 39802);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 38586, 39940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 38586, 39940);
            }
        }

        /// <summary>
        /// Destructor.
        /// </summary>
        ~PSRSACryptoServiceProvider()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 40293, 40307);

            f_1007_40293_40306(this, true);
        }

        static PSRSACryptoServiceProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 20404, 40359);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 21257, 21270);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 21311, 21326);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 21357, 21383);
            s_keyPairGenerated = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 21416, 21443);
            s_syncObject = f_1007_21431_21443();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 20404, 40359);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 20404, 40359);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 20404, 40359);

        static object
        f_1007_21431_21443()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 21431, 21443);
            return return_v;
        }


        System.Management.Automation.Internal.PSSafeCryptProvHandle
        f_1007_21862_21889()
        {
            var return_v = new System.Management.Automation.Internal.PSSafeCryptProvHandle();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 21862, 21889);
            return return_v;
        }


        bool
        f_1007_22067_22289(ref System.Management.Automation.Internal.PSSafeCryptProvHandle
        phProv, string
        szContainer, string
        szProvider, int
        dwProvType, uint
        dwFlags)
        {
            var return_v = PSCryptoNativeUtils.CryptAcquireContext(ref phProv, szContainer, szProvider, (uint)dwProvType, dwFlags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 22067, 22289);
            return return_v;
        }


        int
        f_1007_22310_22326(System.Management.Automation.Internal.PSRSACryptoServiceProvider
        this_param, bool
        value)
        {
            this_param.CheckStatus(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 22310, 22326);
            return 0;
        }


        System.Management.Automation.Internal.PSSafeCryptKey
        f_1007_22358_22378()
        {
            var return_v = new System.Management.Automation.Internal.PSSafeCryptKey();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 22358, 22378);
            return return_v;
        }


        System.Management.Automation.Internal.PSSafeCryptKey
        f_1007_22425_22445()
        {
            var return_v = new System.Management.Automation.Internal.PSSafeCryptKey();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 22425, 22445);
            return return_v;
        }


        int
        f_1007_40293_40306(System.Management.Automation.Internal.PSRSACryptoServiceProvider
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 40293, 40306);
            return 0;
        }

    }
    internal abstract class PSRemotingCryptoHelper : IDisposable
    {
        protected PSRSACryptoServiceProvider _rsaCryptoProvider;

        protected ManualResetEvent _keyExchangeCompleted;

        protected object syncObject;

        private bool _keyExchangeStarted;

        protected void RunKeyExchangeIfRequired()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 41459, 42608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41525, 41587);

                f_1007_41525_41586(f_1007_41536_41543() != null, "data structure handler not set");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41603, 42597) || true) && (f_1007_41607_41637_M(!_rsaCryptoProvider.CanEncrypt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 41603, 42597);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41721, 41731);
                        lock (syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41781, 42173) || true) && (f_1007_41785_41815_M(!_rsaCryptoProvider.CanEncrypt))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 41781, 42173);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41873, 42146) || true) && (!_keyExchangeStarted)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 41873, 42146);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41963, 41990);

                                    _keyExchangeStarted = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 42024, 42054);

                                    f_1007_42024_42053(_keyExchangeCompleted);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 42088, 42115);

                                    f_1007_42088_42114(f_1007_42088_42095());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 41873, 42146);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 41781, 42173);
                            }
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1007, 42233, 42582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 42531, 42563);

                        f_1007_42531_42562(                    // for whatever reason if StartKeyExchange()
                                                               // throws an exception it should reset the
                                                               // wait handle, so it should pass this wait
                                                               // if it doesn't do so, its a bug
                                            _keyExchangeCompleted);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1007, 42233, 42582);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 41603, 42597);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 41459, 42608);

                System.Management.Automation.RemoteSession
                f_1007_41536_41543()
                {
                    var return_v = Session;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 41536, 41543);
                    return return_v;
                }


                int
                f_1007_41525_41586(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 41525, 41586);
                    return 0;
                }


                bool
                f_1007_41607_41637_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 41607, 41637);
                    return return_v;
                }


                bool
                f_1007_41785_41815_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 41785, 41815);
                    return return_v;
                }


                bool
                f_1007_42024_42053(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 42024, 42053);
                    return return_v;
                }


                System.Management.Automation.RemoteSession
                f_1007_42088_42095()
                {
                    var return_v = Session;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 42088, 42095);
                    return return_v;
                }


                int
                f_1007_42088_42114(System.Management.Automation.RemoteSession
                this_param)
                {
                    this_param.StartKeyExchange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 42088, 42114);
                    return 0;
                }


                bool
                f_1007_42531_42562(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 42531, 42562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 41459, 42608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 41459, 42608);
            }
        }

        protected string EncryptSecureStringCore(SecureString secureString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 42893, 44255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 42985, 43021);

                string
                encryptedDataAsString = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43037, 44199) || true) && (f_1007_43041_43070(_rsaCryptoProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 43037, 44199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43104, 43170);

                    IntPtr
                    ptr = f_1007_43117_43169(secureString)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43190, 44040) || true) && (ptr != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 43190, 44040);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43254, 43302);

                        byte[]
                        data = new byte[f_1007_43277_43296(secureString) * 2]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43333, 43338);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43324, 43468) || true) && (i < f_1007_43344_43355(data))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43357, 43360)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 43324, 43468))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 43324, 43468);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43410, 43445);

                                data[i] = f_1007_43420_43444(ptr, i);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1007, 1, 145);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1007, 1, 145);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43492, 43530);

                        f_1007_43492_43529(ptr);

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43606, 43676);

                            byte[]
                            encryptedData = f_1007_43629_43675(_rsaCryptoProvider, data)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43702, 43764);

                            encryptedDataAsString = f_1007_43726_43763(encryptedData);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1007, 43809, 44021);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43874, 43879);
                                for (int
        j = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43865, 43998) || true) && (j < f_1007_43885_43896(data))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43898, 43901)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 43865, 43998))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 43865, 43998);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 43959, 43971);

                                    data[j] = 0;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1007, 1, 134);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1007, 1, 134);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1007, 43809, 44021);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 43190, 44040);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 43037, 44199);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 43037, 44199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 44106, 44184);

                    throw f_1007_44112_44183(f_1007_44134_44182());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 43037, 44199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 44215, 44244);

                return encryptedDataAsString;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 42893, 44255);

                bool
                f_1007_43041_43070(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    var return_v = this_param.CanEncrypt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 43041, 43070);
                    return return_v;
                }


                System.IntPtr
                f_1007_43117_43169(System.Security.SecureString
                s)
                {
                    var return_v = Marshal.SecureStringToCoTaskMemUnicode(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 43117, 43169);
                    return return_v;
                }


                int
                f_1007_43277_43296(System.Security.SecureString
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 43277, 43296);
                    return return_v;
                }


                int
                f_1007_43344_43355(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 43344, 43355);
                    return return_v;
                }


                byte
                f_1007_43420_43444(System.IntPtr
                ptr, int
                ofs)
                {
                    var return_v = Marshal.ReadByte(ptr, ofs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 43420, 43444);
                    return return_v;
                }


                int
                f_1007_43492_43529(System.IntPtr
                s)
                {
                    Marshal.ZeroFreeCoTaskMemUnicode(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 43492, 43529);
                    return 0;
                }


                byte[]
                f_1007_43629_43675(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, byte[]
                data)
                {
                    var return_v = this_param.EncryptWithSessionKey(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 43629, 43675);
                    return return_v;
                }


                string
                f_1007_43726_43763(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 43726, 43763);
                    return return_v;
                }


                int
                f_1007_43885_43896(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 43885, 43896);
                    return return_v;
                }


                string
                f_1007_44134_44182()
                {
                    var return_v = SecuritySupportStrings.CannotEncryptSecureString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 44134, 44182);
                    return return_v;
                }


                System.Management.Automation.Internal.PSCryptoException
                f_1007_44112_44183(string
                message)
                {
                    var return_v = new System.Management.Automation.Internal.PSCryptoException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 44112, 44183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 42893, 44255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 42893, 44255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SecureString DecryptSecureStringCore(string encryptedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 44553, 46856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 44793, 44826);

                SecureString
                secureString = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 44946, 46809) || true) && (f_1007_44950_44979(_rsaCryptoProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 44946, 46809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45013, 45032);

                    byte[]
                    data = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45094, 45143);

                        data = f_1007_45101_45142(encryptedString);
                    }
                    catch (FormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1007, 45180, 45459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45410, 45440);

                        throw f_1007_45416_45439();
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1007, 45180, 45459);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45479, 46670) || true) && (data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 45479, 46670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45537, 45607);

                        byte[]
                        decryptedData = f_1007_45560_45606(_rsaCryptoProvider, data)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45631, 45665);

                        secureString = f_1007_45646_45664();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45687, 45704);

                        UInt16
                        value = 0
                        ;
                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45787, 45792);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45778, 46091) || true) && (i < f_1007_45798_45818(decryptedData))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45820, 45826)
        , i += 2, DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 45778, 46091))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 45778, 46091);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45884, 45957);

                                    value = (UInt16)(decryptedData[i] + (UInt16)(decryptedData[i + 1] << 8));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 45987, 46024);

                                    f_1007_45987_46023(secureString, value);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46054, 46064);

                                    value = 0;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1007, 1, 314);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1007, 1, 314);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1007, 46136, 46651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46331, 46341);

                            value = 0;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46428, 46433);

                                // zero out the contents
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46419, 46628) || true) && (i < f_1007_46439_46459(decryptedData))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46461, 46467)
        , i += 2, DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 46419, 46628))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 46419, 46628);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46525, 46546);

                                    decryptedData[i] = 0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46576, 46601);

                                    decryptedData[i + 1] = 0;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1007, 1, 210);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1007, 1, 210);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1007, 46136, 46651);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 45479, 46670);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 44946, 46809);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 44946, 46809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46736, 46794);

                    f_1007_46736_46793(false, "Session key not available to decrypt");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 44946, 46809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 46825, 46845);

                return secureString;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 44553, 46856);

                bool
                f_1007_44950_44979(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    var return_v = this_param.CanEncrypt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 44950, 44979);
                    return return_v;
                }


                byte[]
                f_1007_45101_45142(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 45101, 45142);
                    return return_v;
                }


                System.Management.Automation.Internal.PSCryptoException
                f_1007_45416_45439()
                {
                    var return_v = new System.Management.Automation.Internal.PSCryptoException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 45416, 45439);
                    return return_v;
                }


                byte[]
                f_1007_45560_45606(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, byte[]
                data)
                {
                    var return_v = this_param.DecryptWithSessionKey(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 45560, 45606);
                    return return_v;
                }


                System.Security.SecureString
                f_1007_45646_45664()
                {
                    var return_v = new System.Security.SecureString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 45646, 45664);
                    return return_v;
                }


                int
                f_1007_45798_45818(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 45798, 45818);
                    return return_v;
                }


                int
                f_1007_45987_46023(System.Security.SecureString
                this_param, ushort
                c)
                {
                    this_param.AppendChar((char)c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 45987, 46023);
                    return 0;
                }


                int
                f_1007_46439_46459(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 46439, 46459);
                    return return_v;
                }


                int
                f_1007_46736_46793(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 46736, 46793);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 44553, 46856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 44553, 46856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract string EncryptSecureString(SecureString secureString);

        internal abstract SecureString DecryptSecureString(string encryptedString);

        internal abstract RemoteSession Session { get; set; }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 47979, 48090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48025, 48039);

                f_1007_48025_48038(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48053, 48079);

                f_1007_48053_48078(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 47979, 48090);

                int
                f_1007_48025_48038(System.Management.Automation.Internal.PSRemotingCryptoHelper
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 48025, 48038);
                    return 0;
                }


                int
                f_1007_48053_48078(System.Management.Automation.Internal.PSRemotingCryptoHelper
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 48053, 48078);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 47979, 48090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 47979, 48090);
            }
        }

        public void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 48195, 48546);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48255, 48535) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 48255, 48535);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48302, 48422) || true) && (_rsaCryptoProvider != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 48302, 48422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48374, 48403);

                        f_1007_48374_48402(_rsaCryptoProvider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 48302, 48422);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48442, 48468);

                    _rsaCryptoProvider = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48488, 48520);

                    f_1007_48488_48519(
                                    _keyExchangeCompleted);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 48255, 48535);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 48195, 48546);

                int
                f_1007_48374_48402(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 48374, 48402);
                    return 0;
                }


                int
                f_1007_48488_48519(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 48488, 48519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 48195, 48546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 48195, 48546);
            }
        }

        internal void CompleteKeyExchange()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 48652, 48751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 48712, 48740);

                f_1007_48712_48739(_keyExchangeCompleted);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 48652, 48751);

                bool
                f_1007_48712_48739(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 48712, 48739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 48652, 48751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 48652, 48751);
            }
        }

        public PSRemotingCryptoHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 40523, 48797);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 40953, 40971);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41141, 41192);
            this._keyExchangeCompleted = f_1007_41165_41192(false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41321, 41346);
            this.syncObject = f_1007_41334_41346();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 41372, 41399);
            this._keyExchangeStarted = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 40523, 48797);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 40523, 48797);
        }


        static PSRemotingCryptoHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 40523, 48797);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 40523, 48797);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 40523, 48797);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 40523, 48797);

        System.Threading.ManualResetEvent
        f_1007_41165_41192(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 41165, 41192);
            return return_v;
        }


        object
        f_1007_41334_41346()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 41334, 41346);
            return return_v;
        }

    }
    internal class PSRemotingCryptoHelperServer : PSRemotingCryptoHelper
    {
        private RemoteSession _session;

        internal PSRemotingCryptoHelperServer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 49513, 49740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 49262, 49270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 49634, 49721);

                _rsaCryptoProvider = f_1007_49655_49720();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 49513, 49740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 49513, 49740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 49513, 49740);
            }
        }

        internal override string EncryptSecureString(SecureString secureString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 49823, 50669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 49919, 49980);

                ServerRemoteSession
                session = f_1007_49949_49956() as ServerRemoteSession
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 50279, 50597) || true) && ((session != null) && (DynAbs.Tracing.TraceSender.Expression_True(1007, 50283, 50398) && (f_1007_50305_50353(f_1007_50305_50337(f_1007_50305_50320(session))) >= RemotingConstants.ProtocolVersionWin8RTM)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 50279, 50597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 50432, 50472);

                    f_1007_50432_50471(_rsaCryptoProvider);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 50279, 50597);
                }

                else // older clients

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1007, 50279, 50597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 50555, 50582);

                    f_1007_50555_50581(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1007, 50279, 50597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 50613, 50658);

                return f_1007_50620_50657(this, secureString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 49823, 50669);

                System.Management.Automation.RemoteSession
                f_1007_49949_49956()
                {
                    var return_v = Session;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 49949, 49956);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1007_50305_50320(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 50305, 50320);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1007_50305_50337(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ClientCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 50305, 50337);
                    return return_v;
                }


                System.Version
                f_1007_50305_50353(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.ProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1007, 50305, 50353);
                    return return_v;
                }


                int
                f_1007_50432_50471(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    this_param.GenerateSessionKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 50432, 50471);
                    return 0;
                }


                int
                f_1007_50555_50581(System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                this_param)
                {
                    this_param.RunKeyExchangeIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 50555, 50581);
                    return 0;
                }


                string
                f_1007_50620_50657(System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                this_param, System.Security.SecureString
                secureString)
                {
                    var return_v = this_param.EncryptSecureStringCore(secureString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 50620, 50657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 49823, 50669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 49823, 50669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SecureString DecryptSecureString(string encryptedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 50681, 50882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 50780, 50807);

                f_1007_50780_50806(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 50823, 50871);

                return f_1007_50830_50870(this, encryptedString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 50681, 50882);

                int
                f_1007_50780_50806(System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                this_param)
                {
                    this_param.RunKeyExchangeIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 50780, 50806);
                    return 0;
                }


                System.Security.SecureString
                f_1007_50830_50870(System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                this_param, string
                encryptedString)
                {
                    var return_v = this_param.DecryptSecureStringCore(encryptedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 50830, 50870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 50681, 50882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 50681, 50882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ImportRemotePublicKey(string publicKeyAsString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 51165, 51770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 51251, 51343);

                f_1007_51251_51342(!f_1007_51263_51302(publicKeyAsString), "public key passed in cannot be null");

                // generate the crypto provider to use for encryption
                // _rsaCryptoProvider = GenerateCryptoServiceProvider(false);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 51539, 51616);

                    f_1007_51539_51615(_rsaCryptoProvider, publicKeyAsString);
                }
                catch (PSCryptoException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1007, 51645, 51731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 51703, 51716);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1007, 51645, 51731);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 51747, 51759);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 51165, 51770);

                bool
                f_1007_51263_51302(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 51263, 51302);
                    return return_v;
                }


                int
                f_1007_51251_51342(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 51251, 51342);
                    return 0;
                }


                int
                f_1007_51539_51615(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, string
                publicKey)
                {
                    this_param.ImportPublicKeyFromBase64EncodedString(publicKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 51539, 51615);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 51165, 51770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 51165, 51770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override RemoteSession Session
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 51967, 52034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 52003, 52019);

                    return _session;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 51967, 52034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 51903, 52129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 51903, 52129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 52050, 52118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 52086, 52103);

                    _session = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 52050, 52118);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 51903, 52129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 51903, 52129);
                }
            }
        }

        internal bool ExportEncryptedSessionKey(out string encryptedSessionKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 52277, 52680);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 52409, 52473);

                    encryptedSessionKey = f_1007_52431_52472(_rsaCryptoProvider);
                }
                catch (PSCryptoException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1007, 52502, 52641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 52560, 52595);

                    encryptedSessionKey = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 52613, 52626);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1007, 52502, 52641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 52657, 52669);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 52277, 52680);

                string
                f_1007_52431_52472(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    var return_v = this_param.SafeExportSessionKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 52431, 52472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 52277, 52680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 52277, 52680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSRemotingCryptoHelperServer GetTestRemotingCryptHelperServer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1007, 52899, 53172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 53003, 53076);

                PSRemotingCryptoHelperServer
                helper = f_1007_53041_53075()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 53090, 53131);

                helper.Session = f_1007_53107_53130();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 53147, 53161);

                return helper;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1007, 52899, 53172);

                System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                f_1007_53041_53075()
                {
                    var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperServer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 53041, 53075);
                    return return_v;
                }


                System.Management.Automation.Internal.TestHelperSession
                f_1007_53107_53130()
                {
                    var return_v = new System.Management.Automation.Internal.TestHelperSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 53107, 53130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 52899, 53172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 52899, 53172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSRemotingCryptoHelperServer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 48961, 53218);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 48961, 53218);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 48961, 53218);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 48961, 53218);

        System.Management.Automation.Internal.PSRSACryptoServiceProvider
        f_1007_49655_49720()
        {
            var return_v = PSRSACryptoServiceProvider.GetRSACryptoServiceProviderForServer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 49655, 49720);
            return return_v;
        }

    }
    internal class PSRemotingCryptoHelperClient : PSRemotingCryptoHelper
    {
        internal PSRemotingCryptoHelperClient()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 53732, 53944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 56398, 56451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 53796, 53883);

                _rsaCryptoProvider = f_1007_53817_53882();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 53732, 53944);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 53732, 53944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 53732, 53944);
            }
        }

        internal override string EncryptSecureString(SecureString secureString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 54104, 54299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 54200, 54227);

                f_1007_54200_54226(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 54243, 54288);

                return f_1007_54250_54287(this, secureString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 54104, 54299);

                int
                f_1007_54200_54226(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
                this_param)
                {
                    this_param.RunKeyExchangeIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 54200, 54226);
                    return 0;
                }


                string
                f_1007_54250_54287(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
                this_param, System.Security.SecureString
                secureString)
                {
                    var return_v = this_param.EncryptSecureStringCore(secureString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 54250, 54287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 54104, 54299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 54104, 54299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SecureString DecryptSecureString(string encryptedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 54311, 54512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 54410, 54437);

                f_1007_54410_54436(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 54453, 54501);

                return f_1007_54460_54500(this, encryptedString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 54311, 54512);

                int
                f_1007_54410_54436(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
                this_param)
                {
                    this_param.RunKeyExchangeIfRequired();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 54410, 54436);
                    return 0;
                }


                System.Security.SecureString
                f_1007_54460_54500(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
                this_param, string
                encryptedString)
                {
                    var return_v = this_param.DecryptSecureStringCore(encryptedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 54460, 54500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 54311, 54512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 54311, 54512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ExportLocalPublicKey(out string publicKeyAsString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 54800, 55634);
                // generate keys - the method already takes of creating
                // only when its not already created

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 55046, 55083);

                    f_1007_55046_55082(_rsaCryptoProvider);
                }
                catch (PSCryptoException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1007, 55112, 55302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 55170, 55176);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1007, 55112, 55302);

                    // the caller has to ensure that they
                    // complete the key exchange process
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 55354, 55429);

                    publicKeyAsString = f_1007_55374_55428(_rsaCryptoProvider);
                }
                catch (PSCryptoException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1007, 55458, 55595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 55516, 55549);

                    publicKeyAsString = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 55567, 55580);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1007, 55458, 55595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 55611, 55623);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 54800, 55634);

                int
                f_1007_55046_55082(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    this_param.GenerateKeyPair();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 55046, 55082);
                    return 0;
                }


                string
                f_1007_55374_55428(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param)
                {
                    var return_v = this_param.GetPublicKeyAsBase64EncodedString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 55374, 55428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 54800, 55634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 54800, 55634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ImportEncryptedSessionKey(string encryptedSessionKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 55782, 56265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 55874, 55979);

                f_1007_55874_55978(!f_1007_55886_55927(encryptedSessionKey), "encrypted session key passed in cannot be null");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 56031, 56111);

                    f_1007_56031_56110(_rsaCryptoProvider, encryptedSessionKey);
                }
                catch (PSCryptoException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1007, 56140, 56226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 56198, 56211);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1007, 56140, 56226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 56242, 56254);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 55782, 56265);

                bool
                f_1007_55886_55927(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 55886, 55927);
                    return return_v;
                }


                int
                f_1007_55874_55978(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 55874, 55978);
                    return 0;
                }


                int
                f_1007_56031_56110(System.Management.Automation.Internal.PSRSACryptoServiceProvider
                this_param, string
                sessionKey)
                {
                    this_param.ImportSessionKeyFromBase64EncodedString(sessionKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 56031, 56110);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 55782, 56265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 55782, 56265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override RemoteSession Session { get; set; }

        internal static PSRemotingCryptoHelperClient GetTestRemotingCryptHelperClient()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1007, 56670, 56943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 56774, 56847);

                PSRemotingCryptoHelperClient
                helper = f_1007_56812_56846()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 56861, 56902);

                helper.Session = f_1007_56878_56901();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 56918, 56932);

                return helper;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1007, 56670, 56943);

                System.Management.Automation.Internal.PSRemotingCryptoHelperClient
                f_1007_56812_56846()
                {
                    var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperClient();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 56812, 56846);
                    return return_v;
                }


                System.Management.Automation.Internal.TestHelperSession
                f_1007_56878_56901()
                {
                    var return_v = new System.Management.Automation.Internal.TestHelperSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 56878, 56901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 56670, 56943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 56670, 56943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSRemotingCryptoHelperClient()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 53382, 56989);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 53382, 56989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 53382, 56989);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 53382, 56989);

        System.Management.Automation.Internal.PSRSACryptoServiceProvider
        f_1007_53817_53882()
        {
            var return_v = PSRSACryptoServiceProvider.GetRSACryptoServiceProviderForClient();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1007, 53817, 53882);
            return return_v;
        }

    }
    internal class TestHelperSession : RemoteSession
    {
        internal override void StartKeyExchange()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 57089, 57193);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 57089, 57193);
                // intentionally left blank
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 57089, 57193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 57089, 57193);
            }
        }

        internal override RemotingDestination MySelf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 57274, 57371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1007, 57310, 57356);

                    return RemotingDestination.InvalidDestination;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 57274, 57371);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 57205, 57382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 57205, 57382);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void CompleteKeyExchange()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1007, 57394, 57501);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1007, 57394, 57501);
                // intentionally left blank
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1007, 57394, 57501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 57394, 57501);
            }
        }

        public TestHelperSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1007, 57024, 57508);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1007, 57024, 57508);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 57024, 57508);
        }


        static TestHelperSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1007, 57024, 57508);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1007, 57024, 57508);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1007, 57024, 57508);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1007, 57024, 57508);
    }
}
