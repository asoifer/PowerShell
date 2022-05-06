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
internal class PSClassHelpProvider : HelpProviderWithCache
{
internal PSClassHelpProvider(HelpSystem helpSystem)
:base(f_1172_615_625_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1172,543,701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,844,852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,1106,1134);
this._helpFiles = f_1172_1119_1134();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,651,690);

_context = f_1172_662_689(helpSystem);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1172,543,701);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,543,701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,543,701);
}
		}

private readonly ExecutionContext _context;

private readonly Hashtable _helpFiles ;

[TraceSource("PSClassHelpProvider", "PSClassHelpProvider")]
        private static readonly PSTraceSource s_tracer ;

internal override string Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,1525,1573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,1531,1571);

return "Powershell Class Help Provider";
DynAbs.Tracing.TraceSender.TraceExitMethod(1172,1525,1573);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,1471,1584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,1471,1584);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,1751,1796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,1757,1794);

return Automation.HelpCategory.Class;
DynAbs.Tracing.TraceSender.TraceExitMethod(1172,1751,1796);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,1683,1807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,1683,1807);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,2131,3157);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2255,2320);

f_1172_2255_2319(helpRequest != null, "helpRequest cannot be null.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2336,2371);

string 
target = f_1172_2352_2370(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2385,2443);

Collection<string> 
patternList = f_1172_2418_2442()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2459,2546);

bool 
decoratedSearch = !f_1172_2483_2545(f_1172_2526_2544(helpRequest))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2562,2726) || true) && (decoratedSearch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,2562,2726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2615,2651);

f_1172_2615_2650(                patternList, "*" + target + "*");
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,2562,2726);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,2562,2726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2702,2726);

f_1172_2702_2725(                patternList, target);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,2562,2726);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2742,2767);

bool 
useWildCards = true
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2783,3146);
foreach(string pattern in f_1172_2810_2821_I(patternList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,2783,3146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2855,2935);

PSClassSearcher 
searcher = f_1172_2882_2934(pattern, useWildCards, _context)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,2955,3131);
foreach(var helpInfo in f_1172_2980_3001_I(f_1172_2980_3001(this, searcher)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,2955,3131);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3043,3112) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,3043,3112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3090,3112);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,3043,3112);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,2955,3131);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1172,1,177);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1172,1,177);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1172,2783,3146);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1172,1,364);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1172,1,364);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1172,2131,3157);

return listYield;

int
f_1172_2255_2319(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2255, 2319);
return 0;
}


string
f_1172_2352_2370(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 2352, 2370);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1172_2418_2442()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2418, 2442);
return return_v;
}


string
f_1172_2526_2544(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 2526, 2544);
return return_v;
}


bool
f_1172_2483_2545(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2483, 2545);
return return_v;
}


int
f_1172_2615_2650(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2615, 2650);
return 0;
}


int
f_1172_2702_2725(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2702, 2725);
return 0;
}


System.Management.Automation.PSClassSearcher
f_1172_2882_2934(string
className,bool
useWildCards,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.PSClassSearcher( className, useWildCards, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2882, 2934);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1172_2980_3001(System.Management.Automation.PSClassHelpProvider
this_param,System.Management.Automation.PSClassSearcher
searcher)
{
var return_v = this_param.GetHelpInfo( searcher);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2980, 3001);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1172_2980_3001_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2980, 3001);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1172_2810_2821_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 2810, 2821);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,2131,3157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,2131,3157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,3450,4180);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3554,3619);

f_1172_3554_3618(helpRequest != null, "helpRequest cannot be null.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3635,3769) || true) && ((f_1172_3640_3664(helpRequest)& Automation.HelpCategory.Class) == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,3635,3769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3736,3754);

listYield.Add(null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,3635,3769);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3785,3820);

string 
target = f_1172_3801_3819(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3834,3860);

bool 
useWildCards = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3876,3955);

PSClassSearcher 
searcher = f_1172_3903_3954(target, useWildCards, _context)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,3971,4169);
foreach(var helpInfo in f_1172_3996_4017_I(f_1172_3996_4017(this, searcher)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,3971,4169);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4051,4154) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,4051,4154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4113,4135);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,4051,4154);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,3971,4169);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1172,1,199);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1172,1,199);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1172,3450,4180);

