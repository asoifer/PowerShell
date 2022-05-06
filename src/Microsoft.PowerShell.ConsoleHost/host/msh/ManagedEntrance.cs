// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.PowerShell
{
public sealed class UnmanagedPSEntry
{
public static int Start(string consoleFilePath, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 2)]string[] args, int argc)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(122,1065,4161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,1329,1349);

f_122_1329_1348();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,1449,1493);

f_122_1449_1492(args);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,1683,1712);

f_122_1683_1711();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2254,2326);

f_122_2254_2274().CurrentUICulture = f_122_2294_2325();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2340,2408);

f_122_2340_2360().CurrentCulture = f_122_2378_2407();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2435,2858) || true) && (f_122_2439_2450(args)> 0 &&(DynAbs.Tracing.TraceSender.Expression_True(122, 2439, 2488)&&!f_122_2459_2488(args[0]))&&(DynAbs.Tracing.TraceSender.Expression_True(122, 2439, 2554)&&f_122_2492_2554(args[0], "-isswait", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(122,2435,2858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2588,2644);

f_122_2588_2643("Attach the debugger to continue...");
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2662,2787) || true) && (f_122_2669_2708_M(!System.Diagnostics.Debugger.IsAttached))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(122,2662,2787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2750,2768);

f_122_2750_2767(100);
DynAbs.Tracing.TraceSender.TraceExitCondition(122,2662,2787);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(122,2662,2787);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(122,2662,2787);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2807,2843);

f_122_2807_2842();
DynAbs.Tracing.TraceSender.TraceExitCondition(122,2435,2858);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2880,2897);

int 
exitCode = 0
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,2947,3151);

var 
banner = f_122_2960_3150(f_122_2996_3024(), f_122_3047_3101(), f_122_3124_3149())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,3171,3249);

exitCode = f_122_3182_3248(banner, f_122_3209_3241(), args);
            }
            catch (HostException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(122,3278,3995);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,3334,3918) || true) && (f_122_3338_3354(e)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(122, 3338, 3418)&&f_122_3366_3392(f_122_3366_3382(e))== typeof(Win32Exception)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(122,3334,3918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,3460,3519);

Win32Exception 
win32e = f_122_3484_3500(e)as Win32Exception
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,3743,3899) || true) && (f_122_3747_3769(win32e)== 0x6 ||(DynAbs.Tracing.TraceSender.Expression_False(122, 3747, 3810)||f_122_3780_3802(win32e)== 1236))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(122,3743,3899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,3860,3876);

return exitCode;
DynAbs.Tracing.TraceSender.TraceExitCondition(122,3743,3899);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(122,3334,3918);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,3938,3980);

f_122_3938_3979(f_122_3966_3975(e), e);
DynAbs.Tracing.TraceSender.TraceExitCatch(122,3278,3995);
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(122,4009,4118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,4061,4103);

f_122_4061_4102(f_122_4089_4098(e), e);
DynAbs.Tracing.TraceSender.TraceExitCatch(122,4009,4118);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(122,4134,4150);

return exitCode;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(122,1065,4161);

int
f_122_1329_1348()
{
EarlyStartup.Init();
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 1329, 1348);
return 0;
}


int
f_122_1449_1492(string[]
args)
{
CommandLineParameterParser.EarlyParse( args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 1449, 1492);
return 0;
}


int
f_122_1683_1711()
{
PSEtwLog.LogConsoleStartup();
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 1683, 1711);
return 0;
}


System.Threading.Thread
f_122_2254_2274()
{
var return_v = 
            // Windows Vista and later support non-traditional UI fallback ie., a
            // user on an Arabic machine can choose either French or English(US) as
            // UI fallback language.
            // CLR does not support this (non-traditional) fallback mechanism.
            // The currentUICulture returned NativeCultureResolver supports this non
            // traditional fallback on Vista. So it is important to set currentUICulture
            // in the beginning before we do anything.
            Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 2254, 2274);
return return_v;
}


System.Globalization.CultureInfo
f_122_2294_2325()
{
var return_v = NativeCultureResolver.UICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 2294, 2325);
return return_v;
}


System.Threading.Thread
f_122_2340_2360()
{
var return_v =             Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 2340, 2360);
return return_v;
}


System.Globalization.CultureInfo
f_122_2378_2407()
{
var return_v = NativeCultureResolver.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 2378, 2407);
return return_v;
}


int
f_122_2439_2450(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 2439, 2450);
return return_v;
}


bool
f_122_2459_2488(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 2459, 2488);
return return_v;
}


bool
f_122_2492_2554(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 2492, 2554);
return return_v;
}


int
f_122_2588_2643(string
value)
{
Console.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 2588, 2643);
return 0;
}


bool
f_122_2669_2708_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 2669, 2708);
return return_v;
}


int
f_122_2750_2767(int
millisecondsTimeout)
{
Thread.Sleep( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 2750, 2767);
return 0;
}


int
f_122_2807_2842()
{
System.Diagnostics.Debugger.Break();
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 2807, 2842);
return 0;
}


System.Globalization.CultureInfo
f_122_2996_3024()
{
var return_v =                     CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 2996, 3024);
return return_v;
}


string
f_122_3047_3101()
{
var return_v =                     ManagedEntranceStrings.ShellBannerNonWindowsPowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3047, 3101);
return return_v;
}


string
f_122_3124_3149()
{
var return_v =                     PSVersionInfo.GitCommitId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3124, 3149);
return return_v;
}


string
f_122_2960_3150(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 2960, 3150);
return return_v;
}


string
f_122_3209_3241()
{
var return_v = ManagedEntranceStrings.UsageHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3209, 3241);
return return_v;
}


int
f_122_3182_3248(string
bannerText,string
helpText,string[]
args)
{
var return_v = ConsoleShell.Start( bannerText, helpText, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 3182, 3248);
return return_v;
}


System.Exception
f_122_3338_3354(System.Management.Automation.Host.HostException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3338, 3354);
return return_v;
}


System.Exception
f_122_3366_3382(System.Management.Automation.Host.HostException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3366, 3382);
return return_v;
}


System.Type
f_122_3366_3392(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 3366, 3392);
return return_v;
}


System.Exception
f_122_3484_3500(System.Management.Automation.Host.HostException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3484, 3500);
return return_v;
}


int
f_122_3747_3769(System.ComponentModel.Win32Exception
this_param)
{
var return_v = this_param.NativeErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3747, 3769);
return return_v;
}


int
f_122_3780_3802(System.ComponentModel.Win32Exception
this_param)
{
var return_v = this_param.NativeErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3780, 3802);
return return_v;
}


string
f_122_3966_3975(System.Management.Automation.Host.HostException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 3966, 3975);
return return_v;
}


int
f_122_3938_3979(string
message,System.Management.Automation.Host.HostException
exception)
{
System.Environment.FailFast( message, (System.Exception)exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 3938, 3979);
return 0;
}


string
f_122_4089_4098(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(122, 4089, 4098);
return return_v;
}


int
f_122_4061_4102(string
message,System.Exception
exception)
{
System.Environment.FailFast( message, exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(122, 4061, 4102);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(122,1065,4161);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122,1065,4161);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public UnmanagedPSEntry()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(122,557,4168);
DynAbs.Tracing.TraceSender.TraceExitConstructor(122,557,4168);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122,557,4168);
}


static UnmanagedPSEntry()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(122,557,4168);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(122,557,4168);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(122,557,4168);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(122,557,4168);
}
}

