// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56523

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Management.Automation.Internal;
using System.Runtime.ConstrainedExecution;
using DWORD = System.UInt32;
using BOOL = System.UInt32;

namespace System.Management.Automation.Security
{
internal partial class NativeConstants
{
internal const int 
CRYPT_OID_INFO_OID_KEY = 1
;

internal const int 
CRYPT_OID_INFO_NAME_KEY = 2
;

internal const int 
CRYPT_OID_INFO_CNG_ALGID_KEY = 5
;

public NativeConstants()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1225,505,732);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1225,505,732);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,505,732);
}


static NativeConstants()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,505,732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,579,605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,635,662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,692,724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,944,973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,1103,1131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,1259,1285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,1412,1440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,1570,1601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,1728,1756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,1886,1917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,2042,2069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,2199,2233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,2347,2362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,2474,2482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,2597,2608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,2723,2744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,2876,2914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,3057,3106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,3223,3247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,3371,3399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,3533,3588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,3715,3747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,3868,3894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,4003,4017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,4156,4184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,69690,69716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,69797,69827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,69911,69945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70030,70060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70143,70171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70256,70286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70376,70415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70508,70550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70643,70685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70772,70809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,70900,70941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,71029,71067);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,505,732);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,505,732);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1225,505,732);
}
internal partial class NativeConstants
{
public const int 
SAFER_TOKEN_NULL_IF_EQUAL = 1
;

public const int 
SAFER_TOKEN_COMPARE_ONLY = 2
;

public const int 
SAFER_TOKEN_MAKE_INERT = 4
;

public const int 
SAFER_CRITERIA_IMAGEPATH = 1
;

public const int 
SAFER_CRITERIA_NOSIGNEDHASH = 2
;

public const int 
SAFER_CRITERIA_IMAGEHASH = 4
;

public const int 
SAFER_CRITERIA_AUTHENTICODE = 8
;

public const int 
SAFER_CRITERIA_URLZONE = 16
;

public const int 
SAFER_CRITERIA_IMAGEPATH_NT = 4096
;

public const int 
WTD_UI_NONE = 2
;

public const int 
S_OK = 0
;

public const int 
S_FALSE = 1
;

public const int 
ERROR_MORE_DATA = 234
;

public const int 
ERROR_ACCESS_DISABLED_BY_POLICY = 1260
;

public const int 
ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = 786
;

public const int 
SAFER_MAX_HASH_SIZE = 64
;

public const string 
SRP_POLICY_SCRIPT = "SCRIPT"
;

internal const int 
SIGNATURE_DISPLAYNAME_LENGTH = NativeConstants.MAX_PATH
;

internal const int 
SIGNATURE_PUBLISHER_LENGTH = 128
;

internal const int 
SIGNATURE_HASH_LENGTH = 64
;

internal const int 
MAX_PATH = 260
;

internal const int 
FUNCTION_NOT_SUPPORTED = 120
;
}
internal static partial class NativeMethods
{
[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertEnumSystemStore(CertStoreFlags Flags,
                                 IntPtr notUsed1,
                                 IntPtr notUsed2,
                                 CertEnumSystemStoreCallBackProto fn);

        /// <summary>
        /// Signature of call back function used by CertEnumSystemStore.
        /// </summary>
        internal delegate
        bool CertEnumSystemStoreCallBackProto([MarshalAs(UnmanagedType.LPWStr)]
                                               string storeName,
                                               DWORD dwFlagsNotUsed,
                                               IntPtr notUsed1,
                                               IntPtr notUsed2,
                                               IntPtr notUsed3);

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        IntPtr CertEnumCertificatesInStore(IntPtr storeHandle,
                                            IntPtr certContext);

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        IntPtr CertFindCertificateInStore(
            IntPtr hCertStore,
            Security.NativeMethods.CertOpenStoreEncodingType dwEncodingType,
            DWORD dwFindFlags,                  // 0
            Security.NativeMethods.CertFindType dwFindType,
            [MarshalAs(UnmanagedType.LPWStr)] string pvFindPara,
            IntPtr notUsed1);

        [Flags]
        internal enum CertFindType
        {                                                       // pvFindPara:
            CERT_COMPARE_ANY = 0 << 16,         // null
            CERT_FIND_ISSUER_STR = (8 << 16) | 4,   // substring
            CERT_FIND_SUBJECT_STR = (8 << 16) | 7,   // substring
            CERT_FIND_CROSS_CERT_DIST_POINTS = 17 << 16,        // null
            CERT_FIND_SUBJECT_INFO_ACCESS = 19 << 16,        // null
            CERT_FIND_HASH_STR = 20 << 16,        // thumbprint
        }

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertCloseStore(IntPtr hCertStore, int dwFlags);

        [Flags]
        internal enum CertStoreFlags
        {
            CERT_SYSTEM_STORE_CURRENT_USER = 1 << 16,
            CERT_SYSTEM_STORE_LOCAL_MACHINE = 2 << 16,
            CERT_SYSTEM_STORE_CURRENT_SERVICE = 4 << 16,
            CERT_SYSTEM_STORE_SERVICES = 5 << 16,
            CERT_SYSTEM_STORE_USERS = 6 << 16,
            CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY = 7 << 16,
            CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY = 8 << 16,
            CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE = 9 << 16,
        }

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertGetEnhancedKeyUsage(IntPtr pCertContext, // PCCERT_CONTEXT
                                      DWORD dwFlags,
                                      IntPtr pUsage,       // PCERT_ENHKEY_USAGE
                                      out int pcbUsage);

[DllImport("Crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        IntPtr CertOpenStore(CertOpenStoreProvider storeProvider,
                              CertOpenStoreEncodingType dwEncodingType,
                              IntPtr notUsed1,          // hCryptProv
                              CertOpenStoreFlags dwFlags,
                              [MarshalAs(UnmanagedType.LPWStr)]
                              string storeName);

        [Flags]
        internal enum CertOpenStoreFlags
        {
            CERT_STORE_NO_CRYPT_RELEASE_FLAG = 0x00000001,
            CERT_STORE_SET_LOCALIZED_NAME_FLAG = 0x00000002,
            CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG = 0x00000004,
            CERT_STORE_DELETE_FLAG = 0x00000010,
            CERT_STORE_UNSAFE_PHYSICAL_FLAG = 0x00000020,
            CERT_STORE_SHARE_STORE_FLAG = 0x00000040,
            CERT_STORE_SHARE_CONTEXT_FLAG = 0x00000080,
            CERT_STORE_MANIFOLD_FLAG = 0x00000100,
            CERT_STORE_ENUM_ARCHIVED_FLAG = 0x00000200,
            CERT_STORE_UPDATE_KEYID_FLAG = 0x00000400,
            CERT_STORE_BACKUP_RESTORE_FLAG = 0x00000800,
            CERT_STORE_READONLY_FLAG = 0x00008000,
            CERT_STORE_OPEN_EXISTING_FLAG = 0x00004000,
            CERT_STORE_CREATE_NEW_FLAG = 0x00002000,
            CERT_STORE_MAXIMUM_ALLOWED_FLAG = 0x00001000,

            CERT_SYSTEM_STORE_CURRENT_USER = 1 << 16,
            CERT_SYSTEM_STORE_LOCAL_MACHINE = 2 << 16,
            CERT_SYSTEM_STORE_CURRENT_SERVICE = 4 << 16,
            CERT_SYSTEM_STORE_SERVICES = 5 << 16,
            CERT_SYSTEM_STORE_USERS = 6 << 16,
            CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY = 7 << 16,
            CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY = 8 << 16,
            CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE = 9 << 16,
        }

        [Flags]
        internal enum CertOpenStoreProvider
        {
            CERT_STORE_PROV_MEMORY = 2,
            CERT_STORE_PROV_SYSTEM = 10,
            CERT_STORE_PROV_SYSTEM_REGISTRY = 13,
        }

        [Flags]
        internal enum CertOpenStoreEncodingType
        {
            X509_ASN_ENCODING = 0x00000001,
        }

[DllImport("Crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertControlStore(
                        IntPtr hCertStore,
                        DWORD dwFlags,
                        CertControlStoreType dwCtrlType,
                        IntPtr pvCtrlPara);

        [Flags]
        internal enum CertControlStoreType : uint
        {
            CERT_STORE_CTRL_RESYNC = 1,
            CERT_STORE_CTRL_COMMIT = 3,
            CERT_STORE_CTRL_AUTO_RESYNC = 4,
        }

        [Flags]
        internal enum AddCertificateContext : uint
        {
            CERT_STORE_ADD_NEW = 1,
            CERT_STORE_ADD_USE_EXISTING = 2,
            CERT_STORE_ADD_REPLACE_EXISTING = 3,
            CERT_STORE_ADD_ALWAYS = 4,
            CERT_STORE_ADD_REPLACE_EXISTING_INHERIT_PROPERTIES = 5,
            CERT_STORE_ADD_NEWER = 6,
            CERT_STORE_ADD_NEWER_INHERIT_PROPERTIES = 7
        }

        [Flags]
        internal enum CertPropertyId
        {
            CERT_KEY_PROV_HANDLE_PROP_ID = 1,
            CERT_KEY_PROV_INFO_PROP_ID = 2,   // CRYPT_KEY_PROV_INFO
            CERT_SHA1_HASH_PROP_ID = 3,
            CERT_MD5_HASH_PROP_ID = 4,
            CERT_SEND_AS_TRUSTED_ISSUER_PROP_ID = 102,
        }

        [Flags]
        internal enum NCryptDeletKeyFlag
        {
            NCRYPT_MACHINE_KEY_FLAG = 0x00000020,  // same as CAPI CRYPT_MACHINE_KEYSET
            NCRYPT_SILENT_FLAG = 0x00000040,  // same as CAPI CRYPT_SILENT
        }

        [Flags]
        internal enum ProviderFlagsEnum : uint
        {
            CRYPT_VERIFYCONTEXT = 0xF0000000,
            CRYPT_NEWKEYSET = 0x00000008,
            CRYPT_DELETEKEYSET = 0x00000010,
            CRYPT_MACHINE_KEYSET = 0x00000020,
            CRYPT_SILENT = 0x00000040,
        }

        internal enum ProviderParam : int
        {
            PP_CLIENT_HWND = 1,
        }

        internal enum PROV : uint
        {
            /// <summary>
            /// The PROV_RSA_FULL type.
            /// </summary>
            RSA_FULL = 1,

            /// <summary>
            /// The PROV_RSA_SIG type.
            /// </summary>
            RSA_SIG = 2,

            /// <summary>
            /// The PROV_RSA_DSS type.
            /// </summary>
            DSS = 3,

            /// <summary>
            /// The PROV_FORTEZZA type.
            /// </summary>
            FORTEZZA = 4,

            /// <summary>
            /// The PROV_MS_EXCHANGE type.
            /// </summary>
            MS_EXCHANGE = 5,

            /// <summary>
            /// The PROV_SSL type.
            /// </summary>
            SSL = 6,

            /// <summary>
            /// The PROV_RSA_SCHANNEL type. SSL certificates are generated with these providers.
            /// </summary>
            RSA_SCHANNEL = 12,

            /// <summary>
            /// The PROV_DSS_DH type.
            /// </summary>
            DSS_DH = 13,

            /// <summary>
            /// The PROV_EC_ECDSA type.
            /// </summary>
            EC_ECDSA_SIG = 14,

            /// <summary>
            /// The PROV_EC_ECNRA_SIG type.
            /// </summary>
            EC_ECNRA_SIG = 15,

            /// <summary>
            /// The PROV_EC_ECDSA_FULL type.
            /// </summary>
            EC_ECDSA_FULL = 16,

            /// <summary>
            /// The PROV_EC_ECNRA_FULL type.
            /// </summary>
            EC_ECNRA_FULL = 17,

            /// <summary>
            /// The PROV_DH_SCHANNEL type.
            /// </summary>
            DH_SCHANNEL = 18,

            /// <summary>
            /// The PROV_SPYRUS_LYNKS type.
            /// </summary>
            SPYRUS_LYNKS = 20,

            /// <summary>
            /// The PROV_RNG type.
            /// </summary>
            RNG = 21,

            /// <summary>
            /// The PROV_INTEL_SEC type.
            /// </summary>
            INTEL_SEC = 22
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct CRYPT_KEY_PROV_INFO
        {

public string pwszContainerName;

public string pwszProvName;

public PROV dwProvType;

public uint dwFlags;

public uint cProvParam;

public IntPtr rgProvParam;

public uint dwKeySpec;
static CRYPT_KEY_PROV_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,14497,15901);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,14497,15901);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,14497,15901);
}
        }

internal const string 
NCRYPT_WINDOW_HANDLE_PROPERTY = "HWND Handle"
;

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertDeleteCertificateFromStore(IntPtr pCertContext);

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        IntPtr CertDuplicateCertificateContext(IntPtr pCertContext);

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertAddCertificateContextToStore(IntPtr hCertStore,
                                              IntPtr pCertContext,
                                              DWORD dwAddDisposition,
                                              ref IntPtr ppStoreContext);

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertFreeCertificateContext(IntPtr certContext);

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertGetCertificateContextProperty(IntPtr pCertContext,
                                               CertPropertyId dwPropId,
                                               IntPtr pvData,
                                               ref int pcbData);

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CertSetCertificateContextProperty(IntPtr pCertContext,
                                               CertPropertyId dwPropId,
                                               DWORD dwFlags,
                                               IntPtr pvData);

[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        IntPtr CryptFindLocalizedName(string pwszCryptName);

[DllImport(PinvokeDllNames.CryptAcquireContextDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CryptAcquireContext(ref IntPtr hProv,
                                 string strContainerName,
                                 string strProviderName,
                                 int nProviderType,
                                 uint uiProviderFlags);

[DllImport(PinvokeDllNames.CryptReleaseContextDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CryptReleaseContext(IntPtr hProv, int dwFlags);

[DllImport(PinvokeDllNames.CryptSetProvParamDllName, SetLastError = true)]
        internal static extern unsafe
        bool CryptSetProvParam(IntPtr hProv, ProviderParam dwParam, void* pbData, int dwFlags);

[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
        internal static extern
        int NCryptOpenStorageProvider(ref IntPtr hProv,
                                      string strProviderName,
                                      uint dwFlags);

[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
        internal static extern
        int NCryptOpenKey(IntPtr hProv,
                          ref IntPtr hKey,
                          string strKeyName,
                          uint dwLegacySpec,
                          uint dwFlags);

[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
        internal static extern unsafe
        int NCryptSetProperty(IntPtr hProv, string pszProperty, void* pbInput, int cbInput, int dwFlags);

[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
        internal static extern
        int NCryptDeleteKey(IntPtr hKey,
                            uint dwFlags);

[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
        internal static extern
        int NCryptFreeObject(IntPtr hObject);

[DllImport("cryptUI.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        bool CryptUIWizDigitalSign(DWORD dwFlags,
                                   IntPtr hwndParentNotUsed,
                                   IntPtr pwszWizardTitleNotUsed,
                                   IntPtr pDigitalSignInfo,
                                   IntPtr ppSignContextNotUsed);

        [Flags]
        internal enum CryptUIFlags
        {
            CRYPTUI_WIZ_NO_UI = 0x0001
            // other flags not used
        };

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPTUI_WIZ_DIGITAL_SIGN_INFO
        {

internal DWORD dwSize;

internal DWORD dwSubjectChoice;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszFileName;

internal DWORD dwSigningCertChoice;

internal IntPtr pSigningCertContext;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszTimestampURL;

internal DWORD dwAdditionalCertChoice;

internal IntPtr pSignExtInfo;
static CRYPTUI_WIZ_DIGITAL_SIGN_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,20757,21393);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,20757,21393);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,20757,21393);
}
        };

        [Flags]
        internal enum SignInfoSubjectChoice
        {
            CRYPTUI_WIZ_DIGITAL_SIGN_SUBJECT_FILE = 0x01
            // CRYPTUI_WIZ_DIGITAL_SIGN_SUBJECT_BLOB = 0x02 NotUsed
        };

        [Flags]
        internal enum SignInfoCertChoice
        {
            CRYPTUI_WIZ_DIGITAL_SIGN_CERT = 0x01
            // CRYPTUI_WIZ_DIGITAL_SIGN_STORE = 0x02, NotUsed
            // CRYPTUI_WIZ_DIGITAL_SIGN_PVK = 0x03, NotUsed
        };

        [Flags]
        internal enum SignInfoAdditionalCertChoice
        {
            CRYPTUI_WIZ_DIGITAL_SIGN_ADD_CHAIN = 1,
            CRYPTUI_WIZ_DIGITAL_SIGN_ADD_CHAIN_NO_ROOT = 2
        };

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO
        {

internal DWORD dwSize;

internal DWORD dwAttrFlagsNotUsed;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszDescription;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszMoreInfoLocation;

[MarshalAs(UnmanagedType.LPStr)]
            internal string pszHashAlg;

internal IntPtr pwszSigningCertDisplayStringNotUsed;

internal IntPtr hAdditionalCertStoreNotUsed;

internal IntPtr psAuthenticatedNotUsed;

internal IntPtr psUnauthenticatedNotUsed;
static CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,22084,22879);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,22084,22879);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,22084,22879);
}
        };

[ArchitectureSensitive]
        internal static CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO
            InitSignInfoExtendedStruct(string description,
                                       string moreInfoUrl,
                                       string hashAlgorithm)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,22891,23938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23185,23293);

CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO 
siex =
f_1225_23248_23292()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23309,23351);

siex.dwSize = (DWORD)f_1225_23330_23350(siex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23365,23393);

siex.dwAttrFlagsNotUsed = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23407,23442);

siex.pwszDescription = description;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23456,23496);

