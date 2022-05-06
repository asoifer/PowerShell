// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Reflection;
using System.Text;

namespace System.Management.Automation.Runspaces
{
internal class PSSnapInTypeAndFormatErrors
{
public string psSnapinName;

internal PSSnapInTypeAndFormatErrors(string psSnapinName, string fullPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1011,679,907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,496,508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1734,1785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1797,1832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1844,1875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1887,1920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1932,1973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1985,2036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2135,2149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,778,811);

this.psSnapinName = psSnapinName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,825,845);

FullPath = fullPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,859,896);

Errors = f_1011_868_895();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1011,679,907);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,679,907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,679,907);
}
		}

internal PSSnapInTypeAndFormatErrors(string psSnapinName, FormatTable formatTable)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1011,919,1161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,496,508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1734,1785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1797,1832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1844,1875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1887,1920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1932,1973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1985,2036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2135,2149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1026,1059);

this.psSnapinName = psSnapinName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1073,1099);

FormatTable = formatTable;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1113,1150);

Errors = f_1011_1122_1149();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1011,919,1161);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,919,1161);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,919,1161);
}
		}

internal PSSnapInTypeAndFormatErrors(string psSnapinName, TypeData typeData, bool isRemove)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1011,1173,1452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,496,508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1734,1785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1797,1832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1844,1875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1887,1920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1932,1973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1985,2036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2135,2149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1289,1322);

this.psSnapinName = psSnapinName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1336,1356);

TypeData = typeData;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1370,1390);

IsRemove = isRemove;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1404,1441);

Errors = f_1011_1413_1440();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1011,1173,1452);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,1173,1452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,1173,1452);
}
		}

internal PSSnapInTypeAndFormatErrors(string psSnapinName, ExtendedTypeDefinition typeDefinition)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1011,1464,1722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,496,508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1734,1785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1797,1832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1844,1875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1887,1920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1932,1973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1985,2036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2135,2149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1585,1618);

this.psSnapinName = psSnapinName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1632,1660);

FormatData = typeDefinition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,1674,1711);

Errors = f_1011_1683_1710();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1011,1464,1722);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,1464,1722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,1464,1722);
}
		}

internal ExtendedTypeDefinition FormatData {get; }

internal TypeData TypeData {get; }

internal bool IsRemove {get; }

internal string FullPath {get; }

internal FormatTable FormatTable {get; }

internal ConcurrentBag<string> Errors {get; set; }

internal string PSSnapinName {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1011,2079,2107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2085,2105);

return psSnapinName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1011,2079,2107);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,2048,2109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,2048,2109);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool FailToLoadFile;

static PSSnapInTypeAndFormatErrors()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1011,423,2157);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1011,423,2157);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,423,2157);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1011,423,2157);

System.Collections.Concurrent.ConcurrentBag<string>
f_1011_868_895()
{
var return_v = new System.Collections.Concurrent.ConcurrentBag<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 868, 895);
return return_v;
}


System.Collections.Concurrent.ConcurrentBag<string>
f_1011_1122_1149()
{
var return_v = new System.Collections.Concurrent.ConcurrentBag<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 1122, 1149);
return return_v;
}


System.Collections.Concurrent.ConcurrentBag<string>
f_1011_1413_1440()
{
var return_v = new System.Collections.Concurrent.ConcurrentBag<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 1413, 1440);
return return_v;
}


System.Collections.Concurrent.ConcurrentBag<string>
f_1011_1683_1710()
{
var return_v = new System.Collections.Concurrent.ConcurrentBag<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 1683, 1710);
return return_v;
}

}
internal static class FormatAndTypeDataHelper
{
private const string 
FileNotFound = "FileNotFound"
;

private const string 
CannotFindRegistryKey = "CannotFindRegistryKey"
;

private const string 
CannotFindRegistryKeyPath = "CannotFindRegistryKeyPath"
;

private const string 
EntryShouldBeMshXml = "EntryShouldBeMshXml"
;

private const string 
DuplicateFile = "DuplicateFile"
;

internal const string 
ValidationException = "ValidationException"
;

private static string GetBaseFolder(Collection<string> independentErrors)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1011,2670,2888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2768,2877);

