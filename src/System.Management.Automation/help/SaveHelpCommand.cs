// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Help;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsData.Save, "Help", DefaultParameterSetName = SaveHelpCommand.PathParameterSetName,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096794")]
    public sealed class SaveHelpCommand : UpdatableHelpCommandBase
{
public SaveHelpCommand() :base(f_1174_961_1001_C(UpdatableHelpCommandType.SaveHelpCommand) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1174,929,1024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,1071,1113);
this._alreadyCheckedOncePerDayPerModule = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,1737,1742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,2376,2398);
this._isLiteralPath = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,2504,3036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,3155,3550);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1174,929,1024);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,929,1024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,929,1024);
}
		}

private bool _alreadyCheckedOncePerDayPerModule ;

[Parameter(Mandatory = true, Position = 0, ParameterSetName = PathParameterSetName)]
        [ValidateNotNull]
        [Alias("Path")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] DestinationPath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,1552,1616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,1588,1601);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,1552,1616);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,1256,1708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,1256,1708);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,1632,1697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,1668,1682);

_path = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,1632,1697);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,1256,1708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,1256,1708);
}
		}}

private string[] _path;

[Parameter(Mandatory = true, ParameterSetName = LiteralPathParameterSetName)]
        [Alias("PSPath", "LP")]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] LiteralPath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,2155,2219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,2191,2204);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,2155,2219);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,1862,2351);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,1862,2351);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,2235,2340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,2271,2285);

_path = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,2303,2325);

_isLiteralPath = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,2235,2340);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,1862,2351);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,1862,2351);
}
		}}

private bool _isLiteralPath ;

[Parameter(Position = 1, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = PathParameterSetName)]
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = LiteralPathParameterSetName)]
        [Alias("Name")]
        [ValidateNotNull]
        [ArgumentToModuleTransformationAttribute()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public PSModuleInfo[] Module {get; set; }

[Parameter(ParameterSetName = PathParameterSetName, ValueFromPipelineByPropertyName = true)]
        [Parameter(ParameterSetName = LiteralPathParameterSetName, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public ModuleSpecification[] FullyQualifiedModule {get; set; }

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,3665,6009);
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,3928,4408) || true) && (f_1174_3932_3938()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1174, 3932, 3978)&&f_1174_3950_3970()!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,3928,4408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4020,4145);

string 
errMsg = f_1174_4036_4144(f_1174_4054_4109(), "Module", "FullyQualifiedModule")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4167,4338);

ErrorRecord 
error = f_1174_4187_4337(f_1174_4203_4240(errMsg), "ModuleAndFullyQualifiedModuleCannotBeSpecifiedTogether", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4360,4389);

f_1174_4360_4388(this, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,3928,4408);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4428,4460);

List<string> 
moduleNames = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4478,4516);

List<PSModuleInfo> 
moduleInfos = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4536,5486) || true) && (f_1174_4540_4546()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,4536,5486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4596,4629);

moduleNames = f_1174_4610_4628();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4651,4690);

moduleInfos = f_1174_4665_4689();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,4714,5467);
foreach(PSModuleInfo moduleInfo in f_1174_4750_4756_I(f_1174_4750_4756()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,4714,5467);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5137,5444) || true) && (f_1174_5141_5184(f_1174_5162_5183(moduleInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,5137,5444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5242,5275);

f_1174_5242_5274(                            moduleNames, f_1174_5258_5273(moduleInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,5137,5444);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,5137,5444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5389,5417);

f_1174_5389_5416(                            moduleInfos, moduleInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,5137,5444);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,4714,5467);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1174,1,754);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1174,1,754);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1174,4536,5486);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5506,5554);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Process(moduleNames,f_1174_5532_5552()),1174,5506,5553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5572,5598);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Process(moduleInfos),1174,5572,5597);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1174,5627,5998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5667,5819);

ProgressRecord 
progress = f_1174_5693_5818(activityId, f_1174_5724_5772(), f_1174_5774_5817())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5839,5870);

progress.PercentComplete = 100;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5888,5939);

progress.RecordType = ProgressRecordType.Completed;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,5959,5983);

f_1174_5959_5982(this, progress);
DynAbs.Tracing.TraceSender.TraceExitFinally(1174,5627,5998);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,3665,6009);

System.Management.Automation.PSModuleInfo[]
f_1174_3932_3938()
{
var return_v = Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 3932, 3938);
return return_v;
}


Microsoft.PowerShell.Commands.ModuleSpecification[]
f_1174_3950_3970()
{
var return_v = FullyQualifiedModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 3950, 3970);
return return_v;
}


string
f_1174_4054_4109()
{
var return_v = SessionStateStrings.GetContent_TailAndHeadCannotCoexist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 4054, 4109);
return return_v;
}


string
f_1174_4036_4144(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 4036, 4144);
return return_v;
}


System.InvalidOperationException
f_1174_4203_4240(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 4203, 4240);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1174_4187_4337(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 4187, 4337);
return return_v;
}


int
f_1174_4360_4388(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 4360, 4388);
return 0;
}


System.Management.Automation.PSModuleInfo[]
f_1174_4540_4546()
{
var return_v = Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 4540, 4546);
return return_v;
}


System.Collections.Generic.List<string>
f_1174_4610_4628()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 4610, 4628);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
f_1174_4665_4689()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 4665, 4689);
return return_v;
}


System.Management.Automation.PSModuleInfo[]
f_1174_4750_4756()
{
var return_v = Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 4750, 4756);
return return_v;
}


string
f_1174_5162_5183(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.ModuleBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 5162, 5183);
return return_v;
}


bool
f_1174_5141_5184(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 5141, 5184);
return return_v;
}


string
f_1174_5258_5273(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 5258, 5273);
return return_v;
}


int
f_1174_5242_5274(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 5242, 5274);
return 0;
}


int
f_1174_5389_5416(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
this_param,System.Management.Automation.PSModuleInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 5389, 5416);
return 0;
}


