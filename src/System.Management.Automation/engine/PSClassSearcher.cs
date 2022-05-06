// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
internal class PSClassSearcher : IEnumerable<PSClassInfo>, IEnumerator<PSClassInfo>
{
internal PSClassSearcher(
            string className,
            bool useWildCards,
            ExecutionContext context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1322,618,1170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1235,1252);
this._className = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1288,1303);
this._context = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1334,1354);
this._currentMatch = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1398,1419);
this._matchingClass = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1462,1487);
this._matchingClassList = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1511,1532);
this._useWildCards = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1584,1607);
this._moduleInfoCache = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1633,1659);
this._lockObject = f_1322_1647_1659();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,770,846);

f_1322_770_845(context != null, "caller to verify context is not null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,860,879);

_context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,895,975);

f_1322_895_974(className != null, "caller to verify className is not null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,989,1012);

_className = className;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1026,1055);

_useWildCards = useWildCards;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1069,1159);

_moduleInfoCache = f_1322_1088_1158(f_1322_1125_1157());
DynAbs.Tracing.TraceSender.TraceExitConstructor(1322,618,1170);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,618,1170);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,618,1170);
}
		}

private string _className ;

private ExecutionContext _context ;

private PSClassInfo _currentMatch ;

private IEnumerator<PSClassInfo> _matchingClass ;

private Collection<PSClassInfo> _matchingClassList ;

private bool _useWildCards ;

private Dictionary<string, PSModuleInfo> _moduleInfoCache ;

private object _lockObject ;

public void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,1808,1920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1852,1873);

_currentMatch = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,1887,1909);

_matchingClass = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,1808,1920);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,1808,1920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,1808,1920);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,2024,2129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2070,2078);

f_1322_2070_2077(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2092,2118);

f_1322_2092_2117(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,2024,2129);

int
f_1322_2070_2077(System.Management.Automation.PSClassSearcher
this_param)
{
this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 2070, 2077);
return 0;
}


int
f_1322_2092_2117(System.Management.Automation.PSClassSearcher
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 2092, 2117);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,2024,2129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,2024,2129);
}
		}

IEnumerator<PSClassInfo> IEnumerable<PSClassInfo>.GetEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,2254,2367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2344,2356);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,2254,2367);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,2254,2367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,2254,2367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

IEnumerator IEnumerable.GetEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,2492,2579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2556,2568);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,2492,2579);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,2492,2579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,2492,2579);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool MoveNext()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,2726,2916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2773,2804);

_currentMatch = f_1322_2789_2803(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2820,2876) || true) && (_currentMatch != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,2820,2876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2864,2876);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,2820,2876);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,2892,2905);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,2726,2916);

System.Management.Automation.PSClassInfo
f_1322_2789_2803(System.Management.Automation.PSClassSearcher
this_param)
{
var return_v = this_param.GetNextClass();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 2789, 2803);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,2726,2916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,2726,2916);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

PSClassInfo IEnumerator<PSClassInfo>.Current
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,3089,3161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,3125,3146);

return _currentMatch;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,3089,3161);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,3020,3172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,3020,3172);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

object IEnumerator.Current
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,3337,3436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,3373,3421);

return f_1322_3380_3420(((IEnumerator<PSClassInfo>)this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,3337,3436);

System.Management.Automation.PSClassInfo
f_1322_3380_3420(System.Collections.Generic.IEnumerator<System.Management.Automation.PSClassInfo>
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 3380, 3420);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,3286,3447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,3286,3447);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSClassInfo GetNextClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,3807,4611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,3866,3897);

PSClassInfo 
returnValue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,3911,4006);

WildcardPattern 
classNameMatcher = f_1322_3946_4005(_className, WildcardOptions.IgnoreCase)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4022,4345) || true) && (_matchingClassList == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,4022,4345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4086,4137);

_matchingClassList = f_1322_4107_4136();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4157,4330) || true) && (f_1322_4161_4199(this, classNameMatcher))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,4157,4330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4222,4274);