siex.pwszMoreInfoLocation = moreInfoUrl;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23510,23533);

siex.pszHashAlg = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23547,23602);

siex.pwszSigningCertDisplayStringNotUsed = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23616,23663);

siex.hAdditionalCertStoreNotUsed = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23677,23719);

siex.psAuthenticatedNotUsed = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23733,23777);

siex.psUnauthenticatedNotUsed = IntPtr.Zero;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23793,23899) || true) && (hashAlgorithm != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,23793,23899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23852,23884);

siex.pszHashAlg = hashAlgorithm;
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,23793,23899);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,23915,23927);

return siex;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,22891,23938);

System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO
f_1225_23248_23292()
{
var return_v = new System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 23248, 23292);
return return_v;
}


int
f_1225_23330_23350(System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 23330, 23350);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,22891,23938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,22891,23938);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_OID_INFO
        {

public uint cbSize;

[MarshalAsAttribute(UnmanagedType.LPStr)]
            public string pszOID;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
            public string pwszName;

public uint dwGroupId;

public Anonymous_a3ae7823_8a1d_432c_bc07_a72b6fc6c7d8 Union1;

public CRYPT_ATTR_BLOB ExtraInfo;
static CRYPT_OID_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,23950,24685);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,23950,24685);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,23950,24685);
}
        }

