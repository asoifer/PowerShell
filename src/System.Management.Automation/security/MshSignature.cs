// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using System.Management.Automation.Internal;
using System.Security.Cryptography.X509Certificates;

using Dbg = System.Management.Automation;
using DWORD = System.UInt32;

namespace System.Management.Automation
{
internal static class Win32Errors
{
internal const DWORD 
NO_ERROR = 0
;

internal const DWORD 
E_FAIL = 0x80004005
;

internal const DWORD 
TRUST_E_NOSIGNATURE = 0x800b0100
;

internal const DWORD 
TRUST_E_BAD_DIGEST = 0x80096010
;

internal const DWORD 
TRUST_E_PROVIDER_UNKNOWN = 0x800b0001
;

internal const DWORD 
TRUST_E_SUBJECT_FORM_UNKNOWN = 0x800B0003
;

internal const DWORD 
CERT_E_UNTRUSTEDROOT = 0x800b0109
;

internal const DWORD 
TRUST_E_EXPLICIT_DISTRUST = 0x800B0111
;

internal const DWORD 
CRYPT_E_BAD_MSG = 0x8009200d
;

internal const DWORD 
NTE_BAD_ALGID = 0x80090008
;

static Win32Errors()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1224,354,1018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,425,437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,469,488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,520,552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,584,615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,647,684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,716,757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,789,822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,854,892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,924,952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,984,1010);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1224,354,1018);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,354,1018);
}

}

    /// <summary>
    /// Defines the valid status flags that a signature
    /// on a file may have.
    /// </summary>
    public enum SignatureStatus
    {
        /// <summary>
        /// The file has a valid signature.  This means only that
        /// the signature is syntactically valid.  It does not
        /// imply trust in any way.
        /// </summary>
        Valid,

        /// <summary>
        /// The file has an invalid signature.
        /// </summary>
        UnknownError,

        /// <summary>
        /// The file has no signature.
        /// </summary>
        NotSigned,

        /// <summary>
        /// The hash of the file does not match the hash stored
        /// along with the signature.
        /// </summary>
        HashMismatch,

        /// <summary>
        /// The certificate was signed by a publisher not trusted
        /// on the system.
        /// </summary>
        NotTrusted,

        /// <summary>
        /// The specified file format is not supported by the system
        /// for signing operations.  This usually means that the
        /// system does not know how to sign or verify the file
        /// type requested.
        /// </summary>
        NotSupportedFileFormat,

        /// <summary>
        /// The signature cannot be verified because it is incompatible
        /// with the current system.
        /// </summary>
        Incompatible
    };

    /// <summary>
    /// Defines the valid types of signatures.
    /// </summary>
    public enum SignatureType
    {
        /// <summary>
        /// The file is not signed.
        /// </summary>
        None = 0,

        /// <summary>
        /// The signature is an Authenticode signature embedded into the file itself.
        /// </summary>
        Authenticode = 1,

        /// <summary>
        /// The signature is a catalog signature.
        /// </summary>
        Catalog = 2
    };
public sealed class Signature
{
private string _path;

private SignatureStatus _status ;

private DWORD _win32Error;

private X509Certificate2 _signerCert;

private string _statusMessage ;

private X509Certificate2 _timeStamperCert;

internal static bool? CatalogApiAvailable ;

public X509Certificate2 SignerCertificate
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1224,4248,4318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,4284,4303);

return _signerCert;
DynAbs.Tracing.TraceSender.TraceExitMethod(1224,4248,4318);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,4182,4329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,4182,4329);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public X509Certificate2 TimeStamperCertificate
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1224,4556,4631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,4592,4616);

return _timeStamperCert;
DynAbs.Tracing.TraceSender.TraceExitMethod(1224,4556,4631);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,4485,4642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,4485,4642);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SignatureStatus Status
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1224,4814,4880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,4850,4865);

return _status;
DynAbs.Tracing.TraceSender.TraceExitMethod(1224,4814,4880);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,4760,4891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,4760,4891);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string StatusMessage
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1224,5103,5176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5139,5161);

return _statusMessage;
DynAbs.Tracing.TraceSender.TraceExitMethod(1224,5103,5176);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,5051,5187);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,5051,5187);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string Path
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1224,5374,5438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5410,5423);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1224,5374,5438);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,5331,5449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,5331,5449);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SignatureType SignatureType {get; internal set; }

public bool IsOSBinary {get; internal set; }

