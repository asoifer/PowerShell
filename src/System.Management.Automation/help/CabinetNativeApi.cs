// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Runtime.InteropServices;

using Microsoft.Win32.SafeHandles;

namespace System.Management.Automation.Internal
{
internal class CabinetExtractor : ICabinetExtractor
{
private CabinetNativeApi.FdiAllocDelegate _allocDelegate;

private GCHandle _fdiAllocHandle;

private CabinetNativeApi.FdiFreeDelegate _freeDelegate;

private GCHandle _fdiFreeHandle;

private CabinetNativeApi.FdiOpenDelegate _openDelegate;

private GCHandle _fdiOpenHandle;

private CabinetNativeApi.FdiReadDelegate _readDelegate;

private GCHandle _fdiReadHandle;

private CabinetNativeApi.FdiWriteDelegate _writeDelegate;

private GCHandle _fdiWriteHandle;

private CabinetNativeApi.FdiCloseDelegate _closeDelegate;

private GCHandle _fdiCloseHandle;

private CabinetNativeApi.FdiSeekDelegate _seekDelegate;

private GCHandle _fdiSeekHandle;

private CabinetNativeApi.FdiNotifyDelegate _notifyDelegate;

private GCHandle _fdiNotifyHandle;

internal CabinetNativeApi.FdiContextHandle fdiContext;

internal CabinetExtractor()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1144,1402,2319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,497,511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,606,619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,713,726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,820,833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,928,942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,1038,1052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,1147,1160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,1256,1271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,1371,1381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,2482,2499);
this._disposed = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,1454,1514);

CabinetNativeApi.FdiERF 
err = f_1144_1484_1513()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,1530,1550);

f_1144_1530_1549(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,1684,2308);

fdiContext = f_1144_1697_2307(f_1144_1742_1795(_allocDelegate), f_1144_1814_1866(_freeDelegate), f_1144_1885_1937(_openDelegate), f_1144_1956_2008(_readDelegate), f_1144_2027_2080(_writeDelegate), f_1144_2099_2152(_closeDelegate), f_1144_2171_2223(_seekDelegate), CabinetNativeApi.FdiCreateCpuType.Cpu80386, err);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1144,1402,2319);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,1402,2319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,1402,2319);
}
		}

private bool _disposed ;

protected override void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1144,2663,3232);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,2735,2804) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,2735,2804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,2782,2789);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,2735,2804);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,2891,2983) || true) && (fdiContext != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,2891,2983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,2947,2968);

f_1144_2947_2967(                fdiContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,2891,2983);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,3041,3065);

f_1144_3041_3064(            // Free unmanaged objects here
            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,3081,3098);

_disposed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,3197,3221);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing),1144,3197,3220);
DynAbs.Tracing.TraceSender.TraceExitMethod(1144,2663,3232);

int
f_1144_2947_2967(System.Management.Automation.Internal.CabinetNativeApi.FdiContextHandle
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 2947, 2967);
return 0;
}


int
f_1144_3041_3064(System.Management.Automation.Internal.CabinetExtractor
this_param)
{
this_param.CleanUpDelegates();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 3041, 3064);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,2663,3232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,2663,3232);
}
		}

        /// <summary>
        /// Finalizer to ensure destruction of unmanaged resources.
        /// </summary>
        ~CabinetExtractor()
        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,3404,3419);

f_1144_3404_3418(this, false);
        }

internal override bool Extract(string cabinetName, string srcPath, string destPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1144,3464,4055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,3572,3634);

IntPtr 
nativeDestPath = f_1144_3596_3633(destPath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,3650,3962);

bool 
result = f_1144_3664_3961(fdiContext, cabinetName, srcPath, 0, f_1144_3843_3897(_notifyDelegate), IntPtr.Zero, nativeDestPath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,3978,4014);

f_1144_3978_4013(nativeDestPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,4030,4044);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1144,3464,4055);

System.IntPtr
f_1144_3596_3633(string
s)
{
var return_v = Marshal.StringToHGlobalAnsi( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 3596, 3633);
return return_v;
}


System.IntPtr
f_1144_3843_3897(System.Management.Automation.Internal.CabinetNativeApi.FdiNotifyDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 3843, 3897);
return return_v;
}


bool
f_1144_3664_3961(System.Management.Automation.Internal.CabinetNativeApi.FdiContextHandle
hfdi,string
pszCabinet,string
pszCabPath,int
flags,System.IntPtr
pfnfdin,System.IntPtr
pfnfdid,System.IntPtr
pvUser)
{
var return_v = CabinetNativeApi.FDICopy( hfdi, pszCabinet, pszCabPath, flags, pfnfdin, pfnfdid, pvUser);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 3664, 3961);
return return_v;
}


