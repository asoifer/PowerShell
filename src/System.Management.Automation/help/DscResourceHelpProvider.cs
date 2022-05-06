// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Xml;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
internal class DscResourceHelpProvider : HelpProviderWithCache
{
internal DscResourceHelpProvider(HelpSystem helpSystem)
:base(f_1148_627_637_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1148,551,713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,856,864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,1118,1146);
this._helpFiles = f_1148_1131_1146();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,663,702);

_context = f_1148_674_701(helpSystem);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1148,551,713);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,551,713);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,551,713);
}
		}

private readonly ExecutionContext _context;

private readonly Hashtable _helpFiles ;

[TraceSource("DscResourceHelpProvider", "DscResourceHelpProvider")]
        private static readonly PSTraceSource s_tracer ;

internal override string Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,1553,1597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,1559,1595);

return "Dsc Resource Help Provider";
DynAbs.Tracing.TraceSender.TraceExitMethod(1148,1553,1597);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,1499,1608);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,1499,1608);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,1775,1826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,1781,1824);

return Automation.HelpCategory.DscResource;
DynAbs.Tracing.TraceSender.TraceExitMethod(1148,1775,1826);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,1707,1837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,1707,1837);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,2156,3135);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2280,2345);

f_1148_2280_2344(helpRequest != null, "helpRequest cannot be null.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2361,2396);

string 
target = f_1148_2377_2395(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2410,2468);

Collection<string> 
patternList = f_1148_2443_2467()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2484,2571);

bool 
decoratedSearch = !f_1148_2508_2570(f_1148_2551_2569(helpRequest))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2587,2751) || true) && (decoratedSearch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,2587,2751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2640,2676);

f_1148_2640_2675(                patternList, "*" + target + "*");
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,2587,2751);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,2587,2751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2727,2751);

f_1148_2727_2750(                patternList, target);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,2587,2751);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2767,3124);
foreach(string pattern in f_1148_2794_2805_I(patternList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,2767,3124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2839,2913);

DscResourceSearcher 
searcher = f_1148_2870_2912(pattern, _context)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,2933,3109);
foreach(var helpInfo in f_1148_2958_2979_I(f_1148_2958_2979(this, searcher)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,2933,3109);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3021,3090) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,3021,3090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3068,3090);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,3021,3090);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,2933,3109);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1148,1,177);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1148,1,177);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1148,2767,3124);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1148,1,358);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1148,1,358);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1148,2156,3135);

return listYield;

int
f_1148_2280_2344(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2280, 2344);
return 0;
}


string
f_1148_2377_2395(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 2377, 2395);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1148_2443_2467()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2443, 2467);
return return_v;
}


string
f_1148_2551_2569(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 2551, 2569);
return return_v;
}


bool
f_1148_2508_2570(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2508, 2570);
return return_v;
}


int
f_1148_2640_2675(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2640, 2675);
return 0;
}


int
f_1148_2727_2750(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2727, 2750);
return 0;
}


System.Management.Automation.DscResourceSearcher
f_1148_2870_2912(string
resourceName,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.DscResourceSearcher( resourceName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2870, 2912);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1148_2958_2979(System.Management.Automation.DscResourceHelpProvider
this_param,System.Management.Automation.DscResourceSearcher
searcher)
{
var return_v = this_param.GetHelpInfo( searcher);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2958, 2979);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1148_2958_2979_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2958, 2979);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1148_2794_2805_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 2794, 2805);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,2156,3135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,2156,3135);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,3427,4117);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3531,3596);

f_1148_3531_3595(helpRequest != null, "helpRequest cannot be null.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3612,3752) || true) && ((f_1148_3617_3641(helpRequest)& Automation.HelpCategory.DscResource) == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,3612,3752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3719,3737);

listYield.Add(null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,3612,3752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3768,3803);

string 
target = f_1148_3784_3802(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3819,3892);

DscResourceSearcher 
searcher = f_1148_3850_3891(target, _context)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3908,4106);
foreach(var helpInfo in f_1148_3933_3954_I(f_1148_3933_3954(this, searcher)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,3908,4106);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,3988,4091) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,3988,4091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,4050,4072);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,3988,4091);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,3908,4106);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1148,1,199);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1148,1,199);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1148,3427,4117);