return f_1011_2775_2876(f_1011_2797_2875(f_1011_2797_2866(f_1011_2819_2865())));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1011,2670,2888);

System.Diagnostics.Process
f_1011_2819_2865()
{
var return_v = System.Diagnostics.Process.GetCurrentProcess();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 2819, 2865);
return return_v;
}


System.Diagnostics.ProcessModule
f_1011_2797_2866(System.Diagnostics.Process
targetProcess)
{
var return_v = PsUtils.GetMainModule( targetProcess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 2797, 2866);
return return_v;
}


string
f_1011_2797_2875(System.Diagnostics.ProcessModule
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 2797, 2875);
return return_v;
}


string?
f_1011_2775_2876(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 2775, 2876);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,2670,2888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,2670,2888);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetAndCheckFullFileName(
            string psSnapinName,
            HashSet<string> fullFileNameSet,
            string baseFolder,
            string baseFileName,
            Collection<string> independentErrors,
            ref bool needToRemoveEntry,
            bool checkFileExists)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1011,2900,4349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3244,3350);

string 
retValue = (DynAbs.Tracing.TraceSender.Conditional_F1(1011, 3262, 3293)||((f_1011_3262_3293(baseFileName)&&DynAbs.Tracing.TraceSender.Conditional_F2(1011, 3296, 3308))||DynAbs.Tracing.TraceSender.Conditional_F3(1011, 3311, 3349)))?baseFileName :f_1011_3311_3349(baseFolder, baseFileName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3366,3624) || true) && (checkFileExists &&(DynAbs.Tracing.TraceSender.Expression_True(1011, 3370, 3411)&&!f_1011_3390_3411(retValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,3366,3624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3445,3532);

string 
error = f_1011_3460_3531(f_1011_3478_3506(), psSnapinName, retValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3550,3579);

f_1011_3550_3578(                independentErrors, error);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3597,3609);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,3366,3624);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3640,3957) || true) && (f_1011_3644_3678(fullFileNameSet, retValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,3640,3957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3887,3912);

needToRemoveEntry = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3930,3942);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,3640,3957);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,3973,4262) || true) && (!f_1011_3978_4042(retValue, ".ps1xml", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,3973,4262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4076,4170);

string 
error = f_1011_4091_4169(f_1011_4109_4144(), psSnapinName, retValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4188,4217);

f_1011_4188_4216(                independentErrors, error);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4235,4247);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,3973,4262);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4278,4308);

f_1011_4278_4307(
            fullFileNameSet, retValue);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4322,4338);

return retValue;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1011,2900,4349);

bool
f_1011_3262_3293(string
path)
{
var return_v = Path.IsPathRooted( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 3262, 3293);
return return_v;
}


string
f_1011_3311_3349(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 3311, 3349);
return return_v;
}


bool
f_1011_3390_3411(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 3390, 3411);
return return_v;
}


string
f_1011_3478_3506()
{
var return_v = TypesXmlStrings.FileNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 3478, 3506);
return return_v;
}


string
f_1011_3460_3531(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 3460, 3531);
return return_v;
}


int
f_1011_3550_3578(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 3550, 3578);
return 0;
}


bool
f_1011_3644_3678(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 3644, 3678);
return return_v;
}


bool
f_1011_3978_4042(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 3978, 4042);
return return_v;
}


string
f_1011_4109_4144()
{
var return_v = TypesXmlStrings.EntryShouldBeMshXml;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 4109, 4144);
return return_v;
}


string
f_1011_4091_4169(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 4091, 4169);
return return_v;
}


int
f_1011_4188_4216(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 4188, 4216);
return 0;
}


bool
f_1011_4278_4307(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 4278, 4307);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,2900,4349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,2900,4349);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void ThrowExceptionOnError(
            string errorId,
            Collection<string> independentErrors,
            Collection<PSSnapInTypeAndFormatErrors> PSSnapinFilesCollection,
            Category category)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1011,4361,6088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4619,4672);

