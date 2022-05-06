// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56523

using Dbg = System.Management.Automation;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DWORD = System.UInt32;

namespace System.Management.Automation
{
    /// <summary>
    /// Defines the options that control what data is embedded in the
    /// signature blob.
    /// </summary>
    public enum SigningOption
    {
        /// <summary>
        /// Embeds only the signer's certificate.
        /// </summary>
        AddOnlyCertificate,

        /// <summary>
        /// Embeds the entire certificate chain.
        /// </summary>
        AddFullCertificateChain,

        /// <summary>
        /// Embeds the entire certificate chain, except for the root
        /// certificate.
        /// </summary>
        AddFullCertificateChainExceptRoot,

        /// <summary>
        /// Default: Embeds the entire certificate chain, except for the
        /// root certificate.
        /// </summary>
        Default = AddFullCertificateChainExceptRoot
    }
internal static class SignatureHelper
{
[Dbg.TraceSource("SignatureHelper",
                          "tracer for SignatureHelper")]
        private static readonly Dbg.PSTraceSource s_tracer ;

[ArchitectureSensitive]
        internal static Signature SignFile(SigningOption option,
                                           string fileName,
                                           X509Certificate2 certificate,
                                           string timeStampServerUrl,
                                           string hashAlgorithm)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,3476,10308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,3862,3882);

bool 
result = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,3896,3923);

Signature 
signature = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,3937,3968);

IntPtr 
pSignInfo = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,3982,3998);

DWORD 
error = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4012,4034);

string 
hashOid = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4050,4101);

f_1221_4050_4100(fileName, "fileName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4115,4165);

f_1221_4115_4164(certificate, "certificate");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4253,4691) || true) && (!f_1221_4258_4298(timeStampServerUrl))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,4253,4691);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4332,4676) || true) && ((f_1221_4337_4362(timeStampServerUrl)<= 7) ||(DynAbs.Tracing.TraceSender.Expression_False(1221, 4336, 4473)||                    (f_1221_4394_4467(timeStampServerUrl, "http://", StringComparison.OrdinalIgnoreCase)!= 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,4332,4676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4515,4657);

throw f_1221_4521_4656("certificate", f_1221_4622_4655());
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,4332,4676);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,4253,4691);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4765,5710) || true) && (!f_1221_4770_4805(hashAlgorithm))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,4765,5710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4839,4906);

IntPtr 
intptrAlgorithm = f_1221_4864_4905(hashAlgorithm)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,4926,5084);

IntPtr 
oidPtr = f_1221_4942_5083(NativeConstants.CRYPT_OID_INFO_NAME_KEY, intptrAlgorithm, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,5211,5695) || true) && (oidPtr == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,5211,5695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,5278,5420);

throw f_1221_5284_5419("certificate", f_1221_5385_5418());
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,5211,5695);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,5211,5695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,5502,5627);

NativeMethods.CRYPT_OID_INFO 
oidInfo =
f_1221_5566_5626(oidPtr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,5651,5676);

hashOid = oidInfo.pszOID;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,5211,5695);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,4765,5710);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,5726,5972) || true) && (!f_1221_5731_5780(certificate))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,5726,5972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,5814,5957);

throw f_1221_5820_5956("certificate", f_1221_5921_5955());
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,5726,5972);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,5988,6032);

f_1221_5988_6031(fileName);
            // SecurityUtils.CheckIfFileSmallerThan4Bytes(fileName);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,6398,6441);

string 
timeStampServerUrlForCryptUI = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,6459,6615) || true) && (!f_1221_6464_6504(timeStampServerUrl))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,6459,6615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,6546,6596);

timeStampServerUrlForCryptUI = timeStampServerUrl;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,6459,6615);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,6787,7191);

NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO 
si = f_1221_6836_7190(fileName, certificate, timeStampServerUrlForCryptUI, hashOid, option)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,7211,7266);

pSignInfo = f_1221_7223_7265(f_1221_7246_7264(si));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,7284,7329);

f_1221_7284_7328(si, pSignInfo, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,7586,7840);

result = f_1221_7595_7839(NativeMethods.CryptUIFlags.CRYPTUI_WIZ_NO_UI, IntPtr.Zero, IntPtr.Zero, pSignInfo, IntPtr.Zero);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,7891,8136) || true) && (si.pSignExtInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,7891,8136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,7960,8056);

f_1221_7960_8055(si.pSignExtInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,8078,8117);

f_1221_8078_8116(si.pSignExtInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,7891,8136);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,8156,9784) || true) && (!result)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,8156,9784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,8209,8237);

error = f_1221_8217_8236();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,8626,9765) || true) && ((error == 0x80004005) ||(DynAbs.Tracing.TraceSender.Expression_False(1221, 8630, 8701)||                        (error == 0x80070001) )||(DynAbs.Tracing.TraceSender.Expression_False(1221, 8630, 9135)||
                        // CryptUIWizDigitalSign introduced a breaking change in Win8 to return this
                        // error code (ERROR_INTERNET_NAME_NOT_RESOLVED) when you provide an invalid
                        // timestamp server. It used to be 0x80070001.
                        // Also masking this out so that we don't introduce a breaking change ourselves.
                        (error == 0x80072EE7)
))
                        )

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,8626,9765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,9211,9225);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,8626,9765);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,8626,9765);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,9323,9604) || true) && (error == Win32Errors.NTE_BAD_ALGID)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,9323,9604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,9419,9577);

