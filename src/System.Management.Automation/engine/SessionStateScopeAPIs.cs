// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.


using Dbg = System.Management.Automation;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
internal sealed partial class SessionStateInternal
{
private SessionStateScope _currentScope;

internal const string 
ScopeParameterName = "Scope"
;

internal SessionStateScope GetScopeByID(string scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1355,2006,4542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2086,2127);

SessionStateScope 
result = _currentScope
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2143,4501) || true) && (!f_1355_2148_2177(scopeID))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,2143,4501);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2211,4486) || true) && (f_1355_2215_2372(scopeID, StringLiterals.Global, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,2211,4486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2414,2435);

result = f_1355_2423_2434();
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,2211,4486);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,2211,4486);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2477,4486) || true) && (f_1355_2481_2649(scopeID, StringLiterals.Local, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,2477,4486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2691,2714);

result = _currentScope;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,2477,4486);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,2477,4486);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2756,4486) || true) && (f_1355_2760_2930(scopeID, StringLiterals.Private, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,2756,4486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,2972,2995);

result = _currentScope;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,2756,4486);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,2756,4486);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,3037,4486) || true) && (f_1355_3041_3210(scopeID, StringLiterals.Script, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,3037,4486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,3321,3356);

result = f_1355_3330_3355(_currentScope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,3037,4486);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,3037,4486);
                    // Since the scope is not any of the special scopes
                    // try parsing it as an ID

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,3613,3704);

int 
scopeNumericID = f_1355_3634_3703(scopeID, f_1355_3655_3702())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,3732,3919) || true) && (scopeNumericID < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,3732,3919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,3812,3892);

throw f_1355_3818_3891(ScopeParameterName, scopeID);
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,3732,3919);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,3947,4002);

result = f_1355_3956_3984(this, scopeNumericID)??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateScope>(1355, 3956, 4001)??_currentScope);
                    }
                    catch (FormatException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1355,4047,4268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,4119,4245);

throw f_1355_4125_4244(ScopeParameterName, f_1355_4180_4223(), ScopeParameterName);
DynAbs.Tracing.TraceSender.TraceExitCatch(1355,4047,4268);
                    }
                    catch (OverflowException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1355,4290,4467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,4364,4444);

throw f_1355_4370_4443(ScopeParameterName, scopeID);
DynAbs.Tracing.TraceSender.TraceExitCatch(1355,4290,4467);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,3037,4486);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,2756,4486);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,2477,4486);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,2211,4486);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,2143,4501);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,4517,4531);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1355,2006,4542);

bool
f_1355_2148_2177(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 2148, 2177);
return return_v;
}


bool
f_1355_2215_2372(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 2215, 2372);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1355_2423_2434()
{
var return_v = GlobalScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 2423, 2434);
return return_v;
}


bool
f_1355_2481_2649(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 2481, 2649);
return return_v;
}


bool
f_1355_2760_2930(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 2760, 2930);
return return_v;
}


bool
f_1355_3041_3210(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 3041, 3210);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1355_3330_3355(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.ScriptScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 3330, 3355);
return return_v;
}


System.Globalization.CultureInfo
f_1355_3655_3702()
{
var return_v = System.Globalization.CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 3655, 3702);
return return_v;
}


int
f_1355_3634_3703(string
s,System.Globalization.CultureInfo
provider)
{
var return_v = Int32.Parse( s, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 3634, 3703);
return return_v;
}


System.Management.Automation.PSArgumentOutOfRangeException
f_1355_3818_3891(string
paramName,string
actualValue)
{
var return_v = PSTraceSource.NewArgumentOutOfRangeException( paramName, (object)actualValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 3818, 3891);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1355_3956_3984(System.Management.Automation.SessionStateInternal
this_param,int
scopeID)
{
var return_v = this_param.GetScopeByID( scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 3956, 3984);
return return_v;
}


string
f_1355_4180_4223()
{
var return_v = AutomationExceptions.InvalidScopeIdArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 4180, 4223);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1355_4125_4244(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 4125, 4244);
return return_v;
}


