// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsLifecycle.Start, "Transcript", SupportsShouldProcess = true, DefaultParameterSetName = "ByPath", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096485")]
    [OutputType(typeof(string))]
    public sealed class StartTranscriptCommand : PSCmdlet
{
[Parameter(Position = 0, ParameterSetName = "ByPath")]
        [ValidateNotNullOrEmpty]
        public string Path
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,1207,1278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,1243,1263);

return _outFilename;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,1207,1278);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,1066,1417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,1066,1417);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,1294,1406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,1330,1352);

_isFilenameSet = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,1370,1391);

_outFilename = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,1294,1406);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,1066,1417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,1066,1417);
}
		}}

[Parameter(Position = 0, ParameterSetName = "ByLiteralPath")]
        [Alias("PSPath", "LP")]
        [ValidateNotNullOrEmpty]
        public string LiteralPath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,1740,1811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,1776,1796);

return _outFilename;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,1740,1811);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,1552,1990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,1552,1990);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,1827,1979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,1863,1885);

_isFilenameSet = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,1903,1924);

_outFilename = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,1942,1964);

_isLiteralPath = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,1827,1979);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,1552,1990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,1552,1990);
}
		}}

private bool _isLiteralPath ;

[Parameter(Position = 0, ParameterSetName = "ByOutputDirectory")]
        [ValidateNotNullOrEmpty]
        public string OutputDirectory
{            get; set;
}

[Parameter]
        public SwitchParameter Append
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,2579,2651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,2615,2636);

return _shouldAppend;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,2579,2651);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,2504,2751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,2504,2751);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,2667,2740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,2703,2725);

_shouldAppend = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,2667,2740);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,2504,2751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,2504,2751);
}
		}}

[Parameter()]
        public SwitchParameter Force
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,3146,3211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,3182,3196);

return _force;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,3146,3211);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,3070,3304);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,3070,3304);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,3227,3293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,3263,3278);

_force = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,3227,3293);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,3070,3304);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,3070,3304);
}
		}}

private bool _force;

[Parameter()]
        [Alias("NoOverwrite")]
        public SwitchParameter NoClobber
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,3559,3628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,3595,3613);

return _noclobber;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,3559,3628);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,3447,3725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,3447,3725);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,3644,3714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,3680,3699);

_noclobber = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,3644,3714);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,3447,3725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,3447,3725);
}
		}}

private bool _noclobber;

[Parameter()]
        public SwitchParameter IncludeInvocationHeader
{            get; set;
}

[Parameter]
        public SwitchParameter UseMinimalHeader
{            get; set;
}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,4346,9800);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,4498,5583) || true) && (!_isFilenameSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,4498,5583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,4606,4670);

object 
value = f_127_4621_4669(this, "global:TRANSCRIPT", null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,4829,5568) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,4829,5568);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,4992,5438) || true) && (f_127_4996_5011()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,4992,5438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5069,5180);

_outFilename = f_127_5084_5179(f_127_5156_5171(), false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5206,5228);

_isLiteralPath = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(127,4992,5438);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,4992,5438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5326,5415);

_outFilename = f_127_5341_5414();
DynAbs.Tracing.TraceSender.TraceExitCondition(127,4992,5438);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(127,4829,5568);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,4829,5568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5520,5549);

_outFilename = (string)value;
DynAbs.Tracing.TraceSender.TraceExitCondition(127,4829,5568);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(127,4498,5583);
}

            // Normalize outFilename here in case it is a relative path
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5708,5773);

string 
effectiveFilePath = f_127_5735_5772(this, f_127_5751_5755(), _isLiteralPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5793,5860) || true) && (!f_127_5798_5830(this, effectiveFilePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,5793,5860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5853,5860);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(127,5793,5860);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5880,8147) || true) && (f_127_5884_5924(effectiveFilePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,5880,8147);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,5966,6628) || true) && (f_127_5970_5979()&&(DynAbs.Tracing.TraceSender.Expression_True(127, 5970, 5990)&&f_127_5983_5990_M(!Append)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,5966,6628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,6040,6214);

string 
message = f_127_6057_6213(f_127_6075_6122(), effectiveFilePath, "NoClobber")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,6265,6322);

