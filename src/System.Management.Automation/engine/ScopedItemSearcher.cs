// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation
{
internal abstract class ScopedItemSearcher<T> : IEnumerator<T>, IEnumerable<T>
{
internal ScopedItemSearcher(
            SessionStateInternal sessionState,
            VariablePath lookupPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1330,1120,1680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,5241,5254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,5512,5525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6885,6893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6935,6947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6979,6990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,7037,7053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,7077,7097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,7121,7135);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,1259,1393) || true) && (sessionState == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,1259,1393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,1317,1378);

throw f_1330_1323_1377("sessionState");
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,1259,1393);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,1409,1539) || true) && (lookupPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,1409,1539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,1465,1524);

throw f_1330_1471_1523("lookupPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,1409,1539);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,1555,1588);

this.sessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,1602,1627);

_lookupPath = lookupPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,1641,1669);

f_1330_1641_1668(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1330,1120,1680);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,1120,1680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,1120,1680);
}
		}

System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,1971,2118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2095,2107);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,1971,2118);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,1971,2118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,1971,2118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,2130,2255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2232,2244);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,2130,2255);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,2130,2255);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,2130,2255);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool MoveNext()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,2510,3438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2557,2576);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2592,2688) || true) && (!_isInitialized)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,2592,2688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2645,2673);

f_1330_2645_2672(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,2592,2688);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2781,3397) || true) && (f_1330_2788_2815(_scopeEnumerable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,2781,3397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2849,2866);

T 
newCurrentItem
=default(T);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,2886,3236) || true) && (f_1330_2890_2988(this, f_1330_2909_2967(((IEnumerator<SessionStateScope>)_scopeEnumerable)), out newCurrentItem))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,2886,3236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3030,3105);

_currentScope = f_1330_3046_3104(((IEnumerator<SessionStateScope>)_scopeEnumerable));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3127,3153);

_current = newCurrentItem;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3175,3189);

result = true;
DynAbs.Tracing.TraceSender.TraceBreak(1330,3211,3217);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,2886,3236);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3256,3271);

result = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3291,3382) || true) && (_isSingleScopeLookup)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,3291,3382);
DynAbs.Tracing.TraceSender.TraceBreak(1330,3357,3363);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,3291,3382);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,2781,3397);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1330,2781,3397);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1330,2781,3397);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3413,3427);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,2510,3438);

int
f_1330_2645_2672(System.Management.Automation.ScopedItemSearcher<T>
this_param)
{
this_param.InitializeScopeEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 2645, 2672);
return 0;
}


bool
f_1330_2788_2815(System.Management.Automation.SessionStateScopeEnumerator
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 2788, 2815);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_2909_2967(System.Collections.Generic.IEnumerator<System.Management.Automation.SessionStateScope>
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 2909, 2967);
return return_v;
}


bool
f_1330_2890_2988(System.Management.Automation.ScopedItemSearcher<T>
this_param,System.Management.Automation.SessionStateScope
lookupScope,out T
newCurrentItem)
{
var return_v = this_param.TryGetNewScopeItem( lookupScope, out newCurrentItem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 2890, 2988);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_3046_3104(System.Collections.Generic.IEnumerator<System.Management.Automation.SessionStateScope>
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 3046, 3104);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,2510,3438);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,2510,3438);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

T IEnumerator<T>.Current
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,3591,3658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3627,3643);

return _current;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,3591,3658);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,3542,3669);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,3542,3669);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public object Current
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,3727,3794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3763,3779);

return _current;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,3727,3794);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,3681,3805);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,3681,3805);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,3817,3900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3861,3889);

f_1330_3861_3888(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,3817,3900);

int
f_1330_3861_3888(System.Management.Automation.ScopedItemSearcher<T>
this_param)
{
this_param.InitializeScopeEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 3861, 3888);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,3817,3900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,3817,3900);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,3912,4147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3958,3980);

_current = default(T);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,3994,4021);

f_1330_3994_4020(            _scopeEnumerable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,4035,4059);

_scopeEnumerable = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,4073,4096);

_isInitialized = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,4110,4136);

f_1330_4110_4135(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,3912,4147);

int
f_1330_3994_4020(System.Management.Automation.SessionStateScopeEnumerator
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 3994, 4020);
return 0;
}