System.Management.Automation.PSModuleInfo[]
f_1174_4750_4756_I(System.Management.Automation.PSModuleInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 4750, 4756);
return return_v;
}


Microsoft.PowerShell.Commands.ModuleSpecification[]
f_1174_5532_5552()
{
var return_v = FullyQualifiedModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 5532, 5552);
return return_v;
}


string
f_1174_5724_5772()
{
var return_v = HelpDisplayStrings.SaveProgressActivityForModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 5724, 5772);
return return_v;
}


string
f_1174_5774_5817()
{
var return_v = HelpDisplayStrings.UpdateProgressInstalling;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 5774, 5817);
return return_v;
}


System.Management.Automation.ProgressRecord
f_1174_5693_5818(int
activityId,string
activity,string
statusDescription)
{
var return_v = new System.Management.Automation.ProgressRecord( activityId, activity, statusDescription);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 5693, 5818);
return return_v;
}


int
f_1174_5959_5982(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,System.Management.Automation.ProgressRecord
progressRecord)
{
this_param.WriteProgress( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 5959, 5982);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,3665,6009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,3665,6009);
}
		}

internal override bool ProcessModuleWithCulture(UpdatableHelpModuleInfo module, string culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,6332,19097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,6452,6512);

Collection<string> 
resolvedPaths = f_1174_6487_6511()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,6572,10938);
foreach(string path in f_1174_6596_6601_I(_path) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,6572,10938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,6635,6681);

UpdatableHelpSystemDrive 
helpInfoDrive = null
;

                try
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,6745,7042) || true) && (f_1174_6749_6775(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,6745,7042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,6825,6928);

PSArgumentException 
e = f_1174_6849_6927(f_1174_6873_6926(f_1174_6891_6925()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,6954,6980);

f_1174_6954_6979(this, f_1174_6965_6978(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7006,7019);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,6745,7042);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7066,7089);

string 
destPath = path
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7113,9243) || true) && (_credential != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,7113,9243);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7186,9220) || true) && (f_1174_7190_7208(path, "*"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,7186,9220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7320,7350);

int 
index = f_1174_7332_7349(path, '*')
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7382,8944) || true) && (index == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,7382,8944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7462,7741);

throw f_1174_7468_7740("PathMustBeValidContainers", f_1174_7567_7636(f_1174_7585_7629(), path), ErrorCategory.InvalidArgument, null, f_1174_7712_7739());
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,7382,8944);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,7382,8944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7871,7885);

int 
i = index
;
try {                                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7919,8220) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,7934,7937)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1174,7919,8220))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,7919,8220);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,8011,8185) || true) && (f_1174_8015_8034(f_1174_8015_8022(path, i), '/')||(DynAbs.Tracing.TraceSender.Expression_False(1174, 8015, 8058)||f_1174_8038_8058(f_1174_8038_8045(path, i), '\\')))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,8011,8185);
DynAbs.Tracing.TraceSender.TraceBreak(1174,8140,8146);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,8011,8185);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1174,1,302);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1174,1,302);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,8256,8662) || true) && (i == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,8256,8662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,8340,8627);

throw f_1174_8346_8626("PathMustBeValidContainers", f_1174_8449_8518(f_1174_8467_8511(), path), ErrorCategory.InvalidArgument, null, f_1174_8598_8625());
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,8256,8662);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,8698,8784);

helpInfoDrive = f_1174_8714_8783(this, f_1174_8749_8769(path, 0, i), _credential);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,8818,8913);

destPath = f_1174_8829_8912(f_1174_8842_8865(helpInfoDrive), f_1174_8867_8911(path, i + 1, f_1174_8889_8900(path)- (i + 1)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,7382,8944);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,7186,9220);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,7186,9220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,9058,9128);

helpInfoDrive = f_1174_9074_9127(this, path, _credential);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,9158,9193);

destPath = f_1174_9169_9192(helpInfoDrive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,7186,9220);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,7113,9243);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,9267,10697) || true) && (_isLiteralPath)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,9267,10697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,9335,9406);

string 
destinationPath = f_1174_9360_9405(this, destPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,9432,9826) || true) && (!f_1174_9437_9470(destinationPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,9432,9826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,9528,9799);

throw f_1174_9534_9798("PathMustBeValidContainers", f_1174_9629_9698(f_1174_9647_9691(), path), ErrorCategory.InvalidArgument, null, f_1174_9770_9797());
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,9432,9826);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,9854,9889);

f_1174_9854_9888(
                        resolvedPaths, destinationPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,9267,10697);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,9267,10697);
                        try
                        {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,10106,10294);
foreach(string tempPath in f_1174_10134_10169_I(f_1174_10134_10169(this, destPath, false, false)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,10106,10294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,10235,10263);

f_1174_10235_10262(                                resolvedPaths, tempPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,10106,10294);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1174,1,189);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1174,1,189);
}                        }
                        catch (ItemNotFoundException e)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1174,10347,10674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,10435,10647);

throw f_1174_10441_10646("PathMustBeValidContainers", f_1174_10536_10605(f_1174_10554_10598(), path), ErrorCategory.InvalidArgument, null, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1174,10347,10674);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,9267,10697);
}
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1174,10734,10923);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,10782,10904) || true) && (helpInfoDrive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,10782,10904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,10857,10881);

f_1174_10857_10880(                        helpInfoDrive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,10782,10904);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1174,10734,10923);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,6572,10938);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1174,1,4367);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1174,1,4367);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,10954,11043) || true) && (f_1174_10958_10977(resolvedPaths)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,10954,11043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11016,11028);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,10954,11043);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11059,11082);

bool 
installed = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11098,19053);
foreach(string path in f_1174_11122_11135_I(resolvedPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,11098,19053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11169,11210);

UpdatableHelpInfo 
currentHelpInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11228,11265);

UpdatableHelpInfo 
newHelpInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11283,11309);

string 
helpInfoUri = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11502,11866);