System.Management.Automation.PSArgumentOutOfRangeException
f_1355_4370_4443(string
paramName,string
actualValue)
{
var return_v = PSTraceSource.NewArgumentOutOfRangeException( paramName, (object)actualValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 4370, 4443);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1355,2006,4542);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1355,2006,4542);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal SessionStateScope GetScopeByID(int scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1355,5196,6037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5273,5323);

SessionStateScope 
processingScope = _currentScope
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5337,5362);

int 
originalID = scopeID
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5378,5541) || true) && (scopeID > 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1355, 5385, 5423)&&processingScope != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,5378,5541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5457,5498);

processingScope = f_1355_5475_5497(processingScope);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5516,5526);

scopeID--;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,5378,5541);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1355,5378,5541);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1355,5378,5541);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5557,5987) || true) && (processingScope == null &&(DynAbs.Tracing.TraceSender.Expression_True(1355, 5561, 5600)&&scopeID >= 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,5557,5987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5634,5937);

ArgumentOutOfRangeException 
outOfRange =
f_1355_5696_5936(ScopeParameterName, originalID, f_1355_5849_5898(), originalID)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,5955,5972);

throw outOfRange;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,5557,5987);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,6003,6026);

return processingScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1355,5196,6037);

System.Management.Automation.SessionStateScope
f_1355_5475_5497(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 5475, 5497);
return return_v;
}


string
f_1355_5849_5898()
{
var return_v =                         SessionStateStrings.ScopeIDExceedsAvailableScopes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 5849, 5898);
return return_v;
}


System.Management.Automation.PSArgumentOutOfRangeException
f_1355_5696_5936(string
paramName,int
actualValue,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentOutOfRangeException( paramName, (object)actualValue, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 5696, 5936);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1355,5196,6037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1355,5196,6037);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal SessionStateScope GlobalScope {get; }

internal SessionStateScope ModuleScope {get; }

internal SessionStateScope CurrentScope
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1355,6672,6744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,6708,6729);

return _currentScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1355,6672,6744);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1355,6608,8040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1355,6608,8040);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1355,6760,8029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,6796,6909);

f_1355_6796_6908(value != null, "A null scope should never be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7339,7371);

SessionStateScope 
scope = value
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7389,7423);

bool 
inGlobalScopeLineage = false
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7443,7726) || true) && (scope != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,7443,7726);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7505,7662) || true) && (scope == f_1355_7518_7529())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,7505,7662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7579,7607);

inGlobalScopeLineage = true;
DynAbs.Tracing.TraceSender.TraceBreak(1355,7633,7639);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,7505,7662);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7686,7707);

scope = f_1355_7694_7706(scope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,7443,7726);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1355,7443,7726);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1355,7443,7726);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7746,7964);

f_1355_7746_7963(inGlobalScopeLineage, "The scope specified to be set in CurrentScope is not in the global scope lineage. All scopes must originate from the global scope.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,7992,8014);

_currentScope = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1355,6760,8029);

int
f_1355_6796_6908(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 6796, 6908);
return 0;
}


System.Management.Automation.SessionStateScope
f_1355_7518_7529()
{
var return_v = GlobalScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 7518, 7529);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1355_7694_7706(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 7694, 7706);
return return_v;
}


int
f_1355_7746_7963(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 7746, 7963);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1355,6608,8040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1355,6608,8040);
}
		}}

internal SessionStateScope ScriptScope {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1355,8198,8239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,8204,8237);

return f_1355_8211_8236(_currentScope);
DynAbs.Tracing.TraceSender.TraceExitMethod(1355,8198,8239);

System.Management.Automation.SessionStateScope
f_1355_8211_8236(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.ScriptScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 8211, 8236);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1355,8157,8241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1355,8157,8241);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal SessionStateScope NewScope(bool isScriptScope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1355,8731,9215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,8811,8930);