Collection<string> 
errors = f_1011_4647_4671()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4686,4885) || true) && (independentErrors != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,4686,4885);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4749,4870);
foreach(string error in f_1011_4774_4791_I(independentErrors) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,4749,4870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4833,4851);

f_1011_4833_4850(                    errors, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,4749,4870);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1011,1,122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1011,1,122);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1011,4686,4885);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,4901,5151);
foreach(PSSnapInTypeAndFormatErrors PSSnapinFiles in f_1011_4955_4978_I(PSSnapinFilesCollection) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,4901,5151);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5012,5136);
foreach(string error in f_1011_5037_5057_I(f_1011_5037_5057(PSSnapinFiles)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,5012,5136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5099,5117);

f_1011_5099_5116(                    errors, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,5012,5136);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1011,1,125);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1011,1,125);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1011,4901,5151);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1011,1,251);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1011,1,251);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5167,5244) || true) && (f_1011_5171_5183(errors)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,5167,5244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5222,5229);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,5167,5244);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5260,5306);

StringBuilder 
allErrors = f_1011_5286_5305()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5322,5345);

f_1011_5322_5344(
            allErrors, '\n');
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5359,5504);
foreach(string error in f_1011_5384_5390_I(errors) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,5359,5504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5424,5448);

f_1011_5424_5447(                allErrors, error);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5466,5489);

f_1011_5466_5488(                allErrors, '\n');
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,5359,5504);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1011,1,146);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1011,1,146);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5520,5550);

string 
message = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5564,5949) || true) && (category == Category.Types)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,5564,5949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5628,5733);

message =
f_1011_5659_5732(f_1011_5677_5709(), f_1011_5711_5731(allErrors));
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,5564,5949);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,5564,5949);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5767,5949) || true) && (category == Category.Formats)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,5767,5949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5833,5934);

message = f_1011_5843_5933(f_1011_5861_5910(), f_1011_5912_5932(allErrors));
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,5767,5949);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,5564,5949);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,5965,6017);

RuntimeException 
ex = f_1011_5987_6016(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6031,6054);

f_1011_6031_6053(            ex, errorId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6068,6077);

throw ex;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1011,4361,6088);

System.Collections.ObjectModel.Collection<string>
f_1011_4647_4671()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 4647, 4671);
return return_v;
}


int
f_1011_4833_4850(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 4833, 4850);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1011_4774_4791_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 4774, 4791);
return return_v;
}


System.Collections.Concurrent.ConcurrentBag<string>
f_1011_5037_5057(System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 5037, 5057);
return return_v;
}


int
f_1011_5099_5116(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5099, 5116);
return 0;
}


System.Collections.Concurrent.ConcurrentBag<string>
f_1011_5037_5057_I(System.Collections.Concurrent.ConcurrentBag<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5037, 5057);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
f_1011_4955_4978_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInTypeAndFormatErrors>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 4955, 4978);
return return_v;
}


int
f_1011_5171_5183(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 5171, 5183);
return return_v;
}


System.Text.StringBuilder
f_1011_5286_5305()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5286, 5305);
return return_v;
}


System.Text.StringBuilder
f_1011_5322_5344(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5322, 5344);
return return_v;
}


System.Text.StringBuilder
f_1011_5424_5447(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5424, 5447);
return return_v;
}


System.Text.StringBuilder
f_1011_5466_5488(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5466, 5488);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1011_5384_5390_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5384, 5390);
return return_v;
}


string
f_1011_5677_5709()
{
var return_v = ExtendedTypeSystem.TypesXmlError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 5677, 5709);
return return_v;
}


string
f_1011_5711_5731(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5711, 5731);
return return_v;
}


string
f_1011_5659_5732(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5659, 5732);
return return_v;
}


string
f_1011_5861_5910()
{
var return_v = FormatAndOutXmlLoadingStrings.FormatLoadingErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 5861, 5910);
return return_v;
}