return listYield;

int
f_1172_3554_3618(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 3554, 3618);
return 0;
}


System.Management.Automation.HelpCategory
f_1172_3640_3664(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.HelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 3640, 3664);
return return_v;
}


string
f_1172_3801_3819(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 3801, 3819);
return return_v;
}


System.Management.Automation.PSClassSearcher
f_1172_3903_3954(string
className,bool
useWildCards,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.PSClassSearcher( className, useWildCards, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 3903, 3954);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1172_3996_4017(System.Management.Automation.PSClassHelpProvider
this_param,System.Management.Automation.PSClassSearcher
searcher)
{
var return_v = this_param.GetHelpInfo( searcher);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 3996, 4017);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1172_3996_4017_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 3996, 4017);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,3450,4180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,3450,4180);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IEnumerable<HelpInfo> GetHelpInfo(PSClassSearcher searcher)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,4425,6076);

var listYield= new List<HelpInfo>();
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4517,6065) || true) && (f_1172_4524_4543(searcher))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,4517,6065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4577,4644);

PSClassInfo 
current = f_1172_4599_4643(((IEnumerator<PSClassInfo>)searcher))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4664,4704);

string 
moduleName = f_1172_4684_4703(f_1172_4684_4698(current))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4722,4767);

string 
moduleDir = f_1172_4741_4766(f_1172_4741_4755(current))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4787,6050) || true) && (!f_1172_4792_4824(moduleName)&&(DynAbs.Tracing.TraceSender.Expression_True(1172, 4791, 4860)&&!f_1172_4829_4860(moduleDir)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,4787,6050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4902,4951);

string 
helpFileToFind = moduleName + "-Help.xml"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,4975,5002);

string 
helpFileName = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5026,5084);

Collection<string> 
searchPaths = f_1172_5059_5083()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5106,5133);

f_1172_5106_5132(                    searchPaths, moduleDir);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5157,5200);

string 
externalHelpFile = f_1172_5183_5199(current)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5224,5762) || true) && (!f_1172_5229_5267(externalHelpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,5224,5762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5317,5372);

FileInfo 
helpFileInfo = f_1172_5341_5371(externalHelpFile)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5398,5449);

DirectoryInfo 
dirToSearch = f_1172_5426_5448(helpFileInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5477,5739) || true) && (f_1172_5481_5499(dirToSearch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,5477,5739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5557,5595);

f_1172_5557_5594(                            searchPaths, f_1172_5573_5593(dirToSearch));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5625,5660);

helpFileToFind = f_1172_5642_5659(helpFileInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,5477,5739);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,5224,5762);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5786,5892);

HelpInfo 
helpInfo = f_1172_5806_5891(this, current, helpFileToFind, searchPaths, true, out helpFileName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5916,6031) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,5916,6031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,5986,6008);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,5916,6031);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,4787,6050);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,4517,6065);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1172,4517,6065);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1172,4517,6065);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1172,4425,6076);

return listYield;

bool
f_1172_4524_4543(System.Management.Automation.PSClassSearcher
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 4524, 4543);
return return_v;
}


System.Management.Automation.PSClassInfo
f_1172_4599_4643(System.Collections.Generic.IEnumerator<System.Management.Automation.PSClassInfo>
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 4599, 4643);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1172_4684_4698(System.Management.Automation.PSClassInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 4684, 4698);
return return_v;
}


string
f_1172_4684_4703(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 4684, 4703);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1172_4741_4755(System.Management.Automation.PSClassInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 4741, 4755);
return return_v;
}


string
f_1172_4741_4766(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.ModuleBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 4741, 4766);
return return_v;
}


bool
f_1172_4792_4824(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 4792, 4824);
return return_v;
}


bool
f_1172_4829_4860(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 4829, 4860);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1172_5059_5083()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 5059, 5083);
return return_v;
}


int
f_1172_5106_5132(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 5106, 5132);
return 0;
}


string
f_1172_5183_5199(System.Management.Automation.PSClassInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 5183, 5199);
return return_v;
}


bool
f_1172_5229_5267(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 5229, 5267);
return return_v;
}


System.IO.FileInfo
f_1172_5341_5371(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 5341, 5371);
return return_v;
}


