// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Help;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsData.Update, "Help", DefaultParameterSetName = PathParameterSetName,
        SupportsShouldProcess = true,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096805")]
    public sealed class UpdateHelpCommand : UpdatableHelpCommandBase
{
public UpdateHelpCommand() :base(f_1182_959_1001_C(UpdatableHelpCommandType.UpdateHelpCommand) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1182,925,1024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,1071,1113);
this._alreadyCheckedOncePerDayPerModule = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,1870,1877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,1997,2392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,2958,2963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,3619,3641);
this._isLiteralPath = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,4002,4010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,4058,4080);
this._isInitialized = false;DynAbs.Tracing.TraceSender.TraceExitConstructor(1182,925,1024);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,925,1024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,925,1024);
}
		}

private bool _alreadyCheckedOncePerDayPerModule ;

[Parameter(Position = 0, ParameterSetName = PathParameterSetName, ValueFromPipelineByPropertyName = true)]
        [Parameter(Position = 0, ParameterSetName = LiteralPathParameterSetName, ValueFromPipelineByPropertyName = true)]
        [Alias("Name")]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] Module
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,1681,1747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,1717,1732);

return _module;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,1681,1747);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,1249,1841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,1249,1841);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,1763,1830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,1799,1815);

_module = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,1763,1830);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,1249,1841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,1249,1841);
}
		}}

private string[] _module;

[Parameter(ParameterSetName = PathParameterSetName, ValueFromPipelineByPropertyName = true)]
        [Parameter(ParameterSetName = LiteralPathParameterSetName, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public ModuleSpecification[] FullyQualifiedModule {get; set; }

[Parameter(Position = 1, ParameterSetName = PathParameterSetName)]
        [ValidateNotNull]
        [Alias("Path")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] SourcePath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,2773,2837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,2809,2822);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,2773,2837);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,2500,2929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,2500,2929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,2853,2918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,2889,2903);

_path = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,2853,2918);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,2500,2929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,2500,2929);
}
		}}

private string[] _path;

[Parameter(ParameterSetName = LiteralPathParameterSetName, ValueFromPipelineByPropertyName = true)]
        [Alias("PSPath", "LP")]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] LiteralPath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,3398,3462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,3434,3447);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,3398,3462);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,3083,3594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,3083,3594);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,3478,3583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,3514,3528);

_path = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,3546,3568);

_isLiteralPath = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,3478,3583);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,3083,3594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,3083,3594);
}
		}}

private bool _isLiteralPath ;

[Parameter]
        public SwitchParameter Recurse
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,3815,3882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,3851,3867);

return _recurse;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,3815,3882);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,3739,3977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,3739,3977);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,3898,3966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,3934,3951);

_recurse = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,3898,3966);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,3739,3977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,3739,3977);
}
		}}

private bool _recurse;

private bool _isInitialized ;

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,4205,4617);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,4271,4606) || true) && (_path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,4271,4606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,4375,4437);

string 
defaultSourcePath = f_1182_4402_4436(_helpSystem)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,4457,4591) || true) && (defaultSourcePath != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,4457,4591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,4528,4572);

_path = new string[1] { defaultSourcePath };
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,4457,4591);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,4271,4606);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,4205,4617);

string
f_1182_4402_4436(System.Management.Automation.Help.UpdatableHelpSystem
this_param)
{
var return_v = this_param.GetDefaultSourcePath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 4402, 4436);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,4205,4617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,4205,4617);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,4708,6701);
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,4971,5451) || true) && (f_1182_4975_4981()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1182, 4975, 5021)&&f_1182_4993_5013()!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,4971,5451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5063,5188);

string 
errMsg = f_1182_5079_5187(f_1182_5097_5152(), "Module", "FullyQualifiedModule")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5210,5381);

ErrorRecord 
error = f_1182_5230_5380(f_1182_5246_5283(errMsg), "ModuleAndFullyQualifiedModuleCannotBeSpecifiedTogether", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5403,5432);

f_1182_5403_5431(this, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,4971,5451);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5471,5890) || true) && (!_isInitialized)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,5471,5890);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5532,5825) || true) && (_path == null &&(DynAbs.Tracing.TraceSender.Expression_True(1182, 5536, 5570)&&f_1182_5553_5560().IsPresent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,5532,5825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5620,5739);

PSArgumentException 
e = f_1182_5644_5738(f_1182_5668_5737(f_1182_5686_5736()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5765,5802);

f_1182_5765_5801(this, f_1182_5787_5800(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,5532,5825);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5849,5871);

_isInitialized = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,5471,5890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,5910,5954);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Process(_module,f_1182_5932_5952()),1182,5910,5953);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,6028,6288);
foreach(HelpProvider provider in f_1182_6062_6094_I(f_1182_6062_6094(f_1182_6062_6080(f_1182_6062_6069()))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,6028,6288);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,6136,6228) || true) && (_stopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,6136,6228);
DynAbs.Tracing.TraceSender.TraceBreak(1182,6199,6205);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,6136,6228);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,6252,6269);

f_1182_6252_6268(
                    provider);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,6028,6288);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1182,1,261);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1182,1,261);
}            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1182,6317,6690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,6357,6511);

ProgressRecord 
progress = f_1182_6383_6510(activityId, f_1182_6414_6464(), f_1182_6466_6509())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,6531,6562);

progress.PercentComplete = 100;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,6580,6631);

