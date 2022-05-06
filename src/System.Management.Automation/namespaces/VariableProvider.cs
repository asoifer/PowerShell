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
[CmdletProvider(VariableProvider.ProviderName, ProviderCapabilities.ShouldProcess)]
    [OutputType(typeof(PSVariable), ProviderCmdlet = ProviderCmdlet.SetItem)]
    [OutputType(typeof(PSVariable), ProviderCmdlet = ProviderCmdlet.RenameItem)]
    [OutputType(typeof(PSVariable), ProviderCmdlet = ProviderCmdlet.CopyItem)]
    [OutputType(typeof(PSVariable), ProviderCmdlet = ProviderCmdlet.GetItem)]
    [OutputType(typeof(PSVariable), ProviderCmdlet = ProviderCmdlet.NewItem)]
    public sealed class VariableProvider : SessionStateProviderBase
{
public const string 
ProviderName = "Variable"
;

public VariableProvider()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1219,1465,1512);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1219,1465,1512);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,1465,1512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,1465,1512);
}
		}

protected override Collection<PSDriveInfo> InitializeDefaultDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1219,1834,2407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,1927,1993);

string 
description = f_1219_1948_1992()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,2009,2249);

PSDriveInfo 
variableDrive =
f_1219_2054_2248(DriveNames.VariableDrive, f_1219_2139_2151(), string.Empty, description, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,2265,2328);

Collection<PSDriveInfo> 
drives = f_1219_2298_2327()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,2342,2368);

f_1219_2342_2367(            drives, variableDrive);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,2382,2396);

return drives;
DynAbs.Tracing.TraceSender.TraceExitMethod(1219,1834,2407);

string
f_1219_1948_1992()
{
var return_v = SessionStateStrings.VariableDriveDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 1948, 1992);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1219_2139_2151()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 2139, 2151);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1219_2054_2248(string
name,System.Management.Automation.ProviderInfo
provider,string
root,string
description,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.PSDriveInfo( name, provider, root, description, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 2054, 2248);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1219_2298_2327()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 2298, 2327);
return return_v;
}


int
f_1219_2342_2367(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 2342, 2367);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,1834,2407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,1834,2407);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override object GetSessionStateItem(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1219,2813,3127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,2895,3025);

f_1219_2895_3024(!f_1219_2937_2963(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,3041,3116);

return (PSVariable)f_1219_3060_3115(f_1219_3060_3081(f_1219_3060_3072()), name, f_1219_3100_3114(f_1219_3100_3107()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1219,2813,3127);

bool
f_1219_2937_2963(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 2937, 2963);
return return_v;
}


int
f_1219_2895_3024(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 2895, 3024);
return 0;
}


System.Management.Automation.SessionState
f_1219_3060_3072()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 3060, 3072);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1219_3060_3081(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 3060, 3081);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1219_3100_3107()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 3100, 3107);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1219_3100_3114(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 3100, 3114);
return return_v;
}


System.Management.Automation.PSVariable
f_1219_3060_3115(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.GetVariable( name, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 3060, 3115);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,2813,3127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,2813,3127);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override void SetSessionStateItem(string name, object value, bool writeItem)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1219,3607,4993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,3717,3847);

f_1219_3717_3846(!f_1219_3759_3785(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,3863,3890);

PSVariable 
variable = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,3906,4733) || true) && (value != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,3906,4733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,3957,3988);

variable = value as PSVariable;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4006,4614) || true) && (variable == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,4006,4614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4068,4107);

variable = f_1219_4079_4106(name, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,4006,4614);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,4006,4614);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4239,4595) || true) && (!f_1219_4244_4314(name, f_1219_4264_4277(variable), StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,4239,4595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4364,4460);

PSVariable 
newVar = f_1219_4384_4459(name, f_1219_4405_4419(variable), f_1219_4421_4437(variable), f_1219_4439_4458(variable))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4486,4528);

newVar.Description = f_1219_4507_4527(variable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4554,4572);

variable = newVar;
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,4239,4595);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,4006,4614);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,3906,4733);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,3906,4733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4680,4718);

variable = f_1219_4691_4717(name, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,3906,4733);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4749,4848);

PSVariable 
item = f_1219_4767_4833(f_1219_4767_4788(f_1219_4767_4779()), variable, f_1219_4811_4816(), f_1219_4818_4832(f_1219_4818_4825()))as PSVariable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4864,4982) || true) && (writeItem &&(DynAbs.Tracing.TraceSender.Expression_True(1219, 4868, 4893)&&item != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,4864,4982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,4927,4967);

f_1219_4927_4966(this, item, f_1219_4949_4958(item), false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,4864,4982);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1219,3607,4993);

bool
f_1219_3759_3785(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 3759, 3785);
return return_v;
}


int
f_1219_3717_3846(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 3717, 3846);
return 0;
}


System.Management.Automation.PSVariable
f_1219_4079_4106(string
name,object
value)
{
var return_v = new System.Management.Automation.PSVariable( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 4079, 4106);
return return_v;
}


string
f_1219_4264_4277(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4264, 4277);
return return_v;
}


bool
f_1219_4244_4314(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 4244, 4314);
return return_v;
}