System.IO.DirectoryInfo
f_1172_5426_5448(System.IO.FileInfo
this_param)
{
var return_v = this_param.Directory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 5426, 5448);
return return_v;
}


bool
f_1172_5481_5499(System.IO.DirectoryInfo
this_param)
{
var return_v = this_param.Exists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 5481, 5499);
return return_v;
}


string
f_1172_5573_5593(System.IO.DirectoryInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 5573, 5593);
return return_v;
}


int
f_1172_5557_5594(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 5557, 5594);
return 0;
}


string
f_1172_5642_5659(System.IO.FileInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 5642, 5659);
return return_v;
}


System.Management.Automation.HelpInfo
f_1172_5806_5891(System.Management.Automation.PSClassHelpProvider
this_param,System.Management.Automation.PSClassInfo
classInfo,string
helpFileToFind,System.Collections.ObjectModel.Collection<string>
searchPaths,bool
reportErrors,out string
helpFile)
{
var return_v = this_param.GetHelpInfoFromHelpFile( classInfo, helpFileToFind, searchPaths, reportErrors, out helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 5806, 5891);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,4425,6076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,4425,6076);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsMamlHelp(string helpFile, XmlNode helpItemsNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1172,6728,7489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,6824,6898);

f_1172_6824_6897(!f_1172_6838_6868(helpFile), "helpFile cannot be null.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,6914,7011) || true) && (f_1172_6918_6980(helpFile, ".maml", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,6914,7011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,6999,7011);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,6914,7011);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7027,7095) || true) && (f_1172_7031_7055(helpItemsNode)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,7027,7095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7082,7095);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,7027,7095);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7111,7449);
foreach(XmlNode attribute in f_1172_7141_7165_I(f_1172_7141_7165(helpItemsNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,7111,7449);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7199,7434) || true) && (f_1172_7203_7270(f_1172_7203_7217(attribute), "schema", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1172, 7203, 7361)&&f_1172_7295_7361(f_1172_7295_7310(attribute), "maml", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,7199,7434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7403,7415);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,7199,7434);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,7111,7449);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1172,1,339);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1172,1,339);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7465,7478);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1172,6728,7489);

bool
f_1172_6838_6868(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 6838, 6868);
return return_v;
}


int
f_1172_6824_6897(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 6824, 6897);
return 0;
}


bool
f_1172_6918_6980(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 6918, 6980);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1172_7031_7055(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 7031, 7055);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1172_7141_7165(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 7141, 7165);
return return_v;
}


string
f_1172_7203_7217(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 7203, 7217);
return return_v;
}


bool
f_1172_7203_7270(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 7203, 7270);
return return_v;
}


string
f_1172_7295_7310(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 7295, 7310);
return return_v;
}


bool
f_1172_7295_7361(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 7295, 7361);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1172_7141_7165_I(System.Xml.XmlAttributeCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 7141, 7165);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,6728,7489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,6728,7489);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private HelpInfo GetHelpInfoFromHelpFile(PSClassInfo classInfo, string helpFileToFind, Collection<string> searchPaths, bool reportErrors, out string helpFile)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,7536,8520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7719,7796);

f_1172_7719_7795(classInfo != null, "Caller should verify that classInfo != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7810,7897);

f_1172_7810_7896(helpFileToFind != null, "Caller should verify that helpFileToFind != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7913,7980);

helpFile = f_1172_7924_7979(helpFileToFind, searchPaths);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,7996,8053) || true) && (!f_1172_8001_8022(helpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,7996,8053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,8041,8053);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,7996,8053);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,8069,8481) || true) && (!f_1172_8074_8104(helpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,8069,8481);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,8216,8374) || true) && (!f_1172_8221_8250(_helpFiles, helpFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,8216,8374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,8292,8355);

f_1172_8292_8354(this, helpFile, helpFile, f_1172_8325_8339(classInfo), reportErrors);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,8216,8374);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,8394,8466);

return f_1172_8401_8465(this, helpFile, Automation.HelpCategory.Class);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,8069,8481);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,8497,8509);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1172,7536,8520);

int
f_1172_7719_7795(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 7719, 7795);
return 0;
}


int
f_1172_7810_7896(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 7810, 7896);
return 0;
}