string 
xml = (DynAbs.Tracing.TraceSender.Conditional_F1(1174, 11515, 11521)||((_force
&&DynAbs.Tracing.TraceSender.Conditional_F2(1174, 11558, 11562))||DynAbs.Tracing.TraceSender.Conditional_F3(1174, 11599, 11865)))?null
:f_1174_11599_11865(this, f_1174_11719_11776(f_1174_11719_11736(f_1174_11719_11731()), path, f_1174_11751_11775(module)), _credential)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,11886,12459) || true) && (xml != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,11886,12459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,12103,12440);

currentHelpInfo = f_1174_12121_12439(_helpSystem, xml, f_1174_12153_12170(module), f_1174_12172_12189(module), currentCulture: null, pathOverride: null, verbose: false, shouldResolveUri: false, ignoreValidationException: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,11886,12459);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,12527,12744) || true) && (!_alreadyCheckedOncePerDayPerModule &&(DynAbs.Tracing.TraceSender.Expression_True(1174, 12531, 12671)&&!f_1174_12571_12671(this, f_1174_12596_12613(module), path, f_1174_12621_12645(module), DateTime.UtcNow, _force)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,12527,12744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,12713,12725);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,12527,12744);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,12764,12806);

_alreadyCheckedOncePerDayPerModule = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,12879,12946);

helpInfoUri = f_1174_12893_12945(f_1174_12893_12933(_helpSystem, module, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,12964,13016);

string 
uri = helpInfoUri + f_1174_12991_13015(module)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,13036,13140);

newHelpInfo = f_1174_13050_13139(_helpSystem, _commandType, uri, f_1174_13093_13110(module), f_1174_13112_13129(module), culture);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,13160,13487) || true) && (newHelpInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,13160,13487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,13225,13468);

throw f_1174_13231_13467("UnableToRetrieveHelpInfoXml", f_1174_13320_13394(f_1174_13338_13384(), culture), ErrorCategory.ResourceUnavailable, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,13160,13487);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,13507,13616);

string 
tempPath = f_1174_13525_13615(f_1174_13538_13556(), f_1174_13558_13614(f_1174_13591_13613()))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,13634,19001);
foreach(UpdatableHelpUri contentUri in f_1174_13674_13710_I(f_1174_13674_13710(newHelpInfo)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,13634,19001);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,13752,18982) || true) && (!f_1174_13757_13840(this, module, currentHelpInfo, newHelpInfo, f_1174_13813_13831(contentUri), _force))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,13752,18982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,13890,14148);

f_1174_13890_14147(this, f_1174_13903_14146(f_1174_13921_13970(), f_1174_13972_13989(module), f_1174_13991_14040(), f_1174_14071_14094(f_1174_14071_14089(contentUri)), f_1174_14096_14145(newHelpInfo, f_1174_14126_14144(contentUri))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14176,14193);

installed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14219,14228);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,13752,18982);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,13752,18982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14326,14408);

f_1174_14326_14407(helpInfoUri != null, "If we are here, helpInfoUri must not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14436,14483);

string 
helpContentUri = f_1174_14460_14482(contentUri)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14509,14580);

string 
helpContentName = f_1174_14534_14579(module, f_1174_14560_14578(contentUri))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14608,14657);

UpdatableHelpSystemDrive 
helpContentDrive = null
;

                        try
                        {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14745,16916) || true) && (f_1174_14749_14781(helpContentUri))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,14745,16916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,14847,15010);

f_1174_14847_15009(f_1174_14857_14915(f_1174_14857_14874(f_1174_14857_14869()), helpContentUri, helpContentName), f_1174_14954_15002(f_1174_14954_14971(f_1174_14954_14966()), path, helpContentName), true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,14745,16916);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,14745,16916);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,15185,16885) || true) && (_credential != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,15185,16885);
                                    try
                                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,15366,15439);

helpContentDrive = f_1174_15385_15438(this, path, _credential);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,15483,15791) || true) && (!f_1174_15488_15585(_helpSystem, _commandType, tempPath, helpContentUri, helpContentName, culture))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,15483,15791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,15675,15693);

installed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,15739,15748);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,15483,15791);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,15835,16025);

f_1174_15835_16024(f_1174_15835_15854(f_1174_15835_15849()), new string[1] { tempPath }, f_1174_15888_15914(helpContentDrive), true, CopyContainers.CopyChildrenOfTargetContainer, true, true);
                                    }
                                    catch (Exception e)
                                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1174,16102,16416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,16202,16266);

f_1174_16202_16265(this, f_1174_16219_16236(module), f_1174_16238_16261(f_1174_16238_16256(contentUri)), e);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,16308,16326);

installed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,16368,16377);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1174,16102,16416);
                                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,15185,16885);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,15185,16885);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,16562,16850) || true) && (!f_1174_16567_16660(_helpSystem, _commandType, path, helpContentUri, helpContentName, culture))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,16562,16850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,16742,16760);

installed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,16802,16811);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,16562,16850);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,15185,16885);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,14745,16916);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,16948,17985) || true) && (_credential != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,16948,17985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,17037,17288);

f_1174_17037_17287(                                _helpSystem, f_1174_17066_17083(module), f_1174_17085_17102(module), f_1174_17104_17129(newHelpInfo), f_1174_17131_17154(f_1174_17131_17149(contentUri)), f_1174_17156_17205(newHelpInfo, f_1174_17186_17204(contentUri)), tempPath, f_1174_17254_17278(                                    module), _force);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,17324,17577);

f_1174_17324_17576(f_1174_17324_17343(f_1174_17324_17338()), new string[1] { f_1174_17365_17413(tempPath, f_1174_17388_17412(module))}, f_1174_17417_17483(f_1174_17430_17456(helpContentDrive), f_1174_17458_17482(module)), false, CopyContainers.CopyTargetContainer, true, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,16948,17985);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,16948,17985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,17707,17954);

f_1174_17707_17953(                                _helpSystem, f_1174_17736_17753(module), f_1174_17755_17772(module), f_1174_17774_17799(newHelpInfo), f_1174_17801_17824(f_1174_17801_17819(contentUri)), f_1174_17826_17875(newHelpInfo, f_1174_17856_17874(contentUri)), path, f_1174_17920_17944(                                    module), _force);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,16948,17985);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,18017,18364);

