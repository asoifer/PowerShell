// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
public class RunspaceRepository : Repository<PSSession>
{
public List<PSSession> Runspaces
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1610,599,663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1610,635,648);

return f_1610_642_647();
DynAbs.Tracing.TraceSender.TraceExitMethod(1610,599,663);

System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1610_642_647()
{
var return_v = Items;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1610, 642, 647);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1610,542,674);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1610,542,674);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal RunspaceRepository() :base(f_1610_878_888_C("runspace") )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1610,841,911);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1610,841,911);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1610,841,911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1610,841,911);
}
		}

protected override Guid GetKey(PSSession item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1610,1092,1296);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1610,1163,1251) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1610,1163,1251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1610,1213,1236);

return f_1610_1220_1235(item);
DynAbs.Tracing.TraceSender.TraceExitCondition(1610,1163,1251);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1610,1267,1285);

return Guid.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1610,1092,1296);

System.Guid
f_1610_1220_1235(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1610, 1220, 1235);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1610,1092,1296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1610,1092,1296);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void AddOrReplace(PSSession item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1610,1539,1654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1610,1606,1643);

f_1610_1606_1621(this)[f_1610_1622_1634(this, item)] = item;
DynAbs.Tracing.TraceSender.TraceExitMethod(1610,1539,1654);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1610_1606_1621(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Dictionary;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1610, 1606, 1621);
return return_v;
}


System.Guid
f_1610_1622_1634(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
var return_v = this_param.GetKey( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1610, 1622, 1634);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1610,1539,1654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1610,1539,1654);
}
		}

static RunspaceRepository()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1610,341,1699);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1610,341,1699);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1610,341,1699);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1610,341,1699);

static string
f_1610_878_888_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1610, 841, 911);
return return_v;
}

}
}
