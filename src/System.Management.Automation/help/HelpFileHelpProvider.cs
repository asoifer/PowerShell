// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation.Internal;

namespace System.Management.Automation
{
internal class HelpFileHelpProvider : HelpProviderWithCache
{
internal HelpFileHelpProvider(HelpSystem helpSystem) :base(f_1154_910_920_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1154,850,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,17076,17104);
this._helpFiles = f_1154_17089_17104();DynAbs.Tracing.TraceSender.TraceExitConstructor(1154,850,943);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,850,943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,850,943);
}
		}

internal override string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,1177,1260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,1213,1245);

return "HelpFile Help Provider";
DynAbs.Tracing.TraceSender.TraceExitMethod(1154,1177,1260);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,1123,1271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,1123,1271);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,1500,1580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,1536,1565);

return HelpCategory.HelpFile;
DynAbs.Tracing.TraceSender.TraceExitMethod(1154,1500,1580);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,1432,1591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,1432,1591);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,1668,3387);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,1772,1800);

int 
countHelpInfosFound = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,1814,1869);

string 
helpFileName = f_1154_1836_1854(helpRequest)+ ".help.txt"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,1883,1985);

Collection<string> 
filesMatched = f_1154_1917_1984(helpFileName, f_1154_1959_1983(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2001,2082);

f_1154_2001_2081(filesMatched != null, "Files collection should not be null.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2096,2165);

var 
matchedFilesToRemove = f_1154_2123_2164(this, filesMatched)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2181,3376);
foreach(string file in f_1154_2205_2217_I(filesMatched) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,2181,3376);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2251,2322) || true) && (f_1154_2255_2290(matchedFilesToRemove, file))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,2251,2322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2313,2322);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,2251,2322);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2403,2993) || true) && (!f_1154_2408_2436(_helpFiles, file))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,2403,2993);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2530,2549);

f_1154_2530_2548(this, file);
                    }
                    catch (IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,2594,2756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2674,2733);

f_1154_2674_2732(this, ioException, f_1154_2707_2725(helpRequest), file);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,2594,2756);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,2778,2974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,2886,2951);

f_1154_2886_2950(this, securityException, f_1154_2925_2943(helpRequest), file);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,2778,2974);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,2403,2993);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3013,3048);

HelpInfo 
helpInfo = f_1154_3033_3047(this, file)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3068,3361) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,3068,3361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3130,3152);

countHelpInfosFound++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3174,3196);

listYield.Add(helpInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3220,3342) || true) && ((countHelpInfosFound >= f_1154_3248_3270(helpRequest)) &&(DynAbs.Tracing.TraceSender.Expression_True(1154, 3224, 3303)&&(f_1154_3276_3298(helpRequest)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,3220,3342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3330,3342);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,3220,3342);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,3068,3361);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,2181,3376);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1154,1,1196);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1154,1,1196);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1154,1668,3387);

return listYield;

string
f_1154_1836_1854(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 1836, 1854);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_1959_1983(System.Management.Automation.HelpFileHelpProvider
this_param)
{
var return_v = this_param.GetExtendedSearchPaths();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 1959, 1983);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_1917_1984(string
pattern,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = MUIFileSearcher.SearchFiles( pattern, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 1917, 1984);
return return_v;
}


int
f_1154_2001_2081(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2001, 2081);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1154_2123_2164(System.Management.Automation.HelpFileHelpProvider
this_param,System.Collections.ObjectModel.Collection<string>
filesMatched)
{
var return_v = this_param.FilterToLatestModuleVersion( filesMatched);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2123, 2164);
return return_v;
}


bool
f_1154_2255_2290(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2255, 2290);
return return_v;
}


bool
f_1154_2408_2436(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2408, 2436);
return return_v;
}


System.Management.Automation.HelpInfo
f_1154_2530_2548(System.Management.Automation.HelpFileHelpProvider
this_param,string
path)
{
var return_v = this_param.LoadHelpFile( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2530, 2548);
return return_v;
}


string
f_1154_2707_2725(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 2707, 2725);
return return_v;
}


int
f_1154_2674_2732(System.Management.Automation.HelpFileHelpProvider
this_param,System.IO.IOException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2674, 2732);
return 0;
}


