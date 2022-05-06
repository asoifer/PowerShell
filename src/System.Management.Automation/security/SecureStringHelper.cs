// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Microsoft.PowerShell
{
internal static class SecureStringHelper
{
internal static string SecureStringExportHeader ;

private static SecureString New(byte[] data)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,1131,2045);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1200,1454) || true) && ((f_1226_1205_1216(data)% 2) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,1200,1454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1344,1384);

string 
error = f_1226_1359_1383()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1402,1439);

throw f_1226_1408_1438(error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,1200,1454);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1470,1478);

char 
ch
=default(char);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1492,1529);

SecureString 
ss = f_1226_1510_1528()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1623,1649);

int 
len = f_1226_1633_1644(data)/ 2
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1674,1679);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1665,2008) || true) && (i < len)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1690,1693)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1226,1665,2008))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,1665,2008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1727,1776);

ch = (char)(data[2 * i + 1] * 256 + data[2 * i]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1794,1812);

f_1226_1794_1811(                ss, ch);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1939,1955);

data[2 * i] = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,1973,1993);

data[2 * i + 1] = 0;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1226,1,344);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1226,1,344);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,2024,2034);

return ss;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,1131,2045);

int
f_1226_1205_1216(byte[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 1205, 1216);
return return_v;
}


string
f_1226_1359_1383()
{
var return_v = Serialization.InvalidKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 1359, 1383);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1226_1408_1438(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 1408, 1438);
return return_v;
}


System.Security.SecureString
f_1226_1510_1528()
{
var return_v = new System.Security.SecureString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 1510, 1528);
return return_v;
}


int
f_1226_1633_1644(byte[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 1633, 1644);
return return_v;
}


int
f_1226_1794_1811(System.Security.SecureString
this_param,char
c)
{
this_param.AppendChar( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 1794, 1811);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,1131,2045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,1131,2045);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ArchitectureSensitive]
        internal static byte[] GetData(SecureString s)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,2289,2929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,2471,2508);

byte[] 
data = new byte[f_1226_2494_2502(s)* 2]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,2524,2890) || true) && (f_1226_2528_2536(s)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,2524,2890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,2574,2629);

IntPtr 
ptr = f_1226_2587_2628(s)
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,2693,2733);

f_1226_2693_2732(ptr, data, 0, f_1226_2720_2731(data));
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1226,2770,2875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,2818,2856);

f_1226_2818_2855(ptr);
DynAbs.Tracing.TraceSender.TraceExitFinally(1226,2770,2875);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,2524,2890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,2906,2918);

return data;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,2289,2929);

int
f_1226_2494_2502(System.Security.SecureString
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 2494, 2502);
return return_v;
}


int
f_1226_2528_2536(System.Security.SecureString
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 2528, 2536);
return return_v;
}


System.IntPtr
f_1226_2587_2628(System.Security.SecureString
s)
{
var return_v = Marshal.SecureStringToCoTaskMemUnicode( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 2587, 2628);
return return_v;
}


int
f_1226_2720_2731(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 2720, 2731);
return return_v;
}


int
f_1226_2693_2732(System.IntPtr
source,byte[]
destination,int
startIndex,int
length)
{
Marshal.Copy( source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 2693, 2732);
return 0;
}


int
f_1226_2818_2855(System.IntPtr
s)
{
Marshal.ZeroFreeCoTaskMemUnicode( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 2818, 2855);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,2289,2929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,2289,2929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string ByteArrayToString(byte[] data)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,3342,3693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,3420,3459);

StringBuilder 
sb = f_1226_3439_3458()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,3484,3489);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,3475,3645) || true) && (i < f_1226_3495_3506(data))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,3508,3511)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1226,3475,3645))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,3475,3645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,3545,3630);

f_1226_3545_3629(                sb, f_1226_3555_3628(data[i], "x2", f_1226_3578_3627()));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1226,1,171);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1226,1,171);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,3661,3682);

return f_1226_3668_3681(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,3342,3693);

System.Text.StringBuilder
f_1226_3439_3458()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 3439, 3458);
return return_v;
}


int
f_1226_3495_3506(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 3495, 3506);
return return_v;
}


System.Globalization.CultureInfo
f_1226_3578_3627()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 3578, 3627);
return return_v;
}


string
f_1226_3555_3628(byte
this_param,string
format,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( format, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 3555, 3628);
return return_v;
}


System.Text.StringBuilder
f_1226_3545_3629(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 3545, 3629);
return return_v;
}


string
f_1226_3668_3681(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 3668, 3681);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,3342,3693);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,3342,3693);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static byte[] ByteArrayFromString(string s)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,3964,4609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4112,4139);

int 
dataLen = f_1226_4126_4134(s)/ 2
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4153,4185);