progress.RecordType = ProgressRecordType.Completed;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,6651,6675);

f_1182_6651_6674(this, progress);
DynAbs.Tracing.TraceSender.TraceExitFinally(1182,6317,6690);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,4708,6701);

string[]
f_1182_4975_4981()
{
var return_v = Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 4975, 4981);
return return_v;
}


Microsoft.PowerShell.Commands.ModuleSpecification[]
f_1182_4993_5013()
{
var return_v = FullyQualifiedModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 4993, 5013);
return return_v;
}


string
f_1182_5097_5152()
{
var return_v = SessionStateStrings.GetContent_TailAndHeadCannotCoexist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 5097, 5152);
return return_v;
}


string
f_1182_5079_5187(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 5079, 5187);
return return_v;
}


System.InvalidOperationException
f_1182_5246_5283(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 5246, 5283);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1182_5230_5380(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 5230, 5380);
return return_v;
}


int
f_1182_5403_5431(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 5403, 5431);
return 0;
}


System.Management.Automation.SwitchParameter
f_1182_5553_5560()
{
var return_v = Recurse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 5553, 5560);
return return_v;
}


string
f_1182_5686_5736()
{
var return_v = HelpDisplayStrings.CannotSpecifyRecurseWithoutPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 5686, 5736);
return return_v;
}


string
f_1182_5668_5737(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 5668, 5737);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1182_5644_5738(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 5644, 5738);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1182_5787_5800(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 5787, 5800);
return return_v;
}


int
f_1182_5765_5801(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 5765, 5801);
return 0;
}


Microsoft.PowerShell.Commands.ModuleSpecification[]
f_1182_5932_5952()
{
var return_v = FullyQualifiedModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 5932, 5952);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1182_6062_6069()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 6062, 6069);
return return_v;
}


System.Management.Automation.HelpSystem
f_1182_6062_6080(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 6062, 6080);
return return_v;
}


System.Collections.ArrayList
f_1182_6062_6094(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 6062, 6094);
return return_v;
}


int
f_1182_6252_6268(System.Management.Automation.HelpProvider
this_param)
{
this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 6252, 6268);
return 0;
}


System.Collections.ArrayList
f_1182_6062_6094_I(System.Collections.ArrayList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 6062, 6094);
return return_v;
}


string
f_1182_6414_6464()
{
var return_v = HelpDisplayStrings.UpdateProgressActivityForModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 6414, 6464);
return return_v;
}


string
f_1182_6466_6509()
{
var return_v = HelpDisplayStrings.UpdateProgressInstalling;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 6466, 6509);
return return_v;
}


System.Management.Automation.ProgressRecord
f_1182_6383_6510(int
activityId,string
activity,string
statusDescription)
{
var return_v = new System.Management.Automation.ProgressRecord( activityId, activity, statusDescription);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 6383, 6510);
return return_v;
}


int
f_1182_6651_6674(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,System.Management.Automation.ProgressRecord
progressRecord)
{
this_param.WriteProgress( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 6651, 6674);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,4708,6701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,4708,6701);
}
		}

internal override bool ProcessModuleWithCulture(UpdatableHelpModuleInfo module, string culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,7024,20864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7144,7185);

UpdatableHelpInfo 
currentHelpInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7199,7236);

UpdatableHelpInfo 
newHelpInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7250,7276);

string 
helpInfoUri = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7292,7330);

string 
moduleBase = f_1182_7312_7329(module)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7346,7519) || true) && (f_1182_7350_7360(this)== UpdateHelpScope.CurrentUser)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,7346,7519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7425,7504);

moduleBase = f_1182_7438_7503(moduleBase, f_1182_7485_7502(module));
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,7346,7519);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7669,7834);

string 
xml = f_1182_7682_7833(this, f_1182_7745_7808(f_1182_7745_7762(f_1182_7745_7757()), moduleBase, f_1182_7783_7807(module)), null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,7850,8569) || true) && (xml != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,7850,8569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,8051,8554);

currentHelpInfo = f_1182_8069_8553(_helpSystem, xml, f_1182_8101_8118(module), f_1182_8120_8137(module), currentCulture: null, pathOverride: null, verbose: false, shouldResolveUri: false, ignoreValidationException: _force);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,7850,8569);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,8629,8840) || true) && (!_alreadyCheckedOncePerDayPerModule &&(DynAbs.Tracing.TraceSender.Expression_True(1182, 8633, 8779)&&!f_1182_8673_8779(this, f_1182_8698_8715(module), moduleBase, f_1182_8729_8753(module), DateTime.UtcNow, _force)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,8629,8840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,8813,8825);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,8629,8840);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,8856,8898);

_alreadyCheckedOncePerDayPerModule = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,8914,12771) || true) && (_path != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,8914,12771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,8965,9011);

UpdatableHelpSystemDrive 
helpInfoDrive = null
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9073,9133);

Collection<string> 
resolvedPaths = f_1182_9108_9132()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9209,10773);
foreach(string path in f_1182_9233_9238_I(_path) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,9209,10773);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9288,9605) || true) && (f_1182_9292_9318(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,9288,9605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9376,9479);

PSArgumentException 
e = f_1182_9400_9478(f_1182_9424_9477(f_1182_9442_9476()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9509,9535);

f_1182_9509_9534(this, f_1182_9520_9533(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9565,9578);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,9288,9605);
}

                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9693,9718);

