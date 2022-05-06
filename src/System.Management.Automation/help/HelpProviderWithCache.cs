// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;

namespace System.Management.Automation
{
internal abstract class HelpProviderWithCache : HelpProvider
{
internal HelpProviderWithCache(HelpSystem helpSystem) :base(f_1158_673_683_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1158,612,706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1039,1099);
this._helpCache = f_1158_1052_1099(f_1158_1066_1098());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,2497,2549);
this.HasCustomMatch = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,8334,8397);
this.CacheFullyLoaded = false;DynAbs.Tracing.TraceSender.TraceExitConstructor(1158,612,706);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,612,706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,612,706);
}
		}

private Hashtable _helpCache ;

internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,1349,2300);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1453,1488);

string 
target = f_1158_1469_1487(helpRequest)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1504,2016) || true) && (f_1158_1508_1528_M(!this.HasCustomMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,1504,2016);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1562,1696) || true) && (f_1158_1566_1593(_helpCache, target))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,1562,1696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1635,1677);

listYield.Add((HelpInfo)f_1158_1658_1676(_helpCache, target));
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,1562,1696);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,1504,2016);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,1504,2016);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1762,2001);
foreach(string key in f_1158_1785_1800_I(f_1158_1785_1800(_helpCache)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,1762,2001);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1842,1982) || true) && (f_1158_1846_1870(this, target, key))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,1842,1982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,1920,1959);

listYield.Add((HelpInfo)f_1158_1943_1958(_helpCache, key));
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,1842,1982);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,1762,2001);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1158,1,240);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1158,1,240);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1158,1504,2016);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,2032,2289) || true) && (f_1158_2036_2058_M(!this.CacheFullyLoaded))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,2032,2289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,2092,2122);

f_1158_2092_2121(this, helpRequest);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,2140,2274) || true) && (f_1158_2144_2171(_helpCache, target))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,2140,2274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,2213,2255);

listYield.Add((HelpInfo)f_1158_2236_2254(_helpCache, target));
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,2140,2274);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,2032,2289);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,1349,2300);

return listYield;

string
f_1158_1469_1487(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 1469, 1487);
return return_v;
}


bool
f_1158_1508_1528_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 1508, 1528);
return return_v;
}


bool
f_1158_1566_1593(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.Contains( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 1566, 1593);
return return_v;
}


object
f_1158_1658_1676(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 1658, 1676);
return return_v;
}


System.Collections.ICollection
f_1158_1785_1800(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 1785, 1800);
return return_v;
}


bool
f_1158_1846_1870(System.Management.Automation.HelpProviderWithCache
this_param,string
target,string
key)
{
var return_v = this_param.CustomMatch( target, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 1846, 1870);
return return_v;
}


object
f_1158_1943_1958(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 1943, 1958);
return return_v;
}


System.Collections.ICollection
f_1158_1785_1800_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 1785, 1800);
return return_v;
}


bool
f_1158_2036_2058_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 2036, 2058);
return return_v;
}


int
f_1158_2092_2121(System.Management.Automation.HelpProviderWithCache
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
this_param.DoExactMatchHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 2092, 2121);
return 0;
}


bool
f_1158_2144_2171(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.Contains( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 2144, 2171);
return return_v;
}


object
f_1158_2236_2254(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 2236, 2254);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,1349,2300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,1349,2300);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected bool HasCustomMatch {get; set; }

protected virtual bool CustomMatch(string target, string key)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,2827,2945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,2913,2934);

return target == key;
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,2827,2945);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,2827,2945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,2827,2945);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual void DoExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,3531,3616);
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,3531,3616);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,3531,3616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,3531,3616);
}
		}

internal override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,4132,5767);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4256,4291);

string 
target = f_1158_4272_4290(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4307,4359);

string 
wildcardpattern = f_1158_4332_4358(this, target)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4375,4427);

HelpRequest 
searchHelpRequest = f_1158_4407_4426(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4441,4484);

searchHelpRequest.Target = wildcardpattern;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4498,5756) || true) && (f_1158_4502_4524_M(!this.CacheFullyLoaded))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,4498,5756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4558,4621);

IEnumerable<HelpInfo> 
result = f_1158_4589_4620(this, searchHelpRequest)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4639,4865) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,4639,4865);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4699,4846);
foreach(HelpInfo helpInfoToReturn in f_1158_4737_4743_I(result) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,4699,4846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4793,4823);

listYield.Add(helpInfoToReturn);
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,4699,4846);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1158,1,148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1158,1,148);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1158,4639,4865);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,4498,5756);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,4498,5756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4931,4967);

int 
countOfHelpInfoObjectsFound = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,4985,5080);