return listYield;

int
f_1148_3531_3595(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 3531, 3595);
return 0;
}


System.Management.Automation.HelpCategory
f_1148_3617_3641(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.HelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 3617, 3641);
return return_v;
}


string
f_1148_3784_3802(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 3784, 3802);
return return_v;
}


System.Management.Automation.DscResourceSearcher
f_1148_3850_3891(string
resourceName,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.DscResourceSearcher( resourceName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 3850, 3891);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1148_3933_3954(System.Management.Automation.DscResourceHelpProvider
this_param,System.Management.Automation.DscResourceSearcher
searcher)
{
var return_v = this_param.GetHelpInfo( searcher);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 3933, 3954);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1148_3933_3954_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 3933, 3954);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,3427,4117);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,3427,4117);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IEnumerable<HelpInfo> GetHelpInfo(DscResourceSearcher searcher)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,4367,5917);

var listYield= new List<HelpInfo>();
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,4463,5906) || true) && (f_1148_4470_4489(searcher))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,4463,5906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,4523,4598);

DscResourceInfo 
current = f_1148_4549_4597(((IEnumerator<DscResourceInfo>)searcher))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,4618,4643);

string 
moduleName = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,4661,4699);

string 
moduleDir = f_1148_4680_4698(current)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,4865,5237) || true) && (f_1148_4869_4883(current)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,4865,5237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,4933,4966);

moduleName = f_1148_4946_4965(f_1148_4946_4960(current));
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,4865,5237);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,4865,5237);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5008,5237) || true) && (!f_1148_5013_5044(moduleDir))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,5008,5237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5086,5151);

string[] 
splitPath = f_1148_5107_5150(moduleDir, Utils.Separators.Backslash)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5173,5218);

moduleName = splitPath[f_1148_5196_5212(splitPath)- 1];
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,5008,5237);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,4865,5237);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5257,5891) || true) && (!f_1148_5262_5294(moduleName)&&(DynAbs.Tracing.TraceSender.Expression_True(1148, 5261, 5330)&&!f_1148_5299_5330(moduleDir)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,5257,5891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5372,5421);

string 
helpFileToFind = moduleName + "-Help.xml"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5445,5472);

string 
helpFileName = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5496,5554);

Collection<string> 
searchPaths = f_1148_5529_5553()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5576,5603);

f_1148_5576_5602(                    searchPaths, moduleDir);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5627,5733);

HelpInfo 
helpInfo = f_1148_5647_5732(this, current, helpFileToFind, searchPaths, true, out helpFileName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5757,5872) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,5757,5872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,5827,5849);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,5757,5872);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,5257,5891);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,4463,5906);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1148,4463,5906);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1148,4463,5906);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1148,4367,5917);

return listYield;

bool
f_1148_4470_4489(System.Management.Automation.DscResourceSearcher
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 4470, 4489);
return return_v;
}


System.Management.Automation.DscResourceInfo
f_1148_4549_4597(System.Collections.Generic.IEnumerator<System.Management.Automation.DscResourceInfo>
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 4549, 4597);
return return_v;
}


string
f_1148_4680_4698(System.Management.Automation.DscResourceInfo
this_param)
{
var return_v = this_param.ParentPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 4680, 4698);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1148_4869_4883(System.Management.Automation.DscResourceInfo
this_param)
{
var return_v = this_param.Module ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 4869, 4883);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1148_4946_4960(System.Management.Automation.DscResourceInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 4946, 4960);
return return_v;
}


string
f_1148_4946_4965(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 4946, 4965);
return return_v;
}


bool
f_1148_5013_5044(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 5013, 5044);
return return_v;
}


string[]
f_1148_5107_5150(string
this_param,params char[]
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 5107, 5150);
return return_v;
}


int
f_1148_5196_5212(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 5196, 5212);
return return_v;
}


bool
f_1148_5262_5294(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 5262, 5294);
return return_v;
}


bool
f_1148_5299_5330(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 5299, 5330);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1148_5529_5553()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 5529, 5553);
return return_v;
}