string
f_1154_2925_2943(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 2925, 2943);
return return_v;
}


int
f_1154_2886_2950(System.Management.Automation.HelpFileHelpProvider
this_param,System.Security.SecurityException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2886, 2950);
return 0;
}


System.Management.Automation.HelpInfo
f_1154_3033_3047(System.Management.Automation.HelpFileHelpProvider
this_param,string
target)
{
var return_v = this_param.GetCache( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 3033, 3047);
return return_v;
}


int
f_1154_3248_3270(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 3248, 3270);
return return_v;
}


int
f_1154_3276_3298(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 3276, 3298);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_2205_2217_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 2205, 2217);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,1668,3387);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,1668,3387);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Collection<string> FilterToLatestModuleVersion(Collection<string> filesMatched)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,3399,7816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3511,3578);

Collection<string> 
matchedFilesToRemove = f_1154_3553_3577()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3594,6851) || true) && (f_1154_3598_3616(filesMatched)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,3594,6851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3737,3879);

Dictionary<Tuple<string, string>, Tuple<string, Version>> 
modulesAndVersion = f_1154_3815_3878()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3897,3952);

HashSet<string> 
filesProcessed = f_1154_3930_3951()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,3972,4067);

var 
allPSModulePaths = f_1154_3995_4066(false, f_1154_4033_4065(f_1154_4033_4048(this)))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4087,6836);
foreach(string fileFullName in f_1154_4119_4131_I(filesMatched) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,4087,6836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4329,4375);

var 
fileName = f_1154_4344_4374(fileFullName)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4399,6764);
foreach(string psModulePath in f_1154_4431_4447_I(allPSModulePaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,4399,6764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4497,4534);

Version 
moduleVersionFromPath = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4560,4585);

string 
moduleName = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4611,4706);

f_1154_4611_4705(this, psModulePath, fileFullName, out moduleName, out moduleVersionFromPath);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4837,6741) || true) && (moduleVersionFromPath != null &&(DynAbs.Tracing.TraceSender.Expression_True(1154, 4841, 4892)&&moduleName != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,4837,6741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,4950,4994);

Tuple<string, Version> 
moduleVersion = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,5024,5100);

Tuple<string, string> 
key = f_1154_5052_5099(moduleName, fileName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,5130,6714) || true) && (f_1154_5134_5187(modulesAndVersion, key, out moduleVersion))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,5130,6714);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,5357,6260) || true) && (f_1154_5361_5394(filesProcessed, fileName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,5357,6260);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,5468,6225) || true) && (moduleVersionFromPath > f_1154_5496_5515(moduleVersion))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,5468,6225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,5597,5686);

modulesAndVersion[key] = f_1154_5622_5685(fileFullName, moduleVersionFromPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,5826,5872);

f_1154_5826_5871(
                                        // Remove the old file since we found a newer version.
                                        matchedFilesToRemove, f_1154_5851_5870(moduleVersion));
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,5468,6225);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,5468,6225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,6147,6186);

f_1154_6147_6185(                                        // Remove the new file as higher version item is already in dictionary.
                                        matchedFilesToRemove, fileFullName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,5468,6225);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,5357,6260);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,5130,6714);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,5130,6714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,6492,6683);

f_1154_6492_6682(                                // Add the module to the dictionary as it was not processes earlier.
                                modulesAndVersion, f_1154_6514_6561(moduleName, fileName), f_1154_6618_6681(fileFullName, moduleVersionFromPath));
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,5130,6714);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,4837,6741);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,4399,6764);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1154,1,2366);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1154,1,2366);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,6788,6817);

f_1154_6788_6816(
                    filesProcessed, fileName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,4087,6836);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1154,1,2750);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1154,1,2750);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1154,3594,6851);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7087,7140);

HashSet<string> 
fileNameHash = f_1154_7118_7139()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7156,7761);
foreach(var file in f_1154_7177_7189_I(filesMatched) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,7156,7761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7223,7264);

string 
fileName = f_1154_7241_7263(file)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7284,7746) || true) && (!f_1154_7289_7320(fileNameHash, fileName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,7284,7746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7362,7389);

f_1154_7362_7388(                    fileNameHash, fileName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,7284,7746);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,7284,7746);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7583,7727) || true) && (!f_1154_7588_7623(matchedFilesToRemove, file))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,7583,7727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7673,7704);