string 
sourcePath = path
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9750,10020) || true) && (_credential != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,9750,10020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9839,9926);

UpdatableHelpSystemDrive 
drive = f_1182_9872_9925(this, path, _credential)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,9960,9989);

sourcePath = f_1182_9973_9988(drive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,9750,10020);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,10111,10313);
foreach(string tempPath in f_1182_10139_10188_I(f_1182_10139_10188(this, sourcePath, _recurse, _isLiteralPath)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,10111,10313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,10254,10282);

f_1182_10254_10281(                                resolvedPaths, tempPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,10111,10313);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1182,1,203);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1182,1,203);
}                        }
                        catch (System.Management.Automation.DriveNotFoundException e)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1182,10366,10560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,10484,10533);

f_1182_10484_10532(this, path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1182,10366,10560);
                        }
                        catch (ItemNotFoundException e)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1182,10586,10750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,10674,10723);

f_1182_10674_10722(this, path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1182,10586,10750);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,9209,10773);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1182,1,1565);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1182,1,1565);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,10797,10910) || true) && (f_1182_10801_10820(resolvedPaths)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,10797,10910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,10875,10887);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,10797,10910);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,11001,11783);
foreach(string resolvedPath in f_1182_11033_11046_I(resolvedPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,11001,11783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,11096,11183);

string 
literalPath = f_1182_11117_11182(f_1182_11117_11134(f_1182_11117_11129()), resolvedPath, f_1182_11157_11181(module))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,11211,11288);

xml = f_1182_11217_11287(this, literalPath, _credential);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,11316,11760) || true) && (xml != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,11316,11760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,11389,11640);

newHelpInfo = f_1182_11403_11639(_helpSystem, xml, f_1182_11435_11452(module), f_1182_11454_11471(module), culture, resolvedPath, verbose: false, shouldResolveUri: true, ignoreValidationException: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,11670,11697);

helpInfoUri = resolvedPath;
DynAbs.Tracing.TraceSender.TraceBreak(1182,11727,11733);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,11316,11760);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,11001,11783);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1182,1,783);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1182,1,783);
}                }
                catch (Exception e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1182,11820,12139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,11880,12120);

throw f_1182_11886_12119("UnableToRetrieveHelpInfoXml", f_1182_11975_12049(f_1182_11993_12039(), culture), ErrorCategory.ResourceUnavailable, null, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1182,11820,12139);
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1182,12157,12346);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,12205,12327) || true) && (helpInfoDrive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,12205,12327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,12280,12304);

f_1182_12280_12303(                        helpInfoDrive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,12205,12327);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1182,12157,12346);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,8914,12771);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,8914,12771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,12465,12532);

helpInfoUri = f_1182_12479_12531(f_1182_12479_12519(_helpSystem, module, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,12550,12602);

string 
uri = helpInfoUri + f_1182_12577_12601(module)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,12622,12756);

newHelpInfo = f_1182_12636_12755(_helpSystem, UpdatableHelpCommandType.UpdateHelpCommand, uri, f_1182_12709_12726(module), f_1182_12728_12745(module), culture);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,8914,12771);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,12787,13094) || true) && (newHelpInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,12787,13094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,12844,13079);

throw f_1182_12850_13078("UnableToRetrieveHelpInfoXml", f_1182_12935_13009(f_1182_12953_12999(), culture), ErrorCategory.ResourceUnavailable, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,12787,13094);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,13110,13133);

bool 
installed = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,13149,20820);
foreach(UpdatableHelpUri contentUri in f_1182_13189_13225_I(f_1182_13189_13225(newHelpInfo)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,13149,20820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,13259,13377);

Version 
currentHelpVersion = (DynAbs.Tracing.TraceSender.Conditional_F1(1182, 13288, 13313)||(((currentHelpInfo != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1182, 13316, 13369))||DynAbs.Tracing.TraceSender.Conditional_F3(1182, 13372, 13376)))?f_1182_13316_13369(currentHelpInfo, f_1182_13350_13368(contentUri)):null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,13395,13804);

string 
updateHelpShouldProcessAction = f_1182_13434_13803(f_1182_13448_13476(), f_1182_13499_13554(), f_1182_13577_13594(module), (DynAbs.Tracing.TraceSender.Conditional_F1(1182, 13617, 13645)||((                    (currentHelpVersion != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1182, 13648, 13677))||DynAbs.Tracing.TraceSender.Conditional_F3(1182, 13680, 13689)))?f_1182_13648_13677(currentHelpVersion):"0.0.0.0", f_1182_13712_13761(                    newHelpInfo, f_1182_13742_13760(contentUri)), f_1182_13784_13802(contentUri))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,13822,13961) || true) && (!f_1182_13827_13891(this, updateHelpShouldProcessAction, "Update-Help"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,13822,13961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,13933,13942);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,13822,13961);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,13981,14447) || true) && (f_1182_13985_14023(moduleBase)&&(DynAbs.Tracing.TraceSender.Expression_True(1182, 13985, 14053)&&(!f_1182_14029_14052())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,13981,14447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,14095,14173);

string 
message = f_1182_14112_14172(f_1182_14130_14171())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,14195,14393);