int
f_1330_4110_4135(System.Management.Automation.ScopedItemSearcher<T>
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 4110, 4135);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,3912,4147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,3912,4147);
}
		}

protected abstract bool GetScopeItem(
            SessionStateScope scope,
            VariablePath name,
            out T newCurrentItem);

internal SessionStateScope CurrentLookupScope
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,5163,5192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,5169,5190);

return _currentScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,5163,5192);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,5093,5203);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,5093,5203);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private SessionStateScope _currentScope;

internal SessionStateScope InitialScope
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,5434,5463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,5440,5461);

return _initialScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,5434,5463);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,5370,5474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,5370,5474);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private SessionStateScope _initialScope;

private bool TryGetNewScopeItem(
            SessionStateScope lookupScope,
            out T newCurrentItem)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,5573,5875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,5709,5834);

bool 
result = f_1330_5723_5833(this, lookupScope, _lookupPath, out newCurrentItem)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,5850,5864);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,5573,5875);

bool
f_1330_5723_5833(System.Management.Automation.ScopedItemSearcher<T>
this_param,System.Management.Automation.SessionStateScope
scope,System.Management.Automation.VariablePath
name,out T
newCurrentItem)
{
var return_v = this_param.GetScopeItem( scope, name, out newCurrentItem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 5723, 5833);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,5573,5875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,5573,5875);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void InitializeScopeEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,5887,6863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6091,6133);

_initialScope = f_1330_6107_6132(sessionState);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6149,6714) || true) && (f_1330_6153_6173(_lookupPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,6149,6714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6207,6248);

_initialScope = f_1330_6223_6247(sessionState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6266,6294);

_isSingleScopeLookup = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,6149,6714);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,6149,6714);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6328,6714) || true) && (f_1330_6332_6351(_lookupPath)||(DynAbs.Tracing.TraceSender.Expression_False(1330, 6332, 6398)||f_1330_6377_6398(_lookupPath)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,6328,6714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6432,6474);

_initialScope = f_1330_6448_6473(sessionState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6492,6520);

_isSingleScopeLookup = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,6328,6714);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,6328,6714);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6554,6714) || true) && (f_1330_6558_6578(_lookupPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,6554,6714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6612,6653);

_initialScope = f_1330_6628_6652(sessionState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6671,6699);

_isSingleScopeLookup = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,6554,6714);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,6328,6714);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,6149,6714);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6730,6814);

_scopeEnumerable =
f_1330_6767_6813(_initialScope);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,6830,6852);

_isInitialized = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,5887,6863);

System.Management.Automation.SessionStateScope
f_1330_6107_6132(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6107, 6132);
return return_v;
}


bool
f_1330_6153_6173(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsGlobal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6153, 6173);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_6223_6247(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.GlobalScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6223, 6247);
return return_v;
}


bool
f_1330_6332_6351(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsLocal ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6332, 6351);
return return_v;
}


bool
f_1330_6377_6398(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsPrivate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6377, 6398);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_6448_6473(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6448, 6473);
return return_v;
}


bool
f_1330_6558_6578(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsScript;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6558, 6578);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_6628_6652(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ScriptScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 6628, 6652);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1330_6767_6813(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 6767, 6813);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,5887,6863);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,5887,6863);
}
		}

private T _current;

protected SessionStateInternal sessionState;

private VariablePath _lookupPath;

private SessionStateScopeEnumerator _scopeEnumerable;

private bool _isSingleScopeLookup;

private bool _isInitialized;

static ScopedItemSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1330,468,7181);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1330,468,7181);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,468,7181);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1330,468,7181);

System.Management.Automation.PSArgumentNullException
f_1330_1323_1377(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 1323, 1377);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1330_1471_1523(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 1471, 1523);
return return_v;
}


int
f_1330_1641_1668(System.Management.Automation.ScopedItemSearcher<T>
this_param)
{
this_param.InitializeScopeEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 1641, 1668);
return 0;
}

}
internal class VariableScopeItemSearcher : ScopedItemSearcher<PSVariable>
{
public VariableScopeItemSearcher(
            SessionStateInternal sessionState,
            VariablePath lookupPath,
            CommandOrigin origin) :base(f_1330_7523_7535_C(sessionState) ,lookupPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1330,7361,7601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,7644,7651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,7573,7590);

_origin = origin;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1330,7361,7601);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,7361,7601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,7361,7601);
}
		}