WildcardPattern 
helpMatcher = f_1158_5015_5079(wildcardpattern, WildcardOptions.IgnoreCase)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,5098,5741);
foreach(string key in f_1158_5121_5136_I(f_1158_5121_5136(_helpCache)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,5098,5741);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,5178,5722) || true) && ((!searchOnlyContent &&(DynAbs.Tracing.TraceSender.Expression_True(1158, 5183, 5229)&&f_1158_5205_5229(helpMatcher, key))) ||(DynAbs.Tracing.TraceSender.Expression_False(1158, 5182, 5344)||                        (searchOnlyContent &&(DynAbs.Tracing.TraceSender.Expression_True(1158, 5260, 5343)&&f_1158_5281_5343(((HelpInfo)f_1158_5292_5307(_helpCache, key)), helpMatcher)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,5178,5722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,5394,5424);

countOfHelpInfoObjectsFound++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,5450,5489);

listYield.Add((HelpInfo)f_1158_5473_5488(_helpCache, key));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,5515,5699) || true) && (f_1158_5519_5541(helpRequest)> 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1158, 5519, 5602)&&countOfHelpInfoObjectsFound >= f_1158_5580_5602(helpRequest)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,5515,5699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,5660,5672);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,5515,5699);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,5178,5722);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,5098,5741);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1158,1,644);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1158,1,644);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1158,4498,5756);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,4132,5767);

return listYield;

string
f_1158_4272_4290(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 4272, 4290);
return return_v;
}


string
f_1158_4332_4358(System.Management.Automation.HelpProviderWithCache
this_param,string
target)
{
var return_v = this_param.GetWildCardPattern( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 4332, 4358);
return return_v;
}


System.Management.Automation.HelpRequest
f_1158_4407_4426(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 4407, 4426);
return return_v;
}


bool
f_1158_4502_4524_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 4502, 4524);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1158_4589_4620(System.Management.Automation.HelpProviderWithCache
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.DoSearchHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 4589, 4620);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1158_4737_4743_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 4737, 4743);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1158_5015_5079(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 5015, 5079);
return return_v;
}


System.Collections.ICollection
f_1158_5121_5136(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 5121, 5136);
return return_v;
}


bool
f_1158_5205_5229(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 5205, 5229);
return return_v;
}


object
f_1158_5292_5307(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 5292, 5307);
return return_v;
}


bool
f_1158_5281_5343(System.Management.Automation.HelpInfo
this_param,System.Management.Automation.WildcardPattern
pattern)
{
var return_v = this_param.MatchPatternInContent( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 5281, 5343);
return return_v;
}


object
f_1158_5473_5488(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 5473, 5488);
return return_v;
}


int
f_1158_5519_5541(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 5519, 5541);
return return_v;
}


int
f_1158_5580_5602(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 5580, 5602);
return return_v;
}


System.Collections.ICollection
f_1158_5121_5136_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 5121, 5136);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,4132,5767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,4132,5767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual string GetWildCardPattern(string target)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,6356,6578);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,6438,6525) || true) && (f_1158_6442_6492(target))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1158,6438,6525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,6511,6525);

return target;
DynAbs.Tracing.TraceSender.TraceExitCondition(1158,6438,6525);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,6541,6567);

return "*" + target + "*";
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,6356,6578);

bool
f_1158_6442_6492(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 6442, 6492);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,6356,6578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,6356,6578);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual IEnumerable<HelpInfo> DoSearchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,7051,7175);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,7152,7164);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,7051,7175);

return listYield;
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,7051,7175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,7051,7175);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void AddCache(string target, HelpInfo helpInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,7436,7558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,7517,7547);

_helpCache[target] = helpInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,7436,7558);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,7436,7558);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,7436,7558);
}
		}

internal HelpInfo GetCache(string target)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,7826,7939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,7892,7928);

return (HelpInfo)f_1158_7909_7927(_helpCache, target);
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,7826,7939);

object
f_1158_7909_7927(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 7909, 7927);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,7826,7939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,7826,7939);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected internal bool CacheFullyLoaded {get; set; }

internal override void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1158,8566,8719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,8621,8634);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Reset(),1158,8621,8633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,8650,8669);

f_1158_8650_8668(
            _helpCache);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1158,8683,8708);

CacheFullyLoaded = false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1158,8566,8719);

int
f_1158_8650_8668(System.Collections.Hashtable
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 8650, 8668);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1158,8566,8719);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,8566,8719);
}
		}

static HelpProviderWithCache()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1158,436,8748);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1158,436,8748);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1158,436,8748);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1158,436,8748);

static System.Management.Automation.HelpSystem
f_1158_673_683_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1158, 612, 706);
return return_v;
}


System.StringComparer
f_1158_1066_1098()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1158, 1066, 1098);
return return_v;
}


System.Collections.Hashtable
f_1158_1052_1099(System.StringComparer
equalityComparer)
{
var return_v = new System.Collections.Hashtable( (System.Collections.IEqualityComparer)equalityComparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1158, 1052, 1099);
return return_v;
}

}
}