f_1182_14195_14392(this, f_1182_14212_14229(module), null, f_1182_14237_14391("UpdatableHelpSystemRequiresElevation", message, ErrorCategory.InvalidOperation, null, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,14415,14428);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,13981,14447);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,14467,20805) || true) && (!f_1182_14472_14571(this, module, (DynAbs.Tracing.TraceSender.Conditional_F1(1182, 14498, 14504)||((_force &&DynAbs.Tracing.TraceSender.Conditional_F2(1182, 14507, 14511))||DynAbs.Tracing.TraceSender.Conditional_F3(1182, 14514, 14529)))?null :currentHelpInfo, newHelpInfo, f_1182_14544_14562(contentUri), _force))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,14467,20805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,14613,14866);

f_1182_14613_14865(this, f_1182_14626_14864(f_1182_14644_14693(), f_1182_14695_14712(module), f_1182_14714_14762(), f_1182_14789_14812(f_1182_14789_14807(contentUri)), f_1182_14814_14863(newHelpInfo, f_1182_14844_14862(contentUri))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,14890,14907);

installed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,14929,14938);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,14467,20805);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,14467,20805);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,15072,15154);

f_1182_15072_15153(helpInfoUri != null, "If we are here, helpInfoUri must not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,15182,15229);

string 
helpContentUri = f_1182_15206_15228(contentUri)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,15255,15370);

string 
xsdPath = f_1182_15272_15369(f_1182_15272_15289(f_1182_15272_15284()), f_1182_15298_15339(f_1182_15323_15338(f_1182_15323_15330())), "Schemas\\PSMaml\\maml.xsd")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,15495,15551);

Collection<string> 
destPaths = f_1182_15526_15550()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,15579,15735) || true) && (!f_1182_15584_15612(moduleBase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,15579,15735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,15670,15708);

f_1182_15670_15707(moduleBase);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,15579,15735);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,15763,15789);

f_1182_15763_15788(
                        destPaths, moduleBase);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,16225,16259);

Collection<string> 
filesInstalled
=default(Collection<string>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,16287,19693) || true) && (f_1182_16291_16323(helpContentUri))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,16287,19693);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,16381,19032) || true) && (_credential != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,16381,19032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,16470,16541);

string 
helpContentName = f_1182_16495_16540(module, f_1182_16521_16539(contentUri))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,16575,16693);

string 
tempContentPath = f_1182_16600_16692(f_1182_16613_16631(), f_1182_16633_16691(f_1182_16666_16690()))
;

                                try
                                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,16805,18057);
using(UpdatableHelpSystemDrive 
drive = f_1182_16845_16908(this, helpContentUri, _credential)
)                                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,16990,17204) || true) && (!f_1182_16995_17028(tempContentPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,16990,17204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,17118,17161);

f_1182_17118_17160(tempContentPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,16990,17204);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,17248,17487);

f_1182_17248_17486(f_1182_17248_17267(f_1182_17248_17262()), new string[1] { f_1182_17289_17335(f_1182_17302_17317(drive), helpContentName)}, f_1182_17384_17430(tempContentPath, helpContentName), false, CopyContainers.CopyTargetContainer, true, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,17581,18018);

f_1182_17581_18017(
                                        // Local
                                        _helpSystem, UpdatableHelpCommandType.UpdateHelpCommand, f_1182_17656_17663(), tempContentPath, destPaths, f_1182_17738_17783(module, f_1182_17764_17782(contentUri)), f_1182_17830_17922(f_1182_17843_17861(), f_1182_17863_17921(f_1182_17896_17920())), f_1182_17969_17987(contentUri), xsdPath, out filesInstalled);
DynAbs.Tracing.TraceSender.TraceExitUsing(1182,16805,18057);
                                    }
                                }
                                catch (Exception e)
                                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1182,18126,18459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,18218,18424);

throw f_1182_18224_18423("HelpContentNotFound", f_1182_18280_18337(f_1182_18298_18336()), ErrorCategory.ResourceUnavailable, null, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1182,18126,18459);
                                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,16381,19032);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,16381,19032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,18589,19001);

f_1182_18589_19000(                                _helpSystem, UpdatableHelpCommandType.UpdateHelpCommand, f_1182_18664_18671(), helpContentUri, destPaths, f_1182_18737_18782(module, f_1182_18763_18781(contentUri)), f_1182_18821_18913(f_1182_18834_18852(), f_1182_18854_18912(f_1182_18887_18911())), f_1182_18952_18970(contentUri), xsdPath, out filesInstalled);
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,16381,19032);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,16287,19693);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,16287,19693);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,19253,19666) || true) && (!f_1182_19258_19508(_helpSystem, UpdatableHelpCommandType.UpdateHelpCommand, f_1182_19344_19351(), destPaths, f_1182_19397_19442(module, f_1182_19423_19441(contentUri)), f_1182_19444_19462(contentUri), helpContentUri, xsdPath, out filesInstalled))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,19253,19666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,19574,19592);

installed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,19626,19635);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,19253,19666);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,16287,19693);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,19721,19966);

f_1182_19721_19965(
                        _helpSystem, f_1182_19750_19767(module), f_1182_19769_19786(module), f_1182_19788_19813(newHelpInfo), f_1182_19815_19838(f_1182_19815_19833(contentUri)), f_1182_19840_19889(newHelpInfo, f_1182_19870_19888(contentUri)), moduleBase, f_1182_19932_19956(module), _force);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,19994,20443);