throw f_1221_9425_9576("certificate", f_1221_9542_9575());
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,9323,9604);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,9632,9742);

f_1221_9632_9741(
                        s_tracer, "CryptUIWizDigitalSign: failed: {0:x}", error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,8626,9765);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,8156,9784);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,9804,10048) || true) && (result)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,9804,10048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,9856,9897);

signature = f_1221_9868_9896(fileName, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,9804,10048);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,9804,10048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,9979,10029);

signature = f_1221_9991_10028(fileName, (DWORD)error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,9804,10048);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1221,10077,10264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,10117,10198);

f_1221_10117_10197(pSignInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,10216,10249);

f_1221_10216_10248(pSignInfo);
DynAbs.Tracing.TraceSender.TraceExitFinally(1221,10077,10264);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,10280,10297);

return signature;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,3476,10308);

int
f_1221_4050_4100(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4050, 4100);
return 0;
}


int
f_1221_4115_4164(System.Security.Cryptography.X509Certificates.X509Certificate2
arg,string
argName)
{
Utils.CheckArgForNull( (object)arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4115, 4164);
return 0;
}


bool
f_1221_4258_4298(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4258, 4298);
return return_v;
}


int
f_1221_4337_4362(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 4337, 4362);
return return_v;
}


int
f_1221_4394_4467(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4394, 4467);
return return_v;
}


string
f_1221_4622_4655()
{
var return_v =                         Authenticode.TimeStampUrlRequired;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 4622, 4655);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1221_4521_4656(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4521, 4656);
return return_v;
}


bool
f_1221_4770_4805(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4770, 4805);
return return_v;
}


System.IntPtr
f_1221_4864_4905(string
s)
{
var return_v = Marshal.StringToHGlobalUni( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4864, 4905);
return return_v;
}


System.IntPtr
f_1221_4942_5083(int
dwKeyType,System.IntPtr
pvKey,int
dwGroupId)
{
var return_v = NativeMethods.CryptFindOIDInfo( (uint)dwKeyType, pvKey, (uint)dwGroupId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 4942, 5083);
return return_v;
}


string
f_1221_5385_5418()
{
var return_v =                         Authenticode.InvalidHashAlgorithm;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 5385, 5418);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1221_5284_5419(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 5284, 5419);
return return_v;
}


System.Management.Automation.Security.NativeMethods.CRYPT_OID_INFO
f_1221_5566_5626(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStructure<NativeMethods.CRYPT_OID_INFO>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 5566, 5626);
return return_v;
}


bool
f_1221_5731_5780(System.Security.Cryptography.X509Certificates.X509Certificate2
c)
{
var return_v = SecuritySupport.CertIsGoodForSigning( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 5731, 5780);
return return_v;
}


string
f_1221_5921_5955()
{
var return_v =                         Authenticode.CertNotGoodForSigning;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 5921, 5955);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1221_5820_5956(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 5820, 5956);
return return_v;
}


int
f_1221_5988_6031(string
filePath)
{
SecuritySupport.CheckIfFileExists( filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 5988, 6031);
return 0;
}


bool
f_1221_6464_6504(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 6464, 6504);
return return_v;
}


System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO
f_1221_6836_7190(string
fileName,System.Security.Cryptography.X509Certificates.X509Certificate2
signingCert,string
timeStampServerUrl,string
hashAlgorithm,System.Management.Automation.SigningOption
option)
{
var return_v = NativeMethods.InitSignInfoStruct( fileName, signingCert, timeStampServerUrl, hashAlgorithm, option);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 6836, 7190);
return return_v;
}


int
f_1221_7246_7264(System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 7246, 7264);
return return_v;
}


System.IntPtr
f_1221_7223_7265(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 7223, 7265);
return return_v;
}


int
f_1221_7284_7328(System.Management.Automation.Security.NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 7284, 7328);
return 0;
}


bool
f_1221_7595_7839(System.Management.Automation.Security.NativeMethods.CryptUIFlags
dwFlags,System.IntPtr
hwndParentNotUsed,System.IntPtr
pwszWizardTitleNotUsed,System.IntPtr
pDigitalSignInfo,System.IntPtr
ppSignContextNotUsed)
{
var return_v = NativeMethods.CryptUIWizDigitalSign( (uint)dwFlags, hwndParentNotUsed, pwszWizardTitleNotUsed, pDigitalSignInfo, ppSignContextNotUsed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 7595, 7839);
return return_v;
}


int
f_1221_7960_8055(System.IntPtr
ptr)
{
Marshal.DestroyStructure<NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_EXTENDED_INFO>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 7960, 8055);
return 0;
}