byte[] 
data = new byte[dataLen]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4201,4570) || true) && (f_1226_4205_4213(s)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,4201,4570);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4260,4265);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4251,4555) || true) && (i < dataLen)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4280,4283)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1226,4251,4555))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,4251,4555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4325,4536);

data[i] = f_1226_4335_4535(f_1226_4346_4367(s, 2 * i, 2), NumberStyles.AllowHexSpecifier, f_1226_4485_4534());
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1226,1,305);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1226,1,305);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1226,4201,4570);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,4586,4598);

return data;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,3964,4609);

int
f_1226_4126_4134(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 4126, 4134);
return return_v;
}


int
f_1226_4205_4213(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 4205, 4213);
return return_v;
}


string
f_1226_4346_4367(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 4346, 4367);
return return_v;
}


System.Globalization.CultureInfo
f_1226_4485_4534()
{
var return_v =                                          System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 4485, 4534);
return return_v;
}


byte
f_1226_4335_4535(string
s,System.Globalization.NumberStyles
style,System.Globalization.CultureInfo
provider)
{
var return_v = byte.Parse( s, style, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 4335, 4535);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,3964,4609);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,3964,4609);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string Protect(SecureString input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,4927,5709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5002,5045);

f_1226_5002_5044(input, "input");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5061,5090);

string 
output = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5104,5123);

byte[] 
data = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5137,5165);

byte[] 
protectedData = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5181,5203);

data = f_1226_5188_5202(input);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5357,5491);

protectedData = f_1226_5373_5490(data, null, DataProtectionScope.CurrentUser);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5514,5519);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5505,5602) || true) && (i < f_1226_5525_5536(data))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5538,5541)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1226,5505,5602))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,5505,5602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5575,5587);

data[i] = 0;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1226,1,98);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1226,1,98);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5626,5668);

output = f_1226_5635_5667(protectedData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,5684,5698);

return output;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,4927,5709);

int
f_1226_5002_5044(System.Security.SecureString
arg,string
argName)
{
Utils.CheckSecureStringArg( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 5002, 5044);
return 0;
}


byte[]
f_1226_5188_5202(System.Security.SecureString
s)
{
var return_v = GetData( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 5188, 5202);
return return_v;
}


byte[]
f_1226_5373_5490(byte[]
userData,byte[]
optionalEntropy,Microsoft.PowerShell.DataProtectionScope
scope)
{
var return_v = ProtectedData.Protect( userData, optionalEntropy, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 5373, 5490);
return return_v;
}


int
f_1226_5525_5536(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 5525, 5536);
return return_v;
}


string
f_1226_5635_5667(byte[]
data)
{
var return_v = ByteArrayToString( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 5635, 5667);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,4927,5709);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,4927,5709);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SecureString Unprotect(string input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,6063,6906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6140,6185);

f_1226_6140_6184(input, "input");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6199,6370) || true) && ((f_1226_6204_6216(input)% 2) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,6199,6370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6260,6355);

throw f_1226_6266_6354("input", f_1226_6310_6346(), input);
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,6199,6370);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6386,6405);

byte[] 
data = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6419,6447);

byte[] 
protectedData = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6461,6476);

SecureString 
s
=default(SecureString);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6492,6535);

protectedData = f_1226_6508_6534(input);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6703,6832);

data = f_1226_6710_6831(protectedData, null, DataProtectionScope.CurrentUser);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6856,6870);

s = f_1226_6860_6869(data);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,6886,6895);

return s;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,6063,6906);

int
f_1226_6140_6184(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 6140, 6184);
return 0;
}


int
f_1226_6204_6216(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 6204, 6216);
return return_v;
}


string
f_1226_6310_6346()
{
var return_v = Serialization.InvalidEncryptedString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 6310, 6346);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1226_6266_6354(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 6266, 6354);
return return_v;
}


byte[]
f_1226_6508_6534(string
s)
{
var return_v = ByteArrayFromString( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 6508, 6534);
return return_v;
}


byte[]
f_1226_6710_6831(byte[]
encryptedData,byte[]
optionalEntropy,Microsoft.PowerShell.DataProtectionScope
scope)
{
var return_v = ProtectedData.Unprotect( encryptedData, optionalEntropy, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 6710, 6831);
return return_v;
}


System.Security.SecureString
f_1226_6860_6869(byte[]
data)
{
var return_v = New( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 6860, 6869);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,6063,6906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,6063,6906);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static EncryptionResult Encrypt(SecureString input, SecureString key)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,7290,7847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,7393,7424);

EncryptionResult 
output = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,7533,7563);

byte[] 
keyBlob = f_1226_7550_7562(key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,7644,7677);

output = f_1226_7653_7676(input, keyBlob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,7766,7806);

