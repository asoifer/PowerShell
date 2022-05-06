// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
internal sealed partial class SessionStateInternal
{
internal CmdletInfo GetCmdlet(string cmdletName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,751,888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,824,877);

return f_1342_831_876(this, cmdletName, CommandOrigin.Internal);
DynAbs.Tracing.TraceSender.TraceExitMethod(1342,751,888);

System.Management.Automation.CmdletInfo
f_1342_831_876(System.Management.Automation.SessionStateInternal
this_param,string
cmdletName,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.GetCmdlet( cmdletName, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 831, 876);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,751,888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,751,888);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal CmdletInfo GetCmdlet(string cmdletName, CommandOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,1366,2730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,1461,1486);

CmdletInfo 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,1500,1597) || true) && (f_1342_1504_1536(cmdletName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,1500,1597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,1570,1582);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,1500,1597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,1726,1836);

SessionStateScopeEnumerator 
scopeEnumerator =
f_1342_1789_1835(_currentScope)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,1852,2689);
foreach(SessionStateScope scope in f_1342_1888_1903_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,1852,2689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,1937,1974);

result = f_1342_1946_1973(scope, cmdletName);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,1994,2674) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,1994,2674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,2120,2167);

f_1342_2120_2166(origin, result);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,2360,2655) || true) && ((f_1342_2365_2379(result)& ScopedItemOptions.Private) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1342, 2364, 2464)&&                        scope != _currentScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,2360,2655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,2514,2528);

result = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,2360,2655);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,2360,2655);
DynAbs.Tracing.TraceSender.TraceBreak(1342,2626,2632);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,2360,2655);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,1994,2674);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,1852,2689);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,838);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,838);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,2705,2719);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1342,1366,2730);

bool
f_1342_1504_1536(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 1504, 1536);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_1789_1835(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 1789, 1835);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1342_1946_1973(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetCmdlet( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 1946, 1973);
return return_v;
}


int
f_1342_2120_2166(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.CmdletInfo
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 2120, 2166);
return 0;
}


System.Management.Automation.ScopedItemOptions
f_1342_2365_2379(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 2365, 2379);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_1888_1903_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 1888, 1903);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,1366,2730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,1366,2730);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal CmdletInfo GetCmdletAtScope(string cmdletName, string scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,3776,4526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,3872,3897);

CmdletInfo 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,3911,4008) || true) && (f_1342_3915_3947(cmdletName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,3911,4008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,3981,3993);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,3911,4008);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,4024,4072);

SessionStateScope 
scope = f_1342_4050_4071(this, scopeID)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,4086,4123);

result = f_1342_4095_4122(scope, cmdletName);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,4290,4485) || true) && (result != null &&(DynAbs.Tracing.TraceSender.Expression_True(1342, 4294, 4378)&&                (f_1342_4330_4344(result)& ScopedItemOptions.Private) != 0 )&&(DynAbs.Tracing.TraceSender.Expression_True(1342, 4294, 4422)&&                 scope != _currentScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,4290,4485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,4456,4470);

result = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,4290,4485);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,4501,4515);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1342,3776,4526);

bool
f_1342_3915_3947(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 3915, 3947);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1342_4050_4071(System.Management.Automation.SessionStateInternal
this_param,string
scopeID)
{
var return_v = this_param.GetScopeByID( scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 4050, 4071);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1342_4095_4122(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetCmdlet( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 4095, 4122);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1342_4330_4344(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 4330, 4344);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,3776,4526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,3776,4526);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IDictionary<string, List<CmdletInfo>> GetCmdletTable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,4640,6075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,4728,4866);

Dictionary<string, List<CmdletInfo>> 
result =
f_1342_4791_4865(f_1342_4832_4864())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,4882,4992);

SessionStateScopeEnumerator 
scopeEnumerator =
f_1342_4945_4991(_currentScope)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5008,6034);
foreach(SessionStateScope scope in f_1342_5044_5059_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,5008,6034);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5093,6019);
foreach(KeyValuePair<string, List<CmdletInfo>> entry in f_1342_5150_5167_I(f_1342_5150_5167(scope)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,5093,6019);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5209,6000) || true) && (!f_1342_5214_5243(result, entry.Key))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,5209,6000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5469,5521);