_matchingClass = f_1322_4239_4273(_matchingClassList);
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,4157,4330);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,4157,4330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4318,4330);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,4157,4330);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,4022,4345);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4361,4565) || true) && (!f_1322_4366_4391(_matchingClass))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,4361,4565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4425,4447);

_matchingClass = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,4361,4565);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,4361,4565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4513,4550);

returnValue = f_1322_4527_4549(_matchingClass);
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,4361,4565);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4581,4600);

return returnValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,3807,4611);

System.Management.Automation.WildcardPattern
f_1322_3946_4005(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 3946, 4005);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassInfo>
f_1322_4107_4136()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 4107, 4136);
return return_v;
}


bool
f_1322_4161_4199(System.Management.Automation.PSClassSearcher
this_param,System.Management.Automation.WildcardPattern
classNameMatcher)
{
var return_v = this_param.FindTypeByModulePath( classNameMatcher);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 4161, 4199);
return return_v;
}


System.Collections.Generic.IEnumerator<System.Management.Automation.PSClassInfo>
f_1322_4239_4273(System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassInfo>
this_param)
{
var return_v = this_param.GetEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 4239, 4273);
return return_v;
}


bool
f_1322_4366_4391(System.Collections.Generic.IEnumerator<System.Management.Automation.PSClassInfo>
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 4366, 4391);
return return_v;
}


System.Management.Automation.PSClassInfo
f_1322_4527_4549(System.Collections.Generic.IEnumerator<System.Management.Automation.PSClassInfo>
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 4527, 4549);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,3807,4611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,3807,4611);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool FindTypeByModulePath(WildcardPattern classNameMatcher)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,4623,6510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4715,4739);

bool 
matchFound = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4755,4852);

var 
moduleList = f_1322_4772_4851(isForAutoDiscovery: false, _context)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4868,6465);
foreach(var modulePath in f_1322_4895_4905_I(moduleList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,4868,6465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,4939,4999);

string 
expandedModulePath = f_1322_4967_4998(modulePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5017,5100);

var 
cachedClasses = f_1322_5037_5099(expandedModulePath, _context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5120,6450) || true) && (cachedClasses != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,5120,6450);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5223,6431) || true) && (!_useWildCards)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,5223,6431);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5291,5721) || true) && (f_1322_5295_5332(cachedClasses, _className))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,5291,5721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5390,5460);

var 
classInfo = f_1322_5406_5459(this, classNameMatcher, modulePath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5490,5694) || true) && (classInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,5490,5694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5577,5611);

f_1322_5577_5610(                                _matchingClassList, classInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5645,5663);

matchFound = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,5490,5694);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,5291,5721);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,5223,6431);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,5223,6431);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5819,6408);
foreach(var className in f_1322_5845_5863_I(f_1322_5845_5863(cachedClasses)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,5819,6408);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,5921,6381) || true) && (f_1322_5925_5960(classNameMatcher, className))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,5921,6381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,6026,6096);

var 
classInfo = f_1322_6042_6095(this, classNameMatcher, modulePath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,6130,6350) || true) && (classInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,6130,6350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,6225,6259);

f_1322_6225_6258(                                    _matchingClassList, classInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,6297,6315);

matchFound = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,6130,6350);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,5921,6381);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,5819,6408);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1322,1,590);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1322,1,590);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1322,5223,6431);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,5120,6450);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,4868,6465);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1322,1,1598);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1322,1,1598);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,6481,6499);

return matchFound;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,4623,6510);

System.Collections.Generic.IEnumerable<string>
f_1322_4772_4851(bool
isForAutoDiscovery,System.Management.Automation.ExecutionContext
context)
{
var return_v = ModuleUtils.GetDefaultAvailableModuleFiles( isForAutoDiscovery: isForAutoDiscovery, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 4772, 4851);
return return_v;
}


string
f_1322_4967_4998(string
path)
{
var return_v = IO.Path.GetFullPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 4967, 4998);
return return_v;
}