internal Signature(string filePath,
                           DWORD error,
                           X509Certificate2 signer,
                           X509Certificate2 timestamper)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1224,6328,6779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3185,3190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3225,3263);
this._status = SignatureStatus.UnknownError;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3288,3299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3335,3346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3372,3401);
this._statusMessage = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3437,3453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5566,5623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5762,5807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,6540,6591);

f_1224_6540_6590(filePath, "filePath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,6605,6645);

f_1224_6605_6644(signer, "signer");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,6659,6709);

f_1224_6659_6708(timestamper, "timestamper");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,6725,6768);

f_1224_6725_6767(this, filePath, signer, error, timestamper);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1224,6328,6779);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,6328,6779);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,6328,6779);
}
		}

internal Signature(string filePath,
                           X509Certificate2 signer)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1224,7155,7432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3185,3190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3225,3263);
this._status = SignatureStatus.UnknownError;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3288,3299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3335,3346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3372,3401);
this._statusMessage = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3437,3453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5566,5623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5762,5807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,7268,7319);

f_1224_7268_7318(filePath, "filePath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,7333,7373);

f_1224_7333_7372(signer, "signer");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,7389,7421);

f_1224_7389_7420(this, filePath, signer, 0, null);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1224,7155,7432);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,7155,7432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,7155,7432);
}
		}

internal Signature(string filePath,
                           DWORD error,
                           X509Certificate2 signer)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1224,7875,8197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3185,3190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3225,3263);
this._status = SignatureStatus.UnknownError;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3288,3299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3335,3346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3372,3401);
this._statusMessage = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3437,3453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5566,5623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5762,5807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,8029,8080);

f_1224_8029_8079(filePath, "filePath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,8094,8134);

f_1224_8094_8133(signer, "signer");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,8150,8186);

f_1224_8150_8185(this, filePath, signer, error, null);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1224,7875,8197);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,7875,8197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,7875,8197);
}
		}

internal Signature(string filePath, DWORD error)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1224,8578,8763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3185,3190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3225,3263);
this._status = SignatureStatus.UnknownError;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3288,3299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3335,3346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3372,3401);
this._statusMessage = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,3437,3453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5566,5623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,5762,5807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,8651,8702);

f_1224_8651_8701(filePath, "filePath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,8718,8752);

f_1224_8718_8751(this, filePath, null, error, null);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1224,8578,8763);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,8578,8763);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,8578,8763);
}
		}

private void Init(string filePath,
                          X509Certificate2 signer,
                          DWORD error,
                          X509Certificate2 timestamper)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1224,8775,9490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,8983,9000);

_path = filePath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9014,9034);

_win32Error = error;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9048,9069);

_signerCert = signer;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9083,9114);

_timeStamperCert = timestamper;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9128,9163);

SignatureType = SignatureType.None;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9179,9258);

SignatureStatus 
isc =
f_1224_9218_9257(error)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9274,9288);

_status = isc;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9304,9479);

_statusMessage = f_1224_9321_9478(isc, error, filePath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1224,8775,9490);

System.Management.Automation.SignatureStatus
f_1224_9218_9257(uint
error)
{
var return_v = GetSignatureStatusFromWin32Error( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 9218, 9257);
return return_v;
}


string
f_1224_9321_9478(System.Management.Automation.SignatureStatus
status,uint
error,string
filePath)
{
var return_v = GetSignatureStatusMessage( status, error, filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 9321, 9478);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,8775,9490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,8775,9490);
}
		}

private static SignatureStatus GetSignatureStatusFromWin32Error(DWORD error)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1224,9502,10644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9603,9654);

SignatureStatus 
isc = SignatureStatus.UnknownError
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9670,10606);

switch (error)
            {

case Win32Errors.NO_ERROR:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,9670,10606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9765,9793);

isc = SignatureStatus.Valid;
DynAbs.Tracing.TraceSender.TraceBreak(1224,9815,9821);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,9670,10606);

case Win32Errors.NTE_BAD_ALGID:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,9670,10606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,9894,9929);

isc = SignatureStatus.Incompatible;
DynAbs.Tracing.TraceSender.TraceBreak(1224,9951,9957);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,9670,10606);

case Win32Errors.TRUST_E_NOSIGNATURE:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,9670,10606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10036,10068);

isc = SignatureStatus.NotSigned;
DynAbs.Tracing.TraceSender.TraceBreak(1224,10090,10096);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,9670,10606);