int
f_1144_3978_4013(System.IntPtr
hglobal)
{
Marshal.FreeHGlobal( hglobal);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 3978, 4013);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,3464,4055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,3464,4055);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void populateDelegates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1144,4179,5889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,4621,4703);

_allocDelegate = new CabinetNativeApi.FdiAllocDelegate(CabinetNativeApi.FdiAlloc);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,4717,4766);

_fdiAllocHandle = GCHandle.Alloc(_allocDelegate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,4782,4861);

_freeDelegate = new CabinetNativeApi.FdiFreeDelegate(CabinetNativeApi.FdiFree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,4875,4922);

_fdiFreeHandle = GCHandle.Alloc(_freeDelegate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,4938,5017);

_openDelegate = new CabinetNativeApi.FdiOpenDelegate(CabinetNativeApi.FdiOpen);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5031,5078);

_fdiOpenHandle = GCHandle.Alloc(_openDelegate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5094,5173);

_readDelegate = new CabinetNativeApi.FdiReadDelegate(CabinetNativeApi.FdiRead);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5187,5234);

_fdiReadHandle = GCHandle.Alloc(_readDelegate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5250,5332);

_writeDelegate = new CabinetNativeApi.FdiWriteDelegate(CabinetNativeApi.FdiWrite);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5346,5395);

_fdiWriteHandle = GCHandle.Alloc(_writeDelegate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5411,5493);

_closeDelegate = new CabinetNativeApi.FdiCloseDelegate(CabinetNativeApi.FdiClose);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5507,5556);

_fdiCloseHandle = GCHandle.Alloc(_closeDelegate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5572,5651);

_seekDelegate = new CabinetNativeApi.FdiSeekDelegate(CabinetNativeApi.FdiSeek);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5665,5712);

_fdiSeekHandle = GCHandle.Alloc(_seekDelegate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5728,5813);

_notifyDelegate = new CabinetNativeApi.FdiNotifyDelegate(CabinetNativeApi.FdiNotify);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,5827,5878);

_fdiNotifyHandle = GCHandle.Alloc(_notifyDelegate);
DynAbs.Tracing.TraceSender.TraceExitMethod(1144,4179,5889);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,4179,5889);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,4179,5889);
}
		}

private void CleanUpDelegates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1144,5993,6543);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6149,6532) || true) && (_fdiAllocHandle != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,6149,6532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6210,6233);

_fdiAllocHandle.Free();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6251,6273);

_fdiFreeHandle.Free();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6291,6313);

_fdiOpenHandle.Free();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6331,6353);

_fdiReadHandle.Free();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6371,6394);

_fdiWriteHandle.Free();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6412,6435);

_fdiCloseHandle.Free();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6453,6475);

_fdiSeekHandle.Free();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6493,6517);

_fdiNotifyHandle.Free();
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,6149,6532);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1144,5993,6543);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,5993,6543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,5993,6543);
}
		}

static CabinetExtractor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1144,253,6551);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1144,253,6551);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,253,6551);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1144,253,6551);

System.Management.Automation.Internal.CabinetNativeApi.FdiERF
f_1144_1484_1513()
{
var return_v = new System.Management.Automation.Internal.CabinetNativeApi.FdiERF();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 1484, 1513);
return return_v;
}


int
f_1144_1530_1549(System.Management.Automation.Internal.CabinetExtractor
this_param)
{
this_param.populateDelegates();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 1530, 1549);
return 0;
}


System.IntPtr
f_1144_1742_1795(System.Management.Automation.Internal.CabinetNativeApi.FdiAllocDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 1742, 1795);
return return_v;
}


System.IntPtr
f_1144_1814_1866(System.Management.Automation.Internal.CabinetNativeApi.FdiFreeDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 1814, 1866);
return return_v;
}


System.IntPtr
f_1144_1885_1937(System.Management.Automation.Internal.CabinetNativeApi.FdiOpenDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 1885, 1937);
return return_v;
}


System.IntPtr
f_1144_1956_2008(System.Management.Automation.Internal.CabinetNativeApi.FdiReadDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 1956, 2008);
return return_v;
}


System.IntPtr
f_1144_2027_2080(System.Management.Automation.Internal.CabinetNativeApi.FdiWriteDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 2027, 2080);
return return_v;
}