List<CmdletInfo> 
toBeAdded = f_1342_5498_5520()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5547,5916);
foreach(CmdletInfo cmdletInfo in f_1342_5581_5592_I(entry.Value) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,5547,5916);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5650,5889) || true) && ((f_1342_5655_5673(cmdletInfo)& ScopedItemOptions.Private) == 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1342, 5654, 5766)||                                scope == _currentScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,5650,5889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5832,5858);

f_1342_5832_5857(                                toBeAdded, cmdletInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,5650,5889);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,5547,5916);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,370);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,370);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,5944,5977);

f_1342_5944_5976(
                        result, entry.Key, toBeAdded);
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,5209,6000);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,5093,6019);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,927);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,927);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1342,5008,6034);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,1027);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,1027);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,6050,6064);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1342,4640,6075);

System.StringComparer
f_1342_4832_4864()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 4832, 4864);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1342_4791_4865(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 4791, 4865);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_4945_4991(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 4945, 4991);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1342_5150_5167(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.CmdletTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 5150, 5167);
return return_v;
}


bool
f_1342_5214_5243(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 5214, 5243);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1342_5498_5520()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CmdletInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 5498, 5520);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1342_5655_5673(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 5655, 5673);
return return_v;
}


int
f_1342_5832_5857(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,System.Management.Automation.CmdletInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 5832, 5857);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1342_5581_5592_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 5581, 5592);
return return_v;
}


int
f_1342_5944_5976(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key,System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 5944, 5976);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1342_5150_5167_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 5150, 5167);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_5044_5059_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 5044, 5059);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,4640,6075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,4640,6075);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IDictionary<string, List<CmdletInfo>> GetCmdletTableAtScope(string scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,6903,7987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7012,7150);

Dictionary<string, List<CmdletInfo>> 
result =
f_1342_7075_7149(f_1342_7116_7148())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7166,7214);

SessionStateScope 
scope = f_1342_7192_7213(this, scopeID)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7230,7946);
foreach(KeyValuePair<string, List<CmdletInfo>> entry in f_1342_7287_7304_I(f_1342_7287_7304(scope)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,7230,7946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7495,7547);

List<CmdletInfo> 
toBeAdded = f_1342_7524_7546()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7565,7878);
foreach(CmdletInfo cmdletInfo in f_1342_7599_7610_I(entry.Value) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,7565,7878);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7652,7859) || true) && ((f_1342_7657_7675(cmdletInfo)& ScopedItemOptions.Private) == 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1342, 7656, 7760)||                        scope == _currentScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,7652,7859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7810,7836);

f_1342_7810_7835(                        toBeAdded, cmdletInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,7652,7859);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,7565,7878);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,314);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,314);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7898,7931);

f_1342_7898_7930(
                result, entry.Key, toBeAdded);
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,7230,7946);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,717);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,717);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,7962,7976);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1342,6903,7987);

System.StringComparer
f_1342_7116_7148()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 7116, 7148);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1342_7075_7149(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 7075, 7149);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1342_7192_7213(System.Management.Automation.SessionStateInternal
this_param,string
scopeID)
{
var return_v = this_param.GetScopeByID( scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 7192, 7213);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1342_7287_7304(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.CmdletTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 7287, 7304);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1342_7524_7546()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CmdletInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 7524, 7546);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1342_7657_7675(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 7657, 7675);
return return_v;
}


int
f_1342_7810_7835(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,System.Management.Automation.CmdletInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 7810, 7835);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1342_7599_7610_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 7599, 7610);
return return_v;
}


int
f_1342_7898_7930(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key,System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 7898, 7930);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1342_7287_7304_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 7287, 7304);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,6903,7987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,6903,7987);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveCmdlet(string name, int index, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,7999,8154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,8086,8143);