[StructLayout(LayoutKind.Explicit)]
        internal struct Anonymous_a3ae7823_8a1d_432c_bc07_a72b6fc6c7d8
        {

[FieldOffset(0)]
            public uint dwValue;

[FieldOffset(0)]
            public uint Algid;

[FieldOffset(0)]
            public uint dwLength;
static Anonymous_a3ae7823_8a1d_432c_bc07_a72b6fc6c7d8(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,24697,25133);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,24697,25133);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,24697,25133);
}
        }

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_ATTR_BLOB
        {

public uint cbData;

public System.IntPtr pbData;
static CRYPT_ATTR_BLOB(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,25145,25382);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,25145,25382);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,25145,25382);
}
        }

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_DATA_BLOB
        {

public uint cbData;

public System.IntPtr pbData;
static CRYPT_DATA_BLOB(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,25394,25631);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,25394,25631);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,25394,25631);
}
        }

[StructLayout(LayoutKind.Sequential)]
        internal struct CERT_CONTEXT
        {

public int dwCertEncodingType;

public IntPtr pbCertEncoded;

public int cbCertEncoded;

public IntPtr pCertInfo;

public IntPtr hCertStore;
static CERT_CONTEXT(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,25643,25942);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,25643,25942);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,25643,25942);
}
        }

[DllImport("crypt32.dll", EntryPoint = "CryptFindOIDInfo")]
        internal static extern IntPtr CryptFindOIDInfo(
            uint dwKeyType,
            System.IntPtr pvKey,
            uint dwGroupId);

[ArchitectureSensitive]
        internal static DWORD GetCertChoiceFromSigningOption(
            SigningOption option)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,26229,27157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,26375,26388);

DWORD 
cc = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,26404,27120);

switch (option)
            {

case SigningOption.AddOnlyCertificate:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,26404,27120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,26512,26519);

cc = 0;
DynAbs.Tracing.TraceSender.TraceBreak(1225,26541,26547);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,26404,27120);

case SigningOption.AddFullCertificateChain:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,26404,27120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,26632,26708);

cc = (DWORD)SignInfoAdditionalCertChoice.CRYPTUI_WIZ_DIGITAL_SIGN_ADD_CHAIN;
DynAbs.Tracing.TraceSender.TraceBreak(1225,26730,26736);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,26404,27120);

case SigningOption.AddFullCertificateChainExceptRoot:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,26404,27120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,26831,26915);

cc = (DWORD)SignInfoAdditionalCertChoice.CRYPTUI_WIZ_DIGITAL_SIGN_ADD_CHAIN_NO_ROOT;
DynAbs.Tracing.TraceSender.TraceBreak(1225,26937,26943);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,26404,27120);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,26404,27120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,26993,27077);

cc = (DWORD)SignInfoAdditionalCertChoice.CRYPTUI_WIZ_DIGITAL_SIGN_ADD_CHAIN_NO_ROOT;
DynAbs.Tracing.TraceSender.TraceBreak(1225,27099,27105);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,26404,27120);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27136,27146);

return cc;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,26229,27157);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,26229,27157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,26229,27157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        internal static CRYPTUI_WIZ_DIGITAL_SIGN_INFO
            InitSignInfoStruct(string fileName,
                               X509Certificate2 signingCert,
                               string timeStampServerUrl,
                               string hashAlgorithm,
                               SigningOption option)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,27169,28480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27550,27621);

CRYPTUI_WIZ_DIGITAL_SIGN_INFO 
si = f_1225_27585_27620()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27637,27675);

si.dwSize = (DWORD)f_1225_27656_27674(si);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27689,27777);

si.dwSubjectChoice = (DWORD)SignInfoSubjectChoice.CRYPTUI_WIZ_DIGITAL_SIGN_SUBJECT_FILE;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27791,27818);

si.pwszFileName = fileName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27832,27913);

si.dwSigningCertChoice = (DWORD)SignInfoCertChoice.CRYPTUI_WIZ_DIGITAL_SIGN_CERT;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27927,27971);

si.pSigningCertContext = f_1225_27952_27970(signingCert);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,27985,28026);

si.pwszTimestampURL = timeStampServerUrl;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,28040,28107);

si.dwAdditionalCertChoice = f_1225_28068_28106(option);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,28123,28256);

CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO 
siex =
f_1225_28186_28255(string.Empty, string.Empty, hashAlgorithm)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,28270,28336);

IntPtr 
pSiexBuffer = f_1225_28291_28335(f_1225_28314_28334(siex))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,28350,28399);

f_1225_28350_28398(siex, pSiexBuffer, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,28413,28443);

si.pSignExtInfo = pSiexBuffer;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,28459,28469);

return si;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,27169,28480);

System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO
f_1225_27585_27620()
{
var return_v = new System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 27585, 27620);
return return_v;
}


int
f_1225_27656_27674(System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 27656, 27674);
return return_v;
}


System.IntPtr
f_1225_27952_27970(System.Security.Cryptography.X509Certificates.X509Certificate2
this_param)
{
var return_v = this_param.Handle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1225, 27952, 27970);
return return_v;
}


uint
f_1225_28068_28106(System.Management.Automation.SigningOption
option)
{
var return_v = GetCertChoiceFromSigningOption( option);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 28068, 28106);
return return_v;
}


System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO
f_1225_28186_28255(string
description,string
moreInfoUrl,string
hashAlgorithm)
{
var return_v = InitSignInfoExtendedStruct( description, moreInfoUrl, hashAlgorithm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 28186, 28255);
return return_v;
}


int
f_1225_28314_28334(System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 28314, 28334);
return return_v;
}


System.IntPtr
f_1225_28291_28335(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 28291, 28335);
return return_v;
}


int
f_1225_28350_28398(System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 28350, 28398);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,27169,28480);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,27169,28480);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[DllImport("wintrust.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
        DWORD WinVerifyTrust(
            IntPtr hWndNotUsed, // HWND
            IntPtr pgActionID, // GUID*
            IntPtr pWinTrustData // WINTRUST_DATA*
        );

[StructLayout(LayoutKind.Sequential)]
        internal struct WINTRUST_FILE_INFO
        {

internal DWORD cbStruct;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pcwszFilePath;

internal IntPtr hFileNotUsed;

internal IntPtr pgKnownSubjectNotUsed;
static WINTRUST_FILE_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,29007,29556);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,29007,29556);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,29007,29556);
}
                                                   // subject type is known
        };

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct WINTRUST_BLOB_INFO
        {

internal uint cbStruct;

internal GUID gSubject;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
            internal string pcwszDisplayName;

internal uint cbMemObject;

internal System.IntPtr pbMemObject;

internal uint cbMemSignedMsg;

internal System.IntPtr pbMemSignedMsg;
static WINTRUST_BLOB_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,29568,30272);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,29568,30272);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,29568,30272);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        internal struct GUID
        {

internal uint Data1;

internal ushort Data2;

internal ushort Data3;

[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            internal byte[] Data4;
static GUID(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,30284,30748);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,30284,30748);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,30284,30748);
}
        }

[ArchitectureSensitive]
        internal static WINTRUST_FILE_INFO InitWintrustFileInfoStruct(string fileName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,30760,31177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,30896,30945);

WINTRUST_FILE_INFO 
fi = f_1225_30920_30944()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,30961,31001);

fi.cbStruct = (DWORD)f_1225_30982_31000(fi);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31015,31043);

fi.pcwszFilePath = fileName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31057,31087);

fi.hFileNotUsed = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31101,31140);

fi.pgKnownSubjectNotUsed = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31156,31166);

return fi;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,30760,31177);

System.Management.Automation.Security.NativeMethods.WINTRUST_FILE_INFO
f_1225_30920_30944()
{
var return_v = new System.Management.Automation.Security.NativeMethods.WINTRUST_FILE_INFO();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 30920, 30944);
return return_v;
}


int
f_1225_30982_31000(System.Management.Automation.Security.NativeMethods.WINTRUST_FILE_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 30982, 31000);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,30760,31177);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,30760,31177);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        internal static WINTRUST_BLOB_INFO InitWintrustBlobInfoStruct(string fileName, string content)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,31189,32096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31341,31390);

WINTRUST_BLOB_INFO 
bi = f_1225_31365_31389()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31404,31473);

byte[] 
contentBytes = f_1225_31426_31472(f_1225_31426_31454(), content)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31536,31567);

bi.gSubject.Data1 = 0x603bcc1f;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31581,31608);

bi.gSubject.Data2 = 0x4b59;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31622,31649);

bi.gSubject.Data3 = 0x4e08;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31663,31745);

bi.gSubject.Data4 = new byte[] { 0xb7, 0x24, 0xd2, 0xc6, 0x29, 0x7e, 0xf3, 0x51 };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31761,31801);

bi.cbStruct = (DWORD)f_1225_31782_31800(bi);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31815,31846);

bi.pcwszDisplayName = fileName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31860,31903);

bi.cbMemObject = (uint)f_1225_31883_31902(contentBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31917,31978);

bi.pbMemObject = f_1225_31934_31977(f_1225_31957_31976(contentBytes));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,31992,32059);

f_1225_31992_32058(contentBytes, 0, bi.pbMemObject, f_1225_32038_32057(contentBytes));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,32075,32085);

return bi;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,31189,32096);

System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
f_1225_31365_31389()
{
var return_v = new System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 31365, 31389);
return return_v;
}


System.Text.Encoding
f_1225_31426_31454()
{
var return_v = System.Text.Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1225, 31426, 31454);
return return_v;
}


byte[]
f_1225_31426_31472(System.Text.Encoding
this_param,string
s)
{
var return_v = this_param.GetBytes( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 31426, 31472);
return return_v;
}