f_1355_8811_8929(_currentScope != null, "The currentScope should always be set.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,8992,9058);

SessionStateScope 
newScope = f_1355_9021_9057(_currentScope)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,9074,9172) || true) && (isScriptScope)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,9074,9172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,9125,9157);

newScope.ScriptScope = newScope;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,9074,9172);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,9188,9204);

return newScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1355,8731,9215);

int
f_1355_8811_8929(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 8811, 8929);
return 0;
}


System.Management.Automation.SessionStateScope
f_1355_9021_9057(System.Management.Automation.SessionStateScope
parentScope)
{
var return_v = new System.Management.Automation.SessionStateScope( parentScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 9021, 9057);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1355,8731,9215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1355,8731,9215);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveScope(SessionStateScope scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1355,9646,11941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,9721,9840);

f_1355_9721_9839(_currentScope != null, "The currentScope should always be set.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,9856,10306) || true) && (scope == f_1355_9869_9880())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,9856,10306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,9914,10263);

SessionStateUnauthorizedAccessException 
e =
f_1355_9979_10262(StringLiterals.Global, SessionStateCategory.Scope, "GlobalScopeCannotRemove", f_1355_10218_10261())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,10283,10291);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,9856,10306);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,10446,11572);
foreach(PSDriveInfo drive in f_1355_10476_10488_I(f_1355_10476_10488(scope)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,10446,11572);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,10522,10609) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,10522,10609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,10581,10590);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,10522,10609);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,10629,10710);

CmdletProviderContext 
context = f_1355_10661_10709(f_1355_10687_10708(this))
;

                // Call CanRemoveDrive to give the provider a chance to cleanup
                // but ignore the return value and exceptions

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,10920,10951);

f_1355_10920_10950(this, drive, context);
                }
                catch (LoopFlowException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1355,10988,11079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,11054,11060);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1355,10988,11079);
                }
                catch (PipelineStoppedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1355,11097,11195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,11170,11176);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1355,11097,11195);
                }
                catch (ActionPreferenceStopException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1355,11213,11316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,11291,11297);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1355,11213,11316);
                }
                catch (Exception) // Catch-all OK, 3rd party callout.
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1355,11334,11557);
DynAbs.Tracing.TraceSender.TraceExitCatch(1355,11334,11557);
                    // Ignore all exceptions from the provider as we are
                    // going to force the removal anyway
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,10446,11572);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1355,1,1127);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1355,1,1127);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,11588,11612);

f_1355_11588_11611(
            scope);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,11750,11894) || true) && (scope == _currentScope &&(DynAbs.Tracing.TraceSender.Expression_True(1355, 11754, 11808)&&f_1355_11780_11800(_currentScope)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1355,11750,11894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,11842,11879);

_currentScope = f_1355_11858_11878(_currentScope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1355,11750,11894);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355,11910,11930);

scope.Parent = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1355,9646,11941);

int
f_1355_9721_9839(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 9721, 9839);
return 0;
}


System.Management.Automation.SessionStateScope
f_1355_9869_9880()
{
var return_v = GlobalScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 9869, 9880);
return return_v;
}


string
f_1355_10218_10261()
{
var return_v =                             SessionStateStrings.GlobalScopeCannotRemove;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 10218, 10261);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1355_9979_10262(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 9979, 10262);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.PSDriveInfo>
f_1355_10476_10488(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.Drives;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 10476, 10488);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1355_10687_10708(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 10687, 10708);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1355_10661_10709(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 10661, 10709);
return return_v;
}


bool
f_1355_10920_10950(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.CanRemoveDrive( drive, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 10920, 10950);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.PSDriveInfo>
f_1355_10476_10488_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSDriveInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 10476, 10488);
return return_v;
}


int
f_1355_11588_11611(System.Management.Automation.SessionStateScope
this_param)
{
this_param.RemoveAllDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1355, 11588, 11611);
return 0;
}


System.Management.Automation.SessionStateScope
f_1355_11780_11800(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 11780, 11800);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1355_11858_11878(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1355, 11858, 11878);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1355,9646,11941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1355,9646,11941);
}
		}
}
}

#pragma warning restore 56500