int
f_1221_8078_8116(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 8078, 8116);
return 0;
}


uint
f_1221_8217_8236()
{
var return_v = GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 8217, 8236);
return return_v;
}


string
f_1221_9542_9575()
{
var return_v =                                 Authenticode.InvalidHashAlgorithm;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 9542, 9575);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1221_9425_9576(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 9425, 9576);
return return_v;
}


int
f_1221_9632_9741(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 9632, 9741);
return 0;
}


System.Management.Automation.Signature
f_1221_9868_9896(string
fileName,string
fileContent)
{
var return_v = GetSignature( fileName, fileContent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 9868, 9896);
return return_v;
}


System.Management.Automation.Signature
f_1221_9991_10028(string
filePath,uint
error)
{
var return_v = new System.Management.Automation.Signature( filePath, error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 9991, 10028);
return return_v;
}


int
f_1221_10117_10197(System.IntPtr
ptr)
{
Marshal.DestroyStructure<NativeMethods.CRYPTUI_WIZ_DIGITAL_SIGN_INFO>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 10117, 10197);
return 0;
}


int
f_1221_10216_10248(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 10216, 10248);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,3476,10308);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,3476,10308);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        internal static Signature GetSignature(string fileName, string fileContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,11044,11801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,11177,11204);

Signature 
signature = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,11220,11423) || true) && (fileContent == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,11220,11423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,11362,11408);

signature = f_1221_11374_11407(fileName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,11220,11423);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,11572,11757) || true) && ((signature == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1221, 11576, 11642)||(f_1221_11600_11616(signature)!= SignatureStatus.Valid)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,11572,11757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,11676,11742);

signature = f_1221_11688_11741(fileName, fileContent);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,11572,11757);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,11773,11790);

return signature;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,11044,11801);

System.Management.Automation.Signature
f_1221_11374_11407(string
filename)
{
var return_v = GetSignatureFromCatalog( filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 11374, 11407);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1221_11600_11616(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 11600, 11616);
return return_v;
}


System.Management.Automation.Signature
f_1221_11688_11741(string
fileName,string
fileContent)
{
var return_v = GetSignatureFromWinVerifyTrust( fileName, fileContent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 11688, 11741);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,11044,11801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,11044,11801);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods")]
        private static Signature GetSignatureFromCatalog(string filename)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,11813,18097);
System.IntPtr pProvSigner = default(System.IntPtr);
System.Security.Cryptography.X509Certificates.X509Certificate2 timestamperCert = default(System.Security.Cryptography.X509Certificates.X509Certificate2);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12028,12484) || true) && (f_1221_12032_12070(Signature.CatalogApiAvailable)&&(DynAbs.Tracing.TraceSender.Expression_True(1221, 12032, 12110)&&f_1221_12074_12110_M(!Signature.CatalogApiAvailable.Value)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,12028,12484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12457,12469);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,12028,12484);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12500,12527);

Signature 
signature = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12543,12594);

f_1221_12543_12593(filename, "fileName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12608,12652);

f_1221_12608_12651(filename);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12704,17800);
using(FileStream 
stream = f_1221_12731_12754(filename)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12796,12870);

NativeMethods.SIGNATURE_INFO 
sigInfo = f_1221_12835_12869()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12892,12939);

sigInfo.cbSize = (uint)f_1221_12915_12938(sigInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,12963,12998);

IntPtr 
ppCertContext = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,13020,13053);

IntPtr 
phStateData = IntPtr.Zero
;

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,13129,13740);

int 
hresult = f_1221_13143_13739(filename, f_1221_13186_13228(f_1221_13186_13207(stream)), NativeMethods.SIGNATURE_INFO_FLAGS.SIF_CATALOG_SIGNED |
                            NativeMethods.SIGNATURE_INFO_FLAGS.SIF_CATALOG_FIRST |
                            NativeMethods.SIGNATURE_INFO_FLAGS.SIF_AUTHENTICODE_SIGNED |
                            NativeMethods.SIGNATURE_INFO_FLAGS.SIF_BASE_VERIFICATION |
                            NativeMethods.SIGNATURE_INFO_FLAGS.SIF_CHECK_OS_BINARY, ref sigInfo, ref ppCertContext, ref phStateData)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,13768,17297) || true) && (f_1221_13772_13796(hresult))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,13768,17297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,13854,13920);

DWORD 
error = f_1221_13868_13919(sigInfo.nSignatureState)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,13952,13981);

X509Certificate2 
cert = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14013,15639) || true) && (ppCertContext != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,14013,15639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14111,14154);

cert = f_1221_14118_14153(ppCertContext);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14272,14368);

f_1221_14272_14367(phStateData, out pProvSigner, out timestamperCert);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14402,14799) || true) && (timestamperCert != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,14402,14799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14503,14569);

signature = f_1221_14515_14568(filename, error, cert, timestamperCert);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,14402,14799);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,14402,14799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14715,14764);

signature = f_1221_14727_14763(filename, error, cert);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,14402,14799);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14835,15236);