string
f_1011_5912_5932(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5912, 5932);
return return_v;
}


string
f_1011_5843_5933(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5843, 5933);
return return_v;
}


System.Management.Automation.RuntimeException
f_1011_5987_6016(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 5987, 6016);
return return_v;
}


int
f_1011_6031_6053(System.Management.Automation.RuntimeException
this_param,string
errorId)
{
this_param.SetErrorId( errorId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6031, 6053);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,4361,6088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,4361,6088);
}
		}

internal static void ThrowExceptionOnError(
            string errorId,
            ConcurrentBag<string> errors,
            Category category)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1011,6100,7193);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6272,6349) || true) && (f_1011_6276_6288(errors)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,6272,6349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6327,6334);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,6272,6349);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6365,6411);

StringBuilder 
allErrors = f_1011_6391_6410()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6427,6450);

f_1011_6427_6449(
            allErrors, '\n');
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6464,6609);
foreach(string error in f_1011_6489_6495_I(errors) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,6464,6609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6529,6553);

f_1011_6529_6552(                allErrors, error);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6571,6594);

f_1011_6571_6593(                allErrors, '\n');
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,6464,6609);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1011,1,146);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1011,1,146);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6625,6655);

string 
message = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6669,7054) || true) && (category == Category.Types)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,6669,7054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6733,6838);

message =
f_1011_6764_6837(f_1011_6782_6814(), f_1011_6816_6836(allErrors));
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,6669,7054);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,6669,7054);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6872,7054) || true) && (category == Category.Formats)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1011,6872,7054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,6938,7039);

message = f_1011_6948_7038(f_1011_6966_7015(), f_1011_7017_7037(allErrors));
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,6872,7054);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1011,6669,7054);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,7070,7122);

RuntimeException 
ex = f_1011_7092_7121(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,7136,7159);

f_1011_7136_7158(            ex, errorId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,7173,7182);

throw ex;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1011,6100,7193);

int
f_1011_6276_6288(System.Collections.Concurrent.ConcurrentBag<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 6276, 6288);
return return_v;
}


System.Text.StringBuilder
f_1011_6391_6410()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6391, 6410);
return return_v;
}


System.Text.StringBuilder
f_1011_6427_6449(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6427, 6449);
return return_v;
}


System.Text.StringBuilder
f_1011_6529_6552(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6529, 6552);
return return_v;
}


System.Text.StringBuilder
f_1011_6571_6593(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6571, 6593);
return return_v;
}


System.Collections.Concurrent.ConcurrentBag<string>
f_1011_6489_6495_I(System.Collections.Concurrent.ConcurrentBag<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6489, 6495);
return return_v;
}


string
f_1011_6782_6814()
{
var return_v = ExtendedTypeSystem.TypesXmlError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 6782, 6814);
return return_v;
}


string
f_1011_6816_6836(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6816, 6836);
return return_v;
}


string
f_1011_6764_6837(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6764, 6837);
return return_v;
}


string
f_1011_6966_7015()
{
var return_v = FormatAndOutXmlLoadingStrings.FormatLoadingErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1011, 6966, 7015);
return return_v;
}


string
f_1011_7017_7037(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 7017, 7037);
return return_v;
}


string
f_1011_6948_7038(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 6948, 7038);
return return_v;
}


System.Management.Automation.RuntimeException
f_1011_7092_7121(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 7092, 7121);
return return_v;
}


int
f_1011_7136_7158(System.Management.Automation.RuntimeException
this_param,string
errorId)
{
this_param.SetErrorId( errorId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1011, 7136, 7158);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1011,6100,7193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,6100,7193);
}
		}

        internal enum Category
        {
            Types,
            Formats,
        }

static FormatAndTypeDataHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1011,2165,7298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2248,2277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2309,2356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2388,2443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2475,2518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2550,2581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1011,2614,2657);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1011,2165,7298);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1011,2165,7298);
}

}
}