int
f_1148_5576_5602(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 5576, 5602);
return 0;
}


System.Management.Automation.HelpInfo
f_1148_5647_5732(System.Management.Automation.DscResourceHelpProvider
this_param,System.Management.Automation.DscResourceInfo
resourceInfo,string
helpFileToFind,System.Collections.ObjectModel.Collection<string>
searchPaths,bool
reportErrors,out string
helpFile)
{
var return_v = this_param.GetHelpInfoFromHelpFile( resourceInfo, helpFileToFind, searchPaths, reportErrors, out helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 5647, 5732);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,4367,5917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,4367,5917);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsMamlHelp(string helpFile, XmlNode helpItemsNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1148,6569,7330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,6665,6739);

f_1148_6665_6738(!f_1148_6679_6709(helpFile), "helpFile cannot be null.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,6755,6852) || true) && (f_1148_6759_6821(helpFile, ".maml", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,6755,6852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,6840,6852);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,6755,6852);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,6868,6936) || true) && (f_1148_6872_6896(helpItemsNode)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,6868,6936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,6923,6936);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,6868,6936);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,6952,7290);
foreach(XmlNode attribute in f_1148_6982_7006_I(f_1148_6982_7006(helpItemsNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,6952,7290);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7040,7275) || true) && (f_1148_7044_7111(f_1148_7044_7058(attribute), "schema", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1148, 7044, 7202)&&f_1148_7136_7202(f_1148_7136_7151(attribute), "maml", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,7040,7275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7244,7256);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,7040,7275);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,6952,7290);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1148,1,339);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1148,1,339);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7306,7319);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1148,6569,7330);

bool
f_1148_6679_6709(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 6679, 6709);
return return_v;
}


int
f_1148_6665_6738(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 6665, 6738);
return 0;
}


bool
f_1148_6759_6821(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 6759, 6821);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1148_6872_6896(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 6872, 6896);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1148_6982_7006(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 6982, 7006);
return return_v;
}


string
f_1148_7044_7058(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 7044, 7058);
return return_v;
}


bool
f_1148_7044_7111(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 7044, 7111);
return return_v;
}


string
f_1148_7136_7151(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 7136, 7151);
return return_v;
}


bool
f_1148_7136_7202(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 7136, 7202);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1148_6982_7006_I(System.Xml.XmlAttributeCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 6982, 7006);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,6569,7330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,6569,7330);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private HelpInfo GetHelpInfoFromHelpFile(DscResourceInfo resourceInfo, string helpFileToFind, Collection<string> searchPaths, bool reportErrors, out string helpFile)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,7377,8384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7567,7650);

f_1148_7567_7649(resourceInfo != null, "Caller should verify that resourceInfo != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7664,7751);

f_1148_7664_7750(helpFileToFind != null, "Caller should verify that helpFileToFind != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7767,7834);

helpFile = f_1148_7778_7833(helpFileToFind, searchPaths);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7850,7907) || true) && (!f_1148_7855_7876(helpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,7850,7907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7895,7907);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,7850,7907);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,7923,8345) || true) && (!f_1148_7928_7958(helpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,7923,8345);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,8070,8231) || true) && (!f_1148_8075_8104(_helpFiles, helpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,8070,8231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,8146,8212);

f_1148_8146_8211(this, helpFile, helpFile, f_1148_8179_8196(resourceInfo), reportErrors);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,8070,8231);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,8251,8330);

return f_1148_8258_8329(this, helpFile, Automation.HelpCategory.DscResource);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,7923,8345);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,8361,8373);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1148,7377,8384);

int
f_1148_7567_7649(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 7567, 7649);
return 0;
}


int
f_1148_7664_7750(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 7664, 7750);
return 0;
}


string
f_1148_7778_7833(string
file,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = MUIFileSearcher.LocateFile( file, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 7778, 7833);
return return_v;
}


bool
f_1148_7855_7876(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 7855, 7876);
return return_v;
}


bool
f_1148_7928_7958(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 7928, 7958);
return return_v;
}


bool
f_1148_8075_8104(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.Contains( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 8075, 8104);
return return_v;
}