foreach(string fileInstalled in f_1182_20027_20041_I(filesInstalled) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1182,19994,20443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,20099,20416);

f_1182_20099_20415(this, f_1182_20112_20414(f_1182_20130_20179(), f_1182_20181_20198(module), f_1182_20233_20304(f_1182_20251_20288(), fileInstalled), f_1182_20306_20329(f_1182_20306_20324(contentUri)), f_1182_20364_20413(                                newHelpInfo, f_1182_20394_20412(contentUri))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,19994,20443);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1182,1,450);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1182,1,450);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,20471,20541);

f_1182_20471_20540(this, f_1182_20482_20539(f_1182_20500_20538()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,20569,20586);

installed = true;
                    }
                    catch (Exception e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1182,20631,20786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,20699,20763);

f_1182_20699_20762(this, f_1182_20716_20733(module), f_1182_20735_20758(f_1182_20735_20753(contentUri)), e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1182,20631,20786);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,14467,20805);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1182,13149,20820);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1182,1,7672);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1182,1,7672);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,20836,20853);

return installed;
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,7024,20864);

string
f_1182_7312_7329(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 7312, 7329);
return return_v;
}


Microsoft.PowerShell.Commands.UpdateHelpScope
f_1182_7350_7360(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param)
{
var return_v = this_param.Scope ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 7350, 7360);
return return_v;
}


string
f_1182_7485_7502(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 7485, 7502);
return return_v;
}


string
f_1182_7438_7503(string
moduleBase,string
moduleName)
{
var return_v = HelpUtils.GetModuleBaseForUserHelp( moduleBase, moduleName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 7438, 7503);
return return_v;
}


System.Management.Automation.SessionState
f_1182_7745_7757()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 7745, 7757);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1182_7745_7762(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 7745, 7762);
return return_v;
}


string
f_1182_7783_7807(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 7783, 7807);
return return_v;
}


string
f_1182_7745_7808(System.Management.Automation.PathIntrinsics
this_param,string
parent,string
child)
{
var return_v = this_param.Combine( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 7745, 7808);
return return_v;
}


string
f_1182_7682_7833(Microsoft.PowerShell.Commands.UpdateHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = UpdatableHelpSystem.LoadStringFromPath( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 7682, 7833);
return return_v;
}


string
f_1182_8101_8118(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 8101, 8118);
return return_v;
}


System.Guid
f_1182_8120_8137(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 8120, 8137);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1182_8069_8553(System.Management.Automation.Help.UpdatableHelpSystem
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 8069, 8553);
return return_v;
}


string
f_1182_8698_8715(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 8698, 8715);
return return_v;
}


string
f_1182_8729_8753(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 8729, 8753);
return return_v;
}


bool
f_1182_8673_8779(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
moduleName,string
path,string
filename,System.DateTime
time,bool
force)
{
var return_v = this_param.CheckOncePerDayPerModule( moduleName, path, filename, time, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 8673, 8779);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1182_9108_9132()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 9108, 9132);
return return_v;
}


bool
f_1182_9292_9318(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 9292, 9318);
return return_v;
}


string
f_1182_9442_9476()
{
var return_v = HelpDisplayStrings.PathNullOrEmpty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 9442, 9476);
return return_v;
}


string
f_1182_9424_9477(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 9424, 9477);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1182_9400_9478(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 9400, 9478);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1182_9520_9533(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 9520, 9533);
return return_v;
}


int
f_1182_9509_9534(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 9509, 9534);
return 0;
}


System.Management.Automation.Help.UpdatableHelpSystemDrive
f_1182_9872_9925(Microsoft.PowerShell.Commands.UpdateHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemDrive( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 9872, 9925);
return return_v;
}


string
f_1182_9973_9988(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 9973, 9988);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1182_10139_10188(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
path,bool
recurse,bool
isLiteralPath)
{
var return_v = this_param.ResolvePath( path, recurse, isLiteralPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 10139, 10188);
return return_v;
}


int
f_1182_10254_10281(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 10254, 10281);
return 0;
}


System.Collections.Generic.IEnumerable<string>
f_1182_10139_10188_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 10139, 10188);
return return_v;
}


int
f_1182_10484_10532(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
path,System.Management.Automation.DriveNotFoundException
e)
{
this_param.ThrowPathMustBeValidContainersException( path, (System.Exception)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 10484, 10532);
return 0;
}


int
f_1182_10674_10722(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
path,System.Management.Automation.ItemNotFoundException
e)
{
this_param.ThrowPathMustBeValidContainersException( path, (System.Exception)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 10674, 10722);
return 0;
}


string[]
f_1182_9233_9238_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 9233, 9238);
return return_v;
}


int
f_1182_10801_10820(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 10801, 10820);
return return_v;
}


System.Management.Automation.SessionState
f_1182_11117_11129()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 11117, 11129);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1182_11117_11134(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 11117, 11134);
return return_v;
}


string
f_1182_11157_11181(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 11157, 11181);
return return_v;
}


string
f_1182_11117_11182(System.Management.Automation.PathIntrinsics
this_param,string
parent,string
child)
{
var return_v = this_param.Combine( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 11117, 11182);
return return_v;
}


string
f_1182_11217_11287(Microsoft.PowerShell.Commands.UpdateHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = UpdatableHelpSystem.LoadStringFromPath( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 11217, 11287);
return return_v;
}