switch (sigInfo.nSignatureType)
                                {

case NativeMethods.SIGNATURE_INFO_TYPE.SIT_AUTHENTICODE: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,14835,15236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,14996,15049);

signature.SignatureType = SignatureType.Authenticode;
DynAbs.Tracing.TraceSender.TraceBreak(1221,15050,15056);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,14835,15236);

case NativeMethods.SIGNATURE_INFO_TYPE.SIT_CATALOG: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,14835,15236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,15146,15194);

signature.SignatureType = SignatureType.Catalog;
DynAbs.Tracing.TraceSender.TraceBreak(1221,15195,15201);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,14835,15236);
                                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,15272,15435) || true) && (sigInfo.fOSBinary == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,15272,15435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,15372,15400);

signature.IsOSBinary = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,15272,15435);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,14013,15639);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,14013,15639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,15565,15608);

signature = f_1221_15577_15607(filename, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,14013,15639);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,15671,16945) || true) && (f_1221_15675_15714_M(!Signature.CatalogApiAvailable.HasValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,15671,16945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,15780,15892);

string 
productFile = f_1221_15801_15891(f_1221_15814_15844(), "Modules\\PSDiagnostics\\PSDiagnostics.psm1")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,15926,16914) || true) && (f_1221_15930_15946(signature)!= SignatureStatus.Valid)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,15926,16914);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,16045,16879) || true) && (f_1221_16049_16121(filename, productFile, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,16045,16879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,16203,16241);

Signature.CatalogApiAvailable = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,16045,16879);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,16045,16879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,16609,16679);

Signature 
productFileSignature = f_1221_16642_16678(productFile)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,16721,16840);

Signature.CatalogApiAvailable = (productFileSignature != null &&(DynAbs.Tracing.TraceSender.Expression_True(1221, 16754, 16838)&&f_1221_16786_16813(productFileSignature)== SignatureStatus.Valid));
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,16045,16879);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,15926,16914);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,15671,16945);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,13768,17297);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,13768,17297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,17232,17270);

Signature.CatalogApiAvailable = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,13768,17297);
}
                    }
                    finally
                    {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1221,17342,17781);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,17398,17557) || true) && (phStateData != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,17398,17557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,17486,17530);

f_1221_17486_17529(phStateData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,17398,17557);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,17585,17758) || true) && (ppCertContext != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,17585,17758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,17675,17731);

f_1221_17675_17730(ppCertContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,17585,17758);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1221,17342,17781);
                    }
DynAbs.Tracing.TraceSender.TraceExitUsing(1221,12704,17800);
                }
            }
            catch (TypeLoadException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1221,17829,18053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,17970,18008);

Signature.CatalogApiAvailable = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18026,18038);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1221,17829,18053);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18069,18086);

return signature;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,11813,18097);

bool
f_1221_12032_12070(bool?
this_param)
{
var return_v = this_param.HasValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 12032, 12070);
return return_v;
}


bool
f_1221_12074_12110_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 12074, 12110);
return return_v;
}


int
f_1221_12543_12593(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 12543, 12593);
return 0;
}


int
f_1221_12608_12651(string
filePath)
{
SecuritySupport.CheckIfFileExists( filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 12608, 12651);
return 0;
}


System.IO.FileStream
f_1221_12731_12754(string
path)
{
var return_v = File.OpenRead( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 12731, 12754);
return return_v;
}


System.Management.Automation.Security.NativeMethods.SIGNATURE_INFO
f_1221_12835_12869()
{
var return_v = new System.Management.Automation.Security.NativeMethods.SIGNATURE_INFO();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 12835, 12869);
return return_v;
}


int
f_1221_12915_12938(System.Management.Automation.Security.NativeMethods.SIGNATURE_INFO
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 12915, 12938);
return return_v;
}


Microsoft.Win32.SafeHandles.SafeFileHandle
f_1221_13186_13207(System.IO.FileStream
this_param)
{
var return_v = this_param.SafeFileHandle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 13186, 13207);
return return_v;
}


System.IntPtr
f_1221_13186_13228(Microsoft.Win32.SafeHandles.SafeFileHandle
this_param)
{
var return_v = this_param.DangerousGetHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 13186, 13228);
return return_v;
}


int
f_1221_13143_13739(string
pszFile,System.IntPtr
hFile,System.Management.Automation.Security.NativeMethods.SIGNATURE_INFO_FLAGS
sigInfoFlags,ref System.Management.Automation.Security.NativeMethods.SIGNATURE_INFO
psiginfo,ref System.IntPtr
ppCertContext,ref System.IntPtr
phWVTStateData)
{
var return_v = NativeMethods.WTGetSignatureInfo( pszFile, hFile, sigInfoFlags, ref psiginfo, ref ppCertContext, ref phWVTStateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 13143, 13739);
return return_v;
}


bool
f_1221_13772_13796(int
hresult)
{
var return_v = Utils.Succeeded( hresult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 13772, 13796);
return return_v;
}