string
f_1148_8179_8196(System.Management.Automation.DscResourceInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 8179, 8196);
return return_v;
}


int
f_1148_8146_8211(System.Management.Automation.DscResourceHelpProvider
this_param,string
helpFile,string
helpFileIdentifier,string
commandName,bool
reportErrors)
{
this_param.LoadHelpFile( helpFile, helpFileIdentifier, commandName, reportErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 8146, 8211);
return 0;
}


System.Management.Automation.HelpInfo
f_1148_8258_8329(System.Management.Automation.DscResourceHelpProvider
this_param,string
helpFileIdentifier,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = this_param.GetFromResourceHelpCache( helpFileIdentifier, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 8258, 8329);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,7377,8384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,7377,8384);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private HelpInfo GetFromResourceHelpCache(string helpFileIdentifier, HelpCategory helpCategory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,8769,9297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,8889,8996);

f_1148_8889_8995(!f_1148_8903_8943(helpFileIdentifier), "helpFileIdentifier should not be null or empty.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9012,9059);

HelpInfo 
result = f_1148_9030_9058(this, helpFileIdentifier)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9075,9256) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,9075,9256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9127,9186);

MamlCommandHelpInfo 
original = (MamlCommandHelpInfo)result
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9204,9241);

result = f_1148_9213_9240(original, helpCategory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,9075,9256);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9272,9286);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1148,8769,9297);

bool
f_1148_8903_8943(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 8903, 8943);
return return_v;
}


int
f_1148_8889_8995(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 8889, 8995);
return 0;
}


System.Management.Automation.HelpInfo
f_1148_9030_9058(System.Management.Automation.DscResourceHelpProvider
this_param,string
target)
{
var return_v = this_param.GetCache( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 9030, 9058);
return return_v;
}


System.Management.Automation.MamlCommandHelpInfo
f_1148_9213_9240(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.HelpCategory
newCategoryToUse)
{
var return_v = this_param.Copy( newCategoryToUse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 9213, 9240);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,8769,9297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,8769,9297);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void LoadHelpFile(string helpFile, string helpFileIdentifier, string commandName, bool reportErrors)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,9309,10659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9442,9461);

Exception 
e = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9511,9554);

f_1148_9511_9553(this, helpFile, helpFileIdentifier);
            }
            catch (IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1148,9583,9678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9647,9663);

e = ioException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1148,9583,9678);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1148,9692,9821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9784,9806);

e = securityException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1148,9692,9821);
            }
            catch (XmlException xmlException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1148,9835,9933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,9901,9918);

e = xmlException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1148,9835,9933);
            }
            catch (NotSupportedException notSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1148,9947,10072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,10031,10057);

e = notSupportedException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1148,9947,10072);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1148,10086,10229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,10182,10214);

e = unauthorizedAccessException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1148,10086,10229);
            }
            catch (InvalidOperationException invalidOperationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1148,10243,10380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,10335,10365);

e = invalidOperationException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1148,10243,10380);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,10396,10506) || true) && (e != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,10396,10506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,10428,10506);

f_1148_10428_10505(                s_tracer, "Error occured in DscResourceHelpProvider {0}", f_1148_10495_10504(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,10396,10506);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,10522,10648) || true) && (reportErrors &&(DynAbs.Tracing.TraceSender.Expression_True(1148, 10526, 10553)&&(e != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,10522,10648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,10587,10633);

f_1148_10587_10632(this, e, commandName, helpFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,10522,10648);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1148,9309,10659);

int
f_1148_9511_9553(System.Management.Automation.DscResourceHelpProvider
this_param,string
helpFile,string
helpFileIdentifier)
{
this_param.LoadHelpFile( helpFile, helpFileIdentifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 9511, 9553);
return 0;
}


string
f_1148_10495_10504(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 10495, 10504);
return return_v;
}


int
f_1148_10428_10505(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 10428, 10505);
return 0;
}


int
f_1148_10587_10632(System.Management.Automation.DscResourceHelpProvider
this_param,System.Exception
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 10587, 10632);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,9309,10659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,9309,10659);
}
		}

