// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
[CmdletProvider(FunctionProvider.ProviderName, ProviderCapabilities.ShouldProcess)]
    [OutputType(typeof(FunctionInfo), ProviderCmdlet = ProviderCmdlet.SetItem)]
    [OutputType(typeof(FunctionInfo), ProviderCmdlet = ProviderCmdlet.RenameItem)]
    [OutputType(typeof(FunctionInfo), ProviderCmdlet = ProviderCmdlet.CopyItem)]
    [OutputType(typeof(FunctionInfo), ProviderCmdlet = ProviderCmdlet.GetChildItem)]
    [OutputType(typeof(FunctionInfo), ProviderCmdlet = ProviderCmdlet.GetItem)]
    [OutputType(typeof(FunctionInfo), ProviderCmdlet = ProviderCmdlet.NewItem)]
    public sealed class FunctionProvider : SessionStateProviderBase
{
public const string 
ProviderName = "Function"
;

public FunctionProvider()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1195,1573,1620);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1195,1573,1620);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,1573,1620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,1573,1620);
}
		}

protected override Collection<PSDriveInfo> InitializeDefaultDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,1941,2514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,2034,2100);

string 
description = f_1195_2055_2099()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,2116,2356);

PSDriveInfo 
functionDrive =
f_1195_2161_2355(DriveNames.FunctionDrive, f_1195_2246_2258(), string.Empty, description, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,2372,2435);

Collection<PSDriveInfo> 
drives = f_1195_2405_2434()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,2449,2475);

f_1195_2449_2474(            drives, functionDrive);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,2489,2503);

return drives;
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,1941,2514);

string
f_1195_2055_2099()
{
var return_v = SessionStateStrings.FunctionDriveDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 2055, 2099);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1195_2246_2258()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 2246, 2258);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1195_2161_2355(string
name,System.Management.Automation.ProviderInfo
provider,string
root,string
description,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.PSDriveInfo( name, provider, root, description, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 2161, 2355);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1195_2405_2434()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 2405, 2434);
return return_v;
}


int
f_1195_2449_2474(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 2449, 2474);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,1941,2514);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,1941,2514);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override object NewItemDynamicParameters(string path, string type, object newItemValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,3134,3314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,3256,3303);

return f_1195_3263_3302();
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,3134,3314);

Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters
f_1195_3263_3302()
{
var return_v = new Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 3263, 3302);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,3134,3314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,3134,3314);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override object SetItemDynamicParameters(string path, object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,3760,3920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,3862,3909);

return f_1195_3869_3908();
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,3760,3920);

Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters
f_1195_3869_3908()
{
var return_v = new Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 3869, 3908);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,3760,3920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,3760,3920);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override object GetSessionStateItem(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,4316,4666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,4398,4528);

f_1195_4398_4527(!f_1195_4440_4466(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,4544,4623);

CommandInfo 
function = f_1195_4567_4622(f_1195_4567_4588(f_1195_4567_4579()), name, f_1195_4607_4621(f_1195_4607_4614()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,4639,4655);

return function;
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,4316,4666);

bool
f_1195_4440_4466(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 4440, 4466);
return return_v;
}


int
f_1195_4398_4527(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 4398, 4527);
return 0;
}


System.Management.Automation.SessionState
f_1195_4567_4579()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 4567, 4579);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_4567_4588(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 4567, 4588);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1195_4607_4614()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 4607, 4614);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1195_4607_4621(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 4607, 4621);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1195_4567_4622(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.GetFunction( name, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 4567, 4622);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,4316,4666);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,4316,4666);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override void SetSessionStateItem(string name, object value, bool writeItem)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,5176,9198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,5286,5416);

f_1195_5286_5415(!f_1195_5328_5354(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,5432,5558);

FunctionProviderDynamicParameters 
dynamicParameters =
f_1195_5503_5520()as FunctionProviderDynamicParameters
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,5574,5606);

CommandInfo 
modifiedItem = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,5622,5714);

bool 
dynamicParametersSpecified = dynamicParameters != null &&(DynAbs.Tracing.TraceSender.Expression_True(1195, 5656, 5713)&&f_1195_5685_5713(dynamicParameters))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,5730,9187) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,5730,9187);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6001,6430) || true) && (dynamicParametersSpecified)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6001,6430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6073,6127);