int
f_1225_31782_31800(System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 31782, 31800);
return return_v;
}


int
f_1225_31883_31902(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1225, 31883, 31902);
return return_v;
}


int
f_1225_31957_31976(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1225, 31957, 31976);
return return_v;
}


System.IntPtr
f_1225_31934_31977(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 31934, 31977);
return return_v;
}


int
f_1225_32038_32057(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1225, 32038, 32057);
return return_v;
}


int
f_1225_31992_32058(byte[]
source,int
startIndex,System.IntPtr
destination,int
length)
{
Marshal.Copy( source, startIndex, destination, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 31992, 32058);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,31189,32096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,31189,32096);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        [Flags]
        internal enum WintrustUIChoice
        {
            WTD_UI_ALL = 1,
            WTD_UI_NONE = 2,
            WTD_UI_NOBAD = 3,
            WTD_UI_NOGOOD = 4
        };

        [Flags]
        internal enum WintrustUnionChoice
        {
            WTD_CHOICE_FILE = 1,
            // WTD_CHOICE_CATALOG = 2,
            WTD_CHOICE_BLOB = 3,
            // WTD_CHOICE_SIGNER = 4,
            // WTD_CHOICE_CERT = 5,
        };

        [Flags]
        internal enum WintrustProviderFlags
        {
            WTD_PROV_FLAGS_MASK = 0x0000FFFF,
            WTD_USE_IE4_TRUST_FLAG = 0x00000001,
            WTD_NO_IE4_CHAIN_FLAG = 0x00000002,
            WTD_NO_POLICY_USAGE_FLAG = 0x00000004,
            WTD_REVOCATION_CHECK_NONE = 0x00000010,
            WTD_REVOCATION_CHECK_END_CERT = 0x00000020,
            WTD_REVOCATION_CHECK_CHAIN = 0x00000040,
            WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000080,
            WTD_SAFER_FLAG = 0x00000100,
            WTD_HASH_ONLY_FLAG = 0x00000200,
            WTD_USE_DEFAULT_OSVER_CHECK = 0x00000400,
            WTD_LIFETIME_SIGNING_FLAG = 0x00000800,
            WTD_CACHE_ONLY_URL_RETRIEVAL = 0x00001000
        };

        [Flags]
        internal enum WintrustAction
        {
            WTD_STATEACTION_IGNORE = 0x00000000,
            WTD_STATEACTION_VERIFY = 0x00000001,
            WTD_STATEACTION_CLOSE = 0x00000002,
            WTD_STATEACTION_AUTO_CACHE = 0x00000003,
            WTD_STATEACTION_AUTO_CACHE_FLUSH = 0x00000004
        };

[StructLayoutAttribute(LayoutKind.Explicit)]
        internal struct WinTrust_Choice
        {

[FieldOffsetAttribute(0)]
            internal System.IntPtr pFile;

[FieldOffsetAttribute(0)]
            internal System.IntPtr pCatalog;

[FieldOffsetAttribute(0)]
            internal System.IntPtr pBlob;

[FieldOffsetAttribute(0)]
            internal System.IntPtr pSgnr;

[FieldOffsetAttribute(0)]
            internal System.IntPtr pCert;
static WinTrust_Choice(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,33689,34410);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,33689,34410);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,33689,34410);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct WINTRUST_DATA
        {

internal uint cbStruct;

internal System.IntPtr pPolicyCallbackData;

internal System.IntPtr pSIPClientData;

internal uint dwUIChoice;

internal uint fdwRevocationChecks;

internal uint dwUnionChoice;

internal WinTrust_Choice Choice;

internal uint dwStateAction;

internal System.IntPtr hWVTStateData;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
            internal string pwszURLReference;

internal uint dwProvFlags;

internal uint dwUIContext;
static WINTRUST_DATA(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,34422,35564);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,34422,35564);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,34422,35564);
}
        }

[ArchitectureSensitive]
        internal static WINTRUST_DATA InitWintrustDataStructFromFile(WINTRUST_FILE_INFO wfi)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,35576,36530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,35718,35758);

WINTRUST_DATA 
wtd = f_1225_35738_35757()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,35774,35816);

wtd.cbStruct = (DWORD)f_1225_35796_35815(wtd);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,35830,35868);

wtd.pPolicyCallbackData = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,35882,35915);

wtd.pSIPClientData = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,35929,35982);

wtd.dwUIChoice = (DWORD)WintrustUIChoice.WTD_UI_NONE;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,35996,36024);

wtd.fdwRevocationChecks = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36038,36101);

wtd.dwUnionChoice = (DWORD)WintrustUnionChoice.WTD_CHOICE_FILE;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36117,36182);

IntPtr 
pFileBuffer = f_1225_36138_36181(f_1225_36161_36180(wfi))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36196,36244);

f_1225_36196_36243(wfi, pFileBuffer, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36258,36289);

wtd.Choice.pFile = pFileBuffer;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36305,36370);

wtd.dwStateAction = (DWORD)WintrustAction.WTD_STATEACTION_VERIFY;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36384,36416);

wtd.hWVTStateData = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36430,36458);

wtd.pwszURLReference = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36472,36492);

wtd.dwProvFlags = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36508,36519);

return wtd;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,35576,36530);

System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
f_1225_35738_35757()
{
var return_v = new System.Management.Automation.Security.NativeMethods.WINTRUST_DATA();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 35738, 35757);
return return_v;
}


int
f_1225_35796_35815(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 35796, 35815);
return return_v;
}


int
f_1225_36161_36180(System.Management.Automation.Security.NativeMethods.WINTRUST_FILE_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 36161, 36180);
return return_v;
}


System.IntPtr
f_1225_36138_36181(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 36138, 36181);
return return_v;
}


int
f_1225_36196_36243(System.Management.Automation.Security.NativeMethods.WINTRUST_FILE_INFO
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 36196, 36243);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,35576,36530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,35576,36530);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        internal static WINTRUST_DATA InitWintrustDataStructFromBlob(WINTRUST_BLOB_INFO wbi)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,36542,37478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36684,36724);

WINTRUST_DATA 
wtd = f_1225_36704_36723()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36740,36782);

wtd.cbStruct = (DWORD)f_1225_36762_36781(wbi);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36796,36834);

wtd.pPolicyCallbackData = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36848,36881);

wtd.pSIPClientData = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36895,36948);

wtd.dwUIChoice = (DWORD)WintrustUIChoice.WTD_UI_NONE;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,36962,36990);

wtd.fdwRevocationChecks = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37004,37067);

wtd.dwUnionChoice = (DWORD)WintrustUnionChoice.WTD_CHOICE_BLOB;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37083,37142);

IntPtr 
pBlob = f_1225_37098_37141(f_1225_37121_37140(wbi))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37156,37198);

f_1225_37156_37197(wbi, pBlob, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37212,37237);

wtd.Choice.pBlob = pBlob;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37253,37318);

wtd.dwStateAction = (DWORD)WintrustAction.WTD_STATEACTION_VERIFY;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37332,37364);

wtd.hWVTStateData = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37378,37406);

wtd.pwszURLReference = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37420,37440);

wtd.dwProvFlags = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37456,37467);

return wtd;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,36542,37478);

System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
f_1225_36704_36723()
{
var return_v = new System.Management.Automation.Security.NativeMethods.WINTRUST_DATA();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 36704, 36723);
return return_v;
}


int
f_1225_36762_36781(System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 36762, 36781);
return return_v;
}


int
f_1225_37121_37140(System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 37121, 37140);
return return_v;
}


System.IntPtr
f_1225_37098_37141(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 37098, 37141);
return return_v;
}


int
f_1225_37156_37197(System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 37156, 37197);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,36542,37478);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,36542,37478);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        internal static DWORD DestroyWintrustDataStruct(WINTRUST_DATA wtd)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,37490,40029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37614,37650);

DWORD 
dwResult = Win32Errors.E_FAIL
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37664,37719);

IntPtr 
WINTRUST_ACTION_GENERIC_VERIFY_V2 = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37733,37764);

IntPtr 
wtdBuffer = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37780,37866);

Guid 
actionVerify =
f_1225_37817_37865("00AAC56B-CD44-11d0-8CC2-00C04FC295EE")
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,37918,38028);

WINTRUST_ACTION_GENERIC_VERIFY_V2 =
f_1225_37975_38027(f_1225_37998_38026(actionVerify));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,38046,38205);

f_1225_38046_38204(actionVerify, WINTRUST_ACTION_GENERIC_VERIFY_V2, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,38225,38289);

wtd.dwStateAction = (DWORD)WintrustAction.WTD_STATEACTION_CLOSE;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,38307,38363);

wtdBuffer = f_1225_38319_38362(f_1225_38342_38361(wtd));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,38381,38427);

f_1225_38381_38426(wtd, wtdBuffer, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,38610,38759);

dwResult = f_1225_38621_38758(IntPtr.Zero, WINTRUST_ACTION_GENERIC_VERIFY_V2, wtdBuffer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,38810,38865);

wtd = f_1225_38816_38864(wtdBuffer);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1225,38894,39210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,38934,38985);

f_1225_38934_38984(wtdBuffer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39003,39036);

f_1225_39003_39035(wtdBuffer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39054,39120);

f_1225_39054_39119(WINTRUST_ACTION_GENERIC_VERIFY_V2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39138,39195);

f_1225_39138_39194(WINTRUST_ACTION_GENERIC_VERIFY_V2);
DynAbs.Tracing.TraceSender.TraceExitFinally(1225,38894,39210);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39340,39986) || true) && (wtd.dwUnionChoice == (DWORD)WintrustUnionChoice.WTD_CHOICE_BLOB)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,39340,39986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39441,39577);