Exception 
uae = f_127_6281_6321(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,6348,6487);

ErrorRecord 
errorRecord = f_127_6374_6486(uae, "NoClobber", ErrorCategory.ResourceExists, effectiveFilePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,6570,6605);

f_127_6570_6604(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(127,5966,6628);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,6652,6721);

System.IO.FileInfo 
fInfo = f_127_6679_6720(effectiveFilePath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,6743,7881) || true) && ((f_127_6748_6764(fInfo)& FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,6743,7881);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,6961,7858) || true) && (f_127_6965_6970())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,6961,7858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,7180,7227);

fInfo.Attributes &= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => ~(FileAttributes.ReadOnly),127,7180,7196);
DynAbs.Tracing.TraceSender.TraceExitCondition(127,6961,7858);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,6961,7858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,7341,7587);

string 
errorMessage = f_127_7363_7586(f_127_7411_7458(), f_127_7493_7533(), effectiveFilePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,7617,7680);

Exception 
innerException = f_127_7644_7679(errorMessage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,7710,7831);

f_127_7710_7830(this, f_127_7732_7829(innerException, "FileReadOnly", ErrorCategory.InvalidArgument, effectiveFilePath));
DynAbs.Tracing.TraceSender.TraceExitCondition(127,6961,7858);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(127,6743,7881);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,7976,8128) || true) && (!_shouldAppend)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,7976,8128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,8044,8105);

f_127_8044_8104(effectiveFilePath, string.Empty);
DynAbs.Tracing.TraceSender.TraceExitCondition(127,7976,8128);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(127,5880,8147);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,8167,8362);

System.Management.Automation.Remoting.PSSenderInfo 
psSenderInfo =
f_127_8254_8307(f_127_8254_8282(f_127_8254_8271(this)), "PSSenderInfo")as System.Management.Automation.Remoting.PSSenderInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,8380,8501);

f_127_8380_8500(f_127_8380_8387(f_127_8380_8384()), effectiveFilePath, psSenderInfo, f_127_8439_8462().ToBool(), f_127_8473_8489().IsPresent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,8805,8929);

PSObject 
outputObject = f_127_8829_8928(f_127_8864_8927(f_127_8882_8920(), f_127_8922_8926()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,8947,9009);

f_127_8947_9008(f_127_8947_8970(outputObject), f_127_8975_9007("Path", f_127_9002_9006()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,9027,9053);

f_127_9027_9052(this, outputObject);
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(127,9082,9789);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,9178,9205);

f_127_9178_9204(f_127_9178_9185(f_127_9178_9182()));
                }
                catch
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(127,9242,9285);
DynAbs.Tracing.TraceSender.TraceExitCatch(127,9242,9285);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,9305,9509);

string 
errorMessage = f_127_9327_9508(f_127_9363_9410(), f_127_9433_9475(), f_127_9498_9507(e))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,9527,9730);

ErrorRecord 
er = f_127_9544_9729(f_127_9582_9641(e, errorMessage), "CannotStartTranscription", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,9748,9774);

f_127_9748_9773(this, er);
DynAbs.Tracing.TraceSender.TraceExitCatch(127,9082,9789);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(127,4346,9800);

object
f_127_4621_4669(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,string
name,object
defaultValue)
{
var return_v = this_param.GetVariableValue( name, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 4621, 4669);
return return_v;
}


string
f_127_4996_5011()
{
var return_v = OutputDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 4996, 5011);
return return_v;
}


string
f_127_5156_5171()
{
var return_v = OutputDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5156, 5171);
return return_v;
}


string
f_127_5084_5179(string
baseDirectory,bool
includeDate)
{
var return_v = System.Management.Automation.Host.PSHostUserInterface.GetTranscriptPath( baseDirectory, includeDate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5084, 5179);
return return_v;
}


string
f_127_5341_5414()
{
var return_v = System.Management.Automation.Host.PSHostUserInterface.GetTranscriptPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5341, 5414);
return return_v;
}


string
f_127_5751_5755()
{
var return_v = Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5751, 5755);
return return_v;
}