uint
f_1221_13868_13919(System.Management.Automation.Security.NativeMethods.SIGNATURE_STATE
state)
{
var return_v = GetErrorFromSignatureState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 13868, 13919);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2
f_1221_14118_14153(System.IntPtr
handle)
{
var return_v = new System.Security.Cryptography.X509Certificates.X509Certificate2( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 14118, 14153);
return return_v;
}


bool
f_1221_14272_14367(System.IntPtr
wvtStateData,out System.IntPtr
pProvSigner,out System.Security.Cryptography.X509Certificates.X509Certificate2
timestamperCert)
{
var return_v = TryGetProviderSigner( wvtStateData, out pProvSigner, out timestamperCert);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 14272, 14367);
return return_v;
}


System.Management.Automation.Signature
f_1221_14515_14568(string
filePath,uint
error,System.Security.Cryptography.X509Certificates.X509Certificate2
signer,System.Security.Cryptography.X509Certificates.X509Certificate2
timestamper)
{
var return_v = new System.Management.Automation.Signature( filePath, error, signer, timestamper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 14515, 14568);
return return_v;
}


System.Management.Automation.Signature
f_1221_14727_14763(string
filePath,uint
error,System.Security.Cryptography.X509Certificates.X509Certificate2
signer)
{
var return_v = new System.Management.Automation.Signature( filePath, error, signer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 14727, 14763);
return return_v;
}


System.Management.Automation.Signature
f_1221_15577_15607(string
filePath,uint
error)
{
var return_v = new System.Management.Automation.Signature( filePath, error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 15577, 15607);
return return_v;
}


bool
f_1221_15675_15714_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 15675, 15714);
return return_v;
}


string
f_1221_15814_15844()
{
var return_v = Utils.DefaultPowerShellAppBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 15814, 15844);
return return_v;
}


string
f_1221_15801_15891(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 15801, 15891);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1221_15930_15946(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 15930, 15946);
return return_v;
}


bool
f_1221_16049_16121(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 16049, 16121);
return return_v;
}


System.Management.Automation.Signature
f_1221_16642_16678(string
filename)
{
var return_v = GetSignatureFromCatalog( filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 16642, 16678);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1221_16786_16813(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1221, 16786, 16813);
return return_v;
}


int
f_1221_17486_17529(System.IntPtr
phWVTStateData)
{
NativeMethods.FreeWVTStateData( phWVTStateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 17486, 17529);
return 0;
}


bool
f_1221_17675_17730(System.IntPtr
certContext)
{
var return_v = NativeMethods.CertFreeCertificateContext( certContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 17675, 17730);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,11813,18097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,11813,18097);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static DWORD GetErrorFromSignatureState(NativeMethods.SIGNATURE_STATE state)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,18109,19467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18218,19456);

switch (state)
            {

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_UNSIGNED_MISSING: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18334,18373);

return Win32Errors.TRUST_E_NOSIGNATURE;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_UNSIGNED_UNSUPPORTED: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18464,18503);

return Win32Errors.TRUST_E_NOSIGNATURE;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_UNSIGNED_POLICY: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18589,18628);

return Win32Errors.TRUST_E_NOSIGNATURE;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_INVALID_CORRUPT: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18714,18752);

return Win32Errors.TRUST_E_BAD_DIGEST;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_INVALID_POLICY: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18837,18872);

return Win32Errors.CRYPT_E_BAD_MSG;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_VALID: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,18948,18976);

return Win32Errors.NO_ERROR;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_TRUSTED: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19054,19082);

return Win32Errors.NO_ERROR;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

case NativeMethods.SIGNATURE_STATE.SIGNATURE_STATE_UNTRUSTED: DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19162,19207);

return Win32Errors.TRUST_E_EXPLICIT_DISTRUST;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,18218,19456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19295,19380);

f_1221_19295_19379("Should not get here - could not map SIGNATURE_STATE");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19402,19441);

return Win32Errors.TRUST_E_NOSIGNATURE;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,18218,19456);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,18109,19467);

int
f_1221_19295_19379(string
message)
{
System.Diagnostics.Debug.Fail( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 19295, 19379);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,18109,19467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,18109,19467);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Signature GetSignatureFromWinVerifyTrust(string fileName, string fileContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,19479,20835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19596,19623);

Signature 
signature = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19639,19671);

NativeMethods.WINTRUST_DATA 
wtd
=default(NativeMethods.WINTRUST_DATA);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19685,19718);

DWORD 
error = Win32Errors.E_FAIL
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19734,19993) || true) && (fileContent == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,19734,19993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19791,19842);

f_1221_19791_19841(fileName, "fileName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,19860,19904);

f_1221_19860_19903(fileName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,19734,19993);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20045,20101);

error = f_1221_20053_20100(fileName, fileContent, out wtd);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20121,20274) || true) && (error != Win32Errors.NO_ERROR)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,20121,20274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20196,20255);

f_1221_20196_20254(                    s_tracer, "GetWinTrustData failed: {0:x}", error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,20121,20274);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20294,20357);

signature = f_1221_20306_20356(fileName, error, wtd);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20377,20430);