modifiedItem = (CommandInfo)f_1195_6101_6126(this, name);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6151,6300) || true) && (modifiedItem != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6151,6300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6225,6277);

f_1195_6225_6276(modifiedItem, f_1195_6250_6275(dynamicParameters));
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6151,6300);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6001,6430);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6001,6430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6382,6411);

f_1195_6382_6410(this, name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6001,6430);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,5730,9187);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,5730,9187);
{try {
do // false loop

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6496,8998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6635,6668);

PSObject 
pso = value as PSObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6690,6801) || true) && (pso != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6690,6801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6755,6778);

value = f_1195_6763_6777(pso);
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6690,6801);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6825,6877);

ScriptBlock 
scriptBlockValue = value as ScriptBlock
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6899,7527) || true) && (scriptBlockValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6899,7527);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6977,7470) || true) && (dynamicParametersSpecified)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6977,7470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7065,7227);

modifiedItem = f_1195_7080_7226(f_1195_7080_7101(f_1195_7080_7092()), name, scriptBlockValue, null, f_1195_7177_7202(dynamicParameters), f_1195_7204_7209(), f_1195_7211_7225(f_1195_7211_7218()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6977,7470);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,6977,7470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7341,7443);

modifiedItem = f_1195_7356_7442(f_1195_7356_7377(f_1195_7356_7368()), name, scriptBlockValue, null, f_1195_7420_7425(), f_1195_7427_7441(f_1195_7427_7434()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6977,7470);
}
DynAbs.Tracing.TraceSender.TraceBreak(1195,7498,7504);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6899,7527);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7551,7597);

FunctionInfo 
function = value as FunctionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7619,8115) || true) && (function != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,7619,8115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7689,7734);

ScopedItemOptions 
options = f_1195_7717_7733(function)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7762,7913) || true) && (dynamicParametersSpecified)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,7762,7913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7850,7886);

options = f_1195_7860_7885(dynamicParameters);
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,7762,7913);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,7941,8060);

modifiedItem = f_1195_7956_8059(f_1195_7956_7977(f_1195_7956_7968()), name, f_1195_7996_8016(function), function, options, f_1195_8037_8042(), f_1195_8044_8058(f_1195_8044_8051()));
DynAbs.Tracing.TraceSender.TraceBreak(1195,8086,8092);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,7619,8115);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,8139,8176);

string 
stringValue = value as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,8198,8890) || true) && (stringValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,8198,8890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,8271,8355);

ScriptBlock 
scriptBlock = f_1195_8297_8354(f_1195_8316_8340(f_1195_8316_8323()), stringValue)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,8383,8833) || true) && (dynamicParametersSpecified)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,8383,8833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,8471,8595);

modifiedItem = f_1195_8486_8594(f_1195_8486_8507(f_1195_8486_8498()), name, scriptBlock, null, f_1195_8545_8570(dynamicParameters), f_1195_8572_8577(), f_1195_8579_8593(f_1195_8579_8586()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,8383,8833);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,8383,8833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,8709,8806);

modifiedItem = f_1195_8724_8805(f_1195_8724_8745(f_1195_8724_8736()), name, scriptBlock, null, f_1195_8783_8788(), f_1195_8790_8804(f_1195_8790_8797()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,8383,8833);
}
DynAbs.Tracing.TraceSender.TraceBreak(1195,8861,8867);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,8198,8890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,8914,8964);

throw f_1195_8920_8963("value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,6496,8998);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,6496,8998) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1195,6496,8998);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1195,6496,8998);
}}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,9018,9172) || true) && (writeItem &&(DynAbs.Tracing.TraceSender.Expression_True(1195, 9022, 9055)&&modifiedItem != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,9018,9172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,9097,9153);

f_1195_9097_9152(this, modifiedItem, f_1195_9127_9144(modifiedItem), false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,9018,9172);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,5730,9187);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,5176,9198);

bool
f_1195_5328_5354(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 5328, 5354);
return return_v;
}


int
f_1195_5286_5415(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 5286, 5415);
return 0;
}


object
f_1195_5503_5520()
{
var return_v = DynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 5503, 5520);
return return_v;
}


bool
f_1195_5685_5713(Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters
this_param)
{
var return_v = this_param.OptionsSet;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 5685, 5713);
return return_v;
}