System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
f_1322_5037_5099(string
modulePath,System.Management.Automation.ExecutionContext
context)
{
var return_v = AnalysisCache.GetExportedClasses( modulePath, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 5037, 5099);
return return_v;
}


bool
f_1322_5295_5332(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 5295, 5332);
return return_v;
}


System.Management.Automation.PSClassInfo
f_1322_5406_5459(System.Management.Automation.PSClassSearcher
this_param,System.Management.Automation.WildcardPattern
classNameMatcher,string
modulePath)
{
var return_v = this_param.CachedItemToPSClassInfo( classNameMatcher, modulePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 5406, 5459);
return return_v;
}


int
f_1322_5577_5610(System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassInfo>
this_param,System.Management.Automation.PSClassInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 5577, 5610);
return 0;
}


System.Collections.Generic.ICollection<string>
f_1322_5845_5863(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 5845, 5863);
return return_v;
}


bool
f_1322_5925_5960(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 5925, 5960);
return return_v;
}


System.Management.Automation.PSClassInfo
f_1322_6042_6095(System.Management.Automation.PSClassSearcher
this_param,System.Management.Automation.WildcardPattern
classNameMatcher,string
modulePath)
{
var return_v = this_param.CachedItemToPSClassInfo( classNameMatcher, modulePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 6042, 6095);
return return_v;
}


int
f_1322_6225_6258(System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassInfo>
this_param,System.Management.Automation.PSClassInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 6225, 6258);
return 0;
}


System.Collections.Generic.ICollection<string>
f_1322_5845_5863_I(System.Collections.Generic.ICollection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 5845, 5863);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1322_4895_4905_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 4895, 4905);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,4623,6510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,4623,6510);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSClassInfo CachedItemToPSClassInfo(WildcardPattern classNameMatcher, string modulePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,6953,8406);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7074,8367);
foreach(var module in f_1322_7097_7124_I(f_1322_7097_7124(this, modulePath)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,7074,8367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7158,7214);

var 
exportedTypes = f_1322_7178_7213(module)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7234,7260);

ScriptBlockAst 
ast = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7278,7311);

TypeDefinitionAst 
typeAst = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7331,8352) || true) && (!_useWildCards)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,7331,8352);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7391,7684) || true) && (f_1322_7395_7445(exportedTypes, _className, out typeAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,7391,7684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7495,7541);

ast = f_1322_7501_7522(f_1322_7501_7515(typeAst))as ScriptBlockAst;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7567,7661) || true) && (ast != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,7567,7661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7613,7661);

return f_1322_7620_7660(this, module, ast, typeAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,7567,7661);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,7391,7684);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,7331,8352);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,7331,8352);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7766,8333);
foreach(var exportedType in f_1322_7795_7808_I(exportedTypes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,7766,8333);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,7858,8310) || true) && (exportedType.Value != null &&(DynAbs.Tracing.TraceSender.Expression_True(1322, 7862, 7970)&&f_1322_7921_7970(                            classNameMatcher, f_1322_7946_7969(exportedType.Value)))&&(DynAbs.Tracing.TraceSender.Expression_True(1322, 7862, 8029)&&f_1322_8003_8029(exportedType.Value)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,7858,8310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8087,8144);

ast = f_1322_8093_8125(f_1322_8093_8118(exportedType.Value))as ScriptBlockAst;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8174,8283) || true) && (ast != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,8174,8283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8224,8283);

return f_1322_8231_8282(this, module, ast, exportedType.Value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,8174,8283);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,7858,8310);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,7766,8333);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1322,1,568);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1322,1,568);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1322,7331,8352);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,7074,8367);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1322,1,1294);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1322,1,1294);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8383,8395);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,6953,8406);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1322_7097_7124(System.Management.Automation.PSClassSearcher
this_param,string
modulePath)
{
var return_v = this_param.GetPSModuleInfo( modulePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 7097, 7124);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
f_1322_7178_7213(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.GetExportedTypeDefinitions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 7178, 7213);
return return_v;
}


bool
f_1322_7395_7445(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
this_param,string
key,out System.Management.Automation.Language.TypeDefinitionAst
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 7395, 7445);
return return_v;
}


