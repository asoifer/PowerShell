// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsDiagnostic.Test, "PSSessionConfigurationFile", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096797")]
    [OutputType(typeof(bool))]
    public class TestPSSessionConfigurationFileCommand : PSCmdlet
{
[Parameter(Mandatory = true, ValueFromPipeline = true, Position = 0, ValueFromPipelineByPropertyName = true)]
        public string Path
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1614,1076,1097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1082,1095);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1614,1076,1097);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1614,914,1146);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1614,914,1146);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1614,1113,1135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1119,1133);

_path = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1614,1113,1135);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1614,914,1146);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1614,914,1146);
}
		}}

private string _path;

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1614,1289,5521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1353,1382);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1396,1425);

Collection<string> 
filePaths
=default(Collection<string>);

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1477,1871) || true) && (f_1614_1481_1563(f_1614_1481_1512(f_1614_1481_1493(this)), f_1614_1530_1562(f_1614_1530_1551(f_1614_1530_1537()))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,1477,1871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1605,1690);

filePaths = f_1614_1617_1689(f_1614_1617_1634(f_1614_1617_1629()), _path, out provider);
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,1477,1871);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,1477,1871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1772,1809);

filePaths = f_1614_1784_1808();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1831,1852);

f_1614_1831_1851(                    filePaths, _path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,1477,1871);
}
            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1614,1900,2374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1962,2063);

string 
message = f_1614_1979_2062(f_1614_1997_2054(), _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2081,2144);

FileNotFoundException 
fnf = f_1614_2109_2143(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2162,2301);

ErrorRecord 
er = f_1614_2179_2300(fnf, "PSSessionConfigurationFileNotFound", ErrorCategory.ResourceUnavailable, _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2319,2334);

f_1614_2319_2333(this, er);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2352,2359);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1614,1900,2374);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2492,2844) || true) && (!f_1614_2497_2555(provider, f_1614_2517_2554(f_1614_2517_2543(f_1614_2517_2529(this)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,2492,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2657,2829);

throw f_1614_2663_2828(_path, typeof(RuntimeException), null, "FileOpenError", f_1614_2781_2808(), f_1614_2810_2827(provider));
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,2492,2844);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2917,3407) || true) && (filePaths == null ||(DynAbs.Tracing.TraceSender.Expression_False(1614, 2921, 2961)||f_1614_2942_2957(filePaths)< 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,2917,3407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,2995,3096);

string 
message = f_1614_3012_3095(f_1614_3030_3087(), _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3114,3177);

FileNotFoundException 
fnf = f_1614_3142_3176(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3195,3334);

ErrorRecord 
er = f_1614_3212_3333(fnf, "PSSessionConfigurationFileNotFound", ErrorCategory.ResourceUnavailable, _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3352,3367);

f_1614_3352_3366(this, er);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3385,3392);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,2917,3407);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3423,3752) || true) && (f_1614_3427_3442(filePaths)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,3423,3752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3580,3737);

throw f_1614_3586_3736(filePaths, typeof(RuntimeException), null, "AmbiguousPath", f_1614_3708_3735());
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,3423,3752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3768,3799);

string 
filePath = f_1614_3786_3798(filePaths, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3813,3850);

ExternalScriptInfo 
scriptInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3864,3915);

string 
ext = f_1614_3877_3914(filePath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,3929,5510) || true) && (f_1614_3933_4023(ext, StringLiterals.PowerShellDISCFileExtension, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,3929,5510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4122,4140);

string 
scriptName
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4158,4242);

scriptInfo = f_1614_4171_4241(f_1614_4202_4214(this), filePath, out scriptName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4262,4291);

Hashtable 
configTable = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4355,4420);

configTable = f_1614_4369_4419(f_1614_4394_4406(this), scriptInfo);
                }
                catch (RuntimeException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1614,4457,4717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4524,4628);

f_1614_4524_4627(this, f_1614_4537_4626(f_1614_4555_4604(), filePath, f_1614_4616_4625(e)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4650,4669);

f_1614_4650_4668(this, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4691,4698);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1614,4457,4717);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4737,4869) || true) && (configTable == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,4737,4869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4802,4821);

f_1614_4802_4820(this, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4843,4850);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,4737,4869);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4889,4945);

DISCUtils.ExecutionPolicyType = typeof(ExecutionPolicy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,4963,5033);

f_1614_4963_5032(this, f_1614_4975_5031(configTable, this, filePath));
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,3929,5510);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1614,3929,5510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,5099,5206);

string 
message = f_1614_5116_5205(f_1614_5134_5194(), filePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,5224,5295);

InvalidOperationException 
ioe = f_1614_5256_5294(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,5313,5451);

ErrorRecord 
er = f_1614_5330_5450(ioe, "InvalidPSSessionConfigurationFilePath", ErrorCategory.InvalidArgument, _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,5469,5495);

f_1614_5469_5494(this, er);
DynAbs.Tracing.TraceSender.TraceExitCondition(1614,3929,5510);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1614,1289,5521);

System.Management.Automation.ExecutionContext
f_1614_1481_1493(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1481, 1493);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1614_1481_1512(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1481, 1512);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1614_1530_1537()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1530, 1537);
return return_v;
}


System.Management.Automation.ProviderNames
f_1614_1530_1551(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1530, 1551);
return return_v;
}


string
f_1614_1530_1562(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1530, 1562);
return return_v;
}


bool
f_1614_1481_1563(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.IsProviderLoaded( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 1481, 1563);
return return_v;
}


System.Management.Automation.SessionState
f_1614_1617_1629()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1617, 1629);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1614_1617_1634(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1617, 1634);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1614_1617_1689(System.Management.Automation.PathIntrinsics
this_param,string
path,out System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetResolvedProviderPathFromPSPath( path, out provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 1617, 1689);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1614_1784_1808()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 1784, 1808);
return return_v;
}