string
f_127_5735_5772(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,string
filePath,bool
isLiteralPath)
{
var return_v = this_param.ResolveFilePath( filePath, isLiteralPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5735, 5772);
return return_v;
}


bool
f_127_5798_5830(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,string
target)
{
var return_v = this_param.ShouldProcess( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5798, 5830);
return return_v;
}


bool
f_127_5884_5924(string
path)
{
var return_v = System.IO.File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5884, 5924);
return return_v;
}


System.Management.Automation.SwitchParameter
f_127_5970_5979()
{
var return_v = NoClobber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5970, 5979);
return return_v;
}


bool
f_127_5983_5990_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5983, 5990);
return return_v;
}


string
f_127_6075_6122()
{
var return_v = TranscriptStrings.TranscriptFileExistsNoClobber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 6075, 6122);
return return_v;
}


string
f_127_6057_6213(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6057, 6213);
return return_v;
}


System.UnauthorizedAccessException
f_127_6281_6321(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6281, 6321);
return return_v;
}


System.Management.Automation.ErrorRecord
f_127_6374_6486(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6374, 6486);
return return_v;
}


int
f_127_6570_6604(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6570, 6604);
return 0;
}


System.IO.FileInfo
f_127_6679_6720(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6679, 6720);
return return_v;
}


System.IO.FileAttributes
f_127_6748_6764(System.IO.FileInfo
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 6748, 6764);
return return_v;
}


System.Management.Automation.SwitchParameter
f_127_6965_6970()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 6965, 6970);
return return_v;
}


System.Globalization.CultureInfo
f_127_7411_7458()
{
var return_v =                                 System.Globalization.CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7411, 7458);
return return_v;
}


string
f_127_7493_7533()
{
var return_v =                                 TranscriptStrings.TranscriptFileReadOnly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7493, 7533);
return return_v;
}


string
f_127_7363_7586(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7363, 7586);
return return_v;
}


System.ArgumentException
f_127_7644_7679(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7644, 7679);
return return_v;
}


System.Management.Automation.ErrorRecord
f_127_7732_7829(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7732, 7829);
return return_v;
}


int
f_127_7710_7830(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7710, 7830);
return 0;
}


int
f_127_8044_8104(string
path,string
contents)
{
System.IO.File.WriteAllText( path, contents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8044, 8104);
return 0;
}


System.Management.Automation.SessionState
f_127_8254_8271(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8254, 8271);
return return_v;
}


System.Management.Automation.PSVariableIntrinsics
f_127_8254_8282(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.PSVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8254, 8282);
return return_v;
}


object
f_127_8254_8307(System.Management.Automation.PSVariableIntrinsics
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8254, 8307);
return return_v;
}


System.Management.Automation.Host.PSHost
f_127_8380_8384()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8380, 8384);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_127_8380_8387(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8380, 8387);
return return_v;
}


System.Management.Automation.SwitchParameter
f_127_8439_8462()
{
var return_v = IncludeInvocationHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8439, 8462);
return return_v;
}


System.Management.Automation.SwitchParameter
f_127_8473_8489()
{
var return_v = UseMinimalHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8473, 8489);
return return_v;
}


int
f_127_8380_8500(System.Management.Automation.Host.PSHostUserInterface
this_param,string
path,System.Management.Automation.Remoting.PSSenderInfo
senderInfo,bool
includeInvocationHeader,bool
useMinimalHeader)
{
this_param.StartTranscribing( path, senderInfo, includeInvocationHeader, useMinimalHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8380, 8500);
return 0;
}


string
f_127_8882_8920()
{
var return_v = TranscriptStrings.TranscriptionStarted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8882, 8920);
return return_v;
}


string
f_127_8922_8926()
{
var return_v = Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8922, 8926);
return return_v;
}


string
f_127_8864_8927(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8864, 8927);
return return_v;
}


System.Management.Automation.PSObject
f_127_8829_8928(string
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8829, 8928);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_127_8947_8970(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8947, 8970);
return return_v;
}


string
f_127_9002_9006()
{
var return_v = Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9002, 9006);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_127_8975_9007(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8975, 9007);
return return_v;
}


int
f_127_8947_9008(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8947, 9008);
return 0;
}


