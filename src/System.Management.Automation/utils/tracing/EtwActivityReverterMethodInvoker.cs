// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Tracing
{
    using System;
internal class EtwActivityReverterMethodInvoker :
        IMethodInvoker
{
private readonly IEtwEventCorrelator _eventCorrelator;

private readonly Func<Guid, Delegate, object[], object> _invoker;

public EtwActivityReverterMethodInvoker(IEtwEventCorrelator eventCorrelator)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1052,509,833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,347,363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,430,438);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,610,737) || true) && (eventCorrelator == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1052,610,737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,671,722);

throw f_1052_677_721("eventCorrelator");
DynAbs.Tracing.TraceSender.TraceExitCondition(1052,610,737);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,753,788);

_eventCorrelator = eventCorrelator;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,802,822);

_invoker = DoInvoke;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1052,509,833);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1052,509,833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1052,509,833);
}
		}

public Delegate Invoker
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1052,950,974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,956,972);

return _invoker;
DynAbs.Tracing.TraceSender.TraceExitMethod(1052,950,974);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1052,902,985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1052,902,985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public object[] CreateInvokerArgs(Delegate methodToInvoke, object[] methodToInvokeArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1052,997,1407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,1171,1358);

var 
retInvokerArgs = new object[]
            {
f_1052_1237_1271(_eventCorrelator),
                methodToInvoke,
                methodToInvokeArgs,
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,1374,1396);

return retInvokerArgs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1052,997,1407);

System.Guid
f_1052_1237_1271(System.Management.Automation.Tracing.IEtwEventCorrelator
this_param)
{
var return_v = this_param.CurrentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1052, 1237, 1271);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1052,997,1407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1052,997,1407);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object DoInvoke(Guid relatedActivityId, Delegate method, object[] methodArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1052,1479,1745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,1589,1734);
using(f_1052_1596_1645(_eventCorrelator, relatedActivityId))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1052,1679,1719);

return f_1052_1686_1718(method, methodArgs);
DynAbs.Tracing.TraceSender.TraceExitUsing(1052,1589,1734);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1052,1479,1745);

System.Management.Automation.Tracing.IEtwActivityReverter
f_1052_1596_1645(System.Management.Automation.Tracing.IEtwEventCorrelator
this_param,System.Guid
relatedActivityId)
{
var return_v = this_param.StartActivity( relatedActivityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1052, 1596, 1645);
return return_v;
}


object?
f_1052_1686_1718(System.Delegate
this_param,params object[]
args)
{
var return_v = this_param.DynamicInvoke( args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1052, 1686, 1718);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1052,1479,1745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1052,1479,1745);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static EtwActivityReverterMethodInvoker()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1052,187,1774);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1052,187,1774);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1052,187,1774);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1052,187,1774);

System.ArgumentNullException
f_1052_677_721(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1052, 677, 721);
return return_v;
}

}
}