f_1154_7673_7703(                        matchedFilesToRemove, file);
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,7583,7727);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,7284,7746);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,7156,7761);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1154,1,606);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1154,1,606);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7777,7805);

return matchedFilesToRemove;
DynAbs.Tracing.TraceSender.TraceExitMethod(1154,3399,7816);

System.Collections.ObjectModel.Collection<string>
f_1154_3553_3577()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 3553, 3577);
return return_v;
}


int
f_1154_3598_3616(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 3598, 3616);
return return_v;
}


System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<string, System.Version>>
f_1154_3815_3878()
{
var return_v = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<string, System.Version>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 3815, 3878);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1154_3930_3951()
{
var return_v = new System.Collections.Generic.HashSet<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 3930, 3951);
return return_v;
}


System.Management.Automation.HelpSystem
f_1154_4033_4048(System.Management.Automation.HelpFileHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 4033, 4048);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1154_4033_4065(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 4033, 4065);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1154_3995_4066(bool
includeSystemModulePath,System.Management.Automation.ExecutionContext
context)
{
var return_v = ModuleIntrinsics.GetModulePath( includeSystemModulePath, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 3995, 4066);
return return_v;
}


string?
f_1154_4344_4374(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 4344, 4374);
return return_v;
}


int
f_1154_4611_4705(System.Management.Automation.HelpFileHelpProvider
this_param,string
psmodulePathRoot,string
filePath,out string
moduleName,out System.Version
moduleVersion)
{
this_param.GetModuleNameAndVersion( psmodulePathRoot, filePath, out moduleName, out moduleVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 4611, 4705);
return 0;
}


System.Tuple<string, string>
f_1154_5052_5099(string
item1,string
item2)
{
var return_v = new System.Tuple<string, string>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 5052, 5099);
return return_v;
}


bool
f_1154_5134_5187(System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<string, System.Version>>
this_param,System.Tuple<string, string>
key,out System.Tuple<string, System.Version>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 5134, 5187);
return return_v;
}


bool
f_1154_5361_5394(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 5361, 5394);
return return_v;
}


System.Version
f_1154_5496_5515(System.Tuple<string, System.Version>
this_param)
{
var return_v = this_param.Item2;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 5496, 5515);
return return_v;
}


System.Tuple<string, System.Version>
f_1154_5622_5685(string
item1,System.Version
item2)
{
var return_v = new System.Tuple<string, System.Version>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 5622, 5685);
return return_v;
}


string
f_1154_5851_5870(System.Tuple<string, System.Version>
this_param)
{
var return_v = this_param.Item1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 5851, 5870);
return return_v;
}


int
f_1154_5826_5871(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 5826, 5871);
return 0;
}


int
f_1154_6147_6185(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 6147, 6185);
return 0;
}


System.Tuple<string, string>
f_1154_6514_6561(string
item1,string
item2)
{
var return_v = new System.Tuple<string, string>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 6514, 6561);
return return_v;
}


System.Tuple<string, System.Version>
f_1154_6618_6681(string
item1,System.Version
item2)
{
var return_v = new System.Tuple<string, System.Version>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 6618, 6681);
return return_v;
}


int
f_1154_6492_6682(System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<string, System.Version>>
this_param,System.Tuple<string, string>
key,System.Tuple<string, System.Version>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 6492, 6682);
return 0;
}


System.Collections.Generic.IEnumerable<string>
f_1154_4431_4447_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 4431, 4447);
return return_v;
}


bool
f_1154_6788_6816(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 6788, 6816);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_4119_4131_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 4119, 4131);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1154_7118_7139()
{
var return_v = new System.Collections.Generic.HashSet<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 7118, 7139);
return return_v;
}


string?
f_1154_7241_7263(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 7241, 7263);
return return_v;
}


bool
f_1154_7289_7320(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 7289, 7320);
return return_v;
}


bool
f_1154_7362_7388(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 7362, 7388);
return return_v;
}


bool
f_1154_7588_7623(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 7588, 7623);
return return_v;
}