string
f_1172_7924_7979(string
file,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = MUIFileSearcher.LocateFile( file, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 7924, 7979);
return return_v;
}


bool
f_1172_8001_8022(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 8001, 8022);
return return_v;
}


bool
f_1172_8074_8104(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 8074, 8104);
return return_v;
}


bool
f_1172_8221_8250(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.Contains( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 8221, 8250);
return return_v;
}


string
f_1172_8325_8339(System.Management.Automation.PSClassInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 8325, 8339);
return return_v;
}


int
f_1172_8292_8354(System.Management.Automation.PSClassHelpProvider
this_param,string
helpFile,string
helpFileIdentifier,string
commandName,bool
reportErrors)
{
this_param.LoadHelpFile( helpFile, helpFileIdentifier, commandName, reportErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 8292, 8354);
return 0;
}


System.Management.Automation.HelpInfo
f_1172_8401_8465(System.Management.Automation.PSClassHelpProvider
this_param,string
helpFileIdentifier,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = this_param.GetFromPSClassHelpCache( helpFileIdentifier, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 8401, 8465);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,7536,8520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,7536,8520);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private HelpInfo GetFromPSClassHelpCache(string helpFileIdentifier, HelpCategory helpCategory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,8905,9428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9024,9131);

f_1172_9024_9130(!f_1172_9038_9078(helpFileIdentifier), "helpFileIdentifier should not be null or empty.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9147,9194);

HelpInfo 
result = f_1172_9165_9193(this, helpFileIdentifier)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9210,9387) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,9210,9387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9262,9317);

MamlClassHelpInfo 
original = (MamlClassHelpInfo)result
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9335,9372);

result = f_1172_9344_9371(original, helpCategory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,9210,9387);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9403,9417);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1172,8905,9428);

bool
f_1172_9038_9078(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 9038, 9078);
return return_v;
}


int
f_1172_9024_9130(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 9024, 9130);
return 0;
}


System.Management.Automation.HelpInfo
f_1172_9165_9193(System.Management.Automation.PSClassHelpProvider
this_param,string
target)
{
var return_v = this_param.GetCache( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 9165, 9193);
return return_v;
}


System.Management.Automation.MamlClassHelpInfo
f_1172_9344_9371(System.Management.Automation.MamlClassHelpInfo
this_param,System.Management.Automation.HelpCategory
newCategoryToUse)
{
var return_v = this_param.Copy( newCategoryToUse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 9344, 9371);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,8905,9428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,8905,9428);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void LoadHelpFile(string helpFile, string helpFileIdentifier, string commandName, bool reportErrors)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,9440,10786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9573,9592);

Exception 
e = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9642,9685);

f_1172_9642_9684(this, helpFile, helpFileIdentifier);
            }
            catch (IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1172,9714,9809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9778,9794);

e = ioException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1172,9714,9809);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1172,9823,9952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,9915,9937);

e = securityException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1172,9823,9952);
            }
            catch (XmlException xmlException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1172,9966,10064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10032,10049);

e = xmlException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1172,9966,10064);
            }
            catch (NotSupportedException notSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1172,10078,10203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10162,10188);

e = notSupportedException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1172,10078,10203);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1172,10217,10360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10313,10345);

e = unauthorizedAccessException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1172,10217,10360);
            }
            catch (InvalidOperationException invalidOperationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1172,10374,10511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10466,10496);

e = invalidOperationException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1172,10374,10511);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10527,10633) || true) && (e != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,10527,10633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10559,10633);

f_1172_10559_10632(                s_tracer, "Error occured in PSClassHelpProvider {0}", f_1172_10622_10631(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,10527,10633);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10649,10775) || true) && (reportErrors &&(DynAbs.Tracing.TraceSender.Expression_True(1172, 10653, 10680)&&(e != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,10649,10775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,10714,10760);

f_1172_10714_10759(this, e, commandName, helpFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,10649,10775);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1172,9440,10786);

int
f_1172_9642_9684(System.Management.Automation.PSClassHelpProvider
this_param,string
helpFile,string
helpFileIdentifier)
{
this_param.LoadHelpFile( helpFile, helpFileIdentifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 9642, 9684);
return 0;
}


string
f_1172_10622_10631(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 10622, 10631);
return return_v;
}