f_1174_18017_18363(this, f_1174_18030_18362(f_1174_18048_18097(), f_1174_18099_18116(module), f_1174_18151_18252(f_1174_18169_18204(), f_1174_18206_18251(path, helpContentName)), f_1174_18254_18277(f_1174_18254_18272(contentUri)), f_1174_18312_18361(                                newHelpInfo, f_1174_18342_18360(contentUri))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,18396,18470);

f_1174_18396_18469(this, f_1174_18407_18468(f_1174_18425_18461(), path));
                        }
                        catch (Exception e)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1174,18523,18690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,18599,18663);

f_1174_18599_18662(this, f_1174_18616_18633(module), f_1174_18635_18658(f_1174_18635_18653(contentUri)), e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1174,18523,18690);
                        }
                        finally
                        {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1174,18716,18959);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,18780,18932) || true) && (helpContentDrive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,18780,18932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,18874,18901);

f_1174_18874_18900(                                helpContentDrive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,18780,18932);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1174,18716,18959);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,13752,18982);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,13634,19001);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1174,1,5368);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1174,1,5368);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19021,19038);

installed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,11098,19053);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1174,1,7956);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1174,1,7956);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19069,19086);

return installed;
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,6332,19097);

System.Collections.ObjectModel.Collection<string>
f_1174_6487_6511()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 6487, 6511);
return return_v;
}


bool
f_1174_6749_6775(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 6749, 6775);
return return_v;
}


string
f_1174_6891_6925()
{
var return_v = HelpDisplayStrings.PathNullOrEmpty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 6891, 6925);
return return_v;
}


string
f_1174_6873_6926(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 6873, 6926);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1174_6849_6927(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 6849, 6927);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1174_6965_6978(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 6965, 6978);
return return_v;
}


int
f_1174_6954_6979(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 6954, 6979);
return 0;
}


bool
f_1174_7190_7208(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 7190, 7208);
return return_v;
}


int
f_1174_7332_7349(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 7332, 7349);
return return_v;
}


string
f_1174_7585_7629()
{
var return_v = HelpDisplayStrings.PathMustBeValidContainers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 7585, 7629);
return return_v;
}


string
f_1174_7567_7636(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 7567, 7636);
return return_v;
}


System.Management.Automation.ItemNotFoundException
f_1174_7712_7739()
{
var return_v = new System.Management.Automation.ItemNotFoundException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 7712, 7739);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1174_7468_7740(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Management.Automation.ItemNotFoundException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 7468, 7740);
return return_v;
}


char
f_1174_8015_8022(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 8015, 8022);
return return_v;
}


bool
f_1174_8015_8034(char
this_param,char
obj)
{
var return_v = this_param.Equals( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8015, 8034);
return return_v;
}


char
f_1174_8038_8045(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 8038, 8045);
return return_v;
}


bool
f_1174_8038_8058(char
this_param,char
obj)
{
var return_v = this_param.Equals( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8038, 8058);
return return_v;
}


string
f_1174_8467_8511()
{
var return_v = HelpDisplayStrings.PathMustBeValidContainers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 8467, 8511);
return return_v;
}


string
f_1174_8449_8518(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8449, 8518);
return return_v;
}


System.Management.Automation.ItemNotFoundException
f_1174_8598_8625()
{
var return_v = new System.Management.Automation.ItemNotFoundException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8598, 8625);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1174_8346_8626(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Management.Automation.ItemNotFoundException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8346, 8626);
return return_v;
}


string
f_1174_8749_8769(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8749, 8769);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemDrive
f_1174_8714_8783(Microsoft.PowerShell.Commands.SaveHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemDrive( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8714, 8783);
return return_v;
}


string
f_1174_8842_8865(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 8842, 8865);
return return_v;
}


int
f_1174_8889_8900(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 8889, 8900);
return return_v;
}


string
f_1174_8867_8911(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8867, 8911);
return return_v;
}


string
f_1174_8829_8912(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 8829, 8912);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemDrive
f_1174_9074_9127(Microsoft.PowerShell.Commands.SaveHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemDrive( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 9074, 9127);
return return_v;
}


string
f_1174_9169_9192(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 9169, 9192);
return return_v;
}


string
f_1174_9360_9405(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
path)
{
var return_v = this_param.GetUnresolvedProviderPathFromPSPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 9360, 9405);
return return_v;
}


bool
f_1174_9437_9470(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 9437, 9470);
return return_v;
}


string
f_1174_9647_9691()
{
var return_v = HelpDisplayStrings.PathMustBeValidContainers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 9647, 9691);
return return_v;
}


string
f_1174_9629_9698(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 9629, 9698);
return return_v;
}


System.Management.Automation.ItemNotFoundException
f_1174_9770_9797()
{
var return_v = new System.Management.Automation.ItemNotFoundException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 9770, 9797);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1174_9534_9798(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Management.Automation.ItemNotFoundException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 9534, 9798);
return return_v;
}


int
f_1174_9854_9888(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 9854, 9888);
return 0;
}


System.Collections.Generic.IEnumerable<string>
f_1174_10134_10169(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
path,bool
recurse,bool
isLiteralPath)
{
var return_v = this_param.ResolvePath( path, recurse, isLiteralPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 10134, 10169);
return return_v;
}


int
f_1174_10235_10262(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 10235, 10262);
return 0;
}


System.Collections.Generic.IEnumerable<string>
f_1174_10134_10169_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 10134, 10169);
return return_v;
}


string
f_1174_10554_10598()
{
var return_v = HelpDisplayStrings.PathMustBeValidContainers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 10554, 10598);
return return_v;
}


string
f_1174_10536_10605(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 10536, 10605);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1174_10441_10646(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Management.Automation.ItemNotFoundException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 10441, 10646);
return return_v;
}


int
f_1174_10857_10880(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 10857, 10880);
return 0;
}


string[]
f_1174_6596_6601_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 6596, 6601);
return return_v;
}