System.IntPtr
f_1144_2099_2152(System.Management.Automation.Internal.CabinetNativeApi.FdiCloseDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 2099, 2152);
return return_v;
}


System.IntPtr
f_1144_2171_2223(System.Management.Automation.Internal.CabinetNativeApi.FdiSeekDelegate
d)
{
var return_v = Marshal.GetFunctionPointerForDelegate( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 2171, 2223);
return return_v;
}


System.Management.Automation.Internal.CabinetNativeApi.FdiContextHandle
f_1144_1697_2307(System.IntPtr
pfnalloc,System.IntPtr
pfnfree,System.IntPtr
pfnopen,System.IntPtr
pfnread,System.IntPtr
pfnwrite,System.IntPtr
pfnclose,System.IntPtr
pfnseek,System.Management.Automation.Internal.CabinetNativeApi.FdiCreateCpuType
cpuType,System.Management.Automation.Internal.CabinetNativeApi.FdiERF
erf)
{
var return_v = CabinetNativeApi.FDICreate( pfnalloc, pfnfree, pfnopen, pfnread, pfnwrite, pfnclose, pfnseek, cpuType, erf);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 1697, 2307);
return return_v;
}


int
f_1144_3404_3418(System.Management.Automation.Internal.CabinetExtractor
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 3404, 3418);
return 0;
}

}
;internal class CabinetExtractorLoader : ICabinetExtractorLoader
{
private static CabinetExtractor s_extractorInstance;

private static CabinetExtractorLoader s_instance;

private static double s_created ;

internal static CabinetExtractorLoader GetInstance()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,6855,7205);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6932,7160) || true) && (0 == f_1144_6941_7006(ref s_created, 1, 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,6932,7160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,7040,7082);

s_instance = f_1144_7053_7081();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,7100,7145);

s_extractorInstance = f_1144_7122_7144();
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,6932,7160);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,7176,7194);

return s_instance;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,6855,7205);

double
f_1144_6941_7006(ref double
location1,int
value,int
comparand)
{
var return_v = System.Threading.Interlocked.CompareExchange( ref location1, (double)value, (double)comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 6941, 7006);
return return_v;
}


System.Management.Automation.Internal.CabinetExtractorLoader
f_1144_7053_7081()
{
var return_v = new System.Management.Automation.Internal.CabinetExtractorLoader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 7053, 7081);
return return_v;
}


System.Management.Automation.Internal.CabinetExtractor
f_1144_7122_7144()
{
var return_v = new System.Management.Automation.Internal.CabinetExtractor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 7122, 7144);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,6855,7205);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,6855,7205);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override ICabinetExtractor GetCabinetExtractor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1144,7217,7337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,7299,7326);

return s_extractorInstance;
DynAbs.Tracing.TraceSender.TraceExitMethod(1144,7217,7337);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,7217,7337);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,7217,7337);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public CabinetExtractorLoader()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1144,6606,7345);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1144,6606,7345);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,6606,7345);
}


static CabinetExtractorLoader()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1144,6606,7345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6718,6737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6786,6796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,6829,6842);
s_created = 0;DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1144,6606,7345);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,6606,7345);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1144,6606,7345);
}
;internal static class CabinetNativeApi
{        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate IntPtr FdiAllocDelegate(int size);

internal static IntPtr FdiAlloc(int size)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,7611,7882);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,7713,7747);

return f_1144_7720_7746(size);
            }
            catch (OutOfMemoryException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,7776,7871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,7837,7856);

return IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,7776,7871);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,7611,7882);

System.IntPtr
f_1144_7720_7746(int
cb)
{
var return_v = Marshal.AllocHGlobal( cb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 7720, 7746);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,7611,7882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,7611,7882);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void FdiFreeDelegate(IntPtr memblock);

internal static void FdiFree(IntPtr memblock)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,8047,8158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,8117,8147);

f_1144_8117_8146(memblock);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,8047,8158);

int
f_1144_8117_8146(System.IntPtr
hglobal)
{
Marshal.FreeHGlobal( hglobal);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 8117, 8146);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,8047,8158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,8047,8158);
}
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate IntPtr FdiOpenDelegate(
            [MarshalAs(UnmanagedType.LPStr)] string filename,
            int oflag,
            int pmode);

internal static IntPtr FdiOpen(string filename, int oflag, int pmode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,8420,9659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,8514,8578);

FileMode 
mode = f_1144_8530_8577(oflag)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,8594,8672);

FileAccess 
access = f_1144_8614_8671(pmode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,8686,8761);