error = f_1221_20385_20429(wtd);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20450,20613) || true) && (error != Win32Errors.NO_ERROR)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,20450,20613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20525,20594);

f_1221_20525_20593(                    s_tracer, "DestroyWinTrustDataStruct failed: {0:x}", error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,20450,20613);
}
            }
            catch (AccessViolationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1221,20642,20791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20707,20776);

signature = f_1221_20719_20775(fileName, Win32Errors.TRUST_E_NOSIGNATURE);
DynAbs.Tracing.TraceSender.TraceExitCatch(1221,20642,20791);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,20807,20824);

return signature;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,19479,20835);

int
f_1221_19791_19841(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 19791, 19841);
return 0;
}


int
f_1221_19860_19903(string
filePath)
{
SecuritySupport.CheckIfFileExists( filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 19860, 19903);
return 0;
}


uint
f_1221_20053_20100(string
fileName,string
fileContent,out System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
wtData)
{
var return_v = GetWinTrustData( fileName, fileContent, out wtData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 20053, 20100);
return return_v;
}


int
f_1221_20196_20254(System.Management.Automation.PSTraceSource
this_param,string
format,uint
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 20196, 20254);
return 0;
}


System.Management.Automation.Signature
f_1221_20306_20356(string
filePath,uint
error,System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
wtd)
{
var return_v = GetSignatureFromWintrustData( filePath, error, wtd);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 20306, 20356);
return return_v;
}


uint
f_1221_20385_20429(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
wtd)
{
var return_v = NativeMethods.DestroyWintrustDataStruct( wtd);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 20385, 20429);
return return_v;
}


int
f_1221_20525_20593(System.Management.Automation.PSTraceSource
this_param,string
format,uint
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 20525, 20593);
return 0;
}


System.Management.Automation.Signature
f_1221_20719_20775(string
filePath,uint
error)
{
var return_v = new System.Management.Automation.Signature( filePath, error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 20719, 20775);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,19479,20835);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,19479,20835);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        private static DWORD GetWinTrustData(string fileName, string fileContent,
                                            out NativeMethods.WINTRUST_DATA wtData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,20847,23290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21063,21099);

DWORD 
dwResult = Win32Errors.E_FAIL
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21113,21168);

IntPtr 
WINTRUST_ACTION_GENERIC_VERIFY_V2 = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21182,21213);

IntPtr 
wtdBuffer = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21229,21315);

Guid 
actionVerify =
f_1221_21266_21314("00AAC56B-CD44-11d0-8CC2-00C04FC295EE")
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21367,21477);

WINTRUST_ACTION_GENERIC_VERIFY_V2 =
f_1221_21424_21476(f_1221_21447_21475(actionVerify));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21495,21654);

f_1221_21495_21653(actionVerify, WINTRUST_ACTION_GENERIC_VERIFY_V2, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21674,21706);

NativeMethods.WINTRUST_DATA 
wtd
=default(NativeMethods.WINTRUST_DATA);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21726,22241) || true) && (fileContent == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,21726,22241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21791,21881);

NativeMethods.WINTRUST_FILE_INFO 
wfi = f_1221_21830_21880(fileName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,21903,21959);

wtd = f_1221_21909_21958(wfi);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,21726,22241);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,21726,22241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,22041,22144);

NativeMethods.WINTRUST_BLOB_INFO 
wbi = f_1221_22080_22143(fileName, fileContent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,22166,22222);

wtd = f_1221_22172_22221(wbi);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,21726,22241);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,22261,22317);

wtdBuffer = f_1221_22273_22316(f_1221_22296_22315(wtd));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,22335,22381);

f_1221_22335_22380(wtd, wtdBuffer, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,22602,22765);

dwResult = f_1221_22613_22764(IntPtr.Zero, WINTRUST_ACTION_GENERIC_VERIFY_V2, wtdBuffer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,22816,22888);

wtData = f_1221_22825_22887(wtdBuffer);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1221,22917,23247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,22957,23023);

f_1221_22957_23022(WINTRUST_ACTION_GENERIC_VERIFY_V2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23041,23098);

f_1221_23041_23097(WINTRUST_ACTION_GENERIC_VERIFY_V2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23116,23181);

f_1221_23116_23180(wtdBuffer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23199,23232);

f_1221_23199_23231(wtdBuffer);
DynAbs.Tracing.TraceSender.TraceExitFinally(1221,22917,23247);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23263,23279);

return dwResult;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,20847,23290);

System.Guid
f_1221_21266_21314(string
g)
{
var return_v = new System.Guid( g);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 21266, 21314);
return return_v;
}


int
f_1221_21447_21475(System.Guid
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 21447, 21475);
return return_v;
}


System.IntPtr
f_1221_21424_21476(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 21424, 21476);
return return_v;
}


int
f_1221_21495_21653(System.Guid
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 21495, 21653);
return 0;
}


System.Management.Automation.Security.NativeMethods.WINTRUST_FILE_INFO
f_1221_21830_21880(string
fileName)
{
var return_v = NativeMethods.InitWintrustFileInfoStruct( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 21830, 21880);
return return_v;
}