private void LoadHelpFile(string helpFile, string helpFileIdentifier)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1148,11187,13974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11281,11362);

f_1148_11281_11361(!f_1148_11293_11323(helpFile), "HelpFile cannot be null or empty.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11376,11477);

f_1148_11376_11476(!f_1148_11388_11428(helpFileIdentifier), "helpFileIdentifier cannot be null or empty.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11493,11683);

XmlDocument 
doc = f_1148_11511_11682(f_1148_11572_11594(helpFile), false, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11827,11852);

_helpFiles[helpFile] = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11868,11897);

XmlNode 
helpItemsNode = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11913,12398) || true) && (f_1148_11917_11934(doc))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,11913,12398);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11977,11982);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,11968,12383) || true) && (i < f_1148_11988_12008(f_1148_11988_12002(doc)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12010,12013)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1148,11968,12383))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,11968,12383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12055,12088);

XmlNode 
node = f_1148_12070_12087(f_1148_12070_12084(doc), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12110,12364) || true) && (f_1148_12114_12127(node)== XmlNodeType.Element &&(DynAbs.Tracing.TraceSender.Expression_True(1148, 12114, 12238)&&f_1148_12154_12233(f_1148_12169_12183(node), "helpItems", StringComparison.OrdinalIgnoreCase)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,12110,12364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12288,12309);

helpItemsNode = node;
DynAbs.Tracing.TraceSender.TraceBreak(1148,12335,12341);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,12110,12364);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1148,1,416);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1148,1,416);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1148,11913,12398);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12414,12592) || true) && (helpItemsNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,12414,12592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12473,12552);

f_1148_12473_12551(                s_tracer, "Unable to find 'helpItems' element in file {0}", helpFile);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12570,12577);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,12414,12592);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12608,12658);

bool 
isMaml = f_1148_12622_12657(helpFile, helpItemsNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12674,13963);
using(f_1148_12681_12712(f_1148_12681_12696(this), helpFile))            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12746,13948) || true) && (f_1148_12750_12777(helpItemsNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,12746,13948);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12828,12833);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12819,13929) || true) && (i < f_1148_12839_12869(f_1148_12839_12863(helpItemsNode)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12871,12874)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1148,12819,13929))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,12819,13929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12924,12967);

XmlNode 
node = f_1148_12939_12966(f_1148_12939_12963(helpItemsNode), i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,12995,13033);

string 
nodeLocalName = f_1148_13018_13032(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13061,13170);

bool 
isDscResource = (f_1148_13083_13163(nodeLocalName, "dscResource", StringComparison.OrdinalIgnoreCase)== 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13198,13906) || true) && (f_1148_13202_13215(node)== XmlNodeType.Element &&(DynAbs.Tracing.TraceSender.Expression_True(1148, 13202, 13255)&&isDscResource))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,13198,13906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13313,13349);

MamlCommandHelpInfo 
helpInfo = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13381,13612) || true) && (isMaml)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,13381,13612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13457,13581) || true) && (isDscResource)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,13457,13581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13513,13581);

helpInfo = f_1148_13524_13580(node, HelpCategory.DscResource);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,13457,13581);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,13381,13612);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13644,13879) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1148,13644,13879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13730,13775);

f_1148_13730_13774(f_1148_13730_13745(this), f_1148_13758_13773(helpInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,13809,13848);

f_1148_13809_13847(this, helpFileIdentifier, helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,13644,13879);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1148,13198,13906);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1148,1,1111);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1148,1,1111);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1148,12746,13948);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1148,12674,13963);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1148,11187,13974);

bool
f_1148_11293_11323(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 11293, 11323);
return return_v;
}


int
f_1148_11281_11361(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 11281, 11361);
return 0;
}


bool
f_1148_11388_11428(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 11388, 11428);
return return_v;
}


int
f_1148_11376_11476(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 11376, 11476);
return 0;
}


System.IO.FileInfo
f_1148_11572_11594(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 11572, 11594);
return return_v;
}