string
f_1182_11435_11452(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 11435, 11452);
return return_v;
}


System.Guid
f_1182_11454_11471(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 11454, 11471);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1182_11403_11639(System.Management.Automation.Help.UpdatableHelpSystem
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
var return_v = this_param.CreateHelpInfo( xml, moduleName, moduleGuid, currentCulture, pathOverride, verbose: verbose, shouldResolveUri: shouldResolveUri, ignoreValidationException: ignoreValidationException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 11403, 11639);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1182_11033_11046_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 11033, 11046);
return return_v;
}


string
f_1182_11993_12039()
{
var return_v = HelpDisplayStrings.UnableToRetrieveHelpInfoXml;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 11993, 12039);
return return_v;
}


string
f_1182_11975_12049(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 11975, 12049);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1182_11886_12119(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 11886, 12119);
return return_v;
}


int
f_1182_12280_12303(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 12280, 12303);
return 0;
}


System.Management.Automation.Help.UpdatableHelpUri
f_1182_12479_12519(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpModuleInfo
module,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetHelpInfoUri( module, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 12479, 12519);
return return_v;
}


string
f_1182_12479_12531(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.ResolvedUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 12479, 12531);
return return_v;
}


string
f_1182_12577_12601(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 12577, 12601);
return return_v;
}


string
f_1182_12709_12726(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 12709, 12726);
return return_v;
}


System.Guid
f_1182_12728_12745(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 12728, 12745);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1182_12636_12755(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,string
uri,string
moduleName,System.Guid
moduleGuid,string
culture)
{
var return_v = this_param.GetHelpInfo( commandType, uri, moduleName, moduleGuid, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 12636, 12755);
return return_v;
}


string
f_1182_12953_12999()
{
var return_v = HelpDisplayStrings.UnableToRetrieveHelpInfoXml;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 12953, 12999);
return return_v;
}


string
f_1182_12935_13009(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 12935, 13009);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1182_12850_13078(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 12850, 13078);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
f_1182_13189_13225(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.HelpContentUriCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 13189, 13225);
return return_v;
}


System.Globalization.CultureInfo
f_1182_13350_13368(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 13350, 13368);
return return_v;
}


System.Version
f_1182_13316_13369(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 13316, 13369);
return return_v;
}


System.Globalization.CultureInfo
f_1182_13448_13476()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 13448, 13476);
return return_v;
}


string
f_1182_13499_13554()
{
var return_v =                     HelpDisplayStrings.UpdateHelpShouldProcessActionMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 13499, 13554);
return return_v;
}


string
f_1182_13577_13594(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 13577, 13594);
return return_v;
}


string
f_1182_13648_13677(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 13648, 13677);
return return_v;
}


System.Globalization.CultureInfo
f_1182_13742_13760(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 13742, 13760);
return return_v;
}


System.Version
f_1182_13712_13761(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 13712, 13761);
return return_v;
}


System.Globalization.CultureInfo
f_1182_13784_13802(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 13784, 13802);
return return_v;
}


string
f_1182_13434_13803(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 13434, 13803);
return return_v;
}


bool
f_1182_13827_13891(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 13827, 13891);
return return_v;
}


bool
f_1182_13985_14023(string
filePath)
{
var return_v = Utils.IsUnderProductFolder( filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 13985, 14023);
return return_v;
}


bool
f_1182_14029_14052()
{
var return_v = Utils.IsAdministrator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14029, 14052);
return return_v;
}


string
f_1182_14130_14171()
{
var return_v = HelpErrors.UpdatableHelpRequiresElevation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14130, 14171);
return return_v;
}


string
f_1182_14112_14172(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14112, 14172);
return return_v;
}


string
f_1182_14212_14229(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14212, 14229);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1182_14237_14391(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14237, 14391);
return return_v;
}


int
f_1182_14195_14392(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
moduleName,string
culture,System.Management.Automation.Help.UpdatableHelpSystemException
e)
{
this_param.ProcessException( moduleName, culture, (System.Exception)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14195, 14392);
return 0;
}


System.Globalization.CultureInfo
f_1182_14544_14562(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14544, 14562);
return return_v;
}


bool
f_1182_14472_14571(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,System.Management.Automation.Help.UpdatableHelpModuleInfo
module,System.Management.Automation.Help.UpdatableHelpInfo
currentHelpInfo,System.Management.Automation.Help.UpdatableHelpInfo
newHelpInfo,System.Globalization.CultureInfo
culture,bool
force)
{
var return_v = this_param.IsUpdateNecessary( module, currentHelpInfo, newHelpInfo, culture, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14472, 14571);
return return_v;
}


string
f_1182_14644_14693()
{
var return_v = HelpDisplayStrings.SuccessfullyUpdatedHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14644, 14693);
return return_v;
}


string
f_1182_14695_14712(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14695, 14712);
return return_v;
}


string
f_1182_14714_14762()
{
var return_v = HelpDisplayStrings.NewestContentAlreadyInstalled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14714, 14762);
return return_v;
}


System.Globalization.CultureInfo
f_1182_14789_14807(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14789, 14807);
return return_v;
}


string
f_1182_14789_14812(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14789, 14812);
return return_v;
}


System.Globalization.CultureInfo
f_1182_14844_14862(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 14844, 14862);
return return_v;
}


System.Version
f_1182_14814_14863(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14814, 14863);
return return_v;
}