FileShare 
share = f_1144_8704_8760(pmode)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9049,9222) || true) && (mode == FileMode.Open ||(DynAbs.Tracing.TraceSender.Expression_False(1144, 9053, 9107)||mode == FileMode.OpenOrCreate))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,9049,9222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9141,9166);

access = FileAccess.Read;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9184,9207);

share = FileShare.Read;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,9049,9222);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9274,9340);

FileStream 
stream = f_1144_9294_9339(filename, mode, access, share)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9360,9461) || true) && (stream == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,9360,9461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9420,9442);

return f_1144_9427_9441(-1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,9360,9461);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9481,9530);

return GCHandle.ToIntPtr(GCHandle.Alloc(stream));
            }
            catch (IOException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,9559,9648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,9611,9633);

return f_1144_9618_9632(-1);
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,9559,9648);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,8420,9659);

System.IO.FileMode
f_1144_8530_8577(int
oflag)
{
var return_v = CabinetNativeApi.ConvertOpflagToFileMode( oflag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 8530, 8577);
return return_v;
}


System.IO.FileAccess
f_1144_8614_8671(int
pmode)
{
var return_v = CabinetNativeApi.ConvertPermissionModeToFileAccess( pmode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 8614, 8671);
return return_v;
}


System.IO.FileShare
f_1144_8704_8760(int
pmode)
{
var return_v = CabinetNativeApi.ConvertPermissionModeToFileShare( pmode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 8704, 8760);
return return_v;
}


System.IO.FileStream
f_1144_9294_9339(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access,System.IO.FileShare
share)
{
var return_v = new System.IO.FileStream( path, mode, access, share);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 9294, 9339);
return return_v;
}


System.IntPtr
f_1144_9427_9441(int
value)
{
var return_v = new System.IntPtr( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 9427, 9441);
return return_v;
}


System.IntPtr
f_1144_9618_9632(int
value)
{
var return_v = new System.IntPtr( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 9618, 9632);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,8420,9659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,8420,9659);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int FdiReadDelegate(
            IntPtr fp,
            [In, Out]
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.U1)]
            byte[] buffer,
            int count);

internal static int FdiRead(IntPtr fp, byte[] buffer, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,10007,10827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10096,10138);

GCHandle 
handle = GCHandle.FromIntPtr(fp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10152,10198);

FileStream 
stream = (FileStream)handle.Target
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10214,10240);

int 
numCharactersRead = 0
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10290,10340);

numCharactersRead = f_1144_10310_10339(stream, buffer, 0, count);
            }
            catch (ArgumentNullException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,10369,10426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10401,10424);

numCharactersRead = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,10369,10426);
}
            catch (ArgumentOutOfRangeException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,10440,10503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10478,10501);

numCharactersRead = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,10440,10503);
}
            catch (NotSupportedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,10517,10574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10549,10572);

numCharactersRead = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,10517,10574);
}
            catch (IOException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,10588,10635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10610,10633);

numCharactersRead = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,10588,10635);
}
            catch (ArgumentException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,10649,10702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10677,10700);

numCharactersRead = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,10649,10702);
}
            catch (ObjectDisposedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,10716,10775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10750,10773);

numCharactersRead = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,10716,10775);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,10791,10816);

return numCharactersRead;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,10007,10827);

int
f_1144_10310_10339(System.IO.FileStream
this_param,byte[]
array,int
offset,int
count)
{
var return_v = this_param.Read( array, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 10310, 10339);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,10007,10827);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,10007,10827);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int FdiWriteDelegate(
            IntPtr fp,
            [In]
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.U1)]
            byte[] buffer,
            int count);

internal static int FdiWrite(IntPtr fp, byte[] buffer, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,11171,12157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11261,11303);

GCHandle 
handle = GCHandle.FromIntPtr(fp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11317,11363);

FileStream 
stream = (FileStream)handle.Target
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11379,11408);

int 
numCharactersWritten = 0
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11458,11489);

f_1144_11458_11488(                stream, buffer, 0, count);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11507,11536);

numCharactersWritten = count;
            }
            catch (ArgumentNullException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,11678,11738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11710,11736);

numCharactersWritten = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,11678,11738);
}
            catch (ArgumentOutOfRangeException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,11752,11818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11790,11816);

numCharactersWritten = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,11752,11818);
}
            catch (NotSupportedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,11832,11892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11864,11890);

numCharactersWritten = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,11832,11892);
}
            catch (IOException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,11906,11956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11928,11954);

numCharactersWritten = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,11906,11956);
}
            catch (ArgumentException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,11970,12026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,11998,12024);