System.Management.Automation.Language.Ast
f_1322_7501_7515(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 7501, 7515);
return return_v;
}


System.Management.Automation.Language.Ast
f_1322_7501_7522(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 7501, 7522);
return return_v;
}


System.Management.Automation.PSClassInfo
f_1322_7620_7660(System.Management.Automation.PSClassSearcher
this_param,System.Management.Automation.PSModuleInfo
module,System.Management.Automation.Language.ScriptBlockAst
ast,System.Management.Automation.Language.TypeDefinitionAst
statement)
{
var return_v = this_param.ConvertToClassInfo( module, ast, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 7620, 7660);
return return_v;
}


string
f_1322_7946_7969(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 7946, 7969);
return return_v;
}


bool
f_1322_7921_7970(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 7921, 7970);
return return_v;
}


bool
f_1322_8003_8029(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.IsClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 8003, 8029);
return return_v;
}


System.Management.Automation.Language.Ast
f_1322_8093_8118(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 8093, 8118);
return return_v;
}


System.Management.Automation.Language.Ast
f_1322_8093_8125(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 8093, 8125);
return return_v;
}


System.Management.Automation.PSClassInfo
f_1322_8231_8282(System.Management.Automation.PSClassSearcher
this_param,System.Management.Automation.PSModuleInfo
module,System.Management.Automation.Language.ScriptBlockAst
ast,System.Management.Automation.Language.TypeDefinitionAst
statement)
{
var return_v = this_param.ConvertToClassInfo( module, ast, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 8231, 8282);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
f_1322_7795_7808_I(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 7795, 7808);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1322_7097_7124_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 7097, 7124);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,6953,8406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,6953,8406);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Collection<PSModuleInfo> GetPSModuleInfo(string modulePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,8418,10170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8510,8541);

PSModuleInfo 
moduleInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8563,8574);

            lock (_lockObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8608,8665);

f_1322_8608_8664(                _moduleInfoCache, modulePath, out moduleInfo);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8696,8899) || true) && (moduleInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,8696,8899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8752,8801);

var 
returnValue = f_1322_8770_8800()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8819,8847);

f_1322_8819_8846(                returnValue, moduleInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8865,8884);

return returnValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,8696,8899);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,8915,9048);

CommandInfo 
commandInfo = f_1322_8941_9047("Get-Module", typeof(Microsoft.PowerShell.Commands.GetModuleCommand), null, null, _context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,9062,9192);

System.Management.Automation.Runspaces.Command 
getModuleCommand = f_1322_9128_9191(commandInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,9208,9273);

string 
moduleName = f_1322_9228_9272(modulePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,9289,9913);

var 
modules = f_1322_9303_9912(f_1322_9303_9867(f_1322_9303_9816(f_1322_9303_9763(f_1322_9303_9682(f_1322_9303_9605(f_1322_9303_9530(f_1322_9303_9475(f_1322_9303_9426(f_1322_9303_9379(RunspaceMode.CurrentRunspace), getModuleCommand), "List", true), "Name", moduleName), "ErrorAction", ActionPreference.Ignore), "WarningAction", ActionPreference.Ignore), "InformationAction", ActionPreference.Ignore), "Verbose", false), "Debug", false))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,9935,9946);

            lock (_lockObject)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,9980,10113);
foreach(var module in f_1322_10003_10010_I(modules) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,9980,10113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10052,10094);

f_1322_10052_10093(                    _moduleInfoCache, f_1322_10073_10084(module), module);
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,9980,10113);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1322,1,134);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1322,1,134);
}            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10144,10159);

return modules;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,8418,10170);

bool
f_1322_8608_8664(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
this_param,string
key,out System.Management.Automation.PSModuleInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 8608, 8664);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1322_8770_8800()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 8770, 8800);
return return_v;
}


int
f_1322_8819_8846(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
this_param,System.Management.Automation.PSModuleInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 8819, 8846);
return 0;
}