f_1226_7766_7805(keyBlob, 0, f_1226_7790_7804(keyBlob));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,7822,7836);

return output;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,7290,7847);

byte[]
f_1226_7550_7562(System.Security.SecureString
s)
{
var return_v = GetData( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 7550, 7562);
return return_v;
}


Microsoft.PowerShell.EncryptionResult
f_1226_7653_7676(System.Security.SecureString
input,byte[]
key)
{
var return_v = Encrypt( input, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 7653, 7676);
return return_v;
}


int
f_1226_7790_7804(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 7790, 7804);
return return_v;
}


int
f_1226_7766_7805(byte[]
array,int
index,int
length)
{
Array.Clear( (System.Array)array, index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 7766, 7805);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,7290,7847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,7290,7847);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static EncryptionResult Encrypt(SecureString input, byte[] key)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,8231,8372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8328,8361);

return f_1226_8335_8360(input, key, null);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,8231,8372);

Microsoft.PowerShell.EncryptionResult
f_1226_8335_8360(System.Security.SecureString
input,byte[]
key,byte[]
iv)
{
var return_v = Encrypt( input, key, iv);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 8335, 8360);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,8231,8372);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,8231,8372);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static EncryptionResult Encrypt(SecureString input, byte[] key, byte[] iv)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,8384,9974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8492,8535);

f_1226_8492_8534(input, "input");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8549,8579);

f_1226_8549_8578(key, "key");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8595,8623);

byte[] 
encryptedData = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8637,8660);

MemoryStream 
ms = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8674,8708);

ICryptoTransform 
encryptor = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8722,8745);

CryptoStream 
cs = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8899,8922);

Aes 
aes = f_1226_8909_8921()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8936,8981) || true) && (iv == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,8936,8981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8969,8981);

iv = f_1226_8974_8980(aes);
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,8936,8981);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,8997,9038);

encryptor = f_1226_9009_9037(aes, key, iv);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9052,9076);

ms = f_1226_9057_9075();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9092,9963);
using(cs = f_1226_9104_9159(ms, encryptor, CryptoStreamMode.Write))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9301,9330);

byte[] 
data = f_1226_9315_9329(input)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9421,9452);

f_1226_9421_9451(
                //
                // encrypt it
                //
                cs, data, 0, f_1226_9439_9450(data));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9470,9491);

f_1226_9470_9490(                cs);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9603,9637);

f_1226_9603_9636(data, 0, f_1226_9624_9635(data));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9756,9785);

encryptedData = f_1226_9772_9784(ms);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9805,9914);

EncryptionResult 
output = f_1226_9831_9913(f_1226_9852_9884(encryptedData), f_1226_9886_9912(iv))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,9934,9948);

return output;
DynAbs.Tracing.TraceSender.TraceExitUsing(1226,9092,9963);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,8384,9974);

int
f_1226_8492_8534(System.Security.SecureString
arg,string
argName)
{
Utils.CheckSecureStringArg( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 8492, 8534);
return 0;
}


int
f_1226_8549_8578(byte[]
arg,string
argName)
{
Utils.CheckKeyArg( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 8549, 8578);
return 0;
}


System.Security.Cryptography.Aes
f_1226_8909_8921()
{
var return_v = Aes.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 8909, 8921);
return return_v;
}


byte[]
f_1226_8974_8980(System.Security.Cryptography.Aes
this_param)
{
var return_v = this_param.IV;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 8974, 8980);
return return_v;
}


System.Security.Cryptography.ICryptoTransform
f_1226_9009_9037(System.Security.Cryptography.Aes
this_param,byte[]
rgbKey,byte[]
rgbIV)
{
var return_v = this_param.CreateEncryptor( rgbKey, rgbIV);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9009, 9037);
return return_v;
}


System.IO.MemoryStream
f_1226_9057_9075()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9057, 9075);
return return_v;
}


System.Security.Cryptography.CryptoStream
f_1226_9104_9159(System.IO.MemoryStream
stream,System.Security.Cryptography.ICryptoTransform
transform,System.Security.Cryptography.CryptoStreamMode
mode)
{
var return_v = new System.Security.Cryptography.CryptoStream( (System.IO.Stream)stream, transform, mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9104, 9159);
return return_v;
}


byte[]
f_1226_9315_9329(System.Security.SecureString
s)
{
var return_v = GetData( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9315, 9329);
return return_v;
}


int
f_1226_9439_9450(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 9439, 9450);
return return_v;
}


int
f_1226_9421_9451(System.Security.Cryptography.CryptoStream
this_param,byte[]
buffer,int
offset,int
count)
{
this_param.Write( buffer, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9421, 9451);
return 0;
}


int
f_1226_9470_9490(System.Security.Cryptography.CryptoStream
this_param)
{
this_param.FlushFinalBlock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9470, 9490);
return 0;
}