numCharactersWritten = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,11970,12026);
}
            catch (ObjectDisposedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,12040,12102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12074,12100);

numCharactersWritten = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,12040,12102);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12118,12146);

return numCharactersWritten;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,11171,12157);

int
f_1144_11458_11488(System.IO.FileStream
this_param,byte[]
array,int
offset,int
count)
{
this_param.Write( array, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 11458, 11488);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,11171,12157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,11171,12157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int FdiCloseDelegate(IntPtr fp);

internal static int FdiClose(IntPtr fp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,12316,12696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12380,12422);

GCHandle 
handle = GCHandle.FromIntPtr(fp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12436,12482);

FileStream 
stream = (FileStream)handle.Target
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12498,12685) || true) && (stream == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,12498,12685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12550,12560);

return -1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,12498,12685);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,12498,12685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12626,12643);

f_1144_12626_12642(                stream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12661,12670);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,12498,12685);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,12316,12696);

int
f_1144_12626_12642(System.IO.FileStream
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 12626, 12642);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,12316,12696);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,12316,12696);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int FdiSeekDelegate(IntPtr fp, int offset, int origin);

internal static int FdiSeek(IntPtr fp, int offset, int origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,12878,13568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,12965,13007);

GCHandle 
handle = GCHandle.FromIntPtr(fp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13021,13067);

FileStream 
stream = (FileStream)handle.Target
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13083,13158);

SeekOrigin 
seekOrigin = f_1144_13107_13157(origin)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13172,13188);

long 
status = 0
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13238,13279);

status = f_1144_13247_13278(stream, offset, seekOrigin);
            }
            catch (NotSupportedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,13308,13354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13340,13352);

status = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,13308,13354);
}
            catch (IOException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,13368,13404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13390,13402);

status = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,13368,13404);
}
            catch (ArgumentException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,13418,13460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13446,13458);

status = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,13418,13460);
}
            catch (ObjectDisposedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1144,13474,13522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13508,13520);

status = -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1144,13474,13522);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13538,13557);

return (int)status;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,12878,13568);

System.IO.SeekOrigin
f_1144_13107_13157(int
origin)
{
var return_v = CabinetNativeApi.ConvertOriginToSeekOrigin( origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 13107, 13157);
return return_v;
}


long
f_1144_13247_13278(System.IO.FileStream
this_param,int
offset,System.IO.SeekOrigin
origin)
{
var return_v = this_param.Seek( (long)offset, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 13247, 13278);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,12878,13568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,12878,13568);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate IntPtr FdiNotifyDelegate(FdiNotificationType fdint, FdiNotification fdin);

internal static IntPtr FdiNotify(FdiNotificationType fdint, FdiNotification fdin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,13806,17306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,13912,17258);

switch (fdint)
            {

case FdiNotificationType.FdintCOPY_FILE:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,13912,17258);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,14183,14234);

string 
destPath = f_1144_14201_14233(fdin.pv)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,14328,14374);

string 
fileName = f_1144_14346_14373(fdin.psz1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,14400,14460);

string 
remainingPsz1Path = f_1144_14427_14459(fdin.psz1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,14486,14539);

destPath = f_1144_14497_14538(destPath, remainingPsz1Path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,14567,14603);

f_1144_14567_14602(destPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,14729,14788);

string 
absoluteFilePath = f_1144_14755_14787(destPath, fileName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,14814,14936);

return f_1144_14821_14935(absoluteFilePath, OpFlags.Create, (PermissionMode.Read | PermissionMode.Write));
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,13912,17258);

case FdiNotificationType.FdintCLOSE_FILE_INFO:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,13912,17258);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,15175,15210);

f_1144_15175_15209(fdin.hf);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,15290,15341);

string 
destPath = f_1144_15308_15340(fdin.pv)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,15367,15427);

string 
absoluteFilePath = f_1144_15393_15426(destPath, fdin.psz1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,15455,15970);

IntPtr 
hFile = f_1144_15470_15969(absoluteFilePath, PlatformInvokes.FileDesiredAccess.GenericRead | PlatformInvokes.FileDesiredAccess.GenericWrite, PlatformInvokes.FileShareMode.Read, IntPtr.Zero, PlatformInvokes.FileCreationDisposition.OpenExisting, PlatformInvokes.FileAttributes.Normal, IntPtr.Zero)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,15998,16765) || true) && (hFile != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,15998,16765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,16080,16145);