object
f_1219_4405_4419(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4405, 4419);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1219_4421_4437(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4421, 4437);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1219_4439_4458(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4439, 4458);
return return_v;
}


System.Management.Automation.PSVariable
f_1219_4384_4459(string
name,object
value,System.Management.Automation.ScopedItemOptions
options,System.Collections.ObjectModel.Collection<System.Attribute>
attributes)
{
var return_v = new System.Management.Automation.PSVariable( name, value, options, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 4384, 4459);
return return_v;
}


string
f_1219_4507_4527(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Description;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4507, 4527);
return return_v;
}


System.Management.Automation.PSVariable
f_1219_4691_4717(string
name,object
value)
{
var return_v = new System.Management.Automation.PSVariable( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 4691, 4717);
return return_v;
}


System.Management.Automation.SessionState
f_1219_4767_4779()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4767, 4779);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1219_4767_4788(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4767, 4788);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1219_4811_4816()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4811, 4816);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1219_4818_4825()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4818, 4825);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1219_4818_4832(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4818, 4832);
return return_v;
}


object
f_1219_4767_4833(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSVariable
variable,System.Management.Automation.SwitchParameter
force,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.SetVariable( variable, (bool)force, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 4767, 4833);
return return_v;
}


string
f_1219_4949_4958(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 4949, 4958);
return return_v;
}


int
f_1219_4927_4966(Microsoft.PowerShell.Commands.VariableProvider
this_param,System.Management.Automation.PSVariable
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( (object)item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 4927, 4966);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,3607,4993);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,3607,4993);
}
		}

internal override void RemoveSessionStateItem(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1219,5239,5529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,5322,5452);

f_1219_5322_5451(!f_1219_5364_5390(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,5468,5518);

f_1219_5468_5517(f_1219_5468_5489(f_1219_5468_5480()), name, f_1219_5511_5516());
DynAbs.Tracing.TraceSender.TraceExitMethod(1219,5239,5529);

bool
f_1219_5364_5390(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 5364, 5390);
return return_v;
}


int
f_1219_5322_5451(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 5322, 5451);
return 0;
}


System.Management.Automation.SessionState
f_1219_5468_5480()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 5468, 5480);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1219_5468_5489(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 5468, 5489);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1219_5511_5516()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 5511, 5516);
return return_v;
}


int
f_1219_5468_5517(System.Management.Automation.SessionStateInternal
this_param,string
name,System.Management.Automation.SwitchParameter
force)
{
this_param.RemoveVariable( name, (bool)force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 5468, 5517);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,5239,5529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,5239,5529);
}
		}

internal override IDictionary GetSessionStateTable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1219,5813,5962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,5890,5951);

return (IDictionary)f_1219_5910_5950(f_1219_5910_5931(f_1219_5910_5922()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1219,5813,5962);

System.Management.Automation.SessionState
f_1219_5910_5922()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 5910, 5922);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1219_5910_5931(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 5910, 5931);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
f_1219_5910_5950(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.GetVariableTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 5910, 5950);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,5813,5962);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,5813,5962);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override object GetValueOfItem(object item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1219,6337,6871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,6414,6529);

f_1219_6414_6528(item != null, "Caller should verify the item parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,6642,6683);

object 
value = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetValueOfItem(item),1219,6657,6682)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,6699,6735);

PSVariable 
var = item as PSVariable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,6749,6831) || true) && (var != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,6749,6831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,6798,6816);

value = f_1219_6806_6815(var);
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,6749,6831);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,6847,6860);

return value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1219,6337,6871);

int
f_1219_6414_6528(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 6414, 6528);
return 0;
}


object
f_1219_6806_6815(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 6806, 6815);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,6337,6871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,6337,6871);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool CanRenameItem(object item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1219,7290,8179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,7364,7384);

bool 
result = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,7400,7441);

PSVariable 
variable = item as PSVariable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,7455,8138) || true) && (variable != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,7455,8138);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,7509,8089) || true) && ((f_1219_7514_7530(variable)& ScopedItemOptions.Constant) != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1219, 7513, 7654)||                    ((f_1219_7592_7608(variable)& ScopedItemOptions.ReadOnly) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1219, 7591, 7653)&&f_1219_7647_7653_M(!Force)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1219,7509,8089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,7696,8038);

SessionStateUnauthorizedAccessException 
e =
f_1219_7765_8037(f_1219_7839_7852(variable), SessionStateCategory.Variable, "CannotRenameVariable", f_1219_7996_8036())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,8062,8070);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,7509,8089);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,8109,8123);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1219,7455,8138);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,8154,8168);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1219,7290,8179);

System.Management.Automation.ScopedItemOptions
f_1219_7514_7530(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 7514, 7530);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1219_7592_7608(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 7592, 7608);
return return_v;
}


bool
f_1219_7647_7653_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 7647, 7653);
return return_v;
}


string
f_1219_7839_7852(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 7839, 7852);
return return_v;
}


string
f_1219_7996_8036()
{
var return_v =                             SessionStateStrings.CannotRenameVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1219, 7996, 8036);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1219_7765_8037(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1219, 7765, 8037);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1219,7290,8179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,7290,8179);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static VariableProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1219,565,8226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1219,1244,1269);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1219,565,8226);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1219,565,8226);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1219,565,8226);
}
}