object
f_1195_6101_6126(Microsoft.PowerShell.Commands.FunctionProvider
this_param,string
name)
{
var return_v = this_param.GetSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 6101, 6126);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1195_6250_6275(Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 6250, 6275);
return return_v;
}


int
f_1195_6225_6276(System.Management.Automation.CommandInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
SetOptions( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 6225, 6276);
return 0;
}


int
f_1195_6382_6410(Microsoft.PowerShell.Commands.FunctionProvider
this_param,string
name)
{
this_param.RemoveSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 6382, 6410);
return 0;
}


object
f_1195_6763_6777(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 6763, 6777);
return return_v;
}


System.Management.Automation.SessionState
f_1195_7080_7092()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7080, 7092);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_7080_7101(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7080, 7101);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1195_7177_7202(Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7177, 7202);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1195_7204_7209()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7204, 7209);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1195_7211_7218()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7211, 7218);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1195_7211_7225(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7211, 7225);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1195_7080_7226(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.ScopedItemOptions
options,System.Management.Automation.SwitchParameter
force,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.SetFunction( name, function, originalFunction, options, (bool)force, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 7080, 7226);
return return_v;
}


System.Management.Automation.SessionState
f_1195_7356_7368()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7356, 7368);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_7356_7377(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7356, 7377);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1195_7420_7425()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7420, 7425);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1195_7427_7434()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7427, 7434);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1195_7427_7441(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7427, 7441);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1195_7356_7442(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.SwitchParameter
force,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.SetFunction( name, function, originalFunction, (bool)force, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 7356, 7442);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1195_7717_7733(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7717, 7733);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1195_7860_7885(Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7860, 7885);
return return_v;
}


System.Management.Automation.SessionState
f_1195_7956_7968()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7956, 7968);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_7956_7977(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7956, 7977);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1195_7996_8016(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 7996, 8016);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1195_8037_8042()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8037, 8042);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1195_8044_8051()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8044, 8051);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1195_8044_8058(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8044, 8058);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1195_7956_8059(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.ScopedItemOptions
options,System.Management.Automation.SwitchParameter
force,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.SetFunction( name, function, originalFunction, options, (bool)force, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 7956, 8059);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1195_8316_8323()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8316, 8323);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1195_8316_8340(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8316, 8340);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1195_8297_8354(System.Management.Automation.ExecutionContext
context,string
script)
{
var return_v = ScriptBlock.Create( context, script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 8297, 8354);
return return_v;
}


System.Management.Automation.SessionState
f_1195_8486_8498()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8486, 8498);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_8486_8507(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8486, 8507);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1195_8545_8570(Microsoft.PowerShell.Commands.FunctionProviderDynamicParameters
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8545, 8570);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1195_8572_8577()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8572, 8577);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1195_8579_8586()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8579, 8586);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1195_8579_8593(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8579, 8593);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1195_8486_8594(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.ScopedItemOptions
options,System.Management.Automation.SwitchParameter
force,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.SetFunction( name, function, originalFunction, options, (bool)force, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 8486, 8594);
return return_v;
}


System.Management.Automation.SessionState
f_1195_8724_8736()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8724, 8736);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_8724_8745(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8724, 8745);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1195_8783_8788()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8783, 8788);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1195_8790_8797()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8790, 8797);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1195_8790_8804(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 8790, 8804);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1195_8724_8805(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.SwitchParameter
force,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.SetFunction( name, function, originalFunction, (bool)force, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 8724, 8805);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1195_8920_8963(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 8920, 8963);
return return_v;
}


string
f_1195_9127_9144(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 9127, 9144);
return return_v;
}


int
f_1195_9097_9152(Microsoft.PowerShell.Commands.FunctionProvider
this_param,System.Management.Automation.CommandInfo
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( (object)item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 9097, 9152);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,5176,9198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,5176,9198);
}
		}

private static void SetOptions(CommandInfo function, ScopedItemOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1195,9240,9398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,9344,9387);

((FunctionInfo)function).Options = options;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1195,9240,9398);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,9240,9398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,9240,9398);
}
		}

internal override void RemoveSessionStateItem(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,9644,9934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,9727,9857);

f_1195_9727_9856(!f_1195_9769_9795(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,9873,9923);

f_1195_9873_9922(f_1195_9873_9894(f_1195_9873_9885()), name, f_1195_9916_9921());
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,9644,9934);

