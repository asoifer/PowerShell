// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation
{
internal abstract class HelpProviderWithFullCache : HelpProviderWithCache
{
internal HelpProviderWithFullCache(HelpSystem helpSystem) :base(f_1159_961_971_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1159,896,994);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1159,896,994);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1159,896,994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1159,896,994);
}
		}

internal sealed override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1159,1362,1672);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,1473,1560) || true) && (f_1159_1477_1499_M(!this.CacheFullyLoaded))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1159,1473,1560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,1533,1545);

f_1159_1533_1544(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1159,1473,1560);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,1576,1605);

this.CacheFullyLoaded = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,1621,1661);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ExactMatchHelp(helpRequest),1159,1628,1660);
DynAbs.Tracing.TraceSender.TraceExitMethod(1159,1362,1672);

bool
f_1159_1477_1499_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1159, 1477, 1499);
return return_v;
}


int
f_1159_1533_1544(System.Management.Automation.HelpProviderWithFullCache
this_param)
{
this_param.LoadCache();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1159, 1533, 1544);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1159,1362,1672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1159,1362,1672);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal sealed override void DoExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1159,1949,2042);
DynAbs.Tracing.TraceSender.TraceExitMethod(1159,1949,2042);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1159,1949,2042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1159,1949,2042);
}
		}

internal sealed override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1159,2677,3022);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,2808,2895) || true) && (f_1159_2812_2834_M(!this.CacheFullyLoaded))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1159,2808,2895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,2868,2880);

f_1159_2868_2879(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1159,2808,2895);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,2911,2940);

this.CacheFullyLoaded = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,2956,3011);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SearchHelp(helpRequest,searchOnlyContent),1159,2963,3010);
DynAbs.Tracing.TraceSender.TraceExitMethod(1159,2677,3022);

bool
f_1159_2812_2834_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1159, 2812, 2834);
return return_v;
}


int
f_1159_2868_2879(System.Management.Automation.HelpProviderWithFullCache
this_param)
{
this_param.LoadCache();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1159, 2868, 2879);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1159,2677,3022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1159,2677,3022);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal sealed override IEnumerable<HelpInfo> DoSearchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1159,3364,3496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1159,3473,3485);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1159,3364,3496);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1159,3364,3496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1159,3364,3496);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual void LoadCache()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1159,3914,3969);
DynAbs.Tracing.TraceSender.TraceExitMethod(1159,3914,3969);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1159,3914,3969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1159,3914,3969);
}
		}

static HelpProviderWithFullCache()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1159,703,3976);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1159,703,3976);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1159,703,3976);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1159,703,3976);

static System.Management.Automation.HelpSystem
f_1159_961_971_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1159, 896, 994);
return return_v;
}

}
}