f_1342_8086_8142(this, name, index, force, CommandOrigin.Internal);
DynAbs.Tracing.TraceSender.TraceExitMethod(1342,7999,8154);

int
f_1342_8086_8142(System.Management.Automation.SessionStateInternal
this_param,string
name,int
index,bool
force,System.Management.Automation.CommandOrigin
origin)
{
this_param.RemoveCmdlet( name, index, force, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 8086, 8142);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,7999,8154);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,7999,8154);
}
		}

internal void RemoveCmdlet(string name, int index, bool force, CommandOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,8978,10247);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9087,9215) || true) && (f_1342_9091_9117(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,9087,9215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9151,9200);

throw f_1342_9157_9199("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,9087,9215);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9303,9413);

SessionStateScopeEnumerator 
scopeEnumerator =
f_1342_9366_9412(_currentScope)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9429,10236);
foreach(SessionStateScope scope in f_1342_9465_9480_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,9429,10236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9514,9581);

CmdletInfo 
cmdletInfo =
f_1342_9559_9580(                    scope, name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9601,10221) || true) && (cmdletInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,9601,10221);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9834,10202) || true) && ((f_1342_9839_9857(cmdletInfo)& ScopedItemOptions.Private) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1342, 9838, 9942)&&                        scope != _currentScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,9834,10202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,9992,10010);

cmdletInfo = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,9834,10202);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,9834,10202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,10108,10147);

f_1342_10108_10146(                        scope, name, index, force);
DynAbs.Tracing.TraceSender.TraceBreak(1342,10173,10179);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,9834,10202);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,9601,10221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,9429,10236);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,808);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,808);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1342,8978,10247);

bool
f_1342_9091_9117(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 9091, 9117);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1342_9157_9199(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 9157, 9199);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_9366_9412(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 9366, 9412);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1342_9559_9580(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetCmdlet( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 9559, 9580);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1342_9839_9857(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 9839, 9857);
return return_v;
}


int
f_1342_10108_10146(System.Management.Automation.SessionStateScope
this_param,string
name,int
index,bool
force)
{
this_param.RemoveCmdlet( name, index, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 10108, 10146);
return 0;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_9465_9480_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 9465, 9480);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,8978,10247);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,8978,10247);
}
		}

internal void RemoveCmdletEntry(string name, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1342,10871,12110);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,10952,11080) || true) && (f_1342_10956_10982(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,10952,11080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11016,11065);

throw f_1342_11022_11064("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,10952,11080);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11168,11278);

SessionStateScopeEnumerator 
scopeEnumerator =
f_1342_11231_11277(_currentScope)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11294,12099);
foreach(SessionStateScope scope in f_1342_11330_11345_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,11294,12099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11379,11446);

CmdletInfo 
cmdletInfo =
f_1342_11424_11445(                    scope, name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11466,12084) || true) && (cmdletInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,11466,12084);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11699,12065) || true) && ((f_1342_11704_11722(cmdletInfo)& ScopedItemOptions.Private) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1342, 11703, 11807)&&                        scope != _currentScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,11699,12065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11857,11875);

cmdletInfo = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,11699,12065);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1342,11699,12065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1342,11973,12010);

f_1342_11973_12009(                        scope, name, force);
DynAbs.Tracing.TraceSender.TraceBreak(1342,12036,12042);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,11699,12065);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,11466,12084);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1342,11294,12099);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1342,1,806);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1342,1,806);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1342,10871,12110);

bool
f_1342_10956_10982(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 10956, 10982);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1342_11022_11064(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 11022, 11064);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_11231_11277(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 11231, 11277);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1342_11424_11445(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetCmdlet( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 11424, 11445);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1342_11704_11722(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1342, 11704, 11722);
return return_v;
}


int
f_1342_11973_12009(System.Management.Automation.SessionStateScope
this_param,string
name,bool
force)
{
this_param.RemoveCmdletEntry( name, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 11973, 12009);
return 0;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1342_11330_11345_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1342, 11330, 11345);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1342,10871,12110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1342,10871,12110);
}
		}
}
}