int
f_1154_7673_7703(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 7673, 7703);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1154_7177_7189_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 7177, 7189);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,3399,7816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,3399,7816);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,7828,10908);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,7952,7987);

string 
target = f_1154_7968_7986(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8001,8025);

string 
pattern = target
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8039,8075);

int 
countOfHelpInfoObjectsFound = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8159,8198);

WildcardPattern 
wildCardPattern = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8214,8584) || true) && ((!searchOnlyContent) &&(DynAbs.Tracing.TraceSender.Expression_True(1154, 8218, 8295)&&(!f_1154_8244_8294(target))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,8214,8584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8539,8569);

pattern = "*" + pattern + "*";
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,8214,8584);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8600,9102) || true) && (searchOnlyContent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,8600,9102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8655,8696);

string 
searchTarget = f_1154_8677_8695(helpRequest)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8714,8882) || true) && (!f_1154_8719_8781(f_1154_8762_8780(helpRequest)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,8714,8882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8823,8863);

searchTarget = "*" + searchTarget + "*";
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,8714,8882);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,8902,9009);

wildCardPattern = f_1154_8920_9008(searchTarget, WildcardOptions.Compiled | WildcardOptions.IgnoreCase);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9073,9087);

pattern = "*";
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,8600,9102);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9118,9141);

pattern += ".help.txt";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9157,9247);

Collection<string> 
files = f_1154_9184_9246(pattern, f_1154_9221_9245(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9263,9325);

var 
matchedFilesToRemove = f_1154_9290_9324(this, files)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9341,9389) || true) && (files == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,9341,9389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9377,9389);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,9341,9389);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9405,10897);
foreach(string file in f_1154_9429_9434_I(files) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,9405,10897);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9468,9539) || true) && (f_1154_9472_9507(matchedFilesToRemove, file))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,9468,9539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9530,9539);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,9468,9539);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9620,10210) || true) && (!f_1154_9625_9653(_helpFiles, file))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,9620,10210);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9747,9766);

f_1154_9747_9765(this, file);
                    }
                    catch (IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,9811,9973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,9891,9950);

f_1154_9891_9949(this, ioException, f_1154_9924_9942(helpRequest), file);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,9811,9973);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,9995,10191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10103,10168);

f_1154_10103_10167(this, securityException, f_1154_10142_10160(helpRequest), file);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,9995,10191);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,9620,10210);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10230,10293);

HelpFileHelpInfo 
helpInfo = f_1154_10258_10272(this, file)as HelpFileHelpInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10313,10882) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,10313,10882);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10375,10615) || true) && (searchOnlyContent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,10375,10615);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10446,10592) || true) && (!f_1154_10451_10498(helpInfo, wildCardPattern))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,10446,10592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10556,10565);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,10446,10592);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,10375,10615);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10639,10669);

countOfHelpInfoObjectsFound++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10691,10713);

listYield.Add(helpInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10737,10863) || true) && (countOfHelpInfoObjectsFound >= f_1154_10772_10794(helpRequest)&&(DynAbs.Tracing.TraceSender.Expression_True(1154, 10741, 10824)&&f_1154_10798_10820(helpRequest)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,10737,10863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,10851,10863);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,10737,10863);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,10313,10882);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,9405,10897);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1154,1,1493);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1154,1,1493);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1154,7828,10908);

return listYield;

string
f_1154_7968_7986(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 7968, 7986);
return return_v;
}


bool
f_1154_8244_8294(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 8244, 8294);
return return_v;
}


string
f_1154_8677_8695(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 8677, 8695);
return return_v;
}


string
f_1154_8762_8780(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 8762, 8780);
return return_v;
}


bool
f_1154_8719_8781(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 8719, 8781);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1154_8920_9008(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 8920, 9008);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_9221_9245(System.Management.Automation.HelpFileHelpProvider
this_param)
{
var return_v = this_param.GetExtendedSearchPaths();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9221, 9245);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_9184_9246(string
pattern,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = MUIFileSearcher.SearchFiles( pattern, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9184, 9246);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_9290_9324(System.Management.Automation.HelpFileHelpProvider
this_param,System.Collections.ObjectModel.Collection<string>
filesMatched)
{
var return_v = this_param.FilterToLatestModuleVersion( filesMatched);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9290, 9324);
return return_v;
}