int
f_1226_9624_9635(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 9624, 9635);
return return_v;
}


int
f_1226_9603_9636(byte[]
array,int
index,int
length)
{
Array.Clear( (System.Array)array, index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9603, 9636);
return 0;
}


byte[]
f_1226_9772_9784(System.IO.MemoryStream
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9772, 9784);
return return_v;
}


string
f_1226_9852_9884(byte[]
data)
{
var return_v = ByteArrayToString( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9852, 9884);
return return_v;
}


string
f_1226_9886_9912(byte[]
inArray)
{
var return_v = Convert.ToBase64String( inArray);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9886, 9912);
return return_v;
}


Microsoft.PowerShell.EncryptionResult
f_1226_9831_9913(string
encrypted,string
IV)
{
var return_v = new Microsoft.PowerShell.EncryptionResult( encrypted, IV);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 9831, 9913);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,8384,9974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,8384,9974);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SecureString Decrypt(string input, SecureString key, byte[] IV)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,10555,11113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,10659,10686);

SecureString 
output = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,10795,10825);

byte[] 
keyBlob = f_1226_10812_10824(key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,10906,10943);

output = f_1226_10915_10942(input, keyBlob, IV);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,11032,11072);

f_1226_11032_11071(keyBlob, 0, f_1226_11056_11070(keyBlob));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,11088,11102);

return output;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,10555,11113);

byte[]
f_1226_10812_10824(System.Security.SecureString
s)
{
var return_v = GetData( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 10812, 10824);
return return_v;
}


System.Security.SecureString
f_1226_10915_10942(string
input,byte[]
key,byte[]
IV)
{
var return_v = Decrypt( input, key, IV);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 10915, 10942);
return return_v;
}


int
f_1226_11056_11070(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 11056, 11070);
return return_v;
}


int
f_1226_11032_11071(byte[]
array,int
index,int
length)
{
Array.Clear( (System.Array)array, index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 11032, 11071);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,10555,11113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,10555,11113);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SecureString Decrypt(string input, byte[] key, byte[] IV)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,11694,13208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,11792,11837);

f_1226_11792_11836(input, "input");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,11851,11881);

f_1226_11851_11880(key, "key");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,11897,11925);

byte[] 
decryptedData = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,11939,11967);

byte[] 
encryptedData = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,11981,12003);

SecureString 
s = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12092,12115);

Aes 
aes = f_1226_12102_12114()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12129,12172);

encryptedData = f_1226_12145_12171(input);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12188,12243);

var 
decryptor = f_1226_12204_12242(aes, key, IV ??(DynAbs.Tracing.TraceSender.Expression_Null<byte[]>(1226, 12229, 12241)??f_1226_12235_12241(aes)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12259,12309);

MemoryStream 
ms = f_1226_12277_12308(encryptedData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12325,13197);
using(CryptoStream 
cs = f_1226_12350_12404(ms, decryptor, CryptoStreamMode.Read)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12438,12496);

byte[] 
tempDecryptedData = new byte[f_1226_12474_12494(encryptedData)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12516,12537);

int 
numBytesRead = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12634,12745);

numBytesRead = f_1226_12649_12744(cs, tempDecryptedData, 0, f_1226_12719_12743(tempDecryptedData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12765,12804);

decryptedData = new byte[numBytesRead];
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12833,12838);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12824,12962) || true) && (i < numBytesRead)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12858,12861)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1226,12824,12962))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,12824,12962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12903,12943);

decryptedData[i] = tempDecryptedData[i];
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1226,1,139);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1226,1,139);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,12982,13005);

s = f_1226_12986_13004(decryptedData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,13023,13075);

f_1226_13023_13074(decryptedData, 0, f_1226_13053_13073(decryptedData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,13093,13153);

f_1226_13093_13152(tempDecryptedData, 0, f_1226_13127_13151(tempDecryptedData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,13173,13182);

return s;
DynAbs.Tracing.TraceSender.TraceExitUsing(1226,12325,13197);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,11694,13208);

int
f_1226_11792_11836(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 11792, 11836);
return 0;
}


int
f_1226_11851_11880(byte[]
arg,string
argName)
{
Utils.CheckKeyArg( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 11851, 11880);
return 0;
}


System.Security.Cryptography.Aes
f_1226_12102_12114()
{
var return_v = Aes.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 12102, 12114);
return return_v;
}


byte[]
f_1226_12145_12171(string
s)
{
var return_v = ByteArrayFromString( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 12145, 12171);
return return_v;
}


byte[]
f_1226_12235_12241(System.Security.Cryptography.Aes
this_param)
{
var return_v = this_param.IV;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 12235, 12241);
return return_v;
}