int
f_1174_10958_10977(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 10958, 10977);
return return_v;
}


System.Management.Automation.SessionState
f_1174_11719_11731()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 11719, 11731);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1174_11719_11736(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 11719, 11736);
return return_v;
}


string
f_1174_11751_11775(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 11751, 11775);
return return_v;
}


string
f_1174_11719_11776(System.Management.Automation.PathIntrinsics
this_param,string
parent,string
child)
{
var return_v = this_param.Combine( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 11719, 11776);
return return_v;
}


string
f_1174_11599_11865(Microsoft.PowerShell.Commands.SaveHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = UpdatableHelpSystem.LoadStringFromPath( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 11599, 11865);
return return_v;
}


string
f_1174_12153_12170(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 12153, 12170);
return return_v;
}


System.Guid
f_1174_12172_12189(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 12172, 12189);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1174_12121_12439(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
xml,string
moduleName,System.Guid
moduleGuid,string
currentCulture,string
pathOverride,bool
verbose,bool
shouldResolveUri,bool
ignoreValidationException)
{
var return_v = this_param.CreateHelpInfo( xml, moduleName, moduleGuid, currentCulture: currentCulture, pathOverride: pathOverride, verbose: verbose, shouldResolveUri: shouldResolveUri, ignoreValidationException: ignoreValidationException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 12121, 12439);
return return_v;
}


string
f_1174_12596_12613(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 12596, 12613);
return return_v;
}


string
f_1174_12621_12645(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 12621, 12645);
return return_v;
}


bool
f_1174_12571_12671(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
moduleName,string
path,string
filename,System.DateTime
time,bool
force)
{
var return_v = this_param.CheckOncePerDayPerModule( moduleName, path, filename, time, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 12571, 12671);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpUri
f_1174_12893_12933(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpModuleInfo
module,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetHelpInfoUri( module, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 12893, 12933);
return return_v;
}


string
f_1174_12893_12945(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.ResolvedUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 12893, 12945);
return return_v;
}


string
f_1174_12991_13015(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 12991, 13015);
return return_v;
}


string
f_1174_13093_13110(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13093, 13110);
return return_v;
}


System.Guid
f_1174_13112_13129(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13112, 13129);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1174_13050_13139(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,string
uri,string
moduleName,System.Guid
moduleGuid,string
culture)
{
var return_v = this_param.GetHelpInfo( commandType, uri, moduleName, moduleGuid, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13050, 13139);
return return_v;
}


string
f_1174_13338_13384()
{
var return_v = HelpDisplayStrings.UnableToRetrieveHelpInfoXml;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13338, 13384);
return return_v;
}


string
f_1174_13320_13394(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13320, 13394);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1174_13231_13467(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13231, 13467);
return return_v;
}


string
f_1174_13538_13556()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13538, 13556);
return return_v;
}


string
f_1174_13591_13613()
{
var return_v = Path.GetTempFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13591, 13613);
return return_v;
}


string?
f_1174_13558_13614(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13558, 13614);
return return_v;
}


string
f_1174_13525_13615(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13525, 13615);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
f_1174_13674_13710(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.HelpContentUriCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13674, 13710);
return return_v;
}


System.Globalization.CultureInfo
f_1174_13813_13831(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13813, 13831);
return return_v;
}


bool
f_1174_13757_13840(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,System.Management.Automation.Help.UpdatableHelpModuleInfo
module,System.Management.Automation.Help.UpdatableHelpInfo
currentHelpInfo,System.Management.Automation.Help.UpdatableHelpInfo
newHelpInfo,System.Globalization.CultureInfo
culture,bool
force)
{
var return_v = this_param.IsUpdateNecessary( module, currentHelpInfo, newHelpInfo, culture, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13757, 13840);
return return_v;
}


string
f_1174_13921_13970()
{
var return_v = HelpDisplayStrings.SuccessfullyUpdatedHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13921, 13970);
return return_v;
}


string
f_1174_13972_13989(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13972, 13989);
return return_v;
}


string
f_1174_13991_14040()
{
var return_v = HelpDisplayStrings.NewestContentAlreadyDownloaded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 13991, 14040);
return return_v;
}


System.Globalization.CultureInfo
f_1174_14071_14089(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14071, 14089);
return return_v;
}


string
f_1174_14071_14094(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14071, 14094);
return return_v;
}


System.Globalization.CultureInfo
f_1174_14126_14144(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14126, 14144);
return return_v;
}


System.Version
f_1174_14096_14145(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 14096, 14145);
return return_v;
}


string
f_1174_13903_14146(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13903, 14146);
return return_v;
}


int
f_1174_13890_14147(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13890, 14147);
return 0;
}


int
f_1174_14326_14407(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 14326, 14407);
return 0;
}


string
f_1174_14460_14482(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.ResolvedUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14460, 14482);
return return_v;
}


System.Globalization.CultureInfo
f_1174_14560_14578(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14560, 14578);
return return_v;
}


string
f_1174_14534_14579(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetHelpContentName( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 14534, 14579);
return return_v;
}


bool
f_1174_14749_14781(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 14749, 14781);
return return_v;
}


System.Management.Automation.SessionState
f_1174_14857_14869()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14857, 14869);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1174_14857_14874(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14857, 14874);
return return_v;
}


string
f_1174_14857_14915(System.Management.Automation.PathIntrinsics
this_param,string
parent,string
child)
{
var return_v = this_param.Combine( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 14857, 14915);
return return_v;
}


System.Management.Automation.SessionState
f_1174_14954_14966()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14954, 14966);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1174_14954_14971(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 14954, 14971);
return return_v;
}


string
f_1174_14954_15002(System.Management.Automation.PathIntrinsics
this_param,string
parent,string
child)
{
var return_v = this_param.Combine( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 14954, 15002);
return return_v;
}


int
f_1174_14847_15009(string
sourceFileName,string
destFileName,bool
overwrite)
{
File.Copy( sourceFileName, destFileName, overwrite);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 14847, 15009);
return 0;
}