bool
f_1154_9472_9507(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9472, 9507);
return return_v;
}


bool
f_1154_9625_9653(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9625, 9653);
return return_v;
}


System.Management.Automation.HelpInfo
f_1154_9747_9765(System.Management.Automation.HelpFileHelpProvider
this_param,string
path)
{
var return_v = this_param.LoadHelpFile( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9747, 9765);
return return_v;
}


string
f_1154_9924_9942(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 9924, 9942);
return return_v;
}


int
f_1154_9891_9949(System.Management.Automation.HelpFileHelpProvider
this_param,System.IO.IOException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9891, 9949);
return 0;
}


string
f_1154_10142_10160(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 10142, 10160);
return return_v;
}


int
f_1154_10103_10167(System.Management.Automation.HelpFileHelpProvider
this_param,System.Security.SecurityException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 10103, 10167);
return 0;
}


System.Management.Automation.HelpInfo
f_1154_10258_10272(System.Management.Automation.HelpFileHelpProvider
this_param,string
target)
{
var return_v = this_param.GetCache( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 10258, 10272);
return return_v;
}


bool
f_1154_10451_10498(System.Management.Automation.HelpFileHelpInfo
this_param,System.Management.Automation.WildcardPattern
pattern)
{
var return_v = this_param.MatchPatternInContent( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 10451, 10498);
return return_v;
}


int
f_1154_10772_10794(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 10772, 10794);
return return_v;
}


int
f_1154_10798_10820(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 10798, 10820);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1154_9429_9434_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 9429, 9434);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,7828,10908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,7828,10908);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void GetModuleNameAndVersion(string psmodulePathRoot, string filePath, out string moduleName, out Version moduleVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,10920,11795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11073,11094);

moduleVersion = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11108,11126);

moduleName = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11142,11784) || true) && (f_1154_11146_11219(filePath, psmodulePathRoot, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,11142,11784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11253,11359);

var 
moduleRootSubPath = f_1154_11277_11358(f_1154_11277_11320(filePath, 0, f_1154_11296_11319(psmodulePathRoot)), Utils.Separators.Directory)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11377,11484);

var 
pathParts = f_1154_11393_11483(moduleRootSubPath, Utils.Separators.Directory, StringSplitOptions.RemoveEmptyEntries)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11504,11530);

moduleName = pathParts[0];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11548,11584);

var 
potentialVersion = pathParts[1]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11602,11617);

Version 
result
=default(Version);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11635,11769) || true) && (f_1154_11639_11685(potentialVersion, out result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,11635,11769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,11727,11750);

moduleVersion = result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,11635,11769);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,11142,11784);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1154,10920,11795);

bool
f_1154_11146_11219(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 11146, 11219);
return return_v;
}


int
f_1154_11296_11319(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 11296, 11319);
return return_v;
}


string
f_1154_11277_11320(string
this_param,int
startIndex,int
count)
{
var return_v = this_param.Remove( startIndex, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 11277, 11320);
return return_v;
}


string
f_1154_11277_11358(string
this_param,params char[]
trimChars)
{
var return_v = this_param.TrimStart( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 11277, 11358);
return return_v;
}


string[]
f_1154_11393_11483(string
this_param,char[]
separator,System.StringSplitOptions
options)
{
var return_v = this_param.Split( separator, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 11393, 11483);
return return_v;
}


bool
f_1154_11639_11685(string
input,out System.Version
result)
{
var return_v = Version.TryParse( input, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 11639, 11685);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,10920,11795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,10920,11795);
}
		}

private HelpInfo LoadHelpFile(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,12046,13561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12113,12154);

string 
fileName = f_1154_12131_12153(path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12642,12740) || true) && (!f_1154_12647_12709(path, ".help.txt", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,12642,12740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12728,12740);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,12642,12740);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12756,12838);

string 
name = f_1154_12770_12837(fileName, 0, f_1154_12792_12807(fileName)- 9)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12854,12915) || true) && (f_1154_12858_12884(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,12854,12915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12903,12915);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,12854,12915);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12931,12966);