System.Security.Cryptography.ICryptoTransform
f_1226_12204_12242(System.Security.Cryptography.Aes
this_param,byte[]
rgbKey,byte[]
rgbIV)
{
var return_v = this_param.CreateDecryptor( rgbKey, rgbIV);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 12204, 12242);
return return_v;
}


System.IO.MemoryStream
f_1226_12277_12308(byte[]
buffer)
{
var return_v = new System.IO.MemoryStream( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 12277, 12308);
return return_v;
}


System.Security.Cryptography.CryptoStream
f_1226_12350_12404(System.IO.MemoryStream
stream,System.Security.Cryptography.ICryptoTransform
transform,System.Security.Cryptography.CryptoStreamMode
mode)
{
var return_v = new System.Security.Cryptography.CryptoStream( (System.IO.Stream)stream, transform, mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 12350, 12404);
return return_v;
}


int
f_1226_12474_12494(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 12474, 12494);
return return_v;
}


int
f_1226_12719_12743(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 12719, 12743);
return return_v;
}


int
f_1226_12649_12744(System.Security.Cryptography.CryptoStream
this_param,byte[]
buffer,int
offset,int
count)
{
var return_v = this_param.Read( buffer, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 12649, 12744);
return return_v;
}


System.Security.SecureString
f_1226_12986_13004(byte[]
data)
{
var return_v = New( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 12986, 13004);
return return_v;
}


int
f_1226_13053_13073(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 13053, 13073);
return return_v;
}


int
f_1226_13023_13074(byte[]
array,int
index,int
length)
{
Array.Clear( (System.Array)array, index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 13023, 13074);
return 0;
}


int
f_1226_13127_13151(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 13127, 13151);
return return_v;
}


int
f_1226_13093_13152(byte[]
array,int
index,int
length)
{
Array.Clear( (System.Array)array, index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 13093, 13152);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,11694,13208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,11694,13208);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SecureStringHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1226,508,13215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,696,757);
SecureStringExportHeader = "76492d1116743f0423413b16050a5345";DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1226,508,13215);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,508,13215);
}

}
internal class EncryptionResult
{
internal EncryptionResult(string encrypted, string IV)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1226,13409,13552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,13649,13687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,13797,13824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,13488,13514);

EncryptedData = encrypted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,13528,13541);

this.IV = IV;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1226,13409,13552);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,13409,13552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,13409,13552);
}
		}

internal string EncryptedData {get; }

internal string IV {get; }

static EncryptionResult()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1226,13361,13831);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1226,13361,13831);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,13361,13831);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1226,13361,13831);
}


    // The DPAPIs implemented in this section are temporary workaround.
    // CoreCLR team will bring 'ProtectedData' type to Project K eventually.

    
    internal enum DataProtectionScope
    {
        CurrentUser = 0x00,
        LocalMachine = 0x01
    }
internal static class ProtectedData
{
public static byte[] Protect(byte[] userData, byte[] optionalEntropy, DataProtectionScope scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,14260,17920);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14381,14494) || true) && (userData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,14381,14494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14435,14479);

throw f_1226_14441_14478("userData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,14381,14494);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14510,14545);

GCHandle 
pbDataIn = f_1226_14530_14544()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14559,14602);

GCHandle 
pOptionalEntropy = f_1226_14587_14601()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14616,14669);

CAPI.CRYPTOAPI_BLOB 
blob = f_1226_14643_14668()
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14721,14778);

pbDataIn = GCHandle.Alloc(userData,GCHandleType.Pinned);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14796,14851);

CAPI.CRYPTOAPI_BLOB 
dataIn = f_1226_14825_14850()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14869,14907);

dataIn.cbData = (uint)f_1226_14891_14906(userData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14925,14971);

dataIn.pbData = pbDataIn.AddrOfPinnedObject();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,14989,15045);

CAPI.CRYPTOAPI_BLOB 
entropy = f_1226_15019_15044()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15063,15368) || true) && (optionalEntropy != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,15063,15368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15132,15204);

pOptionalEntropy = GCHandle.Alloc(optionalEntropy,GCHandleType.Pinned);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15226,15272);

entropy.cbData = (uint)f_1226_15249_15271(optionalEntropy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15294,15349);

entropy.pbData = pOptionalEntropy.AddrOfPinnedObject();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,15063,15368);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15388,15434);

uint 
dwFlags = CAPI.CRYPTPROTECT_UI_FORBIDDEN
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15452,15563) || true) && (scope == DataProtectionScope.LocalMachine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,15452,15563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15520,15563);