int
f_127_9027_9052(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,System.Management.Automation.PSObject
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9027, 9052);
return 0;
}


System.Management.Automation.Host.PSHost
f_127_9178_9182()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9178, 9182);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_127_9178_9185(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9178, 9185);
return return_v;
}


string
f_127_9178_9204(System.Management.Automation.Host.PSHostUserInterface
this_param)
{
var return_v = this_param.StopTranscribing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9178, 9204);
return return_v;
}


System.Globalization.CultureInfo
f_127_9363_9410()
{
var return_v =                     System.Globalization.CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9363, 9410);
return return_v;
}


string
f_127_9433_9475()
{
var return_v =                     TranscriptStrings.CannotStartTranscription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9433, 9475);
return return_v;
}


string
f_127_9498_9507(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9498, 9507);
return return_v;
}


string
f_127_9327_9508(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9327, 9508);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_127_9582_9641(System.Exception
innerException,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( innerException, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9582, 9641);
return return_v;
}


System.Management.Automation.ErrorRecord
f_127_9544_9729(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9544, 9729);
return return_v;
}


int
f_127_9748_9773(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9748, 9773);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,4346,9800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,4346,9800);
}
		}

private string ResolveFilePath(string filePath, bool isLiteralPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,9975,11811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10067,10086);

string 
path = null
;

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10138,10953) || true) && (isLiteralPath)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,10138,10953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10197,10268);

path = f_127_10204_10267(f_127_10204_10221(f_127_10204_10216()), filePath);
DynAbs.Tracing.TraceSender.TraceExitCondition(127,10138,10953);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,10138,10953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10350,10379);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10401,10533);

Collection<string> 
filePaths =
f_127_10457_10532(f_127_10457_10474(f_127_10457_10469()), filePath, out provider)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10557,10736) || true) && (!f_127_10562_10620(provider, f_127_10582_10619(f_127_10582_10608(f_127_10582_10594(this)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,10557,10736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10670,10713);

f_127_10670_10712(this, f_127_10694_10711(provider));
DynAbs.Tracing.TraceSender.TraceExitCondition(127,10557,10736);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10760,10890) || true) && (f_127_10764_10779(filePaths)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,10760,10890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10833,10867);

f_127_10833_10866(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(127,10760,10890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,10914,10934);

path = f_127_10921_10933(filePaths, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(127,10138,10953);
}
            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(127,10982,11071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11044,11056);

path = null;
DynAbs.Tracing.TraceSender.TraceExitCatch(127,10982,11071);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11087,11772) || true) && (f_127_11091_11117(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,11087,11772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11151,11229);

CmdletProviderContext 
cmdletProviderContext = f_127_11197_11228(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11247,11276);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11294,11319);

PSDriveInfo 
drive = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11337,11503);

path =
f_127_11365_11502(f_127_11365_11382(f_127_11365_11377()), filePath, cmdletProviderContext, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11521,11572);

f_127_11521_11571(                cmdletProviderContext);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11590,11757) || true) && (!f_127_11595_11653(provider, f_127_11615_11652(f_127_11615_11641(f_127_11615_11627(this)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(127,11590,11757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11695,11738);

f_127_11695_11737(this, f_127_11719_11736(provider));
DynAbs.Tracing.TraceSender.TraceExitCondition(127,11590,11757);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(127,11087,11772);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11788,11800);

return path;
DynAbs.Tracing.TraceSender.TraceExitMethod(127,9975,11811);

System.Management.Automation.SessionState
f_127_10204_10216()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10204, 10216);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_127_10204_10221(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10204, 10221);
return return_v;
}


string
f_127_10204_10267(System.Management.Automation.PathIntrinsics
this_param,string
path)
{
var return_v = this_param.GetUnresolvedProviderPathFromPSPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 10204, 10267);
return return_v;
}


System.Management.Automation.SessionState
f_127_10457_10469()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10457, 10469);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_127_10457_10474(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10457, 10474);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_127_10457_10532(System.Management.Automation.PathIntrinsics
this_param,string
path,out System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetResolvedProviderPathFromPSPath( path, out provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 10457, 10532);
return return_v;
}


System.Management.Automation.ExecutionContext
f_127_10582_10594(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10582, 10594);
return return_v;
}