System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
f_1221_21909_21958(System.Management.Automation.Security.NativeMethods.WINTRUST_FILE_INFO
wfi)
{
var return_v = NativeMethods.InitWintrustDataStructFromFile( wfi);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 21909, 21958);
return return_v;
}


System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
f_1221_22080_22143(string
fileName,string
content)
{
var return_v = NativeMethods.InitWintrustBlobInfoStruct( fileName, content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22080, 22143);
return return_v;
}


System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
f_1221_22172_22221(System.Management.Automation.Security.NativeMethods.WINTRUST_BLOB_INFO
wbi)
{
var return_v = NativeMethods.InitWintrustDataStructFromBlob( wbi);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22172, 22221);
return return_v;
}


int
f_1221_22296_22315(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure)
{
var return_v = Marshal.SizeOf( structure);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22296, 22315);
return return_v;
}


System.IntPtr
f_1221_22273_22316(int
cb)
{
var return_v = Marshal.AllocCoTaskMem( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22273, 22316);
return return_v;
}


int
f_1221_22335_22380(System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
structure,System.IntPtr
ptr,bool
fDeleteOld)
{
Marshal.StructureToPtr( structure, ptr, fDeleteOld);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22335, 22380);
return 0;
}


uint
f_1221_22613_22764(System.IntPtr
hWndNotUsed,System.IntPtr
pgActionID,System.IntPtr
pWinTrustData)
{
var return_v = NativeMethods.WinVerifyTrust( hWndNotUsed, pgActionID, pWinTrustData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22613, 22764);
return return_v;
}


System.Management.Automation.Security.NativeMethods.WINTRUST_DATA
f_1221_22825_22887(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStructure<NativeMethods.WINTRUST_DATA>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22825, 22887);
return return_v;
}


int
f_1221_22957_23022(System.IntPtr
ptr)
{
Marshal.DestroyStructure<Guid>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 22957, 23022);
return 0;
}


int
f_1221_23041_23097(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 23041, 23097);
return 0;
}


int
f_1221_23116_23180(System.IntPtr
ptr)
{
Marshal.DestroyStructure<NativeMethods.WINTRUST_DATA>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 23116, 23180);
return 0;
}


int
f_1221_23199_23231(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 23199, 23231);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,20847,23290);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,20847,23290);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        private static X509Certificate2 GetCertFromChain(IntPtr pSigner)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,23302,24156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23424,23459);

X509Certificate2 
signerCert = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23648,23735);

IntPtr 
pCert =
f_1221_23680_23734(pSigner, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23782,24111) || true) && (pCert != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,23782,24111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,23840,24028);

NativeMethods.CRYPT_PROVIDER_CERT 
provCert =
                    (NativeMethods.CRYPT_PROVIDER_CERT)
f_1221_23963_24027(pCert)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24046,24096);

signerCert = f_1221_24059_24095(provCert.pCert);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,23782,24111);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24127,24145);

return signerCert;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,23302,24156);

System.IntPtr
f_1221_23680_23734(System.IntPtr
pSgnr,int
idxCert)
{
var return_v = NativeMethods.WTHelperGetProvCertFromChain( pSgnr, (uint)idxCert);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 23680, 23734);
return return_v;
}


System.Management.Automation.Security.NativeMethods.CRYPT_PROVIDER_CERT
f_1221_23963_24027(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStructure<NativeMethods.CRYPT_PROVIDER_CERT>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 23963, 24027);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2
f_1221_24059_24095(System.IntPtr
handle)
{
var return_v = new System.Security.Cryptography.X509Certificates.X509Certificate2( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 24059, 24095);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,23302,24156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,23302,24156);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        private static Signature GetSignatureFromWintrustData(
            string filePath,
            DWORD error,
            NativeMethods.WINTRUST_DATA wtd)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,24168,25881);
System.IntPtr pProvSigner = default(System.IntPtr);
System.Security.Cryptography.X509Certificates.X509Certificate2 timestamperCert = default(System.Security.Cryptography.X509Certificates.X509Certificate2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24382,24452);

f_1221_24382_24451(            s_tracer, "GetSignatureFromWintrustData: error: {0}", error);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24468,24495);

Signature 
signature = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24509,25566) || true) && (f_1221_24513_24614(wtd.hWVTStateData, out pProvSigner, out timestamperCert))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,24509,25566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24731,24791);

X509Certificate2 
signerCert = f_1221_24761_24790(pProvSigner)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24811,25551) || true) && (signerCert != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,24811,25551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24875,25455) || true) && (timestamperCert != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,24875,25455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,24952,25177);

signature = f_1221_24964_25176(filePath, error, signerCert, timestamperCert);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,24875,25455);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,24875,25455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,25275,25432);

signature = f_1221_25287_25431(filePath, error, signerCert);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,24875,25455);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,25479,25532);

signature.SignatureType = SignatureType.Authenticode;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,24811,25551);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,24509,25566);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,25582,25690);