PlatformInvokes.FILETIME 
ftFile = f_1144_16114_16144()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,16175,16671) || true) && (f_1144_16179_16246(fdin.date, fdin.time, ftFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,16175,16671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,16312,16378);

PlatformInvokes.FILETIME 
ftLocal = f_1144_16347_16377()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,16412,16640) || true) && (f_1144_16416_16472(ftFile, ftLocal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,16412,16640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,16546,16605);

f_1144_16546_16604(hFile, ftLocal, null, ftLocal);
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,16412,16640);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,16175,16671);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,16703,16738);

f_1144_16703_16737(hFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,15998,16765);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,16793,17116);

f_1144_16793_17115(absoluteFilePath, (PlatformInvokes.FileAttributes)fdin.attribs & (PlatformInvokes.FileAttributes.ReadOnly | PlatformInvokes.FileAttributes.Hidden | PlatformInvokes.FileAttributes.System | PlatformInvokes.FileAttributes.Archive));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,17199,17220);

return f_1144_17206_17219(1);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,13912,17258);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,17274,17295);

return f_1144_17281_17294(0);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,13806,17306);

string?
f_1144_14201_14233(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStringAnsi( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 14201, 14233);
return return_v;
}


string?
f_1144_14346_14373(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 14346, 14373);
return return_v;
}


string?
f_1144_14427_14459(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 14427, 14459);
return return_v;
}


string
f_1144_14497_14538(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 14497, 14538);
return return_v;
}


System.IO.DirectoryInfo
f_1144_14567_14602(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 14567, 14602);
return return_v;
}


string
f_1144_14755_14787(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 14755, 14787);
return return_v;
}


System.IntPtr
f_1144_14821_14935(string
filename,System.Management.Automation.Internal.CabinetNativeApi.OpFlags
oflag,System.Management.Automation.Internal.CabinetNativeApi.PermissionMode
pmode)
{
var return_v = CabinetNativeApi.FdiOpen( filename, (int)oflag, (int)pmode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 14821, 14935);
return return_v;
}


int
f_1144_15175_15209(System.IntPtr
fp)
{
var return_v = CabinetNativeApi.FdiClose( fp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 15175, 15209);
return return_v;
}


string?
f_1144_15308_15340(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStringAnsi( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 15308, 15340);
return return_v;
}


string
f_1144_15393_15426(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 15393, 15426);
return return_v;
}


System.IntPtr
f_1144_15470_15969(string
lpFileName,System.Management.Automation.PlatformInvokes.FileDesiredAccess
dwDesiredAccess,System.Management.Automation.PlatformInvokes.FileShareMode
dwShareMode,System.IntPtr
lpSecurityAttributes,System.Management.Automation.PlatformInvokes.FileCreationDisposition
dwCreationDisposition,System.Management.Automation.PlatformInvokes.FileAttributes
dwFlagsAndAttributes,System.IntPtr
hTemplateFile)
{
var return_v = PlatformInvokes.CreateFile( lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 15470, 15969);
return return_v;
}


System.Management.Automation.PlatformInvokes.FILETIME
f_1144_16114_16144()
{
var return_v = new System.Management.Automation.PlatformInvokes.FILETIME();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 16114, 16144);
return return_v;
}


bool
f_1144_16179_16246(short
wFatDate,short
wFatTime,System.Management.Automation.PlatformInvokes.FILETIME
lpFileTime)
{
var return_v = PlatformInvokes.DosDateTimeToFileTime( wFatDate, wFatTime, lpFileTime);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 16179, 16246);
return return_v;
}


System.Management.Automation.PlatformInvokes.FILETIME
f_1144_16347_16377()
{
var return_v = new System.Management.Automation.PlatformInvokes.FILETIME();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 16347, 16377);
return return_v;
}


bool
f_1144_16416_16472(System.Management.Automation.PlatformInvokes.FILETIME
lpLocalFileTime,System.Management.Automation.PlatformInvokes.FILETIME
lpFileTime)
{
var return_v = PlatformInvokes.LocalFileTimeToFileTime( lpLocalFileTime, lpFileTime);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 16416, 16472);
return return_v;
}


bool
f_1144_16546_16604(System.IntPtr
hFile,System.Management.Automation.PlatformInvokes.FILETIME
lpCreationTime,System.Management.Automation.PlatformInvokes.FILETIME
lpLastAccessTime,System.Management.Automation.PlatformInvokes.FILETIME
lpLastWriteTime)
{
var return_v = PlatformInvokes.SetFileTime( hFile, lpCreationTime, lpLastAccessTime, lpLastWriteTime);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 16546, 16604);
return return_v;
}