System.Management.Automation.Help.UpdatableHelpSystemDrive
f_1174_15385_15438(Microsoft.PowerShell.Commands.SaveHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemDrive( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 15385, 15438);
return return_v;
}


bool
f_1174_15488_15585(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,string
path,string
helpContentUri,string
fileName,string
culture)
{
var return_v = this_param.DownloadHelpContent( commandType, path, helpContentUri, fileName, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 15488, 15585);
return return_v;
}


System.Management.Automation.ProviderIntrinsics
f_1174_15835_15849()
{
var return_v = InvokeProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 15835, 15849);
return return_v;
}


System.Management.Automation.ItemCmdletProviderIntrinsics
f_1174_15835_15854(System.Management.Automation.ProviderIntrinsics
this_param)
{
var return_v = this_param.Item;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 15835, 15854);
return return_v;
}


string
f_1174_15888_15914(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 15888, 15914);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1174_15835_16024(System.Management.Automation.ItemCmdletProviderIntrinsics
this_param,string[]
path,string
destinationPath,bool
recurse,System.Management.Automation.CopyContainers
copyContainers,bool
force,bool
literalPath)
{
var return_v = this_param.Copy( path, destinationPath, recurse, copyContainers, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 15835, 16024);
return return_v;
}


string
f_1174_16219_16236(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 16219, 16236);
return return_v;
}


System.Globalization.CultureInfo
f_1174_16238_16256(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 16238, 16256);
return return_v;
}


string
f_1174_16238_16261(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 16238, 16261);
return return_v;
}


int
f_1174_16202_16265(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
moduleName,string
culture,System.Exception
e)
{
this_param.ProcessException( moduleName, culture, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 16202, 16265);
return 0;
}


bool
f_1174_16567_16660(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,string
path,string
helpContentUri,string
fileName,string
culture)
{
var return_v = this_param.DownloadHelpContent( commandType, path, helpContentUri, fileName, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 16567, 16660);
return return_v;
}


string
f_1174_17066_17083(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17066, 17083);
return return_v;
}


System.Guid
f_1174_17085_17102(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17085, 17102);
return return_v;
}


string
f_1174_17104_17129(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.UnresolvedUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17104, 17129);
return return_v;
}


System.Globalization.CultureInfo
f_1174_17131_17149(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17131, 17149);
return return_v;
}


string
f_1174_17131_17154(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17131, 17154);
return return_v;
}


System.Globalization.CultureInfo
f_1174_17186_17204(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17186, 17204);
return return_v;
}


System.Version
f_1174_17156_17205(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17156, 17205);
return return_v;
}


string
f_1174_17254_17278(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17254, 17278);
return return_v;
}


int
f_1174_17037_17287(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
moduleName,System.Guid
moduleGuid,string
contentUri,string
culture,System.Version
version,string
destPath,string
fileName,bool
force)
{
this_param.GenerateHelpInfo( moduleName, moduleGuid, contentUri, culture, version, destPath, fileName, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17037, 17287);
return 0;
}


System.Management.Automation.ProviderIntrinsics
f_1174_17324_17338()
{
var return_v = InvokeProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17324, 17338);
return return_v;
}


System.Management.Automation.ItemCmdletProviderIntrinsics
f_1174_17324_17343(System.Management.Automation.ProviderIntrinsics
this_param)
{
var return_v = this_param.Item;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17324, 17343);
return return_v;
}


string
f_1174_17388_17412(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17388, 17412);
return return_v;
}


string
f_1174_17365_17413(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17365, 17413);
return return_v;
}


string
f_1174_17430_17456(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17430, 17456);
return return_v;
}


string
f_1174_17458_17482(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17458, 17482);
return return_v;
}


string
f_1174_17417_17483(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17417, 17483);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1174_17324_17576(System.Management.Automation.ItemCmdletProviderIntrinsics
this_param,string[]
path,string
destinationPath,bool
recurse,System.Management.Automation.CopyContainers
copyContainers,bool
force,bool
literalPath)
{
var return_v = this_param.Copy( path, destinationPath, recurse, copyContainers, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17324, 17576);
return return_v;
}


string
f_1174_17736_17753(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17736, 17753);
return return_v;
}


System.Guid
f_1174_17755_17772(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17755, 17772);
return return_v;
}


string
f_1174_17774_17799(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.UnresolvedUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17774, 17799);
return return_v;
}


System.Globalization.CultureInfo
f_1174_17801_17819(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17801, 17819);
return return_v;
}


string
f_1174_17801_17824(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17801, 17824);
return return_v;
}


System.Globalization.CultureInfo
f_1174_17856_17874(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 17856, 17874);
return return_v;
}


System.Version
f_1174_17826_17875(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17826, 17875);
return return_v;
}


string
f_1174_17920_17944(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17920, 17944);
return return_v;
}


int
f_1174_17707_17953(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
moduleName,System.Guid
moduleGuid,string
contentUri,string
culture,System.Version
version,string
destPath,string
fileName,bool
force)
{
this_param.GenerateHelpInfo( moduleName, moduleGuid, contentUri, culture, version, destPath, fileName, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 17707, 17953);
return 0;
}


string
f_1174_18048_18097()
{
var return_v = HelpDisplayStrings.SuccessfullyUpdatedHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18048, 18097);
return return_v;
}


string
f_1174_18099_18116(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18099, 18116);
return return_v;
}


string
f_1174_18169_18204()
{
var return_v = HelpDisplayStrings.SavedHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18169, 18204);
return return_v;
}


string
f_1174_18206_18251(string
path1,string
path2)
{
var return_v = System.IO.Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18206, 18251);
return return_v;
}


string
f_1174_18151_18252(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18151, 18252);
return return_v;
}


System.Globalization.CultureInfo
f_1174_18254_18272(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18254, 18272);
return return_v;
}


string
f_1174_18254_18277(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18254, 18277);
return return_v;
}


System.Globalization.CultureInfo
f_1174_18342_18360(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18342, 18360);
return return_v;
}


System.Version
f_1174_18312_18361(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18312, 18361);
return return_v;
}