System.Management.Automation.CmdletInfo
f_1322_8941_9047(string
name,System.Type
implementingType,string
helpFile,System.Management.Automation.PSSnapInInfo
PSSnapin,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.CmdletInfo( name, implementingType, helpFile, PSSnapin, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 8941, 9047);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1322_9128_9191(System.Management.Automation.CommandInfo
commandInfo)
{
var return_v = new System.Management.Automation.Runspaces.Command( commandInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9128, 9191);
return return_v;
}


string?
f_1322_9228_9272(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9228, 9272);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9379(System.Management.Automation.RunspaceMode
runspace)
{
var return_v = System.Management.Automation.PowerShell.Create( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9379);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9426(System.Management.Automation.PowerShell
this_param,System.Management.Automation.Runspaces.Command
command)
{
var return_v = this_param.AddCommand( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9426);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9475(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9475);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9530(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9530);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9605(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.ActionPreference
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9605);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9682(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.ActionPreference
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9682);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9763(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.ActionPreference
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9763);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9816(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9816);
return return_v;
}


System.Management.Automation.PowerShell
f_1322_9303_9867(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9867);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1322_9303_9912(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke<System.Management.Automation.PSModuleInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 9303, 9912);
return return_v;
}


string
f_1322_10073_10084(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 10073, 10084);
return return_v;
}


int
f_1322_10052_10093(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
this_param,string
key,System.Management.Automation.PSModuleInfo
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10052, 10093);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1322_10003_10010_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10003, 10010);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,8418,10170);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,8418,10170);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSClassInfo ConvertToClassInfo(PSModuleInfo module, ScriptBlockAst ast, TypeDefinitionAst statement)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1322,10182,12028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10315,10371);

PSClassInfo 
classInfo = f_1322_10339_10370(f_1322_10355_10369(statement))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10385,10453);

f_1322_10385_10452(f_1322_10396_10410(statement)!= null, "statement should have a name.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10467,10493);

classInfo.Module = module;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10507,10586);

Collection<PSClassMemberInfo> 
properties = f_1322_10550_10585()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10602,11667);
foreach(var member in f_1322_10625_10642_I(f_1322_10625_10642(statement)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,10602,11667);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10676,11652) || true) && (member is PropertyMemberAst propAst &&(DynAbs.Tracing.TraceSender.Expression_True(1322, 10680, 10781)&&!f_1322_10720_10781(f_1322_10720_10746(propAst), PropertyAttributes.Hidden)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,10676,11652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10823,10883);

f_1322_10823_10882(f_1322_10834_10846(propAst)!= null, "PropName cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10905,10977);

f_1322_10905_10976(f_1322_10916_10936(propAst)!= null, "PropertyType cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,10999,11085);

f_1322_10999_11084(f_1322_11010_11039(f_1322_11010_11030(propAst))!= null, "Property TypeName cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11107,11176);

f_1322_11107_11175(f_1322_11118_11132(propAst)!= null, "Property Extent cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11198,11276);

f_1322_11198_11275(f_1322_11209_11228(f_1322_11209_11223(propAst))!= null, "Property ExtentText cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11300,11581);

PSClassMemberInfo 
classProperty = f_1322_11334_11580(f_1322_11356_11368(propAst), f_1322_11445_11483(f_1322_11445_11474(f_1322_11445_11465(propAst))), f_1322_11560_11579(f_1322_11560_11574(propAst)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11603,11633);

f_1322_11603_11632(                    properties, classProperty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,10676,11652);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,10602,11667);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1322,1,1066);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1322,1,1066);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11683,11719);

f_1322_11683_11718(
            classInfo, properties);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11735,11762);

string 
mamlHelpFile = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11776,11876) || true) && (f_1322_11780_11800(ast)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,11776,11876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11827,11876);

mamlHelpFile = f_1322_11842_11875(f_1322_11842_11862(ast));
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,11776,11876);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11892,11984) || true) && (!f_1322_11897_11931(mamlHelpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1322,11892,11984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,11950,11984);

classInfo.HelpFile = mamlHelpFile;
DynAbs.Tracing.TraceSender.TraceExitCondition(1322,11892,11984);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1322,12000,12017);

return classInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1322,10182,12028);

string
f_1322_10355_10369(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 10355, 10369);
return return_v;
}


System.Management.Automation.PSClassInfo
f_1322_10339_10370(string
name)
{
var return_v = new System.Management.Automation.PSClassInfo( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10339, 10370);
return return_v;
}


string
f_1322_10396_10410(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 10396, 10410);
return return_v;
}


int
f_1322_10385_10452(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10385, 10452);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassMemberInfo>
f_1322_10550_10585()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassMemberInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10550, 10585);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1322_10625_10642(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Members;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 10625, 10642);
return return_v;
}


System.Management.Automation.Language.PropertyAttributes
f_1322_10720_10746(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 10720, 10746);
return return_v;
}


bool
f_1322_10720_10781(System.Management.Automation.Language.PropertyAttributes
this_param,System.Management.Automation.Language.PropertyAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10720, 10781);
return return_v;
}


string
f_1322_10834_10846(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 10834, 10846);
return return_v;
}


int
f_1322_10823_10882(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10823, 10882);
return 0;
}


System.Management.Automation.Language.TypeConstraintAst
f_1322_10916_10936(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 10916, 10936);
return return_v;
}


int
f_1322_10905_10976(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10905, 10976);
return 0;
}


System.Management.Automation.Language.TypeConstraintAst
f_1322_11010_11030(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11010, 11030);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1322_11010_11039(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11010, 11039);
return return_v;
}


int
f_1322_10999_11084(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10999, 11084);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1322_11118_11132(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Extent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11118, 11132);
return return_v;
}


int
f_1322_11107_11175(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11107, 11175);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1322_11209_11223(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11209, 11223);
return return_v;
}


string
f_1322_11209_11228(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11209, 11228);
return return_v;
}


int
f_1322_11198_11275(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11198, 11275);
return 0;
}


string
f_1322_11356_11368(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11356, 11368);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1322_11445_11465(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11445, 11465);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1322_11445_11474(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11445, 11474);
return return_v;
}


string
f_1322_11445_11483(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11445, 11483);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1322_11560_11574(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11560, 11574);
return return_v;
}


string
f_1322_11560_11579(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11560, 11579);
return return_v;
}


System.Management.Automation.PSClassMemberInfo
f_1322_11334_11580(string
name,string
memberType,string
defaultValue)
{
var return_v = new System.Management.Automation.PSClassMemberInfo( name, memberType, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11334, 11580);
return return_v;
}


int
f_1322_11603_11632(System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassMemberInfo>
this_param,System.Management.Automation.PSClassMemberInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11603, 11632);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1322_10625_10642_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 10625, 10642);
return return_v;
}


int
f_1322_11683_11718(System.Management.Automation.PSClassInfo
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.PSClassMemberInfo>
members)
{
this_param.UpdateMembers( (System.Collections.Generic.IList<System.Management.Automation.PSClassMemberInfo>)members);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11683, 11718);
return 0;
}


System.Management.Automation.Language.CommentHelpInfo
f_1322_11780_11800(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.GetHelpContent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11780, 11800);
return return_v;
}


System.Management.Automation.Language.CommentHelpInfo
f_1322_11842_11862(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.GetHelpContent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11842, 11862);
return return_v;
}


string
f_1322_11842_11875(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.MamlHelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 11842, 11875);
return return_v;
}


bool
f_1322_11897_11931(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 11897, 11931);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1322,10182,12028);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,10182,12028);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static PSClassSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1322,518,12057);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1322,518,12057);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1322,518,12057);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1322,518,12057);

int
f_1322_770_845(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 770, 845);
return 0;
}


int
f_1322_895_974(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 895, 974);
return 0;
}


System.StringComparer
f_1322_1125_1157()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1322, 1125, 1157);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
f_1322_1088_1158(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 1088, 1158);
return return_v;
}


object
f_1322_1647_1659()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1322, 1647, 1659);
return return_v;
}

}
}