bool
f_1144_16703_16737(System.IntPtr
handle)
{
var return_v = PlatformInvokes.CloseHandle( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 16703, 16737);
return return_v;
}


bool
f_1144_16793_17115(string
lpFileName,System.Management.Automation.PlatformInvokes.FileAttributes
dwFileAttributes)
{
var return_v = PlatformInvokes.SetFileAttributesW( lpFileName, dwFileAttributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 16793, 17115);
return return_v;
}


System.IntPtr
f_1144_17206_17219(int
value)
{
var return_v = new System.IntPtr( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 17206, 17219);
return return_v;
}


System.IntPtr
f_1144_17281_17294(int
value)
{
var return_v = new System.IntPtr( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 17281, 17294);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,13806,17306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,13806,17306);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SeekOrigin ConvertOriginToSeekOrigin(int origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,17657,18131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,17746,18120);

switch (origin)
            {

case 0x0: // SEEK_SET
DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,17746,18120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,17837,17861);

return SeekOrigin.Begin;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,17746,18120);

case 0x1: // SEEK_CUR
DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,17746,18120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,17922,17948);

return SeekOrigin.Current;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,17746,18120);

case 0x2: // SEEK_END
DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,17746,18120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,18009,18031);

return SeekOrigin.End;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,17746,18120);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,17746,18120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,18079,18105);

return SeekOrigin.Current;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,17746,18120);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,17657,18131);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,17657,18131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,17657,18131);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static FileMode ConvertOpflagToFileMode(int oflag)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,18408,19623);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,18581,19612) || true) && ((int)(OpFlags.Create | OpFlags.Excl) == (oflag & (int)(OpFlags.Create | OpFlags.Excl)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,18581,19612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,18705,18731);

return FileMode.CreateNew;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,18581,19612);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,18581,19612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,18765,19612) || true) && ((int)(OpFlags.Create | OpFlags.Truncate) == (oflag & (int)(OpFlags.Create | OpFlags.Truncate)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,18765,19612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,18897,18926);

return FileMode.OpenOrCreate;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,18765,19612);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,18765,19612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,18960,19612) || true) && (0 != (oflag & (int)OpFlags.Append))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,18960,19612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19032,19055);

return FileMode.Append;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,18960,19612);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,18960,19612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19089,19612) || true) && (0 != (oflag & (int)OpFlags.Create))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,19089,19612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19161,19184);

return FileMode.Create;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,19089,19612);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,19089,19612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19218,19612) || true) && (0 != (oflag & (int)OpFlags.RdWr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,19218,19612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19288,19309);

return FileMode.Open;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,19218,19612);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,19218,19612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19343,19612) || true) && (0 != (oflag & (int)OpFlags.Truncate))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,19343,19612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19417,19442);

return FileMode.Truncate;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,19343,19612);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,19343,19612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,19508,19537);

return FileMode.OpenOrCreate;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,19343,19612);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,19218,19612);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,19089,19612);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,18960,19612);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,18765,19612);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,18581,19612);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,18408,19623);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,18408,19623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,18408,19623);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static FileAccess ConvertPermissionModeToFileAccess(int pmode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,19902,20650);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,20087,20639) || true) && ((int)(PermissionMode.Read | PermissionMode.Write) == (pmode & (int)(PermissionMode.Read | PermissionMode.Write)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,20087,20639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,20237,20265);

return FileAccess.ReadWrite;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,20087,20639);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,20087,20639);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,20299,20639) || true) && (0 != (pmode & (int)PermissionMode.Read))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,20299,20639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,20376,20399);

return FileAccess.Read;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,20299,20639);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,20299,20639);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,20433,20639) || true) && (0 != (pmode & (int)PermissionMode.Write))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,20433,20639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,20511,20535);

return FileAccess.Write;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,20433,20639);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,20433,20639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,20601,20624);

return FileAccess.Read;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,20433,20639);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,20299,20639);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,20087,20639);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,19902,20650);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,19902,20650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,19902,20650);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static FileShare ConvertPermissionModeToFileShare(int pmode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1144,20928,21670);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,21111,21659) || true) && ((int)(PermissionMode.Read | PermissionMode.Write) == (pmode & (int)(PermissionMode.Read | PermissionMode.Write)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,21111,21659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,21261,21288);

return FileShare.ReadWrite;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,21111,21659);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,21111,21659);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,21322,21659) || true) && (0 != (pmode & (int)PermissionMode.Read))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,21322,21659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,21399,21421);