string
f_1174_18030_18362(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18030, 18362);
return return_v;
}


int
f_1174_18017_18363(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18017, 18363);
return 0;
}


string
f_1174_18425_18461()
{
var return_v = HelpDisplayStrings.SaveHelpCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18425, 18461);
return return_v;
}


string
f_1174_18407_18468(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18407, 18468);
return return_v;
}


int
f_1174_18396_18469(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
message)
{
this_param.LogMessage( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18396, 18469);
return 0;
}


string
f_1174_18616_18633(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18616, 18633);
return return_v;
}


System.Globalization.CultureInfo
f_1174_18635_18653(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18635, 18653);
return return_v;
}


string
f_1174_18635_18658(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 18635, 18658);
return return_v;
}


int
f_1174_18599_18662(Microsoft.PowerShell.Commands.SaveHelpCommand
this_param,string
moduleName,string
culture,System.Exception
e)
{
this_param.ProcessException( moduleName, culture, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18599, 18662);
return 0;
}


int
f_1174_18874_18900(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 18874, 18900);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
f_1174_13674_13710_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 13674, 13710);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1174_11122_11135_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 11122, 11135);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,6332,19097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,6332,19097);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SaveHelpCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1174,568,19126);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1174,568,19126);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,568,19126);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1174,568,19126);

static System.Management.Automation.Help.UpdatableHelpCommandType
f_1174_961_1001_C(System.Management.Automation.Help.UpdatableHelpCommandType
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1174, 929, 1024);
return return_v;
}

}
internal sealed class ArgumentToModuleTransformationAttribute : ArgumentTransformationAttribute
{
public override object Transform(EngineIntrinsics engineIntrinsics, object inputData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,19246,21502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19356,19399);

object 
argument = f_1174_19374_19398(inputData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19464,19496);

var 
strArg = argument as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19510,19662) || true) && (strArg != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,19510,19662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19562,19647);

return f_1174_19569_19646(name: strArg, path: null, context: null, sessionState: null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,19510,19662);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19719,19775);

IList 
iListArg = f_1174_19736_19774(argument)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19789,21263) || true) && (iListArg != null &&(DynAbs.Tracing.TraceSender.Expression_True(1174, 19793, 19831)&&f_1174_19813_19827(iListArg)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,19789,21263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19865,19899);

int 
elementCount = f_1174_19884_19898(iListArg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19917,19937);

int 
targetIndex = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,19955,20019);

var 
target = f_1174_19968_20018(typeof(object), elementCount)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20039,21214);
foreach(object element in f_1174_20066_20074_I(iListArg) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,20039,21214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20116,20158);

var 
elementValue = f_1174_20135_20157(element)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20182,21195) || true) && (elementValue is PSModuleInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,20182,21195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20264,20309);

f_1174_20264_20308(                        target, elementValue, targetIndex++);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,20182,21195);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,20182,21195);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20359,21195) || true) && (elementValue is string)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,20359,21195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20435,20552);

var 
elementAsModuleObj = f_1174_20460_20551(name: (string)elementValue, path: null, context: null, sessionState: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20578,20629);

f_1174_20578_20628(                        target, elementAsModuleObj, targetIndex++);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,20359,21195);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,20359,21195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20727,20770);

PSModuleInfo 
elementValueModuleInfo = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20796,21172) || true) && (f_1174_20800_20878(this, elementValue, out elementValueModuleInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,20796,21172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,20936,20991);

f_1174_20936_20990(                            target, elementValueModuleInfo, targetIndex++);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,20796,21172);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,20796,21172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21105,21145);

f_1174_21105_21144(                            target, element, targetIndex++);
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,20796,21172);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,20359,21195);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,20182,21195);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,20039,21214);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1174,1,1176);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1174,1,1176);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21234,21248);

return target;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,19789,21263);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21279,21310);

PSModuleInfo 
moduleInfo = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21324,21458) || true) && (f_1174_21328_21391(this, inputData, out moduleInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,21324,21458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21425,21443);

return moduleInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,21324,21458);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21474,21491);

return inputData;
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,19246,21502);

object
f_1174_19374_19398(object
obj)
{
var return_v = PSObject.Base( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 19374, 19398);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1174_19569_19646(string
name,string
path,System.Management.Automation.ExecutionContext
context,System.Management.Automation.SessionState
sessionState)
{
var return_v = new System.Management.Automation.PSModuleInfo( name: name, path: path, context: context, sessionState: sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 19569, 19646);
return return_v;
}


System.Collections.IList
f_1174_19736_19774(object
value)
{
var return_v = ParameterBinderBase.GetIList( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 19736, 19774);
return return_v;
}


int
f_1174_19813_19827(System.Collections.IList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 19813, 19827);
return return_v;
}


int
f_1174_19884_19898(System.Collections.IList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 19884, 19898);
return return_v;
}


System.Array
f_1174_19968_20018(System.Type
elementType,int
length)
{
var return_v = Array.CreateInstance( elementType, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 19968, 20018);
return return_v;
}


object
f_1174_20135_20157(object
obj)
{
var return_v = PSObject.Base( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 20135, 20157);
return return_v;
}


int
f_1174_20264_20308(System.Array
this_param,object
value,int
index)
{
this_param.SetValue( value, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 20264, 20308);
return 0;
}


System.Management.Automation.PSModuleInfo
f_1174_20460_20551(object
name,string
path,System.Management.Automation.ExecutionContext
context,System.Management.Automation.SessionState
sessionState)
{
var return_v = new System.Management.Automation.PSModuleInfo( name: (string)name, path: path, context: context, sessionState: sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 20460, 20551);
return return_v;
}


int
f_1174_20578_20628(System.Array
this_param,System.Management.Automation.PSModuleInfo
value,int
index)
{
this_param.SetValue( (object)value, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 20578, 20628);
return 0;
}