int
f_1614_1831_1851(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 1831, 1851);
return 0;
}


string
f_1614_1997_2054()
{
var return_v = RemotingErrorIdStrings.PSSessionConfigurationFileNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 1997, 2054);
return return_v;
}


string
f_1614_1979_2062(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 1979, 2062);
return return_v;
}


System.IO.FileNotFoundException
f_1614_2109_2143(string
message)
{
var return_v = new System.IO.FileNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 2109, 2143);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1614_2179_2300(System.IO.FileNotFoundException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 2179, 2300);
return return_v;
}


int
f_1614_2319_2333(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 2319, 2333);
return 0;
}


System.Management.Automation.ExecutionContext
f_1614_2517_2529(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 2517, 2529);
return return_v;
}


System.Management.Automation.ProviderNames
f_1614_2517_2543(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 2517, 2543);
return return_v;
}


string
f_1614_2517_2554(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 2517, 2554);
return return_v;
}


bool
f_1614_2497_2555(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 2497, 2555);
return return_v;
}


string
f_1614_2781_2808()
{
var return_v = ParserStrings.FileOpenError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 2781, 2808);
return return_v;
}


string
f_1614_2810_2827(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 2810, 2827);
return return_v;
}


System.Management.Automation.RuntimeException
f_1614_2663_2828(string
targetObject,System.Type
exceptionType,System.Management.Automation.Language.IScriptExtent
errorPosition,string
resourceIdAndErrorId,string
resourceString,params object[]
args)
{
var return_v = InterpreterError.NewInterpreterException( (object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 2663, 2828);
return return_v;
}


int
f_1614_2942_2957(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 2942, 2957);
return return_v;
}


string
f_1614_3030_3087()
{
var return_v = RemotingErrorIdStrings.PSSessionConfigurationFileNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 3030, 3087);
return return_v;
}


string
f_1614_3012_3095(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 3012, 3095);
return return_v;
}


System.IO.FileNotFoundException
f_1614_3142_3176(string
message)
{
var return_v = new System.IO.FileNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 3142, 3176);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1614_3212_3333(System.IO.FileNotFoundException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 3212, 3333);
return return_v;
}


int
f_1614_3352_3366(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 3352, 3366);
return 0;
}


int
f_1614_3427_3442(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 3427, 3442);
return return_v;
}


string
f_1614_3708_3735()
{
var return_v = ParserStrings.AmbiguousPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 3708, 3735);
return return_v;
}


System.Management.Automation.RuntimeException
f_1614_3586_3736(System.Collections.ObjectModel.Collection<string>
targetObject,System.Type
exceptionType,System.Management.Automation.Language.IScriptExtent
errorPosition,string
resourceIdAndErrorId,string
resourceString,params object[]
args)
{
var return_v = InterpreterError.NewInterpreterException( (object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 3586, 3736);
return return_v;
}


string
f_1614_3786_3798(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 3786, 3798);
return return_v;
}


string?
f_1614_3877_3914(string
path)
{
var return_v = System.IO.Path.GetExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 3877, 3914);
return return_v;
}


bool
f_1614_3933_4023(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 3933, 4023);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1614_4202_4214(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 4202, 4214);
return return_v;
}


System.Management.Automation.ExternalScriptInfo
f_1614_4171_4241(System.Management.Automation.ExecutionContext
context,string
fileName,out string
scriptName)
{
var return_v = DISCUtils.GetScriptInfoForFile( context, fileName, out scriptName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4171, 4241);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1614_4394_4406(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 4394, 4406);
return return_v;
}


System.Collections.Hashtable
f_1614_4369_4419(System.Management.Automation.ExecutionContext
context,System.Management.Automation.ExternalScriptInfo
scriptInfo)
{
var return_v = DISCUtils.LoadConfigFile( context, scriptInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4369, 4419);
return return_v;
}


string
f_1614_4555_4604()
{
var return_v = RemotingErrorIdStrings.DISCErrorParsingConfigFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 4555, 4604);
return return_v;
}


string
f_1614_4616_4625(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 4616, 4625);
return return_v;
}


string
f_1614_4537_4626(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4537, 4626);
return return_v;
}


int
f_1614_4524_4627(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4524, 4627);
return 0;
}


int
f_1614_4650_4668(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param,bool
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4650, 4668);
return 0;
}


int
f_1614_4802_4820(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param,bool
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4802, 4820);
return 0;
}


bool
f_1614_4975_5031(System.Collections.Hashtable
table,Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
cmdlet,string
path)
{
var return_v = DISCUtils.VerifyConfigTable( table, (System.Management.Automation.PSCmdlet)cmdlet, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4975, 5031);
return return_v;
}


int
f_1614_4963_5032(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param,bool
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 4963, 5032);
return 0;
}


string
f_1614_5134_5194()
{
var return_v = RemotingErrorIdStrings.InvalidPSSessionConfigurationFilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1614, 5134, 5194);
return return_v;
}


string
f_1614_5116_5205(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 5116, 5205);
return return_v;
}


System.InvalidOperationException
f_1614_5256_5294(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 5256, 5294);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1614_5330_5450(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 5330, 5450);
return return_v;
}


int
f_1614_5469_5494(Microsoft.PowerShell.Commands.TestPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1614, 5469, 5494);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1614,1289,5521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1614,1289,5521);
}
		}

public TestPSSessionConfigurationFileCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1614,545,5550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1614,1173,1178);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1614,545,5550);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1614,545,5550);
}


static TestPSSessionConfigurationFileCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1614,545,5550);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1614,545,5550);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1614,545,5550);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1614,545,5550);
}
}