HelpInfo 
helpInfo = f_1154_12951_12965(this, path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,12982,13037) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,12982,13037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13021,13037);

return helpInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,12982,13037);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13053,13076);

string 
helpText = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13092,13276);
using(TextReader 
tr = f_1154_13115_13201(f_1154_13132_13200(path, FileMode.Open, FileAccess.Read, FileShare.Read))
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13235,13261);

helpText = f_1154_13246_13260(tr);
DynAbs.Tracing.TraceSender.TraceExitUsing(1154,13092,13276);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13380,13401);

_helpFiles[path] = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13415,13477);

helpInfo = f_1154_13426_13476(name, helpText, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13493,13518);

f_1154_13493_13517(this, path, helpInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,13534,13550);

return helpInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1154,12046,13561);

string?
f_1154_12131_12153(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 12131, 12153);
return return_v;
}


bool
f_1154_12647_12709(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 12647, 12709);
return return_v;
}


int
f_1154_12792_12807(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 12792, 12807);
return return_v;
}


string
f_1154_12770_12837(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 12770, 12837);
return return_v;
}


bool
f_1154_12858_12884(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 12858, 12884);
return return_v;
}


System.Management.Automation.HelpInfo
f_1154_12951_12965(System.Management.Automation.HelpFileHelpProvider
this_param,string
target)
{
var return_v = this_param.GetCache( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 12951, 12965);
return return_v;
}


System.IO.FileStream
f_1154_13132_13200(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access,System.IO.FileShare
share)
{
var return_v = new System.IO.FileStream( path, mode, access, share);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 13132, 13200);
return return_v;
}


System.IO.StreamReader
f_1154_13115_13201(System.IO.FileStream
stream)
{
var return_v = new System.IO.StreamReader( (System.IO.Stream)stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 13115, 13201);
return return_v;
}


string
f_1154_13246_13260(System.IO.TextReader
this_param)
{
var return_v = this_param.ReadToEnd();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 13246, 13260);
return return_v;
}


System.Management.Automation.HelpFileHelpInfo
f_1154_13426_13476(string
name,string
text,string
filename)
{
var return_v = HelpFileHelpInfo.GetHelpInfo( name, text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 13426, 13476);
return return_v;
}


int
f_1154_13493_13517(System.Management.Automation.HelpFileHelpProvider
this_param,string
target,System.Management.Automation.HelpInfo
helpInfo)
{
this_param.AddCache( target, helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 13493, 13517);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,12046,13561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,12046,13561);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<string> GetExtendedSearchPaths()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,13934,16495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14011,14061);

Collection<string> 
searchPaths = f_1154_14044_14060(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14128,14188);

string 
defaultShellSearchPath = f_1154_14160_14187(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14204,14260);

int 
index = f_1154_14216_14259(searchPaths, defaultShellSearchPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14274,14505) || true) && (index != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,14274,14505);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14322,14424) || true) && (index > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,14322,14424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14377,14405);

f_1154_14377_14404(                    searchPaths, index);
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,14322,14424);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14444,14490);

f_1154_14444_14489(
                searchPaths, 0, defaultShellSearchPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,14274,14505);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14568,14623);

f_1154_14568_14622(
            // Add the CurrentUser help path.
            searchPaths, f_1154_14584_14621());
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14836,16449);
foreach(string psModulePath in f_1154_14868_14939_I(f_1154_14868_14939(false, f_1154_14906_14938(f_1154_14906_14921(this)))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,14836,16449);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,14973,16434) || true) && (f_1154_14977_15007(psModulePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,14973,16434);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,15271,15367);

string[] 
directories = f_1154_15294_15366(psModulePath, "*", SearchOption.AllDirectories)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,15395,15511);

var 
possibleModuleDirectories = f_1154_15427_15510(directories, directory => !ModuleUtils.IsPossibleResourceDirectory(directory))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,15539,16064);
foreach(string directory in f_1154_15568_15593_I(possibleModuleDirectories) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,15539,16064);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,15723,16037) || true) && (f_1154_15727_15768(f_1154_15727_15762(directory)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,15723,16037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,15834,16006) || true) && (!f_1154_15839_15870(searchPaths, directory))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1154,15834,16006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,15944,15971);