f_1221_25582_25689(error != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1221, 25601, 25632)||signature != null), "GetSignatureFromWintrustData: general crypto failure");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,25706,25837) || true) && ((signature == null) &&(DynAbs.Tracing.TraceSender.Expression_True(1221, 25710, 25745)&&(error != 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,25706,25837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,25779,25822);

signature = f_1221_25791_25821(filePath, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,25706,25837);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,25853,25870);

return signature;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,24168,25881);

int
f_1221_24382_24451(System.Management.Automation.PSTraceSource
this_param,string
format,uint
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 24382, 24451);
return 0;
}


bool
f_1221_24513_24614(System.IntPtr
wvtStateData,out System.IntPtr
pProvSigner,out System.Security.Cryptography.X509Certificates.X509Certificate2
timestamperCert)
{
var return_v = TryGetProviderSigner( wvtStateData, out pProvSigner, out timestamperCert);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 24513, 24614);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2
f_1221_24761_24790(System.IntPtr
pSigner)
{
var return_v = GetCertFromChain( pSigner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 24761, 24790);
return return_v;
}


System.Management.Automation.Signature
f_1221_24964_25176(string
filePath,uint
error,System.Security.Cryptography.X509Certificates.X509Certificate2
signer,System.Security.Cryptography.X509Certificates.X509Certificate2
timestamper)
{
var return_v = new System.Management.Automation.Signature( filePath, error, signer, timestamper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 24964, 25176);
return return_v;
}


System.Management.Automation.Signature
f_1221_25287_25431(string
filePath,uint
error,System.Security.Cryptography.X509Certificates.X509Certificate2
signer)
{
var return_v = new System.Management.Automation.Signature( filePath, error, signer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 25287, 25431);
return return_v;
}


int
f_1221_25582_25689(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 25582, 25689);
return 0;
}


System.Management.Automation.Signature
f_1221_25791_25821(string
filePath,uint
error)
{
var return_v = new System.Management.Automation.Signature( filePath, error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 25791, 25821);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,24168,25881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,24168,25881);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        private static bool TryGetProviderSigner(IntPtr wvtStateData, out IntPtr pProvSigner, out X509Certificate2 timestamperCert)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,25893,27325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26074,26100);

pProvSigner = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26114,26137);

timestamperCert = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26308,26402);

IntPtr 
pProvData =
f_1221_26344_26401(wvtStateData)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26449,27285) || true) && (pProvData != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,26449,27285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26511,26611);

pProvSigner =
f_1221_26546_26610(pProvData, 0, 0, 0);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26631,27270) || true) && (pProvSigner != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,26631,27270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26703,26907);

NativeMethods.CRYPT_PROVIDER_SGNR 
provSigner =
                        (NativeMethods.CRYPT_PROVIDER_SGNR)
f_1221_26836_26906(pProvSigner)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,26929,27215) || true) && (provSigner.csCounterSigners == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1221,26929,27215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,27127,27192);

timestamperCert = f_1221_27145_27191(provSigner.pasCounterSigners);
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,26929,27215);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,27239,27251);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,26631,27270);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1221,26449,27285);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,27301,27314);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,25893,27325);

System.IntPtr
f_1221_26344_26401(System.IntPtr
hStateData)
{
var return_v = NativeMethods.WTHelperProvDataFromStateData( hStateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 26344, 26401);
return return_v;
}


System.IntPtr
f_1221_26546_26610(System.IntPtr
pProvData,int
idxSigner,int
fCounterSigner,int
idxCounterSigner)
{
var return_v = NativeMethods.WTHelperGetProvSignerFromChain( pProvData, (uint)idxSigner, (uint)fCounterSigner, (uint)idxCounterSigner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 26546, 26610);
return return_v;
}


System.Management.Automation.Security.NativeMethods.CRYPT_PROVIDER_SGNR
f_1221_26836_26906(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStructure<NativeMethods.CRYPT_PROVIDER_SGNR>( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 26836, 26906);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2
f_1221_27145_27191(System.IntPtr
pSigner)
{
var return_v = GetCertFromChain( pSigner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 27145, 27191);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,25893,27325);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,25893,27325);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        private static DWORD GetLastWin32Error()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1221,27337,27548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,27435,27475);

int 
error = f_1221_27447_27474()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,27491,27537);

return f_1221_27498_27536(error);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1221,27337,27548);

int
f_1221_27447_27474()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 27447, 27474);
return return_v;
}


uint
f_1221_27498_27536(int
n)
{
var return_v = SecuritySupport.GetDWORDFromInt( n);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 27498, 27536);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1221,27337,27548);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,27337,27548);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SignatureHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1221,1426,27555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1221,1713,1840);
s_tracer = f_1221_1737_1840("SignatureHelper", "tracer for SignatureHelper");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1221,1426,27555);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1221,1426,27555);
}


static System.Management.Automation.PSTraceSource
f_1221_1737_1840(string
name,string
description)
{
var return_v = Dbg.PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1221, 1737, 1840);
return return_v;
}

}
}

#pragma warning restore 56523
