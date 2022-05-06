// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace System.Management.Automation
{
internal class MUIFileSearcher
{
private MUIFileSearcher(string target, Collection<string> searchPaths, SearchMode searchMode)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1167,749,972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,1671,1710);
this.Target = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,1815,1871);
this.SearchPaths = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,1977,2037);
this.SearchMode = SearchMode.Unique;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,2076,2090);
this._result = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,2875,2939);
this._uniqueMatches = f_1167_2892_2939(f_1167_2906_2938());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,867,883);

Target = target;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,897,923);

SearchPaths = searchPaths;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,937,961);

SearchMode = searchMode;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1167,749,972);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,749,972);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,749,972);
}
		}

private MUIFileSearcher(string target, Collection<string> searchPaths)
:this(f_1167_1269_1275_C(target) ,searchPaths,SearchMode.Unique)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1167,1178,1330);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1167,1178,1330);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,1178,1330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,1178,1330);
}
		}

internal string Target {get; }

internal Collection<string> SearchPaths {get; }

internal SearchMode SearchMode {get; }

private Collection<string> _result ;

internal Collection<string> Result
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1167,2244,2558);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,2280,2508) || true) && (_result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,2280,2508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,2341,2376);

_result = f_1167_2351_2375();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,2472,2489);

f_1167_2472_2488(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,2280,2508);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,2528,2543);

return _result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1167,2244,2558);

System.Collections.ObjectModel.Collection<string>
f_1167_2351_2375()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 2351, 2375);
return return_v;
}


int
f_1167_2472_2488(System.Management.Automation.MUIFileSearcher
this_param)
{
this_param.SearchForFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 2472, 2488);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,2185,2569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,2185,2569);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private Hashtable _uniqueMatches ;

private void SearchForFiles()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1167,3081,3758);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3135,3198) || true) && (f_1167_3139_3172(f_1167_3160_3171(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,3135,3198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3191,3198);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,3135,3198);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3214,3261);

string 
pattern = f_1167_3231_3260(f_1167_3248_3259(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3275,3334) || true) && (f_1167_3279_3308(pattern))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,3275,3334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3327,3334);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,3275,3334);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3350,3445);

Collection<string> 
normalizedSearchPaths = f_1167_3393_3444(f_1167_3414_3425(this), f_1167_3427_3443(this))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3461,3747);
foreach(string directory in f_1167_3490_3511_I(normalizedSearchPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,3461,3747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3545,3580);

f_1167_3545_3579(this, pattern, directory);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3600,3732) || true) && (f_1167_3604_3619(this)== SearchMode.First &&(DynAbs.Tracing.TraceSender.Expression_True(1167, 3604, 3664)&&f_1167_3643_3660(f_1167_3643_3654(this))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,3600,3732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,3706,3713);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,3600,3732);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,3461,3747);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1167,1,287);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1167,1,287);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1167,3081,3758);

string
f_1167_3160_3171(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 3160, 3171);
return return_v;
}


bool
f_1167_3139_3172(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 3139, 3172);
return return_v;
}


string
f_1167_3248_3259(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 3248, 3259);
return return_v;
}


string?
f_1167_3231_3260(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 3231, 3260);
return return_v;
}


bool
f_1167_3279_3308(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 3279, 3308);
return return_v;
}


string
f_1167_3414_3425(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 3414, 3425);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_3427_3443(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.SearchPaths;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 3427, 3443);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_3393_3444(string
target,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = NormalizeSearchPaths( target, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 3393, 3444);
return return_v;
}


int
f_1167_3545_3579(System.Management.Automation.MUIFileSearcher
this_param,string
pattern,string
directory)
{
this_param.SearchForFiles( pattern, directory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 3545, 3579);
return 0;
}


System.Management.Automation.SearchMode
f_1167_3604_3619(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.SearchMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 3604, 3619);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_3643_3654(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 3643, 3654);
return return_v;
}


int
f_1167_3643_3660(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 3643, 3660);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_3490_3511_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 3490, 3511);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,3081,3758);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,3081,3758);
}
		}

private string[] GetFiles(string path, string pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1167,3770,4995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,4935,4976);

return f_1167_4942_4975(path, pattern);
DynAbs.Tracing.TraceSender.TraceExitMethod(1167,3770,4995);

string[]
f_1167_4942_4975(string
path,string
searchPattern)
{
var return_v = Directory.GetFiles( path, searchPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 4942, 4975);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,3770,4995);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,3770,4995);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void AddFiles(string muiDirectory, string directory, string pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1167,5007,6844);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5108,6833) || true) && (f_1167_5112_5142(muiDirectory))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,5108,6833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5176,5225);