case Win32Errors.TRUST_E_BAD_DIGEST:
                case Win32Errors.CRYPT_E_BAD_MSG:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,9670,10606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10225,10260);

isc = SignatureStatus.HashMismatch;
DynAbs.Tracing.TraceSender.TraceBreak(1224,10282,10288);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,9670,10606);

case Win32Errors.TRUST_E_PROVIDER_UNKNOWN:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,9670,10606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10372,10417);

isc = SignatureStatus.NotSupportedFileFormat;
DynAbs.Tracing.TraceSender.TraceBreak(1224,10439,10445);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,9670,10606);

case Win32Errors.TRUST_E_EXPLICIT_DISTRUST:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,9670,10606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10530,10563);

isc = SignatureStatus.NotTrusted;
DynAbs.Tracing.TraceSender.TraceBreak(1224,10585,10591);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,9670,10606);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10622,10633);

return isc;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1224,9502,10644);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,9502,10644);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,9502,10644);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetSignatureStatusMessage(SignatureStatus status,
                                                 DWORD error,
                                                 string filePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1224,10656,13360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10882,10904);

string 
message = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10918,10947);

string 
resourceString = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10961,10979);

string 
arg = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,10995,13002);

switch (status)
            {

case SignatureStatus.Valid:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,10995,13002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11092,11141);

resourceString = f_1224_11109_11140();
DynAbs.Tracing.TraceSender.TraceBreak(1224,11163,11169);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,10995,13002);

case SignatureStatus.UnknownError:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,10995,13002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11245,11299);

int 
intError = f_1224_11260_11298(error)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11321,11369);

Win32Exception 
e = f_1224_11340_11368(intError)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11391,11411);

message = f_1224_11401_11410(e);
DynAbs.Tracing.TraceSender.TraceBreak(1224,11433,11439);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,10995,13002);

case SignatureStatus.Incompatible:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,10995,13002);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11515,11850) || true) && (error == Win32Errors.NTE_BAD_ALGID)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,11515,11850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11603,11673);

resourceString = f_1224_11620_11672();
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,11515,11850);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,11515,11850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11771,11827);

resourceString = f_1224_11788_11826();
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,11515,11850);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11874,11889);

arg = filePath;
DynAbs.Tracing.TraceSender.TraceBreak(1224,11911,11917);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,10995,13002);

case SignatureStatus.NotSigned:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,10995,13002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,11990,12043);

resourceString = f_1224_12007_12042();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12065,12080);

arg = filePath;
DynAbs.Tracing.TraceSender.TraceBreak(1224,12102,12108);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,10995,13002);

case SignatureStatus.HashMismatch:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,10995,13002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12184,12240);

resourceString = f_1224_12201_12239();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12262,12277);

arg = filePath;
DynAbs.Tracing.TraceSender.TraceBreak(1224,12299,12305);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,10995,13002);

case SignatureStatus.NotTrusted:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,10995,13002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12379,12433);

resourceString = f_1224_12396_12432();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12455,12470);

arg = filePath;
DynAbs.Tracing.TraceSender.TraceBreak(1224,12492,12498);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,10995,13002);

case SignatureStatus.NotSupportedFileFormat:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,10995,13002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12584,12650);

resourceString = f_1224_12601_12649();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12672,12716);

arg = f_1224_12678_12715(filePath);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12740,12957) || true) && (f_1224_12744_12769(arg))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,12740,12957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12819,12897);

resourceString = f_1224_12836_12896();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,12923,12934);

arg = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,12740,12957);
}
DynAbs.Tracing.TraceSender.TraceBreak(1224,12981,12987);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,10995,13002);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,13018,13318) || true) && (message == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,13018,13318);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,13071,13303) || true) && (arg == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,13071,13303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,13128,13153);

message = resourceString;
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,13071,13303);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1224,13071,13303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,13235,13284);

message = f_1224_13245_13283(resourceString, arg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,13071,13303);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1224,13018,13318);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,13334,13349);

return message;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1224,10656,13360);

string
f_1224_11109_11140()
{
var return_v = MshSignature.MshSignature_Valid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 11109, 11140);
return return_v;
}


int
f_1224_11260_11298(uint
n)
{
var return_v = SecuritySupport.GetIntFromDWORD( n);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 11260, 11298);
return return_v;
}