bool
f_1195_9769_9795(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 9769, 9795);
return return_v;
}


int
f_1195_9727_9856(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 9727, 9856);
return 0;
}


System.Management.Automation.SessionState
f_1195_9873_9885()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 9873, 9885);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_9873_9894(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 9873, 9894);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1195_9916_9921()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 9916, 9921);
return return_v;
}


int
f_1195_9873_9922(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.SwitchParameter
force)
{
this_param.RemoveFunction( name, (bool)force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 9873, 9922);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,9644,9934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,9644,9934);
}
		}

internal override object GetValueOfItem(object item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,10477,10918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,10554,10669);

f_1195_10554_10668(item != null, "Caller should verify the item parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,10685,10705);

object 
value = item
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,10721,10766);

FunctionInfo 
function = item as FunctionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,10780,10878) || true) && (function != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,10780,10878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,10834,10863);

value = f_1195_10842_10862(function);
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,10780,10878);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,10894,10907);

return value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,10477,10918);

int
f_1195_10554_10668(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 10554, 10668);
return 0;
}


System.Management.Automation.ScriptBlock
f_1195_10842_10862(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 10842, 10862);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,10477,10918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,10477,10918);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override IDictionary GetSessionStateTable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,11202,11338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,11279,11327);

return f_1195_11286_11326(f_1195_11286_11307(f_1195_11286_11298()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,11202,11338);

System.Management.Automation.SessionState
f_1195_11286_11298()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 11286, 11298);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1195_11286_11307(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 11286, 11307);
return return_v;
}


System.Collections.IDictionary
f_1195_11286_11326(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.GetFunctionTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 11286, 11326);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,11202,11338);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,11202,11338);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool CanRenameItem(object item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,11757,12670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,11831,11851);

bool 
result = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,11867,11916);

FunctionInfo 
functionInfo = item as FunctionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,11930,12629) || true) && (functionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,11930,12629);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,11988,12580) || true) && ((f_1195_11993_12013(functionInfo)& ScopedItemOptions.Constant) != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1195, 11992, 12141)||                    ((f_1195_12075_12095(functionInfo)& ScopedItemOptions.ReadOnly) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1195, 12074, 12140)&&f_1195_12134_12140_M(!Force)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1195,11988,12580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,12183,12529);

SessionStateUnauthorizedAccessException 
e =
f_1195_12252_12528(f_1195_12326_12343(functionInfo), SessionStateCategory.Function, "CannotRenameFunction", f_1195_12487_12527())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,12553,12561);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,11988,12580);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,12600,12614);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1195,11930,12629);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,12645,12659);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,11757,12670);

System.Management.Automation.ScopedItemOptions
f_1195_11993_12013(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 11993, 12013);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1195_12075_12095(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 12075, 12095);
return return_v;
}


bool
f_1195_12134_12140_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 12134, 12140);
return return_v;
}


string
f_1195_12326_12343(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 12326, 12343);
return return_v;
}


string
f_1195_12487_12527()
{
var return_v =                             SessionStateStrings.CannotRenameFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1195, 12487, 12527);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1195_12252_12528(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1195, 12252, 12528);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,11757,12670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,11757,12670);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static FunctionProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1195,577,12717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,1352,1377);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1195,577,12717);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,577,12717);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1195,577,12717);
}
public class FunctionProviderDynamicParameters
{
[Parameter]
        public ScopedItemOptions Options
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,13110,13134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,13116,13132);

return _options;
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,13110,13134);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,13032,13266);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,13032,13266);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,13150,13255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,13186,13205);

_optionsSet = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,13223,13240);

_options = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,13150,13255);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,13032,13266);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,13032,13266);
}
		}}

private ScopedItemOptions _options ;

internal bool OptionsSet
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1195,13533,13560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,13539,13558);

return _optionsSet;
DynAbs.Tracing.TraceSender.TraceExitMethod(1195,13533,13560);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1195,13484,13571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,13484,13571);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _optionsSet;

public FunctionProviderDynamicParameters()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1195,12857,13615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,13304,13337);
this._options = ScopedItemOptions.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1195,13596,13607);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1195,12857,13615);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,12857,13615);
}


static FunctionProviderDynamicParameters()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1195,12857,13615);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1195,12857,13615);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1195,12857,13615);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1195,12857,13615);
}
}