string[] 
files = f_1167_5193_5224(this, muiDirectory, pattern)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5245,5292) || true) && (files == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,5245,5292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5285,5292);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,5245,5292);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5312,6818);
foreach(string file in f_1167_5336_5341_I(files) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,5312,6818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5383,5430);

string 
path = f_1167_5397_5429(muiDirectory, file)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5454,6799);

switch (f_1167_5462_5477(this))
                    {

case SearchMode.All:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,5454,6799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,5577,5595);

f_1167_5577_5594(                            _result, path);
DynAbs.Tracing.TraceSender.TraceBreak(1167,5625,5631);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,5454,6799);

case SearchMode.Unique:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,5454,6799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,6095,6140);

string 
leafFileName = f_1167_6117_6139(file)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,6170,6235);

string 
uniqueToDirectory = f_1167_6197_6234(directory, leafFileName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,6267,6531) || true) && (!f_1167_6272_6294(_result, path)&&(DynAbs.Tracing.TraceSender.Expression_True(1167, 6271, 6341)&&!f_1167_6299_6341(_uniqueMatches, uniqueToDirectory)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,6267,6531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,6407,6425);

f_1167_6407_6424(                                _result, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,6459,6500);

_uniqueMatches[uniqueToDirectory] = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,6267,6531);
}
DynAbs.Tracing.TraceSender.TraceBreak(1167,6563,6569);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,5454,6799);

case SearchMode.First:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,5454,6799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,6649,6667);

f_1167_6649_6666(                            _result, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,6697,6704);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,5454,6799);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,5454,6799);
DynAbs.Tracing.TraceSender.TraceBreak(1167,6770,6776);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,5454,6799);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,5312,6818);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1167,1,1507);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1167,1,1507);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1167,5108,6833);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1167,5007,6844);

bool
f_1167_5112_5142(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 5112, 5142);
return return_v;
}


string[]
f_1167_5193_5224(System.Management.Automation.MUIFileSearcher
this_param,string
path,string
pattern)
{
var return_v = this_param.GetFiles( path, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 5193, 5224);
return return_v;
}


string
f_1167_5397_5429(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 5397, 5429);
return return_v;
}


System.Management.Automation.SearchMode
f_1167_5462_5477(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.SearchMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 5462, 5477);
return return_v;
}


int
f_1167_5577_5594(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 5577, 5594);
return 0;
}


string?
f_1167_6117_6139(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 6117, 6139);
return return_v;
}


string
f_1167_6197_6234(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 6197, 6234);
return return_v;
}


bool
f_1167_6272_6294(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 6272, 6294);
return return_v;
}


bool
f_1167_6299_6341(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.Contains( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 6299, 6341);
return return_v;
}


int
f_1167_6407_6424(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 6407, 6424);
return 0;
}


int
f_1167_6649_6666(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 6649, 6666);
return 0;
}


string[]
f_1167_5336_5341_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 5336, 5341);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,5007,6844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,5007,6844);
}
		}

private void SearchForFiles(string pattern, string directory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1167,7192,8364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7278,7328);

List<string> 
cultureNameList = f_1167_7309_7327()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7342,7393);

CultureInfo 
culture = f_1167_7364_7392()
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7409,7596) || true) && (culture != null &&(DynAbs.Tracing.TraceSender.Expression_True(1167, 7416, 7470)&&!f_1167_7436_7470(f_1167_7457_7469(culture))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,7409,7596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7504,7538);

f_1167_7504_7537(                cultureNameList, f_1167_7524_7536(culture));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7556,7581);

culture = f_1167_7566_7580(culture);
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,7409,7596);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1167,7409,7596);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1167,7409,7596);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7612,7646);

f_1167_7612_7645(
            cultureNameList, string.Empty);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7717,7833) || true) && (!f_1167_7722_7755(cultureNameList, "en-US"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,7717,7833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7789,7818);

f_1167_7789_7817(                cultureNameList, "en-US");
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,7717,7833);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7849,7959) || true) && (!f_1167_7854_7884(cultureNameList, "en"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,7849,7959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7918,7944);

f_1167_7918_7943(                cultureNameList, "en");
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,7849,7959);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,7975,8330);
foreach(string name in f_1167_7999_8014_I(cultureNameList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,7975,8330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,8048,8100);

string 
muiDirectory = f_1167_8070_8099(directory, name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,8120,8163);

f_1167_8120_8162(this, muiDirectory, directory, pattern);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,8183,8315) || true) && (f_1167_8187_8202(this)== SearchMode.First &&(DynAbs.Tracing.TraceSender.Expression_True(1167, 8187, 8247)&&f_1167_8226_8243(f_1167_8226_8237(this))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,8183,8315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,8289,8296);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,8183,8315);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,7975,8330);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1167,1,356);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1167,1,356);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,8346,8353);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1167,7192,8364);