System.ComponentModel.Win32Exception
f_1224_11340_11368(int
error)
{
var return_v = new System.ComponentModel.Win32Exception( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 11340, 11368);
return return_v;
}


string
f_1224_11401_11410(System.ComponentModel.Win32Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 11401, 11410);
return return_v;
}


string
f_1224_11620_11672()
{
var return_v = MshSignature.MshSignature_Incompatible_HashAlgorithm;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 11620, 11672);
return return_v;
}


string
f_1224_11788_11826()
{
var return_v = MshSignature.MshSignature_Incompatible;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 11788, 11826);
return return_v;
}


string
f_1224_12007_12042()
{
var return_v = MshSignature.MshSignature_NotSigned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 12007, 12042);
return return_v;
}


string
f_1224_12201_12239()
{
var return_v = MshSignature.MshSignature_HashMismatch;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 12201, 12239);
return return_v;
}


string
f_1224_12396_12432()
{
var return_v = MshSignature.MshSignature_NotTrusted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 12396, 12432);
return return_v;
}


string
f_1224_12601_12649()
{
var return_v = MshSignature.MshSignature_NotSupportedFileFormat;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 12601, 12649);
return return_v;
}


string?
f_1224_12678_12715(string
path)
{
var return_v = System.IO.Path.GetExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 12678, 12715);
return return_v;
}


bool
f_1224_12744_12769(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 12744, 12769);
return return_v;
}


string
f_1224_12836_12896()
{
var return_v = MshSignature.MshSignature_NotSupportedFileFormat_NoExtension;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1224, 12836, 12896);
return return_v;
}


string
f_1224_13245_13283(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 13245, 13283);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1224,10656,13360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,10656,13360);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static Signature()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1224,3124,13368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1224,4005,4031);
CatalogApiAvailable = null;DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1224,3124,13368);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1224,3124,13368);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1224,3124,13368);

int
f_1224_6540_6590(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 6540, 6590);
return 0;
}


int
f_1224_6605_6644(System.Security.Cryptography.X509Certificates.X509Certificate2
arg,string
argName)
{
Utils.CheckArgForNull( (object)arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 6605, 6644);
return 0;
}


int
f_1224_6659_6708(System.Security.Cryptography.X509Certificates.X509Certificate2
arg,string
argName)
{
Utils.CheckArgForNull( (object)arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 6659, 6708);
return 0;
}


int
f_1224_6725_6767(System.Management.Automation.Signature
this_param,string
filePath,System.Security.Cryptography.X509Certificates.X509Certificate2
signer,uint
error,System.Security.Cryptography.X509Certificates.X509Certificate2
timestamper)
{
this_param.Init( filePath, signer, error, timestamper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 6725, 6767);
return 0;
}


int
f_1224_7268_7318(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 7268, 7318);
return 0;
}


int
f_1224_7333_7372(System.Security.Cryptography.X509Certificates.X509Certificate2
arg,string
argName)
{
Utils.CheckArgForNull( (object)arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 7333, 7372);
return 0;
}


int
f_1224_7389_7420(System.Management.Automation.Signature
this_param,string
filePath,System.Security.Cryptography.X509Certificates.X509Certificate2
signer,int
error,System.Security.Cryptography.X509Certificates.X509Certificate2
timestamper)
{
this_param.Init( filePath, signer, (uint)error, timestamper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 7389, 7420);
return 0;
}


int
f_1224_8029_8079(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 8029, 8079);
return 0;
}


int
f_1224_8094_8133(System.Security.Cryptography.X509Certificates.X509Certificate2
arg,string
argName)
{
Utils.CheckArgForNull( (object)arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 8094, 8133);
return 0;
}


int
f_1224_8150_8185(System.Management.Automation.Signature
this_param,string
filePath,System.Security.Cryptography.X509Certificates.X509Certificate2
signer,uint
error,System.Security.Cryptography.X509Certificates.X509Certificate2
timestamper)
{
this_param.Init( filePath, signer, error, timestamper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 8150, 8185);
return 0;
}


int
f_1224_8651_8701(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 8651, 8701);
return 0;
}


int
f_1224_8718_8751(System.Management.Automation.Signature
this_param,string
filePath,System.Security.Cryptography.X509Certificates.X509Certificate2
signer,uint
error,System.Security.Cryptography.X509Certificates.X509Certificate2
timestamper)
{
this_param.Init( filePath, signer, error, timestamper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1224, 8718, 8751);
return 0;
}

}
;}