return FileShare.Read;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,21322,21659);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,21322,21659);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,21455,21659) || true) && (0 != (pmode & (int)PermissionMode.Write))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,21455,21659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,21533,21556);

return FileShare.Write;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,21455,21659);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1144,21455,21659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,21622,21644);

return FileShare.Read;
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,21455,21659);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,21322,21659);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1144,21111,21659);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1144,20928,21670);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,20928,21670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,20928,21670);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        
        
        [FlagsAttribute]
        internal enum PermissionMode : int
        {
            None = 0x0000,
            Write = 0x0080,
            Read = 0x0100
        }

        [FlagsAttribute]
        internal enum OpFlags : int
        {
            RdOnly = 0x0000,
            WrOnly = 0x0001,
            RdWr = 0x0002,
            Append = 0x0008,
            Create = 0x0100,
            Truncate = 0x0200,
            Excl = 0x0400
        }

        internal enum FdiCreateCpuType : int
        {
            CpuUnknown = -1,
            Cpu80286 = 0,
            Cpu80386 = 1
        }
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        internal class FdiNotification
{
internal int cb;

internal string psz1;

internal string psz2;

internal string psz3;

internal IntPtr pv;

internal IntPtr hf;

internal short date;

internal short time;

internal short attribs;

internal short setID;

internal short iCabinet;

internal short iFolder;

internal int fdie;

public FdiNotification()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1144,22382,23145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22521,22523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22562,22566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22611,22615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22660,22664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22843,22847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22887,22891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22931,22938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,22978,22983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,23023,23031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,23071,23078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,23116,23120);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1144,22382,23145);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,22382,23145);
}


static FdiNotification()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1144,22382,23145);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1144,22382,23145);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,22382,23145);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1144,22382,23145);
}
;
        internal enum FdiNotificationType : int
        {
            FdintCABINET_INFO = 0x0,
            FdintPARTIAL_FILE = 0x1,
            FdintCOPY_FILE = 0x2,
            FdintCLOSE_FILE_INFO = 0x3,
            FdintNEXT_CABINET = 0x4,
            FdintENUMERATE = 0x5
        }
[StructLayout(LayoutKind.Sequential)]
        internal class FdiERF
{
internal int erfOper;

internal int erfType;

internal bool fError;

public FdiERF()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1144,23454,23650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,23560,23567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,23595,23602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,23631,23637);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1144,23454,23650);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,23454,23650);
}


static FdiERF()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1144,23454,23650);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1144,23454,23650);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,23454,23650);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1144,23454,23650);
}
;internal sealed class FdiContextHandle : SafeHandleZeroOrMinusOneIsInvalid
{
private FdiContextHandle()
:base(f_1144_23812_23816_C(true) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1144,23761,23847);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1144,23761,23847);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,23761,23847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,23761,23847);
}
		}

protected override bool ReleaseHandle()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1144,23863,23998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1144,23935,23983);

return f_1144_23942_23982(this.handle);
DynAbs.Tracing.TraceSender.TraceExitMethod(1144,23863,23998);

bool
f_1144_23942_23982(System.IntPtr
hfdi)
{
var return_v = CabinetNativeApi.FDIDestroy( hfdi);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1144, 23942, 23982);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1144,23863,23998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,23863,23998);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static FdiContextHandle()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1144,23662,24009);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1144,23662,24009);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,23662,24009);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1144,23662,24009);

static bool
f_1144_23812_23816_C(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1144, 23761, 23847);
return return_v;
}

}

[DllImport("cabinet.dll", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        internal static extern FdiContextHandle FDICreate(
            IntPtr pfnalloc,
            IntPtr pfnfree,
            IntPtr pfnopen,
            IntPtr pfnread,
            IntPtr pfnwrite,
            IntPtr pfnclose,
            IntPtr pfnseek,
            CabinetNativeApi.FdiCreateCpuType cpuType,
            FdiERF erf);

[DllImport("cabinet.dll", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = true, BestFitMapping = false)]
        internal static extern bool FDICopy(
            FdiContextHandle hfdi,
            [MarshalAs(UnmanagedType.LPStr)] string pszCabinet,
            [MarshalAs(UnmanagedType.LPStr)] string pszCabPath,
            int flags,
            IntPtr pfnfdin,
            IntPtr pfnfdid,
            IntPtr pvUser);

[DllImport("cabinet.dll", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        internal static extern bool FDIDestroy(
            IntPtr hfdi);

static CabinetNativeApi()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1144,7353,27091);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1144,7353,27091);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1144,7353,27091);
}

}
}