System.Collections.Generic.List<string>
f_1167_7309_7327()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7309, 7327);
return return_v;
}


System.Globalization.CultureInfo
f_1167_7364_7392()
{
var return_v = CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 7364, 7392);
return return_v;
}


string
f_1167_7457_7469(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 7457, 7469);
return return_v;
}


bool
f_1167_7436_7470(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7436, 7470);
return return_v;
}


string
f_1167_7524_7536(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 7524, 7536);
return return_v;
}


int
f_1167_7504_7537(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7504, 7537);
return 0;
}


System.Globalization.CultureInfo
f_1167_7566_7580(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 7566, 7580);
return return_v;
}


int
f_1167_7612_7645(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7612, 7645);
return 0;
}


bool
f_1167_7722_7755(System.Collections.Generic.List<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7722, 7755);
return return_v;
}


int
f_1167_7789_7817(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7789, 7817);
return 0;
}


bool
f_1167_7854_7884(System.Collections.Generic.List<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7854, 7884);
return return_v;
}


int
f_1167_7918_7943(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7918, 7943);
return 0;
}


string
f_1167_8070_8099(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 8070, 8099);
return return_v;
}


int
f_1167_8120_8162(System.Management.Automation.MUIFileSearcher
this_param,string
muiDirectory,string
directory,string
pattern)
{
this_param.AddFiles( muiDirectory, directory, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 8120, 8162);
return 0;
}


System.Management.Automation.SearchMode
f_1167_8187_8202(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.SearchMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 8187, 8202);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_8226_8237(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 8226, 8237);
return return_v;
}


int
f_1167_8226_8243(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 8226, 8243);
return return_v;
}


System.Collections.Generic.List<string>
f_1167_7999_8014_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 7999, 8014);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,7192,8364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,7192,8364);
}
		}

private static Collection<string> NormalizeSearchPaths(string target, Collection<string> searchPaths)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1167,9088,10739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,9214,9267);

Collection<string> 
result = f_1167_9242_9266()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,9393,9879) || true) && (!f_1167_9398_9426(target)&&(DynAbs.Tracing.TraceSender.Expression_True(1167, 9397, 9482)&&!f_1167_9431_9482(f_1167_9452_9481(target))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,9393,9879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,9516,9565);

string 
directory = f_1167_9535_9564(target)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,9585,9717) || true) && (f_1167_9589_9616(directory))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,9585,9717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,9658,9698);

f_1167_9658_9697(                    result, f_1167_9669_9696(directory));
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,9585,9717);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,9850,9864);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,9393,9879);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,9964,10294) || true) && (searchPaths != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,9964,10294);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,10021,10279);
foreach(string directory in f_1167_10050_10061_I(searchPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,10021,10279);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,10103,10260) || true) && (!f_1167_10108_10134(result, directory)&&(DynAbs.Tracing.TraceSender.Expression_True(1167, 10107, 10165)&&f_1167_10138_10165(directory)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,10103,10260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,10215,10237);

f_1167_10215_10236(                        result, directory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,10103,10260);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,10021,10279);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1167,1,259);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1167,1,259);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1167,9964,10294);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,10400,10480);

string 
defaultPSPath = f_1167_10423_10479(Utils.DefaultPowerShellShellID)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,10494,10698) || true) && (defaultPSPath != null &&(DynAbs.Tracing.TraceSender.Expression_True(1167, 10498, 10571)&&                !f_1167_10541_10571(result, defaultPSPath))&&(DynAbs.Tracing.TraceSender.Expression_True(1167, 10498, 10623)&&f_1167_10592_10623(defaultPSPath)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,10494,10698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,10657,10683);

f_1167_10657_10682(                result, defaultPSPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,10494,10698);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,10714,10728);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1167,9088,10739);

System.Collections.ObjectModel.Collection<string>
f_1167_9242_9266()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9242, 9266);
return return_v;
}


bool
f_1167_9398_9426(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9398, 9426);
return return_v;
}


string?
f_1167_9452_9481(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9452, 9481);
return return_v;
}


bool
f_1167_9431_9482(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9431, 9482);
return return_v;
}