private readonly CommandOrigin _origin;

protected override bool GetScopeItem(
            SessionStateScope scope,
            VariablePath name,
            out PSVariable variable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,8265,9116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,8435,8578);

f_1330_8435_8577(!(name is FunctionLookupPath), "name was scanned incorrect if we get here and it is a FunctionLookupPath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,8594,8613);

bool 
result = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,8629,8687);

variable = f_1330_8640_8686(scope, f_1330_8658_8676(name), _origin);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,8894,9075) || true) && (variable == null ||(DynAbs.Tracing.TraceSender.Expression_False(1330, 8898, 9011)||                (f_1330_8936_8954(variable)&&(DynAbs.Tracing.TraceSender.Expression_True(1330, 8936, 9010)&&                 scope != f_1330_8985_9010(sessionState)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,8894,9075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,9045,9060);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,8894,9075);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,9091,9105);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,8265,9116);

int
f_1330_8435_8577(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 8435, 8577);
return 0;
}


string
f_1330_8658_8676(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.QualifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 8658, 8676);
return return_v;
}


System.Management.Automation.PSVariable
f_1330_8640_8686(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.GetVariable( name, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 8640, 8686);
return return_v;
}


bool
f_1330_8936_8954(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsPrivate ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 8936, 8954);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_8985_9010(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 8985, 9010);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,8265,9116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,8265,9116);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static VariableScopeItemSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1330,7271,9123);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1330,7271,9123);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,7271,9123);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1330,7271,9123);

static System.Management.Automation.SessionStateInternal
f_1330_7523_7535_C(System.Management.Automation.SessionStateInternal
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1330, 7361, 7601);
return return_v;
}

}
internal class AliasScopeItemSearcher : ScopedItemSearcher<AliasInfo>
{
public AliasScopeItemSearcher(
            SessionStateInternal sessionState,
            VariablePath lookupPath) :base(f_1330_9421_9433_C(sessionState) ,lookupPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1330,9297,9468);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1330,9297,9468);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,9297,9468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,9297,9468);
}
		}

protected override bool GetScopeItem(
            SessionStateScope scope,
            VariablePath name,
            out AliasInfo alias)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,10078,10929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,10244,10387);

f_1330_10244_10386(!(name is FunctionLookupPath), "name was scanned incorrect if we get here and it is a FunctionLookupPath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,10403,10422);

bool 
result = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,10436,10479);

alias = f_1330_10444_10478(scope, f_1330_10459_10477(name));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,10680,10888) || true) && (alias == null ||(DynAbs.Tracing.TraceSender.Expression_False(1330, 10684, 10824)||                ((f_1330_10720_10733(alias)& ScopedItemOptions.Private) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1330, 10719, 10823)&&                 scope != f_1330_10798_10823(sessionState)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,10680,10888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,10858,10873);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,10680,10888);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,10904,10918);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,10078,10929);

int
f_1330_10244_10386(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 10244, 10386);
return 0;
}


string
f_1330_10459_10477(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.QualifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 10459, 10477);
return return_v;
}


System.Management.Automation.AliasInfo
f_1330_10444_10478(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetAlias( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 10444, 10478);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1330_10720_10733(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 10720, 10733);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_10798_10823(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 10798, 10823);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,10078,10929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,10078,10929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static AliasScopeItemSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1330,9211,10936);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1330,9211,10936);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,9211,10936);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1330,9211,10936);

static System.Management.Automation.SessionStateInternal
f_1330_9421_9433_C(System.Management.Automation.SessionStateInternal
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1330, 9297, 9468);
return return_v;
}

}
internal class FunctionScopeItemSearcher : ScopedItemSearcher<FunctionInfo>
{
public FunctionScopeItemSearcher(
            SessionStateInternal sessionState,
            VariablePath lookupPath,
            CommandOrigin origin) :base(f_1330_11280_11292_C(sessionState) ,lookupPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1330,11118,11358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,11401,11408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,13782,13802);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,11330,11347);

_origin = origin;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1330,11118,11358);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,11118,11358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,11118,11358);
}
		}

private readonly CommandOrigin _origin;

protected override bool GetScopeItem(
            SessionStateScope scope,
            VariablePath path,
            out FunctionInfo script)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,12020,13666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12190,12334);