string
f_1182_14626_14864(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14626, 14864);
return return_v;
}


int
f_1182_14613_14865(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 14613, 14865);
return 0;
}


int
f_1182_15072_15153(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 15072, 15153);
return 0;
}


string
f_1182_15206_15228(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.ResolvedUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 15206, 15228);
return return_v;
}


System.Management.Automation.SessionState
f_1182_15272_15284()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 15272, 15284);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1182_15272_15289(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 15272, 15289);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1182_15323_15330()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 15323, 15330);
return return_v;
}


string
f_1182_15323_15338(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ShellID;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 15323, 15338);
return return_v;
}


string
f_1182_15298_15339(string
shellId)
{
var return_v = Utils.GetApplicationBase( shellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 15298, 15339);
return return_v;
}


string
f_1182_15272_15369(System.Management.Automation.PathIntrinsics
this_param,string
parent,string
child)
{
var return_v = this_param.Combine( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 15272, 15369);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1182_15526_15550()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 15526, 15550);
return return_v;
}


bool
f_1182_15584_15612(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 15584, 15612);
return return_v;
}


System.IO.DirectoryInfo
f_1182_15670_15707(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 15670, 15707);
return return_v;
}


int
f_1182_15763_15788(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 15763, 15788);
return 0;
}


bool
f_1182_16291_16323(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16291, 16323);
return return_v;
}


System.Globalization.CultureInfo
f_1182_16521_16539(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 16521, 16539);
return return_v;
}


string
f_1182_16495_16540(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetHelpContentName( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16495, 16540);
return return_v;
}


string
f_1182_16613_16631()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16613, 16631);
return return_v;
}


string
f_1182_16666_16690()
{
var return_v = Path.GetRandomFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16666, 16690);
return return_v;
}


string?
f_1182_16633_16691(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16633, 16691);
return return_v;
}


string
f_1182_16600_16692(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16600, 16692);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemDrive
f_1182_16845_16908(Microsoft.PowerShell.Commands.UpdateHelpCommand
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemDrive( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16845, 16908);
return return_v;
}


bool
f_1182_16995_17028(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 16995, 17028);
return return_v;
}


System.IO.DirectoryInfo
f_1182_17118_17160(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17118, 17160);
return return_v;
}


System.Management.Automation.ProviderIntrinsics
f_1182_17248_17262()
{
var return_v = InvokeProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 17248, 17262);
return return_v;
}


System.Management.Automation.ItemCmdletProviderIntrinsics
f_1182_17248_17267(System.Management.Automation.ProviderIntrinsics
this_param)
{
var return_v = this_param.Item;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 17248, 17267);
return return_v;
}


string
f_1182_17302_17317(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 17302, 17317);
return return_v;
}


string
f_1182_17289_17335(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17289, 17335);
return return_v;
}


string
f_1182_17384_17430(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17384, 17430);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1182_17248_17486(System.Management.Automation.ItemCmdletProviderIntrinsics
this_param,string[]
path,string
destinationPath,bool
recurse,System.Management.Automation.CopyContainers
copyContainers,bool
force,bool
literalPath)
{
var return_v = this_param.Copy( path, destinationPath, recurse, copyContainers, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17248, 17486);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1182_17656_17663()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 17656, 17663);
return return_v;
}


System.Globalization.CultureInfo
f_1182_17764_17782(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 17764, 17782);
return return_v;
}


string
f_1182_17738_17783(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetHelpContentName( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17738, 17783);
return return_v;
}


string
f_1182_17843_17861()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17843, 17861);
return return_v;
}


string
f_1182_17896_17920()
{
var return_v = Path.GetRandomFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17896, 17920);
return return_v;
}


string?
f_1182_17863_17921(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17863, 17921);
return return_v;
}


string
f_1182_17830_17922(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17830, 17922);
return return_v;
}


System.Globalization.CultureInfo
f_1182_17969_17987(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 17969, 17987);
return return_v;
}


int
f_1182_17581_18017(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,System.Management.Automation.ExecutionContext
context,string
sourcePath,System.Collections.ObjectModel.Collection<string>
destPaths,string
fileName,string
tempPath,System.Globalization.CultureInfo
culture,string
xsdPath,out System.Collections.ObjectModel.Collection<string>
installed)
{
this_param.InstallHelpContent( commandType, context, sourcePath, destPaths, fileName, tempPath, culture, xsdPath, out installed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 17581, 18017);
return 0;
}


string
f_1182_18298_18336()
{
var return_v = HelpDisplayStrings.HelpContentNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 18298, 18336);
return return_v;
}


string
f_1182_18280_18337(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18280, 18337);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1182_18224_18423(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18224, 18423);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1182_18664_18671()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 18664, 18671);
return return_v;
}


System.Globalization.CultureInfo
f_1182_18763_18781(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 18763, 18781);
return return_v;
}


string
f_1182_18737_18782(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetHelpContentName( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18737, 18782);
return return_v;
}


string
f_1182_18834_18852()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18834, 18852);
return return_v;
}


string
f_1182_18887_18911()
{
var return_v = Path.GetRandomFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18887, 18911);
return return_v;
}


string?
f_1182_18854_18912(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18854, 18912);
return return_v;
}


string
f_1182_18821_18913(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18821, 18913);
return return_v;
}


System.Globalization.CultureInfo
f_1182_18952_18970(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 18952, 18970);
return return_v;
}