int
f_1172_10559_10632(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 10559, 10632);
return 0;
}


int
f_1172_10714_10759(System.Management.Automation.PSClassHelpProvider
this_param,System.Exception
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 10714, 10759);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,9440,10786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,9440,10786);
}
		}

private void LoadHelpFile(string helpFile, string helpFileIdentifier)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1172,11314,14067);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,11408,11489);

f_1172_11408_11488(!f_1172_11420_11450(helpFile), "HelpFile cannot be null or empty.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,11503,11604);

f_1172_11503_11603(!f_1172_11515_11555(helpFileIdentifier), "helpFileIdentifier cannot be null or empty.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,11620,11810);

XmlDocument 
doc = f_1172_11638_11809(f_1172_11699_11721(helpFile), false, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,11954,11979);

_helpFiles[helpFile] = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,11995,12024);

XmlNode 
helpItemsNode = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12040,12525) || true) && (f_1172_12044_12061(doc))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,12040,12525);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12104,12109);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12095,12510) || true) && (i < f_1172_12115_12135(f_1172_12115_12129(doc)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12137,12140)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1172,12095,12510))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,12095,12510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12182,12215);

XmlNode 
node = f_1172_12197_12214(f_1172_12197_12211(doc), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12237,12491) || true) && (f_1172_12241_12254(node)== XmlNodeType.Element &&(DynAbs.Tracing.TraceSender.Expression_True(1172, 12241, 12365)&&f_1172_12281_12360(f_1172_12296_12310(node), "helpItems", StringComparison.OrdinalIgnoreCase)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,12237,12491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12415,12436);

helpItemsNode = node;
DynAbs.Tracing.TraceSender.TraceBreak(1172,12462,12468);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,12237,12491);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1172,1,416);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1172,1,416);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1172,12040,12525);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12541,12719) || true) && (helpItemsNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,12541,12719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12600,12679);

f_1172_12600_12678(                s_tracer, "Unable to find 'helpItems' element in file {0}", helpFile);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12697,12704);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,12541,12719);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12735,12785);

bool 
isMaml = f_1172_12749_12784(helpFile, helpItemsNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12801,14056);
using(f_1172_12808_12839(f_1172_12808_12823(this), helpFile))            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12873,14041) || true) && (f_1172_12877_12904(helpItemsNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,12873,14041);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12955,12960);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12946,14022) || true) && (i < f_1172_12966_12996(f_1172_12966_12990(helpItemsNode)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,12998,13001)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1172,12946,14022))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,12946,14022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13051,13094);

XmlNode 
node = f_1172_13066_13093(f_1172_13066_13090(helpItemsNode), i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13122,13160);

string 
nodeLocalName = f_1172_13145_13159(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13188,13285);

bool 
isClass = (f_1172_13204_13278(nodeLocalName, "class", StringComparison.OrdinalIgnoreCase)== 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13313,13999) || true) && (f_1172_13317_13330(node)== XmlNodeType.Element &&(DynAbs.Tracing.TraceSender.Expression_True(1172, 13317, 13364)&&isClass))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,13313,13999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13422,13456);

MamlClassHelpInfo 
helpInfo = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13488,13705) || true) && (isMaml)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,13488,13705);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13564,13674) || true) && (isClass)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,13564,13674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13614,13674);

helpInfo = f_1172_13625_13673(node, HelpCategory.Class);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,13564,13674);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,13488,13705);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13737,13972) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1172,13737,13972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13823,13868);

f_1172_13823_13867(f_1172_13823_13838(this), f_1172_13851_13866(helpInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,13902,13941);

f_1172_13902_13940(this, helpFileIdentifier, helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,13737,13972);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1172,13313,13999);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1172,1,1077);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1172,1,1077);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1172,12873,14041);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1172,12801,14056);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1172,11314,14067);

bool
f_1172_11420_11450(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 11420, 11450);
return return_v;
}


int
f_1172_11408_11488(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 11408, 11488);
return 0;
}


bool
f_1172_11515_11555(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 11515, 11555);
return return_v;
}


int
f_1172_11503_11603(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 11503, 11603);
return 0;
}


System.IO.FileInfo
f_1172_11699_11721(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 11699, 11721);
return return_v;
}


