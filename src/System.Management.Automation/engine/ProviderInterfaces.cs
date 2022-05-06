// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
public sealed class CmdletProviderManagementIntrinsics
{
private CmdletProviderManagementIntrinsics()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1318,757,1024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,5666,5679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,826,1013);

f_1318_826_1012(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
DynAbs.Tracing.TraceSender.TraceExitConstructor(1318,757,1024);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1318,757,1024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,757,1024);
}
		}

internal CmdletProviderManagementIntrinsics(SessionStateInternal sessionState)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1318,1383,1676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,5666,5679);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,1486,1620) || true) && (sessionState == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1318,1486,1620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,1544,1605);

throw f_1318_1550_1604("sessionState");
DynAbs.Tracing.TraceSender.TraceExitCondition(1318,1486,1620);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,1636,1665);

_sessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1318,1383,1676);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1318,1383,1676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,1383,1676);
}
		}

public Collection<ProviderInfo> Get(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1318,2414,2789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,2487,2648);

f_1318_2487_2647(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,2739,2778);

return f_1318_2746_2777(_sessionState, name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1318,2414,2789);

int
f_1318_2487_2647(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1318, 2487, 2647);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
f_1318_2746_2777(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.GetProvider( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1318, 2746, 2777);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1318,2414,2789);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,2414,2789);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ProviderInfo GetOne(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1318,3685,4057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,3749,3910);

f_1318_3749_3909(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,4001,4046);

return f_1318_4008_4045(_sessionState, name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1318,3685,4057);

int
f_1318_3749_3909(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1318, 3749, 3909);
return 0;
}


System.Management.Automation.ProviderInfo
f_1318_4008_4045(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.GetSingleProvider( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1318, 4008, 4045);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1318,3685,4057);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,3685,4057);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public IEnumerable<ProviderInfo> GetAll()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1318,4176,4464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,4242,4403);

f_1318_4242_4402(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,4419,4453);

return f_1318_4426_4452(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1318,4176,4464);

int
f_1318_4242_4402(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1318, 4242, 4402);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.ProviderInfo>
f_1318_4426_4452(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ProviderList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1318, 4426, 4452);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1318,4176,4464);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,4176,4464);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool CheckProviderCapabilities(
            ProviderCapabilities capability,
            ProviderInfo provider)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1318,5030,5283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,5223,5272);

return (f_1318_5231_5252(provider)& capability) != 0;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1318,5030,5283);

System.Management.Automation.Provider.ProviderCapabilities
f_1318_5231_5252(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Capabilities ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1318, 5231, 5252);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1318,5030,5283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,5030,5283);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal int Count
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1318,5457,5543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1318,5493,5528);

return f_1318_5500_5527(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1318,5457,5543);

int
f_1318_5500_5527(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ProviderCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1318, 5500, 5527);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1318,5414,5554);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,5414,5554);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private SessionStateInternal _sessionState;

static CmdletProviderManagementIntrinsics()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1318,512,5722);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1318,512,5722);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1318,512,5722);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1318,512,5722);

int
f_1318_826_1012(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1318, 826, 1012);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1318_1550_1604(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1318, 1550, 1604);
return return_v;
}

}
}