string?
f_1167_9535_9564(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9535, 9564);
return return_v;
}


bool
f_1167_9589_9616(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9589, 9616);
return return_v;
}


string
f_1167_9669_9696(string
path)
{
var return_v = Path.GetFullPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9669, 9696);
return return_v;
}


int
f_1167_9658_9697(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 9658, 9697);
return 0;
}


bool
f_1167_10108_10134(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10108, 10134);
return return_v;
}


bool
f_1167_10138_10165(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10138, 10165);
return return_v;
}


int
f_1167_10215_10236(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10215, 10236);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1167_10050_10061_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10050, 10061);
return return_v;
}


string
f_1167_10423_10479(string
shellId)
{
var return_v = Utils.GetApplicationBase( shellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10423, 10479);
return return_v;
}


bool
f_1167_10541_10571(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10541, 10571);
return return_v;
}


bool
f_1167_10592_10623(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10592, 10623);
return return_v;
}


int
f_1167_10657_10682(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 10657, 10682);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,9088,10739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,9088,10739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Collection<string> SearchFiles(string pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1167,10984,11136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,11071,11125);

return f_1167_11078_11124(pattern, f_1167_11099_11123());
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1167,10984,11136);

System.Collections.ObjectModel.Collection<string>
f_1167_11099_11123()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 11099, 11123);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_11078_11124(string
pattern,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = SearchFiles( pattern, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 11078, 11124);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,10984,11136);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,10984,11136);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Collection<string> SearchFiles(string pattern, Collection<string> searchPaths)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1167,11377,11615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,11496,11565);

MUIFileSearcher 
searcher = f_1167_11523_11564(pattern, searchPaths)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,11581,11604);

return f_1167_11588_11603(searcher);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1167,11377,11615);

System.Management.Automation.MUIFileSearcher
f_1167_11523_11564(string
target,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = new System.Management.Automation.MUIFileSearcher( target, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 11523, 11564);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_11588_11603(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 11588, 11603);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,11377,11615);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,11377,11615);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string LocateFile(string file)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1167,11800,11932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,11871,11921);

return f_1167_11878_11920(file, f_1167_11895_11919());
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1167,11800,11932);

System.Collections.ObjectModel.Collection<string>
f_1167_11895_11919()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 11895, 11919);
return return_v;
}


string
f_1167_11878_11920(string
file,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = LocateFile( file, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 11878, 11920);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,11800,11932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,11800,11932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string LocateFile(string file, Collection<string> searchPaths)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1167,12479,12823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,12582,12666);

MUIFileSearcher 
searcher = f_1167_12609_12665(file, searchPaths, SearchMode.First)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,12682,12770) || true) && (f_1167_12686_12701(searcher)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1167, 12686, 12739)||f_1167_12713_12734(f_1167_12713_12728(searcher))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1167,12682,12770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,12758,12770);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1167,12682,12770);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1167,12786,12812);

return f_1167_12793_12811(f_1167_12793_12808(searcher), 0);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1167,12479,12823);

System.Management.Automation.MUIFileSearcher
f_1167_12609_12665(string
target,System.Collections.ObjectModel.Collection<string>
searchPaths,System.Management.Automation.SearchMode
searchMode)
{
var return_v = new System.Management.Automation.MUIFileSearcher( target, searchPaths, searchMode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 12609, 12665);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_12686_12701(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Result ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 12686, 12701);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_12713_12728(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 12713, 12728);
return return_v;
}


int
f_1167_12713_12734(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 12713, 12734);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1167_12793_12808(System.Management.Automation.MUIFileSearcher
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 12793, 12808);
return return_v;
}


string
f_1167_12793_12811(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 12793, 12811);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1167,12479,12823);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,12479,12823);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static MUIFileSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1167,336,12852);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1167,336,12852);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1167,336,12852);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1167,336,12852);

static string
f_1167_1269_1275_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1167, 1178, 1330);
return return_v;
}


System.StringComparer
f_1167_2906_2938()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1167, 2906, 2938);
return return_v;
}


System.Collections.Hashtable
f_1167_2892_2939(System.StringComparer
equalityComparer)
{
var return_v = new System.Collections.Hashtable( (System.Collections.IEqualityComparer)equalityComparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1167, 2892, 2939);
return return_v;
}

}

    /// <summary>
    /// This enum defines different search mode for the MUIFileSearcher.
    /// </summary>
    internal enum SearchMode
    {
        // return the first match
        First,

        // return all matches, with duplicates allowed
        All,

        // return all matches, with duplicates ignored
        Unique
    }
}