System.Xml.XmlDocument
f_1172_11638_11809(System.IO.FileInfo
xmlPath,bool
preserveNonElements,int?
maxCharactersInDocument)
{
var return_v = InternalDeserializer.LoadUnsafeXmlDocument( xmlPath, preserveNonElements, maxCharactersInDocument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 11638, 11809);
return return_v;
}


bool
f_1172_12044_12061(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.HasChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12044, 12061);
return return_v;
}


System.Xml.XmlNodeList
f_1172_12115_12129(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12115, 12129);
return return_v;
}


int
f_1172_12115_12135(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12115, 12135);
return return_v;
}


System.Xml.XmlNodeList
f_1172_12197_12211(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12197, 12211);
return return_v;
}


System.Xml.XmlNode
f_1172_12197_12214(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12197, 12214);
return return_v;
}


System.Xml.XmlNodeType
f_1172_12241_12254(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12241, 12254);
return return_v;
}


string
f_1172_12296_12310(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12296, 12310);
return return_v;
}


int
f_1172_12281_12360(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 12281, 12360);
return return_v;
}


int
f_1172_12600_12678(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 12600, 12678);
return 0;
}


bool
f_1172_12749_12784(string
helpFile,System.Xml.XmlNode
helpItemsNode)
{
var return_v = IsMamlHelp( helpFile, helpItemsNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 12749, 12784);
return return_v;
}


System.Management.Automation.HelpSystem
f_1172_12808_12823(System.Management.Automation.PSClassHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12808, 12823);
return return_v;
}


System.IDisposable
f_1172_12808_12839(System.Management.Automation.HelpSystem
this_param,string
helpFile)
{
var return_v = this_param.Trace( helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 12808, 12839);
return return_v;
}


bool
f_1172_12877_12904(System.Xml.XmlNode
this_param)
{
var return_v = this_param.HasChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12877, 12904);
return return_v;
}


System.Xml.XmlNodeList
f_1172_12966_12990(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12966, 12990);
return return_v;
}


int
f_1172_12966_12996(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 12966, 12996);
return return_v;
}


System.Xml.XmlNodeList
f_1172_13066_13090(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 13066, 13090);
return return_v;
}


System.Xml.XmlNode
f_1172_13066_13093(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 13066, 13093);
return return_v;
}


string
f_1172_13145_13159(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 13145, 13159);
return return_v;
}


int
f_1172_13204_13278(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 13204, 13278);
return return_v;
}


System.Xml.XmlNodeType
f_1172_13317_13330(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 13317, 13330);
return return_v;
}


System.Management.Automation.MamlClassHelpInfo
f_1172_13625_13673(System.Xml.XmlNode
xmlNode,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = MamlClassHelpInfo.Load( xmlNode, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 13625, 13673);
return return_v;
}


System.Management.Automation.HelpSystem
f_1172_13823_13838(System.Management.Automation.PSClassHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 13823, 13838);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1172_13851_13866(System.Management.Automation.MamlClassHelpInfo
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 13851, 13866);
return return_v;
}


int
f_1172_13823_13867(System.Management.Automation.HelpSystem
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
errorRecords)
{
this_param.TraceErrors( errorRecords);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 13823, 13867);
return 0;
}


int
f_1172_13902_13940(System.Management.Automation.PSClassHelpProvider
this_param,string
target,System.Management.Automation.MamlClassHelpInfo
helpInfo)
{
this_param.AddCache( target, (System.Management.Automation.HelpInfo)helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 13902, 13940);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1172,11314,14067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,11314,14067);
}
		}

static PSClassHelpProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1172,371,14096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1172,1254,1334);
s_tracer = f_1172_1265_1334("PSClassHelpProvider", "PSClassHelpProvider");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1172,371,14096);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1172,371,14096);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1172,371,14096);

System.Management.Automation.ExecutionContext
f_1172_662_689(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1172, 662, 689);
return return_v;
}


static System.Management.Automation.HelpSystem
f_1172_615_625_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1172, 543, 701);
return return_v;
}


System.Collections.Hashtable
f_1172_1119_1134()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 1119, 1134);
return return_v;
}


static System.Management.Automation.PSTraceSource
f_1172_1265_1334(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1172, 1265, 1334);
return return_v;
}

}
}