WINTRUST_BLOB_INFO 
originalBlob =
                    (WINTRUST_BLOB_INFO)f_1225_39516_39576(wtd.Choice.pBlob)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39595,39643);

f_1225_39595_39642(originalBlob.pbMemObject);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39663,39726);

f_1225_39663_39725(wtd.Choice.pBlob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39744,39784);

f_1225_39744_39783(wtd.Choice.pBlob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,39340,39986);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,39340,39986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39850,39913);

f_1225_39850_39912(wtd.Choice.pFile);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,39931,39971);

f_1225_39931_39970(wtd.Choice.pFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,39340,39986);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,40002,40018);

return dwResult;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,37490,40029);

System.Guid
f_1225_37817_37865(string
g)
{
var return_v = new System.Guid( g);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 37817, 37865);
return return_v;
}


int
f_1225_37998_38026(System.Guid
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 37998, 38026);
return return_v;
}


System.IntPtr
f_1225_37975_38027(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 37975, 38027);
return return_v;
}


int
f_1225_38046_38204(System.Guid
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 38046, 38204);
return 0;
}


int
f_1225_38342_38361(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 38342, 38361);
return return_v;
}


System.IntPtr
f_1225_38319_38362(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 38319, 38362);
return return_v;
}


int
f_1225_38381_38426(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 38381, 38426);
return 0;
}


uint
f_1225_38621_38758(System.IntPtr
hWndNotUsed,System.IntPtr
pgActionID,System.IntPtr
pWinTrustData)
{
var return_v = WinVerifyTrust( hWndNotUsed, pgActionID, pWinTrustData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 38621, 38758);
return return_v;
}


System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
f_1225_38816_38864(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStructure<WINTRUST_DATA>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 38816, 38864);
return return_v;
}


int
f_1225_38934_38984(System.IntPtr
ptr)
{
Marshal.DestroyStructure<WINTRUST_DATA>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 38934, 38984);
return 0;
}


int
f_1225_39003_39035(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39003, 39035);
return 0;
}


int
f_1225_39054_39119(System.IntPtr
ptr)
{
Marshal.DestroyStructure<Guid>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39054, 39119);
return 0;
}


int
f_1225_39138_39194(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39138, 39194);
return 0;
}


System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
f_1225_39516_39576(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStructure<WINTRUST_BLOB_INFO>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39516, 39576);
return return_v;
}


int
f_1225_39595_39642(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39595, 39642);
return 0;
}


int
f_1225_39663_39725(System.IntPtr
ptr)
{
Marshal.DestroyStructure<WINTRUST_BLOB_INFO>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39663, 39725);
return 0;
}


int
f_1225_39744_39783(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39744, 39783);
return 0;
}


int
f_1225_39850_39912(System.IntPtr
ptr)
{
Marshal.DestroyStructure<WINTRUST_FILE_INFO>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39850, 39912);
return 0;
}


int
f_1225_39931_39970(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 39931, 39970);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,37490,40029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,37490,40029);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_PROVIDER_CERT
        {

private DWORD _cbStruct;

internal IntPtr pCert;

private BOOL _fCommercial;

private BOOL _fTrustedRoot;

private BOOL _fSelfSigned;

private BOOL _fTestCert;

private DWORD _dwRevokedReason;

private DWORD _dwConfidence;

private DWORD _dwError;

private IntPtr _pTrustListContext;

private BOOL _fTrustListSignerCert;

private IntPtr _pCtlContext;

private DWORD _dwCtlError;

private BOOL _fIsCyclic;

private IntPtr _pChainElement;
static CRYPT_PROVIDER_CERT(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,40041,40838);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,40041,40838);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,40041,40838);
}
        };

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_PROVIDER_SGNR
        {

private DWORD _cbStruct;

private FILETIME _sftVerifyAsOf;

private DWORD _csCertChain;

private IntPtr _pasCertChain;

private DWORD _dwSignerType;

private IntPtr _psSigner;

private DWORD _dwError;

internal DWORD csCounterSigners;

internal IntPtr pasCounterSigners;

private IntPtr _pChainContext;
static CRYPT_PROVIDER_SGNR(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,40850,41472);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,40850,41472);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,40850,41472);
}
        };

[DllImport("wintrust.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
            IntPtr // CRYPT_PROVIDER_DATA*
            WTHelperProvDataFromStateData(IntPtr hStateData);

[DllImport("wintrust.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
            IntPtr // CRYPT_PROVIDER_SGNR*
            WTHelperGetProvSignerFromChain(
                IntPtr pProvData, // CRYPT_PROVIDER_DATA*
                DWORD idxSigner,
                BOOL fCounterSigner,
                DWORD idxCounterSigner
            );

[DllImport("wintrust.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern
            IntPtr // CRYPT_PROVIDER_CERT*
            WTHelperGetProvCertFromChain(
                IntPtr pSgnr, // CRYPT_PROVIDER_SGNR*
                DWORD idxCert
            );

[DllImportAttribute("wintrust.dll", EntryPoint = "WTGetSignatureInfo", CallingConvention = CallingConvention.StdCall)]
        internal static extern int WTGetSignatureInfo([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pszFile, [InAttribute()] System.IntPtr hFile, SIGNATURE_INFO_FLAGS sigInfoFlags, ref SIGNATURE_INFO psiginfo, ref System.IntPtr ppCertContext, ref System.IntPtr phWVTStateData);

internal static void FreeWVTStateData(System.IntPtr phWVTStateData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,43159,45150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43251,43291);

WINTRUST_DATA 
wtd = f_1225_43271_43290()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43305,43341);

DWORD 
dwResult = Win32Errors.E_FAIL
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43355,43410);

IntPtr 
WINTRUST_ACTION_GENERIC_VERIFY_V2 = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43424,43455);

IntPtr 
wtdBuffer = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43471,43557);

Guid 
actionVerify =
f_1225_43508_43556("00AAC56B-CD44-11d0-8CC2-00C04FC295EE")
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43609,43719);

WINTRUST_ACTION_GENERIC_VERIFY_V2 =
f_1225_43666_43718(f_1225_43689_43717(actionVerify));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43737,43896);

f_1225_43737_43895(actionVerify, WINTRUST_ACTION_GENERIC_VERIFY_V2, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43916,43958);

wtd.cbStruct = (DWORD)f_1225_43938_43957(wtd);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,43976,44029);

wtd.dwUIChoice = (DWORD)WintrustUIChoice.WTD_UI_NONE;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44047,44075);

wtd.fdwRevocationChecks = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44093,44156);

wtd.dwUnionChoice = (DWORD)WintrustUnionChoice.WTD_CHOICE_BLOB;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44174,44238);

wtd.dwStateAction = (DWORD)WintrustAction.WTD_STATEACTION_CLOSE;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44256,44291);

wtd.hWVTStateData = phWVTStateData;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44311,44367);

wtdBuffer = f_1225_44323_44366(f_1225_44346_44365(wtd));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44385,44431);

f_1225_44385_44430(wtd, wtdBuffer, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44614,44763);

dwResult = f_1225_44625_44762(IntPtr.Zero, WINTRUST_ACTION_GENERIC_VERIFY_V2, wtdBuffer);
#pragma warning restore 56523
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1225,44823,45139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44863,44914);

f_1225_44863_44913(wtdBuffer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44932,44965);

f_1225_44932_44964(wtdBuffer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,44983,45049);

f_1225_44983_45048(WINTRUST_ACTION_GENERIC_VERIFY_V2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,45067,45124);

f_1225_45067_45123(WINTRUST_ACTION_GENERIC_VERIFY_V2);
DynAbs.Tracing.TraceSender.TraceExitFinally(1225,44823,45139);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,43159,45150);

System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
f_1225_43271_43290()
{
var return_v = new System.Management.Automation.Security.NativeMethods.WINTRUST_DATA();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 43271, 43290);
return return_v;
}


System.Guid
f_1225_43508_43556(string
g)
{
var return_v = new System.Guid( g);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 43508, 43556);
return return_v;
}


int
f_1225_43689_43717(System.Guid
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 43689, 43717);
return return_v;
}


System.IntPtr
f_1225_43666_43718(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 43666, 43718);
return return_v;
}


int
f_1225_43737_43895(System.Guid
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 43737, 43895);
return 0;
}


int
f_1225_43938_43957(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 43938, 43957);
return return_v;
}


int
f_1225_44346_44365(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 44346, 44365);
return return_v;
}


System.IntPtr
f_1225_44323_44366(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 44323, 44366);
return return_v;
}


int
f_1225_44385_44430(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 44385, 44430);
return 0;
}


uint
f_1225_44625_44762(System.IntPtr
hWndNotUsed,System.IntPtr
pgActionID,System.IntPtr
pWinTrustData)
{
var return_v = WinVerifyTrust( hWndNotUsed, pgActionID, pWinTrustData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 44625, 44762);
return return_v;
}


int
f_1225_44863_44913(System.IntPtr
ptr)
{
Marshal.DestroyStructure<WINTRUST_DATA>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 44863, 44913);
return 0;
}


int
f_1225_44932_44964(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 44932, 44964);
return 0;
}


int
f_1225_44983_45048(System.IntPtr
ptr)
{
Marshal.DestroyStructure<Guid>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 44983, 45048);
return 0;
}


int
f_1225_45067_45123(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 45067, 45123);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,43159,45150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,43159,45150);
}
		}

