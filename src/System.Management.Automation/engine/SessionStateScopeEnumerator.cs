// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;

namespace System.Management.Automation
{
internal sealed class SessionStateScopeEnumerator : IEnumerator<SessionStateScope>, IEnumerable<SessionStateScope>
{
internal SessionStateScopeEnumerator(SessionStateScope scope)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1356,676,878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,3390,3403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,3440,3463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,762,831);

f_1356_762_830(scope != null, "Caller to verify scope argument");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,845,867);

_initialScope = scope;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1356,676,878);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,676,878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,676,878);
}
		}

public bool MoveNext()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1356,1158,1702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,1397,1504);

_currentEnumeratedScope = (DynAbs.Tracing.TraceSender.Conditional_F1(1356, 1423, 1454)||((_currentEnumeratedScope == null &&DynAbs.Tracing.TraceSender.Conditional_F2(1356, 1457, 1470))||DynAbs.Tracing.TraceSender.Conditional_F3(1356, 1473, 1503)))?_initialScope :f_1356_1473_1503(_currentEnumeratedScope);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,1650,1691);

return (_currentEnumeratedScope != null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1356,1158,1702);

System.Management.Automation.SessionStateScope
f_1356_1473_1503(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1356, 1473, 1503);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,1158,1702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,1158,1702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1356,1821,1907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,1865,1896);

_currentEnumeratedScope = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1356,1821,1907);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,1821,1907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,1821,1907);
}
		}

SessionStateScope IEnumerator<SessionStateScope>.Current
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1356,2300,2549);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,2336,2483) || true) && (_currentEnumeratedScope == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1356,2336,2483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,2413,2464);

throw f_1356_2419_2463();
DynAbs.Tracing.TraceSender.TraceExitCondition(1356,2336,2483);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,2503,2534);

return _currentEnumeratedScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1356,2300,2549);

System.Management.Automation.PSInvalidOperationException
f_1356_2419_2463()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1356, 2419, 2463);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,2219,2560);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,2219,2560);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

object IEnumerator.Current
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1356,2623,2728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,2659,2713);

return f_1356_2666_2712(((IEnumerator<SessionStateScope>)this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1356,2623,2728);

System.Management.Automation.SessionStateScope
f_1356_2666_2712(System.Collections.Generic.IEnumerator<System.Management.Automation.SessionStateScope>
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1356, 2666, 2712);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,2572,2739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,2572,2739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

System.Collections.Generic.IEnumerator<SessionStateScope> System.Collections.Generic.IEnumerable<SessionStateScope>.GetEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1356,2950,3129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,3106,3118);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(1356,2950,3129);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,2950,3129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,2950,3129);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1356,3141,3266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,3243,3255);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(1356,3141,3266);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,3141,3266);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,3141,3266);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1356,3278,3343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1356,3324,3332);

f_1356_3324_3331(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1356,3278,3343);

int
f_1356_3324_3331(System.Management.Automation.SessionStateScopeEnumerator
this_param)
{
this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1356, 3324, 3331);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1356,3278,3343);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,3278,3343);
}
		}

private readonly SessionStateScope _initialScope;

private SessionStateScope _currentEnumeratedScope;

static SessionStateScopeEnumerator()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1356,211,3471);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1356,211,3471);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1356,211,3471);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1356,211,3471);

int
f_1356_762_830(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1356, 762, 830);
return 0;
}

}
}