f_1330_12190_12333(path is FunctionLookupPath, "name was scanned incorrect if we get here and it is not a FunctionLookupPath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12350,12369);

bool 
result = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12385,12453);

_name = (DynAbs.Tracing.TraceSender.Conditional_F1(1330, 12393, 12408)||((f_1330_12393_12408(path)&&DynAbs.Tracing.TraceSender.Conditional_F2(1330, 12411, 12431))||DynAbs.Tracing.TraceSender.Conditional_F3(1330, 12434, 12452)))?f_1330_12411_12431(path):f_1330_12434_12452(path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12469,12503);

script = f_1330_12478_12502(scope, _name);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12519,13625) || true) && (script != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,12519,13625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12571,12586);

bool 
isPrivate
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12604,12649);

FilterInfo 
filterInfo = script as FilterInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12667,12960) || true) && (filterInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,12667,12960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12731,12797);

isPrivate = (f_1330_12744_12762(filterInfo)& ScopedItemOptions.Private) != 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,12667,12960);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,12667,12960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,12879,12941);

isPrivate = (f_1330_12892_12906(script)& ScopedItemOptions.Private) != 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,12667,12960);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,13183,13529) || true) && (isPrivate &&(DynAbs.Tracing.TraceSender.Expression_True(1330, 13187, 13255)&&                    scope != f_1330_13230_13255(sessionState)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,13183,13529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,13297,13312);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,13183,13529);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,13183,13529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,13462,13510);

f_1330_13462_13509(_origin, script);
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,13183,13529);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,12519,13625);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,12519,13625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,13595,13610);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,12519,13625);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,13641,13655);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,12020,13666);

int
f_1330_12190_12333(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 12190, 12333);
return 0;
}


bool
f_1330_12393_12408(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsFunction ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 12393, 12408);
return return_v;
}


string
f_1330_12411_12431(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UnqualifiedPath ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 12411, 12431);
return return_v;
}


string
f_1330_12434_12452(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.QualifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 12434, 12452);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1330_12478_12502(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetFunction( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 12478, 12502);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1330_12744_12762(System.Management.Automation.FilterInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 12744, 12762);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1330_12892_12906(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 12892, 12906);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1330_13230_13255(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 13230, 13255);
return return_v;
}


int
f_1330_13462_13509(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.FunctionInfo
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 13462, 13509);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,12020,13666);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,12020,13666);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,13723,13744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,13729,13742);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,13723,13744);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,13678,13755);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,13678,13755);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _name ;

static FunctionScopeItemSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1330,11026,13810);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1330,11026,13810);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,11026,13810);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1330,11026,13810);

static System.Management.Automation.SessionStateInternal
f_1330_11280_11292_C(System.Management.Automation.SessionStateInternal
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1330, 11118, 11358);
return return_v;
}

}
internal class DriveScopeItemSearcher : ScopedItemSearcher<PSDriveInfo>
{
public DriveScopeItemSearcher(
            SessionStateInternal sessionState,
            VariablePath lookupPath) :base(f_1330_14109_14121_C(sessionState) ,lookupPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1330,13985,14156);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1330,13985,14156);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,13985,14156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,13985,14156);
}
		}

protected override bool GetScopeItem(
            SessionStateScope scope,
            VariablePath name,
            out PSDriveInfo drive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1330,14766,15303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,14934,15077);

f_1330_14934_15076(!(name is FunctionLookupPath), "name was scanned incorrect if we get here and it is a FunctionLookupPath");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,15093,15112);

bool 
result = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,15126,15165);

drive = f_1330_15134_15164(scope, f_1330_15149_15163(name));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,15181,15262) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1330,15181,15262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,15232,15247);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1330,15181,15262);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1330,15278,15292);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1330,14766,15303);

int
f_1330_14934_15076(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 14934, 15076);
return 0;
}


string
f_1330_15149_15163(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1330, 15149, 15163);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1330_15134_15164(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1330, 15134, 15164);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1330,14766,15303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,14766,15303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DriveScopeItemSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1330,13897,15310);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1330,13897,15310);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1330,13897,15310);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1330,13897,15310);

static System.Management.Automation.SessionStateInternal
f_1330_14109_14121_C(System.Management.Automation.SessionStateInternal
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1330, 13985, 14156);
return return_v;
}

}
}