f_1154_15944_15970(                                    searchPaths, directory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,15834,16006);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,15723,16037);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,15539,16064);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1154,1,526);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1154,1,526);
}                    }
                    // Absorb any exception related to enumerating directories
                    catch (System.ArgumentException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,16189,16225);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,16189,16225);
}
                    catch (System.IO.IOException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,16247,16280);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,16247,16280);
}
                    catch (System.UnauthorizedAccessException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,16302,16348);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,16302,16348);
}
                    catch (System.Security.SecurityException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1154,16370,16415);
DynAbs.Tracing.TraceSender.TraceExitCatch(1154,16370,16415);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,14973,16434);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1154,14836,16449);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1154,1,1614);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1154,1,1614);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,16465,16484);

return searchPaths;
DynAbs.Tracing.TraceSender.TraceExitMethod(1154,13934,16495);

System.Collections.ObjectModel.Collection<string>
f_1154_14044_14060(System.Management.Automation.HelpFileHelpProvider
this_param)
{
var return_v = this_param.GetSearchPaths();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14044, 14060);
return return_v;
}


string
f_1154_14160_14187(System.Management.Automation.HelpFileHelpProvider
this_param)
{
var return_v = this_param.GetDefaultShellSearchPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14160, 14187);
return return_v;
}


int
f_1154_14216_14259(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.IndexOf( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14216, 14259);
return return_v;
}


int
f_1154_14377_14404(System.Collections.ObjectModel.Collection<string>
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14377, 14404);
return 0;
}


int
f_1154_14444_14489(System.Collections.ObjectModel.Collection<string>
this_param,int
index,string
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14444, 14489);
return 0;
}


string
f_1154_14584_14621()
{
var return_v = HelpUtils.GetUserHomeHelpSearchPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14584, 14621);
return return_v;
}


int
f_1154_14568_14622(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14568, 14622);
return 0;
}


System.Management.Automation.HelpSystem
f_1154_14906_14921(System.Management.Automation.HelpFileHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 14906, 14921);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1154_14906_14938(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1154, 14906, 14938);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1154_14868_14939(bool
includeSystemModulePath,System.Management.Automation.ExecutionContext
context)
{
var return_v = ModuleIntrinsics.GetModulePath( includeSystemModulePath, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14868, 14939);
return return_v;
}


bool
f_1154_14977_15007(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14977, 15007);
return return_v;
}


string[]
f_1154_15294_15366(string
path,string
searchPattern,System.IO.SearchOption
searchOption)
{
var return_v = Directory.GetDirectories( path, searchPattern, searchOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 15294, 15366);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1154_15427_15510(string[]
source,System.Func<string, bool>
predicate)
{
var return_v = source.Where<string>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 15427, 15510);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1154_15727_15762(string
path)
{
var return_v = Directory.EnumerateFiles( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 15727, 15762);
return return_v;
}


bool
f_1154_15727_15768(System.Collections.Generic.IEnumerable<string>
source)
{
var return_v = source.Any<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 15727, 15768);
return return_v;
}


bool
f_1154_15839_15870(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 15839, 15870);
return return_v;
}


int
f_1154_15944_15970(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 15944, 15970);
return 0;
}


System.Collections.Generic.IEnumerable<string>
f_1154_15568_15593_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 15568, 15593);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1154_14868_14939_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 14868, 14939);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,13934,16495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,13934,16495);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1154,16664,16778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,16719,16732);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Reset(),1154,16719,16731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1154,16748,16767);

f_1154_16748_16766(
            _helpFiles);
DynAbs.Tracing.TraceSender.TraceExitMethod(1154,16664,16778);

int
f_1154_16748_16766(System.Collections.Hashtable
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 16748, 16766);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1154,16664,16778);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,16664,16778);
}
		}

private Hashtable _helpFiles ;

static HelpFileHelpProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1154,684,17134);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1154,684,17134);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1154,684,17134);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1154,684,17134);

static System.Management.Automation.HelpSystem
f_1154_910_920_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1154, 850, 943);
return return_v;
}


System.Collections.Hashtable
f_1154_17089_17104()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1154, 17089, 17104);
return return_v;
}

}
}