int
f_1182_18589_19000(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,System.Management.Automation.ExecutionContext
context,string
sourcePath,System.Collections.ObjectModel.Collection<string>
destPaths,string
fileName,string
tempPath,System.Globalization.CultureInfo
culture,string
xsdPath,out System.Collections.ObjectModel.Collection<string>
installed)
{
this_param.InstallHelpContent( commandType, context, sourcePath, destPaths, fileName, tempPath, culture, xsdPath, out installed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 18589, 19000);
return 0;
}


System.Management.Automation.ExecutionContext
f_1182_19344_19351()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19344, 19351);
return return_v;
}


System.Globalization.CultureInfo
f_1182_19423_19441(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19423, 19441);
return return_v;
}


string
f_1182_19397_19442(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetHelpContentName( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 19397, 19442);
return return_v;
}


System.Globalization.CultureInfo
f_1182_19444_19462(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19444, 19462);
return return_v;
}


bool
f_1182_19258_19508(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,System.Management.Automation.ExecutionContext
context,System.Collections.ObjectModel.Collection<string>
destPaths,string
fileName,System.Globalization.CultureInfo
culture,string
helpContentUri,string
xsdPath,out System.Collections.ObjectModel.Collection<string>
installed)
{
var return_v = this_param.DownloadAndInstallHelpContent( commandType, context, destPaths, fileName, culture, helpContentUri, xsdPath, out installed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 19258, 19508);
return return_v;
}


string
f_1182_19750_19767(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19750, 19767);
return return_v;
}


System.Guid
f_1182_19769_19786(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19769, 19786);
return return_v;
}


string
f_1182_19788_19813(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.UnresolvedUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19788, 19813);
return return_v;
}


System.Globalization.CultureInfo
f_1182_19815_19833(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19815, 19833);
return return_v;
}


string
f_1182_19815_19838(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19815, 19838);
return return_v;
}


System.Globalization.CultureInfo
f_1182_19870_19888(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 19870, 19888);
return return_v;
}


System.Version
f_1182_19840_19889(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 19840, 19889);
return return_v;
}


string
f_1182_19932_19956(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.GetHelpInfoName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 19932, 19956);
return return_v;
}


int
f_1182_19721_19965(System.Management.Automation.Help.UpdatableHelpSystem
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 19721, 19965);
return 0;
}


string
f_1182_20130_20179()
{
var return_v = HelpDisplayStrings.SuccessfullyUpdatedHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20130, 20179);
return return_v;
}


string
f_1182_20181_20198(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20181, 20198);
return return_v;
}


string
f_1182_20251_20288()
{
var return_v = HelpDisplayStrings.UpdatedHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20251, 20288);
return return_v;
}


string
f_1182_20233_20304(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20233, 20304);
return return_v;
}


System.Globalization.CultureInfo
f_1182_20306_20324(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20306, 20324);
return return_v;
}


string
f_1182_20306_20329(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20306, 20329);
return return_v;
}


System.Globalization.CultureInfo
f_1182_20394_20412(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20394, 20412);
return return_v;
}


System.Version
f_1182_20364_20413(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20364, 20413);
return return_v;
}


string
f_1182_20112_20414(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20112, 20414);
return return_v;
}


int
f_1182_20099_20415(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20099, 20415);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1182_20027_20041_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20027, 20041);
return return_v;
}


string
f_1182_20500_20538()
{
var return_v = HelpDisplayStrings.UpdateHelpCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20500, 20538);
return return_v;
}


string
f_1182_20482_20539(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20482, 20539);
return return_v;
}


int
f_1182_20471_20540(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
message)
{
this_param.LogMessage( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20471, 20540);
return 0;
}


string
f_1182_20716_20733(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20716, 20733);
return return_v;
}


System.Globalization.CultureInfo
f_1182_20735_20753(System.Management.Automation.Help.UpdatableHelpUri
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20735, 20753);
return return_v;
}


string
f_1182_20735_20758(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 20735, 20758);
return return_v;
}


int
f_1182_20699_20762(Microsoft.PowerShell.Commands.UpdateHelpCommand
this_param,string
moduleName,string
culture,System.Exception
e)
{
this_param.ProcessException( moduleName, culture, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 20699, 20762);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
f_1182_13189_13225_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 13189, 13225);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,7024,20864);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,7024,20864);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ThrowPathMustBeValidContainersException(string path, Exception e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1182,21059,21386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1182,21162,21375);

throw f_1182_21168_21374("PathMustBeValidContainers", f_1182_21247_21316(f_1182_21265_21309(), path), ErrorCategory.InvalidArgument, null, e);
DynAbs.Tracing.TraceSender.TraceExitMethod(1182,21059,21386);

string
f_1182_21265_21309()
{
var return_v = HelpDisplayStrings.PathMustBeValidContainers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1182, 21265, 21309);
return return_v;
}


string
f_1182_21247_21316(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 21247, 21316);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1182_21168_21374(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1182, 21168, 21374);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1182,21059,21386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,21059,21386);
}
		}

static UpdateHelpCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1182,537,21415);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1182,537,21415);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1182,537,21415);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1182,537,21415);

static System.Management.Automation.Help.UpdatableHelpCommandType
f_1182_959_1001_C(System.Management.Automation.Help.UpdatableHelpCommandType
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1182, 925, 1024);
return return_v;
}

}
}