[StructLayout(LayoutKind.Sequential)]
        internal struct CERT_ENHKEY_USAGE
        {

internal DWORD cUsageIdentifier;

internal IntPtr rgpszUsageIdentifier;
static CERT_ENHKEY_USAGE(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,45243,45612);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,45243,45612);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,45243,45612);
}
        };

        internal enum SIGNATURE_STATE
        {
            /// SIGNATURE_STATE_UNSIGNED_MISSING -> 0
            SIGNATURE_STATE_UNSIGNED_MISSING = 0,

            SIGNATURE_STATE_UNSIGNED_UNSUPPORTED,

            SIGNATURE_STATE_UNSIGNED_POLICY,

            SIGNATURE_STATE_INVALID_CORRUPT,

            SIGNATURE_STATE_INVALID_POLICY,

            SIGNATURE_STATE_VALID,

            SIGNATURE_STATE_TRUSTED,

            SIGNATURE_STATE_UNTRUSTED,
        }

        internal enum SIGNATURE_INFO_FLAGS
        {
            /// SIF_NONE -> 0x0000
            SIF_NONE = 0,

            /// SIF_AUTHENTICODE_SIGNED -> 0x0001
            SIF_AUTHENTICODE_SIGNED = 1,

            /// SIF_CATALOG_SIGNED -> 0x0002
            SIF_CATALOG_SIGNED = 2,

            /// SIF_VERSION_INFO -> 0x0004
            SIF_VERSION_INFO = 4,

            /// SIF_CHECK_OS_BINARY -> 0x0800
            SIF_CHECK_OS_BINARY = 2048,

            /// SIF_BASE_VERIFICATION -> 0x1000
            SIF_BASE_VERIFICATION = 4096,

            /// SIF_CATALOG_FIRST -> 0x2000
            SIF_CATALOG_FIRST = 8192,

            /// SIF_MOTW -> 0x4000
            SIF_MOTW = 16384,
        }

        internal enum SIGNATURE_INFO_AVAILABILITY
        {
            /// SIA_DISPLAYNAME -> 0x0001
            SIA_DISPLAYNAME = 1,

            /// SIA_PUBLISHERNAME -> 0x0002
            SIA_PUBLISHERNAME = 2,

            /// SIA_MOREINFOURL -> 0x0004
            SIA_MOREINFOURL = 4,

            /// SIA_HASH -> 0x0008
            SIA_HASH = 8,
        }

        internal enum SIGNATURE_INFO_TYPE
        {
            /// SIT_UNKNOWN -> 0
            SIT_UNKNOWN = 0,

            SIT_AUTHENTICODE,

            SIT_CATALOG,
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct SIGNATURE_INFO
        {

internal uint cbSize;

internal SIGNATURE_STATE nSignatureState;

internal SIGNATURE_INFO_TYPE nSignatureType;

internal uint dwSignatureInfoAvailability;

internal uint dwInfoAvailability;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
            internal string pszDisplayName;

internal uint cchDisplayName;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
            internal string pszPublisherName;

internal uint cchPublisherName;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
            internal string pszMoreInfoURL;

internal uint cchMoreInfoURL;

internal System.IntPtr prgbHash;

internal uint cbHash;

internal int fOSBinary;
static SIGNATURE_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,47411,48926);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,47411,48926);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,47411,48926);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct CERT_INFO
        {

internal uint dwVersion;

internal CRYPT_ATTR_BLOB SerialNumber;

internal CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

internal CRYPT_ATTR_BLOB Issuer;

internal FILETIME NotBefore;

internal FILETIME NotAfter;

internal CRYPT_ATTR_BLOB Subject;

internal CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

internal CRYPT_BIT_BLOB IssuerUniqueId;

internal CRYPT_BIT_BLOB SubjectUniqueId;

internal uint cExtension;

internal System.IntPtr rgExtension;
static CERT_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,48938,50240);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,48938,50240);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,48938,50240);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct CRYPT_ALGORITHM_IDENTIFIER
        {

[MarshalAsAttribute(UnmanagedType.LPStr)]
            internal string pszObjId;

internal CRYPT_ATTR_BLOB Parameters;
static CRYPT_ALGORITHM_IDENTIFIER(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,50252,50599);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,50252,50599);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,50252,50599);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct FILETIME
        {

internal uint dwLowDateTime;

internal uint dwHighDateTime;
static FILETIME(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,50611,50874);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,50611,50874);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,50611,50874);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct CERT_PUBLIC_KEY_INFO
        {

internal CRYPT_ALGORITHM_IDENTIFIER Algorithm;

internal CRYPT_BIT_BLOB PublicKey;
static CERT_PUBLIC_KEY_INFO(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,50886,51232);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,50886,51232);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,50886,51232);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct CRYPT_BIT_BLOB
        {

internal uint cbData;

internal System.IntPtr pbData;

internal uint cUnusedBits;
static CRYPT_BIT_BLOB(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,51244,51572);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,51244,51572);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,51244,51572);
}
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct CERT_EXTENSION
        {

[MarshalAsAttribute(UnmanagedType.LPStr)]
            internal string pszObjId;

internal int fCritical;

internal CRYPT_ATTR_BLOB Value;
static CERT_EXTENSION(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,51584,51980);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,51584,51980);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,51584,51980);
}
        }

static NativeMethods()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,4282,51987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,15935,15980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,52155,52201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,52231,52274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,52304,52350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58148,58165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58196,58218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58251,58269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58300,58337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58370,58386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58419,58458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58491,58531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58562,58584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58617,58646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58677,58701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58732,58758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58789,58809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58840,58867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58898,58930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,58961,58989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,59020,59049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,59080,59111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,59144,59188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,59219,59252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,59283,59316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,59347,59388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67319,67359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67390,67427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67458,67500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67531,67572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67603,67646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67677,67724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67755,67802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67833,67878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67909,67957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,67988,68030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,68061,68102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,68133,68178);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,4282,51987);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,4282,51987);
}

}
internal static partial class NativeMethods
{
internal const int 
CRYPT_E_NOT_FOUND = unchecked((int)0x80092004)
;

internal const int 
E_INVALID_DATA = unchecked((int)0x8007000d)
;

internal const int 
NTE_NOT_SUPPORTED = unchecked((int)0x80090029)
;

        internal enum AltNameType : uint
        {
            CERT_ALT_NAME_OTHER_NAME = 1,
            CERT_ALT_NAME_RFC822_NAME = 2,
            CERT_ALT_NAME_DNS_NAME = 3,
            CERT_ALT_NAME_X400_ADDRESS = 4,
            CERT_ALT_NAME_DIRECTORY_NAME = 5,
            CERT_ALT_NAME_EDI_PARTY_NAME = 6,
            CERT_ALT_NAME_URL = 7,
            CERT_ALT_NAME_IP_ADDRESS = 8,
            CERT_ALT_NAME_REGISTERED_ID = 9,
        }

        internal enum CryptDecodeFlags : uint
        {
            CRYPT_DECODE_ENABLE_PUNYCODE_FLAG = 0x02000000,
            CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG = 0x04000000,
            CRYPT_DECODE_ENABLE_IA5CONVERSION_FLAG = (CRYPT_DECODE_ENABLE_PUNYCODE_FLAG | CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG),
        }
}
internal static partial class NativeMethods
{
[DllImportAttribute("advapi32.dll", EntryPoint = "SaferIdentifyLevel", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        internal static extern bool SaferIdentifyLevel(
            uint dwNumProperties,
            [InAttribute()]
            ref SAFER_CODE_PROPERTIES pCodeProperties,
            out IntPtr pLevelHandle,
            [InAttribute()]
            [MarshalAsAttribute(UnmanagedType.LPWStr)]
            string bucket);

[DllImportAttribute("advapi32.dll", EntryPoint = "SaferComputeTokenFromLevel", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        internal static extern bool SaferComputeTokenFromLevel(
            [InAttribute()]
            IntPtr LevelHandle,
            [InAttribute()]
            System.IntPtr InAccessToken,
            ref System.IntPtr OutAccessToken,
            uint dwFlags,
            System.IntPtr lpReserved);

[DllImportAttribute("advapi32.dll", EntryPoint = "SaferCloseLevel")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        internal static extern bool SaferCloseLevel([InAttribute()] IntPtr hLevelHandle);

[DllImportAttribute(PinvokeDllNames.CloseHandleDllName, EntryPoint = "CloseHandle")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        internal static extern bool CloseHandle([InAttribute()] System.IntPtr hObject);
}

[StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct SAFER_CODE_PROPERTIES
    {

public uint cbSize;

public uint dwCheckFlags;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
        public string ImagePath;

public System.IntPtr hImageFileHandle;

public uint UrlZoneId;

[MarshalAsAttribute(
            UnmanagedType.ByValArray,
            SizeConst = NativeConstants.SAFER_MAX_HASH_SIZE,
            ArraySubType = UnmanagedType.I1)]
        public byte[] ImageHash;

public uint dwImageHashSize;

public LARGE_INTEGER ImageSize;

public uint HashAlgorithm;

public System.IntPtr pByteBlock;

public System.IntPtr hWndParent;

public uint dwWVTUIChoice;
static SAFER_CODE_PROPERTIES(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,55402,56595);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,55402,56595);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,55402,56595);
}
    }

[StructLayoutAttribute(LayoutKind.Explicit)]
    internal struct LARGE_INTEGER
    {

[FieldOffsetAttribute(0)]
        public Anonymous_9320654f_2227_43bf_a385_74cc8c562686 Struct1;

[FieldOffsetAttribute(0)]
        public Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9 u;

[FieldOffsetAttribute(0)]
        public long QuadPart;
static LARGE_INTEGER(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,56603,57125);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,56603,57125);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,56603,57125);
}
    }

[StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct HWND__
    {

public int unused;
static HWND__(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,57133,57266);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,57133,57266);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,57133,57266);
}
    }

[StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct Anonymous_9320654f_2227_43bf_a385_74cc8c562686
    {

public uint LowPart;

public int HighPart;
static Anonymous_9320654f_2227_43bf_a385_74cc8c562686(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,57274,57520);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,57274,57520);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,57274,57520);
}
    }

[StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9
    {

public uint LowPart;

public int HighPart;
static Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,57528,57774);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,57528,57774);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,57528,57774);
}
    }
internal static partial class NativeMethods
{
internal const uint 
ERROR_SUCCESS = 0
;

internal const uint 
ERROR_NO_TOKEN = 0x3f0
;

internal const uint 
STATUS_SUCCESS = 0
;

internal const uint 
STATUS_INVALID_PARAMETER = 0xC000000D
;

internal const uint 
ACL_REVISION = 2
;

internal const uint 
SYSTEM_SCOPED_POLICY_ID_ACE_TYPE = 0x13
;

internal const uint 
SUB_CONTAINERS_AND_OBJECTS_INHERIT = 0x3
;

internal const uint 
INHERIT_ONLY_ACE = 0x8
;

internal const uint 
TOKEN_ASSIGN_PRIMARY = 0x0001
;

internal const uint 
TOKEN_DUPLICATE = 0x0002
;

internal const uint 
TOKEN_IMPERSONATE = 0x0004
;

internal const uint 
TOKEN_QUERY = 0x0008
;

internal const uint 
TOKEN_QUERY_SOURCE = 0x0010
;

internal const uint 
TOKEN_ADJUST_PRIVILEGES = 0x0020
;

internal const uint 
TOKEN_ADJUST_GROUPS = 0x0040
;

internal const uint 
TOKEN_ADJUST_DEFAULT = 0x0080
;

internal const uint 
TOKEN_ADJUST_SESSIONID = 0x0100
;

internal const uint 
SE_PRIVILEGE_ENABLED_BY_DEFAULT = 0x00000001
;

internal const uint 
SE_PRIVILEGE_ENABLED = 0x00000002
;

internal const uint 
SE_PRIVILEGE_REMOVED = 0X00000004
;

internal const uint 
SE_PRIVILEGE_USED_FOR_ACCESS = 0x80000000
;

        internal enum SeObjectType : uint
        {
            SE_UNKNOWN_OBJECT_TYPE = 0,
            SE_FILE_OBJECT = 1,
            SE_SERVICE = 2,
            SE_PRINTER = 3,
            SE_REGISTRY_KEY = 4,
            SE_LMSHARE = 5,
            SE_KERNEL_OBJECT = 6,
            SE_WINDOW_OBJECT = 7,
            SE_DS_OBJECT = 8,
            SE_DS_OBJECT_ALL = 9,
            SE_PROVIDER_DEFINED_OBJECT = 10,
            SE_WMIGUID_OBJECT = 11,
            SE_REGISTRY_WOW64_32KEY = 12
        }

        internal enum SecurityInformation : uint
        {
            OWNER_SECURITY_INFORMATION = 0x00000001,
            GROUP_SECURITY_INFORMATION = 0x00000002,
            DACL_SECURITY_INFORMATION = 0x00000004,
            SACL_SECURITY_INFORMATION = 0x00000008,
            LABEL_SECURITY_INFORMATION = 0x00000010,
            ATTRIBUTE_SECURITY_INFORMATION = 0x00000020,
            SCOPE_SECURITY_INFORMATION = 0x00000040,
            BACKUP_SECURITY_INFORMATION = 0x00010000,
            PROTECTED_DACL_SECURITY_INFORMATION = 0x80000000,
            PROTECTED_SACL_SECURITY_INFORMATION = 0x40000000,
            UNPROTECTED_DACL_SECURITY_INFORMATION = 0x20000000,
            UNPROTECTED_SACL_SECURITY_INFORMATION = 0x10000000
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct LUID
        {

internal uint LowPart;

internal uint HighPart;
static LUID(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,60688,60877);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,60688,60877);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,60688,60877);
}
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct LUID_AND_ATTRIBUTES
        {

internal LUID Luid;

internal uint Attributes;
static LUID_AND_ATTRIBUTES(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,60889,61092);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,60889,61092);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,60889,61092);
}
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_PRIVILEGE
        {

internal uint PrivilegeCount;

internal LUID_AND_ATTRIBUTES Privilege;
static TOKEN_PRIVILEGE(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,61104,61327);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,61104,61327);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,61104,61327);
}
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct ACL
        {

internal byte AclRevision;

internal byte Sbz1;

internal ushort AclSize;

internal ushort AceCount;

internal ushort Sbz2;
static ACL(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,61339,61639);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,61339,61639);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,61339,61639);
}
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct ACE_HEADER
        {

internal byte AceType;

internal byte AceFlags;

internal ushort AceSize;
static ACE_HEADER(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,61651,61884);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,61651,61884);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,61651,61884);
}
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SYSTEM_AUDIT_ACE
        {

internal ACE_HEADER Header;

internal uint Mask;

internal uint SidStart;
static SYSTEM_AUDIT_ACE(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,61896,62135);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,61896,62135);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,61896,62135);
}
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct LSA_UNICODE_STRING
        {

internal ushort Length;

internal ushort MaximumLength;

internal IntPtr Buffer;
static LSA_UNICODE_STRING(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,62147,62395);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,62147,62395);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,62147,62395);
}
        }

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct CENTRAL_ACCESS_POLICY
        {

internal IntPtr CAPID;

internal LSA_UNICODE_STRING Name;

internal LSA_UNICODE_STRING Description;

internal LSA_UNICODE_STRING ChangeId;

internal uint Flags;

internal uint CAPECount;

internal IntPtr CAPEs;
static CENTRAL_ACCESS_POLICY(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,62407,62836);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,62407,62836);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,62407,62836);
}
        }

[DllImport(PinvokeDllNames.GetNamedSecurityInfoDllName, CharSet = CharSet.Unicode)]
        internal static extern uint GetNamedSecurityInfo(
            string pObjectName,
            SeObjectType ObjectType,
            SecurityInformation SecurityInfo,
            out IntPtr ppsidOwner,
            out IntPtr ppsidGroup,
            out IntPtr ppDacl,
            out IntPtr ppSacl,
            out IntPtr ppSecurityDescriptor
        );

[DllImport(PinvokeDllNames.SetNamedSecurityInfoDllName, CharSet = CharSet.Unicode)]
        internal static extern uint SetNamedSecurityInfo(
            string pObjectName,
            SeObjectType ObjectType,
            SecurityInformation SecurityInfo,
            IntPtr psidOwner,
            IntPtr psidGroup,
            IntPtr pDacl,
            IntPtr pSacl);