dwFlags |= CAPI.CRYPTPROTECT_LOCAL_MACHINE;
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,15452,15563);
}
                unsafe
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,15628,16931) || true) && (!f_1226_15633_16028(pDataIn: f_1226_15690_15709(&dataIn), szDataDescr: string.Empty, pOptionalEntropy: f_1226_15806_15826(&entropy), pvReserved: IntPtr.Zero, pPromptStruct: IntPtr.Zero, dwFlags: dwFlags, pDataBlob: f_1226_16010_16027(&blob)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,15628,16931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,16078,16127);

int 
lastWin32Error = f_1226_16099_16126()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,16525,16908) || true) && (f_1226_16529_16583(lastWin32Error))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,16525,16908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,16641,16718);

throw f_1226_16647_16717("Cryptography_DpApi_ProfileMayNotBeLoaded");
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,16525,16908);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,16525,16908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,16832,16881);

throw f_1226_16838_16880(lastWin32Error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,16525,16908);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,15628,16931);
}
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17069,17193) || true) && (blob.pbData == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,17069,17193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17141,17174);

throw f_1226_17147_17173();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,17069,17193);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17213,17263);

byte[] 
encryptedData = new byte[(int)blob.cbData]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17281,17347);

f_1226_17281_17346(blob.pbData, encryptedData, 0, f_1226_17325_17345(encryptedData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17367,17388);

return encryptedData;
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1226,17417,17909);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17457,17558) || true) && (pbDataIn.IsAllocated)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,17457,17558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17523,17539);

pbDataIn.Free();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,17457,17558);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17576,17693) || true) && (pOptionalEntropy.IsAllocated)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,17576,17693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17650,17674);

pOptionalEntropy.Free();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,17576,17693);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17711,17894) || true) && (blob.pbData != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,17711,17894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17783,17825);

f_1226_17783_17824(blob.pbData, blob.cbData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,17847,17875);

f_1226_17847_17874(blob.pbData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,17711,17894);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1226,17417,17909);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,14260,17920);

System.ArgumentNullException
f_1226_14441_14478(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 14441, 14478);
return return_v;
}


System.Runtime.InteropServices.GCHandle
f_1226_14530_14544()
{
var return_v = new System.Runtime.InteropServices.GCHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 14530, 14544);
return return_v;
}


System.Runtime.InteropServices.GCHandle
f_1226_14587_14601()
{
var return_v = new System.Runtime.InteropServices.GCHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 14587, 14601);
return return_v;
}


Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB
f_1226_14643_14668()
{
var return_v = new Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 14643, 14668);
return return_v;
}


Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB
f_1226_14825_14850()
{
var return_v = new Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 14825, 14850);
return return_v;
}


int
f_1226_14891_14906(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 14891, 14906);
return return_v;
}


Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB
f_1226_15019_15044()
{
var return_v = new Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 15019, 15044);
return return_v;
}


int
f_1226_15249_15271(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 15249, 15271);
return return_v;
}


unsafe System.IntPtr
f_1226_15690_15709(Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB*
value)
{
var return_v = new System.IntPtr( (void*)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 15690, 15709);
return return_v;
}


unsafe System.IntPtr
f_1226_15806_15826(Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB*
value)
{
var return_v = new System.IntPtr( (void*)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 15806, 15826);
return return_v;
}


unsafe System.IntPtr
f_1226_16010_16027(Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB*
value)
{
var return_v = new System.IntPtr( (void*)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 16010, 16027);
return return_v;
}


bool
f_1226_15633_16028(System.IntPtr
pDataIn,string
szDataDescr,System.IntPtr
pOptionalEntropy,System.IntPtr
pvReserved,System.IntPtr
pPromptStruct,uint
dwFlags,System.IntPtr
pDataBlob)
{
var return_v = CAPI.CryptProtectData( pDataIn: pDataIn, szDataDescr: szDataDescr, pOptionalEntropy: pOptionalEntropy, pvReserved: pvReserved, pPromptStruct: pPromptStruct, dwFlags: dwFlags, pDataBlob: pDataBlob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 15633, 16028);
return return_v;
}


int
f_1226_16099_16126()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 16099, 16126);
return return_v;
}


bool
f_1226_16529_16583(int
errorCode)
{
var return_v = CAPI.ErrorMayBeCausedByUnloadedProfile( errorCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 16529, 16583);
return return_v;
}


System.Security.Cryptography.CryptographicException
f_1226_16647_16717(string
message)
{
var return_v = new System.Security.Cryptography.CryptographicException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 16647, 16717);
return return_v;
}


System.Security.Cryptography.CryptographicException
f_1226_16838_16880(int
hr)
{
var return_v = new System.Security.Cryptography.CryptographicException( hr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 16838, 16880);
return return_v;
}


System.OutOfMemoryException
f_1226_17147_17173()
{
var return_v = new System.OutOfMemoryException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 17147, 17173);
return return_v;
}