System.Management.Automation.ProviderNames
f_127_10582_10608(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10582, 10608);
return return_v;
}


string
f_127_10582_10619(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10582, 10619);
return return_v;
}


bool
f_127_10562_10620(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 10562, 10620);
return return_v;
}


string
f_127_10694_10711(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10694, 10711);
return return_v;
}


int
f_127_10670_10712(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,string
providerId)
{
this_param.ReportWrongProviderType( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 10670, 10712);
return 0;
}


int
f_127_10764_10779(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10764, 10779);
return return_v;
}


int
f_127_10833_10866(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param)
{
this_param.ReportMultipleFilesNotSupported();
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 10833, 10866);
return 0;
}


string
f_127_10921_10933(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 10921, 10933);
return return_v;
}


bool
f_127_11091_11117(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11091, 11117);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_127_11197_11228(Microsoft.PowerShell.Commands.StartTranscriptCommand
command)
{
var return_v = new System.Management.Automation.CmdletProviderContext( (System.Management.Automation.Cmdlet)command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11197, 11228);
return return_v;
}


System.Management.Automation.SessionState
f_127_11365_11377()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11365, 11377);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_127_11365_11382(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11365, 11382);
return return_v;
}


string
f_127_11365_11502(System.Management.Automation.PathIntrinsics
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetUnresolvedProviderPathFromPSPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11365, 11502);
return return_v;
}


int
f_127_11521_11571(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11521, 11571);
return 0;
}


System.Management.Automation.ExecutionContext
f_127_11615_11627(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11615, 11627);
return return_v;
}


System.Management.Automation.ProviderNames
f_127_11615_11641(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11615, 11641);
return return_v;
}


string
f_127_11615_11652(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11615, 11652);
return return_v;
}


bool
f_127_11595_11653(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11595, 11653);
return return_v;
}


string
f_127_11719_11736(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11719, 11736);
return return_v;
}


int
f_127_11695_11737(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,string
providerId)
{
this_param.ReportWrongProviderType( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11695, 11737);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,9975,11811);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,9975,11811);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ReportWrongProviderType(string providerId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,11823,12259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,11903,12199);

ErrorRecord 
errorRecord = f_127_11929_12198(f_127_11963_12071(f_127_12006_12058(), providerId), "ReadWriteFileNotFileSystemProvider", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,12213,12248);

f_127_12213_12247(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(127,11823,12259);

string
f_127_12006_12058()
{
var return_v = TranscriptStrings.ReadWriteFileNotFileSystemProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 12006, 12058);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_127_11963_12071(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11963, 12071);
return return_v;
}


System.Management.Automation.ErrorRecord
f_127_11929_12198(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11929, 12198);
return return_v;
}


int
f_127_12213_12247(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12213, 12247);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,11823,12259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,11823,12259);
}
		}

private void ReportMultipleFilesNotSupported()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(127,12271,12668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,12342,12608);

ErrorRecord 
errorRecord = f_127_12368_12607(f_127_12402_12489(f_127_12445_12488()), "MultipleFilesNotSupported", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,12622,12657);

f_127_12622_12656(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(127,12271,12668);

string
f_127_12445_12488()
{
var return_v = TranscriptStrings.MultipleFilesNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 12445, 12488);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_127_12402_12489(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12402, 12489);
return return_v;
}


System.Management.Automation.ErrorRecord
f_127_12368_12607(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12368, 12607);
return return_v;
}


int
f_127_12622_12656(Microsoft.PowerShell.Commands.StartTranscriptCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12622, 12656);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127,12271,12668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,12271,12668);
}
		}

private bool _shouldAppend;

private string _outFilename;

private bool _isFilenameSet;

public StartTranscriptCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(127,395,12790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,2015,2037);
this._isLiteralPath = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,2173,2356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,3329,3335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,3750,3760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,12693,12706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,12732,12744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(127,12768,12782);
DynAbs.Tracing.TraceSender.TraceExitConstructor(127,395,12790);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,395,12790);
}


static StartTranscriptCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(127,395,12790);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(127,395,12790);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127,395,12790);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(127,395,12790);
}
}