bool
f_1174_20800_20878(Microsoft.PowerShell.Commands.ArgumentToModuleTransformationAttribute
this_param,object
inputData,out System.Management.Automation.PSModuleInfo
moduleInfo)
{
var return_v = this_param.TryConvertFromDeserializedModuleInfo( inputData, out moduleInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 20800, 20878);
return return_v;
}


int
f_1174_20936_20990(System.Array
this_param,System.Management.Automation.PSModuleInfo
value,int
index)
{
this_param.SetValue( (object)value, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 20936, 20990);
return 0;
}


int
f_1174_21105_21144(System.Array
this_param,object
value,int
index)
{
this_param.SetValue( value, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 21105, 21144);
return 0;
}


System.Collections.IList
f_1174_20066_20074_I(System.Collections.IList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 20066, 20074);
return return_v;
}


bool
f_1174_21328_21391(Microsoft.PowerShell.Commands.ArgumentToModuleTransformationAttribute
this_param,object
inputData,out System.Management.Automation.PSModuleInfo
moduleInfo)
{
var return_v = this_param.TryConvertFromDeserializedModuleInfo( inputData, out moduleInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 21328, 21391);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,19246,21502);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,19246,21502);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryConvertFromDeserializedModuleInfo(object inputData, out PSModuleInfo moduleInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1174,21514,22938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21635,21653);

moduleInfo = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21667,21704);

PSObject 
pso = inputData as PSObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21718,22898) || true) && (f_1174_21722_21790(pso, typeof(PSModuleInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1174,21718,22898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21824,21842);

string 
moduleName
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21860,21946);

f_1174_21860_21945(f_1174_21900_21928(f_1174_21900_21922(f_1174_21900_21914(pso), "Name")), out moduleName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,21966,21982);

Guid 
moduleGuid
=default(Guid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22000,22084);

f_1174_22000_22083(f_1174_22038_22066(f_1174_22038_22060(f_1174_22038_22052(pso), "Guid")), out moduleGuid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22104,22126);

Version 
moduleVersion
=default(Version);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22144,22237);

f_1174_22144_22236(f_1174_22185_22216(f_1174_22185_22210(f_1174_22185_22199(pso), "Version")), out moduleVersion);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22257,22276);

string 
helpInfoUri
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22294,22388);

f_1174_22294_22387(f_1174_22334_22369(f_1174_22334_22363(f_1174_22334_22348(pso), "HelpInfoUri")), out helpInfoUri);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22408,22503);

moduleInfo = f_1174_22421_22502(name: moduleName, path: null, context: null, sessionState: null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22521,22552);

f_1174_22521_22551(                moduleInfo, moduleGuid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22570,22607);

f_1174_22570_22606(                moduleInfo, moduleVersion);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22625,22664);

f_1174_22625_22663(                moduleInfo, helpInfoUri);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22796,22851);

f_1174_22796_22850(                // setting the base to temp directory as this is a deserialized
                // module info.
                moduleInfo, f_1174_22821_22849());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22871,22883);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1174,21718,22898);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1174,22914,22927);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1174,21514,22938);

bool
f_1174_21722_21790(System.Management.Automation.PSObject
o,System.Type
type)
{
var return_v = Deserializer.IsDeserializedInstanceOfType( (object)o, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 21722, 21790);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1174_21900_21914(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 21900, 21914);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1174_21900_21922(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 21900, 21922);
return return_v;
}


object
f_1174_21900_21928(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 21900, 21928);
return return_v;
}


bool
f_1174_21860_21945(object
valueToConvert,out string
result)
{
var return_v = LanguagePrimitives.TryConvertTo<string>( valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 21860, 21945);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1174_22038_22052(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22038, 22052);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1174_22038_22060(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22038, 22060);
return return_v;
}


object
f_1174_22038_22066(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22038, 22066);
return return_v;
}


bool
f_1174_22000_22083(object
valueToConvert,out System.Guid
result)
{
var return_v = LanguagePrimitives.TryConvertTo<Guid>( valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22000, 22083);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1174_22185_22199(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22185, 22199);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1174_22185_22210(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22185, 22210);
return return_v;
}


object
f_1174_22185_22216(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22185, 22216);
return return_v;
}


bool
f_1174_22144_22236(object
valueToConvert,out System.Version
result)
{
var return_v = LanguagePrimitives.TryConvertTo<Version>( valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22144, 22236);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1174_22334_22348(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22334, 22348);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1174_22334_22363(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22334, 22363);
return return_v;
}


object
f_1174_22334_22369(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1174, 22334, 22369);
return return_v;
}


bool
f_1174_22294_22387(object
valueToConvert,out string
result)
{
var return_v = LanguagePrimitives.TryConvertTo<string>( valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22294, 22387);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1174_22421_22502(string
name,string
path,System.Management.Automation.ExecutionContext
context,System.Management.Automation.SessionState
sessionState)
{
var return_v = new System.Management.Automation.PSModuleInfo( name: name, path: path, context: context, sessionState: sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22421, 22502);
return return_v;
}


int
f_1174_22521_22551(System.Management.Automation.PSModuleInfo
this_param,System.Guid
guid)
{
this_param.SetGuid( guid);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22521, 22551);
return 0;
}


int
f_1174_22570_22606(System.Management.Automation.PSModuleInfo
this_param,System.Version
version)
{
this_param.SetVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22570, 22606);
return 0;
}


int
f_1174_22625_22663(System.Management.Automation.PSModuleInfo
this_param,string
uri)
{
this_param.SetHelpInfoUri( uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22625, 22663);
return 0;
}


string
f_1174_22821_22849()
{
var return_v = System.IO.Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22821, 22849);
return return_v;
}


int
f_1174_22796_22850(System.Management.Automation.PSModuleInfo
this_param,string
moduleBase)
{
this_param.SetModuleBase( moduleBase);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1174, 22796, 22850);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1174,21514,22938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,21514,22938);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ArgumentToModuleTransformationAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1174,19134,22945);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1174,19134,22945);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,19134,22945);
}


static ArgumentToModuleTransformationAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1174,19134,22945);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1174,19134,22945);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1174,19134,22945);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1174,19134,22945);
}
}