[DllImport(PinvokeDllNames.ConvertStringSidToSidDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ConvertStringSidToSid(
            string StringSid,
            out IntPtr Sid);

[DllImport(PinvokeDllNames.IsValidSidDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool IsValidSid(IntPtr pSid);

[DllImport(PinvokeDllNames.GetLengthSidDllName, CharSet = CharSet.Unicode)]
        internal static extern uint GetLengthSid(IntPtr pSid);

[DllImport("Advapi32.dll", CharSet = CharSet.Unicode)]
        internal static extern uint LsaQueryCAPs(
            IntPtr[] CAPIDs,
            uint CAPIDCount,
            out IntPtr CAPs,
            out uint CAPCount);

[DllImport(PinvokeDllNames.LsaFreeMemoryDllName, CharSet = CharSet.Unicode)]
        internal static extern uint LsaFreeMemory(IntPtr Buffer);

[DllImport(PinvokeDllNames.InitializeAclDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool InitializeAcl(
            IntPtr pAcl,
            uint nAclLength,
            uint dwAclRevision);

[DllImport("api-ms-win-security-base-l1-2-0.dll", CharSet = CharSet.Unicode)]
        internal static extern uint AddScopedPolicyIDAce(
            IntPtr Acl,
            uint AceRevision,
            uint AceFlags,
            uint AccessMask,
            IntPtr Sid);

[DllImport(PinvokeDllNames.GetCurrentProcessDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern IntPtr GetCurrentProcess();

[DllImport(PinvokeDllNames.GetCurrentThreadDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern IntPtr GetCurrentThread();

[DllImport(PinvokeDllNames.OpenProcessTokenDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool OpenProcessToken(
            IntPtr ProcessHandle,
            uint DesiredAccess,
            out IntPtr TokenHandle);

[DllImport(PinvokeDllNames.OpenThreadTokenDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool OpenThreadToken(
            IntPtr ThreadHandle,
            uint DesiredAccess,
            bool OpenAsSelf,
            out IntPtr TokenHandle);

[DllImport(PinvokeDllNames.LookupPrivilegeValueDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool LookupPrivilegeValue(
            string lpSystemName,
            string lpName,
            ref LUID lpLuid);

[DllImport(PinvokeDllNames.AdjustTokenPrivilegesDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AdjustTokenPrivileges(
            IntPtr TokenHandle,
            bool DisableAllPrivileges,
            ref TOKEN_PRIVILEGE NewState,
            uint BufferLength,
            ref TOKEN_PRIVILEGE PreviousState,
            ref uint ReturnLength);

[DllImport(PinvokeDllNames.LocalFreeDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern IntPtr LocalFree(IntPtr hMem);

internal const uint 
DONT_RESOLVE_DLL_REFERENCES = 0x00000001
;

internal const uint 
LOAD_LIBRARY_AS_DATAFILE = 0x00000002
;

internal const uint 
LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008
;

internal const uint 
LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010
;

internal const uint 
LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020
;

internal const uint 
LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040
;

internal const uint 
LOAD_LIBRARY_REQUIRE_SIGNED_TARGET = 0x00000080
;

internal const uint 
LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100
;

internal const uint 
LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200
;

internal const uint 
LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400
;

internal const uint 
LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800
;

internal const uint 
LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000
;

[DllImport(PinvokeDllNames.LoadLibraryEx, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern IntPtr LoadLibraryExW(
            string DllName,
            IntPtr reserved,
            uint Flags);

[DllImport(PinvokeDllNames.FreeLibrary, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool FreeLibrary(
            IntPtr Module);

internal static bool IsSystem32DllPresent(string DllName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1225,68661,69500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,68743,68766);

bool 
DllExists = false
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,68818,69217);

IntPtr 
module = f_1225_68834_69216(DllName, IntPtr.Zero, NativeMethods.LOAD_LIBRARY_AS_DATAFILE |
                                            NativeMethods.LOAD_LIBRARY_AS_IMAGE_RESOURCE |
                                            NativeMethods.LOAD_LIBRARY_SEARCH_SYSTEM32)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,69235,69380) || true) && (IntPtr.Zero != module)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1225,69235,69380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,69302,69322);

f_1225_69302_69321(module);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,69344,69361);

DllExists = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1225,69235,69380);
}
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1225,69409,69456);
DynAbs.Tracing.TraceSender.TraceExitCatch(1225,69409,69456);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1225,69472,69489);

return DllExists;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1225,68661,69500);

System.IntPtr
f_1225_68834_69216(string
DllName,System.IntPtr
reserved,uint
Flags)
{
var return_v = LoadLibraryExW( DllName, reserved, Flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 68834, 69216);
return return_v;
}


bool
f_1225_69302_69321(System.IntPtr
Module)
{
var return_v = FreeLibrary( Module);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1225, 69302, 69321);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1225,68661,69500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,68661,69500);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
internal partial class NativeConstants
{
public const int 
CRYPTCAT_E_AREA_HEADER = 0
;

public const int 
CRYPTCAT_E_AREA_MEMBER = 65536
;

public const int 
CRYPTCAT_E_AREA_ATTRIBUTE = 131072
;

public const int 
CRYPTCAT_E_CDF_UNSUPPORTED = 1
;

public const int 
CRYPTCAT_E_CDF_DUPLICATE = 2
;

public const int 
CRYPTCAT_E_CDF_TAGNOTFOUND = 4
;

public const int 
CRYPTCAT_E_CDF_MEMBER_FILE_PATH = 65537
;

public const int 
CRYPTCAT_E_CDF_MEMBER_INDIRECTDATA = 65538
;

public const int 
CRYPTCAT_E_CDF_MEMBER_FILENOTFOUND = 65540
;

public const int 
CRYPTCAT_E_CDF_BAD_GUID_CONV = 131073
;

public const int 
CRYPTCAT_E_CDF_ATTR_TOOFEWVALUES = 131074
;

public const int 
CRYPTCAT_E_CDF_ATTR_TYPECOMBO = 131076
;
}
internal static partial class NativeMethods
{
[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPT_ATTRIBUTE_TYPE_VALUE
        {

[MarshalAs(UnmanagedType.LPStr)]
            internal string pszObjId;

internal CRYPT_ATTR_BLOB Value;
static CRYPT_ATTRIBUTE_TYPE_VALUE(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,71297,71538);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,71297,71538);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,71297,71538);
}
        }

[StructLayout(LayoutKind.Sequential)]
        internal struct SIP_INDIRECT_DATA
        {

internal CRYPT_ATTRIBUTE_TYPE_VALUE Data;

internal CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;

internal CRYPT_ATTR_BLOB Digest;
static SIP_INDIRECT_DATA(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,71550,71819);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,71550,71819);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,71550,71819);
}
        }

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPTCATCDF
        {

private DWORD _cbStruct;

private IntPtr _hFile;

private DWORD _dwCurFilePos;

private DWORD _dwLastMemberOffset;

private BOOL _fEOF;

[MarshalAs(UnmanagedType.LPWStr)]
            private string _pwszResultDir;

private IntPtr _hCATStore;
static CRYPTCATCDF(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,71831,72256);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,71831,72256);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,71831,72256);
}
        };

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPTCATMEMBER
        {

internal DWORD cbStruct;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszReferenceTag;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszFileName;

internal GUID gSubjectType;

internal DWORD fdwMemberFlags;

internal IntPtr pIndirectData;

internal DWORD dwCertVersion;

internal DWORD dwReserved;

internal IntPtr hReserved;

internal CRYPT_ATTR_BLOB sEncodedIndirectData;

internal CRYPT_ATTR_BLOB sEncodedMemberInfo;
static CRYPTCATMEMBER(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,72268,72960);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,72268,72960);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,72268,72960);
}
        };

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPTCATATTRIBUTE
        {

private DWORD _cbStruct;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszReferenceTag;

private DWORD _dwAttrTypeAndAction;

internal DWORD cbValue;

internal System.IntPtr pbValue;

private DWORD _dwReserved;
static CRYPTCATATTRIBUTE(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,72972,73378);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,72972,73378);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,72972,73378);
}
        };

[StructLayout(LayoutKind.Sequential)]
        internal struct CRYPTCATSTORE
        {

private DWORD _cbStruct;

internal DWORD dwPublicVersion;

[MarshalAs(UnmanagedType.LPWStr)]
            internal string pwszP7File;

private IntPtr _hProv;

private DWORD _dwEncodingType;

private DWORD _fdwStoreFlags;

private IntPtr _hReserved;

private IntPtr _hAttrs;

private IntPtr _hCryptMsg;

private IntPtr _hSorted;
static CRYPTCATSTORE(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1225,73390,73938);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1225,73390,73938);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1225,73390,73938);
}
        };

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATCDFOpen(
            [MarshalAs(UnmanagedType.LPWStr)]
            string pwszFilePath,
            CryptCATCDFOpenCallBack pfnParseError
        );

[DllImport("wintrust.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CryptCATCDFClose(
            IntPtr pCDF
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATCDFEnumCatAttributes(
            IntPtr pCDF,
            IntPtr pPrevAttr,
            CryptCATCDFOpenCallBack pfnParseError
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATCDFEnumMembersByCDFTagEx(
            IntPtr pCDF,
            IntPtr pwszPrevCDFTag,
            CryptCATCDFEnumMembersByCDFTagExErrorCallBack fn,
            ref IntPtr ppMember,
            bool fContinueOnError,
            IntPtr pvReserved
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATCDFEnumAttributesWithCDFTag(
            IntPtr pCDF,
            IntPtr pwszMemberTag,
            IntPtr pMember,
            IntPtr pPrevAttr,
            CryptCATCDFEnumMembersByCDFTagExErrorCallBack fn
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATOpen(
            [MarshalAs(UnmanagedType.LPWStr)]
            string pwszFilePath,
            DWORD fdwOpenFlags,
            IntPtr hProv,
            DWORD dwPublicVersion,
            DWORD dwEncodingType
         );

[DllImport("wintrust.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CryptCATClose(
          IntPtr hCatalog
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATStoreFromHandle(
            IntPtr hCatalog
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CryptCATAdminAcquireContext2(
          ref IntPtr phCatAdmin,
          IntPtr pgSubsystem,
          [MarshalAs(UnmanagedType.LPWStr)]
          string pwszHashAlgorithm,
          IntPtr pStrongHashPolicy,
          DWORD dwFlags
      );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CryptCATAdminReleaseContext(
            IntPtr phCatAdmin,
            DWORD dwFlags
        );

[DllImport("kernel32", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern unsafe IntPtr CreateFile(
            string lpFileName,
            DWORD dwDesiredAccess,
            DWORD dwShareMode,
            DWORD lpSecurityAttributes,
            DWORD dwCreationDisposition,
            DWORD dwFlagsAndAttributes,
            IntPtr hTemplateFile
           );

[DllImport("wintrust.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CryptCATAdminCalcHashFromFileHandle2(
            IntPtr hCatAdmin,
            IntPtr hFile,
            [In, Out] ref DWORD pcbHash,
            IntPtr pbHash,
            DWORD dwFlags
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATEnumerateCatAttr(
            IntPtr hCatalog,
            IntPtr pPrevAttr
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATEnumerateMember(
                IntPtr hCatalog,
                IntPtr pPrevMember
        );

[DllImport("wintrust.dll", CharSet = CharSet.Unicode)]
        internal static extern IntPtr CryptCATEnumerateAttr(
            IntPtr hCatalog,
            IntPtr pCatMember,
            IntPtr pPrevAttr
        );

        /// <summary>
        /// Signature of call back function used by CryptCATCDFOpen.
        /// </summary>
        internal delegate
        void CryptCATCDFOpenCallBack(DWORD NotUsedDWORD1,
                                      DWORD NotUsedDWORD2,
                                      [MarshalAs(UnmanagedType.LPWStr)]
                                      string NotUsedString);

        /// <summary>
        /// Signature of call back function used by CryptCATCDFEnumMembersByCDFTagEx.
        /// </summary>
        internal delegate
        void CryptCATCDFEnumMembersByCDFTagExErrorCallBack(DWORD NotUsedDWORD1,
                                      DWORD NotUsedDWORD2,
                                      [MarshalAs(UnmanagedType.LPWStr)]
                                      string NotUsedString);
}
}

#pragma warning restore 56523