int
f_1226_17325_17345(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 17325, 17345);
return return_v;
}


int
f_1226_17281_17346(System.IntPtr
source,byte[]
destination,int
startIndex,int
length)
{
Marshal.Copy( source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 17281, 17346);
return 0;
}


int
f_1226_17783_17824(System.IntPtr
handle,uint
length)
{
CAPI.ZeroMemory( handle, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 17783, 17824);
return 0;
}


System.IntPtr
f_1226_17847_17874(System.IntPtr
handle)
{
var return_v = CAPI.LocalFree( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 17847, 17874);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,14260,17920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,14260,17920);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, DataProtectionScope scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,18003,20965);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18131,18254) || true) && (encryptedData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,18131,18254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18190,18239);

throw f_1226_18196_18238("encryptedData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,18131,18254);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18270,18305);

GCHandle 
pbDataIn = f_1226_18290_18304()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18319,18362);

GCHandle 
pOptionalEntropy = f_1226_18347_18361()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18376,18433);

CAPI.CRYPTOAPI_BLOB 
userData = f_1226_18407_18432()
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18485,18547);

pbDataIn = GCHandle.Alloc(encryptedData,GCHandleType.Pinned);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18565,18620);

CAPI.CRYPTOAPI_BLOB 
dataIn = f_1226_18594_18619()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18638,18681);

dataIn.cbData = (uint)f_1226_18660_18680(encryptedData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18699,18745);

dataIn.pbData = pbDataIn.AddrOfPinnedObject();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18763,18819);

CAPI.CRYPTOAPI_BLOB 
entropy = f_1226_18793_18818()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18837,19142) || true) && (optionalEntropy != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,18837,19142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,18906,18978);

pOptionalEntropy = GCHandle.Alloc(optionalEntropy,GCHandleType.Pinned);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,19000,19046);

entropy.cbData = (uint)f_1226_19023_19045(optionalEntropy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,19068,19123);

entropy.pbData = pOptionalEntropy.AddrOfPinnedObject();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,18837,19142);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,19162,19208);

uint 
dwFlags = CAPI.CRYPTPROTECT_UI_FORBIDDEN
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,19226,19375) || true) && (scope == DataProtectionScope.LocalMachine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,19226,19375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,19313,19356);

dwFlags |= CAPI.CRYPTPROTECT_LOCAL_MACHINE;
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,19226,19375);
}

                unsafe
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,19442,19984) || true) && (!f_1226_19447_19849(pDataIn: f_1226_19506_19525(&dataIn), ppszDataDescr: IntPtr.Zero, pOptionalEntropy: f_1226_19623_19643(&entropy), pvReserved: IntPtr.Zero, pPromptStruct: IntPtr.Zero, dwFlags: dwFlags, pDataBlob: f_1226_19827_19848(&userData)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,19442,19984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,19899,19961);

throw f_1226_19905_19960(f_1226_19932_19959());
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,19442,19984);
}
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20122,20250) || true) && (userData.pbData == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,20122,20250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20198,20231);

throw f_1226_20204_20230();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,20122,20250);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20270,20315);

byte[] 
data = new byte[(int)userData.cbData]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20333,20385);

f_1226_20333_20384(userData.pbData, data, 0, f_1226_20372_20383(data));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20405,20417);

return data;
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1226,20446,20954);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20486,20587) || true) && (pbDataIn.IsAllocated)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,20486,20587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20552,20568);

pbDataIn.Free();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,20486,20587);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20605,20722) || true) && (pOptionalEntropy.IsAllocated)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,20605,20722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20679,20703);

pOptionalEntropy.Free();
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,20605,20722);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20740,20939) || true) && (userData.pbData != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1226,20740,20939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20816,20866);

f_1226_20816_20865(userData.pbData, userData.cbData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,20888,20920);

f_1226_20888_20919(userData.pbData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1226,20740,20939);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1226,20446,20954);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,18003,20965);

System.ArgumentNullException
f_1226_18196_18238(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 18196, 18238);
return return_v;
}


System.Runtime.InteropServices.GCHandle
f_1226_18290_18304()
{
var return_v = new System.Runtime.InteropServices.GCHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 18290, 18304);
return return_v;
}


System.Runtime.InteropServices.GCHandle
f_1226_18347_18361()
{
var return_v = new System.Runtime.InteropServices.GCHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 18347, 18361);
return return_v;
}


Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB
f_1226_18407_18432()
{
var return_v = new Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 18407, 18432);
return return_v;
}


Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB
f_1226_18594_18619()
{
var return_v = new Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 18594, 18619);
return return_v;
}


int
f_1226_18660_18680(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 18660, 18680);
return return_v;
}


Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB
f_1226_18793_18818()
{
var return_v = new Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 18793, 18818);
return return_v;
}