System.Xml.XmlDocument
f_1148_11511_11682(System.IO.FileInfo
xmlPath,bool
preserveNonElements,int?
maxCharactersInDocument)
{
var return_v = InternalDeserializer.LoadUnsafeXmlDocument( xmlPath, preserveNonElements, maxCharactersInDocument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 11511, 11682);
return return_v;
}


bool
f_1148_11917_11934(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.HasChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 11917, 11934);
return return_v;
}


System.Xml.XmlNodeList
f_1148_11988_12002(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 11988, 12002);
return return_v;
}


int
f_1148_11988_12008(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 11988, 12008);
return return_v;
}


System.Xml.XmlNodeList
f_1148_12070_12084(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12070, 12084);
return return_v;
}


System.Xml.XmlNode
f_1148_12070_12087(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12070, 12087);
return return_v;
}


System.Xml.XmlNodeType
f_1148_12114_12127(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12114, 12127);
return return_v;
}


string
f_1148_12169_12183(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12169, 12183);
return return_v;
}


int
f_1148_12154_12233(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 12154, 12233);
return return_v;
}


int
f_1148_12473_12551(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 12473, 12551);
return 0;
}


bool
f_1148_12622_12657(string
helpFile,System.Xml.XmlNode
helpItemsNode)
{
var return_v = IsMamlHelp( helpFile, helpItemsNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 12622, 12657);
return return_v;
}


System.Management.Automation.HelpSystem
f_1148_12681_12696(System.Management.Automation.DscResourceHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12681, 12696);
return return_v;
}


System.IDisposable
f_1148_12681_12712(System.Management.Automation.HelpSystem
this_param,string
helpFile)
{
var return_v = this_param.Trace( helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 12681, 12712);
return return_v;
}


bool
f_1148_12750_12777(System.Xml.XmlNode
this_param)
{
var return_v = this_param.HasChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12750, 12777);
return return_v;
}


System.Xml.XmlNodeList
f_1148_12839_12863(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12839, 12863);
return return_v;
}


int
f_1148_12839_12869(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12839, 12869);
return return_v;
}


System.Xml.XmlNodeList
f_1148_12939_12963(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12939, 12963);
return return_v;
}


System.Xml.XmlNode
f_1148_12939_12966(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 12939, 12966);
return return_v;
}


string
f_1148_13018_13032(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 13018, 13032);
return return_v;
}


int
f_1148_13083_13163(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 13083, 13163);
return return_v;
}


System.Xml.XmlNodeType
f_1148_13202_13215(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 13202, 13215);
return return_v;
}


System.Management.Automation.MamlCommandHelpInfo
f_1148_13524_13580(System.Xml.XmlNode
xmlNode,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = MamlCommandHelpInfo.Load( xmlNode, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 13524, 13580);
return return_v;
}


System.Management.Automation.HelpSystem
f_1148_13730_13745(System.Management.Automation.DscResourceHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 13730, 13745);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1148_13758_13773(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 13758, 13773);
return return_v;
}


int
f_1148_13730_13774(System.Management.Automation.HelpSystem
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
errorRecords)
{
this_param.TraceErrors( errorRecords);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 13730, 13774);
return 0;
}


int
f_1148_13809_13847(System.Management.Automation.DscResourceHelpProvider
this_param,string
target,System.Management.Automation.MamlCommandHelpInfo
helpInfo)
{
this_param.AddCache( target, (System.Management.Automation.HelpInfo)helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 13809, 13847);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1148,11187,13974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,11187,13974);
}
		}

static DscResourceHelpProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1148,371,14003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1148,1274,1362);
s_tracer = f_1148_1285_1362("DscResourceHelpProvider", "DscResourceHelpProvider");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1148,371,14003);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1148,371,14003);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1148,371,14003);

System.Management.Automation.ExecutionContext
f_1148_674_701(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1148, 674, 701);
return return_v;
}


static System.Management.Automation.HelpSystem
f_1148_627_637_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1148, 551, 713);
return return_v;
}


System.Collections.Hashtable
f_1148_1131_1146()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 1131, 1146);
return return_v;
}


static System.Management.Automation.PSTraceSource
f_1148_1285_1362(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1148, 1285, 1362);
return return_v;
}

}
}