int
f_1226_19023_19045(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 19023, 19045);
return return_v;
}


unsafe System.IntPtr
f_1226_19506_19525(Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB*
value)
{
var return_v = new System.IntPtr( (void*)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 19506, 19525);
return return_v;
}


unsafe System.IntPtr
f_1226_19623_19643(Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB*
value)
{
var return_v = new System.IntPtr( (void*)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 19623, 19643);
return return_v;
}


unsafe System.IntPtr
f_1226_19827_19848(Microsoft.PowerShell.CAPI.CRYPTOAPI_BLOB*
value)
{
var return_v = new System.IntPtr( (void*)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 19827, 19848);
return return_v;
}


bool
f_1226_19447_19849(System.IntPtr
pDataIn,System.IntPtr
ppszDataDescr,System.IntPtr
pOptionalEntropy,System.IntPtr
pvReserved,System.IntPtr
pPromptStruct,uint
dwFlags,System.IntPtr
pDataBlob)
{
var return_v = CAPI.CryptUnprotectData( pDataIn: pDataIn, ppszDataDescr: ppszDataDescr, pOptionalEntropy: pOptionalEntropy, pvReserved: pvReserved, pPromptStruct: pPromptStruct, dwFlags: dwFlags, pDataBlob: pDataBlob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 19447, 19849);
return return_v;
}


int
f_1226_19932_19959()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 19932, 19959);
return return_v;
}


System.Security.Cryptography.CryptographicException
f_1226_19905_19960(int
hr)
{
var return_v = new System.Security.Cryptography.CryptographicException( hr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 19905, 19960);
return return_v;
}


System.OutOfMemoryException
f_1226_20204_20230()
{
var return_v = new System.OutOfMemoryException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 20204, 20230);
return return_v;
}


int
f_1226_20372_20383(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1226, 20372, 20383);
return return_v;
}


int
f_1226_20333_20384(System.IntPtr
source,byte[]
destination,int
startIndex,int
length)
{
Marshal.Copy( source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 20333, 20384);
return 0;
}


int
f_1226_20816_20865(System.IntPtr
handle,uint
length)
{
CAPI.ZeroMemory( handle, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 20816, 20865);
return 0;
}


System.IntPtr
f_1226_20888_20919(System.IntPtr
handle)
{
var return_v = CAPI.LocalFree( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1226, 20888, 20919);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,18003,20965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,18003,20965);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ProtectedData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1226,14139,20972);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1226,14139,20972);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,14139,20972);
}

}
internal static class CAPI
{
internal const uint 
CRYPTPROTECT_UI_FORBIDDEN = 0x1
;

internal const uint 
CRYPTPROTECT_LOCAL_MACHINE = 0x4
;

internal const int 
E_FILENOTFOUND = unchecked((int)0x80070002)
;

internal const int 
ERROR_FILE_NOT_FOUND = 2
;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct CRYPTOAPI_BLOB
        {

internal uint cbData;

internal IntPtr pbData;
static CRYPTOAPI_BLOB(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1226,21334,21532);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1226,21334,21532);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,21334,21532);
}
        }

internal static bool ErrorMayBeCausedByUnloadedProfile(int errorCode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1226,21544,21831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,21728,21820);

return errorCode == E_FILENOTFOUND ||(DynAbs.Tracing.TraceSender.Expression_False(1226, 21735, 21819)||                   errorCode == ERROR_FILE_NOT_FOUND);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1226,21544,21831);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1226,21544,21831);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,21544,21831);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[DllImport("CRYPT32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CryptProtectData(
                [In]     IntPtr pDataIn,
                [In]     string szDataDescr,
                [In]     IntPtr pOptionalEntropy,
                [In]     IntPtr pvReserved,
                [In]     IntPtr pPromptStruct,
                [In]     uint dwFlags,
                [In, Out] IntPtr pDataBlob);

[DllImport("CRYPT32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CryptUnprotectData(
                [In]     IntPtr pDataIn,
                [In]     IntPtr ppszDataDescr,
                [In]     IntPtr pOptionalEntropy,
                [In]     IntPtr pvReserved,
                [In]     IntPtr pPromptStruct,
                [In]     uint dwFlags,
                [In, Out] IntPtr pDataBlob);

[DllImport("ntdll.dll", EntryPoint = "RtlZeroMemory", SetLastError = true)]
        internal static extern void ZeroMemory(IntPtr handle, uint length);

[DllImport(PinvokeDllNames.LocalFreeDllName, SetLastError = true)]
        internal static extern IntPtr LocalFree(IntPtr handle);

static CAPI()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1226,20980,23165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,21043,21074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,21105,21137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,21169,21212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1226,21260,21284);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1226,20980,23165);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1226,20980,23165);
}

}

    
}

